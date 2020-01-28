using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExercsiseJsonDeserializer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises;
            using (StreamReader r = new StreamReader("exrx.json"))
            {
                string json = r.ReadToEnd();
                exercises = JsonConvert.DeserializeObject<List<Exercise>>(json);
            };

            foreach(var exercise in exercises)
            {
                if (exercise.muscles.target.Any())
                {
                    Console.WriteLine(exercise.muscles.target[0]);
                }
            }
        }
    }
}
