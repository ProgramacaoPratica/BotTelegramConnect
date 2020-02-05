namespace BotTelegramConnect
{
    partial class FrmEnvioComTemporizador
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbMensagens = new System.Windows.Forms.ListBox();
            this.btnCarregarMenagens = new System.Windows.Forms.Button();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.prbStatusEnvio = new System.Windows.Forms.ProgressBar();
            this.lblStatusEnvio = new System.Windows.Forms.Label();
            this.timerControle = new System.Windows.Forms.Timer(this.components);
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagens:";
            // 
            // lbMensagens
            // 
            this.lbMensagens.FormattingEnabled = true;
            this.lbMensagens.ItemHeight = 16;
            this.lbMensagens.Location = new System.Drawing.Point(27, 42);
            this.lbMensagens.Name = "lbMensagens";
            this.lbMensagens.Size = new System.Drawing.Size(888, 308);
            this.lbMensagens.TabIndex = 1;
            // 
            // btnCarregarMenagens
            // 
            this.btnCarregarMenagens.Location = new System.Drawing.Point(494, 359);
            this.btnCarregarMenagens.Name = "btnCarregarMenagens";
            this.btnCarregarMenagens.Size = new System.Drawing.Size(203, 41);
            this.btnCarregarMenagens.TabIndex = 2;
            this.btnCarregarMenagens.Text = "Carregar Mensagens";
            this.btnCarregarMenagens.UseVisualStyleBackColor = true;
            this.btnCarregarMenagens.Click += new System.EventHandler(this.btnCarregarMenagens_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(712, 359);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(203, 41);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar Mensagens";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status de Envio:";
            // 
            // prbStatusEnvio
            // 
            this.prbStatusEnvio.Location = new System.Drawing.Point(27, 414);
            this.prbStatusEnvio.Name = "prbStatusEnvio";
            this.prbStatusEnvio.Size = new System.Drawing.Size(888, 50);
            this.prbStatusEnvio.TabIndex = 5;
            // 
            // lblStatusEnvio
            // 
            this.lblStatusEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusEnvio.Location = new System.Drawing.Point(24, 467);
            this.lblStatusEnvio.Name = "lblStatusEnvio";
            this.lblStatusEnvio.Size = new System.Drawing.Size(891, 25);
            this.lblStatusEnvio.TabIndex = 6;
            this.lblStatusEnvio.Text = "Aguardando Envio...";
            this.lblStatusEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTempo
            // 
            this.txtTempo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTempo.Location = new System.Drawing.Point(851, 14);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(64, 22);
            this.txtTempo.TabIndex = 7;
            this.txtTempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTempo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(786, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tempo:";
            // 
            // FrmEnvioComTemporizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 503);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStatusEnvio);
            this.Controls.Add(this.prbStatusEnvio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnCarregarMenagens);
            this.Controls.Add(this.lbMensagens);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioComTemporizador";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mensagens com Temporizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbMensagens;
        private System.Windows.Forms.Button btnCarregarMenagens;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar prbStatusEnvio;
        private System.Windows.Forms.Label lblStatusEnvio;
        private System.Windows.Forms.Timer timerControle;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label3;
    }
}