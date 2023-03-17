using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelecionar_Click(object sender, EventArgs e)
        {
            txtBoxDataInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            txtBoxCaixaFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            txtBoxCaixaAtual.Text = monthCalendar1.TodayDate.ToShortDateString(); 
            //ele irá selecionar o componente a seleção de começo e trnasformar em STRING um formato de DATA
        }
    }
}
