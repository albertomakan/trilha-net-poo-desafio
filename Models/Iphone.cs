namespace DesafioPOO.Models
{
    //Implementado!!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        //Implementado!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Você deseja instalar o {nomeApp} no seu {Modelo}, de {Memoria}GB?");
            Console.WriteLine($"O seu número {Numero} e IMEI {IMEI} foram salvos em sua conta com sucesso!");        }
    }
}