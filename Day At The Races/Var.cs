using Races;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day_At_The_Races
{
    abstract class Var
    {
        public static Greyhound[] dogsArray = new Greyhound[4];
        public static Timer timer1;
        public static IContainer components;
        public static System.Windows.Forms.Label label9;
        public static System.Windows.Forms.Label label10;
        public static System.Windows.Forms.Label label11;
        public static System.Windows.Forms.Label label12;
        public static int zackBet = 0;
        public static int nickBet = 0;
        public static int taylorBet = 0;
        public static bool Bet = false;
        public static string winningDog;
        public static decimal dbOddsAgainst;
        public static decimal Test;





        public static Guy[] guyArray = new Guy[3];
        public static System.Windows.Forms.Label lblZack;
        public static System.Windows.Forms.Label lblNick;
        public static System.Windows.Forms.Label lblTaylor;
        public static NumericUpDown numericUpDown2;
        public static ComboBox comboBox1;
        public static System.Windows.Forms.Label lblOdds;
        public static System.Windows.Forms.Label lblDBOdds;
        public static System.Windows.Forms.Label LROdds;
        public static System.Windows.Forms.Label MOdds;
        public static System.Windows.Forms.Label SSOdds;
        public static Random Randomizer = new Random();
        // Bet Mybet = new Bet();
    }
}
