namespace Arrays.Dynamic
{
	public class Item
	{
        public string Name { get; set; }

        public double Weigth { get; set; }

        public decimal Price { get; set; }

        public Item(string name, double weigth, decimal price)
        {
            Name = name;
            Weigth = weigth;
            Price = price;
        }
    }
}
