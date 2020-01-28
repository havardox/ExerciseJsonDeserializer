using System.Collections.Generic;

namespace ExercsiseJsonDeserializer
{
    public class Muscles
    {
        public List<string> target { get; set; }
        public List<string> synergists { get; set; }
        public List<string> dynamicStabilizers { get; set; }
        public List<string> stabilizers { get; set; }
        public List<string> antogonistStabilizers { get; set; }
    }
}