public partial class GameEntity
{
	static readonly EntitasRedux.Tests.GeneratedContextComponent GeneratedContextComponent = new EntitasRedux.Tests.GeneratedContextComponent();

	public bool IsGeneratedContext
	{
		get { return HasComponent(GameComponentsLookup.GeneratedContext); }
		set
		{
			if (value != IsGeneratedContext)
			{
				var index = GameComponentsLookup.GeneratedContext;
				if (value)
				{
					var componentPool = GetComponentPool(index);
					var component = componentPool.Count > 0
							? componentPool.Pop()
							: GeneratedContextComponent;

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

public sealed partial class GameMatcher
{
	static JCMG.EntitasRedux.IMatcher<GameEntity> _matcherGeneratedContext;

	public static JCMG.EntitasRedux.IMatcher<GameEntity> GeneratedContext
	{
		get
		{
			if (_matcherGeneratedContext == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<GameEntity>)JCMG.EntitasRedux.Matcher<GameEntity>.AllOf(GameComponentsLookup.GeneratedContext);
				matcher.ComponentNames = GameComponentsLookup.ComponentNames;
				_matcherGeneratedContext = matcher;
			}

			return _matcherGeneratedContext;
		}
	}
}
