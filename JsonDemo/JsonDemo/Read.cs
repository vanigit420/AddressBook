using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo
{
    public class Read
    {
        public Rice ReadTheData(string path)
        {
            using (StreamReader file = new StreamReader(path))
            {
                try
                {
                    string json = file.ReadToEnd();
                    //Console.WriteLine(json);

                    return JsonConvert.DeserializeObject<Rice>(json);
                    


                }catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}