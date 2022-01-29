using DiagramaClaseUML.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClaseUML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Alumno Erick
            CuentaBancaria cuentaBancaria = new CuentaBancaria(numero : "21540026", saldo: 500000);
            float saldoActual = cuentaBancaria.ObtenerSaldo();
            Console.WriteLine(saldoActual);
            //Console.WriteLine(cuentaBancaria.ObtenerSaldo());
            Console.WriteLine("Retira 150 000");
            Console.WriteLine(cuentaBancaria.Retirar(150000));
            Console.WriteLine("Depositar 250 000");
            cuentaBancaria.Ingresar(250000);
            Console.WriteLine(cuentaBancaria.ObtenerSaldo());



            Console.ReadKey(); 
        }
    }
}
