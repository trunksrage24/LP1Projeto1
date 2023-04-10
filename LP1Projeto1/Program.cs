using System;

//B->BOTÃO L->LAMPADA
//1B-->1L  2B-->1L,2L   3B-->2L,3L
//Maximo de 6 jogadas.
namespace LP1Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Game!");
            int NumbMoves=0;
            
            bool LAMP1=false;
            bool LAMP2=false;
            bool LAMP3=false;

            
            while (NumbMoves<7)
            {
            Console.WriteLine("Clicks on buttons: "+NumbMoves);
            Console.WriteLine("Which button will you press? B1,B2 or B3.");
            string ChosenBUT=Console.ReadLine();

            if (ChosenBUT=="B1" || ChosenBUT=="b1"){
                
                


            }
            else if (ChosenBUT=="B2" || ChosenBUT=="b2"){
                
                


            }
            else if (ChosenBUT=="B3" || ChosenBUT=="b3"){
                
                


            }
            else{
                Console.WriteLine("No valid input");
            }

            }
            
        }
    }
}
