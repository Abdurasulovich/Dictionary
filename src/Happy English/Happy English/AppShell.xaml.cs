using Happy_English.Pages;
using Happy_English.ViewModels;

namespace Happy_English
{
    public partial class AppShell : Shell
    {
        private AppShellViewModel _viewmodel;
        public AppShell(AppShellViewModel viewmodel)
        {
            InitializeComponent();
            this.BindingContext = _viewmodel = viewmodel;
            this.Navigated += OnNavigated;
            Routing.RegisterRoute(Routes.Dashboard, typeof(Dashboard));
            Routing.RegisterRoute(Routes.AddWord, typeof(AddWord));
            Routing.RegisterRoute(Routes.Quiz, typeof(Quiz));
            Routing.RegisterRoute(Routes.QuizStart, typeof(QuizStart));
            Routing.RegisterRoute(Routes.QuizResult, typeof(QuizResult));
            Routing.RegisterRoute(Routes.Translate, typeof(Translate));
            Routing.RegisterRoute(Routes.TranslateSaved, typeof(TranslateSaved));
        }
        //public void OnTabSelected(string tabName)
        //{
        //    _viewmodel.SelectedTab = tabName;
        //}

        private void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {
            // Get the currently selected tab based on the route or location
            var selectedTab = e.Current.Location.OriginalString.Split('/').Last();

            // Update icons based on the selected tab
            _viewmodel.UpdateIcons(selectedTab);
        }
    }
}
