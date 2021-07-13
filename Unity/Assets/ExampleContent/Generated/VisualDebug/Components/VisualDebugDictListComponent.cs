public partial class VisualDebugEntity
{
	public ExampleContent.VisualDebugging.DictListComponent DictList { get { return (ExampleContent.VisualDebugging.DictListComponent)GetComponent(VisualDebugComponentsLookup.DictList); } }
	public bool HasDictList { get { return HasComponent(VisualDebugComponentsLookup.DictList); } }

	public void AddDictList(System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<ExampleContent.VisualDebugging.CustomObject>> newDictRefListType, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<System.Collections.Generic.List<ExampleContent.VisualDebugging.CustomObject>>> newDictRefNestedListType)
	{
		var index = VisualDebugComponentsLookup.DictList;
		var component = (ExampleContent.VisualDebugging.DictListComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictListComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.dictRefListType = newDictRefListType;
		component.dictRefNestedListType = newDictRefNestedListType;
		#endif
		AddComponent(index, component);
	}

	public void ReplaceDictList(System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<ExampleContent.VisualDebugging.CustomObject>> newDictRefListType, System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<System.Collections.Generic.List<ExampleContent.VisualDebugging.CustomObject>>> newDictRefNestedListType)
	{
		var index = VisualDebugComponentsLookup.DictList;
		var component = (ExampleContent.VisualDebugging.DictListComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictListComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.dictRefListType = newDictRefListType;
		component.dictRefNestedListType = newDictRefNestedListType;
		#endif
		ReplaceComponent(index, component);
	}

	public void CopyDictListTo(ExampleContent.VisualDebugging.DictListComponent copyComponent)
	{
		var index = VisualDebugComponentsLookup.DictList;
		var component = (ExampleContent.VisualDebugging.DictListComponent)CreateComponent(index, typeof(ExampleContent.VisualDebugging.DictListComponent));
		#if !ENTITAS_REDUX_NO_IMPL
		component.dictRefListType = (System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<ExampleContent.VisualDebugging.CustomObject>>)JCMG.EntitasRedux.DictionaryTools.DeepCopyListValue(copyComponent.dictRefListType);
		component.dictRefNestedListType = (System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<System.Collections.Generic.List<ExampleContent.VisualDebugging.CustomObject>>>)JCMG.EntitasRedux.DictionaryTools.ShallowCopy(copyComponent.dictRefNestedListType);
		#endif
		ReplaceComponent(index, component);
	}

	public void RemoveDictList()
	{
		RemoveComponent(VisualDebugComponentsLookup.DictList);
	}
}

public sealed partial class VisualDebugMatcher
{
	static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> _matcherDictList;

	public static JCMG.EntitasRedux.IMatcher<VisualDebugEntity> DictList
	{
		get
		{
			if (_matcherDictList == null)
			{
				var matcher = (JCMG.EntitasRedux.Matcher<VisualDebugEntity>)JCMG.EntitasRedux.Matcher<VisualDebugEntity>.AllOf(VisualDebugComponentsLookup.DictList);
				matcher.ComponentNames = VisualDebugComponentsLookup.ComponentNames;
				_matcherDictList = matcher;
			}

			return _matcherDictList;
		}
	}
}
