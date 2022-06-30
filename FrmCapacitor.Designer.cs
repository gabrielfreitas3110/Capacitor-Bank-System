namespace Capacitor_Bank_System
{
    partial class FrmCapacitor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capacitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeMotoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioDeCapacitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetarBancoDeCapacitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacitancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtCapacitancia = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTensao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.relatóriosToolStripMenuItem,
            this.projetarBancoDeCapacitoresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeMotoresToolStripMenuItem,
            this.relatórioDeCapacitoresToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // relatórioDeMotoresToolStripMenuItem
            // 
            this.relatórioDeMotoresToolStripMenuItem.Name = "relatórioDeMotoresToolStripMenuItem";
            this.relatórioDeMotoresToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.relatórioDeMotoresToolStripMenuItem.Text = "Relatório de Motores";
            this.relatórioDeMotoresToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeMotoresToolStripMenuItem_Click);
            // 
            // relatórioDeCapacitoresToolStripMenuItem
            // 
            this.relatórioDeCapacitoresToolStripMenuItem.Name = "relatórioDeCapacitoresToolStripMenuItem";
            this.relatórioDeCapacitoresToolStripMenuItem.Size = new System.Drawing.Size(242, 24);
            this.relatórioDeCapacitoresToolStripMenuItem.Text = "Relatório de Capacitores";
            this.relatórioDeCapacitoresToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeCapacitoresToolStripMenuItem_Click);
            // 
            // projetarBancoDeCapacitoresToolStripMenuItem
            // 
            this.projetarBancoDeCapacitoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.projetarBancoDeCapacitoresToolStripMenuItem.Name = "projetarBancoDeCapacitoresToolStripMenuItem";
            this.projetarBancoDeCapacitoresToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.projetarBancoDeCapacitoresToolStripMenuItem.Text = "Projetar Banco de Capacitores";
            this.projetarBancoDeCapacitoresToolStripMenuItem.Click += new System.EventHandler(this.projetarBancoDeCapacitoresToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tipo,
            this.Capacitancia,
            this.Tensao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(760, 420);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tipo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Capacitancia
            // 
            this.Capacitancia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Capacitancia.DefaultCellStyle = dataGridViewCellStyle3;
            this.Capacitancia.HeaderText = "Capacitância (uF)";
            this.Capacitancia.Name = "Capacitancia";
            this.Capacitancia.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tensao
            // 
            this.Tensao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft PhagsPa", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tensao.DefaultCellStyle = dataGridViewCellStyle4;
            this.Tensao.HeaderText = "Tensão de Operação (V)";
            this.Tensao.Name = "Tensao";
            this.Tensao.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Arial Narrow", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnInserir.Location = new System.Drawing.Point(689, 457);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(83, 37);
            this.btnInserir.TabIndex = 22;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtCapacitancia
            // 
            this.txtCapacitancia.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCapacitancia.Location = new System.Drawing.Point(201, 491);
            this.txtCapacitancia.Name = "txtCapacitancia";
            this.txtCapacitancia.Size = new System.Drawing.Size(100, 26);
            this.txtCapacitancia.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 24);
            this.label9.TabIndex = 31;
            this.label9.Text = "Capacitância (uF):";
            // 
            // txtTensao
            // 
            this.txtTensao.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTensao.Location = new System.Drawing.Point(440, 459);
            this.txtTensao.Name = "txtTensao";
            this.txtTensao.Size = new System.Drawing.Size(100, 26);
            this.txtTensao.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(249, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tensão de Op. (V):";
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTipo.Location = new System.Drawing.Point(73, 459);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(170, 26);
            this.txtTipo.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tipo:";
            // 
            // FrmCapacitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 531);
            this.Controls.Add(this.txtCapacitancia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTensao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCapacitor";
            this.Text = "Capacitor Especification";
            this.Load += new System.EventHandler(this.FrmCapacitor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private ToolStripMenuItem motoresToolStripMenuItem;
        private ToolStripMenuItem capacitoresToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem relatórioDeMotoresToolStripMenuItem;
        private ToolStripMenuItem relatórioDeCapacitoresToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button btnInserir;
        private TextBox txtCapacitancia;
        private Label label9;
        private TextBox txtTensao;
        private Label label3;
        protected TextBox txtTipo;
        private Label label2;
        private ToolStripMenuItem projetarBancoDeCapacitoresToolStripMenuItem;
        private SaveFileDialog saveFileDialog1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Capacitancia;
        private DataGridViewTextBoxColumn Tensao;
    }
}