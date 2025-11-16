using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000003 RID: 3
[ObfuscatedName("<>f__AnonymousType1`2")]
public sealed class __f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar> : Object
{
	// Token: 0x06000010 RID: 16 RVA: 0x0009EC9C File Offset: 0x0009CE9C
	// Note: this type is marked as 'beforefieldinit'.
	static __f__AnonymousType1()
	{
		Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "<>f__AnonymousType1`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
		{
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_renderer_j__TPar>.NativeClassPtr)),
			Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<_targetAlpha_j__TPar>.NativeClassPtr))
		})).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr);
		__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeFieldInfoPtr__renderer_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr, "<renderer>i__Field");
		__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeFieldInfoPtr__targetAlpha_i__Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr, "<targetAlpha>i__Field");
		__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_get_renderer_Public_get__renderer_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr, 100663304);
		__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_get_targetAlpha_Public_get__targetAlpha_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr, 100663305);
		__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__renderer_j__TPar__targetAlpha_j__TPar_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr, 100663306);
		__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr, 100663307);
		__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr, 100663308);
		__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr, 100663309);
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000011 RID: 17 RVA: 0x0009EDBC File Offset: 0x0009CFBC
	public unsafe _renderer_j__TPar renderer
	{
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 44, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_get_renderer_Public_get__renderer_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_renderer_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x1700000A RID: 10
	// (get) Token: 0x06000012 RID: 18 RVA: 0x0009EDF8 File Offset: 0x0009CFF8
	public unsafe _targetAlpha_j__TPar targetAlpha
	{
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_get_targetAlpha_Public_get__targetAlpha_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<_targetAlpha_j__TPar>(intPtr, false, true);
		}
	}

	// Token: 0x06000013 RID: 19 RVA: 0x0009EE34 File Offset: 0x0009D034
	[CallerCount(69)]
	[CachedScanResults(RefRangeStart = 61, RefRangeEnd = 130, XrefRangeStart = 58, XrefRangeEnd = 61, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe __f__AnonymousType1(_renderer_j__TPar renderer, _targetAlpha_j__TPar targetAlpha) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
		ref IntPtr ptr2 = ref *ptr;
		IntPtr intPtr;
		if (!typeof(_renderer_j__TPar).IsValueType)
		{
			_renderer_j__TPar renderer_j__TPar = renderer;
			intPtr = ((renderer_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(renderer_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(renderer_j__TPar as Il2CppObjectBase));
		}
		else
		{
			intPtr = ref renderer;
		}
		ptr2 = intPtr;
		ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
		IntPtr intPtr2;
		if (!typeof(_targetAlpha_j__TPar).IsValueType)
		{
			_targetAlpha_j__TPar targetAlpha_j__TPar = targetAlpha;
			intPtr2 = ((targetAlpha_j__TPar is string) ? IL2CPP.ManagedStringToIl2Cpp(targetAlpha_j__TPar as string) : IL2CPP.Il2CppObjectBaseToPtr(targetAlpha_j__TPar as Il2CppObjectBase));
		}
		else
		{
			intPtr2 = ref targetAlpha;
		}
		ptr3 = intPtr2;
		IntPtr intPtr4;
		IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr__ctor_Public_Void__renderer_j__TPar__targetAlpha_j__TPar_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
		Il2CppException.RaiseExceptionIfNecessary(intPtr4);
	}

	// Token: 0x06000014 RID: 20 RVA: 0x0009EF00 File Offset: 0x0009D100
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130, XrefRangeEnd = 132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override bool Equals(Object value)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0009EF50 File Offset: 0x0009D150
	[CallerCount(0)]
	public unsafe override int GetHashCode()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x06000016 RID: 22 RVA: 0x0009EF8C File Offset: 0x0009D18C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132, XrefRangeEnd = 149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override string ToString()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return IL2CPP.Il2CppStringToManaged(intPtr);
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002059 File Offset: 0x00000259
	public __f__AnonymousType1(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000018 RID: 24 RVA: 0x0009EFC4 File Offset: 0x0009D1C4
	// (set) Token: 0x06000019 RID: 25 RVA: 0x0009EFEC File Offset: 0x0009D1EC
	public unsafe _renderer_j__TPar _renderer_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeFieldInfoPtr__renderer_i__Field);
			return IL2CPP.PointerToValueGeneric<_renderer_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeFieldInfoPtr__renderer_i__Field);
			Type typeFromHandle = typeof(_renderer_j__TPar);
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

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600001A RID: 26 RVA: 0x0009F094 File Offset: 0x0009D294
	// (set) Token: 0x0600001B RID: 27 RVA: 0x0009F0BC File Offset: 0x0009D2BC
	public unsafe _targetAlpha_j__TPar _targetAlpha_i__Field
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeFieldInfoPtr__targetAlpha_i__Field);
			return IL2CPP.PointerToValueGeneric<_targetAlpha_j__TPar>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(__f__AnonymousType1<_renderer_j__TPar, _targetAlpha_j__TPar>.NativeFieldInfoPtr__targetAlpha_i__Field);
			Type typeFromHandle = typeof(_targetAlpha_j__TPar);
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

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeFieldInfoPtr__renderer_i__Field;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeFieldInfoPtr__targetAlpha_i__Field;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr_get_renderer_Public_get__renderer_j__TPar_0;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_get_targetAlpha_Public_get__targetAlpha_j__TPar_0;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void__renderer_j__TPar__targetAlpha_j__TPar_0;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
}
