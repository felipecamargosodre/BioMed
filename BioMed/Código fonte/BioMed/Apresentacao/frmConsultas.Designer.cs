namespace BioMed.Apresentacao
{
    partial class frmConsultas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.picMinimizar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlRodape = new System.Windows.Forms.Panel();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.cdrDia = new System.Windows.Forms.MonthCalendar();
            this.cmbExame = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picProcurar = new System.Windows.Forms.PictureBox();
            this.lblProcurar = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picSalvar = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLimpar = new System.Windows.Forms.PictureBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.pnlBarra.Controls.Add(this.picMinimizar);
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(700, 20);
            this.pnlBarra.TabIndex = 4;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            this.pnlBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseMove);
            this.pnlBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseUp);
            // 
            // picMinimizar
            // 
            this.picMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.picMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinimizar.BackgroundImage")));
            this.picMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picMinimizar.Location = new System.Drawing.Point(660, 2);
            this.picMinimizar.Name = "picMinimizar";
            this.picMinimizar.Size = new System.Drawing.Size(15, 15);
            this.picMinimizar.TabIndex = 6;
            this.picMinimizar.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(680, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pnlRodape
            // 
            this.pnlRodape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.pnlRodape.Location = new System.Drawing.Point(0, 585);
            this.pnlRodape.Name = "pnlRodape";
            this.pnlRodape.Size = new System.Drawing.Size(700, 15);
            this.pnlRodape.TabIndex = 13;
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvPacientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPacientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPacientes.GridColor = System.Drawing.Color.Black;
            this.dgvPacientes.Location = new System.Drawing.Point(37, 126);
            this.dgvPacientes.Name = "dgvPacientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPacientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPacientes.Size = new System.Drawing.Size(626, 150);
            this.dgvPacientes.TabIndex = 403;
            this.dgvPacientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacientes_CellClick);
            // 
            // txbNome
            // 
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNome.ForeColor = System.Drawing.Color.Black;
            this.txbNome.Location = new System.Drawing.Point(210, 26);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(316, 19);
            this.txbNome.TabIndex = 404;
            // 
            // cdrDia
            // 
            this.cdrDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdrDia.Location = new System.Drawing.Point(40, 318);
            this.cdrDia.Name = "cdrDia";
            this.cdrDia.TabIndex = 407;
            this.cdrDia.TitleBackColor = System.Drawing.Color.Black;
            this.cdrDia.TitleForeColor = System.Drawing.Color.Maroon;
            this.cdrDia.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cdrDia_DateChanged);
            // 
            // cmbExame
            // 
            this.cmbExame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbExame.FormattingEnabled = true;
            this.cmbExame.Items.AddRange(new object[] {
            "Bioquímica",
            "Hematologia",
            "Imunologia",
            "Microbiologia",
            "Parasitologia",
            "Urinálise"});
            this.cmbExame.Location = new System.Drawing.Point(297, 318);
            this.cmbExame.Name = "cmbExame";
            this.cmbExame.Size = new System.Drawing.Size(133, 28);
            this.cmbExame.TabIndex = 410;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(33, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 22);
            this.label1.TabIndex = 411;
            this.label1.Text = "Paciente selecionado";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(247, 284);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 18);
            this.lblNome.TabIndex = 412;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.panel2.Controls.Add(this.picProcurar);
            this.panel2.Controls.Add(this.lblProcurar);
            this.panel2.Controls.Add(this.txbNome);
            this.panel2.Location = new System.Drawing.Point(40, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 73);
            this.panel2.TabIndex = 415;
            // 
            // picProcurar
            // 
            this.picProcurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProcurar.BackgroundImage")));
            this.picProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProcurar.Location = new System.Drawing.Point(534, 21);
            this.picProcurar.Name = "picProcurar";
            this.picProcurar.Size = new System.Drawing.Size(30, 30);
            this.picProcurar.TabIndex = 416;
            this.picProcurar.TabStop = false;
            this.picProcurar.Click += new System.EventHandler(this.picProcurar_Click);
            // 
            // lblProcurar
            // 
            this.lblProcurar.AutoSize = true;
            this.lblProcurar.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurar.ForeColor = System.Drawing.Color.White;
            this.lblProcurar.Location = new System.Drawing.Point(56, 26);
            this.lblProcurar.Name = "lblProcurar";
            this.lblProcurar.Size = new System.Drawing.Size(150, 19);
            this.lblProcurar.TabIndex = 416;
            this.lblProcurar.Text = "Nome do paciente";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.panel3.Location = new System.Drawing.Point(37, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 2);
            this.panel3.TabIndex = 402;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.panel4.Location = new System.Drawing.Point(37, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 223);
            this.panel4.TabIndex = 403;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.panel5.Location = new System.Drawing.Point(660, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 220);
            this.panel5.TabIndex = 404;
            // 
            // picSalvar
            // 
            this.picSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSalvar.BackgroundImage")));
            this.picSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSalvar.Location = new System.Drawing.Point(83, 499);
            this.picSalvar.Name = "picSalvar";
            this.picSalvar.Size = new System.Drawing.Size(75, 75);
            this.picSalvar.TabIndex = 405;
            this.picSalvar.TabStop = false;
            this.picSalvar.Click += new System.EventHandler(this.picSalvar_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.panel6.Location = new System.Drawing.Point(38, 276);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(625, 3);
            this.panel6.TabIndex = 404;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.panel1.Location = new System.Drawing.Point(37, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 2);
            this.panel1.TabIndex = 403;
            // 
            // picLimpar
            // 
            this.picLimpar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLimpar.BackgroundImage")));
            this.picLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLimpar.Location = new System.Drawing.Point(538, 499);
            this.picLimpar.Name = "picLimpar";
            this.picLimpar.Size = new System.Drawing.Size(75, 75);
            this.picLimpar.TabIndex = 416;
            this.picLimpar.TabStop = false;
            this.picLimpar.Click += new System.EventHandler(this.picLimpar_Click);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.picLimpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.picSalvar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbExame);
            this.Controls.Add(this.cdrDia);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.pnlRodape);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConsultas";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSalvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.PictureBox picMinimizar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnlRodape;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.MonthCalendar cdrDia;
        private System.Windows.Forms.ComboBox cmbExame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProcurar;
        private System.Windows.Forms.PictureBox picProcurar;
        private System.Windows.Forms.PictureBox picSalvar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picLimpar;
    }
}