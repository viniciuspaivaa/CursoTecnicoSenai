using Menu;

static int Teste(int arg)
{
    while(!int.TryParse(Console.ReadLine(), out arg))
    {
        Console.Write("Error, tente novamente!");
    }
    return arg;
}

static void Main(string[] args)
{
    string opcao = "";
    int n1 = 0;
    int n2 = 0;

    opcao = Navegacao.ImprimirMenu();

    switch (opcao)
    {
        case "1":
            Console.Write("Informe o primeiro número: ");

            Teste(n1);
            break;
    }
}
