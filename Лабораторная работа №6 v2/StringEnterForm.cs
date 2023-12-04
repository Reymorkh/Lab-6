using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Лабораторная_работа__5.BusinessLogic;

namespace Лабораторная_работа__6_v2
{
  public partial class StringEnterForm : Form
  {
    public StringEnterForm()
    {
      InitializeComponent();
    }

    private void StringInputTextBox_Enter(object sender, EventArgs e)
    {
      StringInputTextBox.Text = string.Empty;
      StringInputTextBox.ForeColor = Color.Black;
    }

    private void StringInputTextBox_KeyDown(object sender, KeyEventArgs e)
    {
      var textBox = sender as TextBox;
      if (e.KeyCode == Keys.Enter)
      {
        ConfirmationButton_Click(sender, e);
      }
    }

    private void ConfirmationButton_Click(object sender, EventArgs e)
    {
      task2String = StringInputTextBox.Text;
      if (Task2StringCorrect)
      {
        this.Dispose();
        this.Close();
      }
      else
      {
        task2String = string.Empty;
        MessageBox.Show("Введите хотя бы одно предлоежение. Оно должно заканчиваться соответствующим знаком пунктуации.", "Ошибка");
      }
    }
  }
}
