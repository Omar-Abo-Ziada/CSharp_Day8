namespace Day8
{
    partial class FrmControls
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
            this.colorMixer1 = new Day8.ColorMixer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.digitalClock1 = new Day8.DigitalClock();
            this.SuspendLayout();
            // 
            // colorMixer1
            // 
            this.colorMixer1.Location = new System.Drawing.Point(50, 36);
            this.colorMixer1.Name = "colorMixer1";
            this.colorMixer1.Size = new System.Drawing.Size(237, 301);
            this.colorMixer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(372, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 160);
            this.textBox1.TabIndex = 1;
            // 
            // digitalClock1
            // 
            this.digitalClock1.Location = new System.Drawing.Point(382, 246);
            this.digitalClock1.Name = "digitalClock1";
            this.digitalClock1.Size = new System.Drawing.Size(201, 83);
            this.digitalClock1.TabIndex = 2;
            this.digitalClock1.Text = "digitalClock1";
            // 
            // FrmControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.digitalClock1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.colorMixer1);
            this.Name = "FrmControls";
            this.Text = "FrmControls";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ColorMixer colorMixer1;
        private System.Windows.Forms.TextBox textBox1;
        private DigitalClock digitalClock1;
    }
}