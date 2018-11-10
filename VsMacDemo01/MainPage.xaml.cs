using Xamarin.Forms;
using VsMacDemo01.Services;

namespace VsMacDemo01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            using (var ds = new DataStoreService()){
                itemList.ItemsSource = ds.GetProducts();
            }
        }
    }
}
