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

namespace MyWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int index = 0;
        private bool isClick = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void yesClick(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("亲亲抱抱举高高~", "爱你的Peter~", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.Yes)
            {
                isClick = true;
                Application.Current.Shutdown();
            }
            else
            {
                isClick = true;
                Application.Current.Shutdown();
            }
           
        }

        private void noCLick(object sender, RoutedEventArgs e)
        {
            if (index % 4 == 0)
            {
                index++;
                MessageBox.Show("给你买包包~", "爱你的Peter~", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (index % 4 == 1)
            {
                index++;
                MessageBox.Show("带你去旅行~", "爱你的Peter~", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (index % 4 == 2)
            {
                index++;
                MessageBox.Show("天天陪着你~", "爱你的Peter~", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else if (index % 4 == 3)
            {
                index++;
                MessageBox.Show("我们一起生宝宝~", "爱你的Peter~", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(isClick)
            {
                e.Cancel = false;
            } else{
                var result = MessageBox.Show("快答应我嘛~~", "么么哒", MessageBoxButton.OK);
                if (result != MessageBoxResult.Yes)
                {
                    e.Cancel = true;
                }

                // OR, if triggering dialog via view-model:

                e.Cancel = true;
            }

        }
    }
}
