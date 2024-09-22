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
    public partial class Dictionary : Form
    {
        public Dictionary()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_dict.en_word_list' table. You can move, or remove it, as needed.
            try
            {
                this.en_word_listTableAdapter.Fill(this.my_dict.en_word_list);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void SearchBbutton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.searchTextBox.Text))
            {
                this.en_word_listBindingSource.Filter = null;
                return;
            }
            try
            {
                switch(this.searchComboBox.SelectedItem)
                {
                    case "Equals":
                        //this.en_word_listTableAdapter.Fill_like(this.my_dict.en_word_list, this.searchTextBox.Text);
                        this.en_word_listBindingSource.Filter = $"word = '{this.searchTextBox.Text}'";
                        break;
                    case "Contains":
                        //this.en_word_listTableAdapter.Fill_like(this.my_dict.en_word_list, "%" + this.searchTextBox.Text + "%");
                        this.en_word_listBindingSource.Filter = $"word like '%{this.searchTextBox.Text}%'";
                        break;
                    case "Starts with":
                        //this.en_word_listTableAdapter.Fill_like(this.my_dict.en_word_list, this.searchTextBox.Text + "%");
                        this.en_word_listBindingSource.Filter = $"word like '{this.searchTextBox.Text}%'";
                        break;
                    case "Ends with":
                        //this.en_word_listTableAdapter.Fill_like(this.my_dict.en_word_list, "%" + this.searchTextBox.Text);
                        this.en_word_listBindingSource.Filter = $"word like '%{this.searchTextBox.Text}'";
                        break;
                    default:
                        this.en_word_listBindingSource.Filter = "word = '" + this.searchTextBox.Text + "'";
                        break;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void En_word_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.en_word_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.my_dict);

        }

        private void PleaseWait(bool wait = true)
        {
            if (wait) { }
            else { }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
