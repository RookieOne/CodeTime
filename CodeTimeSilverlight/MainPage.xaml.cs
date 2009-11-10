using System.Windows;
using System.Windows.Controls;

namespace CodeTimeSilverlight
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void ManageProjects_Click(object sender, RoutedEventArgs e)
        {
            content.Content = new ProjectsView();
        }
    }
}