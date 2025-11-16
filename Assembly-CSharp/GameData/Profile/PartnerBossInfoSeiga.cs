using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.PartnerUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x0200031C RID: 796
	public class PartnerBossInfoSeiga : PartnerBossInfo
	{
		// Token: 0x06005E77 RID: 24183 RVA: 0x001D87A0 File Offset: 0x001D69A0
		// Note: this type is marked as 'beforefieldinit'.
		static PartnerBossInfoSeiga()
		{
			Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "PartnerBossInfoSeiga");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr);
			PartnerBossInfoSeiga.NativeFieldInfoPtr_lockTableNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, "lockTableNum");
			PartnerBossInfoSeiga.NativeFieldInfoPtr_lockDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, "lockDuration");
			PartnerBossInfoSeiga.NativeFieldInfoPtr_lockInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, "lockInterval");
			PartnerBossInfoSeiga.NativeFieldInfoPtr_seigaSmileEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, "seigaSmileEffect");
			PartnerBossInfoSeiga.NativeFieldInfoPtr_seigaSmileSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, "seigaSmileSFX");
			PartnerBossInfoSeiga.NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, 100682692);
			PartnerBossInfoSeiga.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, 100682693);
			PartnerBossInfoSeiga.NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, 100682694);
			PartnerBossInfoSeiga.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, 100682695);
			PartnerBossInfoSeiga.NativeMethodInfoPtr__OnGetOverrideCookTime_b__6_0_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, 100682696);
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x001D8898 File Offset: 0x001D6A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234470, XrefRangeEnd = 234486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BossSpecialAbilityPreLoad(PartnerBase currentPartner, EventManager eventManager, PartnerManager manager, Il2CppReferenceArray<Il2CppSystem.Object> additionalData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentPartner);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eventManager);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(manager);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(additionalData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoSeiga.NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x001D891C File Offset: 0x001D6B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234486, XrefRangeEnd = 234496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float OnGetOverrideCookTime(CookController cooker, Sellable food, float baseTime, ref bool doNotCostIngredients)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cooker);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(food);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseTime;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &doNotCostIngredients;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoSeiga.NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x001D89A4 File Offset: 0x001D6BA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234496, XrefRangeEnd = 234501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetBossSpecialSkill()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartnerBossInfoSeiga.NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x001D89E8 File Offset: 0x001D6BE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234501, XrefRangeEnd = 234502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartnerBossInfoSeiga() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x001D8A24 File Offset: 0x001D6C24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234502, XrefRangeEnd = 234506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnGetOverrideCookTime_b__6_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.NativeMethodInfoPtr__OnGetOverrideCookTime_b__6_0_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x0003383A File Offset: 0x00031A3A
		public PartnerBossInfoSeiga(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06005E7E RID: 24190 RVA: 0x001D8A70 File Offset: 0x001D6C70
		// (set) Token: 0x06005E7F RID: 24191 RVA: 0x00033843 File Offset: 0x00031A43
		public unsafe int lockTableNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_lockTableNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_lockTableNum)) = value;
			}
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06005E80 RID: 24192 RVA: 0x001D8A98 File Offset: 0x001D6C98
		// (set) Token: 0x06005E81 RID: 24193 RVA: 0x0003385E File Offset: 0x00031A5E
		public unsafe int lockDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_lockDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_lockDuration)) = value;
			}
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06005E82 RID: 24194 RVA: 0x001D8AC0 File Offset: 0x001D6CC0
		// (set) Token: 0x06005E83 RID: 24195 RVA: 0x00033879 File Offset: 0x00031A79
		public unsafe int lockInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_lockInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_lockInterval)) = value;
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06005E84 RID: 24196 RVA: 0x001D8AE8 File Offset: 0x001D6CE8
		// (set) Token: 0x06005E85 RID: 24197 RVA: 0x00033894 File Offset: 0x00031A94
		public unsafe GameObject seigaSmileEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_seigaSmileEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_seigaSmileEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06005E86 RID: 24198 RVA: 0x001D8B18 File Offset: 0x001D6D18
		// (set) Token: 0x06005E87 RID: 24199 RVA: 0x000338B3 File Offset: 0x00031AB3
		public unsafe AudioClip seigaSmileSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_seigaSmileSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.NativeFieldInfoPtr_seigaSmileSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003E7D RID: 15997
		private static readonly IntPtr NativeFieldInfoPtr_lockTableNum;

		// Token: 0x04003E7E RID: 15998
		private static readonly IntPtr NativeFieldInfoPtr_lockDuration;

		// Token: 0x04003E7F RID: 15999
		private static readonly IntPtr NativeFieldInfoPtr_lockInterval;

		// Token: 0x04003E80 RID: 16000
		private static readonly IntPtr NativeFieldInfoPtr_seigaSmileEffect;

		// Token: 0x04003E81 RID: 16001
		private static readonly IntPtr NativeFieldInfoPtr_seigaSmileSFX;

		// Token: 0x04003E82 RID: 16002
		private static readonly IntPtr NativeMethodInfoPtr_BossSpecialAbilityPreLoad_Public_Virtual_Void_PartnerBase_EventManager_PartnerManager_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04003E83 RID: 16003
		private static readonly IntPtr NativeMethodInfoPtr_OnGetOverrideCookTime_Public_Virtual_Single_CookController_Sellable_Single_byref_Boolean_0;

		// Token: 0x04003E84 RID: 16004
		private static readonly IntPtr NativeMethodInfoPtr_GetBossSpecialSkill_Public_Virtual_String_0;

		// Token: 0x04003E85 RID: 16005
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003E86 RID: 16006
		private static readonly IntPtr NativeMethodInfoPtr__OnGetOverrideCookTime_b__6_0_Private_Boolean_Int32_0;

		// Token: 0x02000D42 RID: 3394
		[ObfuscatedName("GameData.Profile.PartnerBossInfoSeiga+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F3C3 RID: 62403 RVA: 0x0039AFF0 File Offset: 0x003991F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0>.NativeClassPtr);
				PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
				PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0>.NativeClassPtr, "eventManager");
				PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0>.NativeClassPtr, 100682697);
				PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0>.NativeClassPtr, 100682698);
			}

			// Token: 0x0600F3C4 RID: 62404 RVA: 0x0039B06C File Offset: 0x0039926C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3C5 RID: 62405 RVA: 0x0039B0A8 File Offset: 0x003992A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234422, XrefRangeEnd = 234427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F3C6 RID: 62406 RVA: 0x00082DF4 File Offset: 0x00080FF4
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F3B RID: 20283
			// (get) Token: 0x0600F3C7 RID: 62407 RVA: 0x0039B0E8 File Offset: 0x003992E8
			// (set) Token: 0x0600F3C8 RID: 62408 RVA: 0x00082DFD File Offset: 0x00080FFD
			public unsafe PartnerBossInfoSeiga __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoSeiga>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F3C RID: 20284
			// (get) Token: 0x0600F3C9 RID: 62409 RVA: 0x0039B118 File Offset: 0x00399318
			// (set) Token: 0x0600F3CA RID: 62410 RVA: 0x00082E1C File Offset: 0x0008101C
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B42 RID: 39746
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009B43 RID: 39747
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009B44 RID: 39748
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B45 RID: 39749
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001096 RID: 4246
			[ObfuscatedName("GameData.Profile.PartnerBossInfoSeiga+<>c__DisplayClass5_0+<<BossSpecialAbilityPreLoad>g__SeigaCompulsion|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0601214E RID: 74062 RVA: 0x00420A30 File Offset: 0x0041EC30
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique()
				{
					Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0>.NativeClassPtr, "<<BossSpecialAbilityPreLoad>g__SeigaCompulsion|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr);
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>1__state");
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>2__current");
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>4__this");
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>8__1");
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__wait_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<wait>5__2");
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682699);
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682700);
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682701);
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682702);
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682703);
					PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682704);
				}

				// Token: 0x0601214F RID: 74063 RVA: 0x00420B38 File Offset: 0x0041ED38
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012150 RID: 74064 RVA: 0x00420B80 File Offset: 0x0041ED80
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012151 RID: 74065 RVA: 0x00420BB4 File Offset: 0x0041EDB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234355, XrefRangeEnd = 234416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E6B RID: 24171
				// (get) Token: 0x06012152 RID: 74066 RVA: 0x00420BF0 File Offset: 0x0041EDF0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012153 RID: 74067 RVA: 0x00420C30 File Offset: 0x0041EE30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234416, XrefRangeEnd = 234422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E6C RID: 24172
				// (get) Token: 0x06012154 RID: 74068 RVA: 0x00420C64 File Offset: 0x0041EE64
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012155 RID: 74069 RVA: 0x0009D16F File Offset: 0x0009B36F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E66 RID: 24166
				// (get) Token: 0x06012156 RID: 74070 RVA: 0x00420CA4 File Offset: 0x0041EEA4
				// (set) Token: 0x06012157 RID: 74071 RVA: 0x0009D178 File Offset: 0x0009B378
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E67 RID: 24167
				// (get) Token: 0x06012158 RID: 74072 RVA: 0x00420CCC File Offset: 0x0041EECC
				// (set) Token: 0x06012159 RID: 74073 RVA: 0x0009D193 File Offset: 0x0009B393
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E68 RID: 24168
				// (get) Token: 0x0601215A RID: 74074 RVA: 0x00420CFC File Offset: 0x0041EEFC
				// (set) Token: 0x0601215B RID: 74075 RVA: 0x0009D1B2 File Offset: 0x0009B3B2
				public unsafe PartnerBossInfoSeiga.__c__DisplayClass5_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoSeiga.__c__DisplayClass5_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E69 RID: 24169
				// (get) Token: 0x0601215C RID: 74076 RVA: 0x00420D2C File Offset: 0x0041EF2C
				// (set) Token: 0x0601215D RID: 74077 RVA: 0x0009D1D1 File Offset: 0x0009B3D1
				public unsafe PartnerBossInfoSeiga.__c__DisplayClass5_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoSeiga.__c__DisplayClass5_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E6A RID: 24170
				// (get) Token: 0x0601215E RID: 74078 RVA: 0x00420D5C File Offset: 0x0041EF5C
				// (set) Token: 0x0601215F RID: 74079 RVA: 0x0009D1F0 File Offset: 0x0009B3F0
				public unsafe WaitForSeconds _wait_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__wait_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__wait_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B737 RID: 46903
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B738 RID: 46904
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B739 RID: 46905
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B73A RID: 46906
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B73B RID: 46907
				private static readonly IntPtr NativeFieldInfoPtr__wait_5__2;

				// Token: 0x0400B73C RID: 46908
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B73D RID: 46909
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B73E RID: 46910
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B73F RID: 46911
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B740 RID: 46912
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B741 RID: 46913
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D43 RID: 3395
		[ObfuscatedName("GameData.Profile.PartnerBossInfoSeiga+<>c__DisplayClass5_1")]
		public sealed class __c__DisplayClass5_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F3CB RID: 62411 RVA: 0x0039B148 File Offset: 0x00399348
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_1()
			{
				Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, "<>c__DisplayClass5_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_1>.NativeClassPtr);
				PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeFieldInfoPtr_interrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_1>.NativeClassPtr, "interrupt");
				PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeFieldInfoPtr_vfxList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_1>.NativeClassPtr, "vfxList");
				PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_1>.NativeClassPtr, 100682705);
				PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_1>.NativeClassPtr, 100682706);
			}

			// Token: 0x0600F3CC RID: 62412 RVA: 0x0039B1C4 File Offset: 0x003993C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3CD RID: 62413 RVA: 0x0039B200 File Offset: 0x00399400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234427, XrefRangeEnd = 234448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3CE RID: 62414 RVA: 0x00082E3B File Offset: 0x0008103B
			public __c__DisplayClass5_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F3D RID: 20285
			// (get) Token: 0x0600F3CF RID: 62415 RVA: 0x0039B234 File Offset: 0x00399434
			// (set) Token: 0x0600F3D0 RID: 62416 RVA: 0x00082E44 File Offset: 0x00081044
			public unsafe Action interrupt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeFieldInfoPtr_interrupt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeFieldInfoPtr_interrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F3E RID: 20286
			// (get) Token: 0x0600F3D1 RID: 62417 RVA: 0x0039B264 File Offset: 0x00399464
			// (set) Token: 0x0600F3D2 RID: 62418 RVA: 0x00082E63 File Offset: 0x00081063
			public unsafe List<GameObject> vfxList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeFieldInfoPtr_vfxList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_1.NativeFieldInfoPtr_vfxList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B46 RID: 39750
			private static readonly IntPtr NativeFieldInfoPtr_interrupt;

			// Token: 0x04009B47 RID: 39751
			private static readonly IntPtr NativeFieldInfoPtr_vfxList;

			// Token: 0x04009B48 RID: 39752
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B49 RID: 39753
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000D44 RID: 3396
		[ObfuscatedName("GameData.Profile.PartnerBossInfoSeiga+<>c__DisplayClass5_2")]
		public sealed class __c__DisplayClass5_2 : Il2CppSystem.Object
		{
			// Token: 0x0600F3D3 RID: 62419 RVA: 0x0039B294 File Offset: 0x00399494
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_2()
			{
				Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, "<>c__DisplayClass5_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_2>.NativeClassPtr);
				PartnerBossInfoSeiga.__c__DisplayClass5_2.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_2>.NativeClassPtr, "x");
				PartnerBossInfoSeiga.__c__DisplayClass5_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_2>.NativeClassPtr, 100682707);
				PartnerBossInfoSeiga.__c__DisplayClass5_2.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_2>.NativeClassPtr, 100682708);
			}

			// Token: 0x0600F3D4 RID: 62420 RVA: 0x0039B2FC File Offset: 0x003994FC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c__DisplayClass5_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3D5 RID: 62421 RVA: 0x0039B338 File Offset: 0x00399538
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234448, XrefRangeEnd = 234452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BossSpecialAbilityPreLoad_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c__DisplayClass5_2.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3D6 RID: 62422 RVA: 0x00082E82 File Offset: 0x00081082
			public __c__DisplayClass5_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F3F RID: 20287
			// (get) Token: 0x0600F3D7 RID: 62423 RVA: 0x0039B36C File Offset: 0x0039956C
			// (set) Token: 0x0600F3D8 RID: 62424 RVA: 0x00082E8B File Offset: 0x0008108B
			public unsafe GameObject x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_2.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartnerBossInfoSeiga.__c__DisplayClass5_2.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B4A RID: 39754
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04009B4B RID: 39755
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B4C RID: 39756
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__3_Internal_Void_0;
		}

		// Token: 0x02000D45 RID: 3397
		[ObfuscatedName("GameData.Profile.PartnerBossInfoSeiga+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F3D9 RID: 62425 RVA: 0x0039B39C File Offset: 0x0039959C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartnerBossInfoSeiga.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartnerBossInfoSeiga>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c>.NativeClassPtr);
				PartnerBossInfoSeiga.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c>.NativeClassPtr, "<>9");
				PartnerBossInfoSeiga.__c.NativeFieldInfoPtr___9__5_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c>.NativeClassPtr, "<>9__5_2");
				PartnerBossInfoSeiga.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c>.NativeClassPtr, 100682710);
				PartnerBossInfoSeiga.__c.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__5_2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c>.NativeClassPtr, 100682711);
			}

			// Token: 0x0600F3DA RID: 62426 RVA: 0x0039B418 File Offset: 0x00399618
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartnerBossInfoSeiga.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3DB RID: 62427 RVA: 0x0039B454 File Offset: 0x00399654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234452, XrefRangeEnd = 234470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _BossSpecialAbilityPreLoad_b__5_2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartnerBossInfoSeiga.__c.NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__5_2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F3DC RID: 62428 RVA: 0x00082EAA File Offset: 0x000810AA
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004F40 RID: 20288
			// (get) Token: 0x0600F3DD RID: 62429 RVA: 0x0039B498 File Offset: 0x00399698
			// (set) Token: 0x0600F3DE RID: 62430 RVA: 0x00082EB3 File Offset: 0x000810B3
			public unsafe static PartnerBossInfoSeiga.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoSeiga.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerBossInfoSeiga.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoSeiga.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004F41 RID: 20289
			// (get) Token: 0x0600F3DF RID: 62431 RVA: 0x0039B4C0 File Offset: 0x003996C0
			// (set) Token: 0x0600F3E0 RID: 62432 RVA: 0x00082EC5 File Offset: 0x000810C5
			public unsafe static Action<GameObject> __9__5_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartnerBossInfoSeiga.__c.NativeFieldInfoPtr___9__5_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartnerBossInfoSeiga.__c.NativeFieldInfoPtr___9__5_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009B4D RID: 39757
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009B4E RID: 39758
			private static readonly IntPtr NativeFieldInfoPtr___9__5_2;

			// Token: 0x04009B4F RID: 39759
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009B50 RID: 39760
			private static readonly IntPtr NativeMethodInfoPtr__BossSpecialAbilityPreLoad_b__5_2_Internal_Void_GameObject_0;
		}
	}
}
