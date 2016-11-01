namespace YKAddressCalc
{
    using System.Windows;
    using YKAddressCalc.ViewModels;
    using YKAddressCalc.Views;

    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var w = new MainView() { DataContext = new MainViewModel() };
            w.Show();
        }
    }
}
