
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Seaplus.Content.Items
{
    public class ShellCrushedSandItem : ModItem
    {
        public override void SetDefaults()
        {
            Item.width = 16;
            Item.height = 16;
            Item.createTile = ModContent.TileType<Tiles.ShellCrushedSandTile>();
            Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.ShellCrushedSandTile>());
        }

        public override void AddRecipes()
        {
            CreateRecipe(10)
            .AddIngredient(ItemID.SandBlock).Register();

        }
    }
}