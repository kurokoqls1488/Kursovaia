using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kursovaia
{

    public partial class Saper : Form
    {
        private System.Windows.Forms.Timer timer;
        private int secondsElapsed = 0; // Счетчик секунд


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
                    Bombs = 5; // 5 бомб
                    this.Size = new Size(476, 498);
                    break;
                case 2:
                    Rows = 15;
                    Columns = 15;
                    Bombs = 40; // 40 бомб
                    this.Size = new Size(706, 728);
                    break;
                case 3:
                    Rows = 20;
                    Columns = 20;
                    Bombs = 100; // 100 бомб
                    this.Size = new Size(936, 958);
                    break;
                case 4:
                    Rows = 22;
                    Columns = 40;
                    Bombs = 300; // 300 бомб
                    this.Size = new Size(1856, 1600);
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
                    // Создание новой кнопки
                    buttons[i, j] = new Button
                    {
                        Size = new Size(40, 40), // Установка размера кнопки
                        BackColor = Color.LightGray // Установка фона кнопки
                    };
                    // Подписка на событие клика по кнопке
                    buttons[i, j].Click += Button_Click;

                    buttons[i, j].MouseDown += Button_MouseDown;
                    tableLayout.Controls.Add(buttons[i, j], j, i);
                }
            }
            // Добавление таблицы на форму
            this.Controls.Add(tableLayout);
            // Размещение бомб на игровом поле
            PlaceBombs();
            // Подсчет количества соседних бомб для каждой клетки
            CalculateAdjacentBombs();

            // Инициализация таймера
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // 1 секунда
            timer.Tick += Timer_Tick;
            timer.Start(); // Запуск таймера
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++; // Увеличиваем счетчик секунд
            this.Text = $"Saper - Время: {secondsElapsed} секунд"; // Обновляем заголовок формы
        }
        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) // Проверяем, была ли нажата правая кнопка мыши
            {
                Button clickedButton = sender as Button;
                if (clickedButton != null) // Проверяем, что кнопка не равна null
                {
                    // Проверяем, есть ли уже изображение флага
                    if (clickedButton.BackgroundImage != null)
                    {
                        // Убираем флаг
                        clickedButton.BackgroundImage = null;
                        clickedButton.Enabled = true; // Делаем кнопку активной
                    }
                    else if (clickedButton.Enabled) // Если кнопка активна и флага нет
                    {
                        // Установка изображения флага
                        string flagImagePath = Path.Combine(Application.StartupPath, "Flag.png");
                        clickedButton.BackgroundImage = Image.FromFile(flagImagePath);
                        clickedButton.BackgroundImageLayout = ImageLayout.Stretch; // Установить растяжение изображения
                        //clickedButton.Enabled = false; // Делаем кнопку неактивной, чтобы нельзя было открыть клетку
                    }
                }
            }
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
                    if (board[i, j] != -1) // Если текущая клетка не содержит бомбу
                    {
                        int count = 0; // Инициализация счетчика для подсчета соседних бомб
                                       // Циклы для проверки всех соседних клеток (всего 8 соседей)
                        
                        for (int x = -1; x <= 1; x++) // Перебор по строкам соседей
                        {
                            for (int y = -1; y <= 1; y++) // Перебор по столбцам соседей
                            {
                                // Проверка, находится ли соседняя клетка в пределах игрового поля
                                // и содержит ли она бомбу
                                if (IsInBounds(i + x, j + y) && board[i + x, j + y] == -1)
                                    count++; // Увеличиваем счетчик, если соседняя клетка - бомба
                                
                            }
                        }
                        board[i, j] = count; // Установка количества соседних бомб
                        //Добавляем в счетчик если не бомба

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
        private int openedCells = 0;
        private void OpenCell(int row, int col)
        {
            if (!IsInBounds(row, col) || buttons[row, col].Enabled == false || isGameOver)
                return;

            buttons[row, col].Enabled = false; // Открыть клетку
            buttons[row, col].BackgroundImage = null;
            buttons[row, col].BackColor = Color.DarkGray; // Задать цвет при раскрытии клетки

            if (board[row, col] == -1) // Бомба
            {
                string imagePath = Path.Combine(Application.StartupPath, "bomba.png");
                buttons[row, col].BackgroundImage = Image.FromFile(imagePath);
                buttons[row, col].BackgroundImageLayout = ImageLayout.Stretch; // Установить растяжение изображения
                timer.Stop(); // Остановить таймер
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
            // Увеличиваем количество открытых клеток
            openedCells++;

            // Проверяем условие победы
            if (openedCells == Rows * Columns - Bombs)
            {
                timer.Stop(); // Остановить таймер
                MessageBox.Show($"Поздравляем! Вы выиграли за {secondsElapsed} секунд!");
                isGameOver = true;
                
                this.Close(); // Закрываем форму после победы
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