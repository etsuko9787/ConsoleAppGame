using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGame
{
    internal class Program
    {
        // 登場人物のインスタンス生成
        Goblin g = new Goblin();
        Soilder s = new Soilder();
        Magician m = new Magician();
        Random rdm = new Random();


        static void Main(string[] args)
        {

            Program p= new Program();


            
            // 連想記憶クラスに登場人物の攻撃初期値を格納
            Dictionary<string, int> characters= new Dictionary<string, int>();
            characters["soilder_attack"] = 0;
            characters["goblin_attack"]=0;
            characters["magician_attack"] = 0;

            bool flag = false; // フラグ判定
            
            // オープニング
            Console.WriteLine("ようこそ！");
            Console.WriteLine("キャラクターの名前を入力してください");
            string player_name = Console.ReadLine();
            Console.WriteLine("冒険する仲間の名前を入力してください");
            string team_player_name = Console.ReadLine();
            p.s.Name = player_name;
            p.m.Name = team_player_name;
            

            Console.WriteLine("モンスターが現れた！");

            // 戦闘
            while (flag != true) 
            {
                Console.WriteLine("どうする？\n 1:攻撃　2:逃げる");
                int choice = int.Parse(Console.ReadLine());

                
                // 戦士の攻撃
                switch (choice)
                {
                case 1:
                        characters["soilder_attack"] = p.s.Attack(10 * p.rdm.Next(0, 10));
                    p.g.HealthPoint -= characters["soilder_attack"];
                        //Console.WriteLine("現在のHP"+p.s.HealthPoint);
                    break;
                case 2:
                    Console.WriteLine("{0}は逃げようとした",p.s.Name);
                            Console.WriteLine("しかし{0}にまた捕まった", p.g.Name);
                    break;
                default: 
                    Console.WriteLine("入力値エラーです。もう一度入力してください。");
                    choice= int.Parse(Console.ReadLine());
                    break;
                }

                // 魔法使いの攻撃
                int m_random = p.rdm.Next(0, 2);
                if(m_random == 0)
                {
                    Console.WriteLine("{0}は何もしなかった", p.m.Name);
                }
                else if (m_random == 1)
                {
                    characters["magician_attack"] = p.m.Attack(10 * p.rdm.Next(0, 5));
                    p.g.HealthPoint -= characters["magician_attack"];
                }
                else
                {
                    p.s.HealthPoint += 10;
                    p.m.Healing(10);

                }
                
                
                    // ゴブリンの攻撃
                characters["goblin_attack"] = p.g.Attack(8 * p.rdm.Next(0, 10));
                p.s.HealthPoint -= characters["goblin_attack"];
                p.m.HealthPoint -= characters["goblin_attack"];
                //Console.WriteLine("ゴブリンの体力："+p.g.HealthPoint);
                
                
                if (p.s.HealthPoint < 0 || p.g.HealthPoint < 0 || p.m.HealthPoint < 0)
                {
                    flag = true;
                }
                
            }

            // エンディング
            if (p.s.HealthPoint <0)
            {
                Console.WriteLine("{0}と{1}は{2}に倒された。",p.s.Name,p.m.Name,p.g.Name); 
            }
            else
            {
                Console.WriteLine("{0}と{1}は{2}を倒した！", p.s.Name, p.m.Name,p.g.Name);
            }
            

        }
    }
}
