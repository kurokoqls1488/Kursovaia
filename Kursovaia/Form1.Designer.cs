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
            Play = new Button();
            label1 = new Label();
            complexity = new Button();
            HowPlay = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // Play
            // 
            Play.Location = new Point(372, 140);
            Play.Name = "Play";
            Play.Size = new Size(266, 73);
            Play.TabIndex = 0;
            Play.Text = "Играть";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(485, 58);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 1;
            label1.Text = "Сапер";
            // 
            // complexity
            // 
            complexity.Location = new Point(372, 233);
            complexity.Name = "complexity";
            complexity.Size = new Size(266, 73);
            complexity.TabIndex = 2;
            complexity.Text = "Сложность";
            complexity.UseVisualStyleBackColor = true;
            // 
            // HowPlay
            // 
            HowPlay.Location = new Point(372, 327);
            HowPlay.Name = "HowPlay";
            HowPlay.Size = new Size(266, 73);
            HowPlay.TabIndex = 3;
            HowPlay.Text = "Как играть?";
            HowPlay.UseVisualStyleBackColor = true;
            HowPlay.Click += HowPlay_Click_1;
            // 
            // Exit
            // 
            Exit.Location = new Point(372, 422);
            Exit.Name = "Exit";
            Exit.Size = new Size(266, 73);
            Exit.TabIndex = 4;
            Exit.Text = "Выход";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1019, 611);
            Controls.Add(Exit);
            Controls.Add(HowPlay);
            Controls.Add(complexity);
            Controls.Add(label1);
            Controls.Add(Play);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Play;
        private Label label1;
        private Button complexity;
        private Button HowPlay;
        private Button Exit;
    }
}
