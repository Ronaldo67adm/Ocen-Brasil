using System;

namespace Elevador
{
    class Elevador
    {
        static void Main(string[] args)
        {//SAUDAÇÃO AO USUÁRIO
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Bem vindo(a) ao nosso elevador");
            Console.WriteLine("Vamos começar?");
            Console.WriteLine("Você pode digitar a letra s a qualquer momento para terminar o programa.");
            Console.WriteLine("Por favor não digite qualquer outra letra e nem números negativos, ok?");
            Console.WriteLine("------------------------------------------");
         //EMBARQUE INICIAL DE PASSAGEIROS
            int capacidade;
            int andaresDoPredio = Inicializar(out capacidade);
            Console.WriteLine("Ok!");
            Console.WriteLine($"O prédio tem {andaresDoPredio} andares.");
            Console.WriteLine($"A capacidade do elevador é {capacidade} pessoas.");
            Retorno:
            Console.WriteLine("Começamos com o elevador no andar térreo e vazio. Quantas pessoas vão entrar?");
            int passageiros = Validar(Console.ReadLine());
            if (passageiros > capacidade)
            {
                Console.WriteLine("Capacidade excedida. Por gentileza corrija a quantidade");
                goto Retorno;
            }
            Console.WriteLine($"OK,o elevador está agora com {passageiros} pessoas.");
            int andarAtual = 0;

            while (true)
            {
            //MOVIMENTAÇÀO DO ELEVADOR
            Andar:
                Console.WriteLine("Para qual andar o elevador deve ir?");
                int destino = Validar(Console.ReadLine());
                if (destino <= andaresDoPredio)
                {
                    if (destino > andarAtual)
                    {
                        andarAtual = Subir(destino);

                    }
                    else if (destino < andarAtual)
                    {
                        andarAtual = Descer(destino);
                    }
                    else
                    {
                        Console.WriteLine($"O Elevador já se encontra no {andarAtual}º andar");
                        goto Andar;
                    }
                }
                else
                {
                    Console.WriteLine("Andar escolhido está acima do número de andares do prédio. Corrija, por favor");
                    goto Andar;
                }
                //EMBARQUE E DESEMBARQUE DE PASSAGEIROS
                bool totalEmbarcado = false;
                while (totalEmbarcado == false)
                {
                    int decrescimo = Sair(passageiros, capacidade);
                    passageiros -= decrescimo;
                    int acrescimo = Entrar(passageiros, capacidade);
                    int resultado = passageiros + acrescimo;
                    if (resultado > capacidade)
                    {
                        Console.WriteLine("Capacidade excedida. Por gentileza, corrija as quantidades");
                    }
                    else
                    {
                        passageiros = resultado;
                        Console.WriteLine($"O elevador está com {passageiros} pessoas");
                        totalEmbarcado = true;
                    }
                }
            }
        }
        //FORNECIMENTO DE PARAMETROS INICIAIS
        static int Inicializar(out int capacidade)
        {
            Console.WriteLine("Para começar, responda duas perguntas:");
            Inicio:
            Console.WriteLine("Quantos andares tem o prédio");
            int _andaresDoPredio = Validar(Console.ReadLine());
            if (_andaresDoPredio == 0)
            {
                Console.WriteLine("Elevador em construção térrea não combina. Vamos tentar novamente?");
                goto Inicio;
            }

            Console.WriteLine("Quantas pessoas cabem no elevador");
            capacidade = Validar(Console.ReadLine());
            
            return _andaresDoPredio;
        }
        //METODO DE EMBARQUE
        static int Entrar(int _passageiros,int _capacidade)
        {
            Console.WriteLine("Quantas pessoas vão entrar?");
            int embarque = Validar(Console.ReadLine());
            
            while (_capacidade < (_passageiros+embarque))
            {
                Console.WriteLine("Epa! Capacidade excedida, informe outro total");
                embarque = Validar(Console.ReadLine());
            }
            Console.WriteLine($"Ok, entrando {embarque} pessoas!");
            return embarque;
        }
        //METODO DESEMBARQUE
        static int Sair(int _passageiros, int _capacidade)
        {
            Console.WriteLine("Quantas pessoas vão sair?");
            int desembarque = Validar(Console.ReadLine());

            while (_capacidade < desembarque || desembarque > _passageiros)
            {
                Console.WriteLine($"Opa! O elevador está com {_passageiros} pessoas. Não dá para sair mais que isso. Diga um novo total");
                desembarque = Validar(Console.ReadLine());
            }
            int total = _passageiros - desembarque;
            Console.WriteLine($"Ok, saindo {desembarque} pessoas! O elevador está com {total} pessoas");
            return desembarque;
        }
        //METODO PARA SUBIR ANDARES
        static int Subir(int _destino)
        {
            Console.WriteLine($"Elevador subindo para {_destino}º andar");
            int _andarAtual = _destino;
            Console.WriteLine($"Elevador está parado no {_andarAtual}º andar");
            return _andarAtual;
        }
        //METODO PARA DESCER ANDARES
        static int Descer(int _destino)
        {
            Console.WriteLine($"Elevador descendo para {_destino}º andar");
            int _andarAtual = _destino;
            Console.WriteLine($"Elevador está parado no {_andarAtual}º andar");
            return _andarAtual;
        }
        //METODO PARA VALIDAR DADOS INSERIDOS
        static int Validar(string _verificar)
        {
            Comeco:
            char check = _verificar[0];
            //DEFINE SAIDA
            if (_verificar == "S" || _verificar == "s")
            {
                Console.WriteLine("Foi muito bom estar com você. Até a próxima! Tchau!");
                Environment.Exit(0);
            //VERIFICA SE DIGITOU LETRA
            } else if (!Char.IsNumber(check))
            {
                Console.WriteLine("Desculpe, não entendi. Por favor, digite ou um número positivo ou a letra s");
                _verificar = Console.ReadLine();
                goto Comeco;
            }
            //VERIFICA SE DIGITOU NUMERO NEGATIVO
            int _validado = int.Parse(_verificar);
            if (_validado < 0)
            {
                Console.WriteLine("Desculpe, não entendi. Por favor, digite ou um número positivo ou a letra s");
                _verificar = Console.ReadLine();
                goto Comeco;
            }
            return _validado;
            
        }
    }
}
