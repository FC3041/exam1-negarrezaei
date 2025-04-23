namespace Exam1;
using System;
public class Q8StringLengthComparer : IComparer<string>
{

    public int Compare(string? x, string? y)
    {
        if(x == null && y != null)
            return -1;
        if(x != null && y == null)
            return 1;
        if(x == null && y == null)
            return 0;

        if(x.Length == y.Length)
            return x.CompareTo(y);
        
        return x.Length.CompareTo(y.Length);
    }

}


public class Q8ComparableString
{
    public string String { get; set; }

    public Q8ComparableString(string s)
    {
        this.String = s;
    }

    public static bool operator< (Q8ComparableString a, Q8ComparableString b)
    {
        if(a.String == null && b.String != null)
            return true;
        if(a.String != null && b.String == null)
            return false;
        
        if(a.String.Length < b.String.Length)
            return true;
        if(a.String.CompareTo(b.String) < 0)
            return true;
        return false;
    }
    public static bool operator> (Q8ComparableString a, Q8ComparableString b) => !(a < b);


    public static bool operator== (Q8ComparableString a, Q8ComparableString b)
    {
        if(a.String == null && b.String == null)
            return true;
        if(a.String == b.String)
            return true;
        return false;
    }
    public static bool operator!= (Q8ComparableString a, Q8ComparableString b) => !(a == b);
}