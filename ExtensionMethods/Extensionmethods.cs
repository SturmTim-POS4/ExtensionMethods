using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ExtensionMethods
{
    public delegate bool CheckFunctionString(string s);
    public delegate bool CheckFunctionDouble(double d);
    
    public static class Extensionmethods
    {

        public static string FirstAndLast(this string s)
        {
            var characters = s.ToCharArray();
            return  $"{characters[0]} {characters[characters.Length-2]} {characters[characters.Length-1]}";
        }

        public static DateTime Yesterday(this DateTime today) 
            => today.AddDays(-1);
        

        public static int Fact(this int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result = result * i;
            }

            return result;
        }
        
        /*
        public static List<string> UseOnly(this List<string> strings, CheckFunctionString function)
            =>  return strings.Where(x => function(x)).ToList();
        
        
        public static List<double> UseOnly(this List<double> numbers, CheckFunctionDouble function)
            =>  return numbers.Where(x => function(x)).ToList();
        */
        
        public static List<T> UseOnly<T>(this List<T> varList, Func<T,bool> function) 
            => varList.Where(x => function(x)).ToList();
        

        public static List<string> Transform(this List<Person> people, Func<Person,string> function)
        {
            List<string> results = new List<string>();
            people.ForEach(x => results.Add(function(x)));
            return results;
        }

        public static string ToUsefulString(this DateTime date)
        {
            return "seas";
        }
    }
}