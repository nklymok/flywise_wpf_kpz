using System.Collections.Generic;
using System;
using System.Runtime.Serialization;

namespace Model
{
    [DataContract]
    public class Project
    {
        [DataMember]
        public String Name { get; set; }
        [DataMember]
        public String Description { get; set; }
        [DataMember]
        public IEnumerable<Task> Tasks { get; set; }

    }
}

