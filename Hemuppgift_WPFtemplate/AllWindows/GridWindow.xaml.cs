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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void btn_Apply_Click(object sender, RoutedEventArgs e)
        {
            int column = Convert.ToInt32(columnInput.Text);
            int row = Convert.ToInt32(rowInput.Text);
            bool columnCheck = false;
            bool rowCheck = false;

            // Checking if the input is between 0-4
            if (column >= 0 && column < 5)
            {
                columnCheck = true;
                if (row >= 0 && row < 5)
                {
                    rowCheck = true;
                }
                else
                {
                    MessageBox.Show("Please type a number between 0-4", "Row",
                        MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                    rowInput.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please type a number between 0-4", "Column",
                    MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                columnInput.Clear();
            }
            columnInput.Clear();
            rowInput.Clear();
            rowInput.Focus();

            // Creation of the button
            if (rowCheck && columnCheck)
            {
                Button newButton = new Button();
                // Properties, placement and adding to grid
                newButton.Content = $"Row {row}, Column {column} \n (ClearMe)";
                newButton.Background = Brushes.DarkTurquoise;
                Grid.SetColumn(newButton, column);
                Grid.SetRow(newButton, row + 1);
                GridWindowGrid.Children.Add(newButton);
                // Click handler to clear
                newButton.Click += NewButton_Click;
            }
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            // Sending the value that button was clicked and removes the clicked button
            Button clickedButton = (Button)sender;
            GridWindowGrid.Children.Remove(clickedButton);
            rowInput.Focus();
        }
    }
}
