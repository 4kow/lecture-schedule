using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plan_zajęć
{
    public partial class Form1 : Form
    {
        public System.Windows.Forms.HorizontalAlignment TextAlign { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "Adam:" + Environment.NewLine + Environment.NewLine + "Stacjonarne Zajęcia na poniedziałek (08:15 - 11:30):" + Environment.NewLine + Environment.NewLine + "08:15 - 11:30 Systemy wbudowane (L) dr. Rabczuk" + Environment.NewLine + Environment.NewLine + "Zajęcia odbędą się 10.05, 24.05, 07.06, 14.06";

            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = "Julia:" + Environment.NewLine + Environment.NewLine + "Zajęcia na poniedziałek (10:15 - 14:45):"
                + Environment.NewLine + Environment.NewLine + "10:15 - 12:00 Marketing towarów i usług (W)" + Environment.NewLine + Environment.NewLine + "Okienko" + Environment.NewLine + Environment.NewLine +
                "13:00 - 14:45 Podstawy procesów technologicznych (W)";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "Adam:" + Environment.NewLine + Environment.NewLine + "Zajęcia na wtorek (07:20 - 18:45) co2td (09:15 - 18:45)" + Environment.NewLine + Environment.NewLine + "07:20 - 08:50 Metody optymalizacji (L) dr.Miller - Co drugi tydzień"
                + Environment.NewLine + Environment.NewLine + "09:00 - 10:30 Metody i narzędzia sztucznej inteligencji (L) dr.Skakovski" + Environment.NewLine + Environment.NewLine + 
                "11:00 - 12:30 Grafika komputerowa i techniki multimedialne (L) mgr.Milewski" + Environment.NewLine + Environment.NewLine + "13:15 - 14:45 Wprowadzenie do baz danych (L) dr.Łuksza" 
                + Environment.NewLine + Environment.NewLine + "15:15 - 16:45 Sieci komputerowe (L) mgr.Mieczyńska" + Environment.NewLine + Environment.NewLine + "17:15 - 18:45 Grafika komputerowa i techniki multimedialne (W) mgr.Milewski";

            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = "Julia:" + Environment.NewLine + Environment.NewLine + "Stacjonarne zajęcia na wtorek (15:15 - 16:45)" + Environment.NewLine + Environment.NewLine +
                "15:15 - 16:45 Analiza instrumentalna (L)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "Adam:" + Environment.NewLine + Environment.NewLine + "Zajęcia na środę (11:15 - 16:35):" + Environment.NewLine + Environment.NewLine + "11:15 - 12:45 Wprowadzenie do baz danych (W) mgr.Rosicka"
                + Environment.NewLine + Environment.NewLine + "13:15 - 14:45 Teoria informacji (W) prof.Borys" + Environment.NewLine + Environment.NewLine + "15:00 - 16:35 j.Angielski mgr.Korta";

            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = "Julia:" + Environment.NewLine + Environment.NewLine + "Zajęcia na środę (08:00 - 11:45)" + Environment.NewLine + Environment.NewLine + "08:00 - 09:30 Zarządzanie produktem (W)" + Environment.NewLine + Environment.NewLine +
                "10:15 - 11:45 Zarządzanie produktem (ĆW)";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "Adam:" + Environment.NewLine + Environment.NewLine + "Zajęcia na czwartek (09:15 - 11:45):" + Environment.NewLine + Environment.NewLine + "09:15 - 10:45 Teoria informacji (Ć) prof.Borys" + Environment.NewLine + Environment.NewLine +
                "11:15 - 12:45 Sieci komputerowe (W) dr.Januszewski";

            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = "Julia:" + Environment.NewLine + Environment.NewLine + "Zajęcia na czwartek (09:15 - 17:30):" + Environment.NewLine + Environment.NewLine +
                "09:15 - 11:00 j.Angielski" + Environment.NewLine + Environment.NewLine + "11:15 - 12:45 Analiza instrumentalna (W)" + Environment.NewLine + Environment.NewLine + "13:15 - 15:00 Zdrowie publiczne (W)" + Environment.NewLine + Environment.NewLine + "15:15 - 17:30 Środowisko a zdrowie człowieka (W)";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = "Adam:" + Environment.NewLine + Environment.NewLine + "Stacjonarne Zajęcia na piątek (08:15 - 11:30):" + Environment.NewLine + Environment.NewLine + "08:15 - 11:30 Systemy wbudowane dr. Rabczuk" + Environment.NewLine + Environment.NewLine + "Zajęcia odbędą się 30.04, 14.05";

            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.Text = "Julia:" + Environment.NewLine + Environment.NewLine + "Zajęcia na piątek (09:15 - 10:45)" + Environment.NewLine + Environment.NewLine + "09:15 - 10:45 Marketing towarów i usług (ĆW)";
        }
    }
}
