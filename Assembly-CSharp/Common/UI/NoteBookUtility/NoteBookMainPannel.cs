using System;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Common.UI.NoteBookUtility
{
	// Token: 0x0200039C RID: 924
	public class NoteBookMainPannel : MultiLayerUISubPanel<BaseSustainedPannel, NoteBookMainPannel, NoteBookMainPannel.GoToSpecificType>
	{
		// Token: 0x06006F24 RID: 28452 RVA: 0x00210A90 File Offset: 0x0020EC90
		// Note: this type is marked as 'beforefieldinit'.
		static NoteBookMainPannel()
		{
			Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.NoteBookUtility", "NoteBookMainPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr);
			NoteBookMainPannel.NativeFieldInfoPtr_FloatingPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "FloatingPannel");
			NoteBookMainPannel.NativeFieldInfoPtr_BG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "BG");
			NoteBookMainPannel.NativeFieldInfoPtr_ProfilePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "ProfilePannel");
			NoteBookMainPannel.NativeFieldInfoPtr_RecipePannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "RecipePannel");
			NoteBookMainPannel.NativeFieldInfoPtr_MissionPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "MissionPannel");
			NoteBookMainPannel.NativeFieldInfoPtr_NewsPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "NewsPannel");
			NoteBookMainPannel.NativeFieldInfoPtr_AlbumPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "AlbumPannel");
			NoteBookMainPannel.NativeFieldInfoPtr_ProfileBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "ProfileBtn");
			NoteBookMainPannel.NativeFieldInfoPtr_RecipeBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "RecipeBtn");
			NoteBookMainPannel.NativeFieldInfoPtr_MissionBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "MissionBtn");
			NoteBookMainPannel.NativeFieldInfoPtr_NewsBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "NewsBtn");
			NoteBookMainPannel.NativeFieldInfoPtr_AlbumBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "AlbumBtn");
			NoteBookMainPannel.NativeFieldInfoPtr_HighlightColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "HighlightColor");
			NoteBookMainPannel.NativeFieldInfoPtr_NormalColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "NormalColor");
			NoteBookMainPannel.NativeFieldInfoPtr__StandaloneMode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "<StandaloneMode>k__BackingField");
			NoteBookMainPannel.NativeMethodInfoPtr_get_StandaloneMode_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685983);
			NoteBookMainPannel.NativeMethodInfoPtr_set_StandaloneMode_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685984);
			NoteBookMainPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GoToSpecificType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685985);
			NoteBookMainPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685986);
			NoteBookMainPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685987);
			NoteBookMainPannel.NativeMethodInfoPtr_OnPanelPreOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685988);
			NoteBookMainPannel.NativeMethodInfoPtr_Fade_Public_Static_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685989);
			NoteBookMainPannel.NativeMethodInfoPtr_Blink_Public_Static_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685990);
			NoteBookMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685991);
			NoteBookMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685992);
			NoteBookMainPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, 100685993);
		}

		// Token: 0x17002628 RID: 9768
		// (get) Token: 0x06006F25 RID: 28453 RVA: 0x00210CC8 File Offset: 0x0020EEC8
		// (set) Token: 0x06006F26 RID: 28454 RVA: 0x00210D04 File Offset: 0x0020EF04
		public unsafe bool StandaloneMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.NativeMethodInfoPtr_get_StandaloneMode_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.NativeMethodInfoPtr_set_StandaloneMode_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002629 RID: 9769
		// (get) Token: 0x06006F27 RID: 28455 RVA: 0x00210D44 File Offset: 0x0020EF44
		public unsafe override NoteBookMainPannel.GoToSpecificType DefaultPanelSelection
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMainPannel.NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GoToSpecificType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700262A RID: 9770
		// (get) Token: 0x06006F28 RID: 28456 RVA: 0x00210D8C File Offset: 0x0020EF8C
		public unsafe override IEnumerable<ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>>> GetData
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277867, XrefRangeEnd = 277873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMainPannel.NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>>>>(intPtr3) : null;
			}
		}

		// Token: 0x1700262B RID: 9771
		// (get) Token: 0x06006F29 RID: 28457 RVA: 0x00210DD8 File Offset: 0x0020EFD8
		public unsafe override string SwitchKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMainPannel.NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x00210E1C File Offset: 0x0020F01C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277873, XrefRangeEnd = 277882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelPreOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMainPannel.NativeMethodInfoPtr_OnPanelPreOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x00210E58 File Offset: 0x0020F058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 277894, RefRangeEnd = 277896, XrefRangeStart = 277882, XrefRangeEnd = 277894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Fade(CanvasGroup canvasGroup)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.NativeMethodInfoPtr_Fade_Public_Static_Void_CanvasGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00210E90 File Offset: 0x0020F090
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 277914, RefRangeEnd = 277918, XrefRangeStart = 277896, XrefRangeEnd = 277914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Blink(CanvasGroup canvasGroup)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(canvasGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.NativeMethodInfoPtr_Blink_Public_Static_Void_CanvasGroup_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x00210EC8 File Offset: 0x0020F0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277918, XrefRangeEnd = 277933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteBookMainPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x00210F04 File Offset: 0x0020F104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277933, XrefRangeEnd = 277936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteBookMainPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x00210F40 File Offset: 0x0020F140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277936, XrefRangeEnd = 277939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Common_UI_IExternalPanel_CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x0003C45D File Offset: 0x0003A65D
		public NoteBookMainPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002619 RID: 9753
		// (get) Token: 0x06006F31 RID: 28465 RVA: 0x00210F74 File Offset: 0x0020F174
		// (set) Token: 0x06006F32 RID: 28466 RVA: 0x0003C466 File Offset: 0x0003A666
		public unsafe RectTransform FloatingPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_FloatingPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_FloatingPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261A RID: 9754
		// (get) Token: 0x06006F33 RID: 28467 RVA: 0x00210FA4 File Offset: 0x0020F1A4
		// (set) Token: 0x06006F34 RID: 28468 RVA: 0x0003C485 File Offset: 0x0003A685
		public unsafe Image BG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_BG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_BG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261B RID: 9755
		// (get) Token: 0x06006F35 RID: 28469 RVA: 0x00210FD4 File Offset: 0x0020F1D4
		// (set) Token: 0x06006F36 RID: 28470 RVA: 0x0003C4A4 File Offset: 0x0003A6A4
		public unsafe NoteBookProfilePannel ProfilePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_ProfilePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookProfilePannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_ProfilePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261C RID: 9756
		// (get) Token: 0x06006F37 RID: 28471 RVA: 0x00211004 File Offset: 0x0020F204
		// (set) Token: 0x06006F38 RID: 28472 RVA: 0x0003C4C3 File Offset: 0x0003A6C3
		public unsafe NoteBookRecipePannel RecipePannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_RecipePannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookRecipePannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_RecipePannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261D RID: 9757
		// (get) Token: 0x06006F39 RID: 28473 RVA: 0x00211034 File Offset: 0x0020F234
		// (set) Token: 0x06006F3A RID: 28474 RVA: 0x0003C4E2 File Offset: 0x0003A6E2
		public unsafe NoteBookMissionPannel MissionPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_MissionPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMissionPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_MissionPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261E RID: 9758
		// (get) Token: 0x06006F3B RID: 28475 RVA: 0x00211064 File Offset: 0x0020F264
		// (set) Token: 0x06006F3C RID: 28476 RVA: 0x0003C501 File Offset: 0x0003A701
		public unsafe NoteBookNewsPanelSelector NewsPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_NewsPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookNewsPanelSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_NewsPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700261F RID: 9759
		// (get) Token: 0x06006F3D RID: 28477 RVA: 0x00211094 File Offset: 0x0020F294
		// (set) Token: 0x06006F3E RID: 28478 RVA: 0x0003C520 File Offset: 0x0003A720
		public unsafe NoteBookAlbumPannel AlbumPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_AlbumPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookAlbumPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_AlbumPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002620 RID: 9760
		// (get) Token: 0x06006F3F RID: 28479 RVA: 0x002110C4 File Offset: 0x0020F2C4
		// (set) Token: 0x06006F40 RID: 28480 RVA: 0x0003C53F File Offset: 0x0003A73F
		public unsafe UIButtonToggle ProfileBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_ProfileBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_ProfileBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002621 RID: 9761
		// (get) Token: 0x06006F41 RID: 28481 RVA: 0x002110F4 File Offset: 0x0020F2F4
		// (set) Token: 0x06006F42 RID: 28482 RVA: 0x0003C55E File Offset: 0x0003A75E
		public unsafe UIButtonToggle RecipeBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_RecipeBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_RecipeBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002622 RID: 9762
		// (get) Token: 0x06006F43 RID: 28483 RVA: 0x00211124 File Offset: 0x0020F324
		// (set) Token: 0x06006F44 RID: 28484 RVA: 0x0003C57D File Offset: 0x0003A77D
		public unsafe UIButtonToggle MissionBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_MissionBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_MissionBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002623 RID: 9763
		// (get) Token: 0x06006F45 RID: 28485 RVA: 0x00211154 File Offset: 0x0020F354
		// (set) Token: 0x06006F46 RID: 28486 RVA: 0x0003C59C File Offset: 0x0003A79C
		public unsafe UIButtonToggle NewsBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_NewsBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_NewsBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002624 RID: 9764
		// (get) Token: 0x06006F47 RID: 28487 RVA: 0x00211184 File Offset: 0x0020F384
		// (set) Token: 0x06006F48 RID: 28488 RVA: 0x0003C5BB File Offset: 0x0003A7BB
		public unsafe UIButtonToggle AlbumBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_AlbumBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonToggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_AlbumBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002625 RID: 9765
		// (get) Token: 0x06006F49 RID: 28489 RVA: 0x002111B4 File Offset: 0x0020F3B4
		// (set) Token: 0x06006F4A RID: 28490 RVA: 0x0003C5DA File Offset: 0x0003A7DA
		public unsafe Color32 HighlightColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_HighlightColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_HighlightColor)) = value;
			}
		}

		// Token: 0x17002626 RID: 9766
		// (get) Token: 0x06006F4B RID: 28491 RVA: 0x002111DC File Offset: 0x0020F3DC
		// (set) Token: 0x06006F4C RID: 28492 RVA: 0x0003C5F5 File Offset: 0x0003A7F5
		public unsafe Color32 NormalColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_NormalColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr_NormalColor)) = value;
			}
		}

		// Token: 0x17002627 RID: 9767
		// (get) Token: 0x06006F4D RID: 28493 RVA: 0x00211204 File Offset: 0x0020F404
		// (set) Token: 0x06006F4E RID: 28494 RVA: 0x0003C610 File Offset: 0x0003A810
		public unsafe bool _StandaloneMode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr__StandaloneMode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.NativeFieldInfoPtr__StandaloneMode_k__BackingField)) = value;
			}
		}

		// Token: 0x040049A2 RID: 18850
		private static readonly IntPtr NativeFieldInfoPtr_FloatingPannel;

		// Token: 0x040049A3 RID: 18851
		private static readonly IntPtr NativeFieldInfoPtr_BG;

		// Token: 0x040049A4 RID: 18852
		private static readonly IntPtr NativeFieldInfoPtr_ProfilePannel;

		// Token: 0x040049A5 RID: 18853
		private static readonly IntPtr NativeFieldInfoPtr_RecipePannel;

		// Token: 0x040049A6 RID: 18854
		private static readonly IntPtr NativeFieldInfoPtr_MissionPannel;

		// Token: 0x040049A7 RID: 18855
		private static readonly IntPtr NativeFieldInfoPtr_NewsPannel;

		// Token: 0x040049A8 RID: 18856
		private static readonly IntPtr NativeFieldInfoPtr_AlbumPannel;

		// Token: 0x040049A9 RID: 18857
		private static readonly IntPtr NativeFieldInfoPtr_ProfileBtn;

		// Token: 0x040049AA RID: 18858
		private static readonly IntPtr NativeFieldInfoPtr_RecipeBtn;

		// Token: 0x040049AB RID: 18859
		private static readonly IntPtr NativeFieldInfoPtr_MissionBtn;

		// Token: 0x040049AC RID: 18860
		private static readonly IntPtr NativeFieldInfoPtr_NewsBtn;

		// Token: 0x040049AD RID: 18861
		private static readonly IntPtr NativeFieldInfoPtr_AlbumBtn;

		// Token: 0x040049AE RID: 18862
		private static readonly IntPtr NativeFieldInfoPtr_HighlightColor;

		// Token: 0x040049AF RID: 18863
		private static readonly IntPtr NativeFieldInfoPtr_NormalColor;

		// Token: 0x040049B0 RID: 18864
		private static readonly IntPtr NativeFieldInfoPtr__StandaloneMode_k__BackingField;

		// Token: 0x040049B1 RID: 18865
		private static readonly IntPtr NativeMethodInfoPtr_get_StandaloneMode_Private_get_Boolean_0;

		// Token: 0x040049B2 RID: 18866
		private static readonly IntPtr NativeMethodInfoPtr_set_StandaloneMode_Public_set_Void_Boolean_0;

		// Token: 0x040049B3 RID: 18867
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPanelSelection_Protected_Virtual_get_GoToSpecificType_0;

		// Token: 0x040049B4 RID: 18868
		private static readonly IntPtr NativeMethodInfoPtr_get_GetData_Protected_Virtual_get_IEnumerable_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0;

		// Token: 0x040049B5 RID: 18869
		private static readonly IntPtr NativeMethodInfoPtr_get_SwitchKey_Protected_Virtual_get_String_0;

		// Token: 0x040049B6 RID: 18870
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelPreOpen_Protected_Virtual_Void_0;

		// Token: 0x040049B7 RID: 18871
		private static readonly IntPtr NativeMethodInfoPtr_Fade_Public_Static_Void_CanvasGroup_0;

		// Token: 0x040049B8 RID: 18872
		private static readonly IntPtr NativeMethodInfoPtr_Blink_Public_Static_Void_CanvasGroup_0;

		// Token: 0x040049B9 RID: 18873
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040049BA RID: 18874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040049BB RID: 18875
		private static readonly IntPtr NativeMethodInfoPtr_Common_UI_IExternalPanel_CloseExternPanel_Private_Virtual_Final_New_Void_0;

		// Token: 0x02000EDE RID: 3806
		public enum GoToSpecificType
		{
			// Token: 0x0400A930 RID: 43312
			Profile,
			// Token: 0x0400A931 RID: 43313
			Recipe,
			// Token: 0x0400A932 RID: 43314
			Mission,
			// Token: 0x0400A933 RID: 43315
			News,
			// Token: 0x0400A934 RID: 43316
			Album
		}

		// Token: 0x02000EDF RID: 3807
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMainPannel+<get_GetData>d__22")]
		public sealed class _get_GetData_d__22 : Il2CppSystem.Object
		{
			// Token: 0x06010B89 RID: 68489 RVA: 0x003DE748 File Offset: 0x003DC948
			// Note: this type is marked as 'beforefieldinit'.
			static _get_GetData_d__22()
			{
				Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "<get_GetData>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr);
				NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, "<>1__state");
				NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, "<>2__current");
				NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, "<>l__initialThreadId");
				NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, "<>4__this");
				NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, 100685994);
				NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, 100685995);
				NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, 100685996);
				NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, 100685997);
				NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, 100685998);
				NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, 100685999);
				NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, 100686000);
				NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr, 100686001);
			}

			// Token: 0x06010B8A RID: 68490 RVA: 0x003DE864 File Offset: 0x003DCA64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _get_GetData_d__22(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMainPannel._get_GetData_d__22>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B8B RID: 68491 RVA: 0x003DE8AC File Offset: 0x003DCAAC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B8C RID: 68492 RVA: 0x003DE8E0 File Offset: 0x003DCAE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277844, XrefRangeEnd = 277848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005728 RID: 22312
			// (get) Token: 0x06010B8D RID: 68493 RVA: 0x003DE91C File Offset: 0x003DCB1C
			public unsafe ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>> prop_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>>(pointer);
				}
			}

			// Token: 0x06010B8E RID: 68494 RVA: 0x003DE954 File Offset: 0x003DCB54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277848, XrefRangeEnd = 277854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005729 RID: 22313
			// (get) Token: 0x06010B8F RID: 68495 RVA: 0x003DE988 File Offset: 0x003DCB88
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277854, XrefRangeEnd = 277857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06010B90 RID: 68496 RVA: 0x003DE9C8 File Offset: 0x003DCBC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277857, XrefRangeEnd = 277859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>>> Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>>>>(intPtr3) : null;
			}

			// Token: 0x06010B91 RID: 68497 RVA: 0x003DEA08 File Offset: 0x003DCC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel._get_GetData_d__22.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010B92 RID: 68498 RVA: 0x00091C8C File Offset: 0x0008FE8C
			public _get_GetData_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005724 RID: 22308
			// (get) Token: 0x06010B93 RID: 68499 RVA: 0x003DEA48 File Offset: 0x003DCC48
			// (set) Token: 0x06010B94 RID: 68500 RVA: 0x00091C95 File Offset: 0x0008FE95
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005725 RID: 22309
			// (get) Token: 0x06010B95 RID: 68501 RVA: 0x003DEA70 File Offset: 0x003DCC70
			// (set) Token: 0x06010B96 RID: 68502 RVA: 0x00091CB0 File Offset: 0x0008FEB0
			public ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___2__current);
					return new ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<NoteBookMainPannel.GoToSpecificType, UIButtonToggle, UISubPanel<NoteBookMainPannel>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005726 RID: 22310
			// (get) Token: 0x06010B97 RID: 68503 RVA: 0x003DEAA0 File Offset: 0x003DCCA0
			// (set) Token: 0x06010B98 RID: 68504 RVA: 0x00091CDE File Offset: 0x0008FEDE
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17005727 RID: 22311
			// (get) Token: 0x06010B99 RID: 68505 RVA: 0x003DEAC8 File Offset: 0x003DCCC8
			// (set) Token: 0x06010B9A RID: 68506 RVA: 0x00091CF9 File Offset: 0x0008FEF9
			public unsafe NoteBookMainPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NoteBookMainPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel._get_GetData_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A935 RID: 43317
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400A936 RID: 43318
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400A937 RID: 43319
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x0400A938 RID: 43320
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A939 RID: 43321
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400A93A RID: 43322
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A93B RID: 43323
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400A93C RID: 43324
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0;

			// Token: 0x0400A93D RID: 43325
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400A93E RID: 43326
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400A93F RID: 43327
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_ValueTuple_3_GoToSpecificType_UIButtonToggle_UISubPanel_1_NoteBookMainPannel_0;

			// Token: 0x0400A940 RID: 43328
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000EE0 RID: 3808
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMainPannel+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x06010B9B RID: 68507 RVA: 0x003DEAF8 File Offset: 0x003DCCF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass26_0>.NativeClassPtr);
				NoteBookMainPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass26_0>.NativeClassPtr, "canvasGroup");
				NoteBookMainPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass26_0>.NativeClassPtr, 100686002);
				NoteBookMainPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__Fade_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass26_0>.NativeClassPtr, 100686003);
			}

			// Token: 0x06010B9C RID: 68508 RVA: 0x003DEB60 File Offset: 0x003DCD60
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B9D RID: 68509 RVA: 0x003DEB9C File Offset: 0x003DCD9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Fade_b__0(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.__c__DisplayClass26_0.NativeMethodInfoPtr__Fade_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010B9E RID: 68510 RVA: 0x00091D18 File Offset: 0x0008FF18
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700572A RID: 22314
			// (get) Token: 0x06010B9F RID: 68511 RVA: 0x003DEBDC File Offset: 0x003DCDDC
			// (set) Token: 0x06010BA0 RID: 68512 RVA: 0x00091D21 File Offset: 0x0008FF21
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.__c__DisplayClass26_0.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A941 RID: 43329
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x0400A942 RID: 43330
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A943 RID: 43331
			private static readonly IntPtr NativeMethodInfoPtr__Fade_b__0_Internal_Void_Single_0;
		}

		// Token: 0x02000EE1 RID: 3809
		[ObfuscatedName("Common.UI.NoteBookUtility.NoteBookMainPannel+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x06010BA1 RID: 68513 RVA: 0x003DEC0C File Offset: 0x003DCE0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteBookMainPannel>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass27_0>.NativeClassPtr);
				NoteBookMainPannel.__c__DisplayClass27_0.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass27_0>.NativeClassPtr, "canvasGroup");
				NoteBookMainPannel.__c__DisplayClass27_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass27_0>.NativeClassPtr, "<>9__2");
				NoteBookMainPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass27_0>.NativeClassPtr, 100686004);
				NoteBookMainPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__Blink_b__0_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass27_0>.NativeClassPtr, 100686005);
				NoteBookMainPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__Blink_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass27_0>.NativeClassPtr, 100686006);
				NoteBookMainPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__Blink_b__2_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass27_0>.NativeClassPtr, 100686007);
			}

			// Token: 0x06010BA2 RID: 68514 RVA: 0x003DECB0 File Offset: 0x003DCEB0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteBookMainPannel.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BA3 RID: 68515 RVA: 0x003DECEC File Offset: 0x003DCEEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Blink_b__0(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__Blink_b__0_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BA4 RID: 68516 RVA: 0x003DED2C File Offset: 0x003DCF2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 277859, XrefRangeEnd = 277867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Blink_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__Blink_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BA5 RID: 68517 RVA: 0x003DED60 File Offset: 0x003DCF60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Blink_b__2(float value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteBookMainPannel.__c__DisplayClass27_0.NativeMethodInfoPtr__Blink_b__2_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010BA6 RID: 68518 RVA: 0x00091D40 File Offset: 0x0008FF40
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700572B RID: 22315
			// (get) Token: 0x06010BA7 RID: 68519 RVA: 0x003DEDA0 File Offset: 0x003DCFA0
			// (set) Token: 0x06010BA8 RID: 68520 RVA: 0x00091D49 File Offset: 0x0008FF49
			public unsafe CanvasGroup canvasGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.__c__DisplayClass27_0.NativeFieldInfoPtr_canvasGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.__c__DisplayClass27_0.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700572C RID: 22316
			// (get) Token: 0x06010BA9 RID: 68521 RVA: 0x003DEDD0 File Offset: 0x003DCFD0
			// (set) Token: 0x06010BAA RID: 68522 RVA: 0x00091D68 File Offset: 0x0008FF68
			public unsafe Action<float> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.__c__DisplayClass27_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteBookMainPannel.__c__DisplayClass27_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A944 RID: 43332
			private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

			// Token: 0x0400A945 RID: 43333
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x0400A946 RID: 43334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A947 RID: 43335
			private static readonly IntPtr NativeMethodInfoPtr__Blink_b__0_Internal_Void_Single_0;

			// Token: 0x0400A948 RID: 43336
			private static readonly IntPtr NativeMethodInfoPtr__Blink_b__1_Internal_Void_0;

			// Token: 0x0400A949 RID: 43337
			private static readonly IntPtr NativeMethodInfoPtr__Blink_b__2_Internal_Void_Single_0;
		}
	}
}
