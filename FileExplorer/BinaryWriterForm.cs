using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class BinaryWriterForm : Form
    {
        public Encoding SelectedEncoding { get; private set; }
        public BinaryWriterForm()
        {
            InitializeComponent();
        }

       

        private void btnOK_Click(object sender, EventArgs e)
        {

       
            switch (cbEncode.SelectedItem.ToString())
            {
                case "UTF-8":
                    SelectedEncoding = Encoding.UTF8;
                    break;
                case "Unicode(UTF-16)":
                    SelectedEncoding = Encoding.Unicode;
                    break;
                case "ASCII":
                    SelectedEncoding = Encoding.ASCII;
                    break;
                default:
                    MessageBox.Show("Escolha uma opcao valida.");
                    return;
            }

            this.DialogResult = DialogResult.OK; // Set OK result
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel; // Set Cancel result
            this.Close();

        }

        private void cbEmcode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BinaryWriterForm_Load(object sender, EventArgs e)
        {
            cbEncode.Items.Add("UTF-8");
            cbEncode.Items.Add("Unicode(UTF-16)"); // UTF-16
            cbEncode.Items.Add("ASCII");
            cbEncode.SelectedIndex = 0;
        }
    }
}
