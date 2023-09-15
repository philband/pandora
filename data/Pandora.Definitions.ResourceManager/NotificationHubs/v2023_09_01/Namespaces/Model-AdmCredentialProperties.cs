using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Pandora.Definitions.Attributes;
using Pandora.Definitions.Attributes.Validation;
using Pandora.Definitions.CustomTypes;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.NotificationHubs.v2023_09_01.Namespaces;


internal class AdmCredentialPropertiesModel
{
    [JsonPropertyName("authTokenUrl")]
    [Required]
    public string AuthTokenUrl { get; set; }

    [JsonPropertyName("clientId")]
    [Required]
    public string ClientId { get; set; }

    [JsonPropertyName("clientSecret")]
    [Required]
    public string ClientSecret { get; set; }
}
