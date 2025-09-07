namespace GestPeso
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var menu = new menu();
            menu.Show();

        }
    }
}
