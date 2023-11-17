namespace Exercises
{
    internal class StaticClicker
    {
        public static int _points;
        public static char _letter;

        public static void Count(char inputChar)
        {
            if (inputChar == _letter)
            {
                _points++;
            }
        }

        public static void Show()
        {
            Console.WriteLine($"{_letter}={_points}");
        }
    }
}
