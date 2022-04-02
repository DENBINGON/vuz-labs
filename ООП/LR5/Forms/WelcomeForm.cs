namespace LR5;

public partial class WelcomeForm : Form
{
    private Player _player;
    public WelcomeForm(Player player)
    {
        InitializeComponent();
        _player = player;
        Text text = new Text(_player);
        textBox1.Text = text.welcomeMessage;
    }


    private void button1_Click_1(object sender, EventArgs e)
    {
        GameForm form1 = new GameForm(_player);     
        form1.Show();
        this.Close();
    }
}