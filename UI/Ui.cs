using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    class Ui
    {



    }
    public class Player
    {
        public String DisplayPlayer(/*gameLocation, playerobject*/)
        {
            //displays the player on the screen in the given location
            return "Player";
        }
        public String DisplayHS(int HighScore, int Score)
        {
            String HS = "" + HighScore;

            return HS;
        }
        public String DisplayTrivia(bool display, String TriviaQs)
        {
            if (display)
            {
                return TriviaQs;
            }
            return null;
        }
        public String DisplayWumpus(int[][] WumpusLocation, int[][] location, String Wumpus)
        {
            if (Math.Sqrt(location[0][0] * location[0][0] + WumpusLocation[0][0] * WumpusLocation[0][0]) < 2)
            {
                return Wumpus;
            }
            return null;
        }
    }


}
