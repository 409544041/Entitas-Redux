public partial class TestEntity
{
	public EntitasRedux.Tests.BaseComponent Base { get { return (EntitasRedux.Tests.BaseComponent)GetComponent(TestComponentsLookup.Base); } }
	public bool HasBase { get { return HasComponent(TestComponentsLookup.Base); } }

	public void AddBase(int newValue)
	{
		var index = TestComponentsLookup.Base;
		var component = (EntitasRedux.Tests.BaseComponent)CreateComponent(index, typeof(EntitasRedux.Tests.BaseComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceBase(int newValue)
	{
		var index = TestComponentsLookup.Base;
		var component = (EntitasRedux.Tests.BaseComponent)CreateComponent(index, typeof(EntitasRedux.Tests.BaseComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyBaseTo(EntitasRedux.Tests.BaseComponent copyComponent)
	{
		var index = TestComponentsLookup.Base;
		var component = (EntitasRedux.Tests.BaseComponent)CreateComponent(index, typeof(EntitasRedux.Tests.BaseComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveBase()
	{
		RemoveComponent(TestComponentsLookup.Base);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherBase;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> Base
	{
		get
		{
			if (_matcherBase == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.Base);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherBase = matcher;
			}

			return _matcherBase;
		}
	}
}
