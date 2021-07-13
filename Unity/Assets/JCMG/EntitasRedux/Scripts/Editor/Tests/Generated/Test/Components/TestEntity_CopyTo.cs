
using JCMG.EntitasRedux;

public partial class TestEntity
{
	/// <summary>
	/// Copies <paramref name="component"/> to this entity as a new component instance.
	/// </summary>
	public void CopyComponentTo(IComponent component)
	{
		#if !ENTITAS_REDUX_NO_IMPL
		if (component is EntitasRedux.Tests.BaseComponent Base)
		{
			CopyBaseTo(Base);
		}
		else if (component is EntitasRedux.Tests.ComponentWithFields ComponentWithFields)
		{
			CopyComponentWithFieldsTo(ComponentWithFields);
		}
		else if (component is EntitasRedux.Tests.ComponentWithFieldsAndProperties ComponentWithFieldsAndProperties)
		{
			CopyComponentWithFieldsAndPropertiesTo(ComponentWithFieldsAndProperties);
		}
		else if (component is EntitasRedux.Tests.ComponentWithProperties ComponentWithProperties)
		{
			CopyComponentWithPropertiesTo(ComponentWithProperties);
		}
		else if (component is EntitasRedux.Tests.CustomPrefixFlagComponent CustomPrefixFlag)
		{
			MyCustomPrefixFlag = true;
		}
		else if (component is EntitasRedux.Tests.EntityIndexComponent EntityIndex)
		{
			CopyEntityIndexTo(EntityIndex);
		}
		else if (component is EntitasRedux.Tests.FlagComponent Flag)
		{
			IsFlag = true;
		}
		else if (component is EntitasRedux.Tests.FlagEntityEventComponent FlagEntityEvent)
		{
			IsFlagEntityEvent = true;
		}
		else if (component is EntitasRedux.Tests.FlagEventComponent FlagEvent)
		{
			IsFlagEvent = true;
		}
		else if (component is EntitasRedux.Tests.MixedEventComponent MixedEvent)
		{
			CopyMixedEventTo(MixedEvent);
		}
		else if (component is EntitasRedux.Tests.MultipleContextStandardEventComponent MultipleContextStandardEvent)
		{
			CopyMultipleContextStandardEventTo(MultipleContextStandardEvent);
		}
		else if (component is EntitasRedux.Tests.MultipleEntityIndicesComponent MultipleEntityIndices)
		{
			CopyMultipleEntityIndicesTo(MultipleEntityIndices);
		}
		else if (component is EntitasRedux.Tests.MultipleEventsStandardEventComponent MultipleEventsStandardEvent)
		{
			CopyMultipleEventsStandardEventTo(MultipleEventsStandardEvent);
		}
		else if (component is EntitasRedux.Tests.MyNamespaceComponent MyNamespace)
		{
			CopyMyNamespaceTo(MyNamespace);
		}
		else if (component is EntitasRedux.Tests.MyNamespaceFlagComponent MyNamespaceFlag)
		{
			IsMyNamespaceFlag = true;
		}
		else if (component is EntitasRedux.Tests.NameAgeComponent NameAge)
		{
			CopyNameAgeTo(NameAge);
		}
		else if (component is EntitasRedux.Tests.StandardComponent Standard)
		{
			CopyStandardTo(Standard);
		}
		else if (component is EntitasRedux.Tests.StandardEntityEventComponent StandardEntityEvent)
		{
			CopyStandardEntityEventTo(StandardEntityEvent);
		}
		else if (component is EntitasRedux.Tests.StandardEventComponent StandardEvent)
		{
			CopyStandardEventTo(StandardEvent);
		}
		else if (component is EntitasRedux.Tests.Test2ContextComponent Test2Context)
		{
			CopyTest2ContextTo(Test2Context);
		}
		else if (component is EntitasRedux.Tests.UniqueEventComponent UniqueEvent)
		{
			CopyUniqueEventTo(UniqueEvent);
		}
		else if (component is EntitasRedux.Tests.UniqueFlagComponent UniqueFlag)
		{
			IsUniqueFlag = true;
		}
		else if (component is EntitasRedux.Tests.UniqueMyNamespaceComponent UniqueMyNamespace)
		{
			CopyUniqueMyNamespaceTo(UniqueMyNamespace);
		}
		else if (component is EntitasRedux.Tests.UniqueMyNamespaceFlagComponent UniqueMyNamespaceFlag)
		{
			IsUniqueMyNamespaceFlag = true;
		}
		else if (component is EntitasRedux.Tests.UniqueStandardComponent UniqueStandard)
		{
			CopyUniqueStandardTo(UniqueStandard);
		}
		else if (component is EntitasRedux.Tests.PositionComponent Position)
		{
			CopyPositionTo(Position);
		}
		else if (component is EntitasRedux.Tests.SizeComponent Size)
		{
			CopySizeTo(Size);
		}
		else if (component is ClassWithEntitIndexAttributeComponent ClassWithEntitIndexAttribute)
		{
			CopyClassWithEntitIndexAttributeTo(ClassWithEntitIndexAttribute);
		}
		else if (component is NewCustomNameComponent1Component NewCustomNameComponent1)
		{
			CopyNewCustomNameComponent1To(NewCustomNameComponent1);
		}
		else if (component is NewCustomNameComponent2Component NewCustomNameComponent2)
		{
			CopyNewCustomNameComponent2To(NewCustomNameComponent2);
		}
		else if (component is ClassToGenerateComponent ClassToGenerate)
		{
			CopyClassToGenerateTo(ClassToGenerate);
		}
		else if (component is EventToGenerateComponent EventToGenerate)
		{
			CopyEventToGenerateTo(EventToGenerate);
		}
		else if (component is InterfaceToGenerateComponent InterfaceToGenerate)
		{
			CopyInterfaceToGenerateTo(InterfaceToGenerate);
		}
		else if (component is StructToGenerateComponent StructToGenerate)
		{
			CopyStructToGenerateTo(StructToGenerate);
		}
		else if (component is UniqueClassToGenerateComponent UniqueClassToGenerate)
		{
			CopyUniqueClassToGenerateTo(UniqueClassToGenerate);
		}
		else if (component is AnyBaseAddedListenerComponent AnyBaseAddedListener)
		{
			CopyAnyBaseAddedListenerTo(AnyBaseAddedListener);
		}
		else if (component is FlagEntityEventAddedListenerComponent FlagEntityEventAddedListener)
		{
			CopyFlagEntityEventAddedListenerTo(FlagEntityEventAddedListener);
		}
		else if (component is AnyFlagEventRemovedListenerComponent AnyFlagEventRemovedListener)
		{
			CopyAnyFlagEventRemovedListenerTo(AnyFlagEventRemovedListener);
		}
		else if (component is AnyMixedEventAddedListenerComponent AnyMixedEventAddedListener)
		{
			CopyAnyMixedEventAddedListenerTo(AnyMixedEventAddedListener);
		}
		else if (component is MixedEventAddedListenerComponent MixedEventAddedListener)
		{
			CopyMixedEventAddedListenerTo(MixedEventAddedListener);
		}
		else if (component is TestAnyMultipleContextStandardEventAddedListenerComponent TestAnyMultipleContextStandardEventAddedListener)
		{
			CopyTestAnyMultipleContextStandardEventAddedListenerTo(TestAnyMultipleContextStandardEventAddedListener);
		}
		else if (component is TestAnyMultipleEventsStandardEventAddedListenerComponent TestAnyMultipleEventsStandardEventAddedListener)
		{
			CopyTestAnyMultipleEventsStandardEventAddedListenerTo(TestAnyMultipleEventsStandardEventAddedListener);
		}
		else if (component is TestMultipleEventsStandardEventRemovedListenerComponent TestMultipleEventsStandardEventRemovedListener)
		{
			CopyTestMultipleEventsStandardEventRemovedListenerTo(TestMultipleEventsStandardEventRemovedListener);
		}
		else if (component is StandardEntityEventRemovedListenerComponent StandardEntityEventRemovedListener)
		{
			CopyStandardEntityEventRemovedListenerTo(StandardEntityEventRemovedListener);
		}
		else if (component is AnyStandardEventAddedListenerComponent AnyStandardEventAddedListener)
		{
			CopyAnyStandardEventAddedListenerTo(AnyStandardEventAddedListener);
		}
		else if (component is AnyUniqueEventAddedListenerComponent AnyUniqueEventAddedListener)
		{
			CopyAnyUniqueEventAddedListenerTo(AnyUniqueEventAddedListener);
		}
		else if (component is TestAnyEventToGenerateAddedListenerComponent TestAnyEventToGenerateAddedListener)
		{
			CopyTestAnyEventToGenerateAddedListenerTo(TestAnyEventToGenerateAddedListener);
		}
		#endif
	}

