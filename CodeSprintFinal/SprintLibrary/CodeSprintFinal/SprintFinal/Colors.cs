using System;
using static System.Console;
using SprintLibrary;

namespace SprintFinal
{
	public class Colors
	{
		public Colors()
		{
		}

        string[] colors =
        {
            "Red",
            "Orange",
            "Yellow",
            "Green",
            "Cyan",
            "Blue",
            "Violet"
        };

        string[] descriptions = {
            "A color with a frequency between 400-480 terahertz.",
            "A color with a frequency between 480-510 terahertz",
            "A color with a frequency between 510-530 terahertz",
            "A color with a frequency between 530-600 terahertz",
            "A color with a frequency between 600-620 terahertz",
            "A color with a frequency between 620-670 terahertz",
            "A color with a frequency between 670-790 terahertz"
        };

        public void Start()
		{
			ChooseColor();
		}

		public void ChooseColor()
		{
			string choose;

			WriteLine("What color would you like to learn about?\n" +
				"1) Red\n2) Orange\n3) Yellow\n4) Green\n5) Cyan\n6) Blue\n7) Violet");

			choose = ReadLine().ToLower();

			switch (choose)
			{
				case "1":
				case "red":
                    WriteLine("You chose" + colors[1]);
					WriteLine(descriptions[1]);
				    break;
                case "2":
                case "orange":
                    WriteLine("You chose" + colors[2]);
                    WriteLine(descriptions[1]);
                    break;
                case "3":
                case "yellow":
                    WriteLine("You chose" + colors[3]);
                    WriteLine(descriptions[1]);
                    break;
                case "4":
                case "green":
                    WriteLine("You chose" + colors[4]);
                    WriteLine(descriptions[1]);
                    break;
                case "5":
                case "cyan":
                    WriteLine("You chose" + colors[5]);
                    WriteLine(descriptions[1]);
                    break;
                case "6":
                case "blue":
                    WriteLine("You chose" + colors[6]);
                    WriteLine(descriptions[1]);
                    break;
                case "7":
                case "violet":
                    WriteLine("You chose" + colors[7]);
                    WriteLine(descriptions[1]);
                    break;
            }

            ReadLine();
		}
	}
}

