namespace DealerManaging
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Home), typeof(Home));  
            Routing.RegisterRoute(nameof(AddDealer), typeof(AddDealer));    
        }
    }
}
