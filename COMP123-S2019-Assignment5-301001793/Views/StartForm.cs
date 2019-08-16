using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Student Name: Ilhyo Sung
 * Student ID: 301001793
 * Description: This is StartForm
 */

namespace COMP123_S2019_Assignment5_301001793.Views
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event handler for StartButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

        /// <summary>
        /// This is event handler for LoadButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButton_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            ProductOpenFileDialog.FileName = "Product.txt";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // open file stream to read
                    using (StreamReader inputStream = new StreamReader(
                        File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read stuff from the file into the Product object
                        Program.product.productID = short.Parse(inputStream.ReadLine());
                        Program.product.cost = decimal.Parse(inputStream.ReadLine());
                        Program.product.manufacturer = inputStream.ReadLine();
                        Program.product.model = inputStream.ReadLine();
                        Program.product.RAM_type = inputStream.ReadLine();
                        Program.product.RAM_size = inputStream.ReadLine();
                        Program.product.displaytype = inputStream.ReadLine();
                        Program.product.screensize = inputStream.ReadLine();
                        Program.product.resolution = inputStream.ReadLine();
                        Program.product.CPU_Class = inputStream.ReadLine();
                        Program.product.CPU_brand = inputStream.ReadLine();
                        Program.product.CPU_type = inputStream.ReadLine();
                        Program.product.CPU_speed = inputStream.ReadLine();
                        Program.product.CPU_number = inputStream.ReadLine();
                        Program.product.condition = inputStream.ReadLine();
                        Program.product.OS = inputStream.ReadLine();
                        Program.product.platform = inputStream.ReadLine();
                        Program.product.HDD_size = inputStream.ReadLine();
                        Program.product.HDD_speed = inputStream.ReadLine();
                        Program.product.GPU_Type = inputStream.ReadLine();
                        Program.product.optical_drive = inputStream.ReadLine();
                        Program.product.Audio_type = inputStream.ReadLine();
                        Program.product.LAN = inputStream.ReadLine();
                        Program.product.WIFI = inputStream.ReadLine();
                        Program.product.width = inputStream.ReadLine();
                        Program.product.height = inputStream.ReadLine();
                        Program.product.depth = inputStream.ReadLine();
                        Program.product.weight = inputStream.ReadLine();
                        Program.product.moust_type = inputStream.ReadLine();
                        Program.product.power = inputStream.ReadLine();
                        Program.product.webcam = inputStream.ReadLine();

                        //cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }

                    // show ProductInfoForm and hide StartForm
                    Program.Forms[FormName.PRODUCT_INFO_FORM].Show();
                    this.Hide();
                }
                catch (IOException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message, "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException exception)
                {
                    Debug.WriteLine("ERROR: " + exception.Message);

                    MessageBox.Show("ERROR: " + exception.Message + "\n\nPlease select the text file type.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }            
        }

        /// <summary>
        /// This is event handler for ExitButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
