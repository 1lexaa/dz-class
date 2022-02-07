using System;
namespace project {
    partial class MotoBike 
    {
        public void GetTitle()
        {
            Console.WriteLine(mark + " " + model + " with " + Convert.ToString(horsePower) + "hp and "
            + Convert.ToString(nm) + "nm ");
        }
    }
}


