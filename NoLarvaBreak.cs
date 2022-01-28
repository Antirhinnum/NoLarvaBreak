using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoLarvaBreak
{
	public class NoLarvaBreak : Mod
	{
		public override void Load()
		{
			Main.tileCut[TileID.Larva] = false;
		}

		public override void Unload()
		{
			Main.tileCut[TileID.Larva] = true;
		}
	}
}