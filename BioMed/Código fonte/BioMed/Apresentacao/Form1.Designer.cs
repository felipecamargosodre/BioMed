namespace BioMed
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnlBarra = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picDesbloqueio = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picLogOut = new System.Windows.Forms.PictureBox();
            this.pnlBotao = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.picProcurar = new System.Windows.Forms.PictureBox();
            this.picAgendamento = new System.Windows.Forms.PictureBox();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.pnlPrincipal = new System.Windows.Forms.Panel();
            this.tmrPrincipal = new System.Windows.Forms.Timer(this.components);
            this.tmrBotao = new System.Windows.Forms.Timer(this.components);
            this.tmrCircular = new System.Windows.Forms.Timer(this.components);
            this.tmrHora = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.pnlHora = new System.Windows.Forms.Panel();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblApresentacao = new System.Windows.Forms.Label();
            this.pnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesbloqueio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).BeginInit();
            this.pnlBotao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgendamento)).BeginInit();
            this.pnlPrincipal.SuspendLayout();
            this.pnlHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBarra
            // 
            this.pnlBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.pnlBarra.Controls.Add(this.pictureBox4);
            this.pnlBarra.Controls.Add(this.pictureBox1);
            this.pnlBarra.Controls.Add(this.pictureBox2);
            this.pnlBarra.Location = new System.Drawing.Point(0, 0);
            this.pnlBarra.Name = "pnlBarra";
            this.pnlBarra.Size = new System.Drawing.Size(500, 25);
            this.pnlBarra.TabIndex = 4;
            this.pnlBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseDown);
            this.pnlBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseMove);
            this.pnlBarra.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlBarra_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(480, 4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 15);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(580, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(560, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // picDesbloqueio
            // 
            this.picDesbloqueio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picDesbloqueio.BackgroundImage")));
            this.picDesbloqueio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDesbloqueio.Location = new System.Drawing.Point(195, 65);
            this.picDesbloqueio.Name = "picDesbloqueio";
            this.picDesbloqueio.Size = new System.Drawing.Size(110, 110);
            this.picDesbloqueio.TabIndex = 9;
            this.picDesbloqueio.TabStop = false;
            this.picDesbloqueio.Click += new System.EventHandler(this.picDesbloqueio_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(460, 4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(15, 15);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.picHome.Location = new System.Drawing.Point(0, 20);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(250, 80);
            this.picHome.TabIndex = 11;
            this.picHome.TabStop = false;
            // 
            // picLogOut
            // 
            this.picLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(83)))));
            this.picLogOut.Location = new System.Drawing.Point(250, 20);
            this.picLogOut.Name = "picLogOut";
            this.picLogOut.Size = new System.Drawing.Size(250, 80);
            this.picLogOut.TabIndex = 12;
            this.picLogOut.TabStop = false;
            this.picLogOut.Click += new System.EventHandler(this.picLogOut_Click);
            // 
            // pnlBotao
            // 
            this.pnlBotao.Controls.Add(this.label1);
            this.pnlBotao.Controls.Add(this.lblInicio);
            this.pnlBotao.Controls.Add(this.picHome);
            this.pnlBotao.Controls.Add(this.picLogOut);
            this.pnlBotao.Location = new System.Drawing.Point(0, 370);
            this.pnlBotao.Name = "pnlBotao";
            this.pnlBotao.Size = new System.Drawing.Size(500, 100);
            this.pnlBotao.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(83)))));
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = "Deslogar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.lblInicio.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.ForeColor = System.Drawing.Color.White;
            this.lblInicio.Location = new System.Drawing.Point(75, 44);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(94, 32);
            this.lblInicio.TabIndex = 14;
            this.lblInicio.Text = "Inicial";
            // 
            // picProcurar
            // 
            this.picProcurar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picProcurar.BackgroundImage")));
            this.picProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picProcurar.Location = new System.Drawing.Point(125, 4);
            this.picProcurar.Name = "picProcurar";
            this.picProcurar.Size = new System.Drawing.Size(110, 110);
            this.picProcurar.TabIndex = 15;
            this.picProcurar.TabStop = false;
            this.picProcurar.Click += new System.EventHandler(this.picProcurar_Click);
            // 
            // picAgendamento
            // 
            this.picAgendamento.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAgendamento.BackgroundImage")));
            this.picAgendamento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAgendamento.Location = new System.Drawing.Point(265, 4);
            this.picAgendamento.Name = "picAgendamento";
            this.picAgendamento.Size = new System.Drawing.Size(110, 110);
            this.picAgendamento.TabIndex = 16;
            this.picAgendamento.TabStop = false;
            this.picAgendamento.Click += new System.EventHandler(this.picAgendamento_Click);
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.pnlUsuario.Location = new System.Drawing.Point(115, 146);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(270, 3);
            this.pnlUsuario.TabIndex = 17;
            // 
            // pnlPrincipal
            // 
            this.pnlPrincipal.Controls.Add(this.pnlUsuario);
            this.pnlPrincipal.Controls.Add(this.picProcurar);
            this.pnlPrincipal.Controls.Add(this.picAgendamento);
            this.pnlPrincipal.Location = new System.Drawing.Point(490, 65);
            this.pnlPrincipal.Name = "pnlPrincipal";
            this.pnlPrincipal.Size = new System.Drawing.Size(500, 153);
            this.pnlPrincipal.TabIndex = 18;
            // 
            // tmrPrincipal
            // 
            this.tmrPrincipal.Interval = 10;
            this.tmrPrincipal.Tick += new System.EventHandler(this.tmrPrincipal_Tick);
            // 
            // tmrBotao
            // 
            this.tmrBotao.Interval = 10;
            this.tmrBotao.Tick += new System.EventHandler(this.tmrBotao_Tick);
            // 
            // tmrCircular
            // 
            this.tmrCircular.Interval = 10;
            this.tmrCircular.Tick += new System.EventHandler(this.tmrCircular_Tick);
            // 
            // tmrHora
            // 
            this.tmrHora.Enabled = true;
            this.tmrHora.Interval = 1000;
            this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.White;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(309, 4);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.circularProgressBar1.OuterMargin = -10;
            this.circularProgressBar1.OuterWidth = 10;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(206)))), ((int)(((byte)(83)))));
            this.circularProgressBar1.ProgressWidth = 10;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(70, 70);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 19;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 60;
            // 
            // pnlHora
            // 
            this.pnlHora.Controls.Add(this.lblSegundos);
            this.pnlHora.Controls.Add(this.lblHora);
            this.pnlHora.Controls.Add(this.circularProgressBar1);
            this.pnlHora.Location = new System.Drawing.Point(420, 225);
            this.pnlHora.Name = "pnlHora";
            this.pnlHora.Size = new System.Drawing.Size(500, 79);
            this.pnlHora.TabIndex = 20;
            // 
            // lblSegundos
            // 
            this.lblSegundos.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundos.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.lblSegundos.Location = new System.Drawing.Point(328, 28);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(35, 25);
            this.lblSegundos.TabIndex = 22;
            this.lblSegundos.Text = "25";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Arial", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(141)))), ((int)(((byte)(78)))));
            this.lblHora.Location = new System.Drawing.Point(97, 14);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(132, 51);
            this.lblHora.TabIndex = 21;
            this.lblHora.Text = "00:00";
            // 
            // lblApresentacao
            // 
            this.lblApresentacao.AutoSize = true;
            this.lblApresentacao.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblApresentacao.Location = new System.Drawing.Point(167, 186);
            this.lblApresentacao.Name = "lblApresentacao";
            this.lblApresentacao.Size = new System.Drawing.Size(166, 32);
            this.lblApresentacao.TabIndex = 28;
            this.lblApresentacao.Text = "Bem vindo!";
            this.lblApresentacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lblApresentacao);
            this.Controls.Add(this.pnlHora);
            this.Controls.Add(this.pnlPrincipal);
            this.Controls.Add(this.picDesbloqueio);
            this.Controls.Add(this.pnlBotao);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDesbloqueio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogOut)).EndInit();
            this.pnlBotao.ResumeLayout(false);
            this.pnlBotao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProcurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgendamento)).EndInit();
            this.pnlPrincipal.ResumeLayout(false);
            this.pnlHora.ResumeLayout(false);
            this.pnlHora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picDesbloqueio;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picLogOut;
        private System.Windows.Forms.Panel pnlBotao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox picProcurar;
        private System.Windows.Forms.PictureBox picAgendamento;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Panel pnlPrincipal;
        private System.Windows.Forms.Timer tmrPrincipal;
        private System.Windows.Forms.Timer tmrBotao;
        private System.Windows.Forms.Timer tmrCircular;
        private System.Windows.Forms.Timer tmrHora;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Panel pnlHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.Label lblApresentacao;
    }
}

