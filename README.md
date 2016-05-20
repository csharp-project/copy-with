
## Copy With

Simple clone and update object.

```csharp
using CopyWith;

public class Model : ICloneable {
	public string A { set; get; }
	public string B { set; get; }
    public string C { set; get; }
	public object Clone () {
		return this.MemberwiseClone ();
	}
}

var model = new Model { A = "A", B = "B", C = "C" };
var newModel = model.With (x => x.A = "NewA").With (x => x.B = "NewB");
```

## Link

- http://v2matveev.blogspot.co.uk/2010/05/copy-and-update-in-c.html
- https://gist.github.com/freestylecoder/50493ce7369f58e9555f0583dfa07077
