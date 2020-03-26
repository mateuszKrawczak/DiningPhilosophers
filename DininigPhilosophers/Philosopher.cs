
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;


namespace DininigPhilosophers
{
    class Philosopher
    {
        private int eatTime = 2000;
        private int sleepTime = 2000;
        public string Name { get; set; }

        public PhilosopherState State { get; set; }

        
        
        public readonly Fork RightFork;
        public readonly Fork LeftFork;

        public Philosopher(Fork rightFork, Fork leftFork, string name)
        {
            RightFork = rightFork;
            LeftFork = leftFork;
            Name = name;
            State = PhilosopherState.Thinking;
         }

        public void Eat()
        {
            
            if (TakeForkInRightHand())
            {
                
                if (TakeForkInLeftHand())
                {
                    
                    this.State = PhilosopherState.Eating;
                    Console.WriteLine("(:::) {0} is eating..with {1} and {2}", Name, RightFork.ForkID, LeftFork.ForkID);
                    Thread.Sleep(eatTime);

                  
                    
                    RightFork.Put();
                    LeftFork.Put();
                }
                
                else
                {
                    
                    Thread.Sleep(100);
                    if (TakeForkInLeftHand())
                    {
                        
                        this.State = PhilosopherState.Eating;
                        Console.WriteLine("(:::) {0} is eating..with {1} and {2}", Name, RightFork.ForkID, LeftFork.ForkID);
                        Thread.Sleep(eatTime);


                        RightFork.Put();
                        LeftFork.Put();
                    }
                   
                    else
                    {
                        RightFork.Put();
                    }
                }
            }
            
            else
            {
                
                if (TakeForkInLeftHand())
                {
                    
                    Thread.Sleep(100);
                    if (TakeForkInRightHand())
                    {
                       
                        this.State = PhilosopherState.Eating;
                        Console.WriteLine("(:::) {0} is eating..with {1} and {2}", Name, RightFork.ForkID, LeftFork.ForkID);
                        Thread.Sleep(eatTime);

                        

                        RightFork.Put();
                        LeftFork.Put();
                    }
                    else
                    {
                        
                        LeftFork.Put();
                    }
                }
            }

            Think();
        }

        public void Think()
        {
            this.State = PhilosopherState.Thinking;
            Console.WriteLine("^^*^^ {0} is thinking...on {1}", Name, Thread.CurrentThread.Priority.ToString());
            Thread.Sleep(sleepTime);
            

            Eat();
        }

        private bool TakeForkInLeftHand()
        {
            return LeftFork.Take(Name);
        }

        private bool TakeForkInRightHand()
        {
            return RightFork.Take(Name);
        }

    }
}