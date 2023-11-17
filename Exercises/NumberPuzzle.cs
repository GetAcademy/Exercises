namespace Exercises
{
    internal class NumberPuzzle
    {
        private static char[] _numbers;

        public static void Run()
        {
            _numbers = " 13425786".ToCharArray();
            while (true)
            {
                Show();
                Console.Write("Hvilket tall vil du flytte? ");
                var number = Console.ReadLine();
                Move(number[0]);
            }
        }

        private static void Move(char number)
        {
            var index = Array.IndexOf(_numbers, number);
            var rowIndex = index / 3;
            var colIndex = index % 3;
            var didSwap = SwapIsBlank(rowIndex - 1, colIndex, index);
            if (!didSwap) didSwap = SwapIsBlank(rowIndex + 1, colIndex, index);
            if (!didSwap) didSwap = SwapIsBlank(rowIndex, colIndex + 1, index);
            if (!didSwap) SwapIsBlank(rowIndex, colIndex - 1, index);

            //var didSwap =
            //    SwapIsBlank(rowIndex - 1, colIndex, index)
            //|| SwapIsBlank(rowIndex + 1, colIndex, index)
            //|| SwapIsBlank(rowIndex, colIndex + 1, index)
            //|| SwapIsBlank(rowIndex, colIndex - 1, index);
        }

        private static bool SwapIsBlank(int rowIndex, int colIndex, int numberIndex)
        {
            if (rowIndex < 0 || rowIndex > 2 || colIndex < 0 || colIndex > 2) return false;
            var blankIndex = rowIndex * 3 + colIndex;
            if (_numbers[blankIndex] != ' ') return false;
            _numbers[blankIndex] = _numbers[numberIndex];
            _numbers[numberIndex] = ' ';
            return true;
        }

        private static void Show()
        {
            Console.Clear();
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (i % 3 == 0) Console.WriteLine();
                var number = _numbers[i];
                Console.Write(number);
            }
            Console.WriteLine("\n");
        }
    }
}
