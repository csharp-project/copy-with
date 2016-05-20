using System;
namespace CopyWith {
	public static class Extensions {
		public static T With<T>(this T data, Action<T> modifier) where T : ICloneable {
			var newData = (T) data.Clone();
			modifier(newData);
			return newData;
		}
	}
}

