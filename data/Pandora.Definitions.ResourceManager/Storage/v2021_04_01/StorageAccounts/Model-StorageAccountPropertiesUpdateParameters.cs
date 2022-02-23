using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;

namespace Pandora.Definitions.ResourceManager.Storage.v2021_04_01.StorageAccounts;


internal class StorageAccountPropertiesUpdateParametersModel
{
    [JsonPropertyName("accessTier")]
    public AccessTierConstant? AccessTier { get; set; }

    [JsonPropertyName("allowBlobPublicAccess")]
    public bool? AllowBlobPublicAccess { get; set; }

    [JsonPropertyName("allowCrossTenantReplication")]
    public bool? AllowCrossTenantReplication { get; set; }

    [JsonPropertyName("allowSharedKeyAccess")]
    public bool? AllowSharedKeyAccess { get; set; }

    [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
    public AzureFilesIdentityBasedAuthenticationModel? AzureFilesIdentityBasedAuthentication { get; set; }

    [JsonPropertyName("customDomain")]
    public CustomDomainModel? CustomDomain { get; set; }

    [JsonPropertyName("encryption")]
    public EncryptionModel? Encryption { get; set; }

    [JsonPropertyName("keyPolicy")]
    public KeyPolicyModel? KeyPolicy { get; set; }

    [JsonPropertyName("largeFileSharesState")]
    public LargeFileSharesStateConstant? LargeFileSharesState { get; set; }

    [JsonPropertyName("minimumTlsVersion")]
    public MinimumTlsVersionConstant? MinimumTlsVersion { get; set; }

    [JsonPropertyName("networkAcls")]
    public NetworkRuleSetModel? NetworkAcls { get; set; }

    [JsonPropertyName("routingPreference")]
    public RoutingPreferenceModel? RoutingPreference { get; set; }

    [JsonPropertyName("sasPolicy")]
    public SasPolicyModel? SasPolicy { get; set; }

    [JsonPropertyName("supportsHttpsTrafficOnly")]
    public bool? SupportsHttpsTrafficOnly { get; set; }
}
