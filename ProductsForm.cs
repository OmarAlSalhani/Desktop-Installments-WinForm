using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace installmentsApp.ProductsForms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            if (Previlage.Default.AddOneProduct == 0)
                AddOneProductBtn.Enabled = false;
            if (Previlage.Default.ManageProduct == 0)
                ManageProductsBtn.Enabled = false;

            if (Previlage.Default.AddCompany == 0)
                AddCompanyBtn.Enabled = false;
            if (Previlage.Default.ManageCompany == 0)
                ManageCompanyBtn.Enabled = false;
            if (Previlage.Default.AolModa == 0)
                AolModaBtn.Visible = false;
        }
        private void AddCompanyBtn_Click(object sender, EventArgs e)
        {
            CompaniesForms.AddCompany addCompany = new CompaniesForms.AddCompany();
            addCompany.StartPosition = FormStartPosition.CenterScreen;
            addCompany.ShowDialog();
        }

        private void AddOneProductBtn_Click(object sender, EventArgs e)
        {
            ProductsForms.AddProductForm addProductForm = new AddProductForm();
            addProductForm.StartPosition = FormStartPosition.CenterScreen;
            addProductForm.ShowDialog();
        }

        private void ManageProductsBtn_Click(object sender, EventArgs e)
        {
            ProductsForms.ManageProductsForm manageProductsForm = new ProductsForms.ManageProductsForm();
            manageProductsForm.Show();

        }

        private void ManageCompanyBtn_Click(object sender, EventArgs e)
        {
            CompaniesForms.ManageCompanies manageCompanies = new CompaniesForms.ManageCompanies();
            manageCompanies.Show();
        }

        private void AolModaForm_Click(object sender, EventArgs e)
        {
            AolModaForm modaForm = new AolModaForm();
            modaForm.Show();
        }
    }
}
