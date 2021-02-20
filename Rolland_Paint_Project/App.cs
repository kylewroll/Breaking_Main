/*Author: Kyle Rolland
 * Date: 2/20/2021
 * File: App.cs
 * Description: Hand made main function, calls New_Window when ran, instead of Main_Window
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rolland_Paint_Project
{
    public class App : System.Windows.Application
    {
        [STAThread]
        public static void Main()
        {
            App app = new App();
            app.StartupUri = new System.Uri("New_Window.xaml", System.UriKind.Relative);
            app.Run();
        }
    }
}
