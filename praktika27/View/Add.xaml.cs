using System.Windows.Controls;

namespace praktika27.View
{
    public partial class Add : Page
    {
        public Add(object Context)
        {
            InitializeComponent();
            DataContext = new
            {
                item = Context,
                categorys = new ViewModell.VMCategorys()
            };
        }
    }
}
