
namespace SchoolOffice
{
    partial class Nauczyciele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nauczyciele));
            this.label7 = new System.Windows.Forms.Label();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SubCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Ndata = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.NaddTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NPlecCb = new System.Windows.Forms.ComboBox();
            this.NnameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NphoneTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NauczycieleDGV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NauczycieleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(399, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 33);
            this.label7.TabIndex = 43;
            this.label7.Text = "Lista Nauczycieli";
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.LightBlue;
            this.BackBtn.Location = new System.Drawing.Point(752, 245);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(181, 34);
            this.BackBtn.TabIndex = 41;
            this.BackBtn.Text = "Cofnij";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.LightBlue;
            this.DeleteBtn.Location = new System.Drawing.Point(543, 245);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(181, 34);
            this.DeleteBtn.TabIndex = 40;
            this.DeleteBtn.Text = "Usuń";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.Color.LightBlue;
            this.EditBtn.Location = new System.Drawing.Point(335, 245);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(181, 34);
            this.EditBtn.TabIndex = 39;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.LightBlue;
            this.AddBtn.Location = new System.Drawing.Point(126, 245);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(181, 34);
            this.AddBtn.TabIndex = 38;
            this.AddBtn.Text = "Dodaj";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(805, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 37;
            this.label6.Text = "Przedmiot";
            // 
            // SubCb
            // 
            this.SubCb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubCb.FormattingEnabled = true;
            this.SubCb.Items.AddRange(new object[] {
            "Matematyka",
            "Język Polski",
            "Fizyka",
            "Geografia",
            "Chemia",
            "Historia",
            "Biologia"});
            this.SubCb.Location = new System.Drawing.Point(805, 114);
            this.SubCb.Name = "SubCb";
            this.SubCb.Size = new System.Drawing.Size(151, 31);
            this.SubCb.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(348, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Data";
            // 
            // Ndata
            // 
            this.Ndata.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ndata.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Ndata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Ndata.Location = new System.Drawing.Point(348, 191);
            this.Ndata.Name = "Ndata";
            this.Ndata.Size = new System.Drawing.Size(185, 30);
            this.Ndata.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(348, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "Płeć";
            // 
            // NaddTb
            // 
            this.NaddTb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NaddTb.Location = new System.Drawing.Point(580, 114);
            this.NaddTb.Multiline = true;
            this.NaddTb.Name = "NaddTb";
            this.NaddTb.Size = new System.Drawing.Size(200, 108);
            this.NaddTb.TabIndex = 32;
            this.NaddTb.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(580, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Adres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // NPlecCb
            // 
            this.NPlecCb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NPlecCb.FormattingEnabled = true;
            this.NPlecCb.Items.AddRange(new object[] {
            "Mężczyczna",
            "Kobieta"});
            this.NPlecCb.Location = new System.Drawing.Point(348, 114);
            this.NPlecCb.Name = "NPlecCb";
            this.NPlecCb.Size = new System.Drawing.Size(185, 31);
            this.NPlecCb.TabIndex = 30;
            // 
            // NnameTb
            // 
            this.NnameTb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NnameTb.Location = new System.Drawing.Point(125, 115);
            this.NnameTb.Name = "NnameTb";
            this.NnameTb.Size = new System.Drawing.Size(200, 30);
            this.NnameTb.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(125, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Imię";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 52);
            this.panel1.TabIndex = 27;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(981, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(58, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nauczyciele";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1043, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // NphoneTb
            // 
            this.NphoneTb.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NphoneTb.Location = new System.Drawing.Point(125, 191);
            this.NphoneTb.Name = "NphoneTb";
            this.NphoneTb.Size = new System.Drawing.Size(200, 30);
            this.NphoneTb.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(125, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "Telefon";
            // 
            // NauczycieleDGV
            // 
            this.NauczycieleDGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NauczycieleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NauczycieleDGV.Location = new System.Drawing.Point(12, 331);
            this.NauczycieleDGV.Name = "NauczycieleDGV";
            this.NauczycieleDGV.RowHeadersWidth = 51;
            this.NauczycieleDGV.RowTemplate.Height = 29;
            this.NauczycieleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.NauczycieleDGV.Size = new System.Drawing.Size(989, 325);
            this.NauczycieleDGV.TabIndex = 46;
            this.NauczycieleDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NauczycieleDGV_CellContentClick);
            // 
            // Nauczyciele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 682);
            this.Controls.Add(this.NauczycieleDGV);
            this.Controls.Add(this.NphoneTb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SubCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ndata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NaddTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NPlecCb);
            this.Controls.Add(this.NnameTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Nauczyciele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nauczyciele";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NauczycieleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox SubCb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker Ndata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NaddTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NPlecCb;
        private System.Windows.Forms.TextBox NnameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox NphoneTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView NauczycieleDGV;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}