public partial class MyTestEntity
{
	public EntitasRedux.Tests.ShallowCopyComponent ShallowCopy { get { return (EntitasRedux.Tests.ShallowCopyComponent)GetComponent(MyTestComponentsLookup.ShallowCopy); } }
	public bool HasShallowCopy { get { return HasComponent(MyTestComponentsLookup.ShallowCopy); } }

	public void AddShallowCopy(int newIntValue, string newStrValue, UnityEngine.Vector2 newVector2Value, EntitasRedux.Tests.TestScriptableObject newTestScriptableObject, System.Collections.Generic.Dictionary<int, EntitasRedux.Tests.TestScriptableObject> newDictValue, System.Collections.Generic.List<EntitasRedux.Tests.TestScriptableObject> newListValue, System.Collections.Generic.IList<EntitasRedux.Tests.TestScriptableObject> newIListValue)
	{
		var index = MyTestComponentsLookup.ShallowCopy;
		var component = (EntitasRedux.Tests.ShallowCopyComponent)CreateComponent(index, typeof(EntitasRedux.Tests.ShallowCopyComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.intValue = newIntValue;
		component.strValue = newStrValue;
		component.vector2Value = newVector2Value;
		component.testScriptableObject = newTestScriptableObject;
		component.dictValue = newDictValue;
		component.listValue = newListValue;
		component.iListValue = newIListValue;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceShallowCopy(int newIntValue, string newStrValue, UnityEngine.Vector2 newVector2Value, EntitasRedux.Tests.TestScriptableObject newTestScriptableObject, System.Collections.Generic.Dictionary<int, EntitasRedux.Tests.TestScriptableObject> newDictValue, System.Collections.Generic.List<EntitasRedux.Tests.TestScriptableObject> newListValue, System.Collections.Generic.IList<EntitasRedux.Tests.TestScriptableObject> newIListValue)
	{
		var index = MyTestComponentsLookup.ShallowCopy;
		var component = (EntitasRedux.Tests.ShallowCopyComponent)CreateComponent(index, typeof(EntitasRedux.Tests.ShallowCopyComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.intValue = newIntValue;
		component.strValue = newStrValue;
		component.vector2Value = newVector2Value;
		component.testScriptableObject = newTestScriptableObject;
		component.dictValue = newDictValue;
		component.listValue = newListValue;
		component.iListValue = newIListValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyShallowCopyTo(EntitasRedux.Tests.ShallowCopyComponent copyComponent)
	{
		var index = MyTestComponentsLookup.ShallowCopy;
		var component = (EntitasRedux.Tests.ShallowCopyComponent)CreateComponent(index, typeof(EntitasRedux.Tests.ShallowCopyComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.intValue = copyComponent.intValue;
		component.strValue = copyComponent.strValue;
		component.vector2Value = copyComponent.vector2Value;
		component.testScriptableObject = copyComponent.testScriptableObject;
		component.dictValue = (System.Collections.Generic.Dictionary<int, EntitasRedux.Tests.TestScriptableObject>)JCMG.EntitasRedux.DictionaryTools.ShallowCopy(copyComponent.dictValue);
		component.listValue = (System.Collections.Generic.List<EntitasRedux.Tests.TestScriptableObject>)JCMG.EntitasRedux.ListTools.ShallowCopy(copyComponent.listValue);
		component.iListValue = copyComponent.iListValue;
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveShallowCopy()
	{
		RemoveComponent(MyTestComponentsLookup.ShallowCopy);
	}
}

public sealed partial class MyTestMatcher
{
	static JCMG.EntitasRedux.IMatcher<MyTestEntity> _matcherShallowCopy;

	public static JCMG.EntitasRedux.IMatcher<MyTestEntity> ShallowCopy
	{
		get
		{
			if (_matcherShallowCopy == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<MyTestEntity>)JCMG.EntitasRedux.Matcher<MyTestEntity>.AllOf(MyTestComponentsLookup.ShallowCopy);
				matcher.ComponentNames = MyTestComponentsLookup.ComponentNames;
				_matcherShallowCopy = matcher;
			}

			return _matcherShallowCopy;
		}
	}
}
