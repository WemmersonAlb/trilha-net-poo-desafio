using DesafioPOO.Models;

// DONE: Realizar os testes com as classes Nokia e Iphone
// Smartphone celular = new Iphone("982261851", "iPhone 14", "bla1bla2bla3", 256);
// Console.WriteLine("Testando iPhone");
// celular.Ligar();
// celular.ReceberLigacao();
// celular.InstalarAplicativoPelaLojaDeApps();
// celular.ListarAplicativos();
// celular.DesinstalarAplicativo();

// Smartphone celular2 = new Iphone("984064074", "Nokia C3", "bla1bla2bla4", 32);
// Console.WriteLine("\n\n\nTestando Nokia");
// celular2.Ligar();
// celular2.ReceberLigacao();
// celular2.InstalarAplicativoPelaLojaDeApps();
// celular2.ListarAplicativos();
// celular2.DesinstalarAplicativo();

//Celulares funcionando

void showIphone(){
    Smartphone celular = new Iphone("982261851", "iPhone 14", "bla1bla2bla3", 256);
    int escolha = 1;
    do
    {
        Console.WriteLine($"Selecione alguma das funções do iPhone:");
        Console.WriteLine($"1.Ligar;");
        Console.WriteLine($"2.Receber ligação;");
        Console.WriteLine($"3.Instalar Aplicativo pela loja de Apps;");
        Console.WriteLine($"4.Instalar Aplicativo fora da loja de Apps;");
        Console.WriteLine($"5.Listar Aplicativos;");
        Console.WriteLine($"6.Desinstalar Aplicativos;");
        Console.WriteLine($"0.Voltar.");
        escolha = Convert.ToInt16(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.Clear();
                celular.Ligar();
                break;
            case 2:
                Console.Clear();
                celular.ReceberLigacao();
                break;
            case 3:
                Console.Clear();
                celular.InstalarAplicativoPelaLojaDeApps();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Digite o nome do aplicativo que você deseja instalar: ");
                string app = Console.ReadLine();
                celular.InstalarAplicativo(app);
                break;
            case 5:
                Console.Clear();
                celular.ListarAplicativos();
                break;
            case 6:
                Console.Clear();
                celular.DesinstalarAplicativo();
                break;
            case 0:
                Console.Clear();
                Console.WriteLine($"Saindo dos testes do iPhone.");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Número inválido, escolha novamente.\n");
                break;
        }

    } while (escolha!=0);
}
void showNokia(){
    Smartphone celular = new Nokia("982261851", "Nokia C3", "bla1bla2bla4", 32);
    int escolha = 1;
    do
    {
        Console.WriteLine($"Selecione alguma das funções do Nokia:");
        Console.WriteLine($"1.Ligar;");
        Console.WriteLine($"2.Receber ligação;");
        Console.WriteLine($"3.Instalar Aplicativo pela loja de Apps;");
        Console.WriteLine($"4.Instalar Aplicativo fora da loja de Apps;");
        Console.WriteLine($"5.Listar Aplicativos;");
        Console.WriteLine($"6.Desinstalar Aplicativos;");
        Console.WriteLine($"0.Voltar.");
        escolha = Convert.ToInt16(Console.ReadLine());
        switch (escolha)
        {
            case 1:
                Console.Clear();
                celular.Ligar();
                break;
            case 2:
                Console.Clear();
                celular.ReceberLigacao();
                break;
            case 3:
                Console.Clear();
                celular.InstalarAplicativoPelaLojaDeApps();
                break;
            case 4:
                Console.Clear();
                Console.WriteLine("Digite o nome do aplicativo que você deseja instalar: ");
                string app = Console.ReadLine();
                celular.InstalarAplicativo(app);
                break;
            case 5:
                Console.Clear();
                celular.ListarAplicativos();
                break;
            case 6:
                Console.Clear();
                celular.DesinstalarAplicativo();
                break;
            case 0:
                Console.Clear();
                Console.WriteLine($"Saindo dos testes do Nokia.");
                break;
            default:
                Console.Clear();
                Console.WriteLine("Número inválido, escolha novamente.\n");
                break;
        }

    } while (escolha!=0);
}


int escolha = 1;
Console.Clear();
Console.WriteLine($"Boas vindas aos testes dos Smartphones!");
do{
    Console.WriteLine($"Selecione o que você deseja testar:");
    Console.WriteLine($"1.iPhone");
    Console.WriteLine($"2.Nokia\n");
    Console.WriteLine($"0.Sair");
    escolha = Convert.ToInt16(Console.ReadLine());
    switch (escolha)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Testando iPhone");
            showIphone();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Testando Nokia");
            showNokia();
            break;
        case 0:
            Console.WriteLine("Saindo da Aplicação, adeus!");
            break;
        default:
            Console.Clear();
            Console.WriteLine($"Número inválido, escolha novamente.\n");
            break;
    }
}while(escolha != 0);
