using ObjectOrientedProgram;
using System;

namespace ObjectOrientedPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to object oriented program");

            Console.WriteLine("==========||==========");

            string path = "D:\\RFP281 Project\\ObjectOrientedProgram";
            ReadTheData read = new ReadTheData();

            InventoryDetails data = read.Read(path);

            Console.WriteLine("==========|Rice|==========");
            for (int i = 0; i < data.typeOfRice.Count; i++)
            {
                Console.WriteLine(data.typeOfRice[i].name);
                Console.WriteLine(data.typeOfRice[i].weight);
                Console.WriteLine(data.typeOfRice[i].price + "\n");
            }
            Console.WriteLine("==========|Pulses|==========");
            for (int j = 0; j < data.typeOfWheats.Count; j++)
            {
                Console.WriteLine(data.typeOfPulses[j].name);
                Console.WriteLine(data.typeOfPulses[j].weight);
                Console.WriteLine(data.typeOfPulses[j].price + "\n");
            }
            Console.WriteLine("==========|Wheat|==========");
            for (int k = 0; k < data.typeOfPulses.Count; k++)
            {
                Console.WriteLine(data.typeOfWheats[k].name);
                Console.WriteLine(data.typeOfWheats[k].weight);
                Console.WriteLine(data.typeOfWheats[k].price + "\n");
            }
        }
    }
}
