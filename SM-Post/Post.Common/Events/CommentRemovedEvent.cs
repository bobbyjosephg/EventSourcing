using CQRS.Core.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post.Common.Events
{
    public class CommentRemovedEvent : BaseEvent
    {
        public CommentRemovedEvent(string type) : base(type)
        {
        }

        public Guid CommentId { get; set; }
        public string CommentText { get; set; }

    }
}
