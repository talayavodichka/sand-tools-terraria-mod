using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SandTools.Items
{
    public class SandPickaxe : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 10000;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 1;
            Item.useAnimation = 5;
            Item.pick = 1000;
            Item.useStyle = 1;
            Item.knockBack = 12;
            Item.value = 0;
            Item.rare = 0;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SandBlock, 12);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}