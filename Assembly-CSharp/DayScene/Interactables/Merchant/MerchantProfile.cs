using System;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DayScene.Interactables.Merchant
{
	// Token: 0x02000162 RID: 354
	public class MerchantProfile : ScriptableObject
	{
		// Token: 0x06002813 RID: 10259 RVA: 0x00123CB0 File Offset: 0x00121EB0
		// Note: this type is marked as 'beforefieldinit'.
		static MerchantProfile()
		{
			Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Merchant", "MerchantProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr);
			MerchantProfile.NativeFieldInfoPtr_merchants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr, "merchants");
			MerchantProfile.NativeFieldInfoPtr_foodProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr, "foodProfile");
			MerchantProfile.NativeFieldInfoPtr_beverageProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr, "beverageProfile");
			MerchantProfile.NativeFieldInfoPtr_ingredientProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr, "ingredientProfile");
			MerchantProfile.NativeFieldInfoPtr_cookerProfile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr, "cookerProfile");
			MerchantProfile.NativeFieldInfoPtr_tsvBackup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr, "tsvBackup");
			MerchantProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr, 100670348);
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00123D6C File Offset: 0x00121F6C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MerchantProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MerchantProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MerchantProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x000179C4 File Offset: 0x00015BC4
		public MerchantProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06002816 RID: 10262 RVA: 0x00123DA8 File Offset: 0x00121FA8
		// (set) Token: 0x06002817 RID: 10263 RVA: 0x000179CD File Offset: 0x00015BCD
		public unsafe Il2CppReferenceArray<Merchant> merchants
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_merchants);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Merchant>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_merchants), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06002818 RID: 10264 RVA: 0x00123DD8 File Offset: 0x00121FD8
		// (set) Token: 0x06002819 RID: 10265 RVA: 0x000179EC File Offset: 0x00015BEC
		public unsafe SellableProfile foodProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_foodProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_foodProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x00123E08 File Offset: 0x00122008
		// (set) Token: 0x0600281B RID: 10267 RVA: 0x00017A0B File Offset: 0x00015C0B
		public unsafe SellableProfile beverageProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_beverageProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SellableProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_beverageProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x00123E38 File Offset: 0x00122038
		// (set) Token: 0x0600281D RID: 10269 RVA: 0x00017A2A File Offset: 0x00015C2A
		public unsafe IngredientProfile ingredientProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_ingredientProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IngredientProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_ingredientProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x0600281E RID: 10270 RVA: 0x00123E68 File Offset: 0x00122068
		// (set) Token: 0x0600281F RID: 10271 RVA: 0x00017A49 File Offset: 0x00015C49
		public unsafe CookerProfile cookerProfile
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_cookerProfile);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookerProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_cookerProfile), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x00123E98 File Offset: 0x00122098
		// (set) Token: 0x06002821 RID: 10273 RVA: 0x00017A68 File Offset: 0x00015C68
		public unsafe TextAsset tsvBackup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_tsvBackup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MerchantProfile.NativeFieldInfoPtr_tsvBackup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A8C RID: 6796
		private static readonly IntPtr NativeFieldInfoPtr_merchants;

		// Token: 0x04001A8D RID: 6797
		private static readonly IntPtr NativeFieldInfoPtr_foodProfile;

		// Token: 0x04001A8E RID: 6798
		private static readonly IntPtr NativeFieldInfoPtr_beverageProfile;

		// Token: 0x04001A8F RID: 6799
		private static readonly IntPtr NativeFieldInfoPtr_ingredientProfile;

		// Token: 0x04001A90 RID: 6800
		private static readonly IntPtr NativeFieldInfoPtr_cookerProfile;

		// Token: 0x04001A91 RID: 6801
		private static readonly IntPtr NativeFieldInfoPtr_tsvBackup;

		// Token: 0x04001A92 RID: 6802
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
