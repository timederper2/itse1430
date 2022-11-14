namespace KPascua.ContactManager.UI
{
    partial class ContactDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
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
        private void InitializeComponent ()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._cmFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._cmContactAdd = new System.Windows.Forms.ToolStripMenuItem();
            this._cmContactEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._cmContactDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._csHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._lstContacts = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(933, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cmFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _cmFileExit
            // 
            this._cmFileExit.Name = "_cmFileExit";
            this._cmFileExit.Size = new System.Drawing.Size(180, 22);
            this._cmFileExit.Text = "E&xit";
            this._cmFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._cmContactAdd,
            this._cmContactEdit,
            this._cmContactDelete});
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contactsToolStripMenuItem.Text = "&Contacts";
            // 
            // _cmContactAdd
            // 
            this._cmContactAdd.Name = "_cmContactAdd";
            this._cmContactAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._cmContactAdd.Size = new System.Drawing.Size(180, 22);
            this._cmContactAdd.Text = "&Add";
            this._cmContactAdd.Click += new System.EventHandler(this.OnContactAdd);
            // 
            // _cmContactEdit
            // 
            this._cmContactEdit.Name = "_cmContactEdit";
            this._cmContactEdit.Size = new System.Drawing.Size(180, 22);
            this._cmContactEdit.Text = "&Edit";
            this._cmContactEdit.Click += new System.EventHandler(this.OnContactEdit);
            // 
            // _cmContactDelete
            // 
            this._cmContactDelete.Name = "_cmContactDelete";
            this._cmContactDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._cmContactDelete.Size = new System.Drawing.Size(180, 22);
            this._cmContactDelete.Text = "&Delete";
            this._cmContactDelete.Click += new System.EventHandler(this.OnContactDelete);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._csHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _csHelpAbout
            // 
            this._csHelpAbout.Name = "_csHelpAbout";
            this._csHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._csHelpAbout.Size = new System.Drawing.Size(180, 22);
            this._csHelpAbout.Text = "&About";
            this._csHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // _lstContacts
            // 
            this._lstContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lstContacts.FormattingEnabled = true;
            this._lstContacts.ItemHeight = 15;
            this._lstContacts.Location = new System.Drawing.Point(0, 27);
            this._lstContacts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this._lstContacts.Name = "_lstContacts";
            this._lstContacts.Size = new System.Drawing.Size(933, 484);
            this._lstContacts.TabIndex = 1;
            // 
            // ContactDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this._lstContacts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ContactDisplay";
            this.Text = "Kenneth V. Pascua";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _cmFileExit;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _csHelpAbout;
        private System.Windows.Forms.ListBox _lstContacts;
        private ToolStripMenuItem _cmContactAdd;
        private ToolStripMenuItem _cmContactEdit;
        private ToolStripMenuItem _cmContactDelete;
    }
}