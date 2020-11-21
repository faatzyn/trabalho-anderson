namespace GUI
{
    partial class frmCadastroFuncionario
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.cbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtEndereço = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.cbEstados = new System.Windows.Forms.ComboBox();
            this.txtDsSenha = new System.Windows.Forms.TextBox();
            this.txtDsLogin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(436, 220);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(106, 46);
            this.btnEnviar.TabIndex = 54;
            this.btnEnviar.Text = "Cadastrar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.cbSexo.Location = new System.Drawing.Point(70, 63);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(92, 21);
            this.cbSexo.TabIndex = 51;
            // 
            // dtNascimento
            // 
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(445, 12);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(97, 20);
            this.dtNascimento.TabIndex = 50;
            // 
            // cbEstadoCivil
            // 
            this.cbEstadoCivil.FormattingEnabled = true;
            this.cbEstadoCivil.Items.AddRange(new object[] {
            "Solteiro(a)",
            "Casado(a)",
            "Viúvo(a)"});
            this.cbEstadoCivil.Location = new System.Drawing.Point(445, 38);
            this.cbEstadoCivil.Name = "cbEstadoCivil";
            this.cbEstadoCivil.Size = new System.Drawing.Size(97, 21);
            this.cbEstadoCivil.TabIndex = 49;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(69, 168);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(93, 20);
            this.txtCidade.TabIndex = 45;
            // 
            // txtEndereço
            // 
            this.txtEndereço.Location = new System.Drawing.Point(68, 140);
            this.txtEndereço.Name = "txtEndereço";
            this.txtEndereço.Size = new System.Drawing.Size(258, 20);
            this.txtEndereço.TabIndex = 44;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(69, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(257, 20);
            this.txtEmail.TabIndex = 42;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(68, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(258, 20);
            this.txtNome.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "E-mail:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(397, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Celular:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Telefone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "CEP:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Cidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Endereço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "RG:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Estado Civil:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Data de Nascimento:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(70, 91);
            this.txtRG.Mask = "00.000.000-a";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(92, 20);
            this.txtRG.TabIndex = 56;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(70, 114);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(92, 20);
            this.txtCPF.TabIndex = 57;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(445, 95);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(97, 20);
            this.txtCelular.TabIndex = 58;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(68, 194);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(66, 20);
            this.txtCEP.TabIndex = 59;
            // 
            // cbEstados
            // 
            this.cbEstados.FormattingEnabled = true;
            this.cbEstados.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO",
            "DF"});
            this.cbEstados.Location = new System.Drawing.Point(218, 168);
            this.cbEstados.Name = "cbEstados";
            this.cbEstados.Size = new System.Drawing.Size(58, 21);
            this.cbEstados.TabIndex = 60;
            // 
            // txtDsSenha
            // 
            this.txtDsSenha.Location = new System.Drawing.Point(68, 246);
            this.txtDsSenha.Name = "txtDsSenha";
            this.txtDsSenha.Size = new System.Drawing.Size(100, 20);
            this.txtDsSenha.TabIndex = 64;
            this.txtDsSenha.UseSystemPasswordChar = true;
            // 
            // txtDsLogin
            // 
            this.txtDsLogin.Location = new System.Drawing.Point(68, 220);
            this.txtDsLogin.Name = "txtDsLogin";
            this.txtDsLogin.Size = new System.Drawing.Size(100, 20);
            this.txtDsLogin.TabIndex = 63;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 62;
            this.label14.Text = "Senha:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 61;
            this.label15.Text = "Usuário:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(445, 69);
            this.txtTelefone.Mask = "(00) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(97, 20);
            this.txtTelefone.TabIndex = 65;
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToOrderColumns = true;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Location = new System.Drawing.Point(12, 387);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(1127, 300);
            this.dgvFuncionarios.TabIndex = 66;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(668, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(48, 20);
            this.txtBuscar.TabIndex = 67;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(561, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 13);
            this.label16.TabIndex = 68;
            this.label16.Text = "Buscar pelo código:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(722, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 69;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(722, 39);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 70;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(722, 68);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 71;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 699);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDsSenha);
            this.Controls.Add(this.txtDsLogin);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbEstados);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.cbEstadoCivil);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEndereço);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastroFuncionario";
            this.Text = "frmCadastroFuncionario";
            this.Load += new System.EventHandler(this.frmCadastroFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.ComboBox cbEstadoCivil;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtEndereço;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.ComboBox cbEstados;
        private System.Windows.Forms.TextBox txtDsSenha;
        private System.Windows.Forms.TextBox txtDsLogin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnUpdate;
    }
}