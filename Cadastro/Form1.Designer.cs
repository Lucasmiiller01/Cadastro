namespace Cadastro
{
    partial class Form1
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            this.Mês = new System.Windows.Forms.ComboBox();
            this.Ano = new System.Windows.Forms.ComboBox();
            this.Profissão = new System.Windows.Forms.TextBox();
            this.País = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.Rest = new System.Windows.Forms.ComboBox();
            this.Sangue = new System.Windows.Forms.ComboBox();
            this.Raça = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Filhos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.TextBox();
            this.DDD = new System.Windows.Forms.TextBox();
            this.Rua = new System.Windows.Forms.TextBox();
            this.RG = new System.Windows.Forms.TextBox();
            this.EstadoCivil = new System.Windows.Forms.ComboBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.Sexualidade = new System.Windows.Forms.ComboBox();
            this.Dia = new System.Windows.Forms.ComboBox();
            this.Nº = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Filhos)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mês
            // 
            this.Mês.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Mês.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mês.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mês.ForeColor = System.Drawing.Color.Silver;
            this.Mês.FormattingEnabled = true;
            this.Mês.Items.AddRange(new object[] {
            "Jan",
            "Fev",
            "Mar",
            "Abr",
            "Mai",
            "Jun",
            "Jul",
            "Ago",
            "Set",
            "Out",
            "Nov",
            "Dez"});
            this.Mês.Location = new System.Drawing.Point(827, 61);
            this.Mês.Name = "Mês";
            this.Mês.Size = new System.Drawing.Size(72, 27);
            this.Mês.TabIndex = 9;
            this.Mês.Text = "Mês";
            this.Mês.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Mês.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Ano
            // 
            this.Ano.AutoCompleteCustomSource.AddRange(new string[] {
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930"});
            this.Ano.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Ano.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ano.DropDownHeight = 290;
            this.Ano.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ano.ForeColor = System.Drawing.Color.Silver;
            this.Ano.FormattingEnabled = true;
            this.Ano.IntegralHeight = false;
            this.Ano.Items.AddRange(new object[] {
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930"});
            this.Ano.Location = new System.Drawing.Point(905, 61);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(74, 27);
            this.Ano.TabIndex = 10;
            this.Ano.Text = "Ano";
            this.Ano.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Ano.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Profissão
            // 
            this.Profissão.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Profissão, 3);
            this.Profissão.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Profissão.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profissão.ForeColor = System.Drawing.Color.Silver;
            this.Profissão.Location = new System.Drawing.Point(749, 119);
            this.Profissão.Name = "Profissão";
            this.Profissão.Size = new System.Drawing.Size(230, 29);
            this.Profissão.TabIndex = 13;
            this.Profissão.Text = "Profissão";
            this.Profissão.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // País
            // 
            this.País.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.País, 3);
            this.País.Dock = System.Windows.Forms.DockStyle.Fill;
            this.País.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.País.ForeColor = System.Drawing.Color.Silver;
            this.País.Location = new System.Drawing.Point(749, 177);
            this.País.Name = "País";
            this.País.Size = new System.Drawing.Size(230, 29);
            this.País.TabIndex = 16;
            this.País.Text = "País";
            this.País.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // Cidade
            // 
            this.Cidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Cidade, 3);
            this.Cidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.ForeColor = System.Drawing.Color.Silver;
            this.Cidade.Location = new System.Drawing.Point(749, 235);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(230, 29);
            this.Cidade.TabIndex = 18;
            this.Cidade.Text = "Cidade";
            this.Cidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // Complemento
            // 
            this.Complemento.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Complemento, 2);
            this.Complemento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Complemento.ForeColor = System.Drawing.Color.Silver;
            this.Complemento.Location = new System.Drawing.Point(827, 293);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(152, 29);
            this.Complemento.TabIndex = 20;
            this.Complemento.Text = "Complemento";
            // 
            // Rest
            // 
            this.Rest.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Rest, 3);
            this.Rest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rest.DropDownHeight = 290;
            this.Rest.DropDownWidth = 200;
            this.Rest.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rest.ForeColor = System.Drawing.Color.Silver;
            this.Rest.FormattingEnabled = true;
            this.Rest.IntegralHeight = false;
            this.Rest.Items.AddRange(new object[] {
            "@gmail.com",
            "@gmail.com.br",
            "@hotmail.com",
            "@hotmail.com.br",
            "@live.com",
            "@yahoo.com",
            "@yahoo.com.br",
            "@outlook.com",
            "@outlook.com.br",
            "@cesar.org.br"});
            this.Rest.Location = new System.Drawing.Point(749, 409);
            this.Rest.Name = "Rest";
            this.Rest.Size = new System.Drawing.Size(230, 27);
            this.Rest.TabIndex = 26;
            this.Rest.Text = "@.";
            this.Rest.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Rest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Sangue
            // 
            this.Sangue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Sangue, 2);
            this.Sangue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sangue.DropDownHeight = 290;
            this.Sangue.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sangue.ForeColor = System.Drawing.Color.Silver;
            this.Sangue.FormattingEnabled = true;
            this.Sangue.IntegralHeight = false;
            this.Sangue.Items.AddRange(new object[] {
            "O-",
            "O+",
            "A-",
            "A+",
            "B-",
            "B+",
            "AB-",
            "AB+"});
            this.Sangue.Location = new System.Drawing.Point(827, 467);
            this.Sangue.Name = "Sangue";
            this.Sangue.Size = new System.Drawing.Size(152, 27);
            this.Sangue.TabIndex = 27;
            this.Sangue.Text = "Sangue";
            this.Sangue.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Sangue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Raça
            // 
            this.Raça.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Raça, 2);
            this.Raça.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Raça.DropDownHeight = 290;
            this.Raça.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Raça.ForeColor = System.Drawing.Color.Silver;
            this.Raça.FormattingEnabled = true;
            this.Raça.IntegralHeight = false;
            this.Raça.Items.AddRange(new object[] {
            "Humano",
            "Negro",
            "Asiático",
            "Indiano",
            "Índio",
            "Pobre",
            "Judeu",
            "Gay"});
            this.Raça.Location = new System.Drawing.Point(827, 351);
            this.Raça.Name = "Raça";
            this.Raça.Size = new System.Drawing.Size(152, 27);
            this.Raça.TabIndex = 28;
            this.Raça.Text = "Raça";
            this.Raça.TextChanged += new System.EventHandler(this.ComboPlay);
            this.Raça.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.tableLayoutPanel1.SetRowSpan(this.listBox1, 11);
            this.listBox1.Size = new System.Drawing.Size(485, 633);
            this.listBox1.TabIndex = 36;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.Analise);
            // 
            // button4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button4, 3);
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(749, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 52);
            this.button4.TabIndex = 38;
            this.button4.Text = "Pesquisar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Check);
            // 
            // button2
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button2, 3);
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(749, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(230, 52);
            this.button2.TabIndex = 40;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.Controls.Add(this.Filhos, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.Nº, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.Dia, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Complemento, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.Ano, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Mês, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Sexualidade, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Rest, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Email, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.Nome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Profissão, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.EstadoCivil, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.País, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.RG, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Cidade, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Rua, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.DDD, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.Telefone, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Raça, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.Sangue, 3, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090908F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 639);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // Filhos
            // 
            this.Filhos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Filhos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Filhos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Filhos.ForeColor = System.Drawing.Color.Silver;
            this.Filhos.Location = new System.Drawing.Point(749, 467);
            this.Filhos.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Filhos.Name = "Filhos";
            this.Filhos.Size = new System.Drawing.Size(72, 26);
            this.Filhos.TabIndex = 29;
            this.Filhos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(494, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nº de Filhos:";
            // 
            // Telefone
            // 
            this.Telefone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Telefone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.Color.Silver;
            this.Telefone.Location = new System.Drawing.Point(494, 351);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(249, 29);
            this.Telefone.TabIndex = 23;
            this.Telefone.Text = "Telefone";
            this.Telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorNum);
            // 
            // DDD
            // 
            this.DDD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DDD.ForeColor = System.Drawing.Color.Silver;
            this.DDD.Location = new System.Drawing.Point(749, 351);
            this.DDD.Name = "DDD";
            this.DDD.Size = new System.Drawing.Size(72, 29);
            this.DDD.TabIndex = 24;
            this.DDD.Text = "DDD";
            this.DDD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorNum);
            // 
            // Rua
            // 
            this.Rua.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Rua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rua.ForeColor = System.Drawing.Color.Silver;
            this.Rua.Location = new System.Drawing.Point(494, 293);
            this.Rua.Name = "Rua";
            this.Rua.Size = new System.Drawing.Size(249, 29);
            this.Rua.TabIndex = 19;
            this.Rua.Text = "Rua";
            this.Rua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // RG
            // 
            this.RG.BackColor = System.Drawing.Color.WhiteSmoke;
            this.RG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RG.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG.ForeColor = System.Drawing.Color.Silver;
            this.RG.Location = new System.Drawing.Point(494, 235);
            this.RG.Name = "RG";
            this.RG.Size = new System.Drawing.Size(249, 29);
            this.RG.TabIndex = 17;
            this.RG.Text = "RG";
            this.RG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // EstadoCivil
            // 
            this.EstadoCivil.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EstadoCivil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EstadoCivil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoCivil.ForeColor = System.Drawing.Color.Silver;
            this.EstadoCivil.FormattingEnabled = true;
            this.EstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Solteiro",
            "Viúvo"});
            this.EstadoCivil.Location = new System.Drawing.Point(494, 177);
            this.EstadoCivil.Name = "EstadoCivil";
            this.EstadoCivil.Size = new System.Drawing.Size(249, 32);
            this.EstadoCivil.TabIndex = 15;
            this.EstadoCivil.Text = "Estado Civil";
            this.EstadoCivil.TextChanged += new System.EventHandler(this.ComboPlay);
            this.EstadoCivil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Impedir);
            // 
            // Nome
            // 
            this.Nome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.Color.Silver;
            this.Nome.Location = new System.Drawing.Point(494, 61);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(249, 29);
            this.Nome.TabIndex = 4;
            this.Nome.Text = "Nome";
            this.Nome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AprovadorText);
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Email.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Silver;
            this.Email.Location = new System.Drawing.Point(494, 409);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(249, 29);
            this.Email.TabIndex = 25;
            this.Email.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(3, 34);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(197, 18);
            label2.TabIndex = 6;
            label2.Text = "Ou procure alguém na lista.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(181, 34);
            label1.TabIndex = 5;
            label1.Text = "Cadastre-se";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(label1);
            this.flowLayoutPanel1.Controls.Add(label2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(494, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(249, 52);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(494, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.TestAll);
            // 
            // Sexualidade
            // 
            this.Sexualidade.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Sexualidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sexualidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sexualidade.ForeColor = System.Drawing.Color.Silver;
            this.Sexualidade.FormattingEnabled = true;
            this.Sexualidade.Items.AddRange(new object[] {
            "Homem",
            "Mulher",
            "Viado",
            "Gata",
            "Sapatão",
            "Indeciso"});
            this.Sexualidade.Location = new System.Drawing.Point(494, 119);
            this.Sexualidade.Name = "Sexualidade";
            this.Sexualidade.Size = new System.Drawing.Size(249, 32);
            this.Sexualidade.TabIndex = 39;
            this.Sexualidade.Text = "Sexualidade";
            // 
            // Dia
            // 
            this.Dia.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Dia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Dia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.Dia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dia.DropDownHeight = 290;
            this.Dia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia.ForeColor = System.Drawing.Color.Silver;
            this.Dia.FormattingEnabled = true;
            this.Dia.IntegralHeight = false;
            this.Dia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.Dia.Location = new System.Drawing.Point(749, 61);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(72, 27);
            this.Dia.TabIndex = 46;
            this.Dia.Text = "Dia";
            // 
            // Nº
            // 
            this.Nº.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Nº.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nº.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nº.ForeColor = System.Drawing.Color.Silver;
            this.Nº.Location = new System.Drawing.Point(749, 293);
            this.Nº.Name = "Nº";
            this.Nº.Size = new System.Drawing.Size(72, 29);
            this.Nº.TabIndex = 47;
            this.Nº.Text = "Nº";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 639);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Cadastro";
            this.Load += new System.EventHandler(this.Recuperar);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Filhos)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Mês;
        private System.Windows.Forms.ComboBox Ano;
        private System.Windows.Forms.TextBox Profissão;
        private System.Windows.Forms.TextBox País;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.ComboBox Rest;
        private System.Windows.Forms.ComboBox Sangue;
        private System.Windows.Forms.ComboBox Raça;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown Filhos;
        private System.Windows.Forms.TextBox Nº;
        private System.Windows.Forms.ComboBox Dia;
        private System.Windows.Forms.ComboBox Sexualidade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.ComboBox EstadoCivil;
        private System.Windows.Forms.TextBox RG;
        private System.Windows.Forms.TextBox Rua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DDD;
        private System.Windows.Forms.TextBox Telefone;
    }
}

