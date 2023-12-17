

using System.Data;

namespace DesafioPOO.Models
{
    // DONE: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone (string numero, string modelo, string imei, int memoria) : base( numero,  modelo,  imei,  memoria){
            this.CriarAppStore();
        }

        private void CriarAppStore()
        {
            AppStore = new(){
                {1, "WhatsApp"},
                {2, "Telegran"},
                {3, "Instagram"},
                {4, "Dio.me"},
                {5, "GitHub"},
                {6, "Google Chrome"},
                {7, "LinkedIn"},
                {8, "YouTube"},
                {9, "Uber"},
                {10, "iFood"},
            };
        }

        // DONE: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            AppsInstalados.Add(nomeApp);
            Console.WriteLine($"O aplicativo {nomeApp} foi instalado com sucesso!!!");
        }
        //Extras
        public override void DesinstalarAplicativo()
        {
            if(AppsInstalados.Count()>0){
                Console.WriteLine("Selecione o número corresponde ao aplicativo que deseja desistalar");
                int numeroEscolhido;
                do{
                    Console.WriteLine("Aplicativos instalados:\n");
                    for(int i = 1 ; i<=AppsInstalados.Count();i++){
                        Console.WriteLine($"{i}: {AppsInstalados[i-1]}");
                    }
                    numeroEscolhido = Convert.ToInt16(Console.ReadLine());
                    if(numeroEscolhido<=0 || numeroEscolhido>AppsInstalados.Count()){
                        Console.WriteLine("Número inválido, selecione novamente: ");
                    }
                }while(numeroEscolhido<=0 || numeroEscolhido>AppsInstalados.Count());
                Console.WriteLine($"Deseja confirmar a desinstalação de {AppsInstalados[numeroEscolhido-1]}?");
                int simOuNao;
                do{
                    Console.WriteLine("1. Sim\n2. Não");
                    simOuNao = Convert.ToInt16(Console.ReadLine());
                    if(simOuNao!=1&&simOuNao!=2){
                        Console.WriteLine("Escolha uma opção válida.");
                    }
                }while(simOuNao!=1&&simOuNao!=2);
                if(simOuNao == 1){
                    AppsInstalados.Remove(AppsInstalados[numeroEscolhido-1]);
                    Console.WriteLine("Operação realizada com sucesso.");
                }else{
                    Console.WriteLine("Operação Cancelada");
                }
            }else{
                Console.WriteLine("Não existem Aplicativos instalados para serem excluídos.");
            }

        }
        public override void ListarAplicativos()
        {
            Console.WriteLine("Aplicativos instalados:\n");
            foreach(string item in AppsInstalados){
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nExistem {AppsInstalados.Count()} aplicativos instalados em seu iPhone.");
        }
        public override void InstalarAplicativoPelaLojaDeApps(){
            Console.WriteLine("         Boas Vindas a AppleStore!!!          \n\n");
            Console.WriteLine("Digite o valor correspondente ao APP: ");
            int numeroEscolhido;
            do{
                foreach(KeyValuePair<int, string> app in AppStore){
                    Console.WriteLine($"{app.Key}: {app.Value}");
                }
                numeroEscolhido = Convert.ToInt16(Console.ReadLine());
                if(numeroEscolhido<=0||numeroEscolhido>AppStore.Count()){
                    Console.WriteLine("Número inválido, tente novamente");
                }

            }while(numeroEscolhido<=0||numeroEscolhido>AppStore.Count());
            Console.WriteLine($"Deseja confirmar a instalação de {AppStore[numeroEscolhido]}?");
            int simOuNao;
            do{
                Console.WriteLine("1. Sim\n2. Não");
                simOuNao = Convert.ToInt16(Console.ReadLine());
                if(simOuNao!=1&&simOuNao!=2){
                    Console.WriteLine("Escolha uma opção válida.");
                }
            }while(simOuNao!=1&&simOuNao!=2);
            if(simOuNao == 1){
                InstalarAplicativo(AppStore[numeroEscolhido]);
            }else{
                Console.WriteLine("Operação Cancelada");
            }

        }

    }
}