namespace FormsProjeto
{
    partial class Form1
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
            pnlTopo = new Panel();
            btnNavLista = new Button();
            btnNavNovoCliente = new Button();
            btnNavLocal = new Button();
            btnNavTipo = new Button();
            btnNavTemas = new Button();
            btnNavMenus = new Button();
            pnlContainerPrincipal = new Panel();
            pnlListaClientes = new Panel();
            lblPesquisa = new Label();
            txtPesquisa = new TextBox();
            dgvClientes = new DataGridView();
            btnSeguinte = new Button();
            pnlRegistoCliente = new Panel();
            lblRegCliTitulo = new Label();
            txtRegNIF = new TextBox();
            txtRegNome = new TextBox();
            txtRegEmail = new TextBox();
            txtRegTelefone = new TextBox();
            btnGravarCliente = new Button();
            pnlRegistoLocal = new Panel();
            lblLocalTitulo = new Label();
            txtLocalNome = new TextBox();
            txtLocalMorada = new TextBox();
            lblLocalPreco = new Label();
            numLocalPreco = new NumericUpDown();
            lblLocalCapacidade = new Label();
            numLocalCapacidade = new NumericUpDown();
            btnGravarLocal = new Button();
            dgvLocais = new DataGridView();
            pnlRegistoTipoEvento = new Panel();
            lblTipoTitulo = new Label();
            txtTipoNome = new TextBox();
            btnGravarTipo = new Button();
            lblAssociacaoTitulo = new Label();
            chkAtividadesAssociadas = new CheckedListBox();
            btnGuardarAssociacoes = new Button();
            dgvTipos = new DataGridView();
            pnlGestaoTemas = new Panel();
            lblTemasTitulo = new Label();
            lblTemaTipo = new Label();
            txtTemaTipo = new TextBox();
            lblTemaPreco = new Label();
            numTemaPreco = new NumericUpDown();
            btnGravarTema = new Button();
            dgvTemas = new DataGridView();
            pnlGestaoMenus = new Panel();
            lblMenusTitulo = new Label();
            lblMenuNumero = new Label();
            numMenuNumero = new NumericUpDown();
            lblMenuPreco = new Label();
            numMenuPreco = new NumericUpDown();
            btnGravarMenu = new Button();
            dgvMenus = new DataGridView();
            btnNavEventos = new Button();
            pnlListaEventos = new Panel();
            lblEventosTitulo = new Label();
            dgvEventos = new DataGridView();

