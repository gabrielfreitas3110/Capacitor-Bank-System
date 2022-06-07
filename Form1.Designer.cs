namespace Capacitor_Bank_System
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.motor_off = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.motorOff = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.motorOn1 = new System.Windows.Forms.PictureBox();
            this.motorOn3 = new System.Windows.Forms.PictureBox();
            this.motorOn5 = new System.Windows.Forms.PictureBox();
            this.motorOn7 = new System.Windows.Forms.PictureBox();
            this.motorOn2 = new System.Windows.Forms.PictureBox();
            this.motorOn4 = new System.Windows.Forms.PictureBox();
            this.motorOn6 = new System.Windows.Forms.PictureBox();
            this.motorOn8 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.motor_off);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // motor_off
            // 
            this.motor_off.BackColor = System.Drawing.SystemColors.Control;
            this.motor_off.ImageIndex = 0;
            this.motor_off.Location = new System.Drawing.Point(107, 222);
            this.motor_off.Name = "motor_off";
            this.motor_off.Size = new System.Drawing.Size(120, 90);
            this.motor_off.TabIndex = 1;
            this.motor_off.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(197, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(852, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 400);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Location = new System.Drawing.Point(12, 449);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 400);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(197, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 1;
            // 
            // motorOff
            // 
            this.motorOff.Image = global::Capacitor_Bank_System.Properties.Resources.motor_off;
            this.motorOff.Location = new System.Drawing.Point(497, 67);
            this.motorOff.Name = "motorOff";
            this.motorOff.Size = new System.Drawing.Size(90, 120);
            this.motorOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motorOff.TabIndex = 2;
            this.motorOff.TabStop = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackgroundImage = global::Capacitor_Bank_System.Properties.Resources.motor_off;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(616, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 120);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // motorOn1
            // 
            this.motorOn1.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on_1;
            this.motorOn1.Location = new System.Drawing.Point(497, 67);
            this.motorOn1.Name = "motorOn1";
            this.motorOn1.Size = new System.Drawing.Size(90, 120);
            this.motorOn1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motorOn1.TabIndex = 8;
            this.motorOn1.TabStop = false;
            this.motorOn1.Visible = false;
            // 
            // motorOn3
            // 
            this.motorOn3.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on_3;
            this.motorOn3.Location = new System.Drawing.Point(497, 67);
            this.motorOn3.Name = "motorOn3";
            this.motorOn3.Size = new System.Drawing.Size(90, 120);
            this.motorOn3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motorOn3.TabIndex = 9;
            this.motorOn3.TabStop = false;
            this.motorOn3.Visible = false;
            // 
            // motorOn5
            // 
            this.motorOn5.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on_5;
            this.motorOn5.Location = new System.Drawing.Point(497, 67);
            this.motorOn5.Name = "motorOn5";
            this.motorOn5.Size = new System.Drawing.Size(90, 120);
            this.motorOn5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motorOn5.TabIndex = 10;
            this.motorOn5.TabStop = false;
            this.motorOn5.Visible = false;
            // 
            // motorOn7
            // 
            this.motorOn7.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on_7;
            this.motorOn7.Location = new System.Drawing.Point(497, 67);
            this.motorOn7.Name = "motorOn7";
            this.motorOn7.Size = new System.Drawing.Size(90, 120);
            this.motorOn7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motorOn7.TabIndex = 11;
            this.motorOn7.TabStop = false;
            this.motorOn7.Visible = false;
            // 
            // motorOn2
            // 
            this.motorOn2.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on_2;
            this.motorOn2.Location = new System.Drawing.Point(497, 67);
            this.motorOn2.Name = "motorOn2";
            this.motorOn2.Size = new System.Drawing.Size(90, 120);
            this.motorOn2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motorOn2.TabIndex = 13;
            this.motorOn2.TabStop = false;
            this.motorOn2.Visible = false;
            // 
            // motorOn4
            // 
            this.motorOn4.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on_4;
            this.motorOn4.Location = new System.Drawing.Point(497, 67);
            this.motorOn4.Name = "motorOn4";
            this.motorOn4.Size = new System.Drawing.Size(90, 120);
            this.motorOn4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motorOn4.TabIndex = 14;
            this.motorOn4.TabStop = false;
            this.motorOn4.Visible = false;
            // 
            // motorOn6
            // 
            this.motorOn6.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on_6;
            this.motorOn6.Location = new System.Drawing.Point(497, 67);
            this.motorOn6.Name = "motorOn6";
            this.motorOn6.Size = new System.Drawing.Size(90, 120);
            this.motorOn6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motorOn6.TabIndex = 15;
            this.motorOn6.TabStop = false;
            this.motorOn6.Visible = false;
            // 
            // motorOn8
            // 
            this.motorOn8.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on_8;
            this.motorOn8.Location = new System.Drawing.Point(497, 67);
            this.motorOn8.Name = "motorOn8";
            this.motorOn8.Size = new System.Drawing.Size(90, 120);
            this.motorOn8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motorOn8.TabIndex = 16;
            this.motorOn8.TabStop = false;
            this.motorOn8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 861);
            this.Controls.Add(this.motorOn8);
            this.Controls.Add(this.motorOn6);
            this.Controls.Add(this.motorOn4);
            this.Controls.Add(this.motorOn2);
            this.Controls.Add(this.motorOn7);
            this.Controls.Add(this.motorOn5);
            this.Controls.Add(this.motorOn3);
            this.Controls.Add(this.motorOn1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.motorOff);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.motorOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motorOn8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button motor_off;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private Panel panel3;
        private Panel panel6;
        private PictureBox motorOff;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox motorOn1;
        private PictureBox motorOn3;
        private PictureBox motorOn5;
        private PictureBox motorOn7;
        private PictureBox motorOn2;
        private PictureBox motorOn4;
        private PictureBox motorOn6;
        private PictureBox motorOn8;
    }
}