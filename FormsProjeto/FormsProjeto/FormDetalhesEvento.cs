using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class FormDetalhesEvento : Form
    {
        private int idEvento;

        public FormDetalhesEvento(int idEvento)
        {
            InitializeComponent();
            this.idEvento = idEvento;
        }

        private void FormDetalhesEvento_Load(object sender, EventArgs e)
        {
            this.Text = $"Detalhes do Evento #{idEvento}";
            CarregarCabecalhoEvento();
            CarregarAtividades();
        }

        private void CarregarCabecalhoEvento()
        {
            string query = "SELECT Preco_total, Data_hora_evento FROM PROJETO_GESTAO_EVENTOS.Evento WHERE ID_evento = @id";

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conexao))
                {
                    cmd.Parameters.AddWithValue("@id", idEvento);
                    try
                    {
                        conexao.Open();
                        using (SqlDataReader leitor = cmd.ExecuteReader())
                        {
                            if (leitor.Read())
                            {
                                DateTime data = Convert.ToDateTime(leitor["Data_hora_evento"]);
                                decimal precoTotal = Convert.ToDecimal(leitor["Preco_total"]);

                                lblInfoEvento.Text = $"Evento Nº {idEvento} | Data: {data:dd/MM/yyyy HH:mm}";
                                lblPrecoTotal.Text = $"TOTAL FINAL: {precoTotal:C2}";
                            }
                        }
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro a ler detalhes: " + ex.Message); }
                }
            }
        }

        private void CarregarAtividades()
        {
            string sql = @"
                SELECT 
                    a.ID_atividade AS [ID Ativ.],
                    CASE 
                        WHEN m.ID_atividade_musica IS NOT NULL THEN 'Música'
                        WHEN f.ID_atividade_fotografia IS NOT NULL THEN 'Fotografia'
                        WHEN ani.ID_atividade_animacao IS NOT NULL THEN 'Animação'
                        WHEN cat.ID_atividade_catering IS NOT NULL THEN 'Catering'
                        ELSE 'Outra'
                    END AS [Categoria],
                    CASE 
                        WHEN m.ID_atividade_musica IS NOT NULL THEN CAST(m.n_horas AS VARCHAR) + ' horas'
                        WHEN f.ID_atividade_fotografia IS NOT NULL THEN CAST(f.n_sessoes AS VARCHAR) + ' sessões (' + f.altura_dia + ')'
                        WHEN ani.ID_atividade_animacao IS NOT NULL THEN 'Tema #' + CAST(ani.ID_tipo_tema_animacao AS VARCHAR) + ' (' + CAST(ani.n_horas_animacao AS VARCHAR) + 'h)'
                        WHEN cat.ID_atividade_catering IS NOT NULL THEN 'Menu #' + CAST(cat.n_menu_catering AS VARCHAR)
                        ELSE '-'
                    END AS [Detalhes],
                    a.Preco_atividade AS [Subtotal (€)]
                FROM PROJETO_GESTAO_EVENTOS.Inclui i
                INNER JOIN PROJETO_GESTAO_EVENTOS.Atividade a ON i.ID_atividade_inclui = a.ID_atividade
                LEFT JOIN PROJETO_GESTAO_EVENTOS.Musica m ON a.ID_atividade = m.ID_atividade_musica
                LEFT JOIN PROJETO_GESTAO_EVENTOS.Fotografia f ON a.ID_atividade = f.ID_atividade_fotografia
                LEFT JOIN PROJETO_GESTAO_EVENTOS.Animacao ani ON a.ID_atividade = ani.ID_atividade_animacao
                LEFT JOIN PROJETO_GESTAO_EVENTOS.Catering cat ON a.ID_atividade = cat.ID_atividade_catering
                WHERE i.ID_evento_inclui = @idEvento";

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@idEvento", idEvento);
                    try
                    {
                        conexao.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { dt.Load(leitor); }
                        dgvAtividades.DataSource = dt;
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro a carregar as atividades: " + ex.Message); }
                }
            }
        }
    }
}