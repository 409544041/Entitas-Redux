public partial class Test2Entity
{
	public EntitasRedux.Tests.MultipleContextStandardEventComponent MultipleContextStandardEvent { get { return (EntitasRedux.Tests.MultipleContextStandardEventComponent)GetComponent(Test2ComponentsLookup.MultipleContextStandardEvent); } }
	public bool HasMultipleContextStandardEvent { get { return HasComponent(Test2ComponentsLookup.MultipleContextStandardEvent); } }

	public void AddMultipleContextStandardEvent(string newValue)
	{
		var index = Test2ComponentsLookup.MultipleContextStandardEvent;
		var component = (EntitasRedux.Tests.MultipleContextStandardEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.MultipleContextStandardEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMultipleContextStandardEvent(string newValue)
	{
		var index = Test2ComponentsLookup.MultipleContextStandardEvent;
		var component = (EntitasRedux.Tests.MultipleContextStandardEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.MultipleContextStandardEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMultipleContextStandardEventTo(EntitasRedux.Tests.MultipleContextStandardEventComponent copyComponent)
	{
		var index = Test2ComponentsLookup.MultipleContextStandardEvent;
		var component = (EntitasRedux.Tests.MultipleContextStandardEventComponent)CreateComponent(index, typeof(EntitasRedux.Tests.MultipleContextStandardEventComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMultipleContextStandardEvent()
	{
		RemoveComponent(Test2ComponentsLookup.MultipleContextStandardEvent);
	}
}

public partial class Test2Entity : IMultipleContextStandardEventEntity { }

public sealed partial class Test2Matcher
{
	static JCMG.EntitasRedux.IMatcher<Test2Entity> _matcherMultipleContextStandardEvent;

	public static JCMG.EntitasRedux.IMatcher<Test2Entity> MultipleContextStandardEvent
	{
		get
		{
			if (_matcherMultipleContextStandardEvent == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<Test2Entity>)JCMG.EntitasRedux.Matcher<Test2Entity>.AllOf(Test2ComponentsLookup.MultipleContextStandardEvent);
				matcher.ComponentNames = Test2ComponentsLookup.ComponentNames;
				_matcherMultipleContextStandardEvent = matcher;
			}

			return _matcherMultipleContextStandardEvent;
		}
	}
}
