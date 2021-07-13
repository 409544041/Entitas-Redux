public partial class TestContext {

	public TestEntity UniqueMyNamespaceEntity { get { return GetGroup(TestMatcher.UniqueMyNamespace).GetSingleEntity(); } }
	public EntitasRedux.Tests.UniqueMyNamespaceComponent UniqueMyNamespace { get { return UniqueMyNamespaceEntity.UniqueMyNamespace; } }
	public bool HasUniqueMyNamespace { get { return UniqueMyNamespaceEntity != null; } }

	public TestEntity SetUniqueMyNamespace(string newValue)
	{
		if (HasUniqueMyNamespace)
		{
			throw new JCMG.EntitasRedux.EntitasReduxException(
				"Could not set UniqueMyNamespace!\n" +
				this +
				" already has an entity with EntitasRedux.Tests.UniqueMyNamespaceComponent!",
				"You should check if the context already has a UniqueMyNamespaceEntity before setting it or use context.ReplaceUniqueMyNamespace().");
		}
		var entity = CreateEntity();
		#if !ENTITAS_REDUX_NO_IMPL
		entity.AddUniqueMyNamespace(newValue);
		#endif
		return entity;
	}

	public void ReplaceUniqueMyNamespace(string newValue)
	{
		#if !ENTITAS_REDUX_NO_IMPL
		var entity = UniqueMyNamespaceEntity;
		if (entity == null)
		{
			entity = SetUniqueMyNamespace(newValue);
		}
		else
		{
			entity.ReplaceUniqueMyNamespace(newValue);
		}
		#endif
	}

	public void RemoveUniqueMyNamespace()
	{
		UniqueMyNamespaceEntity.Destroy();
	}
}

public partial class TestEntity
{
	public EntitasRedux.Tests.UniqueMyNamespaceComponent UniqueMyNamespace { get { return (EntitasRedux.Tests.UniqueMyNamespaceComponent)GetComponent(TestComponentsLookup.UniqueMyNamespace); } }
	public bool HasUniqueMyNamespace { get { return HasComponent(TestComponentsLookup.UniqueMyNamespace); } }

	public void AddUniqueMyNamespace(string newValue)
	{
		var index = TestComponentsLookup.UniqueMyNamespace;
		var component = (EntitasRedux.Tests.UniqueMyNamespaceComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueMyNamespaceComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceUniqueMyNamespace(string newValue)
	{
		var index = TestComponentsLookup.UniqueMyNamespace;
		var component = (EntitasRedux.Tests.UniqueMyNamespaceComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueMyNamespaceComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = newValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyUniqueMyNamespaceTo(EntitasRedux.Tests.UniqueMyNamespaceComponent copyComponent)
	{
		var index = TestComponentsLookup.UniqueMyNamespace;
		var component = (EntitasRedux.Tests.UniqueMyNamespaceComponent)CreateComponent(index, typeof(EntitasRedux.Tests.UniqueMyNamespaceComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.value = copyComponent.value;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveUniqueMyNamespace()
	{
		RemoveComponent(TestComponentsLookup.UniqueMyNamespace);
	}
}

public sealed partial class TestMatcher
{
	static JCMG.EntitasRedux.IMatcher<TestEntity> _matcherUniqueMyNamespace;

	public static JCMG.EntitasRedux.IMatcher<TestEntity> UniqueMyNamespace
	{
		get
		{
			if (_matcherUniqueMyNamespace == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<TestEntity>)JCMG.EntitasRedux.Matcher<TestEntity>.AllOf(TestComponentsLookup.UniqueMyNamespace);
				matcher.ComponentNames = TestComponentsLookup.ComponentNames;
				_matcherUniqueMyNamespace = matcher;
			}

			return _matcherUniqueMyNamespace;
		}
	}
}
