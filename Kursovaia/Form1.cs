namespace Kursovaia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // ������� ����� � ������
            this.StartPosition = FormStartPosition.CenterScreen; // ���������� ����� �� ������
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

        private void HowPlay_Click_1(object sender, EventArgs e)
        {
            HowPlay howPlayForm = new HowPlay();
            howPlayForm.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close(); // ��������� ������� �����
        }
    }
}
