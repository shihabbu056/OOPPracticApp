using OOPPracticApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPPracticApp.Screens
{
    public partial class PersonInformationForm : Form
    {
        readonly private Person person;
        public PersonInformationForm()
        {
            InitializeComponent();
            person = new Person();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            person.FirstName = textBoxFirstName.Text;
            person.MiddleName = textBoxMiddleName.Text;
            person.LastName = textBoxLastName.Text;

            textBoxFirstName.Text = "";
            textBoxMiddleName.Text = "";
            textBoxLastName.Text = "";

            textBoxFullName.Text = person.GetMyFullName();
            textBoxReverseName.Text = person.GetMyReverseName();
        }
    }
}
