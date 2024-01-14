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
            addTraining_button = new Button();
            SuspendLayout();
            // 
            // addProduct_button
            // 
            addProduct_button.Location = new Point(47, 93);
            addProduct_button.Margin = new Padding(3, 4, 3, 4);
            addProduct_button.Name = "addProduct_button";
            addProduct_button.Size = new Size(98, 60);
            addProduct_button.TabIndex = 0;
            addProduct_button.Text = "Add product";
            addProduct_button.UseVisualStyleBackColor = true;
            addProduct_button.Click += addProduct_button_Click;
            // 
            // addTraining_button
            // 
            addTraining_button.Location = new Point(570, 98);
            addTraining_button.Name = "addTraining_button";
            addTraining_button.Size = new Size(139, 55);
            addTraining_button.TabIndex = 1;
            addTraining_button.Text = "Add training";
            addTraining_button.UseVisualStyleBackColor = true;
            addTraining_button.Click += addTraining_button_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(addTraining_button);
            Controls.Add(addProduct_button);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomePage";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button addProduct_button;
        private Button addTraining_button;
    }
}