using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace DoubleBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            Stage s=new Stage();
            Actor a1=new Actor("a1",s);
            Actor a2=new Actor("a2",s);
            Actor a3=new Actor("a3",s);

            a1.Face(a2);
            a2.Face(a3);
            a3.Face(a1);

            s.Add(a1);
            s.Add(a2);
            s.Add(a3);

            a3.Slap();
            //a1.Slap();
            
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("========");
                s.Sort();//保持调用的先后顺序
                s.Update();
                Console.WriteLine("========");
            }  
        }

        class Stage
        {
            List<Actor> actors=new List<Actor>();


            public static int sort = 0;

            public void Add(Actor ac)
            {
                if (!actors.Contains(ac))
                    actors.Add(ac);
            }

            public void Sort()
            {
                actors.Sort((a, b) => { return a.sortIndex - b.sortIndex;});
                sort = 0;
            }

            public void Update()
            {
                for (int i = 0; i < 3; i++)
                {
                    actors[i].Swap();//交换得到上一帧的状态
                }

                for (int i = 0; i < 3; i++)
                {
                    actors[i].Update();//执行 得到下一帧的状态
                    //actors[i].Reset();
                }
            }
        }

        class Actor
        {
            private Actor facingActor;
            private bool isSlaped;
            private bool currentSlaped;
            private bool nextSlaped;
            private string name;
            private Stage ss;
            public int sortIndex;

            public Actor(string s,Stage stage)
            {
                name = s;
                ss = stage;
            }
            public bool IsSlaped()
            {
                //return isSlaped;
                return currentSlaped;
            }
            public void Face(Actor ac)
            {
                facingActor = ac;
            }

            public void Reset()
            {
                isSlaped = false;
            }

            public void Swap()
            {
                currentSlaped = nextSlaped;
                nextSlaped = false;
            }

            public void Slap()
            {
                //isSlaped = true;
                nextSlaped = true;
                Stage.sort++;
                sortIndex = Stage.sort;

            }
            public void Update()
            {
                if (IsSlaped())
                {
                    Console.WriteLine(name+" is slaped");
                    facingActor.Slap();
                }
            }


        }
    }
}
