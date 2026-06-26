using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FormsProjeto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            MostrarPainel(pnlListaClientes);
            CarregarClientes();
        }

        // =======================================================
        // SISTEMA DE NAVEGAÇÃO (NAVBAR)
        // =======================================================
        private void MostrarPainel(Panel painelAtivo)
        {
            pnlListaClientes.Visible = false;
            pnlRegistoCliente.Visible = false;
            pnlRegistoLocal.Visible = false;
            pnlRegistoTipoEvento.Visible = false;
            pnlGestaoTemas.Visible = false;
            pnlGestaoMenus.Visible = false;
            pnlListaEventos.Visible = false;

            painelAtivo.Visible = true;
            painelAtivo.Dock = DockStyle.Fill;
        }

        private void btnNavLista_Click(object sender, EventArgs e) { MostrarPainel(pnlListaClientes); CarregarClientes(); }
        private void btnNavNovoCliente_Click(object sender, EventArgs e) { MostrarPainel(pnlRegistoCliente); }
        private void btnNavLocal_Click(object sender, EventArgs e) { MostrarPainel(pnlRegistoLocal); CarregarLocais(); }
        private void btnNavTipo_Click(object sender, EventArgs e) { MostrarPainel(pnlRegistoTipoEvento); CarregarCategoriasCheckbox(); CarregarTiposEvento(); }
        private void btnNavTemas_Click(object sender, EventArgs e) { MostrarPainel(pnlGestaoTemas); CarregarGrelhaTemas(); }
        private void btnNavMenus_Click(object sender, EventArgs e) { MostrarPainel(pnlGestaoMenus); CarregarGrelhaMenus(); }
        private void btnNavEventos_Click(object sender, EventArgs e) { MostrarPainel(pnlListaEventos); CarregarGrelhaEventos(); }

        private void CarregarClientes(string filtroNIF = "")
        {
            string querySQL = "SELECT NIF, Nome_cliente, Email, Telefone FROM PROJETO_GESTAO_EVENTOS.Cliente";

            if (!string.IsNullOrWhiteSpace(filtroNIF))
            {
                querySQL += " WHERE NIF LIKE @filtro";
            }

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(querySQL, conexao))
                {
                    if (!string.IsNullOrWhiteSpace(filtroNIF))
                    {
                        comando.Parameters.AddWithValue("@filtro", "%" + filtroNIF + "%");
                    }

                    try
                    {
                        conexao.Open();
                        DataTable tabela = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { tabela.Load(leitor); }
                        dgvClientes.DataSource = tabela;
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro a carregar clientes: " + ex.Message); }
                }
            }
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CarregarClientes(txtPesquisa.Text);
        }

        private void btnSeguinte_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dgvClientes.SelectedRows[0];

                NovoEvento evento = new NovoEvento();
                evento.ClienteNIF = linhaSelecionada.Cells["NIF"].Value.ToString();
                evento.ClienteNome = linhaSelecionada.Cells["Nome_cliente"].Value.ToString();
                FormEventos frmEventos = new FormEventos(evento);
                frmEventos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Selecione um cliente primeiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGravarCliente_Click(object sender, EventArgs e)
        {

            string nif = txtRegNIF.Text.Trim();
            string nome = txtRegNome.Text.Trim();
            string email = txtRegEmail.Text.Trim();
            string telefone = txtRegTelefone.Text.Trim();


            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, introduza o nome do cliente.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(nif, @"^\d{9}$"))
            {
                MessageBox.Show("O NIF tem de conter exatamente 9 dígitos numéricos.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(telefone, @"^\d{9}$"))
            {
                MessageBox.Show("O Telefone tem de conter exatamente 9 dígitos numéricos.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Por favor, introduza um endereço de email válido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string querySQL = "INSERT INTO PROJETO_GESTAO_EVENTOS.Cliente (NIF, Nome_cliente, Email, Telefone) VALUES (@NIF, @Nome, @Email, @Telefone)";
            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(querySQL, conexao))
                {
                    comando.Parameters.AddWithValue("@NIF", nif);
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Email", email);
                    comando.Parameters.AddWithValue("@Telefone", telefone);

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Cliente gravado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtRegNIF.Clear();
                        txtRegNome.Clear();
                        txtRegEmail.Clear();
                        txtRegTelefone.Clear();

                        MostrarPainel(pnlListaClientes);
                        CarregarClientes();
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro ao gravar na Base de Dados:\n" + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void CarregarLocais()
        {
            string querySQL = "SELECT ID_local, Nome_local, Morada, Max_capacidade, Preco_local FROM PROJETO_GESTAO_EVENTOS.Local";

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(querySQL, conexao))
                {
                    try
                    {
                        conexao.Open();
                        DataTable tabela = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { tabela.Load(leitor); }
                        dgvLocais.DataSource = tabela;
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro a carregar locais: " + ex.Message); }
                }
            }
        }

        private void btnGravarLocal_Click(object sender, EventArgs e)
        {
            string nome = txtLocalNome.Text.Trim();
            string morada = txtLocalMorada.Text.Trim();
            decimal preco = numLocalPreco.Value;
            int capacidade = (int)numLocalCapacidade.Value;

            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(morada))
            {
                MessageBox.Show("O Nome e a Morada são obrigatórios.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string querySQL = "INSERT INTO PROJETO_GESTAO_EVENTOS.Local ( Nome_local, Morada, Max_capacidade, Preco_local) VALUES (@Nome, @Morada, @Cap, @Preco)";
            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(querySQL, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", nome);
                    comando.Parameters.AddWithValue("@Morada", morada);
                    comando.Parameters.AddWithValue("@Preco", preco);
                    comando.Parameters.AddWithValue("@Cap", capacidade);

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Local registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtLocalNome.Clear();
                        txtLocalMorada.Clear();
                        numLocalPreco.Value = 0;
                        numLocalCapacidade.Value = 1;

                        CarregarLocais();
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro: " + ex.Message); }
                }
            }
        }

        private void CarregarTiposEvento()
        {
            string querySQL = "SELECT ID_tipo, Nome_tipo_evento FROM PROJETO_GESTAO_EVENTOS.Tipo_evento";

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(querySQL, conexao))
                {
                    try
                    {
                        conexao.Open();
                        DataTable tabela = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { tabela.Load(leitor); }
                        dgvTipos.DataSource = tabela;
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro a carregar tipos de evento: " + ex.Message); }
                }
            }
        }

        private void CarregarCategoriasCheckbox()
        {
            chkAtividadesAssociadas.DataSource = null;
            chkAtividadesAssociadas.Items.Clear();

            chkAtividadesAssociadas.Items.Add("Música");
            chkAtividadesAssociadas.Items.Add("Fotografia");
            chkAtividadesAssociadas.Items.Add("Animação");
            chkAtividadesAssociadas.Items.Add("Catering");
        }

        private void dgvTipos_SelectionChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkAtividadesAssociadas.Items.Count; i++)
                chkAtividadesAssociadas.SetItemChecked(i, false);

            if (dgvTipos.SelectedRows.Count == 0) return;

            int idTipoSelecionado = Convert.ToInt32(dgvTipos.SelectedRows[0].Cells["ID_tipo"].Value);
            lblAssociacaoTitulo.Text = $"Atividades permitidas para: {dgvTipos.SelectedRows[0].Cells["Nome_tipo_evento"].Value}";
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
                    comando.Parameters.AddWithValue("@idTipo", idTipoSelecionado);
                    try
                    {
                        conexao.Open();
                        using (SqlDataReader leitor = comando.ExecuteReader())
                        {
                            while (leitor.Read())
                            {
                                if (leitor["Categoria"] == DBNull.Value) continue;

                                string categoria = leitor["Categoria"].ToString();

                                for (int i = 0; i < chkAtividadesAssociadas.Items.Count; i++)
                                {
                                    if (chkAtividadesAssociadas.Items[i].ToString() == categoria)
                                    {
                                        chkAtividadesAssociadas.SetItemChecked(i, true);
                                        break;
                                    }
                                }
                            }
                        }
                    }
                    catch (SqlException ex) { MessageBox.Show("Erro a ler categorias: " + ex.Message); }
                }
            }
        }

        private void btnGuardarAssociacoes_Click(object sender, EventArgs e)
        {
            if (dgvTipos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um Tipo de Evento na tabela primeiro.");
                return;
            }

            int idTipo = Convert.ToInt32(dgvTipos.SelectedRows[0].Cells["ID_Tipo"].Value);

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                conexao.Open();
                SqlTransaction transacao = conexao.BeginTransaction();

                try
                {
                    string queryDelete = "DELETE FROM PROJETO_GESTAO_EVENTOS.Tem_atividade WHERE Tipo_evento_tem_atividade = @idTipo";
                    using (SqlCommand cmdDelete = new SqlCommand(queryDelete, conexao, transacao))
                    {
                        cmdDelete.Parameters.AddWithValue("@idTipo", idTipo);
                        cmdDelete.ExecuteNonQuery();
                    }

                    foreach (object itemChecked in chkAtividadesAssociadas.CheckedItems)
                    {
                        string categoria = itemChecked.ToString();
                        string tabelaAlvo = "";
                        switch (categoria)
                        {
                            case "Música": tabelaAlvo = "Musica"; break;
                            case "Fotografia": tabelaAlvo = "Fotografia"; break;
                            case "Animação": tabelaAlvo = "Animacao"; break;
                            case "Catering": tabelaAlvo = "Catering"; break;
                        }

                        if (!string.IsNullOrEmpty(tabelaAlvo))
                        {
                            string queryInsert = $@"
                                INSERT INTO PROJETO_GESTAO_EVENTOS.Tem_atividade (Tipo_evento_tem_atividade, Atividade_tem_atividade) 
                                SELECT @idTipo, ID_atividade_{tabelaAlvo.ToLower()} FROM PROJETO_GESTAO_EVENTOS.{tabelaAlvo}";

                            using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conexao, transacao))
                            {
                                cmdInsert.Parameters.AddWithValue("@idTipo", idTipo);
                                cmdInsert.ExecuteNonQuery();
                            }
                        }
                    }

                    transacao.Commit();
                    MessageBox.Show("Permissões de Categorias atualizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException ex)
                {
                    transacao.Rollback();
                    MessageBox.Show("Erro ao gravar associações:\n" + ex.Message);
                }
            }
        }

        private void btnGravarTipo_Click(object sender, EventArgs e)
        {
            string nome = txtTipoNome.Text.Trim();

            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Por favor, introduza o nome do Tipo de Evento.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string querySQL = "INSERT INTO PROJETO_GESTAO_EVENTOS.Tipo_evento (Nome_tipo_evento) VALUES (@Nome)";

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(querySQL, conexao))
                {
                    comando.Parameters.AddWithValue("@Nome", nome);

                    try
                    {
                        conexao.Open();
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Tipo de Evento registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtTipoNome.Clear();
                        CarregarTiposEvento();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
            }
        }

        private void CarregarGrelhaTemas()
        {
            string sql = @"
                SELECT 
                   ID_tipo_tema, preco_tema 
                FROM PROJETO_GESTAO_EVENTOS.Tema";

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    try
                    {
                        conexao.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { dt.Load(leitor); }
                        dgvTemas.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro a carregar Temas: " + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGravarTema_Click(object sender, EventArgs e)
        {
            decimal preco = numTemaPreco.Value;

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                string sql = "INSERT INTO PROJETO_GESTAO_EVENTOS.Tema (preco_tema) VALUES (@preco)";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@preco", preco);

                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Tema de Animação registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTemaTipo.Clear();
                        numTemaPreco.Value = 0;
                        CarregarGrelhaTemas();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro a gravar Tema: " + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CarregarGrelhaMenus()
        {
            string sql = @"
                SELECT n_menu, preco_menu
            FROM PROJETO_GESTAO_EVENTOS.Menu";

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    try
                    {
                        conexao.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { dt.Load(leitor); }
                        dgvMenus.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro a carregar Menus: " + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGravarMenu_Click(object sender, EventArgs e)
        {
            int numeroMenu = (int)numMenuNumero.Value;
            decimal preco = numMenuPreco.Value;

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                string sql = "INSERT INTO PROJETO_GESTAO_EVENTOS.Menu (n_menu, preco_menu) VALUES (@n, @preco)";

                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    cmd.Parameters.AddWithValue("@n", numeroMenu);
                    cmd.Parameters.AddWithValue("@preco", preco);

                    try
                    {
                        conexao.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Menu registado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        numMenuNumero.Value = 1;
                        numMenuPreco.Value = 0;
                        CarregarGrelhaMenus();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro a gravar Menu: " + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void CarregarGrelhaEventos()
        {
            string sql = @"
            SELECT 
                e.ID_evento AS [Nº Evento],
                c.Nome_cliente AS [Cliente],
                l.Nome_local AS [Local],
                t.Nome_tipo_evento AS [Tipo],
                e.Data_hora_evento AS [Data do Evento]
            FROM PROJETO_GESTAO_EVENTOS.Evento e
            LEFT JOIN PROJETO_GESTAO_EVENTOS.Cliente c ON e.Cliente_evento = c.NIF
            LEFT JOIN PROJETO_GESTAO_EVENTOS.Local l ON e.Local_evento = l.ID_local
            LEFT JOIN PROJETO_GESTAO_EVENTOS.Tipo_evento t ON e.ID_tipo_evento = t.ID_tipo
            ORDER BY e.Data_hora_evento ASC";

            using (SqlConnection conexao = new SqlConnection(Program.ConnectionString))
            {
                using (SqlCommand comando = new SqlCommand(sql, conexao))
                {
                    try
                    {
                        conexao.Open();
                        DataTable dt = new DataTable();
                        using (SqlDataReader leitor = comando.ExecuteReader()) { dt.Load(leitor); }
                        dgvEventos.DataSource = dt;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro a carregar Eventos: " + ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvEventos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idEvento = Convert.ToInt32(dgvEventos.Rows[e.RowIndex].Cells["Nº Evento"].Value);

                FormDetalhesEvento frmDetalhes = new FormDetalhesEvento(idEvento);
                frmDetalhes.ShowDialog();
            }
        }
    }
}