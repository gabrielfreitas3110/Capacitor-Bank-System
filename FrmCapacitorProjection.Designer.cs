namespace Capacitor_Bank_System
{
    partial class FrmCapacitorProjection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capacitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPotAp = new System.Windows.Forms.Label();
            this.lbPotReat = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFP = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbPotAtiv = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(627, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.capacitoresToolStripMenuItem,
            this.motoresToolStripMenuItem});
            this.opçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // capacitoresToolStripMenuItem
            // 
            this.capacitoresToolStripMenuItem.Name = "capacitoresToolStripMenuItem";
            this.capacitoresToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.capacitoresToolStripMenuItem.Text = "Capacitores";
            this.capacitoresToolStripMenuItem.Click += new System.EventHandler(this.capacitoresToolStripMenuItem_Click);
            // 
            // motoresToolStripMenuItem
            // 
            this.motoresToolStripMenuItem.Name = "motoresToolStripMenuItem";
            this.motoresToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.motoresToolStripMenuItem.Text = "Motores";
            this.motoresToolStripMenuItem.Click += new System.EventHandler(this.motoresToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Potência Aparente Total:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Potência Reativa Total:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbPotAp
            // 
            this.lbPotAp.AutoSize = true;
            this.lbPotAp.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPotAp.Location = new System.Drawing.Point(259, 87);
            this.lbPotAp.Name = "lbPotAp";
            this.lbPotAp.Size = new System.Drawing.Size(22, 24);
            this.lbPotAp.TabIndex = 3;
            this.lbPotAp.Text = "0";
            this.lbPotAp.Click += new System.EventHandler(this.lbPotAp_Click);
            // 
            // lbPotReat
            // 
            this.lbPotReat.AutoSize = true;
            this.lbPotReat.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPotReat.Location = new System.Drawing.Point(249, 117);
            this.lbPotReat.Name = "lbPotReat";
            this.lbPotReat.Size = new System.Drawing.Size(22, 24);
            this.lbPotReat.TabIndex = 4;
            this.lbPotReat.Text = "0";
            this.lbPotReat.Click += new System.EventHandler(this.lbPotReat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fator de Potência:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbFP
            // 
            this.lbFP.AutoSize = true;
            this.lbFP.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFP.Location = new System.Drawing.Point(205, 147);
            this.lbFP.Name = "lbFP";
            this.lbFP.Size = new System.Drawing.Size(22, 24);
            this.lbFP.TabIndex = 6;
            this.lbFP.Text = "0";
            this.lbFP.Click += new System.EventHandler(this.lbFP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(205, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dados Atuais";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbPotAtiv);
            this.panel1.Controls.Add(this.lbFP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbPotReat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbPotAp);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 210);
            this.panel1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(15, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Potência Ativa Total:";
            // 
            // lbPotAtiv
            // 
            this.lbPotAtiv.AutoSize = true;
            this.lbPotAtiv.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPotAtiv.Location = new System.Drawing.Point(222, 57);
            this.lbPotAtiv.Name = "lbPotAtiv";
            this.lbPotAtiv.Size = new System.Drawing.Size(22, 24);
            this.lbPotAtiv.TabIndex = 9;
            this.lbPotAtiv.Text = "0";
            this.lbPotAtiv.Click += new System.EventHandler(this.lbPotAtiv_Click);
            // 
            // FrmCapacitorProjection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 517);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCapacitorProjection";
            this.Text = "Capacitor Projection";
            this.Load += new System.EventHandler(this.FrmCapacitorProjection_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem motoresToolStripMenuItem;
        private ToolStripMenuItem capacitoresToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label lbPotAp;
        private Label lbPotReat;
        private Label label3;
        private Label lbFP;
        private Label label5;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Label lbPotAtiv;
    }
}