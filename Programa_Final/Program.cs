// See https://aka.ms/new-console-template for more information

class program 
{
//-----------------------------------------------------------------------------------   

//estructura para la agenda
    struct tipocontacto
    {
        public string nombre;
        public string apellido;
        public string Telefono;
        public string direccion;
        public string email; 
    }

//variables para la capacidad de la agenda
    static int capacidad = 100;
    static tipocontacto[] gente = new tipocontacto[capacidad];
    static int cantidad = 0;
    static string nombreFichero = "agenda.dat";


//estructura para eventos
    struct tipoevento
    {
        public string nombre;
        public string fecha;
        public string hora;
        public string lugar;  
    }

//variables para la capacidad de los eventos
    static int capacidad2 = 100;
    static tipoevento[] evento = new tipoevento[capacidad];
    static int cantidad2 = 0;
    static string nombreevento = "evento.dat";


//-----------------------------------------------------------------------------------  


//variable para leer los datos ingresados por el usuario
    static string buscar = "";
    
//variables para la calculadora
    static int num, num2;
    static int resul;

//variable para el switch
    static int opcion = 0;
    static int Vuelta;

// variables para el conversor de unidades     
    static double numero;
    static double fah; 
    static double cel; 
    static double kel; 
    static double pe; 
    static double eu; 
    static double dol;


//----------------------------------------------------------------------------------- 


    public static void Main()
    {
        
        do
        {
            Console.Clear();
            escribir(50,"****menu general****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[1]Agenda_Electronica");
            Console.WriteLine("[2]Conversor_de_unidades");
            Console.WriteLine("[3]Calculadora");
            Console.WriteLine("[4]salir");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: 
                    Agenda_Electronica();
                    break;

                case 2: 
                    Conversor_de_unidades();
                    break;

                case 3: 
                    Calculadora();
                    break;

                case 4: 
                    Salir();
                    break;

                default: 
                    Default();
                    break;
            }

        } while (opcion != 4);

    }


