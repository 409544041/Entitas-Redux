public partial class TestEntity
{
	public InterfaceToGenerateComponent InterfaceToGenerate { get { return (InterfaceToGenerateComponent)GetComponent(TestComponentsLookup.InterfaceToGenerate); } }
	public bool HasInterfaceToGenerate { get { return HasComponent(TestComponentsLookup.InterfaceToGenerate); } }

	public void AddInterfaceToGenerate(EntitasRedux.Tests.InterfaceToGenerate newValue)
	{
		var index = TestComponentsLookup.InterfaceToGenerate;
		var component = (InterfaceToGenerateComponent)CreateComponent(index, typeof(InterfaceToGenerateComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceInterfaceToGenerate(EntitasRedux.Tests.InterfaceToGenerate newValue)
	{
		var index = TestComponentsLookup.InterfaceToGenerate;
		var component = (InterfaceToGenerateComponent)CreateComponent(index, typeof(InterfaceToGenerateComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyInterfaceToGenerateTo(InterfaceToGenerateComponent copyComponent)
	{
		var index = TestComponentsLookup.InterfaceToGenerate;
		var component = (InterfaceToGenerateComponent)CreateComponent(index, typeof(InterfaceToGenerateComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveInterfaceToGenerate()
	{
		RemoveComponent(TestComponentsLookup.InterfaceToGenerate);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherInterfaceToGenerate;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> InterfaceToGenerate
	{
		get
		{
			if (_matcherInterfaceToGenerate == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.InterfaceToGenerate);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherInterfaceToGenerate = matcher;
			}

			return _matcherInterfaceToGenerate;
		}
	}
}
