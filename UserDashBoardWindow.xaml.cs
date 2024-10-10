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

namespace PHTProject
{
    /// <summary>
    /// Interaction logic for UserDashBoardWindow.xaml
    /// </summary>
    public partial class UserDashBoardWindow : Window
    {
        public UserDashBoardWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnMetrixEntry_Click(object sender, RoutedEventArgs e)
        {
            PHTConfig.dailyHealthMetrixEntryWindow.Show();
        }

        private void btnHealthInsight_Click(object sender, RoutedEventArgs e)
        {
            PHTConfig.healthInsightWindow.Show();
        }

        private void btnHealthHistory_Click(object sender, RoutedEventArgs e)
        {
            PHTConfig.healthHistoryWindow.Show();
        }

        private void btnHealthGoals_Click(object sender, RoutedEventArgs e)
        {
            PHTConfig.healthGoalsWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PHTConfig.profileSettingsWindow.Show();
        }

        private void btnDeviceIntegration_Click(object sender, RoutedEventArgs e)
        {
            PHTConfig.deviceIntgrationWindow.Show();
        }
    }
}
