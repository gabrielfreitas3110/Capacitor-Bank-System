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
            this.motor_on_4 = new System.Windows.Forms.PictureBox();
            this.motor_off_4 = new System.Windows.Forms.PictureBox();
            this.motor_on_3 = new System.Windows.Forms.PictureBox();
            this.motor_off_3 = new System.Windows.Forms.PictureBox();
            this.motor_on_2 = new System.Windows.Forms.PictureBox();
            this.motor_off_2 = new System.Windows.Forms.PictureBox();
            this.motor_on_1 = new System.Windows.Forms.PictureBox();
            this.motor_off_1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbMotor1 = new System.Windows.Forms.Label();
            this.lbMotor2 = new System.Windows.Forms.Label();
            this.lbMotor4 = new System.Windows.Forms.Label();
            this.lbMotor3 = new System.Windows.Forms.Label();
            this.statusMotor1 = new System.Windows.Forms.Label();
            this.statusMotor2 = new System.Windows.Forms.Label();
            this.statusMotor4 = new System.Windows.Forms.Label();
            this.statusMotor3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motor_on_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_off_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_on_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_off_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_on_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_off_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_on_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_off_1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.motor_off_4);
            this.panel1.Controls.Add(this.motor_off_3);
            this.panel1.Controls.Add(this.motor_off_2);
            this.panel1.Controls.Add(this.motor_off_1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.motor_on_4);
            this.panel1.Controls.Add(this.motor_on_3);
            this.panel1.Controls.Add(this.motor_on_2);
            this.panel1.Controls.Add(this.motor_on_1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            // 
            // motor_on_4
            // 
            this.motor_on_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motor_on_4.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on;
            this.motor_on_4.Location = new System.Drawing.Point(312, 341);
            this.motor_on_4.Name = "motor_on_4";
            this.motor_on_4.Size = new System.Drawing.Size(43, 59);
            this.motor_on_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motor_on_4.TabIndex = 9;
            this.motor_on_4.TabStop = false;
            this.motor_on_4.Visible = false;
            this.motor_on_4.Click += new System.EventHandler(this.motor_on_4_Click);
            // 
            // motor_off_4
            // 
            this.motor_off_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motor_off_4.Image = global::Capacitor_Bank_System.Properties.Resources.motor_off;
            this.motor_off_4.Location = new System.Drawing.Point(312, 341);
            this.motor_off_4.Name = "motor_off_4";
            this.motor_off_4.Size = new System.Drawing.Size(43, 59);
            this.motor_off_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motor_off_4.TabIndex = 8;
            this.motor_off_4.TabStop = false;
            this.motor_off_4.Click += new System.EventHandler(this.motor_off_4_Click);
            // 
            // motor_on_3
            // 
            this.motor_on_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motor_on_3.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on;
            this.motor_on_3.Location = new System.Drawing.Point(224, 341);
            this.motor_on_3.Name = "motor_on_3";
            this.motor_on_3.Size = new System.Drawing.Size(43, 59);
            this.motor_on_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motor_on_3.TabIndex = 7;
            this.motor_on_3.TabStop = false;
            this.motor_on_3.Visible = false;
            this.motor_on_3.Click += new System.EventHandler(this.motor_on_3_Click);
            // 
            // motor_off_3
            // 
            this.motor_off_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motor_off_3.Image = global::Capacitor_Bank_System.Properties.Resources.motor_off;
            this.motor_off_3.Location = new System.Drawing.Point(224, 341);
            this.motor_off_3.Name = "motor_off_3";
            this.motor_off_3.Size = new System.Drawing.Size(43, 59);
            this.motor_off_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motor_off_3.TabIndex = 6;
            this.motor_off_3.TabStop = false;
            this.motor_off_3.Click += new System.EventHandler(this.motor_off_3_Click);
            // 
            // motor_on_2
            // 
            this.motor_on_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motor_on_2.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on;
            this.motor_on_2.Location = new System.Drawing.Point(133, 341);
            this.motor_on_2.Name = "motor_on_2";
            this.motor_on_2.Size = new System.Drawing.Size(43, 59);
            this.motor_on_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motor_on_2.TabIndex = 5;
            this.motor_on_2.TabStop = false;
            this.motor_on_2.Visible = false;
            this.motor_on_2.Click += new System.EventHandler(this.motor_on_2_Click);
            // 
            // motor_off_2
            // 
            this.motor_off_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motor_off_2.Image = global::Capacitor_Bank_System.Properties.Resources.motor_off;
            this.motor_off_2.Location = new System.Drawing.Point(133, 341);
            this.motor_off_2.Name = "motor_off_2";
            this.motor_off_2.Size = new System.Drawing.Size(43, 59);
            this.motor_off_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motor_off_2.TabIndex = 4;
            this.motor_off_2.TabStop = false;
            this.motor_off_2.Click += new System.EventHandler(this.motor_off_2_Click);
            // 
            // motor_on_1
            // 
            this.motor_on_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motor_on_1.Image = global::Capacitor_Bank_System.Properties.Resources.motor_on;
            this.motor_on_1.Location = new System.Drawing.Point(45, 341);
            this.motor_on_1.Name = "motor_on_1";
            this.motor_on_1.Size = new System.Drawing.Size(43, 59);
            this.motor_on_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motor_on_1.TabIndex = 3;
            this.motor_on_1.TabStop = false;
            this.motor_on_1.Visible = false;
            this.motor_on_1.Click += new System.EventHandler(this.motor_on_1_Click);
            // 
            // motor_off_1
            // 
            this.motor_off_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.motor_off_1.Image = global::Capacitor_Bank_System.Properties.Resources.motor_off;
            this.motor_off_1.Location = new System.Drawing.Point(45, 341);
            this.motor_off_1.Name = "motor_off_1";
            this.motor_off_1.Size = new System.Drawing.Size(43, 59);
            this.motor_off_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motor_off_1.TabIndex = 2;
            this.motor_off_1.TabStop = false;
            this.motor_off_1.Click += new System.EventHandler(this.motor_off_1_Click);
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(674, 389);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 2;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Enabled = false;
            this.btn_stop.Location = new System.Drawing.Point(755, 389);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 3;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTimer.Location = new System.Drawing.Point(418, 15);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(19, 21);
            this.lbTimer.TabIndex = 4;
            this.lbTimer.Text = "0";
            // 
            // lbMotor1
            // 
            this.lbMotor1.AutoSize = true;
            this.lbMotor1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMotor1.Location = new System.Drawing.Point(418, 46);
            this.lbMotor1.Name = "lbMotor1";
            this.lbMotor1.Size = new System.Drawing.Size(74, 21);
            this.lbMotor1.TabIndex = 5;
            this.lbMotor1.Text = "Motor 1:";
            // 
            // lbMotor2
            // 
            this.lbMotor2.AutoSize = true;
            this.lbMotor2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMotor2.Location = new System.Drawing.Point(418, 67);
            this.lbMotor2.Name = "lbMotor2";
            this.lbMotor2.Size = new System.Drawing.Size(74, 21);
            this.lbMotor2.TabIndex = 6;
            this.lbMotor2.Text = "Motor 2:";
            // 
            // lbMotor4
            // 
            this.lbMotor4.AutoSize = true;
            this.lbMotor4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMotor4.Location = new System.Drawing.Point(418, 109);
            this.lbMotor4.Name = "lbMotor4";
            this.lbMotor4.Size = new System.Drawing.Size(74, 21);
            this.lbMotor4.TabIndex = 8;
            this.lbMotor4.Text = "Motor 4:";
            // 
            // lbMotor3
            // 
            this.lbMotor3.AutoSize = true;
            this.lbMotor3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMotor3.Location = new System.Drawing.Point(418, 88);
            this.lbMotor3.Name = "lbMotor3";
            this.lbMotor3.Size = new System.Drawing.Size(74, 21);
            this.lbMotor3.TabIndex = 7;
            this.lbMotor3.Text = "Motor 3:";
            // 
            // statusMotor1
            // 
            this.statusMotor1.AutoSize = true;
            this.statusMotor1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusMotor1.Location = new System.Drawing.Point(498, 46);
            this.statusMotor1.Name = "statusMotor1";
            this.statusMotor1.Size = new System.Drawing.Size(48, 21);
            this.statusMotor1.TabIndex = 9;
            this.statusMotor1.Text = "False";
            // 
            // statusMotor2
            // 
            this.statusMotor2.AutoSize = true;
            this.statusMotor2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusMotor2.Location = new System.Drawing.Point(498, 67);
            this.statusMotor2.Name = "statusMotor2";
            this.statusMotor2.Size = new System.Drawing.Size(48, 21);
            this.statusMotor2.TabIndex = 10;
            this.statusMotor2.Text = "False";
            // 
            // statusMotor4
            // 
            this.statusMotor4.AutoSize = true;
            this.statusMotor4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusMotor4.Location = new System.Drawing.Point(498, 109);
            this.statusMotor4.Name = "statusMotor4";
            this.statusMotor4.Size = new System.Drawing.Size(48, 21);
            this.statusMotor4.TabIndex = 12;
            this.statusMotor4.Text = "False";
            // 
            // statusMotor3
            // 
            this.statusMotor3.AutoSize = true;
            this.statusMotor3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusMotor3.Location = new System.Drawing.Point(498, 88);
            this.statusMotor3.Name = "statusMotor3";
            this.statusMotor3.Size = new System.Drawing.Size(48, 21);
            this.statusMotor3.TabIndex = 11;
            this.statusMotor3.Text = "False";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 861);
            this.Controls.Add(this.statusMotor4);
            this.Controls.Add(this.statusMotor3);
            this.Controls.Add(this.statusMotor2);
            this.Controls.Add(this.statusMotor1);
            this.Controls.Add(this.lbMotor4);
            this.Controls.Add(this.lbMotor3);
            this.Controls.Add(this.lbMotor2);
            this.Controls.Add(this.lbMotor1);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.motor_on_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_off_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_on_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_off_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_on_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_off_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_on_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motor_off_1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Panel panel2;
        private Panel panel5;
        private Panel panel3;
        private Panel panel6;
        private System.Windows.Forms.Timer timer1;
        private Button btn_play;
        private Button btn_stop;
        private Label lbTimer;
        private PictureBox motor_off_1;
        private PictureBox motor_on_1;
        private PictureBox motor_on_4;
        private PictureBox motor_off_4;
        private PictureBox motor_on_3;
        private PictureBox motor_off_3;
        private PictureBox motor_on_2;
        private PictureBox motor_off_2;
        private Label lbMotor1;
        private Label lbMotor2;
        private Label lbMotor4;
        private Label lbMotor3;
        private Label statusMotor1;
        private Label statusMotor2;
        private Label statusMotor4;
        private Label statusMotor3;
    }
}