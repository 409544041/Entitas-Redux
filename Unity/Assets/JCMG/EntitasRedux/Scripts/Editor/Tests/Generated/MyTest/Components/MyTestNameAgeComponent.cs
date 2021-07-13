public partial class MyTestEntity
{
	public EntitasRedux.Tests.NameAgeComponent NameAge { get { return (EntitasRedux.Tests.NameAgeComponent)GetComponent(MyTestComponentsLookup.NameAge); } }
	public bool HasNameAge { get { return HasComponent(MyTestComponentsLookup.NameAge); } }

	public void AddNameAge(string newName, int newAge)
	{
		var index = MyTestComponentsLookup.NameAge;
		var component = (EntitasRedux.Tests.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.NameAgeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.name = newName;
		component.age = newAge;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceNameAge(string newName, int newAge)
	{
		var index = MyTestComponentsLookup.NameAge;
		var component = (EntitasRedux.Tests.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.NameAgeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.name = newName;
		component.age = newAge;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyNameAgeTo(EntitasRedux.Tests.NameAgeComponent copyComponent)
	{
		var index = MyTestComponentsLookup.NameAge;
		var component = (EntitasRedux.Tests.NameAgeComponent)CreateComponent(index, typeof(EntitasRedux.Tests.NameAgeComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.name = copyComponent.name;
		component.age = copyComponent.age;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveNameAge()
	{
		RemoveComponent(MyTestComponentsLookup.NameAge);
	}
}

public partial class MyTestEntity : INameAgeEntity { }

public sealed partial class MyTestMatcher
{
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherNameAge;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> NameAge
	{
		get
		{
			if (_matcherNameAge == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.NameAge);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherNameAge = matcher;
			}

			return _matcherNameAge;
		}
	}
}
