namespace Kursovaia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            Saper saperForm = new Saper();
            saperForm.Show();
            this.Hide();
        }
    }
}
