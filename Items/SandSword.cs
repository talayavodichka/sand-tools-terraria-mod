using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SandTools.Items
{
	public class SandSword : ModItem
	{
		public override void SetDefaults()
		{
			Item.damage = 100000;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = 1;
			Item.knockBack = 9;
			Item.value = 0;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.SandBlock, 8);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}