using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;
using NightScene.CookingUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x02000321 RID: 801
	public sealed class PartnerInfoHina : PartnerInfo
	{
		// Token: 0x06005F0B RID: 24331 RVA: 0x001DAC54 File Offset: 0x001D8E54
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoHina()
		{
			Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoHina");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr);
			PartnerInfoHina.NativeFieldInfoPtr_darkMatterRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr, "darkMatterRate");
			PartnerInfoHina.NativeFieldInfoPtr_failedEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr, "failedEffect");
			PartnerInfoHina.NativeFieldInfoPtr_successEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr, "successEffect");
			PartnerInfoHina.NativeFieldInfoPtr_successSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr, "successSFX");
			PartnerInfoHina.NativeFieldInfoPtr_failSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr, "failSFX");
			PartnerInfoHina.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr, 100682826);
			PartnerInfoHina.NativeMethodInfoPtr_OnGetOverrideFinalCookResult_Public_Virtual_Sellable_CookController_Sellable_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr, 100682827);
			PartnerInfoHina.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr, 100682828);
			PartnerInfoHina.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr, 100682829);
		}

		// Token: 0x06005F0C RID: 24332 RVA: 0x001DAD38 File Offset: 0x001D8F38
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 235122, RefRangeEnd = 235130, XrefRangeStart = 235122, XrefRangeEnd = 235122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &doNotCostIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoHina.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F0D RID: 24333 RVA: 0x001DADB4 File Offset: 0x001D8FB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235130, XrefRangeEnd = 235149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Sellable OnGetOverrideFinalCookResult(CookController cooker, Sellable lastFood, out bool isRequestedFood)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lastFood);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &isRequestedFood;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoHina.NativeMethodInfoPtr_OnGetOverrideFinalCookResult_Public_Virtual_Sellable_CookController_Sellable_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
		}

		// Token: 0x06005F0E RID: 24334 RVA: 0x001DAE24 File Offset: 0x001D9024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235149, XrefRangeEnd = 235162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoHina.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F0F RID: 24335 RVA: 0x001DAE68 File Offset: 0x001D9068
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoHina() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoHina>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoHina.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F10 RID: 24336 RVA: 0x00033C69 File Offset: 0x00031E69
		public PartnerInfoHina(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x06005F11 RID: 24337 RVA: 0x001DAEA4 File Offset: 0x001D90A4
		// (set) Token: 0x06005F12 RID: 24338 RVA: 0x00033C72 File Offset: 0x00031E72
		public unsafe float darkMatterRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_darkMatterRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_darkMatterRate)) = value;
			}
		}

		// Token: 0x170020E2 RID: 8418
		// (get) Token: 0x06005F13 RID: 24339 RVA: 0x001DAECC File Offset: 0x001D90CC
		// (set) Token: 0x06005F14 RID: 24340 RVA: 0x00033C8D File Offset: 0x00031E8D
		public unsafe GameObject failedEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_failedEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_failedEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E3 RID: 8419
		// (get) Token: 0x06005F15 RID: 24341 RVA: 0x001DAEFC File Offset: 0x001D90FC
		// (set) Token: 0x06005F16 RID: 24342 RVA: 0x00033CAC File Offset: 0x00031EAC
		public unsafe GameObject successEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_successEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_successEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E4 RID: 8420
		// (get) Token: 0x06005F17 RID: 24343 RVA: 0x001DAF2C File Offset: 0x001D912C
		// (set) Token: 0x06005F18 RID: 24344 RVA: 0x00033CCB File Offset: 0x00031ECB
		public unsafe AudioClip successSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_successSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_successSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020E5 RID: 8421
		// (get) Token: 0x06005F19 RID: 24345 RVA: 0x001DAF5C File Offset: 0x001D915C
		// (set) Token: 0x06005F1A RID: 24346 RVA: 0x00033CEA File Offset: 0x00031EEA
		public unsafe AudioClip failSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_failSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoHina.NativeFieldInfoPtr_failSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003EE2 RID: 16098
		private static readonly IntPtr NativeFieldInfoPtr_darkMatterRate;

		// Token: 0x04003EE3 RID: 16099
		private static readonly IntPtr NativeFieldInfoPtr_failedEffect;

		// Token: 0x04003EE4 RID: 16100
		private static readonly IntPtr NativeFieldInfoPtr_successEffect;

		// Token: 0x04003EE5 RID: 16101
		private static readonly IntPtr NativeFieldInfoPtr_successSFX;

		// Token: 0x04003EE6 RID: 16102
		private static readonly IntPtr NativeFieldInfoPtr_failSFX;

		// Token: 0x04003EE7 RID: 16103
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0;

		// Token: 0x04003EE8 RID: 16104
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideFinalCookResult_Public_Virtual_Sellable_CookController_Sellable_byref_Boolean_0;

		// Token: 0x04003EE9 RID: 16105
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003EEA RID: 16106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
