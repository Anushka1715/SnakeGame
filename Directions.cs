using System.Net.NetworkInformation;

namespace SnakeGame
{
    public class Directions
    {
        public readonly static Directions Left = new Directions(0, -1);
        public readonly static Directions Right = new Directions(0, 1);
        public readonly static Directions Up = new Directions(-1, 0);
        public readonly static Directions Down = new Directions(1, 0);
        public int RowOffset { get;}
        public int ColOffset { get; }

        //private constructor so no other class can create the instance of the directions class
        private Directions(int rowOffset, int colOffset)
        {
            RowOffset = rowOffset;
            ColOffset = colOffset;  
        }

        public Directions Opposite()
        {
            return new Directions(-RowOffset, -ColOffset);
        }

        //overriding equals and get hashcode so directions class can be used as a key in a dictionary
        public override bool Equals(object obj)
        {
            return obj is Directions directions &&
                   RowOffset == directions.RowOffset &&
                   ColOffset == directions.ColOffset;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(RowOffset, ColOffset);
        }

        public static bool operator ==(Directions left, Directions right)
        {
            return EqualityComparer<Directions>.Default.Equals(left, right);
        }

        public static bool operator !=(Directions left, Directions right)
        {
            return !(left == right);
        }
    }
}
