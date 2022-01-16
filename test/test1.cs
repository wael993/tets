using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
   public class artikel
    {
        public artikel(string obst_name, string obst_herkunft, int obst_preis)
        {
            this.obst_name = obst_name;
            this.obst_herkunft = obst_herkunft;
            this.obst_preis = obst_preis;
        }

        public string obst_name { get; set; }
        public string obst_herkunft { get; set; }
        public int obst_preis { get; set; }

    }
    public class Invoice
    {
        artikel banana = new artikel("banana","somal" ,1);


    }

}
