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

namespace _03ToDoList
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

        private void addToListBox(string item)
        {
            lbxTasks.Items.Add(item);
            txbInput.Text = "";
            btnButton_Add.IsEnabled = false;
        }

        private void txbInput_KeyDown(object sender, KeyEventArgs e)
        {
            btnButton_Add.IsEnabled = true;
            if (e.Key == Key.Enter)
            {
                addToListBox(txbInput.Text);
            }
        }
        private void btnButton_Add_Click(object sender, RoutedEventArgs e)
        {
            addToListBox(txbInput.Text);
        }

        private void btnButton_Delete_Click(object sender, RoutedEventArgs e)
        {
            lbxTasks.Items.Remove(lbxTasks.SelectedItem);
            btnButton_Delete.IsEnabled = false;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            btnButton_Delete.IsEnabled = true;
        }
    }
}
