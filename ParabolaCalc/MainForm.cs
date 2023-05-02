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
            Solver solver = new Solver(a, b, c);
            tb_Result.Text = solver.GetAppearance();
            if (cb_Calculate.Checked)
            {
                var roots = solver.CalculateRoots();
                tb_Result.Text += string.Format("\n\r x₁ = {0:F}; x₂ = {1:F}", roots.Item1, roots.Item2);
            }
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
