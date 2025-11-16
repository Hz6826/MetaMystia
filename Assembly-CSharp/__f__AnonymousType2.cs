using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000004 RID: 4
[ObfuscatedName("<>f__AnonymousType2`2")]
public sealed class __f__AnonymousType2<_type_j__TPar, _num_j__TPar> : Object
{
	// Token: 0x0600001C RID: 28 RVA: 0x0009F164 File Offset: 0x0009D364
	// Note: this type is marked as 'beforefieldinit'.
	static __f__AnonymousType2()
	{
		Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "<>f__AnonymousType2`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_type_j__TPar>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_num_j__TPar>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr);
		__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeFieldInfoPtr__type_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr, "<type>i__Field");
		__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeFieldInfoPtr__num_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr, "<num>i__Field");
		__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_get_type_Public_get__type_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr, 100663310);
		__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_get_num_Public_get__num_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr, 100663311);
		__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__type_j__TPar__num_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr, 100663312);
		__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr, 100663313);
		__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr, 100663314);
		__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr, 100663315);
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x0600001D RID: 29 RVA: 0x0009F284 File Offset: 0x0009D484
	public unsafe _type_j__TPar type
	{
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_get_type_Public_get__type_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_type_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x1700000E RID: 14
	// (get) Token: 0x0600001E RID: 30 RVA: 0x0009F2C0 File Offset: 0x0009D4C0
	public unsafe _num_j__TPar num
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_get_num_Public_get__num_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_num_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x0600001F RID: 31 RVA: 0x0009F2FC File Offset: 0x0009D4FC
	[CallerCount(4)]
	[CachedScanResults(RefRangeStart = 150, RefRangeEnd = 154, XrefRangeStart = 149, XrefRangeEnd = 150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe __f__AnonymousType2(_type_j__TPar type, _num_j__TPar num) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType2<_type_j__TPar, _num_j__TPar>>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr;
		if (!typeof(_type_j__TPar).IsValueType)
		{
			_type_j__TPar type_j__TPar = type;
			intPtr = ((type_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(type_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(type_j__TPar as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref type;
		}
		ptr2 = intPtr;
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2;
		if (!typeof(_num_j__TPar).IsValueType)
		{
			_num_j__TPar num_j__TPar = num;
			intPtr2 = ((num_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(num_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(num_j__TPar as Il2CppObjectBase));
		}
		else
		{
			intPtr2 = ref num;
		}
		ptr3 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__type_j__TPar__num_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
	}

	// Token: 0x06000020 RID: 32 RVA: 0x0009F3C8 File Offset: 0x0009D5C8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154, XrefRangeEnd = 156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000021 RID: 33 RVA: 0x0009F418 File Offset: 0x0009D618
	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000022 RID: 34 RVA: 0x0009F454 File Offset: 0x0009D654
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156, XrefRangeEnd = 169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002062 File Offset: 0x00000262
	public __f__AnonymousType2(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700000B RID: 11
	// (get) Token: 0x06000024 RID: 36 RVA: 0x0009F48C File Offset: 0x0009D68C
	// (set) Token: 0x06000025 RID: 37 RVA: 0x0009F4B4 File Offset: 0x0009D6B4
	public unsafe _type_j__TPar _type_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeFieldInfoPtr__type_i__Field);
			return IL2CPP.PointerToValueGeneric<_type_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeFieldInfoPtr__type_i__Field);
			Type typeFromHandle = typeof(_type_j__TPar);
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

	// Token: 0x1700000C RID: 12
	// (get) Token: 0x06000026 RID: 38 RVA: 0x0009F55C File Offset: 0x0009D75C
	// (set) Token: 0x06000027 RID: 39 RVA: 0x0009F584 File Offset: 0x0009D784
	public unsafe _num_j__TPar _num_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeFieldInfoPtr__num_i__Field);
			return IL2CPP.PointerToValueGeneric<_num_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType2<_type_j__TPar, _num_j__TPar>.NativeFieldInfoPtr__num_i__Field);
			Type typeFromHandle = typeof(_num_j__TPar);
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

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeFieldInfoPtr__type_i__Field;

	// Token: 0x04000014 RID: 20
	private static readonly IntPtr NativeFieldInfoPtr__num_i__Field;

	// Token: 0x04000015 RID: 21
	private static readonly IntPtr NativeMethodInfoPtr_get_type_Public_get__type_j__TPar_0;

	// Token: 0x04000016 RID: 22
	private static readonly IntPtr NativeMethodInfoPtr_get_num_Public_get__num_j__TPar_0;

	// Token: 0x04000017 RID: 23
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void__type_j__TPar__num_j__TPar_0;

	// Token: 0x04000018 RID: 24
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	// Token: 0x04000019 RID: 25
	private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	// Token: 0x0400001A RID: 26
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
