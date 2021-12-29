namespace Units.Logical;

public static class LogicalGate
{
    public static bool And(bool a, bool b)
    {
        if (a != true) return false;
        return b == true;
    }
}
