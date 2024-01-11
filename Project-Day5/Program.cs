namespace Project_Day5
{
    
    internal class Program
    {
        static void Main(string[] args)
        {Student student = new Student();
            student.Id= -1;  // this will call set 
            Console.WriteLine(student.Id);


            Batch batch = new Batch();
            //batch.Strength = 10;

        }
    }
}

// It allows to access private fields of a class outside the class
  //EVery properry has two accessors
  //   get set 
  //  get > is used to return Value of some private filed
  //  set > IServiceProvider used to assign a value to some private field

  //  student.Id = 900; // here 900 will ba passed as value to the variable
