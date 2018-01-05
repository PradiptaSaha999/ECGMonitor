namespace ECG
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartECG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.conditionComboBox = new System.Windows.Forms.ComboBox();
            this.pauseButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartECG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartECG
            // 
            chartArea1.AxisX.Crossing = 1.7976931348623157E+308D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.IsStartedFromZero = false;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisX.MajorGrid.Interval = 20D;
            chartArea1.AxisX.MajorGrid.IntervalOffset = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisX.MajorGrid.LineWidth = 2;
            chartArea1.AxisX.MajorTickMark.Interval = 20D;
            chartArea1.AxisX.MaximumAutoSize = 0F;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 4D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.Interval = 4D;
            chartArea1.AxisX.ScaleView.Size = 600D;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.Maroon;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Red;
            chartArea1.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.IsMarginVisible = false;
            chartArea1.AxisY.LabelStyle.Enabled = false;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY.MajorGrid.Interval = 100D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY.MajorGrid.LineWidth = 2;
            chartArea1.AxisY.MaximumAutoSize = 0F;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.Interval = 20D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY.ScaleView.Position = 50D;
            chartArea1.AxisY.ScaleView.Size = 1000D;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.Red;
            chartArea1.AxisY2.MaximumAutoSize = 30F;
            chartArea1.BorderColor = System.Drawing.Color.Red;
            chartArea1.Name = "ChartArea1";
            this.chartECG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartECG.Legends.Add(legend1);
            this.chartECG.Location = new System.Drawing.Point(12, 129);
            this.chartECG.Name = "chartECG";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.CustomProperties = "IsXAxisQuantitative=False";
            series1.LabelForeColor = System.Drawing.Color.OrangeRed;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            this.chartECG.Series.Add(series1);
            this.chartECG.Size = new System.Drawing.Size(1338, 458);
            this.chartECG.TabIndex = 0;
            this.chartECG.Text = "chartECG";
            this.chartECG.Click += new System.EventHandler(this.chartECG_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(1224, 410);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1224, 381);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1224, 439);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1220, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "value";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(1223, 195);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // conditionComboBox
            // 
            this.conditionComboBox.FormattingEnabled = true;
            this.conditionComboBox.Location = new System.Drawing.Point(1223, 251);
            this.conditionComboBox.Name = "conditionComboBox";
            this.conditionComboBox.Size = new System.Drawing.Size(96, 21);
            this.conditionComboBox.TabIndex = 6;
            this.conditionComboBox.Text = "condition";
            this.conditionComboBox.SelectedIndexChanged += new System.EventHandler(this.conditionComboBox_SelectedIndexChanged);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(1223, 352);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 7;
            this.pauseButton.Text = "pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1220, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(120, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1227, 114);
            this.label4.TabIndex = 10;
            this.label4.Text = "CUET EEE ECG MONITOR";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(12, 590);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 114);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 624);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.conditionComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.chartECG);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ECG Ploter";
            ((System.ComponentModel.ISupportInitialize)(this.chartECG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartECG;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox conditionComboBox;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

