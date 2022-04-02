namespace LR5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.SelectedIndex != -1)
            {
                Player player = new Player(comboBox1.SelectedIndex, textBox1.Text, 100, 20, 1000);
                WelcomeForm form = new WelcomeForm(player);
                this.Hide();
                form.Show();
            }
            else
            {
                Error err = new Error();
                err.Show();
            }
        }
    }
}
