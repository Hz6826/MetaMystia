using System;
using DEYU.AdpUISystem.PanelCollection;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using MusicGame.UI;
using NightScene;
using UnityEngine;

// Token: 0x02000014 RID: 20
public class DLC3_MusicGameStartPannel : UIPanel
{
	// Token: 0x0600017F RID: 383 RVA: 0x000A3EC0 File Offset: 0x000A20C0
	// Note: this type is marked as 'beforefieldinit'.
	static DLC3_MusicGameStartPannel()
	{
		Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "", "DLC3_MusicGameStartPannel");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr);
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr_bossAndChapterMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "bossAndChapterMapping");
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr_DLC3_MusicGameMainPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "DLC3_MusicGameMainPannel");
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr_ResultPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "ResultPannel");
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr_reconfirmPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "reconfirmPannel");
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr_mystiaSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "mystiaSprites");
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr_chapterDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "chapterDic");
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "<MusicalNoteSpeed>k__BackingField");
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr__BossLabel_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "<BossLabel>k__BackingField");
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr__ResultMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "<ResultMode>k__BackingField");
		DLC3_MusicGameStartPannel.NativeFieldInfoPtr__playMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "<playMode>k__BackingField");
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_get_MusicalNoteSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663509);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_set_MusicalNoteSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663510);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_get_BossLabel_Private_get_ChallengeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663511);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_set_BossLabel_Public_set_Void_ChallengeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663512);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_get_ResultMode_Private_get_FinalResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663513);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_set_ResultMode_Public_set_Void_FinalResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663514);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_get_playMode_Public_get_PlaySkipMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663515);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_set_playMode_Public_set_Void_PlaySkipMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663516);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OnGUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663517);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663518);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663519);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OpenMainPannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663520);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OpenResultPannel_Private_Void_DLC3_MusicGameMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663521);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_AfterChallenge_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663522);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663523);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663524);
		DLC3_MusicGameStartPannel.NativeMethodInfoPtr__OnPanelOpen_b__26_0_Private_Void_MusicSelectorReconfirmPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, 100663525);
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000180 RID: 384 RVA: 0x000A410C File Offset: 0x000A230C
	// (set) Token: 0x06000181 RID: 385 RVA: 0x000A4148 File Offset: 0x000A2348
	public unsafe float MusicalNoteSpeed
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_get_MusicalNoteSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_set_MusicalNoteSpeed_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x06000182 RID: 386 RVA: 0x000A4188 File Offset: 0x000A2388
	// (set) Token: 0x06000183 RID: 387 RVA: 0x000A41C4 File Offset: 0x000A23C4
	public unsafe NightSceneDirector.ChallengeType BossLabel
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_get_BossLabel_Private_get_ChallengeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_set_BossLabel_Public_set_Void_ChallengeType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06000184 RID: 388 RVA: 0x000A4204 File Offset: 0x000A2404
	// (set) Token: 0x06000185 RID: 389 RVA: 0x000A4240 File Offset: 0x000A2440
	public unsafe DLC3_MusicGameStartPannel.FinalResult ResultMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_get_ResultMode_Private_get_FinalResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_set_ResultMode_Public_set_Void_FinalResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x06000186 RID: 390 RVA: 0x000A4280 File Offset: 0x000A2480
	// (set) Token: 0x06000187 RID: 391 RVA: 0x000A42BC File Offset: 0x000A24BC
	public unsafe DLC3_MusicGameStartPannel.PlaySkipMode playMode
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_get_playMode_Public_get_PlaySkipMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_set_playMode_Public_set_Void_PlaySkipMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x06000188 RID: 392 RVA: 0x000A42FC File Offset: 0x000A24FC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18737, XrefRangeEnd = 18780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OnGUI()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OnGUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000189 RID: 393 RVA: 0x000A4330 File Offset: 0x000A2530
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18780, XrefRangeEnd = 18845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelInitialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600018A RID: 394 RVA: 0x000A436C File Offset: 0x000A256C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18845, XrefRangeEnd = 18868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void OnPanelOpen()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600018B RID: 395 RVA: 0x000A43A8 File Offset: 0x000A25A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18868, XrefRangeEnd = 18898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenMainPannel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OpenMainPannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600018C RID: 396 RVA: 0x000A43DC File Offset: 0x000A25DC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18898, XrefRangeEnd = 18917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void OpenResultPannel(DLC3_MusicGameMainPannel closedMainPannel)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(closedMainPannel);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_OpenResultPannel_Private_Void_DLC3_MusicGameMainPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600018D RID: 397 RVA: 0x000A4420 File Offset: 0x000A2620
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18917, XrefRangeEnd = 18935, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void AfterChallenge()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr_AfterChallenge_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600018E RID: 398 RVA: 0x000A4454 File Offset: 0x000A2654
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18935, XrefRangeEnd = 18941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Cleanup_Generated()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3_MusicGameStartPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600018F RID: 399 RVA: 0x000A4490 File Offset: 0x000A2690
	[CallerCount(100)]
	[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe DLC3_MusicGameStartPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x000A44CC File Offset: 0x000A26CC
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18941, XrefRangeEnd = 18946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void _OnPanelOpen_b__26_0(MusicSelectorReconfirmPannel x)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
		*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.NativeMethodInfoPtr__OnPanelOpen_b__26_0_Private_Void_MusicSelectorReconfirmPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x00002C15 File Offset: 0x00000E15
	public DLC3_MusicGameStartPannel(IntPtr pointer) : base(pointer)
	{
	}

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x06000192 RID: 402 RVA: 0x000A4510 File Offset: 0x000A2710
	// (set) Token: 0x06000193 RID: 403 RVA: 0x00002C1E File Offset: 0x00000E1E
	public unsafe Il2CppReferenceArray<DLC3_MusicGameStartPannel.BossMusicChapterMapping> bossAndChapterMapping
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_bossAndChapterMapping);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC3_MusicGameStartPannel.BossMusicChapterMapping>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_bossAndChapterMapping), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x06000194 RID: 404 RVA: 0x000A4540 File Offset: 0x000A2740
	// (set) Token: 0x06000195 RID: 405 RVA: 0x00002C3D File Offset: 0x00000E3D
	public unsafe DLC3_MusicGameMainPannel DLC3_MusicGameMainPannel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_DLC3_MusicGameMainPannel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MusicGameMainPannel>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_DLC3_MusicGameMainPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000196 RID: 406 RVA: 0x000A4570 File Offset: 0x000A2770
	// (set) Token: 0x06000197 RID: 407 RVA: 0x00002C5C File Offset: 0x00000E5C
	public unsafe DLC3_BossBattleResultPannel ResultPannel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_ResultPannel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_BossBattleResultPannel>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_ResultPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000198 RID: 408 RVA: 0x000A45A0 File Offset: 0x000A27A0
	// (set) Token: 0x06000199 RID: 409 RVA: 0x00002C7B File Offset: 0x00000E7B
	public unsafe MusicSelectorReconfirmPannel reconfirmPannel
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_reconfirmPannel);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorReconfirmPannel>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_reconfirmPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x0600019A RID: 410 RVA: 0x000A45D0 File Offset: 0x000A27D0
	// (set) Token: 0x0600019B RID: 411 RVA: 0x00002C9A File Offset: 0x00000E9A
	public DLC3_MusicGameStartPannel.RockSprites mystiaSprites
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_mystiaSprites);
			return new DLC3_MusicGameStartPannel.RockSprites(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr, intPtr));
		}
		set
		{
			cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_mystiaSprites), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr, (UIntPtr)0));
		}
	}

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x0600019C RID: 412 RVA: 0x000A4600 File Offset: 0x000A2800
	// (set) Token: 0x0600019D RID: 413 RVA: 0x00002CC8 File Offset: 0x00000EC8
	public unsafe Dictionary<NightSceneDirector.ChallengeType, ValueTuple<MusicGameChapterProfile.MusicChapter, DLC3_MusicGameStartPannel.BossMusicChapterMapping>> chapterDic
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_chapterDic);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<NightSceneDirector.ChallengeType, ValueTuple<MusicGameChapterProfile.MusicChapter, DLC3_MusicGameStartPannel.BossMusicChapterMapping>>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr_chapterDic), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x0600019E RID: 414 RVA: 0x000A4630 File Offset: 0x000A2830
	// (set) Token: 0x0600019F RID: 415 RVA: 0x00002CE7 File Offset: 0x00000EE7
	public unsafe float _MusicalNoteSpeed_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField)) = value;
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060001A0 RID: 416 RVA: 0x000A4658 File Offset: 0x000A2858
	// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002D02 File Offset: 0x00000F02
	public unsafe NightSceneDirector.ChallengeType _BossLabel_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr__BossLabel_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr__BossLabel_k__BackingField)) = value;
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060001A2 RID: 418 RVA: 0x000A4680 File Offset: 0x000A2880
	// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002D1D File Offset: 0x00000F1D
	public unsafe DLC3_MusicGameStartPannel.FinalResult _ResultMode_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr__ResultMode_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr__ResultMode_k__BackingField)) = value;
		}
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x060001A4 RID: 420 RVA: 0x000A46A8 File Offset: 0x000A28A8
	// (set) Token: 0x060001A5 RID: 421 RVA: 0x00002D38 File Offset: 0x00000F38
	public unsafe DLC3_MusicGameStartPannel.PlaySkipMode _playMode_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr__playMode_k__BackingField);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.NativeFieldInfoPtr__playMode_k__BackingField)) = value;
		}
	}

	// Token: 0x040000F8 RID: 248
	private static readonly IntPtr NativeFieldInfoPtr_bossAndChapterMapping;

	// Token: 0x040000F9 RID: 249
	private static readonly IntPtr NativeFieldInfoPtr_DLC3_MusicGameMainPannel;

	// Token: 0x040000FA RID: 250
	private static readonly IntPtr NativeFieldInfoPtr_ResultPannel;

	// Token: 0x040000FB RID: 251
	private static readonly IntPtr NativeFieldInfoPtr_reconfirmPannel;

	// Token: 0x040000FC RID: 252
	private static readonly IntPtr NativeFieldInfoPtr_mystiaSprites;

	// Token: 0x040000FD RID: 253
	private static readonly IntPtr NativeFieldInfoPtr_chapterDic;

	// Token: 0x040000FE RID: 254
	private static readonly IntPtr NativeFieldInfoPtr__MusicalNoteSpeed_k__BackingField;

	// Token: 0x040000FF RID: 255
	private static readonly IntPtr NativeFieldInfoPtr__BossLabel_k__BackingField;

	// Token: 0x04000100 RID: 256
	private static readonly IntPtr NativeFieldInfoPtr__ResultMode_k__BackingField;

	// Token: 0x04000101 RID: 257
	private static readonly IntPtr NativeFieldInfoPtr__playMode_k__BackingField;

	// Token: 0x04000102 RID: 258
	private static readonly IntPtr NativeMethodInfoPtr_get_MusicalNoteSpeed_Public_get_Single_0;

	// Token: 0x04000103 RID: 259
	private static readonly IntPtr NativeMethodInfoPtr_set_MusicalNoteSpeed_Private_set_Void_Single_0;

	// Token: 0x04000104 RID: 260
	private static readonly IntPtr NativeMethodInfoPtr_get_BossLabel_Private_get_ChallengeType_0;

	// Token: 0x04000105 RID: 261
	private static readonly IntPtr NativeMethodInfoPtr_set_BossLabel_Public_set_Void_ChallengeType_0;

	// Token: 0x04000106 RID: 262
	private static readonly IntPtr NativeMethodInfoPtr_get_ResultMode_Private_get_FinalResult_0;

	// Token: 0x04000107 RID: 263
	private static readonly IntPtr NativeMethodInfoPtr_set_ResultMode_Public_set_Void_FinalResult_0;

	// Token: 0x04000108 RID: 264
	private static readonly IntPtr NativeMethodInfoPtr_get_playMode_Public_get_PlaySkipMode_0;

	// Token: 0x04000109 RID: 265
	private static readonly IntPtr NativeMethodInfoPtr_set_playMode_Public_set_Void_PlaySkipMode_0;

	// Token: 0x0400010A RID: 266
	private static readonly IntPtr NativeMethodInfoPtr_OnGUI_Private_Void_0;

	// Token: 0x0400010B RID: 267
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

	// Token: 0x0400010C RID: 268
	private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

	// Token: 0x0400010D RID: 269
	private static readonly IntPtr NativeMethodInfoPtr_OpenMainPannel_Private_Void_0;

	// Token: 0x0400010E RID: 270
	private static readonly IntPtr NativeMethodInfoPtr_OpenResultPannel_Private_Void_DLC3_MusicGameMainPannel_0;

	// Token: 0x0400010F RID: 271
	private static readonly IntPtr NativeMethodInfoPtr_AfterChallenge_Private_Void_0;

	// Token: 0x04000110 RID: 272
	private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

	// Token: 0x04000111 RID: 273
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x04000112 RID: 274
	private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__26_0_Private_Void_MusicSelectorReconfirmPannel_0;

	// Token: 0x02000477 RID: 1143
	public enum FinalResult
	{
		// Token: 0x040051F4 RID: 20980
		Win,
		// Token: 0x040051F5 RID: 20981
		Lose
	}

	// Token: 0x02000478 RID: 1144
	public enum PlaySkipMode
	{
		// Token: 0x040051F7 RID: 20983
		Win,
		// Token: 0x040051F8 RID: 20984
		Lose,
		// Token: 0x040051F9 RID: 20985
		Normal
	}

	// Token: 0x02000479 RID: 1145
	[Serializable]
	public sealed class RockSprites : ValueType
	{
		// Token: 0x06007C9F RID: 31903 RVA: 0x0023B4F4 File Offset: 0x002396F4
		// Note: this type is marked as 'beforefieldinit'.
		static RockSprites()
		{
			Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "RockSprites");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr);
			DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_wait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr, "wait");
			DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_wait2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr, "wait2");
			DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_rock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr, "rock");
			DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_rock2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr, "rock2");
			DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_wrong = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr, "wrong");
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x00043108 File Offset: 0x00041308
		public RockSprites(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x00043111 File Offset: 0x00041311
		public RockSprites() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr))
		{
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x06007CA2 RID: 31906 RVA: 0x0023B584 File Offset: 0x00239784
		// (set) Token: 0x06007CA3 RID: 31907 RVA: 0x00043123 File Offset: 0x00041323
		public unsafe Sprite wait
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_wait);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_wait), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x06007CA4 RID: 31908 RVA: 0x0023B5B4 File Offset: 0x002397B4
		// (set) Token: 0x06007CA5 RID: 31909 RVA: 0x00043142 File Offset: 0x00041342
		public unsafe Sprite wait2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_wait2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_wait2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x06007CA6 RID: 31910 RVA: 0x0023B5E4 File Offset: 0x002397E4
		// (set) Token: 0x06007CA7 RID: 31911 RVA: 0x00043161 File Offset: 0x00041361
		public unsafe Sprite rock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_rock);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_rock), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x06007CA8 RID: 31912 RVA: 0x0023B614 File Offset: 0x00239814
		// (set) Token: 0x06007CA9 RID: 31913 RVA: 0x00043180 File Offset: 0x00041380
		public unsafe Sprite rock2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_rock2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_rock2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x06007CAA RID: 31914 RVA: 0x0023B644 File Offset: 0x00239844
		// (set) Token: 0x06007CAB RID: 31915 RVA: 0x0004319F File Offset: 0x0004139F
		public unsafe Sprite wrong
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_wrong);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.RockSprites.NativeFieldInfoPtr_wrong), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040051FA RID: 20986
		private static readonly IntPtr NativeFieldInfoPtr_wait;

		// Token: 0x040051FB RID: 20987
		private static readonly IntPtr NativeFieldInfoPtr_wait2;

		// Token: 0x040051FC RID: 20988
		private static readonly IntPtr NativeFieldInfoPtr_rock;

		// Token: 0x040051FD RID: 20989
		private static readonly IntPtr NativeFieldInfoPtr_rock2;

		// Token: 0x040051FE RID: 20990
		private static readonly IntPtr NativeFieldInfoPtr_wrong;
	}

	// Token: 0x0200047A RID: 1146
	[Serializable]
	public sealed class BossMusicChapterMapping : ValueType
	{
		// Token: 0x06007CAC RID: 31916 RVA: 0x0023B674 File Offset: 0x00239874
		// Note: this type is marked as 'beforefieldinit'.
		static BossMusicChapterMapping()
		{
			Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "BossMusicChapterMapping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr);
			DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_bossLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr, "bossLabel");
			DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_chapterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr, "chapterLabel");
			DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_missCombo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr, "missCombo");
			DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_rockSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr, "rockSprites");
			DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr__ctor_Public_Void_ChallengeType_String_Vector2Int_RockSprites_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr, 100663526);
			DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr_get_BossLabel_Public_get_ChallengeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr, 100663527);
			DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr_get_ChapterLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr, 100663528);
			DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr_get_MissCombo_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr, 100663529);
			DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr_get_RockSprites_Public_get_RockSprites_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr, 100663530);
		}

		// Token: 0x06007CAD RID: 31917 RVA: 0x0023B754 File Offset: 0x00239954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18566, XrefRangeEnd = 18568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BossMusicChapterMapping(NightSceneDirector.ChallengeType bossLabel, string chapterLabel, Vector2Int missCombo, DLC3_MusicGameStartPannel.RockSprites rockSprites) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref bossLabel;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(chapterLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref missCombo;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rockSprites));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr__ctor_Public_Void_ChallengeType_String_Vector2Int_RockSprites_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x06007CAE RID: 31918 RVA: 0x0023B7D8 File Offset: 0x002399D8
		public unsafe NightSceneDirector.ChallengeType BossLabel
		{
			[CallerCount(140)]
			[CachedScanResults(RefRangeStart = 18568, RefRangeEnd = 18708, XrefRangeStart = 18568, XrefRangeEnd = 18568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr_get_BossLabel_Public_get_ChallengeType_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x06007CAF RID: 31919 RVA: 0x0023B81C File Offset: 0x00239A1C
		public unsafe string ChapterLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr_get_ChapterLabel_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x06007CB0 RID: 31920 RVA: 0x0023B858 File Offset: 0x00239A58
		public unsafe Vector2Int MissCombo
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr_get_MissCombo_Public_get_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17002A3D RID: 10813
		// (get) Token: 0x06007CB1 RID: 31921 RVA: 0x0023B89C File Offset: 0x00239A9C
		public unsafe DLC3_MusicGameStartPannel.RockSprites RockSprites
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeMethodInfoPtr_get_RockSprites_Public_get_RockSprites_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC3_MusicGameStartPannel.RockSprites(pointer);
			}
		}

		// Token: 0x06007CB2 RID: 31922 RVA: 0x000431BE File Offset: 0x000413BE
		public BossMusicChapterMapping(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x000431C7 File Offset: 0x000413C7
		public BossMusicChapterMapping() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.BossMusicChapterMapping>.NativeClassPtr))
		{
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x06007CB4 RID: 31924 RVA: 0x0023B8D8 File Offset: 0x00239AD8
		// (set) Token: 0x06007CB5 RID: 31925 RVA: 0x000431D9 File Offset: 0x000413D9
		public unsafe NightSceneDirector.ChallengeType bossLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_bossLabel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_bossLabel)) = value;
			}
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x0023B900 File Offset: 0x00239B00
		// (set) Token: 0x06007CB7 RID: 31927 RVA: 0x000431F4 File Offset: 0x000413F4
		public unsafe string chapterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_chapterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_chapterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x06007CB8 RID: 31928 RVA: 0x0023B928 File Offset: 0x00239B28
		// (set) Token: 0x06007CB9 RID: 31929 RVA: 0x00043213 File Offset: 0x00041413
		public unsafe Vector2Int missCombo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_missCombo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_missCombo)) = value;
			}
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x06007CBA RID: 31930 RVA: 0x0023B950 File Offset: 0x00239B50
		// (set) Token: 0x06007CBB RID: 31931 RVA: 0x0004322E File Offset: 0x0004142E
		public DLC3_MusicGameStartPannel.RockSprites rockSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_rockSprites);
				return new DLC3_MusicGameStartPannel.RockSprites(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.BossMusicChapterMapping.NativeFieldInfoPtr_rockSprites), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.RockSprites>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040051FF RID: 20991
		private static readonly IntPtr NativeFieldInfoPtr_bossLabel;

		// Token: 0x04005200 RID: 20992
		private static readonly IntPtr NativeFieldInfoPtr_chapterLabel;

		// Token: 0x04005201 RID: 20993
		private static readonly IntPtr NativeFieldInfoPtr_missCombo;

		// Token: 0x04005202 RID: 20994
		private static readonly IntPtr NativeFieldInfoPtr_rockSprites;

		// Token: 0x04005203 RID: 20995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ChallengeType_String_Vector2Int_RockSprites_0;

		// Token: 0x04005204 RID: 20996
		private static readonly IntPtr NativeMethodInfoPtr_get_BossLabel_Public_get_ChallengeType_0;

		// Token: 0x04005205 RID: 20997
		private static readonly IntPtr NativeMethodInfoPtr_get_ChapterLabel_Public_get_String_0;

		// Token: 0x04005206 RID: 20998
		private static readonly IntPtr NativeMethodInfoPtr_get_MissCombo_Public_get_Vector2Int_0;

		// Token: 0x04005207 RID: 20999
		private static readonly IntPtr NativeMethodInfoPtr_get_RockSprites_Public_get_RockSprites_0;
	}

	// Token: 0x0200047B RID: 1147
	[ObfuscatedName("DLC3_MusicGameStartPannel+<>c")]
	[Serializable]
	public sealed class __c : Il2CppSystem.Object
	{
		// Token: 0x06007CBC RID: 31932 RVA: 0x0023B980 File Offset: 0x00239B80
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c>.NativeClassPtr);
			DLC3_MusicGameStartPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c>.NativeClassPtr, "<>9");
			DLC3_MusicGameStartPannel.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c>.NativeClassPtr, "<>9__25_0");
			DLC3_MusicGameStartPannel.__c.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c>.NativeClassPtr, "<>9__25_1");
			DLC3_MusicGameStartPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c>.NativeClassPtr, 100663532);
			DLC3_MusicGameStartPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__25_0_Internal_String_BossMusicChapterMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c>.NativeClassPtr, 100663533);
			DLC3_MusicGameStartPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__25_1_Internal_MusicChapter_BossMusicChapterMapping_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c>.NativeClassPtr, 100663534);
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x0023BA24 File Offset: 0x00239C24
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x0023BA60 File Offset: 0x00239C60
		[CallerCount(0)]
		public unsafe string _OnPanelInitialize_b__25_0(DLC3_MusicGameStartPannel.BossMusicChapterMapping x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__25_0_Internal_String_BossMusicChapterMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007CBF RID: 31935 RVA: 0x0023BAB0 File Offset: 0x00239CB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18708, XrefRangeEnd = 18709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameChapterProfile.MusicChapter _OnPanelInitialize_b__25_1(DLC3_MusicGameStartPannel.BossMusicChapterMapping y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__25_1_Internal_MusicChapter_BossMusicChapterMapping_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new MusicGameChapterProfile.MusicChapter(pointer);
		}

		// Token: 0x06007CC0 RID: 31936 RVA: 0x0004325C File Offset: 0x0004145C
		public __c(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A3E RID: 10814
		// (get) Token: 0x06007CC1 RID: 31937 RVA: 0x0023BB00 File Offset: 0x00239D00
		// (set) Token: 0x06007CC2 RID: 31938 RVA: 0x00043265 File Offset: 0x00041465
		public unsafe static DLC3_MusicGameStartPannel.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameStartPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MusicGameStartPannel.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameStartPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A3F RID: 10815
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x0023BB28 File Offset: 0x00239D28
		// (set) Token: 0x06007CC4 RID: 31940 RVA: 0x00043277 File Offset: 0x00041477
		public unsafe static Func<DLC3_MusicGameStartPannel.BossMusicChapterMapping, string> __9__25_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameStartPannel.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC3_MusicGameStartPannel.BossMusicChapterMapping, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameStartPannel.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A40 RID: 10816
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x0023BB50 File Offset: 0x00239D50
		// (set) Token: 0x06007CC6 RID: 31942 RVA: 0x00043289 File Offset: 0x00041489
		public unsafe static Func<DLC3_MusicGameStartPannel.BossMusicChapterMapping, MusicGameChapterProfile.MusicChapter> __9__25_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC3_MusicGameStartPannel.__c.NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC3_MusicGameStartPannel.BossMusicChapterMapping, MusicGameChapterProfile.MusicChapter>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC3_MusicGameStartPannel.__c.NativeFieldInfoPtr___9__25_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005208 RID: 21000
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04005209 RID: 21001
		private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

		// Token: 0x0400520A RID: 21002
		private static readonly IntPtr NativeFieldInfoPtr___9__25_1;

		// Token: 0x0400520B RID: 21003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400520C RID: 21004
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__25_0_Internal_String_BossMusicChapterMapping_0;

		// Token: 0x0400520D RID: 21005
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__25_1_Internal_MusicChapter_BossMusicChapterMapping_0;
	}

	// Token: 0x0200047C RID: 1148
	[ObfuscatedName("DLC3_MusicGameStartPannel+<>c__DisplayClass27_0")]
	public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
	{
		// Token: 0x06007CC7 RID: 31943 RVA: 0x0023BB78 File Offset: 0x00239D78
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass27_0()
		{
			Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC3_MusicGameStartPannel>.NativeClassPtr, "<>c__DisplayClass27_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c__DisplayClass27_0>.NativeClassPtr);
			DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
			DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeFieldInfoPtr_pannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c__DisplayClass27_0>.NativeClassPtr, "pannel");
			DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c__DisplayClass27_0>.NativeClassPtr, 100663535);
			DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__OpenMainPannel_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c__DisplayClass27_0>.NativeClassPtr, 100663536);
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x0023BBF4 File Offset: 0x00239DF4
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3_MusicGameStartPannel.__c__DisplayClass27_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CC9 RID: 31945 RVA: 0x0023BC30 File Offset: 0x00239E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 18709, XrefRangeEnd = 18737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OpenMainPannel_b__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__OpenMainPannel_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007CCA RID: 31946 RVA: 0x0004329B File Offset: 0x0004149B
		public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002A41 RID: 10817
		// (get) Token: 0x06007CCB RID: 31947 RVA: 0x0023BC64 File Offset: 0x00239E64
		// (set) Token: 0x06007CCC RID: 31948 RVA: 0x000432A4 File Offset: 0x000414A4
		public unsafe DLC3_MusicGameStartPannel __4__this
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC3_MusicGameStartPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002A42 RID: 10818
		// (get) Token: 0x06007CCD RID: 31949 RVA: 0x0023BC94 File Offset: 0x00239E94
		// (set) Token: 0x06007CCE RID: 31950 RVA: 0x000432C3 File Offset: 0x000414C3
		public unsafe MusicSelectorReconfirmPannel pannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeFieldInfoPtr_pannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicSelectorReconfirmPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3_MusicGameStartPannel.__c__DisplayClass27_0.NativeFieldInfoPtr_pannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400520E RID: 21006
		private static readonly IntPtr NativeFieldInfoPtr___4__this;

		// Token: 0x0400520F RID: 21007
		private static readonly IntPtr NativeFieldInfoPtr_pannel;

		// Token: 0x04005210 RID: 21008
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005211 RID: 21009
		private static readonly IntPtr NativeMethodInfoPtr__OpenMainPannel_b__0_Internal_Void_0;
	}
}
