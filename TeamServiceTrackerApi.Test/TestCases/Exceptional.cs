using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TeamServiceTrackerApi.Test.TestCases
{
   public class Exceptional
    {
        static Exceptional()
        {
            if (!File.Exists("../../../../output_boundary_revised.txt"))
                try
                {
                    File.Create("../../../../output_boundary_revised.txt").Dispose();
                }
                catch (Exception)
                {

                }
            else
            {
                File.Delete("../../../../output_boundary_revised.txt");
                File.Create("../../../../output_boundary_revised.txt").Dispose();
            }
        }
    }
}
