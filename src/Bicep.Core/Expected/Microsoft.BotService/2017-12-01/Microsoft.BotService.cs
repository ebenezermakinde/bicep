// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_BotService_2017_12_01
    {
        private const string ProviderNamespace = "Microsoft.BotService";
        private const string ApiVersion = "2017-12-01";
        private static readonly ResourceTypeReference ResourceTypeReference_botServices = new ResourceTypeReference(ProviderNamespace, new[]{"botServices"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_botServices_channels = new ResourceTypeReference(ProviderNamespace, new[]{"botServices", "channels"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_botServices_Connections = new ResourceTypeReference(ProviderNamespace, new[]{"botServices", "Connections"}, ApiVersion);
        private static Lazy<Microsoft_BotService_2017_12_01> InstanceLazy = new Lazy<Microsoft_BotService_2017_12_01>(() => new Microsoft_BotService_2017_12_01());
        private Microsoft_BotService_2017_12_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            BotProperties = new NamedObjectType("BotProperties", new ITypeProperty[]{new TypeProperty("displayName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("iconUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("endpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("msaAppId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("developerAppInsightKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("developerAppInsightsApiKey", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("developerAppInsightsApplicationId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("luisAppIds", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("luisKey", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Channel = new NamedObjectType("Channel", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            FacebookChannel = new NamedObjectType("FacebookChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => FacebookChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            FacebookChannelProperties = new NamedObjectType("FacebookChannelProperties", new ITypeProperty[]{new TypeProperty("pages", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("appId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("appSecret", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            FacebookPage = new NamedObjectType("FacebookPage", new ITypeProperty[]{new TypeProperty("id", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accessToken", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EmailChannel = new NamedObjectType("EmailChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => EmailChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            EmailChannelProperties = new NamedObjectType("EmailChannelProperties", new ITypeProperty[]{new TypeProperty("emailAddress", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("password", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            MsTeamsChannel = new NamedObjectType("MsTeamsChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => MsTeamsChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            MsTeamsChannelProperties = new NamedObjectType("MsTeamsChannelProperties", new ITypeProperty[]{new TypeProperty("enableMessaging", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableMediaCards", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableVideo", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableCalling", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("callMode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SkypeChannel = new NamedObjectType("SkypeChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => SkypeChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SkypeChannelProperties = new NamedObjectType("SkypeChannelProperties", new ITypeProperty[]{new TypeProperty("enableMessaging", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableMediaCards", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableVideo", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableCalling", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableScreenSharing", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("enableGroups", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("groupsMode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("callingWebHook", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KikChannel = new NamedObjectType("KikChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => KikChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            KikChannelProperties = new NamedObjectType("KikChannelProperties", new ITypeProperty[]{new TypeProperty("userName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("apiKey", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isValidated", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            WebChatChannel = new NamedObjectType("WebChatChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => WebChatChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            WebChatChannelProperties = new NamedObjectType("WebChatChannelProperties", new ITypeProperty[]{new TypeProperty("sites", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            WebChatSite = new NamedObjectType("WebChatSite", new ITypeProperty[]{new TypeProperty("siteName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("enablePreview", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DirectLineChannel = new NamedObjectType("DirectLineChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => DirectLineChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DirectLineChannelProperties = new NamedObjectType("DirectLineChannelProperties", new ITypeProperty[]{new TypeProperty("sites", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DirectLineSite = new NamedObjectType("DirectLineSite", new ITypeProperty[]{new TypeProperty("siteName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("isV1Enabled", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("isV3Enabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            TelegramChannel = new NamedObjectType("TelegramChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => TelegramChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            TelegramChannelProperties = new NamedObjectType("TelegramChannelProperties", new ITypeProperty[]{new TypeProperty("accessToken", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isValidated", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SmsChannel = new NamedObjectType("SmsChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => SmsChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SmsChannelProperties = new NamedObjectType("SmsChannelProperties", new ITypeProperty[]{new TypeProperty("phone", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accountSID", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("authToken", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("isValidated", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SlackChannel = new NamedObjectType("SlackChannel", new ITypeProperty[]{new LazyTypeProperty("properties", () => SlackChannelProperties, TypePropertyFlags.None), new TypeProperty("channelName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SlackChannelProperties = new NamedObjectType("SlackChannelProperties", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("clientSecret", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("verificationToken", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("landingPageUrl", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("isEnabled", LanguageConstants.Bool, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ConnectionSettingProperties = new NamedObjectType("ConnectionSettingProperties", new ITypeProperty[]{new TypeProperty("clientId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientSecret", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("scopes", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceProviderId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceProviderDisplayName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("parameters", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ConnectionSettingParameter = new NamedObjectType("ConnectionSettingParameter", new ITypeProperty[]{new TypeProperty("key", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ResourceType_botServices = new ResourceType("Microsoft.BotService/botServices", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => BotProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_botServices);
            ResourceType_botServices_channels = new ResourceType("Microsoft.BotService/botServices/channels", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => Channel, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_botServices_channels);
            ResourceType_botServices_Connections = new ResourceType("Microsoft.BotService/botServices/Connections", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ConnectionSettingProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_botServices_Connections);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_botServices, () => InstanceLazy.Value.ResourceType_botServices);
            registrar.RegisterType(ResourceTypeReference_botServices_channels, () => InstanceLazy.Value.ResourceType_botServices_channels);
            registrar.RegisterType(ResourceTypeReference_botServices_Connections, () => InstanceLazy.Value.ResourceType_botServices_Connections);
        }
        private readonly ResourceType ResourceType_botServices;
        private readonly ResourceType ResourceType_botServices_channels;
        private readonly ResourceType ResourceType_botServices_Connections;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol BotProperties;
        private readonly TypeSymbol Channel;
        private readonly TypeSymbol FacebookChannel;
        private readonly TypeSymbol FacebookChannelProperties;
        private readonly TypeSymbol FacebookPage;
        private readonly TypeSymbol EmailChannel;
        private readonly TypeSymbol EmailChannelProperties;
        private readonly TypeSymbol MsTeamsChannel;
        private readonly TypeSymbol MsTeamsChannelProperties;
        private readonly TypeSymbol SkypeChannel;
        private readonly TypeSymbol SkypeChannelProperties;
        private readonly TypeSymbol KikChannel;
        private readonly TypeSymbol KikChannelProperties;
        private readonly TypeSymbol WebChatChannel;
        private readonly TypeSymbol WebChatChannelProperties;
        private readonly TypeSymbol WebChatSite;
        private readonly TypeSymbol DirectLineChannel;
        private readonly TypeSymbol DirectLineChannelProperties;
        private readonly TypeSymbol DirectLineSite;
        private readonly TypeSymbol TelegramChannel;
        private readonly TypeSymbol TelegramChannelProperties;
        private readonly TypeSymbol SmsChannel;
        private readonly TypeSymbol SmsChannelProperties;
        private readonly TypeSymbol SlackChannel;
        private readonly TypeSymbol SlackChannelProperties;
        private readonly TypeSymbol ConnectionSettingProperties;
        private readonly TypeSymbol ConnectionSettingParameter;
    }
}
