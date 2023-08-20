using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace MinhaAgenda // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string tarefa = string.Empty;
            int tarefaFinalizada = 0;
            List<string> listaTarefas = new List<string>();
            bool agenda = true;

            while (agenda == true)
            {
                int tamanhoLista = listaTarefas.Count;
                ChamarInicio();
                opcao = 0;
                opcao = int.Parse(Console.ReadLine());
                while (opcao > 5 || opcao < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número inválido!");
                    Console.ForegroundColor = ConsoleColor.White;
                    opcao = int.Parse(Console.ReadLine());
                }

                switch (opcao)
                {
                    case 1:

                        if (tamanhoLista == 0) 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            System.Console.WriteLine("Não há tarefas na lista");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            for (int i = 0; i != listaTarefas.Count; i++)
                            {                              
                                
                                Console.WriteLine(string.Format("{0} - {1}", i + 1, listaTarefas[i]));
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                        
                        break;

                    case 2:
                        System.Console.WriteLine("Digite a tarefa: ");
                        tarefa = Console.ReadLine();
                        listaTarefas.Add(tarefa);
                        break;

                    case 3:
                        
                        for (int i = 0; i != listaTarefas.Count; i++)
                            {
                                Console.WriteLine(string.Format("{0} - {1}", i + 1, listaTarefas[i]));
                            }

                            System.Console.WriteLine("Digite o número da tarefa que foi finalizada");
                            tarefaFinalizada = int.Parse(Console.ReadLine());
                            for (int j = 0; j != listaTarefas.Count; j++)
                            {
                                    if (j + 1 == tarefaFinalizada)
                                        {
                                           listaTarefas.RemoveAt(j);

                                        }

                                Console.WriteLine(string.Format("{0} - {1}", j + 1, listaTarefas[j]));
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                    break;

                    case 4:
                            agenda = false;
                    break;

                }
            }
        }

        public static void ChamarInicio()
        {
            Console.WriteLine("Bem-vindo à sua agenda de tarefas!");
            Console.WriteLine("O que você quer fazer? Digite o número correspondente:");
            Console.WriteLine("1 - Ver a lista de tarefas");
            Console.WriteLine("2 - Adicionar uma tarefa");
            Console.WriteLine("3 - Excluir tarefa");
            Console.WriteLine("4 - Sair do aplicativo");
            Console.WriteLine("As tarefas marcadas como finalizadas aparecerão em verde");
        }

    }



}

