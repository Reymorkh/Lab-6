namespace Лабораторная_работа__6_v2
{
  partial class OneDimArrayForm
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
      LengthEnterLabel = new Label();
      LengthEnterTextBox = new TextBox();
      LengthEnterButton = new Button();
      SuspendLayout();
      // 
      // ConfirmationButton
      // 
      ConfirmationButton.Location = new Point(12, 12);
      ConfirmationButton.Name = "ConfirmationButton";
      ConfirmationButton.Size = new Size(93, 23);
      ConfirmationButton.TabIndex = 7;
      ConfirmationButton.Text = "Утвердить";
      ConfirmationButton.UseVisualStyleBackColor = true;
      ConfirmationButton.Visible = false;
      ConfirmationButton.Click += ConfirmationButton_Click;
      // 
      // LengthEnterLabel
      // 
      LengthEnterLabel.AutoSize = true;
      LengthEnterLabel.Location = new Point(39, 20);
      LengthEnterLabel.Name = "LengthEnterLabel";
      LengthEnterLabel.Size = new Size(135, 15);
      LengthEnterLabel.TabIndex = 6;
      LengthEnterLabel.Text = "Введите длину массива";
      // 
      // LengthEnterTextBox
      // 
      LengthEnterTextBox.Location = new Point(12, 47);
      LengthEnterTextBox.Name = "LengthEnterTextBox";
      LengthEnterTextBox.Size = new Size(204, 23);
      LengthEnterTextBox.TabIndex = 5;
      LengthEnterTextBox.KeyDown += LengthEnterTextBox_KeyDown;
      // 
      // LengthEnterButton
      // 
      LengthEnterButton.Location = new Point(222, 47);
      LengthEnterButton.Name = "LengthEnterButton";
      LengthEnterButton.Size = new Size(75, 23);
      LengthEnterButton.TabIndex = 4;
      LengthEnterButton.Text = "Ввод";
      LengthEnterButton.UseVisualStyleBackColor = true;
      LengthEnterButton.Click += LengthEnterButton_Click;
      // 
      // OneDimArrayForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      AutoScroll = true;
      AutoSize = true;
      ClientSize = new Size(305, 101);
      Controls.Add(ConfirmationButton);
      Controls.Add(LengthEnterLabel);
      Controls.Add(LengthEnterTextBox);
      Controls.Add(LengthEnterButton);
      MaximumSize = new Size(600, 150);
      Name = "OneDimArrayForm";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Работа с массивом";
      FormClosing += OneDimArrayForm_FormClosing;
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Button ConfirmationButton;
    private Label LengthEnterLabel;
    private TextBox LengthEnterTextBox;
    private Button LengthEnterButton;
  }
}