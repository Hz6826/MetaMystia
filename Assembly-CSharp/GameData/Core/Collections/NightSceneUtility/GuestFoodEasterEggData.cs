using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000251 RID: 593
	public class GuestFoodEasterEggData : ScriptableObject
	{
		// Token: 0x06004A1C RID: 18972 RVA: 0x001A0D2C File Offset: 0x0019EF2C
		// Note: this type is marked as 'beforefieldinit'.
		static GuestFoodEasterEggData()
		{
			Il2CppClassPointerStore<GuestFoodEasterEggData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "GuestFoodEasterEggData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GuestFoodEasterEggData>.NativeClassPtr);
			GuestFoodEasterEggData.NativeFieldInfoPtr_foodId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GuestFoodEasterEggData>.NativeClassPtr, "foodId");
			GuestFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_New_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestFoodEasterEggData>.NativeClassPtr, 100678239);
			GuestFoodEasterEggData.NativeMethodInfoPtr_TryGetEasterEggIdleDialog_Public_Virtual_New_Boolean_IEnumerable_1_PartnerBase_byref_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestFoodEasterEggData>.NativeClassPtr, 100678240);
			GuestFoodEasterEggData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GuestFoodEasterEggData>.NativeClassPtr, 100678241);
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x001A0DAC File Offset: 0x0019EFAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193829, XrefRangeEnd = 193833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(lastOrder);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(toEval);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldResult;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalResult;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_New_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			specialDialog = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x001A0E50 File Offset: 0x0019F050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193833, XrefRangeEnd = 193837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetEasterEggIdleDialog(IEnumerable<PartnerBase> partners, out IEnumerable<string> idleDialog)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partners);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GuestFoodEasterEggData.NativeMethodInfoPtr_TryGetEasterEggIdleDialog_Public_Virtual_New_Boolean_IEnumerable_1_PartnerBase_byref_IEnumerable_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			idleDialog = ((intPtr4 == 0) ? null : new IEnumerable<string>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x001A0ECC File Offset: 0x0019F0CC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GuestFoodEasterEggData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GuestFoodEasterEggData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GuestFoodEasterEggData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x00025DB5 File Offset: 0x00023FB5
		public GuestFoodEasterEggData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018DE RID: 6366
		// (get) Token: 0x06004A21 RID: 18977 RVA: 0x001A0F08 File Offset: 0x0019F108
		// (set) Token: 0x06004A22 RID: 18978 RVA: 0x00025DBE File Offset: 0x00023FBE
		public unsafe int foodId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestFoodEasterEggData.NativeFieldInfoPtr_foodId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GuestFoodEasterEggData.NativeFieldInfoPtr_foodId)) = value;
			}
		}

		// Token: 0x04003309 RID: 13065
		private static readonly IntPtr NativeFieldInfoPtr_foodId;

		// Token: 0x0400330A RID: 13066
		private static readonly IntPtr NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_New_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0;

		// Token: 0x0400330B RID: 13067
		private static readonly IntPtr NativeMethodInfoPtr_TryGetEasterEggIdleDialog_Public_Virtual_New_Boolean_IEnumerable_1_PartnerBase_byref_IEnumerable_1_String_0;

		// Token: 0x0400330C RID: 13068
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
