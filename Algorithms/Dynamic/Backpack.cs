using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Dynamic
{
	public class Backpack
	{
		public List<Item> BestBackpackItems { get; set; }

		public List<Item> CurrentItems { get; set; }

        public List<Item> GetBestBackpackItems(int capacity, List<Item> currentItems, out int result)
		{
			CurrentItems = currentItems;
			BestBackpackItems = new List<Item>();

			result = ItemsSearch(capacity, CurrentItems);

			return BestBackpackItems;
		}

		private int ItemsSearch(int capacity, List<Item> currentItems)
		{
            if (currentItems.Count == 0 || capacity == 0) 
                return 0;

            if (currentItems.Count == 1)
                return currentItems.First().Weigth < capacity ? currentItems.First().Price : 0;

            var best = 0;
            for (int i = 0; i < currentItems.Count; i++)
            {
                // this is an array of the other items
                var otherItems = currentItems.Take(i).Concat(currentItems.Skip(i + 1)).ToList();

                // calculate the best value without using the current item
                var without = ItemsSearch(capacity, otherItems);
                var with = 0;

                // if the current item fits then calculate the best value for
                // a capacity less it's weight and with it removed from contention
                // and add the current items value to that
                if (currentItems[i].Weigth <= capacity)
                {
                    with = ItemsSearch(capacity - currentItems[i].Weigth, otherItems) + currentItems[i].Price;
                }

                // the current best is the max of the with or without
                int currentBest = Math.Max(without, with);

                // determine if the current best is the overall best
                if (currentBest > best)
				{
                    best = currentBest;
                    var newItemWithout = currentItems.FirstOrDefault(item => item.Price == without);
                    var newItemWith= currentItems.FirstOrDefault(item => item.Price == with);

                    BestBackpackItems.Remove(newItemWith);
                    
                    if(newItemWithout != null)
                        BestBackpackItems.Add(newItemWithout);
                }
            }

            return best;
        }
	}
}
