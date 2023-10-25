namespace Лабораторная_работа__6_v2
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
            OneDimCreateButton = new Button();
            MainWindow = new TextBox();
            OneDimEditButton = new Button();
            OneDimRandomButton = new Button();
            OneDimPrintButton = new Button();
            SortButton = new Button();
            label1 = new Label();
            label2 = new Label();
            StringEnterButton = new Button();
            StringPrintButton = new Button();
            ReverseStringButton = new Button();
            SuspendLayout();
            // 
            // OneDimCreateButton
            // 
            OneDimCreateButton.Location = new Point(497, 64);
            OneDimCreateButton.Name = "OneDimCreateButton";
            OneDimCreateButton.Size = new Size(97, 23);
            OneDimCreateButton.TabIndex = 0;
            OneDimCreateButton.Text = "Создать";
            OneDimCreateButton.UseVisualStyleBackColor = true;
            OneDimCreateButton.Click += OneDimCreateButton_Click;
            // 
            // MainWindow
            // 
            MainWindow.Location = new Point(12, 12);
            MainWindow.Multiline = true;
            MainWindow.Name = "MainWindow";
            MainWindow.ReadOnly = true;
            MainWindow.ScrollBars = ScrollBars.Both;
            MainWindow.Size = new Size(449, 426);
            MainWindow.TabIndex = 1;
            // 
            // OneDimEditButton
            // 
            OneDimEditButton.Location = new Point(497, 93);
            OneDimEditButton.Name = "OneDimEditButton";
            OneDimEditButton.Size = new Size(97, 23);
            OneDimEditButton.TabIndex = 2;
            OneDimEditButton.Text = "Редактировать";
            OneDimEditButton.UseVisualStyleBackColor = true;
            OneDimEditButton.Click += OneDimEditButton_Click;
            // 
            // OneDimRandomButton
            // 
            OneDimRandomButton.Location = new Point(497, 122);
            OneDimRandomButton.Name = "OneDimRandomButton";
            OneDimRandomButton.Size = new Size(97, 23);
            OneDimRandomButton.TabIndex = 3;
            OneDimRandomButton.Text = "Рандом";
            OneDimRandomButton.UseVisualStyleBackColor = true;
            OneDimRandomButton.Click += OneDimRandomButton_Click;
            // 
            // OneDimPrintButton
            // 
            OneDimPrintButton.Location = new Point(497, 151);
            OneDimPrintButton.Name = "OneDimPrintButton";
            OneDimPrintButton.Size = new Size(97, 23);
            OneDimPrintButton.TabIndex = 4;
            OneDimPrintButton.Text = "Печать";
            OneDimPrintButton.UseVisualStyleBackColor = true;
            OneDimPrintButton.Click += OneDimPrintButton_Click;
            // 
            // SortButton
            // 
            SortButton.Location = new Point(497, 180);
            SortButton.Name = "SortButton";
            SortButton.Size = new Size(97, 23);
            SortButton.TabIndex = 5;
            SortButton.Text = "Сорт";
            SortButton.UseVisualStyleBackColor = true;
            SortButton.Click += SortButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(515, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Задача 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(710, 15);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 7;
            label2.Text = "Задача 2";
            // 
            // StringEnterButton
            // 
            StringEnterButton.Location = new Point(689, 64);
            StringEnterButton.Name = "StringEnterButton";
            StringEnterButton.Size = new Size(99, 23);
            StringEnterButton.TabIndex = 8;
            StringEnterButton.Text = "Ввести строку";
            StringEnterButton.UseVisualStyleBackColor = true;
            StringEnterButton.Click += StringEnterButton_Click;
            // 
            // StringPrintButton
            // 
            StringPrintButton.Location = new Point(689, 93);
            StringPrintButton.Name = "StringPrintButton";
            StringPrintButton.Size = new Size(99, 23);
            StringPrintButton.TabIndex = 9;
            StringPrintButton.Text = "Печать";
            StringPrintButton.UseVisualStyleBackColor = true;
            StringPrintButton.Click += StringPrintButton_Click;
            // 
            // ReverseStringButton
            // 
            ReverseStringButton.Location = new Point(689, 122);
            ReverseStringButton.Name = "ReverseStringButton";
            ReverseStringButton.Size = new Size(99, 23);
            ReverseStringButton.TabIndex = 10;
            ReverseStringButton.Text = "Переворот";
            ReverseStringButton.UseVisualStyleBackColor = true;
            ReverseStringButton.Click += ReverseStringButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ReverseStringButton);
            Controls.Add(StringPrintButton);
            Controls.Add(StringEnterButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SortButton);
            Controls.Add(OneDimPrintButton);
            Controls.Add(OneDimRandomButton);
            Controls.Add(OneDimEditButton);
            Controls.Add(MainWindow);
            Controls.Add(OneDimCreateButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OneDimCreateButton;
        private TextBox MainWindow;
        private Button OneDimEditButton;
        private Button OneDimRandomButton;
        private Button OneDimPrintButton;
        private Button SortButton;
        private Label label1;
        private Label label2;
        private Button StringEnterButton;
        private Button StringPrintButton;
        private Button ReverseStringButton;
    }
}