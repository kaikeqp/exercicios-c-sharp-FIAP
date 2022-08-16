public class Candidato
{
    public string? Nome { get; set; }
    public int Votos { get; set; }
}

class Programa
{
    static void Main(string[] args)
    {
        Candidato chaves = new Candidato();
        Candidato chiquinha = new Candidato();
        Candidato quico = new Candidato();

        chaves.Nome = "Chaves";
        chiquinha.Nome = "Chiquinha";
        quico.Nome = "Quico";

        int opcao;
        int votosTotal;
        int votosNulo = 0;
        int votosBranco = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("As opções são:" +
                "\n1.Candidato Chaves " +
                "\n2.Candidata Chiquinha" +
                "\n3.Candidato Quico" +
                "\n4.Nulo / Branco" +
                "\n5.Encerrar a votação" +
                "\nEntre com o seu voto");

            opcao = int.Parse(Console.ReadLine());
            if (opcao >= 1 && opcao < 5)
            {
                switch (opcao)
                {
                    case 1:
                        chaves.Votos++;
                        break;
                    case 2:
                        chiquinha.Votos++;
                        break;
                    case 3:
                        quico.Votos++;
                        break;
                    case 4:
                        Console.WriteLine("digite 1 para Nulo ou 2 para Branco");
                        int opcaoNuloBranco = int.Parse(Console.ReadLine());
                        if (opcaoNuloBranco == 1)
                        {
                            votosNulo++;
                        }
                        else if (opcaoNuloBranco == 2)
                        {
                            votosBranco++;
                        }
                        break;
                }
            }
        } while (opcao != 5);


        votosTotal = quico.Votos + votosNulo + chiquinha.Votos + chaves.Votos + votosBranco;
        int porcentagemNulo = votosNulo * 100 / votosTotal;
        int porcentagemBranco = votosBranco * 100 / votosTotal;

        int maior = chaves.Votos;
        string maiorNome = chaves.Nome;

        if (chiquinha.Votos > maior)
        {
            maior = chiquinha.Votos;
            maiorNome = chiquinha.Nome;
        }
        if (chiquinha.Votos == maior)
        {
            maiorNome = string.Join(", ", maiorNome, chiquinha.Nome);
        }

        if (quico.Votos > maior)
        {
            maior = quico.Votos;
            maiorNome = quico.Nome;
        }
        if (quico.Votos == maior)
        {
            maiorNome = string.Join(", ", maiorNome, quico.Nome);
        }

        Console.WriteLine($"Chaves: {chaves.Votos}" +
            $"\nChiquinha: {chiquinha.Votos}" +
            $"\nQuico: {quico.Votos}" +
            $"\nNulo: {porcentagemNulo}%" +
            $"\nBranco: {porcentagemBranco}%" +
            $"\n\nVencedor: .:{maiorNome}:.");

    }
}

