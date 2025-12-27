using ClassIsland.Core;
using ClassIsland.Core.Abstractions;
using ClassIsland.Core.Abstractions.Services;
using ClassIsland.Core.Attributes;
using ClassIsland.Core.Controls;
using ClassIsland.Core.Extensions.Registry;
using ClassIsland.Shared;
using ClassIsland.Shared.Interfaces;
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
            services.AddNotificationProvider<MyNotificationProvider>(); // 注册自定义提醒提供方
            var UriServiceReg = IAppHost.GetService<IUriNavigationService>(); // 获取 Uri 导航服务
            UriServiceReg.HandlePluginsNavigation( // 注册插件主机 Uri 服务
                "rainybird/hello", // Uri 路径 (Hello World)
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