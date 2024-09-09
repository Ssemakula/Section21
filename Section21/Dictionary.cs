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
            this.en_word_listTableAdapter.Fill(this.my_dict.en_word_list);
        }

        private void SearchBbutton_Click(object sender, EventArgs e)
        {

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
