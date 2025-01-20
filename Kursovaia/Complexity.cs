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
        private int difficult;
        public complexity()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None; // Убираем рамку и кнопки
            this.StartPosition = FormStartPosition.Manual; // Устанавливаем ручное позиционирование
            this.StartPosition = FormStartPosition.CenterScreen; // Центрируем форму на экране
        }



       

        private void SaveCompletixy_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) difficult = 1;
            else if (radioButton2.Checked) difficult = 2;
            else if (radioButton3.Checked) difficult = 3;
            else if (radioButton4.Checked) difficult = 4;

            Form1 menu = new Form1(difficult);
            this.Hide();
            menu.ShowDialog();
        }
    }
}
