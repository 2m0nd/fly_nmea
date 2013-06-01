using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GeoUtility.GeoSystem;
using System.IO.Ports;
namespace Fly_nmea
{

    public partial class Form1 : Form
    {
        public class IPoint
        {
            public double X;
            public double Y;
            public IPoint(UTM uin)
            {
                this.X = uin.East;
                this.Y = uin.North;
            }
        }
        #region Переменные
        delegate void SetTextCallbackDouble(Label textlabel, double var);
        delegate void SetValueCallbackDouble(TrackBar track, double var);
        bool connection=false;
        System.IO.Ports.SerialPort port;
        public double Kren = 0;
        public double Tangazh = 0;
        public double Speed = 50;
        public double Course = 0;
        public double H=0;
        public double Deg2Rad = Math.PI/180;
        public double Rad2Deg = 180/Math.PI;
        Geographic StartPosition;
        private static UDPMulticastListener listener;

        Geographic geo;
        UTM utm, uFrom, uTo;

        #endregion

        public Form1()
        {
            InitializeComponent();
           // trackBar_speed.Value = 180;
            LoadConfig();
        }

        #region События интерфейса
        private void button1_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = 0;
            trackBar_tangazh.Value = 0;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = 0;
        }
        private void label3_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = -5;
        }
        private void label5_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = 5;
        }
        private void label6_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = 10;
        }
        private void label17_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = 15;
        }
        private void label10_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = 20;
        }
        private void label8_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = 30;
        }
        private void label4_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = -10;
        }
        private void label18_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = -15;
        }
        private void label9_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = -20;
        }
        private void label7_Click(object sender, EventArgs e)
        {
            trackBar_kren.Value = -30;
        }
        private void label16_Click(object sender, EventArgs e)
        {
            trackBar_tangazh.Value = 15;
        }
        private void label13_Click(object sender, EventArgs e)
        {
            trackBar_tangazh.Value = 10;
        }
        private void label15_Click(object sender, EventArgs e)
        {
            trackBar_tangazh.Value = 5;
        }
        private void label2_Click(object sender, EventArgs e)
        {
            trackBar_tangazh.Value = 0;
        }
        private void label11_Click(object sender, EventArgs e)
        {
            trackBar_tangazh.Value = -5;
        }
        private void label12_Click(object sender, EventArgs e)
        {
            trackBar_tangazh.Value = -10;
        }
        private void label14_Click(object sender, EventArgs e)
        {
            trackBar_tangazh.Value = -15;
        }
        private void trackBar_kren_ValueChanged(object sender, EventArgs e)
        {
            label_kren.Text = trackBar_kren.Value.ToString();
            Kren = trackBar_kren.Value;
        }
        private void trackBar_tangazh_ValueChanged(object sender, EventArgs e)
        {
            label_tangazh.Text = trackBar_tangazh.Value.ToString();
            Tangazh = trackBar_tangazh.Value;
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label_speed.Text = trackBar_speed.Value.ToString();
            Speed = trackBar_speed.Value*1000/3600;
        }
        private void label35_Click(object sender, EventArgs e)
        {
            trackBar_speed.Value = 320;
        }
        private void label30_Click(object sender, EventArgs e)
        {
            trackBar_speed.Value = 230;
        }
        private void label27_Click(object sender, EventArgs e)
        {
            trackBar_speed.Value = 180;
        }
        private void label29_Click(object sender, EventArgs e)
        {
            trackBar_speed.Value = 130;
        }
        private void label31_Click(object sender, EventArgs e)
        {
            trackBar_speed.Value = 90;
        }
        private void label32_Click(object sender, EventArgs e)
        {
            trackBar_speed.Value = 40;
        }
        private void label34_Click(object sender, EventArgs e)
        {
            trackBar_speed.Value = 0;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Space)
                {
                    trackBar_kren.Value = 0;
                    trackBar_tangazh.Value = 0;
                }
                if (e.KeyCode == Keys.Up)
                {
                    trackBar_speed.Value += 5;
                }
                if (e.KeyCode == Keys.Down)
                {
                    trackBar_speed.Value -= 5;
                }
                if (e.KeyCode == Keys.Left)
                {
                    if (trackBar_kren.Value > 0)
                        trackBar_kren.Value = 0;
                    else
                        trackBar_kren.Value -= 3;
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (trackBar_kren.Value < 0)
                        trackBar_kren.Value = 0;
                    else
                        trackBar_kren.Value += 3;
                }
                if (e.KeyCode == Keys.PageUp)
                {
                    trackBar_tangazh.Value += 3;
                }
                if (e.KeyCode == Keys.PageDown)
                {
                    trackBar_tangazh.Value -= 3;
                }
            }
            catch (Exception) { }
            e.Handled = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (connection == false)
            {
                connection = true;

                button2.Text = "Stop";
                text_com.Enabled = false;
                text_h.Enabled = false;
                text_lat_grad.Enabled = false;
                text_lat_min.Enabled = false;
                text_lat_sec.Enabled = false;
                text_lon_grad.Enabled = false;
                text_lon_min.Enabled = false;
                text_lon_sec.Enabled = false;

				port = new SerialPort("COM" + Int32.Parse(text_com.Text), Convert.ToInt32("38400"), Parity.None, 8, StopBits.One);//new System.IO.Ports.SerialPort("COM" + text_com.Text, 38400, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
                port.Open();
                GetStartPosition();
                SetGeo(StartPosition);
                utm = (UTM)geo;
                timer1.Start();

            }
            else
            {
                connection = false;

                button2.Text = "Start";
                timer1.Stop();
                port.Close();

                text_com.Enabled = true;
                text_h.Enabled = true;
                text_lat_grad.Enabled = true;
                text_lat_min.Enabled = true;
                text_lat_sec.Enabled = true;
                text_lon_grad.Enabled = true;
                text_lon_min.Enabled = true;
                text_lon_sec.Enabled = true;
                SaveConfig();
            }            
        }
        #endregion

        #region Методы
        public void GetStartPosition()
        {
            StartPosition = new Geographic(System.Convert.ToDouble(text_lon_grad.Text) + System.Convert.ToDouble(text_lon_min.Text)/60+System.Convert.ToDouble(text_lon_sec.Text)/3600,
                System.Convert.ToDouble(text_lat_grad.Text) + System.Convert.ToDouble(text_lat_min.Text) / 60 + System.Convert.ToDouble(text_lat_sec.Text)/3600);
            H = System.Convert.ToDouble(text_h.Text);
        }
        public void SetGeo(Geographic g)
        {
            geo = new Geographic(g.Longitude, g.Latitude);
        }

        //Эмуляция движения по таймеру
        public void CalcPosition()
        {
            if (Kren == 0)
            {
                utm.North += timer1.Interval / 1000.0 * Speed * Math.Cos(Deg2Rad * Course) * Math.Cos(Deg2Rad * Tangazh);
                utm.East += timer1.Interval / 1000.0 * Speed * Math.Sin(Deg2Rad * Course) * Math.Cos(Deg2Rad * Tangazh);
                H += timer1.Interval / 1000.0 * Speed * Math.Sin(Deg2Rad * Tangazh);
            }
            else
            {
                Course += CalcDalpha(); if (Course > 360) Course -= 360; else if (Course < 0) Course += 360;
                utm.North += timer1.Interval / 1000.0 * Speed * Math.Cos(Deg2Rad * Course) * Math.Cos(Deg2Rad * Tangazh);
                utm.East += timer1.Interval / 1000.0 * Speed * Math.Sin(Deg2Rad * Course) * Math.Cos(Deg2Rad * Tangazh);
                H += timer1.Interval / 1000.0 * Speed * Math.Sin(Deg2Rad * Tangazh);
            }
        }
        //Расчет изменения курса при заданом крене и скорости
        public double CalcDalpha()
        {

            double R = Speed * Speed / (Math.Tan(Deg2Rad * Kren) * 20);
            double ds = Speed * timer1.Interval/1000;
            double dbetta = Rad2Deg * Math.Acos(ds / (2 * R));
            return 90 - dbetta;
        }
        //вычисление курса по двум точкам трека
        public double CalcGPScourse()
        {
            double GPScourse = 0;
            uTo = new UTM(utm.Zone, utm.Band, utm.East, utm.North);
            try
            {
               GPScourse = GetAzimut2point(new IPoint(uFrom), new IPoint(uTo));
            }
            catch (Exception) { GPScourse = -100; }
            uFrom = new UTM(utm.Zone, utm.Band, utm.East, utm.North);
            return GPScourse;
        }
        public double GetAzimut2point(IPoint p2, IPoint p1)
        {
            double dx = p1.X - p2.X;
            double dy = p1.Y - p2.Y;
            double Angle = -1000;
            if (dx > 0 && dy > 0)
            {
                Angle = 180 / Math.PI * Math.Atan(dx / dy); if (Angle < 0) Angle = Angle + 360;
            }
            else if (dx > 0 && dy < 0)
            {
                Angle = 90 + 180 / Math.PI * Math.Atan(Math.Abs(dy / dx)); if (Angle < 0) Angle = Angle + 360;
            }
            else if (dx < 0 && dy < 0)
            {
                Angle = 180 + 180 / Math.PI * Math.Atan(Math.Abs(dx / dy)); if (Angle < 0) Angle = Angle + 360;
            }
            else if (dx < 0 && dy > 0)
            {
                Angle = 270 + 180 / Math.PI * Math.Atan(Math.Abs(dy / dx)); if (Angle < 0) Angle = Angle + 360;
            }
            return Angle;
        }

        //Значение для строк NMEA
        public string GetStrLat()
        {
            int g = (int)geo.Latitude;
            double m = Math.Round((geo.Latitude - g) * 60, 6);
            return g.ToString()+m.ToString("00.0000").Replace(',','.')+",N,";
        }
        public string GetStrLon()
        {
            int g = (int)geo.Longitude;
            double m = Math.Round((geo.Longitude - g) * 60, 6);
            if(g<100)
                return "0" + g.ToString() + m.ToString("00.0000").Replace(',', '.') + ",E,";
            else
                return g.ToString() + m.ToString("00.0000").Replace(',', '.') + ",E,";
        }
        public string GetStrTime()
        {
            return System.DateTime.Now.Hour.ToString("00") + System.DateTime.Now.Minute.ToString("00") +
                System.DateTime.Now.Second.ToString("00") + "." + System.DateTime.Now.Millisecond.ToString() + ',' +
                "A,";
        }
        public string GetStrSpeedKnot()
        {
            return (Speed * 3600 / 1000 / 1.85200).ToString("0.0").Replace(',', '.') + ',';
        }
        public string GetStrCourse()
        {
            /*
            double CourseReal = Course + Gamma(); if(CourseReal<0) CourseReal +=360; else if(CourseReal>360) CourseReal -= 360;
            return CourseReal.ToString("0.0").Replace(',', '.') + ',';
             * */
            double CourseReal = CalcGPScourse() - Gamma(); if (CourseReal < 0) CourseReal += 360; else if (CourseReal > 360) CourseReal -= 360;
            return CourseReal.ToString("0.0").Replace(',', '.') + ',';

        }
        public string GetStrDate_mag_Auto()
        {
            return "121212,003.3,E";
        }
        public double Gamma()
        {
            double Lc = 6*((int)(geo.Longitude/6)+1)-3;
            double tmp = (geo.Longitude - Lc) * Math.Sin(Deg2Rad * geo.Latitude);
            return (Lc-geo.Longitude)*Math.Sin(Deg2Rad*geo.Latitude);
        }


        //Сообщения NMEA
        public string GenRMC()
        {
            string str = "$GPRMC," + GetStrTime() + GetStrLat() + GetStrLon() + GetStrSpeedKnot() + GetStrCourse() + GetStrDate_mag_Auto()+"*";
            return str + getChecksum(str);
        }
        public string GenGLL()
        {
            string str = "$GPGLL," + GetStrLat() + GetStrLon() + GetStrTime() + "*";
            return str + getChecksum(str);
        }
        public string GenGGA()
        {
            string str = "$GPGGA," + System.DateTime.Now.Hour.ToString() + System.DateTime.Now.Minute.ToString() +
                System.DateTime.Now.Second.ToString() + ".00," + GetStrLat() + GetStrLon() + "1,16,2.1," + ((double)H).ToString().Replace(',', '.') + ",M,214.9,M," + "0.32,0" + "*";
            return str + getChecksum(str);
        }
        public string GenGSA()
        {
            string str = "$GPGSA,A,3,32,23,19,08,25,03,,,,,,,2,2.1,0,92,1,8*"; 
               return str + getChecksum(str);
        }
        private static string getChecksum(string sentence)
        {
            int checksum = Convert.ToByte(sentence[sentence.IndexOf('$') + 1]);
            for (int i = sentence.IndexOf('$') + 2; i < sentence.IndexOf('*'); i++)
            {
                checksum ^= Convert.ToByte(sentence[i]);
            }
            return checksum.ToString("X2")+"\r\n";
        }  
        //файл конфигураций
        public void SaveConfig()
        {
            try
            {
                System.IO.StreamWriter cfgfileo = new System.IO.StreamWriter("config");

                cfgfileo.WriteLine(geo.Latitude.ToString());
                cfgfileo.WriteLine(geo.Longitude.ToString());
                cfgfileo.WriteLine(H.ToString());
                cfgfileo.WriteLine(text_com.Text);
                cfgfileo.WriteLine(Course.ToString());

                cfgfileo.Close();
            }
            catch (Exception) { MessageBox.Show("Ошибка сохранения файла конфигураций"); }
        }
        public void LoadConfig()
        {
            try
            {
                System.IO.StreamReader cfgfile = new System.IO.StreamReader("config", Encoding.Default);

                string tmp;
                //читаем и утсанавливаем широту
                tmp = cfgfile.ReadLine();
                double[] D1 = GetAngle3(System.Convert.ToDouble(tmp));
                text_lat_grad.Text = ((int)D1[0]).ToString();
                text_lat_min.Text = ((int)D1[1]).ToString();
                text_lat_sec.Text = D1[2].ToString();
                //читаем и утсанавливаем долготу
                tmp = cfgfile.ReadLine();
                double[] D2 = GetAngle3(System.Convert.ToDouble(tmp));
                text_lon_grad.Text = ((int)D2[0]).ToString();
                text_lon_min.Text = ((int)D2[1]).ToString();
                text_lon_sec.Text = D2[2].ToString();
                //читаем и утсанавливаем высоту
                text_h.Text = cfgfile.ReadLine();
                //читаем и утсанавливаем COM порт
                text_com.Text = cfgfile.ReadLine();
                //курс
                Course = System.Convert.ToDouble(cfgfile.ReadLine());
                cfgfile.Close();
            }
            catch (Exception) { MessageBox.Show("Ошибка загрузки файла конфигураций"); }
        }
        public double[] GetAngle3(double D)
        {
            double[] tmp = new double[3];
            tmp[0] = (int)D;
            tmp[1] = (int)((D - tmp[0]) * 60);
            tmp[2] = (D - tmp[0] - tmp[1] / 60.0) * 3600;
            return tmp;
        }
        //сенсор листенер
        public void RegListenerSens()
        {
            listener = new UDPMulticastListener(12345, "192.168.1.1");
            listener.Start();
            listener.SensorEvent += new UDPMulticastListener.SensorEventHandler(listener_SensorEvent);
        }
        public void UnRegListenerSens()
        {
            listener.Stop();
            listener.SensorEvent -= new UDPMulticastListener.SensorEventHandler(listener_SensorEvent);
        }
        #endregion



        private void timer1_Tick(object sender, EventArgs e)
        {
            SetD2Tvalue(trackBar_kren, Kren);
            SetD2Tvalue(trackBar_tangazh, Tangazh);
            CalcPosition();
            geo = (Geographic)utm;
            utm = (UTM)geo;


            port.Write(GenRMC());
            port.Write(GenGLL());
            port.Write(GenGGA());
            port.Write(GenGSA());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // SaveConfig();
        }

        private void checkBox_AndroidSensor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AndroidSensor.Checked == false)
            {
                checkBox_AndroidSensor.Text = "Включить управление через Android Sensor";
                UnRegListenerSens();
            }
            if (checkBox_AndroidSensor.Checked == true)
            {
                checkBox_AndroidSensor.Text = "Включить управление через WinForms";
                RegListenerSens();
            }
        }
        void listener_SensorEvent(object sender, SensorEventArgs e)
        {
            Kren = e.OrY / 2;
            if (Kren > 80) Kren = 79;
            else if (Kren < -80) Kren = -79;
            Tangazh = e.OrZ / 4;
        }
        public void SetD2L(Label textlabel, double var)
        {
            if (textlabel.InvokeRequired)
            {
                SetTextCallbackDouble d = new SetTextCallbackDouble(SetD2L);
                textlabel.Invoke(d, new object[] { textlabel, var });
            }
            else
            {
                textlabel.Text = var.ToString("00");
            }
        }
        public void SetD2Tvalue(TrackBar track, double var)
        {
            if (track.InvokeRequired)
            {
                SetValueCallbackDouble d = new SetValueCallbackDouble(SetD2Tvalue);
                track.Invoke(d, new object[] { track, var });
            }
            else
            {
                try
                {
                    track.Value = (int)var;
                }
                catch (Exception) 
                { 
                    if (var > 0) track.Value = track.Maximum;
                    if (var < 0) track.Value = track.Minimum;
                }
            }
        }
        
    }
}
