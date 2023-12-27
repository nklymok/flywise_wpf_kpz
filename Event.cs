using System;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class Event
    {
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public DateTime Date { get; set; }

    }
}

