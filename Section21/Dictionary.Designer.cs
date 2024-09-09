namespace Section21
{
    partial class Dictionary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dictionary));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBbutton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.my_dict = new Section21.Data.my_dict();
            this.en_word_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.en_word_listTableAdapter = new Section21.Data.my_dictTableAdapters.en_word_listTableAdapter();
            this.tableAdapterManager = new Section21.Data.my_dictTableAdapters.TableAdapterManager();
            this.en_word_listBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.en_word_listBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.en_word_listDataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordtypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.definitionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.my_dict)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_word_listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_word_listBindingNavigator)).BeginInit();
            this.en_word_listBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.en_word_listDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBbutton
            // 
            this.searchBbutton.Location = new System.Drawing.Point(334, 19);
            this.searchBbutton.Name = "searchBbutton";
            this.searchBbutton.Size = new System.Drawing.Size(75, 23);
            this.searchBbutton.TabIndex = 1;
            this.searchBbutton.Text = "Search";
            this.searchBbutton.UseVisualStyleBackColor = true;
            this.searchBbutton.Click += new System.EventHandler(this.SearchBbutton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(20, 24);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(56, 13);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search for";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(81, 20);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(119, 20);
            this.searchTextBox.TabIndex = 3;
            // 
            // my_dict
            // 
            this.my_dict.DataSetName = "my_dict";
            this.my_dict.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // en_word_listBindingSource
            // 
            this.en_word_listBindingSource.DataMember = "en_word_list";
            this.en_word_listBindingSource.DataSource = this.my_dict;
            // 
            // en_word_listTableAdapter
            // 
            this.en_word_listTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.en_word_listTableAdapter = this.en_word_listTableAdapter;
            this.tableAdapterManager.phone_book_tableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Section21.Data.my_dictTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // en_word_listBindingNavigator
            // 
            this.en_word_listBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.en_word_listBindingNavigator.BindingSource = this.en_word_listBindingSource;
            this.en_word_listBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.en_word_listBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.en_word_listBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.en_word_listBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.en_word_listBindingNavigatorSaveItem});
            this.en_word_listBindingNavigator.Location = new System.Drawing.Point(0, 425);
            this.en_word_listBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.en_word_listBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.en_word_listBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.en_word_listBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.en_word_listBindingNavigator.Name = "en_word_listBindingNavigator";
            this.en_word_listBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.en_word_listBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.en_word_listBindingNavigator.TabIndex = 4;
            this.en_word_listBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // en_word_listBindingNavigatorSaveItem
            // 
            this.en_word_listBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.en_word_listBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("en_word_listBindingNavigatorSaveItem.Image")));
            this.en_word_listBindingNavigatorSaveItem.Name = "en_word_listBindingNavigatorSaveItem";
            this.en_word_listBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.en_word_listBindingNavigatorSaveItem.Text = "Save Data";
            this.en_word_listBindingNavigatorSaveItem.Click += new System.EventHandler(this.En_word_listBindingNavigatorSaveItem_Click);
            // 
            // en_word_listDataGridView
            // 
            this.en_word_listDataGridView.AllowUserToOrderColumns = true;
            this.en_word_listDataGridView.AutoGenerateColumns = false;
            this.en_word_listDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.en_word_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.en_word_listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.wordColumn,
            this.wordtypeColumn,
            this.definitionColumn});
            this.en_word_listDataGridView.DataSource = this.en_word_listBindingSource;
            this.en_word_listDataGridView.Location = new System.Drawing.Point(20, 48);
            this.en_word_listDataGridView.Name = "en_word_listDataGridView";
            this.en_word_listDataGridView.Size = new System.Drawing.Size(768, 368);
            this.en_word_listDataGridView.TabIndex = 4;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "id";
            this.idColumn.HeaderText = "id";
            this.idColumn.Name = "idColumn";
            this.idColumn.Visible = false;
            this.idColumn.Width = 50;
            // 
            // wordColumn
            // 
            this.wordColumn.DataPropertyName = "word";
            this.wordColumn.HeaderText = "word";
            this.wordColumn.Name = "wordColumn";
            this.wordColumn.Width = 150;
            // 
            // wordtypeColumn
            // 
            this.wordtypeColumn.DataPropertyName = "wordtype";
            this.wordtypeColumn.HeaderText = "wordtype";
            this.wordtypeColumn.Name = "wordtypeColumn";
            this.wordtypeColumn.Width = 150;
            // 
            // definitionColumn
            // 
            this.definitionColumn.DataPropertyName = "definition";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.definitionColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.definitionColumn.HeaderText = "definition";
            this.definitionColumn.Name = "definitionColumn";
            this.definitionColumn.Width = 400;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(713, 19);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Equals",
            "Contains",
            "Starts with",
            "Ends with"});
            this.comboBox1.Location = new System.Drawing.Point(207, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // Dictionary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.en_word_listDataGridView);
            this.Controls.Add(this.en_word_listBindingNavigator);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBbutton);
            this.Name = "Dictionary";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.Start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my_dict)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_word_listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.en_word_listBindingNavigator)).EndInit();
            this.en_word_listBindingNavigator.ResumeLayout(false);
            this.en_word_listBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.en_word_listDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchBbutton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private Data.my_dict my_dict;
        private System.Windows.Forms.BindingSource en_word_listBindingSource;
        private Data.my_dictTableAdapters.en_word_listTableAdapter en_word_listTableAdapter;
        private Data.my_dictTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator en_word_listBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton en_word_listBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView en_word_listDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordtypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn definitionColumn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

