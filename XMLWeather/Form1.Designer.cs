namespace XMLWeather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityOutput = new System.Windows.Forms.Label();
            this.currentTempOut = new System.Windows.Forms.Label();
            this.windDescOut = new System.Windows.Forms.Label();
            this.maxOutput = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.day1Clouds = new System.Windows.Forms.Label();
            this.daySelect = new System.Windows.Forms.ComboBox();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.windSpeedOutput = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cityOutput
            // 
            this.cityOutput.AutoSize = true;
            this.cityOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.Location = new System.Drawing.Point(1, 7);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(35, 20);
            this.cityOutput.TabIndex = 0;
            this.cityOutput.Text = "City";
            // 
            // currentTempOut
            // 
            this.currentTempOut.AutoSize = true;
            this.currentTempOut.BackColor = System.Drawing.Color.Transparent;
            this.currentTempOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTempOut.Location = new System.Drawing.Point(4, 70);
            this.currentTempOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentTempOut.Name = "currentTempOut";
            this.currentTempOut.Size = new System.Drawing.Size(131, 55);
            this.currentTempOut.TabIndex = 1;
            this.currentTempOut.Text = "temp";
            // 
            // windDescOut
            // 
            this.windDescOut.BackColor = System.Drawing.Color.BurlyWood;
            this.windDescOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windDescOut.Location = new System.Drawing.Point(-1, 277);
            this.windDescOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.windDescOut.Name = "windDescOut";
            this.windDescOut.Size = new System.Drawing.Size(359, 27);
            this.windDescOut.TabIndex = 2;
            this.windDescOut.Text = "wind";
            this.windDescOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxOutput.Location = new System.Drawing.Point(0, 202);
            this.maxOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(359, 28);
            this.maxOutput.TabIndex = 3;
            this.maxOutput.Text = "max";
            this.maxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.Teal;
            this.minOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minOutput.Location = new System.Drawing.Point(-5, 230);
            this.minOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(364, 23);
            this.minOutput.TabIndex = 4;
            this.minOutput.Text = "min";
            this.minOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // day1Clouds
            // 
            this.day1Clouds.BackColor = System.Drawing.Color.WhiteSmoke;
            this.day1Clouds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day1Clouds.Location = new System.Drawing.Point(0, 253);
            this.day1Clouds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day1Clouds.Name = "day1Clouds";
            this.day1Clouds.Size = new System.Drawing.Size(358, 25);
            this.day1Clouds.TabIndex = 7;
            this.day1Clouds.Text = "clouds";
            this.day1Clouds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // daySelect
            // 
            this.daySelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daySelect.FormattingEnabled = true;
            this.daySelect.Items.AddRange(new object[] {
            "Today",
            "Tomorrow"});
            this.daySelect.Location = new System.Drawing.Point(208, 6);
            this.daySelect.Name = "daySelect";
            this.daySelect.Size = new System.Drawing.Size(121, 26);
            this.daySelect.TabIndex = 9;
            this.daySelect.Text = "Today";
            this.daySelect.SelectedIndexChanged += new System.EventHandler(this.daySelect_SelectedIndexChanged);
            // 
            // imageBox
            // 
            this.imageBox.Image = global::XMLWeather.Properties.Resources.fog;
            this.imageBox.Location = new System.Drawing.Point(140, 49);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(169, 150);
            this.imageBox.TabIndex = 10;
            this.imageBox.TabStop = false;
            // 
            // windSpeedOutput
            // 
            this.windSpeedOutput.BackColor = System.Drawing.Color.BurlyWood;
            this.windSpeedOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedOutput.Location = new System.Drawing.Point(0, 304);
            this.windSpeedOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.windSpeedOutput.Name = "windSpeedOutput";
            this.windSpeedOutput.Size = new System.Drawing.Size(358, 20);
            this.windSpeedOutput.TabIndex = 11;
            this.windSpeedOutput.Text = "wind speed";
            this.windSpeedOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateOutput
            // 
            this.dateOutput.AutoSize = true;
            this.dateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.Location = new System.Drawing.Point(123, 7);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(41, 20);
            this.dateOutput.TabIndex = 12;
            this.dateOutput.Text = "date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(359, 357);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.windSpeedOutput);
            this.Controls.Add(this.daySelect);
            this.Controls.Add(this.day1Clouds);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.windDescOut);
            this.Controls.Add(this.currentTempOut);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.imageBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5 day Weather";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label currentTempOut;
        private System.Windows.Forms.Label windDescOut;
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label day1Clouds;
        private System.Windows.Forms.ComboBox daySelect;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Label windSpeedOutput;
        private System.Windows.Forms.Label dateOutput;
    }
}

