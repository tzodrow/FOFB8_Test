using System.ComponentModel;

namespace TestApplication.DataEnums
{
    public enum Designation
    {
        [Description("None")]
        None,
        [Description("Unsigned")]
        Unsigned,
        [Description("Unrestricted Free Agent")]
        UnrestrictedFreeAgent,
        [Description("Restricted")]
        Restricted
    }
}
