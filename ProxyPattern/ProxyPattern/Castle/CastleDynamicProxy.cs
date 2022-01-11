using Castle.DynamicProxy;

namespace ProxyPattern.Castle;

public class MyInterceptorAspect : IInterceptor
{
    public void Intercept(IInvocation invocation)
    {
        var methodName = invocation.Method.Name;
        Console.WriteLine($"Loading...");
       invocation.Proceed();
       
    }
}

public class CastleDynamicProxy
{
    public virtual async void  DoStuff()
    {
       await Task.Delay(4000);
        Console.WriteLine("Download success");
    }
}

public class MyOtherClass
{
    public virtual void DoOtherStuff()
    {
        Console.WriteLine("Inside of DoOtherStuff()");
    }
}

public static class CastleDynamicProxyTest
{
    public static void Test()
    {
        var generator = new ProxyGenerator();
        var myObject = generator.CreateClassProxy<CastleDynamicProxy>(new MyInterceptorAspect());
      //  var myOtherObject = generator.CreateClassProxy<MyOtherClass>(new MyInterceptorAspect());

        myObject.DoStuff();
        Console.WriteLine();
      //  myOtherObject.DoOtherStuff();
    }
}