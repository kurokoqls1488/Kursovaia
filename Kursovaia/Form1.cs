namespace Kursovaia
{
    public partial class Form1 : Form
    {
        private int difficult;
        public Form1(int difficult)
        {
            InitializeComponent();
            this.difficult = difficult;
            this.FormBorderStyle = FormBorderStyle.None; // Убираем рамку и кнопки
            this.StartPosition = FormStartPosition.CenterScreen; // Центрируем форму на экране
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Play_Click(object sender, EventArgs e)
        {
            Saper saperForm = new Saper(difficult);
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
            Environment.Exit(0); // завершает процесс приложения с кодом
        }

        private void complexity_Click(object sender, EventArgs e)
        {
            complexity complexityForm = new complexity();
            complexityForm.Show();
            this.Hide();
        }


        private void Play_MouseEnter(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "buttonFonLight.png"));
        }

        private void Play_MouseLeave(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "buttonFon.png"));
        }
    }
}
