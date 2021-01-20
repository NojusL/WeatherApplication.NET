namespace NET_projektas
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
            this.txtCityCountry = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.feelslikelabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.windspeed = new System.Windows.Forms.Label();
            this.percipitation = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.uvrating = new System.Windows.Forms.Label();
            this.fellslike = new System.Windows.Forms.Label();
            this.temperature = new System.Windows.Forms.Label();
            this.forecastminamxtemp = new System.Windows.Forms.Label();
            this.forecastdaypicture = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sunrise = new System.Windows.Forms.Label();
            this.sunset = new System.Windows.Forms.Label();
            this.moonrise = new System.Windows.Forms.Label();
            this.moonset = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCurrentTemp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dayboxFirst = new System.Windows.Forms.Button();
            this.pictureBoxFirst = new System.Windows.Forms.PictureBox();
            this.Temp1 = new System.Windows.Forms.Label();
            this.dayboxSecond = new System.Windows.Forms.Button();
            this.pictureBoxSecond = new System.Windows.Forms.PictureBox();
            this.Temp2 = new System.Windows.Forms.Label();
            this.dayboxThird = new System.Windows.Forms.Button();
            this.pictureBoxThird = new System.Windows.Forms.PictureBox();
            this.Temp3 = new System.Windows.Forms.Label();
            this.panelhourly = new System.Windows.Forms.Panel();
            this.tempreturebutton = new System.Windows.Forms.Button();
            this.percipitationbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forecastdaypicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThird)).BeginInit();
            this.panelhourly.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCityCountry
            // 
            this.txtCityCountry.AutoSize = true;
            this.txtCityCountry.BackColor = System.Drawing.Color.Transparent;
            this.txtCityCountry.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCityCountry.Location = new System.Drawing.Point(689, 47);
            this.txtCityCountry.Name = "txtCityCountry";
            this.txtCityCountry.Size = new System.Drawing.Size(150, 19);
            this.txtCityCountry.TabIndex = 52;
            this.txtCityCountry.Text = "Vilnius, Lithuania";
            this.txtCityCountry.Click += new System.EventHandler(this.txtCityCountry_Click);
            // 
            // txtCity
            // 
            this.txtCity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCity.Location = new System.Drawing.Point(556, 282);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(237, 20);
            this.txtCity.TabIndex = 43;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            // 
            // feelslikelabel
            // 
            this.feelslikelabel.AutoSize = true;
            this.feelslikelabel.BackColor = System.Drawing.Color.Transparent;
            this.feelslikelabel.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelslikelabel.Location = new System.Drawing.Point(24, 283);
            this.feelslikelabel.Name = "feelslikelabel";
            this.feelslikelabel.Size = new System.Drawing.Size(92, 19);
            this.feelslikelabel.TabIndex = 42;
            this.feelslikelabel.Text = "Feels like:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "UV rating:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 40;
            this.label5.Text = "Humidity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 19);
            this.label4.TabIndex = 39;
            this.label4.Text = "Percipitation (mm):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Wind Speed (km/h):";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::NET_projektas.Properties.Resources.location_logo_map_location_icon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(807, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 29);
            this.label8.TabIndex = 56;
            this.label8.Text = "Weather Application";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(215)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(693, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 30);
            this.button2.TabIndex = 57;
            this.button2.Text = "SET LOCATION";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::NET_projektas.Properties.Resources.blue_blur;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panelhourly);
            this.panel1.Controls.Add(this.percipitationbutton);
            this.panel1.Controls.Add(this.tempreturebutton);
            this.panel1.Location = new System.Drawing.Point(-2, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 140);
            this.panel1.TabIndex = 58;
            this.panel1.Tag = "";
            // 
            // windspeed
            // 
            this.windspeed.AutoSize = true;
            this.windspeed.BackColor = System.Drawing.Color.Transparent;
            this.windspeed.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windspeed.Location = new System.Drawing.Point(221, 127);
            this.windspeed.Name = "windspeed";
            this.windspeed.Size = new System.Drawing.Size(0, 19);
            this.windspeed.TabIndex = 59;
            // 
            // percipitation
            // 
            this.percipitation.AutoSize = true;
            this.percipitation.BackColor = System.Drawing.Color.Transparent;
            this.percipitation.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percipitation.Location = new System.Drawing.Point(221, 166);
            this.percipitation.Name = "percipitation";
            this.percipitation.Size = new System.Drawing.Size(0, 19);
            this.percipitation.TabIndex = 60;
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.BackColor = System.Drawing.Color.Transparent;
            this.humidity.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidity.Location = new System.Drawing.Point(221, 205);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(0, 19);
            this.humidity.TabIndex = 61;
            // 
            // uvrating
            // 
            this.uvrating.AutoSize = true;
            this.uvrating.BackColor = System.Drawing.Color.Transparent;
            this.uvrating.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uvrating.Location = new System.Drawing.Point(221, 244);
            this.uvrating.Name = "uvrating";
            this.uvrating.Size = new System.Drawing.Size(0, 19);
            this.uvrating.TabIndex = 62;
            // 
            // fellslike
            // 
            this.fellslike.AutoSize = true;
            this.fellslike.BackColor = System.Drawing.Color.Transparent;
            this.fellslike.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fellslike.Location = new System.Drawing.Point(221, 283);
            this.fellslike.Name = "fellslike";
            this.fellslike.Size = new System.Drawing.Size(0, 19);
            this.fellslike.TabIndex = 63;
            // 
            // temperature
            // 
            this.temperature.AutoSize = true;
            this.temperature.BackColor = System.Drawing.Color.Transparent;
            this.temperature.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature.Location = new System.Drawing.Point(24, 88);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(119, 19);
            this.temperature.TabIndex = 65;
            this.temperature.Text = "Temperature:";
            this.temperature.Visible = false;
            // 
            // forecastminamxtemp
            // 
            this.forecastminamxtemp.AutoSize = true;
            this.forecastminamxtemp.BackColor = System.Drawing.Color.Transparent;
            this.forecastminamxtemp.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastminamxtemp.Location = new System.Drawing.Point(221, 88);
            this.forecastminamxtemp.Name = "forecastminamxtemp";
            this.forecastminamxtemp.Size = new System.Drawing.Size(0, 19);
            this.forecastminamxtemp.TabIndex = 66;
            this.forecastminamxtemp.Visible = false;
            // 
            // forecastdaypicture
            // 
            this.forecastdaypicture.BackColor = System.Drawing.Color.Transparent;
            this.forecastdaypicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forecastdaypicture.Location = new System.Drawing.Point(406, 150);
            this.forecastdaypicture.Name = "forecastdaypicture";
            this.forecastdaypicture.Size = new System.Drawing.Size(121, 113);
            this.forecastdaypicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forecastdaypicture.TabIndex = 69;
            this.forecastdaypicture.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::NET_projektas.Properties.Resources._7326596361553239397_128__1_;
            this.pictureBox2.Location = new System.Drawing.Point(656, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::NET_projektas.Properties.Resources.moon_black_512;
            this.pictureBox4.Location = new System.Drawing.Point(771, 88);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 71;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(616, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Rise:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Set:";
            this.label2.Visible = false;
            // 
            // sunrise
            // 
            this.sunrise.AutoSize = true;
            this.sunrise.BackColor = System.Drawing.Color.Transparent;
            this.sunrise.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunrise.Location = new System.Drawing.Point(670, 166);
            this.sunrise.Name = "sunrise";
            this.sunrise.Size = new System.Drawing.Size(37, 13);
            this.sunrise.TabIndex = 74;
            this.sunrise.Text = "Rise:";
            this.sunrise.Visible = false;
            // 
            // sunset
            // 
            this.sunset.AutoSize = true;
            this.sunset.BackColor = System.Drawing.Color.Transparent;
            this.sunset.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunset.Location = new System.Drawing.Point(670, 205);
            this.sunset.Name = "sunset";
            this.sunset.Size = new System.Drawing.Size(37, 13);
            this.sunset.TabIndex = 75;
            this.sunset.Text = "Rise:";
            this.sunset.Visible = false;
            // 
            // moonrise
            // 
            this.moonrise.AutoSize = true;
            this.moonrise.BackColor = System.Drawing.Color.Transparent;
            this.moonrise.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moonrise.Location = new System.Drawing.Point(768, 166);
            this.moonrise.Name = "moonrise";
            this.moonrise.Size = new System.Drawing.Size(37, 13);
            this.moonrise.TabIndex = 76;
            this.moonrise.Text = "Rise:";
            this.moonrise.Visible = false;
            // 
            // moonset
            // 
            this.moonset.AutoSize = true;
            this.moonset.BackColor = System.Drawing.Color.Transparent;
            this.moonset.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moonset.Location = new System.Drawing.Point(768, 205);
            this.moonset.Name = "moonset";
            this.moonset.Size = new System.Drawing.Size(37, 13);
            this.moonset.TabIndex = 77;
            this.moonset.Text = "Rise:";
            this.moonset.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(804, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(17, 17);
            this.button3.TabIndex = 78;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(215)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 348);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 30);
            this.button4.TabIndex = 79;
            this.button4.Text = "Forecast";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(215)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(142, 348);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 30);
            this.button5.TabIndex = 80;
            this.button5.Text = "Hourly";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(167, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // txtCurrentTemp
            // 
            this.txtCurrentTemp.AutoSize = true;
            this.txtCurrentTemp.BackColor = System.Drawing.Color.Transparent;
            this.txtCurrentTemp.Font = new System.Drawing.Font("Roboto Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentTemp.Location = new System.Drawing.Point(12, 32);
            this.txtCurrentTemp.Name = "txtCurrentTemp";
            this.txtCurrentTemp.Size = new System.Drawing.Size(149, 58);
            this.txtCurrentTemp.TabIndex = 0;
            this.txtCurrentTemp.Text = "-10°C";
            this.txtCurrentTemp.Visible = false;
            this.txtCurrentTemp.Click += new System.EventHandler(this.txtCurrentTemp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(215)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 27);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dayboxFirst
            // 
            this.dayboxFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(215)))));
            this.dayboxFirst.FlatAppearance.BorderSize = 0;
            this.dayboxFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayboxFirst.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayboxFirst.Location = new System.Drawing.Point(375, 25);
            this.dayboxFirst.Name = "dayboxFirst";
            this.dayboxFirst.Size = new System.Drawing.Size(53, 23);
            this.dayboxFirst.TabIndex = 60;
            this.dayboxFirst.UseVisualStyleBackColor = false;
            this.dayboxFirst.Click += new System.EventHandler(this.dayboxFirst_Click);
            // 
            // pictureBoxFirst
            // 
            this.pictureBoxFirst.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFirst.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxFirst.Location = new System.Drawing.Point(381, 55);
            this.pictureBoxFirst.Name = "pictureBoxFirst";
            this.pictureBoxFirst.Size = new System.Drawing.Size(41, 43);
            this.pictureBoxFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFirst.TabIndex = 61;
            this.pictureBoxFirst.TabStop = false;
            this.pictureBoxFirst.Click += new System.EventHandler(this.pictureBoxFirst_Click);
            // 
            // Temp1
            // 
            this.Temp1.AutoSize = true;
            this.Temp1.BackColor = System.Drawing.Color.Transparent;
            this.Temp1.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp1.ForeColor = System.Drawing.Color.Black;
            this.Temp1.Location = new System.Drawing.Point(380, 101);
            this.Temp1.Name = "Temp1";
            this.Temp1.Size = new System.Drawing.Size(0, 13);
            this.Temp1.TabIndex = 62;
            this.Temp1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Temp1.Click += new System.EventHandler(this.Temp1_Click);
            // 
            // dayboxSecond
            // 
            this.dayboxSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(215)))));
            this.dayboxSecond.FlatAppearance.BorderSize = 0;
            this.dayboxSecond.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayboxSecond.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayboxSecond.Location = new System.Drawing.Point(449, 25);
            this.dayboxSecond.Name = "dayboxSecond";
            this.dayboxSecond.Size = new System.Drawing.Size(53, 23);
            this.dayboxSecond.TabIndex = 63;
            this.dayboxSecond.UseVisualStyleBackColor = false;
            this.dayboxSecond.Click += new System.EventHandler(this.dayboxSecond_Click);
            // 
            // pictureBoxSecond
            // 
            this.pictureBoxSecond.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSecond.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSecond.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxSecond.Location = new System.Drawing.Point(455, 55);
            this.pictureBoxSecond.Name = "pictureBoxSecond";
            this.pictureBoxSecond.Size = new System.Drawing.Size(41, 43);
            this.pictureBoxSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSecond.TabIndex = 64;
            this.pictureBoxSecond.TabStop = false;
            // 
            // Temp2
            // 
            this.Temp2.AutoSize = true;
            this.Temp2.BackColor = System.Drawing.Color.Transparent;
            this.Temp2.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp2.Location = new System.Drawing.Point(454, 101);
            this.Temp2.Name = "Temp2";
            this.Temp2.Size = new System.Drawing.Size(0, 13);
            this.Temp2.TabIndex = 65;
            this.Temp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayboxThird
            // 
            this.dayboxThird.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(215)))));
            this.dayboxThird.FlatAppearance.BorderSize = 0;
            this.dayboxThird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dayboxThird.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayboxThird.Location = new System.Drawing.Point(522, 25);
            this.dayboxThird.Name = "dayboxThird";
            this.dayboxThird.Size = new System.Drawing.Size(53, 23);
            this.dayboxThird.TabIndex = 66;
            this.dayboxThird.UseVisualStyleBackColor = false;
            this.dayboxThird.Click += new System.EventHandler(this.dayboxThird_Click);
            // 
            // pictureBoxThird
            // 
            this.pictureBoxThird.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxThird.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxThird.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxThird.Location = new System.Drawing.Point(528, 55);
            this.pictureBoxThird.Name = "pictureBoxThird";
            this.pictureBoxThird.Size = new System.Drawing.Size(41, 43);
            this.pictureBoxThird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThird.TabIndex = 67;
            this.pictureBoxThird.TabStop = false;
            // 
            // Temp3
            // 
            this.Temp3.AutoSize = true;
            this.Temp3.BackColor = System.Drawing.Color.Transparent;
            this.Temp3.Font = new System.Drawing.Font("Roboto Medium", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp3.Location = new System.Drawing.Point(527, 102);
            this.Temp3.Name = "Temp3";
            this.Temp3.Size = new System.Drawing.Size(0, 13);
            this.Temp3.TabIndex = 68;
            this.Temp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelhourly
            // 
            this.panelhourly.BackColor = System.Drawing.Color.Transparent;
            this.panelhourly.BackgroundImage = global::NET_projektas.Properties.Resources.blue_blur;
            this.panelhourly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelhourly.Controls.Add(this.Temp3);
            this.panelhourly.Controls.Add(this.pictureBoxThird);
            this.panelhourly.Controls.Add(this.dayboxThird);
            this.panelhourly.Controls.Add(this.Temp2);
            this.panelhourly.Controls.Add(this.pictureBoxSecond);
            this.panelhourly.Controls.Add(this.dayboxSecond);
            this.panelhourly.Controls.Add(this.Temp1);
            this.panelhourly.Controls.Add(this.pictureBoxFirst);
            this.panelhourly.Controls.Add(this.dayboxFirst);
            this.panelhourly.Controls.Add(this.button1);
            this.panelhourly.Controls.Add(this.txtCurrentTemp);
            this.panelhourly.Controls.Add(this.pictureBox1);
            this.panelhourly.Location = new System.Drawing.Point(3, 0);
            this.panelhourly.Name = "panelhourly";
            this.panelhourly.Size = new System.Drawing.Size(851, 138);
            this.panelhourly.TabIndex = 69;
            this.panelhourly.Visible = false;
            // 
            // tempreturebutton
            // 
            this.tempreturebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(215)))));
            this.tempreturebutton.FlatAppearance.BorderSize = 0;
            this.tempreturebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tempreturebutton.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempreturebutton.Location = new System.Drawing.Point(710, 0);
            this.tempreturebutton.Name = "tempreturebutton";
            this.tempreturebutton.Size = new System.Drawing.Size(142, 30);
            this.tempreturebutton.TabIndex = 81;
            this.tempreturebutton.Text = "Temperature";
            this.tempreturebutton.UseVisualStyleBackColor = false;
            this.tempreturebutton.Visible = false;
            // 
            // percipitationbutton
            // 
            this.percipitationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(200)))), ((int)(((byte)(215)))));
            this.percipitationbutton.FlatAppearance.BorderSize = 0;
            this.percipitationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percipitationbutton.Font = new System.Drawing.Font("Roboto Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percipitationbutton.Location = new System.Drawing.Point(567, 0);
            this.percipitationbutton.Name = "percipitationbutton";
            this.percipitationbutton.Size = new System.Drawing.Size(142, 30);
            this.percipitationbutton.TabIndex = 82;
            this.percipitationbutton.Text = "Percipitation";
            this.percipitationbutton.UseVisualStyleBackColor = false;
            this.percipitationbutton.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NET_projektas.Properties.Resources.v3imagesbina76005dedfda6535ff832055ec0c5527_pcbcbniwrx8555v0tu2;
            this.ClientSize = new System.Drawing.Size(851, 519);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.moonset);
            this.Controls.Add(this.moonrise);
            this.Controls.Add(this.sunset);
            this.Controls.Add(this.sunrise);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.forecastdaypicture);
            this.Controls.Add(this.forecastminamxtemp);
            this.Controls.Add(this.temperature);
            this.Controls.Add(this.fellslike);
            this.Controls.Add(this.uvrating);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.percipitation);
            this.Controls.Add(this.windspeed);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtCityCountry);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.feelslikelabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form1";
            this.Text = "Weather App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.forecastdaypicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThird)).EndInit();
            this.panelhourly.ResumeLayout(false);
            this.panelhourly.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtCityCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label feelslikelabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label windspeed;
        private System.Windows.Forms.Label percipitation;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Label uvrating;
        private System.Windows.Forms.Label fellslike;
        private System.Windows.Forms.Label temperature;
        private System.Windows.Forms.Label forecastminamxtemp;
        private System.Windows.Forms.PictureBox forecastdaypicture;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sunrise;
        private System.Windows.Forms.Label sunset;
        private System.Windows.Forms.Label moonrise;
        private System.Windows.Forms.Label moonset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtCurrentTemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dayboxFirst;
        private System.Windows.Forms.PictureBox pictureBoxFirst;
        private System.Windows.Forms.Label Temp1;
        private System.Windows.Forms.Button dayboxSecond;
        private System.Windows.Forms.PictureBox pictureBoxSecond;
        private System.Windows.Forms.Label Temp2;
        private System.Windows.Forms.Button dayboxThird;
        private System.Windows.Forms.PictureBox pictureBoxThird;
        private System.Windows.Forms.Label Temp3;
        private System.Windows.Forms.Panel panelhourly;
        private System.Windows.Forms.Button percipitationbutton;
        private System.Windows.Forms.Button tempreturebutton;
    }
}

