using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Real_Linq
{
    public partial class Form1 : Form
    {
        List<People> people = new List<People>();
        public Form1()
        {
            InitializeComponent();
        }
        int num = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            People person = new People(num,txtName.Text, txtFullName.Text);
            if (person.Name != "" && person.Fullname != "")
            {
                people.Add(person);
                num++;
                txtName.Text = null;
                txtFullName.Text = null;
            }
            dataGridView1.DataSource = people.ToList();
            
        }


        private void button2_Click(object sender, EventArgs e)
        {      
            dataGridView1.DataSource = people.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var Filter = people.Where(p=>p.Name.Contains(txtSearch.Text)||p.Fullname.Contains(txtSearch.Text)||p.Number.ToString().Contains(txtSearch.Text)).ToList();
            dataGridView1.DataSource = Filter.ToList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                people.RemoveAt(selectedIndex);
            }
            dataGridView1.DataSource = people.ToList();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var item = people.Where(p=>p.Name.Contains(txtSearch.Text)||p.Fullname.Contains(txtSearch.Text)).ToList();
            dataGridView1.DataSource = item;
        }      
    }
}
