namespace V1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           button_start.Enabled = false;
            //note idk
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = "SANDU E GAY";
            textBox1.Name = "text_box_1";
        }
    }
}