namespace Section21
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.dictionaryButton = new System.Windows.Forms.Button();
            this.phoneBookButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dictionaryButton
            // 
            this.dictionaryButton.Location = new System.Drawing.Point(58, 48);
            this.dictionaryButton.Name = "dictionaryButton";
            this.dictionaryButton.Size = new System.Drawing.Size(75, 71);
            this.dictionaryButton.TabIndex = 0;
            this.dictionaryButton.Text = "Dictionary";
            this.dictionaryButton.UseVisualStyleBackColor = true;
            this.dictionaryButton.Click += new System.EventHandler(this.DictionaryButton_Click);
            // 
            // phoneBookButton
            // 
            this.phoneBookButton.Location = new System.Drawing.Point(163, 48);
            this.phoneBookButton.Name = "phoneBookButton";
            this.phoneBookButton.Size = new System.Drawing.Size(75, 71);
            this.phoneBookButton.TabIndex = 1;
            this.phoneBookButton.Text = "Phone Book";
            this.phoneBookButton.UseVisualStyleBackColor = true;
            this.phoneBookButton.Click += new System.EventHandler(this.PhoneBookButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = global::Section21.Properties.Resources.exit;
            this.exitButton.Location = new System.Drawing.Point(441, 48);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 71);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 141);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.phoneBookButton);
            this.Controls.Add(this.dictionaryButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dictionaryButton;
        private System.Windows.Forms.Button phoneBookButton;
        private System.Windows.Forms.Button exitButton;
    }
}