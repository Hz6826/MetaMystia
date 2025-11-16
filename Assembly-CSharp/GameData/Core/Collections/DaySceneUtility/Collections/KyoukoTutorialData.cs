using System;
using Cysharp.Threading.Tasks;
using DayScene.UI;
using DEYU.AssetHandleUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002A3 RID: 675
	[Serializable]
	public class KyoukoTutorialData : Il2CppSystem.Object
	{
		// Token: 0x060055BA RID: 21946 RVA: 0x001BF7DC File Offset: 0x001BD9DC
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData()
		{
			Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr);
			KyoukoTutorialData.NativeFieldInfoPtr_EVENT_MARK_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "EVENT_MARK_KEY");
			KyoukoTutorialData.NativeFieldInfoPtr_s_KyoukoExtraDialogDataConfirmCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "s_KyoukoExtraDialogDataConfirmCallback");
			KyoukoTutorialData.NativeFieldInfoPtr_tutorialStartDialogForKeyBoard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "tutorialStartDialogForKeyBoard");
			KyoukoTutorialData.NativeFieldInfoPtr_tutorialStartDialogForSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "tutorialStartDialogForSwitch");
			KyoukoTutorialData.NativeFieldInfoPtr_tutorialStartDialogNSAlternative = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "tutorialStartDialogNSAlternative");
			KyoukoTutorialData.NativeFieldInfoPtr_notDefaultPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "notDefaultPrompt");
			KyoukoTutorialData.NativeFieldInfoPtr_tutorialPhraseKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "tutorialPhraseKey");
			KyoukoTutorialData.NativeFieldInfoPtr_tutorialEventOrTrackedLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "tutorialEventOrTrackedLabel");
			KyoukoTutorialData.NativeFieldInfoPtr_eventLabelMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "eventLabelMode");
			KyoukoTutorialData.NativeFieldInfoPtr_beginEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "beginEvent");
			KyoukoTutorialData.NativeFieldInfoPtr_beginMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "beginMission");
			KyoukoTutorialData.NativeFieldInfoPtr_needToConfirm = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "needToConfirm");
			KyoukoTutorialData.NativeFieldInfoPtr__SelectionCloseCallback_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "<SelectionCloseCallback>k__BackingField");
			KyoukoTutorialData.NativeFieldInfoPtr__ParentSelection_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "<ParentSelection>k__BackingField");
			KyoukoTutorialData.NativeMethodInfoPtr_get_KyoukoExtraDialogDataConfirmCallback_Private_Static_get_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680779);
			KyoukoTutorialData.NativeMethodInfoPtr_set_KyoukoExtraDialogDataConfirmCallback_Public_Static_set_Void_Action_1_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680780);
			KyoukoTutorialData.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680781);
			KyoukoTutorialData.NativeMethodInfoPtr_get_NeedCheckSwitch_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680782);
			KyoukoTutorialData.NativeMethodInfoPtr_get_HaveFinishedTutorial_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680783);
			KyoukoTutorialData.NativeMethodInfoPtr_get_SelectionCloseCallback_Private_get_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680784);
			KyoukoTutorialData.NativeMethodInfoPtr_set_SelectionCloseCallback_Private_set_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680785);
			KyoukoTutorialData.NativeMethodInfoPtr_get_ParentSelection_Public_get_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680786);
			KyoukoTutorialData.NativeMethodInfoPtr_set_ParentSelection_Public_set_Void_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680787);
			KyoukoTutorialData.NativeMethodInfoPtr_GetTutorialTitle_Protected_Virtual_New_String_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680788);
			KyoukoTutorialData.NativeMethodInfoPtr_OnButtonInteract_Protected_Virtual_New_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680789);
			KyoukoTutorialData.NativeMethodInfoPtr_AfterDialog_Protected_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680790);
			KyoukoTutorialData.NativeMethodInfoPtr_Call_Protected_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680791);
			KyoukoTutorialData.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_New_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680792);
			KyoukoTutorialData.NativeMethodInfoPtr_FinishTutorialEvent_Protected_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680793);
			KyoukoTutorialData.NativeMethodInfoPtr_GetButton_Public_Void_BaseInteractData_Func_2_Boolean_Boolean_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680794);
			KyoukoTutorialData.NativeMethodInfoPtr_OnButtonInteractAsync_Protected_Static_UniTask_1_IAssetHandle_1_GameObject_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680795);
			KyoukoTutorialData.NativeMethodInfoPtr_CloseAllSelection_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680796);
			KyoukoTutorialData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, 100680797);
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x060055BB RID: 21947 RVA: 0x001BFAA0 File Offset: 0x001BDCA0
		// (set) Token: 0x060055BC RID: 21948 RVA: 0x001BFAD4 File Offset: 0x001BDCD4
		public unsafe static Action<Action> KyoukoExtraDialogDataConfirmCallback
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213739, XrefRangeEnd = 213741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_get_KyoukoExtraDialogDataConfirmCallback_Private_Static_get_Action_1_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213741, XrefRangeEnd = 213745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_set_KyoukoExtraDialogDataConfirmCallback_Public_Static_set_Void_Action_1_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x060055BD RID: 21949 RVA: 0x001BFB0C File Offset: 0x001BDD0C
		public unsafe virtual bool NeedToShow
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213745, XrefRangeEnd = 213750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D75 RID: 7541
		// (get) Token: 0x060055BE RID: 21950 RVA: 0x001BFB54 File Offset: 0x001BDD54
		public unsafe virtual bool NeedCheckSwitch
		{
			[CallerCount(299)]
			[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData.NativeMethodInfoPtr_get_NeedCheckSwitch_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D76 RID: 7542
		// (get) Token: 0x060055BF RID: 21951 RVA: 0x001BFB9C File Offset: 0x001BDD9C
		public unsafe virtual bool HaveFinishedTutorial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213750, XrefRangeEnd = 213755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData.NativeMethodInfoPtr_get_HaveFinishedTutorial_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D77 RID: 7543
		// (get) Token: 0x060055C0 RID: 21952 RVA: 0x001BFBE4 File Offset: 0x001BDDE4
		// (set) Token: 0x060055C1 RID: 21953 RVA: 0x001BFC24 File Offset: 0x001BDE24
		public unsafe Action SelectionCloseCallback
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 54348, RefRangeEnd = 54388, XrefRangeStart = 54348, XrefRangeEnd = 54388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_get_SelectionCloseCallback_Private_get_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_set_SelectionCloseCallback_Private_set_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001D78 RID: 7544
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x001BFC68 File Offset: 0x001BDE68
		// (set) Token: 0x060055C3 RID: 21955 RVA: 0x001BFCA8 File Offset: 0x001BDEA8
		public unsafe KyoukoTutorialData ParentSelection
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_get_ParentSelection_Public_get_KyoukoTutorialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_set_ParentSelection_Public_set_Void_KyoukoTutorialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060055C4 RID: 21956 RVA: 0x001BFCEC File Offset: 0x001BDEEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213755, XrefRangeEnd = 213762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetTutorialTitle(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData.NativeMethodInfoPtr_GetTutorialTitle_Protected_Virtual_New_String_BaseInteractData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060055C5 RID: 21957 RVA: 0x001BFD40 File Offset: 0x001BDF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213762, XrefRangeEnd = 213783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnButtonInteract(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData.NativeMethodInfoPtr_OnButtonInteract_Protected_Virtual_New_Void_BaseInteractData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C6 RID: 21958 RVA: 0x001BFD90 File Offset: 0x001BDF90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213791, RefRangeEnd = 213793, XrefRangeStart = 213783, XrefRangeEnd = 213791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AfterDialog(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_AfterDialog_Protected_Void_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x001BFDD4 File Offset: 0x001BDFD4
		[CallerCount(0)]
		public unsafe void Call(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_Call_Protected_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C8 RID: 21960 RVA: 0x001BFE18 File Offset: 0x001BE018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213793, XrefRangeEnd = 213794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_New_Void_BaseInteractData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055C9 RID: 21961 RVA: 0x001BFE68 File Offset: 0x001BE068
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 213810, RefRangeEnd = 213815, XrefRangeStart = 213794, XrefRangeEnd = 213810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishTutorialEvent(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_FinishTutorialEvent_Protected_Void_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055CA RID: 21962 RVA: 0x001BFEAC File Offset: 0x001BE0AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213830, RefRangeEnd = 213832, XrefRangeStart = 213815, XrefRangeEnd = 213830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetButton(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData, Func<bool, bool> extraCheck, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(extraCheck);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_GetButton_Public_Void_BaseInteractData_Func_2_Boolean_Boolean_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060055CB RID: 21963 RVA: 0x001BFF4C File Offset: 0x001BE14C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213832, XrefRangeEnd = 213841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UniTask<IAssetHandle<GameObject>> OnButtonInteractAsync(AssetReference targetGameObject)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetGameObject);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_OnButtonInteractAsync_Protected_Static_UniTask_1_IAssetHandle_1_GameObject_AssetReference_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask<IAssetHandle<GameObject>>(pointer);
		}

		// Token: 0x060055CC RID: 21964 RVA: 0x001BFF88 File Offset: 0x001BE188
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213842, RefRangeEnd = 213844, XrefRangeStart = 213841, XrefRangeEnd = 213842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseAllSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr_CloseAllSelection_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055CD RID: 21965 RVA: 0x001BFFBC File Offset: 0x001BE1BC
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055CE RID: 21966 RVA: 0x0002E2B1 File Offset: 0x0002C4B1
		public KyoukoTutorialData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x060055CF RID: 21967 RVA: 0x001BFFF8 File Offset: 0x001BE1F8
		// (set) Token: 0x060055D0 RID: 21968 RVA: 0x0002E2BA File Offset: 0x0002C4BA
		public unsafe static string EVENT_MARK_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialData.NativeFieldInfoPtr_EVENT_MARK_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialData.NativeFieldInfoPtr_EVENT_MARK_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x060055D1 RID: 21969 RVA: 0x001C0018 File Offset: 0x001BE218
		// (set) Token: 0x060055D2 RID: 21970 RVA: 0x0002E2CC File Offset: 0x0002C4CC
		public unsafe static Action<Action> s_KyoukoExtraDialogDataConfirmCallback
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialData.NativeFieldInfoPtr_s_KyoukoExtraDialogDataConfirmCallback, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialData.NativeFieldInfoPtr_s_KyoukoExtraDialogDataConfirmCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x060055D3 RID: 21971 RVA: 0x001C0040 File Offset: 0x001BE240
		// (set) Token: 0x060055D4 RID: 21972 RVA: 0x0002E2DE File Offset: 0x0002C4DE
		public unsafe DialogPackage tutorialStartDialogForKeyBoard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialStartDialogForKeyBoard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialStartDialogForKeyBoard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x060055D5 RID: 21973 RVA: 0x001C0070 File Offset: 0x001BE270
		// (set) Token: 0x060055D6 RID: 21974 RVA: 0x0002E2FD File Offset: 0x0002C4FD
		public unsafe DialogPackage tutorialStartDialogForSwitch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialStartDialogForSwitch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialStartDialogForSwitch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x060055D7 RID: 21975 RVA: 0x001C00A0 File Offset: 0x001BE2A0
		// (set) Token: 0x060055D8 RID: 21976 RVA: 0x0002E31C File Offset: 0x0002C51C
		public unsafe DialogPackage tutorialStartDialogNSAlternative
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialStartDialogNSAlternative);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialStartDialogNSAlternative), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x060055D9 RID: 21977 RVA: 0x001C00D0 File Offset: 0x001BE2D0
		// (set) Token: 0x060055DA RID: 21978 RVA: 0x0002E33B File Offset: 0x0002C53B
		public unsafe bool notDefaultPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_notDefaultPrompt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_notDefaultPrompt)) = value;
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x060055DB RID: 21979 RVA: 0x001C00F8 File Offset: 0x001BE2F8
		// (set) Token: 0x060055DC RID: 21980 RVA: 0x0002E356 File Offset: 0x0002C556
		public unsafe string tutorialPhraseKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialPhraseKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialPhraseKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x060055DD RID: 21981 RVA: 0x001C0120 File Offset: 0x001BE320
		// (set) Token: 0x060055DE RID: 21982 RVA: 0x0002E375 File Offset: 0x0002C575
		public unsafe string tutorialEventOrTrackedLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialEventOrTrackedLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_tutorialEventOrTrackedLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x060055DF RID: 21983 RVA: 0x001C0148 File Offset: 0x001BE348
		// (set) Token: 0x060055E0 RID: 21984 RVA: 0x0002E394 File Offset: 0x0002C594
		public unsafe bool eventLabelMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_eventLabelMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_eventLabelMode)) = value;
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x060055E1 RID: 21985 RVA: 0x001C0170 File Offset: 0x001BE370
		// (set) Token: 0x060055E2 RID: 21986 RVA: 0x0002E3AF File Offset: 0x0002C5AF
		public unsafe string beginEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_beginEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_beginEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x060055E3 RID: 21987 RVA: 0x001C0198 File Offset: 0x001BE398
		// (set) Token: 0x060055E4 RID: 21988 RVA: 0x0002E3CE File Offset: 0x0002C5CE
		public unsafe string beginMission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_beginMission);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_beginMission), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x060055E5 RID: 21989 RVA: 0x001C01C0 File Offset: 0x001BE3C0
		// (set) Token: 0x060055E6 RID: 21990 RVA: 0x0002E3ED File Offset: 0x0002C5ED
		public unsafe bool needToConfirm
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_needToConfirm);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr_needToConfirm)) = value;
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x060055E7 RID: 21991 RVA: 0x001C01E8 File Offset: 0x001BE3E8
		// (set) Token: 0x060055E8 RID: 21992 RVA: 0x0002E408 File Offset: 0x0002C608
		public unsafe Action _SelectionCloseCallback_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr__SelectionCloseCallback_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr__SelectionCloseCallback_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x060055E9 RID: 21993 RVA: 0x001C0218 File Offset: 0x001BE418
		// (set) Token: 0x060055EA RID: 21994 RVA: 0x0002E427 File Offset: 0x0002C627
		public unsafe KyoukoTutorialData _ParentSelection_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr__ParentSelection_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.NativeFieldInfoPtr__ParentSelection_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003984 RID: 14724
		private static readonly IntPtr NativeFieldInfoPtr_EVENT_MARK_KEY;

		// Token: 0x04003985 RID: 14725
		private static readonly IntPtr NativeFieldInfoPtr_s_KyoukoExtraDialogDataConfirmCallback;

		// Token: 0x04003986 RID: 14726
		private static readonly IntPtr NativeFieldInfoPtr_tutorialStartDialogForKeyBoard;

		// Token: 0x04003987 RID: 14727
		private static readonly IntPtr NativeFieldInfoPtr_tutorialStartDialogForSwitch;

		// Token: 0x04003988 RID: 14728
		private static readonly IntPtr NativeFieldInfoPtr_tutorialStartDialogNSAlternative;

		// Token: 0x04003989 RID: 14729
		private static readonly IntPtr NativeFieldInfoPtr_notDefaultPrompt;

		// Token: 0x0400398A RID: 14730
		private static readonly IntPtr NativeFieldInfoPtr_tutorialPhraseKey;

		// Token: 0x0400398B RID: 14731
		private static readonly IntPtr NativeFieldInfoPtr_tutorialEventOrTrackedLabel;

		// Token: 0x0400398C RID: 14732
		private static readonly IntPtr NativeFieldInfoPtr_eventLabelMode;

		// Token: 0x0400398D RID: 14733
		private static readonly IntPtr NativeFieldInfoPtr_beginEvent;

		// Token: 0x0400398E RID: 14734
		private static readonly IntPtr NativeFieldInfoPtr_beginMission;

		// Token: 0x0400398F RID: 14735
		private static readonly IntPtr NativeFieldInfoPtr_needToConfirm;

		// Token: 0x04003990 RID: 14736
		private static readonly IntPtr NativeFieldInfoPtr__SelectionCloseCallback_k__BackingField;

		// Token: 0x04003991 RID: 14737
		private static readonly IntPtr NativeFieldInfoPtr__ParentSelection_k__BackingField;

		// Token: 0x04003992 RID: 14738
		private static readonly IntPtr NativeMethodInfoPtr_get_KyoukoExtraDialogDataConfirmCallback_Private_Static_get_Action_1_Action_0;

		// Token: 0x04003993 RID: 14739
		private static readonly IntPtr NativeMethodInfoPtr_set_KyoukoExtraDialogDataConfirmCallback_Public_Static_set_Void_Action_1_Action_0;

		// Token: 0x04003994 RID: 14740
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003995 RID: 14741
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedCheckSwitch_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04003996 RID: 14742
		private static readonly IntPtr NativeMethodInfoPtr_get_HaveFinishedTutorial_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003997 RID: 14743
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectionCloseCallback_Private_get_Action_0;

		// Token: 0x04003998 RID: 14744
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectionCloseCallback_Private_set_Void_Action_0;

		// Token: 0x04003999 RID: 14745
		private static readonly IntPtr NativeMethodInfoPtr_get_ParentSelection_Public_get_KyoukoTutorialData_0;

		// Token: 0x0400399A RID: 14746
		private static readonly IntPtr NativeMethodInfoPtr_set_ParentSelection_Public_set_Void_KyoukoTutorialData_0;

		// Token: 0x0400399B RID: 14747
		private static readonly IntPtr NativeMethodInfoPtr_GetTutorialTitle_Protected_Virtual_New_String_BaseInteractData_0;

		// Token: 0x0400399C RID: 14748
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteract_Protected_Virtual_New_Void_BaseInteractData_0;

		// Token: 0x0400399D RID: 14749
		private static readonly IntPtr NativeMethodInfoPtr_AfterDialog_Protected_Void_BaseInteractData_0;

		// Token: 0x0400399E RID: 14750
		private static readonly IntPtr NativeMethodInfoPtr_Call_Protected_Void_Action_0;

		// Token: 0x0400399F RID: 14751
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_New_Void_BaseInteractData_0;

		// Token: 0x040039A0 RID: 14752
		private static readonly IntPtr NativeMethodInfoPtr_FinishTutorialEvent_Protected_Void_BaseInteractData_0;

		// Token: 0x040039A1 RID: 14753
		private static readonly IntPtr NativeMethodInfoPtr_GetButton_Public_Void_BaseInteractData_Func_2_Boolean_Boolean_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x040039A2 RID: 14754
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractAsync_Protected_Static_UniTask_1_IAssetHandle_1_GameObject_AssetReference_0;

		// Token: 0x040039A3 RID: 14755
		private static readonly IntPtr NativeMethodInfoPtr_CloseAllSelection_Protected_Void_0;

		// Token: 0x040039A4 RID: 14756
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C59 RID: 3161
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E42D RID: 58413 RVA: 0x0036E4E0 File Offset: 0x0036C6E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass30_0>.NativeClassPtr);
				KyoukoTutorialData.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				KyoukoTutorialData.__c__DisplayClass30_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass30_0>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialData.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass30_0>.NativeClassPtr, 100680798);
				KyoukoTutorialData.__c__DisplayClass30_0.NativeMethodInfoPtr__OnButtonInteract_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass30_0>.NativeClassPtr, 100680799);
			}

			// Token: 0x0600E42E RID: 58414 RVA: 0x0036E55C File Offset: 0x0036C75C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E42F RID: 58415 RVA: 0x0036E598 File Offset: 0x0036C798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213735, XrefRangeEnd = 213737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnButtonInteract_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.__c__DisplayClass30_0.NativeMethodInfoPtr__OnButtonInteract_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E430 RID: 58416 RVA: 0x00079B34 File Offset: 0x00077D34
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A09 RID: 18953
			// (get) Token: 0x0600E431 RID: 58417 RVA: 0x0036E5CC File Offset: 0x0036C7CC
			// (set) Token: 0x0600E432 RID: 58418 RVA: 0x00079B3D File Offset: 0x00077D3D
			public unsafe KyoukoTutorialData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A0A RID: 18954
			// (get) Token: 0x0600E433 RID: 58419 RVA: 0x0036E5FC File Offset: 0x0036C7FC
			// (set) Token: 0x0600E434 RID: 58420 RVA: 0x00079B5C File Offset: 0x00077D5C
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass30_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass30_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091D8 RID: 37336
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091D9 RID: 37337
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x040091DA RID: 37338
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091DB RID: 37339
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteract_b__0_Internal_Void_0;
		}

		// Token: 0x02000C5A RID: 3162
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E435 RID: 58421 RVA: 0x0036E62C File Offset: 0x0036C82C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass31_0>.NativeClassPtr);
				KyoukoTutorialData.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				KyoukoTutorialData.__c__DisplayClass31_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass31_0>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialData.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass31_0>.NativeClassPtr, 100680800);
				KyoukoTutorialData.__c__DisplayClass31_0.NativeMethodInfoPtr__AfterDialog_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass31_0>.NativeClassPtr, 100680801);
			}

			// Token: 0x0600E436 RID: 58422 RVA: 0x0036E6A8 File Offset: 0x0036C8A8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E437 RID: 58423 RVA: 0x0036E6E4 File Offset: 0x0036C8E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213737, XrefRangeEnd = 213738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _AfterDialog_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.__c__DisplayClass31_0.NativeMethodInfoPtr__AfterDialog_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E438 RID: 58424 RVA: 0x00079B7B File Offset: 0x00077D7B
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A0B RID: 18955
			// (get) Token: 0x0600E439 RID: 58425 RVA: 0x0036E718 File Offset: 0x0036C918
			// (set) Token: 0x0600E43A RID: 58426 RVA: 0x00079B84 File Offset: 0x00077D84
			public unsafe KyoukoTutorialData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A0C RID: 18956
			// (get) Token: 0x0600E43B RID: 58427 RVA: 0x0036E748 File Offset: 0x0036C948
			// (set) Token: 0x0600E43C RID: 58428 RVA: 0x00079BA3 File Offset: 0x00077DA3
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass31_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass31_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091DC RID: 37340
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091DD RID: 37341
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x040091DE RID: 37342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091DF RID: 37343
			private static readonly IntPtr NativeMethodInfoPtr__AfterDialog_b__0_Internal_Void_0;
		}

		// Token: 0x02000C5B RID: 3163
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E43D RID: 58429 RVA: 0x0036E778 File Offset: 0x0036C978
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass35_0>.NativeClassPtr);
				KyoukoTutorialData.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				KyoukoTutorialData.__c__DisplayClass35_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass35_0>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialData.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass35_0>.NativeClassPtr, 100680802);
				KyoukoTutorialData.__c__DisplayClass35_0.NativeMethodInfoPtr__GetButton_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass35_0>.NativeClassPtr, 100680803);
			}

			// Token: 0x0600E43E RID: 58430 RVA: 0x0036E7F4 File Offset: 0x0036C9F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E43F RID: 58431 RVA: 0x0036E830 File Offset: 0x0036CA30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213738, XrefRangeEnd = 213739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetButton_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData.__c__DisplayClass35_0.NativeMethodInfoPtr__GetButton_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E440 RID: 58432 RVA: 0x00079BC2 File Offset: 0x00077DC2
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A0D RID: 18957
			// (get) Token: 0x0600E441 RID: 58433 RVA: 0x0036E864 File Offset: 0x0036CA64
			// (set) Token: 0x0600E442 RID: 58434 RVA: 0x00079BCB File Offset: 0x00077DCB
			public unsafe KyoukoTutorialData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A0E RID: 18958
			// (get) Token: 0x0600E443 RID: 58435 RVA: 0x0036E894 File Offset: 0x0036CA94
			// (set) Token: 0x0600E444 RID: 58436 RVA: 0x00079BEA File Offset: 0x00077DEA
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass35_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData.__c__DisplayClass35_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091E0 RID: 37344
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091E1 RID: 37345
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x040091E2 RID: 37346
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091E3 RID: 37347
			private static readonly IntPtr NativeMethodInfoPtr__GetButton_b__0_Internal_Void_0;
		}
	}
}
