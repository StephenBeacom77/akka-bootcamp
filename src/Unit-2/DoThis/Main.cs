using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Akka.Actor;
using ChartApp.Actors;

namespace ChartApp
{
    public partial class Main : Form
    {
        private IActorRef _chartActor;
        private IActorRef _coordinatorActor;
        private IActorRef _rotationActor;
        private Dictionary<CounterType, IActorRef> _toggleActors = new Dictionary<CounterType, IActorRef>();

        public Main()
        {
            InitializeComponent();
        }

        #region Initialization

        private void Main_Load(object sender, EventArgs e)
        {
            _chartActor = Program.ChartActors.ActorOf(Props.Create(()
                => new ChartingActor(sysChart, pauseButton)), "charting");
            _chartActor.Tell(new ChartingActor.InitializeChart(null)); //no initial series

            _coordinatorActor = Program.ChartActors.ActorOf(Props.Create(()
                => new PerformanceCounterCoordinatorActor(_chartActor)), "counters");

            _rotationActor = Program.ChartActors.ActorOf(Props.Create(()
                => new ButtonRotationActor(_coordinatorActor, rotationButton, CounterType.Cpu))
                .WithDispatcher("akka.actor.synchronized-dispatcher"), "rotation");

            // CPU button toggle actor
            _toggleActors[CounterType.Cpu] = Program.ChartActors.ActorOf(Props.Create(()
                => new ButtonToggleActor(_coordinatorActor, cpuToggleButton, CounterType.Cpu, false))
                .WithDispatcher("akka.actor.synchronized-dispatcher"));

            // MEMORY button toggle actor
            _toggleActors[CounterType.Ram] = Program.ChartActors.ActorOf(Props.Create(()
                => new ButtonToggleActor(_coordinatorActor, ramToggleButton, CounterType.Ram, false))
                .WithDispatcher("akka.actor.synchronized-dispatcher"));

            // DISK button toggle actor
            _toggleActors[CounterType.Disk] = Program.ChartActors.ActorOf(Props.Create(()
                => new ButtonToggleActor(_coordinatorActor, diskToggleButton, CounterType.Disk, false))
               .WithDispatcher("akka.actor.synchronized-dispatcher"));

            // Set the CPU toggle to ON so we start getting some data
            _toggleActors[CounterType.Cpu].Tell(new ButtonToggleActor.Toggle());
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //shut down the charting actor
            _chartActor.Tell(PoisonPill.Instance);

            //shut down the ActorSystem
            Program.ChartActors.Terminate();
        }

        #endregion

        private void cpuToggleButton_Click(object sender, EventArgs e)
        {
            _toggleActors[CounterType.Cpu].Tell(new ButtonToggleActor.Toggle());
        }

        private void ramToggleButton_Click(object sender, EventArgs e)
        {
            _toggleActors[CounterType.Ram].Tell(new ButtonToggleActor.Toggle());
        }

        private void diskToggleButton_Click(object sender, EventArgs e)
        {
            _toggleActors[CounterType.Disk].Tell(new ButtonToggleActor.Toggle());
        }

        private void rotationButton_Click(object sender, EventArgs e)
        {
            _rotationActor.Tell(new ButtonRotationActor.Rotate());
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            _chartActor.Tell(new ChartingActor.TogglePause());
        }
    }
}
