using ClassIsland.Core;
using ClassIsland.Core.Abstractions;
using ClassIsland.Core.Abstractions.Services;
using ClassIsland.Core.Attributes;
using ClassIsland.Core.Controls;
using ClassIsland.Shared;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace RainyBird
{
    [PluginEntrance]
    public class Plugin : PluginBase
    {
        public override void Initialize(HostBuilderContext context, IServiceCollection services)
        {
            // 注释示例 (Hello World 对话框)
            /*AppBase.Current.AppStarted += async (_, _) =>
                await CommonTaskDialogs.ShowDialog("Hello world!", "Hello from RainyBird!");*/
        }
    }
}