using System;

namespace TallerPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program objPro = new Program();
            int option;
            do
            {
                Console.WriteLine(objPro.MainMenu());
                option = Convert.ToInt32(Console.ReadLine());
            } while(option!=0);
        }

        public void Buy()
        {

        }
        public string MainMenu()
        {

            return "Select an option:"+
                "\n1. Buy a motorized vehicle"+
                "\n2. Buy an aerial vehicle"+
                "\n3. Buy a cargo aerial vehicle"+
                "\n4. Buy a human-powered vehicle"+
                "\n5. Buy a military aerial vehicle"+
                "\n6. Buy a used motorized vehicle"+
                "\n0. Exit";
        }
    }
}
