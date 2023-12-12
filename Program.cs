
public abstract class corpo
{
    public string Nome { get; set; }
    public double idade { get; set; }
    public string Dnasci { get; set; }
    public string Dfaleci { get; set; }
    public string genero { get; set; }
    public string testo { get; set; }
    public string conf { get; set; }
    public string dia { get; set; }
    public string mes { get; set; }
    public string ano { get; set; }

    public abstract void laudo();
    public abstract void lapide();
    public abstract void lapidect();
    public abstract void execucao1();

}

public class Mulher : corpo
{

    public override void laudo()
    {
        Console.WriteLine("Confirmacao de informacoes da falecida\nNome: " + Nome + " \nIdade: " + idade + "\nGenero: " + genero + "\nData De Nascimento: " + Dnasci + "\nData De Falecimento: " + Dfaleci);
    }

    public override void lapide()
    {
        Console.WriteLine(Nome + "\n\n* " + Dnasci + "\n\n+ " + Dfaleci + "\n\nSua luz brilhará para sempre em nossos corações.");
    }

    public override void lapidect()
    {
        Console.WriteLine(Nome + "\n\n* " + Dnasci + "\n\n+ " + Dfaleci + "\n\n" + testo);
    }

    public override void execucao1()
    {
        Console.Write("Idade: ");
        idade = Int32.Parse(Console.ReadLine());
        
         Console.Write("Data De Nascimento: ");
         Dnasci = Console.ReadLine();
           
          dia = Dnasci.Substring(0, 2);
          mes = Dnasci.Substring(2, 2);
          ano = Dnasci.Substring(4, 4);
          Dnasci = string.Concat(dia, "/", mes, "/", ano);
           


        Console.Write("Data De Falecimento: ");
        Dfaleci = Console.ReadLine();

         dia = Dfaleci.Substring(0, 2);
         mes = Dfaleci.Substring(2, 2);
         ano = Dfaleci.Substring(4, 4);
         Dfaleci = string.Concat(dia, "/", mes, "/", ano);

        Console.Clear();
        laudo();

        Console.WriteLine("As informacoes acima estao corretas\nSe sim digite S,senao digite N");
        conf = Console.ReadLine();
        switch (conf)
        {

            case "N":
                Console.WriteLine("Ok! Digite as informacoes corretas");
                break;

            case "S":
                Console.WriteLine("informacoes cadastradas com sucesso");
                break;

            default:
                Console.Write("informacao incorreta,preencha o campo novamente");
                break;

        }
    }

}


public class homem : corpo
{

    public override void laudo()
    {
        Console.WriteLine("Confirmacao de informacoes do falecido\nNome: " + Nome + " \nIdade: " + idade + "\nGenero: " + genero + "\nData De Nascimento: " + Dnasci + "\nData De Falecimento: " + Dfaleci);
    }

    public override void lapide()
    {
        Console.WriteLine(Nome + "\n\n* " + Dnasci + "\n\n+ " + Dfaleci + "\n\nSua luz brilhará para sempre em nossos corações.");
    }

    public override void lapidect()
    {
        Console.WriteLine(Nome + "\n\n* " + Dnasci + "\n\n+ " + Dfaleci + "\n\n" + testo);
    }

    public override void execucao1()
    {
        Console.Write("Idade: ");
        idade = Int32.Parse(Console.ReadLine());

        Console.Write("Data De Nascimento: ");
        Dnasci = Console.ReadLine();

         dia = Dnasci.Substring(0, 2);
         mes = Dnasci.Substring(2, 2);
         ano = Dnasci.Substring(4, 4);
         Dnasci = string.Concat(dia, "/", mes, "/", ano);

        Console.Write("Data De Falecimento: ");
        Dfaleci = Console.ReadLine();
        
         dia = Dfaleci.Substring(0, 2);
         mes = Dfaleci.Substring(2, 2);
         ano = Dfaleci.Substring(4, 4);
         Dfaleci = string.Concat(dia, "/", mes, "/", ano);

        Console.Clear();
        laudo();

        Console.WriteLine("As informacoes acima estao corretas\nSe sim digite S,senao digite N");
        conf = Console.ReadLine();

        switch (conf)
        {

            case "N":
                Console.WriteLine("Ok! Digite as informacoes corretas");
                break;

            case "S":
                Console.WriteLine("informacoes cadastradas com sucesso");
                break;

            default:
                Console.Write("informacao incorreta,preencha o campo novamente");
                break;
        }

    }

}

