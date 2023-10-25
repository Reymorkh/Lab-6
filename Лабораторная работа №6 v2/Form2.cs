﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Label = System.Windows.Forms.Label;
using TextBox = System.Windows.Forms.TextBox;

namespace Лабораторная_работа__6_v2
{
    public partial class Form2 : Form
    {
        public static bool isInitialized = false;
        public const double fromTop = 30, fromLeft = 60, startLeft = 40, startTop = 60;
        public static int tabindex = 8;
        public static int[] arrayOne;
        public static List<TextBox> textBoxes = new List<TextBox>();
        public static List<Label> labels = new List<Label>();

        public Form2()
        {
            InitializeComponent();
            if (Form1.isEdit1 == true)
            {
                button1.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
                button2.Visible = true;
                Printer();
                TextToBoxes();
            }
        }

        public void TextBoxPrinter(double multiplierLeft, double multiplierTop)
        {
            TextBox newTextBox = new TextBox();
            newTextBox.Location = new Point(Convert.ToInt32(Math.Round(startLeft + fromLeft * multiplierLeft, 0)), Convert.ToInt32(Math.Round(startTop + fromTop * multiplierTop, 0)));
            textBoxes.Add(newTextBox);
            newTextBox.Size = new Size(40, 20);
            newTextBox.TabIndex = tabindex;
            tabindex++;
            newTextBox.MaxLength = 5;
            newTextBox.TextAlign = HorizontalAlignment.Center;
            Controls.Add(newTextBox);
        }

        public void LabelPrinter(double multiplierLeft, double multiplierTop, int number)
        {
            Label newLabel = new Label();
            newLabel.Location = new Point(Convert.ToInt32(Math.Round(startLeft + fromLeft * multiplierLeft, 0)), Convert.ToInt32(Math.Round(startTop + fromTop * multiplierTop, 0)));
            newLabel.Text = Convert.ToString(number);
            newLabel.Size = new Size(20, 20);
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            newLabel.AutoSize = true;
            labels.Add(newLabel);
            Controls.Add(newLabel);
        }

        public void Printer()
        {
            LabelPrinter(-0.5, 0, 0 + 1);
            for (int i = 0; i < arrayOne.Length; i++)
            {
                TextBoxPrinter(i, 0);
                LabelPrinter(i, -0.8, i + 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(textBox1.Text, out temp) && temp > 0)
            {
                arrayOne = new int[temp];
                label1.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = true;
                Printer();
            }
            else
                MessageBox.Show("Integer больше нуля, пожалуйста.", "Ошибка");
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            var textBox = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isCorrect = true;
            foreach (var x in textBoxes)
            {
                int y;
                if (!int.TryParse(x.Text, out y))
                {
                    isCorrect = false;
                    break;
                }
            }

            if (isCorrect)
            {
                BoxesToArray();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Вы хотите записать введённые параметры в элементы массива? Значения не типа integer будут записаны как нули.", "Предупреждение", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                    BoxesToArray();
            }
        }

        public void BoxesToArray()
        {
            int j, boxIndex = 0, temp;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (int.TryParse(textBoxes[boxIndex].Text, out temp))
                    arrayOne[i] = temp;
                else
                    arrayOne[i] = 0;
                boxIndex++;
            }
            Form1.arrayMainOne = arrayOne;
            isInitialized = true;
            this.Close();
        }

        public void TextToBoxes()
        {
            int j, boxIndex = 0, temp;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != 0)
                    textBoxes[boxIndex].Text = Convert.ToString(arrayOne[i]);
                boxIndex++;
            }
        }
    }
}
