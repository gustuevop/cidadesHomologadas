namespace verificadorDeCidadesHomologadas
{
    partial class frm_main
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
            this.lbl_apiEndpoint = new System.Windows.Forms.Label();
            this.lbl_apiEndpointText = new System.Windows.Forms.Label();
            this.gb_verificarPorNome = new System.Windows.Forms.GroupBox();
            this.lbl_resultadoText = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_verificarPorNome = new System.Windows.Forms.Button();
            this.cb_cidade = new System.Windows.Forms.ComboBox();
            this.cb_uf = new System.Windows.Forms.ComboBox();
            this.gb_verificarPorIBGE = new System.Windows.Forms.GroupBox();
            this.lbl_naoHomologadas = new System.Windows.Forms.Label();
            this.txt_naoHomologadas = new System.Windows.Forms.TextBox();
            this.lbl_homologadas = new System.Windows.Forms.Label();
            this.txt_homologadas = new System.Windows.Forms.TextBox();
            this.lbl_listeOsCodigos = new System.Windows.Forms.Label();
            this.txt_codigosIBGE = new System.Windows.Forms.TextBox();
            this.btn_verificarPorIBGE = new System.Windows.Forms.Button();
            this.lbl_token = new System.Windows.Forms.Label();
            this.txt_Token = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.gb_verificarPorNome.SuspendLayout();
            this.gb_verificarPorIBGE.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_apiEndpoint
            // 
            this.lbl_apiEndpoint.AutoSize = true;
            this.lbl_apiEndpoint.Location = new System.Drawing.Point(14, 11);
            this.lbl_apiEndpoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apiEndpoint.Name = "lbl_apiEndpoint";
            this.lbl_apiEndpoint.Size = new System.Drawing.Size(81, 16);
            this.lbl_apiEndpoint.TabIndex = 0;
            this.lbl_apiEndpoint.Text = "API endpoint";
            // 
            // lbl_apiEndpointText
            // 
            this.lbl_apiEndpointText.AutoSize = true;
            this.lbl_apiEndpointText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_apiEndpointText.Location = new System.Drawing.Point(13, 27);
            this.lbl_apiEndpointText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_apiEndpointText.Name = "lbl_apiEndpointText";
            this.lbl_apiEndpointText.Size = new System.Drawing.Size(248, 18);
            this.lbl_apiEndpointText.TabIndex = 1;
            this.lbl_apiEndpointText.Text = "https://api.plugnotas.com.br/nfse/cidades";
            // 
            // gb_verificarPorNome
            // 
            this.gb_verificarPorNome.Controls.Add(this.lbl_resultadoText);
            this.gb_verificarPorNome.Controls.Add(this.lbl_resultado);
            this.gb_verificarPorNome.Controls.Add(this.btn_verificarPorNome);
            this.gb_verificarPorNome.Controls.Add(this.cb_cidade);
            this.gb_verificarPorNome.Controls.Add(this.cb_uf);
            this.gb_verificarPorNome.Location = new System.Drawing.Point(13, 117);
            this.gb_verificarPorNome.Name = "gb_verificarPorNome";
            this.gb_verificarPorNome.Size = new System.Drawing.Size(486, 162);
            this.gb_verificarPorNome.TabIndex = 4;
            this.gb_verificarPorNome.TabStop = false;
            this.gb_verificarPorNome.Text = "Verificar por nome";
            // 
            // lbl_resultadoText
            // 
            this.lbl_resultadoText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_resultadoText.Location = new System.Drawing.Point(80, 78);
            this.lbl_resultadoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resultadoText.Name = "lbl_resultadoText";
            this.lbl_resultadoText.Size = new System.Drawing.Size(137, 18);
            this.lbl_resultadoText.TabIndex = 6;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(7, 80);
            this.lbl_resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(69, 16);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "Resultado:";
            // 
            // btn_verificarPorNome
            // 
            this.btn_verificarPorNome.Location = new System.Drawing.Point(393, 31);
            this.btn_verificarPorNome.Name = "btn_verificarPorNome";
            this.btn_verificarPorNome.Size = new System.Drawing.Size(75, 23);
            this.btn_verificarPorNome.TabIndex = 2;
            this.btn_verificarPorNome.Text = "Verificar";
            this.btn_verificarPorNome.UseVisualStyleBackColor = true;
            this.btn_verificarPorNome.Click += new System.EventHandler(this.btn_verificarPorNome_Click);
            // 
            // cb_cidade
            // 
            this.cb_cidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cidade.FormattingEnabled = true;
            this.cb_cidade.Location = new System.Drawing.Point(67, 31);
            this.cb_cidade.Name = "cb_cidade";
            this.cb_cidade.Size = new System.Drawing.Size(320, 24);
            this.cb_cidade.TabIndex = 1;
            // 
            // cb_uf
            // 
            this.cb_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_uf.FormattingEnabled = true;
            this.cb_uf.Location = new System.Drawing.Point(6, 31);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(55, 24);
            this.cb_uf.TabIndex = 0;
            this.cb_uf.SelectedIndexChanged += new System.EventHandler(this.cb_uf_SelectedIndexChanged);
            // 
            // gb_verificarPorIBGE
            // 
            this.gb_verificarPorIBGE.Controls.Add(this.lbl_naoHomologadas);
            this.gb_verificarPorIBGE.Controls.Add(this.txt_naoHomologadas);
            this.gb_verificarPorIBGE.Controls.Add(this.lbl_homologadas);
            this.gb_verificarPorIBGE.Controls.Add(this.txt_homologadas);
            this.gb_verificarPorIBGE.Controls.Add(this.lbl_listeOsCodigos);
            this.gb_verificarPorIBGE.Controls.Add(this.txt_codigosIBGE);
            this.gb_verificarPorIBGE.Controls.Add(this.btn_verificarPorIBGE);
            this.gb_verificarPorIBGE.Location = new System.Drawing.Point(13, 285);
            this.gb_verificarPorIBGE.Name = "gb_verificarPorIBGE";
            this.gb_verificarPorIBGE.Size = new System.Drawing.Size(486, 315);
            this.gb_verificarPorIBGE.TabIndex = 5;
            this.gb_verificarPorIBGE.TabStop = false;
            this.gb_verificarPorIBGE.Text = "Verificar por código IBGE";
            // 
            // lbl_naoHomologadas
            // 
            this.lbl_naoHomologadas.AutoSize = true;
            this.lbl_naoHomologadas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_naoHomologadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_naoHomologadas.ForeColor = System.Drawing.Color.Red;
            this.lbl_naoHomologadas.Location = new System.Drawing.Point(208, 162);
            this.lbl_naoHomologadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_naoHomologadas.Name = "lbl_naoHomologadas";
            this.lbl_naoHomologadas.Size = new System.Drawing.Size(113, 18);
            this.lbl_naoHomologadas.TabIndex = 9;
            this.lbl_naoHomologadas.Text = "Não homologadas";
            // 
            // txt_naoHomologadas
            // 
            this.txt_naoHomologadas.Location = new System.Drawing.Point(207, 181);
            this.txt_naoHomologadas.Multiline = true;
            this.txt_naoHomologadas.Name = "txt_naoHomologadas";
            this.txt_naoHomologadas.Size = new System.Drawing.Size(180, 114);
            this.txt_naoHomologadas.TabIndex = 8;
            // 
            // lbl_homologadas
            // 
            this.lbl_homologadas.AutoSize = true;
            this.lbl_homologadas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_homologadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_homologadas.ForeColor = System.Drawing.Color.Lime;
            this.lbl_homologadas.Location = new System.Drawing.Point(7, 162);
            this.lbl_homologadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_homologadas.Name = "lbl_homologadas";
            this.lbl_homologadas.Size = new System.Drawing.Size(88, 18);
            this.lbl_homologadas.TabIndex = 7;
            this.lbl_homologadas.Text = "Homologadas";
            // 
            // txt_homologadas
            // 
            this.txt_homologadas.Location = new System.Drawing.Point(6, 181);
            this.txt_homologadas.Multiline = true;
            this.txt_homologadas.Name = "txt_homologadas";
            this.txt_homologadas.Size = new System.Drawing.Size(180, 114);
            this.txt_homologadas.TabIndex = 6;
            // 
            // lbl_listeOsCodigos
            // 
            this.lbl_listeOsCodigos.AutoSize = true;
            this.lbl_listeOsCodigos.Location = new System.Drawing.Point(7, 23);
            this.lbl_listeOsCodigos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_listeOsCodigos.Name = "lbl_listeOsCodigos";
            this.lbl_listeOsCodigos.Size = new System.Drawing.Size(106, 16);
            this.lbl_listeOsCodigos.TabIndex = 5;
            this.lbl_listeOsCodigos.Text = "Liste os códigos:";
            // 
            // txt_codigosIBGE
            // 
            this.txt_codigosIBGE.Location = new System.Drawing.Point(6, 42);
            this.txt_codigosIBGE.Multiline = true;
            this.txt_codigosIBGE.Name = "txt_codigosIBGE";
            this.txt_codigosIBGE.Size = new System.Drawing.Size(381, 114);
            this.txt_codigosIBGE.TabIndex = 4;
            // 
            // btn_verificarPorIBGE
            // 
            this.btn_verificarPorIBGE.Location = new System.Drawing.Point(393, 42);
            this.btn_verificarPorIBGE.Name = "btn_verificarPorIBGE";
            this.btn_verificarPorIBGE.Size = new System.Drawing.Size(75, 23);
            this.btn_verificarPorIBGE.TabIndex = 3;
            this.btn_verificarPorIBGE.Text = "Verificar";
            this.btn_verificarPorIBGE.UseVisualStyleBackColor = true;
            this.btn_verificarPorIBGE.Click += new System.EventHandler(this.btn_verificarPorIBGE_Click);
            // 
            // lbl_token
            // 
            this.lbl_token.AutoSize = true;
            this.lbl_token.Location = new System.Drawing.Point(14, 56);
            this.lbl_token.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_token.Name = "lbl_token";
            this.lbl_token.Size = new System.Drawing.Size(60, 16);
            this.lbl_token.TabIndex = 7;
            this.lbl_token.Text = "x-api-key";
            // 
            // txt_Token
            // 
            this.txt_Token.Location = new System.Drawing.Point(13, 75);
            this.txt_Token.Name = "txt_Token";
            this.txt_Token.Size = new System.Drawing.Size(248, 22);
            this.txt_Token.TabIndex = 10;
            // 
            // btn_salvar
            // 
            this.btn_salvar.Location = new System.Drawing.Point(267, 74);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_salvar.TabIndex = 7;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = true;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 616);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.txt_Token);
            this.Controls.Add(this.lbl_token);
            this.Controls.Add(this.gb_verificarPorIBGE);
            this.Controls.Add(this.gb_verificarPorNome);
            this.Controls.Add(this.lbl_apiEndpointText);
            this.Controls.Add(this.lbl_apiEndpoint);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verificador de cidades homologadas";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.gb_verificarPorNome.ResumeLayout(false);
            this.gb_verificarPorNome.PerformLayout();
            this.gb_verificarPorIBGE.ResumeLayout(false);
            this.gb_verificarPorIBGE.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_apiEndpoint;
        private System.Windows.Forms.Label lbl_apiEndpointText;
        private System.Windows.Forms.GroupBox gb_verificarPorNome;
        private System.Windows.Forms.GroupBox gb_verificarPorIBGE;
        private System.Windows.Forms.ComboBox cb_cidade;
        private System.Windows.Forms.ComboBox cb_uf;
        private System.Windows.Forms.Button btn_verificarPorNome;
        private System.Windows.Forms.Button btn_verificarPorIBGE;
        private System.Windows.Forms.Label lbl_listeOsCodigos;
        private System.Windows.Forms.TextBox txt_codigosIBGE;
        private System.Windows.Forms.Label lbl_homologadas;
        private System.Windows.Forms.TextBox txt_homologadas;
        private System.Windows.Forms.TextBox txt_naoHomologadas;
        private System.Windows.Forms.Label lbl_naoHomologadas;
        private System.Windows.Forms.Label lbl_resultadoText;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_token;
        private System.Windows.Forms.TextBox txt_Token;
        private System.Windows.Forms.Button btn_salvar;
    }
}

