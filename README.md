[![Build Status](https://kyleherzog.visualstudio.com/RxDisposableExtensions/_apis/build/status/RxDisposableExtensions?branchName=develop)](https://kyleherzog.visualstudio.com/RxDisposableExtensions/_build/latest?definitionId=2?branchName=develop)

This library is available from [NuGet.org](https://www.nuget.org/packages/RxDisposableExtensions/).

--------------------------

A light weight .NET Standard library that provides a `DisposeWith` extension method to `IDisposable` objects.  This is an alternative to the method provided by ReativeUI, allowing for a much smaller library dependency.

See the [changelog](CHANGELOG.md) for changes and roadmap.

## Features

### DisposeWith
An extension method for `IDisposable` objects that will add the object to the given `CompositeDisposable` specified.
```c#
public class MyClass
{
    private readonly CompositeDisposable cd = new CompositeDisposable();

    public MyClass() 
    {
        Observable.FromEventPattern<PropertyChangedEventHandler, PropertyChangedEventArgs>(
                x => response.PropertyChanged += x,
                x => response.PropertyChanged -= x)
                .Where(x => x.EventArgs.PropertyName == nameof(MyProperty))
                .Subscribe(_ => DoSomething())
                .DisposeWith(cd);
    }
}
```


## License
[MIT](LICENSE)