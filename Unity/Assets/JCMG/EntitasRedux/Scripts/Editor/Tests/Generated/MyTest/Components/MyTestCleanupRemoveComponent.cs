public partial class MyTestEntity
{
	static readonly EntitasRedux.Tests.CleanupRemoveComponent CleanupRemoveComponent = new EntitasRedux.Tests.CleanupRemoveComponent();

	public bool IsCleanupRemove
	{
		get { return HasComponent(MyTestComponentsLookup.CleanupRemove); }
		set
		{
			if (value != IsCleanupRemove)
			{
				var index = MyTestComponentsLookup.CleanupRemove;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: CleanupRemoveComponent;

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
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherCleanupRemove;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> CleanupRemove
	{
		get
		{
			if (_matcherCleanupRemove == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.CleanupRemove);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherCleanupRemove = matcher;
			}

			return _matcherCleanupRemove;
		}
	}
}
