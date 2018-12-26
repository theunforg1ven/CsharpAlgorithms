namespace Arrays.FactorialFib
{
    public static class Fibonachi
    {
        public static int FibonachiTwo(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
                return FibonachiTwo(num - 1) + FibonachiTwo(num - 2);
        }

        static public int FibonachiThree(int num)
		{
			if (num < 3)
				return num;
			else
				return FibonachiThree(num - 1) + FibonachiThree(num - 2) + FibonachiThree(num - 3);
		}
    }
}