namespace AplikacjaDotNetProjekt
{
    public partial class HomePage : Form
    {
        AddProduct addProduct;
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
    }
}