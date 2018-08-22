using System.ComponentModel;

namespace TestApplication.DataEnums
{
    public enum Aquire
    {
        [Description("None")]
        None,
        [Description("Free Agent")]
        FreeAgent,
        [Description("Rookie Draft")]
        RookieDraft
    }
}
