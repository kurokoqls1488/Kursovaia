using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaia
{
    public partial class complexity : Form
    {
        public complexity()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // Убираем рамку и кнопки
            this.StartPosition = FormStartPosition.Manual; // Устанавливаем ручное позиционирование
            this.Location = new Point(40, 40); // Устанавливаем положение в верхний левый угол .
        }

        private void BackToMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
