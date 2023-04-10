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
            //count variable to count number of times user clicked buttons
            int NumbMoves=0;
            //variables to store the current state of the lamps
            bool LAMP1=false;
            bool LAMP2=false;
            bool LAMP3=false;
            //variables to be used to SHOW the current state of the lamps
            string Lamp1str="OFF";
            string Lamp2str="OFF";
            string Lamp3str="OFF";
            
            //loop until user gets to 7 clicks on buttons
            while (NumbMoves<7)
            {
            //depending on what state each lamp is, the STR variables will
            //store the suitable value between ON or OFF, to later show 
            //to the user the current state of the lamp
            if (LAMP1==false){
                Lamp1str="OFF";
            }else{Lamp1str="ON";} 

            if (LAMP2==false){
                Lamp2str="OFF";
            }else{Lamp2str="ON";} 

            if (LAMP3==false){
                Lamp3str="OFF";
            }else{Lamp3str="ON";} 

            //shows the current status of all lamps
            Console.WriteLine("Lamps Status:");  
            Console.WriteLine("Lamp 1: "+Lamp1str+"\n"+
                              "Lamp 2: "+Lamp2str+"\n"+
                              "Lamp 3: "+Lamp3str);  

            //Shows clicks made                  
            Console.WriteLine("Clicks on buttons: "+NumbMoves);

            Console.WriteLine("Which button will you press? B1,B2 or B3.");
            string ChosenBUT=Console.ReadLine();
            //each if for each button
            if (ChosenBUT=="B1" || ChosenBUT=="b1"){
                //switchs the value between TRUE or FALSE
                LAMP1=!LAMP1;
                
            }
            else if (ChosenBUT=="B2" || ChosenBUT=="b2"){
                
                


            }
            else if (ChosenBUT=="B3" || ChosenBUT=="b3"){
                
                


            }
            //when the input is not what is wanted
            else{
                Console.WriteLine("No valid input");
            }

            }
            
        }

        
    }
}
