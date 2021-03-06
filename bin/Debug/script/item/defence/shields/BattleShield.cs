using LKCamelot.library;
using LKCamelot.model;

namespace LKCamelot.script.item
{
	public class BattleShield : BaseArmor
	{
		public override string Name { get { return "Battle Shield"; } }

		public override int DamBase { get { return 0; } }
		public override int ACBase { get { return 68; } }

		public override int StrReq { get { return 384; } }
		public override int DexReq { get { return 0; } }

		public override int InitMinHits { get { return 700; } }
		public override int InitMaxHits { get { return 700; } }
        public override int SellPrice { get { return 12000; } }

        public override Class ClassReq { get { return Class.Knight | Class.Swordsman | Class.Beginner; } }
		public override ArmorType ArmorType { get { return ArmorType.Shield; } }

		public BattleShield() : base (18)
		{
		}

		public BattleShield(Serial serial) : base (serial)
		{
		}
	}
}
