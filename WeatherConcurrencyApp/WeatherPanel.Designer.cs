
namespace WeatherConcurrencyApp
{
    partial class WeatherPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTemperature = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWeather = new System.Windows.Forms.Label();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblCity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtwLon = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwLat = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwFeelsLike = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwTempMin = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwTempMax = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwPressure = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwHumidity = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwVissibility = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwSpeed = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwSunrise = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwSunset = new WeatherConcurrencyApp.DetailsWeather();
            this.dtwTimeZone = new WeatherConcurrencyApp.DetailsWeather();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTemperature.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(3, 59);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(332, 59);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "30";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTemperature.Click += new System.EventHandler(this.lblTemperature_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblTemperature, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWeather, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 138);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(3, 118);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(332, 20);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "lblWeather";
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWeather.Click += new System.EventHandler(this.lblWeather_Click);
            // 
            // flpContent
            // 
            this.flpContent.Controls.Add(this.dtwLon);
            this.flpContent.Controls.Add(this.dtwLat);
            this.flpContent.Controls.Add(this.dtwFeelsLike);
            this.flpContent.Controls.Add(this.dtwTempMin);
            this.flpContent.Controls.Add(this.dtwTempMax);
            this.flpContent.Controls.Add(this.dtwPressure);
            this.flpContent.Controls.Add(this.dtwHumidity);
            this.flpContent.Controls.Add(this.dtwVissibility);
            this.flpContent.Controls.Add(this.dtwSpeed);
            this.flpContent.Controls.Add(this.dtwSunrise);
            this.flpContent.Controls.Add(this.dtwSunset);
            this.flpContent.Controls.Add(this.dtwTimeZone);
            this.flpContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpContent.Location = new System.Drawing.Point(0, 144);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(338, 407);
            this.flpContent.TabIndex = 3;
            this.flpContent.TabStop = true;
            this.flpContent.Paint += new System.Windows.Forms.PaintEventHandler(this.flpContent_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblCity);
            this.splitContainer1.Size = new System.Drawing.Size(332, 53);
            this.splitContainer1.SplitterDistance = 110;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCity.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(0, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(60, 26);
            this.lblCity.TabIndex = 1;
            this.lblCity.Text = "City";
            this.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dtwLon
            // 
            this.dtwLon.Location = new System.Drawing.Point(3, 3);
            this.dtwLon.Name = "dtwLon";
            this.dtwLon.Size = new System.Drawing.Size(106, 74);
            this.dtwLon.TabIndex = 0;
            // 
            // dtwLat
            // 
            this.dtwLat.Location = new System.Drawing.Point(115, 3);
            this.dtwLat.Name = "dtwLat";
            this.dtwLat.Size = new System.Drawing.Size(106, 74);
            this.dtwLat.TabIndex = 1;
            // 
            // dtwFeelsLike
            // 
            this.dtwFeelsLike.Location = new System.Drawing.Point(227, 3);
            this.dtwFeelsLike.Name = "dtwFeelsLike";
            this.dtwFeelsLike.Size = new System.Drawing.Size(106, 74);
            this.dtwFeelsLike.TabIndex = 2;
            this.dtwFeelsLike.Load += new System.EventHandler(this.dtwFeelsLike_Load);
            // 
            // dtwTempMin
            // 
            this.dtwTempMin.Location = new System.Drawing.Point(3, 83);
            this.dtwTempMin.Name = "dtwTempMin";
            this.dtwTempMin.Size = new System.Drawing.Size(106, 74);
            this.dtwTempMin.TabIndex = 3;
            // 
            // dtwTempMax
            // 
            this.dtwTempMax.Location = new System.Drawing.Point(115, 83);
            this.dtwTempMax.Name = "dtwTempMax";
            this.dtwTempMax.Size = new System.Drawing.Size(106, 74);
            this.dtwTempMax.TabIndex = 4;
            // 
            // dtwPressure
            // 
            this.dtwPressure.Location = new System.Drawing.Point(227, 83);
            this.dtwPressure.Name = "dtwPressure";
            this.dtwPressure.Size = new System.Drawing.Size(106, 74);
            this.dtwPressure.TabIndex = 5;
            // 
            // dtwHumidity
            // 
            this.dtwHumidity.Location = new System.Drawing.Point(3, 163);
            this.dtwHumidity.Name = "dtwHumidity";
            this.dtwHumidity.Size = new System.Drawing.Size(106, 74);
            this.dtwHumidity.TabIndex = 6;
            // 
            // dtwVissibility
            // 
            this.dtwVissibility.Location = new System.Drawing.Point(115, 163);
            this.dtwVissibility.Name = "dtwVissibility";
            this.dtwVissibility.Size = new System.Drawing.Size(106, 74);
            this.dtwVissibility.TabIndex = 7;
            // 
            // dtwSpeed
            // 
            this.dtwSpeed.Location = new System.Drawing.Point(227, 163);
            this.dtwSpeed.Name = "dtwSpeed";
            this.dtwSpeed.Size = new System.Drawing.Size(106, 74);
            this.dtwSpeed.TabIndex = 8;
            this.dtwSpeed.Load += new System.EventHandler(this.detailsWeather9_Load);
            // 
            // dtwSunrise
            // 
            this.dtwSunrise.Location = new System.Drawing.Point(3, 243);
            this.dtwSunrise.Name = "dtwSunrise";
            this.dtwSunrise.Size = new System.Drawing.Size(106, 74);
            this.dtwSunrise.TabIndex = 9;
            // 
            // dtwSunset
            // 
            this.dtwSunset.Location = new System.Drawing.Point(115, 243);
            this.dtwSunset.Name = "dtwSunset";
            this.dtwSunset.Size = new System.Drawing.Size(106, 74);
            this.dtwSunset.TabIndex = 10;
            // 
            // dtwTimeZone
            // 
            this.dtwTimeZone.Location = new System.Drawing.Point(227, 243);
            this.dtwTimeZone.Name = "dtwTimeZone";
            this.dtwTimeZone.Size = new System.Drawing.Size(106, 74);
            this.dtwTimeZone.TabIndex = 11;
            // 
            // WeatherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "WeatherPanel";
            this.Size = new System.Drawing.Size(338, 551);
            this.Load += new System.EventHandler(this.WeatherPanel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flpContent.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        public DetailsWeather dtwLat;
        public DetailsWeather dtwFeelsLike;
        public DetailsWeather dtwTempMin;
        public DetailsWeather dtwTempMax;
        public DetailsWeather dtwPressure;
        public DetailsWeather dtwHumidity;
        public DetailsWeather dtwVissibility;
        public DetailsWeather dtwSpeed;
        public DetailsWeather dtwSunrise;
        public DetailsWeather dtwSunset;
        public DetailsWeather dtwTimeZone;
        public DetailsWeather dtwLon;
        public System.Windows.Forms.Label lblTemperature;
        public System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.Label lblCity;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
