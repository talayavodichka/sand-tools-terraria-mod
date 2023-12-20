using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SandTools.Items
{
    public class SandAxe : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 50000;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 1;
            Item.useAnimation = 3;
            Item.axe = 500;
            Item.useStyle = 1;
            Item.knockBack = 15;
            Item.value = 0;
            Item.rare = 0;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SandBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}