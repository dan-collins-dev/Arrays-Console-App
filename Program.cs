namespace ArraysConsoleApp;


class Program
{
    static void Main(string[] args)
    {
        Entity[] entities = new Entity[5];
        string[] names = new string[5];
        Random numberGenerator = new Random();

        names = ["Goblin", "Bat", "Slime", "Dragon", "Spoony Bard"];

        for (int i = 0; i < entities.Length; i++)
        {
            Entity newEntity = new Entity(names[i], numberGenerator.Next(10) + 1);
            entities[i] = newEntity;
        }

        Console.WriteLine("============================");
        Console.WriteLine("=       Entity Stats       =");
        Console.WriteLine("============================");

        foreach (Entity e in entities)
            e.DisplayStats();
    }

    class Entity
    {
        private string name;
        private int healthPoints;

        public Entity(string name = "Unknown Entity", int healthPoints = 9999)
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
