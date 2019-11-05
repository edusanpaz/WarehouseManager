using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseManager
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void LabelInfoVar_Click(object sender, EventArgs e)
        {
            labelInfoVar.Text = "Selecciona una opción para comenzar.";
        }

        private void ButtonNewPurchase_Click(object sender, EventArgs e)
        {
            FormAddPurchase formAddPurchase = new FormAddPurchase();
            formAddPurchase.ShowDialog();
        }

        private void ButtonNewSale_Click(object sender, EventArgs e)
        {
            FormAddSale formAddSale = new FormAddSale();
            formAddSale.ShowDialog();
        }
    }
}
