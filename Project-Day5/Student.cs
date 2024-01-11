using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Day5
{
    internal class Student
    {
        // properties are the wrappers around the private variables
        
        int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value <= 0)
                    id = 100;
                else
                    id = value;
            }
        }
        public string Name
        {
            get {  return name;}
            set { name = value;}
        }
        string name;
        public string Batch {  get { return batch;} set { batch = value;} }     
        string batch;
        public void Get() { }
        public void Display() { }
    }
}
