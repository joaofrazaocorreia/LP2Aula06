using System;
using System.IO;

namespace FileStreams
{
    public class Program
    {
        // Nomes dos ficheiros
        private const string filenameText = "dados.txt";
        private const string filenameBinary = "dados.bin";

        // Dados a escrever e ler nos ficheiros
        private const string dataString = "Hello world!";
        private const int dataInt = 18;
        private const float dataFloat = 3.1415f;

        private static void Main()
        {
            // String para onde ler opção inserida pelo utilizador
            string option;

            // Ciclo do menu principal
            do
            {
                // Apresentar menu principal
                Console.WriteLine("==== Que programa devo executar? ==== \n");
                Console.WriteLine("\t1. Escreve ficheiro em modo de texto");
                Console.WriteLine("\t2. Lê ficheiro em modo de texto");
                Console.WriteLine("\t3. Escreve ficheiro em modo binário");
                Console.WriteLine("\t4. Lê ficheiro em modo binário");
                Console.WriteLine("\t5. Sair");
                Console.Write("\n>");

                // Solicitar opção ao utilizador
                option = Console.ReadLine();

                // Tratar opção do utilizador
                switch (option)
                {
                    case "1":
                        EscreverTexto(); break;
                    case "2":
                        LerTexto(); break;
                    case "3":
                        EscreverBin(); break;
                    case "4":
                        LerBin(); break;
                    case "5":
                        Console.WriteLine("Obrigado e até à próxima!");
                        break;
                    default:
                        Console.WriteLine("**** Opção inválida! ****");
                        break;
                }

                Console.WriteLine(
                    "Pressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (option != "5");
        }

        // 1. Escreve ficheiro em modo de texto
        private static void EscreverTexto()
        {
            using TextWriter tw = File.CreateText(filenameText);

            tw.WriteLine(dataString);
            tw.WriteLine(dataFloat);
            tw.WriteLine(dataInt);
        }

        // 2. Lê ficheiro em modo de texto
        private static void LerTexto()
        {
            using TextReader tr = File.OpenText(filenameText);

            string str = tr.ReadLine();
            float fl = float.Parse(tr.ReadLine());
            int i = int.Parse(tr.ReadLine());

            Console.WriteLine(str+" "+fl+" "+i);
        }

        // 3. Escreve ficheiro em modo binário
        private static void EscreverBin()
        {
            using Stream fs = File.Create(filenameBinary);
            using BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(dataString);
            bw.Write(dataFloat);
            bw.Write(dataInt);
        }

        // 4. Lê ficheiro em modo binário
        private static void LerBin()
        {
            using Stream fr = File.OpenRead(filenameBinary);
            using BinaryReader br = new BinaryReader(fr);

            string str = br.ReadString();
            float fl = br.ReadSingle();
            int i = br.ReadInt32();

            Console.WriteLine(str+" "+fl+" "+i);
        }
    }
}
