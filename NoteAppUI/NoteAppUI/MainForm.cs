using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ColorComboBox.Items.Add(Color.Red);
            ColorComboBox.Items.Add(Color.Green);
            ColorComboBox.Items.Add(Color.Blue);
            ColorComboBox.Items.Add(Color.White);
            ColorComboBox.SelectedIndex = 1;
        }
       
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = NumberTextBox.Text;
            int number;
            if (int.TryParse(text, out number))
            {
                if (number >= 0 && number <= 100)
                {
                    NumberTextBox.BackColor = Color.White;
                    this.Text = number.ToString();
                }
                else
                {
                    NumberTextBox.BackColor = Color.LightSalmon;
                }
            }
            else
            {
                NumberTextBox.BackColor = Color.LightSalmon;
            }
        }

        private void ColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColorComboBox.SelectedIndex == -1)
            {
                // Если ничего не выбрано, завершаем обработчик
                return;
            }
            Color selectedColor;
            selectedColor = (Color)ColorComboBox.SelectedItem;
            this.BackColor = selectedColor;
        }

        private void VisibilityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = VisibilityCheckBox.Checked;
            ColorComboBox.Visible = isChecked;
        }
    }
}
