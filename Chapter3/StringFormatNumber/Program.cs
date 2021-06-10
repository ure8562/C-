using static System.Console;
using System;

namespace StringFormatNumber
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // D : 10진수
            WriteLine("10진수: {0:D}", 123);      //WriteLine(string.Format("10wlstn:{0:D}",123)); 동일
            WriteLine("10진수: {0:D5}", 123);

            // X : 16진수
            WriteLine("16진수: 0x{0:X}", 0XFF1234);
            WriteLine("16진수: 0x{0:X8}", 0XFF1234);

            // N : 숫자
            WriteLine("숫자: {0:N}", 123456789);
            WriteLine("숫자: {0:N0}", 123456789.123); // 0은 소숫점이하 자리수 제거

            // F : 고정소수점
            WriteLine("고정소수점: {0:F}", 123.45);
            WriteLine("고정소수점: {0:F5}", 123.456);

            // E : 공학용
            WriteLine("공학: {0:E}", 123.456789);


        }
    }
}