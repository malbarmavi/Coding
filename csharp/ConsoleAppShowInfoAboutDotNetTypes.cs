using System;
using static System.Console;
namespace DotNetTypes
{
  class Program
  {
    static void Main(string[] args)
    {

      ForegroundColor = ConsoleColor.Yellow;
      WriteLine($" {"short"}\n max :{short.MaxValue}  min :{short.MinValue} \n {typeof(short)}  size :  {sizeof(short)} byte\n");
      WriteLine($" {"ushort"}\n max :{ushort.MaxValue}  min :{ushort.MinValue} \n {typeof(ushort)}  size :  {sizeof(ushort)} byte\n");
      WriteLine("------------------------------------");
      ForegroundColor = ConsoleColor.White;
      WriteLine($" {"int"}\n max :{int.MaxValue }  min :{int.MinValue} \n {typeof(int)}    size : {sizeof(int)} byte\n");
      WriteLine($" {"uint"}\n max :{uint.MaxValue}  min :{uint.MinValue} \n {typeof(uint)}  size :  {sizeof(uint)} byte\n");
      WriteLine("------------------------------------");
      ForegroundColor = ConsoleColor.Green;
      WriteLine($" {"long"}\n max :{long.MaxValue}  min :{long.MinValue} \n {typeof(long)}  size :  {sizeof(long)} byte\n");
      WriteLine($" {"ulong"}\n max :{ulong.MaxValue}  min :{ulong.MinValue} \n {typeof(ulong)}  size :  {sizeof(ulong)} byte\n");
      WriteLine("------------------------------------");
      ForegroundColor = ConsoleColor.Cyan;
      WriteLine($" {"float"}\n max :{float.MaxValue}  min :{float.MinValue} \n {typeof(float)}  size :  {sizeof(float)} byte\n");
      WriteLine($" {"decimal"}\n max :{decimal.MaxValue}  min :{decimal.MinValue} \n {typeof(decimal)}  size :  {sizeof(decimal):2} byte\n");
      WriteLine($" {"double"}\n max :{double.MaxValue}  min :{double.MinValue} \n {typeof(double)}  size :  {sizeof(double):2} byte\n");
      WriteLine("------------------------------------");
      ForegroundColor = ConsoleColor.White;
      WriteLine($" {"byte"}\n max :{byte.MaxValue}  min :{byte.MinValue} \n {typeof(byte)}  size :  {sizeof(byte)} byte\n");
      WriteLine($" {"sbyte"}\n max :{sbyte.MaxValue}  min :{sbyte.MinValue} \n {typeof(sbyte)}  size :  {sizeof(sbyte)} byte\n");

      WriteLine("------------------------------------");
      ForegroundColor = ConsoleColor.Red;
      WriteLine($" {"char"}\n max :{char.MaxValue}  min :{char.MinValue} \n {typeof(char)}  size :  {sizeof(char)} byte\n");

      WriteLine("------------------------------------");
      ForegroundColor = ConsoleColor.Magenta;
      WriteLine($" {"boolean"}\n max :{true}  min :{false} \n {typeof(bool)}  size :  {sizeof(bool)} byte\n");

      ReadKey();
    }
  }
}
