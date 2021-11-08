using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsGenerator
{
    public class TestCreator
    {
        static public Task<List<TestStructure>> Generate(string content)
        {
            return Task.Run(() =>
            {
                List<TestStructure> tests = new List<TestStructure>();

                return tests;
            });
        }
    }
}
