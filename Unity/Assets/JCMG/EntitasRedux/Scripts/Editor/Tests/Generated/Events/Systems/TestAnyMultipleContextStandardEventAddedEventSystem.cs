public sealed class TestAnyMultipleContextStandardEventAddedEventSystem : JCMG.EntitasRedux.ReactiveSystem<TestEntity>
{
	readonly JCMG.EntitasRedux.IGroup<TestEntity> _listeners;
	readonly System.Collections.Generic.List<TestEntity> _entityBuffer;
	readonly System.Collections.Generic.List<ITestAnyMultipleContextStandardEventAddedListener> _listenerBuffer;

	public TestAnyMultipleContextStandardEventAddedEventSystem(Contexts contexts) : base(contexts.Test)
	{
		_listeners = contexts.Test.GetGroup(TestMatcher.TestAnyMultipleContextStandardEventAddedListener);
		_entityBuffer = new System.Collections.Generic.List<TestEntity>();
		_listenerBuffer = new System.Collections.Generic.List<ITestAnyMultipleContextStandardEventAddedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<TestEntity> GetTrigger(JCMG.EntitasRedux.IContext<TestEntity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(TestMatcher.MultipleContextStandardEvent)
		);
	}

	protected override bool Filter(TestEntity entity)
	{
		return entity.HasMultipleContextStandardEvent;
	}

	protected override void Execute(System.Collections.Generic.List<TestEntity> entities)
	{
		foreach (var e in entities)
		{
			var component = e.MultipleContextStandardEvent;
			foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer))
			{
				_listenerBuffer.Clear();
				_listenerBuffer.AddRange(listenerEntity.TestAnyMultipleContextStandardEventAddedListener.value);
				foreach (var listener in _listenerBuffer)
				{
					listener.OnAnyMultipleContextStandardEventAdded(e, component.value);
				}
			}
		}
	}
}
