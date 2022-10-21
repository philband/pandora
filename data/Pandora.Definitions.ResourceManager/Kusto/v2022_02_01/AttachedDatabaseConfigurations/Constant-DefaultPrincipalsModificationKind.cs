using Pandora.Definitions.Attributes;
using System.ComponentModel;

namespace Pandora.Definitions.ResourceManager.Kusto.v2022_02_01.AttachedDatabaseConfigurations;

[ConstantType(ConstantTypeAttribute.ConstantType.String)]
internal enum DefaultPrincipalsModificationKindConstant
{
    [Description("None")]
    None,

    [Description("Replace")]
    Replace,

    [Description("Union")]
    Union,
}
