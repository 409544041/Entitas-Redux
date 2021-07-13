public sealed partial class VisualDebugContext : JCMG.EntitasRedux.Context<VisualDebugEntity>
{
	public VisualDebugContext()
		: base(
			VisualDebugComponentsLookup.TotalComponents,
			0,
			new JCMG.EntitasRedux.ContextInfo(
				"VisualDebug",
				VisualDebugComponentsLookup.ComponentNames,
				VisualDebugComponentsLookup.ComponentTypes
			),
			(entity) =>

#if (ENTITAS_FAST_AND_UNSAFE)
				new JCMG.EntitasRedux.UnsafeAERC(),
#else
				new JCMG.EntitasRedux.SafeAERC(entity),
#endif
			() => new VisualDebugEntity()
		)
	{
	}

	/// <summary>
	/// Creates a new entity and adds copies of all specified components to it. If replaceExisting is true, it will
	/// replace existing components.
	/// </summary>
	public VisualDebugEntity CloneEntity(VisualDebugEntity entity, bool replaceExisting = false, params int[] indices)
	{
		var target = CreateEntity();
		entity.CopyTo(target, replaceExisting, indices);
		return target;
	}
}
