using System.Runtime.CompilerServices;

namespace Kursovaia
{

    public partial class Saper : Form
    {
        private int difficult;
        private int Rows;
        private int Columns;
        private int Bombs; // Количество бомб
        private Button[,] buttons;
        private int[,] board;
        private bool isGameOver = false;

        public Saper(int difficult)
        {
            InitializeComponent();
            SetDifficulty(difficult);
            this.difficult = difficult;
            InitializeGame();
            this.StartPosition = FormStartPosition.CenterScreen; // Центрируем форму на экране
        }

        private void SetDifficulty(int difficult)
        {
            switch (difficult)
            {
                case 1:
                    Rows = 10;
                    Columns = 10;
                    Bombs = 10; // 10 бомб
                    this.Size = new Size(476, 498);
                    break;
                case 2:
                    Rows = 15;
                    Columns = 15;
                    Bombs = 30; // 30 бомб
                    this.Size = new Size(706, 728);
                    break;
                case 3:
                    Rows = 20;
                    Columns = 20;
                    Bombs = 50; // 50 бомб
                    this.Size = new Size(936, 958);
                    break;
                case 4:
                    Rows = 22;
                    Columns = 40;
                    Bombs = 100; // 100 бомб
                    this.Size = new Size(1100, 1100);
                    break;
            }
        }

        private void InitializeGame()
        {
            buttons = new Button[Rows, Columns];
            board = new int[Rows, Columns];

            TableLayoutPanel tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = Rows,
                ColumnCount = Columns
            };

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    buttons[i, j] = new Button
                    {
                        Size = new Size(40, 40),
                        BackColor = Color.LightGray
                    };
                    buttons[i, j].Click += Button_Click;
                    tableLayout.Controls.Add(buttons[i, j], j, i);
                }
            }
            this.Controls.Add(tableLayout);
            PlaceBombs();
            CalculateAdjacentBombs();
        }

        private void PlaceBombs()
        {
            Random random = new Random();
            int bombsPlaced = 0;
            while (bombsPlaced < Bombs)
            {
                int row = random.Next(Rows);
                int col = random.Next(Columns);
                if (board[row, col] != -1) // Если бомба не размещена
                {
                    board[row, col] = -1; // -1 означает бомбу
                    bombsPlaced++;
                }
            }
        }

        private void CalculateAdjacentBombs()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (board[i, j] != -1) // Если не бомба
                    {
                        int count = 0;
                        for (int x = -1; x <= 1; x++)
                        {
                            for (int y = -1; y <= 1; y++)
                            {
                                if (IsInBounds(i + x, j + y) && board[i + x, j + y] == -1)
                                    count++;
                            }
                        }
                        board[i, j] = count; // Установка количества соседних бомб
                    }
                }
            }
        }

        private bool IsInBounds(int row, int col)
        {
            return row >= 0 && row < Rows && col >= 0 && col < Columns;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (isGameOver) return;

            Button clickedButton = sender as Button;
            Point position = GetButtonPosition(clickedButton);
            if (position == Point.Empty) return;

            OpenCell(position.X, position.Y);
        }

        private Point GetButtonPosition(Button button)
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    if (buttons[i, j] == button)
                        return new Point(i, j);
                }
            }
            return Point.Empty;
        }

        private void OpenCell(int row, int col)
        {
            if (!IsInBounds(row, col) || buttons[row, col].Enabled == false || isGameOver)
                return;

            buttons[row, col].Enabled = false; // Открыть клетку
            buttons[row, col].BackColor = Color.DarkGray; // Задать цвет при раскрытии клетки

            if (board[row, col] == -1) // Бомба
            {
                string imagePath = Path.Combine(Application.StartupPath, "bomba.png");
                buttons[row, col].BackgroundImage = Image.FromFile(imagePath);
                buttons[row, col].BackgroundImageLayout = ImageLayout.Stretch; // Установить растяжение изображения
                MessageBox.Show("Игра окончена! Вы проиграли");
                isGameOver = true;

                // Закрываем текущую форму
                this.Close();
                return;
            }

            // Если есть соседние мины, показать число
            if (board[row, col] > 0)
            {
                buttons[row, col].Text = board[row, col].ToString(); // Показать количество бомб
            }
            else
            {
                buttons[row, col].Text = ""; // Удалить текст, если нет соседних мин
                // Если нет соседних бомб, открываем соседние клетки
                for (int x = -1; x <= 1; x++)
                {
                    for (int y = -1; y <= 1; y++)
                    {
                        // Открывать только соседние клетки, которые не равны (0, 0)
                        if (x == 0 && y == 0) continue;
                        OpenCell(row + x, col + y);
                    }
                }
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Form1 form1 = new Form1(difficult);
            form1.Show();
            this.Hide();
        }
    }
}