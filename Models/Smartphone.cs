namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // DONE: Implementar as propriedades faltantes de acordo com o diagrama
        public string Modelo { get; }
        public string Imei { get; }
        public int Memoria { get; }
        //Extras
        protected Dictionary<int, string> AppStore { get; set;}
        protected List<string> AppsInstalados{get; set;}


        public Smartphone(){}
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            // DONE: Passar os parâmetros do construtor para as propriedades
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
            AppsInstalados = new List<string>();

        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public abstract void InstalarAplicativoPelaLojaDeApps();
        public abstract void ListarAplicativos();
        public abstract void DesinstalarAplicativo();
    }
}