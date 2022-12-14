namespace _126__Aplicação_Cliente
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
            this.buttonEnviaString = new System.Windows.Forms.Button();
            this.textBoxEnviaString = new System.Windows.Forms.TextBox();
            this.textBoxPegaString = new System.Windows.Forms.TextBox();
            this.buttonPegaString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEnviaString
            // 
            this.buttonEnviaString.Location = new System.Drawing.Point(12, 106);
            this.buttonEnviaString.Name = "buttonEnviaString";
            this.buttonEnviaString.Size = new System.Drawing.Size(452, 68);
            this.buttonEnviaString.TabIndex = 0;
            this.buttonEnviaString.Text = "Envia string";
            this.buttonEnviaString.UseVisualStyleBackColor = true;
            this.buttonEnviaString.Click += new System.EventHandler(this.buttonEnviaString_Click);
            // 
            // textBoxEnviaString
            // 
            this.textBoxEnviaString.Location = new System.Drawing.Point(12, 73);
            this.textBoxEnviaString.Name = "textBoxEnviaString";
            this.textBoxEnviaString.Size = new System.Drawing.Size(452, 27);
            this.textBoxEnviaString.TabIndex = 2;
            // 
            // textBoxPegaString
            // 
            this.textBoxPegaString.Location = new System.Drawing.Point(12, 201);
            this.textBoxPegaString.Name = "textBoxPegaString";
            this.textBoxPegaString.Size = new System.Drawing.Size(452, 27);
            this.textBoxPegaString.TabIndex = 4;
            // 
            // buttonPegaString
            // 
            this.buttonPegaString.Location = new System.Drawing.Point(12, 234);
            this.buttonPegaString.Name = "buttonPegaString";
            this.buttonPegaString.Size = new System.Drawing.Size(452, 68);
            this.buttonPegaString.TabIndex = 3;
            this.buttonPegaString.Text = "Pega string";
            this.buttonPegaString.UseVisualStyleBackColor = true;
            this.buttonPegaString.Click += new System.EventHandler(this.buttonPegaString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 319);
            this.Controls.Add(this.textBoxPegaString);
            this.Controls.Add(this.buttonPegaString);
            this.Controls.Add(this.textBoxEnviaString);
            this.Controls.Add(this.buttonEnviaString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonEnviaString;
        private TextBox textBoxEnviaString;
        private TextBox textBoxPegaString;
        private Button buttonPegaString;
    }
}