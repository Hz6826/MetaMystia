using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000256 RID: 598
	public class MedicineFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06004A38 RID: 19000 RVA: 0x001A14B4 File Offset: 0x0019F6B4
		// Note: this type is marked as 'beforefieldinit'.
		static MedicineFoodEasterEggData()
		{
			Il2CppClassPointerStore<MedicineFoodEasterEggData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "MedicineFoodEasterEggData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MedicineFoodEasterEggData>.NativeClassPtr);
			MedicineFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MedicineFoodEasterEggData>.NativeClassPtr, 100678257);
			MedicineFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MedicineFoodEasterEggData>.NativeClassPtr, 100678258);
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x001A150C File Offset: 0x0019F70C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193909, XrefRangeEnd = 193914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MedicineFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			specialDialog = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x001A15B0 File Offset: 0x0019F7B0
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MedicineFoodEasterEggData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MedicineFoodEasterEggData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MedicineFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A3B RID: 19003 RVA: 0x00025E37 File Offset: 0x00024037
		public MedicineFoodEasterEggData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003318 RID: 13080
		private static readonly IntPtr NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0;

		// Token: 0x04003319 RID: 13081
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
