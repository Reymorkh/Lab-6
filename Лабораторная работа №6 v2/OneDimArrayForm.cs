using System;
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
using MyLibWF;

namespace Лабораторная_работа__6_v2
{
  public partial class OneDimArrayForm : Form
  {
    public static bool isInitialized = false;
    public static int[] arrayOne;
    public static List<TextBox> textBoxes = ActionsWF.textBoxes;
    public static List<Label> labels = ActionsWF.labels;

    public OneDimArrayForm()
    {
      InitializeComponent();
      if (MainMenu.isEdit1 == true)
      {
        button1.Visible = false;
        textBox1.Visible = false;
        label1.Visible = false;
        button2.Visible = true;
        Printer();
      }
    }

    public void Printer()
    {
      ActionsWF.Print(arrayOne);
      foreach (var s in textBoxes)
        Controls.Add(s);
      foreach (var s in labels)
        Controls.Add(s);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      int temp;
      if (int.TryParse(textBox1.Text, out temp) && temp > 0)
      {
        arrayOne = new int[temp];
        MainMenu.arrayMainOne = arrayOne;
        isInitialized = true;
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
        ActionsWF.BoxesToArray(arrayOne);
        isInitialized = true;
        this.Close();
      }
      else
      {
        DialogResult dialogResult = MessageBox.Show("Вы хотите записать введённые параметры в элементы массива? Значения не типа integer будут записаны как нули.", "Предупреждение", MessageBoxButtons.YesNo);
        if (dialogResult == DialogResult.Yes)
        {
          ActionsWF.BoxesToArray(arrayOne);
          isInitialized = true;
          this.Close();
        }
      }
    }
  }
}
