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

        public static int FibonachiThree(int num)
        {
            if (num == 0)
                return 0;
            else if(num == 1)
                return 1;
            else if (num == 2)
                return 2;
            else
                return FibonachiThree(num - 1) + FibonachiThree(num - 2) + FibonachiThree(num - 3);
        }
    }
}