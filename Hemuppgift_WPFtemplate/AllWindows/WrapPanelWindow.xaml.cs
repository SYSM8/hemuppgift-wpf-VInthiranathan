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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate.AllWindows
{
    /// <summary>
    /// Interaction logic for WrapPanelWindow.xaml
    /// </summary>
    public partial class WrapPanelWindow : Window
    {
        public WrapPanelWindow()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void rad_Vertical_Checked(object sender, RoutedEventArgs e)
        {
            //Checking if radiobutton is checked, and change orientation
            if (rad_Vertical.IsChecked == true)
            {
                myPanel.Orientation = Orientation.Vertical;
            }
        }

        private void rad_Horizontal_Checked(object sender, RoutedEventArgs e)
        {
            //Checking if radiobutton is checked, and change orientation
            if (rad_Horizontal.IsChecked == true)
            {
                myPanel.Orientation = Orientation.Horizontal;
            }
        }

        private void btn_info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Use me (WrapPanel) when you want the layout to be more flexible," +
                " I will automatically wrap elements to a new row or column when there isn’t enough space, " +
                "ensuring no content is clipped.", "About me", MessageBoxButton.OKCancel);
        }
    }
}
