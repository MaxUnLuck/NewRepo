using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_номер_2_Сулейманов
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            ProgramGeneric newPG = new ProgramGeneric(Text1.Text);
            Text2.Text = newPG.GetNewList();
        }
    }
}
