using System;
using System.Linq;
using System.Reflection;

public static partial class LoadToken
{
    public const BindingFlags AllMembers = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance;

    public static MethodInfo ForMethod(Delegate method)
        => method.Method;

    [Obsolete]
    public static PropertyInfo ForPropertyGetter(MethodInfo method)
        =>  method.DeclaringType.GetProperties(AllMembers).Single(p => p.GetGetMethod(true) == method);
    [Obsolete]
    public static PropertyInfo ForPropertySetter(MethodInfo method)
        =>  method.DeclaringType.GetProperties(AllMembers).Single(p => p.GetSetMethod(true) == method);

    [Obsolete]
    public static PropertyInfo ForProperty<T>(Func<T> getter)
        =>  ForPropertyGetter(getter.Method);
    [Obsolete]
    public static PropertyInfo ForProperty<T>(Action<T> setter)
        =>  ForPropertySetter(setter.Method);
}
