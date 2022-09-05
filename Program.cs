using System.Numerics;
using System.Text;


Brachets();
void Brachets()
{
    string s = Console.ReadLine(); // Enter date

    Stack<char> stack = new();// create stack 
    bool answer = true; // variable for showing answer
    const string OPEN = "({[", close = ")}]"; // create const for validate
    for (int i = 0; i < s.Length; i++)
    {
        if (OPEN.Contains(s[i])) stack.Push(s[i]); // it's validate for check date
        else if (stack.Count == 0) { answer = false; break; } // if stack is empty then answer false

        else if (OPEN.Contains(stack.Peek()) != close.Contains(s[i])) // if the top element's stack isn't consist of const close 

        {
            { answer = false; break; }
        }
        else if (stack.Peek() == '{' && s[i] != '}') { answer = false; break; }//it's validate for check the same brackets                                                             * 
        else if (stack.Peek() == '[' && s[i] != ']') { answer = false; break; }
        else if (stack.Peek() == '(' && s[i] != ')') { answer = false; break; }
        else stack.Pop();
    }
    if (stack.Count != 0) answer = false; // it's validate for check situation with one brackets
    Console.WriteLine(answer);

}


ReverseMatrix();

void ReverseMatrix()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[n, n];
    Random rand = new();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    Print();
    Console.WriteLine();
    Get90DegressMatrixrotate(matrix);
    Print();
    void Get90DegressMatrixrotate(int[,] matrix)
    {
        int length = matrix.GetLength(0);
        for (int layer = 0; layer < length / 2; layer++)
        {
            int first = layer;
            int last = length - 1 - layer;

            for (int i = first; i < last; i++)
            {
                int offset = i - first;
                int top = matrix[first, i];
                matrix[first, i] = matrix[last - offset, first];
                matrix[last - offset, first] = matrix[last, last - offset];
                matrix[last, last - offset] = matrix[i, last];
                matrix[i, last] = top;

            }
        }
    }


    void Print()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

}

ReverseIntegers();
void ReverseIntegers()
{
    int result = 0;
    int x = int.Parse(Console.ReadLine());
    while (x != 0)
    {
        x = Math.DivRem(x, 10, out var part);
        result = result * 10 + part;
    }
    Console.WriteLine(result);
}

