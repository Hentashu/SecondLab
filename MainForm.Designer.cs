namespace WinFormsApp1
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(307, 36);
            label1.TabIndex = 0;
            label1.Text = "Sports team \"Rucheek\"";
            // 
            // button1
            // 
            button1.Location = new Point(300, 270);
            button1.Name = "button1";
            button1.Size = new Size(210, 40);
            button1.TabIndex = 1;
            button1.Text = "Events Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonEventsInfo_Click;
            // 
            // button2
            // 
            button2.Location = new Point(300, 155);
            button2.Name = "button2";
            button2.Size = new Size(210, 40);
            button2.TabIndex = 2;
            button2.Text = "Registration team members to events";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonRegistr_Click;
            // 
            // button3
            // 
            button3.Location = new Point(300, 210);
            button3.Name = "button3";
            button3.Size = new Size(210, 40);
            button3.TabIndex = 3;
            button3.Text = "Remove team members from events";
            button3.UseVisualStyleBackColor = true;
            button3.Click += buttonRemover_Click;
            // 
            // button4
            // 
            button4.Location = new Point(300, 100);
            button4.Name = "button4";
            button4.Size = new Size(210, 40);
            button4.TabIndex = 4;
            button4.Text = "Add event";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buttonAdd_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button5.Location = new Point(12, 345);
            button5.Name = "button5";
            button5.Size = new Size(87, 35);
            button5.TabIndex = 5;
            button5.Text = "Exit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 391);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ладыгин Николай Б24-181-1 Вариант 8";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}
