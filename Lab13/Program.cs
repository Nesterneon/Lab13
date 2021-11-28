using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Советская, 26", 30, 20, 15);
            MultiBuildingBuilding multiBuildingBuilding = new MultiBuildingBuilding("Советская, 26", 20, 20, 15,3);
            //building.Print();
            //Console.WriteLine();
            multiBuildingBuilding.Print();
            Console.ReadKey();
        }
    }
    public class Building
    {
        public string address;
        public int length;
        public int width;
        public int height;

        public Building(string address, int length, int width, int height)
        {
            this.address = address;
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return width; }
            set { width = value; }
        }
        public Building()
        {

        }
        public void Print()
        {
            Console.WriteLine("адрес здания: {0}", address);
            Console.WriteLine("длина здания: {0}", length);
            Console.WriteLine("ширина здания: {0}", width);
            Console.WriteLine("высота здания: {0}", height);
        }
    }
    sealed class MultiBuildingBuilding : Building
    {
        public int floor;

        public MultiBuildingBuilding(string address, int length, int width, int height, int floor)
            :base(address, length, width, height)
        {
            this.floor = floor;
        }
        public int Floor
        {
            get { return floor; }
            set { floor = value; }
        }
        public new void Print()
        {
            base.Print();
            Console.WriteLine("этаж здания: {0}", floor);
        }
    }
}
