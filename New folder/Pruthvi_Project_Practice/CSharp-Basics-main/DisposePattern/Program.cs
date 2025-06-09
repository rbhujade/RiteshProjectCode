// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class DisposeDemo : IDisposable
{
    private bool _disposed;
    ~ DisposeDemo() => Dispose(false);
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }
            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _disposed = true;
        }
    }
}

public class Derived : DisposeDemo
{
    private bool _disposed;
    ~Derived() => Dispose(false);   

    protected override void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
            }
            // TODO: free unmanaged resourcefs (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            _disposed = true;
        }
        base.Dispose(disposing);
    }
}

