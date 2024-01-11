using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day5
{
    internal class Batch
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string topic;

        public string Topic
        {
            get { return topic; }
            set { topic = value; }
        }

        public int Strength { get; private set; }


    }
}
