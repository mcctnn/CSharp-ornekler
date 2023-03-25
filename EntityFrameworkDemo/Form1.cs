using System.Data.SqlClient;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProduts();
        }

        private void LoadProduts()
        {
            dataGridView1.DataSource = _productDal.GetAll();
        }
        private void SearchProduts(string key)
        {
            var result = _productDal.GetAll().Where(p=>p.Name.ToLower().Contains(key.ToLower())).ToList();
            //var result = _productDal.GetByName(key);
            dataGridView1.DataSource = result;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            _productDal.Add(new Product
            {
                Name=tbxname.Text,
                UnitPrice=Convert.ToDecimal(tbxunitPrice.Text),
                StockAmount=Convert.ToInt32(tbxstockAmount.Text)
            });
            LoadProduts();
            MessageBox.Show("Product added!");
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(new Product
            {
                Id=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value),
                Name=tbxnameUpdate.Text,
                UnitPrice=Convert.ToDecimal(tbxunitPriceUpdate.Text),
                StockAmount=Convert.ToInt32(tbxstockAmountUpdate.Text)
            });
            LoadProduts();
            MessageBox.Show("Product updated!");
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxnameUpdate.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            tbxunitPriceUpdate.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            tbxstockAmountUpdate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(new Product
            {
                Id=Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)
            });
            LoadProduts();
            MessageBox.Show("Product deleted!");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProduts(tbxSearch.Text);
        }

        private void btnGetbyId_Click(object sender, EventArgs e)
        {
            _productDal.GetById(1);
        }
    }
}