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

/* Student Name: Ilhyo Sung
 * Student ID: 301001793
 * Description: This is OrderForm
 */

namespace COMP123_S2019_Assignment5_301001793.Views
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event handler for CancelButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// This is event handler for BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            // show ProductInfoForm and hide this form
            Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This is event handler for aboutToolStripMenuItem Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Program.Forms[FormName.ABOUT_FORM].ShowDialog();
        }

        /// <summary>
        /// This is event handler for printToolStripMenuItem Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        /// <summary>
        /// This is event handler for OrderForm Activated event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Activated(object sender, EventArgs e)
        {
            // input text to labels
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
            
            // calculate price, tax and input data to label
            double taxRate = 0.13;
            double salesTax = (double)Program.product.cost * taxRate;
            double totalPrice = (double)Program.product.cost + salesTax;
            PriceDataLabel.Text = "$ " + Math.Round(Program.product.cost,2).ToString();            
            SalesTaxDataLabel.Text = "$ " + Math.Round(salesTax,2).ToString();
            TotalPriceDataLabel.Text = "$ " + Math.Round(totalPrice,2).ToString();
        }

        /// <summary>
        /// This is event handler for FinishButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            // show messagebox with thank you message and OK button, if press OK button, application will be exited
            DialogResult result = MessageBox.Show("Thank you for your order.\n\nYour order will be processed in 7-10 business days.",
                "Finish Order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
