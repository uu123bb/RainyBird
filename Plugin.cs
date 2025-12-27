using ClassIsland.Core;
using ClassIsland.Core.Abstractions;
using ClassIsland.Core.Abstractions.Services;
using ClassIsland.Core.Attributes;
using ClassIsland.Core.Controls;
using ClassIsland.Shared;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace RainyBird
{
    [PluginEntrance]
    public class Plugin : PluginBase
    {
        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {
            var UriServiceReg = IAppHost.GetService<IUriNavigationService>();
            UriServiceReg.HandlePluginsNavigation(
                "rainybird/hello",
                async args =>
                {
                    await CommonTaskDialogs.ShowDialog("Hello world!", "Hello from RainyBird!");
                }
            );

            // 注释示例 (Hello World 对话框)
            /*AppBase.Current.AppStarted += async (_, _) =>
                await CommonTaskDialogs.ShowDialog("Hello world!", "Hello from RainyBird!");*/
        }
    }
}