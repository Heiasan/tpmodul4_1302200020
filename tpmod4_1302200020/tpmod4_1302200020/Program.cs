using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric<string> halo = new HaloGeneric<string>();
            String x = " Abdillah Hasan";
            halo.SapaUser(x);
            DataGeneric<String> data = new DataGeneric<string>("1302200020");
            data.PrintData();
        }
    }
    public class HaloGeneric<T>
    {
        public void SapaUser(T x)
        {
            Console.WriteLine("halo" + x);
        }
    }
    public class DataGeneric<T>
    {
        private T data;
        public DataGeneric(T data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("data yang tersimpan adalah: " + this.data);
        }
    }
}