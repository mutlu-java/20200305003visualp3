namespace _20200305003visualp3
{
    partial class DeleteBForm
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
            textBox = new TextBox();
            deletebutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 161);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 0;
            label1.Text = "Book ID";
            label1.Click += label1_Click;
            // 
            // textBox
            // 
            textBox.Location = new Point(82, 159);
            textBox.Name = "textBox";
            textBox.Size = new Size(261, 27);
            textBox.TabIndex = 1;
            textBox.Text = "enter the book id you want to delete";
            // 
            // deletebutton
            // 
            deletebutton.Location = new Point(349, 161);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(75, 27);
            deletebutton.TabIndex = 2;
            deletebutton.Text = "Delete";
            deletebutton.UseVisualStyleBackColor = true;
            deletebutton.Click += deletebutton_Click;
            // 
            // DeleteBForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 535);
            Controls.Add(deletebutton);
            Controls.Add(textBox);
            Controls.Add(label1);
            Name = "DeleteBForm";
            Text = "DeleteBForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox;
        private Button deletebutton;
    }
}