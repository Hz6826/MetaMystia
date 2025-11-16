using System;
using DayScene.UI.RogueLike;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.UI.Miscellaneous;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200028B RID: 651
	public class Spell_Toyohime : SpellBase
	{
		// Token: 0x06005255 RID: 21077 RVA: 0x001B5D38 File Offset: 0x001B3F38
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Toyohime()
		{
			Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Toyohime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr);
			Spell_Toyohime.NativeFieldInfoPtr_exiledGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "exiledGuestNum");
			Spell_Toyohime.NativeFieldInfoPtr_positiveExtraRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "positiveExtraRate");
			Spell_Toyohime.NativeFieldInfoPtr_YORIHIME_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "YORIHIME_ID");
			Spell_Toyohime.NativeFieldInfoPtr_TOYOHIME_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "TOYOHIME_ID");
			Spell_Toyohime.NativeFieldInfoPtr_MIZUCHI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "MIZUCHI_ID");
			Spell_Toyohime.NativeFieldInfoPtr_KAGUYA_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "KAGUYA_ID");
			Spell_Toyohime.NativeFieldInfoPtr_mapSelectPanel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "mapSelectPanel");
			Spell_Toyohime.NativeFieldInfoPtr_moonVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "moonVfx");
			Spell_Toyohime.NativeFieldInfoPtr_moonDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "moonDelay");
			Spell_Toyohime.NativeFieldInfoPtr_lockVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "lockVfx");
			Spell_Toyohime.NativeFieldInfoPtr_lockDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "lockDelay");
			Spell_Toyohime.NativeFieldInfoPtr_negativeSfx_Moon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "negativeSfx_Moon");
			Spell_Toyohime.NativeFieldInfoPtr_negativeSfx_Peach = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "negativeSfx_Peach");
			Spell_Toyohime.NativeFieldInfoPtr_positiveSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "positiveSfx");
			Spell_Toyohime.NativeFieldInfoPtr_TOYOHIME_MAP_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "TOYOHIME_MAP_LABEL");
			Spell_Toyohime.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, 100679962);
			Spell_Toyohime.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, 100679963);
			Spell_Toyohime.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, 100679964);
			Spell_Toyohime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, 100679965);
			Spell_Toyohime.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_0_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, 100679966);
			Spell_Toyohime.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_1_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, 100679967);
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x001B5F0C File Offset: 0x001B410C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206837, XrefRangeEnd = 206839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Toyohime.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x001B5F50 File Offset: 0x001B4150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206839, XrefRangeEnd = 206844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Toyohime.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x001B5FAC File Offset: 0x001B41AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206844, XrefRangeEnd = 206849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Toyohime.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x001B6008 File Offset: 0x001B4208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206849, XrefRangeEnd = 206850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Toyohime() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x001B6044 File Offset: 0x001B4244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206850, XrefRangeEnd = 206851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnNegativeBuffExecute_b__17_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_0_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x001B6090 File Offset: 0x001B4290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206851, XrefRangeEnd = 206853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _OnNegativeBuffExecute_b__17_1(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_1_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x0002BFD8 File Offset: 0x0002A1D8
		public Spell_Toyohime(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x0600525D RID: 21085 RVA: 0x001B60DC File Offset: 0x001B42DC
		// (set) Token: 0x0600525E RID: 21086 RVA: 0x0002BFE1 File Offset: 0x0002A1E1
		public unsafe int exiledGuestNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_exiledGuestNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_exiledGuestNum)) = value;
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x0600525F RID: 21087 RVA: 0x001B6104 File Offset: 0x001B4304
		// (set) Token: 0x06005260 RID: 21088 RVA: 0x0002BFFC File Offset: 0x0002A1FC
		public unsafe float positiveExtraRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_positiveExtraRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_positiveExtraRate)) = value;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x06005261 RID: 21089 RVA: 0x001B612C File Offset: 0x001B432C
		// (set) Token: 0x06005262 RID: 21090 RVA: 0x0002C017 File Offset: 0x0002A217
		public unsafe static int YORIHIME_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.NativeFieldInfoPtr_YORIHIME_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.NativeFieldInfoPtr_YORIHIME_ID, (void*)(&value));
			}
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x06005263 RID: 21091 RVA: 0x001B6148 File Offset: 0x001B4348
		// (set) Token: 0x06005264 RID: 21092 RVA: 0x0002C025 File Offset: 0x0002A225
		public unsafe static int TOYOHIME_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.NativeFieldInfoPtr_TOYOHIME_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.NativeFieldInfoPtr_TOYOHIME_ID, (void*)(&value));
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x06005265 RID: 21093 RVA: 0x001B6164 File Offset: 0x001B4364
		// (set) Token: 0x06005266 RID: 21094 RVA: 0x0002C033 File Offset: 0x0002A233
		public unsafe static int MIZUCHI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.NativeFieldInfoPtr_MIZUCHI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.NativeFieldInfoPtr_MIZUCHI_ID, (void*)(&value));
			}
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06005267 RID: 21095 RVA: 0x001B6180 File Offset: 0x001B4380
		// (set) Token: 0x06005268 RID: 21096 RVA: 0x0002C041 File Offset: 0x0002A241
		public unsafe static int KAGUYA_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.NativeFieldInfoPtr_KAGUYA_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.NativeFieldInfoPtr_KAGUYA_ID, (void*)(&value));
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06005269 RID: 21097 RVA: 0x001B619C File Offset: 0x001B439C
		// (set) Token: 0x0600526A RID: 21098 RVA: 0x0002C04F File Offset: 0x0002A24F
		public unsafe DLC5_WorkSceneToyohimePanel mapSelectPanel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_mapSelectPanel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_WorkSceneToyohimePanel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_mapSelectPanel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x0600526B RID: 21099 RVA: 0x001B61CC File Offset: 0x001B43CC
		// (set) Token: 0x0600526C RID: 21100 RVA: 0x0002C06E File Offset: 0x0002A26E
		public unsafe GameObject moonVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_moonVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_moonVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x0600526D RID: 21101 RVA: 0x001B61FC File Offset: 0x001B43FC
		// (set) Token: 0x0600526E RID: 21102 RVA: 0x0002C08D File Offset: 0x0002A28D
		public unsafe float moonDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_moonDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_moonDelay)) = value;
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x0600526F RID: 21103 RVA: 0x001B6224 File Offset: 0x001B4424
		// (set) Token: 0x06005270 RID: 21104 RVA: 0x0002C0A8 File Offset: 0x0002A2A8
		public unsafe GameObject lockVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_lockVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_lockVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x06005271 RID: 21105 RVA: 0x001B6254 File Offset: 0x001B4454
		// (set) Token: 0x06005272 RID: 21106 RVA: 0x0002C0C7 File Offset: 0x0002A2C7
		public unsafe float lockDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_lockDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_lockDelay)) = value;
			}
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x06005273 RID: 21107 RVA: 0x001B627C File Offset: 0x001B447C
		// (set) Token: 0x06005274 RID: 21108 RVA: 0x0002C0E2 File Offset: 0x0002A2E2
		public SpellBase.DelayAudioClip negativeSfx_Moon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_negativeSfx_Moon);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_negativeSfx_Moon), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x06005275 RID: 21109 RVA: 0x001B62AC File Offset: 0x001B44AC
		// (set) Token: 0x06005276 RID: 21110 RVA: 0x0002C110 File Offset: 0x0002A310
		public SpellBase.DelayAudioClip negativeSfx_Peach
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_negativeSfx_Peach);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_negativeSfx_Peach), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x06005277 RID: 21111 RVA: 0x001B62DC File Offset: 0x001B44DC
		// (set) Token: 0x06005278 RID: 21112 RVA: 0x0002C13E File Offset: 0x0002A33E
		public unsafe AudioClip positiveSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_positiveSfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.NativeFieldInfoPtr_positiveSfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06005279 RID: 21113 RVA: 0x001B630C File Offset: 0x001B450C
		// (set) Token: 0x0600527A RID: 21114 RVA: 0x0002C15D File Offset: 0x0002A35D
		public unsafe static string TOYOHIME_MAP_LABEL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.NativeFieldInfoPtr_TOYOHIME_MAP_LABEL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.NativeFieldInfoPtr_TOYOHIME_MAP_LABEL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003787 RID: 14215
		private static readonly IntPtr NativeFieldInfoPtr_exiledGuestNum;

		// Token: 0x04003788 RID: 14216
		private static readonly IntPtr NativeFieldInfoPtr_positiveExtraRate;

		// Token: 0x04003789 RID: 14217
		private static readonly IntPtr NativeFieldInfoPtr_YORIHIME_ID;

		// Token: 0x0400378A RID: 14218
		private static readonly IntPtr NativeFieldInfoPtr_TOYOHIME_ID;

		// Token: 0x0400378B RID: 14219
		private static readonly IntPtr NativeFieldInfoPtr_MIZUCHI_ID;

		// Token: 0x0400378C RID: 14220
		private static readonly IntPtr NativeFieldInfoPtr_KAGUYA_ID;

		// Token: 0x0400378D RID: 14221
		private static readonly IntPtr NativeFieldInfoPtr_mapSelectPanel;

		// Token: 0x0400378E RID: 14222
		private static readonly IntPtr NativeFieldInfoPtr_moonVfx;

		// Token: 0x0400378F RID: 14223
		private static readonly IntPtr NativeFieldInfoPtr_moonDelay;

		// Token: 0x04003790 RID: 14224
		private static readonly IntPtr NativeFieldInfoPtr_lockVfx;

		// Token: 0x04003791 RID: 14225
		private static readonly IntPtr NativeFieldInfoPtr_lockDelay;

		// Token: 0x04003792 RID: 14226
		private static readonly IntPtr NativeFieldInfoPtr_negativeSfx_Moon;

		// Token: 0x04003793 RID: 14227
		private static readonly IntPtr NativeFieldInfoPtr_negativeSfx_Peach;

		// Token: 0x04003794 RID: 14228
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfx;

		// Token: 0x04003795 RID: 14229
		private static readonly IntPtr NativeFieldInfoPtr_TOYOHIME_MAP_LABEL;

		// Token: 0x04003796 RID: 14230
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003797 RID: 14231
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003798 RID: 14232
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003799 RID: 14233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400379A RID: 14234
		private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_0_Private_Boolean_Int32_0;

		// Token: 0x0400379B RID: 14235
		private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_1_Private_Boolean_Int32_0;

		// Token: 0x02000BE9 RID: 3049
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE29 RID: 56873 RVA: 0x0035C420 File Offset: 0x0035A620
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_0>.NativeClassPtr);
				Spell_Toyohime.__c__DisplayClass16_0.NativeFieldInfoPtr_openedList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_0>.NativeClassPtr, "openedList");
				Spell_Toyohime.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				Spell_Toyohime.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_0>.NativeClassPtr, 100679968);
				Spell_Toyohime.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_0>.NativeClassPtr, 100679969);
				Spell_Toyohime.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_0>.NativeClassPtr, 100679970);
			}

			// Token: 0x0600DE2A RID: 56874 RVA: 0x0035C4B0 File Offset: 0x0035A6B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE2B RID: 56875 RVA: 0x0035C4EC File Offset: 0x0035A6EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206290, XrefRangeEnd = 206294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__1(string spotName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(spotName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE2C RID: 56876 RVA: 0x0035C53C File Offset: 0x0035A73C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206294, XrefRangeEnd = 206457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(string targetMap)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(targetMap);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE2D RID: 56877 RVA: 0x00076A8E File Offset: 0x00074C8E
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004834 RID: 18484
			// (get) Token: 0x0600DE2E RID: 56878 RVA: 0x0035C580 File Offset: 0x0035A780
			// (set) Token: 0x0600DE2F RID: 56879 RVA: 0x00076A97 File Offset: 0x00074C97
			public unsafe List<string> openedList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_0.NativeFieldInfoPtr_openedList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_0.NativeFieldInfoPtr_openedList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004835 RID: 18485
			// (get) Token: 0x0600DE30 RID: 56880 RVA: 0x0035C5B0 File Offset: 0x0035A7B0
			// (set) Token: 0x0600DE31 RID: 56881 RVA: 0x00076AB6 File Offset: 0x00074CB6
			public unsafe Spell_Toyohime __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toyohime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E3F RID: 36415
			private static readonly IntPtr NativeFieldInfoPtr_openedList;

			// Token: 0x04008E40 RID: 36416
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E41 RID: 36417
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E42 RID: 36418
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Boolean_String_0;

			// Token: 0x04008E43 RID: 36419
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_String_0;
		}

		// Token: 0x02000BEA RID: 3050
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c__DisplayClass16_1")]
		public sealed class __c__DisplayClass16_1 : Il2CppSystem.Object
		{
			// Token: 0x0600DE32 RID: 56882 RVA: 0x0035C5E0 File Offset: 0x0035A7E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_1()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c__DisplayClass16_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_1>.NativeClassPtr);
				Spell_Toyohime.__c__DisplayClass16_1.NativeFieldInfoPtr_izakayas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_1>.NativeClassPtr, "izakayas");
				Spell_Toyohime.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_1>.NativeClassPtr, 100679971);
				Spell_Toyohime.__c__DisplayClass16_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_1>.NativeClassPtr, 100679972);
			}

			// Token: 0x0600DE33 RID: 56883 RVA: 0x0035C648 File Offset: 0x0035A848
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE34 RID: 56884 RVA: 0x0035C684 File Offset: 0x0035A884
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206457, XrefRangeEnd = 206464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE35 RID: 56885 RVA: 0x00076AD5 File Offset: 0x00074CD5
			public __c__DisplayClass16_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004836 RID: 18486
			// (get) Token: 0x0600DE36 RID: 56886 RVA: 0x0035C6D0 File Offset: 0x0035A8D0
			// (set) Token: 0x0600DE37 RID: 56887 RVA: 0x00076ADE File Offset: 0x00074CDE
			public ValueTuple<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>> izakayas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_1.NativeFieldInfoPtr_izakayas);
					return new ValueTuple<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_1.NativeFieldInfoPtr_izakayas), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<IReadOnlyList<int>, IReadOnlyList<int>, IReadOnlyList<int>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04008E44 RID: 36420
			private static readonly IntPtr NativeFieldInfoPtr_izakayas;

			// Token: 0x04008E45 RID: 36421
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E46 RID: 36422
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000BEB RID: 3051
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c__DisplayClass16_2")]
		public sealed class __c__DisplayClass16_2 : Il2CppSystem.Object
		{
			// Token: 0x0600DE38 RID: 56888 RVA: 0x0035C700 File Offset: 0x0035A900
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_2()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c__DisplayClass16_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_2>.NativeClassPtr);
				Spell_Toyohime.__c__DisplayClass16_2.NativeFieldInfoPtr_rogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_2>.NativeClassPtr, "rogueLikeRunTimeData");
				Spell_Toyohime.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_2>.NativeClassPtr, 100679973);
				Spell_Toyohime.__c__DisplayClass16_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_2>.NativeClassPtr, 100679974);
			}

			// Token: 0x0600DE39 RID: 56889 RVA: 0x0035C768 File Offset: 0x0035A968
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE3A RID: 56890 RVA: 0x0035C7A4 File Offset: 0x0035A9A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206464, XrefRangeEnd = 206467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__5(string spotName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(spotName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE3B RID: 56891 RVA: 0x00076B0C File Offset: 0x00074D0C
			public __c__DisplayClass16_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004837 RID: 18487
			// (get) Token: 0x0600DE3C RID: 56892 RVA: 0x0035C7F4 File Offset: 0x0035A9F4
			// (set) Token: 0x0600DE3D RID: 56893 RVA: 0x00076B15 File Offset: 0x00074D15
			public unsafe RogueLikeRunTimeData rogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_2.NativeFieldInfoPtr_rogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_2.NativeFieldInfoPtr_rogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E47 RID: 36423
			private static readonly IntPtr NativeFieldInfoPtr_rogueLikeRunTimeData;

			// Token: 0x04008E48 RID: 36424
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E49 RID: 36425
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Boolean_String_0;
		}

		// Token: 0x02000BEC RID: 3052
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c__DisplayClass16_3")]
		public sealed class __c__DisplayClass16_3 : Il2CppSystem.Object
		{
			// Token: 0x0600DE3E RID: 56894 RVA: 0x0035C824 File Offset: 0x0035AA24
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_3()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c__DisplayClass16_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_3>.NativeClassPtr);
				Spell_Toyohime.__c__DisplayClass16_3.NativeFieldInfoPtr_targetMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_3>.NativeClassPtr, "targetMap");
				Spell_Toyohime.__c__DisplayClass16_3.NativeFieldInfoPtr_interrupt1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_3>.NativeClassPtr, "interrupt1");
				Spell_Toyohime.__c__DisplayClass16_3.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_3>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Toyohime.__c__DisplayClass16_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_3>.NativeClassPtr, 100679975);
				Spell_Toyohime.__c__DisplayClass16_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_3>.NativeClassPtr, 100679976);
				Spell_Toyohime.__c__DisplayClass16_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_3>.NativeClassPtr, 100679977);
			}

			// Token: 0x0600DE3F RID: 56895 RVA: 0x0035C8C8 File Offset: 0x0035AAC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE40 RID: 56896 RVA: 0x0035C904 File Offset: 0x0035AB04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206467, XrefRangeEnd = 206473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnPositiveBuffExecute_b__13(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DE41 RID: 56897 RVA: 0x0035C94C File Offset: 0x0035AB4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206473, XrefRangeEnd = 206480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_3.NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE42 RID: 56898 RVA: 0x00076B34 File Offset: 0x00074D34
			public __c__DisplayClass16_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004838 RID: 18488
			// (get) Token: 0x0600DE43 RID: 56899 RVA: 0x0035C980 File Offset: 0x0035AB80
			// (set) Token: 0x0600DE44 RID: 56900 RVA: 0x00076B3D File Offset: 0x00074D3D
			public unsafe string targetMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_3.NativeFieldInfoPtr_targetMap);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_3.NativeFieldInfoPtr_targetMap), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004839 RID: 18489
			// (get) Token: 0x0600DE45 RID: 56901 RVA: 0x0035C9A8 File Offset: 0x0035ABA8
			// (set) Token: 0x0600DE46 RID: 56902 RVA: 0x00076B5C File Offset: 0x00074D5C
			public unsafe Action interrupt1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_3.NativeFieldInfoPtr_interrupt1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_3.NativeFieldInfoPtr_interrupt1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700483A RID: 18490
			// (get) Token: 0x0600DE47 RID: 56903 RVA: 0x0035C9D8 File Offset: 0x0035ABD8
			// (set) Token: 0x0600DE48 RID: 56904 RVA: 0x00076B7B File Offset: 0x00074D7B
			public unsafe Spell_Toyohime.__c__DisplayClass16_0 field_Public___c__DisplayClass16_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_3.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toyohime.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_3.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E4A RID: 36426
			private static readonly IntPtr NativeFieldInfoPtr_targetMap;

			// Token: 0x04008E4B RID: 36427
			private static readonly IntPtr NativeFieldInfoPtr_interrupt1;

			// Token: 0x04008E4C RID: 36428
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0;

			// Token: 0x04008E4D RID: 36429
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E4E RID: 36430
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__13_Internal_String_String_0;

			// Token: 0x04008E4F RID: 36431
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_Internal_Void_0;
		}

		// Token: 0x02000BED RID: 3053
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c__DisplayClass16_4")]
		public sealed class __c__DisplayClass16_4 : Il2CppSystem.Object
		{
			// Token: 0x0600DE49 RID: 56905 RVA: 0x0035CA08 File Offset: 0x0035AC08
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_4()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c__DisplayClass16_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_4>.NativeClassPtr);
				Spell_Toyohime.__c__DisplayClass16_4.NativeFieldInfoPtr_izakayaData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_4>.NativeClassPtr, "izakayaData");
				Spell_Toyohime.__c__DisplayClass16_4.NativeFieldInfoPtr_mizuchiCouldControlGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_4>.NativeClassPtr, "mizuchiCouldControlGuest");
				Spell_Toyohime.__c__DisplayClass16_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_4>.NativeClassPtr, 100679978);
				Spell_Toyohime.__c__DisplayClass16_4.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_4>.NativeClassPtr, 100679979);
				Spell_Toyohime.__c__DisplayClass16_4.NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_4>.NativeClassPtr, 100679980);
			}

			// Token: 0x0600DE4A RID: 56906 RVA: 0x0035CA98 File Offset: 0x0035AC98
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE4B RID: 56907 RVA: 0x0035CAD4 File Offset: 0x0035ACD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206480, XrefRangeEnd = 206527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__6(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_4.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE4C RID: 56908 RVA: 0x0035CB24 File Offset: 0x0035AD24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206527, XrefRangeEnd = 206530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__8(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_4.NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE4D RID: 56909 RVA: 0x00076B9A File Offset: 0x00074D9A
			public __c__DisplayClass16_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700483B RID: 18491
			// (get) Token: 0x0600DE4E RID: 56910 RVA: 0x0035CB74 File Offset: 0x0035AD74
			// (set) Token: 0x0600DE4F RID: 56911 RVA: 0x00076BA3 File Offset: 0x00074DA3
			public unsafe Izakaya izakayaData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_4.NativeFieldInfoPtr_izakayaData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_4.NativeFieldInfoPtr_izakayaData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700483C RID: 18492
			// (get) Token: 0x0600DE50 RID: 56912 RVA: 0x0035CBA4 File Offset: 0x0035ADA4
			// (set) Token: 0x0600DE51 RID: 56913 RVA: 0x00076BC2 File Offset: 0x00074DC2
			public unsafe Il2CppStructArray<int> mizuchiCouldControlGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_4.NativeFieldInfoPtr_mizuchiCouldControlGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_4.NativeFieldInfoPtr_mizuchiCouldControlGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E50 RID: 36432
			private static readonly IntPtr NativeFieldInfoPtr_izakayaData;

			// Token: 0x04008E51 RID: 36433
			private static readonly IntPtr NativeFieldInfoPtr_mizuchiCouldControlGuest;

			// Token: 0x04008E52 RID: 36434
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E53 RID: 36435
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Boolean_SpecialGuestGroup_0;

			// Token: 0x04008E54 RID: 36436
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__8_Internal_Boolean_SpecialGuestGroup_0;
		}

		// Token: 0x02000BEE RID: 3054
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c__DisplayClass16_5")]
		public sealed class __c__DisplayClass16_5 : Il2CppSystem.Object
		{
			// Token: 0x0600DE52 RID: 56914 RVA: 0x0035CBD4 File Offset: 0x0035ADD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_5()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c__DisplayClass16_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_5>.NativeClassPtr);
				Spell_Toyohime.__c__DisplayClass16_5.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_5>.NativeClassPtr, "x");
				Spell_Toyohime.__c__DisplayClass16_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_5>.NativeClassPtr, 100679981);
				Spell_Toyohime.__c__DisplayClass16_5.NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_5>.NativeClassPtr, 100679982);
			}

			// Token: 0x0600DE53 RID: 56915 RVA: 0x0035CC3C File Offset: 0x0035AE3C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass16_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE54 RID: 56916 RVA: 0x0035CC78 File Offset: 0x0035AE78
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__11(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass16_5.NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE55 RID: 56917 RVA: 0x00076BE1 File Offset: 0x00074DE1
			public __c__DisplayClass16_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700483D RID: 18493
			// (get) Token: 0x0600DE56 RID: 56918 RVA: 0x0035CCC4 File Offset: 0x0035AEC4
			// (set) Token: 0x0600DE57 RID: 56919 RVA: 0x00076BEA File Offset: 0x00074DEA
			public unsafe Izakaya.SpecialGuestGroup x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_5.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya.SpecialGuestGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass16_5.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E55 RID: 36437
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04008E56 RID: 36438
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E57 RID: 36439
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000BEF RID: 3055
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DE58 RID: 56920 RVA: 0x0035CCF4 File Offset: 0x0035AEF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr);
				Spell_Toyohime.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, "<>9");
				Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, "<>9__16_3");
				Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, "<>9__16_0");
				Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, "<>9__16_10");
				Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, "<>9__16_7");
				Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, "<>9__16_9");
				Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, "<>9__16_12");
				Spell_Toyohime.__c.NativeFieldInfoPtr___9__17_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, "<>9__17_3");
				Spell_Toyohime.__c.NativeFieldInfoPtr___9__17_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, "<>9__17_14");
				Spell_Toyohime.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, 100679984);
				Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_0_Internal_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, 100679985);
				Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_3_Internal_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, 100679986);
				Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_10_Internal_IEnumerable_1_Int32_ValueTuple_2_Int32_PartnerBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, 100679987);
				Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_7_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, 100679988);
				Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_9_Internal_Int32_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, 100679989);
				Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_12_Internal_Int32_KeyValuePair_2_Int32_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, 100679990);
				Spell_Toyohime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_3_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, 100679991);
				Spell_Toyohime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_14_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr, 100679992);
			}

			// Token: 0x0600DE59 RID: 56921 RVA: 0x0035CE88 File Offset: 0x0035B088
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE5A RID: 56922 RVA: 0x0035CEC4 File Offset: 0x0035B0C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206530, XrefRangeEnd = 206561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__16_0(string spotName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(spotName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_0_Internal_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE5B RID: 56923 RVA: 0x0035CF14 File Offset: 0x0035B114
			[CallerCount(0)]
			public unsafe int _OnPositiveBuffExecute_b__16_3(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_3_Internal_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE5C RID: 56924 RVA: 0x0035CF64 File Offset: 0x0035B164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206561, XrefRangeEnd = 206567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _OnPositiveBuffExecute_b__16_10(ValueTuple<int, PartnerBase> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_10_Internal_IEnumerable_1_Int32_ValueTuple_2_Int32_PartnerBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600DE5D RID: 56925 RVA: 0x0035CFBC File Offset: 0x0035B1BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206567, XrefRangeEnd = 206573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPositiveBuffExecute_b__16_7(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_7_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE5E RID: 56926 RVA: 0x0035D00C File Offset: 0x0035B20C
			[CallerCount(0)]
			public unsafe int _OnPositiveBuffExecute_b__16_9(Izakaya.SpecialGuestGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_9_Internal_Int32_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE5F RID: 56927 RVA: 0x0035D05C File Offset: 0x0035B25C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206573, XrefRangeEnd = 206574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _OnPositiveBuffExecute_b__16_12(KeyValuePair<int, Vector2> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_12_Internal_Int32_KeyValuePair_2_Int32_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600DE60 RID: 56928 RVA: 0x0035D0B0 File Offset: 0x0035B2B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206574, XrefRangeEnd = 206580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__17_3(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_3_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DE61 RID: 56929 RVA: 0x0035D0F4 File Offset: 0x0035B2F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206580, XrefRangeEnd = 206586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__17_14(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_14_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DE62 RID: 56930 RVA: 0x00076C09 File Offset: 0x00074E09
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700483E RID: 18494
			// (get) Token: 0x0600DE63 RID: 56931 RVA: 0x0035D138 File Offset: 0x0035B338
			// (set) Token: 0x0600DE64 RID: 56932 RVA: 0x00076C12 File Offset: 0x00074E12
			public unsafe static Spell_Toyohime.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toyohime.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700483F RID: 18495
			// (get) Token: 0x0600DE65 RID: 56933 RVA: 0x0035D160 File Offset: 0x0035B360
			// (set) Token: 0x0600DE66 RID: 56934 RVA: 0x00076C24 File Offset: 0x00074E24
			public unsafe static Func<Izakaya, int> __9__16_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004840 RID: 18496
			// (get) Token: 0x0600DE67 RID: 56935 RVA: 0x0035D188 File Offset: 0x0035B388
			// (set) Token: 0x0600DE68 RID: 56936 RVA: 0x00076C36 File Offset: 0x00074E36
			public unsafe static Predicate<string> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004841 RID: 18497
			// (get) Token: 0x0600DE69 RID: 56937 RVA: 0x0035D1B0 File Offset: 0x0035B3B0
			// (set) Token: 0x0600DE6A RID: 56938 RVA: 0x00076C48 File Offset: 0x00074E48
			public unsafe static Func<ValueTuple<int, PartnerBase>, IEnumerable<int>> __9__16_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<int, PartnerBase>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004842 RID: 18498
			// (get) Token: 0x0600DE6B RID: 56939 RVA: 0x0035D1D8 File Offset: 0x0035B3D8
			// (set) Token: 0x0600DE6C RID: 56940 RVA: 0x00076C5A File Offset: 0x00074E5A
			public unsafe static Func<Izakaya.SpecialGuestGroup, bool> __9__16_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.SpecialGuestGroup, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004843 RID: 18499
			// (get) Token: 0x0600DE6D RID: 56941 RVA: 0x0035D200 File Offset: 0x0035B400
			// (set) Token: 0x0600DE6E RID: 56942 RVA: 0x00076C6C File Offset: 0x00074E6C
			public unsafe static Func<Izakaya.SpecialGuestGroup, int> __9__16_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.SpecialGuestGroup, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004844 RID: 18500
			// (get) Token: 0x0600DE6F RID: 56943 RVA: 0x0035D228 File Offset: 0x0035B428
			// (set) Token: 0x0600DE70 RID: 56944 RVA: 0x00076C7E File Offset: 0x00074E7E
			public unsafe static Func<KeyValuePair<int, Vector2>, int> __9__16_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, Vector2>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__16_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004845 RID: 18501
			// (get) Token: 0x0600DE71 RID: 56945 RVA: 0x0035D250 File Offset: 0x0035B450
			// (set) Token: 0x0600DE72 RID: 56946 RVA: 0x00076C90 File Offset: 0x00074E90
			public unsafe static Func<int, string> __9__17_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__17_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__17_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004846 RID: 18502
			// (get) Token: 0x0600DE73 RID: 56947 RVA: 0x0035D278 File Offset: 0x0035B478
			// (set) Token: 0x0600DE74 RID: 56948 RVA: 0x00076CA2 File Offset: 0x00074EA2
			public unsafe static Func<int, string> __9__17_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__17_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Toyohime.__c.NativeFieldInfoPtr___9__17_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E58 RID: 36440
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008E59 RID: 36441
			private static readonly IntPtr NativeFieldInfoPtr___9__16_3;

			// Token: 0x04008E5A RID: 36442
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04008E5B RID: 36443
			private static readonly IntPtr NativeFieldInfoPtr___9__16_10;

			// Token: 0x04008E5C RID: 36444
			private static readonly IntPtr NativeFieldInfoPtr___9__16_7;

			// Token: 0x04008E5D RID: 36445
			private static readonly IntPtr NativeFieldInfoPtr___9__16_9;

			// Token: 0x04008E5E RID: 36446
			private static readonly IntPtr NativeFieldInfoPtr___9__16_12;

			// Token: 0x04008E5F RID: 36447
			private static readonly IntPtr NativeFieldInfoPtr___9__17_3;

			// Token: 0x04008E60 RID: 36448
			private static readonly IntPtr NativeFieldInfoPtr___9__17_14;

			// Token: 0x04008E61 RID: 36449
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E62 RID: 36450
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_0_Internal_Boolean_String_0;

			// Token: 0x04008E63 RID: 36451
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_3_Internal_Int32_Izakaya_0;

			// Token: 0x04008E64 RID: 36452
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_10_Internal_IEnumerable_1_Int32_ValueTuple_2_Int32_PartnerBase_0;

			// Token: 0x04008E65 RID: 36453
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_7_Internal_Boolean_SpecialGuestGroup_0;

			// Token: 0x04008E66 RID: 36454
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_9_Internal_Int32_SpecialGuestGroup_0;

			// Token: 0x04008E67 RID: 36455
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__16_12_Internal_Int32_KeyValuePair_2_Int32_Vector2_0;

			// Token: 0x04008E68 RID: 36456
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_3_Internal_String_Int32_0;

			// Token: 0x04008E69 RID: 36457
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__17_14_Internal_String_Int32_0;
		}

		// Token: 0x02000BF0 RID: 3056
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<OnPositiveBuffExecute>d__16")]
		public sealed class _OnPositiveBuffExecute_d__16 : Il2CppSystem.Object
		{
			// Token: 0x0600DE75 RID: 56949 RVA: 0x0035D2A0 File Offset: 0x0035B4A0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__16()
			{
				Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<OnPositiveBuffExecute>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr);
				Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>1__state");
				Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>2__current");
				Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>4__this");
				Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679993);
				Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679994);
				Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679995);
				Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679996);
				Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679997);
				Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100679998);
			}

			// Token: 0x0600DE76 RID: 56950 RVA: 0x0035D380 File Offset: 0x0035B580
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime._OnPositiveBuffExecute_d__16>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE77 RID: 56951 RVA: 0x0035D3C8 File Offset: 0x0035B5C8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE78 RID: 56952 RVA: 0x0035D3FC File Offset: 0x0035B5FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206586, XrefRangeEnd = 206661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700484A RID: 18506
			// (get) Token: 0x0600DE79 RID: 56953 RVA: 0x0035D438 File Offset: 0x0035B638
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE7A RID: 56954 RVA: 0x0035D478 File Offset: 0x0035B678
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206661, XrefRangeEnd = 206667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700484B RID: 18507
			// (get) Token: 0x0600DE7B RID: 56955 RVA: 0x0035D4AC File Offset: 0x0035B6AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DE7C RID: 56956 RVA: 0x00076CB4 File Offset: 0x00074EB4
			public _OnPositiveBuffExecute_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004847 RID: 18503
			// (get) Token: 0x0600DE7D RID: 56957 RVA: 0x0035D4EC File Offset: 0x0035B6EC
			// (set) Token: 0x0600DE7E RID: 56958 RVA: 0x00076CBD File Offset: 0x00074EBD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004848 RID: 18504
			// (get) Token: 0x0600DE7F RID: 56959 RVA: 0x0035D514 File Offset: 0x0035B714
			// (set) Token: 0x0600DE80 RID: 56960 RVA: 0x00076CD8 File Offset: 0x00074ED8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004849 RID: 18505
			// (get) Token: 0x0600DE81 RID: 56961 RVA: 0x0035D544 File Offset: 0x0035B744
			// (set) Token: 0x0600DE82 RID: 56962 RVA: 0x00076CF7 File Offset: 0x00074EF7
			public unsafe Spell_Toyohime __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toyohime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E6A RID: 36458
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E6B RID: 36459
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E6C RID: 36460
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E6D RID: 36461
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E6E RID: 36462
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E6F RID: 36463
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E70 RID: 36464
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E71 RID: 36465
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E72 RID: 36466
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BF1 RID: 3057
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DE83 RID: 56963 RVA: 0x0035D574 File Offset: 0x0035B774
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr);
				Spell_Toyohime.__c__DisplayClass17_0.NativeFieldInfoPtr_finalExiledGuestNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr, "finalExiledGuestNum");
				Spell_Toyohime.__c__DisplayClass17_0.NativeFieldInfoPtr_exiledGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr, "exiledGuestId");
				Spell_Toyohime.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr, 100679999);
				Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr, 100680000);
				Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_byref___c__DisplayClass17_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr, 100680001);
				Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__12_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr, 100680002);
				Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__13_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr, 100680003);
			}

			// Token: 0x0600DE84 RID: 56964 RVA: 0x0035D640 File Offset: 0x0035B840
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE85 RID: 56965 RVA: 0x0035D67C File Offset: 0x0035B87C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206667, XrefRangeEnd = 206672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE86 RID: 56966 RVA: 0x0035D6C0 File Offset: 0x0035B8C0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 206732, RefRangeEnd = 206733, XrefRangeStart = 206672, XrefRangeEnd = 206732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_byref___c__DisplayClass17_1_0(int index, ref Spell_Toyohime.__c__DisplayClass17_1 A_2)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref index;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_byref___c__DisplayClass17_1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE87 RID: 56967 RVA: 0x0035D714 File Offset: 0x0035B914
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206733, XrefRangeEnd = 206757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__12(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__12_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600DE88 RID: 56968 RVA: 0x0035D75C File Offset: 0x0035B95C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206757, XrefRangeEnd = 206762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__13()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__13_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE89 RID: 56969 RVA: 0x00076D16 File Offset: 0x00074F16
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700484C RID: 18508
			// (get) Token: 0x0600DE8A RID: 56970 RVA: 0x0035D790 File Offset: 0x0035B990
			// (set) Token: 0x0600DE8B RID: 56971 RVA: 0x00076D1F File Offset: 0x00074F1F
			public unsafe int finalExiledGuestNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_0.NativeFieldInfoPtr_finalExiledGuestNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_0.NativeFieldInfoPtr_finalExiledGuestNum)) = value;
				}
			}

			// Token: 0x1700484D RID: 18509
			// (get) Token: 0x0600DE8C RID: 56972 RVA: 0x0035D7B8 File Offset: 0x0035B9B8
			// (set) Token: 0x0600DE8D RID: 56973 RVA: 0x00076D3A File Offset: 0x00074F3A
			public unsafe Il2CppStructArray<int> exiledGuestId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_0.NativeFieldInfoPtr_exiledGuestId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_0.NativeFieldInfoPtr_exiledGuestId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700484E RID: 18510
			// (get) Token: 0x0600DE8E RID: 56974 RVA: 0x0035D7E8 File Offset: 0x0035B9E8
			// (set) Token: 0x0600DE8F RID: 56975 RVA: 0x00076D59 File Offset: 0x00074F59
			public unsafe Spell_Toyohime __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toyohime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E73 RID: 36467
			private static readonly IntPtr NativeFieldInfoPtr_finalExiledGuestNum;

			// Token: 0x04008E74 RID: 36468
			private static readonly IntPtr NativeFieldInfoPtr_exiledGuestId;

			// Token: 0x04008E75 RID: 36469
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E76 RID: 36470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E77 RID: 36471
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_GameObject_0;

			// Token: 0x04008E78 RID: 36472
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_byref___c__DisplayClass17_1_0;

			// Token: 0x04008E79 RID: 36473
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__12_Internal_String_String_0;

			// Token: 0x04008E7A RID: 36474
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__13_Internal_Void_0;
		}

		// Token: 0x02000BF2 RID: 3058
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c__DisplayClass17_1")]
		public sealed class __c__DisplayClass17_1 : ValueType
		{
			// Token: 0x0600DE90 RID: 56976 RVA: 0x00076D78 File Offset: 0x00074F78
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_1>.NativeClassPtr);
				Spell_Toyohime.__c__DisplayClass17_1.NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_1>.NativeClassPtr, "cluster");
			}

			// Token: 0x0600DE91 RID: 56977 RVA: 0x00076DAC File Offset: 0x00074FAC
			public __c__DisplayClass17_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600DE92 RID: 56978 RVA: 0x00076DB5 File Offset: 0x00074FB5
			public __c__DisplayClass17_1() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_1>.NativeClassPtr))
			{
			}

			// Token: 0x1700484F RID: 18511
			// (get) Token: 0x0600DE93 RID: 56979 RVA: 0x0035D818 File Offset: 0x0035BA18
			// (set) Token: 0x0600DE94 RID: 56980 RVA: 0x00076DC7 File Offset: 0x00074FC7
			public unsafe UIElementCluster cluster
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_1.NativeFieldInfoPtr_cluster);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_1.NativeFieldInfoPtr_cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E7B RID: 36475
			private static readonly IntPtr NativeFieldInfoPtr_cluster;
		}

		// Token: 0x02000BF3 RID: 3059
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<>c__DisplayClass17_2")]
		public sealed class __c__DisplayClass17_2 : Il2CppSystem.Object
		{
			// Token: 0x0600DE95 RID: 56981 RVA: 0x0035D848 File Offset: 0x0035BA48
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_2()
			{
				Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<>c__DisplayClass17_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr);
				Spell_Toyohime.__c__DisplayClass17_2.NativeFieldInfoPtr_specialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, "specialGuest");
				Spell_Toyohime.__c__DisplayClass17_2.NativeFieldInfoPtr_colorScheme = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, "colorScheme");
				Spell_Toyohime.__c__DisplayClass17_2.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, "pixel");
				Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, 100680004);
				Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, 100680005);
				Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, 100680006);
				Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, 100680007);
				Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, 100680008);
				Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, 100680009);
				Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, 100680010);
				Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr, 100680011);
			}

			// Token: 0x0600DE96 RID: 56982 RVA: 0x0035D950 File Offset: 0x0035BB50
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime.__c__DisplayClass17_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE97 RID: 56983 RVA: 0x0035D98C File Offset: 0x0035BB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE98 RID: 56984 RVA: 0x0035D9D0 File Offset: 0x0035BBD0
			[CallerCount(0)]
			public unsafe void _OnNegativeBuffExecute_b__6(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE99 RID: 56985 RVA: 0x0035DA14 File Offset: 0x0035BC14
			[CallerCount(0)]
			public unsafe void _OnNegativeBuffExecute_b__7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE9A RID: 56986 RVA: 0x0035DA58 File Offset: 0x0035BC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE9B RID: 56987 RVA: 0x0035DA9C File Offset: 0x0035BC9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE9C RID: 56988 RVA: 0x0035DAE0 File Offset: 0x0035BCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE9D RID: 56989 RVA: 0x0035DB24 File Offset: 0x0035BD24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime.__c__DisplayClass17_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DE9E RID: 56990 RVA: 0x00076DE6 File Offset: 0x00074FE6
			public __c__DisplayClass17_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004850 RID: 18512
			// (get) Token: 0x0600DE9F RID: 56991 RVA: 0x0035DB68 File Offset: 0x0035BD68
			// (set) Token: 0x0600DEA0 RID: 56992 RVA: 0x00076DEF File Offset: 0x00074FEF
			public unsafe SpecialGuest specialGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_2.NativeFieldInfoPtr_specialGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_2.NativeFieldInfoPtr_specialGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004851 RID: 18513
			// (get) Token: 0x0600DEA1 RID: 56993 RVA: 0x0035DB98 File Offset: 0x0035BD98
			// (set) Token: 0x0600DEA2 RID: 56994 RVA: 0x00076E0E File Offset: 0x0007500E
			public unsafe Il2CppStructArray<Color> colorScheme
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_2.NativeFieldInfoPtr_colorScheme);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Color>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_2.NativeFieldInfoPtr_colorScheme), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004852 RID: 18514
			// (get) Token: 0x0600DEA3 RID: 56995 RVA: 0x0035DBC8 File Offset: 0x0035BDC8
			// (set) Token: 0x0600DEA4 RID: 56996 RVA: 0x00076E2D File Offset: 0x0007502D
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_2.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime.__c__DisplayClass17_2.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E7C RID: 36476
			private static readonly IntPtr NativeFieldInfoPtr_specialGuest;

			// Token: 0x04008E7D RID: 36477
			private static readonly IntPtr NativeFieldInfoPtr_colorScheme;

			// Token: 0x04008E7E RID: 36478
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x04008E7F RID: 36479
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008E80 RID: 36480
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04008E81 RID: 36481
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__6_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04008E82 RID: 36482
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_Image_0;

			// Token: 0x04008E83 RID: 36483
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__8_Internal_Void_Image_0;

			// Token: 0x04008E84 RID: 36484
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__9_Internal_Void_Image_0;

			// Token: 0x04008E85 RID: 36485
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__10_Internal_Void_Image_0;

			// Token: 0x04008E86 RID: 36486
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_Internal_Void_Image_0;
		}

		// Token: 0x02000BF4 RID: 3060
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Toyohime+<OnNegativeBuffExecute>d__17")]
		public sealed class _OnNegativeBuffExecute_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600DEA5 RID: 56997 RVA: 0x0035DBF8 File Offset: 0x0035BDF8
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__17()
			{
				Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Toyohime>.NativeClassPtr, "<OnNegativeBuffExecute>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr);
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>1__state");
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>2__current");
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>4__this");
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, "<>8__1");
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100680012);
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100680013);
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100680014);
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100680015);
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100680016);
				Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr, 100680017);
			}

			// Token: 0x0600DEA6 RID: 56998 RVA: 0x0035DCEC File Offset: 0x0035BEEC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Toyohime._OnNegativeBuffExecute_d__17>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEA7 RID: 56999 RVA: 0x0035DD34 File Offset: 0x0035BF34
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DEA8 RID: 57000 RVA: 0x0035DD68 File Offset: 0x0035BF68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206762, XrefRangeEnd = 206831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004857 RID: 18519
			// (get) Token: 0x0600DEA9 RID: 57001 RVA: 0x0035DDA4 File Offset: 0x0035BFA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEAA RID: 57002 RVA: 0x0035DDE4 File Offset: 0x0035BFE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206831, XrefRangeEnd = 206837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004858 RID: 18520
			// (get) Token: 0x0600DEAB RID: 57003 RVA: 0x0035DE18 File Offset: 0x0035C018
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DEAC RID: 57004 RVA: 0x00076E4C File Offset: 0x0007504C
			public _OnNegativeBuffExecute_d__17(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004853 RID: 18515
			// (get) Token: 0x0600DEAD RID: 57005 RVA: 0x0035DE58 File Offset: 0x0035C058
			// (set) Token: 0x0600DEAE RID: 57006 RVA: 0x00076E55 File Offset: 0x00075055
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004854 RID: 18516
			// (get) Token: 0x0600DEAF RID: 57007 RVA: 0x0035DE80 File Offset: 0x0035C080
			// (set) Token: 0x0600DEB0 RID: 57008 RVA: 0x00076E70 File Offset: 0x00075070
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004855 RID: 18517
			// (get) Token: 0x0600DEB1 RID: 57009 RVA: 0x0035DEB0 File Offset: 0x0035C0B0
			// (set) Token: 0x0600DEB2 RID: 57010 RVA: 0x00076E8F File Offset: 0x0007508F
			public unsafe Spell_Toyohime __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toyohime>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004856 RID: 18518
			// (get) Token: 0x0600DEB3 RID: 57011 RVA: 0x0035DEE0 File Offset: 0x0035C0E0
			// (set) Token: 0x0600DEB4 RID: 57012 RVA: 0x00076EAE File Offset: 0x000750AE
			public unsafe Spell_Toyohime.__c__DisplayClass17_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Toyohime.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Toyohime._OnNegativeBuffExecute_d__17.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008E87 RID: 36487
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008E88 RID: 36488
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008E89 RID: 36489
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008E8A RID: 36490
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008E8B RID: 36491
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008E8C RID: 36492
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E8D RID: 36493
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008E8E RID: 36494
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008E8F RID: 36495
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008E90 RID: 36496
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
