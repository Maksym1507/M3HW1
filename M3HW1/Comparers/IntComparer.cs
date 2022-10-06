namespace M3HW1.Comparers
{
    public class IntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else
            {
                return x - y > 0 ? 1 : -1;
            }
        }
    }
}
