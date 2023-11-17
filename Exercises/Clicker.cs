namespace Exercises
{
    internal class Clicker
    {
        public int _points;
        public char _letter;

        public void Count(char inputChar)
        {
            if (inputChar == _letter)
            {
                _points++;
            }
        }

        public void Show()
        {
            Console.WriteLine($"{_letter}={_points}");
        }
    }
}
