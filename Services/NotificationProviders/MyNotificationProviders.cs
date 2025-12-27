using ClassIsland.Core.Abstractions.Services;
using ClassIsland.Core.Abstractions.Services.NotificationProviders;
using ClassIsland.Core.Attributes;
using ClassIsland.Shared.Interfaces;
using Microsoft.Extensions.Hosting;

namespace RainyBird.Services.NotificationProviders;

[NotificationProviderInfo("DD3BC389-BEA9-40B7-912B-C7C37390A101", "示例提醒提供方", "提醒提供方说明")]
public class MyNotificationSettings : NotificationProviderBase
{

}