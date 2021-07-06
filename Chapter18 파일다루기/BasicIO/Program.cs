using System;
using System.IO;

namespace BasicIO
{
    class Program
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            Console.WriteLine("{0,-1} : 0X{1:X16}", "Original Data", someValue);

            Stream outStream = new FileStream("a.dat", FileMode.Create);
            byte[] wByte = BitConverter.GetBytes(someValue);

            Console.Write("{0,-13} : ", "Byte array");

            foreach (byte b in wByte)
                Console.Write("{0:X2} ", b);
            Console.WriteLine();

            outStream.Write(wByte, 0, wByte.Length);
            outStream.Close();

            Stream inStream = new FileStream("a.dat", FileMode.Open);
            byte[] rbyte = new byte[8];

            int i = 0;
            while (inStream.Position < inStream.Length)
                rbyte[i++] = (byte)inStream.ReadByte();

            long readValue = BitConverter.ToInt64(rbyte, 0);
            Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);
            inStream.Close();
        }
    }
}
