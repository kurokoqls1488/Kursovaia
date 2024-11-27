using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaia
{
    public partial class Saper : Form
    {
        private const int Rows = 20;
        private const int Columns = 20;
        private const int Bombs = 30; // 20% бомб
        private Button[,] buttons = new Button[Rows, Columns];
        private int[,] board = new int[Rows, Columns];
        private bool isGameOver = false;

        public Saper()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
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
                buttons[row, col].Enabled = false; // Открыть клетку
                MessageBox.Show("Game Over!");
                isGameOver = true;
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
    }
}