using System.Windows.Forms;
using Akka.Actor;
using System.Drawing;

namespace ChartApp.Actors
{
    /// <summary>
    /// Actor responsible for managing button toggles
    /// </summary>
    public class ButtonRotationActor : UntypedActor
    {
        #region Message types

        /// <summary>
        /// Toggles this button on or off and sends an appropriate messages
        /// to the <see cref="PerformanceCounterCoordinatorActor"/>
        /// </summary>
        public class Rotate { }

        #endregion

        private CounterType _myCounterType;
        private readonly Button _myButton;
        private readonly IActorRef _coordinatorActor;

        public ButtonRotationActor(IActorRef coordinatorActor, Button myButton,
                CounterType myCounterType)
        {
            _coordinatorActor = coordinatorActor;
            _myButton = myButton;
            _myCounterType = myCounterType;

            _coordinatorActor.Tell(
                new PerformanceCounterCoordinatorActor.Watch(_myCounterType));
        }

        protected override void OnReceive(object message)
        {
            if (message is Rotate)
            {
                var oldCounterType = _myCounterType;
                switch (_myCounterType)
                {
                    case CounterType.Cpu:
                        _myCounterType = CounterType.Ram;
                        break;
                    case CounterType.Ram:
                        _myCounterType = CounterType.Disk;
                        break;
                    case CounterType.Disk:
                        _myCounterType = CounterType.Cpu;
                        break;
                }
                _coordinatorActor.Tell(new PerformanceCounterCoordinatorActor.Rotate(oldCounterType, _myCounterType));
                _myButton.Text = $"{_myCounterType}";
            }
            else if (message is Metric)
            {
                var metric = message as Metric;
                _myButton.Text = $"{_myCounterType}\n{metric.CounterValue}";
            }
            else
            {
                Unhandled(message);
            }
        }
    }
}