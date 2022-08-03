using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStack {
    public class Executar {

        static void Main(string[] args) {
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("Listando elementos da fila:");
            while (queue.Count > 0) {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine($"A lista possui {queue.Count.ToString()} elementos");


            /////////////////////////////////////////

            
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            
            Console.WriteLine("Listando elementos da pilha:");
            while(stack.Count > 0) {
                Console.WriteLine(stack.Pop());
            }
            Console.WriteLine($"A pilha possui {stack.Count.ToString()} elementos");


            Console.ReadLine();
        }
    }
}
