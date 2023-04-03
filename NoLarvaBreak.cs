using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NoLarvaBreak;

public sealed class NoLarvaBreak : Mod
{
	private static bool _oldValue = false;

	public override void Load()
	{
		_oldValue = Main.tileCut[TileID.Larva];
		Main.tileCut[TileID.Larva] = false;
	}

	public override void Unload()
	{
		Main.tileCut[TileID.Larva] = _oldValue;
	}
}