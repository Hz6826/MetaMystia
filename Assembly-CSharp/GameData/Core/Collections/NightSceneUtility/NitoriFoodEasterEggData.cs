using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.GuestManagementUtility;

namespace GameData.Core.Collections.NightSceneUtility
{
	// Token: 0x02000258 RID: 600
	public class NitoriFoodEasterEggData : GuestFoodEasterEggData
	{
		// Token: 0x06004A42 RID: 19010 RVA: 0x001A1760 File Offset: 0x0019F960
		// Note: this type is marked as 'beforefieldinit'.
		static NitoriFoodEasterEggData()
		{
			Il2CppClassPointerStore<NitoriFoodEasterEggData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility", "NitoriFoodEasterEggData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriFoodEasterEggData>.NativeClassPtr);
			NitoriFoodEasterEggData.NativeFieldInfoPtr_cucumberId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriFoodEasterEggData>.NativeClassPtr, "cucumberId");
			NitoriFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriFoodEasterEggData>.NativeClassPtr, 100678261);
			NitoriFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriFoodEasterEggData>.NativeClassPtr, 100678262);
		}

		// Token: 0x06004A43 RID: 19011 RVA: 0x001A17CC File Offset: 0x0019F9CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 193942, XrefRangeEnd = 193964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NitoriFoodEasterEggData.NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			specialDialog = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004A44 RID: 19012 RVA: 0x001A1870 File Offset: 0x0019FA70
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NitoriFoodEasterEggData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriFoodEasterEggData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriFoodEasterEggData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A45 RID: 19013 RVA: 0x00025E64 File Offset: 0x00024064
		public NitoriFoodEasterEggData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06004A46 RID: 19014 RVA: 0x001A18AC File Offset: 0x0019FAAC
		// (set) Token: 0x06004A47 RID: 19015 RVA: 0x00025E6D File Offset: 0x0002406D
		public unsafe int cucumberId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriFoodEasterEggData.NativeFieldInfoPtr_cucumberId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriFoodEasterEggData.NativeFieldInfoPtr_cucumberId)) = value;
			}
		}

		// Token: 0x0400331D RID: 13085
		private static readonly IntPtr NativeFieldInfoPtr_cucumberId;

		// Token: 0x0400331E RID: 13086
		private static readonly IntPtr NativeMethodInfoPtr_CheckEasterEgg_Public_Virtual_Boolean_OrderBase_GuestGroupController_EvaluationResult_byref_EvaluationResult_byref_String_0;

		// Token: 0x0400331F RID: 13087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
