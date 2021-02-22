using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Person> person = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            Person personTemp = new Person();
            personTemp.DPI1 = textBox1.Text;
            personTemp.Name1 = textBox2.Text;
            personTemp.LastName = textBox3.Text;
            personTemp.DateBirthday = monthCalendar1.SelectionStart;

            person.Add(personTemp);
        }

        private void showData()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = person;
            dataGridView1.Refresh();
        }
        private void botonMostrar_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            string ID = textBox4.Text;
            person.RemoveAll(p => p.DPI1 == ID);
            showData();
        }

        private void botonOrdenar_Click(object sender, EventArgs e)
        {
            person = person.OrderBy(p => p.LastName).ToList();
            showData();
        }

        private void botonDesendente_Click(object sender, EventArgs e)
        {
            person = person.OrderByDescending(p => p.LastName).ToList();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            FileStream file = new FileStream("personas.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter write = new StreamWriter(file);
            foreach (var x in person)
            {
                write.WriteLine(x.DPI1);
                write.WriteLine(x.Name1);
                write.WriteLine(x.LastName);
                write.WriteLine(x.DateBirthday);
            }
            write.Close();
        }
    }
}
