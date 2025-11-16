using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200025D RID: 605
	public class Spell_Akyuu : SpellBase
	{
		// Token: 0x06004A5E RID: 19038 RVA: 0x001A1E8C File Offset: 0x001A008C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Akyuu()
		{
			Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Akyuu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr);
			Spell_Akyuu.NativeFieldInfoPtr_overrideGuestMoodMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "overrideGuestMoodMin");
			Spell_Akyuu.NativeFieldInfoPtr_overrideGuestMoodMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "overrideGuestMoodMax");
			Spell_Akyuu.NativeFieldInfoPtr_curtainDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "curtainDuration");
			Spell_Akyuu.NativeFieldInfoPtr_giveItemID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "giveItemID");
			Spell_Akyuu.NativeFieldInfoPtr_giveItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "giveItem");
			Spell_Akyuu.NativeFieldInfoPtr_rewardItemDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "rewardItemDuration");
			Spell_Akyuu.NativeFieldInfoPtr_rewardEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "rewardEffectDuration");
			Spell_Akyuu.NativeFieldInfoPtr_rewardDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "rewardDelay");
			Spell_Akyuu.NativeFieldInfoPtr_negativeEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "negativeEffectDuration");
			Spell_Akyuu.NativeFieldInfoPtr_rewardEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "rewardEffect");
			Spell_Akyuu.NativeFieldInfoPtr_punishmentPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "punishmentPic");
			Spell_Akyuu.NativeFieldInfoPtr_passionCameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "passionCameraShakeAmplitude");
			Spell_Akyuu.NativeFieldInfoPtr_passionCameraShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "passionCameraShakeDuration");
			Spell_Akyuu.NativeFieldInfoPtr_passionCameraShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "passionCameraShakeFadeDuration");
			Spell_Akyuu.NativeFieldInfoPtr_rewardAppear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "rewardAppear");
			Spell_Akyuu.NativeFieldInfoPtr_passionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "passionDuration");
			Spell_Akyuu.NativeFieldInfoPtr_crimeEvidenceTXT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "crimeEvidenceTXT");
			Spell_Akyuu.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, 100678276);
			Spell_Akyuu.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, 100678277);
			Spell_Akyuu.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, 100678278);
			Spell_Akyuu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, 100678279);
			Spell_Akyuu.NativeMethodInfoPtr_Method_Internal_Static_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, 100678280);
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x001A2074 File Offset: 0x001A0274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194163, XrefRangeEnd = 194165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Akyuu.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x001A20B8 File Offset: 0x001A02B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194165, XrefRangeEnd = 194170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Akyuu.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x001A2114 File Offset: 0x001A0314
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194170, XrefRangeEnd = 194176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Akyuu.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x001A2170 File Offset: 0x001A0370
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Akyuu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x001A21AC File Offset: 0x001A03AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194176, XrefRangeEnd = 194177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector3 Method_Internal_Static_Vector3_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.NativeMethodInfoPtr_Method_Internal_Static_Vector3_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x00025EE6 File Offset: 0x000240E6
		public Spell_Akyuu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170018E5 RID: 6373
		// (get) Token: 0x06004A65 RID: 19045 RVA: 0x001A21DC File Offset: 0x001A03DC
		// (set) Token: 0x06004A66 RID: 19046 RVA: 0x00025EEF File Offset: 0x000240EF
		public unsafe float overrideGuestMoodMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_overrideGuestMoodMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_overrideGuestMoodMin)) = value;
			}
		}

		// Token: 0x170018E6 RID: 6374
		// (get) Token: 0x06004A67 RID: 19047 RVA: 0x001A2204 File Offset: 0x001A0404
		// (set) Token: 0x06004A68 RID: 19048 RVA: 0x00025F0A File Offset: 0x0002410A
		public unsafe float overrideGuestMoodMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_overrideGuestMoodMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_overrideGuestMoodMax)) = value;
			}
		}

		// Token: 0x170018E7 RID: 6375
		// (get) Token: 0x06004A69 RID: 19049 RVA: 0x001A222C File Offset: 0x001A042C
		// (set) Token: 0x06004A6A RID: 19050 RVA: 0x00025F25 File Offset: 0x00024125
		public unsafe int curtainDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_curtainDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_curtainDuration)) = value;
			}
		}

		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x06004A6B RID: 19051 RVA: 0x001A2254 File Offset: 0x001A0454
		// (set) Token: 0x06004A6C RID: 19052 RVA: 0x00025F40 File Offset: 0x00024140
		public unsafe int giveItemID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_giveItemID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_giveItemID)) = value;
			}
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06004A6D RID: 19053 RVA: 0x001A227C File Offset: 0x001A047C
		// (set) Token: 0x06004A6E RID: 19054 RVA: 0x00025F5B File Offset: 0x0002415B
		public unsafe GameObject giveItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_giveItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_giveItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06004A6F RID: 19055 RVA: 0x001A22AC File Offset: 0x001A04AC
		// (set) Token: 0x06004A70 RID: 19056 RVA: 0x00025F7A File Offset: 0x0002417A
		public unsafe float rewardItemDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardItemDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardItemDuration)) = value;
			}
		}

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06004A71 RID: 19057 RVA: 0x001A22D4 File Offset: 0x001A04D4
		// (set) Token: 0x06004A72 RID: 19058 RVA: 0x00025F95 File Offset: 0x00024195
		public unsafe float rewardEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardEffectDuration)) = value;
			}
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06004A73 RID: 19059 RVA: 0x001A22FC File Offset: 0x001A04FC
		// (set) Token: 0x06004A74 RID: 19060 RVA: 0x00025FB0 File Offset: 0x000241B0
		public unsafe float rewardDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardDelay)) = value;
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06004A75 RID: 19061 RVA: 0x001A2324 File Offset: 0x001A0524
		// (set) Token: 0x06004A76 RID: 19062 RVA: 0x00025FCB File Offset: 0x000241CB
		public unsafe float negativeEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_negativeEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_negativeEffectDuration)) = value;
			}
		}

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x06004A77 RID: 19063 RVA: 0x001A234C File Offset: 0x001A054C
		// (set) Token: 0x06004A78 RID: 19064 RVA: 0x00025FE6 File Offset: 0x000241E6
		public unsafe GameObject rewardEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06004A79 RID: 19065 RVA: 0x001A237C File Offset: 0x001A057C
		// (set) Token: 0x06004A7A RID: 19066 RVA: 0x00026005 File Offset: 0x00024205
		public unsafe GameObject punishmentPic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_punishmentPic);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_punishmentPic), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06004A7B RID: 19067 RVA: 0x001A23AC File Offset: 0x001A05AC
		// (set) Token: 0x06004A7C RID: 19068 RVA: 0x00026024 File Offset: 0x00024224
		public unsafe float passionCameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_passionCameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_passionCameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x001A23D4 File Offset: 0x001A05D4
		// (set) Token: 0x06004A7E RID: 19070 RVA: 0x0002603F File Offset: 0x0002423F
		public unsafe float passionCameraShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_passionCameraShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_passionCameraShakeDuration)) = value;
			}
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06004A7F RID: 19071 RVA: 0x001A23FC File Offset: 0x001A05FC
		// (set) Token: 0x06004A80 RID: 19072 RVA: 0x0002605A File Offset: 0x0002425A
		public unsafe float passionCameraShakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_passionCameraShakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_passionCameraShakeFadeDuration)) = value;
			}
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06004A81 RID: 19073 RVA: 0x001A2424 File Offset: 0x001A0624
		// (set) Token: 0x06004A82 RID: 19074 RVA: 0x00026075 File Offset: 0x00024275
		public unsafe AudioClip rewardAppear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardAppear);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_rewardAppear), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x06004A83 RID: 19075 RVA: 0x001A2454 File Offset: 0x001A0654
		// (set) Token: 0x06004A84 RID: 19076 RVA: 0x00026094 File Offset: 0x00024294
		public unsafe float passionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_passionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_passionDuration)) = value;
			}
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x001A247C File Offset: 0x001A067C
		// (set) Token: 0x06004A86 RID: 19078 RVA: 0x000260AF File Offset: 0x000242AF
		public unsafe MultiLanguageTextMesh.MultiLanguageTextAsset crimeEvidenceTXT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_crimeEvidenceTXT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageTextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.NativeFieldInfoPtr_crimeEvidenceTXT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400332C RID: 13100
		private static readonly IntPtr NativeFieldInfoPtr_overrideGuestMoodMin;

		// Token: 0x0400332D RID: 13101
		private static readonly IntPtr NativeFieldInfoPtr_overrideGuestMoodMax;

		// Token: 0x0400332E RID: 13102
		private static readonly IntPtr NativeFieldInfoPtr_curtainDuration;

		// Token: 0x0400332F RID: 13103
		private static readonly IntPtr NativeFieldInfoPtr_giveItemID;

		// Token: 0x04003330 RID: 13104
		private static readonly IntPtr NativeFieldInfoPtr_giveItem;

		// Token: 0x04003331 RID: 13105
		private static readonly IntPtr NativeFieldInfoPtr_rewardItemDuration;

		// Token: 0x04003332 RID: 13106
		private static readonly IntPtr NativeFieldInfoPtr_rewardEffectDuration;

		// Token: 0x04003333 RID: 13107
		private static readonly IntPtr NativeFieldInfoPtr_rewardDelay;

		// Token: 0x04003334 RID: 13108
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectDuration;

		// Token: 0x04003335 RID: 13109
		private static readonly IntPtr NativeFieldInfoPtr_rewardEffect;

		// Token: 0x04003336 RID: 13110
		private static readonly IntPtr NativeFieldInfoPtr_punishmentPic;

		// Token: 0x04003337 RID: 13111
		private static readonly IntPtr NativeFieldInfoPtr_passionCameraShakeAmplitude;

		// Token: 0x04003338 RID: 13112
		private static readonly IntPtr NativeFieldInfoPtr_passionCameraShakeDuration;

		// Token: 0x04003339 RID: 13113
		private static readonly IntPtr NativeFieldInfoPtr_passionCameraShakeFadeDuration;

		// Token: 0x0400333A RID: 13114
		private static readonly IntPtr NativeFieldInfoPtr_rewardAppear;

		// Token: 0x0400333B RID: 13115
		private static readonly IntPtr NativeFieldInfoPtr_passionDuration;

		// Token: 0x0400333C RID: 13116
		private static readonly IntPtr NativeFieldInfoPtr_crimeEvidenceTXT;

		// Token: 0x0400333D RID: 13117
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400333E RID: 13118
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400333F RID: 13119
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003340 RID: 13120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003341 RID: 13121
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Vector3_PDM_0;

		// Token: 0x02000AF1 RID: 2801
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Akyuu+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D08C RID: 53388 RVA: 0x00333AC0 File Offset: 0x00331CC0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass18_0>.NativeClassPtr);
				Spell_Akyuu.__c__DisplayClass18_0.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass18_0>.NativeClassPtr, "text");
				Spell_Akyuu.__c__DisplayClass18_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass18_0>.NativeClassPtr, "index");
				Spell_Akyuu.__c__DisplayClass18_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass18_0>.NativeClassPtr, "<>9__2");
				Spell_Akyuu.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass18_0>.NativeClassPtr, 100678281);
				Spell_Akyuu.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass18_0>.NativeClassPtr, 100678282);
				Spell_Akyuu.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass18_0>.NativeClassPtr, 100678283);
			}

			// Token: 0x0600D08D RID: 53389 RVA: 0x00333B64 File Offset: 0x00331D64
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass18_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D08E RID: 53390 RVA: 0x00333BA0 File Offset: 0x00331DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194023, XrefRangeEnd = 194037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(GameObject xa)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xa);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D08F RID: 53391 RVA: 0x00333BE4 File Offset: 0x00331DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194037, XrefRangeEnd = 194039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass18_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D090 RID: 53392 RVA: 0x0006FA8E File Offset: 0x0006DC8E
			public __c__DisplayClass18_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043DA RID: 17370
			// (get) Token: 0x0600D091 RID: 53393 RVA: 0x00333C28 File Offset: 0x00331E28
			// (set) Token: 0x0600D092 RID: 53394 RVA: 0x0006FA97 File Offset: 0x0006DC97
			public unsafe Il2CppStringArray text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass18_0.NativeFieldInfoPtr_text);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass18_0.NativeFieldInfoPtr_text), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043DB RID: 17371
			// (get) Token: 0x0600D093 RID: 53395 RVA: 0x00333C58 File Offset: 0x00331E58
			// (set) Token: 0x0600D094 RID: 53396 RVA: 0x0006FAB6 File Offset: 0x0006DCB6
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass18_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass18_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x170043DC RID: 17372
			// (get) Token: 0x0600D095 RID: 53397 RVA: 0x00333C80 File Offset: 0x00331E80
			// (set) Token: 0x0600D096 RID: 53398 RVA: 0x0006FAD1 File Offset: 0x0006DCD1
			public unsafe Action<TextMeshProUGUI> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass18_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass18_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008611 RID: 34321
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04008612 RID: 34322
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04008613 RID: 34323
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x04008614 RID: 34324
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008615 RID: 34325
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0;

			// Token: 0x04008616 RID: 34326
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000AF2 RID: 2802
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Akyuu+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D097 RID: 53399 RVA: 0x00333CB0 File Offset: 0x00331EB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Akyuu.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Akyuu.__c>.NativeClassPtr);
				Spell_Akyuu.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c>.NativeClassPtr, "<>9");
				Spell_Akyuu.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c>.NativeClassPtr, "<>9__18_0");
				Spell_Akyuu.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c>.NativeClassPtr, 100678285);
				Spell_Akyuu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_0_Internal_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c>.NativeClassPtr, 100678286);
			}

			// Token: 0x0600D098 RID: 53400 RVA: 0x00333D2C File Offset: 0x00331F2C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Akyuu.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D099 RID: 53401 RVA: 0x00333D68 File Offset: 0x00331F68
			[CallerCount(0)]
			public unsafe string _OnNegativeBuffExecute_b__18_0(Il2CppStringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_0_Internal_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D09A RID: 53402 RVA: 0x0006FAF0 File Offset: 0x0006DCF0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043DD RID: 17373
			// (get) Token: 0x0600D09B RID: 53403 RVA: 0x00333DB0 File Offset: 0x00331FB0
			// (set) Token: 0x0600D09C RID: 53404 RVA: 0x0006FAF9 File Offset: 0x0006DCF9
			public unsafe static Spell_Akyuu.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Akyuu.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Akyuu.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Akyuu.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043DE RID: 17374
			// (get) Token: 0x0600D09D RID: 53405 RVA: 0x00333DD8 File Offset: 0x00331FD8
			// (set) Token: 0x0600D09E RID: 53406 RVA: 0x0006FB0B File Offset: 0x0006DD0B
			public unsafe static Func<Il2CppStringArray, string> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Akyuu.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppStringArray, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Akyuu.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008617 RID: 34327
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008618 RID: 34328
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x04008619 RID: 34329
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400861A RID: 34330
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__18_0_Internal_String_Il2CppStringArray_0;
		}

		// Token: 0x02000AF3 RID: 2803
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Akyuu+<OnNegativeBuffExecute>d__18")]
		public sealed class _OnNegativeBuffExecute_d__18 : Il2CppSystem.Object
		{
			// Token: 0x0600D09F RID: 53407 RVA: 0x00333E00 File Offset: 0x00332000
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__18()
			{
				Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "<OnNegativeBuffExecute>d__18");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr);
				Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>1__state");
				Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>2__current");
				Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr, "<>4__this");
				Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100678287);
				Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100678288);
				Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100678289);
				Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100678290);
				Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100678291);
				Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr, 100678292);
			}

			// Token: 0x0600D0A0 RID: 53408 RVA: 0x00333EE0 File Offset: 0x003320E0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__18(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Akyuu._OnNegativeBuffExecute_d__18>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0A1 RID: 53409 RVA: 0x00333F28 File Offset: 0x00332128
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0A2 RID: 53410 RVA: 0x00333F5C File Offset: 0x0033215C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194039, XrefRangeEnd = 194105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043E2 RID: 17378
			// (get) Token: 0x0600D0A3 RID: 53411 RVA: 0x00333F98 File Offset: 0x00332198
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D0A4 RID: 53412 RVA: 0x00333FD8 File Offset: 0x003321D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194105, XrefRangeEnd = 194111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043E3 RID: 17379
			// (get) Token: 0x0600D0A5 RID: 53413 RVA: 0x0033400C File Offset: 0x0033220C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D0A6 RID: 53414 RVA: 0x0006FB1D File Offset: 0x0006DD1D
			public _OnNegativeBuffExecute_d__18(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043DF RID: 17375
			// (get) Token: 0x0600D0A7 RID: 53415 RVA: 0x0033404C File Offset: 0x0033224C
			// (set) Token: 0x0600D0A8 RID: 53416 RVA: 0x0006FB26 File Offset: 0x0006DD26
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043E0 RID: 17376
			// (get) Token: 0x0600D0A9 RID: 53417 RVA: 0x00334074 File Offset: 0x00332274
			// (set) Token: 0x0600D0AA RID: 53418 RVA: 0x0006FB41 File Offset: 0x0006DD41
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E1 RID: 17377
			// (get) Token: 0x0600D0AB RID: 53419 RVA: 0x003340A4 File Offset: 0x003322A4
			// (set) Token: 0x0600D0AC RID: 53420 RVA: 0x0006FB60 File Offset: 0x0006DD60
			public unsafe Spell_Akyuu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Akyuu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnNegativeBuffExecute_d__18.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400861B RID: 34331
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400861C RID: 34332
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400861D RID: 34333
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400861E RID: 34334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400861F RID: 34335
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008620 RID: 34336
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008621 RID: 34337
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008622 RID: 34338
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008623 RID: 34339
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000AF4 RID: 2804
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Akyuu+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0AD RID: 53421 RVA: 0x003340D4 File Offset: 0x003322D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0>.NativeClassPtr);
				Spell_Akyuu.__c__DisplayClass19_0.NativeFieldInfoPtr_characterStartPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0>.NativeClassPtr, "characterStartPosition");
				Spell_Akyuu.__c__DisplayClass19_0.NativeFieldInfoPtr_giveItemObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0>.NativeClassPtr, "giveItemObject");
				Spell_Akyuu.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0>.NativeClassPtr, 100678293);
				Spell_Akyuu.__c__DisplayClass19_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0>.NativeClassPtr, 100678294);
				Spell_Akyuu.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_GameObject_Action_1_GameObject_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0>.NativeClassPtr, 100678295);
			}

			// Token: 0x0600D0AE RID: 53422 RVA: 0x00334164 File Offset: 0x00332364
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0AF RID: 53423 RVA: 0x003341A0 File Offset: 0x003323A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194129, XrefRangeEnd = 194134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass19_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0B0 RID: 53424 RVA: 0x003341E4 File Offset: 0x003323E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194134, XrefRangeEnd = 194141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_GameObject_Action_1_GameObject_Single_PDM_0(GameObject parent, Action<GameObject> objectProcessingCallback, float duration)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectProcessingCallback);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass19_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_GameObject_Action_1_GameObject_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D0B1 RID: 53425 RVA: 0x0006FB7F File Offset: 0x0006DD7F
			public __c__DisplayClass19_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043E4 RID: 17380
			// (get) Token: 0x0600D0B2 RID: 53426 RVA: 0x00334254 File Offset: 0x00332454
			// (set) Token: 0x0600D0B3 RID: 53427 RVA: 0x0006FB88 File Offset: 0x0006DD88
			public Nullable<Vector3> characterStartPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.NativeFieldInfoPtr_characterStartPosition);
					return new Nullable<Vector3>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.NativeFieldInfoPtr_characterStartPosition), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<Vector3>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170043E5 RID: 17381
			// (get) Token: 0x0600D0B4 RID: 53428 RVA: 0x00334284 File Offset: 0x00332484
			// (set) Token: 0x0600D0B5 RID: 53429 RVA: 0x0006FBB6 File Offset: 0x0006DDB6
			public unsafe GameObject giveItemObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.NativeFieldInfoPtr_giveItemObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.NativeFieldInfoPtr_giveItemObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008624 RID: 34340
			private static readonly IntPtr NativeFieldInfoPtr_characterStartPosition;

			// Token: 0x04008625 RID: 34341
			private static readonly IntPtr NativeFieldInfoPtr_giveItemObject;

			// Token: 0x04008626 RID: 34342
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008627 RID: 34343
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Void_GameObject_0;

			// Token: 0x04008628 RID: 34344
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_GameObject_Action_1_GameObject_Single_PDM_0;

			// Token: 0x02001020 RID: 4128
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Akyuu+<>c__DisplayClass19_0+<<OnPositiveBuffExecute>g__InstantiateTimedOverride|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique : Il2CppSystem.Object
			{
				// Token: 0x06011A8A RID: 72330 RVA: 0x0040C4F0 File Offset: 0x0040A6F0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique()
				{
					Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__InstantiateTimedOverride|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr);
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, "<>1__state");
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, "<>2__current");
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, "parent");
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, "<>4__this");
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr_objectProcessingCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, "objectProcessingCallback");
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr_duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, "duration");
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, 100678296);
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, 100678297);
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, 100678298);
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, 100678299);
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, 100678300);
					Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr, 100678301);
				}

				// Token: 0x06011A8B RID: 72331 RVA: 0x0040C60C File Offset: 0x0040A80C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A8C RID: 72332 RVA: 0x0040C654 File Offset: 0x0040A854
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A8D RID: 72333 RVA: 0x0040C688 File Offset: 0x0040A888
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194111, XrefRangeEnd = 194123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BDF RID: 23519
				// (get) Token: 0x06011A8E RID: 72334 RVA: 0x0040C6C4 File Offset: 0x0040A8C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A8F RID: 72335 RVA: 0x0040C704 File Offset: 0x0040A904
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194123, XrefRangeEnd = 194129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BE0 RID: 23520
				// (get) Token: 0x06011A90 RID: 72336 RVA: 0x0040C738 File Offset: 0x0040A938
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011A91 RID: 72337 RVA: 0x000997C8 File Offset: 0x000979C8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BD9 RID: 23513
				// (get) Token: 0x06011A92 RID: 72338 RVA: 0x0040C778 File Offset: 0x0040A978
				// (set) Token: 0x06011A93 RID: 72339 RVA: 0x000997D1 File Offset: 0x000979D1
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BDA RID: 23514
				// (get) Token: 0x06011A94 RID: 72340 RVA: 0x0040C7A0 File Offset: 0x0040A9A0
				// (set) Token: 0x06011A95 RID: 72341 RVA: 0x000997EC File Offset: 0x000979EC
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BDB RID: 23515
				// (get) Token: 0x06011A96 RID: 72342 RVA: 0x0040C7D0 File Offset: 0x0040A9D0
				// (set) Token: 0x06011A97 RID: 72343 RVA: 0x0009980B File Offset: 0x00097A0B
				public unsafe GameObject parent
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr_parent);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BDC RID: 23516
				// (get) Token: 0x06011A98 RID: 72344 RVA: 0x0040C800 File Offset: 0x0040AA00
				// (set) Token: 0x06011A99 RID: 72345 RVA: 0x0009982A File Offset: 0x00097A2A
				public unsafe Spell_Akyuu.__c__DisplayClass19_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Akyuu.__c__DisplayClass19_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BDD RID: 23517
				// (get) Token: 0x06011A9A RID: 72346 RVA: 0x0040C830 File Offset: 0x0040AA30
				// (set) Token: 0x06011A9B RID: 72347 RVA: 0x00099849 File Offset: 0x00097A49
				public unsafe Action<GameObject> objectProcessingCallback
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr_objectProcessingCallback);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr_objectProcessingCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BDE RID: 23518
				// (get) Token: 0x06011A9C RID: 72348 RVA: 0x0040C860 File Offset: 0x0040AA60
				// (set) Token: 0x06011A9D RID: 72349 RVA: 0x00099868 File Offset: 0x00097A68
				public unsafe float duration
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr_duration);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu.__c__DisplayClass19_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGapaAc1obGaSiduUnique.NativeFieldInfoPtr_duration)) = value;
					}
				}

				// Token: 0x0400B286 RID: 45702
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B287 RID: 45703
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B288 RID: 45704
				private static readonly IntPtr NativeFieldInfoPtr_parent;

				// Token: 0x0400B289 RID: 45705
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B28A RID: 45706
				private static readonly IntPtr NativeFieldInfoPtr_objectProcessingCallback;

				// Token: 0x0400B28B RID: 45707
				private static readonly IntPtr NativeFieldInfoPtr_duration;

				// Token: 0x0400B28C RID: 45708
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B28D RID: 45709
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B28E RID: 45710
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B28F RID: 45711
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B290 RID: 45712
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B291 RID: 45713
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000AF5 RID: 2805
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Akyuu+<OnPositiveBuffExecute>d__19")]
		public sealed class _OnPositiveBuffExecute_d__19 : Il2CppSystem.Object
		{
			// Token: 0x0600D0B6 RID: 53430 RVA: 0x003342B4 File Offset: 0x003324B4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__19()
			{
				Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Akyuu>.NativeClassPtr, "<OnPositiveBuffExecute>d__19");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr);
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>1__state");
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>2__current");
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>4__this");
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, "spellExecutionContext");
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, "<>8__1");
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100678302);
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100678303);
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100678304);
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100678305);
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100678306);
				Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr, 100678307);
			}

			// Token: 0x0600D0B7 RID: 53431 RVA: 0x003343BC File Offset: 0x003325BC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__19(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Akyuu._OnPositiveBuffExecute_d__19>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0B8 RID: 53432 RVA: 0x00334404 File Offset: 0x00332604
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D0B9 RID: 53433 RVA: 0x00334438 File Offset: 0x00332638
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194141, XrefRangeEnd = 194157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170043EB RID: 17387
			// (get) Token: 0x0600D0BA RID: 53434 RVA: 0x00334474 File Offset: 0x00332674
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D0BB RID: 53435 RVA: 0x003344B4 File Offset: 0x003326B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 194157, XrefRangeEnd = 194163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170043EC RID: 17388
			// (get) Token: 0x0600D0BC RID: 53436 RVA: 0x003344E8 File Offset: 0x003326E8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D0BD RID: 53437 RVA: 0x0006FBD5 File Offset: 0x0006DDD5
			public _OnPositiveBuffExecute_d__19(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043E6 RID: 17382
			// (get) Token: 0x0600D0BE RID: 53438 RVA: 0x00334528 File Offset: 0x00332728
			// (set) Token: 0x0600D0BF RID: 53439 RVA: 0x0006FBDE File Offset: 0x0006DDDE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170043E7 RID: 17383
			// (get) Token: 0x0600D0C0 RID: 53440 RVA: 0x00334550 File Offset: 0x00332750
			// (set) Token: 0x0600D0C1 RID: 53441 RVA: 0x0006FBF9 File Offset: 0x0006DDF9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E8 RID: 17384
			// (get) Token: 0x0600D0C2 RID: 53442 RVA: 0x00334580 File Offset: 0x00332780
			// (set) Token: 0x0600D0C3 RID: 53443 RVA: 0x0006FC18 File Offset: 0x0006DE18
			public unsafe Spell_Akyuu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Akyuu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E9 RID: 17385
			// (get) Token: 0x0600D0C4 RID: 53444 RVA: 0x003345B0 File Offset: 0x003327B0
			// (set) Token: 0x0600D0C5 RID: 53445 RVA: 0x0006FC37 File Offset: 0x0006DE37
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043EA RID: 17386
			// (get) Token: 0x0600D0C6 RID: 53446 RVA: 0x003345E0 File Offset: 0x003327E0
			// (set) Token: 0x0600D0C7 RID: 53447 RVA: 0x0006FC56 File Offset: 0x0006DE56
			public unsafe Spell_Akyuu.__c__DisplayClass19_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Akyuu.__c__DisplayClass19_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Akyuu._OnPositiveBuffExecute_d__19.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008629 RID: 34345
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400862A RID: 34346
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400862B RID: 34347
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400862C RID: 34348
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400862D RID: 34349
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400862E RID: 34350
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400862F RID: 34351
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008630 RID: 34352
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008631 RID: 34353
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008632 RID: 34354
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008633 RID: 34355
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
