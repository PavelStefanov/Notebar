﻿using CommandLine;

namespace NoteBar.App
{
    public class Options
    {
        [Option('p', "port", HelpText = "Port number", Default = 1738u)]
        public uint Port { get; set; }
    }
}
