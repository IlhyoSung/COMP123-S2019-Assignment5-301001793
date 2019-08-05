namespace COMP123_S2019_Assignment5_301001793
{
    partial class SelectForm
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
            this.DollarComputerSelectionLabel = new System.Windows.Forms.Label();
            this.SelectionListDataGridView = new System.Windows.Forms.DataGridView();
            this.dollarComputerDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dollarComputerDatabaseDataSet = new COMP123_S2019_Assignment5_301001793.DollarComputerDatabaseDataSet();
            this.YourSelectionLabel = new System.Windows.Forms.Label();
            this.YourSelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionListDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputerDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputerDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // DollarComputerSelectionLabel
            // 
            this.DollarComputerSelectionLabel.AutoSize = true;
            this.DollarComputerSelectionLabel.Location = new System.Drawing.Point(13, 9);
            this.DollarComputerSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DollarComputerSelectionLabel.Name = "DollarComputerSelectionLabel";
            this.DollarComputerSelectionLabel.Size = new System.Drawing.Size(198, 17);
            this.DollarComputerSelectionLabel.TabIndex = 0;
            this.DollarComputerSelectionLabel.Text = "Dollar Computer Selection List";
            // 
            // SelectionListDataGridView
            // 
            this.SelectionListDataGridView.AutoGenerateColumns = false;
            this.SelectionListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectionListDataGridView.DataSource = this.dollarComputerDatabaseDataSetBindingSource;
            this.SelectionListDataGridView.Location = new System.Drawing.Point(13, 30);
            this.SelectionListDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectionListDataGridView.Name = "SelectionListDataGridView";
            this.SelectionListDataGridView.Size = new System.Drawing.Size(758, 488);
            this.SelectionListDataGridView.TabIndex = 1;
            // 
            // dollarComputerDatabaseDataSetBindingSource
            // 
            this.dollarComputerDatabaseDataSetBindingSource.DataSource = this.dollarComputerDatabaseDataSet;
            this.dollarComputerDatabaseDataSetBindingSource.Position = 0;
            // 
            // dollarComputerDatabaseDataSet
            // 
            this.dollarComputerDatabaseDataSet.DataSetName = "DollarComputerDatabaseDataSet";
            this.dollarComputerDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // YourSelectionLabel
            // 
            this.YourSelectionLabel.AutoSize = true;
            this.YourSelectionLabel.Location = new System.Drawing.Point(13, 529);
            this.YourSelectionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YourSelectionLabel.Name = "YourSelectionLabel";
            this.YourSelectionLabel.Size = new System.Drawing.Size(100, 17);
            this.YourSelectionLabel.TabIndex = 2;
            this.YourSelectionLabel.Text = "Your Selection";
            // 
            // YourSelectionTextBox
            // 
            this.YourSelectionTextBox.Location = new System.Drawing.Point(121, 526);
            this.YourSelectionTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.YourSelectionTextBox.Name = "YourSelectionTextBox";
            this.YourSelectionTextBox.ReadOnly = true;
            this.YourSelectionTextBox.Size = new System.Drawing.Size(445, 23);
            this.YourSelectionTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(601, 525);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(84, 25);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(689, 525);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(84, 25);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.YourSelectionTextBox);
            this.Controls.Add(this.YourSelectionLabel);
            this.Controls.Add(this.SelectionListDataGridView);
            this.Controls.Add(this.DollarComputerSelectionLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            ((System.ComponentModel.ISupportInitialize)(this.SelectionListDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputerDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarComputerDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DollarComputerSelectionLabel;
        private System.Windows.Forms.DataGridView SelectionListDataGridView;
        private System.Windows.Forms.BindingSource dollarComputerDatabaseDataSetBindingSource;
        private DollarComputerDatabaseDataSet dollarComputerDatabaseDataSet;
        private System.Windows.Forms.Label YourSelectionLabel;
        private System.Windows.Forms.TextBox YourSelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}