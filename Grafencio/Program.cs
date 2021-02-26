using System;
/*
    El código fue hecho única y exclusivamente para funcionar sobre el grafo
    planteado en clases. Algunos de los métodos aquí pueden o no funcionar para un grafo en general.
    
 */


namespace Grafencio
{
    class Program
    {

        public static void Menu()
        {
            Console.WriteLine("1 busqueda en profundidad, '2' busqueda en ancho, '3' primero mejor, '4' Maxima Pendiente '5' Pendiente Simple");
        }
        public static void Menu2()
        {
            Console.WriteLine("¿En qué sentido deseas la busqueda? 'x' Antihorario, 'y' horario");
        }
        static void Main(string[] args)
        {
            Grafiurri grafy = new Grafiurri();
            int opc;
            string opc2;
            while (true)
            {
                Menu();
                opc = int.Parse(Console.ReadLine());
               

               
                int inici, final;
                switch (opc)
                {

                    case 1:
                        
                        Console.Write("Inicial: ");
                        inici = int.Parse(Console.ReadLine());
                        Console.Write("Meta: ");
                        final = int.Parse(Console.ReadLine());
                        Console.WriteLine("");

                       

                        Menu2();
                        opc2 = Console.ReadLine();
                        switch (opc2)
                        {
                            case "x":
                                grafy = VARIABLESESTATICAS.grafoAntiHorario;
                                break;
                            case "y":
                                grafy = VARIABLESESTATICAS.grafoHorario;
                                break;
                        }
                        grafy.BusquedaEnProfundidad(inici.ToString(), final.ToString());
                        break;

                    case 2:
                        
                        Console.Write("Inicial:");
                        inici = int.Parse(Console.ReadLine());
                        Console.Write("Meta:");
                        final = int.Parse(Console.ReadLine());
                        Menu2();
                        opc2 = Console.ReadLine();
                        switch (opc2)
                        {
                            case "x":
                                grafy = VARIABLESESTATICAS.grafoAntiHorario;
                                break;
                            case "y":
                                grafy = VARIABLESESTATICAS.grafoHorario;
                                break;
                        }
                        grafy.BusquedaEnAncho(inici.ToString(), final.ToString());
                        break;
                    case 3:
                        grafy = VARIABLESESTATICAS.grafoHorario;
                        Console.Write("Inicial:");
                        inici = int.Parse(Console.ReadLine());
                        Console.Write("Meta:");
                        final = int.Parse(Console.ReadLine());
                        grafy.BusquedaPrimeroMejor(inici.ToString(), final.ToString());
                        break;
                    case 4:
                        grafy = VARIABLESESTATICAS.grafoHorario;
                        Console.Write("Inicial:");
                        inici = int.Parse(Console.ReadLine());
                        Console.Write("Meta:");
                        final = int.Parse(Console.ReadLine());
                        grafy.BusquedaCimaMejorada(inici.ToString(), final.ToString());
                        break;
                    case 5:
                        Console.Write("Inicial: ");
                        inici = int.Parse(Console.ReadLine());
                        Console.Write("Meta: ");
                        final = int.Parse(Console.ReadLine());
                        Console.WriteLine("");



                        Menu2();
                        opc2 = Console.ReadLine();
                        switch (opc2)
                        {
                            case "x":
                                grafy = VARIABLESESTATICAS.grafoAntiHorario;
                                break;
                            case "y":
                                grafy = VARIABLESESTATICAS.grafoHorario;
                                break;
                        }
                        grafy.busquedaCima(inici.ToString(), final.ToString());
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
