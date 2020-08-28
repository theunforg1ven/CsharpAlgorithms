using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Dynamic
{
	public class Backpack
	{
		private double MaxWeight { get; set; }

		public decimal BestPrice { get; set; }

		public List<Item> BestBackpackItems { get; set; }

		public List<Item> CurrentItems { get; set; }

		public List<Item> GetBestBackpackItems(double maxW, List<Item> currentItems)
		{
			MaxWeight = maxW;
			CurrentItems = currentItems;
			BestBackpackItems = new List<Item>();

			int[,] matrix = new int[currentItems.Count + 1, currentItems.Capacity + 1];

			var resultMatrix = GetBestBackpackItems(MaxWeight, CurrentItems, BestBackpackItems);

			return resultMatrix;
		}

		private List<Item> GetBestBackpackItems(double maxW, List<Item> currentItems, int[,] matrix)
		{

		}
	}
}
