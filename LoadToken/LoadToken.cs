using System;
using System.Reflection;

public static partial class LoadToken
{
    public static MethodInfo ForMethod(Delegate method)
    {
#if LoadTokenEx
        throw new NotImplementedException();
#else
        return method.Method;
#endif
    }
}
