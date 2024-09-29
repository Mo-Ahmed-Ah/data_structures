using System;
using System.Drawing;
namespace DataStructuresWithCCharp_Stack
{
    class Stack_With_Array
    {
        int top;
        int[] array;

        public Stack_With_Array(int size)
        {
            array = new int[size];
            top = -1;
        }

        public void bush(int value) {
            if (!this.is_full())
            {
                top++;
                array[top] = value;
            }
            else
            {
                Console.WriteLine("The stack is full ");
            }
        }

        Boolean is_full()
        {
            if (top ==  this.array.Length-1 ){ 
                return true;
            }
            return false;
        }

        Boolean is_empty()
        {
            if (top == -1)
            {
                return true;
            }
            return false ;
        }

        public int git_top()
        {
            return this.array[top];
        }

        public void pop()
        {
            if (!is_empty())
            {
                this.top--;
            }
            else
            {
                Console.WriteLine("The stack is empty");
            }
        }

        public void change_array_size(int size)
        {
            array = new int[size];
        }

        public void git_all()
        {
            if (is_empty())
            {
                Console.WriteLine("The stack is empty.");
            }
            else
            {
                for(int i = top;  i >= 0; i--)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        

    }
    class Program
    {
        static void Main(string[] args) {
            Stack_With_Array stack_1 = new Stack_With_Array(12);

            stack_1.bush(1);
            stack_1.bush(2);
            stack_1.bush(3);
            stack_1.bush(4);
            stack_1.bush(5);
            stack_1.git_all();
            
        }
    }
}