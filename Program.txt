// See https://aka.ms/new-console-template for more information

using UC12_ER2.Classes;


Console.WriteLine(@$"
========================================================================================
|                       Bem vindo ao sistema de cadastro de                             |
|                            Pessoas Físicas e Jurídicas                                |                       
========================================================================================
");

/*
Console.BackgroundColor = ConsoleColor.DarkGray;
Console.ForegroundColor = ConsoleColor.DarkBlue;

Console.Write("Carregando");

for (var contador = 0; contador < 35; contador++)
{
    Console.Write(". ");
    Thread.Sleep(100);
}

Console.ResetColor();
*/

BarraCarregamento("Carregando", 50);

List<PessoaFisica> listaPf = new List<PessoaFisica>();
List<PessoaJuridica> listaPj = new List<PessoaJuridica>();



string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================================================================
|                       Escolha uma das opções a seguir:                                    |
|___________________________________________________________________________________________|
|                                                                                           |
|                             1 - Pessoa Física                                             |            
|                             2 - Pessoa Jurídica                                           |
|                                                                                           |     
|                             0 - Sair                                                      |             
=============================================================================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            PessoaFisica metodoPf = new PessoaFisica();

            string? opcaoPf;
            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=============================================================================================
|                       Escolha uma das opções a seguir:                                    |
|___________________________________________________________________________________________|
|                                                                                           |
|                             1 - Cadastrar Pessoa Física                                   |            
|                             2 - Mostrar Pessoa Física                                     |
|                                                                                           |     
|                             0 - Sair                                                      |             
=============================================================================================
");

                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":

                    

                        // string? resposta;


                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEnd = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física que deseja cadastrar");
                        novaPf.nome = Console.ReadLine();
/*
                        bool dataValida;

                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex.: DD/MM/AAAA");
                            string dataNasc = Console.ReadLine();

                            dataValida = metodoPf.ValidarDataNascimento(dataNasc);

                            if (dataValida)
                            {
                                novaPf.dataNascimento = dataNasc;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine($"Data digitada é inválida, por favor digite uma data válida");
                                Console.ResetColor();

                            }

                        } while (dataValida == false);
*/


                        Console.WriteLine($"Digite o número do CPF");
                        novaPf.cpf = Console.ReadLine();
/*
                        Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
                        novaPf.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEnd.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEnd.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento (aperte ENTER para vazio)");
                        novoEnd.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? [S ou N]");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEnd.endComercial = true;
                        }
                        else
                        {
                            novoEnd.endComercial = false;
                        }

                        novaPf.endereco = novoEnd;
                        //listaPf.Add(novaPf);

                        */

                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        {
                           sw.WriteLine($"{novaPf.nome}");
                           sw.WriteLine($"{novaPf.cpf}");
                        }                   
                        // sw.WriteLine(novaPf.nome);
                        // sw.Close();

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro Realizado com Sucesso!!!");
                        Console.ResetColor();
                        Thread.Sleep(2000);
                        break;
                    case "2":
                        Console.Clear();

/*
                        if (listaPf.Count > 0)
                        {
                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"
                            Nome: {cadaPessoa.nome}
                            Endereço: {cadaPessoa.endereco.logradouro}, {cadaPessoa.endereco.numero}
                            Maior de idade: {cadaPessoa.dataNascimento}
                            Taxa de imposto a ser paga é: {metodoPf.PagarImposto(cadaPessoa.rendimento).ToString("C")}
                            ");
                        Console.WriteLine($"Aperte 'Enter' para continuar");
                        Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Lista Vazia!!!");
                            Thread.Sleep(3000);
                            
                        }
*/ 

                        using (StreamReader sr = new StreamReader($"Luis.txt"))
                        {
                           string linha;
                           while ((linha = sr.ReadLine())!= null)
                           {
                            Console.WriteLine($"{linha}");
                           }
                        }     

                        Console.WriteLine($"Aperte 'Enter' para continuar...");
                        Console.ReadLine();
                        
                        

                        break;
                    case "0":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Opção Inválida, por favor digite outra opção.");
                        Thread.Sleep(2000);
                        break;
                }


            } while (opcaoPf != "0");


            /*
                        Console.WriteLine(@$"
                            Nome: {novaPf.nome}
                            Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
                            Maior de idade: {(metodoPf.ValidarDataNascimento(novaPf.dataNascimento) ? "Sim" : "Não")}
                            Taxa de imposto a ser paga é: {metodoPf.PagarImposto(novaPf.rendimento).ToString("C")}
                            ");
                        Console.WriteLine($"Aperte 'Enter' para continuar");
                        Console.ReadLine();
                        */
            break;
        case "2":

            
            PessoaJuridica metodoPj = new PessoaJuridica();

            

            string? opcaoPj;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"

