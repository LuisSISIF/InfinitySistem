namespace InfoGestOficial
{
    partial class principal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.marcador = new System.Windows.Forms.Panel();
            this.btnfunc = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabFunc = new System.Windows.Forms.TabControl();
            this.tabcadastrafunc = new System.Windows.Forms.TabPage();
            this.chkadm = new System.Windows.Forms.CheckBox();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.txt_func = new System.Windows.Forms.TextBox();
            this.txt_sal = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_fone = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabpesquisaFunc = new System.Windows.Forms.TabPage();
            this.btnestoque = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabFunc.SuspendLayout();
            this.tabcadastrafunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.btnestoque);
            this.panel1.Controls.Add(this.marcador);
            this.panel1.Controls.Add(this.btnfunc);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 750);
            this.panel1.TabIndex = 0;
            // 
            // marcador
            // 
            this.marcador.BackColor = System.Drawing.Color.Blue;
            this.marcador.Location = new System.Drawing.Point(0, 91);
            this.marcador.Margin = new System.Windows.Forms.Padding(4);
            this.marcador.Name = "marcador";
            this.marcador.Size = new System.Drawing.Size(11, 41);
            this.marcador.TabIndex = 9;
            // 
            // btnfunc
            // 
            this.btnfunc.Location = new System.Drawing.Point(12, 91);
            this.btnfunc.Name = "btnfunc";
            this.btnfunc.Size = new System.Drawing.Size(181, 41);
            this.btnfunc.TabIndex = 2;
            this.btnfunc.Text = "Funcionários";
            this.btnfunc.UseVisualStyleBackColor = true;
            this.btnfunc.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InfoGestOficial.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(107)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(195, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 50);
            this.panel2.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(14, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 32);
            this.lblTitulo.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(8, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 32);
            this.lblTitle.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::InfoGestOficial.Properties.Resources.close;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(907, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 43);
            this.button2.TabIndex = 11;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabFunc
            // 
            this.tabFunc.Controls.Add(this.tabcadastrafunc);
            this.tabFunc.Controls.Add(this.tabpesquisaFunc);
            this.tabFunc.Location = new System.Drawing.Point(199, 56);
            this.tabFunc.Name = "tabFunc";
            this.tabFunc.SelectedIndex = 0;
            this.tabFunc.Size = new System.Drawing.Size(944, 694);
            this.tabFunc.TabIndex = 2;
            // 
            // tabcadastrafunc
            // 
            this.tabcadastrafunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabcadastrafunc.Controls.Add(this.chkadm);
            this.tabcadastrafunc.Controls.Add(this.btn_cadastro);
            this.tabcadastrafunc.Controls.Add(this.txt_func);
            this.tabcadastrafunc.Controls.Add(this.txt_sal);
            this.tabcadastrafunc.Controls.Add(this.txt_end);
            this.tabcadastrafunc.Controls.Add(this.txt_fone);
            this.tabcadastrafunc.Controls.Add(this.txt_senha);
            this.tabcadastrafunc.Controls.Add(this.txt_login);
            this.tabcadastrafunc.Controls.Add(this.txt_cpf);
            this.tabcadastrafunc.Controls.Add(this.txt_nome);
            this.tabcadastrafunc.Controls.Add(this.label9);
            this.tabcadastrafunc.Controls.Add(this.label8);
            this.tabcadastrafunc.Controls.Add(this.label7);
            this.tabcadastrafunc.Controls.Add(this.label6);
            this.tabcadastrafunc.Controls.Add(this.label5);
            this.tabcadastrafunc.Controls.Add(this.label4);
            this.tabcadastrafunc.Controls.Add(this.label3);
            this.tabcadastrafunc.Controls.Add(this.label2);
            this.tabcadastrafunc.Location = new System.Drawing.Point(4, 34);
            this.tabcadastrafunc.Name = "tabcadastrafunc";
            this.tabcadastrafunc.Padding = new System.Windows.Forms.Padding(3);
            this.tabcadastrafunc.Size = new System.Drawing.Size(936, 656);
            this.tabcadastrafunc.TabIndex = 0;
            this.tabcadastrafunc.Text = "Novo Funcionário";
            // 
            // chkadm
            // 
            this.chkadm.AutoSize = true;
            this.chkadm.Location = new System.Drawing.Point(547, 375);
            this.chkadm.Name = "chkadm";
            this.chkadm.Size = new System.Drawing.Size(232, 29);
            this.chkadm.TabIndex = 36;
            this.chkadm.Text = "Administra Funcionários?";
            this.chkadm.UseVisualStyleBackColor = true;
            this.chkadm.CheckedChanged += new System.EventHandler(this.chkadm_CheckedChanged);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_cadastro.ForeColor = System.Drawing.Color.White;
            this.btn_cadastro.Location = new System.Drawing.Point(634, 451);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(145, 41);
            this.btn_cadastro.TabIndex = 35;
            this.btn_cadastro.Text = "Cadastrar";
            this.btn_cadastro.UseVisualStyleBackColor = false;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // txt_func
            // 
            this.txt_func.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_func.Location = new System.Drawing.Point(552, 316);
            this.txt_func.Name = "txt_func";
            this.txt_func.Size = new System.Drawing.Size(227, 29);
            this.txt_func.TabIndex = 34;
            // 
            // txt_sal
            // 
            this.txt_sal.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sal.Location = new System.Drawing.Point(192, 316);
            this.txt_sal.Name = "txt_sal";
            this.txt_sal.Size = new System.Drawing.Size(227, 29);
            this.txt_sal.TabIndex = 33;
            // 
            // txt_end
            // 
            this.txt_end.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_end.Location = new System.Drawing.Point(552, 251);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(227, 29);
            this.txt_end.TabIndex = 32;
            // 
            // txt_fone
            // 
            this.txt_fone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_fone.Location = new System.Drawing.Point(192, 251);
            this.txt_fone.Name = "txt_fone";
            this.txt_fone.Size = new System.Drawing.Size(227, 29);
            this.txt_fone.TabIndex = 31;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_senha.Location = new System.Drawing.Point(552, 177);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(227, 29);
            this.txt_senha.TabIndex = 30;
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_login.Location = new System.Drawing.Point(192, 176);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(227, 29);
            this.txt_login.TabIndex = 29;
            // 
            // txt_cpf
            // 
            this.txt_cpf.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_cpf.Location = new System.Drawing.Point(552, 112);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(227, 29);
            this.txt_cpf.TabIndex = 28;
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nome.Location = new System.Drawing.Point(192, 112);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(227, 29);
            this.txt_nome.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "Cargo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 25;
            this.label8.Text = "Salário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 25);
            this.label7.TabIndex = 24;
            this.label7.Text = "Endereço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "CPF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // tabpesquisaFunc
            // 
            this.tabpesquisaFunc.Location = new System.Drawing.Point(4, 24);
            this.tabpesquisaFunc.Name = "tabpesquisaFunc";
            this.tabpesquisaFunc.Padding = new System.Windows.Forms.Padding(3);
            this.tabpesquisaFunc.Size = new System.Drawing.Size(936, 666);
            this.tabpesquisaFunc.TabIndex = 1;
            this.tabpesquisaFunc.Text = "Buscar Funcionário";
            this.tabpesquisaFunc.UseVisualStyleBackColor = true;
            // 
            // btnestoque
            // 
            this.btnestoque.Location = new System.Drawing.Point(12, 139);
            this.btnestoque.Name = "btnestoque";
            this.btnestoque.Size = new System.Drawing.Size(181, 41);
            this.btnestoque.TabIndex = 10;
            this.btnestoque.Text = "Estoque";
            this.btnestoque.UseVisualStyleBackColor = true;
            this.btnestoque.Click += new System.EventHandler(this.btnestoque_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 749);
            this.ControlBox = false;
            this.Controls.Add(this.tabFunc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "principal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabFunc.ResumeLayout(false);
            this.tabcadastrafunc.ResumeLayout(false);
            this.tabcadastrafunc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btnfunc;
        private Panel marcador;
        private TabControl tabFunc;
        private TabPage tabcadastrafunc;
        private TabPage tabpesquisaFunc;
        private Label lblTitle;
        private Button button2;
        private Label lblTitulo;
        private Button btn_cadastro;
        private TextBox txt_func;
        private TextBox txt_sal;
        private TextBox txt_end;
        private TextBox txt_fone;
        private TextBox txt_senha;
        private TextBox txt_login;
        private TextBox txt_cpf;
        private TextBox txt_nome;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox chkadm;
        private Button btnestoque;
    }
}