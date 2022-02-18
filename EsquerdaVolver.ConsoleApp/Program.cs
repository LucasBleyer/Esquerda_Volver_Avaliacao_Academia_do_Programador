using System;

namespace EsquerdaVolver.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char comando, bussola = 'N';

            Console.Write("Digite o número de comados emitidos pelo sargento: ");
            int numeros_comandos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\r\nInforme os comandos a serem seguidos pelo recruta");
            Console.WriteLine("[E] Esquerda, [D] Direita");
            for (int i = 1; i <= numeros_comandos; i++)
            {
                Console.Write(i + "° Comando: ");
                comando = Convert.ToChar(Console.ReadLine().ToLower());

                if (comando == 'D')
                {
                    switch (bussola)
                    {
                        case 'N':
                            bussola = 'L';
                            break;
                        case 'S':
                            bussola = 'O';
                            break;
                        case 'L':
                            bussola = 'S';
                            break;
                        case 'O':
                            bussola = 'N';
                            break;
                    }
                }

                if (comando == 'E')
                {
                    switch (bussola)
                    {
                        case 'N':
                            bussola = 'O';
                            break;
                        case 'S':
                            bussola = 'L';
                            break;
                        case 'L':
                            bussola = 'N';
                            break;
                        case 'O':
                            bussola = 'S';
                            break;
                    }
                }
            }
            Console.WriteLine("\r\nDireção onde o recruta está com sua face voltada: " + bussola);
        }
    }
}
