﻿using System;

namespace Examples_types
{
    class Program
    {
        static void Main(string[] args)
        {


        // Логический тип
       
            /*-----------------bool-----------------

            Хранит значение true или false (логические литералы). 
            Представлен системным типом System.Boolean
            Размер - 8 бит                        */
            
            bool Alive = true;
            bool IsDead = false;
            




        // Арифметические целочисленные типы
        
            /*-----------------byte-----------------
            
            Хранит целое число от 0 до 255 и занимает 1 байт.
            Представлен системным типом System.Byte
            Беззнаковый, Размер - 8 бит           */
            
            byte bit1 = 1;
            byte bit2 = 102;

            
            /*-----------------sbyte-----------------

            Хранит целое число от -128 до 127 и занимает 1 байт. 
            Представлен системным типом System.SByte
            Знаковый, 8 бит                        */

            sbyte bit_1 = -101;
            sbyte bit_2 = 102;
        

            /*-----------------short-----------------

            Хранит целое число от -32768 до 32767 и занимает 2 байта. 
            Представлен системным типом System.Int16
            Знаковое, 16 Бит                       */

            short n1 = 1;
            short n2 = 102;


            /*-----------------ushort-----------------

            Хранит целое число от 0 до 65535 и занимает 2 байта.
            Представлен системным типом System.UInt16
            Беззнаковое, 16 Бит                     */

            ushort n_1 = 1;
            ushort n_2 = 102;


            /*-----------------int-----------------

            Хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
            Представлен системным типом System.Int32. 
            Все целочисленные литералы по умолчанию представляют значения типа int:
            Знаковое, 32 Бит                     */

            int a = 10;
            int b = 0b101;  // бинарная форма b = 5
            int c = 0xFF;   // шестнадцатеричная форма c = 255
        

            /*-----------------uint-----------------

            Хранит целое число от 0 до 4294967295 и занимает 4 байта.
            Представлен системным типом System.UInt32
            Беззнаковое, 32 Бит                   */

            uint a_1 = 10;
            uint b_1 = 0b101;
            uint c_1 = 0xFF;


            /*-----------------long-----------------

            Хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. 
            Представлен системным типом System.Int64
            Знаковое, 64 Бит                      */

            long a_2 = -10;
            long b_2 = 0b101;
            long c_2 = 0xFF;


            /*-----------------ulong-----------------

            Хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт. 
            Представлен системным типом System.UInt64
            Беззнаковое, 64 Бит                    */

            ulong a_3 = 10;
            ulong b_3 = 0b101;
            ulong c_3 = 0xFF;





            /*-----------------float-----------------

            Хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта.
            Представлен системным типом System.Single
            Точность - 7 цифр                      */


            /*-----------------double-----------------
            
            Хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта. 
            Представлен системным типом System.Double
            Точность -  15-16 цифр                 */


            /*------------------double-------------------

            Хранит десятичное дробное число. 
            Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, 
            может хранить 28 знаков после запятой и занимает 16 байт. 
            Представлен системным типом System.Decimal */





        // Символьные типы

            /*---------------------char---------------------
            
            Хранит одиночный символ в кодировке Unicode и занимает 2 байта. 
            Представлен системным типом System.Char. 
            Этому типу соответствуют символьные литералы:
            16 бит Unicode символ                         */

            char a_4 = 'A';
            char b_4 = '\x5A';
            char c_4 = '\u0420';


            /*--------------------string--------------------
            
            Хранит набор символов Unicode.
            Представлен системным типом System.String.
            Этому типу соответствуют символьные литералы. 
            Строка из символов Unicode                     */

            string hello = "Hello";
            string word = "world";





            /*----------------------------object----------------------------

            Может хранить значение любого типа данных 
            и занимает 4 байта на 32-разрядной платформе 
            и 8 байт на 64-разрядной платформе. 
            Представлен системным типом System.Object, 
            который является базовым для всех других типов и классов .NET. */


            object a_5 = 22;
            object b_5 = 3.14;
            object c_5 = "hello code";


            Console.WriteLine($"{Alive} {IsDead}", bit1 + bit2 + bit_1 + bit_2 + n1 + n2 + n_1 + n_2 + a + b + c);
            Console.WriteLine($"{a_1},{b_1},{c_1},{a_2},{b_2},{c_2}", a_3 + b_3 + c_3 + a_4 + b_4 + c_4 + hello + word);

        }
    }
}
