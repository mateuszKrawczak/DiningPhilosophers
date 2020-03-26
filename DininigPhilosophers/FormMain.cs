
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace DininigPhilosophers
{
    public partial class FormMain : Form
    {
        
        private bool isStarted = false;
        List<Philosopher> philosophers = new List<Philosopher>();
        List<Thread> philosophersThreads;
        public FormMain()
        {
            InitializeComponent();
            
            philosophers = InitializePhilosophers();
            philosophersThreads = new List<Thread>();



            foreach (var philosopher in philosophers)
            {
                philosophersThreads.Add(new Thread(philosopher.Think));


            }
            timer.Start();
           
            
            initializeLabels();
        }

        
        private void initializeLabels()
        {
            labelPhilosopher1.Text = philosophers[0].Name;
            labelPhilosopher2.Text = philosophers[1].Name;
            labelPhilosopher3.Text = philosophers[2].Name;
            labelPhilosopher4.Text = philosophers[3].Name;
            labelPhilosopher5.Text = philosophers[4].Name;

            labelStatus1.Text = philosophers[0].State.ToString();
            labelStatus2.Text = philosophers[1].State.ToString();

            labelStatus3.Text = philosophers[2].State.ToString();

            labelStatus4.Text = philosophers[3].State.ToString();
            labelStatus5.Text = philosophers[4].State.ToString();
        }
        


        private void buttonStart_Click(object sender, EventArgs e)
        {
            isStarted = true;
            Console.WriteLine("Dinner is starting!");
            foreach (var philosopher in philosophersThreads)
            {
                philosopher.Start();



            }

            
        }


        private void buttonStop_Click(object sender, EventArgs e)
        {
            isStarted = false;
            foreach (var thread in philosophersThreads)
            {
                thread.Abort();
            }
        }


        
        private List<Philosopher> InitializePhilosophers()
        {
            Philosopher aristotle = new Philosopher(Table.Plastic, Table.Platinum, "Aristotle");
            Philosopher palto = new Philosopher(Table.Platinum, Table.Gold, "Plato");
            Philosopher kant = new Philosopher(Table.Gold, Table.Silver, "Immanuel Kant");
            Philosopher socrates = new Philosopher(Table.Silver, Table.Wood, "Socrates");
            Philosopher thomas = new Philosopher(Table.Wood, Table.Plastic, "Thomas Aquinas");

            philosophers.Add(aristotle);
            philosophers.Add(palto);
            philosophers.Add(kant);
            philosophers.Add(socrates);
            philosophers.Add(thomas);
            
            return philosophers;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (isStarted)
            {
                labelStatus1.Text = philosophers[0].State.ToString();
                labelStatus2.Text = philosophers[1].State.ToString();
                labelStatus3.Text = philosophers[2].State.ToString();
                labelStatus4.Text = philosophers[3].State.ToString();
                labelStatus5.Text = philosophers[4].State.ToString();
             }
          
         }
    }

 }
    

    



   
