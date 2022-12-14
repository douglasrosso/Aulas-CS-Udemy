namespace _137__Décimo_segundo_projeto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxMensagens = new System.Windows.Forms.GroupBox();
            this.buttonEnviarMensagem = new System.Windows.Forms.Button();
            this.textBoxPortaDoContato = new System.Windows.Forms.TextBox();
            this.textBoxIPDoContato = new System.Windows.Forms.TextBox();
            this.labelPortaDoContato = new System.Windows.Forms.Label();
            this.labelIPDoContato = new System.Windows.Forms.Label();
            this.richTextBoxMensagensParaEnviar = new System.Windows.Forms.RichTextBox();
            this.labelMensagensParaEnviar = new System.Windows.Forms.Label();
            this.richTextBoxMensagens = new System.Windows.Forms.RichTextBox();
            this.textBoxMeuNome = new System.Windows.Forms.TextBox();
            this.labelMeuNome = new System.Windows.Forms.Label();
            this.groupBoxServidor = new System.Windows.Forms.GroupBox();
            this.buttonAplicarConfigServidor = new System.Windows.Forms.Button();
            this.textBoxPortaDoServidor = new System.Windows.Forms.TextBox();
            this.labelPortaDoServidor = new System.Windows.Forms.Label();
            this.groupBoxMensagens.SuspendLayout();
            this.groupBoxServidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMensagens
            // 
            this.groupBoxMensagens.Controls.Add(this.buttonEnviarMensagem);
            this.groupBoxMensagens.Controls.Add(this.textBoxPortaDoContato);
            this.groupBoxMensagens.Controls.Add(this.textBoxIPDoContato);
            this.groupBoxMensagens.Controls.Add(this.labelPortaDoContato);
            this.groupBoxMensagens.Controls.Add(this.labelIPDoContato);
            this.groupBoxMensagens.Controls.Add(this.richTextBoxMensagensParaEnviar);
            this.groupBoxMensagens.Controls.Add(this.labelMensagensParaEnviar);
            this.groupBoxMensagens.Controls.Add(this.richTextBoxMensagens);
            this.groupBoxMensagens.Controls.Add(this.textBoxMeuNome);
            this.groupBoxMensagens.Controls.Add(this.labelMeuNome);
            this.groupBoxMensagens.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMensagens.Name = "groupBoxMensagens";
            this.groupBoxMensagens.Size = new System.Drawing.Size(615, 464);
            this.groupBoxMensagens.TabIndex = 0;
            this.groupBoxMensagens.TabStop = false;
            this.groupBoxMensagens.Text = "Mensagens";
            // 
            // buttonEnviarMensagem
            // 
            this.buttonEnviarMensagem.Location = new System.Drawing.Point(6, 383);
            this.buttonEnviarMensagem.Name = "buttonEnviarMensagem";
            this.buttonEnviarMensagem.Size = new System.Drawing.Size(603, 70);
            this.buttonEnviarMensagem.TabIndex = 9;
            this.buttonEnviarMensagem.Text = "Enviar mensagem";
            this.buttonEnviarMensagem.UseVisualStyleBackColor = true;
            this.buttonEnviarMensagem.Click += new System.EventHandler(this.buttonEnviarMensagem_Click);
            // 
            // textBoxPortaDoContato
            // 
            this.textBoxPortaDoContato.Location = new System.Drawing.Point(513, 339);
            this.textBoxPortaDoContato.Name = "textBoxPortaDoContato";
            this.textBoxPortaDoContato.Size = new System.Drawing.Size(96, 27);
            this.textBoxPortaDoContato.TabIndex = 8;
            // 
            // textBoxIPDoContato
            // 
            this.textBoxIPDoContato.Location = new System.Drawing.Point(117, 339);
            this.textBoxIPDoContato.Name = "textBoxIPDoContato";
            this.textBoxIPDoContato.Size = new System.Drawing.Size(257, 27);
            this.textBoxIPDoContato.TabIndex = 7;
            // 
            // labelPortaDoContato
            // 
            this.labelPortaDoContato.AutoSize = true;
            this.labelPortaDoContato.Location = new System.Drawing.Point(380, 342);
            this.labelPortaDoContato.Name = "labelPortaDoContato";
            this.labelPortaDoContato.Size = new System.Drawing.Size(127, 20);
            this.labelPortaDoContato.TabIndex = 6;
            this.labelPortaDoContato.Text = "Porta do contato :";
            // 
            // labelIPDoContato
            // 
            this.labelIPDoContato.AutoSize = true;
            this.labelIPDoContato.Location = new System.Drawing.Point(6, 339);
            this.labelIPDoContato.Name = "labelIPDoContato";
            this.labelIPDoContato.Size = new System.Drawing.Size(105, 20);
            this.labelIPDoContato.TabIndex = 5;
            this.labelIPDoContato.Text = "IP do contato :";
            // 
            // richTextBoxMensagensParaEnviar
            // 
            this.richTextBoxMensagensParaEnviar.Location = new System.Drawing.Point(272, 273);
            this.richTextBoxMensagensParaEnviar.Name = "richTextBoxMensagensParaEnviar";
            this.richTextBoxMensagensParaEnviar.Size = new System.Drawing.Size(337, 58);
            this.richTextBoxMensagensParaEnviar.TabIndex = 4;
            this.richTextBoxMensagensParaEnviar.Text = "";
            // 
            // labelMensagensParaEnviar
            // 
            this.labelMensagensParaEnviar.AutoSize = true;
            this.labelMensagensParaEnviar.Location = new System.Drawing.Point(6, 287);
            this.labelMensagensParaEnviar.Name = "labelMensagensParaEnviar";
            this.labelMensagensParaEnviar.Size = new System.Drawing.Size(168, 20);
            this.labelMensagensParaEnviar.TabIndex = 3;
            this.labelMensagensParaEnviar.Text = "Mensagens para enviar :";
            // 
            // richTextBoxMensagens
            // 
            this.richTextBoxMensagens.Enabled = false;
            this.richTextBoxMensagens.Location = new System.Drawing.Point(6, 63);
            this.richTextBoxMensagens.Name = "richTextBoxMensagens";
            this.richTextBoxMensagens.Size = new System.Drawing.Size(603, 204);
            this.richTextBoxMensagens.TabIndex = 2;
            this.richTextBoxMensagens.Text = "";
            // 
            // textBoxMeuNome
            // 
            this.textBoxMeuNome.Location = new System.Drawing.Point(97, 30);
            this.textBoxMeuNome.Name = "textBoxMeuNome";
            this.textBoxMeuNome.Size = new System.Drawing.Size(512, 27);
            this.textBoxMeuNome.TabIndex = 1;
            // 
            // labelMeuNome
            // 
            this.labelMeuNome.AutoSize = true;
            this.labelMeuNome.Location = new System.Drawing.Point(6, 33);
            this.labelMeuNome.Name = "labelMeuNome";
            this.labelMeuNome.Size = new System.Drawing.Size(87, 20);
            this.labelMeuNome.TabIndex = 0;
            this.labelMeuNome.Text = "Meu nome :";
            // 
            // groupBoxServidor
            // 
            this.groupBoxServidor.Controls.Add(this.buttonAplicarConfigServidor);
            this.groupBoxServidor.Controls.Add(this.textBoxPortaDoServidor);
            this.groupBoxServidor.Controls.Add(this.labelPortaDoServidor);
            this.groupBoxServidor.Location = new System.Drawing.Point(12, 482);
            this.groupBoxServidor.Name = "groupBoxServidor";
            this.groupBoxServidor.Size = new System.Drawing.Size(615, 154);
            this.groupBoxServidor.TabIndex = 1;
            this.groupBoxServidor.TabStop = false;
            this.groupBoxServidor.Text = "Configurações do servidor";
            // 
            // buttonAplicarConfigServidor
            // 
            this.buttonAplicarConfigServidor.Location = new System.Drawing.Point(6, 80);
            this.buttonAplicarConfigServidor.Name = "buttonAplicarConfigServidor";
            this.buttonAplicarConfigServidor.Size = new System.Drawing.Size(603, 68);
            this.buttonAplicarConfigServidor.TabIndex = 2;
            this.buttonAplicarConfigServidor.Text = "Aplicar configurações";
            this.buttonAplicarConfigServidor.UseVisualStyleBackColor = true;
            this.buttonAplicarConfigServidor.Click += new System.EventHandler(this.buttonAplicarConfigServidor_Click);
            // 
            // textBoxPortaDoServidor
            // 
            this.textBoxPortaDoServidor.Location = new System.Drawing.Point(141, 31);
            this.textBoxPortaDoServidor.Name = "textBoxPortaDoServidor";
            this.textBoxPortaDoServidor.Size = new System.Drawing.Size(468, 27);
            this.textBoxPortaDoServidor.TabIndex = 1;
            // 
            // labelPortaDoServidor
            // 
            this.labelPortaDoServidor.AutoSize = true;
            this.labelPortaDoServidor.Location = new System.Drawing.Point(6, 34);
            this.labelPortaDoServidor.Name = "labelPortaDoServidor";
            this.labelPortaDoServidor.Size = new System.Drawing.Size(129, 20);
            this.labelPortaDoServidor.TabIndex = 0;
            this.labelPortaDoServidor.Text = "Porta do servidor :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 648);
            this.Controls.Add(this.groupBoxServidor);
            this.Controls.Add(this.groupBoxMensagens);
            this.MaximumSize = new System.Drawing.Size(658, 695);
            this.MinimumSize = new System.Drawing.Size(658, 695);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxMensagens.ResumeLayout(false);
            this.groupBoxMensagens.PerformLayout();
            this.groupBoxServidor.ResumeLayout(false);
            this.groupBoxServidor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBoxMensagens;
        private Label labelIPDoContato;
        private RichTextBox richTextBoxMensagensParaEnviar;
        private Label labelMensagensParaEnviar;
        private RichTextBox richTextBoxMensagens;
        private TextBox textBoxMeuNome;
        private Label labelMeuNome;
        private GroupBox groupBoxServidor;
        private TextBox textBoxPortaDoContato;
        private TextBox textBoxIPDoContato;
        private Label labelPortaDoContato;
        private Button buttonEnviarMensagem;
        private Button buttonAplicarConfigServidor;
        private TextBox textBoxPortaDoServidor;
        private Label labelPortaDoServidor;
    }
}