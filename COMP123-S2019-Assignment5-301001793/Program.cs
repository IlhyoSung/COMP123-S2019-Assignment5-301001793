﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment5_301001793
{
    static class Program
    {
        public static SplashScreen splashScreen;
        public static StartForm startForm;
        public static SelectForm selectForm;
        public static ProductInfoForm productInfoForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            splashScreen = new SplashScreen();
            startForm = new StartForm();
            selectForm = new SelectForm();
            productInfoForm = new ProductInfoForm();

            Application.Run(splashScreen);
        }
    }
}
