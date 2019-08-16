using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_301001793.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void OrderForm_Activated(object sender, EventArgs e)
        {
            ConditionDataLabel.Text = Program.product.condition;
            PlatformDataLabel.Text = Program.product.platform;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            ModelDataLabel.Text = Program.product.model;

            SpecsDataLabel.Text = Program.product.screensize + "\n\n" +
                Program.product.RAM_size + "\n\n" +
                Program.product.CPU_brand + "\n\n" +
                Program.product.CPU_type + "\n\n" +
                Program.product.CPU_speed + "\n\n" +
                Program.product.CPU_Class + "\n\n" +
                Program.product.HDD_size + "\n\n" +
                Program.product.GPU_Type + "\n\n" +
                Program.product.webcam + "\n\n" +
                Program.product.OS;
                        
            double taxRate = 0.13;
            double salesTax = (double)Program.product.cost * taxRate;
            double totalPrice = (double)Program.product.cost + salesTax;
            PriceDataLabel.Text = "$ " + Math.Round(Program.product.cost,2).ToString();            
            SalesTaxDataLabel.Text = "$ " + Math.Round(salesTax,2).ToString();
            TotalPriceDataLabel.Text = "$ " + Math.Round(totalPrice,2).ToString();
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thank you for your order.\n\nYour order will be processed in 7-10 business days.",
                "Finish Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
