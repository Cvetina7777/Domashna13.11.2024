namespace domashna13_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            LinkedList<int> numbers = new LinkedList<int>();
            numbers.AddLast(10);
            numbers.AddLast(20);
            numbers.AddLast(30);
            numbers.AddLast(40);

            int count = 0;
            LinkedListNode<int> node = numbers.First;
            while (node != null)
            {
                count++;
                node = node.Next;
            }
            Console.WriteLine("Broq na elementite v spisuka s chisla e: " + count);

            LinkedList<string> names = new LinkedList<string>();
            names.AddLast("John");
            names.AddLast("Alice");
            names.AddLast("Bob");

            string nameToCheck = "John";
            bool containsName = false;
            foreach (var name in names)
            {
                if (name == nameToCheck)
                {
                    containsName = true;
                    break;
                }
            }

            if (containsName)
            {
                Console.WriteLine($"Imeto {nameToCheck} se sudurja v spisuka: ");
            }
            else
            {
                Console.WriteLine($"Imeto {nameToCheck} ne se sudurja v spisuka: ");
            }

            LinkedList<int> numbers2 = new LinkedList<int>();
            numbers2.AddLast(1);
            numbers2.AddLast(2);
            numbers2.AddLast(4);
            numbers2.AddLast(5);

            LinkedListNode<int> node2 = numbers2.Find(2);
            if (node2 != null)
            {
                numbers2.AddAfter(node2, 3);
            }

            Console.WriteLine("Spisuka sled vvmukvane na 3: ");
            foreach (var num in numbers2)
            {
                Console.WriteLine(num);
            }
        }
    }
}