using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Student Name: Ilhyo Sung
 * Student ID: 301001793
 * Description: This is SplashScreen Form
 */

namespace COMP123_S2019_Assignment5_301001793.Views
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is event handler for SplashScreen Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            // SplashTimer on
            SplashTimer.Enabled = true;
        }

        /// <summary>
        /// This is event handler for SplashTimer Tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            // when interval is over, SplashTimer off
            SplashTimer.Enabled = false;

            // show StartForm and hide SplashScreen
            Program.Forms[FormName.START_FORM].Show();
            this.Hide();
        }
    }
}
