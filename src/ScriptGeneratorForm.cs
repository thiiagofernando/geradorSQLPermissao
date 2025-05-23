using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;


namespace GeradorSQLPermissao
{
    public partial class ScriptGeneratorForm : Form
    {
        private DataTable funcionalidadesTable;

        public ScriptGeneratorForm()
        {
            InitializeComponents();
            InitializeFuncionalidadesTable();
        }

        private void InitializeComponents()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblModulo = new System.Windows.Forms.Label();
            this.txtModulo = new System.Windows.Forms.TextBox();
            this.lblTela = new System.Windows.Forms.Label();
            this.txtTela = new System.Windows.Forms.TextBox();
            this.lblFuncionalidade = new System.Windows.Forms.Label();
            this.txtFuncionalidade = new System.Windows.Forms.TextBox();
            this.btnAddFuncionalidade = new System.Windows.Forms.Button();
            this.dgvFuncionalidades = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblModulo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtModulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTela, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTela, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFuncionalidade, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtFuncionalidade, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddFuncionalidade, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dgvFuncionalidades, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnGenerate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtResult, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblModulo
            // 
            this.lblModulo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModulo.AutoSize = true;
            this.lblModulo.Location = new System.Drawing.Point(112, 11);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(45, 13);
            this.lblModulo.TabIndex = 0;
            this.lblModulo.Text = "Módulo:";
            // 
            // txtModulo
            // 
            this.txtModulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModulo.Location = new System.Drawing.Point(163, 8);
            this.txtModulo.Name = "txtModulo";
            this.txtModulo.Size = new System.Drawing.Size(474, 20);
            this.txtModulo.TabIndex = 1;
            // 
            // lblTela
            // 
            this.lblTela.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTela.AutoSize = true;
            this.lblTela.Location = new System.Drawing.Point(126, 47);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(31, 13);
            this.lblTela.TabIndex = 2;
            this.lblTela.Text = "Tela:";
            // 
            // txtTela
            // 
            this.txtTela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTela.Location = new System.Drawing.Point(163, 44);
            this.txtTela.Name = "txtTela";
            this.txtTela.Size = new System.Drawing.Size(474, 20);
            this.txtTela.TabIndex = 3;
            // 
            // lblFuncionalidade
            // 
            this.lblFuncionalidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFuncionalidade.AutoSize = true;
            this.lblFuncionalidade.Location = new System.Drawing.Point(77, 83);
            this.lblFuncionalidade.Name = "lblFuncionalidade";
            this.lblFuncionalidade.Size = new System.Drawing.Size(80, 13);
            this.lblFuncionalidade.TabIndex = 4;
            this.lblFuncionalidade.Text = "Funcionalidade:";
            // 
            // txtFuncionalidade
            // 
            this.txtFuncionalidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFuncionalidade.Location = new System.Drawing.Point(163, 80);
            this.txtFuncionalidade.Name = "txtFuncionalidade";
            this.txtFuncionalidade.Size = new System.Drawing.Size(474, 20);
            this.txtFuncionalidade.TabIndex = 5;
            // 
            // btnAddFuncionalidade
            // 
            this.btnAddFuncionalidade.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddFuncionalidade.Location = new System.Drawing.Point(643, 78);
            this.btnAddFuncionalidade.Name = "btnAddFuncionalidade";
            this.btnAddFuncionalidade.Size = new System.Drawing.Size(75, 23);
            this.btnAddFuncionalidade.TabIndex = 6;
            this.btnAddFuncionalidade.Text = "Adicionar";
            this.btnAddFuncionalidade.UseVisualStyleBackColor = true;
            this.btnAddFuncionalidade.Click += new System.EventHandler(this.btnAddFuncionalidade_Click);
            // 
            // dgvFuncionalidades
            // 
            this.dgvFuncionalidades.AllowUserToAddRows = false;
            this.dgvFuncionalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFuncionalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvFuncionalidades, 3);
            this.dgvFuncionalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionalidades.Location = new System.Drawing.Point(3, 111);
            this.dgvFuncionalidades.Name = "dgvFuncionalidades";
            this.dgvFuncionalidades.Size = new System.Drawing.Size(794, 84);
            this.dgvFuncionalidades.TabIndex = 7;
            // 
            // btnGenerate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnGenerate, 3);
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGenerate.Location = new System.Drawing.Point(3, 201);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(794, 30);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Gerar Script";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtResult
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtResult, 3);
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 237);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(794, 210);
            this.txtResult.TabIndex = 9;
            // 
            // ScriptGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ScriptGeneratorForm";
            this.Text = "Gerador de Script SQL";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionalidades)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.TextBox txtModulo;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.TextBox txtTela;
        private System.Windows.Forms.Label lblFuncionalidade;
        private System.Windows.Forms.TextBox txtFuncionalidade;
        private System.Windows.Forms.Button btnAddFuncionalidade;
        private System.Windows.Forms.DataGridView dgvFuncionalidades;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtResult;


        private string RemoveAcentosECaracteresEspeciais(string texto)
        {
            string textoNormalizado = texto.Normalize(NormalizationForm.FormD);
            StringBuilder resultado = new StringBuilder();

            foreach (char c in textoNormalizado)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                {
                    resultado.Append(c);
                }
            }

            // Remove caracteres especiais e mantém o CamelCase
            string[] palavras = resultado.ToString()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(palavra => new string(palavra.Where(c => char.IsLetterOrDigit(c)).ToArray()))
                .Select(palavra => char.ToUpper(palavra[0]) + palavra.Substring(1))
                .ToArray();

            return string.Join("", palavras);
        }

        private void InitializeFuncionalidadesTable()
        {
            try
            {
                funcionalidadesTable = new DataTable();
                funcionalidadesTable.Columns.Add("Funcionalidade", typeof(string));

                dgvFuncionalidades.DataSource = funcionalidadesTable;

                // Remover a coluna "Remover" existente, se houver
                if (dgvFuncionalidades.Columns.Contains("Remover"))
                {
                    dgvFuncionalidades.Columns.Remove("Remover");
                }

                // Adicionar a coluna de botão "Remover"
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.HeaderText = "Remover";
                btnColumn.Text = "Remover";
                btnColumn.Name = "Remover";
                btnColumn.UseColumnTextForButtonValue = true;
                dgvFuncionalidades.Columns.Add(btnColumn);

                // Configurar a largura da coluna "Remover"
                dgvFuncionalidades.Columns["Remover"].Width = 70;

                // Configurar o modo de redimensionamento das colunas
                dgvFuncionalidades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvFuncionalidades.Columns["Funcionalidade"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvFuncionalidades.Columns["Remover"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

                dgvFuncionalidades.CellClick += DgvFuncionalidades_CellClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar a tabela de funcionalidades: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnAddFuncionalidade_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtFuncionalidade.Text))
            {
                funcionalidadesTable.Rows.Add(txtFuncionalidade.Text);
                txtFuncionalidade.Clear();
            }
        }

        private void DgvFuncionalidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFuncionalidades.Columns["Remover"].Index && e.RowIndex >= 0)
            {
                dgvFuncionalidades.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string modulo = txtModulo.Text;
            string tela = txtTela.Text;
            List<string> funcionalidades = new List<string>();

            // Coletando funcionalidades da DataGridView
            foreach (DataGridViewRow row in dgvFuncionalidades.Rows)
            {
                if (row.Cells["Funcionalidade"].Value != null)
                {
                    funcionalidades.Add(row.Cells["Funcionalidade"].Value.ToString());
                }
            }

            StringBuilder script = new StringBuilder();

            script.AppendLine("DECLARE @ID_MODULO INT;");
            script.AppendLine("DECLARE @ID_TELA INT;");
            script.AppendLine("DECLARE @ID_FUNCIONALIDADE INT;");
            script.AppendLine("-- Insert Módulo se não existir e captura ID");
            script.AppendLine($"IF NOT EXISTS (SELECT 1 FROM Modulos WHERE NOME = '{modulo}')");
            script.AppendLine("BEGIN");
            script.AppendLine($" INSERT INTO Modulos (NOME,ATIVO,DATA_CRIACAO,ID_USUARIO_CRIACAO,DATA_MODIFICACAO,ID_USUARIO_MODIFICACAO)");
            script.AppendLine($" VALUES ('{modulo}',1,GETDATE(),1000,GETDATE(),1000);");
            script.AppendLine(" SET @ID_MODULO = SCOPE_IDENTITY();");
            script.AppendLine("END");
            script.AppendLine("ELSE");
            script.AppendLine("BEGIN");
            script.AppendLine($" SELECT @ID_MODULO = ID FROM Modulos WHERE NOME = '{modulo}';");
            script.AppendLine("END");
            script.AppendLine("-- Insert Tela se não existir e captura ID");
            script.AppendLine($"IF NOT EXISTS (SELECT 1 FROM Telas WHERE NOME = '{tela}' AND ID_MODULO = @ID_MODULO)");
            script.AppendLine("BEGIN");
            script.AppendLine($" INSERT INTO Telas (NOME,ATIVO,DATA_CRIACAO,ID_USUARIO_CRIACAO,DATA_MODIFICACAO,ID_USUARIO_MODIFICACAO,ID_MODULO,ROTA,ROTA_PRIVADA)");
            script.AppendLine($" VALUES ('{tela}',1,GETDATE(),1000,GETDATE(),1000,@ID_MODULO,'/{RemoveAcentosECaracteresEspeciais(tela)}',1);");
            script.AppendLine(" SET @ID_TELA = SCOPE_IDENTITY();");
            script.AppendLine("END");
            script.AppendLine("ELSE");
            script.AppendLine("BEGIN");
            script.AppendLine($" SELECT @ID_TELA = ID FROM Telas WHERE NOME = '{tela}' AND ID_MODULO = @ID_MODULO;");
            script.AppendLine("END");
            script.AppendLine("-- Insert Funcionalidades se não existirem e insere em PerfisFuncionalidades");
            foreach (string funcionalidade in funcionalidades)
            {
                script.AppendLine($"IF NOT EXISTS (SELECT 1 FROM Funcionalidades WHERE NOME = '{funcionalidade}' AND ID_TELA = @ID_TELA)");
                script.AppendLine("BEGIN");
                script.AppendLine($" INSERT INTO Funcionalidades (NOME,ATIVO,ID_TELA,DATA_CRIACAO,ID_USUARIO_CRIACAO,DATA_MODIFICACAO,ID_USUARIO_MODIFICACAO)");
                script.AppendLine($" VALUES ('{funcionalidade}',1,@ID_TELA,GETDATE(),1000,GETDATE(),1000);");
                script.AppendLine(" SET @ID_FUNCIONALIDADE = SCOPE_IDENTITY();");
                script.AppendLine(" INSERT INTO PerfisFuncionalidades (ID_PERFIL, ID_FUNCIONALIDADE, DATA_CRIACAO, ID_USUARIO_CRIACAO, DATA_MODIFICACAO, ID_USUARIO_MODIFICACAO)");
                script.AppendLine(" VALUES(2, @ID_FUNCIONALIDADE, GetDate(), 1000, GetDate(), 1000);");
                script.AppendLine("END");
            }
            txtResult.Text = script.ToString();
        }

    }

}