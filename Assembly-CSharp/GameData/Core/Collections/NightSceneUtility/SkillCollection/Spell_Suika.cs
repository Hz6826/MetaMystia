using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000286 RID: 646
	public class Spell_Suika : SpellBase
	{
		// Token: 0x06005194 RID: 20884 RVA: 0x001B3EB8 File Offset: 0x001B20B8
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Suika()
		{
			Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Suika");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr);
			Spell_Suika.NativeFieldInfoPtr_giveBeverageAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "giveBeverageAmount");
			Spell_Suika.NativeFieldInfoPtr_takeBeverageAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "takeBeverageAmount");
			Spell_Suika.NativeFieldInfoPtr_giveBeveragePriceMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "giveBeveragePriceMin");
			Spell_Suika.NativeFieldInfoPtr_spawnSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "spawnSFX");
			Spell_Suika.NativeFieldInfoPtr_stepSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "stepSFX");
			Spell_Suika.NativeFieldInfoPtr_takeItemSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "takeItemSFX");
			Spell_Suika.NativeFieldInfoPtr_suikaSpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "suikaSpawnOffset");
			Spell_Suika.NativeFieldInfoPtr_suikaStartTakeItemOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "suikaStartTakeItemOffset");
			Spell_Suika.NativeFieldInfoPtr_suikaStartEndOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "suikaStartEndOffset");
			Spell_Suika.NativeFieldInfoPtr_suikaEndOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "suikaEndOffset");
			Spell_Suika.NativeFieldInfoPtr_suikaTakeItemOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "suikaTakeItemOffset");
			Spell_Suika.NativeFieldInfoPtr_suikaStartGiveItemOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "suikaStartGiveItemOffset");
			Spell_Suika.NativeFieldInfoPtr_positiveSmallSuika = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "positiveSmallSuika");
			Spell_Suika.NativeFieldInfoPtr_positiveSuikaRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "positiveSuikaRuntime");
			Spell_Suika.NativeFieldInfoPtr_positiveSuikaWholeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "positiveSuikaWholeTime");
			Spell_Suika.NativeFieldInfoPtr_negativeSmallSuika = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "negativeSmallSuika");
			Spell_Suika.NativeFieldInfoPtr_negativeSuikaRuntime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "negativeSuikaRuntime");
			Spell_Suika.NativeFieldInfoPtr_negativeSuikaWholeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "negativeSuikaWholeTime");
			Spell_Suika.NativeFieldInfoPtr_firstSmallSuikaDisappear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "firstSmallSuikaDisappear");
			Spell_Suika.NativeFieldInfoPtr_nextSuikaDisappear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "nextSuikaDisappear");
			Spell_Suika.NativeFieldInfoPtr_spawnEffectFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "spawnEffectFirst");
			Spell_Suika.NativeFieldInfoPtr_spawnEffectLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "spawnEffectLast");
			Spell_Suika.NativeFieldInfoPtr_effectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "effectDuration");
			Spell_Suika.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, 100679784);
			Spell_Suika.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, 100679785);
			Spell_Suika.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, 100679786);
			Spell_Suika.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, 100679787);
		}

		// Token: 0x06005195 RID: 20885 RVA: 0x001B4104 File Offset: 0x001B2304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205301, XrefRangeEnd = 205303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Suika.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005196 RID: 20886 RVA: 0x001B4148 File Offset: 0x001B2348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205303, XrefRangeEnd = 205308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Suika.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005197 RID: 20887 RVA: 0x001B41A4 File Offset: 0x001B23A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205308, XrefRangeEnd = 205313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Suika.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005198 RID: 20888 RVA: 0x001B4200 File Offset: 0x001B2400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205313, XrefRangeEnd = 205314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Suika() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005199 RID: 20889 RVA: 0x0002B6F6 File Offset: 0x000298F6
		public Spell_Suika(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001BD7 RID: 7127
		// (get) Token: 0x0600519A RID: 20890 RVA: 0x001B423C File Offset: 0x001B243C
		// (set) Token: 0x0600519B RID: 20891 RVA: 0x0002B6FF File Offset: 0x000298FF
		public unsafe int giveBeverageAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_giveBeverageAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_giveBeverageAmount)) = value;
			}
		}

		// Token: 0x17001BD8 RID: 7128
		// (get) Token: 0x0600519C RID: 20892 RVA: 0x001B4264 File Offset: 0x001B2464
		// (set) Token: 0x0600519D RID: 20893 RVA: 0x0002B71A File Offset: 0x0002991A
		public unsafe int takeBeverageAmount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_takeBeverageAmount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_takeBeverageAmount)) = value;
			}
		}

		// Token: 0x17001BD9 RID: 7129
		// (get) Token: 0x0600519E RID: 20894 RVA: 0x001B428C File Offset: 0x001B248C
		// (set) Token: 0x0600519F RID: 20895 RVA: 0x0002B735 File Offset: 0x00029935
		public unsafe int giveBeveragePriceMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_giveBeveragePriceMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_giveBeveragePriceMin)) = value;
			}
		}

		// Token: 0x17001BDA RID: 7130
		// (get) Token: 0x060051A0 RID: 20896 RVA: 0x001B42B4 File Offset: 0x001B24B4
		// (set) Token: 0x060051A1 RID: 20897 RVA: 0x0002B750 File Offset: 0x00029950
		public unsafe AudioClip spawnSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_spawnSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_spawnSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BDB RID: 7131
		// (get) Token: 0x060051A2 RID: 20898 RVA: 0x001B42E4 File Offset: 0x001B24E4
		// (set) Token: 0x060051A3 RID: 20899 RVA: 0x0002B76F File Offset: 0x0002996F
		public unsafe LoopedBGMPackage stepSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_stepSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_stepSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BDC RID: 7132
		// (get) Token: 0x060051A4 RID: 20900 RVA: 0x001B4314 File Offset: 0x001B2514
		// (set) Token: 0x060051A5 RID: 20901 RVA: 0x0002B78E File Offset: 0x0002998E
		public unsafe AudioClip takeItemSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_takeItemSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_takeItemSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BDD RID: 7133
		// (get) Token: 0x060051A6 RID: 20902 RVA: 0x001B4344 File Offset: 0x001B2544
		// (set) Token: 0x060051A7 RID: 20903 RVA: 0x0002B7AD File Offset: 0x000299AD
		public unsafe float suikaSpawnOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaSpawnOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaSpawnOffset)) = value;
			}
		}

		// Token: 0x17001BDE RID: 7134
		// (get) Token: 0x060051A8 RID: 20904 RVA: 0x001B436C File Offset: 0x001B256C
		// (set) Token: 0x060051A9 RID: 20905 RVA: 0x0002B7C8 File Offset: 0x000299C8
		public unsafe float suikaStartTakeItemOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaStartTakeItemOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaStartTakeItemOffset)) = value;
			}
		}

		// Token: 0x17001BDF RID: 7135
		// (get) Token: 0x060051AA RID: 20906 RVA: 0x001B4394 File Offset: 0x001B2594
		// (set) Token: 0x060051AB RID: 20907 RVA: 0x0002B7E3 File Offset: 0x000299E3
		public unsafe float suikaStartEndOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaStartEndOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaStartEndOffset)) = value;
			}
		}

		// Token: 0x17001BE0 RID: 7136
		// (get) Token: 0x060051AC RID: 20908 RVA: 0x001B43BC File Offset: 0x001B25BC
		// (set) Token: 0x060051AD RID: 20909 RVA: 0x0002B7FE File Offset: 0x000299FE
		public unsafe float suikaEndOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaEndOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaEndOffset)) = value;
			}
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x060051AE RID: 20910 RVA: 0x001B43E4 File Offset: 0x001B25E4
		// (set) Token: 0x060051AF RID: 20911 RVA: 0x0002B819 File Offset: 0x00029A19
		public unsafe float suikaTakeItemOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaTakeItemOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaTakeItemOffset)) = value;
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x060051B0 RID: 20912 RVA: 0x001B440C File Offset: 0x001B260C
		// (set) Token: 0x060051B1 RID: 20913 RVA: 0x0002B834 File Offset: 0x00029A34
		public unsafe float suikaStartGiveItemOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaStartGiveItemOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_suikaStartGiveItemOffset)) = value;
			}
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x060051B2 RID: 20914 RVA: 0x001B4434 File Offset: 0x001B2634
		// (set) Token: 0x060051B3 RID: 20915 RVA: 0x0002B84F File Offset: 0x00029A4F
		public unsafe GameObject positiveSmallSuika
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_positiveSmallSuika);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_positiveSmallSuika), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE4 RID: 7140
		// (get) Token: 0x060051B4 RID: 20916 RVA: 0x001B4464 File Offset: 0x001B2664
		// (set) Token: 0x060051B5 RID: 20917 RVA: 0x0002B86E File Offset: 0x00029A6E
		public unsafe float positiveSuikaRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_positiveSuikaRuntime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_positiveSuikaRuntime)) = value;
			}
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x060051B6 RID: 20918 RVA: 0x001B448C File Offset: 0x001B268C
		// (set) Token: 0x060051B7 RID: 20919 RVA: 0x0002B889 File Offset: 0x00029A89
		public unsafe float positiveSuikaWholeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_positiveSuikaWholeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_positiveSuikaWholeTime)) = value;
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x060051B8 RID: 20920 RVA: 0x001B44B4 File Offset: 0x001B26B4
		// (set) Token: 0x060051B9 RID: 20921 RVA: 0x0002B8A4 File Offset: 0x00029AA4
		public unsafe GameObject negativeSmallSuika
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_negativeSmallSuika);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_negativeSmallSuika), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x001B44E4 File Offset: 0x001B26E4
		// (set) Token: 0x060051BB RID: 20923 RVA: 0x0002B8C3 File Offset: 0x00029AC3
		public unsafe float negativeSuikaRuntime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_negativeSuikaRuntime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_negativeSuikaRuntime)) = value;
			}
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x060051BC RID: 20924 RVA: 0x001B450C File Offset: 0x001B270C
		// (set) Token: 0x060051BD RID: 20925 RVA: 0x0002B8DE File Offset: 0x00029ADE
		public unsafe float negativeSuikaWholeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_negativeSuikaWholeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_negativeSuikaWholeTime)) = value;
			}
		}

		// Token: 0x17001BE9 RID: 7145
		// (get) Token: 0x060051BE RID: 20926 RVA: 0x001B4534 File Offset: 0x001B2734
		// (set) Token: 0x060051BF RID: 20927 RVA: 0x0002B8F9 File Offset: 0x00029AF9
		public unsafe float firstSmallSuikaDisappear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_firstSmallSuikaDisappear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_firstSmallSuikaDisappear)) = value;
			}
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x060051C0 RID: 20928 RVA: 0x001B455C File Offset: 0x001B275C
		// (set) Token: 0x060051C1 RID: 20929 RVA: 0x0002B914 File Offset: 0x00029B14
		public unsafe float nextSuikaDisappear
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_nextSuikaDisappear);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_nextSuikaDisappear)) = value;
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x060051C2 RID: 20930 RVA: 0x001B4584 File Offset: 0x001B2784
		// (set) Token: 0x060051C3 RID: 20931 RVA: 0x0002B92F File Offset: 0x00029B2F
		public unsafe GameObject spawnEffectFirst
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_spawnEffectFirst);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_spawnEffectFirst), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x060051C4 RID: 20932 RVA: 0x001B45B4 File Offset: 0x001B27B4
		// (set) Token: 0x060051C5 RID: 20933 RVA: 0x0002B94E File Offset: 0x00029B4E
		public unsafe GameObject spawnEffectLast
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_spawnEffectLast);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_spawnEffectLast), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x060051C6 RID: 20934 RVA: 0x001B45E4 File Offset: 0x001B27E4
		// (set) Token: 0x060051C7 RID: 20935 RVA: 0x0002B96D File Offset: 0x00029B6D
		public unsafe float effectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_effectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.NativeFieldInfoPtr_effectDuration)) = value;
			}
		}

		// Token: 0x0400371E RID: 14110
		private static readonly IntPtr NativeFieldInfoPtr_giveBeverageAmount;

		// Token: 0x0400371F RID: 14111
		private static readonly IntPtr NativeFieldInfoPtr_takeBeverageAmount;

		// Token: 0x04003720 RID: 14112
		private static readonly IntPtr NativeFieldInfoPtr_giveBeveragePriceMin;

		// Token: 0x04003721 RID: 14113
		private static readonly IntPtr NativeFieldInfoPtr_spawnSFX;

		// Token: 0x04003722 RID: 14114
		private static readonly IntPtr NativeFieldInfoPtr_stepSFX;

		// Token: 0x04003723 RID: 14115
		private static readonly IntPtr NativeFieldInfoPtr_takeItemSFX;

		// Token: 0x04003724 RID: 14116
		private static readonly IntPtr NativeFieldInfoPtr_suikaSpawnOffset;

		// Token: 0x04003725 RID: 14117
		private static readonly IntPtr NativeFieldInfoPtr_suikaStartTakeItemOffset;

		// Token: 0x04003726 RID: 14118
		private static readonly IntPtr NativeFieldInfoPtr_suikaStartEndOffset;

		// Token: 0x04003727 RID: 14119
		private static readonly IntPtr NativeFieldInfoPtr_suikaEndOffset;

		// Token: 0x04003728 RID: 14120
		private static readonly IntPtr NativeFieldInfoPtr_suikaTakeItemOffset;

		// Token: 0x04003729 RID: 14121
		private static readonly IntPtr NativeFieldInfoPtr_suikaStartGiveItemOffset;

		// Token: 0x0400372A RID: 14122
		private static readonly IntPtr NativeFieldInfoPtr_positiveSmallSuika;

		// Token: 0x0400372B RID: 14123
		private static readonly IntPtr NativeFieldInfoPtr_positiveSuikaRuntime;

		// Token: 0x0400372C RID: 14124
		private static readonly IntPtr NativeFieldInfoPtr_positiveSuikaWholeTime;

		// Token: 0x0400372D RID: 14125
		private static readonly IntPtr NativeFieldInfoPtr_negativeSmallSuika;

		// Token: 0x0400372E RID: 14126
		private static readonly IntPtr NativeFieldInfoPtr_negativeSuikaRuntime;

		// Token: 0x0400372F RID: 14127
		private static readonly IntPtr NativeFieldInfoPtr_negativeSuikaWholeTime;

		// Token: 0x04003730 RID: 14128
		private static readonly IntPtr NativeFieldInfoPtr_firstSmallSuikaDisappear;

		// Token: 0x04003731 RID: 14129
		private static readonly IntPtr NativeFieldInfoPtr_nextSuikaDisappear;

		// Token: 0x04003732 RID: 14130
		private static readonly IntPtr NativeFieldInfoPtr_spawnEffectFirst;

		// Token: 0x04003733 RID: 14131
		private static readonly IntPtr NativeFieldInfoPtr_spawnEffectLast;

		// Token: 0x04003734 RID: 14132
		private static readonly IntPtr NativeFieldInfoPtr_effectDuration;

		// Token: 0x04003735 RID: 14133
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003736 RID: 14134
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003737 RID: 14135
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003738 RID: 14136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000BD1 RID: 3025
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCD6 RID: 56534 RVA: 0x00358564 File Offset: 0x00356764
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr);
				Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, "<>4__this");
				Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr_smallSuika = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, "smallSuika");
				Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr_suikaTakeItemOffsetWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, "suikaTakeItemOffsetWait");
				Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr_suikaSpawnOffsetWait = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, "suikaSpawnOffsetWait");
				Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, 100679788);
				Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, 100679789);
				Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, 100679790);
				Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, 100679791);
				Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, 100679792);
				Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, 100679793);
			}

			// Token: 0x0600DCD7 RID: 56535 RVA: 0x00358658 File Offset: 0x00356858
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCD8 RID: 56536 RVA: 0x00358694 File Offset: 0x00356894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205169, XrefRangeEnd = 205174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DCD9 RID: 56537 RVA: 0x003586D4 File Offset: 0x003568D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205174, XrefRangeEnd = 205177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__4(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCDA RID: 56538 RVA: 0x00358718 File Offset: 0x00356918
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205177, XrefRangeEnd = 205182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DCDB RID: 56539 RVA: 0x00358758 File Offset: 0x00356958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205182, XrefRangeEnd = 205187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DCDC RID: 56540 RVA: 0x00358798 File Offset: 0x00356998
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205187, XrefRangeEnd = 205192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DCDD RID: 56541 RVA: 0x00075F8E File Offset: 0x0007418E
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047C7 RID: 18375
			// (get) Token: 0x0600DCDE RID: 56542 RVA: 0x003587D8 File Offset: 0x003569D8
			// (set) Token: 0x0600DCDF RID: 56543 RVA: 0x00075F97 File Offset: 0x00074197
			public unsafe Spell_Suika __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047C8 RID: 18376
			// (get) Token: 0x0600DCE0 RID: 56544 RVA: 0x00358808 File Offset: 0x00356A08
			// (set) Token: 0x0600DCE1 RID: 56545 RVA: 0x00075FB6 File Offset: 0x000741B6
			public unsafe GameObject smallSuika
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr_smallSuika);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr_smallSuika), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047C9 RID: 18377
			// (get) Token: 0x0600DCE2 RID: 56546 RVA: 0x00358838 File Offset: 0x00356A38
			// (set) Token: 0x0600DCE3 RID: 56547 RVA: 0x00075FD5 File Offset: 0x000741D5
			public unsafe WaitForSeconds suikaTakeItemOffsetWait
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr_suikaTakeItemOffsetWait);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr_suikaTakeItemOffsetWait), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047CA RID: 18378
			// (get) Token: 0x0600DCE4 RID: 56548 RVA: 0x00358868 File Offset: 0x00356A68
			// (set) Token: 0x0600DCE5 RID: 56549 RVA: 0x00075FF4 File Offset: 0x000741F4
			public unsafe WaitForSeconds suikaSpawnOffsetWait
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr_suikaSpawnOffsetWait);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.NativeFieldInfoPtr_suikaSpawnOffsetWait), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D75 RID: 36213
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D76 RID: 36214
			private static readonly IntPtr NativeFieldInfoPtr_smallSuika;

			// Token: 0x04008D77 RID: 36215
			private static readonly IntPtr NativeFieldInfoPtr_suikaTakeItemOffsetWait;

			// Token: 0x04008D78 RID: 36216
			private static readonly IntPtr NativeFieldInfoPtr_suikaSpawnOffsetWait;

			// Token: 0x04008D79 RID: 36217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D7A RID: 36218
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008D7B RID: 36219
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__4_Internal_Void_GameObject_0;

			// Token: 0x04008D7C RID: 36220
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x04008D7D RID: 36221
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2;

			// Token: 0x04008D7E RID: 36222
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_3;

			// Token: 0x02001041 RID: 4161
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<>c__DisplayClass24_0+<<OnNegativeBuffExecute>g__TinySuika|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011CBE RID: 72894 RVA: 0x00412F28 File Offset: 0x00411128
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__TinySuika|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679794);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679795);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679796);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679797);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679798);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679799);
				}

				// Token: 0x06011CBF RID: 72895 RVA: 0x00413008 File Offset: 0x00411208
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CC0 RID: 72896 RVA: 0x00413050 File Offset: 0x00411250
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CC1 RID: 72897 RVA: 0x00413084 File Offset: 0x00411284
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205131, XrefRangeEnd = 205140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CB4 RID: 23732
				// (get) Token: 0x06011CC2 RID: 72898 RVA: 0x004130C0 File Offset: 0x004112C0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CC3 RID: 72899 RVA: 0x00413100 File Offset: 0x00411300
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205140, XrefRangeEnd = 205146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CB5 RID: 23733
				// (get) Token: 0x06011CC4 RID: 72900 RVA: 0x00413134 File Offset: 0x00411334
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CC5 RID: 72901 RVA: 0x0009AA52 File Offset: 0x00098C52
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CB1 RID: 23729
				// (get) Token: 0x06011CC6 RID: 72902 RVA: 0x00413174 File Offset: 0x00411374
				// (set) Token: 0x06011CC7 RID: 72903 RVA: 0x0009AA5B File Offset: 0x00098C5B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CB2 RID: 23730
				// (get) Token: 0x06011CC8 RID: 72904 RVA: 0x0041319C File Offset: 0x0041139C
				// (set) Token: 0x06011CC9 RID: 72905 RVA: 0x0009AA76 File Offset: 0x00098C76
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CB3 RID: 23731
				// (get) Token: 0x06011CCA RID: 72906 RVA: 0x004131CC File Offset: 0x004113CC
				// (set) Token: 0x06011CCB RID: 72907 RVA: 0x0009AA95 File Offset: 0x00098C95
				public unsafe Spell_Suika.__c__DisplayClass24_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika.__c__DisplayClass24_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B3E2 RID: 46050
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B3E3 RID: 46051
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3E4 RID: 46052
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3E5 RID: 46053
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3E6 RID: 46054
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3E7 RID: 46055
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3E8 RID: 46056
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3E9 RID: 46057
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3EA RID: 46058
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001042 RID: 4162
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<>c__DisplayClass24_0+<<OnNegativeBuffExecute>g__SuikaExtractAudio|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0 : Il2CppSystem.Object
			{
				// Token: 0x06011CCC RID: 72908 RVA: 0x004131FC File Offset: 0x004113FC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0()
				{
					Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__SuikaExtractAudio|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, "<>1__state");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, "<>2__current");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, "<>4__this");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, "<i>5__2");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100679800);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100679801);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100679802);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100679803);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100679804);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100679805);
				}

				// Token: 0x06011CCD RID: 72909 RVA: 0x004132F0 File Offset: 0x004114F0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CCE RID: 72910 RVA: 0x00413338 File Offset: 0x00411538
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CCF RID: 72911 RVA: 0x0041336C File Offset: 0x0041156C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205146, XrefRangeEnd = 205147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CBA RID: 23738
				// (get) Token: 0x06011CD0 RID: 72912 RVA: 0x004133A8 File Offset: 0x004115A8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CD1 RID: 72913 RVA: 0x004133E8 File Offset: 0x004115E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205147, XrefRangeEnd = 205153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CBB RID: 23739
				// (get) Token: 0x06011CD2 RID: 72914 RVA: 0x0041341C File Offset: 0x0041161C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CD3 RID: 72915 RVA: 0x0009AAB4 File Offset: 0x00098CB4
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CB6 RID: 23734
				// (get) Token: 0x06011CD4 RID: 72916 RVA: 0x0041345C File Offset: 0x0041165C
				// (set) Token: 0x06011CD5 RID: 72917 RVA: 0x0009AABD File Offset: 0x00098CBD
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CB7 RID: 23735
				// (get) Token: 0x06011CD6 RID: 72918 RVA: 0x00413484 File Offset: 0x00411684
				// (set) Token: 0x06011CD7 RID: 72919 RVA: 0x0009AAD8 File Offset: 0x00098CD8
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CB8 RID: 23736
				// (get) Token: 0x06011CD8 RID: 72920 RVA: 0x004134B4 File Offset: 0x004116B4
				// (set) Token: 0x06011CD9 RID: 72921 RVA: 0x0009AAF7 File Offset: 0x00098CF7
				public unsafe Spell_Suika.__c__DisplayClass24_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika.__c__DisplayClass24_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CB9 RID: 23737
				// (get) Token: 0x06011CDA RID: 72922 RVA: 0x004134E4 File Offset: 0x004116E4
				// (set) Token: 0x06011CDB RID: 72923 RVA: 0x0009AB16 File Offset: 0x00098D16
				public unsafe int _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400B3EB RID: 46059
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B3EC RID: 46060
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3ED RID: 46061
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3EE RID: 46062
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400B3EF RID: 46063
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3F0 RID: 46064
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3F1 RID: 46065
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3F2 RID: 46066
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3F3 RID: 46067
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3F4 RID: 46068
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001043 RID: 4163
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<>c__DisplayClass24_0+<<OnNegativeBuffExecute>g__SuikaSpawnAudio|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1 : Il2CppSystem.Object
			{
				// Token: 0x06011CDC RID: 72924 RVA: 0x0041350C File Offset: 0x0041170C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1()
				{
					Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__SuikaSpawnAudio|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, "<>1__state");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, "<>2__current");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, "<>4__this");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, "<i>5__2");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100679806);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100679807);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100679808);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100679809);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100679810);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100679811);
				}

				// Token: 0x06011CDD RID: 72925 RVA: 0x00413600 File Offset: 0x00411800
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CDE RID: 72926 RVA: 0x00413648 File Offset: 0x00411848
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CDF RID: 72927 RVA: 0x0041367C File Offset: 0x0041187C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205153, XrefRangeEnd = 205156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CC0 RID: 23744
				// (get) Token: 0x06011CE0 RID: 72928 RVA: 0x004136B8 File Offset: 0x004118B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CE1 RID: 72929 RVA: 0x004136F8 File Offset: 0x004118F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205156, XrefRangeEnd = 205162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CC1 RID: 23745
				// (get) Token: 0x06011CE2 RID: 72930 RVA: 0x0041372C File Offset: 0x0041192C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CE3 RID: 72931 RVA: 0x0009AB31 File Offset: 0x00098D31
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CBC RID: 23740
				// (get) Token: 0x06011CE4 RID: 72932 RVA: 0x0041376C File Offset: 0x0041196C
				// (set) Token: 0x06011CE5 RID: 72933 RVA: 0x0009AB3A File Offset: 0x00098D3A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CBD RID: 23741
				// (get) Token: 0x06011CE6 RID: 72934 RVA: 0x00413794 File Offset: 0x00411994
				// (set) Token: 0x06011CE7 RID: 72935 RVA: 0x0009AB55 File Offset: 0x00098D55
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CBE RID: 23742
				// (get) Token: 0x06011CE8 RID: 72936 RVA: 0x004137C4 File Offset: 0x004119C4
				// (set) Token: 0x06011CE9 RID: 72937 RVA: 0x0009AB74 File Offset: 0x00098D74
				public unsafe Spell_Suika.__c__DisplayClass24_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika.__c__DisplayClass24_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CBF RID: 23743
				// (get) Token: 0x06011CEA RID: 72938 RVA: 0x004137F4 File Offset: 0x004119F4
				// (set) Token: 0x06011CEB RID: 72939 RVA: 0x0009AB93 File Offset: 0x00098D93
				public unsafe int _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400B3F5 RID: 46069
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B3F6 RID: 46070
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B3F7 RID: 46071
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B3F8 RID: 46072
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400B3F9 RID: 46073
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B3FA RID: 46074
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3FB RID: 46075
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B3FC RID: 46076
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B3FD RID: 46077
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B3FE RID: 46078
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001044 RID: 4164
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<>c__DisplayClass24_0+<<OnNegativeBuffExecute>g__SuikaRemoveAudio|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2 : Il2CppSystem.Object
			{
				// Token: 0x06011CEC RID: 72940 RVA: 0x0041381C File Offset: 0x00411A1C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2()
				{
					Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__SuikaRemoveAudio|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, "<>1__state");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, "<>2__current");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, "<>4__this");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, "<i>5__2");
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, 100679812);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, 100679813);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, 100679814);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, 100679815);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, 100679816);
					Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr, 100679817);
				}

				// Token: 0x06011CED RID: 72941 RVA: 0x00413910 File Offset: 0x00411B10
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CEE RID: 72942 RVA: 0x00413958 File Offset: 0x00411B58
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CEF RID: 72943 RVA: 0x0041398C File Offset: 0x00411B8C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205162, XrefRangeEnd = 205163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CC6 RID: 23750
				// (get) Token: 0x06011CF0 RID: 72944 RVA: 0x004139C8 File Offset: 0x00411BC8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CF1 RID: 72945 RVA: 0x00413A08 File Offset: 0x00411C08
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205163, XrefRangeEnd = 205169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CC7 RID: 23751
				// (get) Token: 0x06011CF2 RID: 72946 RVA: 0x00413A3C File Offset: 0x00411C3C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011CF3 RID: 72947 RVA: 0x0009ABAE File Offset: 0x00098DAE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CC2 RID: 23746
				// (get) Token: 0x06011CF4 RID: 72948 RVA: 0x00413A7C File Offset: 0x00411C7C
				// (set) Token: 0x06011CF5 RID: 72949 RVA: 0x0009ABB7 File Offset: 0x00098DB7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CC3 RID: 23747
				// (get) Token: 0x06011CF6 RID: 72950 RVA: 0x00413AA4 File Offset: 0x00411CA4
				// (set) Token: 0x06011CF7 RID: 72951 RVA: 0x0009ABD2 File Offset: 0x00098DD2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CC4 RID: 23748
				// (get) Token: 0x06011CF8 RID: 72952 RVA: 0x00413AD4 File Offset: 0x00411CD4
				// (set) Token: 0x06011CF9 RID: 72953 RVA: 0x0009ABF1 File Offset: 0x00098DF1
				public unsafe Spell_Suika.__c__DisplayClass24_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika.__c__DisplayClass24_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CC5 RID: 23749
				// (get) Token: 0x06011CFA RID: 72954 RVA: 0x00413B04 File Offset: 0x00411D04
				// (set) Token: 0x06011CFB RID: 72955 RVA: 0x0009AC10 File Offset: 0x00098E10
				public unsafe int _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass24_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn2.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400B3FF RID: 46079
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B400 RID: 46080
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B401 RID: 46081
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B402 RID: 46082
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400B403 RID: 46083
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B404 RID: 46084
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B405 RID: 46085
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B406 RID: 46086
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B407 RID: 46087
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B408 RID: 46088
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BD2 RID: 3026
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<OnNegativeBuffExecute>d__24")]
		public sealed class _OnNegativeBuffExecute_d__24 : Il2CppSystem.Object
		{
			// Token: 0x0600DCE6 RID: 56550 RVA: 0x00358898 File Offset: 0x00356A98
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__24()
			{
				Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "<OnNegativeBuffExecute>d__24");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr);
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<>1__state");
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<>2__current");
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<>4__this");
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__smallSuikas_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<smallSuikas>5__2");
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__beerSuikaTake_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<beerSuikaTake>5__3");
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__smallSuikaTransform_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<smallSuikaTransform>5__4");
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__i_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, "<i>5__5");
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100679818);
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100679819);
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100679820);
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100679821);
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100679822);
				Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr, 100679823);
			}

			// Token: 0x0600DCE7 RID: 56551 RVA: 0x003589C8 File Offset: 0x00356BC8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__24(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika._OnNegativeBuffExecute_d__24>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCE8 RID: 56552 RVA: 0x00358A10 File Offset: 0x00356C10
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCE9 RID: 56553 RVA: 0x00358A44 File Offset: 0x00356C44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205192, XrefRangeEnd = 205227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047D2 RID: 18386
			// (get) Token: 0x0600DCEA RID: 56554 RVA: 0x00358A80 File Offset: 0x00356C80
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCEB RID: 56555 RVA: 0x00358AC0 File Offset: 0x00356CC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205227, XrefRangeEnd = 205233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047D3 RID: 18387
			// (get) Token: 0x0600DCEC RID: 56556 RVA: 0x00358AF4 File Offset: 0x00356CF4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnNegativeBuffExecute_d__24.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DCED RID: 56557 RVA: 0x00076013 File Offset: 0x00074213
			public _OnNegativeBuffExecute_d__24(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047CB RID: 18379
			// (get) Token: 0x0600DCEE RID: 56558 RVA: 0x00358B34 File Offset: 0x00356D34
			// (set) Token: 0x0600DCEF RID: 56559 RVA: 0x0007601C File Offset: 0x0007421C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047CC RID: 18380
			// (get) Token: 0x0600DCF0 RID: 56560 RVA: 0x00358B5C File Offset: 0x00356D5C
			// (set) Token: 0x0600DCF1 RID: 56561 RVA: 0x00076037 File Offset: 0x00074237
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047CD RID: 18381
			// (get) Token: 0x0600DCF2 RID: 56562 RVA: 0x00358B8C File Offset: 0x00356D8C
			// (set) Token: 0x0600DCF3 RID: 56563 RVA: 0x00076056 File Offset: 0x00074256
			public unsafe Spell_Suika __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047CE RID: 18382
			// (get) Token: 0x0600DCF4 RID: 56564 RVA: 0x00358BBC File Offset: 0x00356DBC
			// (set) Token: 0x0600DCF5 RID: 56565 RVA: 0x00076075 File Offset: 0x00074275
			public unsafe Il2CppReferenceArray<GameObject> _smallSuikas_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__smallSuikas_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__smallSuikas_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047CF RID: 18383
			// (get) Token: 0x0600DCF6 RID: 56566 RVA: 0x00358BEC File Offset: 0x00356DEC
			// (set) Token: 0x0600DCF7 RID: 56567 RVA: 0x00076094 File Offset: 0x00074294
			public EventManager.SelectedValue _beerSuikaTake_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__beerSuikaTake_5__3);
					return new EventManager.SelectedValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__beerSuikaTake_5__3), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170047D0 RID: 18384
			// (get) Token: 0x0600DCF8 RID: 56568 RVA: 0x00358C1C File Offset: 0x00356E1C
			// (set) Token: 0x0600DCF9 RID: 56569 RVA: 0x000760C2 File Offset: 0x000742C2
			public unsafe List<Vector3> _smallSuikaTransform_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__smallSuikaTransform_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__smallSuikaTransform_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047D1 RID: 18385
			// (get) Token: 0x0600DCFA RID: 56570 RVA: 0x00358C4C File Offset: 0x00356E4C
			// (set) Token: 0x0600DCFB RID: 56571 RVA: 0x000760E1 File Offset: 0x000742E1
			public unsafe int _i_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__i_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnNegativeBuffExecute_d__24.NativeFieldInfoPtr__i_5__5)) = value;
				}
			}

			// Token: 0x04008D7F RID: 36223
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D80 RID: 36224
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D81 RID: 36225
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D82 RID: 36226
			private static readonly IntPtr NativeFieldInfoPtr__smallSuikas_5__2;

			// Token: 0x04008D83 RID: 36227
			private static readonly IntPtr NativeFieldInfoPtr__beerSuikaTake_5__3;

			// Token: 0x04008D84 RID: 36228
			private static readonly IntPtr NativeFieldInfoPtr__smallSuikaTransform_5__4;

			// Token: 0x04008D85 RID: 36229
			private static readonly IntPtr NativeFieldInfoPtr__i_5__5;

			// Token: 0x04008D86 RID: 36230
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D87 RID: 36231
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D88 RID: 36232
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D89 RID: 36233
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D8A RID: 36234
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D8B RID: 36235
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BD3 RID: 3027
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCFC RID: 56572 RVA: 0x00358C74 File Offset: 0x00356E74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr);
				Spell_Suika.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				Spell_Suika.__c__DisplayClass25_0.NativeFieldInfoPtr_smallSuika = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr, "smallSuika");
				Spell_Suika.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr, 100679824);
				Spell_Suika.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr, 100679825);
				Spell_Suika.__c__DisplayClass25_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr, 100679826);
				Spell_Suika.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr, 100679827);
			}

			// Token: 0x0600DCFD RID: 56573 RVA: 0x00358D18 File Offset: 0x00356F18
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DCFE RID: 56574 RVA: 0x00358D54 File Offset: 0x00356F54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205261, XrefRangeEnd = 205266, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DCFF RID: 56575 RVA: 0x00358D94 File Offset: 0x00356F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205266, XrefRangeEnd = 205269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD00 RID: 56576 RVA: 0x00358DD8 File Offset: 0x00356FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205269, XrefRangeEnd = 205274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600DD01 RID: 56577 RVA: 0x000760FC File Offset: 0x000742FC
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047D4 RID: 18388
			// (get) Token: 0x0600DD02 RID: 56578 RVA: 0x00358E18 File Offset: 0x00357018
			// (set) Token: 0x0600DD03 RID: 56579 RVA: 0x00076105 File Offset: 0x00074305
			public unsafe Spell_Suika __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047D5 RID: 18389
			// (get) Token: 0x0600DD04 RID: 56580 RVA: 0x00358E48 File Offset: 0x00357048
			// (set) Token: 0x0600DD05 RID: 56581 RVA: 0x00076124 File Offset: 0x00074324
			public unsafe GameObject smallSuika
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.NativeFieldInfoPtr_smallSuika);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.NativeFieldInfoPtr_smallSuika), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D8C RID: 36236
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D8D RID: 36237
			private static readonly IntPtr NativeFieldInfoPtr_smallSuika;

			// Token: 0x04008D8E RID: 36238
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D8F RID: 36239
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008D90 RID: 36240
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_GameObject_0;

			// Token: 0x04008D91 RID: 36241
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x02001045 RID: 4165
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<>c__DisplayClass25_0+<<OnPositiveBuffExecute>g__TinySuika|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0 : Il2CppSystem.Object
			{
				// Token: 0x06011CFC RID: 72956 RVA: 0x00413B2C File Offset: 0x00411D2C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0()
				{
					Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__TinySuika|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>1__state");
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>2__current");
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>4__this");
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679828);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679829);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679830);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679831);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679832);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100679833);
				}

				// Token: 0x06011CFD RID: 72957 RVA: 0x00413C0C File Offset: 0x00411E0C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CFE RID: 72958 RVA: 0x00413C54 File Offset: 0x00411E54
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011CFF RID: 72959 RVA: 0x00413C88 File Offset: 0x00411E88
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205233, XrefRangeEnd = 205244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CCB RID: 23755
				// (get) Token: 0x06011D00 RID: 72960 RVA: 0x00413CC4 File Offset: 0x00411EC4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D01 RID: 72961 RVA: 0x00413D04 File Offset: 0x00411F04
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205244, XrefRangeEnd = 205250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CCC RID: 23756
				// (get) Token: 0x06011D02 RID: 72962 RVA: 0x00413D38 File Offset: 0x00411F38
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D03 RID: 72963 RVA: 0x0009AC2B File Offset: 0x00098E2B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CC8 RID: 23752
				// (get) Token: 0x06011D04 RID: 72964 RVA: 0x00413D78 File Offset: 0x00411F78
				// (set) Token: 0x06011D05 RID: 72965 RVA: 0x0009AC34 File Offset: 0x00098E34
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CC9 RID: 23753
				// (get) Token: 0x06011D06 RID: 72966 RVA: 0x00413DA0 File Offset: 0x00411FA0
				// (set) Token: 0x06011D07 RID: 72967 RVA: 0x0009AC4F File Offset: 0x00098E4F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CCA RID: 23754
				// (get) Token: 0x06011D08 RID: 72968 RVA: 0x00413DD0 File Offset: 0x00411FD0
				// (set) Token: 0x06011D09 RID: 72969 RVA: 0x0009AC6E File Offset: 0x00098E6E
				public unsafe Spell_Suika.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B409 RID: 46089
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B40A RID: 46090
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B40B RID: 46091
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B40C RID: 46092
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B40D RID: 46093
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B40E RID: 46094
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B40F RID: 46095
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B410 RID: 46096
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B411 RID: 46097
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001046 RID: 4166
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<>c__DisplayClass25_0+<<OnPositiveBuffExecute>g__SuikaGiveAudio|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1 : Il2CppSystem.Object
			{
				// Token: 0x06011D0A RID: 72970 RVA: 0x00413E00 File Offset: 0x00412000
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1()
				{
					Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__SuikaGiveAudio|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>1__state");
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>2__current");
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>4__this");
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679834);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679835);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679836);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679837);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679838);
					Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100679839);
				}

				// Token: 0x06011D0B RID: 72971 RVA: 0x00413EE0 File Offset: 0x004120E0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D0C RID: 72972 RVA: 0x00413F28 File Offset: 0x00412128
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011D0D RID: 72973 RVA: 0x00413F5C File Offset: 0x0041215C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205250, XrefRangeEnd = 205255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005CD0 RID: 23760
				// (get) Token: 0x06011D0E RID: 72974 RVA: 0x00413F98 File Offset: 0x00412198
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D0F RID: 72975 RVA: 0x00413FD8 File Offset: 0x004121D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205255, XrefRangeEnd = 205261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005CD1 RID: 23761
				// (get) Token: 0x06011D10 RID: 72976 RVA: 0x0041400C File Offset: 0x0041220C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011D11 RID: 72977 RVA: 0x0009AC8D File Offset: 0x00098E8D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005CCD RID: 23757
				// (get) Token: 0x06011D12 RID: 72978 RVA: 0x0041404C File Offset: 0x0041224C
				// (set) Token: 0x06011D13 RID: 72979 RVA: 0x0009AC96 File Offset: 0x00098E96
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005CCE RID: 23758
				// (get) Token: 0x06011D14 RID: 72980 RVA: 0x00414074 File Offset: 0x00412274
				// (set) Token: 0x06011D15 RID: 72981 RVA: 0x0009ACB1 File Offset: 0x00098EB1
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005CCF RID: 23759
				// (get) Token: 0x06011D16 RID: 72982 RVA: 0x004140A4 File Offset: 0x004122A4
				// (set) Token: 0x06011D17 RID: 72983 RVA: 0x0009ACD0 File Offset: 0x00098ED0
				public unsafe Spell_Suika.__c__DisplayClass25_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B412 RID: 46098
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B413 RID: 46099
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B414 RID: 46100
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B415 RID: 46101
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B416 RID: 46102
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B417 RID: 46103
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B418 RID: 46104
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B419 RID: 46105
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B41A RID: 46106
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000BD4 RID: 3028
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Suika+<OnPositiveBuffExecute>d__25")]
		public sealed class _OnPositiveBuffExecute_d__25 : Il2CppSystem.Object
		{
			// Token: 0x0600DD06 RID: 56582 RVA: 0x00358E78 File Offset: 0x00357078
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__25()
			{
				Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Suika>.NativeClassPtr, "<OnPositiveBuffExecute>d__25");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr);
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<>1__state");
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<>2__current");
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<>4__this");
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<>8__1");
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr__beerFromSuika_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<beerFromSuika>5__2");
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr__lastposition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, "<lastposition>5__3");
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679840);
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679841);
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679842);
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679843);
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679844);
				Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr, 100679845);
			}

			// Token: 0x0600DD07 RID: 56583 RVA: 0x00358F94 File Offset: 0x00357194
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__25(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Suika._OnPositiveBuffExecute_d__25>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD08 RID: 56584 RVA: 0x00358FDC File Offset: 0x003571DC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DD09 RID: 56585 RVA: 0x00359010 File Offset: 0x00357210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205274, XrefRangeEnd = 205295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170047DC RID: 18396
			// (get) Token: 0x0600DD0A RID: 56586 RVA: 0x0035904C File Offset: 0x0035724C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD0B RID: 56587 RVA: 0x0035908C File Offset: 0x0035728C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205295, XrefRangeEnd = 205301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170047DD RID: 18397
			// (get) Token: 0x0600DD0C RID: 56588 RVA: 0x003590C0 File Offset: 0x003572C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Suika._OnPositiveBuffExecute_d__25.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DD0D RID: 56589 RVA: 0x00076143 File Offset: 0x00074343
			public _OnPositiveBuffExecute_d__25(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170047D6 RID: 18390
			// (get) Token: 0x0600DD0E RID: 56590 RVA: 0x00359100 File Offset: 0x00357300
			// (set) Token: 0x0600DD0F RID: 56591 RVA: 0x0007614C File Offset: 0x0007434C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170047D7 RID: 18391
			// (get) Token: 0x0600DD10 RID: 56592 RVA: 0x00359128 File Offset: 0x00357328
			// (set) Token: 0x0600DD11 RID: 56593 RVA: 0x00076167 File Offset: 0x00074367
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047D8 RID: 18392
			// (get) Token: 0x0600DD12 RID: 56594 RVA: 0x00359158 File Offset: 0x00357358
			// (set) Token: 0x0600DD13 RID: 56595 RVA: 0x00076186 File Offset: 0x00074386
			public unsafe Spell_Suika __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047D9 RID: 18393
			// (get) Token: 0x0600DD14 RID: 56596 RVA: 0x00359188 File Offset: 0x00357388
			// (set) Token: 0x0600DD15 RID: 56597 RVA: 0x000761A5 File Offset: 0x000743A5
			public unsafe Spell_Suika.__c__DisplayClass25_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Suika.__c__DisplayClass25_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170047DA RID: 18394
			// (get) Token: 0x0600DD16 RID: 56598 RVA: 0x003591B8 File Offset: 0x003573B8
			// (set) Token: 0x0600DD17 RID: 56599 RVA: 0x000761C4 File Offset: 0x000743C4
			public EventManager.SelectedValue _beerFromSuika_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr__beerFromSuika_5__2);
					return new EventManager.SelectedValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr__beerFromSuika_5__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170047DB RID: 18395
			// (get) Token: 0x0600DD18 RID: 56600 RVA: 0x003591E8 File Offset: 0x003573E8
			// (set) Token: 0x0600DD19 RID: 56601 RVA: 0x000761F2 File Offset: 0x000743F2
			public unsafe Vector3 _lastposition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr__lastposition_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Suika._OnPositiveBuffExecute_d__25.NativeFieldInfoPtr__lastposition_5__3)) = value;
				}
			}

			// Token: 0x04008D92 RID: 36242
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D93 RID: 36243
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D94 RID: 36244
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D95 RID: 36245
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008D96 RID: 36246
			private static readonly IntPtr NativeFieldInfoPtr__beerFromSuika_5__2;

			// Token: 0x04008D97 RID: 36247
			private static readonly IntPtr NativeFieldInfoPtr__lastposition_5__3;

			// Token: 0x04008D98 RID: 36248
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D99 RID: 36249
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D9A RID: 36250
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D9B RID: 36251
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D9C RID: 36252
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D9D RID: 36253
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
