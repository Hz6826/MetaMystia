using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

// Token: 0x02000007 RID: 7
public sealed class CreatorBoxData : ValueType
{
	// Token: 0x06000043 RID: 67 RVA: 0x0009FA48 File Offset: 0x0009DC48
	// Note: this type is marked as 'beforefieldinit'.
	static CreatorBoxData()
	{
		Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "CreatorBoxData");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr);
		CreatorBoxData.NativeFieldInfoPtr_m_Stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, "m_Stream");
		CreatorBoxData.NativeMethodInfoPtr_get_SpecGuestSettingStream_Public_get_IReadOnlyList_1_SpecGuestRefreshNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, 100663321);
		CreatorBoxData.NativeMethodInfoPtr_Create_Public_Static_CreatorBoxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, 100663322);
		CreatorBoxData.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, 100663323);
		CreatorBoxData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SpecGuestRefreshNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, 100663324);
		CreatorBoxData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_CreatorBoxData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, 100663325);
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x06000044 RID: 68 RVA: 0x0009FAF0 File Offset: 0x0009DCF0
	public unsafe IReadOnlyList<CreatorBoxData.SpecGuestRefreshNode> SpecGuestSettingStream
	{
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 2638, RefRangeEnd = 2734, XrefRangeStart = 2638, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxData.NativeMethodInfoPtr_get_SpecGuestSettingStream_Public_get_IReadOnlyList_1_SpecGuestRefreshNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<CreatorBoxData.SpecGuestRefreshNode>>(intPtr3) : null;
		}
	}

	// Token: 0x06000045 RID: 69 RVA: 0x0009FB34 File Offset: 0x0009DD34
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2741, RefRangeEnd = 2742, XrefRangeStart = 2734, XrefRangeEnd = 2741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe static CreatorBoxData Create()
	{
		IntPtr* ptr = null;
		IntPtr intPtr;
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CreatorBoxData.NativeMethodInfoPtr_Create_Public_Static_CreatorBoxData_0, 0, (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new CreatorBoxData(pointer);
	}

	// Token: 0x06000046 RID: 70 RVA: 0x0009FB60 File Offset: 0x0009DD60
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 2765, RefRangeEnd = 2766, XrefRangeStart = 2742, XrefRangeEnd = 2765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreatorBoxData(IEnumerable<ValueTuple<int, int>> values) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxData.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ValueTuple_2_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000047 RID: 71 RVA: 0x0009FBB0 File Offset: 0x0009DDB0
	[CallerCount(9)]
	[CachedScanResults(RefRangeStart = 2767, RefRangeEnd = 2776, XrefRangeStart = 2766, XrefRangeEnd = 2767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreatorBoxData(List<CreatorBoxData.SpecGuestRefreshNode> stream) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr))
	{
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxData.NativeMethodInfoPtr__ctor_Public_Void_List_1_SpecGuestRefreshNode_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0009FC00 File Offset: 0x0009DE00
	[CallerCount(2)]
	[CachedScanResults(RefRangeStart = 2780, RefRangeEnd = 2782, XrefRangeStart = 2776, XrefRangeEnd = 2780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe CreatorBoxData Clone()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr;
		IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(CreatorBoxData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_CreatorBoxData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
		Il2CppException.RaiseExceptionIfNecessary(intPtr);
		return new CreatorBoxData(pointer);
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002184 File Offset: 0x00000384
	public CreatorBoxData(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x0000218D File Offset: 0x0000038D
	public CreatorBoxData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr))
	{
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x0600004B RID: 75 RVA: 0x0009FC3C File Offset: 0x0009DE3C
	// (set) Token: 0x0600004C RID: 76 RVA: 0x0000219F File Offset: 0x0000039F
	public unsafe List<CreatorBoxData.SpecGuestRefreshNode> m_Stream
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxData.NativeFieldInfoPtr_m_Stream);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CreatorBoxData.SpecGuestRefreshNode>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxData.NativeFieldInfoPtr_m_Stream), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x04000029 RID: 41
	private static readonly IntPtr NativeFieldInfoPtr_m_Stream;

	// Token: 0x0400002A RID: 42
	private static readonly IntPtr NativeMethodInfoPtr_get_SpecGuestSettingStream_Public_get_IReadOnlyList_1_SpecGuestRefreshNode_0;

	// Token: 0x0400002B RID: 43
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CreatorBoxData_0;

	// Token: 0x0400002C RID: 44
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_ValueTuple_2_Int32_Int32_0;

	// Token: 0x0400002D RID: 45
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_SpecGuestRefreshNode_0;

	// Token: 0x0400002E RID: 46
	private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_CreatorBoxData_0;

	// Token: 0x02000460 RID: 1120
	[StructLayout(2)]
	public struct SpecGuestRefreshNode
	{
		// Token: 0x06007BE7 RID: 31719 RVA: 0x002391DC File Offset: 0x002373DC
		// Note: this type is marked as 'beforefieldinit'.
		static SpecGuestRefreshNode()
		{
			Il2CppClassPointerStore<CreatorBoxData.SpecGuestRefreshNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, "SpecGuestRefreshNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorBoxData.SpecGuestRefreshNode>.NativeClassPtr);
			CreatorBoxData.SpecGuestRefreshNode.NativeFieldInfoPtr_RefreshPointTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxData.SpecGuestRefreshNode>.NativeClassPtr, "RefreshPointTime");
			CreatorBoxData.SpecGuestRefreshNode.NativeFieldInfoPtr_SpecGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxData.SpecGuestRefreshNode>.NativeClassPtr, "SpecGuestId");
			CreatorBoxData.SpecGuestRefreshNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxData.SpecGuestRefreshNode>.NativeClassPtr, 100663326);
		}

		// Token: 0x06007BE8 RID: 31720 RVA: 0x00239244 File Offset: 0x00237444
		[CallerCount(104)]
		[CachedScanResults(RefRangeStart = 395, RefRangeEnd = 499, XrefRangeStart = 395, XrefRangeEnd = 395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecGuestRefreshNode(int time, int id)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxData.SpecGuestRefreshNode.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BE9 RID: 31721 RVA: 0x00042B6E File Offset: 0x00040D6E
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreatorBoxData.SpecGuestRefreshNode>.NativeClassPtr, ref this));
		}

		// Token: 0x04005181 RID: 20865
		private static readonly IntPtr NativeFieldInfoPtr_RefreshPointTime;

		// Token: 0x04005182 RID: 20866
		private static readonly IntPtr NativeFieldInfoPtr_SpecGuestId;

		// Token: 0x04005183 RID: 20867
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04005184 RID: 20868
		[FieldOffset(0)]
		public readonly int RefreshPointTime;

		// Token: 0x04005185 RID: 20869
		[FieldOffset(4)]
		public readonly int SpecGuestId;
	}

	// Token: 0x02000461 RID: 1121
	[ObfuscatedName("CreatorBoxData+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06007BEA RID: 31722 RVA: 0x00239284 File Offset: 0x00237484
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<CreatorBoxData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorBoxData>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorBoxData.__c>.NativeClassPtr);
			CreatorBoxData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxData.__c>.NativeClassPtr, "<>9");
			CreatorBoxData.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxData.__c>.NativeClassPtr, "<>9__4_0");
			CreatorBoxData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxData.__c>.NativeClassPtr, 100663328);
			CreatorBoxData.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_SpecGuestRefreshNode_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxData.__c>.NativeClassPtr, 100663329);
		}

		// Token: 0x06007BEB RID: 31723 RVA: 0x00239300 File Offset: 0x00237500
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 499, XrefRangeEnd = 500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorBoxData.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007BEC RID: 31724 RVA: 0x0023933C File Offset: 0x0023753C
		[CallerCount(0)]
		public unsafe CreatorBoxData.SpecGuestRefreshNode __ctor_b__4_0(ValueTuple<int, int> x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxData.__c.NativeMethodInfoPtr___ctor_b__4_0_Internal_SpecGuestRefreshNode_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007BED RID: 31725 RVA: 0x00042B80 File Offset: 0x00040D80
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A03 RID: 10755
		// (get) Token: 0x06007BEE RID: 31726 RVA: 0x00239390 File Offset: 0x00237590
		// (set) Token: 0x06007BEF RID: 31727 RVA: 0x00042B89 File Offset: 0x00040D89
		public unsafe static CreatorBoxData.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CreatorBoxData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorBoxData.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreatorBoxData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A04 RID: 10756
		// (get) Token: 0x06007BF0 RID: 31728 RVA: 0x002393B8 File Offset: 0x002375B8
		// (set) Token: 0x06007BF1 RID: 31729 RVA: 0x00042B9B File Offset: 0x00040D9B
		public unsafe static Func<ValueTuple<int, int>, CreatorBoxData.SpecGuestRefreshNode> __9__4_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CreatorBoxData.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, int>, CreatorBoxData.SpecGuestRefreshNode>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CreatorBoxData.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005186 RID: 20870
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04005187 RID: 20871
		private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

		// Token: 0x04005188 RID: 20872
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005189 RID: 20873
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__4_0_Internal_SpecGuestRefreshNode_ValueTuple_2_Int32_Int32_0;
	}
}
