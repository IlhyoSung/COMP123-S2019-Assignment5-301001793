namespace COMP123_S2019_Assignment5_301001793.Views
{
    partial class StartForm
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
            this.StartButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartPictureBox = new System.Windows.Forms.PictureBox();
            this.ProductOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.StartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(64, 222);
            this.StartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(158, 35);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start a new order";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(64, 267);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(158, 35);
            this.LoadButton.TabIndex = 1;
            this.LoadButton.Text = "Load a saved order";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(64, 312);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(158, 35);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartPictureBox
            // 
            this.StartPictureBox.Image = global::COMP123_S2019_Assignment5_301001793.Properties.Resources.dollarcomputer;
            this.StartPictureBox.Location = new System.Drawing.Point(13, 14);
            this.StartPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartPictureBox.Name = "StartPictureBox";
            this.StartPictureBox.Size = new System.Drawing.Size(258, 198);
            this.StartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartPictureBox.TabIndex = 3;
            this.StartPictureBox.TabStop = false;
            // 
            // ProductOpenFileDialog
            // 
            this.ProductOpenFileDialog.FileName = "openFileDialog1";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.ControlBox = false;
            this.Controls.Add(this.StartPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dollar Computer";
            ((System.ComponentModel.ISupportInitialize)(this.StartPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox StartPictureBox;
        private System.Windows.Forms.OpenFileDialog ProductOpenFileDialog;
    }
}

