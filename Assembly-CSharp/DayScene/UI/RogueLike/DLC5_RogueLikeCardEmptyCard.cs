using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using Night.RogueLike;
using NightScene.EventUtility;

namespace DayScene.UI.RogueLike
{
	// Token: 0x020000D8 RID: 216
	public class DLC5_RogueLikeCardEmptyCard : RogueLikeCard
	{
		// Token: 0x06001A54 RID: 6740 RVA: 0x000F5AB4 File Offset: 0x000F3CB4
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeCardEmptyCard()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeCardEmptyCard>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeCardEmptyCard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeCardEmptyCard>.NativeClassPtr);
			DLC5_RogueLikeCardEmptyCard.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEmptyCard>.NativeClassPtr, 100667959);
			DLC5_RogueLikeCardEmptyCard.NativeMethodInfoPtr_ModifyAssociatedRogueLikeCardInstances_Public_Virtual_Final_New_Void_List_1_RogueLikeCardInstance_RogueLikeManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEmptyCard>.NativeClassPtr, 100667960);
			DLC5_RogueLikeCardEmptyCard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeCardEmptyCard>.NativeClassPtr, 100667961);
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x000F5B20 File Offset: 0x000F3D20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70370, XrefRangeEnd = 70371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckExtraConditionToShow(RogueLikeManager rogueLikeManager, EventManager eventManager, RogueLikeCardBase.Rarity rarity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rarity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeCardEmptyCard.NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x000F5B98 File Offset: 0x000F3D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 70371, XrefRangeEnd = 70388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyAssociatedRogueLikeCardInstances(List<RogueLikeCardInstance> associatedRogueLikeCards, RogueLikeManager rogueLikeManager)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(associatedRogueLikeCards);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeManager);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEmptyCard.NativeMethodInfoPtr_ModifyAssociatedRogueLikeCardInstances_Public_Virtual_Final_New_Void_List_1_RogueLikeCardInstance_RogueLikeManager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x000F5BEC File Offset: 0x000F3DEC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeCardEmptyCard() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeCardEmptyCard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeCardEmptyCard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x00010602 File Offset: 0x0000E802
		public DLC5_RogueLikeCardEmptyCard(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001196 RID: 4502
		private static readonly IntPtr NativeMethodInfoPtr_CheckExtraConditionToShow_Public_Virtual_Boolean_RogueLikeManager_EventManager_Rarity_0;

		// Token: 0x04001197 RID: 4503
		private static readonly IntPtr NativeMethodInfoPtr_ModifyAssociatedRogueLikeCardInstances_Public_Virtual_Final_New_Void_List_1_RogueLikeCardInstance_RogueLikeManager_0;

		// Token: 0x04001198 RID: 4504
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
