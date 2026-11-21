using praktika27.ViewModell;
using System.Windows.Controls;

namespace praktika27.View
{
    public partial class Main : Page
    {
        public Main()
        {
            InitializeComponent();
            DataContext = new VMItems();
        }
    }
}
