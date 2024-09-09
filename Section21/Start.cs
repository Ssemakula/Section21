using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section21
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DictionaryButton_Click(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if(form.GetType() == typeof(Dictionary))
                {
                    form.Activate();
                    return;
                }
            }
            Dictionary dictionary = new Dictionary();
            dictionary.Show();
        }

        private void PhoneBookButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(PhoneBook))
                {
                    form.Activate();
                    return;
                }
            }
            PhoneBook phoneBook = new PhoneBook();
            phoneBook.Show();
        }
    }
}
