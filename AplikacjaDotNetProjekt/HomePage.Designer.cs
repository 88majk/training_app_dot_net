namespace AplikacjaDotNetProjekt
{
    partial class HomePage
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
            addProduct_button = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // addProduct_button
            // 
            addProduct_button.Location = new Point(41, 70);
            addProduct_button.Name = "addProduct_button";
            addProduct_button.Size = new Size(86, 45);
            addProduct_button.TabIndex = 0;
            addProduct_button.Text = "Add product";
            addProduct_button.UseVisualStyleBackColor = true;
            addProduct_button.Click += addProduct_button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(499, 74);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(122, 41);
            button1.TabIndex = 1;
            button1.Text = "Add training";
            button1.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(addProduct_button);
            Name = "HomePage";
            Text = "Home Page";
            ResumeLayout(false);
        }

        #endregion

        private Button addProduct_button;
        private Button button1;
    }
}