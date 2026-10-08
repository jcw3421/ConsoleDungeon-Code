using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace test
{

    public class branche_test_class
    {
    
    }
    internal class Program
    {  
        static void Main(string[] args)
        {
            DungeonGame game = new DungeonGame("던전", 5);

            game.PlayGame(5);

        }
        
    }
    
    public class GameData
    {
        [JsonInclude] public string stageName;
        [JsonInclude] public int dungeonCount;
        

        [JsonIgnore] public int count { get; set; }

        public GameData(string name, int count)
        {
            stageName = name;
            dungeonCount = count;
        }
    }
}