	/// <summary>
	/// Copies all components on this entity to <paramref name="copyToEntity"/>.
	/// </summary>
	public void CopyTo(TestEntity copyToEntity)
	{
		for (var i = 0; i < TestComponentsLookup.TotalComponents; ++i)
		{
			if (HasComponent(i))
			{
				if (copyToEntity.HasComponent(i))
				{
					throw new EntityAlreadyHasComponentException(
						i,
						"Cannot copy component '" +
						TestComponentsLookup.ComponentNames[i] +
						"' to " +
						this +
						"!",
						"If replacement is intended, please call CopyTo() with `replaceExisting` set to true.");
				}

				var component = GetComponent(i);
				copyToEntity.CopyComponentTo(component);
			}
		}
	}

	/// <summary>
	/// Copies all components on this entity to <paramref name="copyToEntity"/>; if <paramref name="replaceExisting"/>
	/// is true any of the components that <paramref name="copyToEntity"/> has that this entity has will be replaced,
	/// otherwise they will be skipped.
	/// </summary>
	public void CopyTo(TestEntity copyToEntity, bool replaceExisting)
	{
		for (var i = 0; i < TestComponentsLookup.TotalComponents; ++i)
		{
			if (!HasComponent(i))
			{
				continue;
			}

			if (!copyToEntity.HasComponent(i) || replaceExisting)
			{
				var component = GetComponent(i);
				copyToEntity.CopyComponentTo(component);
			}
		}
	}

