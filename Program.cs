using System;
using Bechmark.classes;
using BenchmarkDotNet.Running;

namespace Bechmark
{
    class Program
    {
        static void Main(string[] args)
        {
             var summary = BenchmarkRunner.Run<BechmarkTest>();
        }
    }
}
