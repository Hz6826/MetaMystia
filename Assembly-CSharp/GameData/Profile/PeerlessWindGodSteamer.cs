using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using NightScene.CookingUtility;

namespace GameData.Profile
{
	// Token: 0x02000305 RID: 773
	public class PeerlessWindGodSteamer : CookerAssetBase
	{
		// Token: 0x06005CE2 RID: 23778 RVA: 0x001D3728 File Offset: 0x001D1928
		// Note: this type is marked as 'beforefieldinit'.
		static PeerlessWindGodSteamer()
		{
			Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PeerlessWindGodSteamer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr);
			PeerlessWindGodSteamer.NativeFieldInfoPtr_POPULAR_LIKE_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr, "POPULAR_LIKE_ID");
			PeerlessWindGodSteamer.NativeFieldInfoPtr_extraCookSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr, "extraCookSpeed");
			PeerlessWindGodSteamer.NativeFieldInfoPtr_extraOrderRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr, "extraOrderRate");
			PeerlessWindGodSteamer.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr, 100682465);
			PeerlessWindGodSteamer.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr, 100682466);
			PeerlessWindGodSteamer.NativeMethodInfoPtr_ExtraAdditiveNextOrderProb_Public_Virtual_Single_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr, 100682467);
			PeerlessWindGodSteamer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr, 100682468);
		}

		// Token: 0x06005CE3 RID: 23779 RVA: 0x001D37E4 File Offset: 0x001D19E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232725, XrefRangeEnd = 232741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PeerlessWindGodSteamer.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005CE4 RID: 23780 RVA: 0x001D3838 File Offset: 0x001D1A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232741, XrefRangeEnd = 232745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ExtraCookTimeMultiplier(CookController thisCookController, Sellable food)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisCookController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PeerlessWindGodSteamer.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005CE5 RID: 23781 RVA: 0x001D38A4 File Offset: 0x001D1AA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232745, XrefRangeEnd = 232749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ExtraAdditiveNextOrderProb(Sellable food)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PeerlessWindGodSteamer.NativeMethodInfoPtr_ExtraAdditiveNextOrderProb_Public_Virtual_Single_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005CE6 RID: 23782 RVA: 0x001D38FC File Offset: 0x001D1AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PeerlessWindGodSteamer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PeerlessWindGodSteamer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PeerlessWindGodSteamer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CE7 RID: 23783 RVA: 0x00032B9A File Offset: 0x00030D9A
		public PeerlessWindGodSteamer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06005CE8 RID: 23784 RVA: 0x001D3938 File Offset: 0x001D1B38
		// (set) Token: 0x06005CE9 RID: 23785 RVA: 0x00032BA3 File Offset: 0x00030DA3
		public unsafe static int POPULAR_LIKE_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(PeerlessWindGodSteamer.NativeFieldInfoPtr_POPULAR_LIKE_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PeerlessWindGodSteamer.NativeFieldInfoPtr_POPULAR_LIKE_ID, (void*)(&value));
			}
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x06005CEA RID: 23786 RVA: 0x001D3954 File Offset: 0x001D1B54
		// (set) Token: 0x06005CEB RID: 23787 RVA: 0x00032BB1 File Offset: 0x00030DB1
		public unsafe float extraCookSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PeerlessWindGodSteamer.NativeFieldInfoPtr_extraCookSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PeerlessWindGodSteamer.NativeFieldInfoPtr_extraCookSpeed)) = value;
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06005CEC RID: 23788 RVA: 0x001D397C File Offset: 0x001D1B7C
		// (set) Token: 0x06005CED RID: 23789 RVA: 0x00032BCC File Offset: 0x00030DCC
		public unsafe float extraOrderRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PeerlessWindGodSteamer.NativeFieldInfoPtr_extraOrderRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PeerlessWindGodSteamer.NativeFieldInfoPtr_extraOrderRate)) = value;
			}
		}

		// Token: 0x04003D81 RID: 15745
		private static readonly IntPtr NativeFieldInfoPtr_POPULAR_LIKE_ID;

		// Token: 0x04003D82 RID: 15746
		private static readonly IntPtr NativeFieldInfoPtr_extraCookSpeed;

		// Token: 0x04003D83 RID: 15747
		private static readonly IntPtr NativeFieldInfoPtr_extraOrderRate;

		// Token: 0x04003D84 RID: 15748
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0;

		// Token: 0x04003D85 RID: 15749
		private static readonly IntPtr NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0;

		// Token: 0x04003D86 RID: 15750
		private static readonly IntPtr NativeMethodInfoPtr_ExtraAdditiveNextOrderProb_Public_Virtual_Single_Sellable_0;

		// Token: 0x04003D87 RID: 15751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
