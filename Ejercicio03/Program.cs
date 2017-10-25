using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******BIENVENIDO A SU CUENTA**********");
            Fachada fachada = new Fachada();
            Console.WriteLine("Su saldo actual para caja de ahorro es de: " + fachada.MostrarSaldoCajaAhorro());
            Console.WriteLine("Su saldo actual para cuenta corriente es de: " + fachada.MostrarSaldoCuentaCorriente());
            Console.WriteLine("*************************************************");
            Console.WriteLine("Seleccione una opcion");
            Console.WriteLine("1 = Acreditar monto a cuenta corriente");
            Console.WriteLine("2 = Debitar monto a cuenta corriente");
            Console.WriteLine("3 = Acreditar monto a caja de ahorro");
            Console.WriteLine("4 = Debitar monto a caja de ahorro");
            Console.WriteLine("5 = Transferencia de caja de ahorro a cuenta corriente");
            Console.WriteLine("6 = Transferencia de cuenta corriente a caja de ahorro");

            double value = Convert.ToDouble(Console.ReadLine());

            switch (value)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("*******SE ENCUENTRA EN SU CUENTA CORRIENTE*******");
                    Console.WriteLine("Su saldo actual para Cuenta Corriente es de: " + fachada.MostrarSaldoCuentaCorriente());
                    Console.WriteLine("Ingrese el monto a acreditar: ");
                    double saldoAcCC = Convert.ToDouble(Console.ReadLine());
                    fachada.AcreditarSaldoCuentaCorriente(saldoAcCC);
                    Console.WriteLine("Su monto ha sido acreditado exitosamente");
                    Console.WriteLine("Su nuevo saldo es de: $" + fachada.MostrarSaldoCuentaCorriente());
                    Console.WriteLine("PRESIONE ENTER PARA SALIR");
                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("*******SE ENCUENTRA EN SU CUENTA CORRIENTE*******");
                    Console.WriteLine("Su saldo actual para Cuenta Corriente es de: " + fachada.MostrarSaldoCuentaCorriente());
                    Console.WriteLine("Ingrese el monto a debitar: ");
                    double saldoDebCC = Convert.ToDouble(Console.ReadLine());
                    Boolean result1 = fachada.DebitarSaldoCuentaCorriente(saldoDebCC);
                    if (result1 == false)
                    {
                        Console.WriteLine("No se ha podido debitar ya que no hay fondos");
                    }
                    else
                    {
                        Console.WriteLine("Su monto ha sido debitado exitosamente");
                        if (fachada.MostrarSaldoCuentaCorriente() < 0)
                        {
                            Console.WriteLine("Su nuevo saldo es de: $0 ");
                            Console.WriteLine("Se descuentan del descubierto: " + fachada.MostrarSaldoCuentaCorriente());
                        }
                        else
                        {
                            Console.WriteLine("Su nuevo saldo es de: " + fachada.MostrarSaldoCuentaCorriente());
                        }

                    }
                    Console.WriteLine("PRESIONE ENTER PARA SALIR");
                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("********SE ENCUENTRA EN SU CAJA DE AHORRO********");
                    Console.WriteLine("Su saldo actual para Caja de Ahorro es de: " + fachada.MostrarSaldoCajaAhorro());
                    Console.WriteLine("Ingrese el monto a acreditar: ");
                    double saldoAcCA = Convert.ToDouble(Console.ReadLine());
                    fachada.AcreditarSaldoCajaAhorro(saldoAcCA);
                    Console.WriteLine("Su monto ha sido acreditado exitosamente");
                    Console.WriteLine("Su nuevo saldo es de: $" + fachada.MostrarSaldoCajaAhorro());
                    Console.WriteLine("PRESIONE ENTER PARA SALIR");
                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine("*************************************************");
                    Console.WriteLine("********SE ENCUENTRA EN SU CAJA DE AHORRO********");
                    Console.WriteLine("Su saldo actual para Caja de Ahorro es de: " + fachada.MostrarSaldoCajaAhorro());
                    Console.WriteLine("Ingrese el monto a debitar: ");
                    double saldoDebCA = Convert.ToDouble(Console.ReadLine());
                    Boolean result2 = fachada.DebitarSaldoCajaAhorro(saldoDebCA);
                    if (result2 == false)
                    {
                        Console.WriteLine("No se ha podido debitar ya que no hay fondos");
                    }
                    else
                    {
                        Console.WriteLine("Su monto ha sido debitado exitosamente");
                        if (fachada.MostrarSaldoCajaAhorro() < 0)
                        {
                            Console.WriteLine("Su nuevo saldo es de: $0 ");
                            Console.WriteLine("Se descuentan del descubierto: " + fachada.MostrarSaldoCajaAhorro());
                        }
                        else
                        {
                            Console.WriteLine("Su nuevo saldo es de: " + fachada.MostrarSaldoCajaAhorro());
                        }

                    }
                    Console.WriteLine("PRESIONE ENTER PARA SALIR");
                    Console.ReadKey();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("********************************************************");
                    Console.WriteLine("***TRANSFERENCIA DE CAJA DE AHORRO A CUENTA CORRIENTE***");
                    Console.WriteLine("Su saldo actual para Caja de Ahorro es de: " + fachada.MostrarSaldoCajaAhorro());
                    Console.WriteLine("Su saldo actual para Cuenta Corriente es de: " + fachada.MostrarSaldoCuentaCorriente());
                    Console.WriteLine("Ingrese el saldo a transferir: ");
                    double saldoDebCATrans = Convert.ToDouble(Console.ReadLine());
                    Boolean result3 = fachada.DebitarSaldoCajaAhorro(saldoDebCATrans);
                    if (result3 == false)
                    {
                        Console.WriteLine("No se ha podido transferir ya que no hay fondos");
                    }
                    else
                    {
                        fachada.AcreditarSaldoCuentaCorriente(saldoDebCATrans);
                        Console.WriteLine("Su monto ha sido transferido exitosamente");
                        Console.WriteLine("Su nuevo saldo en CA es : $" + fachada.MostrarSaldoCajaAhorro());
                        Console.WriteLine("Su nuevo saldo en CC es : $" + fachada.MostrarSaldoCuentaCorriente());
                    }
                    Console.WriteLine("PRESIONE ENTER PARA SALIR");
                    Console.ReadKey();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("********************************************************");
                    Console.WriteLine("***TRANSFERENCIA DE CUENTA CORRIENTE A CAJA DE AHORRO***");
                    Console.WriteLine("Su saldo actual para Cuenta Corriente es de: " + fachada.MostrarSaldoCuentaCorriente());
                    Console.WriteLine("Su saldo actual para Caja de Ahorro es de: " + fachada.MostrarSaldoCajaAhorro());
                    Console.WriteLine("Ingrese el monto a transferir: ");
                    double saldoDebCCTrans = Convert.ToDouble(Console.ReadLine());
                    Boolean result4 = fachada.DebitarSaldoCuentaCorriente(saldoDebCCTrans);
                    if (result4 == false)
                    {
                        Console.WriteLine("No se ha podido transferir ya que no hay fondos");
                    }
                    else
                    {
                        fachada.AcreditarSaldoCajaAhorro(saldoDebCCTrans);
                        Console.WriteLine("Su monto ha sido transferido exitosamente");
                        Console.WriteLine("Su nuevo saldo en CA es : $" + fachada.MostrarSaldoCajaAhorro());
                        Console.WriteLine("Su nuevo saldo en CC es : $" + fachada.MostrarSaldoCuentaCorriente());
                    }
                    Console.WriteLine("PRESIONE ENTER PARA SALIR");
                    Console.ReadKey();
                    break;
            }
    }
}
