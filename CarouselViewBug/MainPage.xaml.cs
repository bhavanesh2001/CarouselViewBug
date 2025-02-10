
using System.Reflection;

namespace CarouselViewBug
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
           
            
        }

     


        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var pickMedia = new PickOptions
            {
                PickerTitle = "",
                FileTypes = FilePickerFileType.Jpeg
            };
            var res = await FilePicker.PickMultipleAsync(pickMedia);
            caroselView.ItemsSource = res;
        }
       
    }

}
