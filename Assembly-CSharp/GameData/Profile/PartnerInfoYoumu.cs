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
	// Token: 0x0200032D RID: 813
	public sealed class PartnerInfoYoumu : PartnerInfo
	{
		// Token: 0x06005F95 RID: 24469 RVA: 0x001DCA80 File Offset: 0x001DAC80
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerInfoYoumu()
		{
			Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerInfoYoumu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr);
			PartnerInfoYoumu.NativeFieldInfoPtr_cookerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr, "cookerType");
			PartnerInfoYoumu.NativeFieldInfoPtr_successEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr, "successEffect");
			PartnerInfoYoumu.NativeFieldInfoPtr_successTextEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr, "successTextEffect");
			PartnerInfoYoumu.NativeFieldInfoPtr_successSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr, "successSFX");
			PartnerInfoYoumu.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr, 100682939);
			PartnerInfoYoumu.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr, 100682940);
			PartnerInfoYoumu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr, 100682941);
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x001DCB3C File Offset: 0x001DAD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235875, XrefRangeEnd = 235882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &doNotCostIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoumu.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F97 RID: 24471 RVA: 0x001DCBB8 File Offset: 0x001DADB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235882, XrefRangeEnd = 235885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostProcessInfo(StringBuilder builder)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(builder);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoumu.NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F98 RID: 24472 RVA: 0x001DCBFC File Offset: 0x001DADFC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerInfoYoumu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerInfoYoumu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerInfoYoumu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F99 RID: 24473 RVA: 0x00034059 File Offset: 0x00032259
		public PartnerInfoYoumu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002105 RID: 8453
		// (get) Token: 0x06005F9A RID: 24474 RVA: 0x001DCC38 File Offset: 0x001DAE38
		// (set) Token: 0x06005F9B RID: 24475 RVA: 0x00034062 File Offset: 0x00032262
		public unsafe Cooker.CookerType cookerType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoumu.NativeFieldInfoPtr_cookerType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoumu.NativeFieldInfoPtr_cookerType)) = value;
			}
		}

		// Token: 0x17002106 RID: 8454
		// (get) Token: 0x06005F9C RID: 24476 RVA: 0x001DCC60 File Offset: 0x001DAE60
		// (set) Token: 0x06005F9D RID: 24477 RVA: 0x0003407D File Offset: 0x0003227D
		public unsafe GameObject successEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoumu.NativeFieldInfoPtr_successEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoumu.NativeFieldInfoPtr_successEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002107 RID: 8455
		// (get) Token: 0x06005F9E RID: 24478 RVA: 0x001DCC90 File Offset: 0x001DAE90
		// (set) Token: 0x06005F9F RID: 24479 RVA: 0x0003409C File Offset: 0x0003229C
		public unsafe GameObject successTextEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoumu.NativeFieldInfoPtr_successTextEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoumu.NativeFieldInfoPtr_successTextEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002108 RID: 8456
		// (get) Token: 0x06005FA0 RID: 24480 RVA: 0x001DCCC0 File Offset: 0x001DAEC0
		// (set) Token: 0x06005FA1 RID: 24481 RVA: 0x000340BB File Offset: 0x000322BB
		public unsafe AudioClip successSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoumu.NativeFieldInfoPtr_successSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerInfoYoumu.NativeFieldInfoPtr_successSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003F34 RID: 16180
		private static readonly IntPtr NativeFieldInfoPtr_cookerType;

		// Token: 0x04003F35 RID: 16181
		private static readonly IntPtr NativeFieldInfoPtr_successEffect;

		// Token: 0x04003F36 RID: 16182
		private static readonly IntPtr NativeFieldInfoPtr_successTextEffect;

		// Token: 0x04003F37 RID: 16183
		private static readonly IntPtr NativeFieldInfoPtr_successSFX;

		// Token: 0x04003F38 RID: 16184
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0;

		// Token: 0x04003F39 RID: 16185
		private static readonly IntPtr NativeMethodInfoPtr_PostProcessInfo_Protected_Virtual_Void_StringBuilder_0;

		// Token: 0x04003F3A RID: 16186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
