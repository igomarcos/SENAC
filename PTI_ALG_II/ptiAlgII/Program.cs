namespace ptiAlgoritmoII
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(" Digite o tamanho do vetor: ");
            bool verificacao = int.TryParse(Console.ReadLine(), out int tamanhoVetor);

            int[] array = new int[tamanhoVetor];

            for (int i = 0; i < tamanhoVetor; i++)
            {
                Console.WriteLine($" Digite o {i + 1}º número ");
                verificacao = int.TryParse(Console.ReadLine(), out int x);
                array.SetValue(x, i);
            }

            int diferenca = FuncaoDiferenca(array);
            Console.WriteLine("Resposta da A: A maior diferença é " + diferenca);

            bool comparar = CompararArrayCrescente(array);
            Console.WriteLine("Resposta da B: " + comparar);


        }
        public static int FuncaoDiferenca(int[] numeros)
        {
            int maiorValor = numeros.Max();
            int menorValor = numeros.Min();
            int diferenca = maiorValor - menorValor;

            return diferenca;
        }

        public static bool CompararArrayCrescente(int[] listNumeros)

        {
            for (int i = 0; i < listNumeros.Length; i++)
            {

                if ((i + 1) < listNumeros.Length)
                {
                    var num1 = listNumeros[i];
                    var num2 = listNumeros[i + 1];
                    if (num1 > num2)
                    {
                        return false;
                    }
                }
            }

            return true;
        }


    }
}