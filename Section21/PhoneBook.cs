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
    public partial class PhoneBook : Form
    {
        public PhoneBook()
        {
            InitializeComponent();
        }

        private void Phone_book_tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.phone_book_tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.my_dict);
        }

        private void PhoneBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_dict.phone_book_table' table. You can move, or remove it, as needed.
            try
            {
                this.phone_book_tableTableAdapter.Fill(this.my_dict.phone_book_table);
                this.toDateTimePicker.Value = DateTime.Now;
                this.fromDateTimePicker.Value = DateTime.Now;
                this.phone_book_tableBindingSource.Filter = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            DateTime from, to;

            if (this.fromDateTimePicker.Value <= this.toDateTimePicker.Value)
            {
                from = this.fromDateTimePicker.Value;
                to = this.toDateTimePicker.Value;
            }
            else
            {
                from = this.toDateTimePicker.Value;
                to = this.fromDateTimePicker.Value;
            }
            this.phone_book_tableBindingSource.Filter =
                $"birth_date >= '{from}'  AND birth_date <= '{to}'";
        }

        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
