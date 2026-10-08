using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class DungeonGame
    {
        
        Map gameMap = new Map();
        Player player = new Player();
       
        public DungeonGame(string name, int count)
        {


        }
        public void PlayGame(int stageCount)
        {
         

            for (int i = 0; i < stageCount; i++)
            {
                //Console.WriteLine();
                gameMap.PrintMap();

                var P = gameMap.FindPlayer();
                player.row = P.Item1;
                player.col = P.Item2;

                bool playing = true;
                while (playing)
                {
                    Console.WriteLine($"[상태] {player.PlayerName} | HP: {player.Hp} | Gold: {player.Gold} | Damage {player.Damage} | Exp {player.Exp}");
                    Console.WriteLine("이동명령 w,a,s,d");
                    string cmd = Console.ReadLine();
                    Console.Clear();

                  


                    int dirR = 0;
                    int dirC = 0;


                    switch (cmd)
                    {
                        case "a":
                            dirC = -1;
                            
                            break;

                        case "d":
                            dirC = 1;
                            break;

                        case "w":
                            dirR = -1;
                            break;

                        case "s":
                            dirR = 1;
                            break;
                    }
                 
                    if (gameMap.IsWall(player.row + dirR, player.col + dirC))
                    {
                        Console.WriteLine("이동 못함");

                    }

                    else if (gameMap.map[player.row + dirR, player.col + dirC] == 'M')
                    {
                        Console.WriteLine("게임종료");
                        return;
                    }
                    else
                    {
                        gameMap.SetPlayer(dirR, dirC, player);
                       
                    }

                    gameMap.PrintMap();
                }
            }
        }
    }
}
