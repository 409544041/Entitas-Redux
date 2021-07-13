public sealed class TestAnyEventToGenerateAddedEventSystem : JCMG.EntitasRedux.ReactiveSystem<TestEntity>
{
	readonly JCMG.EntitasRedux.IGroup<TestEntity> _listeners;
	readonly System.Collections.Generic.List<TestEntity> _entityBuffer;
	readonly System.Collections.Generic.List<ITestAnyEventToGenerateAddedListener> _listenerBuffer;

	public TestAnyEventToGenerateAddedEventSystem(Contexts contexts) : base(contexts.Test)
	{
		_listeners = contexts.Test.GetGroup(TestMatcher.TestAnyEventToGenerateAddedListener);
		_entityBuffer = new System.Collections.Generic.List<TestEntity>();
		_listenerBuffer = new System.Collections.Generic.List<ITestAnyEventToGenerateAddedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<TestEntity> GetTrigger(JCMG.EntitasRedux.IContext<TestEntity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(TestMatcher.EventToGenerate)
		);
	}

	protected override bool Filter(TestEntity entity)
	{
		return entity.HasEventToGenerate;
	}

	protected override void Execute(System.Collections.Generic.List<TestEntity> entities)
	{
		foreach (var e in entities)
		{
			var component = e.EventToGenerate;
			foreach (var listenerEntity in _listeners.GetEntities(_entityBuffer))
			{
				_listenerBuffer.Clear();
				_listenerBuffer.AddRange(listenerEntity.TestAnyEventToGenerateAddedListener.value);
				foreach (var listener in _listenerBuffer)
				{
					listener.OnAnyEventToGenerateAdded(e, component.value);
				}
			}
		}
	}
}
