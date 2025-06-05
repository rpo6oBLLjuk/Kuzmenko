namespace WeatherAPIProj
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            GetWeatherButton = new Button();
            weatherInputField = new TextBox();
            label1 = new Label();
            weatherLabel = new Label();
            SuspendLayout();
            // 
            // GetWeatherButton
            // 
            GetWeatherButton.Location = new Point(27, 148);
            GetWeatherButton.Name = "GetWeatherButton";
            GetWeatherButton.Size = new Size(200, 60);
            GetWeatherButton.TabIndex = 0;
            GetWeatherButton.Text = "Get Weather";
            GetWeatherButton.UseVisualStyleBackColor = true;
            GetWeatherButton.Click += GetWeatherButton_Click;
            // 
            // weatherInputField
            // 
            weatherInputField.Location = new Point(27, 93);
            weatherInputField.Name = "weatherInputField";
            weatherInputField.Size = new Size(200, 27);
            weatherInputField.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(61, 60);
            label1.Name = "label1";
            label1.Size = new Size(134, 22);
            label1.TabIndex = 2;
            label1.Text = "ENTER CITY NAME";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // weatherLabel
            // 
            weatherLabel.BorderStyle = BorderStyle.FixedSingle;
            weatherLabel.Location = new Point(310, 60);
            weatherLabel.Name = "weatherLabel";
            weatherLabel.Size = new Size(200, 148);
            weatherLabel.TabIndex = 3;
            weatherLabel.Text = "Weather";
            weatherLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 254);
            Controls.Add(weatherLabel);
            Controls.Add(label1);
            Controls.Add(weatherInputField);
            Controls.Add(GetWeatherButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WeatherAPI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GetWeatherButton;
        private TextBox weatherInputField;
        private Label label1;
        private Label weatherLabel;
    }
}
