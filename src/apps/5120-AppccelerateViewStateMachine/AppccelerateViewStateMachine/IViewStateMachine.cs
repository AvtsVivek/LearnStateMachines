using System;
using static AppccelerateStateMachine.Extensions.EventRaiser;

namespace AppccelerateStateMachine
{
    public interface IViewStateMachine
    {
        void FireEvent(Events events);
        void ChangeViewModel(int index);
        event EventHandler<EventArgs<int>> ViewModelEvent;
    }
}
