using System;

namespace Enum
{
    class MainApp
    {
        enum DialogResult { YES, NO, CANCLE, CONFIRM, OK }

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCLE);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}