public class caixao
{
    public double vtmadeira { get; set; }
    public double vestilo { get; set; }
    public double vcor { get; set; }
    public double vmaquiagem { get; set; }
    public double vlapide { get; set; }
    public string tmadeira { get; set; }
    public string estilo { get; set; }
    public string cor { get; set; }
    public string maquiagem { get; set; }
    public double total { get; set; }
    public double troco { get; set; }
    public double pagamento { get; set; }
    public double opcaoPagamento { get; set; }
    public double teste { get; set; }
    public string opcao { get; set; }
    public string conf { get; set; }


    public void coninf()
    {
        Console.WriteLine("Confirmacao de informacoes de caixao\nTipo de Madeira: " + tmadeira + "\nEstilo do Caixao: " + estilo + "\nCor do Caixao: " + cor);
    }

    public void vapagar()
    {
        vlapide = 30.00;
        total = vtmadeira + vestilo + vcor + vmaquiagem + vlapide + 150.00;
        Console.WriteLine("Total Geral\nMadeira = R$" + vtmadeira + "\nEstilo = R$" + vestilo + "\nCor = R$" + vcor + "\nMaquiagem = R$" + vmaquiagem + "\nLapide = R$" + vlapide + "\nMao de Obra = R$150\nTotal = R$" + total);
    }

    public void pagar()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("Total: " + total);
            Console.WriteLine("Deseja pagar com débito, crédito ou à vista?");
            Console.WriteLine("1 - Débito");
            Console.WriteLine("2 - Crédito");
            Console.WriteLine("3 - À vista");
            Console.WriteLine("Digite apenas o numero");
            opcaoPagamento = Convert.ToDouble(Console.ReadLine());

