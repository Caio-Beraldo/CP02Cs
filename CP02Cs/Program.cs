class CP02Cs
{
    const double media_aprovado = 7.0;
    static string nomeAluno = "";
    static double[] notas = new double[3];
    static void CadastrarAluno()
    {
        Console.WriteLine("Digite o nome do aluno:  ");
        nomeAluno = Console.ReadLine();
        Console.WriteLine("Aluno cadastrado com sucesso!");
    }
    static void lancarNotas()
    {
        
        for (int i = 0; i < notas.Length; i++)
        {
            double nota;
            while (true)
            {
                Console.WriteLine($"Digite a {i + 1} nota ");
                if (!double.TryParse(Console.ReadLine(), out nota))
                {
                    Console.WriteLine("Valor inválido");
                    continue;

                }
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("A nota deve ser entre 0 e 10");
                    continue;

                }
                notas[i] = nota;
                break;
            }
        }
        Console.WriteLine("Notas cadastradas com sucesso!");

    }
    static double CalcularMedia()
    {
        double soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];

        }
        double media = soma / notas.Length;
        return media;
    }
    static void mostrarSituacao(double media)
    {
        if (media >= media_aprovado)
        {
            Console.WriteLine("Voce foi aprovado!");

        } else if(media < 5)
        {
            Console.WriteLine("Voce foi reprovado");
        }
        else
        {
            Console.WriteLine("Voce esta de recuperação");
        }
        
    }
        
        
    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\nCALCULADORA DE NOTAS");
            Console.WriteLine("1 - Cadastrar aluno");
            Console.WriteLine("2 - Lançar notas");
            Console.WriteLine("3 - Calcular média ");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("Escolha uma opção: ");
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida");
                continue;
            }
            switch (opcao)
            {
                case 1:
                    CadastrarAluno();
                    break;
                case 2:
                    if (nomeAluno == "")
                    {
                        Console.WriteLine("Cadastre o aluno primeiro.");
                        return;
                    }
                    lancarNotas();
                    break;
                case 3:
                    if (nomeAluno == "")
                    {
                        Console.WriteLine("Cadastre o aluno primeiro.");
                        return;
                    }
                    else
                    {
                        double media = CalcularMedia();
                        Console.WriteLine($"\nAluno: {nomeAluno}");
                        Console.WriteLine($"Média: {media}");
                        mostrarSituacao(media);
                    }
                    break;
                case 4:
                    Console.WriteLine("Programa encerrado");
                    break;
                default:
                    Console.WriteLine("Escolha uma opção de 1 a 4");
                    break;
            }
        } while (opcao != 4);
    }
}
