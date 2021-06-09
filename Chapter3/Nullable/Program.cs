using System;

namespace Nullable
{
    class MainApp
    {
        enum DialogResult { YES = 10, NO, CANCLE, CONFIRM = 50, OK }

        static void Main(string[] args)
        {

            int? a = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
        }
    }
}
