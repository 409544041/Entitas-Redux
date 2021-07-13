public partial class MyTestEntity
{
	static readonly EntitasRedux.Tests.ComponentB ComponentBComponent = new EntitasRedux.Tests.ComponentB();

	public bool IsComponentB
	{
		get { return HasComponent(MyTestComponentsLookup.ComponentB); }
		set
		{
			if (value != IsComponentB)
			{
				var index = MyTestComponentsLookup.ComponentB;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: ComponentBComponent;

					AddComponent(index, component);
				}
				else
				{
					RemoveComponent(index);
				}
			}
		}
	}
}

public sealed partial class MyTestMatcher
{
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherComponentB;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> ComponentB
	{
		get
		{
			if (_matcherComponentB == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.ComponentB);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherComponentB = matcher;
			}

			return _matcherComponentB;
		}
	}
}
