using System;
using System.Collections.Generic;
using System.Text;

namespace ExamJSONPrep
{
    public class CatAPI
    {
        public status status { get; set; }
        public string type { get; set; }
        public string text { get; set; }
        public string _id { get; set; }
    }


    public class status
    {
        public string verified { get; set; }
    }
}
