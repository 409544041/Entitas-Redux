public partial class MyTestEntity
{
	public EntitasRedux.Tests.InheritedComponent Inherited { get { return (EntitasRedux.Tests.InheritedComponent)GetComponent(MyTestComponentsLookup.Inherited); } }
	public bool HasInherited { get { return HasComponent(MyTestComponentsLookup.Inherited); } }

	public void AddInherited(float newValue)
	{
		var index = MyTestComponentsLookup.Inherited;
		var component = (EntitasRedux.Tests.InheritedComponent)CreateComponent(index, typeof(EntitasRedux.Tests.InheritedComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceInherited(float newValue)
	{
		var index = MyTestComponentsLookup.Inherited;
		var component = (EntitasRedux.Tests.InheritedComponent)CreateComponent(index, typeof(EntitasRedux.Tests.InheritedComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyInheritedTo(EntitasRedux.Tests.InheritedComponent copyComponent)
	{
		var index = MyTestComponentsLookup.Inherited;
		var component = (EntitasRedux.Tests.InheritedComponent)CreateComponent(index, typeof(EntitasRedux.Tests.InheritedComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveInherited()
	{
		RemoveComponent(MyTestComponentsLookup.Inherited);
	}
}

public sealed partial class MyTestMatcher
{
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherInherited;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> Inherited
	{
		get
		{
			if (_matcherInherited == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.Inherited);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherInherited = matcher;
			}

			return _matcherInherited;
		}
	}
}
