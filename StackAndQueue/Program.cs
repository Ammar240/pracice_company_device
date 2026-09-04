namespace StackAndQueue;

internal class Program
{
    static void Main(string[] args)
    {
        #region Stack task
        Stack<Command> undo = new Stack<Command>();
        Stack<Command> redo = new Stack<Command>();

        string line;
        while (true)
        {
            Console.Write("Enter url (exit) to Exit: ");
            line = Console.ReadLine();
            line.ToLower();
            if (line == "exit")
            {
                break;
            }
            else if (line == "forward")
            {
                if (redo.Count > 0)
                    undo.Push(redo.Pop());
                else
                    continue;
            }
            else if (line == "back")
            {
                if (undo.Count > 0)
                    redo.Push(undo.Pop());
                else
                    continue;
            }
            else
            {
                undo.Push(new Command(line));
            }
            Console.Clear();
            PrintStack("Back", undo);
            PrintStack("Forward", redo);
        }// end of while
        #endregion

        #region Queue

        //Queue<PrinitingJop> printingjob = new Queue<PrinitingJop>();
        //printingjob.Enqueue(new PrinitingJop("documentation.docx", 2));
        //printingjob.Enqueue(new PrinitingJop("user-stories.pdf", 3));
        //printingjob.Enqueue(new PrinitingJop("report.xlsx", 5));
        //printingjob.Enqueue(new PrinitingJop("payroll.report", 2));
        //printingjob.Enqueue(new PrinitingJop("book.docx", 1));
        //printingjob.Enqueue(new PrinitingJop("budget.xlsx", 3));

        //while (printingjob.Count > 0)
        //{
        //    Console.ForegroundColor = ConsoleColor.Green;
        //    Console.WriteLine($"priniting... {printingjob.Dequeue()}");
        //    System.Threading.Thread.Sleep(1000);
        //}

        //Console.ForegroundColor = ConsoleColor.White; 
        #endregion


    }// end of main

    static void PrintStack(string name,  Stack<Command> stack)
    {
        Console.WriteLine($"{name} history:");
        Console.BackgroundColor = name.ToLower() == "back" ? ConsoleColor.DarkGreen : ConsoleColor.DarkBlue;
        foreach (var command in stack)
        {
            Console.WriteLine($"\t{command}");
        }
        Console.BackgroundColor = ConsoleColor.Black;

    }
}
