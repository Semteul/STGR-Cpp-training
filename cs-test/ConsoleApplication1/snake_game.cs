using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    struct Program
    {      //-----------------------------------------------
        const int UP = 0;         //전역상수 선언
        const int DOWN = 1;
        const int RIGHT = 2;
        const int LEFT = 3;

        const int WALL = 0;
        const int BLANK = 1;
        const int PLAYER_HEAD = 2;
        const int PLAYER_BODY = 3;
        const int FOOD = 4;

        const string WALL_ICON = "□";
        const string BLANK_ICON = "  ";
        const string PLAYER_HEAD_ICON = "●";
        const string PLAYER_BODY_ICON = "○";
        const string FOOD_ICON = "★";
            //-----------------------------------------------
        public static int Keycode = -1;              //static 으로 Keycode 선언 및 초기화
        public static Random r = new Random();       //static 으로 랜덤함수를 호출하고 변수 r에 입력
        public static List<XY> Player = new List<XY>() { new XY(1, 1)};     //static으로 List<>함수생성 및 구조체XY 할당 (시작지점 1.1)
        public static List<XY> Food = new List<XY>() { };

        public struct XY
        {
            public int x, y;

            public XY(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            Thread sg = new Thread(new ThreadStart(NONONO));  //sg쓰레드 생성 및 NONONO메소드 쓰레드호출
            sg.Start();  // 쓰레드시작
            while (true)
            {
                switch (Console.ReadKey(true).Key)    //값을 입력받는데 true를 넣으면 입력받은값을 입력창에 출력x
                {                                    //.Key는 입력받는값의 반환형식이 Key이다.
                    case ConsoleKey.UpArrow:
                        Keycode = UP;
                        break;
                    case ConsoleKey.DownArrow:
                        Keycode = DOWN;
                        break;
                    case ConsoleKey.RightArrow:
                        Keycode = RIGHT;
                        break;
                    case ConsoleKey.LeftArrow:
                        Keycode = LEFT;
                        break;

                    default:
                        Console.Beep();
                        break;
                }
            }
        }

        public static void NONONO()
        {
            DRAW();
            while (true)
            {
                Thread.Sleep(500);
                int cd = -1;
                XY xy = new XY(0, 0);
                switch(Keycode)
                {
                    case -1:
                        continue;
                    case UP:
                        xy = new XY(Player[0].x, Player[0].y - 1);
                        cd = CD(xy);
                        break;
                    case DOWN:
                        xy = new XY(Player[0].x, Player[0].y + 1);
                        cd = CD(xy);
                        break;
                    case RIGHT:
                        xy = new XY(Player[0].x + 1, Player[0].y);
                        cd = CD(xy);
                        break;
                    case LEFT:
                        xy = new XY(Player[0].x - 1, Player[0].y);
                        cd = CD(xy);
                        break;
                }

                if(cd == WALL || cd == PLAYER_BODY)
                {
                    break;
                }
                else if(cd == BLANK)
                {
                    Player.Insert(0, xy);//원하는 위치의 값을 넣음(insert)
                    Player.RemoveAt(Player.Count - 1); //index를 삭제함
                }
                else if(cd == FOOD)
                {
                    Player.Insert(0, xy);
                    Food.Remove(xy);
                }

                if(Food.Count<6)
                {
                    Food.Add(RandomFood()); // add는 리스트배열 마지막에 새로운값을 추가
                }
                DRAW();
            }
        }

        public static XY RandomFood()
        {
            XY food =  new XY(r.Next(1, 22), r.Next(1, 22));
            if(CD(food) != BLANK)
            {
                return RandomFood();
            }
            return food;
        }

        public static int CD(XY loc)
        {
            if (loc.x <= 0 || loc.y <= 0 || loc.x >= 23 || loc.y >= 23)
            {
                return WALL;
            }

            for (int i = 0; i < Player.Count; i++)
            {
                if (Player[i].x == loc.x && Player[i].y == loc.y)
                {
                    if (i == 0)
                    {
                        return PLAYER_HEAD;
                    }
                    else
                    {
                        return PLAYER_BODY;
                    }
                }
            }
            for (int i = 0; i < Food.Count; i++) // Count는 리스트의 총 길이
            {
                if (Food[i].x == loc.x && Food[i].y == loc.y)
                {
                    return FOOD;
                }
            }
            return BLANK;
        }

        public static void DRAW()
        {
            string result = "";
            for (int num = 0; num < 24; num++)        
            {
                for (int num2 = 0; num2 < 24; num2++)
                {
                    switch (CD(new XY(num2, num)))
                    {
                        case WALL: result += WALL_ICON;
                            break;
                        case BLANK: result += BLANK_ICON;
                            break;
                        case PLAYER_BODY: result += PLAYER_BODY_ICON;
                            break;
                        case PLAYER_HEAD: result += PLAYER_HEAD_ICON;
                            break;
                        case FOOD: result += FOOD_ICON;
                            break;
                    }
                }
                result += "\n";
            }
            Console.Clear();
            Console.Write(result);
        }
    }
}

