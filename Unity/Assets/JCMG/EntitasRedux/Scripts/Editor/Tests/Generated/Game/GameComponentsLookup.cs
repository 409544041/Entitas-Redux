using System;
using System.Collections.Generic;
using JCMG.EntitasRedux;

public static class GameComponentsLookup
{
	public const int CleanupEventAddedListener = 0;
	public const int CleanupEvent = 1;
	public const int GeneratedContext = 2;

	public const int TotalComponents = 3;

	public static readonly string[] ComponentNames =
	{
		"CleanupEventAddedListener",
		"CleanupEvent",
		"GeneratedContext"
	};

	public static readonly System.Type[] ComponentTypes =
	{
		typeof(CleanupEventAddedListenerComponent),
		typeof(EntitasRedux.Tests.CleanupEventComponent),
		typeof(EntitasRedux.Tests.GeneratedContextComponent)
	};

	public static readonly Dictionary<Type, int> ComponentTypeToIndex = new Dictionary<Type, int>
	{
		{ typeof(CleanupEventAddedListenerComponent), 0 },
		{ typeof(EntitasRedux.Tests.CleanupEventComponent), 1 },
		{ typeof(EntitasRedux.Tests.GeneratedContextComponent), 2 }
	};

	/// <summary>
	/// Returns a component index based on the passed <paramref name="component"/> type; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="component"></param>
	public static int GetComponentIndex(IComponent component)
	{
		return GetComponentIndex(component.GetType());
	}

	/// <summary>
	/// Returns a component index based on the passed <paramref name="componentType"/>; where an index cannot be found
	/// -1 will be returned instead.
	/// </summary>
	/// <param name="componentType"></param>
	public static int GetComponentIndex(Type componentType)
	{
		return ComponentTypeToIndex.TryGetValue(componentType, out var index) ? index : -1;
	}
}
