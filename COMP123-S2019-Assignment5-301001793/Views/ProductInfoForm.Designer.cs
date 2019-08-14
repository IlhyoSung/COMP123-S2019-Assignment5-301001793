namespace COMP123_S2019_Assignment5_301001793.Views
{
    partial class ProductInfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.ProductInfoOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductInfoMenuStrip = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NextButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ClickNextLabel = new System.Windows.Forms.Label();
            this.ProductIdGroupBox = new System.Windows.Forms.GroupBox();
            this.CostDataLabel = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.ProductIdDataLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ManufacturerDataLabel = new System.Windows.Forms.Label();
            this.ModelDataLabel = new System.Windows.Forms.Label();
            this.OSDataLabel = new System.Windows.Forms.Label();
            this.PlatformDataLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUSpeedDataLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.CPUClassDataLabel = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.WebcamDataLabel = new System.Windows.Forms.Label();
            this.GPUTypeDataLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.LCDSizeDataLabel = new System.Windows.Forms.Label();
            this.MemoryDataLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUClassLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.ProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ProductSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfoMenuStrip.SuspendLayout();
            this.ProductIdGroupBox.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoOpenFileDialog
            // 
            this.ProductInfoOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoMenuStrip
            // 
            this.ProductInfoMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem});
            this.ProductInfoMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoMenuStrip.Name = "ProductInfoMenuStrip";
            this.ProductInfoMenuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.ProductInfoMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.ProductInfoMenuStrip.TabIndex = 0;
            this.ProductInfoMenuStrip.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Se&lect Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(679, 369);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(94, 31);
            this.NextButton.TabIndex = 6;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(581, 369);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 31);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(364, 369);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(213, 31);
            this.SelectButton.TabIndex = 8;
            this.SelectButton.Text = "Select Another Product";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ClickNextLabel
            // 
            this.ClickNextLabel.AutoSize = true;
            this.ClickNextLabel.Location = new System.Drawing.Point(12, 374);
            this.ClickNextLabel.Name = "ClickNextLabel";
            this.ClickNextLabel.Size = new System.Drawing.Size(263, 20);
            this.ClickNextLabel.TabIndex = 9;
            this.ClickNextLabel.Text = "Click Next to Confirm Your Selection";
            // 
            // ProductIdGroupBox
            // 
            this.ProductIdGroupBox.Controls.Add(this.CostDataLabel);
            this.ProductIdGroupBox.Controls.Add(this.ConditionDataLabel);
            this.ProductIdGroupBox.Controls.Add(this.ProductIdDataLabel);
            this.ProductIdGroupBox.Controls.Add(this.CostLabel);
            this.ProductIdGroupBox.Controls.Add(this.ConditionLabel);
            this.ProductIdGroupBox.Controls.Add(this.ProductIdLabel);
            this.ProductIdGroupBox.Location = new System.Drawing.Point(14, 28);
            this.ProductIdGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductIdGroupBox.Name = "ProductIdGroupBox";
            this.ProductIdGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductIdGroupBox.Size = new System.Drawing.Size(758, 68);
            this.ProductIdGroupBox.TabIndex = 10;
            this.ProductIdGroupBox.TabStop = false;
            // 
            // CostDataLabel
            // 
            this.CostDataLabel.BackColor = System.Drawing.Color.White;
            this.CostDataLabel.Location = new System.Drawing.Point(577, 27);
            this.CostDataLabel.Name = "CostDataLabel";
            this.CostDataLabel.Size = new System.Drawing.Size(112, 26);
            this.CostDataLabel.TabIndex = 8;
            this.CostDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.BackColor = System.Drawing.Color.White;
            this.ConditionDataLabel.Location = new System.Drawing.Point(361, 27);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(112, 26);
            this.ConditionDataLabel.TabIndex = 7;
            this.ConditionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ProductIdDataLabel
            // 
            this.ProductIdDataLabel.AccessibleDescription = "";
            this.ProductIdDataLabel.AccessibleName = "";
            this.ProductIdDataLabel.BackColor = System.Drawing.Color.White;
            this.ProductIdDataLabel.Location = new System.Drawing.Point(123, 27);
            this.ProductIdDataLabel.Name = "ProductIdDataLabel";
            this.ProductIdDataLabel.Size = new System.Drawing.Size(112, 26);
            this.ProductIdDataLabel.TabIndex = 6;
            this.ProductIdDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CostLabel.Location = new System.Drawing.Point(529, 30);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(42, 20);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ConditionLabel.Location = new System.Drawing.Point(279, 30);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(76, 20);
            this.ConditionLabel.TabIndex = 2;
            this.ConditionLabel.Text = "Condition";
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ProductIdLabel.Location = new System.Drawing.Point(32, 30);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(85, 20);
            this.ProductIdLabel.TabIndex = 0;
            this.ProductIdLabel.Text = "Product ID";
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformDataLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(14, 104);
            this.ProductInfoGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(758, 104);
            this.ProductInfoGroupBox.TabIndex = 11;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ManufacturerDataLabel
            // 
            this.ManufacturerDataLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerDataLabel.Location = new System.Drawing.Point(123, 61);
            this.ManufacturerDataLabel.Name = "ManufacturerDataLabel";
            this.ManufacturerDataLabel.Size = new System.Drawing.Size(112, 26);
            this.ManufacturerDataLabel.TabIndex = 14;
            this.ManufacturerDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelDataLabel
            // 
            this.ModelDataLabel.BackColor = System.Drawing.Color.White;
            this.ModelDataLabel.Location = new System.Drawing.Point(361, 61);
            this.ModelDataLabel.Name = "ModelDataLabel";
            this.ModelDataLabel.Size = new System.Drawing.Size(391, 26);
            this.ModelDataLabel.TabIndex = 8;
            this.ModelDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OSDataLabel
            // 
            this.OSDataLabel.BackColor = System.Drawing.Color.White;
            this.OSDataLabel.Location = new System.Drawing.Point(361, 27);
            this.OSDataLabel.Name = "OSDataLabel";
            this.OSDataLabel.Size = new System.Drawing.Size(391, 26);
            this.OSDataLabel.TabIndex = 8;
            this.OSDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatformDataLabel
            // 
            this.PlatformDataLabel.BackColor = System.Drawing.Color.White;
            this.PlatformDataLabel.Location = new System.Drawing.Point(123, 27);
            this.PlatformDataLabel.Name = "PlatformDataLabel";
            this.PlatformDataLabel.Size = new System.Drawing.Size(112, 26);
            this.PlatformDataLabel.TabIndex = 8;
            this.PlatformDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(13, 65);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.ManufacturerLabel.TabIndex = 10;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(303, 65);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 12;
            this.ModelLabel.Text = "Model";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(49, 30);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(68, 20);
            this.PlatformLabel.TabIndex = 6;
            this.PlatformLabel.Text = "Platform";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(323, 30);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(32, 20);
            this.OSLabel.TabIndex = 8;
            this.OSLabel.Text = "OS";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebcamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUClassDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.WebcamDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryDataLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUClassLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(14, 216);
            this.TechSpecsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(758, 141);
            this.TechSpecsGroupBox.TabIndex = 12;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Location = new System.Drawing.Point(497, 104);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(75, 20);
            this.WebcamLabel.TabIndex = 22;
            this.WebcamLabel.Text = "WebCam";
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(37, 103);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(80, 20);
            this.CPUTypeLabel.TabIndex = 18;
            this.CPUTypeLabel.Text = "CPU Type";
            // 
            // CPUSpeedDataLabel
            // 
            this.CPUSpeedDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedDataLabel.Location = new System.Drawing.Point(362, 101);
            this.CPUSpeedDataLabel.Name = "CPUSpeedDataLabel";
            this.CPUSpeedDataLabel.Size = new System.Drawing.Size(112, 26);
            this.CPUSpeedDataLabel.TabIndex = 8;
            this.CPUSpeedDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(123, 100);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(112, 26);
            this.CPUTypeDataLabel.TabIndex = 8;
            this.CPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUClassDataLabel
            // 
            this.CPUClassDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUClassDataLabel.Location = new System.Drawing.Point(361, 65);
            this.CPUClassDataLabel.Name = "CPUClassDataLabel";
            this.CPUClassDataLabel.Size = new System.Drawing.Size(112, 26);
            this.CPUClassDataLabel.TabIndex = 8;
            this.CPUClassDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(123, 64);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(112, 26);
            this.CPUBrandDataLabel.TabIndex = 8;
            this.CPUBrandDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WebcamDataLabel
            // 
            this.WebcamDataLabel.BackColor = System.Drawing.Color.White;
            this.WebcamDataLabel.Location = new System.Drawing.Point(577, 100);
            this.WebcamDataLabel.Name = "WebcamDataLabel";
            this.WebcamDataLabel.Size = new System.Drawing.Size(175, 26);
            this.WebcamDataLabel.TabIndex = 8;
            this.WebcamDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GPUTypeDataLabel
            // 
            this.GPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeDataLabel.Location = new System.Drawing.Point(578, 65);
            this.GPUTypeDataLabel.Name = "GPUTypeDataLabel";
            this.GPUTypeDataLabel.Size = new System.Drawing.Size(175, 26);
            this.GPUTypeDataLabel.TabIndex = 8;
            this.GPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.BackColor = System.Drawing.Color.White;
            this.HDDDataLabel.Location = new System.Drawing.Point(578, 28);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(175, 26);
            this.HDDDataLabel.TabIndex = 8;
            this.HDDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LCDSizeDataLabel
            // 
            this.LCDSizeDataLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeDataLabel.Location = new System.Drawing.Point(361, 28);
            this.LCDSizeDataLabel.Name = "LCDSizeDataLabel";
            this.LCDSizeDataLabel.Size = new System.Drawing.Size(112, 26);
            this.LCDSizeDataLabel.TabIndex = 8;
            this.LCDSizeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryDataLabel
            // 
            this.MemoryDataLabel.BackColor = System.Drawing.Color.White;
            this.MemoryDataLabel.Location = new System.Drawing.Point(123, 28);
            this.MemoryDataLabel.Name = "MemoryDataLabel";
            this.MemoryDataLabel.Size = new System.Drawing.Size(112, 26);
            this.MemoryDataLabel.TabIndex = 8;
            this.MemoryDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(263, 104);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(93, 20);
            this.CPUSpeedLabel.TabIndex = 20;
            this.CPUSpeedLabel.Text = "CPU Speed";
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(490, 68);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(82, 20);
            this.GPUTypeLabel.TabIndex = 16;
            this.GPUTypeLabel.Text = "GPU Type";
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(26, 67);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(89, 20);
            this.CPUBrandLabel.TabIndex = 12;
            this.CPUBrandLabel.Text = "CPU Brand";
            // 
            // CPUClassLabel
            // 
            this.CPUClassLabel.AutoSize = true;
            this.CPUClassLabel.Location = new System.Drawing.Point(270, 67);
            this.CPUClassLabel.Name = "CPUClassLabel";
            this.CPUClassLabel.Size = new System.Drawing.Size(85, 20);
            this.CPUClassLabel.TabIndex = 14;
            this.CPUClassLabel.Text = "CPU Class";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(527, 31);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(45, 20);
            this.HDDLabel.TabIndex = 10;
            this.HDDLabel.Text = "HDD";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(52, 31);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(65, 20);
            this.MemoryLabel.TabIndex = 6;
            this.MemoryLabel.Text = "Memory";
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(279, 31);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(76, 20);
            this.LCDSizeLabel.TabIndex = 8;
            this.LCDSizeLabel.Text = "LCD Size";
            // 
            // ProductOpenFileDialog
            // 
            this.ProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.OpenBinaryToolStripMenuItem,
            this.SaveBinaryToolStripMenuItem,
            this.toolStripSeparator,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.OpenToolStripMenuItem.Text = "&Open (Text File)";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(206, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.SaveToolStripMenuItem.Text = "&Save (Text File)";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(206, 6);
            // 
            // OpenBinaryToolStripMenuItem
            // 
            this.OpenBinaryToolStripMenuItem.Name = "OpenBinaryToolStripMenuItem";
            this.OpenBinaryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.OpenBinaryToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.OpenBinaryToolStripMenuItem.Text = "Open (&Binary File)";
            this.OpenBinaryToolStripMenuItem.Click += new System.EventHandler(this.OpenBinaryToolStripMenuItem_Click);
            // 
            // SaveBinaryToolStripMenuItem
            // 
            this.SaveBinaryToolStripMenuItem.Name = "SaveBinaryToolStripMenuItem";
            this.SaveBinaryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.SaveBinaryToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.SaveBinaryToolStripMenuItem.Text = "Save (B&inary File)";
            this.SaveBinaryToolStripMenuItem.Click += new System.EventHandler(this.SaveBinaryToolStripMenuItem_Click);
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.ControlBox = false;
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ProductIdGroupBox);
            this.Controls.Add(this.ClickNextLabel);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.ProductInfoMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.ProductInfoMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Infomation";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.ProductInfoMenuStrip.ResumeLayout(false);
            this.ProductInfoMenuStrip.PerformLayout();
            this.ProductIdGroupBox.ResumeLayout(false);
            this.ProductIdGroupBox.PerformLayout();
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.TechSpecsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ProductInfoOpenFileDialog;
        private System.Windows.Forms.MenuStrip ProductInfoMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Label ClickNextLabel;
        private System.Windows.Forms.GroupBox ProductIdGroupBox;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUClassLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.Label ProductIdDataLabel;
        private System.Windows.Forms.Label CostDataLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label ManufacturerDataLabel;
        private System.Windows.Forms.Label ModelDataLabel;
        private System.Windows.Forms.Label OSDataLabel;
        private System.Windows.Forms.Label PlatformDataLabel;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.Label LCDSizeDataLabel;
        private System.Windows.Forms.Label MemoryDataLabel;
        private System.Windows.Forms.Label CPUSpeedDataLabel;
        private System.Windows.Forms.Label CPUClassDataLabel;
        private System.Windows.Forms.Label WebcamDataLabel;
        private System.Windows.Forms.Label GPUTypeDataLabel;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.OpenFileDialog ProductOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog ProductSaveFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OpenBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}