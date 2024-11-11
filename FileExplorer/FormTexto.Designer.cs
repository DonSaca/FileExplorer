
namespace FileExplorer
{
    partial class FormTexto
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
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBinaryWriter = new System.Windows.Forms.Button();
            this.btnStreamWriter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(14, 92);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto.Size = new System.Drawing.Size(411, 374);
            this.txtTexto.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 35);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(397, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do ficheiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto:";
            // 
            // btnBinaryWriter
            // 
            this.btnBinaryWriter.Location = new System.Drawing.Point(14, 486);
            this.btnBinaryWriter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBinaryWriter.Name = "btnBinaryWriter";
            this.btnBinaryWriter.Size = new System.Drawing.Size(126, 61);
            this.btnBinaryWriter.TabIndex = 4;
            this.btnBinaryWriter.Text = "BinaryWriter";
            this.btnBinaryWriter.UseVisualStyleBackColor = true;
            this.btnBinaryWriter.Click += new System.EventHandler(this.btnBinaryWriter_Click);
            // 
            // btnStreamWriter
            // 
            this.btnStreamWriter.Location = new System.Drawing.Point(219, 486);
            this.btnStreamWriter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStreamWriter.Name = "btnStreamWriter";
            this.btnStreamWriter.Size = new System.Drawing.Size(126, 61);
            this.btnStreamWriter.TabIndex = 5;
            this.btnStreamWriter.Text = "StreamWriter";
            this.btnStreamWriter.UseVisualStyleBackColor = true;
            this.btnStreamWriter.Click += new System.EventHandler(this.btnStreamWriter_Click);
            // 
            // FormTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnStreamWriter);
            this.Controls.Add(this.btnBinaryWriter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTexto);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTexto";
            this.Text = "FormTexto";
            this.Load += new System.EventHandler(this.FormTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtTexto;
        public System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBinaryWriter;
        private System.Windows.Forms.Button btnStreamWriter;
    }
}