namespace BasicConcept
{
    //creating a class
    class Demo
    {
        //creating field members
        int no;
        
        //initializing static field member
        static string name = "Vishal";

        string city;

        //Constructor Overloading
        //default constructor
        public Demo() { }

        //one parameterized constructor
        public Demo(int no1)
        {
            this.no = no1;
            Console.WriteLine(no);
        }

        //two parameterized constructor
        public Demo(int no, string city) 
        {
            this.no = no;
            this.city = city;
            Console.WriteLine(no +" " + city);
        }
        //creating method
        public void Method1()
        {
            Console.WriteLine("This is method1");
        }
        public static void Method2()
        {
            Console.WriteLine("This is method2");
        }

        //one parametrized method
        public int Method3(int no)
        {
            int a = no * 2;
            return a;
        }
        //two parameterized method
        public string FullName(string fname,string lname)
        {
            string fullname = fname +" " + lname;
            return fullname;
        }
        public static void Main(string[] args)
        {
            //creating object
            Demo var1 = new Demo();

            //method calling with object
            var1.Method1();

            //static method calling with classname
            Demo.Method2();

            //accesing method with parameters
            int b = var1.Method3(45);

            Console.WriteLine(b);

            Console.WriteLine(var1.Method3(22));

            Demo var2 = new Demo();
            Console.WriteLine(var2.FullName("Sakshi", "Gupta"));

            string c = var2.FullName("Rohan", "Sawant");
            //string interpolation
            Console.WriteLine( $"My Name is : {c}");

            //accessing parameterized Constructor
            Demo var3 = new Demo(2);

            //accesing field member with object
            Console.WriteLine(var3.no);

            //accessing static member
            Console.WriteLine(name);

            //accesing 2 parameterized constructor
            Demo var4 = new Demo(3, "Mumbai");

            

        }
    }
}
