using System;

namespace Task1
{
    class Block
    {
        private int side1;
        private int side2;
        private int side3;
        private int side4;

        public Block(int side1, int side2, int side3, int side4)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            this.side4 = side4;
        }

        public override bool Equals(object objBlock)
        {
            Block block = objBlock as Block;
            if (side1 == block.side1 && side2 == block.side2 && side3 == block.side3 && side4 == block.side4)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("side1:{0}, side2:{1}, side3:{2}, side4:{3}", side1, side2, side3, side4);
        }
    }
}
