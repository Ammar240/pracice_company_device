namespace IEnumerableProject;

internal partial class Program
{
    internal class Temperature:IComparable
    {
        private int _value;
        public Temperature(int value)
        {
            _value = value;
        }
        public int Value => _value;

        public int CompareTo(object? obj)
        {
            if (obj is null)
                return 1;
            Temperature otherTemp = obj as Temperature;
            if (otherTemp is null)
                throw new ArgumentException("object is not a Temperature");
            return _value.CompareTo(otherTemp._value);
        }
    }
}
