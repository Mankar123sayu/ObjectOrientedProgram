using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgram
{
    public class ReadTheData
    {
        public InventoryDetails Read(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    return JsonConvert.DeserializeObject<InventoryDetails>(json);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
        public StockAccount Read2(string path2)
        {
            using (StreamReader file2 = new StreamReader(path2))
            {
                try
                {
                    string json2 = file2.ReadToEnd();
                    return JsonConvert.DeserializeObject<StockAccount>(json2);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }
            }
        }
    }
}