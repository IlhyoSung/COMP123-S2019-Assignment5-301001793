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

namespace COMP123_S2019_Assignment5_301001793.Views
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.ORDER_FORM].Show();
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SelectButton_Click(object sender, EventArgs e)
        {
            Program.Forms[FormName.SELECT_FORM].Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            ProductSaveFileDialog.FileName = "Product.txt";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Text Files (*.txt)|*.txt| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open a stream to write
                using (StreamWriter outputString = new StreamWriter(
                    File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write stuff to the file
                    outputString.WriteLine(Program.product.productID);
                    outputString.WriteLine(Program.product.cost);
                    outputString.WriteLine(Program.product.manufacturer);
                    outputString.WriteLine(Program.product.model);
                    outputString.WriteLine(Program.product.RAM_type);
                    outputString.WriteLine(Program.product.RAM_size);
                    outputString.WriteLine(Program.product.displaytype);
                    outputString.WriteLine(Program.product.screensize);
                    outputString.WriteLine(Program.product.resolution);
                    outputString.WriteLine(Program.product.CPU_Class);
                    outputString.WriteLine(Program.product.CPU_brand);
                    outputString.WriteLine(Program.product.CPU_type);
                    outputString.WriteLine(Program.product.CPU_speed);
                    outputString.WriteLine(Program.product.CPU_number);
                    outputString.WriteLine(Program.product.condition);
                    outputString.WriteLine(Program.product.OS);
                    outputString.WriteLine(Program.product.platform);
                    outputString.WriteLine(Program.product.HDD_size);
                    outputString.WriteLine(Program.product.HDD_speed);
                    outputString.WriteLine(Program.product.GPU_Type);
                    outputString.WriteLine(Program.product.optical_drive);
                    outputString.WriteLine(Program.product.Audio_type);
                    outputString.WriteLine(Program.product.LAN);
                    outputString.WriteLine(Program.product.WIFI);
                    outputString.WriteLine(Program.product.width);
                    outputString.WriteLine(Program.product.height);
                    outputString.WriteLine(Program.product.depth);
                    outputString.WriteLine(Program.product.weight);
                    outputString.WriteLine(Program.product.moust_type);
                    outputString.WriteLine(Program.product.power);
                    outputString.WriteLine(Program.product.webcam);

                    // cleanup
                    outputString.Close();
                    outputString.Dispose();

                    // give feedback to the user that the file has been saved
                    // this is a "modal" form
                    MessageBox.Show("File Saved...", "Saving File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }           
        }

        private void ProductInfoForm_Activated(object sender, EventArgs e)
        {           
            ProductIdDataLabel.Text = Program.product.productID.ToString();
            ConditionDataLabel.Text = Program.product.condition;
            CostDataLabel.Text = Program.product.cost.ToString();
            PlatformDataLabel.Text = Program.product.platform;
            ManufacturerDataLabel.Text = Program.product.manufacturer;
            OSDataLabel.Text = Program.product.OS;
            ModelDataLabel.Text = Program.product.model;
            MemoryDataLabel.Text = Program.product.RAM_size;
            CPUBrandDataLabel.Text = Program.product.CPU_brand;
            CPUTypeDataLabel.Text = Program.product.CPU_type;
            LCDSizeDataLabel.Text = Program.product.screensize;
            CPUClassDataLabel.Text = Program.product.CPU_Class;
            CPUSpeedDataLabel.Text = Program.product.CPU_speed;
            HDDDataLabel.Text = Program.product.HDD_size;
            GPUTypeDataLabel.Text = Program.product.GPU_Type;
            WebcamDataLabel.Text = Program.product.webcam;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
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

                    ProductInfoForm_Activated(sender, e);
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

        private void OpenBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            ProductOpenFileDialog.FileName = "Product.dat";
            ProductOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductOpenFileDialog.Filter = "Binary Files (*.dat)|*.dat| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductOpenFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                try
                {
                    // open file stream to read
                    using (BinaryReader inputStream = new BinaryReader(
                        File.Open(ProductOpenFileDialog.FileName, FileMode.Open)))
                    {
                        // read stuff from the file into the Product object
                        Program.product.productID = short.Parse(inputStream.ReadString());
                        Program.product.cost = decimal.Parse(inputStream.ReadString());
                        Program.product.manufacturer = inputStream.ReadString();
                        Program.product.model = inputStream.ReadString();
                        Program.product.RAM_type = inputStream.ReadString();
                        Program.product.RAM_size = inputStream.ReadString();
                        Program.product.displaytype = inputStream.ReadString();
                        Program.product.screensize = inputStream.ReadString();
                        Program.product.resolution = inputStream.ReadString();
                        Program.product.CPU_Class = inputStream.ReadString();
                        Program.product.CPU_brand = inputStream.ReadString();
                        Program.product.CPU_type = inputStream.ReadString();
                        Program.product.CPU_speed = inputStream.ReadString();
                        Program.product.CPU_number = inputStream.ReadString();
                        Program.product.condition = inputStream.ReadString();
                        Program.product.OS = inputStream.ReadString();
                        Program.product.platform = inputStream.ReadString();
                        Program.product.HDD_size = inputStream.ReadString();
                        Program.product.HDD_speed = inputStream.ReadString();
                        Program.product.GPU_Type = inputStream.ReadString();
                        Program.product.optical_drive = inputStream.ReadString();
                        Program.product.Audio_type = inputStream.ReadString();
                        Program.product.LAN = inputStream.ReadString();
                        Program.product.WIFI = inputStream.ReadString();
                        Program.product.width = inputStream.ReadString();
                        Program.product.height = inputStream.ReadString();
                        Program.product.depth = inputStream.ReadString();
                        Program.product.weight = inputStream.ReadString();
                        Program.product.moust_type = inputStream.ReadString();
                        Program.product.power = inputStream.ReadString();
                        Program.product.webcam = inputStream.ReadString();

                        //cleanup
                        inputStream.Close();
                        inputStream.Dispose();
                    }

                    ProductInfoForm_Activated(sender, e);
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

                    MessageBox.Show("ERROR: " + exception.Message + "\n\nPlease select the binary file type.", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveBinaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // configure the file dialog
            ProductSaveFileDialog.FileName = "Product.dat";
            ProductSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            ProductSaveFileDialog.Filter = "Binary Files (*.dat)|*.dat| All Files (*.*)|*.*";

            // open the file dialog
            var result = ProductSaveFileDialog.ShowDialog();
            if (result != DialogResult.Cancel)
            {
                // open a stream to write
                using (BinaryWriter outputString = new BinaryWriter(
                    File.Open(ProductSaveFileDialog.FileName, FileMode.Create)))
                {
                    // write stuff to the file
                    outputString.Write(Program.product.productID);
                    outputString.Write(Program.product.cost);
                    outputString.Write(Program.product.manufacturer);
                    outputString.Write(Program.product.model);
                    outputString.Write(Program.product.RAM_type);
                    outputString.Write(Program.product.RAM_size);
                    outputString.Write(Program.product.displaytype);
                    outputString.Write(Program.product.screensize);
                    outputString.Write(Program.product.resolution);
                    outputString.Write(Program.product.CPU_Class);
                    outputString.Write(Program.product.CPU_brand);
                    outputString.Write(Program.product.CPU_type);
                    outputString.Write(Program.product.CPU_speed);
                    outputString.Write(Program.product.CPU_number);
                    outputString.Write(Program.product.condition);
                    outputString.Write(Program.product.OS);
                    outputString.Write(Program.product.platform);
                    outputString.Write(Program.product.HDD_size);
                    outputString.Write(Program.product.HDD_speed);
                    outputString.Write(Program.product.GPU_Type);
                    outputString.Write(Program.product.optical_drive);
                    outputString.Write(Program.product.Audio_type);
                    outputString.Write(Program.product.LAN);
                    outputString.Write(Program.product.WIFI);
                    outputString.Write(Program.product.width);
                    outputString.Write(Program.product.height);
                    outputString.Write(Program.product.depth);
                    outputString.Write(Program.product.weight);
                    outputString.Write(Program.product.moust_type);
                    outputString.Write(Program.product.power);
                    outputString.Write(Program.product.webcam);

                    // cleanup
                    outputString.Close();
                    outputString.Dispose();

                    // give feedback to the user that the file has been saved
                    // this is a "modal" form
                    MessageBox.Show("Binary File Saved...", "Saving Binary File...",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
