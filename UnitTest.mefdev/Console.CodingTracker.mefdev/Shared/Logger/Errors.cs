﻿namespace CodingLogger.Shared.Logger
{
    public class ErrorsLogger
    {
        public ErrorsLogger()
        {
        }
        public void DisplayError(string message)
        {
            Console.Error.WriteLine(message);
        }

    }
}

