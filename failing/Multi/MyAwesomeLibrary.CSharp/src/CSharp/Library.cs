using System;
using MyAwesomeLibrary.Core;

namespace MyAwesomeLibrary.CSharp
{
    public static class Lib
    {
        public static string GetMessage(string name) => LibCore.GetMessage(name);
    }
}
