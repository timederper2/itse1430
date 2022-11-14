namespace KennethVPascua.ContactManager.UI
{
    partial class ContactEntry
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
            this.components = new System.ComponentModel.Container();
            this._txtFirstName = new System.Windows.Forms.TextBox();
            this._txtLastName = new System.Windows.Forms.TextBox();
            this._txtEmail = new System.Windows.Forms.TextBox();
            this._txtNotes = new System.Windows.Forms.TextBox();
            this._chkFavoriteContact = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._errors = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errors)).BeginInit();
            this.SuspendLayout();
            // 
            // _txtFirstName
            // 
            this._txtFirstName.Location = new System.Drawing.Point(168, 43);
            this._txtFirstName.Name = "_txtFirstName";
            this._txtFirstName.Size = new System.Drawing.Size(198, 20);
            this._txtFirstName.TabIndex = 0;
            // 
            // _txtLastName
            // 
            this._txtLastName.Location = new System.Drawing.Point(168, 81);
            this._txtLastName.Name = "_txtLastName";
            this._txtLastName.Size = new System.Drawing.Size(198, 20);
            this._txtLastName.TabIndex = 1;
            // 
            // _txtEmail
            // 
            this._txtEmail.Location = new System.Drawing.Point(168, 124);
            this._txtEmail.Name = "_txtEmail";
            this._txtEmail.Size = new System.Drawing.Size(198, 20);
            this._txtEmail.TabIndex = 2;
            // 
            // _txtNotes
            // 
            this._txtNotes.Location = new System.Drawing.Point(172, 231);
            this._txtNotes.Multiline = true;
            this._txtNotes.Name = "_txtNotes";
            this._txtNotes.Size = new System.Drawing.Size(194, 156);
            this._txtNotes.TabIndex = 3;
            // 
            // _chkFavoriteContact
            // 
            this._chkFavoriteContact.AutoSize = true;
            this._chkFavoriteContact.Location = new System.Drawing.Point(168, 172);
            this._chkFavoriteContact.Name = "_chkFavoriteContact";
            this._chkFavoriteContact.Size = new System.Drawing.Size(104, 17);
            this._chkFavoriteContact.TabIndex = 4;
            this._chkFavoriteContact.Text = "Favorite Contact";
            this._chkFavoriteContact.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(38, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name (optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(36, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name (required)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(64, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email (required)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(66, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Notes (optional)";
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(197, 415);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 9;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(291, 415);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 10;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _errors
            // 
            this._errors.ContainerControl = this;
            // 
            // ContactEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._chkFavoriteContact);
            this.Controls.Add(this._txtNotes);
            this.Controls.Add(this._txtEmail);
            this.Controls.Add(this._txtLastName);
            this.Controls.Add(this._txtFirstName);
            this.Name = "ContactEntry";
            this.Text = "Enter A Contact";
            ((System.ComponentModel.ISupportInitialize)(this._errors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtFirstName;
        private System.Windows.Forms.TextBox _txtLastName;
        private System.Windows.Forms.TextBox _txtEmail;
        private System.Windows.Forms.TextBox _txtNotes;
        private System.Windows.Forms.CheckBox _chkFavoriteContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.ErrorProvider _errors;
    }
}