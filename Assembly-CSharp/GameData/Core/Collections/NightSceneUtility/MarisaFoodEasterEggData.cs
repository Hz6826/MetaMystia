using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000255 RID: 597
	public class MarisaFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06004A33 RID: 18995 RVA: 0x001A1330 File Offset: 0x0019F530
		// Note: this type is marked as 'beforefieldinit'.
		static MarisaFoodEasterEggData()
		{
			Il2CppClassPointerStore<MarisaFoodEasterEggData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "MarisaFoodEasterEggData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MarisaFoodEasterEggData>.NativeClassPtr);
			MarisaFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarisaFoodEasterEggData>.NativeClassPtr, 100678254);
			MarisaFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarisaFoodEasterEggData>.NativeClassPtr, 100678255);
			MarisaFoodEasterEggData.NativeMethodInfoPtr_Method_Internal_Static_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MarisaFoodEasterEggData>.NativeClassPtr, 100678256);
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x001A139C File Offset: 0x0019F59C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193888, XrefRangeEnd = 193895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckEasterEgg(GuestsManager.OrderBase lastOrder, GuestGroupController toEval, GuestGroupController.EvaluationResult oldResult, out GuestGroupController.EvaluationResult finalResult, out string specialDialog)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MarisaFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			specialDialog = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x001A1440 File Offset: 0x0019F640
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MarisaFoodEasterEggData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MarisaFoodEasterEggData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarisaFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x001A147C File Offset: 0x0019F67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193895, XrefRangeEnd = 193909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Method_Internal_Static_Void_GuestGroupController_PDM_0(GuestGroupController guest)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MarisaFoodEasterEggData.NativeMethodInfoPtr_Method_Internal_Static_Void_GuestGroupController_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00025E2E File Offset: 0x0002402E
		public MarisaFoodEasterEggData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003315 RID: 13077
		private static readonly IntPtr NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0;

		// Token: 0x04003316 RID: 13078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003317 RID: 13079
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Void_GuestGroupController_PDM_0;
	}
}
