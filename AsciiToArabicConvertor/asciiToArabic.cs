using System;
using System.Reflection;

namespace AsciiToArabicConverter
{
    class asciiToArabic
    {
        public static void Converter()
        {
            Console.Write("أدخل رموز ASCII (مفصولة بمسافة): ");
            string asciiInput = Console.ReadLine();

            // تحويل الرموز ASCII إلى مصفوفة من الأعداد
            string[] asciiValues = asciiInput.Split(' ');
            string arabicText = "";

            foreach (string value in asciiValues)
            {
                try
                {
                    // تحويل كل قيمة إلى حرف عربي
                    int asciiValue = int.Parse(value);
                    char arabicChar = (char)asciiValue;
                    arabicText += arabicChar;
                }
                catch (Exception)
                {
                    // تجاهل القيم غير الصحيحة
                }
            }

            Console.WriteLine("النص العربي:");
            Console.WriteLine(arabicText);
            //اعادة تشغيل البرنامج
            Program.Main();
        }
    }
}
