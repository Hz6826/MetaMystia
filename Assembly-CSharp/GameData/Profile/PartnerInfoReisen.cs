using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Text;
using NightScene.EventUtility;
using NightScene.PartnerUtility;

namespace GameData.Profile
{
	// Token: 0x02000327 RID: 807
	public sealed class PartnerInfoReisen : PartnerInfo
	{
		// Token: 0x06005F4C RID: 24396 RVA: 0x001DB9F0 File Offset: 0x001D9BF0
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoReisen()
		{
			Il2CppClassPointerStore<PartnerInfoReisen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoReisen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoReisen>.NativeClassPtr);
			PartnerInfoReisen.NativeFieldInfoPtr_extraFeePercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoReisen>.NativeClassPtr, "extraFeePercentage");
			PartnerInfoReisen.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoReisen>.NativeClassPtr, 100682867);
			PartnerInfoReisen.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoReisen>.NativeClassPtr, 100682868);
			PartnerInfoReisen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoReisen>.NativeClassPtr, 100682869);
		}

		// Token: 0x06005F4D RID: 24397 RVA: 0x001DBA70 File Offset: 0x001D9C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235420, XrefRangeEnd = 235421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPartnerLoad(PartnerBase partnerBase, EventManager eventManager, PartnerManager partnerManager, Il2CppReferenceArray<Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(partnerBase);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(partnerManager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoReisen.NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x001DBAEC File Offset: 0x001D9CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235421, XrefRangeEnd = 235431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoReisen.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x001DBB30 File Offset: 0x001D9D30
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoReisen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoReisen>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoReisen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F50 RID: 24400 RVA: 0x00033E56 File Offset: 0x00032056
		public PartnerInfoReisen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020F4 RID: 8436
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x001DBB6C File Offset: 0x001D9D6C
		// (set) Token: 0x06005F52 RID: 24402 RVA: 0x00033E5F File Offset: 0x0003205F
		public unsafe float extraFeePercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoReisen.NativeFieldInfoPtr_extraFeePercentage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoReisen.NativeFieldInfoPtr_extraFeePercentage)) = value;
			}
		}

		// Token: 0x04003F08 RID: 16136
		private static readonly IntPtr NativeFieldInfoPtr_extraFeePercentage;

		// Token: 0x04003F09 RID: 16137
		private static readonly IntPtr NativeMethodInfoPtr_OnPartnerLoad_Protected_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003F0A RID: 16138
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003F0B RID: 16139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
