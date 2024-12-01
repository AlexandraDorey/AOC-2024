public static class Helpers
{

    public static long asI(this string input) => long.Parse(input);
    public static double asF(this string input) => double.Parse(input);
    public static DateTime asDt(this string input) => DateTime.Parse(input);

    public static long Dig2I(this char input) => input - '0';

    public static bool isD(this char input) => input >= '0' && input <= '9';
    public static bool isLC(this char input) => input >= 'a' && input <= 'z';
    public static bool isUC(this char input) => input >= 'A' && input <= 'Z';
    public static bool isL(this char input) => input.isLC() || input.isUC();

    public static int CardC2Val(char x)
    {
        switch (x)
        {
            case 'A': return 14;
            case 'K': return 13;
            case 'Q': return 12;
            case 'J': return 11;
            case 'T': return 10;
            case '9': return 9;
            case '8': return 8;
            case '7': return 7;
            case '6': return 6;
            case '5': return 5;
            case '4': return 4;
            case '3': return 3;
            case '2': return 2;
        }
        return 0;
    }
}