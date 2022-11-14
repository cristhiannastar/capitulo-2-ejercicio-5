namespace ejercicio25
{
    public class lotes
    {
        public static decimal Ar { get; private set; }
        public static decimal At { get; private set; }
        public static decimal Ato { get; private set; }

        public static void Main ()
        {
            decimal a,b,c,at,ar,ato;
            Console.WriteLine("por favor digite la longitud de a");
            a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("por favor ingrese la longitud de b");
            b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("por favor ingrese la longitud de c");
            c = decimal.Parse(Console.ReadLine());
            Ar = b * c;
            At = ((a - c) * b) / 2;
            Ato = Ar + At;
            Console.WriteLine($"el area del lote es {Ato}");


            
     
        }
    }

}