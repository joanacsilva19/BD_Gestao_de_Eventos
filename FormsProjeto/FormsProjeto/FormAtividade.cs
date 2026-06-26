using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace FormsProjeto
{
    public partial class FormAtividade : Form
    {
        private NovoEvento evento;

        public FormAtividade(NovoEvento evento)
        {
            InitializeComponent();
            this.evento = evento;
        }

        private void FormAtividade_Load(object sender, EventArgs e)
        {
            CarregarCategoriasPermitidas();
            cmbSubCategoria.Items.AddRange(new object[] { "Banda", "DJ" });
            cmbAlturaDia.Items.AddRange(new object[] { "Manhã", "Tarde", "Noite", "Dia Inteiro" });
            numPrecoFotografia.Value = 20;
            numPrecoFotografia.Enabled = false;

            AtualizarResumo();
        }

        private void CarregarCategoriasPermitidas()
        {
            cmbCategoria.Items.Clear();
            string querySQL = @"
        SELECT DISTINCT
            CASE 
                WHEN m.ID_atividade_musica IS NOT NULL THEN 'Música'
                WHEN f.ID_atividade_fotografia IS NOT NULL THEN 'Fotografia'
                WHEN ani.ID_atividade_animacao IS NOT NULL THEN 'Animação'
                WHEN cat.ID_atividade_catering IS NOT NULL THEN 'Catering'
            END AS Categoria
        FROM PROJETO_GESTAO_EVENTOS.Tem_atividade t
        LEFT JOIN PROJETO_GESTAO_EVENTOS.Musica m ON t.Atividade_tem_atividade = m.ID_atividade_musica
        LEFT JOIN PROJETO_GESTAO_EVENTOS.Fotografia f ON t.Atividade_tem_atividade = f.ID_atividade_fotografia
        LEFT JOIN PROJETO_GESTAO_EVENTOS.Animacao ani ON t.Atividade_tem_atividade = ani.ID_atividade_animacao
        LEFT JOIN PROJETO_GESTAO_EVENTOS.Catering cat ON t.Atividade_tem_atividade = cat.ID_atividade_catering
        WHERE t.Tipo_evento_tem_atividade = @idTipo";

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(querySQL, conexao))
                {
                    comando.Parameters.AddWithValue("@idTipo", evento.ID_Tipo);
                    try
                    {
                        conexao.Open();
                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                if (leitor["Categoria"] != DBNull.Value)
                                {
                                    string categoria = leitor["Categoria"].ToString();
                                    cmbCategoria.Items.Add(categoria);
                                }
                            }
                        }
                        if (cmbCategoria.Items.Count > 0)
                        {
                            cmbCategoria.SelectedIndex = 0;
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao carregar categorias permitidas para este evento:\n" + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1) return;

            string categoria = cmbCategoria.SelectedItem.ToString();

            pnlMusica.Visible = false;
            pnlFotografia.Visible = false;
            pnlAnimacao.Visible = false;
            pnlCatering.Visible = false;

            if (categoria == "Música")
            {
                pnlMusica.Visible = true;
                cmbSubCategoria.SelectedIndex = -1;
                cmbCatMusica.DataSource = null;
            }
            else if (categoria == "Fotografia")
            {
                pnlFotografia.Visible = true;
            }
            else if (categoria == "Animação")
            {
                pnlAnimacao.Visible = true;
                CarregarCatalogo("SELECT ID_tipo_tema AS ID, 'Tema: ' + CAST(ID_tipo_tema AS VARCHAR) + ' (' + CAST(preco_tema AS VARCHAR) + '€)' AS Display, preco_tema AS Preco FROM PROJETO_GESTAO_EVENTOS.Tema", cmbCatAnimacao);
            }
            else if (categoria == "Catering")
            {
                pnlCatering.Visible = true;
                CarregarCatalogo("SELECT n_menu AS ID, 'Menu #' + CAST(n_menu AS VARCHAR) + ' (' + CAST(preco_menu AS VARCHAR) + '€/px)' AS Display, preco_menu AS Preco FROM PROJETO_GESTAO_EVENTOS.Menu", cmbCatCatering);
            }
        }

        private void cmbSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubCategoria.SelectedIndex == -1) return;
            string sub = cmbSubCategoria.SelectedItem.ToString();

            if (sub == "Banda")
                CarregarCatalogo("SELECT ID_atividade_banda AS ID, 'Banda #' + CAST(ID_atividade_banda AS VARCHAR) + ' (' + CAST(preco_banda AS VARCHAR) + '€/h)' AS Display, preco_banda AS Preco FROM PROJETO_GESTAO_EVENTOS.Banda", cmbCatMusica);
            else if (sub == "DJ")
                CarregarCatalogo("SELECT ID_atividade_DJ AS ID, 'DJ #' + CAST(ID_atividade_DJ AS VARCHAR) + ' (' + CAST(preco_DJ AS VARCHAR) + '€/h)' AS Display, preco_DJ AS Preco FROM PROJETO_GESTAO_EVENTOS.DJ", cmbCatMusica);
        }

        private void CarregarCatalogo(string query, ComboBox cmb)
        {
            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(query, conexao))
                {
                    try
                    {
                        conexao.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { dt.Load(leitor); }
                        cmb.DataSource = dt;
                        cmb.DisplayMember = "Display";
                        cmb.ValueMember = "ID";
                        cmb.Tag = dt;
                        cmb.SelectedIndex = -1;
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro catálogo: " + ex.Message); }
                }
            }
        }

        private void btnAdicionarCarrinho_Click(object sender, EventArgs e)
        {
            if (cmbCategoria.SelectedIndex == -1) return;
            string cat = cmbCategoria.SelectedItem.ToString();

            ItemCarrinho item = new ItemCarrinho { Categoria = cat, ParticipantesEvento = evento.Participantes };

            try
            {
                if (cat == "Música")
                {
                    if (cmbSubCategoria.SelectedIndex == -1 || cmbCatMusica.SelectedIndex == -1) { MessageBox.Show("Preencha os dados da Música."); return; }
                    item.SubCategoria = cmbSubCategoria.SelectedItem.ToString();
                    item.ID_Catalogo = Convert.ToInt32(cmbCatMusica.SelectedValue);
                    item.Horas = (int)numMusicaHoras.Value;
                    item.PrecoUnitario = ObterPrecoDaTag(cmbCatMusica);
                    item.Descricao = $"{item.SubCategoria} ({item.Horas}h)";
                }
                else if (cat == "Fotografia")
                {
                    if (cmbAlturaDia.SelectedIndex == -1) { MessageBox.Show("Escolha a altura do dia."); return; }
                    item.Sessoes = (int)numSessoes.Value;
                    item.AlturaDia = cmbAlturaDia.SelectedItem.ToString();
                    item.PrecoUnitario = 20;
                    item.Descricao = $"Fotografia - {item.AlturaDia} ({item.Sessoes} sessões)";
                }
                else if (cat == "Animação")
                {
                    if (cmbCatAnimacao.SelectedIndex == -1) { MessageBox.Show("Escolha um Tema."); return; }
                    item.ID_Catalogo = Convert.ToInt32(cmbCatAnimacao.SelectedValue);
                    item.Horas = (int)numAnimacaoHoras.Value;
                    item.Animadores = (int)numAnimadores.Value;
                    item.PrecoUnitario = ObterPrecoDaTag(cmbCatAnimacao);
                    item.Descricao = $"Animação Tema #{item.ID_Catalogo}";
                }
                else if (cat == "Catering")
                {
                    if (cmbCatCatering.SelectedIndex == -1) { MessageBox.Show("Escolha um Menu."); return; }
                    item.ID_Catalogo = Convert.ToInt32(cmbCatCatering.SelectedValue);
                    item.PrecoUnitario = ObterPrecoDaTag(cmbCatCatering);
                    item.Descricao = $"Catering Menu #{item.ID_Catalogo}";
                }

                evento.AtividadesEscolhidas.Add(item);
                AtualizarResumo();
            }
            catch (Exception ex) { MessageBox.Show("Erro ao adicionar: " + ex.Message); }
        }

        private decimal ObterPrecoDaTag(ComboBox cmb)
        {
            DataTable dt = cmb.Tag as DataTable;
            DataRow[] rows = dt.Select($"ID = {cmb.SelectedValue}");
            return Convert.ToDecimal(rows[0]["Preco"]);
        }

        private void AtualizarResumo()
        {
            dgvCarrinho.DataSource = null;
            dgvCarrinho.DataSource = evento.AtividadesEscolhidas;
            lblPrecoLocal.Text = $"Custo do Local: {evento.Preco:C2}";
            lblPrecoTotal.Text = $"TOTAL DO EVENTO: {evento.PrecoTotalFinal:C2}";
        }

        private void btnFinalizarEvento_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                conexao.Open();
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string sqlEv = "INSERT INTO PROJETO_GESTAO_EVENTOS.Evento (Data_hora_evento, Duracao_horas_evento, Participantes, Preco_total, Cliente_evento, Local_evento, ID_tipo_evento) VALUES (@di, @df, @np, @pt, @idc, @idl, @idt); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdEv = new SqlCommand(sqlEv, conexao, transacao);
                    cmdEv.Parameters.AddWithValue("@di", evento.DataInicio);
                    cmdEv.Parameters.AddWithValue("@df", evento.DuracaoHoras);
                    cmdEv.Parameters.AddWithValue("@np", evento.Participantes);
                    cmdEv.Parameters.AddWithValue("@pt", evento.PrecoTotalFinal);
                    cmdEv.Parameters.AddWithValue("@idc", evento.ClienteNIF);
                    cmdEv.Parameters.AddWithValue("@idl", evento.ID_Local);
                    cmdEv.Parameters.AddWithValue("@idt", evento.ID_Tipo);
                    int idEvento = Convert.ToInt32(cmdEv.ExecuteScalar());

                    foreach (var item in evento.AtividadesEscolhidas)
                    {
                        SqlCommand cmdAtiv = new SqlCommand("INSERT INTO PROJETO_GESTAO_EVENTOS.Atividade (Preco_atividade) VALUES (@p); SELECT SCOPE_IDENTITY();", conexao, transacao);
                        cmdAtiv.Parameters.AddWithValue("@p", item.SubTotal);
                        int idAtiv = Convert.ToInt32(cmdAtiv.ExecuteScalar());

                        SqlCommand cmdInclui = new SqlCommand("INSERT INTO PROJETO_GESTAO_EVENTOS.Inclui (ID_evento_inclui, ID_atividade_inclui) VALUES (@idev, @ida)", conexao, transacao);
                        cmdInclui.Parameters.AddWithValue("@idev", idEvento);
                        cmdInclui.Parameters.AddWithValue("@ida", idAtiv);
                        cmdInclui.ExecuteNonQuery();

                        if (item.Categoria == "Música")
                        {
                            SqlCommand cmdMus = new SqlCommand("INSERT INTO PROJETO_GESTAO_EVENTOS.Musica (ID_atividade_musica, n_horas, preco_musica) VALUES (@ida, @h, @p)", conexao, transacao);
                            cmdMus.Parameters.AddWithValue("@ida", idAtiv);
                            cmdMus.Parameters.AddWithValue("@h", item.Horas);
                            cmdMus.Parameters.AddWithValue("@p", item.PrecoUnitario * item.Horas);
                            cmdMus.ExecuteNonQuery();
                            }
                        else if (item.Categoria == "Fotografia")
                        {
                            SqlCommand cmdFoto = new SqlCommand("INSERT INTO PROJETO_GESTAO_EVENTOS.Fotografia (ID_atividade_fotografia, n_sessoes, altura_dia, preco_sessao, preco_fotografia) VALUES (@ida, @ns, @alt, @p, @pf)", conexao, transacao);
                            cmdFoto.Parameters.AddWithValue("@ida", idAtiv);
                            cmdFoto.Parameters.AddWithValue("@ns", item.Sessoes);
                            cmdFoto.Parameters.AddWithValue("@alt", item.AlturaDia);
                            cmdFoto.Parameters.AddWithValue("@p", item.PrecoUnitario);
                            cmdFoto.Parameters.AddWithValue("@pf", item.PrecoUnitario * item.Sessoes);
                            cmdFoto.ExecuteNonQuery();
                        }
                        else if (item.Categoria == "Animação")
                        {
                            SqlCommand cmdAni = new SqlCommand("INSERT INTO PROJETO_GESTAO_EVENTOS.Animacao (ID_atividade_animacao, n_horas_animacao, n_animadores, ID_tipo_tema_animacao, preco_animacao) VALUES (@ida, @h, @na, @idt, @p)", conexao, transacao);
                            cmdAni.Parameters.AddWithValue("@ida", idAtiv);
                            cmdAni.Parameters.AddWithValue("@h", item.Horas);
                            cmdAni.Parameters.AddWithValue("@na", item.Animadores);
                            cmdAni.Parameters.AddWithValue("@idt", item.ID_Catalogo);
                            cmdAni.Parameters.AddWithValue("@p", item.PrecoUnitario * item.Horas);
                            cmdAni.ExecuteNonQuery();
                        }
                        else if (item.Categoria == "Catering")
                        {
                            SqlCommand cmdCat = new SqlCommand("INSERT INTO PROJETO_GESTAO_EVENTOS.Catering (ID_atividade_catering, n_menu_catering, preco_catering) VALUES (@ida, @idm, @p)", conexao, transacao);
                            cmdCat.Parameters.AddWithValue("@ida", idAtiv);
                            cmdCat.Parameters.AddWithValue("@idm", item.ID_Catalogo);
                            cmdCat.Parameters.AddWithValue("@p", item.PrecoUnitario * evento.Participantes);
                            cmdCat.ExecuteNonQuery();
                        }
                    }

                    transacao.Commit();
                    MessageBox.Show("EVENTO AGENDADO COM SUCESSO!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (SqlException ex) { transacao.Rollback(); MessageBox.Show("Erro BD: " + ex.Message); }
            }
        }
    }
}