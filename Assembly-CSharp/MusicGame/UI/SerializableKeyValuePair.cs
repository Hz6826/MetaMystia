using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace MusicGame.UI
{
	// Token: 0x02000025 RID: 37
	[Serializable]
	public sealed class SerializableKeyValuePair<TKey, TValue> : ValueType
	{
		// Token: 0x06000397 RID: 919 RVA: 0x000AA33C File Offset: 0x000A853C
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableKeyValuePair()
		{
			Il2CppClassPointerStore<SerializableKeyValuePair<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "SerializableKeyValuePair`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableKeyValuePair<TKey, TValue>>.NativeClassPtr);
			SerializableKeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableKeyValuePair<TKey, TValue>>.NativeClassPtr, "Key");
			SerializableKeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableKeyValuePair<TKey, TValue>>.NativeClassPtr, "Value");
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00004000 File Offset: 0x00002200
		public SerializableKeyValuePair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00004009 File Offset: 0x00002209
		public SerializableKeyValuePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableKeyValuePair<TKey, TValue>>.NativeClassPtr))
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x0600039A RID: 922 RVA: 0x000AA3E4 File Offset: 0x000A85E4
		// (set) Token: 0x0600039B RID: 923 RVA: 0x000AA40C File Offset: 0x000A860C
		public unsafe TKey Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableKeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Key);
				return IL2CPP.PointerToValueGeneric<TKey>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableKeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Key);
				Type typeFromHandle = typeof(TKey);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600039C RID: 924 RVA: 0x000AA4B4 File Offset: 0x000A86B4
		// (set) Token: 0x0600039D RID: 925 RVA: 0x000AA4DC File Offset: 0x000A86DC
		public unsafe TValue Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableKeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Value);
				return IL2CPP.PointerToValueGeneric<TValue>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableKeyValuePair<TKey, TValue>.NativeFieldInfoPtr_Value);
				Type typeFromHandle = typeof(TValue);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase);
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeFieldInfoPtr_Value;
	}
}
