// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_DataBoxEdge_2019_03_01
    {
        private const string ProviderNamespace = "Microsoft.DataBoxEdge";
        private const string ApiVersion = "2019-03-01";
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_bandwidthSchedules = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "bandwidthSchedules"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_orders = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "orders"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_roles = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "roles"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_shares = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "shares"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_storageAccountCredentials = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "storageAccountCredentials"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_triggers = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "triggers"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_dataBoxEdgeDevices_users = new ResourceTypeReference(ProviderNamespace, new[]{"dataBoxEdgeDevices", "users"}, ApiVersion);
        private static Lazy<Microsoft_DataBoxEdge_2019_03_01> InstanceLazy = new Lazy<Microsoft_DataBoxEdge_2019_03_01>(() => new Microsoft_DataBoxEdge_2019_03_01());
        private Microsoft_DataBoxEdge_2019_03_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tier", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            DataBoxEdgeDeviceProperties = new NamedObjectType("DataBoxEdgeDeviceProperties", new ITypeProperty[]{new TypeProperty("dataBoxEdgeDeviceStatus", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("modelDescription", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("friendlyName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            BandwidthScheduleProperties = new NamedObjectType("BandwidthScheduleProperties", new ITypeProperty[]{new TypeProperty("start", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("stop", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("rateInMbps", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("days", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            OrderProperties = new NamedObjectType("OrderProperties", new ITypeProperty[]{new LazyTypeProperty("contactInformation", () => ContactDetails, TypePropertyFlags.Required), new LazyTypeProperty("shippingAddress", () => Address, TypePropertyFlags.Required), new LazyTypeProperty("currentStatus", () => OrderStatus, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ContactDetails = new NamedObjectType("ContactDetails", new ITypeProperty[]{new TypeProperty("contactPerson", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("companyName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("phone", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("emailList", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            Address = new NamedObjectType("Address", new ITypeProperty[]{new TypeProperty("addressLine1", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("addressLine2", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("addressLine3", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("postalCode", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("city", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("state", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("country", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            OrderStatus = new NamedObjectType("OrderStatus", new ITypeProperty[]{new TypeProperty("status", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("comments", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            IoTRole = new NamedObjectType("IoTRole", new ITypeProperty[]{new LazyTypeProperty("properties", () => IoTRoleProperties, TypePropertyFlags.None), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            IoTRoleProperties = new NamedObjectType("IoTRoleProperties", new ITypeProperty[]{new TypeProperty("hostPlatform", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("ioTDeviceDetails", () => IoTDeviceInfo, TypePropertyFlags.Required), new LazyTypeProperty("ioTEdgeDeviceDetails", () => IoTDeviceInfo, TypePropertyFlags.Required), new TypeProperty("shareMappings", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("roleStatus", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            IoTDeviceInfo = new NamedObjectType("IoTDeviceInfo", new ITypeProperty[]{new TypeProperty("deviceId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("ioTHostHub", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("authentication", () => Authentication, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            Authentication = new NamedObjectType("Authentication", new ITypeProperty[]{new LazyTypeProperty("symmetricKey", () => SymmetricKey, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            SymmetricKey = new NamedObjectType("SymmetricKey", new ITypeProperty[]{new LazyTypeProperty("connectionString", () => AsymmetricEncryptedSecret, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AsymmetricEncryptedSecret = new NamedObjectType("AsymmetricEncryptedSecret", new ITypeProperty[]{new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("encryptionCertThumbprint", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("encryptionAlgorithm", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            MountPointMap = new NamedObjectType("MountPointMap", new ITypeProperty[]{new TypeProperty("shareId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ShareProperties = new NamedObjectType("ShareProperties", new ITypeProperty[]{new TypeProperty("description", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("shareStatus", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("monitoringStatus", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("azureContainerInfo", () => AzureContainerInfo, TypePropertyFlags.None), new TypeProperty("accessProtocol", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("userAccessRights", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("clientAccessRights", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("refreshDetails", () => RefreshDetails, TypePropertyFlags.None), new TypeProperty("dataPolicy", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AzureContainerInfo = new NamedObjectType("AzureContainerInfo", new ITypeProperty[]{new TypeProperty("storageAccountCredentialId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("containerName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("dataFormat", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            UserAccessRight = new NamedObjectType("UserAccessRight", new ITypeProperty[]{new TypeProperty("userId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accessType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ClientAccessRight = new NamedObjectType("ClientAccessRight", new ITypeProperty[]{new TypeProperty("client", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accessPermission", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            RefreshDetails = new NamedObjectType("RefreshDetails", new ITypeProperty[]{new TypeProperty("inProgressRefreshJobId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastCompletedRefreshJobTimeInUTC", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("errorManifestFile", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("lastJob", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            StorageAccountCredentialProperties = new NamedObjectType("StorageAccountCredentialProperties", new ITypeProperty[]{new TypeProperty("alias", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("userName", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("accountKey", () => AsymmetricEncryptedSecret, TypePropertyFlags.None), new TypeProperty("connectionString", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("sslStatus", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("blobDomainName", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("accountType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            FileEventTrigger = new NamedObjectType("FileEventTrigger", new ITypeProperty[]{new LazyTypeProperty("properties", () => FileTriggerProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            FileTriggerProperties = new NamedObjectType("FileTriggerProperties", new ITypeProperty[]{new LazyTypeProperty("sourceInfo", () => FileSourceInfo, TypePropertyFlags.Required), new LazyTypeProperty("sinkInfo", () => RoleSinkInfo, TypePropertyFlags.Required), new TypeProperty("customContextTag", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            FileSourceInfo = new NamedObjectType("FileSourceInfo", new ITypeProperty[]{new TypeProperty("shareId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            RoleSinkInfo = new NamedObjectType("RoleSinkInfo", new ITypeProperty[]{new TypeProperty("roleId", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            PeriodicTimerEventTrigger = new NamedObjectType("PeriodicTimerEventTrigger", new ITypeProperty[]{new LazyTypeProperty("properties", () => PeriodicTimerProperties, TypePropertyFlags.Required), new TypeProperty("kind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            PeriodicTimerProperties = new NamedObjectType("PeriodicTimerProperties", new ITypeProperty[]{new LazyTypeProperty("sourceInfo", () => PeriodicTimerSourceInfo, TypePropertyFlags.Required), new LazyTypeProperty("sinkInfo", () => RoleSinkInfo, TypePropertyFlags.Required), new TypeProperty("customContextTag", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            PeriodicTimerSourceInfo = new NamedObjectType("PeriodicTimerSourceInfo", new ITypeProperty[]{new TypeProperty("startTime", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("schedule", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("topic", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            UserProperties = new NamedObjectType("UserProperties", new ITypeProperty[]{new LazyTypeProperty("encryptedPassword", () => AsymmetricEncryptedSecret, TypePropertyFlags.None), new TypeProperty("shareAccessRights", LanguageConstants.Array, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ShareAccessRight = new NamedObjectType("ShareAccessRight", new ITypeProperty[]{new TypeProperty("shareId", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accessType", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_dataBoxEdgeDevices = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.None), new TypeProperty("etag", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("properties", () => DataBoxEdgeDeviceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices);
            ResourceType_dataBoxEdgeDevices_bandwidthSchedules = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/bandwidthSchedules", new ITypeProperty[]{new LazyTypeProperty("properties", () => BandwidthScheduleProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_bandwidthSchedules);
            ResourceType_dataBoxEdgeDevices_orders = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/orders", new ITypeProperty[]{new LazyTypeProperty("properties", () => OrderProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_orders);
            ResourceType_dataBoxEdgeDevices_roles = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/roles", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_roles);
            ResourceType_dataBoxEdgeDevices_shares = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/shares", new ITypeProperty[]{new LazyTypeProperty("properties", () => ShareProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_shares);
            ResourceType_dataBoxEdgeDevices_storageAccountCredentials = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/storageAccountCredentials", new ITypeProperty[]{new LazyTypeProperty("properties", () => StorageAccountCredentialProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_storageAccountCredentials);
            ResourceType_dataBoxEdgeDevices_triggers = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/triggers", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_triggers);
            ResourceType_dataBoxEdgeDevices_users = new ResourceType("Microsoft.DataBoxEdge/dataBoxEdgeDevices/users", new ITypeProperty[]{new LazyTypeProperty("properties", () => UserProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_dataBoxEdgeDevices_users);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_bandwidthSchedules, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_bandwidthSchedules);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_orders, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_orders);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_roles, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_roles);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_shares, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_shares);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_storageAccountCredentials, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_storageAccountCredentials);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_triggers, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_triggers);
            registrar.RegisterType(ResourceTypeReference_dataBoxEdgeDevices_users, () => InstanceLazy.Value.ResourceType_dataBoxEdgeDevices_users);
        }
        private readonly ResourceType ResourceType_dataBoxEdgeDevices;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_bandwidthSchedules;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_orders;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_roles;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_shares;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_storageAccountCredentials;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_triggers;
        private readonly ResourceType ResourceType_dataBoxEdgeDevices_users;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol DataBoxEdgeDeviceProperties;
        private readonly TypeSymbol BandwidthScheduleProperties;
        private readonly TypeSymbol OrderProperties;
        private readonly TypeSymbol ContactDetails;
        private readonly TypeSymbol Address;
        private readonly TypeSymbol OrderStatus;
        private readonly TypeSymbol IoTRole;
        private readonly TypeSymbol IoTRoleProperties;
        private readonly TypeSymbol IoTDeviceInfo;
        private readonly TypeSymbol Authentication;
        private readonly TypeSymbol SymmetricKey;
        private readonly TypeSymbol AsymmetricEncryptedSecret;
        private readonly TypeSymbol MountPointMap;
        private readonly TypeSymbol ShareProperties;
        private readonly TypeSymbol AzureContainerInfo;
        private readonly TypeSymbol UserAccessRight;
        private readonly TypeSymbol ClientAccessRight;
        private readonly TypeSymbol RefreshDetails;
        private readonly TypeSymbol StorageAccountCredentialProperties;
        private readonly TypeSymbol FileEventTrigger;
        private readonly TypeSymbol FileTriggerProperties;
        private readonly TypeSymbol FileSourceInfo;
        private readonly TypeSymbol RoleSinkInfo;
        private readonly TypeSymbol PeriodicTimerEventTrigger;
        private readonly TypeSymbol PeriodicTimerProperties;
        private readonly TypeSymbol PeriodicTimerSourceInfo;
        private readonly TypeSymbol UserProperties;
        private readonly TypeSymbol ShareAccessRight;
    }
}
