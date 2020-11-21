namespace GUI
{
    partial class frmPermitirLogin
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
            this.txtCdFuncionario = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.CdFuncionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsLogin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DsSenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Funcionário:";
            // 
            // txtCdFuncionario
            // 
            this.txtCdFuncionario.Location = new System.Drawing.Point(108, 6);
            this.txtCdFuncionario.Name = "txtCdFuncionario";
            this.txtCdFuncionario.Size = new System.Drawing.Size(100, 20);
            this.txtCdFuncionario.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(229, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Ativar/Desativar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdFuncionario,
            this.DsLogin,
            this.DsSenha,
            this.Status});
            this.dgvFuncionarios.Location = new System.Drawing.Point(12, 215);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.Size = new System.Drawing.Size(776, 223);
            this.dgvFuncionarios.TabIndex = 3;
            // 
            // CdFuncionario
            // 
            this.CdFuncionario.DataPropertyName = "CdFuncionario";
            this.CdFuncionario.HeaderText = "Código";
            this.CdFuncionario.Name = "CdFuncionario";
            // 
            // DsLogin
            // 
            this.DsLogin.DataPropertyName = "DsLogin";
            this.DsLogin.HeaderText = "Login";
            this.DsLogin.Name = "DsLogin";
            // 
            // DsSenha
            // 
            this.DsSenha.DataPropertyName = "DsSenha";
            this.DsSenha.HeaderText = "Senha";
            this.DsSenha.Name = "DsSenha";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Permissão";
            this.Status.Name = "Status";
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmPermitirLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvFuncionarios);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCdFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "frmPermitirLogin";
            this.Text = "frmPermitirLogin";
            this.Load += new System.EventHandler(this.frmPermitirLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCdFuncionario;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFuncionario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsLogin;
        private System.Windows.Forms.DataGridViewTextBoxColumn DsSenha;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Status;
    }
}