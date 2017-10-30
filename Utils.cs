using System;


namespace Utils
{
    /// <summary>
    /// Class for logging things to a log file and to the console
    /// </summary>
    public class Logger
    {
        
        /// <summary>
        /// Print a debug message to the console
        /// </summary>
        /// <param name="Message">
        /// The message that needs sent to the console
        /// </param>
        public void Debug(string Message)
        {
            Debug(Tag: "[DEBUG]", Message: Message);
        }

        /// <summary>
        /// Print a debug message to the console with a custom tag
        /// </summary>
        /// <param name="Tag">
        /// The custom tag to use
        /// </param>
        /// <param name="Message">
        /// The message that needs sent to the console
        /// </param>
        public void Debug(string Tag, string Message)
        {
            // Change the foreground color to denote that this is a debug message
            Console.ForegroundColor = ConsoleColor.Cyan;
            // Write out the message with the tag
            Console.WriteLine("{0}: {1}", tag, message);
            // Reset the foreground color so that all messages after this one have correct
            // formatting
            Console.ForegroundColor = ConsoleColor.White;

            // Write the message to the log file
            LogToFile(Tag, Message);
        }

        /// <summary>
        /// Print an error message to the console
        /// </summary>
        /// <param name="Message">
        /// The message that needs sent to the console
        /// </param>
        public void Error(string Message)
        {
            Error(Tag: "[ERROR]", Message: Message);
        }

        /// <summary>
        /// Print an error message to the console, with a custom tag
        /// </summary>
        /// <param name="Tag">
        /// The tag to use
        /// </param>
        /// <param name="Message">
        /// The message that needs sent to the console
        /// </param>
        public void Error(string Tag, string Message)
        {
            // Change the foreground color to denote that this is an error message
            Console.ForegroundColor = ConsoleColor.Red;
            // Write out the message with the tag
            Console.WriteLine("{0}: {1}", Tag, Message);
            // Reset the foreground color so that all messages after this one have correct
            // formatting
            Console.ForegroundColor = ConsoleColor.White;

            // Write the message to the log file
            LogToFile(Tag, Message);
        }

        /// <summary>
        /// Print an info message to the console
        /// </summary>
        /// <param name="Message">
        /// The message that needs sent to the console
        /// </param>
        public void Info(string Message)
        {
            Info(Tag: "[INFO]", Message: Message);
        }

        /// <summary>
        /// Print an info message to the console, with a custom tag
        /// </summary>
        /// <param name="Tag">
        /// The custom tag to use
        /// </param>
        /// <param name="Message">
        /// The message that needs sent to the console
        /// </param>
        public void Info(string Tag, string Message)
        {
            // Write out the message with the tag
            Console.WriteLine("{0}: {1}", Tag, Message);

            // Write the message to the log file
            LogToFile(Tag, Message);
        }

        /// <summary>
        /// Write a log message to a file
        /// </summary>
        /// <param name="Tag">
        /// The tag to use for the log
        /// </param>
        /// <param name="Message">
        /// The message that needs logged
        /// </param>
        public void LogToFile(string Tag, string Message)
        {
            StreamWriter writer;
            DateTime date = new DateTime();
            string Month = date.Date;
            try
            {
                writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Log_.log", true);
                writer.WriteLine("{0} | {1}: {2}", DateTime.Now.ToString(), Tag, Message);
            } catch (Exception e)
            {
                Error(e.Message());
            }
        }
    }
}
