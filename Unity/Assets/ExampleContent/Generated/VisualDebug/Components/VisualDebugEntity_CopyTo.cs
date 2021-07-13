
using JCMG.EntitasRedux;

public partial class VisualDebugEntity
{
	/// <summary>
	/// Copies <paramref name="component"/> to this entity as a new component instance.
	/// </summary>
	public void CopyComponentTo(IComponent component)
	{
		#if !ENTITAS_REDUX_NO_IMPL
		if (component is ExampleContent.VisualDebugging.AnArrayComponent AnArray)
		{
			CopyAnArrayTo(AnArray);
		}
		else if (component is ExampleContent.VisualDebugging.AnCleanupDestroyEntityComponent AnCleanupDestroyEntity)
		{
			IsAnCleanupDestroyEntity = true;
		}
		else if (component is ExampleContent.VisualDebugging.AnCleanupRemoveComponent AnCleanupRemove)
		{
			IsAnCleanupRemove = true;
		}
		else if (component is ExampleContent.VisualDebugging.AnimationCurveComponent AnimationCurve)
		{
			CopyAnimationCurveTo(AnimationCurve);
		}
		else if (component is ExampleContent.VisualDebugging.Array2DComponent Array2D)
		{
			CopyArray2DTo(Array2D);
		}
		else if (component is ExampleContent.VisualDebugging.Array3DComponent Array3D)
		{
			CopyArray3DTo(Array3D);
		}
		else if (component is ExampleContent.VisualDebugging.BoundsComponent Bounds)
		{
			CopyBoundsTo(Bounds);
		}
		else if (component is ExampleContent.VisualDebugging.ColorComponent Color)
		{
			CopyColorTo(Color);
		}
		else if (component is ExampleContent.VisualDebugging.CustomFlagComponent CustomFlag)
		{
			MyCustomFlag = true;
		}
		else if (component is ExampleContent.VisualDebugging.CustomObjectComponent CustomObject)
		{
			CopyCustomObjectTo(CustomObject);
		}
		else if (component is ExampleContent.VisualDebugging.CustomObjectDictionaryComponent CustomObjectDictionary)
		{
			CopyCustomObjectDictionaryTo(CustomObjectDictionary);
		}
		else if (component is ExampleContent.VisualDebugging.CustomObjectListComponent CustomObjectList)
		{
			CopyCustomObjectListTo(CustomObjectList);
		}
		else if (component is ExampleContent.VisualDebugging.DateTimeComponent DateTime)
		{
			CopyDateTimeTo(DateTime);
		}
		else if (component is ExampleContent.VisualDebugging.DictArrayComponent DictArray)
		{
			CopyDictArrayTo(DictArray);
		}
		else if (component is ExampleContent.VisualDebugging.DictListComponent DictList)
		{
			CopyDictListTo(DictList);
		}
		else if (component is ExampleContent.VisualDebugging.DictionaryComponent Dictionary)
		{
			CopyDictionaryTo(Dictionary);
		}
		else if (component is ExampleContent.VisualDebugging.DontDrawSimpleObjectComponent DontDrawSimpleObject)
		{
			CopyDontDrawSimpleObjectTo(DontDrawSimpleObject);
		}
		else if (component is ExampleContent.VisualDebugging.FlagComponent Flag)
		{
			IsFlag = true;
		}
		else if (component is ExampleContent.VisualDebugging.GameObjectComponent GameObject)
		{
			CopyGameObjectTo(GameObject);
		}
		else if (component is ExampleContent.VisualDebugging.HashSetComponent HashSet)
		{
			CopyHashSetTo(HashSet);
		}
		else if (component is ExampleContent.VisualDebugging.IndexedEntityComponent IndexedEntity)
		{
			CopyIndexedEntityTo(IndexedEntity);
		}
		else if (component is ExampleContent.VisualDebugging.IndexedPrimaryComponent IndexedPrimary)
		{
			CopyIndexedPrimaryTo(IndexedPrimary);
		}
		else if (component is ExampleContent.VisualDebugging.JaggedArrayComponent JaggedArray)
		{
			CopyJaggedArrayTo(JaggedArray);
		}
		else if (component is ExampleContent.VisualDebugging.ListArrayComponent ListArray)
		{
			CopyListArrayTo(ListArray);
		}
		else if (component is ExampleContent.VisualDebugging.ListComponent List)
		{
			CopyListTo(List);
		}
		else if (component is ExampleContent.VisualDebugging.ManyMembersComponent ManyMembers)
		{
			CopyManyMembersTo(ManyMembers);
		}
		else if (component is ExampleContent.VisualDebugging.MonoBehaviourSubClassComponent MonoBehaviourSubClass)
		{
			CopyMonoBehaviourSubClassTo(MonoBehaviourSubClass);
		}
		else if (component is ExampleContent.VisualDebugging.MyBoolComponent MyBool)
		{
			CopyMyBoolTo(MyBool);
		}
		else if (component is ExampleContent.VisualDebugging.MyCharComponent MyChar)
		{
			CopyMyCharTo(MyChar);
		}
		else if (component is ExampleContent.VisualDebugging.MyDoubleComponent MyDouble)
		{
			CopyMyDoubleTo(MyDouble);
		}
		else if (component is ExampleContent.VisualDebugging.MyEnumComponent MyEnum)
		{
			CopyMyEnumTo(MyEnum);
		}
		else if (component is ExampleContent.VisualDebugging.MyEventComponent MyEvent)
		{
			CopyMyEventTo(MyEvent);
		}
		else if (component is ExampleContent.VisualDebugging.MyFlagsComponent MyFlags)
		{
			CopyMyFlagsTo(MyFlags);
		}
		else if (component is ExampleContent.VisualDebugging.MyFloatComponent MyFloat)
		{
			CopyMyFloatTo(MyFloat);
		}
		else if (component is ExampleContent.VisualDebugging.MyHiddenIntComponent MyHiddenInt)
		{
			CopyMyHiddenIntTo(MyHiddenInt);
		}
		else if (component is ExampleContent.VisualDebugging.MyIntComponent MyInt)
		{
			CopyMyIntTo(MyInt);
		}
		else if (component is ExampleContent.VisualDebugging.MyStringComponent MyString)
		{
			CopyMyStringTo(MyString);
		}
		else if (component is ExampleContent.VisualDebugging.PersonComponent Person)
		{
			CopyPersonTo(Person);
		}
		else if (component is ExampleContent.VisualDebugging.PropertyComponent Property)
		{
			CopyPropertyTo(Property);
		}
		else if (component is ExampleContent.VisualDebugging.RectComponent Rect)
		{
			CopyRectTo(Rect);
		}
		else if (component is ExampleContent.VisualDebugging.SimpleObjectComponent SimpleObject)
		{
			CopySimpleObjectTo(SimpleObject);
		}
		else if (component is ExampleContent.VisualDebugging.SystemObjectComponent SystemObject)
		{
			CopySystemObjectTo(SystemObject);
		}
		else if (component is ExampleContent.VisualDebugging.Texture2DComponent Texture2D)
		{
			CopyTexture2DTo(Texture2D);
		}
		else if (component is ExampleContent.VisualDebugging.TextureComponent Texture)
		{
			CopyTextureTo(Texture);
		}
		else if (component is ExampleContent.VisualDebugging.UniqueComponent Unique)
		{
			CopyUniqueTo(Unique);
		}
		else if (component is ExampleContent.VisualDebugging.UnityObjectComponent UnityObject)
		{
			CopyUnityObjectTo(UnityObject);
		}
		else if (component is ExampleContent.VisualDebugging.UnsupportedObjectComponent UnsupportedObject)
		{
			CopyUnsupportedObjectTo(UnsupportedObject);
		}
		else if (component is ExampleContent.VisualDebugging.Vector2Component Vector2)
		{
			CopyVector2To(Vector2);
		}
		else if (component is ExampleContent.VisualDebugging.Vector3Component Vector3)
		{
			CopyVector3To(Vector3);
		}
		else if (component is ExampleContent.VisualDebugging.Vector4Component Vector4)
		{
			CopyVector4To(Vector4);
		}
		else if (component is CoolNameComponent CoolName)
		{
			CopyCoolNameTo(CoolName);
		}
		else if (component is ISomeInterfaceComponent ISomeInterface)
		{
			CopyISomeInterfaceTo(ISomeInterface);
		}
		else if (component is PositionComponent Position)
		{
			CopyPositionTo(Position);
		}
		else if (component is VelocityComponent Velocity)
		{
			CopyVelocityTo(Velocity);
		}
		else if (component is MyEventClassComponent MyEventClass)
		{
			CopyMyEventClassTo(MyEventClass);
		}
		else if (component is SomeClassComponent SomeClass)
		{
			CopySomeClassTo(SomeClass);
		}
		else if (component is SomeOtherClassComponent SomeOtherClass)
		{
			CopySomeOtherClassTo(SomeOtherClass);
		}
		else if (component is SomeStructComponent SomeStruct)
		{
			CopySomeStructTo(SomeStruct);
		}
		else if (component is AnyMyEventAddedListenerComponent AnyMyEventAddedListener)
		{
			CopyAnyMyEventAddedListenerTo(AnyMyEventAddedListener);
		}
		else if (component is AnyMyEventClassAddedListenerComponent AnyMyEventClassAddedListener)
		{
			CopyAnyMyEventClassAddedListenerTo(AnyMyEventClassAddedListener);
		}
		#endif
	}

