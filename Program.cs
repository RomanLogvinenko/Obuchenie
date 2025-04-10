
using System.Xml.Serialization;
using System;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.InteropServices;

namespace Solutions
{
    class SSS{

         static public bool IsPalindrome(){
            string s = Console.ReadLine();
             s = s.ToLower();
            char[] sChar = s.ToCharArray();
            List<char> chars = new List<char>();
            for(int i =0;i<s.Length;i++){
                if(Convert.ToString(sChar[i])==" "){
                    
                }
                else{
                    chars.Add(sChar[i]);
                    System.Console.WriteLine(Convert.ToString(chars));
                }
            }
            s=chars.ToString();
            System.Console.WriteLine(s);
          
            return s==s.Reverse();
        }

        public static int RomanToInt(){

           string s = Console.ReadLine(); 
           char[] sChar = s.ToCharArray();
           int SOL = 0;
           var Roman = new Dictionary<string, int>(){
                {"I", 1},
                {"IV", 4},
                {"V", 5},
                {"IX", 9},
                {"X", 10},
                {"XL", 40},
                {"L", 50},
                {"XC", 90},
                {"C", 100},
                {"CD", 400},
                {"D", 500},
                {"CM", 900},
                {"M", 1000}
           };
           for (int i = 0;s.Length>i;){
                try
                { if(Roman.ContainsKey(Convert.ToString(sChar[i])+Convert.ToString(sChar[i+1]))){  //Если два ключа две цифры такие как IV или IX есть в словаре то он записывает их сочетание
                    SOL = SOL + Roman[Convert.ToString(sChar[i])+Convert.ToString(sChar[i+1])];//Название словаря [конвертацияДоСтроки(МассивСимволов[Индекссимвола])+аналагичная хуета просто индекс +1 тип соседний]
                    //System.Console.WriteLine(SOL); //Проемжуточный вывод для проверочки
                    i+=2;
                }
                else{
                    SOL = SOL + Roman[Convert.ToString(sChar[i])]; // если их нет, то просто одиночное число конвертирует 
                    //System.Console.WriteLine(SOL); //Проемжуточный вывод для проверочки
                    i++;
                }
                }
                catch {
                     SOL = SOL + Roman[Convert.ToString(sChar[i])];
                    //System.Console.WriteLine(SOL); //Проемжуточный вывод для проверочки
                    i++;
                }
           }
           System.Console.WriteLine(SOL);
            return SOL;
        }



        static void Main(string[] args){
            //RomanToInt();
            IsPalindrome();
        }
    }
}