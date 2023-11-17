namespace Exercises
{
    internal class NumberPuzzle2
    {
        static char[] _numbers;

        static Direction[] _directions;
        /*
            static ????[] _directions = [
                {deltaRow: 1, deltaCol: 0 },
                {deltaRow: -1, deltaCol: 0 },
                {deltaRow: 0, deltaCol: 1 },
                {deltaRow: 0, deltaCol: -1 },
            ];
        */

        /*
         * ned:     rad: +1 col:  0
         * opp:     rad: -1 col:  0
         * høyre:   rad:  0 col: +1
         * venstre: rad:  0 col: -1
         */

        public static void Run()
        {
            _directions = new Direction[]
            {
                new Direction{DeltaRow = 1, DeltaCol = 0},
                new Direction{DeltaRow = -1, DeltaCol = 0},
                new Direction{DeltaRow = 0, DeltaCol = 1},
                new Direction{DeltaRow = 0, DeltaCol = -1},

            };
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
            foreach (var direction in _directions)
            {
                var didSwap = SwapIsBlank(
                    rowIndex + direction.DeltaRow,
                    colIndex + direction.DeltaCol,
                    index);
                if (didSwap) break;
            }
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
