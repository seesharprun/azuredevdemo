using Contoso.Events.Data;
using Contoso.Events.Models;
using System.Linq;

namespace Contoso.Events.ViewModels
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        { }

        public RegisterViewModel(string eventKey)
        {
            using (EventsContext context = new EventsContext())
            {
                this.Event = context.Events.SingleOrDefault(e => e.EventKey == eventKey);
            }
        }

        public Event Event { get; set; }

        public EventRegistrant Registration { get; set; }
    }
}