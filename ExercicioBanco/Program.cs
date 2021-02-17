using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c = new Cliente();
            Endereco e = new Endereco();
            Conta d = new Conta();

            int escolherMenu = 0;

            Cliente[] clientes = new Cliente[10];

            /*for(int i = 0; i <10; i++)
            {
                clientes[i] = 
            }*/

            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("\n1- Informar dados da conta a ser criada.");
                Console.WriteLine("2- Fazer Depósito.");
                Console.WriteLine("3- Fazer Saque.");
                Console.WriteLine("4- Fazer uma Transferência.");
                Console.WriteLine("5- Verificar Saldo.");

                Console.WriteLine("\nEscolha uma das opções acima:");
                escolherMenu = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                switch (escolherMenu)
                {
                    case 1:
                        LendoDados(c, e, d);
                        break;
                    case 2:
                        //fazer deposito
                        Console.WriteLine("Informe os dados da Conta na qual deseja realizar o depósito:");
                        Console.Write("Agência: ");
                        d.Agencia = Console.ReadLine();
                        Console.Write("Número da Conta: ");
                        d.NumConta = Console.ReadLine();
                        Console.Write("Valor: ");
                        d.Valor = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        break;
                    case 3:
                        //fazer saque
                        Console.WriteLine("Informe o valor que deseja sacar: ");
                        d.Valor = int.Parse(Console.ReadLine());
                        if (d.Valor <= d.Saldo)
                        {
                            d.Saldo = d.Saldo - d.Valor;
                        }else
                        {
                            Console.WriteLine("\nSaldo Indisponível!");
                        }
                        break;
                    case 4:
                        //fazer uma transferência
                        Console.WriteLine("Informe os dados da Conta Origem:");
                        Console.Write("Agência: ");
                        d.Agencia = Console.ReadLine();
                        Console.Write("Número da Conta: ");
                        d.NumConta = Console.ReadLine();
                        Console.WriteLine("\nInforme os dados da Conta Destino:");
                        Console.Write("Agência: ");
                        d.Agencia = Console.ReadLine();
                        Console.Write("Número da Conta: ");
                        d.NumConta = Console.ReadLine();
                        Console.WriteLine("\nInforme o valor a ser transferido:");
                        Console.Write("Valor: ");
                        d.Valor = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Seu saldo é: " + d.Saldo);
                        break;
                }
            } while (escolherMenu != 6);


            Console.ReadKey();
        }

        static void LendoDados(Cliente c, Endereco e, Conta d)
        {
            Console.WriteLine("");
            Console.WriteLine("Informe os dados do Cliente:");
            Console.Write("CPF: ");
            c.Cpf = Console.ReadLine();
            Console.Write("Nome: ");
            c.Nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Informe o endereço:");
            Console.Write("Logradouro: ");
            e.Logradouro = Console.ReadLine();
            Console.Write("Número: ");
            e.Numero = int.Parse(Console.ReadLine());
            Console.Write("Localidade: ");
            e.Localidade = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Informe os dados da Conta:");
            Console.Write("Agência: ");
            d.Agencia = Console.ReadLine();
            Console.Write("Número da Conta: ");
            d.NumConta = Console.ReadLine();
            Console.Write("Saldo: ");
            d.Saldo = int.Parse(Console.ReadLine());
            Console.WriteLine("");
        }
        
    }
}
