using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    public class InventoryDetails
    {
        public List<TypeOfRice> typeOfRice;
        public List<TypeOfPulses> typeOfPulses;
        public List<TypeOfWheats> typeOfWheats;
    }
    public class TypeOfRice
    {

        public string name;
        public int weight;
        public int price;
    }
    public class TypeOfPulses
    {
        public string name;
        public int weight;
        public int price;
    }
    public class TypeOfWheats
    {
        public string name;
        public int weight;
        public int price;
    }

}
    

