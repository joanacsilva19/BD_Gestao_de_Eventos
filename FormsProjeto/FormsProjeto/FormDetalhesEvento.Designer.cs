namespace FormsProjeto
{
    partial class FormDetalhesEvento
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTopo = new System.Windows.Forms.Panel();
            this.lblInfoEvento = new System.Windows.Forms.Label();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.dgvAtividades = new System.Windows.Forms.DataGridView();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();

            this.pnlTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).BeginInit();
            this.SuspendLayout();

            this.pnlTopo.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
            this.pnlTopo.Controls.Add(this.lblInfoEvento);
            this.pnlTopo.Controls.Add(this.lblPrecoTotal);
            this.pnlTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopo.Height = 70;

            this.lblInfoEvento.AutoSize = true;
            this.lblInfoEvento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblInfoEvento.ForeColor = System.Drawing.Color.White;
            this.lblInfoEvento.Location = new System.Drawing.Point(12, 12);
            this.lblInfoEvento.Text = "Evento Nº ...";

            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPrecoTotal.ForeColor = System.Drawing.Color.LightGreen;
            this.lblPrecoTotal.Location = new System.Drawing.Point(12, 35);
            this.lblPrecoTotal.Text = "TOTAL FINAL: 0,00 €";

            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSubtitulo.Location = new System.Drawing.Point(12, 90);
            this.lblSubtitulo.Text = "Atividades Contratadas:";

            this.dgvAtividades.AllowUserToAddRows = false;
            this.dgvAtividades.AllowUserToDeleteRows = false;
            this.dgvAtividades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtividades.Location = new System.Drawing.Point(16, 120);
            this.dgvAtividades.ReadOnly = true;
            this.dgvAtividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAtividades.Size = new System.Drawing.Size(550, 200);

            this.btnFechar.Location = new System.Drawing.Point(230, 335);
            this.btnFechar.Size = new System.Drawing.Size(120, 35);
            this.btnFechar.Text = "Fechar Janela";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.DialogResult = System.Windows.Forms.DialogResult.OK;

            this.ClientSize = new System.Drawing.Size(580, 390);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.dgvAtividades);
            this.Controls.Add(this.pnlTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalhes do Evento";
            this.Load += new System.EventHandler(this.FormDetalhesEvento_Load);

            this.pnlTopo.ResumeLayout(false);
            this.pnlTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Label lblInfoEvento;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.DataGridView dgvAtividades;
        private System.Windows.Forms.Button btnFechar;
    }
}