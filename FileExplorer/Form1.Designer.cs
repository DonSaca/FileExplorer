
namespace FileExplorer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvwNaviPanel = new System.Windows.Forms.TreeView();
            this.lvMainPanel = new System.Windows.Forms.ListView();
            this.imgMainPanel = new System.Windows.Forms.ImageList(this.components);
            this.imglNaviPanel = new System.Windows.Forms.ImageList(this.components);
            this.txtAddressBar = new System.Windows.Forms.TextBox();
            this.cbDrives = new System.Windows.Forms.ComboBox();
            this.cmsRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statstripInfo = new System.Windows.Forms.StatusStrip();
            this.cbViewMode = new System.Windows.Forms.ComboBox();
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.btnColar = new System.Windows.Forms.Button();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.btnCortar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmsRightClickMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwNaviPanel
            // 
            this.tvwNaviPanel.ImageIndex = 0;
            this.tvwNaviPanel.ImageList = this.imglNaviPanel;
            this.tvwNaviPanel.Location = new System.Drawing.Point(0, 94);
            this.tvwNaviPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvwNaviPanel.Name = "tvwNaviPanel";
            this.tvwNaviPanel.SelectedImageIndex = 0;
            this.tvwNaviPanel.Size = new System.Drawing.Size(255, 535);
            this.tvwNaviPanel.TabIndex = 0;
            this.tvwNaviPanel.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwNaviPanel_BeforeExpand);
            this.tvwNaviPanel.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwNaviPanel_AfterSelect);
            // 
            // lvMainPanel
            // 
            this.lvMainPanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cName,
            this.cType,
            this.cSize,
            this.cDate});
            this.lvMainPanel.HideSelection = false;
            this.lvMainPanel.LargeImageList = this.imgMainPanel;
            this.lvMainPanel.Location = new System.Drawing.Point(262, 94);
            this.lvMainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvMainPanel.Name = "lvMainPanel";
            this.lvMainPanel.Size = new System.Drawing.Size(880, 535);
            this.lvMainPanel.SmallImageList = this.imgMainPanel;
            this.lvMainPanel.TabIndex = 1;
            this.lvMainPanel.UseCompatibleStateImageBehavior = false;
            this.lvMainPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMainPanel_MouseDoubleClick);
            this.lvMainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvMainPanel_MouseUp);
            // 
            // imgMainPanel
            // 
            this.imgMainPanel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgMainPanel.ImageStream")));
            this.imgMainPanel.TransparentColor = System.Drawing.Color.Transparent;
            this.imgMainPanel.Images.SetKeyName(0, "folder.png");
            this.imgMainPanel.Images.SetKeyName(1, "File.png");
            // 
            // imglNaviPanel
            // 
            this.imglNaviPanel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglNaviPanel.ImageStream")));
            this.imglNaviPanel.TransparentColor = System.Drawing.Color.Transparent;
            this.imglNaviPanel.Images.SetKeyName(0, "Folder.png");
            // 
            // txtAddressBar
            // 
            this.txtAddressBar.Enabled = false;
            this.txtAddressBar.Location = new System.Drawing.Point(262, 3);
            this.txtAddressBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddressBar.Name = "txtAddressBar";
            this.txtAddressBar.Size = new System.Drawing.Size(880, 26);
            this.txtAddressBar.TabIndex = 2;
            // 
            // cbDrives
            // 
            this.cbDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrives.FormattingEnabled = true;
            this.cbDrives.Location = new System.Drawing.Point(0, 56);
            this.cbDrives.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDrives.Name = "cbDrives";
            this.cbDrives.Size = new System.Drawing.Size(136, 28);
            this.cbDrives.TabIndex = 3;
            this.cbDrives.SelectedIndexChanged += new System.EventHandler(this.cbDrives_SelectedIndexChanged);
            // 
            // cmsRightClickMenu
            // 
            this.cmsRightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCut,
            this.tsmiCopy,
            this.tsmiPaste});
            this.cmsRightClickMenu.Name = "cmsRightClickMenu";
            this.cmsRightClickMenu.Size = new System.Drawing.Size(127, 100);
            this.cmsRightClickMenu.Click += new System.EventHandler(this.cmsRightClickMenu_Click);
            // 
            // statstripInfo
            // 
            this.statstripInfo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statstripInfo.Location = new System.Drawing.Point(0, 672);
            this.statstripInfo.Name = "statstripInfo";
            this.statstripInfo.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statstripInfo.Size = new System.Drawing.Size(1183, 22);
            this.statstripInfo.TabIndex = 5;
            this.statstripInfo.Text = "statusStrip1";
            // 
            // cbViewMode
            // 
            this.cbViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbViewMode.FormattingEnabled = true;
            this.cbViewMode.Items.AddRange(new object[] {
            "Large",
            "Small",
            "List",
            "Details"});
            this.cbViewMode.Location = new System.Drawing.Point(1007, 56);
            this.cbViewMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbViewMode.Name = "cbViewMode";
            this.cbViewMode.Size = new System.Drawing.Size(136, 28);
            this.cbViewMode.TabIndex = 6;
            this.cbViewMode.SelectedIndexChanged += new System.EventHandler(this.cbViewMode_SelectedIndexChanged);
            // 
            // cName
            // 
            this.cName.Text = "Name";
            this.cName.Width = 250;
            // 
            // cType
            // 
            this.cType.Text = "Type";
            this.cType.Width = 100;
            // 
            // cSize
            // 
            this.cSize.Text = "Size";
            this.cSize.Width = 100;
            // 
            // cDate
            // 
            this.cDate.Text = "Date Modified";
            this.cDate.Width = 150;
            // 
            // tsmiCut
            // 
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(126, 32);
            this.tsmiCut.Text = "Cut";
            this.tsmiCut.Click += new System.EventHandler(this.tsmiCut_Click);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(126, 32);
            this.tsmiCopy.Text = "Copy";
            this.tsmiCopy.Click += new System.EventHandler(this.tsmiCopy_Click);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(126, 32);
            this.tsmiPaste.Text = "Paste";
            this.tsmiPaste.Click += new System.EventHandler(this.tsmiPaste_Click);
            // 
            // btnColar
            // 
            this.btnColar.BackgroundImage = global::FileExplorer.Properties.Resources.COLAR;
            this.btnColar.Location = new System.Drawing.Point(879, 47);
            this.btnColar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnColar.Name = "btnColar";
            this.btnColar.Size = new System.Drawing.Size(85, 44);
            this.btnColar.TabIndex = 10;
            this.btnColar.Text = "COLAR";
            this.btnColar.UseVisualStyleBackColor = true;
            this.btnColar.Click += new System.EventHandler(this.btnColar_Click);
            // 
            // btnCopiar
            // 
            this.btnCopiar.BackgroundImage = global::FileExplorer.Properties.Resources.COPIAR;
            this.btnCopiar.Location = new System.Drawing.Point(779, 54);
            this.btnCopiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(82, 37);
            this.btnCopiar.TabIndex = 9;
            this.btnCopiar.Text = "COPIAR";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // btnCortar
            // 
            this.btnCortar.BackgroundImage = global::FileExplorer.Properties.Resources.CORTAR1;
            this.btnCortar.Location = new System.Drawing.Point(655, 47);
            this.btnCortar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCortar.Name = "btnCortar";
            this.btnCortar.Size = new System.Drawing.Size(118, 44);
            this.btnCortar.TabIndex = 8;
            this.btnCortar.Text = "CORTAR";
            this.btnCortar.UseVisualStyleBackColor = true;
            this.btnCortar.Click += new System.EventHandler(this.btnCortar_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::FileExplorer.Properties.Resources.Backbtn;
            this.btnBack.Location = new System.Drawing.Point(262, 47);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 44);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cortar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(779, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Copiar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(875, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Colar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 694);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnColar);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.btnCortar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cbViewMode);
            this.Controls.Add(this.statstripInfo);
            this.Controls.Add(this.cbDrives);
            this.Controls.Add(this.txtAddressBar);
            this.Controls.Add(this.lvMainPanel);
            this.Controls.Add(this.tvwNaviPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cmsRightClickMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvwNaviPanel;
        private System.Windows.Forms.ListView lvMainPanel;
        private System.Windows.Forms.ImageList imglNaviPanel;
        private System.Windows.Forms.ImageList imgMainPanel;
        private System.Windows.Forms.TextBox txtAddressBar;
        private System.Windows.Forms.ComboBox cbDrives;
        private System.Windows.Forms.ContextMenuStrip cmsRightClickMenu;
        private System.Windows.Forms.StatusStrip statstripInfo;
        private System.Windows.Forms.ComboBox cbViewMode;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cType;
        private System.Windows.Forms.ColumnHeader cSize;
        private System.Windows.Forms.ColumnHeader cDate;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.Button btnCortar;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.Button btnColar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

