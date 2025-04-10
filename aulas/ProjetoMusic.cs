using System;

class Programa
{
  static void Main()
  {
    string MensagensDeBoasVindas = "seja muito bem vindo, Scream sound";

    Console.ForegroundColor = ConsoleColor.Red;
    Console.ResetColor();

    ExibirMensagemDeBoasVindas();
    ExibirOpcoesDoMenu();
  }

  static void ExibirOpcoesDoMenu()
  {

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda ");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite 0 para sair");

  }

  static void ExibirMensagemDeBoasVindas()
  {
    Console.ForegroundColor = ConsoleColor.Red;

    Console.WriteLine(@"  
╭━━━╮╱╱╱╱╱╱╱╱╱╱╱╱╱╱╭━━━╮╱╱╱╱╱╱╱╱╱╱╭╮
┃╭━╮┃╱╱╱╱╱╱╱╱╱╱╱╱╱╱┃╭━╮┃╱╱╱╱╱╱╱╱╱╱┃┃
┃╰━━┳━━┳━┳━━┳━━┳╮╭╮┃╰━━┳━━┳╮╭┳━╮╭━╯┃
╰━━╮┃╭━┫╭┫┃━┫╭╮┃╰╯┃╰━━╮┃╭╮┃┃┃┃╭╮┫╭╮┃
┃╰━╯┃╰━┫┃┃┃━┫╭╮┃┃┃┃┃╰━╯┃╰╯┃╰╯┃┃┃┃╰╯┃
╰━━━┻━━┻╯╰━━┻╯╰┻┻┻╯╰━━━┻━━┻━━┻╯╰┻━━╯");
    Console.WriteLine("seja muito bem vindo");

    Console.ResetColor();
  }
}
