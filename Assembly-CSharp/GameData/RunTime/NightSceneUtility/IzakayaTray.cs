using System;
using DEYU.Singletons;
using DEYU.Utils;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace GameData.RunTime.NightSceneUtility
{
	// Token: 0x02000220 RID: 544
	public class IzakayaTray : Singleton<IzakayaTray>
	{
		// Token: 0x06004094 RID: 16532 RVA: 0x0017B2B8 File Offset: 0x001794B8
		// Note: this type is marked as 'beforefieldinit'.
		static IzakayaTray()
		{
			Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.NightSceneUtility", "IzakayaTray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr);
			IzakayaTray.NativeFieldInfoPtr__Tray_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, "<Tray>k__BackingField");
			IzakayaTray.NativeFieldInfoPtr_OnTrayUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, "OnTrayUpdate");
			IzakayaTray.NativeFieldInfoPtr_OnTrayUpdateClipPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, "OnTrayUpdateClipPlay");
			IzakayaTray.NativeMethodInfoPtr_get_Tray_Public_get_FixedList_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675463);
			IzakayaTray.NativeMethodInfoPtr_set_Tray_Private_set_Void_FixedList_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675464);
			IzakayaTray.NativeMethodInfoPtr_get_IsTrayEmpty_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675465);
			IzakayaTray.NativeMethodInfoPtr_get_IsTrayFull_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675466);
			IzakayaTray.NativeMethodInfoPtr_add_OnTrayUpdate_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675467);
			IzakayaTray.NativeMethodInfoPtr_remove_OnTrayUpdate_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675468);
			IzakayaTray.NativeMethodInfoPtr_add_OnTrayUpdateClipPlay_Public_add_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675469);
			IzakayaTray.NativeMethodInfoPtr_remove_OnTrayUpdateClipPlay_Public_rem_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675470);
			IzakayaTray.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675471);
			IzakayaTray.NativeMethodInfoPtr_get_TrayMaxNum_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675472);
			IzakayaTray.NativeMethodInfoPtr_Swap_Public_Sellable_Sellable_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675473);
			IzakayaTray.NativeMethodInfoPtr_Deliver_Public_Sellable_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675474);
			IzakayaTray.NativeMethodInfoPtr_DeliverInternal_Private_Sellable_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675475);
			IzakayaTray.NativeMethodInfoPtr_ClearTray_Public_IEnumerable_1_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675476);
			IzakayaTray.NativeMethodInfoPtr_ClearTargetTray_Public_Void_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675477);
			IzakayaTray.NativeMethodInfoPtr_Receive_Public_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675478);
			IzakayaTray.NativeMethodInfoPtr_RecieveInternal_Public_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675479);
			IzakayaTray.NativeMethodInfoPtr_UpdateTray_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675480);
			IzakayaTray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, 100675481);
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06004095 RID: 16533 RVA: 0x0017B4A0 File Offset: 0x001796A0
		// (set) Token: 0x06004096 RID: 16534 RVA: 0x0017B4E0 File Offset: 0x001796E0
		public unsafe FixedList<Sellable> Tray
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_get_Tray_Public_get_FixedList_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FixedList<Sellable>>(intPtr3) : null;
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_set_Tray_Private_set_Void_FixedList_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06004097 RID: 16535 RVA: 0x0017B524 File Offset: 0x00179724
		public unsafe bool IsTrayEmpty
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 158554, RefRangeEnd = 158562, XrefRangeStart = 158547, XrefRangeEnd = 158554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_get_IsTrayEmpty_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06004098 RID: 16536 RVA: 0x0017B560 File Offset: 0x00179760
		public unsafe bool IsTrayFull
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 158575, RefRangeEnd = 158581, XrefRangeStart = 158562, XrefRangeEnd = 158575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_get_IsTrayFull_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x0017B59C File Offset: 0x0017979C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158581, XrefRangeEnd = 158585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnTrayUpdate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_add_OnTrayUpdate_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0017B5E0 File Offset: 0x001797E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158589, RefRangeEnd = 158590, XrefRangeStart = 158585, XrefRangeEnd = 158589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnTrayUpdate(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_remove_OnTrayUpdate_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x0017B624 File Offset: 0x00179824
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158594, RefRangeEnd = 158595, XrefRangeStart = 158590, XrefRangeEnd = 158594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_OnTrayUpdateClipPlay(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_add_OnTrayUpdateClipPlay_Public_add_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x0017B668 File Offset: 0x00179868
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158599, RefRangeEnd = 158600, XrefRangeStart = 158595, XrefRangeEnd = 158599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_OnTrayUpdateClipPlay(Action value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_remove_OnTrayUpdateClipPlay_Public_rem_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0017B6AC File Offset: 0x001798AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 158609, RefRangeEnd = 158610, XrefRangeStart = 158600, XrefRangeEnd = 158609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x0600409E RID: 16542 RVA: 0x0017B6E0 File Offset: 0x001798E0
		public unsafe int TrayMaxNum
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 158615, RefRangeEnd = 158618, XrefRangeStart = 158610, XrefRangeEnd = 158615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_get_TrayMaxNum_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x0017B71C File Offset: 0x0017991C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158622, RefRangeEnd = 158624, XrefRangeStart = 158618, XrefRangeEnd = 158622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sellable Swap(Sellable toDeliver, Sellable toRecieve)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(toDeliver);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toRecieve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_Swap_Public_Sellable_Sellable_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x060040A0 RID: 16544 RVA: 0x0017B780 File Offset: 0x00179980
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 158636, RefRangeEnd = 158641, XrefRangeStart = 158624, XrefRangeEnd = 158636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sellable Deliver(Sellable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_Deliver_Public_Sellable_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x060040A1 RID: 16545 RVA: 0x0017B7D0 File Offset: 0x001799D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158641, XrefRangeEnd = 158644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Sellable DeliverInternal(Sellable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_DeliverInternal_Private_Sellable_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x060040A2 RID: 16546 RVA: 0x0017B820 File Offset: 0x00179A20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158670, RefRangeEnd = 158672, XrefRangeStart = 158644, XrefRangeEnd = 158670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<Sellable> ClearTray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_ClearTray_Public_IEnumerable_1_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Sellable>>(intPtr3) : null;
		}

		// Token: 0x060040A3 RID: 16547 RVA: 0x0017B860 File Offset: 0x00179A60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158684, RefRangeEnd = 158686, XrefRangeStart = 158672, XrefRangeEnd = 158684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTargetTray(IEnumerable<int> targetId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_ClearTargetTray_Public_Void_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040A4 RID: 16548 RVA: 0x0017B8A4 File Offset: 0x00179AA4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 158687, RefRangeEnd = 158693, XrefRangeStart = 158686, XrefRangeEnd = 158687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Receive(Sellable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_Receive_Public_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040A5 RID: 16549 RVA: 0x0017B8F4 File Offset: 0x00179AF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158715, RefRangeEnd = 158717, XrefRangeStart = 158693, XrefRangeEnd = 158715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int RecieveInternal(Sellable value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_RecieveInternal_Public_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060040A6 RID: 16550 RVA: 0x0017B944 File Offset: 0x00179B44
		[CallerCount(0)]
		public unsafe void UpdateTray()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr_UpdateTray_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040A7 RID: 16551 RVA: 0x0017B978 File Offset: 0x00179B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158717, XrefRangeEnd = 158720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IzakayaTray() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040A8 RID: 16552 RVA: 0x00023414 File Offset: 0x00021614
		public IzakayaTray(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x060040A9 RID: 16553 RVA: 0x0017B9B4 File Offset: 0x00179BB4
		// (set) Token: 0x060040AA RID: 16554 RVA: 0x0002341D File Offset: 0x0002161D
		public unsafe FixedList<Sellable> _Tray_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaTray.NativeFieldInfoPtr__Tray_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FixedList<Sellable>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaTray.NativeFieldInfoPtr__Tray_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x060040AB RID: 16555 RVA: 0x0017B9E4 File Offset: 0x00179BE4
		// (set) Token: 0x060040AC RID: 16556 RVA: 0x0002343C File Offset: 0x0002163C
		public unsafe Action OnTrayUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaTray.NativeFieldInfoPtr_OnTrayUpdate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaTray.NativeFieldInfoPtr_OnTrayUpdate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x060040AD RID: 16557 RVA: 0x0017BA14 File Offset: 0x00179C14
		// (set) Token: 0x060040AE RID: 16558 RVA: 0x0002345B File Offset: 0x0002165B
		public unsafe Action OnTrayUpdateClipPlay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaTray.NativeFieldInfoPtr_OnTrayUpdateClipPlay);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IzakayaTray.NativeFieldInfoPtr_OnTrayUpdateClipPlay), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002B6C RID: 11116
		private static readonly IntPtr NativeFieldInfoPtr__Tray_k__BackingField;

		// Token: 0x04002B6D RID: 11117
		private static readonly IntPtr NativeFieldInfoPtr_OnTrayUpdate;

		// Token: 0x04002B6E RID: 11118
		private static readonly IntPtr NativeFieldInfoPtr_OnTrayUpdateClipPlay;

		// Token: 0x04002B6F RID: 11119
		private static readonly IntPtr NativeMethodInfoPtr_get_Tray_Public_get_FixedList_1_Sellable_0;

		// Token: 0x04002B70 RID: 11120
		private static readonly IntPtr NativeMethodInfoPtr_set_Tray_Private_set_Void_FixedList_1_Sellable_0;

		// Token: 0x04002B71 RID: 11121
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTrayEmpty_Public_get_Boolean_0;

		// Token: 0x04002B72 RID: 11122
		private static readonly IntPtr NativeMethodInfoPtr_get_IsTrayFull_Public_get_Boolean_0;

		// Token: 0x04002B73 RID: 11123
		private static readonly IntPtr NativeMethodInfoPtr_add_OnTrayUpdate_Public_add_Void_Action_0;

		// Token: 0x04002B74 RID: 11124
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnTrayUpdate_Public_rem_Void_Action_0;

		// Token: 0x04002B75 RID: 11125
		private static readonly IntPtr NativeMethodInfoPtr_add_OnTrayUpdateClipPlay_Public_add_Void_Action_0;

		// Token: 0x04002B76 RID: 11126
		private static readonly IntPtr NativeMethodInfoPtr_remove_OnTrayUpdateClipPlay_Public_rem_Void_Action_0;

		// Token: 0x04002B77 RID: 11127
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04002B78 RID: 11128
		private static readonly IntPtr NativeMethodInfoPtr_get_TrayMaxNum_Public_get_Int32_0;

		// Token: 0x04002B79 RID: 11129
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Public_Sellable_Sellable_Sellable_0;

		// Token: 0x04002B7A RID: 11130
		private static readonly IntPtr NativeMethodInfoPtr_Deliver_Public_Sellable_Sellable_0;

		// Token: 0x04002B7B RID: 11131
		private static readonly IntPtr NativeMethodInfoPtr_DeliverInternal_Private_Sellable_Sellable_0;

		// Token: 0x04002B7C RID: 11132
		private static readonly IntPtr NativeMethodInfoPtr_ClearTray_Public_IEnumerable_1_Sellable_0;

		// Token: 0x04002B7D RID: 11133
		private static readonly IntPtr NativeMethodInfoPtr_ClearTargetTray_Public_Void_IEnumerable_1_Int32_0;

		// Token: 0x04002B7E RID: 11134
		private static readonly IntPtr NativeMethodInfoPtr_Receive_Public_Int32_Sellable_0;

		// Token: 0x04002B7F RID: 11135
		private static readonly IntPtr NativeMethodInfoPtr_RecieveInternal_Public_Int32_Sellable_0;

		// Token: 0x04002B80 RID: 11136
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTray_Public_Void_0;

		// Token: 0x04002B81 RID: 11137
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009E9 RID: 2537
		[ObfuscatedName("GameData.RunTime.NightSceneUtility.IzakayaTray+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600C26B RID: 49771 RVA: 0x003073F0 File Offset: 0x003055F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<IzakayaTray.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IzakayaTray>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IzakayaTray.__c>.NativeClassPtr);
				IzakayaTray.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaTray.__c>.NativeClassPtr, "<>9");
				IzakayaTray.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaTray.__c>.NativeClassPtr, "<>9__5_0");
				IzakayaTray.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IzakayaTray.__c>.NativeClassPtr, "<>9__20_0");
				IzakayaTray.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray.__c>.NativeClassPtr, 100675483);
				IzakayaTray.__c.NativeMethodInfoPtr__get_IsTrayEmpty_b__5_0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray.__c>.NativeClassPtr, 100675484);
				IzakayaTray.__c.NativeMethodInfoPtr__ClearTray_b__20_0_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IzakayaTray.__c>.NativeClassPtr, 100675485);
			}

			// Token: 0x0600C26C RID: 49772 RVA: 0x00307494 File Offset: 0x00305694
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IzakayaTray.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C26D RID: 49773 RVA: 0x003074D0 File Offset: 0x003056D0
			[CallerCount(0)]
			public unsafe bool _get_IsTrayEmpty_b__5_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.__c.NativeMethodInfoPtr__get_IsTrayEmpty_b__5_0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C26E RID: 49774 RVA: 0x00307520 File Offset: 0x00305720
			[CallerCount(0)]
			public unsafe bool _ClearTray_b__20_0(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IzakayaTray.__c.NativeMethodInfoPtr__ClearTray_b__20_0_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C26F RID: 49775 RVA: 0x00068DD8 File Offset: 0x00066FD8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003F4C RID: 16204
			// (get) Token: 0x0600C270 RID: 49776 RVA: 0x00307570 File Offset: 0x00305770
			// (set) Token: 0x0600C271 RID: 49777 RVA: 0x00068DE1 File Offset: 0x00066FE1
			public unsafe static IzakayaTray.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaTray.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaTray.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaTray.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F4D RID: 16205
			// (get) Token: 0x0600C272 RID: 49778 RVA: 0x00307598 File Offset: 0x00305798
			// (set) Token: 0x0600C273 RID: 49779 RVA: 0x00068DF3 File Offset: 0x00066FF3
			public unsafe static Func<Sellable, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaTray.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaTray.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003F4E RID: 16206
			// (get) Token: 0x0600C274 RID: 49780 RVA: 0x003075C0 File Offset: 0x003057C0
			// (set) Token: 0x0600C275 RID: 49781 RVA: 0x00068E05 File Offset: 0x00067005
			public unsafe static Func<Sellable, bool> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(IzakayaTray.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(IzakayaTray.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007D26 RID: 32038
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04007D27 RID: 32039
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x04007D28 RID: 32040
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04007D29 RID: 32041
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007D2A RID: 32042
			private static readonly IntPtr NativeMethodInfoPtr__get_IsTrayEmpty_b__5_0_Internal_Boolean_Sellable_0;

			// Token: 0x04007D2B RID: 32043
			private static readonly IntPtr NativeMethodInfoPtr__ClearTray_b__20_0_Internal_Boolean_Sellable_0;
		}
	}
}
