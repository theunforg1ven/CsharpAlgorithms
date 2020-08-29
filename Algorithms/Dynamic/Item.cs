namespace Arrays.Dynamic
{
	public class Item
	{
        public string Name { get; set; }

        public int Weigth { get; set; }

        public int Price { get; set; }

        public Item(string name, int weigth, int price)
        {
            Name = name;
            Weigth = weigth;
            Price = price;
        }
    }
}
