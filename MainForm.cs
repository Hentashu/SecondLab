namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            _3RegistrationForm newForm = new _3RegistrationForm();
            newForm.Show();
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            _4RemoveForm newForm = new _4RemoveForm();
            newForm.Show();
        }

        private void buttonEventsInfo_Click(object sender, EventArgs e)
        {
            InfoEventForm newForm = new InfoEventForm();
            newForm.Show();
        }
    }
}
