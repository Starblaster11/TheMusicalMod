using Terraria;

namespace TheMusicalMod
{
    public static class ChatHandler
    {
        public static void ProcessCommand(string command, string[] args)
        {
            switch (command)
            {
                case "time":
                    TimeCommand(args);

                    break;
            }
        }

        public static void TimeCommand(string[] args)
        {
            int time;

            if (args.Length == 0 || !int.TryParse(args[0], out time))
            {
                Main.NewText("Usage: /time [time]");

                return;
            }

            Main.time = time;
        }
    }
}
