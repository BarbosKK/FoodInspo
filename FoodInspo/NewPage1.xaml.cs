namespace FoodInspo;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }
    
    async void OnCounterClicked_2(System.Object sender, System.EventArgs e)
    {
        // Viib tagasi alguse vaatele
        await Navigation.PushAsync(new MainPage());
    }

    private async void OnImageButtonClicked(object sender, EventArgs e)
    {

        // nupu ja pildi seos
        var button = sender as ImageButton;

        if (button != null && button.Source is FileImageSource fileImageSource)
        {
            // Kontrollime faili nime
            switch (fileImageSource.File)
            {
                case "main_page.png":
                    await Navigation.PushAsync(new Hommikusook());
                    break;

                case "main_page1.png":
                    await Navigation.PushAsync(new Hommikusook());
                    break;
                case "main_page2.png":
                    await Navigation.PushAsync(new Hommikusook());
                    break;
                case "main_page3.png":
                    await Navigation.PushAsync(new Hommikusook());
                    break;
                case "main_page4.png":
                    await Navigation.PushAsync(new Hommikusook());
                    break;
                case "main_page5.png":
                    await Navigation.PushAsync(new Hommikusook());
                    break;
                case "main_page6.png":
                    await Navigation.PushAsync(new Hommikusook());
                    break;
                default:
                        DisplayAlert("Nupp", "Suphoe", "OK");
                        break;
                }
            }
        }
    }
