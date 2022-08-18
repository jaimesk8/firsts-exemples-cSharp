int numeroA, numeroB; 

            Console.write("Numero A: ");
            numeroA = int.Parse(Console.ReadLine()); 

            Console.write("Numero B: ");
            numeroB = int.Parse(Console.ReadLine()); 

            if (numeroA % 2 == 0 & numeroB % 2 == 0)
            { 
               Console.Write("Soma = " + (numeroA + numeroB));
            }

            if (numeroA % 2 != 0 & numeroB % 2 != 0)
            { 
               Console.Write("Multiplicação = " + numeroA * numeroB);
            }

            if (numeroA % 2 == 0 & numeroB % 2 != 0)
            { 
               Console.Write("Numero A é Par e o Numeor B é Impar");
            }

            if (numeroA % 2 != 0 & numeroB % 2 == 0)
            { 
               Console.Write("Numero A é Impar e o Numeor B é Par");
            }

            Console.ReadLine();
