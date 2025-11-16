using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x0200025A RID: 602
	public class RemiliaFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06004A50 RID: 19024 RVA: 0x001A1A64 File Offset: 0x0019FC64
		// Note: this type is marked as 'beforefieldinit'.
		static RemiliaFoodEasterEggData()
		{
			Il2CppClassPointerStore<RemiliaFoodEasterEggData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "RemiliaFoodEasterEggData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemiliaFoodEasterEggData>.NativeClassPtr);
			RemiliaFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemiliaFoodEasterEggData>.NativeClassPtr, 100678268);
			RemiliaFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemiliaFoodEasterEggData>.NativeClassPtr, 100678269);
		}

		// Token: 0x06004A51 RID: 19025 RVA: 0x001A1ABC File Offset: 0x0019FCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193999, XrefRangeEnd = 194004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RemiliaFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			specialDialog = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A52 RID: 19026 RVA: 0x001A1B60 File Offset: 0x0019FD60
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemiliaFoodEasterEggData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemiliaFoodEasterEggData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemiliaFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A53 RID: 19027 RVA: 0x00025ECB File Offset: 0x000240CB
		public RemiliaFoodEasterEggData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003324 RID: 13092
		private static readonly IntPtr NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0;

		// Token: 0x04003325 RID: 13093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
