using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class FormEventos : Form
    {
        private NovoEvento evento;

        public FormEventos(NovoEvento evento)
        {
            InitializeComponent();
            this.evento = evento;
        }

        private void FormEventos_Load(object sender, EventArgs e)
        {
            this.Text = "Agendamento - Detalhes do Evento";
            lblClienteInfo.Text = $"Cliente: {evento.ClienteNome}";
            dtpInicio.MinDate = DateTime.Today;
            dtpFim.Enabled = false;

            CarregarComboBoxLocais();
            CarregarComboBoxTipos();
            AtualizarDataFim();
        }

        private void AtualizarDataFim()
        {
            if (dtpInicio != null && numDuracao != null && dtpFim != null)
            {
                dtpFim.Value = dtpInicio.Value.AddHours((double)numDuracao.Value);
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e) { AtualizarDataFim(); }
        private void numDuracao_ValueChanged(object sender, EventArgs e) { AtualizarDataFim(); }


        private void CarregarComboBoxLocais()
        {
            string querySQL = "SELECT ID_local, Nome_local, Max_capacidade, Preco_local FROM PROJETO_GESTAO_EVENTOS.Local";
            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(querySQL, conexao))
                {
                    try
                    {
                        conexao.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { dt.Load(leitor); }
                        dt.Columns.Add("DisplayCompleto", typeof(string), "Nome_local + ' (' + Preco_local + ' €)'");
                        cmbLocais.DataSource = dt;
                        cmbLocais.DisplayMember = "DisplayCompleto";
                        cmbLocais.ValueMember = "ID_local";
                        cmbLocais.SelectedIndex = -1;
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro ao carregar locais.\n" + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void CarregarComboBoxTipos()
        {
            string querySQL = "SELECT ID_tipo, Nome_tipo_evento FROM PROJETO_GESTAO_EVENTOS.Tipo_evento";
            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(querySQL, conexao))
                {
                    try
                    {
                        conexao.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { dt.Load(leitor); }

                        cmbTipoEvento.DataSource = dt;
                        cmbTipoEvento.DisplayMember = "Nome_tipo_evento";
                        cmbTipoEvento.ValueMember = "ID_tipo";
                        cmbTipoEvento.SelectedIndex = -1;
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro ao carregar tipos de evento.\n" + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            if (cmbLocais.SelectedIndex == -1 || cmbTipoEvento.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecione um Local e um Tipo de Evento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numParticipantes.Value <= 0)
            {
                MessageBox.Show("O número de participantes tem de ser superior a zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numDuracao.Value <= 0)
            {
                MessageBox.Show("A duração do evento não pode ser zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView localSelecionado = cmbLocais.SelectedItem as DataRowView;
            string nomeLocalLimpo = "";
            if (localSelecionado != null && localSelecionado["Max_capacidade"] != DBNull.Value)
            {
                nomeLocalLimpo = localSelecionado["Nome_local"].ToString();
                int capacidade = Convert.ToInt32(localSelecionado["Max_capacidade"]);
                if (numParticipantes.Value > capacidade)
                {
                    MessageBox.Show($"O local '{nomeLocalLimpo}' tem uma capacidade máxima de {capacidade} pessoas.", "Capacidade Excedida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (localSelecionado["Preco_local"] != DBNull.Value)
                {
                    evento.Preco = Convert.ToDecimal(localSelecionado["Preco_local"]);
                }
            }

            evento.ID_Local = Convert.ToInt32(cmbLocais.SelectedValue);
            evento.NomeLocal = nomeLocalLimpo;
            evento.ID_Tipo = Convert.ToInt32(cmbTipoEvento.SelectedValue);
            evento.NomeTipo = cmbTipoEvento.Text;
            evento.Participantes = (int)numParticipantes.Value;
            evento.DuracaoHoras = (int)numDuracao.Value;

            evento.DataInicio = dtpInicio.Value;
            evento.DataFim = dtpInicio.Value.AddHours((double)numDuracao.Value);

            FormAtividade frmAtividade = new FormAtividade(evento);
            this.Hide();
            frmAtividade.ShowDialog();
            this.Close();
        }
    }
}