namespace ArraysConsoleApp;


class Program
{
    static void Main(string[] args)
    {
        Monster[] monsters = new Monster[5];
        string[] names = ["Goblin", "Bat", "Slime", "Dragon", "Spoony Bard"];
        Random numberGenerator = new Random();

        for (int i = 0; i < monsters.Length; i++)
        {
            Monster newMonster = new Monster(names[i], numberGenerator.Next(10) + 1);
            monsters[i] = newMonster;
        }

        Console.WriteLine("============================");
        Console.WriteLine("=       Monster Stats       =");
        Console.WriteLine("============================");

        foreach (Monster m in monsters)
            m.DisplayStats();
    }

    class Monster
    {
        private string name;
        private int healthPoints;

        public Monster(string name = "Unknown Monster", int healthPoints = 9999)
        {
            this.name = name;
            this.healthPoints = healthPoints;
        }

        // apparently C# has arrow functions. cool.
        public void SetName(string name) => this.name = name;

        public string GetName() => this.name;

        public void SetHealthPoints(int healthPoints) => this.healthPoints = healthPoints;

        public int GetHealthPoints() => this.healthPoints;

        public void DisplayStats()
        {
            Console.WriteLine($"Name:\t\t{this.name}");
            Console.WriteLine($"Health Points:\t{this.healthPoints}");
            Console.WriteLine("============================");
        }
    }
}
