using FileHelpers;
using FOF8Test.DataEnums;

namespace FOF8Test.DataModels
{
    [IgnoreFirst(1)]
    [DelimitedRecord(",")]
    class RookieRecord
    {
        public int PlayerId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public PlayerPositionGroup Position { get; set; }
        public string College { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int Dash { get; set; }
        public int Solecismic { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Jump { get; set; }
        public int PositionSpecific { get; set; }
        public int Developed { get; set; }
        public int Grade { get; set; }
    }
}
