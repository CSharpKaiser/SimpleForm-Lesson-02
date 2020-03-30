using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleForm.Model;

namespace SimpleForm
{
    public partial class Form1 : Form
    {
        Person person;
        public Form1()
        {
            InitializeComponent();
            person = new Person();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            
            person.Title = tbTitle.Text;
            person.Forename = tbForename.Text;
            person.Surname = tbSurname.Text;

            MessageBox.Show(person.ToString());
        }
    }
}
