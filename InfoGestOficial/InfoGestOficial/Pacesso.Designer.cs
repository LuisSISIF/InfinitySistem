namespace InfoGestOficial
{
    partial class Pacesso
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ativacao = new System.Windows.Forms.TextBox();
            this.btnverifica = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.button2.Location = new System.Drawing.Point(391, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 43);
            this.button2.TabIndex = 10;
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(84, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Primeiro Acesso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Insira a senha de Ativação";
            // 
            // txt_ativacao
            // 
            this.txt_ativacao.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_ativacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ativacao.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ativacao.Location = new System.Drawing.Point(41, 152);
            this.txt_ativacao.Name = "txt_ativacao";
            this.txt_ativacao.Size = new System.Drawing.Size(313, 31);
            this.txt_ativacao.TabIndex = 13;
            this.txt_ativacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ativacao.UseSystemPasswordChar = true;
            // 
            // btnverifica
            // 
            this.btnverifica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnverifica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnverifica.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnverifica.ForeColor = System.Drawing.Color.White;
            this.btnverifica.Location = new System.Drawing.Point(217, 220);
            this.btnverifica.Name = "btnverifica";
            this.btnverifica.Size = new System.Drawing.Size(137, 41);
            this.btnverifica.TabIndex = 14;
            this.btnverifica.Text = "Verificar";
            this.btnverifica.UseVisualStyleBackColor = false;
            this.btnverifica.Click += new System.EventHandler(this.btnverifica_Click);
            // 
            // Pacesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(28)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(435, 335);
            this.ControlBox = false;
            this.Controls.Add(this.btnverifica);
            this.Controls.Add(this.txt_ativacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pacesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox txt_ativacao;
        private Button btnverifica;
    }
}