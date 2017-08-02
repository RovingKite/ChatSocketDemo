﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSocketDemo
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login __frmLogin = new Login();
            if (__frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new ChatClient(__frmLogin.p_user));
            }
        }
    }
}
