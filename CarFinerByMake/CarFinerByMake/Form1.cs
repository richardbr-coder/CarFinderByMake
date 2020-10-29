using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarFinerByMake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honestRalphsUsedCarsDataSet.tblCars' table. You can move, or remove it, as needed.
            this.tblCarsTableAdapter.Fill(this.honestRalphsUsedCarsDataSet.tblCars);

        }

        private void ford_Click(object sender, EventArgs e)
        {
            //only showing ford vehicles in the table
            var ford =
               from c in this.honestRalphsUsedCarsDataSet.tblCars
               where c.Make == "Ford"
               select c;

            dataGridView1.DataSource = ford.ToList();

            label1.Text = "*Only 'ford' Vehicle's are being shown!";
        }

        private void chev_Click(object sender, EventArgs e)
        {
            //only showing ford vehicles in the table
            var chev =
               from c in this.honestRalphsUsedCarsDataSet.tblCars
               where c.Make == "Chevrolet"
               select c;

            dataGridView1.DataSource = chev.ToList();

            label1.Text = "*Only 'Chevrolet' Vehicle's are being shown!";
        }

        private void cad_Click(object sender, EventArgs e)
        {
            //only showing ford vehicles in the table
            var ford =
               from c in this.honestRalphsUsedCarsDataSet.tblCars
               where c.Make == "Cadillac"
               select c;

            dataGridView1.DataSource = ford.ToList();

            label1.Text = "*Only 'Cadillac' Vehicle's are being shown!";
        }

        private void all_Click(object sender, EventArgs e)
        {
            //only showing ford vehicles in the table
            var ford =
               from c in this.honestRalphsUsedCarsDataSet.tblCars
               select c;

            dataGridView1.DataSource = ford.ToList();

            label1.Text = "*'ALL' vehicles are showing!";
        }
    }
}
