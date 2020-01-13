using System;

namespace CSuma
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dame el primer numero");
            double numero1=double.Parse(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
            double numero2 = double.Parse(Console.ReadLine());
            double Suma = numero1 + numero2;
            double Resta = numero1 - numero2;
            double Producto = numero1 * numero2;
            double Cociente = numero1 / numero2;
            Console.WriteLine("El resultado de la suma es de " + Suma);
            Console.WriteLine("El resultado de la resta es de " + Resta);
            Console.WriteLine("El resultado del producto es de " + Producto);
            Console.WriteLine("El resultado del cociente es de " + Cociente);
        }
    }
}
