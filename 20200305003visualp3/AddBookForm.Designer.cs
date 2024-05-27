namespace _20200305003visualp3
{
    partial class AddBookForm
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
            bookidtextBox = new TextBox();
            titletextBox = new TextBox();
            authortextBox = new TextBox();
            isbntextBox = new TextBox();
            yearpublishedtextBox = new TextBox();
            genretextBox = new TextBox();
            copiesavailabletextBox = new TextBox();
            AddBookbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 72);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "BookID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 115);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 157);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 203);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(101, 249);
            label5.Name = "label5";
            label5.Size = new Size(101, 20);
            label5.TabIndex = 4;
            label5.Text = "YearPublished";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(101, 289);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 5;
            label6.Text = "Genre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(101, 339);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 6;
            label7.Text = "CopiesAvailable";
            // 
            // bookidtextBox
            // 
            bookidtextBox.Location = new Point(230, 72);
            bookidtextBox.Name = "bookidtextBox";
            bookidtextBox.Size = new Size(143, 27);
            bookidtextBox.TabIndex = 7;
            // 
            // titletextBox
            // 
            titletextBox.Location = new Point(230, 115);
            titletextBox.Name = "titletextBox";
            titletextBox.Size = new Size(143, 27);
            titletextBox.TabIndex = 8;
            // 
            // authortextBox
            // 
            authortextBox.Location = new Point(230, 157);
            authortextBox.Name = "authortextBox";
            authortextBox.Size = new Size(143, 27);
            authortextBox.TabIndex = 9;
            // 
            // isbntextBox
            // 
            isbntextBox.Location = new Point(230, 210);
            isbntextBox.Name = "isbntextBox";
            isbntextBox.Size = new Size(143, 27);
            isbntextBox.TabIndex = 10;
            // 
            // yearpublishedtextBox
            // 
            yearpublishedtextBox.Location = new Point(230, 249);
            yearpublishedtextBox.Name = "yearpublishedtextBox";
            yearpublishedtextBox.Size = new Size(143, 27);
            yearpublishedtextBox.TabIndex = 11;
            // 
            // genretextBox
            // 
            genretextBox.Location = new Point(230, 289);
            genretextBox.Name = "genretextBox";
            genretextBox.Size = new Size(143, 27);
            genretextBox.TabIndex = 12;
            // 
            // copiesavailabletextBox
            // 
            copiesavailabletextBox.Location = new Point(230, 332);
            copiesavailabletextBox.Name = "copiesavailabletextBox";
            copiesavailabletextBox.Size = new Size(143, 27);
            copiesavailabletextBox.TabIndex = 13;
            // 
            // AddBookbutton
            // 
            AddBookbutton.Location = new Point(298, 393);
            AddBookbutton.Name = "AddBookbutton";
            AddBookbutton.Size = new Size(75, 35);
            AddBookbutton.TabIndex = 14;
            AddBookbutton.Text = "Add";
            AddBookbutton.UseVisualStyleBackColor = true;
            AddBookbutton.Click += AddBookbutton_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 555);
            Controls.Add(AddBookbutton);
            Controls.Add(copiesavailabletextBox);
            Controls.Add(genretextBox);
            Controls.Add(yearpublishedtextBox);
            Controls.Add(isbntextBox);
            Controls.Add(authortextBox);
            Controls.Add(titletextBox);
            Controls.Add(bookidtextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBookForm";
            Text = "AddBookForm";
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
        private TextBox bookidtextBox;
        private TextBox titletextBox;
        private TextBox authortextBox;
        private TextBox isbntextBox;
        private TextBox yearpublishedtextBox;
        private TextBox genretextBox;
        private TextBox copiesavailabletextBox;
        private Button AddBookbutton;
    }
}