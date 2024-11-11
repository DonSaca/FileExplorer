namespace FileExplorer
{
    partial class BinaryWriterForm
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
            this.cbEncode = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbEncode
            // 
            this.cbEncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncode.FormattingEnabled = true;
            this.cbEncode.Location = new System.Drawing.Point(76, 71);
            this.cbEncode.Name = "cbEncode";
            this.cbEncode.Size = new System.Drawing.Size(121, 28);
            this.cbEncode.TabIndex = 0;
            this.cbEncode.SelectedIndexChanged += new System.EventHandler(this.cbEmcode_SelectedIndexChanged);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(37, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(76, 40);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(147, 121);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 33);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BinaryWriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 209);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbEncode);
            this.MaximizeBox = false;
            this.Name = "BinaryWriterForm";
            this.Text = "BinaryWriterForm";
            this.Load += new System.EventHandler(this.BinaryWriterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox cbEncode;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
    }
}