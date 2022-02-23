using Pandora.Definitions.Attributes;
using Pandora.Definitions.CustomTypes;
using Pandora.Definitions.Interfaces;
using Pandora.Definitions.Operations;
using System;
using System.Collections.Generic;
using System.Net;

namespace Pandora.Definitions.ResourceManager.Storage.v2021_04_01.StorageAccounts;

internal class ListAccountSASOperation : Operations.PostOperation
{
    public override IEnumerable<HttpStatusCode> ExpectedStatusCodes() => new List<HttpStatusCode>
        {
                HttpStatusCode.OK,
        };

    public override Type? RequestObject() => typeof(AccountSasParametersModel);

    public override ResourceID? ResourceId() => new StorageAccountId();

    public override Type? ResponseObject() => typeof(ListAccountSasResponseModel);

    public override string? UriSuffix() => "/listAccountSas";


}
