using System;
using System.Windows.Forms;
using RestaurantManagementSystem.UI;

namespace RestaurantManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Replace with your startup form
            Application.Run(new LoginPage());
        }
    }
}

