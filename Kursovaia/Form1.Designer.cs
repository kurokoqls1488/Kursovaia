namespace Kursovaia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Play = new Button();
            label1 = new Label();
            complexity = new Button();
            HowPlay = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Play
            // 
            Play.BackColor = Color.Transparent;
            Play.BackgroundImage = (Image)resources.GetObject("Play.BackgroundImage");
            Play.BackgroundImageLayout = ImageLayout.Stretch;
            Play.Cursor = Cursors.Hand;
            Play.FlatAppearance.BorderSize = 0;
            Play.FlatStyle = FlatStyle.Flat;
            Play.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Play.ForeColor = Color.FromArgb(247, 227, 226);
            Play.Location = new Point(364, 106);
            Play.Name = "Play";
            Play.Size = new Size(296, 90);
            Play.TabIndex = 0;
            Play.Text = "Играть";
            Play.UseVisualStyleBackColor = false;
            Play.Click += Play_Click;
            Play.MouseEnter += Play_MouseEnter;
            Play.MouseLeave += Play_MouseLeave;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(364, 1);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(296, 102);
            label1.TabIndex = 1;
            label1.Text = "Сапер";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // complexity
            // 
            complexity.BackColor = Color.Transparent;
            complexity.BackgroundImage = Properties.Resources.buttonFon2;
            complexity.BackgroundImageLayout = ImageLayout.Stretch;
            complexity.Cursor = Cursors.Hand;
            complexity.FlatAppearance.BorderSize = 0;
            complexity.FlatStyle = FlatStyle.Flat;
            complexity.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            complexity.ForeColor = Color.FromArgb(247, 227, 226);
            complexity.Location = new Point(364, 218);
            complexity.Name = "complexity";
            complexity.Size = new Size(296, 90);
            complexity.TabIndex = 2;
            complexity.Text = "Сложность";
            complexity.UseVisualStyleBackColor = false;
            complexity.Click += complexity_Click;
            complexity.MouseEnter += Play_MouseEnter;
            complexity.MouseLeave += Play_MouseLeave;
            // 
            // HowPlay
            // 
            HowPlay.BackColor = Color.Transparent;
            HowPlay.BackgroundImage = Properties.Resources.buttonFon2;
            HowPlay.BackgroundImageLayout = ImageLayout.Stretch;
            HowPlay.Cursor = Cursors.Help;
            HowPlay.FlatAppearance.BorderSize = 0;
            HowPlay.FlatStyle = FlatStyle.Flat;
            HowPlay.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            HowPlay.ForeColor = Color.FromArgb(247, 227, 226);
            HowPlay.Location = new Point(364, 329);
            HowPlay.Name = "HowPlay";
            HowPlay.Size = new Size(296, 90);
            HowPlay.TabIndex = 3;
            HowPlay.Text = "Как играть?";
            HowPlay.UseVisualStyleBackColor = false;
            HowPlay.Click += HowPlay_Click_1;
            HowPlay.MouseEnter += Play_MouseEnter;
            HowPlay.MouseLeave += Play_MouseLeave;
            // 
            // Exit
            // 
            Exit.BackColor = Color.Transparent;
            Exit.BackgroundImage = Properties.Resources.buttonFon2;
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.Cursor = Cursors.Hand;
            Exit.FlatAppearance.BorderSize = 0;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Exit.ForeColor = Color.FromArgb(247, 227, 226);
            Exit.Location = new Point(364, 445);
            Exit.Name = "Exit";
            Exit.Size = new Size(296, 90);
            Exit.TabIndex = 4;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            Exit.MouseEnter += Play_MouseEnter;
            Exit.MouseLeave += Play_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Fon2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1019, 611);
            Controls.Add(Exit);
            Controls.Add(HowPlay);
            Controls.Add(complexity);
            Controls.Add(label1);
            Controls.Add(Play);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Play;
        private Label label1;
        private Button complexity;
        private Button HowPlay;
        private Button Exit;
    }
}
