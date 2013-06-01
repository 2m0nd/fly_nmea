namespace Fly_nmea
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBar_kren = new System.Windows.Forms.TrackBar();
            this.trackBar_tangazh = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label_kren = new System.Windows.Forms.Label();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_tangazh = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_h = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.text_com = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.text_lon_sec = new System.Windows.Forms.TextBox();
            this.text_lon_min = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.text_lon_grad = new System.Windows.Forms.TextBox();
            this.text_lat_grad = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.text_lat_min = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.text_lat_sec = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.trackBar_speed = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.checkBox_AndroidSensor = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_kren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tangazh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_kren
            // 
            this.trackBar_kren.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trackBar_kren.Location = new System.Drawing.Point(-2, 261);
            this.trackBar_kren.Maximum = 30;
            this.trackBar_kren.Minimum = -30;
            this.trackBar_kren.Name = "trackBar_kren";
            this.trackBar_kren.Size = new System.Drawing.Size(261, 45);
            this.trackBar_kren.TabIndex = 0;
            this.trackBar_kren.ValueChanged += new System.EventHandler(this.trackBar_kren_ValueChanged);
            // 
            // trackBar_tangazh
            // 
            this.trackBar_tangazh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.trackBar_tangazh.Location = new System.Drawing.Point(0, -2);
            this.trackBar_tangazh.Maximum = 15;
            this.trackBar_tangazh.Minimum = -15;
            this.trackBar_tangazh.Name = "trackBar_tangazh";
            this.trackBar_tangazh.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_tangazh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBar_tangazh.RightToLeftLayout = true;
            this.trackBar_tangazh.Size = new System.Drawing.Size(45, 237);
            this.trackBar_tangazh.TabIndex = 1;
            this.trackBar_tangazh.ValueChanged += new System.EventHandler(this.trackBar_tangazh_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(120, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0 -";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(102, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "-5";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(79, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "-10";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(143, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(158, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "10";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(1, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "-30";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(237, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "30";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label9.Location = new System.Drawing.Point(37, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "-20";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(198, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "20";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(2, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "-5";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label12.Location = new System.Drawing.Point(-2, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "-10";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label13.Location = new System.Drawing.Point(0, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "10";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(-1, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "-15";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label15.Location = new System.Drawing.Point(4, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "5";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label16.Location = new System.Drawing.Point(1, 4);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "15";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label17.Location = new System.Drawing.Point(178, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(19, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "15";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label18.Location = new System.Drawing.Point(58, 289);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 13);
            this.label18.TabIndex = 20;
            this.label18.Text = "-15";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(51, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 234);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label_kren);
            this.groupBox3.Controls.Add(this.label_speed);
            this.groupBox3.Controls.Add(this.label_tangazh);
            this.groupBox3.Controls.Add(this.label19);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(3, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(143, 89);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Переменные";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label25.Location = new System.Drawing.Point(7, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(70, 24);
            this.label25.TabIndex = 6;
            this.label25.Text = "Ск-ть:";
            // 
            // label_kren
            // 
            this.label_kren.AutoSize = true;
            this.label_kren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_kren.ForeColor = System.Drawing.Color.Green;
            this.label_kren.Location = new System.Drawing.Point(93, 36);
            this.label_kren.Name = "label_kren";
            this.label_kren.Size = new System.Drawing.Size(32, 24);
            this.label_kren.TabIndex = 0;
            this.label_kren.Text = "00";
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label_speed.Location = new System.Drawing.Point(94, 63);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(43, 24);
            this.label_speed.TabIndex = 5;
            this.label_speed.Text = "000";
            // 
            // label_tangazh
            // 
            this.label_tangazh.AutoSize = true;
            this.label_tangazh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tangazh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_tangazh.Location = new System.Drawing.Point(93, 13);
            this.label_tangazh.Name = "label_tangazh";
            this.label_tangazh.Size = new System.Drawing.Size(32, 24);
            this.label_tangazh.TabIndex = 1;
            this.label_tangazh.Text = "00";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(8, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 24);
            this.label19.TabIndex = 2;
            this.label19.Text = "Крен:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(6, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 24);
            this.label20.TabIndex = 3;
            this.label20.Text = "Тангаж:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.text_h);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.text_com);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.text_lon_sec);
            this.groupBox2.Controls.Add(this.text_lon_min);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.text_lon_grad);
            this.groupBox2.Controls.Add(this.text_lat_grad);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.text_lat_min);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.text_lat_sec);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(6, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 134);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Данные инициализаци";
            // 
            // text_h
            // 
            this.text_h.Location = new System.Drawing.Point(63, 83);
            this.text_h.Name = "text_h";
            this.text_h.Size = new System.Drawing.Size(66, 20);
            this.text_h.TabIndex = 19;
            this.text_h.Text = "1990";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(4, 86);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(45, 13);
            this.label33.TabIndex = 18;
            this.label33.Text = "Высота";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 20);
            this.button2.TabIndex = 17;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_com
            // 
            this.text_com.Location = new System.Drawing.Point(42, 108);
            this.text_com.Name = "text_com";
            this.text_com.Size = new System.Drawing.Size(19, 20);
            this.text_com.TabIndex = 16;
            this.text_com.Text = "6";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 112);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(31, 13);
            this.label26.TabIndex = 15;
            this.label26.Text = "COM";
            // 
            // text_lon_sec
            // 
            this.text_lon_sec.Location = new System.Drawing.Point(98, 61);
            this.text_lon_sec.Name = "text_lon_sec";
            this.text_lon_sec.Size = new System.Drawing.Size(31, 20);
            this.text_lon_sec.TabIndex = 14;
            this.text_lon_sec.Text = "48";
            // 
            // text_lon_min
            // 
            this.text_lon_min.Location = new System.Drawing.Point(63, 61);
            this.text_lon_min.Name = "text_lon_min";
            this.text_lon_min.Size = new System.Drawing.Size(29, 20);
            this.text_lon_min.TabIndex = 13;
            this.text_lon_min.Text = "44";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 13);
            this.label21.TabIndex = 5;
            this.label21.Text = "Lat";
            // 
            // text_lon_grad
            // 
            this.text_lon_grad.Location = new System.Drawing.Point(32, 61);
            this.text_lon_grad.Name = "text_lon_grad";
            this.text_lon_grad.Size = new System.Drawing.Size(28, 20);
            this.text_lon_grad.TabIndex = 12;
            this.text_lon_grad.Text = "061";
            // 
            // text_lat_grad
            // 
            this.text_lat_grad.Location = new System.Drawing.Point(32, 35);
            this.text_lat_grad.Name = "text_lat_grad";
            this.text_lat_grad.Size = new System.Drawing.Size(28, 20);
            this.text_lat_grad.TabIndex = 6;
            this.text_lat_grad.Text = "57";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(4, 64);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(25, 13);
            this.label28.TabIndex = 11;
            this.label28.Text = "Lon";
            // 
            // text_lat_min
            // 
            this.text_lat_min.Location = new System.Drawing.Point(63, 35);
            this.text_lat_min.Name = "text_lat_min";
            this.text_lat_min.Size = new System.Drawing.Size(29, 20);
            this.text_lat_min.TabIndex = 7;
            this.text_lat_min.Text = "59";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(118, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(11, 13);
            this.label24.TabIndex = 10;
            this.label24.Text = "\'\'";
            // 
            // text_lat_sec
            // 
            this.text_lat_sec.Location = new System.Drawing.Point(98, 35);
            this.text_lat_sec.Name = "text_lat_sec";
            this.text_lat_sec.Size = new System.Drawing.Size(31, 20);
            this.text_lat_sec.TabIndex = 8;
            this.text_lat_sec.Text = "39";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(39, 19);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(13, 13);
            this.label23.TabIndex = 9;
            this.label23.Text = "o";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(72, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(9, 13);
            this.label22.TabIndex = 9;
            this.label22.Text = "\'";
            // 
            // trackBar_speed
            // 
            this.trackBar_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.trackBar_speed.Location = new System.Drawing.Point(214, -6);
            this.trackBar_speed.Maximum = 320;
            this.trackBar_speed.Name = "trackBar_speed";
            this.trackBar_speed.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_speed.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar_speed.RightToLeftLayout = true;
            this.trackBar_speed.Size = new System.Drawing.Size(45, 243);
            this.trackBar_speed.TabIndex = 22;
            this.trackBar_speed.Value = 180;
            this.trackBar_speed.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(233, 95);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(23, 12);
            this.label27.TabIndex = 24;
            this.label27.Text = "180";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(235, 128);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(20, 12);
            this.label29.TabIndex = 25;
            this.label29.Text = "130";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(236, 61);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(20, 12);
            this.label30.TabIndex = 24;
            this.label30.Text = "230";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(238, 154);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(15, 12);
            this.label31.TabIndex = 24;
            this.label31.Text = "90";
            this.label31.Click += new System.EventHandler(this.label31_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(238, 189);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(15, 12);
            this.label32.TabIndex = 24;
            this.label32.Text = "40";
            this.label32.Click += new System.EventHandler(this.label32_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(239, 220);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(11, 12);
            this.label34.TabIndex = 26;
            this.label34.Text = "0";
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(236, 2);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(20, 12);
            this.label35.TabIndex = 27;
            this.label35.Text = "320";
            this.label35.Click += new System.EventHandler(this.label35_Click);
            // 
            // checkBox_AndroidSensor
            // 
            this.checkBox_AndroidSensor.AutoSize = true;
            this.checkBox_AndroidSensor.Location = new System.Drawing.Point(9, 240);
            this.checkBox_AndroidSensor.Name = "checkBox_AndroidSensor";
            this.checkBox_AndroidSensor.Size = new System.Drawing.Size(244, 17);
            this.checkBox_AndroidSensor.TabIndex = 28;
            this.checkBox_AndroidSensor.Text = "Включить управление через Android Sensor";
            this.checkBox_AndroidSensor.UseVisualStyleBackColor = true;
            this.checkBox_AndroidSensor.CheckedChanged += new System.EventHandler(this.checkBox_AndroidSensor_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(259, 306);
            this.Controls.Add(this.checkBox_AndroidSensor);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.trackBar_speed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar_tangazh);
            this.Controls.Add(this.trackBar_kren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Fly_NMEA";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_kren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tangazh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_kren;
        private System.Windows.Forms.TrackBar trackBar_tangazh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_kren;
        private System.Windows.Forms.Label label_tangazh;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox text_lat_sec;
        private System.Windows.Forms.TextBox text_lat_min;
        private System.Windows.Forms.TextBox text_lat_grad;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_lon_sec;
        private System.Windows.Forms.TextBox text_lon_min;
        private System.Windows.Forms.TextBox text_lon_grad;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.TrackBar trackBar_speed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_com;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox text_h;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox checkBox_AndroidSensor;
    }
}

