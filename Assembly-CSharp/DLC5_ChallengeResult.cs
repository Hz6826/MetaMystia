using System;
using System.Runtime.InteropServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

// Token: 0x02000016 RID: 22
public class DLC5_ChallengeResult : UIPanelParamOpen<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>
{
	// Token: 0x060001BA RID: 442 RVA: 0x000A4A74 File Offset: 0x000A2C74
	// Note: this type is marked as 'beforefieldinit'.
	static DLC5_ChallengeResult()
	{
		Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC5_ChallengeResult");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr);
		DLC5_ChallengeResult.NativeFieldInfoPtr_confirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr, "confirm");
		DLC5_ChallengeResult.NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr, "cluster");
		DLC5_ChallengeResult.NativeFieldInfoPtr_risingEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr, "risingEffect");
		DLC5_ChallengeResult.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr, 100663544);
		DLC5_ChallengeResult.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_DLC5_ChallengeResultPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr, 100663545);
		DLC5_ChallengeResult.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr, 100663546);
		DLC5_ChallengeResult.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr, 100663547);
	}

	// Token: 0x060001BB RID: 443 RVA: 0x000A4B30 File Offset: 0x000A2D30
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19031, XrefRangeEnd = 19043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_ChallengeResult.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BC RID: 444 RVA: 0x000A4B6C File Offset: 0x000A2D6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19043, XrefRangeEnd = 19072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelOpen(DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext openContext)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = ref openContext;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_ChallengeResult.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_DLC5_ChallengeResultPannelOpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BD RID: 445 RVA: 0x000A4BB8 File Offset: 0x000A2DB8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_ChallengeResult.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BE RID: 446 RVA: 0x000A4BF4 File Offset: 0x000A2DF4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19072, XrefRangeEnd = 19075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC5_ChallengeResult() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_ChallengeResult.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001BF RID: 447 RVA: 0x00002E12 File Offset: 0x00001012
	public DLC5_ChallengeResult(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x060001C0 RID: 448 RVA: 0x000A4C30 File Offset: 0x000A2E30
	// (set) Token: 0x060001C1 RID: 449 RVA: 0x00002E1B File Offset: 0x0000101B
	public unsafe UIButtonSimple confirm
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_ChallengeResult.NativeFieldInfoPtr_confirm);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_ChallengeResult.NativeFieldInfoPtr_confirm), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060001C2 RID: 450 RVA: 0x000A4C60 File Offset: 0x000A2E60
	// (set) Token: 0x060001C3 RID: 451 RVA: 0x00002E3A File Offset: 0x0000103A
	public unsafe UIElementCluster cluster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_ChallengeResult.NativeFieldInfoPtr_cluster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_ChallengeResult.NativeFieldInfoPtr_cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x060001C4 RID: 452 RVA: 0x000A4C90 File Offset: 0x000A2E90
	// (set) Token: 0x060001C5 RID: 453 RVA: 0x00002E59 File Offset: 0x00001059
	public unsafe GameObject risingEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_ChallengeResult.NativeFieldInfoPtr_risingEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_ChallengeResult.NativeFieldInfoPtr_risingEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400011F RID: 287
	private static readonly IntPtr NativeFieldInfoPtr_confirm;

	// Token: 0x04000120 RID: 288
	private static readonly IntPtr NativeFieldInfoPtr_cluster;

	// Token: 0x04000121 RID: 289
	private static readonly IntPtr NativeFieldInfoPtr_risingEffect;

	// Token: 0x04000122 RID: 290
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

	// Token: 0x04000123 RID: 291
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_DLC5_ChallengeResultPannelOpenContext_0;

	// Token: 0x04000124 RID: 292
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x04000125 RID: 293
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200047F RID: 1151
	public enum OpenType
	{
		// Token: 0x0400521F RID: 21023
		Cook,
		// Token: 0x04005220 RID: 21024
		Music
	}

	// Token: 0x02000480 RID: 1152
	[StructLayout(2)]
	public struct DLC5_ChallengeResultPannelOpenContext
	{
		// Token: 0x06007CD2 RID: 31954 RVA: 0x0023BDB0 File Offset: 0x00239FB0
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_ChallengeResultPannelOpenContext()
		{
			Il2CppClassPointerStore<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_ChallengeResult>.NativeClassPtr, "DLC5_ChallengeResultPannelOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>.NativeClassPtr);
			DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext.NativeFieldInfoPtr_oldTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>.NativeClassPtr, "oldTime");
			DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext.NativeFieldInfoPtr_newTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>.NativeClassPtr, "newTime");
			DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext.NativeFieldInfoPtr_oldSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>.NativeClassPtr, "oldSpeed");
			DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext.NativeFieldInfoPtr_newSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>.NativeClassPtr, "newSpeed");
			DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>.NativeClassPtr, 100663548);
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x0023BE40 File Offset: 0x0023A040
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 19030, RefRangeEnd = 19031, XrefRangeStart = 19030, XrefRangeEnd = 19030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_ChallengeResultPannelOpenContext(int oldTime, int newTime, float oldSpeed, float newSpeed)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref oldTime;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldSpeed;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x000432F4 File Offset: 0x000414F4
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_ChallengeResult.DLC5_ChallengeResultPannelOpenContext>.NativeClassPtr, ref this));
		}

		// Token: 0x04005221 RID: 21025
		private static readonly IntPtr NativeFieldInfoPtr_oldTime;

		// Token: 0x04005222 RID: 21026
		private static readonly IntPtr NativeFieldInfoPtr_newTime;

		// Token: 0x04005223 RID: 21027
		private static readonly IntPtr NativeFieldInfoPtr_oldSpeed;

		// Token: 0x04005224 RID: 21028
		private static readonly IntPtr NativeFieldInfoPtr_newSpeed;

		// Token: 0x04005225 RID: 21029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Single_Single_0;

		// Token: 0x04005226 RID: 21030
		[FieldOffset(0)]
		public readonly int oldTime;

		// Token: 0x04005227 RID: 21031
		[FieldOffset(4)]
		public readonly int newTime;

		// Token: 0x04005228 RID: 21032
		[FieldOffset(8)]
		public readonly float oldSpeed;

		// Token: 0x04005229 RID: 21033
		[FieldOffset(12)]
		public readonly float newSpeed;
	}
}
