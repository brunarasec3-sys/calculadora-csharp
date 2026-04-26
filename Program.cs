using System;
using System.Collections.Generic;

namespace ComputerArchitectureLab
{

class Program
{
    static void Main()
   {
      while (true)
      {
         Console.Clear(); 
         Console.WriteLine("=== Computer Architecture Lab === ");
         Console.WriteLine("1 - informações do Sistema");
         Console.WriteLine("2 - testar CPU");
         Console.WriteLine("3 - testar Memória");
         Console.WriteLine("4 - Sair");
         Console.Write("Escolha uma opção: ");

         string opcao = 
         Console.ReadLine();

         switch (opcao)
         {
            case "1":
                     MonstrarInformacoes();
                       break;
            case "2":
                     TestarCPU();
                       break;
            case "3":
                     Testarmemoria();
                     break;
            case "4":
                     return; 
            default:

         Console.WriteLine("Opção inválida.");
                     break;
         }


         Console.WriteLine("\nPressione qualquer tecla para continuar...");
         Console.ReadKey();
      }
   }
        static void 
        MonstrarInformacoes()
   {
      Console.WriteLine("\nInformações do Sistema:");

      Console.WriteLine($"Núcleos da CPU: {Environment.ProcessorCount}");

      Console.WriteLine($"Sistema Operacional 64 bits:{Environment.Is64BitOperatingSystem}");
   }

   static void TestarCPU()
   {
      Console.WriteLine("\nExecutando carga de CPU por 5 segundos...");
      var inicio = DateTime.Now;

      while((DateTime.Now - inicio).TotalSeconds < 5)
      {
         double x = Math.Sqrt(12345.6789);
      }
      Console.WriteLine("Teste de CPU finalizado.");
   } 

   static void Testarmemoria()
   {
      
      Console.WriteLine("\nConsumindo memória por 5 segundos...");
      var blocos = new System.Collections.Generic.List<byte[]>(); 
      var inicio = DateTime.Now ;

      while ((DateTime.Now - inicio).TotalSeconds < 5)
      {
         blocos.Add(new byte[10_000_000]);
      }

      Console.WriteLine("Teste de memória finalizado.");
   }
}
}
      
   
   




         
      
   

