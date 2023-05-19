using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Nyelv
    {
        string nev;
        int _2009;
        int _2010;
        int _2011;
        int _2012;
        int _2013;
        int _2014;
        int _2015;
        int _2016;
        int _2017;
        int[] evek;


        public Nyelv(string csvSor)
        {
            string[] adatTagok = csvSor.Split(';'); 
            this.nev = adatTagok[0];
            this._2009 = int.Parse(adatTagok[1]);
            this._2010 = int.Parse(adatTagok[2]);
            this._2011 = int.Parse(adatTagok[3]);
            this._2012 = int.Parse(adatTagok[4]);
            this._2013 = int.Parse(adatTagok[5]);
            this._2014 = int.Parse(adatTagok[6]);
            this._2015 = int.Parse(adatTagok[7]);
            this._2016 = int.Parse(adatTagok[8]);
            this._2017 = int.Parse(adatTagok[9]);
            evek = new int[] { _2009, _2010, _2011, _2012 , _2013, _2014 , _2015, _2016 , _2017};
        }

        public string Nev { get => nev; set => nev = value; }
        public int _2009_ { get => _2009; set => _2009 = value; }
        public int _2010_ { get => _2009; set => _2009 = value; }
        public int _2011_ { get => _2009; set => _2009 = value; }
        public int _2012_ { get => _2009; set => _2009 = value; }
        public int _2013_ { get => _2009; set => _2009 = value; }
        public int _2014_ { get => _2009; set => _2009 = value; }
        public int _2015_ { get => _2009; set => _2009 = value; }
        public int _2016_ { get => _2009; set => _2009 = value; }
        public int _2017_ { get => _2009; set => _2009 = value; }
        public int[] Evek { get => evek; set => evek = value; }
    }
}
