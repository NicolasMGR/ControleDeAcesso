namespace ControleDeAcesso
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(409, 113);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(154, 22);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(405, 74);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(60, 20);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(405, 154);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(106, 20);
            this.lblSobrenome.TabIndex = 2;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(409, 189);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(154, 22);
            this.txtSobrenome.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(405, 234);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(170, 20);
            this.lblData.TabIndex = 4;
            this.lblData.Text = "Ano de Nascimento:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(409, 276);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(154, 22);
            this.txtData.TabIndex = 5;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Red;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(637, 29);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(151, 111);
            this.btnVerificar.TabIndex = 6;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcesso.Location = new System.Drawing.Point(12, 358);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(87, 20);
            this.lblAcesso.TabIndex = 7;
            this.lblAcesso.Text = "ACESSO:";
            // 
            // pbFoto
            // 
            this.pbFoto.Image = global::ControleDeAcesso.Properties.Resources.fundobruno;
            this.pbFoto.Location = new System.Drawing.Point(16, 12);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(368, 296);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 9;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(12, 400);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 20);
            this.lblResultado.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(637, 249);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(151, 111);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControleDeAcesso.Properties.Resources.espera;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.lblAcesso);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Controle de Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblAcesso;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnSair;
    }
}

