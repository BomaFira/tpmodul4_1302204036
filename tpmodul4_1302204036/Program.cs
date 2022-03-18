// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204036
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric<string> halo = new HaloGeneric<string>();
            String c = "Boma Fira Suganda";
            halo.PanggilUser(c);
            DataGeneric<String> berkas = new DataGeneric<string>("1302204036");
            berkas.CetakData();
        }
    }
    public class HaloGeneric<T>
    {
        public void PanggilUser(T c)
        {
            Console.WriteLine("Halo " + c);
        }
    }
    public class DataGeneric<T>
    {
        private T berkas;
        public DataGeneric(T berkas)
        {
            this.berkas = berkas;
        }
        public void CetakData()
        {
            Console.WriteLine("data tersimpan: " + this.berkas);
        }
    }
}
