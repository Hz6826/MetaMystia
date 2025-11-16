using System;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200025E RID: 606
	public class Spell_Alice : SpellBase
	{
		// Token: 0x06004A87 RID: 19079 RVA: 0x001A24AC File Offset: 0x001A06AC
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Alice()
		{
			Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Alice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr);
			Spell_Alice.NativeFieldInfoPtr_negativeDurationSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "negativeDurationSec");
			Spell_Alice.NativeFieldInfoPtr_boomedCookerNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "boomedCookerNum");
			Spell_Alice.NativeFieldInfoPtr_rewardDoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "rewardDoll");
			Spell_Alice.NativeFieldInfoPtr_handOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "handOffset");
			Spell_Alice.NativeFieldInfoPtr_rewardSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "rewardSFX");
			Spell_Alice.NativeFieldInfoPtr_punishmentDoll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "punishmentDoll");
			Spell_Alice.NativeFieldInfoPtr_dollFlyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "dollFlyTime");
			Spell_Alice.NativeFieldInfoPtr_punishmentBoomEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "punishmentBoomEffect");
			Spell_Alice.NativeFieldInfoPtr_punishmentCookerEffectNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "punishmentCookerEffectNormal");
			Spell_Alice.NativeFieldInfoPtr_punishmentCookerEffectDrop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "punishmentCookerEffectDrop");
			Spell_Alice.NativeFieldInfoPtr_launchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "launchSpeed");
			Spell_Alice.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "launchHeight");
			Spell_Alice.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "punishmentSFX");
			Spell_Alice.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, 100678308);
			Spell_Alice.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, 100678309);
			Spell_Alice.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, 100678310);
			Spell_Alice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, 100678311);
			Spell_Alice.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_CookController_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, 100678312);
		}

		// Token: 0x06004A88 RID: 19080 RVA: 0x001A2644 File Offset: 0x001A0844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194503, XrefRangeEnd = 194505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Alice.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004A89 RID: 19081 RVA: 0x001A2688 File Offset: 0x001A0888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194505, XrefRangeEnd = 194511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Alice.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A8A RID: 19082 RVA: 0x001A26E4 File Offset: 0x001A08E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194511, XrefRangeEnd = 194517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Alice.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x001A2740 File Offset: 0x001A0940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194517, XrefRangeEnd = 194518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Alice() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x001A277C File Offset: 0x001A097C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194518, XrefRangeEnd = 194523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator Method_Internal_Static_IEnumerator_CookController_Single_PDM_0(CookController cookController, float delay)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookController);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delay;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_CookController_Single_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x000260CE File Offset: 0x000242CE
		public Spell_Alice(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x06004A8E RID: 19086 RVA: 0x001A27D0 File Offset: 0x001A09D0
		// (set) Token: 0x06004A8F RID: 19087 RVA: 0x000260D7 File Offset: 0x000242D7
		public unsafe int negativeDurationSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_negativeDurationSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_negativeDurationSec)) = value;
			}
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06004A90 RID: 19088 RVA: 0x001A27F8 File Offset: 0x001A09F8
		// (set) Token: 0x06004A91 RID: 19089 RVA: 0x000260F2 File Offset: 0x000242F2
		public unsafe int boomedCookerNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_boomedCookerNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_boomedCookerNum)) = value;
			}
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06004A92 RID: 19090 RVA: 0x001A2820 File Offset: 0x001A0A20
		// (set) Token: 0x06004A93 RID: 19091 RVA: 0x0002610D File Offset: 0x0002430D
		public unsafe GameObject rewardDoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_rewardDoll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_rewardDoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06004A94 RID: 19092 RVA: 0x001A2850 File Offset: 0x001A0A50
		// (set) Token: 0x06004A95 RID: 19093 RVA: 0x0002612C File Offset: 0x0002432C
		public unsafe Vector2 handOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_handOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_handOffset)) = value;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x06004A96 RID: 19094 RVA: 0x001A2878 File Offset: 0x001A0A78
		// (set) Token: 0x06004A97 RID: 19095 RVA: 0x00026147 File Offset: 0x00024347
		public unsafe AudioClip rewardSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_rewardSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_rewardSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06004A98 RID: 19096 RVA: 0x001A28A8 File Offset: 0x001A0AA8
		// (set) Token: 0x06004A99 RID: 19097 RVA: 0x00026166 File Offset: 0x00024366
		public unsafe GameObject punishmentDoll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentDoll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentDoll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x06004A9A RID: 19098 RVA: 0x001A28D8 File Offset: 0x001A0AD8
		// (set) Token: 0x06004A9B RID: 19099 RVA: 0x00026185 File Offset: 0x00024385
		public unsafe float dollFlyTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_dollFlyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_dollFlyTime)) = value;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x06004A9C RID: 19100 RVA: 0x001A2900 File Offset: 0x001A0B00
		// (set) Token: 0x06004A9D RID: 19101 RVA: 0x000261A0 File Offset: 0x000243A0
		public unsafe GameObject punishmentBoomEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentBoomEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentBoomEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FE RID: 6398
		// (get) Token: 0x06004A9E RID: 19102 RVA: 0x001A2930 File Offset: 0x001A0B30
		// (set) Token: 0x06004A9F RID: 19103 RVA: 0x000261BF File Offset: 0x000243BF
		public unsafe GameObject punishmentCookerEffectNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentCookerEffectNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentCookerEffectNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x06004AA0 RID: 19104 RVA: 0x001A2960 File Offset: 0x001A0B60
		// (set) Token: 0x06004AA1 RID: 19105 RVA: 0x000261DE File Offset: 0x000243DE
		public unsafe GameObject punishmentCookerEffectDrop
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentCookerEffectDrop);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentCookerEffectDrop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001900 RID: 6400
		// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x001A2990 File Offset: 0x001A0B90
		// (set) Token: 0x06004AA3 RID: 19107 RVA: 0x000261FD File Offset: 0x000243FD
		public unsafe float launchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_launchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_launchSpeed)) = value;
			}
		}

		// Token: 0x17001901 RID: 6401
		// (get) Token: 0x06004AA4 RID: 19108 RVA: 0x001A29B8 File Offset: 0x001A0BB8
		// (set) Token: 0x06004AA5 RID: 19109 RVA: 0x00026218 File Offset: 0x00024418
		public unsafe float launchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_launchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_launchHeight)) = value;
			}
		}

		// Token: 0x17001902 RID: 6402
		// (get) Token: 0x06004AA6 RID: 19110 RVA: 0x001A29E0 File Offset: 0x001A0BE0
		// (set) Token: 0x06004AA7 RID: 19111 RVA: 0x00026233 File Offset: 0x00024433
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003342 RID: 13122
		private static readonly IntPtr NativeFieldInfoPtr_negativeDurationSec;

		// Token: 0x04003343 RID: 13123
		private static readonly IntPtr NativeFieldInfoPtr_boomedCookerNum;

		// Token: 0x04003344 RID: 13124
		private static readonly IntPtr NativeFieldInfoPtr_rewardDoll;

		// Token: 0x04003345 RID: 13125
		private static readonly IntPtr NativeFieldInfoPtr_handOffset;

		// Token: 0x04003346 RID: 13126
		private static readonly IntPtr NativeFieldInfoPtr_rewardSFX;

		// Token: 0x04003347 RID: 13127
		private static readonly IntPtr NativeFieldInfoPtr_punishmentDoll;

		// Token: 0x04003348 RID: 13128
		private static readonly IntPtr NativeFieldInfoPtr_dollFlyTime;

		// Token: 0x04003349 RID: 13129
		private static readonly IntPtr NativeFieldInfoPtr_punishmentBoomEffect;

		// Token: 0x0400334A RID: 13130
		private static readonly IntPtr NativeFieldInfoPtr_punishmentCookerEffectNormal;

		// Token: 0x0400334B RID: 13131
		private static readonly IntPtr NativeFieldInfoPtr_punishmentCookerEffectDrop;

		// Token: 0x0400334C RID: 13132
		private static readonly IntPtr NativeFieldInfoPtr_launchSpeed;

		// Token: 0x0400334D RID: 13133
		private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

		// Token: 0x0400334E RID: 13134
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x0400334F RID: 13135
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003350 RID: 13136
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003351 RID: 13137
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003352 RID: 13138
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003353 RID: 13139
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_IEnumerator_CookController_Single_PDM_0;

		// Token: 0x02000AF6 RID: 2806
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c__DisplayClass14_0")]
		public new sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0C8 RID: 53448 RVA: 0x00334610 File Offset: 0x00332810
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_0>.NativeClassPtr);
				Spell_Alice.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				Spell_Alice.__c__DisplayClass14_0.NativeFieldInfoPtr_lockedCookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_0>.NativeClassPtr, "lockedCookController");
				Spell_Alice.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_0>.NativeClassPtr, 100678313);
				Spell_Alice.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_0>.NativeClassPtr, 100678314);
			}

			// Token: 0x0600D0C9 RID: 53449 RVA: 0x0033468C File Offset: 0x0033288C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0CA RID: 53450 RVA: 0x003346C8 File Offset: 0x003328C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194177, XrefRangeEnd = 194239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0CB RID: 53451 RVA: 0x0006FC75 File Offset: 0x0006DE75
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043ED RID: 17389
			// (get) Token: 0x0600D0CC RID: 53452 RVA: 0x003346FC File Offset: 0x003328FC
			// (set) Token: 0x0600D0CD RID: 53453 RVA: 0x0006FC7E File Offset: 0x0006DE7E
			public unsafe Spell_Alice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EE RID: 17390
			// (get) Token: 0x0600D0CE RID: 53454 RVA: 0x0033472C File Offset: 0x0033292C
			// (set) Token: 0x0600D0CF RID: 53455 RVA: 0x0006FC9D File Offset: 0x0006DE9D
			public unsafe List<CookController> lockedCookController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_0.NativeFieldInfoPtr_lockedCookController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CookController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_0.NativeFieldInfoPtr_lockedCookController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008634 RID: 34356
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008635 RID: 34357
			private static readonly IntPtr NativeFieldInfoPtr_lockedCookController;

			// Token: 0x04008636 RID: 34358
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008637 RID: 34359
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000AF7 RID: 2807
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c__DisplayClass14_1")]
		public sealed class __c__DisplayClass14_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D0D0 RID: 53456 RVA: 0x0033475C File Offset: 0x0033295C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_1()
			{
				Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<>c__DisplayClass14_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_1>.NativeClassPtr);
				Spell_Alice.__c__DisplayClass14_1.NativeFieldInfoPtr_cooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_1>.NativeClassPtr, "cooker");
				Spell_Alice.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_1>.NativeClassPtr, 100678315);
				Spell_Alice.__c__DisplayClass14_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_1>.NativeClassPtr, 100678316);
			}

			// Token: 0x0600D0D1 RID: 53457 RVA: 0x003347C4 File Offset: 0x003329C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0D2 RID: 53458 RVA: 0x00334800 File Offset: 0x00332A00
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0D3 RID: 53459 RVA: 0x0006FCBC File Offset: 0x0006DEBC
			public __c__DisplayClass14_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043EF RID: 17391
			// (get) Token: 0x0600D0D4 RID: 53460 RVA: 0x0033483C File Offset: 0x00332A3C
			// (set) Token: 0x0600D0D5 RID: 53461 RVA: 0x0006FCC5 File Offset: 0x0006DEC5
			public unsafe CookController cooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_1.NativeFieldInfoPtr_cooker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_1.NativeFieldInfoPtr_cooker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008638 RID: 34360
			private static readonly IntPtr NativeFieldInfoPtr_cooker;

			// Token: 0x04008639 RID: 34361
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400863A RID: 34362
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0;
		}

		// Token: 0x02000AF8 RID: 2808
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c__DisplayClass14_2")]
		public sealed class __c__DisplayClass14_2 : Il2CppSystem.Object
		{
			// Token: 0x0600D0D6 RID: 53462 RVA: 0x0033486C File Offset: 0x00332A6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_2()
			{
				Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<>c__DisplayClass14_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_2>.NativeClassPtr);
				Spell_Alice.__c__DisplayClass14_2.NativeFieldInfoPtr_cooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_2>.NativeClassPtr, "cooker");
				Spell_Alice.__c__DisplayClass14_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_2>.NativeClassPtr, 100678317);
				Spell_Alice.__c__DisplayClass14_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_2>.NativeClassPtr, 100678318);
				Spell_Alice.__c__DisplayClass14_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_2>.NativeClassPtr, 100678319);
			}

			// Token: 0x0600D0D7 RID: 53463 RVA: 0x003348E8 File Offset: 0x00332AE8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0D8 RID: 53464 RVA: 0x00334924 File Offset: 0x00332B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194239, XrefRangeEnd = 194241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__4(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0D9 RID: 53465 RVA: 0x00334968 File Offset: 0x00332B68
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0DA RID: 53466 RVA: 0x0006FCE4 File Offset: 0x0006DEE4
			public __c__DisplayClass14_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F0 RID: 17392
			// (get) Token: 0x0600D0DB RID: 53467 RVA: 0x003349A4 File Offset: 0x00332BA4
			// (set) Token: 0x0600D0DC RID: 53468 RVA: 0x0006FCED File Offset: 0x0006DEED
			public unsafe CookController cooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_2.NativeFieldInfoPtr_cooker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_2.NativeFieldInfoPtr_cooker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400863B RID: 34363
			private static readonly IntPtr NativeFieldInfoPtr_cooker;

			// Token: 0x0400863C RID: 34364
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400863D RID: 34365
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_GameObject_0;

			// Token: 0x0400863E RID: 34366
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Vector3_0;
		}

		// Token: 0x02000AF9 RID: 2809
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c__DisplayClass14_3")]
		public sealed class __c__DisplayClass14_3 : Il2CppSystem.Object
		{
			// Token: 0x0600D0DD RID: 53469 RVA: 0x003349D4 File Offset: 0x00332BD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_3()
			{
				Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<>c__DisplayClass14_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_3>.NativeClassPtr);
				Spell_Alice.__c__DisplayClass14_3.NativeFieldInfoPtr_cookerPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_3>.NativeClassPtr, "cookerPic");
				Spell_Alice.__c__DisplayClass14_3.NativeFieldInfoPtr_field_Public___c__DisplayClass14_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_3>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Alice.__c__DisplayClass14_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_3>.NativeClassPtr, 100678320);
				Spell_Alice.__c__DisplayClass14_3.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_3>.NativeClassPtr, 100678321);
			}

			// Token: 0x0600D0DE RID: 53470 RVA: 0x00334A50 File Offset: 0x00332C50
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0DF RID: 53471 RVA: 0x00334A8C File Offset: 0x00332C8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194241, XrefRangeEnd = 194250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__5(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_3.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0E0 RID: 53472 RVA: 0x0006FD0C File Offset: 0x0006DF0C
			public __c__DisplayClass14_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F1 RID: 17393
			// (get) Token: 0x0600D0E1 RID: 53473 RVA: 0x00334AD0 File Offset: 0x00332CD0
			// (set) Token: 0x0600D0E2 RID: 53474 RVA: 0x0006FD15 File Offset: 0x0006DF15
			public unsafe GameObject cookerPic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_3.NativeFieldInfoPtr_cookerPic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_3.NativeFieldInfoPtr_cookerPic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F2 RID: 17394
			// (get) Token: 0x0600D0E3 RID: 53475 RVA: 0x00334B00 File Offset: 0x00332D00
			// (set) Token: 0x0600D0E4 RID: 53476 RVA: 0x0006FD34 File Offset: 0x0006DF34
			public unsafe Spell_Alice.__c__DisplayClass14_2 field_Public___c__DisplayClass14_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_3.NativeFieldInfoPtr_field_Public___c__DisplayClass14_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice.__c__DisplayClass14_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_3.NativeFieldInfoPtr_field_Public___c__DisplayClass14_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400863F RID: 34367
			private static readonly IntPtr NativeFieldInfoPtr_cookerPic;

			// Token: 0x04008640 RID: 34368
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass14_2_0;

			// Token: 0x04008641 RID: 34369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008642 RID: 34370
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_GameObject_0;
		}

		// Token: 0x02000AFA RID: 2810
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c__DisplayClass14_4")]
		public sealed class __c__DisplayClass14_4 : Il2CppSystem.Object
		{
			// Token: 0x0600D0E5 RID: 53477 RVA: 0x00334B30 File Offset: 0x00332D30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_4()
			{
				Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<>c__DisplayClass14_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_4>.NativeClassPtr);
				Spell_Alice.__c__DisplayClass14_4.NativeFieldInfoPtr_cooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_4>.NativeClassPtr, "cooker");
				Spell_Alice.__c__DisplayClass14_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_4>.NativeClassPtr, 100678322);
				Spell_Alice.__c__DisplayClass14_4.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_4>.NativeClassPtr, 100678323);
			}

			// Token: 0x0600D0E6 RID: 53478 RVA: 0x00334B98 File Offset: 0x00332D98
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0E7 RID: 53479 RVA: 0x00334BD4 File Offset: 0x00332DD4
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_4.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0E8 RID: 53480 RVA: 0x0006FD53 File Offset: 0x0006DF53
			public __c__DisplayClass14_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F3 RID: 17395
			// (get) Token: 0x0600D0E9 RID: 53481 RVA: 0x00334C10 File Offset: 0x00332E10
			// (set) Token: 0x0600D0EA RID: 53482 RVA: 0x0006FD5C File Offset: 0x0006DF5C
			public unsafe CookController cooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_4.NativeFieldInfoPtr_cooker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_4.NativeFieldInfoPtr_cooker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008643 RID: 34371
			private static readonly IntPtr NativeFieldInfoPtr_cooker;

			// Token: 0x04008644 RID: 34372
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008645 RID: 34373
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Vector3_0;
		}

		// Token: 0x02000AFB RID: 2811
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c__DisplayClass14_5")]
		public sealed class __c__DisplayClass14_5 : Il2CppSystem.Object
		{
			// Token: 0x0600D0EB RID: 53483 RVA: 0x00334C40 File Offset: 0x00332E40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_5()
			{
				Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<>c__DisplayClass14_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_5>.NativeClassPtr);
				Spell_Alice.__c__DisplayClass14_5.NativeFieldInfoPtr_cookerPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_5>.NativeClassPtr, "cookerPic");
				Spell_Alice.__c__DisplayClass14_5.NativeFieldInfoPtr_field_Public___c__DisplayClass14_4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_5>.NativeClassPtr, "CS$<>8__locals2");
				Spell_Alice.__c__DisplayClass14_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_5>.NativeClassPtr, 100678324);
				Spell_Alice.__c__DisplayClass14_5.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_5>.NativeClassPtr, 100678325);
			}

			// Token: 0x0600D0EC RID: 53484 RVA: 0x00334CBC File Offset: 0x00332EBC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass14_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0ED RID: 53485 RVA: 0x00334CF8 File Offset: 0x00332EF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194250, XrefRangeEnd = 194259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__7(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass14_5.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0EE RID: 53486 RVA: 0x0006FD7B File Offset: 0x0006DF7B
			public __c__DisplayClass14_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F4 RID: 17396
			// (get) Token: 0x0600D0EF RID: 53487 RVA: 0x00334D3C File Offset: 0x00332F3C
			// (set) Token: 0x0600D0F0 RID: 53488 RVA: 0x0006FD84 File Offset: 0x0006DF84
			public unsafe GameObject cookerPic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_5.NativeFieldInfoPtr_cookerPic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_5.NativeFieldInfoPtr_cookerPic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F5 RID: 17397
			// (get) Token: 0x0600D0F1 RID: 53489 RVA: 0x00334D6C File Offset: 0x00332F6C
			// (set) Token: 0x0600D0F2 RID: 53490 RVA: 0x0006FDA3 File Offset: 0x0006DFA3
			public unsafe Spell_Alice.__c__DisplayClass14_4 field_Public___c__DisplayClass14_4_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_5.NativeFieldInfoPtr_field_Public___c__DisplayClass14_4_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice.__c__DisplayClass14_4>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass14_5.NativeFieldInfoPtr_field_Public___c__DisplayClass14_4_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008646 RID: 34374
			private static readonly IntPtr NativeFieldInfoPtr_cookerPic;

			// Token: 0x04008647 RID: 34375
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass14_4_0;

			// Token: 0x04008648 RID: 34376
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008649 RID: 34377
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0;
		}

		// Token: 0x02000AFC RID: 2812
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D0F3 RID: 53491 RVA: 0x00334D9C File Offset: 0x00332F9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Alice.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c>.NativeClassPtr);
				Spell_Alice.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c>.NativeClassPtr, "<>9");
				Spell_Alice.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c>.NativeClassPtr, "<>9__14_0");
				Spell_Alice.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c>.NativeClassPtr, "<>9__15_0");
				Spell_Alice.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c>.NativeClassPtr, 100678327);
				Spell_Alice.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Internal_Void_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c>.NativeClassPtr, 100678328);
				Spell_Alice.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_0_Internal_Boolean_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c>.NativeClassPtr, 100678329);
			}

			// Token: 0x0600D0F4 RID: 53492 RVA: 0x00334E40 File Offset: 0x00333040
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0F5 RID: 53493 RVA: 0x00334E7C File Offset: 0x0033307C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194259, XrefRangeEnd = 194261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__14_0(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Internal_Void_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0F6 RID: 53494 RVA: 0x00334EC0 File Offset: 0x003330C0
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__15_0(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_0_Internal_Boolean_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D0F7 RID: 53495 RVA: 0x0006FDC2 File Offset: 0x0006DFC2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F6 RID: 17398
			// (get) Token: 0x0600D0F8 RID: 53496 RVA: 0x00334F10 File Offset: 0x00333110
			// (set) Token: 0x0600D0F9 RID: 53497 RVA: 0x0006FDCB File Offset: 0x0006DFCB
			public unsafe static Spell_Alice.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Alice.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Alice.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F7 RID: 17399
			// (get) Token: 0x0600D0FA RID: 53498 RVA: 0x00334F38 File Offset: 0x00333138
			// (set) Token: 0x0600D0FB RID: 53499 RVA: 0x0006FDDD File Offset: 0x0006DFDD
			public unsafe static Action<CookController> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Alice.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CookController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Alice.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043F8 RID: 17400
			// (get) Token: 0x0600D0FC RID: 53500 RVA: 0x00334F60 File Offset: 0x00333160
			// (set) Token: 0x0600D0FD RID: 53501 RVA: 0x0006FDEF File Offset: 0x0006DFEF
			public unsafe static Func<NormalGuest, bool> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Alice.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Alice.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400864A RID: 34378
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400864B RID: 34379
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x0400864C RID: 34380
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x0400864D RID: 34381
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400864E RID: 34382
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__14_0_Internal_Void_CookController_0;

			// Token: 0x0400864F RID: 34383
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__15_0_Internal_Boolean_NormalGuest_0;
		}

		// Token: 0x02000AFD RID: 2813
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<OnNegativeBuffExecute>d__14")]
		public sealed class _OnNegativeBuffExecute_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600D0FE RID: 53502 RVA: 0x00334F88 File Offset: 0x00333188
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__14()
			{
				Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<OnNegativeBuffExecute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr);
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>1__state");
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>2__current");
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>4__this");
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, "spellExecutionContext");
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<>8__1");
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr__cookerToBoom_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, "<cookerToBoom>5__2");
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678330);
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678331);
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678332);
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678333);
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678334);
				Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr, 100678335);
			}

			// Token: 0x0600D0FF RID: 53503 RVA: 0x003350A4 File Offset: 0x003332A4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice._OnNegativeBuffExecute_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D100 RID: 53504 RVA: 0x003350EC File Offset: 0x003332EC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D101 RID: 53505 RVA: 0x00335120 File Offset: 0x00333320
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194261, XrefRangeEnd = 194353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043FF RID: 17407
			// (get) Token: 0x0600D102 RID: 53506 RVA: 0x0033515C File Offset: 0x0033335C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D103 RID: 53507 RVA: 0x0033519C File Offset: 0x0033339C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194353, XrefRangeEnd = 194359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004400 RID: 17408
			// (get) Token: 0x0600D104 RID: 53508 RVA: 0x003351D0 File Offset: 0x003333D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnNegativeBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D105 RID: 53509 RVA: 0x0006FE01 File Offset: 0x0006E001
			public _OnNegativeBuffExecute_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043F9 RID: 17401
			// (get) Token: 0x0600D106 RID: 53510 RVA: 0x00335210 File Offset: 0x00333410
			// (set) Token: 0x0600D107 RID: 53511 RVA: 0x0006FE0A File Offset: 0x0006E00A
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043FA RID: 17402
			// (get) Token: 0x0600D108 RID: 53512 RVA: 0x00335238 File Offset: 0x00333438
			// (set) Token: 0x0600D109 RID: 53513 RVA: 0x0006FE25 File Offset: 0x0006E025
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043FB RID: 17403
			// (get) Token: 0x0600D10A RID: 53514 RVA: 0x00335268 File Offset: 0x00333468
			// (set) Token: 0x0600D10B RID: 53515 RVA: 0x0006FE44 File Offset: 0x0006E044
			public unsafe Spell_Alice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043FC RID: 17404
			// (get) Token: 0x0600D10C RID: 53516 RVA: 0x00335298 File Offset: 0x00333498
			// (set) Token: 0x0600D10D RID: 53517 RVA: 0x0006FE63 File Offset: 0x0006E063
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043FD RID: 17405
			// (get) Token: 0x0600D10E RID: 53518 RVA: 0x003352C8 File Offset: 0x003334C8
			// (set) Token: 0x0600D10F RID: 53519 RVA: 0x0006FE82 File Offset: 0x0006E082
			public unsafe Spell_Alice.__c__DisplayClass14_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice.__c__DisplayClass14_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043FE RID: 17406
			// (get) Token: 0x0600D110 RID: 53520 RVA: 0x003352F8 File Offset: 0x003334F8
			// (set) Token: 0x0600D111 RID: 53521 RVA: 0x0006FEA1 File Offset: 0x0006E0A1
			public unsafe Il2CppStructArray<int> _cookerToBoom_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr__cookerToBoom_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnNegativeBuffExecute_d__14.NativeFieldInfoPtr__cookerToBoom_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008650 RID: 34384
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008651 RID: 34385
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008652 RID: 34386
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008653 RID: 34387
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008654 RID: 34388
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008655 RID: 34389
			private static readonly IntPtr NativeFieldInfoPtr__cookerToBoom_5__2;

			// Token: 0x04008656 RID: 34390
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008657 RID: 34391
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008658 RID: 34392
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008659 RID: 34393
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400865A RID: 34394
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400865B RID: 34395
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AFE RID: 2814
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c__DisplayClass15_0")]
		public new sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D112 RID: 53522 RVA: 0x00335328 File Offset: 0x00333528
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr);
				Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_aliceHand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr, "aliceHand");
				Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_dollEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr, "dollEnd");
				Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_allNGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr, "allNGuests");
				Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_guestManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr, "guestManager");
				Spell_Alice.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr, 100678336);
				Spell_Alice.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_GameObject_UIElementCluster_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr, 100678337);
			}

			// Token: 0x0600D113 RID: 53523 RVA: 0x003353E0 File Offset: 0x003335E0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D114 RID: 53524 RVA: 0x0033541C File Offset: 0x0033361C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194449, XrefRangeEnd = 194456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_GameObject_UIElementCluster_Int32_PDM_0(GameObject doll, UIElementCluster uiElementCluster, int seat)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(doll);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seat;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_GameObject_UIElementCluster_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D115 RID: 53525 RVA: 0x0006FEC0 File Offset: 0x0006E0C0
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004401 RID: 17409
			// (get) Token: 0x0600D116 RID: 53526 RVA: 0x0033548C File Offset: 0x0033368C
			// (set) Token: 0x0600D117 RID: 53527 RVA: 0x0006FEC9 File Offset: 0x0006E0C9
			public unsafe Spell_Alice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004402 RID: 17410
			// (get) Token: 0x0600D118 RID: 53528 RVA: 0x003354BC File Offset: 0x003336BC
			// (set) Token: 0x0600D119 RID: 53529 RVA: 0x0006FEE8 File Offset: 0x0006E0E8
			public unsafe Vector3 aliceHand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_aliceHand);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_aliceHand)) = value;
				}
			}

			// Token: 0x17004403 RID: 17411
			// (get) Token: 0x0600D11A RID: 53530 RVA: 0x003354E4 File Offset: 0x003336E4
			// (set) Token: 0x0600D11B RID: 53531 RVA: 0x0006FF03 File Offset: 0x0006E103
			public unsafe bool dollEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_dollEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_dollEnd)) = value;
				}
			}

			// Token: 0x17004404 RID: 17412
			// (get) Token: 0x0600D11C RID: 53532 RVA: 0x0033550C File Offset: 0x0033370C
			// (set) Token: 0x0600D11D RID: 53533 RVA: 0x0006FF1E File Offset: 0x0006E11E
			public unsafe List<NormalGuest> allNGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_allNGuests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NormalGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_allNGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004405 RID: 17413
			// (get) Token: 0x0600D11E RID: 53534 RVA: 0x0033553C File Offset: 0x0033373C
			// (set) Token: 0x0600D11F RID: 53535 RVA: 0x0006FF3D File Offset: 0x0006E13D
			public unsafe GuestsManager guestManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_guestManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.NativeFieldInfoPtr_guestManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400865C RID: 34396
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400865D RID: 34397
			private static readonly IntPtr NativeFieldInfoPtr_aliceHand;

			// Token: 0x0400865E RID: 34398
			private static readonly IntPtr NativeFieldInfoPtr_dollEnd;

			// Token: 0x0400865F RID: 34399
			private static readonly IntPtr NativeFieldInfoPtr_allNGuests;

			// Token: 0x04008660 RID: 34400
			private static readonly IntPtr NativeFieldInfoPtr_guestManager;

			// Token: 0x04008661 RID: 34401
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008662 RID: 34402
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_GameObject_UIElementCluster_Int32_PDM_0;

			// Token: 0x02001021 RID: 4129
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c__DisplayClass15_0+<<OnPositiveBuffExecute>g__SetLinenear|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique : Il2CppSystem.Object
			{
				// Token: 0x06011A9E RID: 72350 RVA: 0x0040C888 File Offset: 0x0040AA88
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique()
				{
					Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__SetLinenear|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr);
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "<>1__state");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "<>2__current");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr_uiElementCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "uiElementCluster");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "<>4__this");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr_doll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "doll");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr_seat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "seat");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__lineRenderer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "<lineRenderer>5__2");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__guest1_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "<guest1>5__3");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__guest2_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "<guest2>5__4");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__dollSprite_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, "<dollSprite>5__5");
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, 100678338);
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, 100678339);
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, 100678340);
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, 100678341);
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, 100678342);
					Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr, 100678343);
				}

				// Token: 0x06011A9F RID: 72351 RVA: 0x0040C9F4 File Offset: 0x0040ABF4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011AA0 RID: 72352 RVA: 0x0040CA3C File Offset: 0x0040AC3C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011AA1 RID: 72353 RVA: 0x0040CA70 File Offset: 0x0040AC70
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194359, XrefRangeEnd = 194443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BEB RID: 23531
				// (get) Token: 0x06011AA2 RID: 72354 RVA: 0x0040CAAC File Offset: 0x0040ACAC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011AA3 RID: 72355 RVA: 0x0040CAEC File Offset: 0x0040ACEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194443, XrefRangeEnd = 194449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BEC RID: 23532
				// (get) Token: 0x06011AA4 RID: 72356 RVA: 0x0040CB20 File Offset: 0x0040AD20
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011AA5 RID: 72357 RVA: 0x00099883 File Offset: 0x00097A83
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BE1 RID: 23521
				// (get) Token: 0x06011AA6 RID: 72358 RVA: 0x0040CB60 File Offset: 0x0040AD60
				// (set) Token: 0x06011AA7 RID: 72359 RVA: 0x0009988C File Offset: 0x00097A8C
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BE2 RID: 23522
				// (get) Token: 0x06011AA8 RID: 72360 RVA: 0x0040CB88 File Offset: 0x0040AD88
				// (set) Token: 0x06011AA9 RID: 72361 RVA: 0x000998A7 File Offset: 0x00097AA7
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BE3 RID: 23523
				// (get) Token: 0x06011AAA RID: 72362 RVA: 0x0040CBB8 File Offset: 0x0040ADB8
				// (set) Token: 0x06011AAB RID: 72363 RVA: 0x000998C6 File Offset: 0x00097AC6
				public unsafe UIElementCluster uiElementCluster
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr_uiElementCluster);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr_uiElementCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BE4 RID: 23524
				// (get) Token: 0x06011AAC RID: 72364 RVA: 0x0040CBE8 File Offset: 0x0040ADE8
				// (set) Token: 0x06011AAD RID: 72365 RVA: 0x000998E5 File Offset: 0x00097AE5
				public unsafe Spell_Alice.__c__DisplayClass15_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice.__c__DisplayClass15_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BE5 RID: 23525
				// (get) Token: 0x06011AAE RID: 72366 RVA: 0x0040CC18 File Offset: 0x0040AE18
				// (set) Token: 0x06011AAF RID: 72367 RVA: 0x00099904 File Offset: 0x00097B04
				public unsafe GameObject doll
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr_doll);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr_doll), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BE6 RID: 23526
				// (get) Token: 0x06011AB0 RID: 72368 RVA: 0x0040CC48 File Offset: 0x0040AE48
				// (set) Token: 0x06011AB1 RID: 72369 RVA: 0x00099923 File Offset: 0x00097B23
				public unsafe int seat
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr_seat);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr_seat)) = value;
					}
				}

				// Token: 0x17005BE7 RID: 23527
				// (get) Token: 0x06011AB2 RID: 72370 RVA: 0x0040CC70 File Offset: 0x0040AE70
				// (set) Token: 0x06011AB3 RID: 72371 RVA: 0x0009993E File Offset: 0x00097B3E
				public unsafe LineRenderer _lineRenderer_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__lineRenderer_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<LineRenderer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__lineRenderer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BE8 RID: 23528
				// (get) Token: 0x06011AB4 RID: 72372 RVA: 0x0040CCA0 File Offset: 0x0040AEA0
				// (set) Token: 0x06011AB5 RID: 72373 RVA: 0x0009995D File Offset: 0x00097B5D
				public unsafe NormalGuest _guest1_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__guest1_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__guest1_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BE9 RID: 23529
				// (get) Token: 0x06011AB6 RID: 72374 RVA: 0x0040CCD0 File Offset: 0x0040AED0
				// (set) Token: 0x06011AB7 RID: 72375 RVA: 0x0009997C File Offset: 0x00097B7C
				public unsafe NormalGuest _guest2_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__guest2_5__4);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<NormalGuest>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__guest2_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BEA RID: 23530
				// (get) Token: 0x06011AB8 RID: 72376 RVA: 0x0040CD00 File Offset: 0x0040AF00
				// (set) Token: 0x06011AB9 RID: 72377 RVA: 0x0009999B File Offset: 0x00097B9B
				public unsafe SpriteRenderer _dollSprite_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__dollSprite_5__5);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObUIuiGadoseInLiNoUnique.NativeFieldInfoPtr__dollSprite_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B292 RID: 45714
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B293 RID: 45715
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B294 RID: 45716
				private static readonly IntPtr NativeFieldInfoPtr_uiElementCluster;

				// Token: 0x0400B295 RID: 45717
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B296 RID: 45718
				private static readonly IntPtr NativeFieldInfoPtr_doll;

				// Token: 0x0400B297 RID: 45719
				private static readonly IntPtr NativeFieldInfoPtr_seat;

				// Token: 0x0400B298 RID: 45720
				private static readonly IntPtr NativeFieldInfoPtr__lineRenderer_5__2;

				// Token: 0x0400B299 RID: 45721
				private static readonly IntPtr NativeFieldInfoPtr__guest1_5__3;

				// Token: 0x0400B29A RID: 45722
				private static readonly IntPtr NativeFieldInfoPtr__guest2_5__4;

				// Token: 0x0400B29B RID: 45723
				private static readonly IntPtr NativeFieldInfoPtr__dollSprite_5__5;

				// Token: 0x0400B29C RID: 45724
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B29D RID: 45725
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B29E RID: 45726
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B29F RID: 45727
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B2A0 RID: 45728
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2A1 RID: 45729
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AFF RID: 2815
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<>c__DisplayClass15_1")]
		public sealed class __c__DisplayClass15_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D120 RID: 53536 RVA: 0x0033556C File Offset: 0x0033376C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_1()
			{
				Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<>c__DisplayClass15_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_1>.NativeClassPtr);
				Spell_Alice.__c__DisplayClass15_1.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_1>.NativeClassPtr, "targetPosition");
				Spell_Alice.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_1>.NativeClassPtr, 100678344);
				Spell_Alice.__c__DisplayClass15_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_1>.NativeClassPtr, 100678345);
			}

			// Token: 0x0600D121 RID: 53537 RVA: 0x003355D4 File Offset: 0x003337D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.__c__DisplayClass15_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D122 RID: 53538 RVA: 0x00335610 File Offset: 0x00333810
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.__c__DisplayClass15_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D123 RID: 53539 RVA: 0x0006FF5C File Offset: 0x0006E15C
			public __c__DisplayClass15_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004406 RID: 17414
			// (get) Token: 0x0600D124 RID: 53540 RVA: 0x0033564C File Offset: 0x0033384C
			// (set) Token: 0x0600D125 RID: 53541 RVA: 0x0006FF65 File Offset: 0x0006E165
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_1.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.__c__DisplayClass15_1.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x04008663 RID: 34403
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x04008664 RID: 34404
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008665 RID: 34405
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Vector3_0;
		}

		// Token: 0x02000B00 RID: 2816
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<OnPositiveBuffExecute>d__15")]
		public sealed class _OnPositiveBuffExecute_d__15 : Il2CppSystem.Object
		{
			// Token: 0x0600D126 RID: 53542 RVA: 0x00335674 File Offset: 0x00333874
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__15()
			{
				Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<OnPositiveBuffExecute>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr);
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>1__state");
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>2__current");
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>4__this");
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, "spellExecutionContext");
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, "<>8__1");
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100678346);
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100678347);
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100678348);
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100678349);
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100678350);
				Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr, 100678351);
			}

			// Token: 0x0600D127 RID: 53543 RVA: 0x0033577C File Offset: 0x0033397C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice._OnPositiveBuffExecute_d__15>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D128 RID: 53544 RVA: 0x003357C4 File Offset: 0x003339C4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D129 RID: 53545 RVA: 0x003357F8 File Offset: 0x003339F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194456, XrefRangeEnd = 194486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700440C RID: 17420
			// (get) Token: 0x0600D12A RID: 53546 RVA: 0x00335834 File Offset: 0x00333A34
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D12B RID: 53547 RVA: 0x00335874 File Offset: 0x00333A74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194486, XrefRangeEnd = 194492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700440D RID: 17421
			// (get) Token: 0x0600D12C RID: 53548 RVA: 0x003358A8 File Offset: 0x00333AA8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice._OnPositiveBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D12D RID: 53549 RVA: 0x0006FF80 File Offset: 0x0006E180
			public _OnPositiveBuffExecute_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004407 RID: 17415
			// (get) Token: 0x0600D12E RID: 53550 RVA: 0x003358E8 File Offset: 0x00333AE8
			// (set) Token: 0x0600D12F RID: 53551 RVA: 0x0006FF89 File Offset: 0x0006E189
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004408 RID: 17416
			// (get) Token: 0x0600D130 RID: 53552 RVA: 0x00335910 File Offset: 0x00333B10
			// (set) Token: 0x0600D131 RID: 53553 RVA: 0x0006FFA4 File Offset: 0x0006E1A4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004409 RID: 17417
			// (get) Token: 0x0600D132 RID: 53554 RVA: 0x00335940 File Offset: 0x00333B40
			// (set) Token: 0x0600D133 RID: 53555 RVA: 0x0006FFC3 File Offset: 0x0006E1C3
			public unsafe Spell_Alice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700440A RID: 17418
			// (get) Token: 0x0600D134 RID: 53556 RVA: 0x00335970 File Offset: 0x00333B70
			// (set) Token: 0x0600D135 RID: 53557 RVA: 0x0006FFE2 File Offset: 0x0006E1E2
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700440B RID: 17419
			// (get) Token: 0x0600D136 RID: 53558 RVA: 0x003359A0 File Offset: 0x00333BA0
			// (set) Token: 0x0600D137 RID: 53559 RVA: 0x00070001 File Offset: 0x0006E201
			public unsafe Spell_Alice.__c__DisplayClass15_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Alice.__c__DisplayClass15_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice._OnPositiveBuffExecute_d__15.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008666 RID: 34406
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008667 RID: 34407
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008668 RID: 34408
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008669 RID: 34409
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400866A RID: 34410
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400866B RID: 34411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400866C RID: 34412
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400866D RID: 34413
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400866E RID: 34414
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400866F RID: 34415
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008670 RID: 34416
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B01 RID: 2817
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Alice+<<OnNegativeBuffExecute>g__ResetVisual|14_2>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600D138 RID: 53560 RVA: 0x003359D0 File Offset: 0x00333BD0
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique()
			{
				Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Alice>.NativeClassPtr, "<<OnNegativeBuffExecute>g__ResetVisual|14_2>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr);
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, "<>1__state");
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, "<>2__current");
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr_delay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, "delay");
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr_cookController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, "cookController");
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, 100678352);
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, 100678353);
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, 100678354);
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, 100678355);
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, 100678356);
				Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr, 100678357);
			}

			// Token: 0x0600D139 RID: 53561 RVA: 0x00335AC4 File Offset: 0x00333CC4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D13A RID: 53562 RVA: 0x00335B0C File Offset: 0x00333D0C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D13B RID: 53563 RVA: 0x00335B40 File Offset: 0x00333D40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194492, XrefRangeEnd = 194497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004412 RID: 17426
			// (get) Token: 0x0600D13C RID: 53564 RVA: 0x00335B7C File Offset: 0x00333D7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D13D RID: 53565 RVA: 0x00335BBC File Offset: 0x00333DBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194497, XrefRangeEnd = 194503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004413 RID: 17427
			// (get) Token: 0x0600D13E RID: 53566 RVA: 0x00335BF0 File Offset: 0x00333DF0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D13F RID: 53567 RVA: 0x00070020 File Offset: 0x0006E220
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700440E RID: 17422
			// (get) Token: 0x0600D140 RID: 53568 RVA: 0x00335C30 File Offset: 0x00333E30
			// (set) Token: 0x0600D141 RID: 53569 RVA: 0x00070029 File Offset: 0x0006E229
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700440F RID: 17423
			// (get) Token: 0x0600D142 RID: 53570 RVA: 0x00335C58 File Offset: 0x00333E58
			// (set) Token: 0x0600D143 RID: 53571 RVA: 0x00070044 File Offset: 0x0006E244
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004410 RID: 17424
			// (get) Token: 0x0600D144 RID: 53572 RVA: 0x00335C88 File Offset: 0x00333E88
			// (set) Token: 0x0600D145 RID: 53573 RVA: 0x00070063 File Offset: 0x0006E263
			public unsafe float delay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr_delay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr_delay)) = value;
				}
			}

			// Token: 0x17004411 RID: 17425
			// (get) Token: 0x0600D146 RID: 53574 RVA: 0x00335CB0 File Offset: 0x00333EB0
			// (set) Token: 0x0600D147 RID: 53575 RVA: 0x0007007E File Offset: 0x0006E27E
			public unsafe CookController cookController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr_cookController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Alice.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSideCocoObObUnique.NativeFieldInfoPtr_cookController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008671 RID: 34417
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008672 RID: 34418
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008673 RID: 34419
			private static readonly IntPtr NativeFieldInfoPtr_delay;

			// Token: 0x04008674 RID: 34420
			private static readonly IntPtr NativeFieldInfoPtr_cookController;

			// Token: 0x04008675 RID: 34421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008676 RID: 34422
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008677 RID: 34423
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008678 RID: 34424
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008679 RID: 34425
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400867A RID: 34426
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
