namespace Konu22WindowsForms
{
    partial class Form9
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("MCPD Yazilim Egitimi");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Grafik Tasarim");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Sql Raporlama");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Mobil Uygulama Gelistirme");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Kurslar", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("C# Egitim");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Windows Forms");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("SQL");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Yaziliom Egitim Konulari", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Egitim Icerikleri", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(258, 137);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "MCPD Yazilim Egitimi";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Grafik Tasarim";
            treeNode3.Name = "Node3";
            treeNode3.Text = "Sql Raporlama";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Mobil Uygulama Gelistirme";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Kurslar";
            treeNode6.Name = "Node8";
            treeNode6.Text = "C# Egitim";
            treeNode7.Name = "Node9";
            treeNode7.Text = "Windows Forms";
            treeNode8.Name = "Node10";
            treeNode8.Text = "SQL";
            treeNode9.Name = "Node7";
            treeNode9.Text = "Yaziliom Egitim Konulari";
            treeNode10.Name = "Node5";
            treeNode10.Text = "Egitim Icerikleri";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(340, 205);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form9";
            this.Text = "Treeview Kullanimi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}