namespace AdoNetDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //private void Form1_Load(object sender, DataGridViewCellEventArgs e)
        //{

        //}


        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productDal.GetAll();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name = tbxname.Text,
                UnitPrice = Convert.ToDecimal(tbxunitPrice.Text),
                StockAmount = Convert.ToInt32(tbxunitPrice)
            });
            LoadProducts();
            MessageBox.Show("Product added!");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxnameUpdate.Text = dgwProducts.CurrentRow.Cells[1].Value.ToString();
            tbxunitPriceUpdate.Text = dgwProducts.CurrentRow.Cells[2].Value.ToString();
            tbxstockAmountUpdate.Text = dgwProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Product product = new Product 
            {
                Id= Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value),
                Name= tbxnameUpdate.Text,
                UnitPrice= Convert.ToDecimal(tbxunitPriceUpdate.Text),
                StockAmount= Convert.ToInt32(tbxstockAmountUpdate.Text)
            };
            _productDal.Update(product);
            LoadProducts();
            MessageBox.Show("Updated!");
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProducts.CurrentRow.Cells[0].Value);
            _productDal.Delete(id);
            LoadProducts();
            MessageBox.Show("Deleted");
        }
    }
       
}

    
