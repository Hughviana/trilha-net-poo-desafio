namespace DesafioPOO.Models
{
    public class Nokia : Smarpnhone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Abrindo Playstore...");
            Console.WriteLine("Instalando aplicativo " + nomeApp + " no Nokia...");
        }
}