	/// <summary>
	/// Copies components on this entity at <paramref name="indices"/> in the <see cref="TestComponentsLookup"/> to
	/// <paramref name="copyToEntity"/>. If <paramref name="replaceExisting"/> is true any of the components that
	/// <paramref name="copyToEntity"/> has that this entity has will be replaced, otherwise they will be skipped.
	/// </summary>
	public void CopyTo(TestEntity copyToEntity, bool replaceExisting, params int[] indices)
	{
		for (var i = 0; i < indices.Length; ++i)
		{
			var index = indices[i];

			// Validate that the index is within range of the component lookup
			if (index < 0 && index >= TestComponentsLookup.TotalComponents)
			{
				const string OUT_OF_RANGE_WARNING =
					"Component Index [{0}] is out of range for [{1}].";

				const string HINT = "Please ensure any CopyTo indices are valid.";

				throw new IndexOutOfLookupRangeException(
					string.Format(OUT_OF_RANGE_WARNING, index, nameof(TestComponentsLookup)),
					HINT);
			}

			if (!HasComponent(index))
			{
				continue;
			}

			if (!copyToEntity.HasComponent(index) || replaceExisting)
			{
				var component = GetComponent(index);
				copyToEntity.CopyComponentTo(component);
			}
		}
	}
}
