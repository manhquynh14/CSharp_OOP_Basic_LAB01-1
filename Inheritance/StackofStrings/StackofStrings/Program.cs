using System;

namespace StackofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
             private List<string> _data;

        public StackOfStrings()
        {
            _data = new List<string>();
        }
        
        public void Push(string item)
        {
            _data.Add(item);
            Console.Write("Data: ");
            foreach (string s in _data)
            {
                Console.Write($"{s} ");
            }
            Console.WriteLine();
        }
    }
}
