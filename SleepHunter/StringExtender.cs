﻿using System.Text;

namespace SleepHunter
{
    public static class StringExtender
   {
      public static string StripNumbers(this string text)
      {
         if (text == null)
            return null;

         var sb = new StringBuilder(text.Length);

         foreach (var c in text)
         {
            if (char.IsDigit(c) || char.IsNumber(c))
               continue;

            sb.Append(c);
         }

         return sb.ToString();
      }
   }
}
