namespace _2Task
{
    internal class Block
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public Block(int side1, int side2, int side3, int side4)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            Side4 = side4;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Block block = (Block)obj;
            return (Side1 == block.Side1) && (Side2 == block.Side2) && (Side3 == block.Side3) && (Side4 == block.Side4);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Side1, Side2, Side3, Side4);
        }

        public override string ToString()
        {
            return $"Block: Side1 = {Side1}, Side2 = {Side2}, Side3 = {Side3}, Side4 = {Side4}";
        }
    }
}
