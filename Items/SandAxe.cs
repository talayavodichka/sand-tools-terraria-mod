using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SandTools.Items
{
    public class SandAxe : ModItem
    {
        public override void SetDefaults()
        {
            Item.damage = 5;
            Item.DamageType = DamageClass.Melee;
            Item.width = 40;
            Item.height = 40;
            Item.useTime = 15;
            Item.useAnimation = 20;
            Item.axe = 12;
            Item.useStyle = 1;
            Item.knockBack = 3;
            Item.value = 0;
            Item.rare = 0;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.SandBlock, 16);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }
        public override void GetHealLife(Player player, bool quickHeal, ref int healValue)
        {
            healValue = 2;
        }
    }
}