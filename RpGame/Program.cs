using RpGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace RpGame
{
    public class Menu
    {

        public void GrandMenu()
        {

            /*
            SoundPlayer mainsound = new SoundPlayer("5l.wav");  //music player import
            mainsound.PlayLooping();    //playing music with loop
            */
            Console.ForegroundColor = ConsoleColor.DarkRed;  //Menu
            Console.WriteLine(@"██╗███╗   ██╗███████╗     █████╗ ██████╗ ███████╗███╗   ██╗ █████╗ 
██║████╗  ██║██╔════╝    ██╔══██╗██╔══██╗██╔════╝████╗  ██║██╔══██╗
██║██╔██╗ ██║█████╗      ███████║██████╔╝█████╗  ██╔██╗ ██║███████║
██║██║╚██╗██║██╔══╝      ██╔══██║██╔══██╗██╔══╝  ██║╚██╗██║██╔══██║
██║██║ ╚████║██║         ██║  ██║██║  ██║███████╗██║ ╚████║██║  ██║
╚═╝╚═╝  ╚═══╝╚═╝         ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝╚═╝  ╚═╝
                                                                   ");
            Console.ResetColor();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine();
            }                           //empty space

            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("(1)Новая игра");
            Console.BackgroundColor = ConsoleColor.DarkGray;        //GUI
            Console.WriteLine("(0)Выход");

            Console.WriteLine("");
            Console.ResetColor();

        }
    }
    public class Warrior    
    {
        public void Fighter_Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
 █     █░ ▄▄▄       ██▀███   ██▀███   ██▓ ▒█████   ██▀███    ██████ 
▓█░ █ ░█░▒████▄    ▓██ ▒ ██▒▓██ ▒ ██▒▓██▒▒██▒  ██▒▓██ ▒ ██▒▒██    ▒ 
▒█░ █ ░█ ▒██  ▀█▄  ▓██ ░▄█ ▒▓██ ░▄█ ▒▒██▒▒██░  ██▒▓██ ░▄█ ▒░ ▓██▄   
░█░ █ ░█ ░██▄▄▄▄██ ▒██▀▀█▄  ▒██▀▀█▄  ░██░▒██   ██░▒██▀▀█▄    ▒   ██▒
░░██▒██▓  ▓█   ▓██▒░██▓ ▒██▒░██▓ ▒██▒░██░░ ████▓▒░░██▓ ▒██▒▒██████▒▒
░ ▓░▒ ▒   ▒▒   ▓▒█░░ ▒▓ ░▒▓░░ ▒▓ ░▒▓░░▓  ░ ▒░▒░▒░ ░ ▒▓ ░▒▓░▒ ▒▓▒ ▒ ░
  ▒ ░ ░    ▒   ▒▒ ░  ░▒ ░ ▒░  ░▒ ░ ▒░ ▒ ░  ░ ▒ ▒░   ░▒ ░ ▒░░ ░▒  ░ ░
  ░   ░    ░   ▒     ░░   ░   ░░   ░  ▒ ░░ ░ ░ ▒    ░░   ░ ░  ░  ░  
    ░          ░  ░   ░        ░      ░      ░ ░     ░           ░  
                                                                    
");
            Console.ResetColor();                       //player class select gui
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine();
            }

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(1)Танк");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("(2)Лучник");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("(3)Берсерк");
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("(4)Маг");
            Console.ResetColor();

            choose_warrior();

        }

        public void choose_warrior()
        {
            int choice = Int32.Parse(Console.ReadLine());

            Random rn = new Random();

            int hp = 0;
            int shield = 0;
            int dg = 0;
            int res = 0;
            int money = 0;
            switch (choice)  //player class selector               
            {                                               // class stats
                case 1: //TANK

                    hp = 70;
                    shield = 100;
                    dg = rn.Next(5, 20);
                    res = 95;
                    Console.Clear();
                    battle(hp, shield, dg, res, money);
                    break;
                case 2: //bowman
                    hp = 100;
                    shield = 40;
                    dg = rn.Next(10, 30);
                    res = 50;
                    Console.Clear();
                    battle(hp, shield, dg, res, money);
                    break;
                case 3: //berserker
                    hp = 36;
                    shield = 10;
                    dg = rn.Next(50, 100);
                    res = 95;
                    Console.Clear();
                    battle(hp, shield, dg, res, money);
                    break;
                case 4: //wizard
                    hp = 100;
                    shield = 60;
                    dg = rn.Next(50, 60);
                    res = 95;
                    Console.Clear();
                    battle(hp, shield, dg, res, money);
                    break;
            }
        }
        public void battle(int hp, int shield, int dg, int res, int money)  //battlefield
        {


            Random rand = new Random();
            var mobs = new string[] { "Шизик какой-то", "Слизень", "Боб", "Боблин", "Трава", "Дерево", "Крапива" }; //random mob array
            string mobname = mobs[rand.Next(0, 7)];


            int mob_hp = 0; // mob stats generator
            int mob_dmg = 0;
            int randomboss = rand.Next(1, 15);  //random chance to get a boss

            bool lastboss;           //if lastmob was a boss checker

            if (randomboss >= 12)   //random boss generator
            {
                mob_hp = rand.Next(150,400);    
                mob_dmg = rand.Next(30, 70); 
                lastboss = true;                //if last enemy not a boss we set this random bigger statistics

            }
            else    
            {
                mob_hp = rand.Next(50, 100);    //if we already have boss in last fight we set usual statistics
                mob_dmg = rand.Next(15, 35);
                lastboss = false;
            }


            acting(hp, shield, dg, res, mobname, mob_hp, mob_dmg, money, lastboss); //return to our turn

        }

        void mobact(int hp, int dg, string mobname, int mob_hp, int mob_dmgs, int shield, int res, int money, bool lastboss)    //enemy turn 
        {
            Random mact = new Random();
            int ran = mact.Next(1, 4);  //random move generator
            switch (ran)
            {
                case 1:  //enemy attacking
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    int mdmg = hp - mob_dmgs;
                    hp = hp - mob_dmgs;
                    Console.WriteLine("Противник нанёс вам " + mob_dmgs + ", осталось " + mdmg + " хп");
                    Console.ResetColor();
                    Console.ReadLine();
                    acting(hp, shield, dg, res, mobname, mob_hp, mob_dmgs, money, lastboss);
                    break;
                case 2:
                    int regen = mact.Next(5, 15);    //regenerating
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(mobname + " зализывает раны");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(mobname + " регенерировал + " + regen + " хп");
                    mob_hp = mob_hp + regen;
                    Console.ResetColor();
                    Console.ReadLine();
                    acting(hp, shield, dg, res, mobname, mob_hp, mob_dmgs, money, lastboss);
                    break;
                case 3: //do nothing
                    Console.Clear();
                    Console.WriteLine("Противник смотрит на небо...");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Противник пропустил ход...");
                    Console.ResetColor();
                    Console.ReadLine();
                    acting(hp, shield, dg, res, mobname, mob_hp, mob_dmgs, money, lastboss);
                    break;
            }
        }

        void reward(int hp, int shield, int dg, int res, string mobname, int mob_hp, int mob_dmgs,int money, bool lastboss) //reward screen
        {
            Random random = new Random();   

            Console.Clear();                                                //reward gui
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
██████╗ ███████╗██╗    ██╗ █████╗ ██████╗ ██████╗ 
██╔══██╗██╔════╝██║    ██║██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗  ██║ █╗ ██║███████║██████╔╝██║  ██║
██╔══██╗██╔══╝  ██║███╗██║██╔══██║██╔══██╗██║  ██║
██║  ██║███████╗╚███╔███╔╝██║  ██║██║  ██║██████╔╝
╚═╝  ╚═╝╚══════╝ ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚═════╝ 
                                                  
");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
            }
            if (lastboss == true)       //if killed boss we have big reward
            {
                hp = hp + random.Next(50, 65);

                shield = shield + random.Next(35, 50);

                dg = dg + random.Next(10, 20);

                money = money + random.Next(300, 600);
            }
            else                        //if killed not a boss recieve not so big reward
            {
                hp = hp + random.Next(10, 15);

                shield = shield + random.Next(1, 5);

                dg = dg + random.Next(1, 2);

                money = money + random.Next(1, 15);
            }


            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;               //earning some stats after epic win
            Console.WriteLine("Ваше здоровье было восполнено");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Ваша защита была восполнена");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Ваша сила была увеличена");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Вы забрали деньги у " + mobname);        //stealing some money from defeated mob
            Console.ForegroundColor = ConsoleColor.DarkGray;


            Console.WriteLine("Вы желаете продолжить бой или отойти в магазин?");   //do you want to buy something?
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.DarkCyan; 
            Console.WriteLine(@"1 - В бой
2 - Магазин");
            Console.ResetColor();
            int O = Int32.Parse(Console.ReadLine());

            switch (O)
            {
                default:
                    Console.WriteLine("Введите одно из двух");
                    break;
                case 1:
                    battle(hp, shield, dg, res, money);     //return to battle
                    break;
                case 2:
                    Shop(hp, shield, dg, res, money);   //return to shop
                    break;
            }

            Console.ResetColor();

        }

        void acting(int hp, int shield, int dg, int res, string mobname, int mob_hp, int mob_dmgs, int money, bool lastboss)
        {


            Console.Clear();



            if (hp <= 0)    //if hp <= 0  then hero killed
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Герой убит");
                Console.ResetColor();
                Console.ReadLine();
                Environment.Exit(0);

            }


            Console.ForegroundColor = ConsoleColor.DarkRed;

            if (mob_hp > 100)   //if hp more than 100 adds BOSS tag to monster
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Босс: " + mobname);
                Console.ResetColor();
            }
            else            //if less than print usual enemy tag
            {
                Console.WriteLine("Противник: " + mobname);
                Console.ResetColor();
            }

            
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Здоровье " + mobname + " = " + mob_hp);  //monster hp
            Console.ResetColor();
            
            MobImg(mobname);

            Console.WriteLine();

            Console.WriteLine("Ваши статистики: ");     //hero statis
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("Здоровье = " + hp);
            Console.ResetColor();
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("Щит = " + shield);
            Console.ResetColor();
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("Сила = " + dg);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.Write("Деньги = " + money);
            Console.ResetColor();


            Console.WriteLine("\nВыберите действие: ");     //hero moves
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Write("1 - атака");
            Console.ResetColor();
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Write("2 - лечение");
            Console.ResetColor();
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Write("3  - защита");
            Console.ResetColor();
            Console.Write("  ");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("4  - бегство");
            Console.ResetColor();
            Console.Write("  ");

            int act = Int32.Parse(Console.ReadLine());

            switch (act)    //hero turn to choose atack
            {
                case 1: //Атаки 
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Random pu = new Random();

                    var punch = new string[] { "Вы накормили " + mobname + " жаренными гвоздями", "Ты укусил " + mobname + " за пяту", "Пробил меж глаз " + mobname, "Отправил к маме " + mobname, "Захрюкал до истощения " + mobname, "Подписал на поступление в каит" + mobname };    //atacks array


                    Console.WriteLine(punch[pu.Next(0, 5)]); //random atack splash text writer
                    int result = mob_hp -= dg;
                    if (mob_hp <= 0)            //if died then go to reward screen
                    {
                        Console.WriteLine("Противник погиб");   

                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\n Нажмите enter чтобы продолжить");
                        Console.ResetColor();
                        Console.ReadLine();
                        reward(hp, shield, dg, res, mobname, mob_hp, mob_dmgs,money, lastboss);
                    }
                    else        //attack registration
                    {
                        Console.WriteLine("Нанесено " + dg + " урона.");
                        mob_hp = result;
                        Console.ResetColor();
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("\n Нажмите enter чтобы продолжить");
                        Console.ResetColor();
                        Console.ReadLine();

                        mobact(hp,dg, mobname, mob_hp, mob_dmgs, shield,res,money,lastboss);    

                    }
                    break;
                case 2:   //healing
                    if (hp >= 100) //if hp more than 100 it says nothing more to bandage
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.WriteLine("Вы здоровы, клеить бинты больше некуда");
                        Console.ResetColor();
                        Console.ReadLine();
                        acting(hp, shield, dg, res, mobname, mob_hp, mob_dmgs, money, lastboss);
                    }
                    else // if less than 100 you heals
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.Green;
                        Random Rhealing = new Random();
                        var HEALING = new string[] { "Пьём ряженки...", "Закусываем раны бинтами...", "Бахаем 0.5 жигулёвского...", "Устраиваем пир...", "Заклеиваем царапину активированным углём", "Расчёсываем раны...", "Лепим подорожник..." };    //random healing splash texts
                        Console.WriteLine(HEALING[Rhealing.Next(0, 6)]);
                        int healed = Rhealing.Next(20, 40);
                        Console.WriteLine("Вылечили: " + healed);
                        hp = hp + healed;
                        Console.ResetColor();
                        Console.ReadLine();
                        mobact(hp, dg, mobname, mob_hp, mob_dmgs, shield, res, money, lastboss);
                    }

                    break;
                case 3: //Deff


                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Random defence = new Random();
                    var DEFF = new string[] { "Прикрываем сраку...", "Закрываем шторы...", "Обороняем пятку...", "Прикрываем пах...", "Закрываем глаза...", "Одеваем очки...", "Ложимся на пол...", "Полируем лысину...", "Напрягаем мышцы...", "Притворяемся мертвым..." };    //random deffence splash texts
                    Console.WriteLine(DEFF[defence.Next(0, 9)]);

                    int shielddg = mob_dmgs;

                    Console.WriteLine("Урон по щиту: " + shielddg);
                    if (shield < shielddg)  
                    {
                        Console.WriteLine("Щит не выдерживает такого обращения и ломается..."); //shield breaks if damage more than we have shield
                        hp = hp - mob_dmgs;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Вы получаете урон в размере " + mob_dmgs + " едениц");
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.Clear();

                        acting(hp, shield, dg, res, mobname, mob_hp, mob_dmgs, money, lastboss);
                    }
                    else    //shield harder than attack damage
                    {
                        shield = shield - shielddg;
                        Console.WriteLine("Осталось щита: " + shield);
                        Console.ReadLine();
                        Console.ResetColor();
                        Console.Clear();
                        acting(hp, shield, dg, res, mobname, mob_hp, mob_dmgs, money, lastboss);
                    }
                    break;
                case 4: //running away
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Уносим ноги...");
                    Console.ReadLine();

                    battle(hp, shield, dg, res,money);
                    break;

                default:
                    acting(hp, shield, dg, res, mobname, mob_hp, mob_dmgs, money, lastboss);
                    break;


            }

        }
        void MobImg(string mobname)         //monster pictures, i drawed it in mspaint
        {
            if (mobname == "Шизик какой-то")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine(@"                     .^.                          
                   ^?7Y??.                        
                  !Y:   75                        
                 .G      P^                       
                  ??:   ^P.                       
            .!7!!!!?J?YJ?: :^^^:                  
           ~J~.....^~!YB!!?!~^^7?~                
           .          .7G:      .J?               
                        ?7        7.              
                        7?                        
                        ?7                        
                      .:P.                        
                   :77!7Y7^                       
                 ^??^    :??^                     
                !Y:        :7J~                   
               ?J            .Y!                  
              .!               P~                 
                               :^                                                         ");
                Console.ResetColor();
            }
            else if (mobname == "Слизень")
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine(@"                   .:^^^^^^^^^:..                 
             .^!777!!~^^^^^^^~!7777!~:            
          .~7?!:.                 .:~7?7:         
        .??!.                          ^Y!        
       ~Y~                              .P.       
      ~5. :GG.       5PJ                 ??       
      P^                                  P:      
     !Y    :~~!~~~~~~^.                   !Y      
     J!  :?7~^::^^^^^~!?:                 :P      
     ??                                   :P      
     .P:                            .     ^5      
      7Y           .............    ...:  5~      
       Y7  .....   .                   :!J!       
        ?J~^::...            ..:^~~!7777~.        
         :^!!!!!777!!!7!!77777!!~^::.             
                      ....");
                Console.ResetColor();
            }
            else if (mobname == "Боб")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(@"                    , ,
              ╔▄▄▀▀▀▀▀`█▄▄
            █▀▀           ▀▀█▄▄
            █            ,,    ▌
            ▌  ▀█    ,▄P▀  ▀   █
            █    █   ▀         █
            █ ██ ,     ▄██     ▌
           ▐▌ ▀▌█▀     ▀▀▀    ▐█▀▄           ▄█
           ▐  j█                 ▐▌        ▄▀ █
           █   ▀▀P▀           ▐N▄▄▀      ,█   ▐▌
           █                  ▐         ]▌ ▄  ▐▀
           █   ```▀▀▀▀'       █         █ ▐▌ ╓▌
           █▄,                █M       █  █  █
              █   ▄ ▀▄▄▄▄▄Æ▀▀▀`        ▌ ,█ ▐
              `▀▀▀█▄▄█   █            █` █ ,█
           ▄▄P▀▀N▄▀      ,█ ▀█▄     ▄▄█ ▄▀ █
        ▄▀▀       -▀▀▀▀▀▀▀     ▀▄  ▐▄▄▄▀█▄█
       ▀                        ▀▄ ▄█∞'▀█▄█▌
                                  ]█²    ▀▄
                                   ▀▀▄▄   ▀▄");
                Console.ResetColor();
            }
            else if (mobname == "Боблин")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(@"
                              ]██▄
                               ▀███▄              ,,
                                ╙█▌██         ,▄█▀▀▀▀█▄┐
                                 ╙█▄███▀▀▀████▀  ▄▄█▀▀ 
                             ╓▄▄▄▄██▀ ,▄███ `▀ ▐█▀
                           ▄█▀    '   ▀▀ ███   ▐█
                         ╓█▀   ╓▄██▀ ,         █▌
                         ██▄▄██▀ ╙█▄ ██▄█     ██
                        ╒▄         ██▄,    ▄▄██▄▄
                         ██          ██▀▀▀▀▀████████▄▄,
                         ███       ,▄███▄  ▄█▀███▀▀   ▀██▄
                        ]████▄██▀▀▀▀`   █▌██▄▄███▌       ▐█
                           █`           █▌      █▌   ████▄▀█
                                      ▄▄█       ██   ▄██▄  ▀█
                                      ██▄,▄▄▄▄▄██▀█▄  ▀▀    █▌
                                      █ `▀▀`  ▐█    ▀▀▀▀▀▀▀▀▀▀
                                      ██       █▄
                                       █U     ,▄██H
                                    ▀▀▀▀     ▀▀'");
                Console.ResetColor();
            }
            else if (mobname == "Трава")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"                       █
                       █▌     ▄               █▌
                       ██▌    █▌              █▌       ,▄
               ▐█      █▓█    ██     █U       █▌       ██
                █▌     █▒█▌   ▀█     ██      ╒█▌      ▐█       ,,
      ▀██▄      ▐█,    █▒▒█w  ▐█▌    ██      ██▌      █▌     ╓██ 
       ╙█▓█▄     ██    █╣▒██  ▐██    ██     ]██▌      █▌   ,█▀█▌
        ▐█▒█▌    ███  ▐█▓▒▐█  █▌█▌   ██     ██▀█     ▐█▌   █▀▐█
         ██▒██   ███  ▐▌▓▒▒█  █▒▐█  ▐██▌   ▐█▒▐█⌐    ██▌  █▌▒█▌
          █▌▒█▄  █▒█▌ ▐▓▒▒▒█▌ █▒▒█▄ █▓▓█   █▓▒▒█▌   █▌█▌ ██▒▓█
           █▒▒██ █▓▓█ █╣▌▒▒▒█▐█▓▒█▌,█▓▐█  ▄█▓▒▒▒█  ██▓██▐█░░█`
           █▌▒▒█▌█▓▒█µ█▓▌▒▒▒██▓▓▒▀███▓▒█▌██▓▒▒▒▒█▌██▓▒▒██▒▒▐█
           ▐█▒▒▒██▓▒███▓▒▒▒▒██▓▒▒▒██▓▌▒███▓▒▒▒▒▒▀█▀▓▒▒▒▐█▒▒▐█
            █▌▒▒██▓▒██▓▒▒▒▒██▓▒▒▒▒█▌▓▒▒▒█▓▒▒▒▒▒▒▓█▒▒▒▒▒▐█▒▒█▌
            ▐█▒▒█▌▓▒░█▌▒▒▒▐█▓▒▒▒▒▒█▌▒▒▒█▌▓▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▌
             █▒██▓▒▒▒░█▌▒▒▒░▒▒▒▒▒▒░░▒▒▒▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐█
            ▐█▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄▄▄▄▄▄▄██▌▒▒▒██
             ██░██▄▒▄█████▀▀██▄███▀████▀▀▀█▄██▀  ▀▀`   ▀███▀
              ▀▀▀  ▀▀                      `

 ");
                Console.ResetColor();

            }
            else if (mobname == "Дерево")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"                            ,▄▄▄▄▄   ╓▄▄▄▄,▄▄▄▄▄▄▄,
                    ,████████▓▓▓▓▓███▓▓▓▓▓█▓▓▓▓▓▓▓██▓██▄
                    ██▓╢▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▄╖
                   ▄██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▄
                  █▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█▄
                ╒██▓╢▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
             ▄████╢▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██
             ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▀
              ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█
              ██▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓╢█▓▓▓▓▓▓▓▓▓▓▓▓▓▓██▀
               ▀██▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓▓▓▓▓▓██▓▓▓▓▓▓█╢▓▓▓▓▓▓▓█
                 ██████▓▓╢█████████▓▓▓███▌ ▀█████▌▀▀▀▀▀██▀");
                Console.ForegroundColor= ConsoleColor.DarkYellow;
                Console.WriteLine(@"                              ██▒░░▀▀▀░▒█▌
                              ▐█▒▒▒▒▒▒▒╠█
                              ▐█▒▒▒▒▒▒▒██
                              █▌▒▒▒▐█████
                              █▌▒▒▒██▐███
                              █▌▒▒▒▒██▀██
                              █▌▒▒▒▒▒▒▒█▌
                              █▌▒▒▒▒▒▒▒█U
                             ▐█▒▒▒▒▒▒▒▒██
                            █▌▒▒▒▒▒▒▒▒▒▒▒▀█▄
                          ╓██▒▄░▒░▄░▒▒▄██▄▒▀██⌐
                         ╓███▀▀███▀█▄████▌ ▀▀▀");
                Console.ResetColor();

            }
            else if (mobname == "Крапива")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"                      ^.                          
                  ... ~~^. .:^^^^^:.              
               :^^::::^:::~^:::.                  
                    ....:^:.:.                    
                      ..:.^.                      
                        :::                       
           ..::::^:::.  .::     ...               
        ...::^.....:^:^^~^:  .^^^^^^:^::.         
      .::..... .::^^^^7!!:~^^:.      ..^^^:.      
     .:.^.  ... .^.    ..:~~?!~^:......  ..^~:    
    ^:... .:..:::::::.  .:: :!7~!!~^:. .... .^~:  
   :^^..... :^~~~~!!~~~^^::. .!:  :^!7^:  ....:~  
  .~::..      .::.:~.^^~!~~^....:..  .^!!.     :. 
  ^~:.       .^  ..:::::.:.. .    .:.   :         
  ~^        .^. :::. ::       ..    ::            
            .^ :^:   ::        ..    ^.           
             :^^     .^          .   :.           
              :.      .:          :  ::           
                       .^.        .: .:           
                        ^^:.       :..:           
                        :::..:.     :.:           
                        :::   .:..   .^           
                        :.:      ..:. ^           
                        : ^        ..:~.          
                       .^ ^           ..          
                       .^:^.                      
                        ^^^     ");
                Console.ResetColor();

            }

        }
        void Shop(int hp, int shield, int dg, int res, int money)   //shop!
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine(@"  ______   __                           
 /      \ /  |                          
/$$$$$$  |$$ |____    ______    ______  
$$ \__$$/ $$      \  /      \  /      \ 
$$      \ $$$$$$$  |/$$$$$$  |/$$$$$$  |
 $$$$$$  |$$ |  $$ |$$ |  $$ |$$ |  $$ |
/  \__$$ |$$ |  $$ |$$ \__$$ |$$ |__$$ |
$$    $$/ $$ |  $$ |$$    $$/ $$    $$/ 
 $$$$$$/  $$/   $$/  $$$$$$/  $$$$$$$/  
                              $$ |      
                              $$ |      
                              $$/   ");

            Console.ForegroundColor=ConsoleColor.DarkYellow;    //guis and texts
            Console.WriteLine("Деньги:" + money);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("Товар:");
            Console.WriteLine(@"1 - Лечение(20$)
2 - Ремонт щита (20$)
3 - Анаболиеские стеройды (150$)
4 - Выход");

            int o = Int32.Parse(Console.ReadLine());
            switch (o)
            {
                default:
                    Console.Clear();
                    Shop(hp, shield, dg, res, money);    
                    break;
                case 1:

                    if (money < 20)
                    {
                        Console.WriteLine("У вас не хватает денег");    //no money
                        Console.ReadKey(true);
                        Shop(hp, shield, dg, res, money);

                    }
                    else
                    {
                        Console.Clear();
                        hp = hp + 10;
                        money = money - 20;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Вылечили 10 очков здоровья");    //buyed healing pack
                        Console.ReadLine();
                        Console.ResetColor();
                        battle(hp, shield, dg, res, money);

                    }

                    
                    
                    break;
                case 2:

                    if (money < 20)
                    {
                        Console.WriteLine("У вас не хватает денег");    //no money
                        Console.ReadKey(true);
                        Shop(hp, shield, dg, res, money);

                    }
                    else
                    {
                        Console.Clear();
                        shield = shield + 10;
                        money = money - 20;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Щит восстановлен на 10 едениц"); //we buy armor
                        Console.ReadLine();
                        Console.ResetColor();
                        battle(hp, shield, dg, res, money);
                    }
                    break;
                case 3:
                    if (money < 150)
                    {
                        Console.WriteLine("У вас не хватает денег");    //no money
                        Console.ReadKey(true);
                        Shop(hp, shield, dg, res, money);

                    }
                    else
                    {
                        Console.Clear();
                        dg = dg + 10;
                        money = money - 150;
                        Console.ForegroundColor = ConsoleColor.Green;   //buffed some damage
                        Console.WriteLine("Сила увеличена на 10");
                        Console.ReadLine();
                        Console.ResetColor();
                        battle(hp, shield, dg, res, money);
                    }
                    break;
                case 4:
                    battle(hp, shield, dg, res, money);
                    break;
            }

            Console.ReadKey(true);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Menu MENU = new Menu();
            Warrior WARRIOR = new Warrior();

            MENU.GrandMenu();
            int game = Int32.Parse(Console.ReadLine());
            switch (game)
            {
                case 1:
                    WARRIOR.Fighter_Menu();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;

            }
        }
    }
}
