public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.MyFlagsComponent MyFlags { get { return (ExampleContent.VisualDebugging.MyFlagsComponent)GetComponent(VisualDebugComponentsLookup.MyFlags); } }
	public bool HasMyFlags { get { return HasComponent(VisualDebugComponentsLookup.MyFlags); } }

	public void AddMyFlags(ExampleContent.VisualDebugging.MyFlagsComponent.MyFlags newMyFlags)
	{
		var index = VisualDebugComponentsLookup.MyFlags;
		var component = (ExampleContent.VisualDebugging.MyFlagsComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyFlagsComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myFlags = newMyFlags;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceMyFlags(ExampleContent.VisualDebugging.MyFlagsComponent.MyFlags newMyFlags)
	{
		var index = VisualDebugComponentsLookup.MyFlags;
		var component = (ExampleContent.VisualDebugging.MyFlagsComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyFlagsComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myFlags = newMyFlags;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyMyFlagsTo(ExampleContent.VisualDebugging.MyFlagsComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.MyFlags;
		var component = (ExampleContent.VisualDebugging.MyFlagsComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.MyFlagsComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.myFlags = copyComponent.myFlags;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveMyFlags()
	{
		RemoveComponent(VisualDebugComponentsLookup.MyFlags);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherMyFlags;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> MyFlags
	{
		get
		{
			if (_matcherMyFlags == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.MyFlags);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherMyFlags = matcher;
			}

			return _matcherMyFlags;
		}
	}
}
