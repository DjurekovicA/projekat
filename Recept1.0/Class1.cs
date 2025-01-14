﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recept1._0
{
    public class Class1
    {
        private string NazivRecepta;
        private string Recept;
        private string TipJela;
        private string Sastojci;
        private List<string> Sastojak;
        public string GetNazivRecepta()
        {
            return NazivRecepta;
        }
        public void SetNazivRecepta(string a)
        {
            NazivRecepta = a;
        }
        public string GetRecept()
        {
            return Recept;
        }
        public void SetRecept(string a)
        {
            Recept = a;
        }
        public string GetTipJela()
        {
            return TipJela;
        }
        public void SetTipJelaa(string a)
        {
            TipJela = a;
        }
        public string GetSastojci()
        {
            return Sastojci;
        }
        public void SetSastojci(string a)
        {
            Sastojci = a;
        }
        public List<string> GetSastojak()
        {
            return Sastojak;
        }
        public void SetSastojak(List<string> a)
        {
            Sastojak = a;
        }
        public Class1(List<string> s)
        {
            Sastojak = s;
        }
        public Class1(string nr, string tj, List<string> s, string r)
        {
            NazivRecepta = nr;
            TipJela = tj;
            Recept = r;
            Sastojak = s;
        }
        public override string ToString()
        {
            return NazivRecepta + ", " + TipJela;
        }
    }
}
