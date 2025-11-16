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

// Token: 0x02000015 RID: 21
public class DLC3_BossBattleResultPannel : UIPanel
{
	// Token: 0x060001A6 RID: 422 RVA: 0x000A46D0 File Offset: 0x000A28D0
	// Note: this type is marked as 'beforefieldinit'.
	static DLC3_BossBattleResultPannel()
	{
		Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC3_BossBattleResultPannel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr);
		DLC3_BossBattleResultPannel.NativeFieldInfoPtr_confirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, "confirm");
		DLC3_BossBattleResultPannel.NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, "cluster");
		DLC3_BossBattleResultPannel.NativeFieldInfoPtr_cookPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, "cookPage");
		DLC3_BossBattleResultPannel.NativeFieldInfoPtr_musicPage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, "musicPage");
		DLC3_BossBattleResultPannel.NativeFieldInfoPtr_risingEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, "risingEffect");
		DLC3_BossBattleResultPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, "<PannelOpenContext>k__BackingField");
		DLC3_BossBattleResultPannel.NativeMethodInfoPtr_get_PannelOpenContext_Private_get_BossBattleResultPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, 100663537);
		DLC3_BossBattleResultPannel.NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_BossBattleResultPannelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, 100663538);
		DLC3_BossBattleResultPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, 100663539);
		DLC3_BossBattleResultPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, 100663540);
		DLC3_BossBattleResultPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, 100663541);
		DLC3_BossBattleResultPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, 100663542);
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060001A7 RID: 423 RVA: 0x000A47F0 File Offset: 0x000A29F0
	// (set) Token: 0x060001A8 RID: 424 RVA: 0x000A482C File Offset: 0x000A2A2C
	public unsafe DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext PannelOpenContext
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleResultPannel.NativeMethodInfoPtr_get_PannelOpenContext_Private_get_BossBattleResultPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
		[CallerCount(0)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleResultPannel.NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_BossBattleResultPannelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x060001A9 RID: 425 RVA: 0x000A486C File Offset: 0x000A2A6C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18983, XrefRangeEnd = 18993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_BossBattleResultPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AA RID: 426 RVA: 0x000A48A8 File Offset: 0x000A2AA8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18993, XrefRangeEnd = 19024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_BossBattleResultPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AB RID: 427 RVA: 0x000A48E4 File Offset: 0x000A2AE4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 19024, XrefRangeEnd = 19030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_BossBattleResultPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AC RID: 428 RVA: 0x000A4920 File Offset: 0x000A2B20
	[CallerCount(100)]
	[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC3_BossBattleResultPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleResultPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060001AD RID: 429 RVA: 0x00002D53 File Offset: 0x00000F53
	public DLC3_BossBattleResultPannel(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060001AE RID: 430 RVA: 0x000A495C File Offset: 0x000A2B5C
	// (set) Token: 0x060001AF RID: 431 RVA: 0x00002D5C File Offset: 0x00000F5C
	public unsafe UIButtonSimple confirm
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_confirm);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_confirm), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060001B0 RID: 432 RVA: 0x000A498C File Offset: 0x000A2B8C
	// (set) Token: 0x060001B1 RID: 433 RVA: 0x00002D7B File Offset: 0x00000F7B
	public unsafe UIElementCluster cluster
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_cluster);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x060001B2 RID: 434 RVA: 0x000A49BC File Offset: 0x000A2BBC
	// (set) Token: 0x060001B3 RID: 435 RVA: 0x00002D9A File Offset: 0x00000F9A
	public unsafe GameObject cookPage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_cookPage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_cookPage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x060001B4 RID: 436 RVA: 0x000A49EC File Offset: 0x000A2BEC
	// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002DB9 File Offset: 0x00000FB9
	public unsafe GameObject musicPage
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_musicPage);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_musicPage), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x060001B6 RID: 438 RVA: 0x000A4A1C File Offset: 0x000A2C1C
	// (set) Token: 0x060001B7 RID: 439 RVA: 0x00002DD8 File Offset: 0x00000FD8
	public unsafe GameObject risingEffect
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_risingEffect);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr_risingEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x060001B8 RID: 440 RVA: 0x000A4A4C File Offset: 0x000A2C4C
	// (set) Token: 0x060001B9 RID: 441 RVA: 0x00002DF7 File Offset: 0x00000FF7
	public unsafe DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext _PannelOpenContext_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_BossBattleResultPannel.NativeFieldInfoPtr__PannelOpenContext_k__BackingField)) = value;
		}
	}

	// Token: 0x04000113 RID: 275
	private static readonly IntPtr NativeFieldInfoPtr_confirm;

	// Token: 0x04000114 RID: 276
	private static readonly IntPtr NativeFieldInfoPtr_cluster;

	// Token: 0x04000115 RID: 277
	private static readonly IntPtr NativeFieldInfoPtr_cookPage;

	// Token: 0x04000116 RID: 278
	private static readonly IntPtr NativeFieldInfoPtr_musicPage;

	// Token: 0x04000117 RID: 279
	private static readonly IntPtr NativeFieldInfoPtr_risingEffect;

	// Token: 0x04000118 RID: 280
	private static readonly IntPtr NativeFieldInfoPtr__PannelOpenContext_k__BackingField;

	// Token: 0x04000119 RID: 281
	private static readonly IntPtr NativeMethodInfoPtr_get_PannelOpenContext_Private_get_BossBattleResultPannelOpenContext_0;

	// Token: 0x0400011A RID: 282
	private static readonly IntPtr NativeMethodInfoPtr_set_PannelOpenContext_Public_set_Void_BossBattleResultPannelOpenContext_0;

	// Token: 0x0400011B RID: 283
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

	// Token: 0x0400011C RID: 284
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

	// Token: 0x0400011D RID: 285
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x0400011E RID: 286
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x0200047D RID: 1149
	public enum OpenType
	{
		// Token: 0x04005213 RID: 21011
		Cook,
		// Token: 0x04005214 RID: 21012
		Music
	}

	// Token: 0x0200047E RID: 1150
	[StructLayout(2)]
	public struct BossBattleResultPannelOpenContext
	{
		// Token: 0x06007CCF RID: 31951 RVA: 0x0023BCC4 File Offset: 0x00239EC4
		// Note: this type is marked as 'beforefieldinit'.
		static BossBattleResultPannelOpenContext()
		{
			Il2CppClassPointerStore<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_BossBattleResultPannel>.NativeClassPtr, "BossBattleResultPannelOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>.NativeClassPtr);
			DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext.NativeFieldInfoPtr_openType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>.NativeClassPtr, "openType");
			DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext.NativeFieldInfoPtr_myScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>.NativeClassPtr, "myScore");
			DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext.NativeFieldInfoPtr_bossScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>.NativeClassPtr, "bossScore");
			DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext.NativeFieldInfoPtr_maxCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>.NativeClassPtr, "maxCombo");
			DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_OpenType_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>.NativeClassPtr, 100663543);
		}

		// Token: 0x06007CD0 RID: 31952 RVA: 0x0023BD54 File Offset: 0x00239F54
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 18946, RefRangeEnd = 18983, XrefRangeStart = 18946, XrefRangeEnd = 18946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BossBattleResultPannelOpenContext(DLC3_BossBattleResultPannel.OpenType openType, int myScore, int bossScore, int maxCombo)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref myScore;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bossScore;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxCombo;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_OpenType_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x000432E2 File Offset: 0x000414E2
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_BossBattleResultPannel.BossBattleResultPannelOpenContext>.NativeClassPtr, ref this));
		}

		// Token: 0x04005215 RID: 21013
		private static readonly IntPtr NativeFieldInfoPtr_openType;

		// Token: 0x04005216 RID: 21014
		private static readonly IntPtr NativeFieldInfoPtr_myScore;

		// Token: 0x04005217 RID: 21015
		private static readonly IntPtr NativeFieldInfoPtr_bossScore;

		// Token: 0x04005218 RID: 21016
		private static readonly IntPtr NativeFieldInfoPtr_maxCombo;

		// Token: 0x04005219 RID: 21017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_OpenType_Int32_Int32_Int32_0;

		// Token: 0x0400521A RID: 21018
		[FieldOffset(0)]
		public readonly DLC3_BossBattleResultPannel.OpenType openType;

		// Token: 0x0400521B RID: 21019
		[FieldOffset(4)]
		public readonly int myScore;

		// Token: 0x0400521C RID: 21020
		[FieldOffset(8)]
		public readonly int bossScore;

		// Token: 0x0400521D RID: 21021
		[FieldOffset(12)]
		public readonly int maxCombo;
	}
}
