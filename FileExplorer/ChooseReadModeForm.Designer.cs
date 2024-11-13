
namespace FileExplorer
{
    partial class ChooseReadModeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbReadMode = new System.Windows.Forms.ComboBox();
            this.txtPosCaracter = new System.Windows.Forms.TextBox();
            this.txtPosLinha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha como quer ler o .txt";
            // 
            // cbReadMode
            // 
            this.cbReadMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReadMode.FormattingEnabled = true;
            this.cbReadMode.Items.AddRange(new object[] {
            "Notepad++",
            "StreamReader",
            "BinaryReader"});
            this.cbReadMode.Location = new System.Drawing.Point(76, 54);
            this.cbReadMode.Name = "cbReadMode";
            this.cbReadMode.Size = new System.Drawing.Size(121, 24);
            this.cbReadMode.TabIndex = 1;
            // 
            // txtPosCaracter
            // 
            this.txtPosCaracter.Location = new System.Drawing.Point(12, 120);
            this.txtPosCaracter.Name = "txtPosCaracter";
            this.txtPosCaracter.Size = new System.Drawing.Size(100, 22);
            this.txtPosCaracter.TabIndex = 2;
            // 
            // txtPosLinha
            // 
            this.txtPosLinha.Location = new System.Drawing.Point(12, 176);
            this.txtPosLinha.Name = "txtPosLinha";
            this.txtPosLinha.Size = new System.Drawing.Size(100, 22);
            this.txtPosLinha.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Posição do caracter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Posição da linha";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(133, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(84, 37);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(37, 227);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 37);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ChooseReadModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 276);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPosLinha);
            this.Controls.Add(this.txtPosCaracter);
            this.Controls.Add(this.cbReadMode);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChooseReadModeForm";
            this.Text = "ChooseReadModeForm";
            this.Load += new System.EventHandler(this.ChooseReadModeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbReadMode;
        private System.Windows.Forms.TextBox txtPosCaracter;
        private System.Windows.Forms.TextBox txtPosLinha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
    }
}