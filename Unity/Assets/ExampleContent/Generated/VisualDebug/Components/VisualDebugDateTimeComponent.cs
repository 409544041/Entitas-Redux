public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.DateTimeComponent DateTime { get { return (ExampleContent.VisualDebugging.DateTimeComponent)GetComponent(VisualDebugComponentsLookup.DateTime); } }
	public bool HasDateTime { get { return HasComponent(VisualDebugComponentsLookup.DateTime); } }

	public void AddDateTime(System.DateTime newDate)
	{
		var index = VisualDebugComponentsLookup.DateTime;
		var component = (ExampleContent.VisualDebugging.DateTimeComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DateTimeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.date = newDate;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceDateTime(System.DateTime newDate)
	{
		var index = VisualDebugComponentsLookup.DateTime;
		var component = (ExampleContent.VisualDebugging.DateTimeComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DateTimeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.date = newDate;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyDateTimeTo(ExampleContent.VisualDebugging.DateTimeComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.DateTime;
		var component = (ExampleContent.VisualDebugging.DateTimeComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DateTimeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.date = copyComponent.date;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveDateTime()
	{
		RemoveComponent(VisualDebugComponentsLookup.DateTime);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherDateTime;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> DateTime
	{
		get
		{
			if (_matcherDateTime == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.DateTime);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherDateTime = matcher;
			}

			return _matcherDateTime;
		}
	}
}
