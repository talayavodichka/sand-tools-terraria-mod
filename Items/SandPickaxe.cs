using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SandTools.Items
{
    public class SandPickaxe : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 3;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 8;
            Item.useAnimation = 12;
            Item.pick = 45;
            Item.useStyle = 1;
            Item.knockBack = 1;
            Item.value = 0;
            Item.rare = 0;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SandBlock, 18);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
    }
}