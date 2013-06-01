using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Fly_nmea
{
    public delegate void EventsDelegate();

    public class SensorEventArgs : EventArgs
    {
        public SensorEventArgs(double AccX, double AccY, double AccZ, double OrX, double OrY, double OrZ)
        {
            this.AccX = AccX;
            this.AccY = AccY;
            this.AccZ = AccZ;

            this.OrX = OrX;
            this.OrY = OrY;
            this.OrZ = OrZ;
        }

        public double AccX;
        public double AccY;
        public double AccZ;

        public double OrX;
        public double OrY;
        public double OrZ;
    }

    internal sealed class UDPMulticastListener
    {
        private int port;
        private string address;
        private Thread thread;
        private bool isTerminated;
        private UdpClient client;
        SensorEventArgs SensorArgs = new SensorEventArgs(0, 0, 0, 0, 0, 0);
        public delegate void SensorEventHandler(object sender, SensorEventArgs fe);
        public event SensorEventHandler SensorEvent;

        public UDPMulticastListener(int port, string address)
        {
            this.port = port;
            this.address = address;
        }

        public void Start()
        {
            isTerminated = false;
            thread = new Thread(threadProc);
            thread.IsBackground = true;
            thread.Start();
        }
        public void Stop()
        {
            isTerminated = true;
        }

        private void threadProc()
        {
            IPAddress addr = IPAddress.Parse(address);
            IPEndPoint ep = new IPEndPoint(addr, port);
            client = new UdpClient(port);
            while (!isTerminated)
            {
                byte[] data = client.Receive(ref ep);
                string s = Encoding.UTF8.GetString(data);
                SensorDataUpdate(s);
            }
            try
            {
                client.DropMulticastGroup(addr);
            }
            catch (Exception) { }
            client.Close();
        }
        public void SensorDataUpdate(string UDPstring)
        {
            String[] spliter;
            spliter = UDPstring.Split('\t');
            if (spliter[0] == "Angle:")
            {
                SensorArgs.OrX = System.Convert.ToDouble(spliter[1].Replace('.', ','));
                SensorArgs.OrY = System.Convert.ToDouble(spliter[2].Replace('.', ','));
                SensorArgs.OrZ = System.Convert.ToDouble(spliter[3].Replace('.', ','));
                SensorEvent(this, SensorArgs);
            }
            
        }
    }
}