//-----------------------------------------------------------------------------------   


    public static void Agenda_Electronica()
    {
        do
        {  
            Console.Clear();
            escribir(50,"Agenda eletronica");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[1]Contacto");
            Console.WriteLine("[2]Evento");
            Console.WriteLine("[3]Volver al menu principal");
            Console.WriteLine("[4]Salir");

            opcion = Convert.ToInt32(Console.ReadLine());


            switch(opcion)
            {
                case 1:
                    contacto();
                    break;

                case 2:
                    eventos();
                    break;

                case 3:
                    Main();
                break;

                case 4:
                    Salir();
                    break;

                default:
                    Default();
                    break;
            
            }

            Console.ReadKey();
        
        }while(opcion != 4);

        LeerDeFichero();
        leerdeficheroevento();


        //---------------------------------------------------------------------------------// 
        static void contacto()
        {
            do
            {
                Console.Clear();
                escribir(50,"menu contactos");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("[1]Añadir nuevo contacto");
                Console.WriteLine("[2]Ver todos los contactos");
                Console.WriteLine("[3]Buscar contacto");
                Console.WriteLine("[4]editar contacto");
                Console.WriteLine("[5]Borrar contacto");
                Console.WriteLine("[6]volver al menu de agenda electronica");
                Console.WriteLine("[7]Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

        
                switch (opcion)
                {
                    case 1: 
                        NuevoDato();
                        break;

                    case 2: 
                        MostrarDatos(); 
                        break;

                    case 3: 
                        BuscarDatos(); 
                        break;

                    case 4: 
                        editar_agenda();
                        break;

                    case 5:
                        borrar_agenda(); 
                        break;

                    case 6:
                        Agenda_Electronica();
                        break;

                    case 7:
                        Salir();
                        break;

                    default:
                        Default();    
                        break;
                }

            }while (opcion != 7);
        }


        //---------------------------------------------------------------------------------//


        static void eventos()
        {
            do
            {
                Console.Clear();
                escribir(50,"Menu eventos");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("[1]Añadir nuevo evento");
                Console.WriteLine("[2]Ver eventos");
                Console.WriteLine("[3]Buscar eventos");
                Console.WriteLine("[4]Editar evento");
                Console.WriteLine("[5]Borrar evento");
                Console.WriteLine("[6]volver al menu de agenda electronica");
                Console.WriteLine("[7]Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

            
                switch (opcion)
                {
                    case 1: 
                        Console.Clear();
                        nuevodatoagenda();

                        break;

                    case 2: 
                        Console.Clear();
                        mostrardatoagenda(); 
                        break;

                    case 3: 
                        Console.Clear();
                        buscardatoagenda(); 
                        break;

                    case 4: 
                        Console.Clear();
                        editar_evento();
                        break;

                    case 5: 
                        Console.Clear();
                        borrar_evento(); 
                        break;

                    case 6:
                        Agenda_Electronica();
                        break;

                    case 7:
                        Salir();
                        break;

                    default:
                        Default();
                        break;
                }

            }while (opcion != 7);

        }
        //---------------------------------------------------------------------------------//

        static void NuevoDato()
        {
            if (cantidad < capacidad - 1)
            {
                Console.WriteLine("Introduciendo Contacto {0}",
                cantidad + 1);
    
                Console.Write("Digite el nombre de contacto: ");
                gente[cantidad].nombre = Console.ReadLine()!;
    
                Console.Write("Digite su apellido: ");
                gente[cantidad].apellido = Console.ReadLine()!;

                Console.Write("Digite Numero De telefono: ");
                gente[cantidad].Telefono = Console.ReadLine()!;

                Console.Write("Digite direccion del contacto: ");
                gente[cantidad].direccion = Console.ReadLine()!;
    
                Console.Write("Digite su correo: ");
                gente[cantidad].email = Console.ReadLine()!;


                cantidad++;
                
                GuardarEnFichero();
            }
            else
                escribir(50,"Base de datos llena");
            
        }

        //---------------------------------------------------------------------------------//

        static void MostrarDatos()
        {
            if (cantidad == 0)
            {
                escribir(50,"No hay datos");
            }
                
            else
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("{0}: {1}",
                    i + 1, gente[i].nombre);
                }
                    
            Console.ReadKey();
        }

        //---------------------------------------------------------------------------------//

        static void BuscarDatos()
        {
            escribir(50,"¿buscar contacto? ");
            string buscar = Console.ReadLine()!;
    
            bool encontrado = false;
            for (int i = 0; i < cantidad; i++)
            {
                if (buscar.ToUpper() == gente[i].nombre.ToUpper())
                {
                    encontrado = true;
                    Console.WriteLine(
                    "{0}: Nombre: {1}, apellido: {2}, telefono: {3}, direccion: {4}, email: {5}",
                    i + 1, gente[i].nombre, gente[i].apellido, gente[i].Telefono,
                    gente[i].direccion, gente[i].email);  
                    
                }

            }
            
    
            if (!encontrado)
            {
                escribir(50,"No se ha encontrado...");
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        //---------------------------------------------------------------------------------//


        static void LeerDeFichero()
        {
            Console.Clear();
            if (File.Exists(nombreFichero))
            {
                escribir(50,"Abriendo contacto...");
                StreamReader fichero = File.OpenText(nombreFichero);
                string linea1, linea2, linea3, linea4, linea5;
                do
                {
                    linea1 = fichero.ReadLine()!;
                    if (linea1 == null) 
                        break;
                    linea2 = fichero.ReadLine()!;
                    linea3 = fichero.ReadLine()!;
                    linea4 = fichero.ReadLine()!;
                    linea5 = fichero.ReadLine()!;
                    if (cantidad < capacidad - 1)
                    {
                        gente[cantidad].nombre = linea1;
                        gente[cantidad].apellido = linea2;
                        gente[cantidad].Telefono =linea3;
                        gente[cantidad].direccion=linea4;
                        gente[cantidad].email=linea5;
                        cantidad++;
                    }
                }
                while ((linea1 != null) && (linea2 != null)
                    && (linea3 != null) && (linea4 != null) && (linea5 != null));
                fichero.Close();
            }
            Console.ReadKey();

        }


        //---------------------------------------------------------------------------------//


        static void GuardarEnFichero()
        {
            StreamWriter fichero = File.CreateText(nombreFichero);
            for (int i = 0; i < cantidad; i++)
            {
                fichero.WriteLine(gente[i].nombre);
                fichero.WriteLine(gente[i].apellido);
                fichero.WriteLine(gente[i].Telefono);
                fichero.WriteLine(gente[i].direccion);
                fichero.WriteLine(gente[i].email);
                
            }
            fichero.Close();
            Console.ReadKey();
        }


        //---------------------------------------------------------------------------------//


        static void editar_agenda()
        {
            Console.Clear();
            escribir(50,"Escriba el nombre de contacto que desea editar: ");
            string buscar = Console.ReadLine()!;
            
            
            for(int i = 0; i < cantidad; i++)
            {
                if (buscar == gente[i].nombre)
                {
                    Console.WriteLine();
                    Console.WriteLine("Editando contacto ",
                    cantidad + 1);
        
                    Console.Write("Digite el nombre de contacto: ");
                    gente[i].nombre = Console.ReadLine()!;
        
                    Console.Write("Digite su apellido: ");
                    gente[i].apellido = Console.ReadLine()!;

                    Console.Write("Digite Numero De telefono: ");
                    gente[i].Telefono = Console.ReadLine()!;

                    Console.Write("Digite direccion del contacto: ");
                    gente[i].direccion = Console.ReadLine()!;
        
                    Console.Write("Digite su correo: ");
                    gente[i].email = Console.ReadLine()!;
                }
                
                Console.ReadKey();
            }

        }


        //---------------------------------------------------------------------------------//


        static void borrar_agenda()
        {
            Console.Clear();

            escribir(50,"Escriba el noombre de contacto que desea eliminar:");
            buscar = Console.ReadLine()!;


            for(int i = 0; i <cantidad;i++)
            {
                
                if(gente[i].nombre.Equals(buscar))
                {
                    gente[i].nombre = null!;
                    gente[i].apellido = null!;
                    gente[i].Telefono = null!;
                    gente[i].direccion = null!;
                    gente[i].email = null!;

                    escribir(50,$"Se elimino correctamente el contacto {buscar} de esta agenda...");
                }


            }
            Console.ReadKey();

        }


        //---------------------------------------------------------------------------------//


        static void nuevodatoagenda()
        {
            if (cantidad2 < capacidad2 - 1)
            {
                Console.WriteLine("Introduciendo evento {0}",
                cantidad2 + 1);
    
                Console.Write("Digite el nombre del evento: ");
                evento[cantidad2].nombre = Console.ReadLine()!;
    
                Console.Write("Digite la fecha de este: ");
                evento[cantidad2].fecha = Console.ReadLine()!;

                Console.Write("Digite la hora de este: ");
                evento[cantidad2].hora = Console.ReadLine()!;

                Console.Write("Digite el lugar de este: ");
                evento[cantidad2].lugar = Console.ReadLine()!;
    
                


                cantidad2++;
                guardareneventoagenda();
            }
            else
                escribir(50,"Base de datos llena");
                Console.ReadKey();
        }


        //---------------------------------------------------------------------------------//


        static void mostrardatoagenda()
        {
            if (cantidad2 == 0)
            {
                escribir(50,"No hay datos");
            }
                
            else
                for (int i = 0; i < cantidad2; i++)
                {
                    Console.WriteLine("{0}: {1}",
                    i + 1, evento[i].nombre);
                }
                    
            Console.ReadKey();
        }


        //---------------------------------------------------------------------------------//


        static void buscardatoagenda()
        {
            escribir(50,"¿buscar evento? ");
            string buscar = Console.ReadLine()!;
    
            bool encontrado2 = false;
            for (int i = 0; i < cantidad2; i++)
            {
                if (buscar.ToUpper() == evento[i].nombre.ToUpper())
                {
                    encontrado2 = true;
                    Console.WriteLine(
                    "{0}: Nombre: {1}, Fecha: {2}, Hora: {3}, Lugar: {4}",
                    i + 1, evento[i].nombre, evento[i].fecha, evento[i].hora,
                    evento[i].lugar); 
                }

            }
                
    
            if (!encontrado2)
            {
                escribir(50,"No se ha encontrado...");
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        //---------------------------------------------------------------------------------//


        static void leerdeficheroevento()
        {
            Console.Clear();
            if (File.Exists(nombreevento))
            {
                escribir(50,"Abriendo evento...");
                StreamReader dato = File.OpenText(nombreevento);
                string linea1, linea2, linea3, linea4;
                do
                {
                    linea1 = dato.ReadLine()!;
                    if (linea1 == null)
                    break;
                    linea2 = dato.ReadLine()!;
                    linea3 = dato.ReadLine()!;
                    linea4 = dato.ReadLine()!;
                    
                    
                    if (cantidad2 < capacidad2 - 1)
                    {
                        evento[cantidad2].nombre = linea1;
                        evento[cantidad2].fecha = linea2;
                        evento[cantidad2].hora = linea3;
                        evento[cantidad2].lugar= linea4;
                        cantidad2++;
                    }
                }while ((linea1 != null) && (linea2 != null)
                && (linea3 != null) && (linea4 != null));

                dato.Close();
            }
            Console.ReadKey();
        }


        //---------------------------------------------------------------------------------//


        static void guardareneventoagenda()
        {
            StreamWriter dato = File.CreateText(nombreevento);
            for (int i = 0; i < cantidad2; i++)
            {
                dato.WriteLine(evento[i].nombre);
                dato.WriteLine(evento[i].fecha);
                dato.WriteLine(evento[i].hora);
                dato.WriteLine(evento[i].lugar);
                
            }
            dato.Close();
            Console.ReadKey();
        }


        //---------------------------------------------------------------------------------//


        static void editar_evento()
        {
            Console.Clear();
            escribir(50,"Escriba el nombre del evento que desea editar: ");
            string buscar = Console.ReadLine()!;

            for(int i = 0; i < cantidad2; i++)
            {
                if(buscar == evento[i].nombre )
                {
                    Console.WriteLine();
                    Console.WriteLine($"Editando evento {buscar} ",
                    cantidad2 + 1);
        
                    Console.Write("Digite el nombre del evento: ");
                    evento[i].nombre = Console.ReadLine()!;
        
                    Console.Write("Digite la fecha: ");
                    evento[i].fecha = Console.ReadLine()!;

                    Console.Write("Digite la hora: ");
                    evento[i].hora = Console.ReadLine()!;

                    Console.Write("Digite el lugar: ");
                    evento[i].lugar = Console.ReadLine()!;
                }

            }

            Console.ReadKey();
        }


        //---------------------------------------------------------------------------------//


        static void borrar_evento()
        {
            Console.Clear();

            escribir(50,"Escriba el nombre del evento que desea eliminar:");
            buscar = Console.ReadLine()!;


            for(int i = 0; i <cantidad2;i++)
            {
                
                if(evento[i].nombre.Equals(buscar))
                {
                    evento[i].nombre = null!;
                    evento[i].fecha = null!;
                    evento[i].lugar = null!;
                    evento[i].hora = null!;

                    escribir(50,$"Se elimino correctamente el evento {buscar} de esta agenda...");
                }


            }
            Console.ReadKey();
        }
        
    }


//-----------------------------------------------------------------------------------   


    static void Conversor_de_unidades()
    {
        do
        {
            Console.Clear();
            escribir(50,"Elige el conversor que deseas utilizar: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[1]Conversor de temperatura");
            Console.WriteLine("[2]Conversor de monedas");
            Console.WriteLine("[3]Volver al menu principal");
            Console.WriteLine("[4]Salir");

            opcion = Convert.ToInt32(Console.ReadLine()); 

                
                if (opcion <= 1 && opcion <= 4)
                {
                    Vuelta = 1;

                }

            switch(opcion)
            {
                case 1:
                    unidades_Temperatura();
                    break;

                case 2:
                    unidades_Cantidad();
                    break;

                case 3:
                    Main();
                    break;

                case 4:
                    Salir();
                    break;

                default:
                    Default();
                    break;
            }

        }while(Vuelta != 4);

        //---------------------------------------------------------------------------------//

        static void unidades_Temperatura()
        {
            do
            {
                Console.Clear();
                escribir(50,"Elige la temperatura a la cual deseas hacer una conversion: ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("[1]FAHRENHEIT a CELSIUS"); 
                Console.WriteLine("[2]CELSIUS a KELVIN"); 
                Console.WriteLine("[3]KELVIN a FAHRENHEIT");
                Console.WriteLine("[4]Volver al menu de conversor de unidades");
                Console.WriteLine("[5]Salir");

                opcion = Convert.ToInt32(Console.ReadLine()); 

                    
                    if (opcion <= 1 && opcion <= 5)
                    {
                        Vuelta = 1;

                    }

                switch(opcion)
                {
                    case 1:
                        Console.Clear(); 
                        Console.WriteLine(" ingrese la cantidad de grados a convertir de fahrenfeit a celsius son: "); 
                        numero = Convert.ToDouble(Console.ReadLine());  
                        fah =(numero - 32)/1.8;
                        Console.WriteLine(fah); 
                        Console.ReadKey();     
                        break; 

        
                    case 2: 
                        Console.Clear(); 
                        Console.WriteLine("Ingrese la cantidad de grados a convertir de celsius a Kelvin son: "); 
                        numero = Convert.ToDouble(Console.ReadLine());
                        cel = numero + 273.15;  
                        Console.WriteLine(cel); 
                        Console.ReadKey(); 
                        break; 
        
                    case 3: 
                        Console.Clear(); 
                        Console.WriteLine("Ingrese la cantidad de grados a convertir de Kelvin a Fahrenheit son: "); 
                        numero = Convert.ToDouble(Console.ReadLine()); 
                        kel = (numero - 273.15) * 9/5 + 32; 
                        Console.WriteLine(kel); 
                        Console.ReadKey();  
                        break; 

                    case 4:
                        Conversor_de_unidades();
                        break;

                    case 5:
                        Salir();
                        break;

                    default:
                        Default();
                        break;
                }

            }while(Vuelta != 5);

        }

        //---------------------------------------------------------------------------------//

        static void unidades_Cantidad()
        {
            do
            {
                Console.Clear();
                escribir(50,"Elige la cantidad de dinero que quieres convertir: ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("[1]Pesos a dolar"); 
                Console.WriteLine("[2]Euro a dolar"); 
                Console.WriteLine("[3]Dolar a pesos");
                Console.WriteLine("[4]volver");
                Console.WriteLine("[5]Salir");

                opcion = Convert.ToInt32(Console.ReadLine()); 

                    
                    if (opcion <= 1 && opcion <= 5)
                    {
                        Vuelta = 1;

                    }

                switch(opcion)
                {
                    case 1:
                        Console.Clear(); 
                        Console.WriteLine("Ingrese la cantidad de pesos para convertir a dolar son: "); 
                        numero = Convert.ToDouble(Console.ReadLine()); 
                        pe = (numero / 53.86); 
                        Console.WriteLine(pe); 
                        Console.ReadKey(); 
                        break;

                    case 2:
                        eu = 1; 
                    
                        Console.Clear(); 
                        Console.WriteLine($"Ingrese la cantidad de euros para convertir a dolar son: "); 
                        numero = Convert.ToDouble(Console.ReadLine()); 
                        eu = (numero / eu);  
                        Console.WriteLine(eu); 
                        Console.ReadKey(); 
                        break;

                    case 3:
                        Console.Clear(); 
                        Console.WriteLine("Ingrese la cantidad de dolares para convertir a pesos son: "); 
                        numero = Convert.ToDouble(Console.ReadLine()); 
                        dol = (numero * 53.40); 
                        Console.WriteLine(dol); 
                        Console.ReadKey();
                        break;

                    case 4:
                        Conversor_de_unidades();
                        break;

                    case 5:
                        Salir();
                        break;

                    default:
                        Default();
                        break;
                }

            }while(Vuelta != 5);

        }
        
    }


//-----------------------------------------------------------------------------------   


        static void Calculadora()
        {
            Console.Clear();

            do
            {
                Console.Clear();
                escribir(50,"Elije una de operacion a realizar:");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("[1] - Suma");
                Console.WriteLine("[2] - Resta");
                Console.WriteLine("[3] - Multiplicacion");
                Console.WriteLine("[4] - Divicion");
                Console.WriteLine("[5] - Volver al menu principal");
                Console.WriteLine("[6] - Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                

                if (opcion <= 1 && opcion <= 5)
                {
                    Vuelta = 1;
                    
                }
            

                switch (opcion)
                {
                    case 1: 
                        Console.Clear();

                        Console.WriteLine("Digite el primer numero");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());


                        resul = num + num2;

                        Console.WriteLine();
                        Console.WriteLine("***********************************");
                        escribir(50,"El resultado de la suma es: " + resul);
                        Console.WriteLine("***********************************");
                        Console.ReadKey();
                        break;

                    case 2: 
                        Console.Clear();
                        Console.WriteLine("Digite el primer numero");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());


                        resul = num - num2;

                        Console.WriteLine();
                        Console.WriteLine("*************************************");
                        escribir(50,"El resultado de la resta es : " + resul);
                        Console.WriteLine("*************************************");
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Digite el primer numero");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());


                        resul = num * num2;

                        Console.WriteLine();
                        Console.WriteLine("**********************************************");
                        escribir(50,"EL resultado de la multiplicacion es : " + resul);
                        Console.WriteLine("**********************************************");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Digite el primer numero");
                        num = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite el segundo numero");
                        num2 = Convert.ToInt32(Console.ReadLine());


                        resul = num / num2;

                        Console.WriteLine();
                        Console.WriteLine("****************************************");
                        escribir(50,"El resultado de la divicion es : " + resul);
                        Console.WriteLine("****************************************");
                        Console.ReadKey();
                        break;

                    case 5: 
                        Main();
                        break;

                    case 6: 
                        Salir();
                        break;

                    default: 
                        Default();
                        break;

                }

            } while (Vuelta != 5);

        }

//-----------------------------------------------------------------------------------

    
    static void Salir()
    {
        Console.Clear();
        escribir(100,"cerrando el programa... :) ");
        Environment.Exit(0);
        Console.ReadKey();
    }


//-----------------------------------------------------------------------------------   


    static void Default()
    {
        Console.Clear();
        escribir(100,"Opcion incorrecta");
        Console.ReadKey();
    }


//-----------------------------------------------------------------------------------   
              
    static void escribir(int vel, string texto)
    {
        for(int i = 0; i<texto.Length; i++)
        {
            Console.Write(texto[i]);
            Thread.Sleep(vel);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
    }

}