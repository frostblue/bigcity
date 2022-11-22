using ICities;
using UnityEngine;

namespace BigCity
{
	public class BigCityUserMod: IUserMod
	{
		public string Name
		{
			get { return "BigCity"; }
		}

		public string Description
		{
			get { return "Sets the maximum amount of purchasable tiles to 25"; }
		}
	}

	public class BigCityAreasExtension: IAreasExtension
	{
		public void OnCreated(IAreas areas)
		{
			areas.maxAreaCount = 25;
		}

		public void OnReleased()
		{

		}

		public bool OnCanUnlockArea(int x, int z, bool originalResult)
		{
			return originalResult;
		}

		public int OnGetAreaPrice(uint ore, uint oil, uint forest, uint fertility, uint water, bool road, bool train, bool ship, bool plane, float landFlatness, int originalPrice)
		{
			return originalPrice;
		}

		public void OnUnlockArea(int x, int z)
		{

		}
	}
}
