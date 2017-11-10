using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Class1
    {
        public class Word
        {
            public string boundingBox { get; set; }
            public string text { get; set; }
        }

        public class Line
        {
            public string boundingBox { get; set; }
            public IList<Word> words { get; set; }
        }

        public class Region
        {
            public string boundingBox { get; set; }
            public IList<Line> lines { get; set; }
        }

        public class Example
        {
            public string language { get; set; }
            public string orientation { get; set; }
            public double textAngle { get; set; }
            public IList<Region> regions { get; set; }
        }
    }

}

