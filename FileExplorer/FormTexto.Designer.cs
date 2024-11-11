
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
            this.txtTexto.Location = new System.Drawing.Point(12, 74);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTexto.Size = new System.Drawing.Size(366, 300);
            this.txtTexto.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(353, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome do ficheiro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto:";
            // 
            // btnBinaryWriter
            // 
            this.btnBinaryWriter.Location = new System.Drawing.Point(12, 389);
            this.btnBinaryWriter.Name = "btnBinaryWriter";
            this.btnBinaryWriter.Size = new System.Drawing.Size(112, 49);
            this.btnBinaryWriter.TabIndex = 4;
            this.btnBinaryWriter.Text = "BinaryWriter";
            this.btnBinaryWriter.UseVisualStyleBackColor = true;
            // 
            // btnStreamWriter
            // 
            this.btnStreamWriter.Location = new System.Drawing.Point(195, 389);
            this.btnStreamWriter.Name = "btnStreamWriter";
            this.btnStreamWriter.Size = new System.Drawing.Size(112, 49);
            this.btnStreamWriter.TabIndex = 5;
            this.btnStreamWriter.Text = "StreamWriter";
            this.btnStreamWriter.UseVisualStyleBackColor = true;
            this.btnStreamWriter.Click += new System.EventHandler(this.btnStreamWriter_Click);
            // 
            // FormTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStreamWriter);
            this.Controls.Add(this.btnBinaryWriter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtTexto);
            this.Name = "FormTexto";
            this.Text = "FormTexto";
            this.Load += new System.EventHandler(this.FormTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBinaryWriter;
        private System.Windows.Forms.Button btnStreamWriter;
    }
}