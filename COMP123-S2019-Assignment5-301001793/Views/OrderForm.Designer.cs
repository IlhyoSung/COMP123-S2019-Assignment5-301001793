namespace COMP123_S2019_Assignment5_301001793.Views
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.LCDSizelabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.OSLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUClassLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.PriceGroupBox = new System.Windows.Forms.GroupBox();
            this.TotalPriceLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.TotalLine = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FinishButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.PlatformDataLabel = new System.Windows.Forms.Label();
            this.ManufacturerDataLabel = new System.Windows.Forms.Label();
            this.ModelDataLabel = new System.Windows.Forms.Label();
            this.SpecsDataLabel = new System.Windows.Forms.Label();
            this.PriceDataLabel = new System.Windows.Forms.Label();
            this.SalesTaxDataLabel = new System.Windows.Forms.Label();
            this.TotalPriceDataLabel = new System.Windows.Forms.Label();
            this.ComputerPictureBox = new System.Windows.Forms.PictureBox();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormMenuStrip.SuspendLayout();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.OrderTableLayoutPanel.SuspendLayout();
            this.PriceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(784, 24);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem1.Text = "E&xit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // SystemComponentsGroupBox
            // 
            this.SystemComponentsGroupBox.Controls.Add(this.ModelDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionDataLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.OrderTableLayoutPanel);
            this.SystemComponentsGroupBox.Controls.Add(this.ModelLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ManufacturerLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.PlatformLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.ConditionLabel);
            this.SystemComponentsGroupBox.Controls.Add(this.SpecsDataLabel);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(15, 28);
            this.SystemComponentsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.SystemComponentsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(486, 520);
            this.SystemComponentsGroupBox.TabIndex = 1;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // OrderTableLayoutPanel
            // 
            this.OrderTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderTableLayoutPanel.ColumnCount = 1;
            this.OrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OrderTableLayoutPanel.Controls.Add(this.LCDSizelabel, 0, 0);
            this.OrderTableLayoutPanel.Controls.Add(this.WebcamLabel, 0, 8);
            this.OrderTableLayoutPanel.Controls.Add(this.MemoryLabel, 0, 1);
            this.OrderTableLayoutPanel.Controls.Add(this.GPUTypeLabel, 0, 7);
            this.OrderTableLayoutPanel.Controls.Add(this.OSLabel, 0, 9);
            this.OrderTableLayoutPanel.Controls.Add(this.HDDLabel, 0, 6);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUBrandLabel, 0, 2);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUClassLabel, 0, 5);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUTypeLabel, 0, 3);
            this.OrderTableLayoutPanel.Controls.Add(this.CPUSpeedLabel, 0, 4);
            this.OrderTableLayoutPanel.Location = new System.Drawing.Point(6, 113);
            this.OrderTableLayoutPanel.Name = "OrderTableLayoutPanel";
            this.OrderTableLayoutPanel.RowCount = 10;
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.OrderTableLayoutPanel.Size = new System.Drawing.Size(110, 400);
            this.OrderTableLayoutPanel.TabIndex = 21;
            // 
            // LCDSizelabel
            // 
            this.LCDSizelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCDSizelabel.Location = new System.Drawing.Point(3, 0);
            this.LCDSizelabel.Name = "LCDSizelabel";
            this.LCDSizelabel.Size = new System.Drawing.Size(104, 40);
            this.LCDSizelabel.TabIndex = 9;
            this.LCDSizelabel.Text = "LCD Size";
            this.LCDSizelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebcamLabel.Location = new System.Drawing.Point(3, 320);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(104, 40);
            this.WebcamLabel.TabIndex = 20;
            this.WebcamLabel.Text = "Webcam";
            this.WebcamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryLabel.Location = new System.Drawing.Point(3, 40);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(104, 40);
            this.MemoryLabel.TabIndex = 12;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUTypeLabel.Location = new System.Drawing.Point(3, 280);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(104, 40);
            this.GPUTypeLabel.TabIndex = 19;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OSLabel
            // 
            this.OSLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OSLabel.Location = new System.Drawing.Point(3, 360);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(104, 40);
            this.OSLabel.TabIndex = 13;
            this.OSLabel.Text = "OS";
            this.OSLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDLabel.Location = new System.Drawing.Point(3, 240);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(104, 40);
            this.HDDLabel.TabIndex = 18;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandLabel.Location = new System.Drawing.Point(3, 80);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(104, 40);
            this.CPUBrandLabel.TabIndex = 14;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUClassLabel
            // 
            this.CPUClassLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUClassLabel.Location = new System.Drawing.Point(3, 200);
            this.CPUClassLabel.Name = "CPUClassLabel";
            this.CPUClassLabel.Size = new System.Drawing.Size(104, 40);
            this.CPUClassLabel.TabIndex = 17;
            this.CPUClassLabel.Text = "CPU Class";
            this.CPUClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTypeLabel.Location = new System.Drawing.Point(3, 120);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(104, 40);
            this.CPUTypeLabel.TabIndex = 15;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSpeedLabel.Location = new System.Drawing.Point(3, 160);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(104, 40);
            this.CPUSpeedLabel.TabIndex = 16;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(287, 69);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(52, 20);
            this.ModelLabel.TabIndex = 6;
            this.ModelLabel.Text = "Model";
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(12, 69);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(104, 20);
            this.ManufacturerLabel.TabIndex = 4;
            this.ManufacturerLabel.Text = "Manufacturer";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(271, 32);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(68, 20);
            this.PlatformLabel.TabIndex = 2;
            this.PlatformLabel.Text = "Platform";
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(40, 32);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(76, 20);
            this.ConditionLabel.TabIndex = 0;
            this.ConditionLabel.Text = "Condition";
            // 
            // PriceGroupBox
            // 
            this.PriceGroupBox.Controls.Add(this.TotalPriceDataLabel);
            this.PriceGroupBox.Controls.Add(this.SalesTaxDataLabel);
            this.PriceGroupBox.Controls.Add(this.PriceDataLabel);
            this.PriceGroupBox.Controls.Add(this.TotalPriceLabel);
            this.PriceGroupBox.Controls.Add(this.SalesTaxLabel);
            this.PriceGroupBox.Controls.Add(this.PriceLabel);
            this.PriceGroupBox.Controls.Add(this.shapeContainer1);
            this.PriceGroupBox.Location = new System.Drawing.Point(507, 329);
            this.PriceGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceGroupBox.Name = "PriceGroupBox";
            this.PriceGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PriceGroupBox.Size = new System.Drawing.Size(265, 180);
            this.PriceGroupBox.TabIndex = 3;
            this.PriceGroupBox.TabStop = false;
            this.PriceGroupBox.Text = "Your Price";
            // 
            // TotalPriceLabel
            // 
            this.TotalPriceLabel.AutoSize = true;
            this.TotalPriceLabel.Location = new System.Drawing.Point(7, 129);
            this.TotalPriceLabel.Name = "TotalPriceLabel";
            this.TotalPriceLabel.Size = new System.Drawing.Size(44, 20);
            this.TotalPriceLabel.TabIndex = 4;
            this.TotalPriceLabel.Text = "Total";
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(7, 68);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(124, 20);
            this.SalesTaxLabel.TabIndex = 2;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(7, 31);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 20);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "Price";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 23);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.TotalLine});
            this.shapeContainer1.Size = new System.Drawing.Size(259, 153);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // TotalLine
            // 
            this.TotalLine.BorderWidth = 3;
            this.TotalLine.Name = "TotalLine";
            this.TotalLine.X1 = 7;
            this.TotalLine.X2 = 249;
            this.TotalLine.Y1 = 84;
            this.TotalLine.Y2 = 84;
            // 
            // FinishButton
            // 
            this.FinishButton.Location = new System.Drawing.Point(689, 517);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(83, 31);
            this.FinishButton.TabIndex = 4;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(600, 517);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(83, 31);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(511, 517);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(83, 31);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.BackColor = System.Drawing.Color.White;
            this.ConditionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionDataLabel.Location = new System.Drawing.Point(122, 31);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(134, 26);
            this.ConditionDataLabel.TabIndex = 22;
            // 
            // PlatformDataLabel
            // 
            this.PlatformDataLabel.BackColor = System.Drawing.Color.White;
            this.PlatformDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlatformDataLabel.Location = new System.Drawing.Point(346, 31);
            this.PlatformDataLabel.Name = "PlatformDataLabel";
            this.PlatformDataLabel.Size = new System.Drawing.Size(134, 26);
            this.PlatformDataLabel.TabIndex = 23;
            // 
            // ManufacturerDataLabel
            // 
            this.ManufacturerDataLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturerDataLabel.Location = new System.Drawing.Point(122, 67);
            this.ManufacturerDataLabel.Name = "ManufacturerDataLabel";
            this.ManufacturerDataLabel.Size = new System.Drawing.Size(134, 26);
            this.ManufacturerDataLabel.TabIndex = 24;
            // 
            // ModelDataLabel
            // 
            this.ModelDataLabel.BackColor = System.Drawing.Color.White;
            this.ModelDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelDataLabel.Location = new System.Drawing.Point(346, 67);
            this.ModelDataLabel.Name = "ModelDataLabel";
            this.ModelDataLabel.Size = new System.Drawing.Size(134, 26);
            this.ModelDataLabel.TabIndex = 25;
            // 
            // SpecsDataLabel
            // 
            this.SpecsDataLabel.BackColor = System.Drawing.Color.White;
            this.SpecsDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpecsDataLabel.Location = new System.Drawing.Point(122, 120);
            this.SpecsDataLabel.Name = "SpecsDataLabel";
            this.SpecsDataLabel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.SpecsDataLabel.Size = new System.Drawing.Size(358, 392);
            this.SpecsDataLabel.TabIndex = 26;
            // 
            // PriceDataLabel
            // 
            this.PriceDataLabel.BackColor = System.Drawing.Color.White;
            this.PriceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceDataLabel.Location = new System.Drawing.Point(137, 30);
            this.PriceDataLabel.Name = "PriceDataLabel";
            this.PriceDataLabel.Size = new System.Drawing.Size(117, 26);
            this.PriceDataLabel.TabIndex = 27;
            // 
            // SalesTaxDataLabel
            // 
            this.SalesTaxDataLabel.BackColor = System.Drawing.Color.White;
            this.SalesTaxDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesTaxDataLabel.Location = new System.Drawing.Point(137, 67);
            this.SalesTaxDataLabel.Name = "SalesTaxDataLabel";
            this.SalesTaxDataLabel.Size = new System.Drawing.Size(117, 26);
            this.SalesTaxDataLabel.TabIndex = 28;
            // 
            // TotalPriceDataLabel
            // 
            this.TotalPriceDataLabel.BackColor = System.Drawing.Color.White;
            this.TotalPriceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalPriceDataLabel.Location = new System.Drawing.Point(137, 128);
            this.TotalPriceDataLabel.Name = "TotalPriceDataLabel";
            this.TotalPriceDataLabel.Size = new System.Drawing.Size(117, 26);
            this.TotalPriceDataLabel.TabIndex = 29;
            // 
            // ComputerPictureBox
            // 
            this.ComputerPictureBox.Image = global::COMP123_S2019_Assignment5_301001793.Properties.Resources.computerHardwareImage;
            this.ComputerPictureBox.Location = new System.Drawing.Point(507, 28);
            this.ComputerPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComputerPictureBox.Name = "ComputerPictureBox";
            this.ComputerPictureBox.Size = new System.Drawing.Size(265, 180);
            this.ComputerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ComputerPictureBox.TabIndex = 2;
            this.ComputerPictureBox.TabStop = false;
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.FinishButton);
            this.Controls.Add(this.PriceGroupBox);
            this.Controls.Add(this.ComputerPictureBox);
            this.Controls.Add(this.SystemComponentsGroupBox);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(560, 220);
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complete Your Order";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemComponentsGroupBox.PerformLayout();
            this.OrderTableLayoutPanel.ResumeLayout(false);
            this.PriceGroupBox.ResumeLayout(false);
            this.PriceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComputerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUClassLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label LCDSizelabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.PictureBox ComputerPictureBox;
        private System.Windows.Forms.GroupBox PriceGroupBox;
        private System.Windows.Forms.Label TotalPriceLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button FinishButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel OrderTableLayoutPanel;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape TotalLine;
        private System.Windows.Forms.Label ModelDataLabel;
        private System.Windows.Forms.Label ManufacturerDataLabel;
        private System.Windows.Forms.Label PlatformDataLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.Label SpecsDataLabel;
        private System.Windows.Forms.Label TotalPriceDataLabel;
        private System.Windows.Forms.Label SalesTaxDataLabel;
        private System.Windows.Forms.Label PriceDataLabel;
    }
}