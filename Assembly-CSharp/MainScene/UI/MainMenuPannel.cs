using System;
using Common.UI;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.Managers;
using GameData.RunTime.Common;
using GameData.Utils;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace MainScene.UI
{
	// Token: 0x020000B0 RID: 176
	public class MainMenuPannel : BaseSustainedPannel
	{
		// Token: 0x060012E5 RID: 4837 RVA: 0x000DDE48 File Offset: 0x000DC048
		// Note: this type is marked as 'beforefieldinit'.
		static MainMenuPannel()
		{
			Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MainScene.UI", "MainMenuPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr);
			MainMenuPannel.NativeFieldInfoPtr_ContinueBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, "ContinueBtn");
			MainMenuPannel.NativeFieldInfoPtr_NewGameBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, "NewGameBtn");
			MainMenuPannel.NativeFieldInfoPtr_SavesBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, "SavesBtn");
			MainMenuPannel.NativeFieldInfoPtr_ExitBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, "ExitBtn");
			MainMenuPannel.NativeFieldInfoPtr_m_AllBtns = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, "m_AllBtns");
			MainMenuPannel.NativeFieldInfoPtr_m_FrameCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, "m_FrameCode");
			MainMenuPannel.NativeFieldInfoPtr_m_WillLoadSaveFile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, "m_WillLoadSaveFile");
			MainMenuPannel.NativeFieldInfoPtr__SceneManager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, "<SceneManager>k__BackingField");
			MainMenuPannel.NativeMethodInfoPtr_get_SceneManager_Private_get_SceneManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666563);
			MainMenuPannel.NativeMethodInfoPtr_set_SceneManager_Public_set_Void_SceneManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666564);
			MainMenuPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666565);
			MainMenuPannel.NativeMethodInfoPtr_get_PanelOpenMode_Protected_Virtual_get_PanelOpenMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666566);
			MainMenuPannel.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666567);
			MainMenuPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666568);
			MainMenuPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666569);
			MainMenuPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666570);
			MainMenuPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666571);
			MainMenuPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666572);
			MainMenuPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666573);
			MainMenuPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666574);
			MainMenuPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666575);
			MainMenuPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_4_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666576);
			MainMenuPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666577);
			MainMenuPannel.NativeMethodInfoPtr__OnPannelPostOpen_b__19_1_Private_Boolean_UILogicalUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666578);
			MainMenuPannel.NativeMethodInfoPtr__OnPannelPostOpen_b__19_2_Private_Boolean_UILogicalUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, 100666579);
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x000DE06C File Offset: 0x000DC26C
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x000DE0AC File Offset: 0x000DC2AC
		public unsafe SceneManager SceneManager
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr_get_SceneManager_Private_get_SceneManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52391, XrefRangeEnd = 52392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr_set_SceneManager_Public_set_Void_SceneManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x000DE0F0 File Offset: 0x000DC2F0
		public unsafe override AdpUIPanelManager.RequestedInputMode RequestedInputMode
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuPannel.NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060012E9 RID: 4841 RVA: 0x000DE138 File Offset: 0x000DC338
		public unsafe override AdpUIPanelManager.PanelOpenMode PanelOpenMode
		{
			[CallerCount(84)]
			[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuPannel.NativeMethodInfoPtr_get_PanelOpenMode_Protected_Virtual_get_PanelOpenMode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x000DE180 File Offset: 0x000DC380
		[CallerCount(0)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EB RID: 4843 RVA: 0x000DE1B4 File Offset: 0x000DC3B4
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitExtern()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuPannel.NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EC RID: 4844 RVA: 0x000DE1F0 File Offset: 0x000DC3F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52392, XrefRangeEnd = 52428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPannelPostInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuPannel.NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x000DE22C File Offset: 0x000DC42C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52428, XrefRangeEnd = 52433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x000DE268 File Offset: 0x000DC468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52433, XrefRangeEnd = 52509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPannelPostOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuPannel.NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012EF RID: 4847 RVA: 0x000DE2A4 File Offset: 0x000DC4A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52509, XrefRangeEnd = 52515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MainMenuPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x000DE2E0 File Offset: 0x000DC4E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52515, XrefRangeEnd = 52522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MainMenuPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x000DE31C File Offset: 0x000DC51C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52522, XrefRangeEnd = 52530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPannelPostInitialize_b__17_1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F2 RID: 4850 RVA: 0x000DE350 File Offset: 0x000DC550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52530, XrefRangeEnd = 52538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPannelPostInitialize_b__17_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F3 RID: 4851 RVA: 0x000DE384 File Offset: 0x000DC584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52538, XrefRangeEnd = 52542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPannelPostInitialize_b__17_4()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_4_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F4 RID: 4852 RVA: 0x000DE3B8 File Offset: 0x000DC5B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52542, XrefRangeEnd = 52546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPannelPostInitialize_b__17_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012F5 RID: 4853 RVA: 0x000DE3EC File Offset: 0x000DC5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52546, XrefRangeEnd = 52550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPannelPostOpen_b__19_1(UILogicalUnit x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr__OnPannelPostOpen_b__19_1_Private_Boolean_UILogicalUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000DE43C File Offset: 0x000DC63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52550, XrefRangeEnd = 52554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnPannelPostOpen_b__19_2(UILogicalUnit x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.NativeMethodInfoPtr__OnPannelPostOpen_b__19_2_Private_Boolean_UILogicalUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x0000C023 File Offset: 0x0000A223
		public MainMenuPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x060012F8 RID: 4856 RVA: 0x000DE48C File Offset: 0x000DC68C
		// (set) Token: 0x060012F9 RID: 4857 RVA: 0x0000C02C File Offset: 0x0000A22C
		public unsafe UIButtonSimple ContinueBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_ContinueBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_ContinueBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x000DE4BC File Offset: 0x000DC6BC
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x0000C04B File Offset: 0x0000A24B
		public unsafe UIButtonSimple NewGameBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_NewGameBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_NewGameBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x000DE4EC File Offset: 0x000DC6EC
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x0000C06A File Offset: 0x0000A26A
		public unsafe UIButtonSimple SavesBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_SavesBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_SavesBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x000DE51C File Offset: 0x000DC71C
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x0000C089 File Offset: 0x0000A289
		public unsafe UIButtonSimple ExitBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_ExitBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_ExitBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F9 RID: 1529
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x000DE54C File Offset: 0x000DC74C
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		public unsafe UILogicalGroup m_AllBtns
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_m_AllBtns);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_m_AllBtns), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005FA RID: 1530
		// (get) Token: 0x06001302 RID: 4866 RVA: 0x000DE57C File Offset: 0x000DC77C
		// (set) Token: 0x06001303 RID: 4867 RVA: 0x0000C0C7 File Offset: 0x0000A2C7
		public unsafe int m_FrameCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_m_FrameCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_m_FrameCode)) = value;
			}
		}

		// Token: 0x170005FB RID: 1531
		// (get) Token: 0x06001304 RID: 4868 RVA: 0x000DE5A4 File Offset: 0x000DC7A4
		// (set) Token: 0x06001305 RID: 4869 RVA: 0x0000C0E2 File Offset: 0x0000A2E2
		public KeyValuePair<PlayerSaveFile, int> m_WillLoadSaveFile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_m_WillLoadSaveFile);
				return new KeyValuePair<PlayerSaveFile, int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<PlayerSaveFile, int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr_m_WillLoadSaveFile), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<PlayerSaveFile, int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170005FC RID: 1532
		// (get) Token: 0x06001306 RID: 4870 RVA: 0x000DE5D4 File Offset: 0x000DC7D4
		// (set) Token: 0x06001307 RID: 4871 RVA: 0x0000C110 File Offset: 0x0000A310
		public unsafe SceneManager _SceneManager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr__SceneManager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SceneManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MainMenuPannel.NativeFieldInfoPtr__SceneManager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CC6 RID: 3270
		private static readonly IntPtr NativeFieldInfoPtr_ContinueBtn;

		// Token: 0x04000CC7 RID: 3271
		private static readonly IntPtr NativeFieldInfoPtr_NewGameBtn;

		// Token: 0x04000CC8 RID: 3272
		private static readonly IntPtr NativeFieldInfoPtr_SavesBtn;

		// Token: 0x04000CC9 RID: 3273
		private static readonly IntPtr NativeFieldInfoPtr_ExitBtn;

		// Token: 0x04000CCA RID: 3274
		private static readonly IntPtr NativeFieldInfoPtr_m_AllBtns;

		// Token: 0x04000CCB RID: 3275
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameCode;

		// Token: 0x04000CCC RID: 3276
		private static readonly IntPtr NativeFieldInfoPtr_m_WillLoadSaveFile;

		// Token: 0x04000CCD RID: 3277
		private static readonly IntPtr NativeFieldInfoPtr__SceneManager_k__BackingField;

		// Token: 0x04000CCE RID: 3278
		private static readonly IntPtr NativeMethodInfoPtr_get_SceneManager_Private_get_SceneManager_0;

		// Token: 0x04000CCF RID: 3279
		private static readonly IntPtr NativeMethodInfoPtr_set_SceneManager_Public_set_Void_SceneManager_0;

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_get_RequestedInputMode_Public_Virtual_get_RequestedInputMode_0;

		// Token: 0x04000CD1 RID: 3281
		private static readonly IntPtr NativeMethodInfoPtr_get_PanelOpenMode_Protected_Virtual_get_PanelOpenMode_0;

		// Token: 0x04000CD2 RID: 3282
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeMethodInfoPtr_OnExitExtern_Protected_Virtual_Void_0;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeMethodInfoPtr_OnPannelPostOpen_Protected_Virtual_Void_0;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000CD9 RID: 3289
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__17_1_Private_Void_0;

		// Token: 0x04000CDA RID: 3290
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__17_2_Private_Void_0;

		// Token: 0x04000CDB RID: 3291
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__17_4_Private_Void_0;

		// Token: 0x04000CDC RID: 3292
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__17_3_Private_Void_0;

		// Token: 0x04000CDD RID: 3293
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostOpen_b__19_1_Private_Boolean_UILogicalUnit_0;

		// Token: 0x04000CDE RID: 3294
		private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostOpen_b__19_2_Private_Boolean_UILogicalUnit_0;

		// Token: 0x020005C3 RID: 1475
		[ObfuscatedName("MainScene.UI.MainMenuPannel+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06008CCF RID: 36047 RVA: 0x0026A860 File Offset: 0x00268A60
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MainMenuPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr);
				MainMenuPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr, "<>9");
				MainMenuPannel.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr, "<>9__17_0");
				MainMenuPannel.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr, "<>9__19_0");
				MainMenuPannel.__c.NativeFieldInfoPtr___9__19_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr, "<>9__19_3");
				MainMenuPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr, 100666581);
				MainMenuPannel.__c.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr, 100666582);
				MainMenuPannel.__c.NativeMethodInfoPtr__OnPannelPostOpen_b__19_0_Internal_Boolean_KeyValuePair_2_LoadedSaveDataInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr, 100666583);
				MainMenuPannel.__c.NativeMethodInfoPtr__OnPannelPostOpen_b__19_3_Internal_Boolean_KeyValuePair_2_LoadedSaveDataInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr, 100666584);
			}

			// Token: 0x06008CD0 RID: 36048 RVA: 0x0026A92C File Offset: 0x00268B2C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MainMenuPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CD1 RID: 36049 RVA: 0x0026A968 File Offset: 0x00268B68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52381, XrefRangeEnd = 52389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPannelPostInitialize_b__17_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.__c.NativeMethodInfoPtr__OnPannelPostInitialize_b__17_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008CD2 RID: 36050 RVA: 0x0026A99C File Offset: 0x00268B9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52389, XrefRangeEnd = 52390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPannelPostOpen_b__19_0(KeyValuePair<LoadedSaveDataInfo, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.__c.NativeMethodInfoPtr__OnPannelPostOpen_b__19_0_Internal_Boolean_KeyValuePair_2_LoadedSaveDataInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008CD3 RID: 36051 RVA: 0x0026A9F0 File Offset: 0x00268BF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 52390, XrefRangeEnd = 52391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPannelPostOpen_b__19_3(KeyValuePair<LoadedSaveDataInfo, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MainMenuPannel.__c.NativeMethodInfoPtr__OnPannelPostOpen_b__19_3_Internal_Boolean_KeyValuePair_2_LoadedSaveDataInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008CD4 RID: 36052 RVA: 0x0004BB57 File Offset: 0x00049D57
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F1A RID: 12058
			// (get) Token: 0x06008CD5 RID: 36053 RVA: 0x0026AA44 File Offset: 0x00268C44
			// (set) Token: 0x06008CD6 RID: 36054 RVA: 0x0004BB60 File Offset: 0x00049D60
			public unsafe static MainMenuPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainMenuPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MainMenuPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainMenuPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F1B RID: 12059
			// (get) Token: 0x06008CD7 RID: 36055 RVA: 0x0026AA6C File Offset: 0x00268C6C
			// (set) Token: 0x06008CD8 RID: 36056 RVA: 0x0004BB72 File Offset: 0x00049D72
			public unsafe static Action __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainMenuPannel.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainMenuPannel.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F1C RID: 12060
			// (get) Token: 0x06008CD9 RID: 36057 RVA: 0x0026AA94 File Offset: 0x00268C94
			// (set) Token: 0x06008CDA RID: 36058 RVA: 0x0004BB84 File Offset: 0x00049D84
			public unsafe static Func<KeyValuePair<LoadedSaveDataInfo, int>, bool> __9__19_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainMenuPannel.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<LoadedSaveDataInfo, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainMenuPannel.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F1D RID: 12061
			// (get) Token: 0x06008CDB RID: 36059 RVA: 0x0026AABC File Offset: 0x00268CBC
			// (set) Token: 0x06008CDC RID: 36060 RVA: 0x0004BB96 File Offset: 0x00049D96
			public unsafe static Func<KeyValuePair<LoadedSaveDataInfo, int>, bool> __9__19_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MainMenuPannel.__c.NativeFieldInfoPtr___9__19_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<LoadedSaveDataInfo, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MainMenuPannel.__c.NativeFieldInfoPtr___9__19_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C14 RID: 23572
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005C15 RID: 23573
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04005C16 RID: 23574
			private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

			// Token: 0x04005C17 RID: 23575
			private static readonly IntPtr NativeFieldInfoPtr___9__19_3;

			// Token: 0x04005C18 RID: 23576
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C19 RID: 23577
			private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostInitialize_b__17_0_Internal_Void_0;

			// Token: 0x04005C1A RID: 23578
			private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostOpen_b__19_0_Internal_Boolean_KeyValuePair_2_LoadedSaveDataInfo_Int32_0;

			// Token: 0x04005C1B RID: 23579
			private static readonly IntPtr NativeMethodInfoPtr__OnPannelPostOpen_b__19_3_Internal_Boolean_KeyValuePair_2_LoadedSaveDataInfo_Int32_0;
		}
	}
}
