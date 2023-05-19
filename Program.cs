class Program{
    static void Main(string[] args){
        Console.Write("Enter the row number of Pascal's triangle: ");
        int row = int.Parse(Console.ReadLine());

        if (row < 0){
            Console.WriteLine("Invalid Pascal's triangle row number.");
            Console.Write("Enter the row number of Pascal's triangle: ");
            row = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= row; i++){
            int c = 1;
            for (int j = 0; j <= i; j++){
                Console.Write("{0} ", c);
                c = c * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}
