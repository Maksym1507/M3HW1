using M3HW1.Comparers;
using M3HW1.Interfaces;
using M3HW1.Models;

namespace M3HW1
{
    public class Starter
    {
        public Starter(IMyList<int> list)
        {
            List = list;
        }

        public IMyList<int> List { get; set; }

        public void Run()
        {
            List.Add(154234);
            List.Add(765);
            List.Add(2343);
            List.Add(3);

            Console.WriteLine("Capacity: " + List.Capacity);

            List.Add(1);
            List.Add(-3);

            Console.WriteLine("Capacity: " + List.Capacity);

            List.AddRange(new int[] { 10, 12, 33 });

            foreach (var item in List)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nCapacity: " + List.Capacity);

            try
            {
                List.RemoveAt(0);
                List.RemoveAt(12);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Failed to removed list item: {ex.Message}");
            }

            foreach (var item in List)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nCapacity: " + List.Capacity);

            List.Sort(new IntComparer());

            foreach (var item in List)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nCapacity: " + List.Capacity);

            List.Remove(3);
            List.Remove(11);
            List.Remove(10);

            foreach (var item in List)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nCapacity: " + List.Capacity);

            List.Add(95);
            List.Add(17);

            List.Sort(new IntComparer());

            foreach (var item in List)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nCapacity: " + List.Capacity);
        }
    }
}
