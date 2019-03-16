using System;

namespace NuGetServer.Service
{
    public class PrematureTerminationException : Exception
    {
        public PrematureTerminationException(string message) : base(message)
        {

        }
    }
}
