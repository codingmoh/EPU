namespace Backoffice
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Home", 18, 18);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Projekt A", 16, 16);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Projekt B", 16, 16);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Projekt C", 16, 16);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Projekt D", 16, 16);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("2012", 5, 5, new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Projekte", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Rudi Rakete", 17, 17);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Norbert Nukular", 17, 17);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Kunden", 12, 12, new System.Windows.Forms.TreeNode[] {
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Finanzen", 4, 4);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Suche", 1, 1);
            this.projectContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.asdasdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tangoIcons = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nativeTreeView1 = new Backoffice.CustomForms.NativeTreeView();
            this.projectContextMenu.SuspendLayout();
            this.clientContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectContextMenu
            // 
            this.projectContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asdasdToolStripMenuItem,
            this.asdToolStripMenuItem});
            this.projectContextMenu.Name = "projectContextMenu";
            this.projectContextMenu.Size = new System.Drawing.Size(119, 48);
            // 
            // asdasdToolStripMenuItem
            // 
            this.asdasdToolStripMenuItem.Name = "asdasdToolStripMenuItem";
            this.asdasdToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.asdasdToolStripMenuItem.Text = "Erstellen";
            // 
            // asdToolStripMenuItem
            // 
            this.asdToolStripMenuItem.Name = "asdToolStripMenuItem";
            this.asdToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.asdToolStripMenuItem.Text = "Suchen";
            // 
            // clientContextMenu
            // 
            this.clientContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.clientContextMenu.Name = "projectContextMenu";
            this.clientContextMenu.Size = new System.Drawing.Size(119, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem1.Text = "Erstellen";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(118, 22);
            this.toolStripMenuItem2.Text = "Suchen";
            // 
            // tangoIcons
            // 
            this.tangoIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tangoIcons.ImageStream")));
            this.tangoIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.tangoIcons.Images.SetKeyName(0, "Box.png");
            this.tangoIcons.Images.SetKeyName(1, "FolderSearch.png");
            this.tangoIcons.Images.SetKeyName(2, "Pens.png");
            this.tangoIcons.Images.SetKeyName(3, "ScissorRuler.png");
            this.tangoIcons.Images.SetKeyName(4, "Calculator.png");
            this.tangoIcons.Images.SetKeyName(5, "FolderClosed.png");
            this.tangoIcons.Images.SetKeyName(6, "FolderExposed.png");
            this.tangoIcons.Images.SetKeyName(7, "FolderNetwork.png");
            this.tangoIcons.Images.SetKeyName(8, "FolderNew.png");
            this.tangoIcons.Images.SetKeyName(9, "FolderOpen.png");
            this.tangoIcons.Images.SetKeyName(10, "GearSilver.png");
            this.tangoIcons.Images.SetKeyName(11, "MailBook.png");
            this.tangoIcons.Images.SetKeyName(12, "User.png");
            this.tangoIcons.Images.SetKeyName(13, "Collar.png");
            this.tangoIcons.Images.SetKeyName(14, "Desktop.png");
            this.tangoIcons.Images.SetKeyName(15, "EmoticonDevil.png");
            this.tangoIcons.Images.SetKeyName(16, "Pens.png");
            this.tangoIcons.Images.SetKeyName(17, "User.png");
            this.tangoIcons.Images.SetKeyName(18, "Home.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Click Me!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kontakt Test:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(276, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Rechnung Test:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Click Me!";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "(value)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(485, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Ausgangsrechnung Test:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "(ID)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(510, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "(RechnungID)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(512, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "(AngebotID)";
            // 
            // nativeTreeView1
            // 
            this.nativeTreeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.nativeTreeView1.FullRowSelect = true;
            this.nativeTreeView1.ImageIndex = 0;
            this.nativeTreeView1.ImageList = this.tangoIcons;
            this.nativeTreeView1.Location = new System.Drawing.Point(0, 0);
            this.nativeTreeView1.Name = "nativeTreeView1";
            treeNode1.ImageIndex = 18;
            treeNode1.Name = "Node0";
            treeNode1.SelectedImageIndex = 18;
            treeNode1.Text = "Home";
            treeNode2.ImageIndex = 16;
            treeNode2.Name = "Node5";
            treeNode2.SelectedImageIndex = 16;
            treeNode2.Text = "Projekt A";
            treeNode3.ImageIndex = 16;
            treeNode3.Name = "Node6";
            treeNode3.SelectedImageIndex = 16;
            treeNode3.Text = "Projekt B";
            treeNode4.ImageIndex = 16;
            treeNode4.Name = "Node8";
            treeNode4.SelectedImageIndex = 16;
            treeNode4.Text = "Projekt C";
            treeNode5.ImageIndex = 16;
            treeNode5.Name = "Node9";
            treeNode5.SelectedImageIndex = 16;
            treeNode5.Text = "Projekt D";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "Node7";
            treeNode6.SelectedImageIndex = 5;
            treeNode6.Text = "2012";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "Node1";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Text = "Projekte";
            treeNode8.ImageIndex = 17;
            treeNode8.Name = "Node10";
            treeNode8.SelectedImageIndex = 17;
            treeNode8.Text = "Rudi Rakete";
            treeNode9.ImageIndex = 17;
            treeNode9.Name = "Node11";
            treeNode9.SelectedImageIndex = 17;
            treeNode9.Text = "Norbert Nukular";
            treeNode10.ImageIndex = 12;
            treeNode10.Name = "Node2";
            treeNode10.SelectedImageIndex = 12;
            treeNode10.Text = "Kunden";
            treeNode11.ImageIndex = 4;
            treeNode11.Name = "Node3";
            treeNode11.SelectedImageIndex = 4;
            treeNode11.Text = "Finanzen";
            treeNode12.ImageIndex = 1;
            treeNode12.Name = "Node4";
            treeNode12.SelectedImageIndex = 1;
            treeNode12.Text = "Suche";
            this.nativeTreeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode7,
            treeNode10,
            treeNode11,
            treeNode12});
            this.nativeTreeView1.SelectedImageIndex = 0;
            this.nativeTreeView1.ShowLines = false;
            this.nativeTreeView1.Size = new System.Drawing.Size(229, 505);
            this.nativeTreeView1.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 505);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nativeTreeView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Devil\'s Backoffice";
            this.projectContextMenu.ResumeLayout(false);
            this.clientContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList tangoIcons;
        private System.Windows.Forms.ContextMenuStrip clientContextMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip projectContextMenu;
        private System.Windows.Forms.ToolStripMenuItem asdasdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asdToolStripMenuItem;
        private CustomForms.NativeTreeView nativeTreeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;

    }
}

