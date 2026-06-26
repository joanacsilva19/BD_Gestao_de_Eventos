namespace FormsProjeto
{
    partial class FormAtividade
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblTituloTopo = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAdicionarCarrinho = new System.Windows.Forms.Button();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.lblPrecoLocal = new System.Windows.Forms.Label();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.btnFinalizarEvento = new System.Windows.Forms.Button();

            this.pnlMusica = new System.Windows.Forms.Panel();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.cmbCatMusica = new System.Windows.Forms.ComboBox();
            this.numMusicaHoras = new System.Windows.Forms.NumericUpDown();

            this.pnlFotografia = new System.Windows.Forms.Panel();
            this.numSessoes = new System.Windows.Forms.NumericUpDown();
            this.cmbAlturaDia = new System.Windows.Forms.ComboBox();
            this.numPrecoFotografia = new System.Windows.Forms.NumericUpDown();

            this.pnlAnimacao = new System.Windows.Forms.Panel();
            this.cmbCatAnimacao = new System.Windows.Forms.ComboBox();
            this.numAnimacaoHoras = new System.Windows.Forms.NumericUpDown();
            this.numAnimadores = new System.Windows.Forms.NumericUpDown();

            this.pnlCatering = new System.Windows.Forms.Panel();
            this.cmbCatCatering = new System.Windows.Forms.ComboBox();

            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();

            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.pnlTopo.Controls.Add(this.lblTituloTopo);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Height = 50;
            this.lblTituloTopo.AutoSize = true;
            this.lblTituloTopo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTituloTopo.ForeColor = System.Drawing.Color.White;
            this.lblTituloTopo.Location = new System.Drawing.Point(12, 12);
            this.lblTituloTopo.Text = "Passo 3: Configurar Atividades";

            this.lblCategoria.Location = new System.Drawing.Point(20, 70);
            this.lblCategoria.Text = "Categoria:";
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.Location = new System.Drawing.Point(20, 90);
            this.cmbCategoria.Size = new System.Drawing.Size(220, 23);
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);

            this.pnlMusica.Location = new System.Drawing.Point(20, 120);
            this.pnlMusica.Size = new System.Drawing.Size(220, 150);
            this.cmbSubCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubCategoria.Location = new System.Drawing.Point(0, 0);
            this.cmbSubCategoria.Size = new System.Drawing.Size(220, 23);
            this.cmbSubCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbSubCategoria_SelectedIndexChanged);
            this.cmbCatMusica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatMusica.Location = new System.Drawing.Point(0, 30);
            this.cmbCatMusica.Size = new System.Drawing.Size(220, 23);
            this.numMusicaHoras.Location = new System.Drawing.Point(0, 60);
            this.numMusicaHoras.Size = new System.Drawing.Size(100, 23);
            this.pnlMusica.Controls.Add(this.cmbSubCategoria);
            this.pnlMusica.Controls.Add(this.cmbCatMusica);
            this.pnlMusica.Controls.Add(new System.Windows.Forms.Label { Text = "Horas:", Location = new System.Drawing.Point(110, 62), AutoSize = true });
            this.pnlMusica.Controls.Add(this.numMusicaHoras);
            this.pnlMusica.Visible = false;

            this.pnlFotografia.Location = new System.Drawing.Point(20, 120);
            this.pnlFotografia.Size = new System.Drawing.Size(220, 150);
            this.numSessoes.Location = new System.Drawing.Point(0, 0);
            this.numSessoes.Size = new System.Drawing.Size(100, 23);
            this.cmbAlturaDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlturaDia.Location = new System.Drawing.Point(0, 30);
            this.cmbAlturaDia.Size = new System.Drawing.Size(220, 23);
            this.numPrecoFotografia.Location = new System.Drawing.Point(0, 60);
            this.numPrecoFotografia.Size = new System.Drawing.Size(100, 23);
            this.numPrecoFotografia.DecimalPlaces = 2;
            this.pnlFotografia.Controls.Add(new System.Windows.Forms.Label { Text = "Sessões:", Location = new System.Drawing.Point(110, 2), AutoSize = true });
            this.pnlFotografia.Controls.Add(this.numSessoes);
            this.pnlFotografia.Controls.Add(this.cmbAlturaDia);
            this.pnlFotografia.Controls.Add(new System.Windows.Forms.Label { Text = "Preço/Sessão:", Location = new System.Drawing.Point(110, 62), AutoSize = true });
            this.pnlFotografia.Controls.Add(this.numPrecoFotografia);
            this.pnlFotografia.Visible = false;

            this.pnlAnimacao.Location = new System.Drawing.Point(20, 120);
            this.pnlAnimacao.Size = new System.Drawing.Size(220, 150);
            this.cmbCatAnimacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatAnimacao.Location = new System.Drawing.Point(0, 0);
            this.cmbCatAnimacao.Size = new System.Drawing.Size(220, 23);
            this.numAnimacaoHoras.Location = new System.Drawing.Point(0, 30);
            this.numAnimacaoHoras.Size = new System.Drawing.Size(100, 23);
            this.numAnimadores.Location = new System.Drawing.Point(0, 60);
            this.numAnimadores.Size = new System.Drawing.Size(100, 23);
            this.pnlAnimacao.Controls.Add(this.cmbCatAnimacao);
            this.pnlAnimacao.Controls.Add(new System.Windows.Forms.Label { Text = "Horas:", Location = new System.Drawing.Point(110, 32), AutoSize = true });
            this.pnlAnimacao.Controls.Add(this.numAnimacaoHoras);
            this.pnlAnimacao.Controls.Add(new System.Windows.Forms.Label { Text = "Animadores:", Location = new System.Drawing.Point(110, 62), AutoSize = true });
            this.pnlAnimacao.Controls.Add(this.numAnimadores);
            this.pnlAnimacao.Visible = false;

            this.pnlCatering.Location = new System.Drawing.Point(20, 120);
            this.pnlCatering.Size = new System.Drawing.Size(220, 150);
            this.cmbCatCatering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCatCatering.Location = new System.Drawing.Point(0, 0);
            this.cmbCatCatering.Size = new System.Drawing.Size(220, 23);
            this.pnlCatering.Controls.Add(this.cmbCatCatering);
            this.pnlCatering.Visible = false;

            this.btnAdicionarCarrinho.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.btnAdicionarCarrinho.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarCarrinho.Location = new System.Drawing.Point(20, 280);
            this.btnAdicionarCarrinho.Size = new System.Drawing.Size(220, 40);
            this.btnAdicionarCarrinho.Text = "Adicionar Atividade";
            this.btnAdicionarCarrinho.Click += new System.EventHandler(this.btnAdicionarCarrinho_Click);

            this.dgvCarrinho.Location = new System.Drawing.Point(260, 90);
            this.dgvCarrinho.Size = new System.Drawing.Size(510, 230);
            this.dgvCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.lblPrecoLocal.Location = new System.Drawing.Point(260, 340);
            this.lblPrecoLocal.AutoSize = true;
            this.lblPrecoTotal.Location = new System.Drawing.Point(260, 370);
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPrecoTotal.ForeColor = System.Drawing.Color.DarkGreen;

            this.btnFinalizarEvento.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFinalizarEvento.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarEvento.Location = new System.Drawing.Point(590, 350);
            this.btnFinalizarEvento.Size = new System.Drawing.Size(180, 45);
            this.btnFinalizarEvento.Text = "Finalizar Evento ✔";
            this.btnFinalizarEvento.Click += new System.EventHandler(this.btnFinalizarEvento_Click);

            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.pnlTopo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.pnlMusica);
            this.Controls.Add(this.pnlFotografia);
            this.Controls.Add(this.pnlAnimacao);
            this.Controls.Add(this.pnlCatering);
            this.Controls.Add(this.btnAdicionarCarrinho);
            this.Controls.Add(this.dgvCarrinho);
            this.Controls.Add(this.lblPrecoLocal);
            this.Controls.Add(this.lblPrecoTotal);
            this.Controls.Add(this.btnFinalizarEvento);
            this.Load += new System.EventHandler(this.FormAtividade_Load);

            this.pnlTopo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblTituloTopo;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;

        private System.Windows.Forms.Panel pnlMusica;
        private System.Windows.Forms.ComboBox cmbSubCategoria;
        private System.Windows.Forms.ComboBox cmbCatMusica;
        private System.Windows.Forms.NumericUpDown numMusicaHoras;

        private System.Windows.Forms.Panel pnlFotografia;
        private System.Windows.Forms.NumericUpDown numSessoes;
        private System.Windows.Forms.ComboBox cmbAlturaDia;
        private System.Windows.Forms.NumericUpDown numPrecoFotografia;

        private System.Windows.Forms.Panel pnlAnimacao;
        private System.Windows.Forms.ComboBox cmbCatAnimacao;
        private System.Windows.Forms.NumericUpDown numAnimacaoHoras;
        private System.Windows.Forms.NumericUpDown numAnimadores;

        private System.Windows.Forms.Panel pnlCatering;
        private System.Windows.Forms.ComboBox cmbCatCatering;

        private System.Windows.Forms.Button btnAdicionarCarrinho;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Label lblPrecoLocal;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Button btnFinalizarEvento;
    }
}