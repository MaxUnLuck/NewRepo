namespace WinFormsAppSulemanov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c; // обьявление переменных
                if (textBoxA.Text == string.Empty || textBoxB.Text == string.Empty || textBoxC.Text == string.Empty)
                {
                    MessageBox.Show("В одном из полей ввода пусто", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                a = Convert.ToDouble(textBoxA.Text);
                b = Convert.ToDouble(textBoxB.Text);
                c = Convert.ToDouble(textBoxC.Text);
                double v1 = Math.Pow(10, 3); // возведение переменных в степень
                double v2 = Math.Pow(a, 4);
                double v3 = Math.Pow(b, 0.5);
                double v4 = Math.Pow(c, -3);
                double v5 = Math.Log10(v1 * v2 * v3 * v4); // перемножение всех 4 действий и потом считается lg
                double v6 = 0.4 * Math.Pow(a, -2) * b; // вторая половина уравнения
                double v7 = v5 + v6; // складывание половин уравнения
                textBoxY.Text = Convert.ToString(Math.Round(v7, 5));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxStart_Click(object sender, EventArgs e)
        {
            try
            {
                double a, b, c; // обьявление переменных
                if (textBoxA.Text == string.Empty || textBoxB.Text == string.Empty || textBoxC.Text == string.Empty)
                {
                    MessageBox.Show("В одном из полей ввода пусто", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                a = Convert.ToInt32(textBoxA.Text);
                b = Convert.ToInt32(textBoxB.Text);
                c = Convert.ToInt32(textBoxC.Text);
                double v1 = Math.Pow(10, 3); // возведение переменных в степень
                double v2 = Math.Pow(a, 4);
                double v3 = Math.Pow(b, 0.5);
                double v4 = Math.Pow(c, -3);
                double v5 = Math.Log10(v1 * v2 * v3 * v4); // перемножение всех 4 действий и потом считается lg
                double v6 = 0.4 * Math.Pow(a, -2) * b; // вторая половина уравнения
                double v7 = v5 + v6; // складывание половин уравнения
                textBoxY.Text = Convert.ToString(Math.Round(v7, 5));
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
        }

        private void toolStripMenuItemClear_Click(object sender, EventArgs e)
        {
            textBoxA.Text = string.Empty;
            textBoxB.Text = string.Empty;
            textBoxC.Text = string.Empty;
            textBoxY.Text = string.Empty;
        }

        private void toolStripMenuItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripTextBoxAboutProgram_Click(object sender, EventArgs e)
        {
            Form2 newF = new Form2();
            newF.Show();
        }

        private void textBoxA_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxB, "Введите тут 'a'");
        }

        private void textBoxB_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxB, "Введите тут 'b'");
        }

        private void textBoxC_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxB, "Введите тут 'c'");
        }

        private void textBoxY_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxB, "Вывод ответа'");
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
