using HW_1._3.Models;
using System.Windows.Forms;

namespace HW_1._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void GetDataButton_Click(object sender, EventArgs e)
        {
            using (DbOfProductsContext context = new DbOfProductsContext())
            {
                var products = context.Products.OrderBy(p => p.Name).ToList();
                //var products = context.Products.ToList();
                dataGridView.DataSource = products;
            }
        }
    }
}