            if (opcaoPagamento == 1 || opcaoPagamento == 2 || opcaoPagamento == 3)
            {
                Console.WriteLine("Digite o valor do pagamento: ");
                pagamento = Convert.ToDouble(Console.ReadLine());

                if (opcaoPagamento == 3)
                {
                    troco = pagamento - total;
                    if (troco >= 0)
                    {
                        Console.WriteLine("Seu troco é: " + troco);
                        teste = 1;
                    }
                    else if (troco < 0)
                    {
                        Console.WriteLine("pagamento invalido,dinheiro insuficiente");
                        teste = 0;
                    }
                }
                else
                {
                    Console.WriteLine("Pagamento realizado com sucesso!");
                    teste = 1;
                }
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente.");
                teste = 0;
            }
        } while (teste == 0);

    }

    public void execucao1()
    {
        Console.WriteLine("Agora voce devera escolher as informaçoes do caixao");
        do
        {
            Console.WriteLine("Esses sao os Tipos de Madeira\n1- MDF = R$350,00\n2- Carvalho = R$400,00\n3- Cerejeira = R$500,00\nDigite apenas o numero da opcao escolhida");
            opcao = Console.ReadLine();
            switch (opcao)
            {

                case "1":
                    vtmadeira = 350.00;
                    tmadeira = "MDF";
                    break;

                case "2":
                    vtmadeira = 400.00;
                    tmadeira = "Carvalho";
                    break;

                case "3":
                    vtmadeira = 500.00;
                    tmadeira = "Carejeira";
                    break;

                default:
                    Console.WriteLine("Tipo de madeira nao encontrada,informe um dos tipos de madeira acima");
                    break;

            }
            Console.WriteLine("Aperte enter para proseguir");
            Console.ReadLine();
            Console.Clear();
        } while (opcao != "1" && opcao != "2" && opcao != "3");
        do
        {
            Console.WriteLine("escolha agora o estilo do caixao");
            do
            {
                Console.WriteLine("Esses sao os estilos de caixao\n1- Classico = R$100,00\n2- Rustico = R$150,00\n3- Moderno = R$150,00\nDigite apenas o numero da opcao escolhida");
                opcao = Console.ReadLine();
                switch (opcao)
                {

                    case "1":
                        vestilo = 100.00;
                        estilo = "Classico";
                        break;

                    case "2":
                        vestilo = 150.00;
                        estilo = "Rustico";
                        break;

                    case "3":
                        vestilo = 150.00;
                        estilo = "Moderno";
                        break;

                    default:
                        Console.WriteLine("Estilo de caixao nao encontrado,informe um dos estilos de caixao acima");
                        break;

                }
                Console.WriteLine("Aperte enter para proseguir");
                Console.ReadLine();
                Console.Clear();
            } while (opcao != "1" && opcao != "2" && opcao != "3");
            Console.WriteLine("escolha agora a cor do caixao");
            do
            {
                Console.WriteLine("Essas sao as cores de caixao\n1- Preto = R$30,00\n2- Branco = R$40,00\n3- Vermelho = R$50,00\n4- Sem Cor = R$0,00\nDigite apenas o numero da opcao escolhida");
                opcao = Console.ReadLine();
                switch (opcao)
                {

                    case "1":
                        vcor = 30.00;
                        cor = "Preto";
                        break;

                    case "2":
                        vcor = 40.00;
                        cor = "Branco";
                        break;

                    case "3":
                        vcor = 50.00;
                        cor = "vermelho";
                        break;

                    case "4":
                        vcor = 0.00;
                        cor = "Sem Cor";
                        break;

                    default:
                        Console.WriteLine("Cor de caixao nao encontrado,informe uma das cores de caixao acima");
                        break;

                }
                Console.WriteLine("Aperte enter para proseguir");
                Console.ReadLine();
                Console.Clear();
            } while (opcao != "1" && opcao != "2" && opcao != "3" && opcao != "4");

            coninf();
            Console.WriteLine("As informacoes acima estao corretas\nSe sim digite S,senao digite N");
            conf = Console.ReadLine();

            switch (conf)
            {

                case "N":
                    Console.WriteLine("Ok! Digite as informacoes corretas");
                    break;

                case "S":
                    Console.WriteLine("informacoes cadastradas com sucesso");
                    break;

                default:
                    Console.Write("informacao incorreta,preencha o campo novamente");
                    break;
            }
            Console.Write("Para proceguir aperte Enter");
            Console.ReadLine();
            Console.Clear();
        } while (conf != "S");
    }

    public void execucao2()
    {
        do
        {
            Console.WriteLine("Voce deseja que facamos uma maquiagem no defunto?\nO valor da maquiagem e de R$20.00\nSe a resposta for sim digite S,se a resposta for nao digite N");
            conf = Console.ReadLine();

            switch (conf)
            {

                case "N":
                    vmaquiagem = 0.00;
                    maquiagem = "Nao";
                    break;

                case "S":
                    vmaquiagem = 20.00;
                    maquiagem = "Sim";
                    break;

                default:
                    Console.Write("informacao incorreta,preencha o campo novamente");
                    break;
            }
            Console.Write("Para proceguir aperte Enter");
            Console.ReadLine();
            Console.Clear();
        } while (conf != "S" && conf != "N");
    }

    public void execucao3()
    {
        do
        {
            do
            {
                Console.WriteLine("Confirmi agora os dados de pagamento");
                vapagar();
                Console.WriteLine("os dados estao corretos?\nSe sim digite S,senao digite N");
                conf = Console.ReadLine();

                switch (conf)
                {

                    case "N":
                        Console.WriteLine("Ok! entao altere os seus dados para os corretos");
                        break;

                    case "S":
                        Console.WriteLine("Dados confirmados com sucesso");
                        break;

                    default:
                        Console.Write("informacao incorreta,preencha o campo novamente");
                        break;
                }
            } while (conf != "S" && conf != "N");
        } while (conf != "S");
    }


}

public class local
{
    public string hospi { get; set; }
    public string lsepul { get; set; }
    public string data { get; set; }
    public string hora { get; set; }

