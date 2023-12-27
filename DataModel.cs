using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Model
{

    [DataContract]
    public class DataModel
    {
        [DataMember]
        public IEnumerable<Task> Tasks { get; set; }
        [DataMember]
        public IEnumerable<Project> Projects { get; set; }
        [DataMember]
        public IEnumerable<Event> Eventss { get; set; }
    }
}
