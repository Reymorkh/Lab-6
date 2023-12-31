﻿using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace MyLibStructWF
{
  public static class ArrayTypes
  {
    const double fromTop = 30, fromLeft = 60;
    static Size size = new Size(40, 20);
    public static List<TextBox> textBoxes = new List<TextBox>();
    public static List<Label> labels = new List<Label>();

    public class OneDim
    {
      public int[] array;

      public OneDim(int length)
      {
        array = new int[length];

      }

      #region interface
      public string Show
      {
        get
        {
          if (Length != 0)
          {
            string Text = "Одномерный массив:";
            string[] text = new string[array.Length / 10 + 2];
            int textIndex = 1;
            for (int temp = 0; temp < array.Length; temp += 10)
            {
              text[textIndex] = LineConverter(temp, text[textIndex]);
              textIndex++;
            }
            Text += string.Join(Environment.NewLine, text);
            return Text;
          }
          else
            return "Одномерный массив пуст.";
        }
      }

      private string LineConverter(int temp, string line)
      {
        for (int i = temp; i < temp + 10 && i < array.Length; i++)
          line += Convert.ToString(array[i]) + ' ';
        line = line.Trim();
        return line;
      } //Функция для верхней функции
      #endregion

      public int Length
      {
        get { return array.Length; }
      }
    }

    public static void AddBox(double posx, double posy)
    {
      TextBox newTextBox = new TextBox();
      newTextBox.Location = new Point(40 + Convert.ToInt32(Math.Round(fromLeft * posx, 0)), 60 + Convert.ToInt32(Math.Round(fromTop * posy, 0)));
      newTextBox.Size = size;
      newTextBox.MaxLength = 5;
      newTextBox.TextAlign = HorizontalAlignment.Center;
      textBoxes.Add(newTextBox);
    }

    public static void AddLabel(double posx, double posy, int number)
    {
      Label newLabel = new Label();
      newLabel.Location = new Point(40 + Convert.ToInt32(Math.Round(fromLeft * posx, 0)), 60 + Convert.ToInt32(Math.Round(fromTop * posy, 0)));
      newLabel.Text = Convert.ToString(number);
      newLabel.TextAlign = ContentAlignment.MiddleCenter;
      newLabel.AutoSize = true;
      labels.Add(newLabel);
    }
  }
}