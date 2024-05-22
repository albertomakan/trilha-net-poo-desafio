namespace DesafioPOO.Models
{
    
    //Implementado!!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        //Implementado!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O {nomeApp} é compatível com seu {Modelo}, de {Memoria}GB!");
            Console.WriteLine($"O seu número {Numero} e IMEI {IMEI} foram registrados com sucesso!");
        }
    }
}