public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.Texture2DComponent Texture2D { get { return (ExampleContent.VisualDebugging.Texture2DComponent)GetComponent(VisualDebugComponentsLookup.Texture2D); } }
	public bool HasTexture2D { get { return HasComponent(VisualDebugComponentsLookup.Texture2D); } }

	public void AddTexture2D(UnityEngine.Texture2D newTexture2D)
	{
		var index = VisualDebugComponentsLookup.Texture2D;
		var component = (ExampleContent.VisualDebugging.Texture2DComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Texture2DComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.texture2D = newTexture2D;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceTexture2D(UnityEngine.Texture2D newTexture2D)
	{
		var index = VisualDebugComponentsLookup.Texture2D;
		var component = (ExampleContent.VisualDebugging.Texture2DComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Texture2DComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.texture2D = newTexture2D;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyTexture2DTo(ExampleContent.VisualDebugging.Texture2DComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.Texture2D;
		var component = (ExampleContent.VisualDebugging.Texture2DComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.Texture2DComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.texture2D = copyComponent.texture2D;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveTexture2D()
	{
		RemoveComponent(VisualDebugComponentsLookup.Texture2D);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherTexture2D;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> Texture2D
	{
		get
		{
			if (_matcherTexture2D == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.Texture2D);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherTexture2D = matcher;
			}

			return _matcherTexture2D;
		}
	}
}
