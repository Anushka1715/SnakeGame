//class to show position in the grid

namespace SnakeGame
{
    public class Position
    {
        public int Row { get; }
        public int Col { get; }

        public Position(int row, int col)
        {
            Row = row;
            Col = col;
        }

        //the method translate will take the direction and change the position of the snake withrespect to current position
        public Position Translate(Directions direction)
        {
            return new Position(Row + direction.RowOffset, Col + direction.ColOffset);
        }

        //just like directions we will override equals and get hashcode
        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   Row == position.Row &&
                   Col == position.Col;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Col);
        }

        public static bool operator ==(Position left, Position right)
        {
            return EqualityComparer<Position>.Default.Equals(left, right);
        }

        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }


    }
}
