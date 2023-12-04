namespace Лабораторная_работа__6_v2
{
    partial class StringEnterForm
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
            ConfirmationButton = new Button();
            StringInputTextBox = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            ConfirmationButton.Location = new Point(385, 93);
            ConfirmationButton.Name = "button1";
            ConfirmationButton.Size = new Size(75, 40);
            ConfirmationButton.TabIndex = 0;
            ConfirmationButton.Text = "Ввод";
            ConfirmationButton.UseVisualStyleBackColor = true;
            ConfirmationButton.Click += ConfirmationButton_Click;
            // 
            // textBox1
            // 
            StringInputTextBox.ForeColor = Color.Gray;
            StringInputTextBox.Location = new Point(12, 12);
            StringInputTextBox.Multiline = true;
            StringInputTextBox.Name = "textBox1";
            StringInputTextBox.ScrollBars = ScrollBars.Vertical;
            StringInputTextBox.Size = new Size(367, 122);
            StringInputTextBox.TabIndex = 1;
            StringInputTextBox.Text = "Введите строку";
            StringInputTextBox.Enter += StringInputTextBox_Enter;
            StringInputTextBox.KeyDown += StringInputTextBox_KeyDown;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 145);
            Controls.Add(StringInputTextBox);
            Controls.Add(ConfirmationButton);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Задача 2. Текст.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConfirmationButton;
        private TextBox StringInputTextBox;
    }
}