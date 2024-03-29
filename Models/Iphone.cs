namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        
        public Iphone(string numero, int memoria, string modelo, string imei) : base(numero, memoria, modelo, imei) 
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo \"{nomeApp}\" instalado no Iphone");
        }
    }
}