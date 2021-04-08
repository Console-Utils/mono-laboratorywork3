using System;
using System.Linq;
using System.Globalization;
using LaboratoryWork.Utils;
using LaboratoryWork.Extensions;

namespace LaboratoryWork
{
  internal static class MainClass
  {
    private static void Main()
    {
      double[] z = LaboratoryWork.Utils.Array.ReadDouble(LaboratoryWork.Utils.Base.ReadInt32("Please enter z array length value: "), "Please enter z[{0}] value: ").PrintLine(", ").ToArray();
      
      Console.WriteLine("Positive number count == {0}", z.Where(x => x > 0).Count());
      Console.WriteLine("In [-7, 5.2] range number count == {0}", z.Where(x => x >= -7 && x <= 5.2).Count());
      double[] p = z.Where(x => x < 0).PrintLine(", ").ToArray();
    }
  }
}
