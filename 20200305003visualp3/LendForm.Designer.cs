﻿namespace _20200305003visualp3
{
    partial class LendForm
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(355, 145);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 0;
            button1.Text = "Lend";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 151);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Book ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Enter the BookID to lend";
            // 
            // LendForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 543);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "LendForm";
            Text = "LendForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
    }
}