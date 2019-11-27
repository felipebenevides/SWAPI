using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SWAPI.Application.ViewModels
{
    public class PeopleViewModel
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        string birth_year { get; set; }
        [DataMember]
        string eye_color { get; set; }
        [DataMember]
        string gender { get; set; }
        [DataMember]
        string hair_color { get; set; }
        [DataMember]
        string height { get; set; }
        [DataMember]
        string mass { get; set; }
        [DataMember]
        string skin_color { get; set; }
        [DataMember]
        string homeworld { get; set; }
        [DataMember]
        string created { get; set; }
        [DataMember]
        string edited { get; set; }
        [DataMember]
        string url { get; set; }

        [DataMember]
        public string[] Films { get; set; }

        [DataMember]
        string[] species { get; set; }
        [DataMember]
        string[] starships { get; set; }
        [DataMember]
        string[] vehicles { get; set; }
    }

    [DataContract]
    public class Json
    {
        [DataMember]
        public List<PeopleViewModel> results { get; set; }
    }
}