=============================================================================================
|                       Escolha uma das opções a seguir:                                    |
|___________________________________________________________________________________________|
|                                                                                           |
|                             1 - Cadastrar Pessoa Jurídica                                 |            
|                             2 - Mostrar Pessoa Jurídica                                   |
|                                                                                           |     
|                             0 - Sair                                                      |             
=============================================================================================                
");

            opcaoPj = Console.ReadLine();

        switch (opcaoPj)
        {
            case "1":

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

             novaPj.nome = Console.ReadLine();

          

            Console.WriteLine($"Digite o nome do CNPJ que desejacadastrar:");
            
           

            bool cnpjValido;

            do
            {
                Console.WriteLine($"Digite o CNPJ. Ex.:'XX.XXX.XXX/0001-XX'");
                string numCNPJ = Console.ReadLine();

                cnpjValido = metodoPj.ValidarCnpj(numCNPJ);

                if (cnpjValido)
                {
                    novaPj.cnpj = numCNPJ;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine($"CNPJ digitado é inválido, por favor digite um CNPJ válido");
                    Console.ResetColor();
                }
                    
            } while (cnpjValido == false);

            Console.WriteLine($"Digita a razão social");
            novaPj.razaosocial = Console.ReadLine();

            Console.WriteLine($"Digite o rendimento mensal (digite apenas números)");
            novaPj.rendimento = float.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o logradouro");
            novoEndPj.logradouro = Console.ReadLine();
            
            Console.WriteLine($"Digite o número");
            novoEndPj.numero = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite o complemento (aperte ENTER para vazio)");
            novoEndPj.complemento = Console.ReadLine();
            
            Console.WriteLine($"Este endereço é comercial? [S ou N]");
            string endComPj = Console.ReadLine().ToUpper();
            
            if (endComPj == "S")
            {
                novoEndPj.endComercial = true;
            }
            else
            {
                novoEndPj.endComercial = false;
            }
            
            novaPj.endereco = novoEndPj; // objeto endereço valido tanto para pessoa fisica como juridica

            listaPj.Add(novaPj);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Cadastro realizado com Sucesso!!!");
            Console.ResetColor();
            Thread.Sleep(2000);
                                   
            // OK novaPj.cnpj = "00000000000100";
            // OK novaPj.razaosocial = "Razao Social Pj";
            // OK novaPj.rendimento = 8000.5f;
            // OK novoEndPj.logradouro = "Alameda Barao de Limeira";
            // ok novoEndPj.numero = 539;
            // ok novoEndPj.complemento = "Senai Informatica";
            // ok novoEndPj.endComercial = true;
            // novaPj.endereco = novoEndPj;
                metodoPj.Inserir(novaPj);

                break;

               case "2":
               Console.Clear();

                if (listaPj.Count > 0)
                {
                    foreach (PessoaJuridica cadaPj in listaPj)
                    {
                        Console.Clear();
            Console.WriteLine(@$"
                Nome: {cadaPj.nome}
                Razao social: {cadaPj.razaosocial}
                CNPJ: {cadaPj.cnpj}
                Endereço: {cadaPj.endereco.logradouro}, {cadaPj.endereco.numero}, {cadaPj.endereco.complemento}
                Comercial: {cadaPj.endereco.endComercial}
                Taxa de imposto a ser paga é: {metodoPj.PagarImposto(cadaPj.rendimento).ToString("C")}
                ");
                Console.WriteLine($"Aperte 'Enter' para confirmar retorno ao menu anterior");
                Console.ReadLine();              
                    }
                }
                else
                {
                    Console.WriteLine($"Lista Vazia!!!");
                    BarraCarregamento("Voltando ao menu anterior",1000);
                
                }

            


                break;  

                 case "0":
                break;

            default:
            Console.Clear();
            Console.WriteLine($"Opção Inválida, por favor digite outra opção");
            Thread.Sleep(2000);
                break;
        }
        
                
            } while (opcaoPj != "0");

            // Console.WriteLine(@$"
            //     Nome: {novaPj.nome}
            //     Razao social: {novaPj.razaosocial}
            //     CNPJ: {novaPj.cnpj}
            //     CNPJ é válido: {(metodoPj.ValidarCnpj(novaPj.cnpj) ? "Sim" : "Não")}
            //     Taxa de imposto a ser paga é: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
            //     ");
            
            Console.WriteLine($"Aperte 'Enter' para continuar");
            Console.ReadLine();
            break;
            
        case "0":
            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema");

            /* 
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"Finalizando");

            for (var contador = 0; contador < 35; contador++)
            {
                Console.Write(". ");
                Thread.Sleep(100);
            }
            Console.ResetColor();
            */

            BarraCarregamento("Finalizando", 100);

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Opção inválida, por favor digite outra opção");
            Thread.Sleep(2000);
            break;
    }
} while (opcao != "0");

static void BarraCarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkGray;
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write($"{texto}");
    Thread.Sleep(tempo);

    for (var contador = 0; contador < 35; contador++)
    {
        Console.Write(". ");
        Thread.Sleep(75);
    }
    Console.ResetColor();
}







/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

PessoaFisica metodoPf = new PessoaFisica();


novaPf.nome = "Luiz";
novaPf.dataNascimento = "18/02/1984";
novaPf.cpf = "12345678900";
novaPf.rendimento = 600.0f;

novoEnd.logradouro = "Alameda Barao de Limeira";
novoEnd.numero = 539;
novoEnd.complemento = "Senai Informatica" ;
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");
*/




/*
novaPf.nome = "Lozano";

Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}");
PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();
novaPj.nome = "NomePj";
novaPj.cnpj = "00000000000100";
novaPj.razaosocial = "Razao Social Pj";
novoEndPj.logradouro = "Alameda Barao de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "Senai Informatica" ;
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;
Console.WriteLine(@$"
Nome: {novaPj.nome}
Razao social: {novaPj.razaosocial}
CNPJ: {novaPj.cnpj}
CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");

// antes estava comentado só até aqui

// Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime(2000,01,01)));

// Console.WriteLine(novaPf.ValidarDataNascimento("01/01/2000"));

*/