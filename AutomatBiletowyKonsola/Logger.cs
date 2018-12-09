using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMachineConsole
{
    public sealed class Logger
    {
        private static readonly Logger _Instance = new Logger();
        private const string LogPath = "Log.log";

        static Logger()
        {
            if (!File.Exists(LogPath))
            {
                File.Create(Path.Combine(Environment.CurrentDirectory, LogPath));
            }
        }
        public static Logger Instance
        {
            get
            {
                return _Instance;
            }
        }

        private void AppendLog(string text)
        {
            using (var streamWriter = new StreamWriter(LogPath, append: true))
            {
                streamWriter.WriteLine(text);
            }
        }

        public void LogTicket(Ticket ticket)
        {
            AppendLog(ticket.LoggingMessage);
        }
    }
}
