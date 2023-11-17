using Exercises;

//StaticClicker.Run();

var clickers = new Clicker[]
{
    new Clicker {_letter = 'a'},
    new Clicker {_letter = 'b'},
    new Clicker {_letter = 'c'},
};

var inputKey = ' ';
while (true)
{
    Console.Clear();
    foreach (var clicker in clickers)
    {
        clicker.Count(inputKey);
        clicker.Show();
    }
    inputKey = Console.ReadKey(true).KeyChar;
}

/*
StaticClicker._points = 0;
StaticClicker._letter = 'a';

while (true)
{
    StaticClicker.Show();
    var inputKey = Console.ReadKey(true);
    StaticClicker.Count(inputKey.KeyChar);
}
*/