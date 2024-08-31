using Happy_English.ViewModels;

namespace Happy_English
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var viewModel = new AppShellViewModel();
            MainPage = new AppShell(viewModel);
        }
    }
}
