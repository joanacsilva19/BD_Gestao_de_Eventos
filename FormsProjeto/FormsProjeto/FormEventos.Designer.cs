namespace FormsProjeto
{
    partial class FormEventos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTituloTopo = new System.Windows.Forms.Label();
            this.lblClienteInfo = new System.Windows.Forms.Label();
            this.lblLocal = new System.Windows.Forms.Label();
            this.cmbLocais = new System.Windows.Forms.ComboBox();
            this.lblTipoEvento = new System.Windows.Forms.Label();
            this.cmbTipoEvento = new System.Windows.Forms.ComboBox();
            this.lblParticipantes = new System.Windows.Forms.Label();
            this.numParticipantes = new System.Windows.Forms.NumericUpDown();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFim = new System.Windows.Forms.Label();
            this.dtpFim = new System.Windows.Forms.DateTimePicker();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.numDuracao = new System.Windows.Forms.NumericUpDown();
            this.btnSeguinte = new System.Windows.Forms.Button();

            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).BeginInit();
            this.SuspendLayout();

            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlTopo.Controls.Add(this.lblTituloTopo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Location = new System.Drawing.Point(0, 0);
            this.pnlTopo.Name = "pnlTopo";
            this.pnlTopo.Size = new System.Drawing.Size(430, 50);
            this.pnlTopo.TabIndex = 14;

            this.lblTituloTopo.AutoSize = true;
            this.lblTituloTopo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTituloTopo.ForeColor = System.Drawing.Color.White;
            this.lblTituloTopo.Location = new System.Drawing.Point(12, 12);
            this.lblTituloTopo.Name = "lblTituloTopo";
            this.lblTituloTopo.Size = new System.Drawing.Size(262, 25);
            this.lblTituloTopo.TabIndex = 0;
            this.lblTituloTopo.Text = "Passo 2: Detalhes do Evento";

            this.lblClienteInfo.AutoSize = true;
            this.lblClienteInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblClienteInfo.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblClienteInfo.Location = new System.Drawing.Point(20, 70); // Descido 50px
            this.lblClienteInfo.Name = "lblClienteInfo";
            this.lblClienteInfo.Size = new System.Drawing.Size(155, 20);
            this.lblClienteInfo.TabIndex = 0;
            this.lblClienteInfo.Text = "Cliente Selecionado: ";

            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocal.Location = new System.Drawing.Point(20, 120);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(95, 15);
            this.lblLocal.TabIndex = 1;
            this.lblLocal.Text = "Local do Evento:";

            this.cmbLocais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbLocais.FormattingEnabled = true;
            this.cmbLocais.Location = new System.Drawing.Point(140, 117);
            this.cmbLocais.Name = "cmbLocais";
            this.cmbLocais.Size = new System.Drawing.Size(250, 23);
            this.cmbLocais.TabIndex = 2;

            this.lblTipoEvento.AutoSize = true;
            this.lblTipoEvento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTipoEvento.Location = new System.Drawing.Point(20, 160);
            this.lblTipoEvento.Name = "lblTipoEvento";
            this.lblTipoEvento.Size = new System.Drawing.Size(90, 15);
            this.lblTipoEvento.TabIndex = 3;
            this.lblTipoEvento.Text = "Tipo de Evento:";

            this.cmbTipoEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoEvento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTipoEvento.FormattingEnabled = true;
            this.cmbTipoEvento.Location = new System.Drawing.Point(140, 157);
            this.cmbTipoEvento.Name = "cmbTipoEvento";
            this.cmbTipoEvento.Size = new System.Drawing.Size(250, 23);
            this.cmbTipoEvento.TabIndex = 4;

            this.lblParticipantes.AutoSize = true;
            this.lblParticipantes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblParticipantes.Location = new System.Drawing.Point(20, 200);
            this.lblParticipantes.Name = "lblParticipantes";
            this.lblParticipantes.Size = new System.Drawing.Size(95, 15);
            this.lblParticipantes.TabIndex = 5;
            this.lblParticipantes.Text = "Nº Participantes:";

            this.numParticipantes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numParticipantes.Location = new System.Drawing.Point(140, 198);
            this.numParticipantes.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            this.numParticipantes.Name = "numParticipantes";
            this.numParticipantes.Size = new System.Drawing.Size(100, 23);
            this.numParticipantes.TabIndex = 6;

            this.lblInicio.AutoSize = true;
            this.lblInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInicio.Location = new System.Drawing.Point(20, 240);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(68, 15);
            this.lblInicio.TabIndex = 7;
            this.lblInicio.Text = "Data Início:";
 
            this.dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(140, 237);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 23);
            this.dtpInicio.TabIndex = 8;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);

            this.lblFim.AutoSize = true;
            this.lblFim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFim.Location = new System.Drawing.Point(20, 280);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(57, 15);
            this.lblFim.TabIndex = 9;
            this.lblFim.Text = "Data Fim:";

            this.dtpFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFim.Location = new System.Drawing.Point(140, 277);
            this.dtpFim.Name = "dtpFim";
            this.dtpFim.Size = new System.Drawing.Size(200, 23);
            this.dtpFim.TabIndex = 10;

            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDuracao.Location = new System.Drawing.Point(20, 320);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(95, 15);
            this.lblDuracao.TabIndex = 11;
            this.lblDuracao.Text = "Duração (Horas):";

            this.numDuracao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numDuracao.Location = new System.Drawing.Point(140, 318);
            this.numDuracao.Maximum = new decimal(new int[] { 720, 0, 0, 0 });
            this.numDuracao.Name = "numDuracao";
            this.numDuracao.Size = new System.Drawing.Size(100, 23);
            this.numDuracao.TabIndex = 12;
            this.numDuracao.ValueChanged += new System.EventHandler(this.numDuracao_ValueChanged);
 
            this.btnSeguinte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSeguinte.FlatAppearance.BorderSize = 0;
            this.btnSeguinte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeguinte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeguinte.ForeColor = System.Drawing.Color.White;
            this.btnSeguinte.Location = new System.Drawing.Point(140, 360);
            this.btnSeguinte.Name = "btnSeguinte";
            this.btnSeguinte.Size = new System.Drawing.Size(150, 40);
            this.btnSeguinte.TabIndex = 13;
            this.btnSeguinte.Text = "Seguinte ➔";
            this.btnSeguinte.UseVisualStyleBackColor = false;
            this.btnSeguinte.Click += new System.EventHandler(this.btnSeguinte_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(430, 430); // Aumentado para acomodar o painel extra
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.btnSeguinte);
            this.Controls.Add(this.numDuracao);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.dtpFim);
            this.Controls.Add(this.lblFim);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.numParticipantes);
            this.Controls.Add(this.lblParticipantes);
            this.Controls.Add(this.cmbTipoEvento);
            this.Controls.Add(this.lblTipoEvento);
            this.Controls.Add(this.cmbLocais);
            this.Controls.Add(this.lblLocal);
            this.Controls.Add(this.lblClienteInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEventos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento - Detalhes do Evento";
            this.Load += new System.EventHandler(this.FormEventos_Load);

            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTituloTopo;
        private System.Windows.Forms.Label lblClienteInfo;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.ComboBox cmbLocais;
        private System.Windows.Forms.Label lblTipoEvento;
        private System.Windows.Forms.ComboBox cmbTipoEvento;
        private System.Windows.Forms.Label lblParticipantes;
        private System.Windows.Forms.NumericUpDown numParticipantes;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.DateTimePicker dtpFim;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.NumericUpDown numDuracao;
        private System.Windows.Forms.Button btnSeguinte;
    }
}