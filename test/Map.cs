using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace test
{
    public class SaveLoadJson
    {    
        static public char[][] ConvertMap(char[,] map)
        {
            int rows = map.GetLength(0);
            int cols = map.GetLength(1);

            char[][] result = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                result[i] = new char[cols];
                for (int j = 0; j < cols; j++)
                {
                    result[i][j] = map[i, j];
                }
            }

            return result;
        }
        static public void SaveData(char[][] map)
        {
            string folderPath = "./GameData";
            string filePath = Path.Combine(folderPath, "data.json");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

           

            string result = JsonSerializer.Serialize(map); //new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, result);

            
        }
    }
    internal class Map
    {
        public char[,] map;
        public int rows;
        public int cols;

        public Map()
        {
            map = new char[,] {
            { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', 'P', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', 'M', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
            };
            rows = map.GetLength(0);
            cols = map.GetLength(1);
        }
     
       
        public (int, int) FindPlayer()
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (map[r, c] == 'P') return (r, c);
                }
            }
            return (1, 1);
        }
        public void SetPlayer(int newR, int newC, Player p)
        {
            map[p.row, p.col] = ' ';
            p.row += newR;
            p.col += newC;
            map[p.row, p.col] = 'P';
        }
        public bool IsWall(int r, int c)
        {
            if (map[r, c] == '#')
            {
                return true;
            }
            return false;
        }
        public bool IsMonster(int r, int c)
        {
            if (map[r, c] == 'M')
            {
                return true;
            }
            return false;
        }
        public void PrintMap()
        {

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(map[r, c]);
                }
                Console.WriteLine();

            }
        }
    }
}

