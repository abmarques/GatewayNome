namespace GatewayNome {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.dtgView = new System.Windows.Forms.DataGridView();
            this.uso_gateway_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operadora_cartao_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cobranca_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluno_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricula_aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aluno_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrato_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrato_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresa_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgView
            // 
            this.dtgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uso_gateway_nome,
            this.operadora_cartao_nome,
            this.cobranca_desc,
            this.aluno_nome,
            this.matricula_aluno,
            this.aluno_status,
            this.contrato_id,
            this.contrato_status,
            this.empresa_nome});
            this.dtgView.Location = new System.Drawing.Point(13, 125);
            this.dtgView.Name = "dtgView";
            this.dtgView.Size = new System.Drawing.Size(632, 150);
            this.dtgView.TabIndex = 0;
            // 
            // uso_gateway_nome
            // 
            this.uso_gateway_nome.DataPropertyName = "uso_gateway_nome";
            this.uso_gateway_nome.HeaderText = "GATEWAY NOME";
            this.uso_gateway_nome.Name = "uso_gateway_nome";
            this.uso_gateway_nome.Width = 150;
            // 
            // operadora_cartao_nome
            // 
            this.operadora_cartao_nome.DataPropertyName = "operadora_cartao_nome";
            this.operadora_cartao_nome.HeaderText = "OPERADORA CARTAO";
            this.operadora_cartao_nome.Name = "operadora_cartao_nome";
            this.operadora_cartao_nome.Width = 150;
            // 
            // cobranca_desc
            // 
            this.cobranca_desc.DataPropertyName = "cobranca_desc";
            this.cobranca_desc.HeaderText = "PLANO TIPO";
            this.cobranca_desc.Name = "cobranca_desc";
            // 
            // aluno_nome
            // 
            this.aluno_nome.DataPropertyName = "aluno_nome";
            this.aluno_nome.HeaderText = "NOME ALUNO";
            this.aluno_nome.Name = "aluno_nome";
            this.aluno_nome.Width = 150;
            // 
            // matricula_aluno
            // 
            this.matricula_aluno.DataPropertyName = "matricula_aluno";
            this.matricula_aluno.HeaderText = "ALUNO MATRICULA";
            this.matricula_aluno.Name = "matricula_aluno";
            this.matricula_aluno.Width = 150;
            // 
            // aluno_status
            // 
            this.aluno_status.DataPropertyName = "status_aluno";
            this.aluno_status.HeaderText = "ALUNO STATUS";
            this.aluno_status.Name = "aluno_status";
            this.aluno_status.Width = 130;
            // 
            // contrato_id
            // 
            this.contrato_id.DataPropertyName = "contrato_id";
            this.contrato_id.HeaderText = "CONTRATO ID";
            this.contrato_id.Name = "contrato_id";
            this.contrato_id.Width = 130;
            // 
            // contrato_status
            // 
            this.contrato_status.DataPropertyName = "contrato_status";
            this.contrato_status.HeaderText = "CONTRATO STATUS";
            this.contrato_status.Name = "contrato_status";
            this.contrato_status.Width = 150;
            // 
            // empresa_nome
            // 
            this.empresa_nome.DataPropertyName = "empresa_nome";
            this.empresa_nome.HeaderText = "UNIDADE";
            this.empresa_nome.Name = "empresa_nome";
            this.empresa_nome.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(10, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "MATRÍCULA ALUNO:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMatricula.Location = new System.Drawing.Point(134, 54);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(109, 25);
            this.txtMatricula.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnPesquisar.Location = new System.Drawing.Point(490, 54);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(72, 25);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAjuda,
            this.mnuSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuAjuda
            // 
            this.mnuAjuda.Name = "mnuAjuda";
            this.mnuAjuda.Size = new System.Drawing.Size(56, 20);
            this.mnuAjuda.Text = "AJUDA";
            this.mnuAjuda.Click += new System.EventHandler(this.MnuAjuda_Click);
            // 
            // mnuSobre
            // 
            this.mnuSobre.Name = "mnuSobre";
            this.mnuSobre.Size = new System.Drawing.Size(54, 20);
            this.mnuSobre.Text = "SOBRE";
            this.mnuSobre.Click += new System.EventHandler(this.MnuSobre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(261, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "UNIDADE:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(327, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(157, 25);
            this.comboBox1.TabIndex = 5;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(657, 291);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAjuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSobre;
        private System.Windows.Forms.DataGridViewTextBoxColumn uso_gateway_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn operadora_cartao_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cobranca_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricula_aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn aluno_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrato_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrato_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresa_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

