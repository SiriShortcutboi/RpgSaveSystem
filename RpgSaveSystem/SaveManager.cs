using System;
using System.IO;
public static class SaveManager
{
	public static void Save(ISaveable entity)
	{
	}

	public static T Load<T>(string path)
	{
		return default(T)!;
	}
}