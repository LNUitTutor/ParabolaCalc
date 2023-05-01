using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace ParabolaCalc
{
    public partial class MainForm : Form
    {
        double a = 1.0;
        double b = 0.0;
        double c = 0.0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private double RecognizeDouble(TextBox box)
        {
            double number = 0.0;
            try
            {
                number = double.Parse(box.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Потрібно ввести дійсне число\n" + ex.Message,
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.Focus();
                box.SelectAll();
            }
            return number;
        }
        private void tb_A_Validating(object sender, CancelEventArgs e)
        {
            TextBox box = sender as TextBox;
            try
            {
                a = double.Parse(box.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                MessageBox.Show("Потрібно ввести дійсне число\n" + ex.Message,
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.SelectAll();
            }
            if (a == 0.0)
            {
                e.Cancel = true;
                MessageBox.Show("Старший коефіцієнт повинен бути відмінним від нуля\n",
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                box.SelectAll();
            }
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            btn_Calc.Focus();
            StringBuilder builder = new StringBuilder(100);
            if (a == 1.0) builder.Append("y = x²");
            else builder.AppendFormat("y = {0}x²", a);
            if (b > 0) builder.AppendFormat(" +{0}x", b);
            else if (b < 0) builder.AppendFormat(" {0}x", b);
            if (c > 0) builder.AppendFormat(" +{0}", c);
            else if (c < 0) builder.AppendFormat(" {0}", c);
            tb_Result.Text = builder.ToString();
        }

        private void tb_B_Leave(object sender, EventArgs e)
        {
            b = RecognizeDouble(sender as TextBox);
        }

        private void tb_C_Leave(object sender, EventArgs e)
        {
            c = RecognizeDouble(sender as TextBox);
        }

        private void cb_Value_CheckedChanged(object sender, EventArgs e)
        {
            tb_X.Visible = (sender as CheckBox).Checked;
            if (tb_X.Visible) tb_X.Focus();
        }
    }
}
