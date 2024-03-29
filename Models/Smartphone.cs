namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private int Memoria { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }

        public Smartphone(string numero, int memoria, string modelo, string imei)
        {
            Numero = numero;
            Memoria = memoria;
            Modelo = modelo;
            IMEI = imei;
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
    }
}