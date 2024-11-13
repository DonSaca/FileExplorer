using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileExplorer
{
    public partial class FormTexto : Form
    {
        public FormTexto()
        {
            InitializeComponent();
        }

        private void FormTexto_Load(object sender, EventArgs e)
        {

        }

        private void btnStreamWriter_Click(object sender, EventArgs e)
        {
         
            string currentPath = Program.Form1Instance.txtAddressBar.Text;
            string fileName = txtNome.Text + ".txt";
            string Texto = txtTexto.Text;
            string fullPath = Path.Combine(currentPath, fileName);

            try
            {
                
                Directory.CreateDirectory(currentPath);

                
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    writer.Write(Texto);
                }

                MessageBox.Show("Ficheiro criado em  " + fullPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro durante a operacao: " + ex.Message);
            }
        }

        private void btnBinaryWriter_Click(object sender, EventArgs e)
        {
          

            using (BinaryWriterForm binWriterForm = new BinaryWriterForm())
            {
                // Show the encoding selection form
                if (binWriterForm.ShowDialog() == DialogResult.OK)
                {
                    // Retrieve the chosen encoding
                    Encoding selectedEncoding = binWriterForm.SelectedEncoding;

                    // Get path and content
                    string currentPath = Program.Form1Instance.txtAddressBar.Text;
                    string fileName = txtNome.Text + ".bin";
                    string fullPath = Path.Combine(currentPath, fileName);
                    string Texto = txtTexto.Text;

                    try
                    {
                        // Convert the text to bytes using the selected encoding
                        byte[] textBytes = selectedEncoding.GetBytes(Texto);

                        // Write the binary file with the selected encoding
                        using (FileStream fs = new FileStream(fullPath, FileMode.Create, FileAccess.Write))
                        using (BinaryWriter writer = new BinaryWriter(fs))
                        {
                           // writer.Write(textBytes.Length); // Optional: Write the length of the byte array
                            writer.Write(textBytes); // Write the encoded byte array
                        }

                        MessageBox.Show("Ficheiro binario do tipo " + binWriterForm.cbEncode.SelectedItem + " criado com sucesso em" + fullPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Operacao cancelada.");
                }
            }

        }
    }
}
