using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongVat
{
    namespace AnCo
    {
        public class Bo 
        {
            public string Id {  get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }

            public Bo() { }

            public Bo (string id, string name, int weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }

        public class Trau
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public Trau() { }


            public Trau(string id, string name, int weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }

        public class De
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public De() { }


            public De(string id, string name, int weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }
    }

    namespace AnThit
    {
        public class CaSau
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public CaSau() { }


            public CaSau (string id, string name, int weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }

        public class Ho
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public Ho() { }


            public Ho(string id, string name, int weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }

        public class SuTu
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public SuTu() { }


            public SuTu(string id, string name, int weight)
            {
                Id = id;
                Name = name;
                Weight = weight;
            }
        }
    }

    namespace AnTap
    {
    }

    
}
