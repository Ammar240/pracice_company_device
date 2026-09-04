using System.Collections;

namespace IEnumerableProject;

internal class FiveIntergers : IEnumerable
{
    int[] _values;
    public FiveIntergers(int n1, int n2, int n3, int n4, int n5)
    {
        _values = new int[] { n1, n2, n3, n4, n5 };
    }

    public IEnumerator GetEnumerator()
    {

        //return new Enumerator(this); // I make state machine (Enumerator manually)

        foreach (var item in _values)
        {
            yield return item; // yield -> makes state machine(Enumerator) Emplicitly 
        }
    }

    #region Custom Enumerator
    //class Enumerator : IEnumerator
    //{
    //    int _currentIndex = -1;
    //    FiveIntergers _intergers;
    //    public Enumerator(FiveIntergers intergers)
    //    {
    //        _intergers = intergers;
    //    }

    //    public object Current
    //    {
    //        get
    //        {
    //            if (_currentIndex == -1)
    //                throw new InvalidOperationException("Enumeration not started");
    //            if (_currentIndex == _intergers._values.Length)
    //                throw new InvalidOperationException("Enumeration has ended");
    //            return _intergers._values[_currentIndex];
    //        }
    //    }

    //    public bool MoveNext()
    //    {
    //        if (_currentIndex >= _intergers._values.Length - 1)
    //            return false;
    //        return ++_currentIndex < _intergers._values.Length;
    //    }

    //    public void Reset()
    //    {
    //        _currentIndex = -1;
    //    }
    //}
    #endregion
}
