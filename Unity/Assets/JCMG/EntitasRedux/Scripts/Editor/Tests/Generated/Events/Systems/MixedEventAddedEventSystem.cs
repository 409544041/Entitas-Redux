public sealed class MixedEventAddedEventSystem : JCMG.EntitasRedux.ReactiveSystem<TestEntity>
{
	readonly System.Collections.Generic.List<IMixedEventAddedListener> _listenerBuffer;

	public MixedEventAddedEventSystem(Contexts contexts) : base(contexts.Test)
	{
		_listenerBuffer = new System.Collections.Generic.List<IMixedEventAddedListener>();
	}

	protected override JCMG.EntitasRedux.ICollector<TestEntity> GetTrigger(JCMG.EntitasRedux.IContext<TestEntity> context)
	{
		return JCMG.EntitasRedux.CollectorContextExtension.CreateCollector(
			context,
			JCMG.EntitasRedux.TriggerOnEventMatcherExtension.Added(TestMatcher.MixedEvent)
		);
	}

	protected override bool Filter(TestEntity entity)
	{
		return entity.HasMixedEvent && entity.HasMixedEventAddedListener;
	}

	protected override void Execute(System.Collections.Generic.List<TestEntity> entities)
	{
		foreach (var e in entities)
		{
			var component = e.MixedEvent;
			_listenerBuffer.Clear();
			_listenerBuffer.AddRange(e.MixedEventAddedListener.value);
			foreach (var listener in _listenerBuffer)
			{
				listener.OnMixedEventAdded(e, component.value);
			}
		}
	}
}
