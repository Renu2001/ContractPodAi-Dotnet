namespace BasicConcept
{
    //creating a class
    class Demo
    {
        //creating field members
        int no;
        string name;

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
            Console.WriteLine(var2.FullName("sakshi", "gupta"));

            string c = var2.FullName("Rohan", "Sawant");
            //string interpolation
            Console.WriteLine( $"My Name is : {c}");

        }
    }
}
