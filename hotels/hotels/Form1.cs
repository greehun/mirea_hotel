using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 2)
            {
                label5.Visible = false;
                comboBox2.Enabled = true;
            }
            else 
            {
                label5.Visible = true;
                comboBox2.Enabled = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                dateTimePicker1.Enabled = true;
                button1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы оставили заявку на бронирование отеля.\nВ ближайшее время вам позвонят.", "Бронирование номера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
