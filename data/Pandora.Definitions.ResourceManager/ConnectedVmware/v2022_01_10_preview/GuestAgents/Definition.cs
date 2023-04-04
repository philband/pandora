using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.ConnectedVmware.v2022_01_10_preview.GuestAgents;

internal class Definition : ResourceDefinition
{
    public string Name => "GuestAgents";
    public IEnumerable<Interfaces.ApiOperation> Operations => new List<Interfaces.ApiOperation>
    {
        new CreateOperation(),
        new DeleteOperation(),
        new GetOperation(),
        new ListByVMOperation(),
    };
    public IEnumerable<System.Type> Constants => new List<System.Type>
    {
        typeof(ProvisioningActionConstant),
    };
    public IEnumerable<System.Type> Models => new List<System.Type>
    {
        typeof(GuestAgentModel),
        typeof(GuestAgentPropertiesModel),
        typeof(GuestCredentialModel),
        typeof(HTTPProxyConfigurationModel),
        typeof(ResourceStatusModel),
    };
}
