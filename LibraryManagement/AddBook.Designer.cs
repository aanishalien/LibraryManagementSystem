namespace LibraryManagement
{
    partial class AddBook
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addbooks_published = new System.Windows.Forms.DateTimePicker();
            this.addbooks_status = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.addbooks_deletebtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.addbook_importbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addbooks_author = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addbooks_booktitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addbooks_picture = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addbooks_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(336, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 553);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.dataGridView1.Location = new System.Drawing.Point(28, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(383, 476);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "All Issued Book";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.addbooks_published);
            this.panel1.Controls.Add(this.addbooks_status);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.addbooks_deletebtn);
            this.panel1.Controls.Add(this.updatebtn);
            this.panel1.Controls.Add(this.addbook_importbtn);
            this.panel1.Controls.Add(this.addbtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addbooks_author);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addbooks_booktitle);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.addbooks_picture);
            this.panel1.Location = new System.Drawing.Point(21, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 553);
            this.panel1.TabIndex = 2;
            // 
            // addbooks_published
            // 
            this.addbooks_published.Location = new System.Drawing.Point(124, 246);
            this.addbooks_published.Name = "addbooks_published";
            this.addbooks_published.Size = new System.Drawing.Size(100, 20);
            this.addbooks_published.TabIndex = 6;
            // 
            // addbooks_status
            // 
            this.addbooks_status.FormattingEnabled = true;
            this.addbooks_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addbooks_status.Location = new System.Drawing.Point(124, 293);
            this.addbooks_status.Name = "addbooks_status";
            this.addbooks_status.Size = new System.Drawing.Size(100, 21);
            this.addbooks_status.TabIndex = 5;
            this.addbooks_status.SelectedIndexChanged += new System.EventHandler(this.Addbooks_status_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(149, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "CLEAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // addbooks_deletebtn
            // 
            this.addbooks_deletebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addbooks_deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbooks_deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbooks_deletebtn.Location = new System.Drawing.Point(40, 432);
            this.addbooks_deletebtn.Name = "addbooks_deletebtn";
            this.addbooks_deletebtn.Size = new System.Drawing.Size(75, 23);
            this.addbooks_deletebtn.TabIndex = 4;
            this.addbooks_deletebtn.Text = "DELETE";
            this.addbooks_deletebtn.UseVisualStyleBackColor = false;
            this.addbooks_deletebtn.Click += new System.EventHandler(this.Addbooks_deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Location = new System.Drawing.Point(149, 373);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 4;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // addbook_importbtn
            // 
            this.addbook_importbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addbook_importbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbook_importbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbook_importbtn.Location = new System.Drawing.Point(52, 122);
            this.addbook_importbtn.Name = "addbook_importbtn";
            this.addbook_importbtn.Size = new System.Drawing.Size(96, 23);
            this.addbook_importbtn.TabIndex = 4;
            this.addbook_importbtn.Text = "Import";
            this.addbook_importbtn.UseVisualStyleBackColor = false;
            this.addbook_importbtn.Click += new System.EventHandler(this.Addbook_importbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Location = new System.Drawing.Point(40, 372);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status";
            // 
            // addbooks_author
            // 
            this.addbooks_author.Location = new System.Drawing.Point(124, 208);
            this.addbooks_author.Name = "addbooks_author";
            this.addbooks_author.Size = new System.Drawing.Size(100, 20);
            this.addbooks_author.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Published :";
            // 
            // addbooks_booktitle
            // 
            this.addbooks_booktitle.Location = new System.Drawing.Point(124, 167);
            this.addbooks_booktitle.Name = "addbooks_booktitle";
            this.addbooks_booktitle.Size = new System.Drawing.Size(100, 20);
            this.addbooks_booktitle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Author";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Title";
            // 
            // addbooks_picture
            // 
            this.addbooks_picture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.addbooks_picture.Location = new System.Drawing.Point(52, 35);
            this.addbooks_picture.Name = "addbooks_picture";
            this.addbooks_picture.Size = new System.Drawing.Size(96, 87);
            this.addbooks_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addbooks_picture.TabIndex = 0;
            this.addbooks_picture.TabStop = false;
            this.addbooks_picture.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddBook";
            this.Size = new System.Drawing.Size(773, 595);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addbooks_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addbooks_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addbooks_booktitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox addbooks_picture;
        private System.Windows.Forms.DateTimePicker addbooks_published;
        private System.Windows.Forms.ComboBox addbooks_status;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addbooks_deletebtn;
        private System.Windows.Forms.Button addbook_importbtn;
    }
}