            pnlTopo.SuspendLayout();
            pnlContainerPrincipal.SuspendLayout();
            pnlListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            pnlRegistoCliente.SuspendLayout();
            pnlRegistoLocal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLocalPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLocalCapacidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocais).BeginInit();
            pnlRegistoTipoEvento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipos).BeginInit();
            pnlGestaoTemas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTemaPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTemas).BeginInit();
            pnlGestaoMenus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEventos).BeginInit();
            pnlListaEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMenuNumero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMenuPreco).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenus).BeginInit();
            SuspendLayout();

            pnlTopo.BackColor = Color.FromArgb(45, 45, 48);
            pnlTopo.Controls.Add(btnNavLista);
            pnlTopo.Controls.Add(btnNavNovoCliente);
            pnlTopo.Controls.Add(btnNavLocal);
            pnlTopo.Controls.Add(btnNavTipo);
            pnlTopo.Controls.Add(btnNavTemas);
            pnlTopo.Controls.Add(btnNavMenus);
            pnlTopo.Controls.Add(btnNavEventos);
            pnlTopo.Dock = DockStyle.Top;
            pnlTopo.Location = new Point(0, 0);
            pnlTopo.Name = "pnlTopo";
            pnlTopo.Size = new Size(800, 50);
            pnlTopo.TabIndex = 1;
            
            btnNavLista.Location = new Point(10, 10);
            btnNavLista.Name = "btnNavLista";
            btnNavLista.Size = new Size(100, 30);
            btnNavLista.TabIndex = 0;
            btnNavLista.Text = "Clientes";
            btnNavLista.ForeColor = Color.White;
            btnNavLista.Click += btnNavLista_Click;
            
            btnNavNovoCliente.Location = new Point(120, 10);
            btnNavNovoCliente.Name = "btnNavNovoCliente";
            btnNavNovoCliente.Size = new Size(100, 30);
            btnNavNovoCliente.TabIndex = 1;
            btnNavNovoCliente.Text = "Novo Cliente";
            btnNavNovoCliente.ForeColor = Color.White;
            btnNavNovoCliente.Click += btnNavNovoCliente_Click;
            
            btnNavLocal.Location = new Point(230, 10);
            btnNavLocal.Name = "btnNavLocal";
            btnNavLocal.Size = new Size(100, 30);
            btnNavLocal.TabIndex = 2;
            btnNavLocal.Text = "Locais";
            btnNavLocal.ForeColor = Color.White;
            btnNavLocal.Click += btnNavLocal_Click;
            
            btnNavTipo.Location = new Point(340, 10);
            btnNavTipo.Name = "btnNavTipo";
            btnNavTipo.Size = new Size(100, 30);
            btnNavTipo.TabIndex = 3;
            btnNavTipo.Text = "Tipos Evento";
            btnNavTipo.ForeColor = Color.White;
            btnNavTipo.Click += btnNavTipo_Click;
            
            btnNavTemas.Location = new Point(450, 10);
            btnNavTemas.Name = "btnNavTemas";
            btnNavTemas.Size = new Size(180, 30);
            btnNavTemas.TabIndex = 5;
            btnNavTemas.Text = "Gestão de Temas De Animação";
            btnNavTemas.ForeColor = Color.White;
            btnNavTemas.Click += btnNavTemas_Click;
           
            btnNavMenus.Location = new Point(640, 10);
            btnNavMenus.Name = "btnNavMenus";
            btnNavMenus.Size = new Size(150, 30);
            btnNavMenus.TabIndex = 6;
            btnNavMenus.Text = "Gestão de Menus";
            btnNavMenus.ForeColor = Color.White;
            btnNavMenus.Click += btnNavMenus_Click;

            btnNavEventos.Location = new Point(800, 10);
            btnNavEventos.Name = "btnNavEventos";
            btnNavEventos.Size = new Size(100, 30);
            btnNavEventos.Text = "Ver Eventos";
            btnNavEventos.ForeColor = Color.White;
            btnNavEventos.Click += btnNavEventos_Click;

            pnlContainerPrincipal.Controls.Add(pnlListaClientes);
            pnlContainerPrincipal.Controls.Add(pnlRegistoCliente);
            pnlContainerPrincipal.Controls.Add(pnlRegistoLocal);
            pnlContainerPrincipal.Controls.Add(pnlRegistoTipoEvento);
            pnlContainerPrincipal.Controls.Add(pnlGestaoTemas);
            pnlContainerPrincipal.Controls.Add(pnlGestaoMenus);
            pnlContainerPrincipal.Dock = DockStyle.Fill;
            pnlContainerPrincipal.Location = new Point(0, 50);
            pnlContainerPrincipal.Name = "pnlContainerPrincipal";
            pnlContainerPrincipal.Size = new Size(800, 430);
            pnlContainerPrincipal.TabIndex = 0;
            
            pnlListaClientes.Controls.Add(lblPesquisa);
            pnlListaClientes.Controls.Add(txtPesquisa);
            pnlListaClientes.Controls.Add(dgvClientes);
            pnlListaClientes.Controls.Add(btnSeguinte);
            pnlListaClientes.Location = new Point(0, 0);
            pnlListaClientes.Name = "pnlListaClientes";
            pnlListaClientes.Size = new Size(200, 100);
            pnlListaClientes.TabIndex = 0;
            
            lblPesquisa.AutoSize = true;
            lblPesquisa.Location = new Point(20, 23);
            lblPesquisa.Name = "lblPesquisa";
            lblPesquisa.Size = new Size(102, 15);
            lblPesquisa.TabIndex = 0;
            lblPesquisa.Text = "Pesquisar por NIF:";
           
            txtPesquisa.Location = new Point(140, 20);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(300, 23);
            txtPesquisa.TabIndex = 1;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.Location = new Point(20, 60);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(700, 300);
            dgvClientes.TabIndex = 2;
            
            btnSeguinte.Location = new Point(570, 370);
            btnSeguinte.Name = "btnSeguinte";
            btnSeguinte.Size = new Size(150, 40);
            btnSeguinte.TabIndex = 3;
            btnSeguinte.Text = "Marcar Evento ➔";
            btnSeguinte.Click += btnSeguinte_Click;
            
            pnlRegistoCliente.Controls.Add(lblRegCliTitulo);
            pnlRegistoCliente.Controls.Add(txtRegNIF);
            pnlRegistoCliente.Controls.Add(txtRegNome);
            pnlRegistoCliente.Controls.Add(txtRegEmail);
            pnlRegistoCliente.Controls.Add(txtRegTelefone);
            pnlRegistoCliente.Controls.Add(btnGravarCliente);
            pnlRegistoCliente.Location = new Point(0, 0);
            pnlRegistoCliente.Name = "pnlRegistoCliente";
            pnlRegistoCliente.Size = new Size(200, 100);
            pnlRegistoCliente.TabIndex = 1;
            pnlRegistoCliente.Visible = false;
            
            lblRegCliTitulo.AutoSize = true;
            lblRegCliTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblRegCliTitulo.Location = new Point(20, 20);
            lblRegCliTitulo.Name = "lblRegCliTitulo";
            lblRegCliTitulo.Size = new Size(204, 25);
            lblRegCliTitulo.TabIndex = 0;
            lblRegCliTitulo.Text = "Registar Novo Cliente";
            
            txtRegNIF.Location = new Point(20, 70);
            txtRegNIF.Name = "txtRegNIF";
            txtRegNIF.PlaceholderText = "NIF (9 dígitos)";
            txtRegNIF.Size = new Size(200, 23);
            txtRegNIF.TabIndex = 1;
            
            txtRegNome.Location = new Point(20, 110);
            txtRegNome.Name = "txtRegNome";
            txtRegNome.PlaceholderText = "Nome Completo";
            txtRegNome.Size = new Size(300, 23);
            txtRegNome.TabIndex = 2;
            
            txtRegEmail.Location = new Point(20, 150);
            txtRegEmail.Name = "txtRegEmail";
            txtRegEmail.PlaceholderText = "Email";
            txtRegEmail.Size = new Size(300, 23);
            txtRegEmail.TabIndex = 3;
            
            txtRegTelefone.Location = new Point(20, 190);
            txtRegTelefone.Name = "txtRegTelefone";
            txtRegTelefone.PlaceholderText = "Telefone";
            txtRegTelefone.Size = new Size(200, 23);
            txtRegTelefone.TabIndex = 4;
            
            btnGravarCliente.Location = new Point(20, 240);
            btnGravarCliente.Name = "btnGravarCliente";
            btnGravarCliente.Size = new Size(150, 40);
            btnGravarCliente.TabIndex = 5;
            btnGravarCliente.Text = "Gravar Cliente";
            btnGravarCliente.Click += btnGravarCliente_Click;
            
            pnlRegistoLocal.Controls.Add(lblLocalTitulo);
            pnlRegistoLocal.Controls.Add(txtLocalNome);
            pnlRegistoLocal.Controls.Add(txtLocalMorada);
            pnlRegistoLocal.Controls.Add(lblLocalPreco);
            pnlRegistoLocal.Controls.Add(numLocalPreco);
            pnlRegistoLocal.Controls.Add(lblLocalCapacidade);
            pnlRegistoLocal.Controls.Add(numLocalCapacidade);
            pnlRegistoLocal.Controls.Add(btnGravarLocal);
            pnlRegistoLocal.Controls.Add(dgvLocais);
            pnlRegistoLocal.Location = new Point(0, 0);
            pnlRegistoLocal.Name = "pnlRegistoLocal";
            pnlRegistoLocal.Size = new Size(200, 100);
            pnlRegistoLocal.TabIndex = 2;
            pnlRegistoLocal.Visible = false;
            
            lblLocalTitulo.AutoSize = true;
            lblLocalTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblLocalTitulo.Location = new Point(20, 20);
            lblLocalTitulo.Name = "lblLocalTitulo";
            lblLocalTitulo.Size = new Size(159, 25);
            lblLocalTitulo.TabIndex = 0;
            lblLocalTitulo.Text = "Gestão de Locais";
            
            txtLocalNome.Location = new Point(20, 70);
            txtLocalNome.Name = "txtLocalNome";
            txtLocalNome.PlaceholderText = "Nome do Local";
            txtLocalNome.Size = new Size(250, 23);
            txtLocalNome.TabIndex = 1;
           
            txtLocalMorada.Location = new Point(20, 110);
            txtLocalMorada.Name = "txtLocalMorada";
            txtLocalMorada.PlaceholderText = "Morada Completa";
            txtLocalMorada.Size = new Size(250, 23);
            txtLocalMorada.TabIndex = 2;
            
            lblLocalPreco.AutoSize = true;
            lblLocalPreco.Location = new Point(20, 145);
            lblLocalPreco.Name = "lblLocalPreco";
            lblLocalPreco.Size = new Size(100, 15);
            lblLocalPreco.TabIndex = 3;
            lblLocalPreco.Text = "Preço por Evento:";
            
            numLocalPreco.DecimalPlaces = 2;
            numLocalPreco.Location = new Point(20, 165);
            numLocalPreco.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numLocalPreco.Name = "numLocalPreco";
            numLocalPreco.Size = new Size(120, 23);
            numLocalPreco.TabIndex = 4;
            
            lblLocalCapacidade.AutoSize = true;
            lblLocalCapacidade.Location = new Point(150, 145);
            lblLocalCapacidade.Name = "lblLocalCapacidade";
            lblLocalCapacidade.Size = new Size(117, 15);
            lblLocalCapacidade.TabIndex = 5;
            lblLocalCapacidade.Text = "Capacidade Máxima:";
            
            numLocalCapacidade.Location = new Point(150, 165);
            numLocalCapacidade.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numLocalCapacidade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numLocalCapacidade.Name = "numLocalCapacidade";
            numLocalCapacidade.Size = new Size(120, 23);
            numLocalCapacidade.TabIndex = 6;
            numLocalCapacidade.Value = new decimal(new int[] { 50, 0, 0, 0 });
            
            btnGravarLocal.Location = new Point(20, 190);
            btnGravarLocal.Name = "btnGravarLocal";
            btnGravarLocal.Size = new Size(250, 40);
            btnGravarLocal.TabIndex = 7;
            btnGravarLocal.Text = "Gravar Local";
            btnGravarLocal.Click += btnGravarLocal_Click;
            
            dgvLocais.AllowUserToAddRows = false;
            dgvLocais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLocais.Location = new Point(300, 70);
            dgvLocais.Name = "dgvLocais";
            dgvLocais.ReadOnly = true;
            dgvLocais.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLocais.Size = new Size(420, 300);
            dgvLocais.TabIndex = 8;
            
            pnlRegistoTipoEvento.Controls.Add(lblTipoTitulo);
            pnlRegistoTipoEvento.Controls.Add(txtTipoNome);
            pnlRegistoTipoEvento.Controls.Add(btnGravarTipo);
            pnlRegistoTipoEvento.Controls.Add(lblAssociacaoTitulo);
            pnlRegistoTipoEvento.Controls.Add(chkAtividadesAssociadas);
            pnlRegistoTipoEvento.Controls.Add(btnGuardarAssociacoes);
            pnlRegistoTipoEvento.Controls.Add(dgvTipos);
            pnlRegistoTipoEvento.Location = new Point(0, 0);
            pnlRegistoTipoEvento.Name = "pnlRegistoTipoEvento";
            pnlRegistoTipoEvento.Size = new Size(200, 100);
            pnlRegistoTipoEvento.TabIndex = 3;
            pnlRegistoTipoEvento.Visible = false;
            
            lblTipoTitulo.AutoSize = true;
            lblTipoTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTipoTitulo.Location = new Point(20, 20);
            lblTipoTitulo.Name = "lblTipoTitulo";
            lblTipoTitulo.Size = new Size(246, 25);
            lblTipoTitulo.TabIndex = 0;
            lblTipoTitulo.Text = "Gestão de Tipos de Evento";
            
            txtTipoNome.Location = new Point(20, 50);
            txtTipoNome.Name = "txtTipoNome";
            txtTipoNome.PlaceholderText = "Ex: Casamento";
            txtTipoNome.Size = new Size(250, 23);
            txtTipoNome.TabIndex = 1;
            
            btnGravarTipo.Location = new Point(20, 80);
            btnGravarTipo.Name = "btnGravarTipo";
            btnGravarTipo.Size = new Size(250, 35);
            btnGravarTipo.TabIndex = 2;
            btnGravarTipo.Text = "Gravar Tipo";
            btnGravarTipo.Click += btnGravarTipo_Click;
             
            lblAssociacaoTitulo.AutoSize = true;
            lblAssociacaoTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAssociacaoTitulo.ForeColor = Color.DarkBlue;
            lblAssociacaoTitulo.Location = new Point(20, 140);
            lblAssociacaoTitulo.Name = "lblAssociacaoTitulo";
            lblAssociacaoTitulo.Size = new Size(171, 15);
            lblAssociacaoTitulo.TabIndex = 3;
            lblAssociacaoTitulo.Text = "Selecione um Tipo na tabela...";
            
            chkAtividadesAssociadas.CheckOnClick = true;
            chkAtividadesAssociadas.FormattingEnabled = true;
            chkAtividadesAssociadas.Location = new Point(20, 165);
            chkAtividadesAssociadas.Name = "chkAtividadesAssociadas";
            chkAtividadesAssociadas.Size = new Size(250, 148);
            chkAtividadesAssociadas.TabIndex = 4;
             
            btnGuardarAssociacoes.BackColor = Color.LightGoldenrodYellow;
            btnGuardarAssociacoes.Location = new Point(20, 320);
            btnGuardarAssociacoes.Name = "btnGuardarAssociacoes";
            btnGuardarAssociacoes.Size = new Size(250, 35);
            btnGuardarAssociacoes.TabIndex = 5;
            btnGuardarAssociacoes.Text = "Atualizar Permissões";
            btnGuardarAssociacoes.UseVisualStyleBackColor = false;
            btnGuardarAssociacoes.Click += btnGuardarAssociacoes_Click;
             
            dgvTipos.AllowUserToAddRows = false;
            dgvTipos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTipos.Location = new Point(300, 50);
            dgvTipos.Name = "dgvTipos";
            dgvTipos.ReadOnly = true;
            dgvTipos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTipos.Size = new Size(420, 305);
            dgvTipos.TabIndex = 6;
            dgvTipos.SelectionChanged += dgvTipos_SelectionChanged;
            
            pnlGestaoTemas.Controls.Add(lblTemasTitulo);
            pnlGestaoTemas.Controls.Add(lblTemaTipo);
            pnlGestaoTemas.Controls.Add(txtTemaTipo);
            pnlGestaoTemas.Controls.Add(lblTemaPreco);
            pnlGestaoTemas.Controls.Add(numTemaPreco);
            pnlGestaoTemas.Controls.Add(btnGravarTema);
            pnlGestaoTemas.Controls.Add(dgvTemas);
            pnlGestaoTemas.Location = new Point(0, 0);
            pnlGestaoTemas.Name = "pnlGestaoTemas";
            pnlGestaoTemas.Size = new Size(200, 100);
            pnlGestaoTemas.TabIndex = 4;
            pnlGestaoTemas.Visible = false;
            
            lblTemasTitulo.AutoSize = true;
            lblTemasTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTemasTitulo.Location = new Point(20, 20);
            lblTemasTitulo.Name = "lblTemasTitulo";
            lblTemasTitulo.Size = new Size(266, 25);
            lblTemasTitulo.TabIndex = 0;
            lblTemasTitulo.Text = "Gestão de Temas (Animação)";
            
            lblTemaTipo.Location = new Point(0, 0);
            lblTemaTipo.Name = "lblTemaTipo";
            lblTemaTipo.Size = new Size(100, 23);
            lblTemaTipo.TabIndex = 1;
             
            txtTemaTipo.Location = new Point(0, 0);
            txtTemaTipo.Name = "txtTemaTipo";
            txtTemaTipo.Size = new Size(100, 23);
            txtTemaTipo.TabIndex = 2;
            
            lblTemaPreco.AutoSize = true;
            lblTemaPreco.Location = new Point(20, 60);
            lblTemaPreco.Name = "lblTemaPreco";
            lblTemaPreco.Size = new Size(57, 15);
            lblTemaPreco.TabIndex = 3;
            lblTemaPreco.Text = "Preço (€):";
            
            numTemaPreco.DecimalPlaces = 2;
            numTemaPreco.Location = new Point(20, 80);
            numTemaPreco.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numTemaPreco.Name = "numTemaPreco";
            numTemaPreco.Size = new Size(200, 23);
            numTemaPreco.TabIndex = 4;
             
            btnGravarTema.Location = new Point(20, 180);
            btnGravarTema.Name = "btnGravarTema";
            btnGravarTema.Size = new Size(200, 40);
            btnGravarTema.TabIndex = 5;
            btnGravarTema.Text = "Registar Tema";
            btnGravarTema.Click += btnGravarTema_Click;
            
            dgvTemas.AllowUserToAddRows = false;
            dgvTemas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTemas.Location = new Point(250, 60);
            dgvTemas.Name = "dgvTemas";
            dgvTemas.ReadOnly = true;
            dgvTemas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTemas.Size = new Size(470, 300);
            dgvTemas.TabIndex = 6;

            lblEventosTitulo.AutoSize = true;
            lblEventosTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblEventosTitulo.Location = new System.Drawing.Point(20, 20);
            lblEventosTitulo.Text = "Agenda Geral de Eventos";

            dgvEventos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEventos.Location = new System.Drawing.Point(20, 60);
            dgvEventos.Size = new System.Drawing.Size(700, 350);
            dgvEventos.AllowUserToAddRows = false;
            dgvEventos.ReadOnly = true;
            dgvEventos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEventos.CellDoubleClick += dgvEventos_CellDoubleClick;

            pnlListaEventos.Controls.Add(this.lblEventosTitulo);
            pnlListaEventos.Controls.Add(this.dgvEventos);
            pnlContainerPrincipal.Controls.Add(this.pnlListaEventos);
            pnlListaEventos.Visible = false;

            pnlGestaoMenus.Controls.Add(lblMenusTitulo);
            pnlGestaoMenus.Controls.Add(lblMenuNumero);
            pnlGestaoMenus.Controls.Add(numMenuNumero);
            pnlGestaoMenus.Controls.Add(lblMenuPreco);
            pnlGestaoMenus.Controls.Add(numMenuPreco);
            pnlGestaoMenus.Controls.Add(btnGravarMenu);
            pnlGestaoMenus.Controls.Add(dgvMenus);
            pnlGestaoMenus.Location = new Point(0, 0);
            pnlGestaoMenus.Name = "pnlGestaoMenus";
            pnlGestaoMenus.Size = new Size(200, 100);
            pnlGestaoMenus.TabIndex = 5;
            pnlGestaoMenus.Visible = false;
           
            lblMenusTitulo.AutoSize = true;
            lblMenusTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblMenusTitulo.Location = new Point(20, 20);
            lblMenusTitulo.Name = "lblMenusTitulo";
            lblMenusTitulo.Size = new Size(260, 25);
            lblMenusTitulo.TabIndex = 0;
            lblMenusTitulo.Text = "Gestão de Menus (Catering)";
            
            lblMenuNumero.AutoSize = true;
            lblMenuNumero.Location = new Point(20, 60);
            lblMenuNumero.Name = "lblMenuNumero";
            lblMenuNumero.Size = new Size(105, 15);
            lblMenuNumero.TabIndex = 1;
            lblMenuNumero.Text = "Número do Menu:";
             
            numMenuNumero.Location = new Point(20, 80);
            numMenuNumero.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMenuNumero.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMenuNumero.Name = "numMenuNumero";
            numMenuNumero.Size = new Size(200, 23);
            numMenuNumero.TabIndex = 2;
            numMenuNumero.Value = new decimal(new int[] { 1, 0, 0, 0 });
           
            lblMenuPreco.AutoSize = true;
            lblMenuPreco.Location = new Point(20, 115);
            lblMenuPreco.Name = "lblMenuPreco";
            lblMenuPreco.Size = new Size(112, 15);
            lblMenuPreco.TabIndex = 3;
            lblMenuPreco.Text = "Preço por Menu (€):";
             
            numMenuPreco.DecimalPlaces = 2;
            numMenuPreco.Location = new Point(20, 135);
            numMenuPreco.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numMenuPreco.Name = "numMenuPreco";
            numMenuPreco.Size = new Size(200, 23);
            numMenuPreco.TabIndex = 4;
            
            btnGravarMenu.Location = new Point(20, 180);
            btnGravarMenu.Name = "btnGravarMenu";
            btnGravarMenu.Size = new Size(200, 40);
            btnGravarMenu.TabIndex = 5;
            btnGravarMenu.Text = "Registar Menu";
            btnGravarMenu.Click += btnGravarMenu_Click;
             
            dgvMenus.AllowUserToAddRows = false;
            dgvMenus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenus.Location = new Point(250, 60);
            dgvMenus.Name = "dgvMenus";
            dgvMenus.ReadOnly = true;
            dgvMenus.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenus.Size = new Size(470, 300);
            dgvMenus.TabIndex = 6;
          
            ClientSize = new Size(900, 480);
            Controls.Add(pnlContainerPrincipal);
            Controls.Add(pnlTopo);
            Name = "Form1";
            Text = "Gestão de Eventos - Painel Principal";
            Load += Form1_Load;
            pnlTopo.ResumeLayout(false);
            pnlContainerPrincipal.ResumeLayout(false);
            pnlListaClientes.ResumeLayout(false);
            pnlListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            pnlRegistoCliente.ResumeLayout(false);
            pnlRegistoCliente.PerformLayout();
            pnlRegistoLocal.ResumeLayout(false);
            pnlRegistoLocal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLocalPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLocalCapacidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLocais).EndInit();
            pnlRegistoTipoEvento.ResumeLayout(false);
            pnlRegistoTipoEvento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTipos).EndInit();
            pnlGestaoTemas.ResumeLayout(false);
            pnlGestaoTemas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTemaPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTemas).EndInit();
            pnlGestaoMenus.ResumeLayout(false);
            pnlGestaoMenus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvEventos)).EndInit();
            pnlListaEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numMenuNumero).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMenuPreco).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMenus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTopo;
        private System.Windows.Forms.Button btnNavLista;
        private System.Windows.Forms.Button btnNavNovoCliente;
        private System.Windows.Forms.Button btnNavLocal;
        private System.Windows.Forms.Button btnNavTipo;
        private System.Windows.Forms.Button btnNavTemas;
        private System.Windows.Forms.Button btnNavMenus;

        private System.Windows.Forms.Panel pnlContainerPrincipal;

        private System.Windows.Forms.Panel pnlListaClientes;
        private System.Windows.Forms.Label lblPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnSeguinte;

        private System.Windows.Forms.Panel pnlRegistoCliente;
        private System.Windows.Forms.Label lblRegCliTitulo;
        private System.Windows.Forms.TextBox txtRegNIF;
        private System.Windows.Forms.TextBox txtRegNome;
        private System.Windows.Forms.TextBox txtRegEmail;
        private System.Windows.Forms.TextBox txtRegTelefone;
        private System.Windows.Forms.Button btnGravarCliente;

        private System.Windows.Forms.Panel pnlRegistoLocal;
        private System.Windows.Forms.Button btnGravarLocal;
        private System.Windows.Forms.Label lblLocalTitulo;
        private System.Windows.Forms.TextBox txtLocalNome;
        private System.Windows.Forms.TextBox txtLocalMorada;
        private System.Windows.Forms.NumericUpDown numLocalPreco;
        private System.Windows.Forms.NumericUpDown numLocalCapacidade;
        private System.Windows.Forms.DataGridView dgvLocais;
        private System.Windows.Forms.Label lblLocalPreco;
        private System.Windows.Forms.Label lblLocalCapacidade;

        private System.Windows.Forms.Panel pnlRegistoTipoEvento;
        private System.Windows.Forms.Button btnGravarTipo;
        private System.Windows.Forms.Label lblTipoTitulo;
        private System.Windows.Forms.TextBox txtTipoNome;
        private System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.Label lblAssociacaoTitulo;
        private System.Windows.Forms.CheckedListBox chkAtividadesAssociadas;
        private System.Windows.Forms.Button btnGuardarAssociacoes;

        private System.Windows.Forms.Panel pnlGestaoTemas;
        private System.Windows.Forms.Label lblTemasTitulo;
        private System.Windows.Forms.Label lblTemaTipo;
        private System.Windows.Forms.TextBox txtTemaTipo;
        private System.Windows.Forms.Label lblTemaPreco;
        private System.Windows.Forms.NumericUpDown numTemaPreco;
        private System.Windows.Forms.Button btnGravarTema;
        private System.Windows.Forms.DataGridView dgvTemas;

        private System.Windows.Forms.Panel pnlGestaoMenus;
        private System.Windows.Forms.Label lblMenusTitulo;
        private System.Windows.Forms.Label lblMenuNumero;
        private System.Windows.Forms.NumericUpDown numMenuNumero;
        private System.Windows.Forms.Label lblMenuPreco;
        private System.Windows.Forms.NumericUpDown numMenuPreco;
        private System.Windows.Forms.Button btnGravarMenu;
        private System.Windows.Forms.DataGridView dgvMenus;

        private System.Windows.Forms.Button btnNavEventos;
        private System.Windows.Forms.Panel pnlListaEventos;
        private System.Windows.Forms.Label lblEventosTitulo;
        private System.Windows.Forms.DataGridView dgvEventos;
    }
}