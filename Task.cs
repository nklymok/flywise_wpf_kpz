using System;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class Task
    {
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String Description { get; set; }
        [DataMember]
        public int Priority { get; set; }

    }
}

