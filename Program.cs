// See https://aka.ms/new-console-template for more information

using practica;
using practica.Clases;
using practica.Interfaces;

List<EmpleadoBase> empleados = new List<EmpleadoBase>();

Gerente gerente = new Gerente
{    IdEmpleado = 1,    Nombre = "Ethan Sevilla",    Puesto = "Gerente TI"};

Desarrollador desarrollador = new Desarrollador
{    IdEmpleado = 2,    Nombre = "Mauricio Sevilla",    Puesto = "Desarrollador"};

GerenteRRHH gerenteRRHH = new GerenteRRHH
{    IdEmpleado = 3,    Nombre = "Edrik Sevilla",    Puesto = "Gerente RRHH"};

ConsultorExterno consultorExterno= new ConsultorExterno
{ IdEmpleado = 4, Nombre = "Lenin Perez", Puesto = "Consultor Externo" };


empleados.Add(gerente);
empleados.Add(desarrollador);
empleados.Add(gerenteRRHH);
empleados.Add(consultorExterno);


/*
 Console.WriteLine("A: "+ desarrollador.Nombre);
    Console.WriteLine("B: " + gerente.Nombre);
    Console.WriteLine("C: " + gerenteRRHH.Nombre);
    Console.WriteLine("D: " + consultorExterno.Nombre);
 */
string opcionElegida = "";
string tipoEmpleado = "";
string Nombre = "";
do
{
    Console.WriteLine("======= MANTENEDOR DE TRABAJADORES =======");
    Console.WriteLine("A) Ingresar Empleado: ");
    Console.WriteLine("B) Mostrar Listado de Empleados: ");
    Console.WriteLine("C) Salir: ");
    Console.Write("Digite su opción: ");
    opcionElegida = Convert.ToString(Console.ReadLine()).ToUpper();

    switch (opcionElegida)
    {
        case "A":                                  

            do
            {
                Console.WriteLine("Elija el tipo de Empleado a Registrar: ");

                Console.WriteLine("A) Desarrollador ");
                Console.WriteLine("B) Gerente ");
                Console.WriteLine("C) GerenteRRhh");
                Console.WriteLine("D) Consultor Externo");
                Console.WriteLine("S) SALIR");
                Console.Write("Digite su opción: ");
                tipoEmpleado = Console.ReadLine().ToUpper();
                switch (tipoEmpleado)
                {
                    case "A":
                        Console.Write("Ingrese el nombre: ");
                        Nombre = Convert.ToString(Console.ReadLine()).ToUpper();
                        Desarrollador desarrollador1 = new Desarrollador
                        { IdEmpleado = 5, Nombre = Nombre, Puesto = "Desarrollador" };
                        empleados.Add(desarrollador1);
                        break;

                    case "B":
                        Console.Write("Ingrese el nombre: ");
                        Nombre = Convert.ToString(Console.ReadLine()).ToUpper();
                        Gerente gerente2 = new Gerente
                        { IdEmpleado = 5, Nombre = Nombre, Puesto = "Gerente TI" };
                        empleados.Add(gerente2);
                        break;

                    case "C":
                        Console.Write("Ingrese el nombre: ");
                        Nombre = Convert.ToString(Console.ReadLine()).ToUpper();
                        GerenteRRHH gerenteRRhh1 = new GerenteRRHH
                        { IdEmpleado = 5, Nombre = Nombre, Puesto = "GerenteRRhh" };
                        empleados.Add(gerenteRRhh1);
                        break;

                    case "D":
                        Console.Write("Ingrese el nombre: ");
                        Nombre = Convert.ToString(Console.ReadLine()).ToUpper();
                        ConsultorExterno consultorExterno1 = new ConsultorExterno
                        { IdEmpleado = 5, Nombre = Nombre, Puesto = "Consultor Externo" };
                        empleados.Add(consultorExterno1);
                        break;



                    default:
                        break;
                }
            } while (tipoEmpleado != "S");


            break;
        case "B":
            Console.WriteLine(" ");
            Console.WriteLine("======= LISTADO DE TRABAJADORES =======");
            foreach (var empleado in empleados)
            {
                Console.WriteLine(empleado.IdEmpleado + " " + empleado.Nombre + " " + empleado.Puesto);
                empleado.CalcularSueldo();
                empleado.MostrarDetalles();

                if (empleado is ISueldoBonificable empleadoBonificable)
                {
                    Console.WriteLine("EL sueldo con Bonificicacion es:" + empleadoBonificable.CalcularBonificacion());
                }
                if (empleado is IDescuentoImpuesto empleadoConDescuento)
                {
                    Console.WriteLine("EL sueldo con Descuentos es:" + empleadoConDescuento.DescontarSueldo());
                }
                Console.WriteLine("_____________________");
                Console.WriteLine("by Ivan Sevilla");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
            break;

        default:
            break;
    }

} while (opcionElegida != "C");







Console.Read();
