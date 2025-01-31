
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Seaplus.Content.Tiles
{

    public class ShellCrushedSandTile : ModTile
    {

        public override void SetStaticDefaults()
        {
            Main.tileSolid[Type] = true;
			Main.tileBrick[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlockLight[Type] = true;
            Main.tileSand[Type] = true;
            TileID.Sets.Falling[Type] = true;
            MineResist = 0.5f;
        }
    }
}