namespace CSSqlDbBackupTools
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonRestoreDatabase_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FormRestoreDatabase formRestoreDatabase = new();
            formRestoreDatabase.ShowDialog();
            this.Cursor = Cursor.Current;
        }
    }
}
