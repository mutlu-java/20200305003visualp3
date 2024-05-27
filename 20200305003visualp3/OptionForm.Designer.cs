
namespace _20200305003visualp3
{
    partial class OptionForm
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
            addBookbutton = new Button();
            updateBookbutton = new Button();
            deleteBookbutton = new Button();
            displayBooksbutton = new Button();
            searchBookButton = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(112, 56);
            label1.Name = "label1";
            label1.Size = new Size(239, 30);
            label1.TabIndex = 4;
            label1.Text = "Inventory Management";
            // 
            // addBookbutton
            // 
            addBookbutton.Location = new Point(64, 167);
            addBookbutton.Name = "addBookbutton";
            addBookbutton.Size = new Size(103, 37);
            addBookbutton.TabIndex = 6;
            addBookbutton.Text = "Add Book";
            addBookbutton.UseVisualStyleBackColor = true;
            addBookbutton.Click += addBookbutton_Click;
            // 
            // updateBookbutton
            // 
            updateBookbutton.Location = new Point(63, 210);
            updateBookbutton.Name = "updateBookbutton";
            updateBookbutton.Size = new Size(107, 37);
            updateBookbutton.TabIndex = 7;
            updateBookbutton.Text = "Update Book";
            updateBookbutton.UseVisualStyleBackColor = true;
            updateBookbutton.Click += updateBookbutton_Click;
            // 
            // deleteBookbutton
            // 
            deleteBookbutton.Location = new Point(64, 124);
            deleteBookbutton.Name = "deleteBookbutton";
            deleteBookbutton.Size = new Size(103, 37);
            deleteBookbutton.TabIndex = 8;
            deleteBookbutton.Text = "Delete Book";
            deleteBookbutton.UseVisualStyleBackColor = true;
            deleteBookbutton.Click += button5_Click;
            // 
            // displayBooksbutton
            // 
            displayBooksbutton.Location = new Point(63, 339);
            displayBooksbutton.Name = "displayBooksbutton";
            displayBooksbutton.Size = new Size(185, 38);
            displayBooksbutton.TabIndex = 12;
            displayBooksbutton.Text = "Display Books";
            displayBooksbutton.UseVisualStyleBackColor = true;
            displayBooksbutton.Click += displayBooksbutton_Click;
            // 
            // searchBookButton
            // 
            searchBookButton.Location = new Point(64, 295);
            searchBookButton.Name = "searchBookButton";
            searchBookButton.Size = new Size(110, 38);
            searchBookButton.TabIndex = 13;
            searchBookButton.Text = "Search Book";
            searchBookButton.UseVisualStyleBackColor = true;
            searchBookButton.Click += searchBookButton_Click;
            // 
            // button4
            // 
            button4.Location = new Point(63, 253);
            button4.Name = "button4";
            button4.Size = new Size(106, 36);
            button4.TabIndex = 14;
            button4.Text = "Lend Book";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // OptionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 528);
            Controls.Add(button4);
            Controls.Add(searchBookButton);
            Controls.Add(displayBooksbutton);
            Controls.Add(deleteBookbutton);
            Controls.Add(updateBookbutton);
            Controls.Add(addBookbutton);
            Controls.Add(label1);
            Name = "OptionForm";
            Text = "Options";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Label label1;
        private Button addBookbutton;
        private Button updateBookbutton;
        private Button deleteBookbutton;
        private Button displayBooksbutton;
        private Button searchBookButton;
        private Button button4;
    }
}