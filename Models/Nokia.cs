namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, int memoria, string modelo, string imei) : base(numero, memoria, modelo, imei) 
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo \"{nomeApp}\" instalado no Nokia");
        }
    }
}