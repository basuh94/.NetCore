using System;
using static System.Console;  //LLamamos


namespace ProgramaEjemplo01
{
    class Program
    {   /*
        -------------------------------------------------------------------------------------------------
        //ENUMERADORES
        enum Color {Yellow = 1, Blue, Green};
        enum Meses  {Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre ,Noviembre, Diciembre};
        enum Semana  {Lunes = 1, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo};*/
        static void Main(string[] args)
        {   
            
           /* Console.WriteLine("Escribe el nombre de la mesa: ");
            string name = "Mesa Azul";
            double width = 2400.57;
            Console.WriteLine($" La {name} es {width}");

            //Tamaño de un tipo de dato entero sizeof() en byte
            //Con MinValue:N0 el tamaño minimo de un tipo de valor
            //Con MaxValue:N0 EL tamaño maximo de un tipo de valor 
            
            Console.WriteLine($"int emplea {sizeof(int)} byte y puede almacenar número desde {int.MinValue:N0} a {int.MaxValue:N0}.");
            Console.WriteLine($"double emplea {sizeof(double)} byte y puede almacenar número desde {double.MinValue:N0} a {double.MaxValue:N0}.");
            Console.WriteLine($"decimal emplea {sizeof(decimal)} byte y puede almacenar número desde {decimal.MinValue:N0} a {decimal.MaxValue:N0}.");
            Console.WriteLine($"byte emplea {sizeof(byte)} byte y puede almacenar número desde {byte.MinValue:N0} a {byte.MaxValue:N0}.");
            Console.WriteLine($"short emplea {sizeof(short)} byte y puede almacenar número desde {short.MinValue:N0} a {short.MaxValue:N0}.");
            Console.WriteLine($"char emplea {sizeof(char)} byte y puede almacenar número desde {char.MinValue:N0} a {char.MaxValue:N0}.");
            Console.WriteLine($"ulong emplea {sizeof(ulong)} byte y puede almacenar número desde {ulong.MinValue:N0} a {ulong.MaxValue:N0}.");
            Console.WriteLine($"long emplea {sizeof(long)} byte y puede almacenar número desde {long.MinValue:N0} a {long.MaxValue:N0}.");
            Console.WriteLine($"uint emplea {sizeof(uint)} byte y puede almacenar número desde {uint.MinValue:N0} a {uint.MaxValue:N0}.");

            
            string PathDeArchivo = @"C:\Users\pramos.BSW\Desktop\Curso.Net";  // @ Para tratar \ con su vendareo valor 
            string PathDeArchivotab = "C:\\Users\\pramos.BSW\\Desktop\\Curso.Net"; 
            Console.WriteLine(PathDeArchivotab);
            Console.WriteLine(PathDeArchivo);
        
            Console.WriteLine("Introduce tu nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Tu nombre es: \t {nombre}");   
            
            while(true){
                Console.Write("Presiona una tecla o combinación de teclas: ");
                ConsoleKeyInfo tecla = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("Tecla:{0}, Caracter:{1}, Modificador:{2}", arg0:tecla.Key, arg1:tecla.KeyChar, arg2: tecla.Modifiers);    
            } 
            
            -------------------------------------------------------------------------------------------------
            int numero = 1;
            Console.WriteLine("El numero uno se esribe como " + numero);
            Console.WriteLine($"El numero uno se esribe como {numero}");
            Console.WriteLine("El numero uno se escribe como {0} y el siguiente es {1}",  arg0:numero++, arg1:numero);
            
            -------------------------------------------------------------------------------------------------
            Console.Clear();
            Console.WriteLine("-------ENUMERACIONES-------");
            Console.WriteLine(
                
                "General (G) \t {0:G}\n"+
                "Defecto \t {0} (default = 'G')\n"+
                "Flag \t {0:F} (flags o interger)\n"+
                "Numero Decimal \t {0:D}\n"+
                "Hexadecimal \t {0:X} \n", Color.Green
            ); 
           

        
            Console.WriteLine("------------MESES------------");
            Console.WriteLine(

                "General (G) \t {0:G}\n"+
                "Defecto \t {0} (default = 'G')\n"+
                "Flag \t {0:F} (flags o interger)\n"+
                "Numero Decimal \t {0:D}\n"+
                "Hexadecimal \t {0:X} \n", Meses.Marzo
            ); 
            Console.WriteLine("El mes de {1:G} es el mes numero {1:D}", Meses.Diciembre,);
            
           
            Console.Clear();

            Console.WriteLine("\n\a \\a=Timbre \r \\r=Otra Linea \\n=nueva");
            Console.WriteLine("\n\t \\t=Texto tabulado");
            Console.WriteLine("\n \'Exto entrecomillado(1)\'");
            Console.WriteLine("\n \"Exto entrecomillado(2)\"");
            
            
            -------------------------------------------------------------------------------------------------
            int AnchuraOriginal, Anchura;
            int AlturaOriginal, Altura;

            string Texto1 = "La vetana original tiene de anchura {0} y de altura {1}";
            string Texto2 = "La vetana ahora tiene de anchura {0} y de altura {1}";
            string TextoTecla =  "Presione una tecla pra continuar";

            AnchuraOriginal = Console.WindowWidth;
            AlturaOriginal = Console.WindowHeight;
            Console.Clear();
            Console.WriteLine(Texto1, AnchuraOriginal, AlturaOriginal);
            Console.WriteLine(TextoTecla);
            Console.ReadLine();
            Anchura = AnchuraOriginal/2;
            Altura = AlturaOriginal/2;
            Console.SetWindowSize(Anchura, Altura);
            Console.WriteLine(Texto2, Anchura, Altura);
            Console.WriteLine(TextoTecla);
            Console.ReadLine();
            Anchura = AnchuraOriginal;
            Altura = AlturaOriginal;
            Console.SetWindowSize(Anchura, Altura);
            
            -------------------------------------------------------------------------------------------------
            int ColorOriginal, RowOriginal;
            Console.Clear();
            ColorOriginal = Console.CursorTop;
            RowOriginal = Console.CursorLeft;           
            Console.SetCursorPosition(ColorOriginal + 10, RowOriginal);
            Console.Write("╔"); //alt+201
            Console.SetCursorPosition(ColorOriginal + 11, RowOriginal);
            Console.Write("═"); //alt + 205
            Console.SetCursorPosition(ColorOriginal + 12, RowOriginal);
            Console.Write("═");
            Console.SetCursorPosition(ColorOriginal + 13, RowOriginal);
            Console.Write("═");
            Console.SetCursorPosition(ColorOriginal + 14, RowOriginal);
            Console.Write("╗"); //alt+187
            Console.SetCursorPosition(ColorOriginal + 10, RowOriginal+1);
            Console.Write("║");
            Console.SetCursorPosition(ColorOriginal + 14, RowOriginal+1);
            Console.Write("║");
            Console.SetCursorPosition(ColorOriginal + 10, RowOriginal+2);
            Console.Write("╚"); // alt + 200
            Console.SetCursorPosition(ColorOriginal + 11, RowOriginal+2);
            Console.Write("═");
            Console.SetCursorPosition(ColorOriginal + 12, RowOriginal+2);
            Console.Write("═");
            Console.SetCursorPosition(ColorOriginal + 13, RowOriginal+2);
            Console.Write("═");
            Console.SetCursorPosition(ColorOriginal + 14, RowOriginal+2);
            Console.Write("╝"); //alt + 188
            -------------------------------------------------------------------------------------------------
            //Cambiar la consola de COLOR//
            var ColorDeFondoActual =  Console.BackgroundColor;
            var ColorDeTintaActual = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.WriteLine("Presiona una tecla para volver aa los colores originales");
            Console.ReadLine();
            Console.BackgroundColor=ColorDeFondoActual;
            Console.ForegroundColor = ColorDeTintaActual;
            Console.Clear(); 
            -------------------------------------------------------------------------------------------------
            //PASAR NUMERO ENTERO A STRING//
            Console.WriteLine("Introduce valor de numero");
            string NumeroIntroducido  = Console.ReadLine();
            int numero2 = Int32.Parse(NumeroIntroducido) + 10;
            Console.WriteLine($"Numero Introducido:{NumeroIntroducido}");
            Console.WriteLine($"Numero Introducido + 10:{numero2}");
            
            -------------------------------------------------------------------------------------------------   
            object anchura =  1.88; //Object de un double 
            object nombre = "Mesa"; //Object de un string 
            Console.WriteLine($"{nombre} es {anchura} mm");
            -------------------------------------------------------------------------------------------------  
             //MATRICES//
            string[]nombre;
            nombre = new string[4];
            nombre[0] = "Ale";
            nombre[1] = "Juan";
            nombre[2] = "Pablo";
            nombre[3] = "Alberto";

            for (int i = 0; i < nombre.Length; i++) 
            {
                Console.WriteLine(nombre[i]);
                Console.WriteLine("Nombre {0:N0}", arg0:nombre[i]);
                Console.WriteLine("Nombre: " + nombre[i]);
            }
            
            //DETRAS DE INT SI PONES ? PUEDES PERMITIR VALORES NULOS//
            int? PodriaSerNulo = null;
            Console.WriteLine (PodriaSerNulo);
            Console.WriteLine(PodriaSerNulo.GetValueOrDefault());

            PodriaSerNulo = 7;
            Console.WriteLine (PodriaSerNulo);
            Console.WriteLine(PodriaSerNulo.GetValueOrDefault());
            
            // CUANDO HACEMOS UN dotnet run arg1 arg2 arg3  LO MOSTRAMOS POR LA PANTALLA 
            Clear();
            WriteLine($"Existen {args.Length} argumentos");
             foreach(string arg in args){
                 WriteLine(arg);
             }

             if(args.Length > 4){
                 WriteLine("Debes especificar dos colores y dimensiones de la ventana. Por ejemplo: red green 50 40");
                 return;     
             }

             var ColorDeFondoActual = BackgroundColor;
             var ColorDeTintaActual = ForegroundColor;
             int AlturaActual = WindowHeight;
             int AnchurActual = WindowWidth;

             int Anchura = int.Parse(args[2]);
             int Altura = int.Parse(args[3]);

             SetWindowSize(Altura,Anchura);
             ForegroundColor = (ConsoleColor)Enum.Parse(
                 enumType: typeof(ConsoleColor),
                 value:args[0],
                 ignoreCase:true
             );

              BackgroundColor = (ConsoleColor)Enum.Parse(
                 enumType: typeof(ConsoleColor),
                 value:args[1],
                 ignoreCase:true
             );
             WriteLine("Pulsa para volver a los valores preterminados");
             ReadLine();
             WindowWidth = AnchurActual;
             WindowHeight = AlturaActual;
             BackgroundColor = ColorDeFondoActual;
             ForegroundColor = ColorDeTintaActual;
            -------------------------------------------------------------------------------------------------  
             //EJERCICIO1
            WriteLine("Introduce el primer numero");
             string num1s = ReadLine();
             int num1 = int.Parse(num1s);

            WriteLine("Introduce el segundo numero");
             string num2s = ReadLine();
             int num2 = int.Parse(num2s);

            WriteLine("Introduce el tercer numero");
            string num3s = ReadLine();
            int num3 = int.Parse(num3s);

            int result = num1 + num2 + num3;

            Write($"La suma de los numero {num1}, {num2}, {num3} es: {result}");
            
            -------------------------------------------------------------------------------------------------  
             //EJERCICIO2 
             WriteLine("Hola introduce tu nombre: ");
             string nombre = ReadLine();

             WriteLine("De que ciudad eres?: ");
             string ciudad = ReadLine();

             WriteLine("Hola {0} tu ciudad es {1}",nombre,ciudad);
             

            WriteLine("Hola introduce tu nombre: ");
             string nombre = ReadLine();

            WriteLine("Introduce tu edad");
             string edad = ReadLine();
             int edad1 = int.Parse(edad);

             WriteLine("Tu nombre es {0} y tu edad es {1}",nombre, edad1);
            

              WriteLine("Introduce el primer numero");
             string num1s = ReadLine();
             int num1 = int.Parse(num1s);

            WriteLine("Introduce el segundo numero");
             string num2s = ReadLine();
             int num2 = int.Parse(num2s);

             if(num1>num2){
                 WriteLine($"El numero {num1} es mayor");
             }else if(num1<num2){
                 WriteLine($"El numero {num2} es mayor");
             }else{
                 WriteLine($"El numero {num1} es igual a {num2}");
             }
            WriteLine("Introduce el nombre le la semana");
            string dia = ReadLine();
            if(dia.ToLower() == "sabado" || dia.ToLower() == "domingo"){
                WriteLine($"El {dia} es fin de semana");
            }else{
                WriteLine($"El {dia} se tiene que trabajar!");
            }
            ------------------------------------------------------------------------------------------------- 
            //EJERCICIO3 
            
                WriteLine("Introduce el dia de la semana:");
                string sDayNum = ReadLine();
                try{
                    int iDayNum = int.Parse(sDayNum);
                    if(iDayNum>7 || iDayNum<=0){
                        WriteLine($"{iDayNum} no es un dia de la semana");   
                    }else{
                        foreach (var day in Enum.GetValues(typeof(Semana))){
                            string nsDayNum = string.Format("{0:D}",day);
                            int isDayNum = int.Parse(nsDayNum);    
                            if(iDayNum==isDayNum && iDayNum>=6){
                                WriteLine($"El {day} es fin de semana!");
                            }else if(iDayNum==isDayNum && iDayNum<6){
                                WriteLine($"El {day} se trabaja!");
                            }
                        }
                    }  
                }
                catch (System.Exception){
                    WriteLine("No has introducido un numero");   
                }  
         
            ------------------------------------------------------------------------------------------------- 
            //EJERCICIO8
            int par = 0;
            int impar = 0;
            Console.SetCursorPosition(10,0);
            WriteLine("--PARES--");
            Console.SetCursorPosition(20,0);
            WriteLine("--IMPARES--");
            for (int i = 0; i < 101; i++){  
                if(i%2==0){
                    Console.SetCursorPosition(10,par);
                     par++;
                    WriteLine($"{i}");
                }

                if(i%3==0){ 
                    Console.SetCursorPosition(20,impar);
                    impar++;
                    WriteLine($"{i}");
                }     
            }
            
           int num1 = 0;
           int num2 = 0;

           for (int i = 0; i < 2; i++){
                int numeroA = int.Parse(args[i]);   
                num1 += numeroA;
           } 
             for (int i = 2; i < 5; i++){
                int numeroB = int.Parse(args[i]);   
                num2 += numeroB;
           } 
           WriteLine(num1 / num2);
        
           ------------------------------------------------------------------------------------------------- 
          
            int numero1 =int.Parse(args[0]);
            int numero2 = int.Parse(args[1]);
            int result = numero1*numero1;
            Console.WriteLine(result);
            
            // TEMA 2 EJERCICIO 12
            int[]numeros;
            numeros = new int[20];
            int j=0;
            int suma = 0;
            int producto = 1;
            bool exit=false;
            var ColorDefault = ForegroundColor;

            for (int i =5437; exit==false; i++){
                if(i%3==0){  
                    try{
                        numeros[j++]=i;         
                    }catch(Exception){
                        for (int ite = 0; ite < numeros.Length; ite++){
                            Console.ForegroundColor = ColorDefault;
                            WriteLine(numeros[ite]);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            producto *= numeros[ite];
                            WriteLine($"Producto: {producto}");
                            suma = suma + numeros[ite];
                        }
                        WriteLine("---------------------");
                        Console.ForegroundColor = ConsoleColor.Red; 
                        WriteLine($"Total: {suma}");
                        exit = true;
                    }
                    Console.ForegroundColor = ColorDefault;
                } 
            }

            int i = 3;
            WriteLine(i);
            WriteLine(i++);
            WriteLine(i);
            
            double u = 1.2;
            WriteLine(u);
            WriteLine(++u);
            WriteLine(u);

            int d = 3;
            WriteLine(d);
            WriteLine(d--);
            WriteLine(d);

            double z = 1.2;
            WriteLine(z);
            WriteLine(--z);
            WriteLine(z);
            

            DateTime fecha = new DateTime(2020,03,09);
            WriteLine($"{fecha}");
            DateTime fecha =  DateTime.Now;
            WriteLine($"{fecha}");

            DateTime fecha = DateTime.Now;
            DateTime mañana = DateTime.Today;

            WriteLine($"El dia de ayer a la misma hora: {fecha.AddDays(-1)}");
            WriteLine($"Dia de ayer  sin hora: {mañana.AddDays(-1)}");
            WriteLine($"El dia de mañana a la misma hora: {fecha.AddDays(1)}");
            WriteLine($"Dia de mañana sin hora: {mañana.AddDays(1)}");

            int NumeroDeDias = DateTime.DaysInMonth(2020, 2);
            WriteLine($"El numero de dias de Febrero de 2020 era de : {NumeroDeDias}");
            
            string HoraActual = DateTime.Now.ToString("HH:MM:ss zzz dddd");
            WriteLine($"{HoraActual}");
            

            DateTime hoy  = DateTime.Now;

            WriteLine($"El dia de hoy es {hoy}");
            WriteLine($"El dia de mañana es {hoy.AddDays(1)}");
        EtiquetaOriginaria:
            var numero = (new Random()).Next(1,7);
            WriteLine($"He creado mi primer numero aleatorio {numero}");

            switch(numero){
                case 1:
                    WriteLine("Uno");
                    break;
                case 2: 
                    WriteLine("Dos");
                    goto case 1;
                case 3:
                case 4: 
                    WriteLine("Tres o Cuatro");
                    goto case 1;
                case 5:
                    System.Threading.Thread.Sleep(500);
                    goto EtiquetaOriginaria;
                default:
                    WriteLine("Por defecto");
                    break; 
                
            }
               
            }
            double producto = 1;
            for (int i = 0; i<6; i++){
                var aleatorio = (new Random()).Next(1,500);
                producto *= aleatorio;
                WriteLine($" El Numero Aleatorio: {aleatorio}");
                WriteLine($" El Producto: {producto}");     
            }

            double multiplicar = 1;
            var ColorFuenteDefecto = ForegroundColor;
            for (int i = 0; i<10; i++){
                Console.ForegroundColor = ConsoleColor.Green;
                var aleatorio = (new Random()).Next(-45738,96431);
                    Write($"{aleatorio}\t");
                    multiplicar *=aleatorio;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine($"{multiplicar:N0}");
            Console.ForegroundColor = ColorFuenteDefecto;

            int x = 0; 
            Clear();
            while(true){
                x++;
                if(x == 2000){
                    break;
                }
            Clear();
            string password = string.Empty;
            do{
                Write("Escribe una contraseña: ");
                password = ReadLine();
            }
            while(password!="CONTRASEÑA");
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Lo has conseguido");
            
            uint a = 5;
            var b = -a;
            
            WriteLine(b);
            WriteLine(b.GetType());

            WriteLine(a);
            WriteLine(a.GetType());
            

            int p = 6;
            p +=3;
            WriteLine(p);
            p -=3;
            WriteLine(p);
            p *=3;
            WriteLine(p);
            p /=3;
            WriteLine(p);
            
            int a = 10;
            double b =  a; 
            WriteLine(b);
            

            double c =9.5;
            int d = Convert.ToInt32(c);
            WriteLine(d);
            
            
            int numero = 12;
            WriteLine(numero.ToString());

            bool numero1 = true;
            WriteLine(numero1.ToString());

            DateTime ahora  = DateTime.Now;
            WriteLine(ahora.ToString());

            object yo = new object();
            WriteLine(yo.ToString());
            
            
            int edad = int.Parse("7");
            DateTime Cumpleaños = DateTime.Parse("6 Diciembre de 1994");

            WriteLine($"Nací hace {edad} años");
            WriteLine($"Mi cumpleaños es {Cumpleaños}");
            WriteLine($"Mi cumpleaños es el {Cumpleaños:D}");
            

            Write("Cual es tu edad: ");
            string EdadIntroducida = ReadLine();

            try{
                uint edad = uint.Parse(EdadIntroducida);
                WriteLine($"Tiene {edad} años");
            }
            catch(FormatException){
                WriteLine("La edad introducida no tiene un formato valido");
            }
            catch(OverflowException){
                WriteLine("Te has pasado del rango que se puede introducir");
            }
            catch(Exception e){
                WriteLine($"{e.GetType()}  {e.Message}");
            }
            

            DateTime año1 =new DateTime(2020,05,30);
            DateTime año2 =new DateTime(2030,05,30);
            TimeSpan result =  año2 - año1;
            int dias = result.Days;

            WriteLine(dias);
            // RELOJ EJERCICIO 2 TEMA 3

            //WriteLine("Introduce una hora para la Alarma");
            String alarma = args[0];

            while(true){
                int ColumOriginal, RowOriginal;
                DateTime TimeAhora = DateTime.Now;
                String hora = TimeAhora.ToString("hh:mm:ss");
                String fecha = TimeAhora.ToString("dd/MM/yyyy");

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                ColumOriginal = Console.CursorTop;
                RowOriginal = Console.CursorLeft;           
                Console.SetCursorPosition(ColumOriginal + 10, RowOriginal);
                Console.Write("╔"); 
                Console.SetCursorPosition(ColumOriginal + 11, RowOriginal);
                for (int i = 0; i < 10; i++){
                    Console.Write("═");
                } 
                Console.Write("╗"); 
                Console.SetCursorPosition(ColumOriginal + 10, RowOriginal+1);
                Console.Write("║");
                Write($" {hora}");
                Console.SetCursorPosition(ColumOriginal + 21, RowOriginal+1);
                Console.Write("║");
                Console.SetCursorPosition(ColumOriginal + 10, RowOriginal+2);
                Console.Write("╚"); 
                Console.SetCursorPosition(ColumOriginal + 11, RowOriginal+2);
                for (int i = 0; i < 10; i++){
                    Console.Write("═");
                } 
                Console.SetCursorPosition(ColumOriginal + 21, RowOriginal+2);
                Console.Write("╝"); 
                Console.SetCursorPosition(ColumOriginal + 8, RowOriginal+3);
                Console.ForegroundColor = ConsoleColor.Blue;
                Write($"Alarma: {alarma}");
                Console.SetCursorPosition(ColumOriginal + 10, RowOriginal+4);
                Console.ForegroundColor = ConsoleColor.Red;
                Write($"*{fecha}*");
                System.Threading.Thread.Sleep(1000);

                if(hora==alarma){
                    for (int i = 0; i < 25; i++){
        
                        Console.Beep(1600, 1000);
                        Console.SetCursorPosition(ColumOriginal + 11, RowOriginal+5);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        WriteLine("¡¡ALARMA!!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                
            }

            string fecha = ReadLine();
            DateTime semana = DateTime.Parse(fecha);
            string dia = semana.ToString("dddd");
            WriteLine($"{dia}");
            
            
           // DateTime fechaA = DateTime.Now;
            
          

            DateTime fechaA = DateTime.Parse("01/02/2020");
            while(true){   
                fechaA = fechaA.AddYears(-1);   
                string diaNom = fechaA.ToString("dddd");
                WriteLine(diaNom);

                if(diaNom=="viernes"){
                    WriteLine($"{fechaA}");
                    break;
                }

            DateTime FechaEntrada =DateTime.Parse($"01/{args[0]}/{args[1]}");
            String primerDia = FechaEntrada.ToString("dddd");
            WriteLine(primerDia);

            }
                //CALENDARIO
                DateTime FechaCalendario = DateTime.Parse("01/02/2019");
                int ColumOriginal, RowOriginal;
                ColumOriginal = Console.CursorTop;
                RowOriginal = Console.CursorLeft;  

                int i = 4;
                int row = 2;
                int colum = 30;
                int columSem = 20;
                string[] semana={"Lun","Mar","Mie","Jue","Vie","Sab","Dom"};
                
                
                Clear();
                //NOMBRE DIA DE LA SEMANA
                for (int g = 0; g < 7; g++){   
                    Console.SetCursorPosition(columSem, RowOriginal);
                    Write($"{semana[g]}");
                    columSem+=5;
                }                
                while(FechaCalendario.ToString("MM")=="02"){
                    //Iteraciones
                    colum = colum+5;
                    i++;
                    string Dias= FechaCalendario.ToString("dd");
                    int DiaInt = int.Parse(Dias);
                    Console.SetCursorPosition(ColumOriginal+colum, RowOriginal+row);

                    //Color de Festivos
                    if (colum==40 || colum==45){
                        Console.ForegroundColor = ConsoleColor.Green;
                    }else{
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    //Pinta el valor

                    Write($"{DiaInt}");

                    FechaCalendario=FechaCalendario.AddDays(1);
                    if(i>6){                  
                        row++;
                        i=0;
                        colum=10;
                    }
                }
                
                //EJERCICIO 6
                var numero = (new Random()).Next(1,7);
                WriteLine($"{numero}");

                //EJERCICIO 8
                Clear();
                WriteLine("Introduces un numero para jugar");
                var numero = (new Random()).Next(1,100);
                int  i = 0;

                while(true){
                    i++;
                    string respuesta =  ReadLine();
                    int respuestaInt = int.Parse(respuesta);
                    if(respuestaInt == numero){
                        WriteLine($"Has acertado el numero es {numero}");
                        break;
                    }
                    else if(respuestaInt>100){
                        WriteLine($"{respuestaInt} es un numero muy grande");
                    }
                    else if(i==6){
                        WriteLine($"No has acertado el numero correcto es {numero}");
                        break;
                    }
                }

                //EJERCICIO 9
                int[] numero;
                numero = new int[100];
                int resultado =0;
                double media = 0;

                for (int i = 0; i < 101; i++)
                {
                    int random = (new Random()).Next(-1000,1000);
                    try{
                    numero[i]=random; 
                    resultado = resultado + random;
                    }catch{
                        media =  resultado/numero.Length;
                        WriteLine($"La media de todos los numeros son: {media}");
                    }
                }
 
            Clear();
            bool[,] vector = new bool[24,79];

            for (int i = 0; i < 101; i++)
            {
                  int x = (new Random()).Next(0,24);
                  int y = (new Random()).Next(0,79);
                  vector[x,y] = true;
            }

            for (int i=0;i<79;i++)
            {
                for (int j=0;j<24;j++)
                {
                    if(vector[j,i]){
                        SetCursorPosition(i, j);
                        Write("*");
                    }
                }
            }
   

    DateTime fecha1 = DateTime.Parse("12/03/2020");
    DateTime fecha2 = DateTime.Parse("12/05/2020");
    DateTime FechaResult;
    String DiaSem;


    for (int i = 0; i < 10; i++)
    {
        int random = (new Random()).Next(1,61);
        FechaResult = fecha1.AddDays(random);
        DiaSem = FechaResult.ToString("ddddd");
        if(FechaResult>fecha2 || DiaSem=="viernes"|| DiaSem=="sabado" || DiaSem=="domingo"){
            --i;
            //WriteLine("La fecha no está dentro del rango");
        }else{
            WriteLine($"Fecha{i}: {FechaResult.ToString("dd/MM/yyyy")}");
        }    
        
    }
    /*  
      int ancho = int.Parse(args[0]);
    int abajo = int.Parse(args[1]);
        Clear();
        //SetCursorPosition(6, 40);
        //Write("OOO");

        //WriteLine($"{ancho} {abajo}");
        for (int i = 0; i < abajo; i++)
        {
           SetCursorPosition(0, i); 
           Write("║");
        }
        for (int j = 0; j < ancho; j++)
        {
           SetCursorPosition(j, 0); 
           Write("═");
        }
        for (int c = 0; c < ancho; c++)
        {
           SetCursorPosition(c, ancho); 
           Write("═");
        }
          for (int c = 0; c < abajo; c++)
        {
           SetCursorPosition(ancho, c); 
           Write("║");
        }
         */
              
        }
    }

}


