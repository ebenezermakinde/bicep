// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using System;
using Bicep.Core;
using Bicep.Core.Resources;
using Bicep.Core.TypeSystem;
namespace Bicep.Resources.Types
{
    [ResourceTypeRegisterableAttribute]
    public class Microsoft_ContainerRegistry_2017_03_01
    {
        private const string ProviderNamespace = "Microsoft.ContainerRegistry";
        private const string ApiVersion = "2017-03-01";
        private static readonly ResourceTypeReference ResourceTypeReference_registries = new ResourceTypeReference(ProviderNamespace, new[]{"registries"}, ApiVersion);
        private static Lazy<Microsoft_ContainerRegistry_2017_03_01> InstanceLazy = new Lazy<Microsoft_ContainerRegistry_2017_03_01>(() => new Microsoft_ContainerRegistry_2017_03_01());
        private Microsoft_ContainerRegistry_2017_03_01()
        {
            Sku = new NamedObjectType("Sku", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            RegistryPropertiesCreateParameters = new NamedObjectType("RegistryPropertiesCreateParameters", new ITypeProperty[]{new TypeProperty("adminUserEnabled", LanguageConstants.Bool, TypePropertyFlags.None), new LazyTypeProperty("storageAccount", () => StorageAccountParameters, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            StorageAccountParameters = new NamedObjectType("StorageAccountParameters", new ITypeProperty[]{new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.Required), new TypeProperty("accessKey", LanguageConstants.String, TypePropertyFlags.Required)}, null, TypePropertyFlags.None);
            ResourceType_registries = new ResourceType("Microsoft.ContainerRegistry/registries", new ITypeProperty[]{new TypeProperty("tags", LanguageConstants.Any, TypePropertyFlags.None), new TypeProperty("location", LanguageConstants.String, TypePropertyFlags.Required), new LazyTypeProperty("sku", () => Sku, TypePropertyFlags.Required), new LazyTypeProperty("properties", () => RegistryPropertiesCreateParameters, TypePropertyFlags.Required), new TypeProperty("name", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.Required), new TypeProperty("type", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly), new TypeProperty("apiVersion", LanguageConstants.String, TypePropertyFlags.SkipInlining | TypePropertyFlags.ReadOnly)}, null, ResourceTypeReference_registries);
        }
        public static void Register(IResourceTypeRegistrar registrar)
        {
            registrar.RegisterType(ResourceTypeReference_registries, () => InstanceLazy.Value.ResourceType_registries);
        }
        private readonly ResourceType ResourceType_registries;
        private readonly TypeSymbol Sku;
        private readonly TypeSymbol RegistryPropertiesCreateParameters;
        private readonly TypeSymbol StorageAccountParameters;
    }
}
