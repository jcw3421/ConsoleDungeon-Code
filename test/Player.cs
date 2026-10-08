using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Player : Character
    {
        public string PlayerName { get; set; }
        public int Damage { get; set; }
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Gold { get; set; }
        public int Hp { get; set; }
        public Player(string name = "정창우", int damage = 10, int level = 1, int exp = 5, int gold = 10, int hp = 100)
        {
            PlayerName = name;
            Damage = damage;
            Level = level;
            Exp = exp;
            Gold = gold;
            Hp = hp;
            Console.WriteLine($"[데이터 로드] {PlayerName}님(Lv.{Level}) 환영합니다!");
        }
    }
     
}
