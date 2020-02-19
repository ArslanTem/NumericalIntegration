using System;

namespace Project_4
{
    class WrongIntegralBoundsException : Exception
    {
        public WrongIntegralBoundsException()
        {

        }

        public WrongIntegralBoundsException(string Message) : base(Message)
        {

        }
    }
}
