using System;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

// Token: 0x02000012 RID: 18
public class DaySceneSleepAndSavePrePannel : UIPanel
{
	// Token: 0x06000149 RID: 329 RVA: 0x000A32B0 File Offset: 0x000A14B0
	// Note: this type is marked as 'beforefieldinit'.
	static DaySceneSleepAndSavePrePannel()
	{
		Il2CppClassPointerStore<DaySceneSleepAndSavePrePannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DaySceneSleepAndSavePrePannel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneSleepAndSavePrePannel>.NativeClassPtr);
		DaySceneSleepAndSavePrePannel.NativeFieldInfoPtr_haveEventDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePrePannel>.NativeClassPtr, "haveEventDialog");
		DaySceneSleepAndSavePrePannel.NativeFieldInfoPtr_pannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneSleepAndSavePrePannel>.NativeClassPtr, "pannel");
		DaySceneSleepAndSavePrePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePrePannel>.NativeClassPtr, 100663458);
		DaySceneSleepAndSavePrePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePrePannel>.NativeClassPtr, 100663459);
		DaySceneSleepAndSavePrePannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneSleepAndSavePrePannel>.NativeClassPtr, 100663460);
	}

	// Token: 0x0600014A RID: 330 RVA: 0x000A3344 File Offset: 0x000A1544
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17703, XrefRangeEnd = 17723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSleepAndSavePrePannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600014B RID: 331 RVA: 0x000A3380 File Offset: 0x000A1580
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 17723, XrefRangeEnd = 17726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneSleepAndSavePrePannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600014C RID: 332 RVA: 0x000A33BC File Offset: 0x000A15BC
	[CallerCount(100)]
	[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17726, XrefRangeEnd = 17727, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DaySceneSleepAndSavePrePannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneSleepAndSavePrePannel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneSleepAndSavePrePannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00002A52 File Offset: 0x00000C52
	public DaySceneSleepAndSavePrePannel(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x0600014E RID: 334 RVA: 0x000A33F8 File Offset: 0x000A15F8
	// (set) Token: 0x0600014F RID: 335 RVA: 0x00002A5B File Offset: 0x00000C5B
	public unsafe DialogPackage haveEventDialog
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePrePannel.NativeFieldInfoPtr_haveEventDialog);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePrePannel.NativeFieldInfoPtr_haveEventDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x06000150 RID: 336 RVA: 0x000A3428 File Offset: 0x000A1628
	// (set) Token: 0x06000151 RID: 337 RVA: 0x00002A7A File Offset: 0x00000C7A
	public unsafe DaySceneSleepAndSavePannel pannel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePrePannel.NativeFieldInfoPtr_pannel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneSleepAndSavePannel>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneSleepAndSavePrePannel.NativeFieldInfoPtr_pannel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000D3 RID: 211
	private static readonly IntPtr NativeFieldInfoPtr_haveEventDialog;

	// Token: 0x040000D4 RID: 212
	private static readonly IntPtr NativeFieldInfoPtr_pannel;

	// Token: 0x040000D5 RID: 213
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

	// Token: 0x040000D6 RID: 214
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x040000D7 RID: 215
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
}
