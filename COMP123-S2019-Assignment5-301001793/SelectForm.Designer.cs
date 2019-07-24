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
            this.HardwareSelectionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HardwareSelectionLabel
            // 
            this.HardwareSelectionLabel.AutoSize = true;
            this.HardwareSelectionLabel.Location = new System.Drawing.Point(13, 13);
            this.HardwareSelectionLabel.Name = "HardwareSelectionLabel";
            this.HardwareSelectionLabel.Size = new System.Drawing.Size(147, 13);
            this.HardwareSelectionLabel.TabIndex = 0;
            this.HardwareSelectionLabel.Text = "DollarComputer Hardware List";
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HardwareSelectionLabel);
            this.Name = "SelectForm";
            this.Text = "SelectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HardwareSelectionLabel;
    }
}