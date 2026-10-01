using Spectre.Console;

namespace CLI_verktøy
{
    public static class Program

    {
        public static void Main(string[] args)
        {
            var selected = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("Select options:")
                    .AddChoices("ls", "cat", "echo", "pwd", "head", "tail", "wc", "touch", "cp", "mv", "rm")
            );
            switch (selected)
            {
                case "ls":
                    FileHandler.LS();
                    break;
                case "cat":
                    FileHandler.CAT();
                    break;
                case "echo":
                    FileHandler.ECHO();
                    break;
                case "pwd":
                    FileHandler.PWD();
                    break;
                case "head":
                    FileHandler.HEAD();
                    break;
                case "tail":
                    FileHandler.TAIL();
                    break;
                case "wc":
                    FileHandler.WC();
                    break;
                case "touch":
                    FileHandler.TOUCH();
                    break;
                case "cp":
                    FileHandler.CP();
                    break;
                case "mv":
                    FileHandler.MV();
                    break;
                case "rm":
                    FileHandler.RM();
                    break;
            }
        }
    }
}