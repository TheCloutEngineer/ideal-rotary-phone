using System;
using System.Collections.Generic;

namespace ideal_rotary_phone.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class CMSModel
    {
        public List<Page> Page { get; set; }

    }

    public class Page
    {

        public List<Component> Component { get; set; }

    }

    public class Component
    {
        public string id { get; set; }
        public string image { get; set; }
        public string header { get; set; }
        public string subtitle { get; set; }
        public string body { get; set; }

    }






}
