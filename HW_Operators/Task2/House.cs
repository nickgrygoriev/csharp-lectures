
namespace Task2
{
    class House
    {
        private Interior interior = new Interior();
        private int doors;

        public string Interior
        {
            get { return interior.houseInterior; }
            set { interior.houseInterior = value; }
        }

        public int Doors
        {
            get { return doors; }
            set { doors = value; }
        }

        public House Clone()
        {
            return (House)this.MemberwiseClone();
        }

        public House DeepClone()
        {
            House deepCloneHouse = new House();
            deepCloneHouse.Interior = Interior;
            deepCloneHouse.Doors = Doors;
            return deepCloneHouse;
        }
    }

    class Interior
    {
        public string houseInterior;
    }
}
