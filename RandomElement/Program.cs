string[] snacks = { "sush", "pizza", "burger", "chicken wing", "Asian takeaway" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonigth we are going to eat {snacks[randomIndex]}.");