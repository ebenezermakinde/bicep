// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ServiceFabric_2019_03_01_preview
    {
        private const string ProviderNamespace = "Microsoft.ServiceFabric";
        private const string ApiVersion = "2019-03-01-preview";
        private static readonly ResourceTypeReference ResourceTypeReference_clusters = new ResourceTypeReference(ProviderNamespace, new[]{"clusters"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_clusters_applicationTypes = new ResourceTypeReference(ProviderNamespace, new[]{"clusters", "applicationTypes"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_clusters_applications = new ResourceTypeReference(ProviderNamespace, new[]{"clusters", "applications"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_clusters_applicationTypes_versions = new ResourceTypeReference(ProviderNamespace, new[]{"clusters", "applicationTypes", "versions"}, ApiVersion);
        private static readonly ResourceTypeReference ResourceTypeReference_clusters_applications_services = new ResourceTypeReference(ProviderNamespace, new[]{"clusters", "applications", "services"}, ApiVersion);
        private static Lazy<Microsoft_ServiceFabric_2019_03_01_preview> InstanceLazy = new Lazy<Microsoft_ServiceFabric_2019_03_01_preview>(() => new Microsoft_ServiceFabric_2019_03_01_preview());
        private Microsoft_ServiceFabric_2019_03_01_preview()
        {
            ClusterProperties = new NamedObjectType("ClusterProperties", new ITypeProperty[]{new TypeProperty("addOnFeatures", LanguageConstants.Array, TypePropertyFlags.None), new LazyTypeProperty("azureActiveDirectory", () => AzureActiveDirectory, TypePropertyFlags.None), new LazyTypeProperty("certificate", () => CertificateDescription, TypePropertyFlags.None), new LazyTypeProperty("certificateCommonNames", () => ServerCertificateCommonNames, TypePropertyFlags.None), new TypeProperty("clientCertificateCommonNames", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("clientCertificateThumbprints", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("clusterCodeVersion", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("diagnosticsStorageAccountConfig", () => DiagnosticsStorageAccountConfig, TypePropertyFlags.None), new TypeProperty("eventStoreServiceEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("fabricSettings", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("managementEndpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("nodeTypes", LanguageConstants.Array, TypePropertyFlags.Required), new TypeProperty("reliabilityLevel", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("reverseProxyCertificate", () => CertificateDescription, TypePropertyFlags.None), new LazyTypeProperty("reverseProxyCertificateCommonNames", () => ServerCertificateCommonNames, TypePropertyFlags.None), new LazyTypeProperty("upgradeDescription", () => ClusterUpgradePolicy, TypePropertyFlags.None), new TypeProperty("upgradeMode", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("vmImage", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            AzureActiveDirectory = new NamedObjectType("AzureActiveDirectory", new ITypeProperty[]{new TypeProperty("tenantId", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clusterApplication", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("clientApplication", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            CertificateDescription = new NamedObjectType("CertificateDescription", new ITypeProperty[]{new TypeProperty("thumbprint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("thumbprintSecondary", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("x509StoreName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServerCertificateCommonNames = new NamedObjectType("ServerCertificateCommonNames", new ITypeProperty[]{new TypeProperty("commonNames", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("x509StoreName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServerCertificateCommonName = new NamedObjectType("ServerCertificateCommonName", new ITypeProperty[]{new TypeProperty("certificateCommonName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("certificateIssuerThumbprint", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ClientCertificateCommonName = new NamedObjectType("ClientCertificateCommonName", new ITypeProperty[]{new TypeProperty("isAdmin", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("certificateCommonName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("certificateIssuerThumbprint", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ClientCertificateThumbprint = new NamedObjectType("ClientCertificateThumbprint", new ITypeProperty[]{new TypeProperty("isAdmin", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("certificateThumbprint", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            DiagnosticsStorageAccountConfig = new NamedObjectType("DiagnosticsStorageAccountConfig", new ITypeProperty[]{new TypeProperty("storageAccountName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("protectedAccountKeyName", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("blobEndpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("queueEndpoint", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tableEndpoint", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SettingsSectionDescription = new NamedObjectType("SettingsSectionDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("parameters", LanguageConstants.Array, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            SettingsParameterDescription = new NamedObjectType("SettingsParameterDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("value", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            NodeTypeDescription = new NamedObjectType("NodeTypeDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("placementProperties", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("capacities", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("clientConnectionEndpointPort", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("httpGatewayEndpointPort", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("durabilityLevel", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("applicationPorts", () => EndpointRangeDescription, TypePropertyFlags.None), new LazyTypeProperty("ephemeralPorts", () => EndpointRangeDescription, TypePropertyFlags.None), new TypeProperty("isPrimary", LanguageConstants.Bool, TypePropertyFlags.Required), new TypeProperty("vmInstanceCount", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("reverseProxyEndpointPort", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            EndpointRangeDescription = new NamedObjectType("EndpointRangeDescription", new ITypeProperty[]{new TypeProperty("startPort", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("endPort", LanguageConstants.Int, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ClusterUpgradePolicy = new NamedObjectType("ClusterUpgradePolicy", new ITypeProperty[]{new TypeProperty("forceRestart", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("upgradeReplicaSetCheckTimeout", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("healthCheckWaitDuration", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("healthCheckStableDuration", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("healthCheckRetryTimeout", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("upgradeTimeout", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("upgradeDomainTimeout", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("healthPolicy", () => ClusterHealthPolicy, TypePropertyFlags.Required), new LazyTypeProperty("deltaHealthPolicy", () => ClusterUpgradeDeltaHealthPolicy, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClusterHealthPolicy = new NamedObjectType("ClusterHealthPolicy", new ITypeProperty[]{new TypeProperty("maxPercentUnhealthyNodes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxPercentUnhealthyApplications", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("applicationHealthPolicies", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ApplicationHealthPolicy = new NamedObjectType("ApplicationHealthPolicy", new ITypeProperty[]{new LazyTypeProperty("defaultServiceTypeHealthPolicy", () => ServiceTypeHealthPolicy, TypePropertyFlags.None), new TypeProperty("serviceTypeHealthPolicies", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServiceTypeHealthPolicy = new NamedObjectType("ServiceTypeHealthPolicy", new ITypeProperty[]{new TypeProperty("maxPercentUnhealthyServices", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ClusterUpgradeDeltaHealthPolicy = new NamedObjectType("ClusterUpgradeDeltaHealthPolicy", new ITypeProperty[]{new TypeProperty("maxPercentDeltaUnhealthyNodes", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("maxPercentUpgradeDomainDeltaUnhealthyNodes", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("maxPercentDeltaUnhealthyApplications", LanguageConstants.Int, TypePropertyFlags.Required), new TypeProperty("applicationDeltaHealthPolicies", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ApplicationDeltaHealthPolicy = new NamedObjectType("ApplicationDeltaHealthPolicy", new ITypeProperty[]{new LazyTypeProperty("defaultServiceTypeDeltaHealthPolicy", () => ServiceTypeDeltaHealthPolicy, TypePropertyFlags.None), new TypeProperty("serviceTypeDeltaHealthPolicies", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServiceTypeDeltaHealthPolicy = new NamedObjectType("ServiceTypeDeltaHealthPolicy", new ITypeProperty[]{new TypeProperty("maxPercentDeltaUnhealthyServices", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ApplicationTypeResourceProperties = new NamedObjectType("ApplicationTypeResourceProperties", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            ApplicationTypeVersionResourceProperties = new NamedObjectType("ApplicationTypeVersionResourceProperties", new ITypeProperty[]{new TypeProperty("appPackageUrl", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ApplicationResourceProperties = new NamedObjectType("ApplicationResourceProperties", new ITypeProperty[]{new TypeProperty("typeVersion", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("parameters", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("upgradePolicy", () => ApplicationUpgradePolicy, TypePropertyFlags.None), new TypeProperty("minimumNodes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maximumNodes", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("removeApplicationCapacity", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("metrics", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("typeName", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ApplicationUpgradePolicy = new NamedObjectType("ApplicationUpgradePolicy", new ITypeProperty[]{new TypeProperty("upgradeReplicaSetCheckTimeout", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("forceRestart", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("rollingUpgradeMonitoringPolicy", () => ArmRollingUpgradeMonitoringPolicy, TypePropertyFlags.None), new LazyTypeProperty("applicationHealthPolicy", () => ArmApplicationHealthPolicy, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ArmRollingUpgradeMonitoringPolicy = new NamedObjectType("ArmRollingUpgradeMonitoringPolicy", new ITypeProperty[]{new TypeProperty("failureAction", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("healthCheckWaitDuration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("healthCheckStableDuration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("healthCheckRetryTimeout", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("upgradeTimeout", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("upgradeDomainTimeout", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ArmApplicationHealthPolicy = new NamedObjectType("ArmApplicationHealthPolicy", new ITypeProperty[]{new TypeProperty("considerWarningAsError", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("maxPercentUnhealthyDeployedApplications", LanguageConstants.Int, TypePropertyFlags.None), new LazyTypeProperty("defaultServiceTypeHealthPolicy", () => ArmServiceTypeHealthPolicy, TypePropertyFlags.None), new TypeProperty("serviceTypeHealthPolicyMap", LanguageConstants.Any, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ArmServiceTypeHealthPolicy = new NamedObjectType("ArmServiceTypeHealthPolicy", new ITypeProperty[]{new TypeProperty("maxPercentUnhealthyServices", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxPercentUnhealthyPartitionsPerService", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("maxPercentUnhealthyReplicasPerPartition", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ApplicationMetricDescription = new NamedObjectType("ApplicationMetricDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("maximumCapacity", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("reservationCapacity", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("totalApplicationCapacity", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServiceResourceProperties = new NamedObjectType("ServiceResourceProperties", new ITypeProperty[]{new TypeProperty("placementConstraints", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("correlationScheme", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("serviceLoadMetrics", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("servicePlacementPolicies", LanguageConstants.Array, TypePropertyFlags.None), new TypeProperty("defaultMoveCost", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceTypeName", LanguageConstants.String, TypePropertyFlags.None), new LazyTypeProperty("partitionDescription", () => PartitionSchemeDescription, TypePropertyFlags.None), new TypeProperty("servicePackageActivationMode", LanguageConstants.String, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServiceCorrelationDescription = new NamedObjectType("ServiceCorrelationDescription", new ITypeProperty[]{new TypeProperty("scheme", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("serviceName", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ServiceLoadMetricDescription = new NamedObjectType("ServiceLoadMetricDescription", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("weight", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("primaryDefaultLoad", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("secondaryDefaultLoad", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("defaultLoad", LanguageConstants.Int, TypePropertyFlags.None)}, null, TypePropertyFlags.None);
            ServicePlacementPolicyDescription = new NamedObjectType("ServicePlacementPolicyDescription", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            PartitionSchemeDescription = new NamedObjectType("PartitionSchemeDescription", new ITypeProperty[]{}, null, TypePropertyFlags.None);
            SingletonPartitionSchemeDescription = new NamedObjectType("SingletonPartitionSchemeDescription", new ITypeProperty[]{new TypeProperty("partitionScheme", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            StatefulServiceProperties = new NamedObjectType("StatefulServiceProperties", new ITypeProperty[]{new TypeProperty("hasPersistedState", LanguageConstants.Bool, TypePropertyFlags.None), new TypeProperty("targetReplicaSetSize", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("minReplicaSetSize", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("replicaRestartWaitDuration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("quorumLossWaitDuration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("standByReplicaKeepDuration", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("serviceKind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            StatelessServiceProperties = new NamedObjectType("StatelessServiceProperties", new ITypeProperty[]{new TypeProperty("instanceCount", LanguageConstants.Int, TypePropertyFlags.None), new TypeProperty("serviceKind", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_clusters = new ResourceType("Microsoft.ServiceFabric/clusters", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ClusterProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters);
            ResourceType_clusters_applicationTypes = new ResourceType("Microsoft.ServiceFabric/clusters/applicationTypes", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ApplicationTypeResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters_applicationTypes);
            ResourceType_clusters_applications = new ResourceType("Microsoft.ServiceFabric/clusters/applications", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ApplicationResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters_applications);
            ResourceType_clusters_applicationTypes_versions = new ResourceType("Microsoft.ServiceFabric/clusters/applicationTypes/versions", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ApplicationTypeVersionResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters_applicationTypes_versions);
            ResourceType_clusters_applications_services = new ResourceType("Microsoft.ServiceFabric/clusters/applications/services", new ITypeProperty[]{new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.None), new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new LazyTypeProperty("properties", () => ServiceResourceProperties, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_clusters_applications_services);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_clusters, () => InstanceLazy.Value.ResourceType_clusters);
            registrar.RegisterType(ResourceTypeReference_clusters_applicationTypes, () => InstanceLazy.Value.ResourceType_clusters_applicationTypes);
            registrar.RegisterType(ResourceTypeReference_clusters_applications, () => InstanceLazy.Value.ResourceType_clusters_applications);
            registrar.RegisterType(ResourceTypeReference_clusters_applicationTypes_versions, () => InstanceLazy.Value.ResourceType_clusters_applicationTypes_versions);
            registrar.RegisterType(ResourceTypeReference_clusters_applications_services, () => InstanceLazy.Value.ResourceType_clusters_applications_services);
        }
        private readonly ResourceType ResourceType_clusters;
        private readonly ResourceType ResourceType_clusters_applicationTypes;
        private readonly ResourceType ResourceType_clusters_applications;
        private readonly ResourceType ResourceType_clusters_applicationTypes_versions;
        private readonly ResourceType ResourceType_clusters_applications_services;
        private readonly TypeSymbol ClusterProperties;
        private readonly TypeSymbol AzureActiveDirectory;
        private readonly TypeSymbol CertificateDescription;
        private readonly TypeSymbol ServerCertificateCommonNames;
        private readonly TypeSymbol ServerCertificateCommonName;
        private readonly TypeSymbol ClientCertificateCommonName;
        private readonly TypeSymbol ClientCertificateThumbprint;
        private readonly TypeSymbol DiagnosticsStorageAccountConfig;
        private readonly TypeSymbol SettingsSectionDescription;
        private readonly TypeSymbol SettingsParameterDescription;
        private readonly TypeSymbol NodeTypeDescription;
        private readonly TypeSymbol EndpointRangeDescription;
        private readonly TypeSymbol ClusterUpgradePolicy;
        private readonly TypeSymbol ClusterHealthPolicy;
        private readonly TypeSymbol ApplicationHealthPolicy;
        private readonly TypeSymbol ServiceTypeHealthPolicy;
        private readonly TypeSymbol ClusterUpgradeDeltaHealthPolicy;
        private readonly TypeSymbol ApplicationDeltaHealthPolicy;
        private readonly TypeSymbol ServiceTypeDeltaHealthPolicy;
        private readonly TypeSymbol ApplicationTypeResourceProperties;
        private readonly TypeSymbol ApplicationTypeVersionResourceProperties;
        private readonly TypeSymbol ApplicationResourceProperties;
        private readonly TypeSymbol ApplicationUpgradePolicy;
        private readonly TypeSymbol ArmRollingUpgradeMonitoringPolicy;
        private readonly TypeSymbol ArmApplicationHealthPolicy;
        private readonly TypeSymbol ArmServiceTypeHealthPolicy;
        private readonly TypeSymbol ApplicationMetricDescription;
        private readonly TypeSymbol ServiceResourceProperties;
        private readonly TypeSymbol ServiceCorrelationDescription;
        private readonly TypeSymbol ServiceLoadMetricDescription;
        private readonly TypeSymbol ServicePlacementPolicyDescription;
        private readonly TypeSymbol PartitionSchemeDescription;
        private readonly TypeSymbol SingletonPartitionSchemeDescription;
        private readonly TypeSymbol StatefulServiceProperties;
        private readonly TypeSymbol StatelessServiceProperties;
    }
}
