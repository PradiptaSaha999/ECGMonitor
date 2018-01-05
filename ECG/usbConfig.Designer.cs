namespace ECG
{
    partial class usbConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(usbConfig));
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxBAUDrate = new System.Windows.Forms.ComboBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(127, 34);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOM.TabIndex = 0;
            this.comboBoxCOM.Text = "COM port";
            this.comboBoxCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOM_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select COM port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BAUD rate";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxBAUDrate
            // 
            this.comboBoxBAUDrate.FormattingEnabled = true;
            this.comboBoxBAUDrate.Location = new System.Drawing.Point(127, 72);
            this.comboBoxBAUDrate.Name = "comboBoxBAUDrate";
            this.comboBoxBAUDrate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBAUDrate.TabIndex = 3;
            this.comboBoxBAUDrate.Text = "select";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(467, 205);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // usbConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(717, 335);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.comboBoxBAUDrate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCOM);
            this.Name = "usbConfig";
            this.Text = "usbConfig";
            this.Load += new System.EventHandler(this.usbConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBAUDrate;
        private System.Windows.Forms.Button nextButton;
    }
}