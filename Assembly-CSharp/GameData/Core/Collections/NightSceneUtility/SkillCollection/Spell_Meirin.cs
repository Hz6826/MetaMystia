using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using NightScene.Tiles;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000270 RID: 624
	public class Spell_Meirin : SpellBase
	{
		// Token: 0x06004E0E RID: 19982 RVA: 0x001AAFB4 File Offset: 0x001A91B4
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Meirin()
		{
			Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Meirin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr);
			Spell_Meirin.NativeFieldInfoPtr_passionAddPertime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "passionAddPertime");
			Spell_Meirin.NativeFieldInfoPtr_passionAddUnitTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "passionAddUnitTime");
			Spell_Meirin.NativeFieldInfoPtr_positiveDurationSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "positiveDurationSec");
			Spell_Meirin.NativeFieldInfoPtr_passionLostNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "passionLostNum");
			Spell_Meirin.NativeFieldInfoPtr_breakTableNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "breakTableNum");
			Spell_Meirin.NativeFieldInfoPtr_negativeDurationSec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "negativeDurationSec");
			Spell_Meirin.NativeFieldInfoPtr_pandaCameraShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "pandaCameraShakeAmplitude");
			Spell_Meirin.NativeFieldInfoPtr_pandaCameraShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "pandaCameraShakeDuration");
			Spell_Meirin.NativeFieldInfoPtr_pandaCameraShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "pandaCameraShakeFadeDuration");
			Spell_Meirin.NativeFieldInfoPtr_angryPandaEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "angryPandaEffect");
			Spell_Meirin.NativeFieldInfoPtr_dummyDesk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "dummyDesk");
			Spell_Meirin.NativeFieldInfoPtr_dummyDeskStayDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "dummyDeskStayDuration");
			Spell_Meirin.NativeFieldInfoPtr_waitForAngryPandaJumpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "waitForAngryPandaJumpTime");
			Spell_Meirin.NativeFieldInfoPtr_angryPandaPrepareTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "angryPandaPrepareTime");
			Spell_Meirin.NativeFieldInfoPtr_landShakeAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "landShakeAmplitude");
			Spell_Meirin.NativeFieldInfoPtr_landShakeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "landShakeDuration");
			Spell_Meirin.NativeFieldInfoPtr_landShakeFadeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "landShakeFadeDuration");
			Spell_Meirin.NativeFieldInfoPtr_landSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "landSFX");
			Spell_Meirin.NativeFieldInfoPtr_smashSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "smashSFX");
			Spell_Meirin.NativeFieldInfoPtr_smashTimeStamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "smashTimeStamp");
			Spell_Meirin.NativeFieldInfoPtr_destroySFXDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "destroySFXDelay");
			Spell_Meirin.NativeFieldInfoPtr_destroySFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "destroySFX");
			Spell_Meirin.NativeFieldInfoPtr_clearSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "clearSprite");
			Spell_Meirin.NativeFieldInfoPtr_dancingMeirinEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "dancingMeirinEffect");
			Spell_Meirin.NativeFieldInfoPtr_dancingMeirinMoveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "dancingMeirinMoveTime");
			Spell_Meirin.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, 100678987);
			Spell_Meirin.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, 100678988);
			Spell_Meirin.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, 100678989);
			Spell_Meirin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, 100678990);
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x001AB228 File Offset: 0x001A9428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199896, XrefRangeEnd = 199898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Meirin.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x001AB26C File Offset: 0x001A946C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199898, XrefRangeEnd = 199904, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Meirin.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x001AB2C8 File Offset: 0x001A94C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199904, XrefRangeEnd = 199910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Meirin.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x001AB324 File Offset: 0x001A9524
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Meirin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x00028C88 File Offset: 0x00026E88
		public Spell_Meirin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06004E14 RID: 19988 RVA: 0x001AB360 File Offset: 0x001A9560
		// (set) Token: 0x06004E15 RID: 19989 RVA: 0x00028C91 File Offset: 0x00026E91
		public unsafe int passionAddPertime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_passionAddPertime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_passionAddPertime)) = value;
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06004E16 RID: 19990 RVA: 0x001AB388 File Offset: 0x001A9588
		// (set) Token: 0x06004E17 RID: 19991 RVA: 0x00028CAC File Offset: 0x00026EAC
		public unsafe float passionAddUnitTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_passionAddUnitTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_passionAddUnitTime)) = value;
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x001AB3B0 File Offset: 0x001A95B0
		// (set) Token: 0x06004E19 RID: 19993 RVA: 0x00028CC7 File Offset: 0x00026EC7
		public unsafe int positiveDurationSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_positiveDurationSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_positiveDurationSec)) = value;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06004E1A RID: 19994 RVA: 0x001AB3D8 File Offset: 0x001A95D8
		// (set) Token: 0x06004E1B RID: 19995 RVA: 0x00028CE2 File Offset: 0x00026EE2
		public unsafe int passionLostNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_passionLostNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_passionLostNum)) = value;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06004E1C RID: 19996 RVA: 0x001AB400 File Offset: 0x001A9600
		// (set) Token: 0x06004E1D RID: 19997 RVA: 0x00028CFD File Offset: 0x00026EFD
		public unsafe int breakTableNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_breakTableNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_breakTableNum)) = value;
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x06004E1E RID: 19998 RVA: 0x001AB428 File Offset: 0x001A9628
		// (set) Token: 0x06004E1F RID: 19999 RVA: 0x00028D18 File Offset: 0x00026F18
		public unsafe int negativeDurationSec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_negativeDurationSec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_negativeDurationSec)) = value;
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x06004E20 RID: 20000 RVA: 0x001AB450 File Offset: 0x001A9650
		// (set) Token: 0x06004E21 RID: 20001 RVA: 0x00028D33 File Offset: 0x00026F33
		public unsafe float pandaCameraShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_pandaCameraShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_pandaCameraShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x06004E22 RID: 20002 RVA: 0x001AB478 File Offset: 0x001A9678
		// (set) Token: 0x06004E23 RID: 20003 RVA: 0x00028D4E File Offset: 0x00026F4E
		public unsafe float pandaCameraShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_pandaCameraShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_pandaCameraShakeDuration)) = value;
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06004E24 RID: 20004 RVA: 0x001AB4A0 File Offset: 0x001A96A0
		// (set) Token: 0x06004E25 RID: 20005 RVA: 0x00028D69 File Offset: 0x00026F69
		public unsafe float pandaCameraShakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_pandaCameraShakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_pandaCameraShakeFadeDuration)) = value;
			}
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x06004E26 RID: 20006 RVA: 0x001AB4C8 File Offset: 0x001A96C8
		// (set) Token: 0x06004E27 RID: 20007 RVA: 0x00028D84 File Offset: 0x00026F84
		public unsafe GameObject angryPandaEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_angryPandaEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_angryPandaEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x001AB4F8 File Offset: 0x001A96F8
		// (set) Token: 0x06004E29 RID: 20009 RVA: 0x00028DA3 File Offset: 0x00026FA3
		public unsafe GameObject dummyDesk
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_dummyDesk);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_dummyDesk), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x001AB528 File Offset: 0x001A9728
		// (set) Token: 0x06004E2B RID: 20011 RVA: 0x00028DC2 File Offset: 0x00026FC2
		public unsafe float dummyDeskStayDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_dummyDeskStayDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_dummyDeskStayDuration)) = value;
			}
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x06004E2C RID: 20012 RVA: 0x001AB550 File Offset: 0x001A9750
		// (set) Token: 0x06004E2D RID: 20013 RVA: 0x00028DDD File Offset: 0x00026FDD
		public unsafe float waitForAngryPandaJumpTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_waitForAngryPandaJumpTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_waitForAngryPandaJumpTime)) = value;
			}
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x06004E2E RID: 20014 RVA: 0x001AB578 File Offset: 0x001A9778
		// (set) Token: 0x06004E2F RID: 20015 RVA: 0x00028DF8 File Offset: 0x00026FF8
		public unsafe float angryPandaPrepareTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_angryPandaPrepareTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_angryPandaPrepareTime)) = value;
			}
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x06004E30 RID: 20016 RVA: 0x001AB5A0 File Offset: 0x001A97A0
		// (set) Token: 0x06004E31 RID: 20017 RVA: 0x00028E13 File Offset: 0x00027013
		public unsafe float landShakeAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_landShakeAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_landShakeAmplitude)) = value;
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06004E32 RID: 20018 RVA: 0x001AB5C8 File Offset: 0x001A97C8
		// (set) Token: 0x06004E33 RID: 20019 RVA: 0x00028E2E File Offset: 0x0002702E
		public unsafe float landShakeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_landShakeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_landShakeDuration)) = value;
			}
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x06004E34 RID: 20020 RVA: 0x001AB5F0 File Offset: 0x001A97F0
		// (set) Token: 0x06004E35 RID: 20021 RVA: 0x00028E49 File Offset: 0x00027049
		public unsafe float landShakeFadeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_landShakeFadeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_landShakeFadeDuration)) = value;
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x06004E36 RID: 20022 RVA: 0x001AB618 File Offset: 0x001A9818
		// (set) Token: 0x06004E37 RID: 20023 RVA: 0x00028E64 File Offset: 0x00027064
		public unsafe AudioClip landSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_landSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_landSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x06004E38 RID: 20024 RVA: 0x001AB648 File Offset: 0x001A9848
		// (set) Token: 0x06004E39 RID: 20025 RVA: 0x00028E83 File Offset: 0x00027083
		public unsafe AudioClip smashSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_smashSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_smashSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x06004E3A RID: 20026 RVA: 0x001AB678 File Offset: 0x001A9878
		// (set) Token: 0x06004E3B RID: 20027 RVA: 0x00028EA2 File Offset: 0x000270A2
		public unsafe Il2CppStructArray<float> smashTimeStamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_smashTimeStamp);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_smashTimeStamp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x06004E3C RID: 20028 RVA: 0x001AB6A8 File Offset: 0x001A98A8
		// (set) Token: 0x06004E3D RID: 20029 RVA: 0x00028EC1 File Offset: 0x000270C1
		public unsafe float destroySFXDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_destroySFXDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_destroySFXDelay)) = value;
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x06004E3E RID: 20030 RVA: 0x001AB6D0 File Offset: 0x001A98D0
		// (set) Token: 0x06004E3F RID: 20031 RVA: 0x00028EDC File Offset: 0x000270DC
		public unsafe AudioClip destroySFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_destroySFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_destroySFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x06004E40 RID: 20032 RVA: 0x001AB700 File Offset: 0x001A9900
		// (set) Token: 0x06004E41 RID: 20033 RVA: 0x00028EFB File Offset: 0x000270FB
		public unsafe Sprite clearSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_clearSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_clearSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x06004E42 RID: 20034 RVA: 0x001AB730 File Offset: 0x001A9930
		// (set) Token: 0x06004E43 RID: 20035 RVA: 0x00028F1A File Offset: 0x0002711A
		public unsafe GameObject dancingMeirinEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_dancingMeirinEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_dancingMeirinEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x06004E44 RID: 20036 RVA: 0x001AB760 File Offset: 0x001A9960
		// (set) Token: 0x06004E45 RID: 20037 RVA: 0x00028F39 File Offset: 0x00027139
		public unsafe float dancingMeirinMoveTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_dancingMeirinMoveTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.NativeFieldInfoPtr_dancingMeirinMoveTime)) = value;
			}
		}

		// Token: 0x0400352E RID: 13614
		private static readonly IntPtr NativeFieldInfoPtr_passionAddPertime;

		// Token: 0x0400352F RID: 13615
		private static readonly IntPtr NativeFieldInfoPtr_passionAddUnitTime;

		// Token: 0x04003530 RID: 13616
		private static readonly IntPtr NativeFieldInfoPtr_positiveDurationSec;

		// Token: 0x04003531 RID: 13617
		private static readonly IntPtr NativeFieldInfoPtr_passionLostNum;

		// Token: 0x04003532 RID: 13618
		private static readonly IntPtr NativeFieldInfoPtr_breakTableNum;

		// Token: 0x04003533 RID: 13619
		private static readonly IntPtr NativeFieldInfoPtr_negativeDurationSec;

		// Token: 0x04003534 RID: 13620
		private static readonly IntPtr NativeFieldInfoPtr_pandaCameraShakeAmplitude;

		// Token: 0x04003535 RID: 13621
		private static readonly IntPtr NativeFieldInfoPtr_pandaCameraShakeDuration;

		// Token: 0x04003536 RID: 13622
		private static readonly IntPtr NativeFieldInfoPtr_pandaCameraShakeFadeDuration;

		// Token: 0x04003537 RID: 13623
		private static readonly IntPtr NativeFieldInfoPtr_angryPandaEffect;

		// Token: 0x04003538 RID: 13624
		private static readonly IntPtr NativeFieldInfoPtr_dummyDesk;

		// Token: 0x04003539 RID: 13625
		private static readonly IntPtr NativeFieldInfoPtr_dummyDeskStayDuration;

		// Token: 0x0400353A RID: 13626
		private static readonly IntPtr NativeFieldInfoPtr_waitForAngryPandaJumpTime;

		// Token: 0x0400353B RID: 13627
		private static readonly IntPtr NativeFieldInfoPtr_angryPandaPrepareTime;

		// Token: 0x0400353C RID: 13628
		private static readonly IntPtr NativeFieldInfoPtr_landShakeAmplitude;

		// Token: 0x0400353D RID: 13629
		private static readonly IntPtr NativeFieldInfoPtr_landShakeDuration;

		// Token: 0x0400353E RID: 13630
		private static readonly IntPtr NativeFieldInfoPtr_landShakeFadeDuration;

		// Token: 0x0400353F RID: 13631
		private static readonly IntPtr NativeFieldInfoPtr_landSFX;

		// Token: 0x04003540 RID: 13632
		private static readonly IntPtr NativeFieldInfoPtr_smashSFX;

		// Token: 0x04003541 RID: 13633
		private static readonly IntPtr NativeFieldInfoPtr_smashTimeStamp;

		// Token: 0x04003542 RID: 13634
		private static readonly IntPtr NativeFieldInfoPtr_destroySFXDelay;

		// Token: 0x04003543 RID: 13635
		private static readonly IntPtr NativeFieldInfoPtr_destroySFX;

		// Token: 0x04003544 RID: 13636
		private static readonly IntPtr NativeFieldInfoPtr_clearSprite;

		// Token: 0x04003545 RID: 13637
		private static readonly IntPtr NativeFieldInfoPtr_dancingMeirinEffect;

		// Token: 0x04003546 RID: 13638
		private static readonly IntPtr NativeFieldInfoPtr_dancingMeirinMoveTime;

		// Token: 0x04003547 RID: 13639
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003548 RID: 13640
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003549 RID: 13641
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400354A RID: 13642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B5B RID: 2907
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Meirin+<>c__DisplayClass26_0")]
		public new sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D682 RID: 54914 RVA: 0x003454B8 File Offset: 0x003436B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr);
				Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_deskTile = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, "deskTile");
				Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_targetDesk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, "targetDesk");
				Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_interactableTileMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, "interactableTileMap");
				Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_tilePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, "tilePosition");
				Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_angryPanda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, "angryPanda");
				Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_tableDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, "tableDisplayer");
				Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_deskStartSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, "deskStartSprite");
				Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, 100678991);
				Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, 100678992);
				Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, 100678993);
				Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, 100678994);
				Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, 100678995);
			}

			// Token: 0x0600D683 RID: 54915 RVA: 0x003455E8 File Offset: 0x003437E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D684 RID: 54916 RVA: 0x00345624 File Offset: 0x00343824
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199653, XrefRangeEnd = 199659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D685 RID: 54917 RVA: 0x00345668 File Offset: 0x00343868
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199659, XrefRangeEnd = 199660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D686 RID: 54918 RVA: 0x003456A4 File Offset: 0x003438A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199660, XrefRangeEnd = 199665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D687 RID: 54919 RVA: 0x003456E4 File Offset: 0x003438E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199665, XrefRangeEnd = 199673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D688 RID: 54920 RVA: 0x00072D1C File Offset: 0x00070F1C
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C7 RID: 17863
			// (get) Token: 0x0600D689 RID: 54921 RVA: 0x00345718 File Offset: 0x00343918
			// (set) Token: 0x0600D68A RID: 54922 RVA: 0x00072D25 File Offset: 0x00070F25
			public unsafe Spell_Meirin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Meirin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045C8 RID: 17864
			// (get) Token: 0x0600D68B RID: 54923 RVA: 0x00345748 File Offset: 0x00343948
			// (set) Token: 0x0600D68C RID: 54924 RVA: 0x00072D44 File Offset: 0x00070F44
			public unsafe InteractableTile deskTile
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_deskTile);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableTile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_deskTile), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045C9 RID: 17865
			// (get) Token: 0x0600D68D RID: 54925 RVA: 0x00345778 File Offset: 0x00343978
			// (set) Token: 0x0600D68E RID: 54926 RVA: 0x00072D63 File Offset: 0x00070F63
			public unsafe int targetDesk
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_targetDesk);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_targetDesk)) = value;
				}
			}

			// Token: 0x170045CA RID: 17866
			// (get) Token: 0x0600D68F RID: 54927 RVA: 0x003457A0 File Offset: 0x003439A0
			// (set) Token: 0x0600D690 RID: 54928 RVA: 0x00072D7E File Offset: 0x00070F7E
			public unsafe Tilemap interactableTileMap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_interactableTileMap);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_interactableTileMap), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045CB RID: 17867
			// (get) Token: 0x0600D691 RID: 54929 RVA: 0x003457D0 File Offset: 0x003439D0
			// (set) Token: 0x0600D692 RID: 54930 RVA: 0x00072D9D File Offset: 0x00070F9D
			public unsafe Vector3Int tilePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_tilePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_tilePosition)) = value;
				}
			}

			// Token: 0x170045CC RID: 17868
			// (get) Token: 0x0600D693 RID: 54931 RVA: 0x003457F8 File Offset: 0x003439F8
			// (set) Token: 0x0600D694 RID: 54932 RVA: 0x00072DB8 File Offset: 0x00070FB8
			public unsafe GameObject angryPanda
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_angryPanda);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_angryPanda), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045CD RID: 17869
			// (get) Token: 0x0600D695 RID: 54933 RVA: 0x00345828 File Offset: 0x00343A28
			// (set) Token: 0x0600D696 RID: 54934 RVA: 0x00072DD7 File Offset: 0x00070FD7
			public unsafe GuestTableDisplayer tableDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_tableDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestTableDisplayer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_tableDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045CE RID: 17870
			// (get) Token: 0x0600D697 RID: 54935 RVA: 0x00345858 File Offset: 0x00343A58
			// (set) Token: 0x0600D698 RID: 54936 RVA: 0x00072DF6 File Offset: 0x00070FF6
			public unsafe Sprite deskStartSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_deskStartSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.NativeFieldInfoPtr_deskStartSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008994 RID: 35220
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008995 RID: 35221
			private static readonly IntPtr NativeFieldInfoPtr_deskTile;

			// Token: 0x04008996 RID: 35222
			private static readonly IntPtr NativeFieldInfoPtr_targetDesk;

			// Token: 0x04008997 RID: 35223
			private static readonly IntPtr NativeFieldInfoPtr_interactableTileMap;

			// Token: 0x04008998 RID: 35224
			private static readonly IntPtr NativeFieldInfoPtr_tilePosition;

			// Token: 0x04008999 RID: 35225
			private static readonly IntPtr NativeFieldInfoPtr_angryPanda;

			// Token: 0x0400899A RID: 35226
			private static readonly IntPtr NativeFieldInfoPtr_tableDisplayer;

			// Token: 0x0400899B RID: 35227
			private static readonly IntPtr NativeFieldInfoPtr_deskStartSprite;

			// Token: 0x0400899C RID: 35228
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400899D RID: 35229
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x0400899E RID: 35230
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Vector3_0;

			// Token: 0x0400899F RID: 35231
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040089A0 RID: 35232
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02001030 RID: 4144
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Meirin+<>c__DisplayClass26_0+<<OnNegativeBuffExecute>g__OnPandaBeginRuin|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011BB2 RID: 72626 RVA: 0x0040FB58 File Offset: 0x0040DD58
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__OnPandaBeginRuin|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678996);
					Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678997);
					Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678998);
					Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678999);
					Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679000);
					Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679001);
				}

				// Token: 0x06011BB3 RID: 72627 RVA: 0x0040FC38 File Offset: 0x0040DE38
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BB4 RID: 72628 RVA: 0x0040FC80 File Offset: 0x0040DE80
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BB5 RID: 72629 RVA: 0x0040FCB4 File Offset: 0x0040DEB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199640, XrefRangeEnd = 199647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C50 RID: 23632
				// (get) Token: 0x06011BB6 RID: 72630 RVA: 0x0040FCF0 File Offset: 0x0040DEF0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BB7 RID: 72631 RVA: 0x0040FD30 File Offset: 0x0040DF30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199647, XrefRangeEnd = 199653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C51 RID: 23633
				// (get) Token: 0x06011BB8 RID: 72632 RVA: 0x0040FD64 File Offset: 0x0040DF64
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BB9 RID: 72633 RVA: 0x0009A21F File Offset: 0x0009841F
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C4D RID: 23629
				// (get) Token: 0x06011BBA RID: 72634 RVA: 0x0040FDA4 File Offset: 0x0040DFA4
				// (set) Token: 0x06011BBB RID: 72635 RVA: 0x0009A228 File Offset: 0x00098428
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C4E RID: 23630
				// (get) Token: 0x06011BBC RID: 72636 RVA: 0x0040FDCC File Offset: 0x0040DFCC
				// (set) Token: 0x06011BBD RID: 72637 RVA: 0x0009A243 File Offset: 0x00098443
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C4F RID: 23631
				// (get) Token: 0x06011BBE RID: 72638 RVA: 0x0040FDFC File Offset: 0x0040DFFC
				// (set) Token: 0x06011BBF RID: 72639 RVA: 0x0009A262 File Offset: 0x00098462
				public unsafe Spell_Meirin.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Meirin.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B33A RID: 45882
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B33B RID: 45883
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B33C RID: 45884
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B33D RID: 45885
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B33E RID: 45886
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B33F RID: 45887
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B340 RID: 45888
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B341 RID: 45889
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B342 RID: 45890
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B5C RID: 2908
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Meirin+<OnNegativeBuffExecute>d__26")]
		public sealed class _OnNegativeBuffExecute_d__26 : Il2CppSystem.Object
		{
			// Token: 0x0600D699 RID: 54937 RVA: 0x00345888 File Offset: 0x00343A88
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__26()
			{
				Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "<OnNegativeBuffExecute>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr);
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, "<>1__state");
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, "<>2__current");
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, "<>4__this");
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, "spellExecutionContext");
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, "<>8__1");
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100679002);
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100679003);
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100679004);
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100679005);
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100679006);
				Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr, 100679007);
			}

			// Token: 0x0600D69A RID: 54938 RVA: 0x00345990 File Offset: 0x00343B90
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__26(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Meirin._OnNegativeBuffExecute_d__26>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D69B RID: 54939 RVA: 0x003459D8 File Offset: 0x00343BD8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D69C RID: 54940 RVA: 0x00345A0C File Offset: 0x00343C0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199673, XrefRangeEnd = 199769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045D4 RID: 17876
			// (get) Token: 0x0600D69D RID: 54941 RVA: 0x00345A48 File Offset: 0x00343C48
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D69E RID: 54942 RVA: 0x00345A88 File Offset: 0x00343C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199769, XrefRangeEnd = 199775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045D5 RID: 17877
			// (get) Token: 0x0600D69F RID: 54943 RVA: 0x00345ABC File Offset: 0x00343CBC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6A0 RID: 54944 RVA: 0x00072E15 File Offset: 0x00071015
			public _OnNegativeBuffExecute_d__26(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045CF RID: 17871
			// (get) Token: 0x0600D6A1 RID: 54945 RVA: 0x00345AFC File Offset: 0x00343CFC
			// (set) Token: 0x0600D6A2 RID: 54946 RVA: 0x00072E1E File Offset: 0x0007101E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045D0 RID: 17872
			// (get) Token: 0x0600D6A3 RID: 54947 RVA: 0x00345B24 File Offset: 0x00343D24
			// (set) Token: 0x0600D6A4 RID: 54948 RVA: 0x00072E39 File Offset: 0x00071039
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045D1 RID: 17873
			// (get) Token: 0x0600D6A5 RID: 54949 RVA: 0x00345B54 File Offset: 0x00343D54
			// (set) Token: 0x0600D6A6 RID: 54950 RVA: 0x00072E58 File Offset: 0x00071058
			public unsafe Spell_Meirin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Meirin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045D2 RID: 17874
			// (get) Token: 0x0600D6A7 RID: 54951 RVA: 0x00345B84 File Offset: 0x00343D84
			// (set) Token: 0x0600D6A8 RID: 54952 RVA: 0x00072E77 File Offset: 0x00071077
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045D3 RID: 17875
			// (get) Token: 0x0600D6A9 RID: 54953 RVA: 0x00345BB4 File Offset: 0x00343DB4
			// (set) Token: 0x0600D6AA RID: 54954 RVA: 0x00072E96 File Offset: 0x00071096
			public unsafe Spell_Meirin.__c__DisplayClass26_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Meirin.__c__DisplayClass26_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnNegativeBuffExecute_d__26.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089A1 RID: 35233
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089A2 RID: 35234
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089A3 RID: 35235
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089A4 RID: 35236
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040089A5 RID: 35237
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040089A6 RID: 35238
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089A7 RID: 35239
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089A8 RID: 35240
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089A9 RID: 35241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089AA RID: 35242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089AB RID: 35243
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B5D RID: 2909
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Meirin+<>c__DisplayClass27_0")]
		public sealed class __c__DisplayClass27_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D6AB RID: 54955 RVA: 0x00345BE4 File Offset: 0x00343DE4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass27_0()
			{
				Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "<>c__DisplayClass27_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr);
				Spell_Meirin.__c__DisplayClass27_0.NativeFieldInfoPtr_targetPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr, "targetPosition");
				Spell_Meirin.__c__DisplayClass27_0.NativeFieldInfoPtr_dancingMeirin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr, "dancingMeirin");
				Spell_Meirin.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr, "<>4__this");
				Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr, 100679008);
				Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr, 100679009);
				Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr, 100679010);
				Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr, 100679011);
				Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr, 100679012);
			}

			// Token: 0x0600D6AC RID: 54956 RVA: 0x00345CB0 File Offset: 0x00343EB0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass27_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Meirin.__c__DisplayClass27_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6AD RID: 54957 RVA: 0x00345CEC File Offset: 0x00343EEC
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D6AE RID: 54958 RVA: 0x00345D28 File Offset: 0x00343F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199775, XrefRangeEnd = 199796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6AF RID: 54959 RVA: 0x00345D5C File Offset: 0x00343F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199796, XrefRangeEnd = 199800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6B0 RID: 54960 RVA: 0x00345D90 File Offset: 0x00343F90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199800, XrefRangeEnd = 199810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin.__c__DisplayClass27_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6B1 RID: 54961 RVA: 0x00072EB5 File Offset: 0x000710B5
			public __c__DisplayClass27_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D6 RID: 17878
			// (get) Token: 0x0600D6B2 RID: 54962 RVA: 0x00345DD0 File Offset: 0x00343FD0
			// (set) Token: 0x0600D6B3 RID: 54963 RVA: 0x00072EBE File Offset: 0x000710BE
			public unsafe Vector3 targetPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass27_0.NativeFieldInfoPtr_targetPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass27_0.NativeFieldInfoPtr_targetPosition)) = value;
				}
			}

			// Token: 0x170045D7 RID: 17879
			// (get) Token: 0x0600D6B4 RID: 54964 RVA: 0x00345DF8 File Offset: 0x00343FF8
			// (set) Token: 0x0600D6B5 RID: 54965 RVA: 0x00072ED9 File Offset: 0x000710D9
			public unsafe GameObject dancingMeirin
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass27_0.NativeFieldInfoPtr_dancingMeirin);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass27_0.NativeFieldInfoPtr_dancingMeirin), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045D8 RID: 17880
			// (get) Token: 0x0600D6B6 RID: 54966 RVA: 0x00345E28 File Offset: 0x00344028
			// (set) Token: 0x0600D6B7 RID: 54967 RVA: 0x00072EF8 File Offset: 0x000710F8
			public unsafe Spell_Meirin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Meirin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin.__c__DisplayClass27_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089AC RID: 35244
			private static readonly IntPtr NativeFieldInfoPtr_targetPosition;

			// Token: 0x040089AD RID: 35245
			private static readonly IntPtr NativeFieldInfoPtr_dancingMeirin;

			// Token: 0x040089AE RID: 35246
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089AF RID: 35247
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040089B0 RID: 35248
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Vector3_0;

			// Token: 0x040089B1 RID: 35249
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040089B2 RID: 35250
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_0;

			// Token: 0x040089B3 RID: 35251
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0;
		}

		// Token: 0x02000B5E RID: 2910
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Meirin+<OnPositiveBuffExecute>d__27")]
		public sealed class _OnPositiveBuffExecute_d__27 : Il2CppSystem.Object
		{
			// Token: 0x0600D6B8 RID: 54968 RVA: 0x00345E58 File Offset: 0x00344058
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__27()
			{
				Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Meirin>.NativeClassPtr, "<OnPositiveBuffExecute>d__27");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr);
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<>1__state");
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<>2__current");
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, "<>4__this");
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, "spellExecutionContext");
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100679013);
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100679014);
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100679015);
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100679016);
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100679017);
				Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr, 100679018);
			}

			// Token: 0x0600D6B9 RID: 54969 RVA: 0x00345F4C File Offset: 0x0034414C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__27(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Meirin._OnPositiveBuffExecute_d__27>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6BA RID: 54970 RVA: 0x00345F94 File Offset: 0x00344194
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D6BB RID: 54971 RVA: 0x00345FC8 File Offset: 0x003441C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199810, XrefRangeEnd = 199890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045DD RID: 17885
			// (get) Token: 0x0600D6BC RID: 54972 RVA: 0x00346004 File Offset: 0x00344204
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6BD RID: 54973 RVA: 0x00346044 File Offset: 0x00344244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199890, XrefRangeEnd = 199896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045DE RID: 17886
			// (get) Token: 0x0600D6BE RID: 54974 RVA: 0x00346078 File Offset: 0x00344278
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D6BF RID: 54975 RVA: 0x00072F17 File Offset: 0x00071117
			public _OnPositiveBuffExecute_d__27(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045D9 RID: 17881
			// (get) Token: 0x0600D6C0 RID: 54976 RVA: 0x003460B8 File Offset: 0x003442B8
			// (set) Token: 0x0600D6C1 RID: 54977 RVA: 0x00072F20 File Offset: 0x00071120
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045DA RID: 17882
			// (get) Token: 0x0600D6C2 RID: 54978 RVA: 0x003460E0 File Offset: 0x003442E0
			// (set) Token: 0x0600D6C3 RID: 54979 RVA: 0x00072F3B File Offset: 0x0007113B
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045DB RID: 17883
			// (get) Token: 0x0600D6C4 RID: 54980 RVA: 0x00346110 File Offset: 0x00344310
			// (set) Token: 0x0600D6C5 RID: 54981 RVA: 0x00072F5A File Offset: 0x0007115A
			public unsafe Spell_Meirin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Meirin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045DC RID: 17884
			// (get) Token: 0x0600D6C6 RID: 54982 RVA: 0x00346140 File Offset: 0x00344340
			// (set) Token: 0x0600D6C7 RID: 54983 RVA: 0x00072F79 File Offset: 0x00071179
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Meirin._OnPositiveBuffExecute_d__27.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040089B4 RID: 35252
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040089B5 RID: 35253
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040089B6 RID: 35254
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040089B7 RID: 35255
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x040089B8 RID: 35256
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040089B9 RID: 35257
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089BA RID: 35258
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040089BB RID: 35259
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040089BC RID: 35260
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040089BD RID: 35261
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
