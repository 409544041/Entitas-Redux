public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.ListComponent List { get { return (ExampleContent.VisualDebugging.ListComponent)GetComponent(VisualDebugComponentsLookup.List); } }
	public bool HasList { get { return HasComponent(VisualDebugComponentsLookup.List); } }

	public void AddList(System.Collections.Generic.List<string> newList)
	{
		var index = VisualDebugComponentsLookup.List;
		var component = (ExampleContent.VisualDebugging.ListComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.ListComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.list = newList;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceList(System.Collections.Generic.List<string> newList)
	{
		var index = VisualDebugComponentsLookup.List;
		var component = (ExampleContent.VisualDebugging.ListComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.ListComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.list = newList;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyListTo(ExampleContent.VisualDebugging.ListComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.List;
		var component = (ExampleContent.VisualDebugging.ListComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.ListComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.list = (System.Collections.Generic.List<string>)JCMG.EntitasRedux.ListTools.DeepCopy(copyComponent.list);
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveList()
	{
		RemoveComponent(VisualDebugComponentsLookup.List);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherList;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> List
	{
		get
		{
			if (_matcherList == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.List);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherList = matcher;
			}

			return _matcherList;
		}
	}
}
