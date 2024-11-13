using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class ChooseReadModeForm : Form
    {
        public string SelectedReadMode { private set; get; }
        public string posChar { set; get; }
        public string posLine { set; get; }
        public ChooseReadModeForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedReadMode = cbReadMode.SelectedItem.ToString();
            posChar = txtPosCaracter.Text;
            posLine = txtPosLinha.Text;
            this.DialogResult = DialogResult.OK;
            this.Close(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChooseReadModeForm_Load(object sender, EventArgs e)
        {
            cbReadMode.SelectedIndex = 0;

        }
    }
}