	/// <summary>
	/// Copies all components on this entity to <paramref name="copyToEntity"/>.
	/// </summary>
	public void CopyTo(VisualDebugEntity copyToEntity)
	{
		for (var i = 0; i < VisualDebugComponentsLookup.TotalComponents; ++i)
		{
			if (HasComponent(i))
			{
				if (copyToEntity.HasComponent(i))
				{
					throw new EntityAlreadyHasComponentException(
						i,
						"Cannot copy component '" +
						VisualDebugComponentsLookup.ComponentNames[i] +
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
	public void CopyTo(VisualDebugEntity copyToEntity, bool replaceExisting)
	{
		for (var i = 0; i < VisualDebugComponentsLookup.TotalComponents; ++i)
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
	/// Copies components on this entity at <paramref name="indices"/> in the <see cref="VisualDebugComponentsLookup"/> to
	/// <paramref name="copyToEntity"/>. If <paramref name="replaceExisting"/> is true any of the components that
	/// <paramref name="copyToEntity"/> has that this entity has will be replaced, otherwise they will be skipped.
	/// </summary>
	public void CopyTo(VisualDebugEntity copyToEntity, bool replaceExisting, params int[] indices)
	{
		for (var i = 0; i < indices.Length; ++i)
		{
			var index = indices[i];

			// Validate that the index is within range of the component lookup
			if (index < 0 && index >= VisualDebugComponentsLookup.TotalComponents)
			{
				const string OUT_OF_RANGE_WARNING =
					"Component Index [{0}] is out of range for [{1}].";

				const string HINT = "Please ensure any CopyTo indices are valid.";

				throw new IndexOutOfLookupRangeException(
					string.Format(OUT_OF_RANGE_WARNING, index, nameof(VisualDebugComponentsLookup)),
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
