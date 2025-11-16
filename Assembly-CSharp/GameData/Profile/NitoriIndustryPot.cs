using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace GameData.Profile
{
	// Token: 0x02000303 RID: 771
	public class NitoriIndustryPot : CookerAssetBase
	{
		// Token: 0x06005CC5 RID: 23749 RVA: 0x001D31A0 File Offset: 0x001D13A0
		// Note: this type is marked as 'beforefieldinit'.
		static NitoriIndustryPot()
		{
			Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "NitoriIndustryPot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr);
			NitoriIndustryPot.NativeFieldInfoPtr_finalFoodUseTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, "finalFoodUseTime");
			NitoriIndustryPot.NativeFieldInfoPtr_targetWorkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, "targetWorkTime");
			NitoriIndustryPot.NativeFieldInfoPtr_upgradeVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, "upgradeVfx");
			NitoriIndustryPot.NativeFieldInfoPtr_upgradeVfxOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, "upgradeVfxOffset");
			NitoriIndustryPot.NativeFieldInfoPtr_v2Idle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, "v2Idle");
			NitoriIndustryPot.NativeFieldInfoPtr_v2Load = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, "v2Load");
			NitoriIndustryPot.NativeFieldInfoPtr_v2Cooking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, "v2Cooking");
			NitoriIndustryPot.NativeMethodInfoPtr_OnCookerWorkTimeUpdate_Public_Virtual_Void_CookController_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, 100682446);
			NitoriIndustryPot.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, 100682447);
			NitoriIndustryPot.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, 100682448);
			NitoriIndustryPot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, 100682449);
		}

		// Token: 0x06005CC6 RID: 23750 RVA: 0x001D32AC File Offset: 0x001D14AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232560, XrefRangeEnd = 232571, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCookerWorkTimeUpdate(CookController targetCooker, float oldWorkTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetCooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldWorkTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NitoriIndustryPot.NativeMethodInfoPtr_OnCookerWorkTimeUpdate_Public_Virtual_Void_CookController_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CC7 RID: 23751 RVA: 0x001D3308 File Offset: 0x001D1508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232571, XrefRangeEnd = 232583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ProcessBaseDescriptionCallback(string baseDescription)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseDescription);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NitoriIndustryPot.NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005CC8 RID: 23752 RVA: 0x001D335C File Offset: 0x001D155C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232583, XrefRangeEnd = 232708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float ExtraCookTimeMultiplier(CookController thisCookController, Sellable food)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisCookController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NitoriIndustryPot.NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005CC9 RID: 23753 RVA: 0x001D33C8 File Offset: 0x001D15C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232708, XrefRangeEnd = 232709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NitoriIndustryPot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005CCA RID: 23754 RVA: 0x00032A85 File Offset: 0x00030C85
		public NitoriIndustryPot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x06005CCB RID: 23755 RVA: 0x001D3404 File Offset: 0x001D1604
		// (set) Token: 0x06005CCC RID: 23756 RVA: 0x00032A8E File Offset: 0x00030C8E
		public unsafe float finalFoodUseTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_finalFoodUseTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_finalFoodUseTime)) = value;
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x06005CCD RID: 23757 RVA: 0x001D342C File Offset: 0x001D162C
		// (set) Token: 0x06005CCE RID: 23758 RVA: 0x00032AA9 File Offset: 0x00030CA9
		public unsafe int targetWorkTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_targetWorkTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_targetWorkTime)) = value;
			}
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06005CCF RID: 23759 RVA: 0x001D3454 File Offset: 0x001D1654
		// (set) Token: 0x06005CD0 RID: 23760 RVA: 0x00032AC4 File Offset: 0x00030CC4
		public unsafe GameObject upgradeVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_upgradeVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_upgradeVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06005CD1 RID: 23761 RVA: 0x001D3484 File Offset: 0x001D1684
		// (set) Token: 0x06005CD2 RID: 23762 RVA: 0x00032AE3 File Offset: 0x00030CE3
		public unsafe Vector3 upgradeVfxOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_upgradeVfxOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_upgradeVfxOffset)) = value;
			}
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06005CD3 RID: 23763 RVA: 0x001D34AC File Offset: 0x001D16AC
		// (set) Token: 0x06005CD4 RID: 23764 RVA: 0x00032AFE File Offset: 0x00030CFE
		public unsafe AnimatedTile v2Idle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_v2Idle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_v2Idle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06005CD5 RID: 23765 RVA: 0x001D34DC File Offset: 0x001D16DC
		// (set) Token: 0x06005CD6 RID: 23766 RVA: 0x00032B1D File Offset: 0x00030D1D
		public unsafe AnimatedTile v2Load
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_v2Load);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_v2Load), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x06005CD7 RID: 23767 RVA: 0x001D350C File Offset: 0x001D170C
		// (set) Token: 0x06005CD8 RID: 23768 RVA: 0x00032B3C File Offset: 0x00030D3C
		public unsafe AnimatedTile v2Cooking
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_v2Cooking);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimatedTile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.NativeFieldInfoPtr_v2Cooking), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D71 RID: 15729
		private static readonly IntPtr NativeFieldInfoPtr_finalFoodUseTime;

		// Token: 0x04003D72 RID: 15730
		private static readonly IntPtr NativeFieldInfoPtr_targetWorkTime;

		// Token: 0x04003D73 RID: 15731
		private static readonly IntPtr NativeFieldInfoPtr_upgradeVfx;

		// Token: 0x04003D74 RID: 15732
		private static readonly IntPtr NativeFieldInfoPtr_upgradeVfxOffset;

		// Token: 0x04003D75 RID: 15733
		private static readonly IntPtr NativeFieldInfoPtr_v2Idle;

		// Token: 0x04003D76 RID: 15734
		private static readonly IntPtr NativeFieldInfoPtr_v2Load;

		// Token: 0x04003D77 RID: 15735
		private static readonly IntPtr NativeFieldInfoPtr_v2Cooking;

		// Token: 0x04003D78 RID: 15736
		private static readonly IntPtr NativeMethodInfoPtr_OnCookerWorkTimeUpdate_Public_Virtual_Void_CookController_Single_0;

		// Token: 0x04003D79 RID: 15737
		private static readonly IntPtr NativeMethodInfoPtr_ProcessBaseDescriptionCallback_Protected_Virtual_String_String_0;

		// Token: 0x04003D7A RID: 15738
		private static readonly IntPtr NativeMethodInfoPtr_ExtraCookTimeMultiplier_Public_Virtual_Single_CookController_Sellable_0;

		// Token: 0x04003D7B RID: 15739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D2A RID: 3370
		[ObfuscatedName("GameData.Profile.NitoriIndustryPot+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F2D6 RID: 62166 RVA: 0x0039856C File Offset: 0x0039676C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr);
				NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_numMaxIng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr, "numMaxIng");
				NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_numMinIng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr, "numMinIng");
				NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_valueMaxIng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr, "valueMaxIng");
				NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_valueMinIng = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr, "valueMinIng");
				NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr, 100682450);
				NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__2_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr, 100682451);
				NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__4_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr, 100682452);
				NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__6_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr, 100682453);
				NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__8_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr, 100682454);
			}

			// Token: 0x0600F2D7 RID: 62167 RVA: 0x0039864C File Offset: 0x0039684C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriIndustryPot.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2D8 RID: 62168 RVA: 0x00398688 File Offset: 0x00396888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232550, XrefRangeEnd = 232551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExtraCookTimeMultiplier_b__2(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__2_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2D9 RID: 62169 RVA: 0x003986DC File Offset: 0x003968DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232551, XrefRangeEnd = 232552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExtraCookTimeMultiplier_b__4(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__4_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2DA RID: 62170 RVA: 0x00398730 File Offset: 0x00396930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232552, XrefRangeEnd = 232553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExtraCookTimeMultiplier_b__6(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__6_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2DB RID: 62171 RVA: 0x00398784 File Offset: 0x00396984
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232553, XrefRangeEnd = 232554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExtraCookTimeMultiplier_b__8(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c__DisplayClass9_0.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__8_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2DC RID: 62172 RVA: 0x00082660 File Offset: 0x00080860
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EFA RID: 20218
			// (get) Token: 0x0600F2DD RID: 62173 RVA: 0x003987D8 File Offset: 0x003969D8
			// (set) Token: 0x0600F2DE RID: 62174 RVA: 0x00082669 File Offset: 0x00080869
			public unsafe int numMaxIng
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_numMaxIng);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_numMaxIng)) = value;
				}
			}

			// Token: 0x17004EFB RID: 20219
			// (get) Token: 0x0600F2DF RID: 62175 RVA: 0x00398800 File Offset: 0x00396A00
			// (set) Token: 0x0600F2E0 RID: 62176 RVA: 0x00082684 File Offset: 0x00080884
			public unsafe int numMinIng
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_numMinIng);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_numMinIng)) = value;
				}
			}

			// Token: 0x17004EFC RID: 20220
			// (get) Token: 0x0600F2E1 RID: 62177 RVA: 0x00398828 File Offset: 0x00396A28
			// (set) Token: 0x0600F2E2 RID: 62178 RVA: 0x0008269F File Offset: 0x0008089F
			public unsafe int valueMaxIng
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_valueMaxIng);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_valueMaxIng)) = value;
				}
			}

			// Token: 0x17004EFD RID: 20221
			// (get) Token: 0x0600F2E3 RID: 62179 RVA: 0x00398850 File Offset: 0x00396A50
			// (set) Token: 0x0600F2E4 RID: 62180 RVA: 0x000826BA File Offset: 0x000808BA
			public unsafe int valueMinIng
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_valueMinIng);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NitoriIndustryPot.__c__DisplayClass9_0.NativeFieldInfoPtr_valueMinIng)) = value;
				}
			}

			// Token: 0x04009AB5 RID: 39605
			private static readonly IntPtr NativeFieldInfoPtr_numMaxIng;

			// Token: 0x04009AB6 RID: 39606
			private static readonly IntPtr NativeFieldInfoPtr_numMinIng;

			// Token: 0x04009AB7 RID: 39607
			private static readonly IntPtr NativeFieldInfoPtr_valueMaxIng;

			// Token: 0x04009AB8 RID: 39608
			private static readonly IntPtr NativeFieldInfoPtr_valueMinIng;

			// Token: 0x04009AB9 RID: 39609
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009ABA RID: 39610
			private static readonly IntPtr NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__2_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04009ABB RID: 39611
			private static readonly IntPtr NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__4_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04009ABC RID: 39612
			private static readonly IntPtr NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__6_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04009ABD RID: 39613
			private static readonly IntPtr NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__8_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;
		}

		// Token: 0x02000D2B RID: 3371
		[ObfuscatedName("GameData.Profile.NitoriIndustryPot+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F2E5 RID: 62181 RVA: 0x00398878 File Offset: 0x00396A78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NitoriIndustryPot>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr);
				NitoriIndustryPot.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, "<>9");
				NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, "<>9__9_0");
				NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, "<>9__9_1");
				NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, "<>9__9_3");
				NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, "<>9__9_5");
				NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, "<>9__9_7");
				NitoriIndustryPot.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, 100682456);
				NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_0_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, 100682457);
				NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, 100682458);
				NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_3_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, 100682459);
				NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_5_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, 100682460);
				NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_7_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr, 100682461);
			}

			// Token: 0x0600F2E6 RID: 62182 RVA: 0x00398994 File Offset: 0x00396B94
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NitoriIndustryPot.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F2E7 RID: 62183 RVA: 0x003989D0 File Offset: 0x00396BD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232554, XrefRangeEnd = 232556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ExtraCookTimeMultiplier_b__9_0(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_0_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2E8 RID: 62184 RVA: 0x00398A24 File Offset: 0x00396C24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232556, XrefRangeEnd = 232557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ExtraCookTimeMultiplier_b__9_1(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2E9 RID: 62185 RVA: 0x00398A78 File Offset: 0x00396C78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232557, XrefRangeEnd = 232558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ExtraCookTimeMultiplier_b__9_3(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_3_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2EA RID: 62186 RVA: 0x00398ACC File Offset: 0x00396CCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232558, XrefRangeEnd = 232559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ExtraCookTimeMultiplier_b__9_5(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_5_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2EB RID: 62187 RVA: 0x00398B20 File Offset: 0x00396D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232559, XrefRangeEnd = 232560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _ExtraCookTimeMultiplier_b__9_7(KeyValuePair<Ingredient, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NitoriIndustryPot.__c.NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_7_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F2EC RID: 62188 RVA: 0x000826D5 File Offset: 0x000808D5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EFE RID: 20222
			// (get) Token: 0x0600F2ED RID: 62189 RVA: 0x00398B74 File Offset: 0x00396D74
			// (set) Token: 0x0600F2EE RID: 62190 RVA: 0x000826DE File Offset: 0x000808DE
			public unsafe static NitoriIndustryPot.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NitoriIndustryPot.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EFF RID: 20223
			// (get) Token: 0x0600F2EF RID: 62191 RVA: 0x00398B9C File Offset: 0x00396D9C
			// (set) Token: 0x0600F2F0 RID: 62192 RVA: 0x000826F0 File Offset: 0x000808F0
			public unsafe static Func<KeyValuePair<Ingredient, int>, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F00 RID: 20224
			// (get) Token: 0x0600F2F1 RID: 62193 RVA: 0x00398BC4 File Offset: 0x00396DC4
			// (set) Token: 0x0600F2F2 RID: 62194 RVA: 0x00082702 File Offset: 0x00080902
			public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F01 RID: 20225
			// (get) Token: 0x0600F2F3 RID: 62195 RVA: 0x00398BEC File Offset: 0x00396DEC
			// (set) Token: 0x0600F2F4 RID: 62196 RVA: 0x00082714 File Offset: 0x00080914
			public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__9_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F02 RID: 20226
			// (get) Token: 0x0600F2F5 RID: 62197 RVA: 0x00398C14 File Offset: 0x00396E14
			// (set) Token: 0x0600F2F6 RID: 62198 RVA: 0x00082726 File Offset: 0x00080926
			public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__9_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F03 RID: 20227
			// (get) Token: 0x0600F2F7 RID: 62199 RVA: 0x00398C3C File Offset: 0x00396E3C
			// (set) Token: 0x0600F2F8 RID: 62200 RVA: 0x00082738 File Offset: 0x00080938
			public unsafe static Func<KeyValuePair<Ingredient, int>, int> __9__9_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<Ingredient, int>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NitoriIndustryPot.__c.NativeFieldInfoPtr___9__9_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009ABE RID: 39614
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009ABF RID: 39615
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04009AC0 RID: 39616
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04009AC1 RID: 39617
			private static readonly IntPtr NativeFieldInfoPtr___9__9_3;

			// Token: 0x04009AC2 RID: 39618
			private static readonly IntPtr NativeFieldInfoPtr___9__9_5;

			// Token: 0x04009AC3 RID: 39619
			private static readonly IntPtr NativeFieldInfoPtr___9__9_7;

			// Token: 0x04009AC4 RID: 39620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009AC5 RID: 39621
			private static readonly IntPtr NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_0_Internal_Boolean_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04009AC6 RID: 39622
			private static readonly IntPtr NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_1_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04009AC7 RID: 39623
			private static readonly IntPtr NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_3_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04009AC8 RID: 39624
			private static readonly IntPtr NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_5_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;

			// Token: 0x04009AC9 RID: 39625
			private static readonly IntPtr NativeMethodInfoPtr__ExtraCookTimeMultiplier_b__9_7_Internal_Int32_KeyValuePair_2_Ingredient_Int32_0;
		}
	}
}
