#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif

using FoodInspo;

namespace FoodInspo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
            {
#if WINDOWS
                var mauiWindow = handler.VirtualView;
                var nativeWindow = handler.PlatformView;
                nativeWindow.Activate();
                IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
                WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
                AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
                
                // Seadista akna suurus
                appWindow.Resize(new SizeInt32(540, 900));

                // Seadista minimaalne ja maksimaalne akna suurus
                appWindow.Resize(new SizeInt32(
                    Math.Clamp(540, 400, 800),
                    Math.Clamp(900, 600, 1200)
                ));
#endif
            });

            MainPage = new NavigationPage(new MainPage());
        }
    }
}

