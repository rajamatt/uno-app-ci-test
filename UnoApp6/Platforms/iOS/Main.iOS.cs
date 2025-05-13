using UIKit;
using Uno.UI.Hosting;
using UnoApp6;

var host = UnoPlatformHostBuilder.Create()
    .App(() => new App())
    .UseAppleUIKit()
    .Build();

host.Run();
