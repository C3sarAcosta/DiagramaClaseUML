using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramaClaseUML.Clases
{
    /*
     * La clase CuentaBancaria respresenta cuentas
     * bancarias en las que se mantiene un saldo
     * @autor César Acosta
     */
    internal class CuentaBancaria
    {
        //--------------------------------PROPIEDDADES------------------------------------
        //Numero de cuenta
        private string numero;

        //Saldo en pesos de la cuenta
        private float saldo;

        //private bool pico;

        //------------------------------------METODOS O FUNCIONES--------------------------------

        //Constructor de la clase CuentaBancaria
        public CuentaBancaria(string numero, float saldo)
        {
            this.numero = numero;
            this.saldo = saldo;
        }

        public float ObtenerSaldo()
        {
            return saldo;
        }

        public void Ingresar(float cantidad)
        {
            saldo = saldo + cantidad;
            //saldo += cantidad;
        }

        public string Retirar(float cantidad)
        {
            if(cantidad > saldo)
            {
                return "Saldo insuficiente";
            }
            //saldo = saldo - cantidad;
            saldo -= cantidad;
            return "Su saldo es de " + saldo;
        }

        //--------------------------------------------------------------------

    }
}
