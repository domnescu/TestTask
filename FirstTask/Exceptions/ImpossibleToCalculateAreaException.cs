using System;

namespace TestTask.Exceptions
{
    class ImpossibleToCalculateAreaException : Exception
    {
        public ImpossibleToCalculateAreaException(string message) : base(message)
        {

        }
    }
}
