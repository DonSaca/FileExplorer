using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Stack<string> directoryHistory = new Stack<string>();
        private string selectedPath = string.Empty; // Path of the selected file or folder
        private bool isCut = false;       // Indicates whether the operation is cut

        private void CopyItem()
        {
            if (lvMainPanel.SelectedItems.Count > 0)
            {
                selectedPath = Path.Combine(txtAddressBar.Text, lvMainPanel.SelectedItems[0].Text); 
                isCut = false; 
            }
        }
        private void CutItem()
        {
            if (lvMainPanel.SelectedItems.Count > 0)
            {
                selectedPath = Path.Combine(txtAddressBar.Text, lvMainPanel.SelectedItems[0].Text);
                isCut = true; 
            }
        }

        private void PasteItem()
        {
            if (string.IsNullOrEmpty(selectedPath))
            {
                MessageBox.Show("Nenhum item pra colar.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string destinationPath = Path.Combine(txtAddressBar.Text, Path.GetFileName(selectedPath)); //O destino vai ser a pasta em que estamos mais o file ou pasta q copiamos/cortamos

            try
            {
                if (File.Exists(selectedPath))
                {
                    if (isCut)
                    {
                        File.Move(selectedPath, destinationPath);
                    }
                    else
                    {
                        File.Copy(selectedPath, destinationPath, true);
                    }
                }
                else if (Directory.Exists(selectedPath))
                {
                    if (isCut)
                    {
                        Directory.Move(selectedPath, destinationPath);
                    }
                    else
                    {
                        CopyDirectory(selectedPath, destinationPath);
                    }
                }

                // Refresh the view
                PopulateListView(txtAddressBar.Text);

                // Limpar o ctrl c/clipboard caso for cortar
                if (isCut)
                {
                    selectedPath = string.Empty;
                    isCut = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error durante a operaçao: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CopyDirectory(string sourceDir, string destDir)
        {
            Directory.CreateDirectory(destDir);
            foreach (var file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destDir, Path.GetFileName(file)); 
                File.Copy(file, destFile, true); //copia os dados do file e coloca-os no destFile, com overwrite
            }

            foreach (var directory in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destDir, Path.GetFileName(directory));
                CopyDirectory(directory, destSubDir); //Faz recursividade para copiar todos os files do directory para o destSubDir
            }
        }



        private void ChangeViewMode(string view)

        {
            if(cbViewMode != null)
            {
                switch(view)
                {
                    case "Large":
                        lvMainPanel.View = View.LargeIcon;
                        break;
                    case "Small":
                        lvMainPanel.View = View.SmallIcon;
                        break;
                    case "List":
                        lvMainPanel.View = View.List;
                        break;
                    case "Details":
                        lvMainPanel.View = View.Details;
                        break;
                    default:
                        lvMainPanel.View = View.List;
                        break;

                }
            }

        }
        
        private void LoadDirectories(TreeNode node)
        {
            string path = node.Tag.ToString();
            try
            {
                foreach (var dir in Directory.GetDirectories(path))
                {
                    var dirNode = new TreeNode(Path.GetFileName(dir)) { Tag = dir };
                    dirNode.Nodes.Add(new TreeNode("Loading...")); // Isto é um dummy node só ta la pra a opcao expand do node estar enabled
                    node.Nodes.Add(dirNode);

                    
                   // LoadDirectories(dirNode);
                }
            }
            catch {  }
        }
        private void PopulateTreeView(string rootPath)
        {
            tvwNaviPanel.Nodes.Clear(); // Clear previous nodes
            var rootNode = new TreeNode(rootPath) { Tag = rootPath };
            tvwNaviPanel.Nodes.Add(rootNode);
            LoadDirectories(rootNode);
            rootNode.Expand();
        }
        private void PopulateListView(string path)
        {
            lvMainPanel.Items.Clear(); // Clear previous items

            
            foreach (var dir in System.IO.Directory.GetDirectories(path))
            {
                var dirInfo = new System.IO.DirectoryInfo(dir);
                ListViewItem item = new ListViewItem(dirInfo.Name, 0); // Assuming 0 is folder icon index
                item.SubItems.Add("Folder"); // Type
                item.SubItems.Add(""); // Size
                item.SubItems.Add(dirInfo.LastWriteTime.ToString()); // Date Modified
                lvMainPanel.Items.Add(item);
            }

            // Add files to ListView
            foreach (var file in System.IO.Directory.GetFiles(path))
            {
                var fileInfo = new System.IO.FileInfo(file);
                ListViewItem item = new ListViewItem(fileInfo.Name, 1); // Assuming 1 is file icon index
                item.SubItems.Add(fileInfo.Extension); // Type
                item.SubItems.Add(fileInfo.Length.ToString()); // Size
                item.SubItems.Add(fileInfo.LastWriteTime.ToString()); // Date Modified
                lvMainPanel.Items.Add(item);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                cbDrives.Items.Add(drive.Name);
            }
            if (cbDrives.Items.Count > 0)
                cbDrives.SelectedIndex = 0;
            cbViewMode.SelectedIndex = 2;
        }

        private void cbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDrive = cbDrives.SelectedItem.ToString();
            txtAddressBar.Text = selectedDrive; // Update address bar
            PopulateTreeView(selectedDrive);
            PopulateListView(selectedDrive);
        }

        private void tvwNaviPanel_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            var node = e.Node;

            
            if (node.Nodes.Count == 1 && node.Nodes[0].Text == "Loading...")
            {
                node.Nodes.Clear(); 

                
                LoadDirectories(node);
            }
        }

        private void cbViewMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { ChangeViewMode(cbViewMode.SelectedItem.ToString()); }
            catch
            { MessageBox.Show("Só Deus sabe"); }

        }

        private void lvMainPanel_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvMainPanel.SelectedItems.Count > 0)
            {
                var selectedItem = lvMainPanel.SelectedItems[0];

               
                if (selectedItem.SubItems[1].Text == "Folder")
                {
                    string path = Path.Combine(txtAddressBar.Text, selectedItem.Text);
                    string currentPath = txtAddressBar.Text;
                    try
                    {
                        PopulateListView(path);

                        directoryHistory.Push(currentPath);
                        txtAddressBar.Text = path;
                    }
                    catch (UnauthorizedAccessException )
                    {
                        MessageBox.Show("Acesso não autorizado \r\n Você não tem privilegios para ver esta pasta!", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAddressBar.Text = currentPath;
                        PopulateListView(currentPath);

                    }
                    catch (Exception )
                    {
                        MessageBox.Show("Só Deus sabe, mas provavelmete vc n tem acesso a esta pasta", "Erro!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAddressBar.Text = currentPath;
                        PopulateListView(currentPath);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (directoryHistory.Count > 0)
            {
                string previousPath = directoryHistory.Pop();
                PopulateListView(previousPath);
                txtAddressBar.Text = previousPath;
            }
            else
            {
                MessageBox.Show("Nenhuma pasta anterior no historico.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmsRightClickMenu_Click(object sender, EventArgs e)
        {

        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            CutItem();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            CopyItem();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            PasteItem();

        }

        private void lvMainPanel_MouseUp(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Right)
            {
               
                ListViewItem item = lvMainPanel.GetItemAt(e.X, e.Y);

                if (item != null)
                {
                   
                    item.Selected = true;

                   
                    cmsRightClickMenu.Show(lvMainPanel, e.Location);
                }
            }
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            CutItem();
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            CopyItem();
        }

        private void btnColar_Click(object sender, EventArgs e)
        {
            PasteItem();
        }

        private void tvwNaviPanel_AfterSelect(object sender, TreeViewEventArgs e)
        {
         
            string selectedPath = e.Node.Tag.ToString();

            try
            {
                
                PopulateListView(selectedPath);

              
                txtAddressBar.Text = selectedPath;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Acesso não autorizado \r\n Você não tem privilegios para ver esta pasta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Só ºDeus sabe {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
