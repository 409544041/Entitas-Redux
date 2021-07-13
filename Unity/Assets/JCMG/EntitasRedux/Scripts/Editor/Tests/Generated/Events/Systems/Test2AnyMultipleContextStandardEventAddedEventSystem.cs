public sealed class Test2AnyMultipleContextStandardEventAddedEventSystem : JCMG.EntitasRedux.ReactiveSystem<Test2Entity>
{
	readonly JCMG.EntitasRedux.IGroup<Test2Entity> _listeners;
	readonly System.Collections.Generic.List<Test2Entity> _entityBuffer;
	readonly System.Collections.Generic.List<ITest2AnyMultipleContextStandardEventAddedListener> _listenerBuffer;

	public Test2AnyMultipleContextStandardEventAddedEventSystem(Contexts contexts) : base(contexts.Test2)
	{
		_listeners = contexts.Test2.GetGroup(Test2Matcher.Test2AnyMultipleContextStandardEventAddedListener);
		_entityBuffer = new System.Collections.Generic.List<Test2Entity>();
		_listenerBuffer = new System.Collections.Generic.List<ITest2AnyMultipleContextStandardEventAddedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<Test2Entity> GetTrigger(JCMG.EntitasRedux.IContext<Test2Entity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(Test2Matcher.MultipleContextStandardEvent)
		);
	}

	protected override bool Filter(Test2Entity entity)
	{
		return entity.HasMultipleContextStandardEvent;
	}

	protected override void Execute(System.Collections.Generic.List<Test2Entity> entities)
	{
		foreach (var e in entities)
		{
			var component = e.MultipleContextStandardEvent;
			foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer))
			{
				_listenerBuffer.Clear();
				_listenerBuffer.AddRange(listenerEntity.Test2AnyMultipleContextStandardEventAddedListener.value);
				foreach (var listener in _listenerBuffer)
				{
					listener.OnAnyMultipleContextStandardEventAdded(e, component.value);
				}
			}
		}
	}
}
