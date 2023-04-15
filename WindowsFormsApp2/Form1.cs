using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] array = new int[2, 3] { { 1, 2, 23 }, { 3, 4, 15 } };
            Class_2 obj_class2 = new Class_2();
            Class_1 gamodzaxeba;
            gamodzaxeba = obj_class2.Metodi_1(array);

            label1.Text = gamodzaxeba.jami.ToString();
        }
    }
}
