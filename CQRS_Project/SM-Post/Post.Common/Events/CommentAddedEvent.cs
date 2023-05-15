using System;
using CQRS.Core.Events;
using MongoDB.Bson.Serialization.Conventions;

namespace Post.Common.Events
{
    public class CommentAddedEvent : BaseEvent
    {
        public CommentAddedEvent() : base(nameof(CommentAddedEvent))
        {
        }
        public Guid CommentId {get; set;}
        public string Comment {get; set;}
        public string UserName {get; set;} 
        public DateTime CommmentDate {get; set;}

    }
}
