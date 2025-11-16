using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000257 RID: 599
	public class MomiziFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06004A3C RID: 19004 RVA: 0x001A15EC File Offset: 0x0019F7EC
		// Note: this type is marked as 'beforefieldinit'.
		static MomiziFoodEasterEggData()
		{
			Il2CppClassPointerStore<MomiziFoodEasterEggData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "MomiziFoodEasterEggData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MomiziFoodEasterEggData>.NativeClassPtr);
			MomiziFoodEasterEggData.NativeFieldInfoPtr_chocolateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MomiziFoodEasterEggData>.NativeClassPtr, "chocolateId");
			MomiziFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MomiziFoodEasterEggData>.NativeClassPtr, 100678259);
			MomiziFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MomiziFoodEasterEggData>.NativeClassPtr, 100678260);
		}

		// Token: 0x06004A3D RID: 19005 RVA: 0x001A1658 File Offset: 0x0019F858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193914, XrefRangeEnd = 193941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MomiziFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			specialDialog = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A3E RID: 19006 RVA: 0x001A16FC File Offset: 0x0019F8FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193941, XrefRangeEnd = 193942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MomiziFoodEasterEggData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MomiziFoodEasterEggData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MomiziFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A3F RID: 19007 RVA: 0x00025E40 File Offset: 0x00024040
		public MomiziFoodEasterEggData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06004A40 RID: 19008 RVA: 0x001A1738 File Offset: 0x0019F938
		// (set) Token: 0x06004A41 RID: 19009 RVA: 0x00025E49 File Offset: 0x00024049
		public unsafe int chocolateId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MomiziFoodEasterEggData.NativeFieldInfoPtr_chocolateId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MomiziFoodEasterEggData.NativeFieldInfoPtr_chocolateId)) = value;
			}
		}

		// Token: 0x0400331A RID: 13082
		private static readonly IntPtr NativeFieldInfoPtr_chocolateId;

		// Token: 0x0400331B RID: 13083
		private static readonly IntPtr NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0;

		// Token: 0x0400331C RID: 13084
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
