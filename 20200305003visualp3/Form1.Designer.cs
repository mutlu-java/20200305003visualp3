namespace _20200305003visualp3
{
    partial class Window
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sıgnButton = new Button();
            usernametextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            passwordtextBox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // sıgnButton
            // 
            sıgnButton.Location = new Point(293, 287);
            sıgnButton.Name = "sıgnButton";
            sıgnButton.Size = new Size(75, 35);
            sıgnButton.TabIndex = 0;
            sıgnButton.Text = "Sıgn In";
            sıgnButton.UseVisualStyleBackColor = true;
            sıgnButton.Click += sıgnButton_Click;
            // 
            // usernametextBox
            // 
            usernametextBox.Location = new Point(230, 177);
            usernametextBox.Name = "usernametextBox";
            usernametextBox.Size = new Size(138, 27);
            usernametextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 180);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 231);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // passwordtextBox
            // 
            passwordtextBox.Location = new Point(230, 228);
            passwordtextBox.Name = "passwordtextBox";
            passwordtextBox.Size = new Size(138, 27);
            passwordtextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(230, 91);
            label3.Name = "label3";
            label3.Size = new Size(77, 30);
            label3.TabIndex = 5;
            label3.Text = "Libgen";
            // 
            // Window
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 556);
            Controls.Add(label3);
            Controls.Add(passwordtextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernametextBox);
            Controls.Add(sıgnButton);
            Name = "Window";
            Text = "Libgen Library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sıgnButton;
        private TextBox usernametextBox;
        private Label label1;
        private Label label2;
        private TextBox passwordtextBox;
        private Label label3;
    }
}
