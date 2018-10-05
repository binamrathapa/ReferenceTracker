namespace ReferenceTracker
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.referenceManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addReferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportReferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayTagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagArticlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbCitationStyle = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSorting = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referenceManageToolStripMenuItem,
            this.manageTagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referenceManageToolStripMenuItem
            // 
            this.referenceManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addReferenceToolStripMenuItem,
            this.referencesToolStripMenuItem,
            this.exportReferencesToolStripMenuItem});
            this.referenceManageToolStripMenuItem.Name = "referenceManageToolStripMenuItem";
            this.referenceManageToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.referenceManageToolStripMenuItem.Text = "Manage References";
            // 
            // addReferenceToolStripMenuItem
            // 
            this.addReferenceToolStripMenuItem.Name = "addReferenceToolStripMenuItem";
            this.addReferenceToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.addReferenceToolStripMenuItem.Text = "Add Reference";
            this.addReferenceToolStripMenuItem.Click += new System.EventHandler(this.addReferenceToolStripMenuItem_Click);
            // 
            // referencesToolStripMenuItem
            // 
            this.referencesToolStripMenuItem.Name = "referencesToolStripMenuItem";
            this.referencesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.referencesToolStripMenuItem.Text = "Display All References";
            this.referencesToolStripMenuItem.Click += new System.EventHandler(this.referencesToolStripMenuItem_Click);
            // 
            // exportReferencesToolStripMenuItem
            // 
            this.exportReferencesToolStripMenuItem.Name = "exportReferencesToolStripMenuItem";
            this.exportReferencesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.exportReferencesToolStripMenuItem.Text = "Export References";
            this.exportReferencesToolStripMenuItem.Click += new System.EventHandler(this.exportReferencesToolStripMenuItem_Click);
            // 
            // manageTagsToolStripMenuItem
            // 
            this.manageTagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTagToolStripMenuItem,
            this.displayTagsToolStripMenuItem,
            this.tagArticlesToolStripMenuItem});
            this.manageTagsToolStripMenuItem.Name = "manageTagsToolStripMenuItem";
            this.manageTagsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.manageTagsToolStripMenuItem.Text = "Manage Tags";
            // 
            // addTagToolStripMenuItem
            // 
            this.addTagToolStripMenuItem.Name = "addTagToolStripMenuItem";
            this.addTagToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addTagToolStripMenuItem.Text = "Add Tag";
            this.addTagToolStripMenuItem.Click += new System.EventHandler(this.addTagToolStripMenuItem_Click);
            // 
            // displayTagsToolStripMenuItem
            // 
            this.displayTagsToolStripMenuItem.Name = "displayTagsToolStripMenuItem";
            this.displayTagsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayTagsToolStripMenuItem.Text = "Display Tags";
            this.displayTagsToolStripMenuItem.Click += new System.EventHandler(this.displayTagsToolStripMenuItem_Click);
            // 
            // tagArticlesToolStripMenuItem
            // 
            this.tagArticlesToolStripMenuItem.Name = "tagArticlesToolStripMenuItem";
            this.tagArticlesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tagArticlesToolStripMenuItem.Text = "Tag Articles";
            this.tagArticlesToolStripMenuItem.Click += new System.EventHandler(this.tagArticlesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 394);
            this.panel1.TabIndex = 2;
            // 
            // cbCitationStyle
            // 
            this.cbCitationStyle.FormattingEnabled = true;
            this.cbCitationStyle.Items.AddRange(new object[] {
            "Harvard",
            "APA",
            "Chicago"});
            this.cbCitationStyle.Location = new System.Drawing.Point(12, 41);
            this.cbCitationStyle.Name = "cbCitationStyle";
            this.cbCitationStyle.Size = new System.Drawing.Size(121, 21);
            this.cbCitationStyle.TabIndex = 3;
            this.cbCitationStyle.Text = "ChooseCitation Style";
            this.cbCitationStyle.SelectedIndexChanged += new System.EventHandler(this.cbCitationStyle_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(139, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 20);
            this.txtSearch.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSorting
            // 
            this.cbSorting.FormattingEnabled = true;
            this.cbSorting.Items.AddRange(new object[] {
            "Title",
            "Journal",
            "Year",
            "Author"});
            this.cbSorting.Location = new System.Drawing.Point(363, 42);
            this.cbSorting.Name = "cbSorting";
            this.cbSorting.Size = new System.Drawing.Size(121, 21);
            this.cbSorting.TabIndex = 7;
            this.cbSorting.Text = "Choose Sorting";
            this.cbSorting.SelectedIndexChanged += new System.EventHandler(this.cbSorting_SelectedIndexChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 462);
            this.Controls.Add(this.cbSorting);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cbCitationStyle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referenceManageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addReferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referencesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbCitationStyle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ToolStripMenuItem manageTagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayTagsToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbSorting;
        private System.Windows.Forms.ToolStripMenuItem exportReferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagArticlesToolStripMenuItem;
    }
}