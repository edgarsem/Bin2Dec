using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bin2Dec
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
            convertButton.Enabled = true;
            warningLabelTooLong.Hide();
            warningLabelWrongFormat.Hide();
            warningLabelWrongLengthAndFormat.Hide();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String textBox = textBox1.Text;
            if(!isBinary(textBox) || textBox.Length > 8)
            {
                convertButton.Enabled = false;
                if (!isBinary(textBox) && !(textBox.Length > 8))
                {
                    warningLabelTooLong.Hide();
                    warningLabelWrongLengthAndFormat.Hide();
                    warningLabelWrongFormat.Show();
                }
                else if (isBinary(textBox) && textBox.Length > 8)
                {
                    warningLabelWrongFormat.Hide();
                    warningLabelWrongLengthAndFormat.Hide();
                    warningLabelTooLong.Show();
                }
                else if (!isBinary(textBox) && textBox.Length > 8)
                {
                    warningLabelTooLong.Hide();
                    warningLabelWrongFormat.Hide();
                    warningLabelWrongLengthAndFormat.Show();
                }
            }
            else
            {
                warningLabelTooLong.Hide();
                warningLabelWrongFormat.Hide();
                warningLabelWrongLengthAndFormat.Hide();
                convertButton.Enabled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            resultLabel.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private bool isBinary(String text)
        {
            for (int i = 0; i < text.Length; i++)
                if (text[i] != '0' && text[i] != '1')
                    return false;
            return true;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            String textBox = textBox1.Text;
            resultLabel.Text = Bin2DecConvert.bin2DecConvert(textBox);
        }
    }
}
