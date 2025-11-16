using System;
using Common.UI;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine.AddressableAssets;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000127 RID: 295
	public class DLC5_RogueLikeTutorialPanel : UIPanelParamOpen<bool>
	{
		// Token: 0x0600220B RID: 8715 RVA: 0x0010F378 File Offset: 0x0010D578
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeTutorialPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeTutorialPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr);
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_BaseRule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_Button_BaseRule");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_AboutKourindou = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_Button_AboutKourindou");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_AboutCard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_Button_AboutCard");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_AboutMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_Button_AboutMap");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_MoreRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_Button_MoreRules");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_Button_End");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_Bye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_Button_Bye");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_EndFirstTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_EndFirstTutorial");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_BaseRuleImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_BaseRuleImage");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_KourindouImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_KourindouImage");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_CardImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_CardImage");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MapImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_MapImage");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MoreRuleImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_MoreRuleImage");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_BaseRuleImageHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_BaseRuleImageHandle");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_KourindouImageHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_KourindouImageHandle");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_CardImageHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_CardImageHandle");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MapImageHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_MapImageHandle");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MoreRuleImageHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "m_MoreRuleImageHandle");
			DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr__CleanRogueTutorialCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "<CleanRogueTutorialCallback>k__BackingField");
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669383);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669384);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_get_CleanRogueTutorialCallback_Public_Static_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669385);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_set_CleanRogueTutorialCallback_Private_Static_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669386);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_TriggerCleanRogueTutorialCallback_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669387);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669388);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_CleanRogueTutorialPanelHandle_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669389);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenBaseRuleImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669390);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenKourindouImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669391);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenCardImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669392);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenMapImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669393);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenMoreImage_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669394);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_TryLoadOrOpenTargetTutorial_Private_UniTask_TutorialType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669395);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_TryLoadOrOpenTargetTutorialInternal_Private_UniTask_IGameObjectAssetHandle_1_ImageDisplayerPannel_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669396);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669397);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669398);
			DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr__OnPanelInitialize_b__19_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, 100669399);
		}

		// Token: 0x0600220C RID: 8716 RVA: 0x0010F678 File Offset: 0x0010D878
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83240, XrefRangeEnd = 83289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600220D RID: 8717 RVA: 0x0010F6B4 File Offset: 0x0010D8B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83289, XrefRangeEnd = 83306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(bool isFirstTutorial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref isFirstTutorial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600220E RID: 8718 RVA: 0x0010F700 File Offset: 0x0010D900
		// (set) Token: 0x0600220F RID: 8719 RVA: 0x0010F734 File Offset: 0x0010D934
		public unsafe static Action CleanRogueTutorialCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83306, XrefRangeEnd = 83308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_get_CleanRogueTutorialCallback_Public_Static_get_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83308, XrefRangeEnd = 83312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_set_CleanRogueTutorialCallback_Private_Static_set_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0010F76C File Offset: 0x0010D96C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 83318, RefRangeEnd = 83321, XrefRangeStart = 83312, XrefRangeEnd = 83318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void TriggerCleanRogueTutorialCallback()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_TriggerCleanRogueTutorialCallback_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x0010F794 File Offset: 0x0010D994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83321, XrefRangeEnd = 83323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0010F7D0 File Offset: 0x0010D9D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83323, XrefRangeEnd = 83338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CleanRogueTutorialPanelHandle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_CleanRogueTutorialPanelHandle_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0010F804 File Offset: 0x0010DA04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83338, XrefRangeEnd = 83340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenBaseRuleImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenBaseRuleImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x0010F838 File Offset: 0x0010DA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83340, XrefRangeEnd = 83342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenKourindouImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenKourindouImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0010F86C File Offset: 0x0010DA6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83342, XrefRangeEnd = 83344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenCardImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenCardImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0010F8A0 File Offset: 0x0010DAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83344, XrefRangeEnd = 83346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenMapImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenMapImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002217 RID: 8727 RVA: 0x0010F8D4 File Offset: 0x0010DAD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83346, XrefRangeEnd = 83348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenMoreImage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_OpenMoreImage_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002218 RID: 8728 RVA: 0x0010F908 File Offset: 0x0010DB08
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 83354, RefRangeEnd = 83359, XrefRangeStart = 83348, XrefRangeEnd = 83354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask TryLoadOrOpenTargetTutorial(DLC5_RogueLikeTutorialPanel.TutorialType tutorialType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref tutorialType;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_TryLoadOrOpenTargetTutorial_Private_UniTask_TutorialType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06002219 RID: 8729 RVA: 0x0010F94C File Offset: 0x0010DB4C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 83366, RefRangeEnd = 83371, XrefRangeStart = 83359, XrefRangeEnd = 83366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask TryLoadOrOpenTargetTutorialInternal(IGameObjectAssetHandle<ImageDisplayerPannel> handle, AssetReference baseReference)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(baseReference);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_TryLoadOrOpenTargetTutorialInternal_Private_UniTask_IGameObjectAssetHandle_1_ImageDisplayerPannel_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600221A RID: 8730 RVA: 0x0010F9A8 File Offset: 0x0010DBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83371, XrefRangeEnd = 83394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600221B RID: 8731 RVA: 0x0010F9E4 File Offset: 0x0010DBE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83394, XrefRangeEnd = 83397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeTutorialPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600221C RID: 8732 RVA: 0x0010FA20 File Offset: 0x0010DC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83397, XrefRangeEnd = 83407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__19_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel.NativeMethodInfoPtr__OnPanelInitialize_b__19_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600221D RID: 8733 RVA: 0x00014B95 File Offset: 0x00012D95
		public DLC5_RogueLikeTutorialPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B5A RID: 2906
		// (get) Token: 0x0600221E RID: 8734 RVA: 0x0010FA54 File Offset: 0x0010DC54
		// (set) Token: 0x0600221F RID: 8735 RVA: 0x00014B9E File Offset: 0x00012D9E
		public unsafe UIButtonSimple m_Button_BaseRule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_BaseRule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_BaseRule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5B RID: 2907
		// (get) Token: 0x06002220 RID: 8736 RVA: 0x0010FA84 File Offset: 0x0010DC84
		// (set) Token: 0x06002221 RID: 8737 RVA: 0x00014BBD File Offset: 0x00012DBD
		public unsafe UIButtonSimple m_Button_AboutKourindou
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_AboutKourindou);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_AboutKourindou), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5C RID: 2908
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x0010FAB4 File Offset: 0x0010DCB4
		// (set) Token: 0x06002223 RID: 8739 RVA: 0x00014BDC File Offset: 0x00012DDC
		public unsafe UIButtonSimple m_Button_AboutCard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_AboutCard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_AboutCard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5D RID: 2909
		// (get) Token: 0x06002224 RID: 8740 RVA: 0x0010FAE4 File Offset: 0x0010DCE4
		// (set) Token: 0x06002225 RID: 8741 RVA: 0x00014BFB File Offset: 0x00012DFB
		public unsafe UIButtonSimple m_Button_AboutMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_AboutMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_AboutMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002226 RID: 8742 RVA: 0x0010FB14 File Offset: 0x0010DD14
		// (set) Token: 0x06002227 RID: 8743 RVA: 0x00014C1A File Offset: 0x00012E1A
		public unsafe UIButtonSimple m_Button_MoreRules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_MoreRules);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_MoreRules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x0010FB44 File Offset: 0x0010DD44
		// (set) Token: 0x06002229 RID: 8745 RVA: 0x00014C39 File Offset: 0x00012E39
		public unsafe UIButtonSimple m_Button_End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_End);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_End), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B60 RID: 2912
		// (get) Token: 0x0600222A RID: 8746 RVA: 0x0010FB74 File Offset: 0x0010DD74
		// (set) Token: 0x0600222B RID: 8747 RVA: 0x00014C58 File Offset: 0x00012E58
		public unsafe UIButtonSimple m_Button_Bye
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_Bye);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_Button_Bye), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x0600222C RID: 8748 RVA: 0x0010FBA4 File Offset: 0x0010DDA4
		// (set) Token: 0x0600222D RID: 8749 RVA: 0x00014C77 File Offset: 0x00012E77
		public unsafe DialogPackage m_EndFirstTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_EndFirstTutorial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_EndFirstTutorial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x0600222E RID: 8750 RVA: 0x0010FBD4 File Offset: 0x0010DDD4
		// (set) Token: 0x0600222F RID: 8751 RVA: 0x00014C96 File Offset: 0x00012E96
		public unsafe AssetReference m_BaseRuleImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_BaseRuleImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_BaseRuleImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x06002230 RID: 8752 RVA: 0x0010FC04 File Offset: 0x0010DE04
		// (set) Token: 0x06002231 RID: 8753 RVA: 0x00014CB5 File Offset: 0x00012EB5
		public unsafe AssetReference m_KourindouImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_KourindouImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_KourindouImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x0010FC34 File Offset: 0x0010DE34
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x00014CD4 File Offset: 0x00012ED4
		public unsafe AssetReference m_CardImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_CardImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_CardImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B65 RID: 2917
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x0010FC64 File Offset: 0x0010DE64
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x00014CF3 File Offset: 0x00012EF3
		public unsafe AssetReference m_MapImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MapImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MapImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B66 RID: 2918
		// (get) Token: 0x06002236 RID: 8758 RVA: 0x0010FC94 File Offset: 0x0010DE94
		// (set) Token: 0x06002237 RID: 8759 RVA: 0x00014D12 File Offset: 0x00012F12
		public unsafe AssetReference m_MoreRuleImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MoreRuleImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MoreRuleImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B67 RID: 2919
		// (get) Token: 0x06002238 RID: 8760 RVA: 0x0010FCC4 File Offset: 0x0010DEC4
		// (set) Token: 0x06002239 RID: 8761 RVA: 0x00014D31 File Offset: 0x00012F31
		public unsafe IGameObjectAssetHandle<ImageDisplayerPannel> m_BaseRuleImageHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_BaseRuleImageHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<ImageDisplayerPannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_BaseRuleImageHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B68 RID: 2920
		// (get) Token: 0x0600223A RID: 8762 RVA: 0x0010FCF4 File Offset: 0x0010DEF4
		// (set) Token: 0x0600223B RID: 8763 RVA: 0x00014D50 File Offset: 0x00012F50
		public unsafe IGameObjectAssetHandle<ImageDisplayerPannel> m_KourindouImageHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_KourindouImageHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<ImageDisplayerPannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_KourindouImageHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B69 RID: 2921
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x0010FD24 File Offset: 0x0010DF24
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x00014D6F File Offset: 0x00012F6F
		public unsafe IGameObjectAssetHandle<ImageDisplayerPannel> m_CardImageHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_CardImageHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<ImageDisplayerPannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_CardImageHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6A RID: 2922
		// (get) Token: 0x0600223E RID: 8766 RVA: 0x0010FD54 File Offset: 0x0010DF54
		// (set) Token: 0x0600223F RID: 8767 RVA: 0x00014D8E File Offset: 0x00012F8E
		public unsafe IGameObjectAssetHandle<ImageDisplayerPannel> m_MapImageHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MapImageHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<ImageDisplayerPannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MapImageHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6B RID: 2923
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x0010FD84 File Offset: 0x0010DF84
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x00014DAD File Offset: 0x00012FAD
		public unsafe IGameObjectAssetHandle<ImageDisplayerPannel> m_MoreRuleImageHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MoreRuleImageHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<ImageDisplayerPannel>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr_m_MoreRuleImageHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B6C RID: 2924
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x0010FDB4 File Offset: 0x0010DFB4
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x00014DCC File Offset: 0x00012FCC
		public unsafe static Action _CleanRogueTutorialCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr__CleanRogueTutorialCallback_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeTutorialPanel.NativeFieldInfoPtr__CleanRogueTutorialCallback_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001698 RID: 5784
		private static readonly IntPtr NativeFieldInfoPtr_m_Button_BaseRule;

		// Token: 0x04001699 RID: 5785
		private static readonly IntPtr NativeFieldInfoPtr_m_Button_AboutKourindou;

		// Token: 0x0400169A RID: 5786
		private static readonly IntPtr NativeFieldInfoPtr_m_Button_AboutCard;

		// Token: 0x0400169B RID: 5787
		private static readonly IntPtr NativeFieldInfoPtr_m_Button_AboutMap;

		// Token: 0x0400169C RID: 5788
		private static readonly IntPtr NativeFieldInfoPtr_m_Button_MoreRules;

		// Token: 0x0400169D RID: 5789
		private static readonly IntPtr NativeFieldInfoPtr_m_Button_End;

		// Token: 0x0400169E RID: 5790
		private static readonly IntPtr NativeFieldInfoPtr_m_Button_Bye;

		// Token: 0x0400169F RID: 5791
		private static readonly IntPtr NativeFieldInfoPtr_m_EndFirstTutorial;

		// Token: 0x040016A0 RID: 5792
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseRuleImage;

		// Token: 0x040016A1 RID: 5793
		private static readonly IntPtr NativeFieldInfoPtr_m_KourindouImage;

		// Token: 0x040016A2 RID: 5794
		private static readonly IntPtr NativeFieldInfoPtr_m_CardImage;

		// Token: 0x040016A3 RID: 5795
		private static readonly IntPtr NativeFieldInfoPtr_m_MapImage;

		// Token: 0x040016A4 RID: 5796
		private static readonly IntPtr NativeFieldInfoPtr_m_MoreRuleImage;

		// Token: 0x040016A5 RID: 5797
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseRuleImageHandle;

		// Token: 0x040016A6 RID: 5798
		private static readonly IntPtr NativeFieldInfoPtr_m_KourindouImageHandle;

		// Token: 0x040016A7 RID: 5799
		private static readonly IntPtr NativeFieldInfoPtr_m_CardImageHandle;

		// Token: 0x040016A8 RID: 5800
		private static readonly IntPtr NativeFieldInfoPtr_m_MapImageHandle;

		// Token: 0x040016A9 RID: 5801
		private static readonly IntPtr NativeFieldInfoPtr_m_MoreRuleImageHandle;

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeFieldInfoPtr__CleanRogueTutorialCallback_k__BackingField;

		// Token: 0x040016AB RID: 5803
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040016AC RID: 5804
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_Boolean_0;

		// Token: 0x040016AD RID: 5805
		private static readonly IntPtr NativeMethodInfoPtr_get_CleanRogueTutorialCallback_Public_Static_get_Action_0;

		// Token: 0x040016AE RID: 5806
		private static readonly IntPtr NativeMethodInfoPtr_set_CleanRogueTutorialCallback_Private_Static_set_Void_Action_0;

		// Token: 0x040016AF RID: 5807
		private static readonly IntPtr NativeMethodInfoPtr_TriggerCleanRogueTutorialCallback_Public_Static_Void_0;

		// Token: 0x040016B0 RID: 5808
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x040016B1 RID: 5809
		private static readonly IntPtr NativeMethodInfoPtr_CleanRogueTutorialPanelHandle_Private_Void_0;

		// Token: 0x040016B2 RID: 5810
		private static readonly IntPtr NativeMethodInfoPtr_OpenBaseRuleImage_Private_Void_0;

		// Token: 0x040016B3 RID: 5811
		private static readonly IntPtr NativeMethodInfoPtr_OpenKourindouImage_Private_Void_0;

		// Token: 0x040016B4 RID: 5812
		private static readonly IntPtr NativeMethodInfoPtr_OpenCardImage_Private_Void_0;

		// Token: 0x040016B5 RID: 5813
		private static readonly IntPtr NativeMethodInfoPtr_OpenMapImage_Private_Void_0;

		// Token: 0x040016B6 RID: 5814
		private static readonly IntPtr NativeMethodInfoPtr_OpenMoreImage_Private_Void_0;

		// Token: 0x040016B7 RID: 5815
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadOrOpenTargetTutorial_Private_UniTask_TutorialType_0;

		// Token: 0x040016B8 RID: 5816
		private static readonly IntPtr NativeMethodInfoPtr_TryLoadOrOpenTargetTutorialInternal_Private_UniTask_IGameObjectAssetHandle_1_ImageDisplayerPannel_AssetReference_0;

		// Token: 0x040016B9 RID: 5817
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040016BA RID: 5818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040016BB RID: 5819
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__19_0_Private_Void_0;

		// Token: 0x02000749 RID: 1865
		public enum TutorialType
		{
			// Token: 0x04006739 RID: 26425
			BaseRuleImage,
			// Token: 0x0400673A RID: 26426
			KourindouImage,
			// Token: 0x0400673B RID: 26427
			CardImage,
			// Token: 0x0400673C RID: 26428
			MapImage,
			// Token: 0x0400673D RID: 26429
			MoreRuleImage
		}

		// Token: 0x0200074A RID: 1866
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeTutorialPanel+<TryLoadOrOpenTargetTutorial>d__33")]
		public sealed class _TryLoadOrOpenTargetTutorial_d__33 : ValueType
		{
			// Token: 0x06009F2B RID: 40747 RVA: 0x002A0E18 File Offset: 0x0029F018
			// Note: this type is marked as 'beforefieldinit'.
			static _TryLoadOrOpenTargetTutorial_d__33()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "<TryLoadOrOpenTargetTutorial>d__33");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr);
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr_tutorialType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr, "tutorialType");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr, 100669400);
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr, 100669401);
			}

			// Token: 0x06009F2C RID: 40748 RVA: 0x002A0ED0 File Offset: 0x0029F0D0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 83210, RefRangeEnd = 83213, XrefRangeStart = 83158, XrefRangeEnd = 83210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F2D RID: 40749 RVA: 0x002A0F08 File Offset: 0x0029F108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F2E RID: 40750 RVA: 0x00055F7E File Offset: 0x0005417E
			public _TryLoadOrOpenTargetTutorial_d__33(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009F2F RID: 40751 RVA: 0x00055F87 File Offset: 0x00054187
			public _TryLoadOrOpenTargetTutorial_d__33() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33>.NativeClassPtr))
			{
			}

			// Token: 0x17003493 RID: 13459
			// (get) Token: 0x06009F30 RID: 40752 RVA: 0x002A0F50 File Offset: 0x0029F150
			// (set) Token: 0x06009F31 RID: 40753 RVA: 0x00055F99 File Offset: 0x00054199
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003494 RID: 13460
			// (get) Token: 0x06009F32 RID: 40754 RVA: 0x002A0F78 File Offset: 0x0029F178
			// (set) Token: 0x06009F33 RID: 40755 RVA: 0x00055FB4 File Offset: 0x000541B4
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003495 RID: 13461
			// (get) Token: 0x06009F34 RID: 40756 RVA: 0x002A0FA8 File Offset: 0x0029F1A8
			// (set) Token: 0x06009F35 RID: 40757 RVA: 0x00055FE2 File Offset: 0x000541E2
			public unsafe DLC5_RogueLikeTutorialPanel.TutorialType tutorialType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr_tutorialType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr_tutorialType)) = value;
				}
			}

			// Token: 0x17003496 RID: 13462
			// (get) Token: 0x06009F36 RID: 40758 RVA: 0x002A0FD0 File Offset: 0x0029F1D0
			// (set) Token: 0x06009F37 RID: 40759 RVA: 0x00055FFD File Offset: 0x000541FD
			public unsafe DLC5_RogueLikeTutorialPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeTutorialPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003497 RID: 13463
			// (get) Token: 0x06009F38 RID: 40760 RVA: 0x002A1000 File Offset: 0x0029F200
			// (set) Token: 0x06009F39 RID: 40761 RVA: 0x0005601C File Offset: 0x0005421C
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorial_d__33.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400673E RID: 26430
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400673F RID: 26431
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006740 RID: 26432
			private static readonly IntPtr NativeFieldInfoPtr_tutorialType;

			// Token: 0x04006741 RID: 26433
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006742 RID: 26434
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04006743 RID: 26435
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006744 RID: 26436
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}

		// Token: 0x0200074B RID: 1867
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeTutorialPanel+<TryLoadOrOpenTargetTutorialInternal>d__34")]
		public sealed class _TryLoadOrOpenTargetTutorialInternal_d__34 : ValueType
		{
			// Token: 0x06009F3A RID: 40762 RVA: 0x002A1030 File Offset: 0x0029F230
			// Note: this type is marked as 'beforefieldinit'.
			static _TryLoadOrOpenTargetTutorialInternal_d__34()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel>.NativeClassPtr, "<TryLoadOrOpenTargetTutorialInternal>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr);
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr, "handle");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr_baseReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr, "baseReference");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr, 100669402);
				DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr, 100669403);
			}

			// Token: 0x06009F3B RID: 40763 RVA: 0x002A10E8 File Offset: 0x0029F2E8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 83237, RefRangeEnd = 83240, XrefRangeStart = 83213, XrefRangeEnd = 83237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F3C RID: 40764 RVA: 0x002A1120 File Offset: 0x0029F320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009F3D RID: 40765 RVA: 0x0005604A File Offset: 0x0005424A
			public _TryLoadOrOpenTargetTutorialInternal_d__34(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009F3E RID: 40766 RVA: 0x00056053 File Offset: 0x00054253
			public _TryLoadOrOpenTargetTutorialInternal_d__34() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34>.NativeClassPtr))
			{
			}

			// Token: 0x17003498 RID: 13464
			// (get) Token: 0x06009F3F RID: 40767 RVA: 0x002A1168 File Offset: 0x0029F368
			// (set) Token: 0x06009F40 RID: 40768 RVA: 0x00056065 File Offset: 0x00054265
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003499 RID: 13465
			// (get) Token: 0x06009F41 RID: 40769 RVA: 0x002A1190 File Offset: 0x0029F390
			// (set) Token: 0x06009F42 RID: 40770 RVA: 0x00056080 File Offset: 0x00054280
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700349A RID: 13466
			// (get) Token: 0x06009F43 RID: 40771 RVA: 0x002A11C0 File Offset: 0x0029F3C0
			// (set) Token: 0x06009F44 RID: 40772 RVA: 0x000560AE File Offset: 0x000542AE
			public unsafe IGameObjectAssetHandle<ImageDisplayerPannel> handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr_handle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IGameObjectAssetHandle<ImageDisplayerPannel>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700349B RID: 13467
			// (get) Token: 0x06009F45 RID: 40773 RVA: 0x002A11F0 File Offset: 0x0029F3F0
			// (set) Token: 0x06009F46 RID: 40774 RVA: 0x000560CD File Offset: 0x000542CD
			public unsafe AssetReference baseReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr_baseReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr_baseReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700349C RID: 13468
			// (get) Token: 0x06009F47 RID: 40775 RVA: 0x002A1220 File Offset: 0x0029F420
			// (set) Token: 0x06009F48 RID: 40776 RVA: 0x000560EC File Offset: 0x000542EC
			public UniTask<IGameObjectAssetHandle<ImageDisplayerPannel>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr___u__1);
					return new UniTask<IGameObjectAssetHandle<ImageDisplayerPannel>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<ImageDisplayerPannel>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeTutorialPanel._TryLoadOrOpenTargetTutorialInternal_d__34.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IGameObjectAssetHandle<ImageDisplayerPannel>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006745 RID: 26437
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006746 RID: 26438
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04006747 RID: 26439
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x04006748 RID: 26440
			private static readonly IntPtr NativeFieldInfoPtr_baseReference;

			// Token: 0x04006749 RID: 26441
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400674A RID: 26442
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400674B RID: 26443
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
