namespace LKCamelot.script.spells
{
    public class WildMonk : Spell
    {
        public override string Name { get { return "WILD MONK"; } }
        public override int SpellLearnedIcon { get { return 43; } }
        public override LKCamelot.library.MagicType mType { get { return LKCamelot.library.MagicType.Target2; } }

        public override int DamBase { get { return 320; } }
        public override int DamPl { get { return 10; } }
        public override int ManaCost { get { return -70; } }
        public override int ManaCostPl { get { return 4; } }
        public override LKCamelot.library.Class ClassReq { get { return LKCamelot.library.Class.Wizard; } }
        public override SpellSequence Seq
        {
            get
            {
                return new SpellSequence(
                    0,  //oncast
                    0,  //moving
                    0,  //impact
                    0,  //thickness
                    0,  //type
                    0,  //speed
                    0  //streak
                    );
            }
        }

        public WildMonk()
        {
        }
    }
}