using System;

class HelloWorld {
    public static int Main(string[] args) {
        Console.WriteLine("введите слово");
        string word = Console.ReadLine();
        if (args.Length == 1) {
            int N = Int32.Parse(args[0]);
            int num = 20;
            for (int i = 1; i <=N; i++) {
                num += 2 / i;
            }Console.WriteLine(num);
            return 0;
        }
        else {
            Console.WriteLine("No N provided!");
            return 1;
        }
    }
}



