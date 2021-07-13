public partial class VisualDebugEntity
{
	public AnyMyEventAddedListenerComponent AnyMyEventAddedListener { get { return (AnyMyEventAddedListenerComponent)GetComponent(VisualDebugComponentsLookup.AnyMyEventAddedListener); } }
	public bool HasAnyMyEventAddedListener { get { return HasComponent(VisualDebugComponentsLookup.AnyMyEventAddedListener); } }

	public void AddAnyMyEventAddedListener(System.Collections.Generic.List<IAnyMyEventAddedListener> newValue)
	{
		var index = VisualDebugComponentsLookup.AnyMyEventAddedListener;
		var component = (AnyMyEventAddedListenerComponent)CreateComponent(index, typeof(AnyMyEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceAnyMyEventAddedListener(System.Collections.Generic.List<IAnyMyEventAddedListener> newValue)
	{
		var index = VisualDebugComponentsLookup.AnyMyEventAddedListener;
		var component = (AnyMyEventAddedListenerComponent)CreateComponent(index, typeof(AnyMyEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyAnyMyEventAddedListenerTo(AnyMyEventAddedListenerComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.AnyMyEventAddedListener;
		var component = (AnyMyEventAddedListenerComponent)CreateComponent(index, typeof(AnyMyEventAddedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveAnyMyEventAddedListener()
	{
		RemoveComponent(VisualDebugComponentsLookup.AnyMyEventAddedListener);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherAnyMyEventAddedListener;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> AnyMyEventAddedListener
	{
		get
		{
			if (_matcherAnyMyEventAddedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.AnyMyEventAddedListener);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherAnyMyEventAddedListener = matcher;
			}

			return _matcherAnyMyEventAddedListener;
		}
	}
}

public partial class VisualDebugEntity
{
	public void AddAnyMyEventAddedListener(IAnyMyEventAddedListener value)
	{
		var listeners = HasAnyMyEventAddedListener
			? AnyMyEventAddedListener.value
			: new System.Collections.Generic.List<IAnyMyEventAddedListener>();
		listeners.Add(value);
		ReplaceAnyMyEventAddedListener(listeners);
	}

	public void RemoveAnyMyEventAddedListener(IAnyMyEventAddedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = AnyMyEventAddedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveAnyMyEventAddedListener();
		}
		else
		{
			ReplaceAnyMyEventAddedListener(listeners);
		}
	}
}
