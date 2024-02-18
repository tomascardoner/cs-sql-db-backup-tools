namespace CSSqlDbBackupTools
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            ButtonRestoreDatabase = new Button();
            ButtonBackupDatabase = new Button();
            SuspendLayout();
            // 
            // ButtonRestoreDatabase
            // 
            ButtonRestoreDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonRestoreDatabase.FlatStyle = FlatStyle.System;
            ButtonRestoreDatabase.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonRestoreDatabase.Location = new Point(13, 174);
            ButtonRestoreDatabase.Margin = new Padding(4, 3, 4, 3);
            ButtonRestoreDatabase.Name = "ButtonRestoreDatabase";
            ButtonRestoreDatabase.Size = new Size(433, 150);
            ButtonRestoreDatabase.TabIndex = 1;
            ButtonRestoreDatabase.Text = "Restore Database";
            ButtonRestoreDatabase.UseVisualStyleBackColor = true;
            ButtonRestoreDatabase.Click += ButtonRestoreDatabase_Click;
            // 
            // ButtonBackupDatabase
            // 
            ButtonBackupDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ButtonBackupDatabase.Enabled = false;
            ButtonBackupDatabase.FlatStyle = FlatStyle.System;
            ButtonBackupDatabase.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonBackupDatabase.Location = new Point(13, 12);
            ButtonBackupDatabase.Margin = new Padding(4, 3, 4, 3);
            ButtonBackupDatabase.Name = "ButtonBackupDatabase";
            ButtonBackupDatabase.Size = new Size(433, 150);
            ButtonBackupDatabase.TabIndex = 0;
            ButtonBackupDatabase.Text = "Backup Database";
            ButtonBackupDatabase.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 336);
            Controls.Add(ButtonRestoreDatabase);
            Controls.Add(ButtonBackupDatabase);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CS-SQL DB Backup Tools";
            ResumeLayout(false);
        }

        #endregion

        internal Button ButtonRestoreDatabase;
        internal Button ButtonBackupDatabase;
    }
}
