using System;
using static System.Console;
using System.Collections.Generic;

namespace PokemonASCIIArt
{
    class Class1
    {
        static void Main(string[] args)
        {
            Pokemon BULBASAUR = new Pokemon("BULBASAUR", "", @"
                                           /
                        _,.------....___,.' ',.-.
                     ,-'          _,.--""        |
                   ,'         _.-'              .
                  /   ,     ,'                   `
                 .   /     /                     ``.
                 |  |     .                       \.\
       ____      |___._.  |       __               \ `.
     .'    `---""""       ``""-.--""'`  \               .  \
    .  ,            __               `              |   .
    `,'         ,-""'  .               \             |    L
   ,'          '    _.'                -._          /    |
  ,`-.    ,"".   `--'                      >.      ,'     |
 . .'\'   `-'       __    ,  ,-.         /  `.__.-      ,'
 ||:, .           ,'  ;  /  / \ `        `.    .      .'/
 j|:D  \          `--'  ' ,'_  . .         `.__, \   , /
/ L:_  |                 .  ""' :_;                `.'.'
.    """"'                  """"""""""'                    
 `.                                 .    `.   _,..  `
   `,_   .    .                _,-'/    .. `,'   __  `
    ) \`._        ___....----""'  ,'   .'  \ |   '  \  .
   /   `. ""`-.--""'         _,' ,'     `---' |    `./  |
  .   _  `""""'--.._____..--""   ,             '         |
  | ."" `. `-.                /-.           /          ,
  | `._.'    `,_            ;  /         ,'          .
 .'          /| `-.        . ,'         ,           ,
 '-.__ __ _,','    '`-..___;-...__   ,.'\ ____.___.'
 `""^--'..'   '-`-^-'""--    `-^-'`.''""""""""""`.,^.`.--
");
            Pokemon CHARMANDER = new Pokemon("CHARMANDER", "", @"

              _.--""""`-..
            ,'          `.
          ,'          __  `.
         /|          "" __   \
        , |           / |.   .
        |,'          !_.'|   |
      ,'             '   |   |
     /              |`--'|   |
    |                `---'   |
     .   ,                   |                       ,"".
      ._     '           _'  |                    , ' \ `
  `.. `.`-...___,...---""""    |       __,.        ,`""   L,|
  |, `- .`._        _,-,.'   .  __.-'-. /        .   ,    \
-:..     `. `-..--_.,.<       `""      / `.        `-/ |   .
  `,         """"""""'     `.              ,'         |   |  ',,
    `.      '            '            /          '    |'. |/
      `.   |              \       _,-'           |       ''
        `._'               \   '""\                .      |
           |                '     \                `._  ,'
           |                 '     \                 .'|
           |                 .      \                | |
           |                 |       L              ,' |
           `                 |       |             /   '
            \                |       |           ,'   /
          ,' \               |  _.._ ,-..___,..-'    ,'
         /     .             .      `!             ,j'
        /       `.          /        .           .'/
       .          `.       /         |        _.'.'
        `.          7`'---'          |------""'_.'
       _,.`,_     _'                ,''-----""'
   _,-_    '       `.     .'      ,\
   -"" /`.         _,'     | _  _  _.|
    """"--'---""""""""""'        `' '! |! /
                            `"" "" -' 
");
            Pokemon SQUIRTLE = new Pokemon("SQUIRTLE", "", @"
               _,........__
            ,-'            ""`-.
          ,'                   `-.
        ,'                        \
      ,'                           .
      .'\               ,"""".       `
     ._.'|             / |  `       \
     |   |            `-.'  ||       `.
     |   |            '-._,'||       | \
     .`.,'             `..,'.'       , |`-.
     l                       .'`.  _/  |   `.
     `-.._'-   ,          _ _'   -"" \  .     `
`.""""""""""'-.`-...,---------','         `. `....__.
.'        `""-..___      __,'\          \  \     \
\_ .          |   `""""""""'    `.           . \     \
  `.          |              `.          |  .     L
    `.        |`--...________.'.        j   |     |
      `._    .'      |          `.     .|   ,     |
         `--,\       .            `7""""' |  ,      |
            ` `      `            /     |  |      |    _,-'""""""`-.
             \ `.     .          /      |  '      |  ,'          `.
              \  v.__  .        '       .   \    /| /              \
               \/    `""""\""""""""""""""`.       \   \  /.''       |
                `        .        `._ ___,j.  `/ .-       ,---.     |
                ,`-.      \         .""     `.  |/        j     `    |
               /    `.     \       /         \ /         |     /    j
              |       `-.   7-.._ .          |""          '         /
              |          `./_    `|          |            .     _,'
              `.           / `----|          |-............`---'
                \          \      |          |
               ,'           )     `.         |
                7____,,..--'      /          |
                                  `---.__,--.'
");
            WriteLine("\nWhich starter pokemon will you use?:");

            ConsoleMenu menu = new ConsoleMenu();

            menu.DisplayMenu("BULBASAUR", "CHARMANDER", "SQUIRTLE", "???");

            menu.Prompt();

            if (menu._choice.Equals("???")) { menu._choice = "BING CHILLING"; }

            WriteLine("Congratulations on getting your starter " + menu._choice + ". Would you like to name it? (Y/N)");


            if (menu.YesOrNo())
            {
                Write("\n>");
                menu._choice = ReadLine();
                WriteLine("\nYour pokemon's name is now " + menu._choice);
            }
            else
            {
                WriteLine();
            }
        }
    }
    public class ConsoleMenu
    {
        /* The ConsoleMenu object takes in options and gives out an interactable menu.*/
        private Dictionary<int, String> _options = new Dictionary<int, string>();

        public string _choice { get; set; }//dunno if it right to do this lol

        private void AddOptions(params string[] options)
        {
            for (int i = 0; i < options.Length; i++)
                _options.Add((i + 1), options[i]);
        }

        public void Prompt(string promptMessage)
        {
            WriteLine(promptMessage);
            string optionChosen;
            do
            {
                optionChosen = ReadKey(true).KeyChar.ToString();
            } while (!_options.ContainsKey(int.Parse(optionChosen)));
            _choice = _options[int.Parse(optionChosen)];
        }
        public bool YesOrNo()
        {
            string answer;
            do
            {
                answer = ReadKey(true).KeyChar.ToString();
                answer = answer.ToLower();
            } while (!answer.Equals("y") && !answer.Equals("n"));//if it's not y or n
            return answer.Equals("y");
        }
        public void Prompt()
        {
            WriteLine();
            string optionChosen;
            do
            {
                optionChosen = ReadKey(true).KeyChar.ToString();
            } while (!_options.ContainsKey(int.Parse(optionChosen)));
            _choice = _options[int.Parse(optionChosen)];
        }

        public void DisplayMenu(params string[] Options)
        {
            AddOptions(Options);
            WriteLine();
            WriteLine("||===========================================||");
            WriteLine("||                                           ||");
            for (int i = 0; i < Options.Length; i++)
            {
                Write("||                {0}-{1}", (i + 1), Options[i]);
                for (int j = 0; j < 25 - Options[i].Length; j++)
                {
                    Write(" ");
                }
                WriteLine("||");
            }
            WriteLine("||                                           ||");
            WriteLine("||===========================================||");
            WriteLine();
        }
    }
    /* The pokemon class is used to make a new pokemon. A pokemon can evolve, be displayed, it may eventually fight (?) probably not lol.
     * Pokemon can have a nickname, name, description, and a type. */
    public class Pokemon // essentially a singly linked list 
    {
        private string nickname { get; set; }

        private string name { get; }

        private Pokemon nextEvolution { get; }


        private string sprite;//use string literal for this

        public Pokemon(string name, string nickname, string sprite)
        {
            this.name = name;
            this.sprite = sprite;
            this.nickname = nickname;
        }

        public Pokemon(string name, string nickname, Pokemon nextEvolution)
        {
            this.name = name;
            this.nextEvolution = nextEvolution;
        }
    }

    /* I don't know when to use access modifiers for example:
     * I want a pokemon to evolve and the player can choose this. But should it be public? A lot of confusion here.
     * 
     * Goal: make evolution text no ascii art yet
     * 
     * UX: suddenly out of nowhere the pokemon evolves. That is to say the pokemon is displayed with text being displayed at the bottom of the screen
     * Saying that it is evolving: ... What's this? POKEMON_NAME is evolving! *CLEAR* (SHOWS POKEMON) *MUSIC PLAYS* POKEMONE CHANGES
     * *CLEAR* WOW UR BLAH BLAH HAS EVOLVED INTO A BLAH BLEH. WOULD YOU LIKE TO N-. *CLEAR* !? WHAT'S THIS POKEMON IS EVOLVING AGAIN DF. 
     * REPEAT 
     * 
     * for the ??? there will be stupid jokes in the next evolution 
     * 
     * DATA BEING CHANGED: pokemon name and avatar 
     * 
     * Ok so when we have the name of the pokemon we will get the pokemon that it correpsonds to and then 
     * There will be a dictionary that links all the pokemon with their next evolution. So string to strings or if null then it's hte last 
     */
    //todo

}
