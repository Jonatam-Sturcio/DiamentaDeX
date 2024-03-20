namespace DiamentaDeX.ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {
            {
                Console.WriteLine("Digite o tamanho do diamante (deve ser um número ímpar): ");
                int tamanho = Convert.ToInt16(Console.ReadLine());

                if (tamanho % 2 == 0) {
                    Console.WriteLine("O tamanho do diamante deve ser um número ímpar.");
                    return;
                }

                int metade = tamanho / 2;

                for (int i = 0; i < tamanho; i++) {
                    for (int j = 0; j < tamanho; j++) {
                        if (i <= metade) {
                            if (j >= metade - i && j <= metade + i)
                                Console.Write("X");
                            else
                                Console.Write(" ");
                        }
                        else {
                            if (j >= i - metade && j <= tamanho - 1 - (i - metade))
                                Console.Write("X");
                            else
                                Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
