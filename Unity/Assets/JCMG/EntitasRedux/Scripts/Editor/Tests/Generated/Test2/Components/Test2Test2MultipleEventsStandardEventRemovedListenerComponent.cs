public partial class Test2Entity
{
	public Test2MultipleEventsStandardEventRemovedListenerComponent Test2MultipleEventsStandardEventRemovedListener { get { return (Test2MultipleEventsStandardEventRemovedListenerComponent)GetComponent(Test2ComponentsLookup.Test2MultipleEventsStandardEventRemovedListener); } }
	public bool HasTest2MultipleEventsStandardEventRemovedListener { get { return HasComponent(Test2ComponentsLookup.Test2MultipleEventsStandardEventRemovedListener); } }

	public void AddTest2MultipleEventsStandardEventRemovedListener(System.Collections.Generic.List<ITest2MultipleEventsStandardEventRemovedListener> newValue)
	{
		var index = Test2ComponentsLookup.Test2MultipleEventsStandardEventRemovedListener;
		var component = (Test2MultipleEventsStandardEventRemovedListenerComponent)CreateComponent(index, typeof(Test2MultipleEventsStandardEventRemovedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceTest2MultipleEventsStandardEventRemovedListener(System.Collections.Generic.List<ITest2MultipleEventsStandardEventRemovedListener> newValue)
	{
		var index = Test2ComponentsLookup.Test2MultipleEventsStandardEventRemovedListener;
		var component = (Test2MultipleEventsStandardEventRemovedListenerComponent)CreateComponent(index, typeof(Test2MultipleEventsStandardEventRemovedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyTest2MultipleEventsStandardEventRemovedListenerTo(Test2MultipleEventsStandardEventRemovedListenerComponent copyComponent)
	{
		var index = Test2ComponentsLookup.Test2MultipleEventsStandardEventRemovedListener;
		var component = (Test2MultipleEventsStandardEventRemovedListenerComponent)CreateComponent(index, typeof(Test2MultipleEventsStandardEventRemovedListenerComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveTest2MultipleEventsStandardEventRemovedListener()
	{
		RemoveComponent(Test2ComponentsLookup.Test2MultipleEventsStandardEventRemovedListener);
	}
}

public sealed partial class Test2Matcher
{
	static JCMG.EntitasRedux.IMatcher<Test2Entity> _matcherTest2MultipleEventsStandardEventRemovedListener;

	public static JCMG.EntitasRedux.IMatcher<Test2Entity> Test2MultipleEventsStandardEventRemovedListener
	{
		get
		{
			if (_matcherTest2MultipleEventsStandardEventRemovedListener == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<Test2Entity>)JCMG.EntitasRedux.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.Test2MultipleEventsStandardEventRemovedListener);
				matcher.ComponentNames = Test2ComponentsLookup.ComponentNames;
				_matcherTest2MultipleEventsStandardEventRemovedListener = matcher;
			}

			return _matcherTest2MultipleEventsStandardEventRemovedListener;
		}
	}
}

public partial class Test2Entity
{
	public void AddTest2MultipleEventsStandardEventRemovedListener(ITest2MultipleEventsStandardEventRemovedListener value)
	{
		var listeners = HasTest2MultipleEventsStandardEventRemovedListener
			? Test2MultipleEventsStandardEventRemovedListener.value
			: new System.Collections.Generic.List<ITest2MultipleEventsStandardEventRemovedListener>();
		listeners.Add(value);
		ReplaceTest2MultipleEventsStandardEventRemovedListener(listeners);
	}

	public void RemoveTest2MultipleEventsStandardEventRemovedListener(ITest2MultipleEventsStandardEventRemovedListener value, bool removeComponentWhenEmpty = true)
	{
		var listeners = Test2MultipleEventsStandardEventRemovedListener.value;
		listeners.Remove(value);
		if (removeComponentWhenEmpty && listeners.Count == 0)
		{
			RemoveTest2MultipleEventsStandardEventRemovedListener();
		}
		else
		{
			ReplaceTest2MultipleEventsStandardEventRemovedListener(listeners);
		}
	}
}
