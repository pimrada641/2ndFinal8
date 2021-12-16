using System;

namespace Final
{
    class Node{
        protected Node next = null;
    }
    class Equipment : Node{
        public Equipment Next{
            get{return next as Equipment;}
            set{next = value;}
        }
        public Equipment name;
        public Equipment(Equipment valueName){
            name = valueName;
        }
    }
    class Combine{
        private Equipment root = null;
        public void Add(Equipment newEquipment){
            if(root == null){
                root = newEquipment;
            }
            else if(newEquipment < root){
                newEquipment = root;
                root = newEquipment;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int amount = int.Parse(Console.ReadLine());
            Combine combine = new Combine();
            Equipment equips = Console.ReadLine();
            Combine.Add(new Equipment(equips));
        }
    }
}