    public void inflocal()
    {
        Console.Clear();
        Console.WriteLine("Agora que voce ja efetuou o pagamento informe:");
        do
        {
            Console.WriteLine("Em qual hospital o corpo esta localizado: ");
            hospi = Console.ReadLine();
            if (hospi == "")
            {
                Console.WriteLine("compo vazio,porfavor digite oque esta sendo pedido");
            }
        } while (hospi == "");
        do
        {
            Console.WriteLine("Local onde sera realizado o sepultamento: ");
            lsepul = Console.ReadLine();
            if (lsepul == "")
            {
                Console.WriteLine("compo vazio,porfavor digite oque esta sendo pedido");
            }
        } while (lsepul == "");
        Console.WriteLine("Data e hora do sepultamento");
        do
        {
            Console.Write("Data: ");
            data = Console.ReadLine();
            if (data == "")
            {
                Console.WriteLine("compo vazio,porfavor digite oque esta sendo pedido");
            }
        } while (data == "");
        do
        {
            Console.Write("Hora: ");
            hora = Console.ReadLine();
            if (hora == "")
            {
                Console.WriteLine("compo vazio,porfavor digite oque esta sendo pedido");
            }
        } while (hora == "");

    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("FUNERARIA OMAR,SUA MORTE NOSSA ALEGRIA\n");
        string genero = "";
        string conf = "";
        string nome = "";
        Mulher m1 = new Mulher();
        homem h1 = new homem();
        caixao c1 = new caixao();
        do
        {
            do
            {
                Console.WriteLine("Digite algumas informaçoes sobre o falecido\nDigite as informacoes com a 1ª letra maiuscula\nNas datas digite apenas os numeros");
                do
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    if (nome == "")
                    {
                        Console.WriteLine("compo vazio,porfavor digite oque esta sendo pedido");
                    }
                    else
                    {
                        m1.Nome = nome;
                        h1.Nome = nome;
                    }
                } while (nome == "");
                do
                {
                    Console.WriteLine("genero\n1- Masculino\n2- Feminino\nDigite apenas o numero da opcao");
                    genero = Console.ReadLine();
                    if (genero == "1")
                    {
                        genero = "Masculino";
                    }
                    else if (genero == "2")
                    {
                        genero = "Feminino";
                    }

                    switch (genero)
                    {
                        case "Feminino":
                            m1.genero = genero;
                            m1.execucao1();

                            break;

                        case "Masculino":
                            h1.genero = genero;
                            h1.execucao1();

                            break;

                        default:
                            Console.WriteLine("informaçao incorreta,escolha uma opcao valida");
                            break;

                    }


                } while (genero != "Masculino" && genero != "Feminino");

                Console.Write("Para proceguir aperte Enter");
                Console.ReadLine();
                Console.Clear();

            } while (h1.conf != "S" && m1.conf != "S");

            c1.execucao1();

            do
            {
                Console.WriteLine("Voce deseja escrever algo na lapide\nCaso sua resposta seja nao escreveremos uma frase padrao\nSe a resposta for sim digite S,se a resposta for nao digite N");
                conf = Console.ReadLine();

                switch (conf)
                {

                    case "N":
                        Console.WriteLine("Ok! A lapide ficara dessa forma\n");
                        if (genero == "Masculino")
                        {
                            h1.lapide();
                        }
                        else
                        {
                            m1.lapide();
                        }
                        break;

                    case "S":
                        Console.WriteLine("escreva aqui o testo");
                        string testo = Console.ReadLine();
                        m1.testo = testo;
                        h1.testo = testo;
                        Console.WriteLine("A lapide ficara desta forma\n");
                        if (genero == "Masculino")
                        {
                            h1.lapidect();
                        }
                        else
                        {
                            m1.lapidect();
                        }
                        break;

                    default:
                        Console.Write("informacao incorreta,preencha o campo novamente");
                        break;
                }
                Console.Write("Para proceguir aperte Enter");
                Console.ReadLine();
                Console.Clear();
            } while (conf != "S" && conf != "N");

            c1.execucao2();

            do
            {
                Console.WriteLine("confirme todas as informaçoes");
                if (genero == "Masculino")
                {
                    h1.laudo();
                }
                else
                {
                    m1.laudo();
                }
                c1.coninf();
                Console.WriteLine("Maquiagem: " + c1.maquiagem);
                Console.WriteLine("os dados estao corretos?\nSe sim digite S,senao digite N");
                conf = Console.ReadLine();

                switch (conf)
                {

                    case "N":
                        Console.WriteLine("Ok! entao altere os seus dados para os corretos");
                        break;

                    case "S":
                        Console.WriteLine("Dados confirmados com sucesso");
                        break;

                    default:
                        Console.Write("informacao incorreta,preencha o campo novamente");
                        break;
                }
            } while (conf != "S" && conf != "N");
            Console.Write("Para proceguir aperte Enter");
            Console.ReadLine();
            Console.Clear();
        } while (conf != "S");
        c1.execucao3();
        c1.pagar();
        local l1 = new local();
        l1.inflocal();
        Console.WriteLine("ok! iremos mandar uma equipe para o recolhimento do corpo ainda hoje\nFuneraria Omar agradece a sua preferencia.");


    }
}