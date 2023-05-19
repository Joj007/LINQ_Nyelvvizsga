using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Ev
    {
        int ev;
        int angol;
        int arab;
        int cigány1;
        int cigány2;
        int bolgár;
        int cseh;
        int finn;
        int dán;
        int eszperantó;

        public Ev(int ev, int angol, int arab, int bolgar, int cigany1, int cigany2, int cseh, int dan, int eszperanto, int finn)
        {
            this.ev = ev;
            this.angol = angol;
            this.arab = arab;
            this.bolgár = bolgar;
            this.cigány1 = cigany1;
            this.cigány2 = cigany2;
            this.cseh = cseh;
            this.dán = dan;
            this.eszperantó = eszperanto;
            this.finn = finn;
        }

        public int Angol { get => angol; set => angol = value; }
        public int Arab { get => arab; set => arab = value; }
        public int Cigány1 { get => cigány1; set => cigány1 = value; }
        public int Cigány2 { get => cigány2; set => cigány2 = value; }
        public int Bolgár { get => bolgár; set => bolgár = value; }
        public int Cseh { get => cseh; set => cseh = value; }
        public int Finn { get => finn; set => finn = value; }
        public int Dán { get => dán; set => dán = value; }
        public int Eszperantó { get => eszperantó; set => eszperantó = value; }
        public int EvAdat { get => ev; set => ev = value; }
    }
}
