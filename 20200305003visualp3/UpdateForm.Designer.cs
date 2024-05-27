namespace _20200305003visualp3
{
    partial class UpdateForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            updatebutton1 = new Button();
            bookidtextBox1 = new TextBox();
            titletextBox2 = new TextBox();
            authortextBox3 = new TextBox();
            isbntextBox4 = new TextBox();
            yearspublishedtextBox5 = new TextBox();
            genretextBox6 = new TextBox();
            copiesavailabletextBox7 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 125);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Book ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 162);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 201);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 242);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(92, 281);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 4;
            label5.Text = "Years Published";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(92, 326);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 5;
            label6.Text = "Genre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(92, 366);
            label7.Name = "label7";
            label7.Size = new Size(120, 20);
            label7.TabIndex = 6;
            label7.Text = "Copies Available";
            // 
            // updatebutton1
            // 
            updatebutton1.Location = new Point(243, 420);
            updatebutton1.Name = "updatebutton1";
            updatebutton1.Size = new Size(75, 37);
            updatebutton1.TabIndex = 7;
            updatebutton1.Text = "Update";
            updatebutton1.UseVisualStyleBackColor = true;
            updatebutton1.Click += button1_Click;
            // 
            // bookidtextBox1
            // 
            bookidtextBox1.Location = new Point(227, 122);
            bookidtextBox1.Name = "bookidtextBox1";
            bookidtextBox1.Size = new Size(100, 27);
            bookidtextBox1.TabIndex = 8;
            // 
            // titletextBox2
            // 
            titletextBox2.Location = new Point(227, 159);
            titletextBox2.Name = "titletextBox2";
            titletextBox2.Size = new Size(100, 27);
            titletextBox2.TabIndex = 9;
            // 
            // authortextBox3
            // 
            authortextBox3.Location = new Point(227, 198);
            authortextBox3.Name = "authortextBox3";
            authortextBox3.Size = new Size(100, 27);
            authortextBox3.TabIndex = 10;
            // 
            // isbntextBox4
            // 
            isbntextBox4.Location = new Point(227, 231);
            isbntextBox4.Name = "isbntextBox4";
            isbntextBox4.Size = new Size(100, 27);
            isbntextBox4.TabIndex = 11;
            // 
            // yearspublishedtextBox5
            // 
            yearspublishedtextBox5.Location = new Point(227, 278);
            yearspublishedtextBox5.Name = "yearspublishedtextBox5";
            yearspublishedtextBox5.Size = new Size(100, 27);
            yearspublishedtextBox5.TabIndex = 12;
            // 
            // genretextBox6
            // 
            genretextBox6.Location = new Point(227, 323);
            genretextBox6.Name = "genretextBox6";
            genretextBox6.Size = new Size(100, 27);
            genretextBox6.TabIndex = 13;
            // 
            // copiesavailabletextBox7
            // 
            copiesavailabletextBox7.Location = new Point(229, 363);
            copiesavailabletextBox7.Name = "copiesavailabletextBox7";
            copiesavailabletextBox7.Size = new Size(100, 27);
            copiesavailabletextBox7.TabIndex = 14;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 579);
            Controls.Add(copiesavailabletextBox7);
            Controls.Add(genretextBox6);
            Controls.Add(yearspublishedtextBox5);
            Controls.Add(isbntextBox4);
            Controls.Add(authortextBox3);
            Controls.Add(titletextBox2);
            Controls.Add(bookidtextBox1);
            Controls.Add(updatebutton1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UpdateForm";
            Text = "UpdateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button updatebutton1;
        private TextBox bookidtextBox1;
        private TextBox titletextBox2;
        private TextBox authortextBox3;
        private TextBox isbntextBox4;
        private TextBox yearspublishedtextBox5;
        private TextBox genretextBox6;
        private TextBox copiesavailabletextBox7;
    }
}