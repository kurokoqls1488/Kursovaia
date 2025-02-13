namespace Kursovaia
{
    partial class complexity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(complexity));
            panel1 = new Panel();
            panel2 = new Panel();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            SaveCompletixy = new Button();
            labelComplexity = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(labelComplexity);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 450);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(radioButton4);
            panel2.Controls.Add(radioButton3);
            panel2.Controls.Add(radioButton2);
            panel2.Controls.Add(radioButton1);
            panel2.Controls.Add(SaveCompletixy);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 372);
            panel2.TabIndex = 4;
            // 
            // radioButton4
            // 
            radioButton4.BackColor = Color.Transparent;
            radioButton4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton4.ForeColor = Color.White;
            radioButton4.Location = new Point(36, 195);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(266, 58);
            radioButton4.TabIndex = 7;
            radioButton4.Text = "Невозможно";
            radioButton4.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton3.ForeColor = Color.White;
            radioButton3.Location = new Point(36, 131);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(266, 58);
            radioButton3.TabIndex = 6;
            radioButton3.Text = "Сложно";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.BackColor = Color.Transparent;
            radioButton2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(36, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(266, 58);
            radioButton2.TabIndex = 5;
            radioButton2.Text = "Нормально";
            radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Checked = true;
            radioButton1.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(36, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(266, 58);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Легко";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // SaveCompletixy
            // 
            SaveCompletixy.BackColor = Color.Transparent;
            SaveCompletixy.BackgroundImage = (Image)resources.GetObject("SaveCompletixy.BackgroundImage");
            SaveCompletixy.BackgroundImageLayout = ImageLayout.Stretch;
            SaveCompletixy.Cursor = Cursors.Hand;
            SaveCompletixy.FlatAppearance.BorderSize = 0;
            SaveCompletixy.FlatStyle = FlatStyle.Flat;
            SaveCompletixy.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SaveCompletixy.ForeColor = Color.White;
            SaveCompletixy.Location = new Point(36, 271);
            SaveCompletixy.Name = "SaveCompletixy";
            SaveCompletixy.Size = new Size(266, 73);
            SaveCompletixy.TabIndex = 3;
            SaveCompletixy.Text = "Сохранить";
            SaveCompletixy.UseVisualStyleBackColor = false;
            SaveCompletixy.Click += SaveCompletixy_Click;
            SaveCompletixy.MouseEnter += SaveCompletixy_MouseEnter;
            SaveCompletixy.MouseLeave += SaveCompletixy_MouseLeave;
            // 
            // labelComplexity
            // 
            labelComplexity.BackColor = Color.FromArgb(250, 209, 207);
            labelComplexity.Dock = DockStyle.Top;
            labelComplexity.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelComplexity.ForeColor = Color.Maroon;
            labelComplexity.Location = new Point(0, 0);
            labelComplexity.Name = "labelComplexity";
            labelComplexity.Size = new Size(339, 78);
            labelComplexity.TabIndex = 3;
            labelComplexity.Text = "Сложность:";
            labelComplexity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // complexity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Fon2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(339, 450);
            Controls.Add(panel1);
            DoubleBuffered = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "complexity";
            Text = "complexity";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelComplexity;
        private Panel panel2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button SaveCompletixy;
        private RadioButton radioButton4;
    }
}