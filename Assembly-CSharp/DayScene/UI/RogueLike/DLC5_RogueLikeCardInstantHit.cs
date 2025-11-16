using System;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Night.RogueLike;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000DF RID: 223
	public class DLC5_RogueLikeCardInstantHit : RogueLikeCard
	{
		// Token: 0x06001A88 RID: 6792 RVA: 0x000F6A00 File Offset: 0x000F4C00
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardInstantHit()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardInstantHit");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr);
			DLC5_RogueLikeCardInstantHit.NativeFieldInfoPtr_datas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr, "datas");
			DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr, 100668030);
			DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr, 100668031);
			DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr, 100668032);
			DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr, 100668033);
			DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr, 100668034);
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x000F6AA8 File Offset: 0x000F4CA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70835, XrefRangeEnd = 70842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator UseCard(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x000F6B28 File Offset: 0x000F4D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70842, XrefRangeEnd = 70843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x000F6BA0 File Offset: 0x000F4DA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70843, XrefRangeEnd = 70857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OverrideDescription(string oldDescription, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(oldDescription);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000F6C04 File Offset: 0x000F4E04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardInstantHit() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000F6C40 File Offset: 0x000F4E40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0(BossData.BossDataContext dataContext, RogueLikeCardBase.Rarity rarity, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dataContext));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit.NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000106D8 File Offset: 0x0000E8D8
		public DLC5_RogueLikeCardInstantHit(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001A8F RID: 6799 RVA: 0x000F6CB8 File Offset: 0x000F4EB8
		// (set) Token: 0x06001A90 RID: 6800 RVA: 0x000106E1 File Offset: 0x0000E8E1
		public unsafe Il2CppReferenceArray<RarityDataMappingForInstantHit> datas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.NativeFieldInfoPtr_datas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RarityDataMappingForInstantHit>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.NativeFieldInfoPtr_datas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011B7 RID: 4535
		private static readonly IntPtr NativeFieldInfoPtr_datas;

		// Token: 0x040011B8 RID: 4536
		private static readonly IntPtr NativeMethodInfoPtr_UseCard_Public_Virtual_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x040011B9 RID: 4537
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0;

		// Token: 0x040011BA RID: 4538
		private static readonly IntPtr NativeMethodInfoPtr_OverrideDescription_Public_Virtual_String_String_Rarity_0;

		// Token: 0x040011BB RID: 4539
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040011BC RID: 4540
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_BossDataContext_Rarity_RogueLikeManager_0;

		// Token: 0x0200069F RID: 1695
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardInstantHit+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x06009781 RID: 38785 RVA: 0x00289204 File Offset: 0x00287404
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr);
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_newFoods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, "newFoods");
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, 100668035);
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, 100668036);
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_Sellable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, 100668037);
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, 100668038);
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr__UseCard_b__5_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, 100668039);
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, 100668040);
				DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr, 100668041);
			}

			// Token: 0x06009782 RID: 38786 RVA: 0x00289320 File Offset: 0x00287520
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009783 RID: 38787 RVA: 0x0028935C File Offset: 0x0028755C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70667, XrefRangeEnd = 70679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__0(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr__UseCard_b__0_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009784 RID: 38788 RVA: 0x002893A0 File Offset: 0x002875A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70679, XrefRangeEnd = 70686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Sellable_PDM_0(Sellable sellable)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sellable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_Sellable_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009785 RID: 38789 RVA: 0x002893E4 File Offset: 0x002875E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70686, XrefRangeEnd = 70710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009786 RID: 38790 RVA: 0x00289418 File Offset: 0x00287618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70710, XrefRangeEnd = 70722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UseCard_b__5(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr__UseCard_b__5_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009787 RID: 38791 RVA: 0x0028945C File Offset: 0x0028765C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70722, XrefRangeEnd = 70769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0(GuestGroupController.EvaluationResult evaluationResult, GuestGroupController guestGroupController, bool finishedByPartner)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref evaluationResult;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref finishedByPartner;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009788 RID: 38792 RVA: 0x002894BC File Offset: 0x002876BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70769, XrefRangeEnd = 70781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guestGroupController)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009789 RID: 38793 RVA: 0x00051F06 File Offset: 0x00050106
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003252 RID: 12882
			// (get) Token: 0x0600978A RID: 38794 RVA: 0x00289500 File Offset: 0x00287700
			// (set) Token: 0x0600978B RID: 38795 RVA: 0x00051F0F File Offset: 0x0005010F
			public unsafe HashSet<Guid> newFoods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_newFoods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Guid>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_newFoods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003253 RID: 12883
			// (get) Token: 0x0600978C RID: 38796 RVA: 0x00289530 File Offset: 0x00287730
			// (set) Token: 0x0600978D RID: 38797 RVA: 0x00051F2E File Offset: 0x0005012E
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003254 RID: 12884
			// (get) Token: 0x0600978E RID: 38798 RVA: 0x00289560 File Offset: 0x00287760
			// (set) Token: 0x0600978F RID: 38799 RVA: 0x00051F5C File Offset: 0x0005015C
			public unsafe DLC5_RogueLikeCardInstantHit __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardInstantHit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003255 RID: 12885
			// (get) Token: 0x06009790 RID: 38800 RVA: 0x00289590 File Offset: 0x00287790
			// (set) Token: 0x06009791 RID: 38801 RVA: 0x00051F7B File Offset: 0x0005017B
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x17003256 RID: 12886
			// (get) Token: 0x06009792 RID: 38802 RVA: 0x002895B8 File Offset: 0x002877B8
			// (set) Token: 0x06009793 RID: 38803 RVA: 0x00051F96 File Offset: 0x00050196
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006236 RID: 25142
			private static readonly IntPtr NativeFieldInfoPtr_newFoods;

			// Token: 0x04006237 RID: 25143
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x04006238 RID: 25144
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006239 RID: 25145
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x0400623A RID: 25146
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x0400623B RID: 25147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400623C RID: 25148
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__0_Internal_Void_GuestGroupController_0;

			// Token: 0x0400623D RID: 25149
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Sellable_PDM_0;

			// Token: 0x0400623E RID: 25150
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400623F RID: 25151
			private static readonly IntPtr NativeMethodInfoPtr__UseCard_b__5_Internal_Void_GuestGroupController_0;

			// Token: 0x04006240 RID: 25152
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_EvaluationResult_GuestGroupController_Boolean_PDM_0;

			// Token: 0x04006241 RID: 25153
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;
		}

		// Token: 0x020006A0 RID: 1696
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeCardInstantHit+<UseCard>d__1")]
		public sealed class _UseCard_d__1 : Object
		{
			// Token: 0x06009794 RID: 38804 RVA: 0x002895E8 File Offset: 0x002877E8
			// Note: this type is marked as 'beforefieldinit'.
			static _UseCard_d__1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit>.NativeClassPtr, "<UseCard>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr);
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, "<>2__current");
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr_dataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, "dataContext");
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr_rarity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, "rarity");
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, "rogueLikeManager");
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, "<>8__1");
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, 100668042);
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, 100668043);
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, 100668044);
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, 100668045);
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, 100668046);
				DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr, 100668047);
			}

			// Token: 0x06009795 RID: 38805 RVA: 0x00289718 File Offset: 0x00287918
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _UseCard_d__1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardInstantHit._UseCard_d__1>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009796 RID: 38806 RVA: 0x00289760 File Offset: 0x00287960
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009797 RID: 38807 RVA: 0x00289794 File Offset: 0x00287994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70781, XrefRangeEnd = 70829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700325E RID: 12894
			// (get) Token: 0x06009798 RID: 38808 RVA: 0x002897D0 File Offset: 0x002879D0
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06009799 RID: 38809 RVA: 0x00289810 File Offset: 0x00287A10
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70829, XrefRangeEnd = 70835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700325F RID: 12895
			// (get) Token: 0x0600979A RID: 38810 RVA: 0x00289844 File Offset: 0x00287A44
			public unsafe Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600979B RID: 38811 RVA: 0x00051FB5 File Offset: 0x000501B5
			public _UseCard_d__1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003257 RID: 12887
			// (get) Token: 0x0600979C RID: 38812 RVA: 0x00289884 File Offset: 0x00287A84
			// (set) Token: 0x0600979D RID: 38813 RVA: 0x00051FBE File Offset: 0x000501BE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003258 RID: 12888
			// (get) Token: 0x0600979E RID: 38814 RVA: 0x002898AC File Offset: 0x00287AAC
			// (set) Token: 0x0600979F RID: 38815 RVA: 0x00051FD9 File Offset: 0x000501D9
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003259 RID: 12889
			// (get) Token: 0x060097A0 RID: 38816 RVA: 0x002898DC File Offset: 0x00287ADC
			// (set) Token: 0x060097A1 RID: 38817 RVA: 0x00051FF8 File Offset: 0x000501F8
			public BossData.BossDataContext dataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr_dataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr_dataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700325A RID: 12890
			// (get) Token: 0x060097A2 RID: 38818 RVA: 0x0028990C File Offset: 0x00287B0C
			// (set) Token: 0x060097A3 RID: 38819 RVA: 0x00052026 File Offset: 0x00050226
			public unsafe DLC5_RogueLikeCardInstantHit __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardInstantHit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700325B RID: 12891
			// (get) Token: 0x060097A4 RID: 38820 RVA: 0x0028993C File Offset: 0x00287B3C
			// (set) Token: 0x060097A5 RID: 38821 RVA: 0x00052045 File Offset: 0x00050245
			public unsafe RogueLikeCardBase.Rarity rarity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr_rarity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr_rarity)) = value;
				}
			}

			// Token: 0x1700325C RID: 12892
			// (get) Token: 0x060097A6 RID: 38822 RVA: 0x00289964 File Offset: 0x00287B64
			// (set) Token: 0x060097A7 RID: 38823 RVA: 0x00052060 File Offset: 0x00050260
			public unsafe RogueLikeManager rogueLikeManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr_rogueLikeManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700325D RID: 12893
			// (get) Token: 0x060097A8 RID: 38824 RVA: 0x00289994 File Offset: 0x00287B94
			// (set) Token: 0x060097A9 RID: 38825 RVA: 0x0005207F File Offset: 0x0005027F
			public unsafe DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeCardInstantHit.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeCardInstantHit._UseCard_d__1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006242 RID: 25154
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006243 RID: 25155
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006244 RID: 25156
			private static readonly IntPtr NativeFieldInfoPtr_dataContext;

			// Token: 0x04006245 RID: 25157
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006246 RID: 25158
			private static readonly IntPtr NativeFieldInfoPtr_rarity;

			// Token: 0x04006247 RID: 25159
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeManager;

			// Token: 0x04006248 RID: 25160
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04006249 RID: 25161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400624A RID: 25162
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400624B RID: 25163
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400624C RID: 25164
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400624D RID: 25165
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400624E RID: 25166
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
