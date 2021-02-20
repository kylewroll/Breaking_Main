/* Author: Kyle Rolland
 * Date: 2/10/2021
 * File: MainWindow.xaml.cs
 * Description: Implementation file for the various functions provided by the drawing application
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Rolland_Paint_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        //Changes brush color to black
        private void BLACK_Click(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.Black;
        }

        //Clears out any lines made by user
        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            Canvas.Strokes.Clear();
        }

        //Changes brush color to red
        private void RED_Click(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.Red;
        }
        
        //Changes brush color to blue
        private void BLUE_Click(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.Blue;
        }

        //Changes brush color to green
        private void GREEN_Click(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Color = Colors.Green;
        }



        //Changes brush size back to default
        private void DEF_BRUSH_Click(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Width = 1;
            Canvas.DefaultDrawingAttributes.Height = 1;
        }

        //Changes brush to a large circle
        private void LARGE_BRUSH_Click(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Width = 20;
            Canvas.DefaultDrawingAttributes.Height = 20;
        }

        //Changes brush to have large width
        private void WIDE_BRUSH_Click(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Width = 20;
        }

        //Changes brush to have large height
        private void NARROW_BRUSH_Click(object sender, RoutedEventArgs e)
        {
            Canvas.DefaultDrawingAttributes.Height = 20;
        }
    }
}
