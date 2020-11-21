namespace GUI
{
    partial class frmItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtAno = new System.Windows.Forms.DateTimePicker();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAtores = new System.Windows.Forms.TextBox();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.btnImagem = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.txtCusto = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVAluguel = new System.Windows.Forms.MaskedTextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtAdquirido = new System.Windows.Forms.DateTimePicker();
            this.txtGenero = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Barras:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(98, 191);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(341, 20);
            this.txtCod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Título:";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(47, 12);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(210, 20);
            this.txtTitulo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gênero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Tag = "";
            this.label5.Text = "Tipo:";
            // 
            // dtAno
            // 
            this.dtAno.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAno.Location = new System.Drawing.Point(318, 38);
            this.dtAno.Name = "dtAno";
            this.dtAno.Size = new System.Drawing.Size(121, 20);
            this.dtAno.TabIndex = 8;
            this.dtAno.Value = new System.DateTime(2020, 11, 20, 0, 0, 0, 0);
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "DVD",
            "BLU-RAY"});
            this.cbTipo.Location = new System.Drawing.Point(318, 64);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data Adquirida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(234, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Valor de custo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Atores:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Diretor:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Foto da Capa:";
            // 
            // txtAtores
            // 
            this.txtAtores.Location = new System.Drawing.Point(47, 67);
            this.txtAtores.Multiline = true;
            this.txtAtores.Name = "txtAtores";
            this.txtAtores.Size = new System.Drawing.Size(180, 70);
            this.txtAtores.TabIndex = 18;
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(47, 38);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(180, 20);
            this.txtDiretor.TabIndex = 19;
            // 
            // btnImagem
            // 
            this.btnImagem.Location = new System.Drawing.Point(81, 150);
            this.btnImagem.Name = "btnImagem";
            this.btnImagem.Size = new System.Drawing.Size(121, 20);
            this.btnImagem.TabIndex = 20;
            this.btnImagem.Text = "Inserir";
            this.btnImagem.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(465, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(121, 20);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(694, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 21);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(465, 36);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(121, 21);
            this.btnAtualizar.TabIndex = 23;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(694, 36);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(121, 21);
            this.btnExcluir.TabIndex = 24;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Location = new System.Drawing.Point(12, 233);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.Size = new System.Drawing.Size(1125, 349);
            this.dgvFilmes.TabIndex = 25;
            // 
            // txtCusto
            // 
            this.txtCusto.Location = new System.Drawing.Point(318, 118);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(121, 20);
            this.txtCusto.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(225, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Valor de Aluguel:";
            // 
            // txtVAluguel
            // 
            this.txtVAluguel.Location = new System.Drawing.Point(318, 147);
            this.txtVAluguel.Name = "txtVAluguel";
            this.txtVAluguel.Size = new System.Drawing.Size(121, 20);
            this.txtVAluguel.TabIndex = 28;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(592, 13);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(379, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // dtAdquirido
            // 
            this.dtAdquirido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdquirido.Location = new System.Drawing.Point(318, 92);
            this.dtAdquirido.Name = "dtAdquirido";
            this.dtAdquirido.Size = new System.Drawing.Size(121, 20);
            this.dtAdquirido.TabIndex = 31;
            this.dtAdquirido.Value = new System.DateTime(2020, 11, 20, 0, 0, 0, 0);
            // 
            // txtGenero
            // 
            this.txtGenero.FormattingEnabled = true;
            this.txtGenero.Items.AddRange(new object[] {
            "Romance",
            "Ação",
            "Drama",
            "Aventura",
            "Infantil",
            "Futurista",
            "Terror"});
            this.txtGenero.Location = new System.Drawing.Point(318, 11);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(121, 21);
            this.txtGenero.TabIndex = 32;
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 594);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.dtAdquirido);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtVAluguel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.dgvFilmes);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnImagem);
            this.Controls.Add(this.txtDiretor);
            this.Controls.Add(this.txtAtores);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.dtAno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Name = "frmItem";
            this.Text = "Registrar Item";
            this.Load += new System.EventHandler(this.frmItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtAno;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAtores;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Button btnImagem;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.MaskedTextBox txtCusto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtVAluguel;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtAdquirido;
        private System.Windows.Forms.ComboBox txtGenero;
    }
}