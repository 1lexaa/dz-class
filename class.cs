using System;

namespace project
{
    partial class MotoBike
    {

        // кол-во колес , марка , модель , скорость 
        private static int countWheels;
        private static string material;
        private static bool cooling;
        private static bool starter;
        public int speed = 0;
        public MotoBike() {
            model = "Kawasaki";
            mark = "Ninja";
            horsePower = 800;
            nm = 753.4;
            color = "green";
        }

        public MotoBike(string newmodel, string newmark) {
            model = newmodel;
            mark = newmark;
        }
        public MotoBike(string newmodel, string newmark, int horses, double newnm) {
            model = newmodel;
            mark = newmark;
            horsePower = horses;
            nm = newnm;
        }

        static MotoBike() {
            countWheels = 2;
            material = "plastic";
            cooling = false;
            starter = true;
        }
        
        public int Speed(ref int acc)
        {
            speed += acc;
            return speed;
        }
        public string model { get ; set ; }
        public string mark { get ; set ; }
        public int horsePower { get ; set ; }
        public double nm { get ; set ; }
        public string color { get ; set ; }


    }

    class Program {
        static void Main(string[] args)
        {

            //             MotoBike[]mb;
            // mb = new MotoBike[5];
         Motobike Kawasaki = new Motobike();
                Kawasaki.GetTitle();

        }
    }
}
