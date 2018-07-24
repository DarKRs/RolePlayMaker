using System;

namespace RolePlay_Maker.Utilities
{
    class Roll
    {
        //right bound(.Next(1, _5_)) is increased by 1 because
        //the MaxValue isn't included in range
        static public int D4()
        {
            return new Random().Next(1, 5);
        }
        static public int D5()
        {
            return new Random().Next(1, 6);
        }
        static public int D6()
        {
            return new Random().Next(1, 7);
        }
        static public int D7()
        {
            return new Random().Next(1, 8);
        }
        static public int D8()
        {
            return new Random().Next(1, 9);
        }
        static public int D10()
        {
            return new Random().Next(1, 10);
        }
    }
}