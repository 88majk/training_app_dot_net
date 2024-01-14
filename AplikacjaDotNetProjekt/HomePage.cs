namespace AplikacjaDotNetProjekt
{
    public partial class HomePage : Form
    {
        AddProduct addProduct;
        AddTraining addTraining;
        public HomePage()
        {
            InitializeComponent();
        }

        private void addProduct_button_Click(object sender, EventArgs e)
        {
            if (addProduct == null || addProduct.IsDisposed)
            {
                addProduct = new AddProduct();
                addProduct.Show();
            }
            else
            {
                if (addProduct.WindowState == FormWindowState.Minimized)
                {
                    addProduct.WindowState = FormWindowState.Normal;
                }

                addProduct.BringToFront();
                addProduct.Focus();
            }
        }

        private void addTraining_button_Click(object sender, EventArgs e)
        {
            if (addTraining == null || addTraining.IsDisposed)
            {
                addTraining = new AddTraining();
                addTraining.Show();
            }
            else
            {
                if (addTraining.WindowState == FormWindowState.Minimized)
                {
                    addTraining.WindowState = FormWindowState.Normal;
                }

                addTraining.BringToFront();
                addTraining.Focus();
            }
        }
    }
}