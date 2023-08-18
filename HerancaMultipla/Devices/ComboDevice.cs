using System;

namespace HerancaMultipla.Devices
{
    internal class ComboDevice : Device, IPrinter, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("ComboDevice Print: " + document);
        }

        public string Scan()
        {
            return "ComboDevice Scanner result";
        }
    }
}
