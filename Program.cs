using System;

namespace firstDemo
{
    class Mobile
    {
        int RAM;
        string motherboard;
        string speaker;

        public void mobileBoot() //Encapsulation..Wrapper of private variable inside the function
        {
            RAM = 2;
            motherboard = "Initialised";
            speaker = "Initialisd";
        }
    

    }

class user
{
    public static void Main()
    {
        Mobile samsung = new Mobile();
        samsung.mobileBoot(); //Abstraction..  operational part of the application like (volume +-, Reset, power)
    }

}
}