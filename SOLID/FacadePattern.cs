using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    using System;

    // Subsystem classes
    public class CPU
    {
        public void Freeze()
        {
            Console.WriteLine("CPU: Freeze");
        }

        public void Execute()
        {
            Console.WriteLine("CPU: Execute");
        }
    }

    public class Memory
    {
        public void Load()
        {
            Console.WriteLine("Memory: Load");
        }
    }

    public class HardDrive
    {
        public void ReadData()
        {
            Console.WriteLine("HardDrive: ReadData");
        }
    }

    // Facade class
    public class ComputerFacade
    {
        private CPU cpu;
        private Memory memory;
        private HardDrive hardDrive;

        public ComputerFacade()
        {
            this.cpu = new CPU();
            this.memory = new Memory();
            this.hardDrive = new HardDrive();
        }

        public void Start()
        {
            cpu.Freeze();
            memory.Load();
            hardDrive.ReadData();
            cpu.Execute();
            Console.WriteLine("Computer started successfully.");
        }
    }

    // Client code
    class Program8
    {
        static void Main(string[] args)
        {
            // Using the Facade to start the computer
            ComputerFacade computerFacade = new ComputerFacade();
            computerFacade.Start();
        }
    }

}
