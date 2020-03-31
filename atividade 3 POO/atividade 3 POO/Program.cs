using System;

namespace atividade_3_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* menu*/
            Console.WriteLine("Aluno : Guilherme Pereira \n");
            Console.WriteLine("Selecione a opção desejada \n");
            Console.WriteLine(" 1: Carimbar ");
            Console.WriteLine(" 2: Escrever ");
            Console.Write(" Digite a opção desejada: ");
            /*recebe referencia*/
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            /* limpa a tela*/
            
            switch (opcao)
            {
                case 1:
                    
                    Console.WriteLine("Aluno : Guilherme Pereira\n ");
                    Console.WriteLine(" Opção selecionada ( Carimbar)\n ");
                    Console.Write(" Digite o texto desejado: ");
                    string Ptexto = Console.ReadLine();
                    carimbo x = new carimbo(Ptexto);
                    /* Atribuir valores e referencias nos atributos*/
                    Console.WriteLine("\n Carimbado!\n ");
                    x.carregar(" Azul", 10);
                    x.usar();
                    Console.WriteLine(" Deseja Alterar texto e cor? 1 alterar / 2 sair \n");
                    int selecao = Convert.ToInt32(Console.ReadLine());

                    switch (selecao)
                    {
                        case 1:

                            Console.Write("\n Digite o texto:");
                            string Gtexto = Console.ReadLine();
                            carimbo alteratexto = new carimbo(Gtexto);
                            x.trocaTexto(Gtexto);
                            x.trocarcor(" amarelo");
                            x.usar();
                            break;

                        case 2:
                            Console.Clear();
                            break;
                    }
                    
                    Console.ReadKey();

                    break;

                case 2:

                    Console.WriteLine("Aluno : Guilherme Pereira\n");
                    Console.WriteLine("Opção selecionada ( Escrever)\n ");
                    Console.Write(" Digite o texto desejado: \n");
                    string Ptexto2 = Console.ReadLine();
                    caneta y = new caneta(Ptexto2);
                    Console.WriteLine("\n Escrito!");
                    y.carregar(" Vermelho", 10);
                    y.usar();
                    Console.WriteLine(" Deseja Alterar texto e cor? 1 alterar / 2 sair \n");
                    int selecao2 = Convert.ToInt32(Console.ReadLine());

                    switch (selecao2)
                    {
                        case 1:

                            Console.Write("\n Digite o texto:");
                            string atexto = Console.ReadLine();
                            carimbo alteratexto = new carimbo(atexto);
                            y.trocaTexto(atexto);
                            y.trocarcor(" amarelo");
                            y.usar();
                            break;

                        case 2:
                            Console.Clear();
                            break;
                    }
                    Console.ReadKey();
                    break;

            }

        }
    }
}
