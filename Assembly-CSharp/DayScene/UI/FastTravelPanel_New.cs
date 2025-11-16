using System;
using Common.UI.GlobalMap;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000CD RID: 205
	public sealed class FastTravelPanel_New : GuideMapPanel<FastTravelPanel_New.FastTravelPanelOpenContext, VoidType>
	{
		// Token: 0x060018AD RID: 6317 RVA: 0x000F074C File Offset: 0x000EE94C
		// Note: this type is marked as 'beforefieldinit'.
		static FastTravelPanel_New()
		{
			Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "FastTravelPanel_New");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr);
			FastTravelPanel_New.NativeFieldInfoPtr_YUKARI_TELEPORT_EVENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "YUKARI_TELEPORT_EVENT_ID");
			FastTravelPanel_New.NativeFieldInfoPtr_m_PlayerCurrentPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_PlayerCurrentPosition");
			FastTravelPanel_New.NativeFieldInfoPtr_m_TimeIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_TimeIndicator");
			FastTravelPanel_New.NativeFieldInfoPtr_m_SubPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_SubPanel");
			FastTravelPanel_New.NativeFieldInfoPtr_m_MapDescriber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_MapDescriber");
			FastTravelPanel_New.NativeFieldInfoPtr_m_UnitPriceForTeleport = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_UnitPriceForTeleport");
			FastTravelPanel_New.NativeFieldInfoPtr_m_FloatMenuModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_FloatMenuModifiers");
			FastTravelPanel_New.NativeFieldInfoPtr_m_MainContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_MainContent");
			FastTravelPanel_New.NativeFieldInfoPtr_m_CurrentSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_CurrentSpot");
			FastTravelPanel_New.NativeFieldInfoPtr_m_CachedOpenContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_CachedOpenContext");
			FastTravelPanel_New.NativeFieldInfoPtr_m_CachedTimeIndicatorContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_CachedTimeIndicatorContext");
			FastTravelPanel_New.NativeFieldInfoPtr_m_FloatMenuModifierDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "m_FloatMenuModifierDictionary");
			FastTravelPanel_New.NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667683);
			FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667684);
			FastTravelPanel_New.NativeMethodInfoPtr_CloseExternPanel_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667685);
			FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapClose_Protected_Virtual_Void_VoidType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667686);
			FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapPanelPostOpen_Protected_Virtual_Void_FastTravelPanelOpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667687);
			FastTravelPanel_New.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667688);
			FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667689);
			FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_Void_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667690);
			FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSubmitAsync_Private_UniTask_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667691);
			FastTravelPanel_New.NativeMethodInfoPtr_IsFirstToSelectSpot_Protected_Virtual_Nullable_1_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667692);
			FastTravelPanel_New.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667693);
			FastTravelPanel_New.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667694);
			FastTravelPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__15_0_Private_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, 100667695);
		}

		// Token: 0x060018AE RID: 6318 RVA: 0x000F0970 File Offset: 0x000EEB70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67298, XrefRangeEnd = 67304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSecondarySwitchUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018AF RID: 6319 RVA: 0x000F09A4 File Offset: 0x000EEBA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67304, XrefRangeEnd = 67348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B0 RID: 6320 RVA: 0x000F09D8 File Offset: 0x000EEBD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67348, XrefRangeEnd = 67351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseExternPanel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_CloseExternPanel_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x000F0A0C File Offset: 0x000EEC0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67351, XrefRangeEnd = 67364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapClose(VoidType voidType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref voidType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapClose_Protected_Virtual_Void_VoidType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x000F0A4C File Offset: 0x000EEC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67364, XrefRangeEnd = 67413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapPanelPostOpen(FastTravelPanel_New.FastTravelPanelOpenContext openContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapPanelPostOpen_Protected_Virtual_Void_FastTravelPanelOpenContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x000F0A94 File Offset: 0x000EEC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67413, XrefRangeEnd = 67418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool GetSpotOpenStatus(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x000F0AE4 File Offset: 0x000EECE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67418, XrefRangeEnd = 67465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapSpotSelected(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x000F0B28 File Offset: 0x000EED28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67465, XrefRangeEnd = 67473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnGuideMapSpotSubmit(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_Void_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x000F0B6C File Offset: 0x000EED6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 67491, RefRangeEnd = 67492, XrefRangeStart = 67473, XrefRangeEnd = 67491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OnGuideMapSpotSubmitAsync(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_OnGuideMapSpotSubmitAsync_Private_UniTask_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x000F0BB4 File Offset: 0x000EEDB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67492, XrefRangeEnd = 67496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Nullable<bool> IsFirstToSelectSpot(IGuideMapSpot guideMapSpot)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_IsFirstToSelectSpot_Protected_Virtual_Nullable_1_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new Nullable<bool>(pointer);
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x000F0BFC File Offset: 0x000EEDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67496, XrefRangeEnd = 67507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018B9 RID: 6329 RVA: 0x000F0C30 File Offset: 0x000EEE30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67507, XrefRangeEnd = 67510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FastTravelPanel_New() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BA RID: 6330 RVA: 0x000F0C6C File Offset: 0x000EEE6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67510, XrefRangeEnd = 67513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnGuideMapInitialize_b__15_0(InputAction.CallbackContext _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(_));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.NativeMethodInfoPtr__OnGuideMapInitialize_b__15_0_Private_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x0000F624 File Offset: 0x0000D824
		public FastTravelPanel_New(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060018BC RID: 6332 RVA: 0x000F0CB4 File Offset: 0x000EEEB4
		// (set) Token: 0x060018BD RID: 6333 RVA: 0x0000F62D File Offset: 0x0000D82D
		public unsafe static string YUKARI_TELEPORT_EVENT_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FastTravelPanel_New.NativeFieldInfoPtr_YUKARI_TELEPORT_EVENT_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FastTravelPanel_New.NativeFieldInfoPtr_YUKARI_TELEPORT_EVENT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060018BE RID: 6334 RVA: 0x000F0CD4 File Offset: 0x000EEED4
		// (set) Token: 0x060018BF RID: 6335 RVA: 0x0000F63F File Offset: 0x0000D83F
		public unsafe Image m_PlayerCurrentPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_PlayerCurrentPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_PlayerCurrentPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060018C0 RID: 6336 RVA: 0x000F0D04 File Offset: 0x000EEF04
		// (set) Token: 0x060018C1 RID: 6337 RVA: 0x0000F65E File Offset: 0x0000D85E
		public unsafe FastTravelPanel_TimeIndicator m_TimeIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_TimeIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastTravelPanel_TimeIndicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_TimeIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060018C2 RID: 6338 RVA: 0x000F0D34 File Offset: 0x000EEF34
		// (set) Token: 0x060018C3 RID: 6339 RVA: 0x0000F67D File Offset: 0x0000D87D
		public unsafe DaySceneFastTravelSubPannel m_SubPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_SubPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneFastTravelSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_SubPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060018C4 RID: 6340 RVA: 0x000F0D64 File Offset: 0x000EEF64
		// (set) Token: 0x060018C5 RID: 6341 RVA: 0x0000F69C File Offset: 0x0000D89C
		public unsafe DaySceneMapDescriber m_MapDescriber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_MapDescriber);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneMapDescriber>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_MapDescriber), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x060018C6 RID: 6342 RVA: 0x000F0D94 File Offset: 0x000EEF94
		// (set) Token: 0x060018C7 RID: 6343 RVA: 0x0000F6BB File Offset: 0x0000D8BB
		public unsafe int m_UnitPriceForTeleport
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_UnitPriceForTeleport);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_UnitPriceForTeleport)) = value;
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x060018C8 RID: 6344 RVA: 0x000F0DBC File Offset: 0x000EEFBC
		// (set) Token: 0x060018C9 RID: 6345 RVA: 0x0000F6D6 File Offset: 0x0000D8D6
		public unsafe Il2CppReferenceArray<FastTravelPanel_New.FloatMenuModifier> m_FloatMenuModifiers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_FloatMenuModifiers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FastTravelPanel_New.FloatMenuModifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_FloatMenuModifiers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x000F0DEC File Offset: 0x000EEFEC
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x0000F6F5 File Offset: 0x0000D8F5
		public unsafe CanvasGroup m_MainContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_MainContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_MainContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x000F0E1C File Offset: 0x000EF01C
		// (set) Token: 0x060018CD RID: 6349 RVA: 0x0000F714 File Offset: 0x0000D914
		public unsafe IGuideMapSpot m_CurrentSpot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_CurrentSpot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_CurrentSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x000F0E4C File Offset: 0x000EF04C
		// (set) Token: 0x060018CF RID: 6351 RVA: 0x0000F733 File Offset: 0x0000D933
		public DaySceneFastTravelSubPannel.OpenContext m_CachedOpenContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_CachedOpenContext);
				return new DaySceneFastTravelSubPannel.OpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_CachedOpenContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DaySceneFastTravelSubPannel.OpenContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x000F0E7C File Offset: 0x000EF07C
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x0000F761 File Offset: 0x0000D961
		public TimeIndicatorContext m_CachedTimeIndicatorContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_CachedTimeIndicatorContext);
				return new TimeIndicatorContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_CachedTimeIndicatorContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TimeIndicatorContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x060018D2 RID: 6354 RVA: 0x000F0EAC File Offset: 0x000EF0AC
		// (set) Token: 0x060018D3 RID: 6355 RVA: 0x0000F78F File Offset: 0x0000D98F
		public unsafe Dictionary<IGuideMapSpot, Vector2> m_FloatMenuModifierDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_FloatMenuModifierDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<IGuideMapSpot, Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.NativeFieldInfoPtr_m_FloatMenuModifierDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001087 RID: 4231
		private static readonly IntPtr NativeFieldInfoPtr_YUKARI_TELEPORT_EVENT_ID;

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeFieldInfoPtr_m_PlayerCurrentPosition;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeFieldInfoPtr_m_TimeIndicator;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeFieldInfoPtr_m_SubPanel;

		// Token: 0x0400108B RID: 4235
		private static readonly IntPtr NativeFieldInfoPtr_m_MapDescriber;

		// Token: 0x0400108C RID: 4236
		private static readonly IntPtr NativeFieldInfoPtr_m_UnitPriceForTeleport;

		// Token: 0x0400108D RID: 4237
		private static readonly IntPtr NativeFieldInfoPtr_m_FloatMenuModifiers;

		// Token: 0x0400108E RID: 4238
		private static readonly IntPtr NativeFieldInfoPtr_m_MainContent;

		// Token: 0x0400108F RID: 4239
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentSpot;

		// Token: 0x04001090 RID: 4240
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedOpenContext;

		// Token: 0x04001091 RID: 4241
		private static readonly IntPtr NativeFieldInfoPtr_m_CachedTimeIndicatorContext;

		// Token: 0x04001092 RID: 4242
		private static readonly IntPtr NativeFieldInfoPtr_m_FloatMenuModifierDictionary;

		// Token: 0x04001093 RID: 4243
		private static readonly IntPtr NativeMethodInfoPtr_OnSecondarySwitchUpdate_Protected_Virtual_Void_0;

		// Token: 0x04001094 RID: 4244
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001095 RID: 4245
		private static readonly IntPtr NativeMethodInfoPtr_CloseExternPanel_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001096 RID: 4246
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapClose_Protected_Virtual_Void_VoidType_0;

		// Token: 0x04001097 RID: 4247
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapPanelPostOpen_Protected_Virtual_Void_FastTravelPanelOpenContext_0;

		// Token: 0x04001098 RID: 4248
		private static readonly IntPtr NativeMethodInfoPtr_GetSpotOpenStatus_Protected_Virtual_Boolean_IGuideMapSpot_0;

		// Token: 0x04001099 RID: 4249
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSelected_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x0400109A RID: 4250
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSubmit_Protected_Virtual_Void_IGuideMapSpot_0;

		// Token: 0x0400109B RID: 4251
		private static readonly IntPtr NativeMethodInfoPtr_OnGuideMapSpotSubmitAsync_Private_UniTask_IGuideMapSpot_0;

		// Token: 0x0400109C RID: 4252
		private static readonly IntPtr NativeMethodInfoPtr_IsFirstToSelectSpot_Protected_Virtual_Nullable_1_Boolean_IGuideMapSpot_0;

		// Token: 0x0400109D RID: 4253
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400109E RID: 4254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400109F RID: 4255
		private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__15_0_Private_Void_CallbackContext_0;

		// Token: 0x02000676 RID: 1654
		public sealed class FastTravelPanelOpenContext : ValueType
		{
			// Token: 0x0600956B RID: 38251 RVA: 0x002831EC File Offset: 0x002813EC
			// Note: this type is marked as 'beforefieldinit'.
			static FastTravelPanelOpenContext()
			{
				Il2CppClassPointerStore<FastTravelPanel_New.FastTravelPanelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "FastTravelPanelOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastTravelPanel_New.FastTravelPanelOpenContext>.NativeClassPtr);
				FastTravelPanel_New.FastTravelPanelOpenContext.NativeFieldInfoPtr__IsOpenThroughYukariTeleport_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New.FastTravelPanelOpenContext>.NativeClassPtr, "<IsOpenThroughYukariTeleport>k__BackingField");
				FastTravelPanel_New.FastTravelPanelOpenContext.NativeFieldInfoPtr__GetFirstToSelectNodeHandler_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New.FastTravelPanelOpenContext>.NativeClassPtr, "<GetFirstToSelectNodeHandler>k__BackingField");
				FastTravelPanel_New.FastTravelPanelOpenContext.NativeMethodInfoPtr_get_IsOpenThroughYukariTeleport_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New.FastTravelPanelOpenContext>.NativeClassPtr, 100667696);
				FastTravelPanel_New.FastTravelPanelOpenContext.NativeMethodInfoPtr_get_GetFirstToSelectNodeHandler_Public_get_Predicate_1_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New.FastTravelPanelOpenContext>.NativeClassPtr, 100667697);
				FastTravelPanel_New.FastTravelPanelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Predicate_1_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New.FastTravelPanelOpenContext>.NativeClassPtr, 100667698);
			}

			// Token: 0x170031A6 RID: 12710
			// (get) Token: 0x0600956C RID: 38252 RVA: 0x0028327C File Offset: 0x0028147C
			public unsafe bool IsOpenThroughYukariTeleport
			{
				[CallerCount(20)]
				[CachedScanResults(RefRangeStart = 67190, RefRangeEnd = 67210, XrefRangeStart = 67190, XrefRangeEnd = 67190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.FastTravelPanelOpenContext.NativeMethodInfoPtr_get_IsOpenThroughYukariTeleport_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170031A7 RID: 12711
			// (get) Token: 0x0600956D RID: 38253 RVA: 0x002832C0 File Offset: 0x002814C0
			public unsafe Predicate<IGuideMapSpot> GetFirstToSelectNodeHandler
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.FastTravelPanelOpenContext.NativeMethodInfoPtr_get_GetFirstToSelectNodeHandler_Public_get_Predicate_1_IGuideMapSpot_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Predicate<IGuideMapSpot>>(intPtr3) : null;
				}
			}

			// Token: 0x0600956E RID: 38254 RVA: 0x00283304 File Offset: 0x00281504
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 67211, RefRangeEnd = 67215, XrefRangeStart = 67210, XrefRangeEnd = 67211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FastTravelPanelOpenContext(bool isOpenThroughYukariTeleport, Predicate<IGuideMapSpot> getFirstToSelectNodeHandler) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastTravelPanel_New.FastTravelPanelOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref isOpenThroughYukariTeleport;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getFirstToSelectNodeHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.FastTravelPanelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Predicate_1_IGuideMapSpot_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600956F RID: 38255 RVA: 0x00050CB4 File Offset: 0x0004EEB4
			public FastTravelPanelOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009570 RID: 38256 RVA: 0x00050CBD File Offset: 0x0004EEBD
			public FastTravelPanelOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastTravelPanel_New.FastTravelPanelOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x170031A4 RID: 12708
			// (get) Token: 0x06009571 RID: 38257 RVA: 0x00283364 File Offset: 0x00281564
			// (set) Token: 0x06009572 RID: 38258 RVA: 0x00050CCF File Offset: 0x0004EECF
			public unsafe bool _IsOpenThroughYukariTeleport_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.FastTravelPanelOpenContext.NativeFieldInfoPtr__IsOpenThroughYukariTeleport_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.FastTravelPanelOpenContext.NativeFieldInfoPtr__IsOpenThroughYukariTeleport_k__BackingField)) = value;
				}
			}

			// Token: 0x170031A5 RID: 12709
			// (get) Token: 0x06009573 RID: 38259 RVA: 0x0028338C File Offset: 0x0028158C
			// (set) Token: 0x06009574 RID: 38260 RVA: 0x00050CEA File Offset: 0x0004EEEA
			public unsafe Predicate<IGuideMapSpot> _GetFirstToSelectNodeHandler_k__BackingField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.FastTravelPanelOpenContext.NativeFieldInfoPtr__GetFirstToSelectNodeHandler_k__BackingField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<IGuideMapSpot>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.FastTravelPanelOpenContext.NativeFieldInfoPtr__GetFirstToSelectNodeHandler_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040060F1 RID: 24817
			private static readonly IntPtr NativeFieldInfoPtr__IsOpenThroughYukariTeleport_k__BackingField;

			// Token: 0x040060F2 RID: 24818
			private static readonly IntPtr NativeFieldInfoPtr__GetFirstToSelectNodeHandler_k__BackingField;

			// Token: 0x040060F3 RID: 24819
			private static readonly IntPtr NativeMethodInfoPtr_get_IsOpenThroughYukariTeleport_Public_get_Boolean_0;

			// Token: 0x040060F4 RID: 24820
			private static readonly IntPtr NativeMethodInfoPtr_get_GetFirstToSelectNodeHandler_Public_get_Predicate_1_IGuideMapSpot_0;

			// Token: 0x040060F5 RID: 24821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Predicate_1_IGuideMapSpot_0;
		}

		// Token: 0x02000677 RID: 1655
		[Serializable]
		public sealed class FloatMenuModifier : ValueType
		{
			// Token: 0x06009575 RID: 38261 RVA: 0x002833BC File Offset: 0x002815BC
			// Note: this type is marked as 'beforefieldinit'.
			static FloatMenuModifier()
			{
				Il2CppClassPointerStore<FastTravelPanel_New.FloatMenuModifier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "FloatMenuModifier");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastTravelPanel_New.FloatMenuModifier>.NativeClassPtr);
				FastTravelPanel_New.FloatMenuModifier.NativeFieldInfoPtr_GuideMapSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New.FloatMenuModifier>.NativeClassPtr, "GuideMapSpot");
				FastTravelPanel_New.FloatMenuModifier.NativeFieldInfoPtr_OverrideOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New.FloatMenuModifier>.NativeClassPtr, "OverrideOffset");
			}

			// Token: 0x06009576 RID: 38262 RVA: 0x00050D09 File Offset: 0x0004EF09
			public FloatMenuModifier(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009577 RID: 38263 RVA: 0x00050D12 File Offset: 0x0004EF12
			public FloatMenuModifier() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastTravelPanel_New.FloatMenuModifier>.NativeClassPtr))
			{
			}

			// Token: 0x170031A8 RID: 12712
			// (get) Token: 0x06009578 RID: 38264 RVA: 0x00283410 File Offset: 0x00281610
			// (set) Token: 0x06009579 RID: 38265 RVA: 0x00050D24 File Offset: 0x0004EF24
			public unsafe GuideMapSpot GuideMapSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.FloatMenuModifier.NativeFieldInfoPtr_GuideMapSpot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuideMapSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.FloatMenuModifier.NativeFieldInfoPtr_GuideMapSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031A9 RID: 12713
			// (get) Token: 0x0600957A RID: 38266 RVA: 0x00283440 File Offset: 0x00281640
			// (set) Token: 0x0600957B RID: 38267 RVA: 0x00050D43 File Offset: 0x0004EF43
			public unsafe Vector2 OverrideOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.FloatMenuModifier.NativeFieldInfoPtr_OverrideOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.FloatMenuModifier.NativeFieldInfoPtr_OverrideOffset)) = value;
				}
			}

			// Token: 0x040060F6 RID: 24822
			private static readonly IntPtr NativeFieldInfoPtr_GuideMapSpot;

			// Token: 0x040060F7 RID: 24823
			private static readonly IntPtr NativeFieldInfoPtr_OverrideOffset;
		}

		// Token: 0x02000678 RID: 1656
		[ObfuscatedName("DayScene.UI.FastTravelPanel_New+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600957C RID: 38268 RVA: 0x00283468 File Offset: 0x00281668
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FastTravelPanel_New.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastTravelPanel_New.__c>.NativeClassPtr);
				FastTravelPanel_New.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New.__c>.NativeClassPtr, "<>9");
				FastTravelPanel_New.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New.__c>.NativeClassPtr, "<>9__15_1");
				FastTravelPanel_New.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New.__c>.NativeClassPtr, "<>9__15_2");
				FastTravelPanel_New.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New.__c>.NativeClassPtr, 100667700);
				FastTravelPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__15_1_Internal_IGuideMapSpot_FloatMenuModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New.__c>.NativeClassPtr, 100667701);
				FastTravelPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__15_2_Internal_Vector2_FloatMenuModifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New.__c>.NativeClassPtr, 100667702);
			}

			// Token: 0x0600957D RID: 38269 RVA: 0x0028350C File Offset: 0x0028170C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastTravelPanel_New.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600957E RID: 38270 RVA: 0x00283548 File Offset: 0x00281748
			[CallerCount(0)]
			public unsafe IGuideMapSpot _OnGuideMapInitialize_b__15_1(FastTravelPanel_New.FloatMenuModifier x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__15_1_Internal_IGuideMapSpot_FloatMenuModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr3) : null;
			}

			// Token: 0x0600957F RID: 38271 RVA: 0x002835A0 File Offset: 0x002817A0
			[CallerCount(0)]
			public unsafe Vector2 _OnGuideMapInitialize_b__15_2(FastTravelPanel_New.FloatMenuModifier x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.__c.NativeMethodInfoPtr__OnGuideMapInitialize_b__15_2_Internal_Vector2_FloatMenuModifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009580 RID: 38272 RVA: 0x00050D5E File Offset: 0x0004EF5E
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031AA RID: 12714
			// (get) Token: 0x06009581 RID: 38273 RVA: 0x002835F4 File Offset: 0x002817F4
			// (set) Token: 0x06009582 RID: 38274 RVA: 0x00050D67 File Offset: 0x0004EF67
			public unsafe static FastTravelPanel_New.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FastTravelPanel_New.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastTravelPanel_New.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FastTravelPanel_New.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031AB RID: 12715
			// (get) Token: 0x06009583 RID: 38275 RVA: 0x0028361C File Offset: 0x0028181C
			// (set) Token: 0x06009584 RID: 38276 RVA: 0x00050D79 File Offset: 0x0004EF79
			public unsafe static Func<FastTravelPanel_New.FloatMenuModifier, IGuideMapSpot> __9__15_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FastTravelPanel_New.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FastTravelPanel_New.FloatMenuModifier, IGuideMapSpot>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FastTravelPanel_New.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031AC RID: 12716
			// (get) Token: 0x06009585 RID: 38277 RVA: 0x00283644 File Offset: 0x00281844
			// (set) Token: 0x06009586 RID: 38278 RVA: 0x00050D8B File Offset: 0x0004EF8B
			public unsafe static Func<FastTravelPanel_New.FloatMenuModifier, Vector2> __9__15_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FastTravelPanel_New.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<FastTravelPanel_New.FloatMenuModifier, Vector2>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FastTravelPanel_New.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040060F8 RID: 24824
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040060F9 RID: 24825
			private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

			// Token: 0x040060FA RID: 24826
			private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

			// Token: 0x040060FB RID: 24827
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040060FC RID: 24828
			private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__15_1_Internal_IGuideMapSpot_FloatMenuModifier_0;

			// Token: 0x040060FD RID: 24829
			private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapInitialize_b__15_2_Internal_Vector2_FloatMenuModifier_0;
		}

		// Token: 0x02000679 RID: 1657
		[ObfuscatedName("DayScene.UI.FastTravelPanel_New+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x06009587 RID: 38279 RVA: 0x0028366C File Offset: 0x0028186C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<FastTravelPanel_New.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastTravelPanel_New.__c__DisplayClass18_0>.NativeClassPtr);
				FastTravelPanel_New.__c__DisplayClass18_0.NativeFieldInfoPtr_currentActiveMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New.__c__DisplayClass18_0>.NativeClassPtr, "currentActiveMapLabel");
				FastTravelPanel_New.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New.__c__DisplayClass18_0>.NativeClassPtr, 100667703);
				FastTravelPanel_New.__c__DisplayClass18_0.NativeMethodInfoPtr__OnGuideMapPanelPostOpen_b__0_Internal_Boolean_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New.__c__DisplayClass18_0>.NativeClassPtr, 100667704);
			}

			// Token: 0x06009588 RID: 38280 RVA: 0x002836D4 File Offset: 0x002818D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastTravelPanel_New.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009589 RID: 38281 RVA: 0x00283710 File Offset: 0x00281910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 67215, XrefRangeEnd = 67220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnGuideMapPanelPostOpen_b__0(IGuideMapSpot guideMapSpot)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guideMapSpot);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New.__c__DisplayClass18_0.NativeMethodInfoPtr__OnGuideMapPanelPostOpen_b__0_Internal_Boolean_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600958A RID: 38282 RVA: 0x00050D9D File Offset: 0x0004EF9D
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170031AD RID: 12717
			// (get) Token: 0x0600958B RID: 38283 RVA: 0x00283760 File Offset: 0x00281960
			// (set) Token: 0x0600958C RID: 38284 RVA: 0x00050DA6 File Offset: 0x0004EFA6
			public unsafe string currentActiveMapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.__c__DisplayClass18_0.NativeFieldInfoPtr_currentActiveMapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New.__c__DisplayClass18_0.NativeFieldInfoPtr_currentActiveMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040060FE RID: 24830
			private static readonly IntPtr NativeFieldInfoPtr_currentActiveMapLabel;

			// Token: 0x040060FF RID: 24831
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006100 RID: 24832
			private static readonly IntPtr NativeMethodInfoPtr__OnGuideMapPanelPostOpen_b__0_Internal_Boolean_IGuideMapSpot_0;
		}

		// Token: 0x0200067A RID: 1658
		[ObfuscatedName("DayScene.UI.FastTravelPanel_New+<OnGuideMapSpotSubmitAsync>d__22")]
		public sealed class _OnGuideMapSpotSubmitAsync_d__22 : ValueType
		{
			// Token: 0x0600958D RID: 38285 RVA: 0x00283788 File Offset: 0x00281988
			// Note: this type is marked as 'beforefieldinit'.
			static _OnGuideMapSpotSubmitAsync_d__22()
			{
				Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FastTravelPanel_New>.NativeClassPtr, "<OnGuideMapSpotSubmitAsync>d__22");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr);
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, "<>1__state");
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, "<>t__builder");
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, "<>4__this");
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr_guideMapSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, "guideMapSpot");
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr__mapName_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, "<mapName>5__2");
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr__cost_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, "<cost>5__3");
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr__yukariTeleportCost_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, "<yukariTeleportCost>5__4");
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, "<>u__1");
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, 100667705);
				FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr, 100667706);
			}

			// Token: 0x0600958E RID: 38286 RVA: 0x0028387C File Offset: 0x00281A7C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 67295, RefRangeEnd = 67298, XrefRangeStart = 67220, XrefRangeEnd = 67295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600958F RID: 38287 RVA: 0x002838B4 File Offset: 0x00281AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009590 RID: 38288 RVA: 0x00050DC5 File Offset: 0x0004EFC5
			public _OnGuideMapSpotSubmitAsync_d__22(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009591 RID: 38289 RVA: 0x00050DCE File Offset: 0x0004EFCE
			public _OnGuideMapSpotSubmitAsync_d__22() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22>.NativeClassPtr))
			{
			}

			// Token: 0x170031AE RID: 12718
			// (get) Token: 0x06009592 RID: 38290 RVA: 0x002838FC File Offset: 0x00281AFC
			// (set) Token: 0x06009593 RID: 38291 RVA: 0x00050DE0 File Offset: 0x0004EFE0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170031AF RID: 12719
			// (get) Token: 0x06009594 RID: 38292 RVA: 0x00283924 File Offset: 0x00281B24
			// (set) Token: 0x06009595 RID: 38293 RVA: 0x00050DFB File Offset: 0x0004EFFB
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170031B0 RID: 12720
			// (get) Token: 0x06009596 RID: 38294 RVA: 0x00283954 File Offset: 0x00281B54
			// (set) Token: 0x06009597 RID: 38295 RVA: 0x00050E29 File Offset: 0x0004F029
			public unsafe FastTravelPanel_New __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FastTravelPanel_New>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031B1 RID: 12721
			// (get) Token: 0x06009598 RID: 38296 RVA: 0x00283984 File Offset: 0x00281B84
			// (set) Token: 0x06009599 RID: 38297 RVA: 0x00050E48 File Offset: 0x0004F048
			public unsafe IGuideMapSpot guideMapSpot
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr_guideMapSpot);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGuideMapSpot>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr_guideMapSpot), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170031B2 RID: 12722
			// (get) Token: 0x0600959A RID: 38298 RVA: 0x002839B4 File Offset: 0x00281BB4
			// (set) Token: 0x0600959B RID: 38299 RVA: 0x00050E67 File Offset: 0x0004F067
			public unsafe string _mapName_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr__mapName_5__2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr__mapName_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170031B3 RID: 12723
			// (get) Token: 0x0600959C RID: 38300 RVA: 0x002839DC File Offset: 0x00281BDC
			// (set) Token: 0x0600959D RID: 38301 RVA: 0x00050E86 File Offset: 0x0004F086
			public unsafe int _cost_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr__cost_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr__cost_5__3)) = value;
				}
			}

			// Token: 0x170031B4 RID: 12724
			// (get) Token: 0x0600959E RID: 38302 RVA: 0x00283A04 File Offset: 0x00281C04
			// (set) Token: 0x0600959F RID: 38303 RVA: 0x00050EA1 File Offset: 0x0004F0A1
			public unsafe int _yukariTeleportCost_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr__yukariTeleportCost_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr__yukariTeleportCost_5__4)) = value;
				}
			}

			// Token: 0x170031B5 RID: 12725
			// (get) Token: 0x060095A0 RID: 38304 RVA: 0x00283A2C File Offset: 0x00281C2C
			// (set) Token: 0x060095A1 RID: 38305 RVA: 0x00050EBC File Offset: 0x0004F0BC
			public UniTask<DaySceneFastTravelSubPannel.PannelCloseData>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___u__1);
					return new UniTask<DaySceneFastTravelSubPannel.PannelCloseData>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<DaySceneFastTravelSubPannel.PannelCloseData>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FastTravelPanel_New._OnGuideMapSpotSubmitAsync_d__22.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<DaySceneFastTravelSubPannel.PannelCloseData>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006101 RID: 24833
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006102 RID: 24834
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006103 RID: 24835
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006104 RID: 24836
			private static readonly IntPtr NativeFieldInfoPtr_guideMapSpot;

			// Token: 0x04006105 RID: 24837
			private static readonly IntPtr NativeFieldInfoPtr__mapName_5__2;

			// Token: 0x04006106 RID: 24838
			private static readonly IntPtr NativeFieldInfoPtr__cost_5__3;

			// Token: 0x04006107 RID: 24839
			private static readonly IntPtr NativeFieldInfoPtr__yukariTeleportCost_5__4;

			// Token: 0x04006108 RID: 24840
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006109 RID: 24841
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400610A RID: 24842
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
