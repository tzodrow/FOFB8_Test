using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FOF8Test.DataEnums;

namespace FOF8Test.DataModels
{
    class PlayerRecord
    {
        public int PlayerId { get; set; }
        public int UniformNumber { get; set; }
        public PlayerPosition Position { get; set; }
        public int YearsExperience { get; set; }
        public PlayerPositionGroup PositionGroup { get; set; }
        public Team Team { get; set; }
        public int InjuryLength { get; set; }
        public string Health { get; set; }
        public int InjuryType { get; set; }
        public int Loyalty { get; set; }
        public int PlayForWinner { get; set; }
        public int PersonalityStrength { get; set; }
        public int Leadership { get; set; }
        public int Intelligence { get; set; }
        public int MyProperty { get; set; }
    }
}
