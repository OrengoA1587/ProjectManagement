using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatamanLibrary
{
    public class Player
    {
        #region Player Class
        //Fields
        private string _name;
        private int _score;
        private int _counter;

        //Default constructors
        public Player()
        {
            Name = "";
            Score = 0;
            Counter = 0;
        }
        //Custom Constructors
        public Player(string name, int score,int counter)
        {
            Name = name;
            Score = score;
            Counter = counter;
        }
        //Properties
        public string Name
        {
            get { return _name; } set { _name = value; }             
        }
        public int Score
        {
            get { return _score; } set { _score = value; }
        }
        public int Counter
        {
            get { return _counter; }
            set { _counter = value; }
        }
        #endregion End Player Class
    }
}
