using System;
using Common.UI.Story;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Linq;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.PartnerUtility;
using NightScene.UI;
using NightScene.UI.HUDUtility;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002F6 RID: 758
	public class DLC1_YuumaBossData : BossData
	{
		// Token: 0x06005A8D RID: 23181 RVA: 0x001CD9CC File Offset: 0x001CBBCC
		// Note: this type is marked as 'beforefieldinit'.
		static DLC1_YuumaBossData()
		{
			Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DLC1_YuumaBossData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr);
			DLC1_YuumaBossData.NativeFieldInfoPtr_YUUMA_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "YUUMA_ID");
			DLC1_YuumaBossData.NativeFieldInfoPtr_CHALLENGESUCCESS_EVENT_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "CHALLENGESUCCESS_EVENT_ID");
			DLC1_YuumaBossData.NativeFieldInfoPtr_singleRoundDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "singleRoundDuration");
			DLC1_YuumaBossData.NativeFieldInfoPtr_tutorialObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "tutorialObject");
			DLC1_YuumaBossData.NativeFieldInfoPtr_phase1YuumaNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "phase1YuumaNum");
			DLC1_YuumaBossData.NativeFieldInfoPtr_phase2YuumaNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "phase2YuumaNum");
			DLC1_YuumaBossData.NativeFieldInfoPtr_phase3YuumaNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "phase3YuumaNum");
			DLC1_YuumaBossData.NativeFieldInfoPtr_maxAnger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "maxAnger");
			DLC1_YuumaBossData.NativeFieldInfoPtr_satisfyTagDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "satisfyTagDamage");
			DLC1_YuumaBossData.NativeFieldInfoPtr_notSatisfyTagDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "notSatisfyTagDamage");
			DLC1_YuumaBossData.NativeFieldInfoPtr_notSatisfyTagAnger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "notSatisfyTagAnger");
			DLC1_YuumaBossData.NativeFieldInfoPtr_notSatisfyOrderAnger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "notSatisfyOrderAnger");
			DLC1_YuumaBossData.NativeFieldInfoPtr_onPatienceEndAddAnger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "onPatienceEndAddAnger");
			DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaTotalLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "yuumaTotalLife");
			DLC1_YuumaBossData.NativeFieldInfoPtr_spell1EatIngNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "spell1EatIngNum");
			DLC1_YuumaBossData.NativeFieldInfoPtr_spell2EatIngNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "spell2EatIngNum");
			DLC1_YuumaBossData.NativeFieldInfoPtr_spell2EatBevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "spell2EatBevNum");
			DLC1_YuumaBossData.NativeFieldInfoPtr_spell1RestoreLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "spell1RestoreLife");
			DLC1_YuumaBossData.NativeFieldInfoPtr_spell2RestoreLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "spell2RestoreLife");
			DLC1_YuumaBossData.NativeFieldInfoPtr_tagToAngerReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "tagToAngerReduction");
			DLC1_YuumaBossData.NativeFieldInfoPtr_banTagCouple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "banTagCouple");
			DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaSpellCard1Effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "yuumaSpellCard1Effect");
			DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaSpellCard2Effect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "yuumaSpellCard2Effect");
			DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaSpellSmokeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "yuumaSpellSmokeEffect");
			DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaEnergyVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "yuumaEnergyVfx");
			DLC1_YuumaBossData.NativeFieldInfoPtr_punishmentSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "punishmentSFX");
			DLC1_YuumaBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, 100681451);
			DLC1_YuumaBossData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, 100681452);
		}

		// Token: 0x06005A8E RID: 23182 RVA: 0x001CDC2C File Offset: 0x001CBE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221969, XrefRangeEnd = 221975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC1_YuumaBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005A8F RID: 23183 RVA: 0x001CDC8C File Offset: 0x001CBE8C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 220017, RefRangeEnd = 220023, XrefRangeStart = 220017, XrefRangeEnd = 220023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC1_YuumaBossData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x00030F01 File Offset: 0x0002F101
		public DLC1_YuumaBossData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x06005A91 RID: 23185 RVA: 0x001CDCC8 File Offset: 0x001CBEC8
		// (set) Token: 0x06005A92 RID: 23186 RVA: 0x00030F0A File Offset: 0x0002F10A
		public unsafe static int YUUMA_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.NativeFieldInfoPtr_YUUMA_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.NativeFieldInfoPtr_YUUMA_ID, (void*)(&value));
			}
		}

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x06005A93 RID: 23187 RVA: 0x001CDCE4 File Offset: 0x001CBEE4
		// (set) Token: 0x06005A94 RID: 23188 RVA: 0x00030F18 File Offset: 0x0002F118
		public unsafe static string CHALLENGESUCCESS_EVENT_ID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.NativeFieldInfoPtr_CHALLENGESUCCESS_EVENT_ID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.NativeFieldInfoPtr_CHALLENGESUCCESS_EVENT_ID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06005A95 RID: 23189 RVA: 0x001CDD04 File Offset: 0x001CBF04
		// (set) Token: 0x06005A96 RID: 23190 RVA: 0x00030F2A File Offset: 0x0002F12A
		public unsafe int singleRoundDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_singleRoundDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_singleRoundDuration)) = value;
			}
		}

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06005A97 RID: 23191 RVA: 0x001CDD2C File Offset: 0x001CBF2C
		// (set) Token: 0x06005A98 RID: 23192 RVA: 0x00030F45 File Offset: 0x0002F145
		public unsafe GameObject tutorialObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_tutorialObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_tutorialObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06005A99 RID: 23193 RVA: 0x001CDD5C File Offset: 0x001CBF5C
		// (set) Token: 0x06005A9A RID: 23194 RVA: 0x00030F64 File Offset: 0x0002F164
		public unsafe int phase1YuumaNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_phase1YuumaNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_phase1YuumaNum)) = value;
			}
		}

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06005A9B RID: 23195 RVA: 0x001CDD84 File Offset: 0x001CBF84
		// (set) Token: 0x06005A9C RID: 23196 RVA: 0x00030F7F File Offset: 0x0002F17F
		public unsafe int phase2YuumaNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_phase2YuumaNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_phase2YuumaNum)) = value;
			}
		}

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x06005A9D RID: 23197 RVA: 0x001CDDAC File Offset: 0x001CBFAC
		// (set) Token: 0x06005A9E RID: 23198 RVA: 0x00030F9A File Offset: 0x0002F19A
		public unsafe int phase3YuumaNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_phase3YuumaNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_phase3YuumaNum)) = value;
			}
		}

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x06005A9F RID: 23199 RVA: 0x001CDDD4 File Offset: 0x001CBFD4
		// (set) Token: 0x06005AA0 RID: 23200 RVA: 0x00030FB5 File Offset: 0x0002F1B5
		public unsafe int maxAnger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_maxAnger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_maxAnger)) = value;
			}
		}

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x06005AA1 RID: 23201 RVA: 0x001CDDFC File Offset: 0x001CBFFC
		// (set) Token: 0x06005AA2 RID: 23202 RVA: 0x00030FD0 File Offset: 0x0002F1D0
		public unsafe int satisfyTagDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_satisfyTagDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_satisfyTagDamage)) = value;
			}
		}

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x06005AA3 RID: 23203 RVA: 0x001CDE24 File Offset: 0x001CC024
		// (set) Token: 0x06005AA4 RID: 23204 RVA: 0x00030FEB File Offset: 0x0002F1EB
		public unsafe int notSatisfyTagDamage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_notSatisfyTagDamage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_notSatisfyTagDamage)) = value;
			}
		}

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06005AA5 RID: 23205 RVA: 0x001CDE4C File Offset: 0x001CC04C
		// (set) Token: 0x06005AA6 RID: 23206 RVA: 0x00031006 File Offset: 0x0002F206
		public unsafe int notSatisfyTagAnger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_notSatisfyTagAnger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_notSatisfyTagAnger)) = value;
			}
		}

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06005AA7 RID: 23207 RVA: 0x001CDE74 File Offset: 0x001CC074
		// (set) Token: 0x06005AA8 RID: 23208 RVA: 0x00031021 File Offset: 0x0002F221
		public unsafe int notSatisfyOrderAnger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_notSatisfyOrderAnger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_notSatisfyOrderAnger)) = value;
			}
		}

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06005AA9 RID: 23209 RVA: 0x001CDE9C File Offset: 0x001CC09C
		// (set) Token: 0x06005AAA RID: 23210 RVA: 0x0003103C File Offset: 0x0002F23C
		public unsafe int onPatienceEndAddAnger
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_onPatienceEndAddAnger);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_onPatienceEndAddAnger)) = value;
			}
		}

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x06005AAB RID: 23211 RVA: 0x001CDEC4 File Offset: 0x001CC0C4
		// (set) Token: 0x06005AAC RID: 23212 RVA: 0x00031057 File Offset: 0x0002F257
		public unsafe int yuumaTotalLife
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaTotalLife);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaTotalLife)) = value;
			}
		}

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06005AAD RID: 23213 RVA: 0x001CDEEC File Offset: 0x001CC0EC
		// (set) Token: 0x06005AAE RID: 23214 RVA: 0x00031072 File Offset: 0x0002F272
		public unsafe Vector2Int spell1EatIngNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell1EatIngNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell1EatIngNum)) = value;
			}
		}

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x06005AAF RID: 23215 RVA: 0x001CDF14 File Offset: 0x001CC114
		// (set) Token: 0x06005AB0 RID: 23216 RVA: 0x0003108D File Offset: 0x0002F28D
		public unsafe Vector2Int spell2EatIngNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell2EatIngNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell2EatIngNum)) = value;
			}
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x06005AB1 RID: 23217 RVA: 0x001CDF3C File Offset: 0x001CC13C
		// (set) Token: 0x06005AB2 RID: 23218 RVA: 0x000310A8 File Offset: 0x0002F2A8
		public unsafe Vector2Int spell2EatBevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell2EatBevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell2EatBevNum)) = value;
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x06005AB3 RID: 23219 RVA: 0x001CDF64 File Offset: 0x001CC164
		// (set) Token: 0x06005AB4 RID: 23220 RVA: 0x000310C3 File Offset: 0x0002F2C3
		public unsafe int spell1RestoreLife
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell1RestoreLife);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell1RestoreLife)) = value;
			}
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x001CDF8C File Offset: 0x001CC18C
		// (set) Token: 0x06005AB6 RID: 23222 RVA: 0x000310DE File Offset: 0x0002F2DE
		public unsafe int spell2RestoreLife
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell2RestoreLife);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_spell2RestoreLife)) = value;
			}
		}

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06005AB7 RID: 23223 RVA: 0x001CDFB4 File Offset: 0x001CC1B4
		// (set) Token: 0x06005AB8 RID: 23224 RVA: 0x000310F9 File Offset: 0x0002F2F9
		public unsafe Il2CppStructArray<Vector2Int> tagToAngerReduction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_tagToAngerReduction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_tagToAngerReduction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06005AB9 RID: 23225 RVA: 0x001CDFE4 File Offset: 0x001CC1E4
		// (set) Token: 0x06005ABA RID: 23226 RVA: 0x00031118 File Offset: 0x0002F318
		public unsafe Il2CppStructArray<Vector2Int> banTagCouple
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_banTagCouple);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_banTagCouple), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06005ABB RID: 23227 RVA: 0x001CE014 File Offset: 0x001CC214
		// (set) Token: 0x06005ABC RID: 23228 RVA: 0x00031137 File Offset: 0x0002F337
		public unsafe GameObject yuumaSpellCard1Effect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaSpellCard1Effect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaSpellCard1Effect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06005ABD RID: 23229 RVA: 0x001CE044 File Offset: 0x001CC244
		// (set) Token: 0x06005ABE RID: 23230 RVA: 0x00031156 File Offset: 0x0002F356
		public unsafe GameObject yuumaSpellCard2Effect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaSpellCard2Effect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaSpellCard2Effect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x06005ABF RID: 23231 RVA: 0x001CE074 File Offset: 0x001CC274
		// (set) Token: 0x06005AC0 RID: 23232 RVA: 0x00031175 File Offset: 0x0002F375
		public unsafe GameObject yuumaSpellSmokeEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaSpellSmokeEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaSpellSmokeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x06005AC1 RID: 23233 RVA: 0x001CE0A4 File Offset: 0x001CC2A4
		// (set) Token: 0x06005AC2 RID: 23234 RVA: 0x00031194 File Offset: 0x0002F394
		public unsafe GameObject yuumaEnergyVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaEnergyVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_yuumaEnergyVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x06005AC3 RID: 23235 RVA: 0x001CE0D4 File Offset: 0x001CC2D4
		// (set) Token: 0x06005AC4 RID: 23236 RVA: 0x000311B3 File Offset: 0x0002F3B3
		public unsafe AudioClip punishmentSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_punishmentSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.NativeFieldInfoPtr_punishmentSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C3F RID: 15423
		private static readonly IntPtr NativeFieldInfoPtr_YUUMA_ID;

		// Token: 0x04003C40 RID: 15424
		private static readonly IntPtr NativeFieldInfoPtr_CHALLENGESUCCESS_EVENT_ID;

		// Token: 0x04003C41 RID: 15425
		private static readonly IntPtr NativeFieldInfoPtr_singleRoundDuration;

		// Token: 0x04003C42 RID: 15426
		private static readonly IntPtr NativeFieldInfoPtr_tutorialObject;

		// Token: 0x04003C43 RID: 15427
		private static readonly IntPtr NativeFieldInfoPtr_phase1YuumaNum;

		// Token: 0x04003C44 RID: 15428
		private static readonly IntPtr NativeFieldInfoPtr_phase2YuumaNum;

		// Token: 0x04003C45 RID: 15429
		private static readonly IntPtr NativeFieldInfoPtr_phase3YuumaNum;

		// Token: 0x04003C46 RID: 15430
		private static readonly IntPtr NativeFieldInfoPtr_maxAnger;

		// Token: 0x04003C47 RID: 15431
		private static readonly IntPtr NativeFieldInfoPtr_satisfyTagDamage;

		// Token: 0x04003C48 RID: 15432
		private static readonly IntPtr NativeFieldInfoPtr_notSatisfyTagDamage;

		// Token: 0x04003C49 RID: 15433
		private static readonly IntPtr NativeFieldInfoPtr_notSatisfyTagAnger;

		// Token: 0x04003C4A RID: 15434
		private static readonly IntPtr NativeFieldInfoPtr_notSatisfyOrderAnger;

		// Token: 0x04003C4B RID: 15435
		private static readonly IntPtr NativeFieldInfoPtr_onPatienceEndAddAnger;

		// Token: 0x04003C4C RID: 15436
		private static readonly IntPtr NativeFieldInfoPtr_yuumaTotalLife;

		// Token: 0x04003C4D RID: 15437
		private static readonly IntPtr NativeFieldInfoPtr_spell1EatIngNum;

		// Token: 0x04003C4E RID: 15438
		private static readonly IntPtr NativeFieldInfoPtr_spell2EatIngNum;

		// Token: 0x04003C4F RID: 15439
		private static readonly IntPtr NativeFieldInfoPtr_spell2EatBevNum;

		// Token: 0x04003C50 RID: 15440
		private static readonly IntPtr NativeFieldInfoPtr_spell1RestoreLife;

		// Token: 0x04003C51 RID: 15441
		private static readonly IntPtr NativeFieldInfoPtr_spell2RestoreLife;

		// Token: 0x04003C52 RID: 15442
		private static readonly IntPtr NativeFieldInfoPtr_tagToAngerReduction;

		// Token: 0x04003C53 RID: 15443
		private static readonly IntPtr NativeFieldInfoPtr_banTagCouple;

		// Token: 0x04003C54 RID: 15444
		private static readonly IntPtr NativeFieldInfoPtr_yuumaSpellCard1Effect;

		// Token: 0x04003C55 RID: 15445
		private static readonly IntPtr NativeFieldInfoPtr_yuumaSpellCard2Effect;

		// Token: 0x04003C56 RID: 15446
		private static readonly IntPtr NativeFieldInfoPtr_yuumaSpellSmokeEffect;

		// Token: 0x04003C57 RID: 15447
		private static readonly IntPtr NativeFieldInfoPtr_yuumaEnergyVfx;

		// Token: 0x04003C58 RID: 15448
		private static readonly IntPtr NativeFieldInfoPtr_punishmentSFX;

		// Token: 0x04003C59 RID: 15449
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0;

		// Token: 0x04003C5A RID: 15450
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CBC RID: 3260
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_0")]
		public sealed class __c__DisplayClass26_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E95C RID: 59740 RVA: 0x0037C9F0 File Offset: 0x0037ABF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_0()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_restCountDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "restCountDown");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<>4__this");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "eventManager");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "canContinue");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_banTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "banTags");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_yuumaWantedTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "yuumaWantedTag");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allFoodTagsPoolWanted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "allFoodTagsPoolWanted");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_haveEnterPhase2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "haveEnterPhase2");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "partnerManager");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_totalCookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "totalCookers");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "uiManager");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_ptc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "ptc");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_statusDisplayerTransition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "statusDisplayerTransition");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_yuumaSkillCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "yuumaSkillCorotine");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_mainLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "mainLoop");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_standSpawnLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "standSpawnLoop");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_guestsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "guestsManager");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_canContinueYieldInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "canContinueYieldInstruction");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_currentTagChangeLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "currentTagChangeLife");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_tagPerChangeLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "tagPerChangeLife");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_statusDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "statusDisplayer");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_yuumaCurrentLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "yuumaCurrentLife");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_currentAnger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "currentAnger");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_toutetsuSeatPostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "toutetsuSeatPostion");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_phase2HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "phase2HP");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_phase3HP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "phase3HP");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_haveEnterPhase3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "haveEnterPhase3");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_toutetsu = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "toutetsu");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_isManualing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "isManualing");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_isUsingSpellCards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "isUsingSpellCards");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_toutetsuData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "toutetsuData");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_eatingGameObejctCooker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "eatingGameObejctCooker");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_bossBuffend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "bossBuffend");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_interrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "interrupt");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_currentGuestMaxNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "currentGuestMaxNum");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_waitForSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "waitForSeconds");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allSelectedFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "allSelectedFood");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_tagToAngerReductionDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "tagToAngerReductionDictionary");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allSelectedBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "allSelectedBev");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allFoodTagsPoolOrdered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "allFoodTagsPoolOrdered");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allBevTagsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "allBevTagsPool");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__57 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<>9__57");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__77 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<>9__77");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__75 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<>9__75");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__88 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<>9__88");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__89 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<>9__89");
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681453);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681454);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681455);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_YuumaTutorialPhase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681456);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681457);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681458);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681459);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681460);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681461);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__14_Internal_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681462);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681463);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__17_Internal_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681464);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681465);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681466);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681467);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681468);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681469);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__57_Internal_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681470);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681471);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681472);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681473);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681474);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__58_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681475);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681476);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681477);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681478);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__59_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681479);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector3_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681480);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681481);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681482);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__77_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681483);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681484);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681485);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Boolean_Sellable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681486);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__82_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681487);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__81_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681488);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681489);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681490);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681491);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681492);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__88_Internal_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681493);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__89_Internal_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681494);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__40_Internal_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681495);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__41_Internal_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681496);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__42_Internal_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681497);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__43_Internal_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681498);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681499);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__45_Internal_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681500);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__46_Internal_Boolean_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681501);
				DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__48_Internal_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, 100681502);
			}

			// Token: 0x0600E95D RID: 59741 RVA: 0x0037D19C File Offset: 0x0037B39C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E95E RID: 59742 RVA: 0x0037D1D8 File Offset: 0x0037B3D8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 220713, RefRangeEnd = 220716, XrefRangeStart = 220707, XrefRangeEnd = 220713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Func_1_Boolean_0(Func<bool> extraTiming)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extraTiming);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E95F RID: 59743 RVA: 0x0037D228 File Offset: 0x0037B428
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E960 RID: 59744 RVA: 0x0037D264 File Offset: 0x0037B464
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 220721, RefRangeEnd = 220724, XrefRangeStart = 220716, XrefRangeEnd = 220721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_YuumaTutorialPhase_0(EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase yuumaTutorialPhase)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref yuumaTutorialPhase;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_YuumaTutorialPhase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E961 RID: 59745 RVA: 0x0037D2B0 File Offset: 0x0037B4B0
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E962 RID: 59746 RVA: 0x0037D2E4 File Offset: 0x0037B4E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220724, XrefRangeEnd = 220725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__9(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E963 RID: 59747 RVA: 0x0037D330 File Offset: 0x0037B530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220725, XrefRangeEnd = 220726, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__10(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E964 RID: 59748 RVA: 0x0037D37C File Offset: 0x0037B57C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 220734, RefRangeEnd = 220735, XrefRangeStart = 220726, XrefRangeEnd = 220734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E965 RID: 59749 RVA: 0x0037D3B0 File Offset: 0x0037B5B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220735, XrefRangeEnd = 220738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E966 RID: 59750 RVA: 0x0037D3E4 File Offset: 0x0037B5E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220738, XrefRangeEnd = 220740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__14()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__14_Internal_Void_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E967 RID: 59751 RVA: 0x0037D418 File Offset: 0x0037B618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220740, XrefRangeEnd = 220741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E968 RID: 59752 RVA: 0x0037D454 File Offset: 0x0037B654
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220741, XrefRangeEnd = 220742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__17()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__17_Internal_Void_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E969 RID: 59753 RVA: 0x0037D488 File Offset: 0x0037B688
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220742, XrefRangeEnd = 220743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__18()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Void_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E96A RID: 59754 RVA: 0x0037D4BC File Offset: 0x0037B6BC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 220748, RefRangeEnd = 220751, XrefRangeStart = 220743, XrefRangeEnd = 220748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E96B RID: 59755 RVA: 0x0037D4FC File Offset: 0x0037B6FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220751, XrefRangeEnd = 220753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__55(Coroutine x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E96C RID: 59756 RVA: 0x0037D540 File Offset: 0x0037B740
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__56()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Void_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E96D RID: 59757 RVA: 0x0037D574 File Offset: 0x0037B774
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 220794, RefRangeEnd = 220796, XrefRangeStart = 220753, XrefRangeEnd = 220794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E96E RID: 59758 RVA: 0x0037D5A8 File Offset: 0x0037B7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220796, XrefRangeEnd = 220804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__57(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__57_Internal_Boolean_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E96F RID: 59759 RVA: 0x0037D5F4 File Offset: 0x0037B7F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220804, XrefRangeEnd = 220806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_Int32_PDM_0(int angerNum, int damageNum)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref angerNum;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref damageNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E970 RID: 59760 RVA: 0x0037D640 File Offset: 0x0037B840
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 220817, RefRangeEnd = 220821, XrefRangeStart = 220806, XrefRangeEnd = 220817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_0(int num)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref num;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E971 RID: 59761 RVA: 0x0037D680 File Offset: 0x0037B880
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 220826, RefRangeEnd = 220830, XrefRangeStart = 220821, XrefRangeEnd = 220826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_1(int damage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref damage;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E972 RID: 59762 RVA: 0x0037D6C0 File Offset: 0x0037B8C0
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 220842, RefRangeEnd = 220850, XrefRangeStart = 220830, XrefRangeEnd = 220842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E973 RID: 59763 RVA: 0x0037D6F4 File Offset: 0x0037B8F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220850, XrefRangeEnd = 220851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__58(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__58_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E974 RID: 59764 RVA: 0x0037D738 File Offset: 0x0037B938
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220851, XrefRangeEnd = 220852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E975 RID: 59765 RVA: 0x0037D76C File Offset: 0x0037B96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220852, XrefRangeEnd = 220853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E976 RID: 59766 RVA: 0x0037D7A0 File Offset: 0x0037B9A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220853, XrefRangeEnd = 220858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Vector3_PDM_0(Vector3 yuumaPosition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref yuumaPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector3_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E977 RID: 59767 RVA: 0x0037D7EC File Offset: 0x0037B9EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220858, XrefRangeEnd = 220882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__59(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__59_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E978 RID: 59768 RVA: 0x0037D838 File Offset: 0x0037BA38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220882, XrefRangeEnd = 220887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Vector3_PDM_1(Vector3 yuumaPosition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref yuumaPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector3_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E979 RID: 59769 RVA: 0x0037D884 File Offset: 0x0037BA84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220887, XrefRangeEnd = 220906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E97A RID: 59770 RVA: 0x0037D8B8 File Offset: 0x0037BAB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220906, XrefRangeEnd = 220911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E97B RID: 59771 RVA: 0x0037D8F8 File Offset: 0x0037BAF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220911, XrefRangeEnd = 220913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__77(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__77_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E97C RID: 59772 RVA: 0x0037D93C File Offset: 0x0037BB3C
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__75()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E97D RID: 59773 RVA: 0x0037D978 File Offset: 0x0037BB78
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 220926, RefRangeEnd = 220927, XrefRangeStart = 220913, XrefRangeEnd = 220926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int Method_Internal_Int32_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E97E RID: 59774 RVA: 0x0037D9B4 File Offset: 0x0037BBB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220927, XrefRangeEnd = 220949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_Sellable_PDM_0(Sellable food)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Boolean_Sellable_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E97F RID: 59775 RVA: 0x0037DA04 File Offset: 0x0037BC04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220949, XrefRangeEnd = 220953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__82(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__82_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E980 RID: 59776 RVA: 0x0037DA50 File Offset: 0x0037BC50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220953, XrefRangeEnd = 220976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__81(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__81_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E981 RID: 59777 RVA: 0x0037DA9C File Offset: 0x0037BC9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 220976, RefRangeEnd = 220977, XrefRangeStart = 220976, XrefRangeEnd = 220976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E982 RID: 59778 RVA: 0x0037DAD8 File Offset: 0x0037BCD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220977, XrefRangeEnd = 221038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0(GuestGroupController.EvaluationResult lastResult, GuestGroupController thisGuestGroup, bool oldComboProtect, out string newMessage, out bool comboProtect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref lastResult;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisGuestGroup);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				newMessage = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600E983 RID: 59779 RVA: 0x0037DB6C File Offset: 0x0037BD6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221038, XrefRangeEnd = 221062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestsManager.OrderBase Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0(GuestGroupController guestGroup, out string orderGenerationMessage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				orderGenerationMessage = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr4) : null;
			}

			// Token: 0x0600E984 RID: 59780 RVA: 0x0037DBD8 File Offset: 0x0037BDD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221062, XrefRangeEnd = 221067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E985 RID: 59781 RVA: 0x0037DC18 File Offset: 0x0037BE18
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__88(GuestGroupController.EvaluationResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__88_Internal_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E986 RID: 59782 RVA: 0x0037DC58 File Offset: 0x0037BE58
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__89(GuestGroupController.EvaluationResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__89_Internal_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E987 RID: 59783 RVA: 0x0037DC98 File Offset: 0x0037BE98
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__40()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__40_Internal_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E988 RID: 59784 RVA: 0x0037DCD4 File Offset: 0x0037BED4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221067, XrefRangeEnd = 221068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__41()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__41_Internal_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E989 RID: 59785 RVA: 0x0037DD10 File Offset: 0x0037BF10
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__42()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__42_Internal_Void_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E98A RID: 59786 RVA: 0x0037DD44 File Offset: 0x0037BF44
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__43()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__43_Internal_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E98B RID: 59787 RVA: 0x0037DD80 File Offset: 0x0037BF80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221068, XrefRangeEnd = 221069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__44()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E98C RID: 59788 RVA: 0x0037DDBC File Offset: 0x0037BFBC
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__45()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__45_Internal_Void_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E98D RID: 59789 RVA: 0x0037DDF0 File Offset: 0x0037BFF0
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__46()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__46_Internal_Boolean_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E98E RID: 59790 RVA: 0x0037DE2C File Offset: 0x0037C02C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__48(Coroutine x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeMethodInfoPtr__MainChallengeLoop_b__48_Internal_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E98F RID: 59791 RVA: 0x0007CDE4 File Offset: 0x0007AFE4
			public __c__DisplayClass26_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BDF RID: 19423
			// (get) Token: 0x0600E990 RID: 59792 RVA: 0x0037DE70 File Offset: 0x0037C070
			// (set) Token: 0x0600E991 RID: 59793 RVA: 0x0007CDED File Offset: 0x0007AFED
			public unsafe int restCountDown
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_restCountDown);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_restCountDown)) = value;
				}
			}

			// Token: 0x17004BE0 RID: 19424
			// (get) Token: 0x0600E992 RID: 59794 RVA: 0x0037DE98 File Offset: 0x0037C098
			// (set) Token: 0x0600E993 RID: 59795 RVA: 0x0007CE08 File Offset: 0x0007B008
			public unsafe DLC1_YuumaBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE1 RID: 19425
			// (get) Token: 0x0600E994 RID: 59796 RVA: 0x0037DEC8 File Offset: 0x0037C0C8
			// (set) Token: 0x0600E995 RID: 59797 RVA: 0x0007CE27 File Offset: 0x0007B027
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE2 RID: 19426
			// (get) Token: 0x0600E996 RID: 59798 RVA: 0x0037DEF8 File Offset: 0x0037C0F8
			// (set) Token: 0x0600E997 RID: 59799 RVA: 0x0007CE46 File Offset: 0x0007B046
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x17004BE3 RID: 19427
			// (get) Token: 0x0600E998 RID: 59800 RVA: 0x0037DF20 File Offset: 0x0037C120
			// (set) Token: 0x0600E999 RID: 59801 RVA: 0x0007CE61 File Offset: 0x0007B061
			public unsafe List<int> banTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_banTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_banTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE4 RID: 19428
			// (get) Token: 0x0600E99A RID: 59802 RVA: 0x0037DF50 File Offset: 0x0037C150
			// (set) Token: 0x0600E99B RID: 59803 RVA: 0x0007CE80 File Offset: 0x0007B080
			public unsafe List<int> yuumaWantedTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_yuumaWantedTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_yuumaWantedTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE5 RID: 19429
			// (get) Token: 0x0600E99C RID: 59804 RVA: 0x0037DF80 File Offset: 0x0037C180
			// (set) Token: 0x0600E99D RID: 59805 RVA: 0x0007CE9F File Offset: 0x0007B09F
			public unsafe List<int> allFoodTagsPoolWanted
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allFoodTagsPoolWanted);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allFoodTagsPoolWanted), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE6 RID: 19430
			// (get) Token: 0x0600E99E RID: 59806 RVA: 0x0037DFB0 File Offset: 0x0037C1B0
			// (set) Token: 0x0600E99F RID: 59807 RVA: 0x0007CEBE File Offset: 0x0007B0BE
			public unsafe bool haveEnterPhase2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_haveEnterPhase2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_haveEnterPhase2)) = value;
				}
			}

			// Token: 0x17004BE7 RID: 19431
			// (get) Token: 0x0600E9A0 RID: 59808 RVA: 0x0037DFD8 File Offset: 0x0037C1D8
			// (set) Token: 0x0600E9A1 RID: 59809 RVA: 0x0007CED9 File Offset: 0x0007B0D9
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BE8 RID: 19432
			// (get) Token: 0x0600E9A2 RID: 59810 RVA: 0x0037E008 File Offset: 0x0037C208
			// (set) Token: 0x0600E9A3 RID: 59811 RVA: 0x0007CEF8 File Offset: 0x0007B0F8
			public unsafe int totalCookers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_totalCookers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_totalCookers)) = value;
				}
			}

			// Token: 0x17004BE9 RID: 19433
			// (get) Token: 0x0600E9A4 RID: 59812 RVA: 0x0037E030 File Offset: 0x0037C230
			// (set) Token: 0x0600E9A5 RID: 59813 RVA: 0x0007CF13 File Offset: 0x0007B113
			public unsafe UIManager uiManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_uiManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_uiManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BEA RID: 19434
			// (get) Token: 0x0600E9A6 RID: 59814 RVA: 0x0037E060 File Offset: 0x0037C260
			// (set) Token: 0x0600E9A7 RID: 59815 RVA: 0x0007CF32 File Offset: 0x0007B132
			public unsafe PannelTransitionController ptc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_ptc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PannelTransitionController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_ptc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BEB RID: 19435
			// (get) Token: 0x0600E9A8 RID: 59816 RVA: 0x0037E090 File Offset: 0x0037C290
			// (set) Token: 0x0600E9A9 RID: 59817 RVA: 0x0007CF51 File Offset: 0x0007B151
			public unsafe CanvasGroup statusDisplayerTransition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_statusDisplayerTransition);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_statusDisplayerTransition), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BEC RID: 19436
			// (get) Token: 0x0600E9AA RID: 59818 RVA: 0x0037E0C0 File Offset: 0x0037C2C0
			// (set) Token: 0x0600E9AB RID: 59819 RVA: 0x0007CF70 File Offset: 0x0007B170
			public unsafe List<Coroutine> yuumaSkillCorotine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_yuumaSkillCorotine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Coroutine>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_yuumaSkillCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BED RID: 19437
			// (get) Token: 0x0600E9AC RID: 59820 RVA: 0x0037E0F0 File Offset: 0x0037C2F0
			// (set) Token: 0x0600E9AD RID: 59821 RVA: 0x0007CF8F File Offset: 0x0007B18F
			public unsafe Coroutine mainLoop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_mainLoop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_mainLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BEE RID: 19438
			// (get) Token: 0x0600E9AE RID: 59822 RVA: 0x0037E120 File Offset: 0x0037C320
			// (set) Token: 0x0600E9AF RID: 59823 RVA: 0x0007CFAE File Offset: 0x0007B1AE
			public unsafe Coroutine standSpawnLoop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_standSpawnLoop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_standSpawnLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BEF RID: 19439
			// (get) Token: 0x0600E9B0 RID: 59824 RVA: 0x0037E150 File Offset: 0x0037C350
			// (set) Token: 0x0600E9B1 RID: 59825 RVA: 0x0007CFCD File Offset: 0x0007B1CD
			public unsafe GuestsManager guestsManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_guestsManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_guestsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BF0 RID: 19440
			// (get) Token: 0x0600E9B2 RID: 59826 RVA: 0x0037E180 File Offset: 0x0037C380
			// (set) Token: 0x0600E9B3 RID: 59827 RVA: 0x0007CFEC File Offset: 0x0007B1EC
			public unsafe WaitUntil canContinueYieldInstruction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_canContinueYieldInstruction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_canContinueYieldInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BF1 RID: 19441
			// (get) Token: 0x0600E9B4 RID: 59828 RVA: 0x0037E1B0 File Offset: 0x0037C3B0
			// (set) Token: 0x0600E9B5 RID: 59829 RVA: 0x0007D00B File Offset: 0x0007B20B
			public unsafe int currentTagChangeLife
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_currentTagChangeLife);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_currentTagChangeLife)) = value;
				}
			}

			// Token: 0x17004BF2 RID: 19442
			// (get) Token: 0x0600E9B6 RID: 59830 RVA: 0x0037E1D8 File Offset: 0x0037C3D8
			// (set) Token: 0x0600E9B7 RID: 59831 RVA: 0x0007D026 File Offset: 0x0007B226
			public unsafe int tagPerChangeLife
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_tagPerChangeLife);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_tagPerChangeLife)) = value;
				}
			}

			// Token: 0x17004BF3 RID: 19443
			// (get) Token: 0x0600E9B8 RID: 59832 RVA: 0x0037E200 File Offset: 0x0037C400
			// (set) Token: 0x0600E9B9 RID: 59833 RVA: 0x0007D041 File Offset: 0x0007B241
			public unsafe IncomeControllerYuuma statusDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_statusDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerYuuma>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_statusDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BF4 RID: 19444
			// (get) Token: 0x0600E9BA RID: 59834 RVA: 0x0037E230 File Offset: 0x0037C430
			// (set) Token: 0x0600E9BB RID: 59835 RVA: 0x0007D060 File Offset: 0x0007B260
			public unsafe int yuumaCurrentLife
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_yuumaCurrentLife);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_yuumaCurrentLife)) = value;
				}
			}

			// Token: 0x17004BF5 RID: 19445
			// (get) Token: 0x0600E9BC RID: 59836 RVA: 0x0037E258 File Offset: 0x0037C458
			// (set) Token: 0x0600E9BD RID: 59837 RVA: 0x0007D07B File Offset: 0x0007B27B
			public unsafe int currentAnger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_currentAnger);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_currentAnger)) = value;
				}
			}

			// Token: 0x17004BF6 RID: 19446
			// (get) Token: 0x0600E9BE RID: 59838 RVA: 0x0037E280 File Offset: 0x0037C480
			// (set) Token: 0x0600E9BF RID: 59839 RVA: 0x0007D096 File Offset: 0x0007B296
			public unsafe Vector3 toutetsuSeatPostion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_toutetsuSeatPostion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_toutetsuSeatPostion)) = value;
				}
			}

			// Token: 0x17004BF7 RID: 19447
			// (get) Token: 0x0600E9C0 RID: 59840 RVA: 0x0037E2A8 File Offset: 0x0037C4A8
			// (set) Token: 0x0600E9C1 RID: 59841 RVA: 0x0007D0B1 File Offset: 0x0007B2B1
			public unsafe int phase2HP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_phase2HP);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_phase2HP)) = value;
				}
			}

			// Token: 0x17004BF8 RID: 19448
			// (get) Token: 0x0600E9C2 RID: 59842 RVA: 0x0037E2D0 File Offset: 0x0037C4D0
			// (set) Token: 0x0600E9C3 RID: 59843 RVA: 0x0007D0CC File Offset: 0x0007B2CC
			public unsafe int phase3HP
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_phase3HP);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_phase3HP)) = value;
				}
			}

			// Token: 0x17004BF9 RID: 19449
			// (get) Token: 0x0600E9C4 RID: 59844 RVA: 0x0037E2F8 File Offset: 0x0037C4F8
			// (set) Token: 0x0600E9C5 RID: 59845 RVA: 0x0007D0E7 File Offset: 0x0007B2E7
			public unsafe bool haveEnterPhase3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_haveEnterPhase3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_haveEnterPhase3)) = value;
				}
			}

			// Token: 0x17004BFA RID: 19450
			// (get) Token: 0x0600E9C6 RID: 59846 RVA: 0x0037E320 File Offset: 0x0037C520
			// (set) Token: 0x0600E9C7 RID: 59847 RVA: 0x0007D102 File Offset: 0x0007B302
			public unsafe SpecialGuestsController toutetsu
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_toutetsu);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_toutetsu), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BFB RID: 19451
			// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x0037E350 File Offset: 0x0037C550
			// (set) Token: 0x0600E9C9 RID: 59849 RVA: 0x0007D121 File Offset: 0x0007B321
			public unsafe bool isManualing
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_isManualing);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_isManualing)) = value;
				}
			}

			// Token: 0x17004BFC RID: 19452
			// (get) Token: 0x0600E9CA RID: 59850 RVA: 0x0037E378 File Offset: 0x0037C578
			// (set) Token: 0x0600E9CB RID: 59851 RVA: 0x0007D13C File Offset: 0x0007B33C
			public unsafe List<bool> isUsingSpellCards
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_isUsingSpellCards);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_isUsingSpellCards), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BFD RID: 19453
			// (get) Token: 0x0600E9CC RID: 59852 RVA: 0x0037E3A8 File Offset: 0x0037C5A8
			// (set) Token: 0x0600E9CD RID: 59853 RVA: 0x0007D15B File Offset: 0x0007B35B
			public unsafe SpecialGuest toutetsuData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_toutetsuData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_toutetsuData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BFE RID: 19454
			// (get) Token: 0x0600E9CE RID: 59854 RVA: 0x0037E3D8 File Offset: 0x0037C5D8
			// (set) Token: 0x0600E9CF RID: 59855 RVA: 0x0007D17A File Offset: 0x0007B37A
			public unsafe List<GameObject> eatingGameObejctCooker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_eatingGameObejctCooker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_eatingGameObejctCooker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BFF RID: 19455
			// (get) Token: 0x0600E9D0 RID: 59856 RVA: 0x0037E408 File Offset: 0x0037C608
			// (set) Token: 0x0600E9D1 RID: 59857 RVA: 0x0007D199 File Offset: 0x0007B399
			public unsafe Action bossBuffend
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_bossBuffend);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_bossBuffend), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C00 RID: 19456
			// (get) Token: 0x0600E9D2 RID: 59858 RVA: 0x0037E438 File Offset: 0x0037C638
			// (set) Token: 0x0600E9D3 RID: 59859 RVA: 0x0007D1B8 File Offset: 0x0007B3B8
			public unsafe Action interrupt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_interrupt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_interrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C01 RID: 19457
			// (get) Token: 0x0600E9D4 RID: 59860 RVA: 0x0037E468 File Offset: 0x0037C668
			// (set) Token: 0x0600E9D5 RID: 59861 RVA: 0x0007D1D7 File Offset: 0x0007B3D7
			public unsafe int currentGuestMaxNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_currentGuestMaxNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_currentGuestMaxNum)) = value;
				}
			}

			// Token: 0x17004C02 RID: 19458
			// (get) Token: 0x0600E9D6 RID: 59862 RVA: 0x0037E490 File Offset: 0x0037C690
			// (set) Token: 0x0600E9D7 RID: 59863 RVA: 0x0007D1F2 File Offset: 0x0007B3F2
			public unsafe WaitForSeconds waitForSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_waitForSeconds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_waitForSeconds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C03 RID: 19459
			// (get) Token: 0x0600E9D8 RID: 59864 RVA: 0x0037E4C0 File Offset: 0x0037C6C0
			// (set) Token: 0x0600E9D9 RID: 59865 RVA: 0x0007D211 File Offset: 0x0007B411
			public unsafe IEnumerable<int> allSelectedFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allSelectedFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allSelectedFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C04 RID: 19460
			// (get) Token: 0x0600E9DA RID: 59866 RVA: 0x0037E4F0 File Offset: 0x0037C6F0
			// (set) Token: 0x0600E9DB RID: 59867 RVA: 0x0007D230 File Offset: 0x0007B430
			public unsafe Dictionary<int, int> tagToAngerReductionDictionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_tagToAngerReductionDictionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_tagToAngerReductionDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C05 RID: 19461
			// (get) Token: 0x0600E9DC RID: 59868 RVA: 0x0037E520 File Offset: 0x0037C720
			// (set) Token: 0x0600E9DD RID: 59869 RVA: 0x0007D24F File Offset: 0x0007B44F
			public unsafe IEnumerable<int> allSelectedBev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allSelectedBev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allSelectedBev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C06 RID: 19462
			// (get) Token: 0x0600E9DE RID: 59870 RVA: 0x0037E550 File Offset: 0x0037C750
			// (set) Token: 0x0600E9DF RID: 59871 RVA: 0x0007D26E File Offset: 0x0007B46E
			public unsafe List<int> allFoodTagsPoolOrdered
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allFoodTagsPoolOrdered);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allFoodTagsPoolOrdered), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C07 RID: 19463
			// (get) Token: 0x0600E9E0 RID: 59872 RVA: 0x0037E580 File Offset: 0x0037C780
			// (set) Token: 0x0600E9E1 RID: 59873 RVA: 0x0007D28D File Offset: 0x0007B48D
			public unsafe List<int> allBevTagsPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allBevTagsPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr_allBevTagsPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C08 RID: 19464
			// (get) Token: 0x0600E9E2 RID: 59874 RVA: 0x0037E5B0 File Offset: 0x0037C7B0
			// (set) Token: 0x0600E9E3 RID: 59875 RVA: 0x0007D2AC File Offset: 0x0007B4AC
			public unsafe Func<Vector2Int, bool> __9__57
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__57);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__57), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C09 RID: 19465
			// (get) Token: 0x0600E9E4 RID: 59876 RVA: 0x0037E5E0 File Offset: 0x0037C7E0
			// (set) Token: 0x0600E9E5 RID: 59877 RVA: 0x0007D2CB File Offset: 0x0007B4CB
			public unsafe Action<GuestGroupController> __9__77
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__77);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__77), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C0A RID: 19466
			// (get) Token: 0x0600E9E6 RID: 59878 RVA: 0x0037E610 File Offset: 0x0037C810
			// (set) Token: 0x0600E9E7 RID: 59879 RVA: 0x0007D2EA File Offset: 0x0007B4EA
			public unsafe Func<bool> __9__75
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__75);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__75), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C0B RID: 19467
			// (get) Token: 0x0600E9E8 RID: 59880 RVA: 0x0037E640 File Offset: 0x0037C840
			// (set) Token: 0x0600E9E9 RID: 59881 RVA: 0x0007D309 File Offset: 0x0007B509
			public unsafe Action<GuestGroupController.EvaluationResult> __9__88
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__88);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__88), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C0C RID: 19468
			// (get) Token: 0x0600E9EA RID: 59882 RVA: 0x0037E670 File Offset: 0x0037C870
			// (set) Token: 0x0600E9EB RID: 59883 RVA: 0x0007D328 File Offset: 0x0007B528
			public unsafe Action<GuestGroupController.EvaluationResult> __9__89
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__89);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.NativeFieldInfoPtr___9__89), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040094D7 RID: 38103
			private static readonly IntPtr NativeFieldInfoPtr_restCountDown;

			// Token: 0x040094D8 RID: 38104
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040094D9 RID: 38105
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040094DA RID: 38106
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x040094DB RID: 38107
			private static readonly IntPtr NativeFieldInfoPtr_banTags;

			// Token: 0x040094DC RID: 38108
			private static readonly IntPtr NativeFieldInfoPtr_yuumaWantedTag;

			// Token: 0x040094DD RID: 38109
			private static readonly IntPtr NativeFieldInfoPtr_allFoodTagsPoolWanted;

			// Token: 0x040094DE RID: 38110
			private static readonly IntPtr NativeFieldInfoPtr_haveEnterPhase2;

			// Token: 0x040094DF RID: 38111
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x040094E0 RID: 38112
			private static readonly IntPtr NativeFieldInfoPtr_totalCookers;

			// Token: 0x040094E1 RID: 38113
			private static readonly IntPtr NativeFieldInfoPtr_uiManager;

			// Token: 0x040094E2 RID: 38114
			private static readonly IntPtr NativeFieldInfoPtr_ptc;

			// Token: 0x040094E3 RID: 38115
			private static readonly IntPtr NativeFieldInfoPtr_statusDisplayerTransition;

			// Token: 0x040094E4 RID: 38116
			private static readonly IntPtr NativeFieldInfoPtr_yuumaSkillCorotine;

			// Token: 0x040094E5 RID: 38117
			private static readonly IntPtr NativeFieldInfoPtr_mainLoop;

			// Token: 0x040094E6 RID: 38118
			private static readonly IntPtr NativeFieldInfoPtr_standSpawnLoop;

			// Token: 0x040094E7 RID: 38119
			private static readonly IntPtr NativeFieldInfoPtr_guestsManager;

			// Token: 0x040094E8 RID: 38120
			private static readonly IntPtr NativeFieldInfoPtr_canContinueYieldInstruction;

			// Token: 0x040094E9 RID: 38121
			private static readonly IntPtr NativeFieldInfoPtr_currentTagChangeLife;

			// Token: 0x040094EA RID: 38122
			private static readonly IntPtr NativeFieldInfoPtr_tagPerChangeLife;

			// Token: 0x040094EB RID: 38123
			private static readonly IntPtr NativeFieldInfoPtr_statusDisplayer;

			// Token: 0x040094EC RID: 38124
			private static readonly IntPtr NativeFieldInfoPtr_yuumaCurrentLife;

			// Token: 0x040094ED RID: 38125
			private static readonly IntPtr NativeFieldInfoPtr_currentAnger;

			// Token: 0x040094EE RID: 38126
			private static readonly IntPtr NativeFieldInfoPtr_toutetsuSeatPostion;

			// Token: 0x040094EF RID: 38127
			private static readonly IntPtr NativeFieldInfoPtr_phase2HP;

			// Token: 0x040094F0 RID: 38128
			private static readonly IntPtr NativeFieldInfoPtr_phase3HP;

			// Token: 0x040094F1 RID: 38129
			private static readonly IntPtr NativeFieldInfoPtr_haveEnterPhase3;

			// Token: 0x040094F2 RID: 38130
			private static readonly IntPtr NativeFieldInfoPtr_toutetsu;

			// Token: 0x040094F3 RID: 38131
			private static readonly IntPtr NativeFieldInfoPtr_isManualing;

			// Token: 0x040094F4 RID: 38132
			private static readonly IntPtr NativeFieldInfoPtr_isUsingSpellCards;

			// Token: 0x040094F5 RID: 38133
			private static readonly IntPtr NativeFieldInfoPtr_toutetsuData;

			// Token: 0x040094F6 RID: 38134
			private static readonly IntPtr NativeFieldInfoPtr_eatingGameObejctCooker;

			// Token: 0x040094F7 RID: 38135
			private static readonly IntPtr NativeFieldInfoPtr_bossBuffend;

			// Token: 0x040094F8 RID: 38136
			private static readonly IntPtr NativeFieldInfoPtr_interrupt;

			// Token: 0x040094F9 RID: 38137
			private static readonly IntPtr NativeFieldInfoPtr_currentGuestMaxNum;

			// Token: 0x040094FA RID: 38138
			private static readonly IntPtr NativeFieldInfoPtr_waitForSeconds;

			// Token: 0x040094FB RID: 38139
			private static readonly IntPtr NativeFieldInfoPtr_allSelectedFood;

			// Token: 0x040094FC RID: 38140
			private static readonly IntPtr NativeFieldInfoPtr_tagToAngerReductionDictionary;

			// Token: 0x040094FD RID: 38141
			private static readonly IntPtr NativeFieldInfoPtr_allSelectedBev;

			// Token: 0x040094FE RID: 38142
			private static readonly IntPtr NativeFieldInfoPtr_allFoodTagsPoolOrdered;

			// Token: 0x040094FF RID: 38143
			private static readonly IntPtr NativeFieldInfoPtr_allBevTagsPool;

			// Token: 0x04009500 RID: 38144
			private static readonly IntPtr NativeFieldInfoPtr___9__57;

			// Token: 0x04009501 RID: 38145
			private static readonly IntPtr NativeFieldInfoPtr___9__77;

			// Token: 0x04009502 RID: 38146
			private static readonly IntPtr NativeFieldInfoPtr___9__75;

			// Token: 0x04009503 RID: 38147
			private static readonly IntPtr NativeFieldInfoPtr___9__88;

			// Token: 0x04009504 RID: 38148
			private static readonly IntPtr NativeFieldInfoPtr___9__89;

			// Token: 0x04009505 RID: 38149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009506 RID: 38150
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_0;

			// Token: 0x04009507 RID: 38151
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Boolean_1;

			// Token: 0x04009508 RID: 38152
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_YuumaTutorialPhase_0;

			// Token: 0x04009509 RID: 38153
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_3;

			// Token: 0x0400950A RID: 38154
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Boolean_Int32_0;

			// Token: 0x0400950B RID: 38155
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Boolean_Int32_0;

			// Token: 0x0400950C RID: 38156
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x0400950D RID: 38157
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400950E RID: 38158
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__14_Internal_Void_3;

			// Token: 0x0400950F RID: 38159
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0;

			// Token: 0x04009510 RID: 38160
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__17_Internal_Void_3;

			// Token: 0x04009511 RID: 38161
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Void_3;

			// Token: 0x04009512 RID: 38162
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x04009513 RID: 38163
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Void_Coroutine_0;

			// Token: 0x04009514 RID: 38164
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Void_3;

			// Token: 0x04009515 RID: 38165
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_1;

			// Token: 0x04009516 RID: 38166
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__57_Internal_Boolean_Vector2Int_0;

			// Token: 0x04009517 RID: 38167
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_Int32_PDM_0;

			// Token: 0x04009518 RID: 38168
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_0;

			// Token: 0x04009519 RID: 38169
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_1;

			// Token: 0x0400951A RID: 38170
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_2;

			// Token: 0x0400951B RID: 38171
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__58_Internal_Void_GuestGroupController_0;

			// Token: 0x0400951C RID: 38172
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x0400951D RID: 38173
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_2;

			// Token: 0x0400951E RID: 38174
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector3_PDM_0;

			// Token: 0x0400951F RID: 38175
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_Internal_Boolean_Int32_0;

			// Token: 0x04009520 RID: 38176
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector3_PDM_1;

			// Token: 0x04009521 RID: 38177
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_3;

			// Token: 0x04009522 RID: 38178
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009523 RID: 38179
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__77_Internal_Void_GuestGroupController_0;

			// Token: 0x04009524 RID: 38180
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_Boolean_1;

			// Token: 0x04009525 RID: 38181
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Int32_0;

			// Token: 0x04009526 RID: 38182
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_Sellable_PDM_0;

			// Token: 0x04009527 RID: 38183
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__82_Internal_Boolean_Int32_0;

			// Token: 0x04009528 RID: 38184
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__81_Internal_Boolean_Int32_0;

			// Token: 0x04009529 RID: 38185
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_0;

			// Token: 0x0400952A RID: 38186
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0;

			// Token: 0x0400952B RID: 38187
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0;

			// Token: 0x0400952C RID: 38188
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x0400952D RID: 38189
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__88_Internal_Void_EvaluationResult_0;

			// Token: 0x0400952E RID: 38190
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__89_Internal_Void_EvaluationResult_0;

			// Token: 0x0400952F RID: 38191
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__40_Internal_Boolean_1;

			// Token: 0x04009530 RID: 38192
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__41_Internal_Boolean_1;

			// Token: 0x04009531 RID: 38193
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__42_Internal_Void_3;

			// Token: 0x04009532 RID: 38194
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__43_Internal_Boolean_1;

			// Token: 0x04009533 RID: 38195
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Boolean_1;

			// Token: 0x04009534 RID: 38196
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__45_Internal_Void_3;

			// Token: 0x04009535 RID: 38197
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__46_Internal_Boolean_1;

			// Token: 0x04009536 RID: 38198
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__48_Internal_Void_Coroutine_0;

			// Token: 0x02001068 RID: 4200
			[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_0+<<MainChallengeLoop>g__Timing|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011E70 RID: 73328 RVA: 0x00418088 File Offset: 0x00416288
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique()
				{
					Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<<MainChallengeLoop>g__Timing|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<>1__state");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<>2__current");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<>4__this");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr_extraTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "extraTiming");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__totalCountDown_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<totalCountDown>5__2");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__progress_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<progress>5__3");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681503);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681504);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681505);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681506);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681507);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681508);
				}

				// Token: 0x06011E71 RID: 73329 RVA: 0x004181A4 File Offset: 0x004163A4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E72 RID: 73330 RVA: 0x004181EC File Offset: 0x004163EC
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E73 RID: 73331 RVA: 0x00418220 File Offset: 0x00416420
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220023, XrefRangeEnd = 220026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D56 RID: 23894
				// (get) Token: 0x06011E74 RID: 73332 RVA: 0x0041825C File Offset: 0x0041645C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E75 RID: 73333 RVA: 0x0041829C File Offset: 0x0041649C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220026, XrefRangeEnd = 220032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D57 RID: 23895
				// (get) Token: 0x06011E76 RID: 73334 RVA: 0x004182D0 File Offset: 0x004164D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E77 RID: 73335 RVA: 0x0009B8CE File Offset: 0x00099ACE
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D50 RID: 23888
				// (get) Token: 0x06011E78 RID: 73336 RVA: 0x00418310 File Offset: 0x00416510
				// (set) Token: 0x06011E79 RID: 73337 RVA: 0x0009B8D7 File Offset: 0x00099AD7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D51 RID: 23889
				// (get) Token: 0x06011E7A RID: 73338 RVA: 0x00418338 File Offset: 0x00416538
				// (set) Token: 0x06011E7B RID: 73339 RVA: 0x0009B8F2 File Offset: 0x00099AF2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D52 RID: 23890
				// (get) Token: 0x06011E7C RID: 73340 RVA: 0x00418368 File Offset: 0x00416568
				// (set) Token: 0x06011E7D RID: 73341 RVA: 0x0009B911 File Offset: 0x00099B11
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D53 RID: 23891
				// (get) Token: 0x06011E7E RID: 73342 RVA: 0x00418398 File Offset: 0x00416598
				// (set) Token: 0x06011E7F RID: 73343 RVA: 0x0009B930 File Offset: 0x00099B30
				public unsafe Func<bool> extraTiming
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr_extraTiming);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr_extraTiming), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D54 RID: 23892
				// (get) Token: 0x06011E80 RID: 73344 RVA: 0x004183C8 File Offset: 0x004165C8
				// (set) Token: 0x06011E81 RID: 73345 RVA: 0x0009B94F File Offset: 0x00099B4F
				public unsafe int _totalCountDown_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__totalCountDown_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__totalCountDown_5__2)) = value;
					}
				}

				// Token: 0x17005D55 RID: 23893
				// (get) Token: 0x06011E82 RID: 73346 RVA: 0x004183F0 File Offset: 0x004165F0
				// (set) Token: 0x06011E83 RID: 73347 RVA: 0x0009B96A File Offset: 0x00099B6A
				public unsafe float _progress_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__progress_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__progress_5__3)) = value;
					}
				}

				// Token: 0x0400B56C RID: 46444
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B56D RID: 46445
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B56E RID: 46446
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B56F RID: 46447
				private static readonly IntPtr NativeFieldInfoPtr_extraTiming;

				// Token: 0x0400B570 RID: 46448
				private static readonly IntPtr NativeFieldInfoPtr__totalCountDown_5__2;

				// Token: 0x0400B571 RID: 46449
				private static readonly IntPtr NativeFieldInfoPtr__progress_5__3;

				// Token: 0x0400B572 RID: 46450
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B573 RID: 46451
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B574 RID: 46452
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B575 RID: 46453
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B576 RID: 46454
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B577 RID: 46455
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001069 RID: 4201
			[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_0+<<MainChallengeLoop>g__OpenTutorialPanel|4>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011E84 RID: 73348 RVA: 0x00418418 File Offset: 0x00416618
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique()
				{
					Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<<MainChallengeLoop>g__OpenTutorialPanel|4>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, "<>1__state");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, "<>2__current");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, "<>4__this");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr_yuumaTutorialPhase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, "yuumaTutorialPhase");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, 100681509);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, 100681510);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, 100681511);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, 100681512);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, 100681513);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr, 100681514);
				}

				// Token: 0x06011E85 RID: 73349 RVA: 0x0041850C File Offset: 0x0041670C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E86 RID: 73350 RVA: 0x00418554 File Offset: 0x00416754
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E87 RID: 73351 RVA: 0x00418588 File Offset: 0x00416788
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220032, XrefRangeEnd = 220069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D5C RID: 23900
				// (get) Token: 0x06011E88 RID: 73352 RVA: 0x004185C4 File Offset: 0x004167C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E89 RID: 73353 RVA: 0x00418604 File Offset: 0x00416804
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220069, XrefRangeEnd = 220075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D5D RID: 23901
				// (get) Token: 0x06011E8A RID: 73354 RVA: 0x00418638 File Offset: 0x00416838
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E8B RID: 73355 RVA: 0x0009B985 File Offset: 0x00099B85
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D58 RID: 23896
				// (get) Token: 0x06011E8C RID: 73356 RVA: 0x00418678 File Offset: 0x00416878
				// (set) Token: 0x06011E8D RID: 73357 RVA: 0x0009B98E File Offset: 0x00099B8E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D59 RID: 23897
				// (get) Token: 0x06011E8E RID: 73358 RVA: 0x004186A0 File Offset: 0x004168A0
				// (set) Token: 0x06011E8F RID: 73359 RVA: 0x0009B9A9 File Offset: 0x00099BA9
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D5A RID: 23898
				// (get) Token: 0x06011E90 RID: 73360 RVA: 0x004186D0 File Offset: 0x004168D0
				// (set) Token: 0x06011E91 RID: 73361 RVA: 0x0009B9C8 File Offset: 0x00099BC8
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D5B RID: 23899
				// (get) Token: 0x06011E92 RID: 73362 RVA: 0x00418700 File Offset: 0x00416900
				// (set) Token: 0x06011E93 RID: 73363 RVA: 0x0009B9E7 File Offset: 0x00099BE7
				public unsafe EventToutetsuYuumaTutorialPanel.YuumaTutorialPhase yuumaTutorialPhase
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr_yuumaTutorialPhase);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObYuyuObObUnique.NativeFieldInfoPtr_yuumaTutorialPhase)) = value;
					}
				}

				// Token: 0x0400B578 RID: 46456
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B579 RID: 46457
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B57A RID: 46458
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B57B RID: 46459
				private static readonly IntPtr NativeFieldInfoPtr_yuumaTutorialPhase;

				// Token: 0x0400B57C RID: 46460
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B57D RID: 46461
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B57E RID: 46462
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B57F RID: 46463
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B580 RID: 46464
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B581 RID: 46465
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200106A RID: 4202
			[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_0+<<MainChallengeLoop>g__OnFail|19>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0 : Il2CppSystem.Object
			{
				// Token: 0x06011E94 RID: 73364 RVA: 0x00418728 File Offset: 0x00416928
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0()
				{
					Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<<MainChallengeLoop>g__OnFail|19>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>1__state");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>2__current");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>4__this");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681515);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681516);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681517);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681518);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681519);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681520);
				}

				// Token: 0x06011E95 RID: 73365 RVA: 0x00418808 File Offset: 0x00416A08
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E96 RID: 73366 RVA: 0x00418850 File Offset: 0x00416A50
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011E97 RID: 73367 RVA: 0x00418884 File Offset: 0x00416A84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220075, XrefRangeEnd = 220136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D61 RID: 23905
				// (get) Token: 0x06011E98 RID: 73368 RVA: 0x004188C0 File Offset: 0x00416AC0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E99 RID: 73369 RVA: 0x00418900 File Offset: 0x00416B00
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220136, XrefRangeEnd = 220142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D62 RID: 23906
				// (get) Token: 0x06011E9A RID: 73370 RVA: 0x00418934 File Offset: 0x00416B34
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011E9B RID: 73371 RVA: 0x0009BA02 File Offset: 0x00099C02
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D5E RID: 23902
				// (get) Token: 0x06011E9C RID: 73372 RVA: 0x00418974 File Offset: 0x00416B74
				// (set) Token: 0x06011E9D RID: 73373 RVA: 0x0009BA0B File Offset: 0x00099C0B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D5F RID: 23903
				// (get) Token: 0x06011E9E RID: 73374 RVA: 0x0041899C File Offset: 0x00416B9C
				// (set) Token: 0x06011E9F RID: 73375 RVA: 0x0009BA26 File Offset: 0x00099C26
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D60 RID: 23904
				// (get) Token: 0x06011EA0 RID: 73376 RVA: 0x004189CC File Offset: 0x00416BCC
				// (set) Token: 0x06011EA1 RID: 73377 RVA: 0x0009BA45 File Offset: 0x00099C45
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B582 RID: 46466
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B583 RID: 46467
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B584 RID: 46468
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B585 RID: 46469
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B586 RID: 46470
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B587 RID: 46471
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B588 RID: 46472
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B589 RID: 46473
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B58A RID: 46474
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200106B RID: 4203
			[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_0+<<MainChallengeLoop>g__YuumaSpellAngry|27>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011EA2 RID: 73378 RVA: 0x004189FC File Offset: 0x00416BFC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique()
				{
					Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<<MainChallengeLoop>g__YuumaSpellAngry|27>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, "<>1__state");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, "<>2__current");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, "<>4__this");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr_yuumaPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, "yuumaPosition");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, "<>8__1");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, "<>8__2");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr__eatingSprite_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, "<eatingSprite>5__2");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, 100681521);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, 100681522);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, 100681523);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, 100681524);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, 100681525);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr, 100681526);
				}

				// Token: 0x06011EA3 RID: 73379 RVA: 0x00418B2C File Offset: 0x00416D2C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EA4 RID: 73380 RVA: 0x00418B74 File Offset: 0x00416D74
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EA5 RID: 73381 RVA: 0x00418BA8 File Offset: 0x00416DA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220142, XrefRangeEnd = 220497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D6A RID: 23914
				// (get) Token: 0x06011EA6 RID: 73382 RVA: 0x00418BE4 File Offset: 0x00416DE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011EA7 RID: 73383 RVA: 0x00418C24 File Offset: 0x00416E24
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220497, XrefRangeEnd = 220503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D6B RID: 23915
				// (get) Token: 0x06011EA8 RID: 73384 RVA: 0x00418C58 File Offset: 0x00416E58
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011EA9 RID: 73385 RVA: 0x0009BA64 File Offset: 0x00099C64
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D63 RID: 23907
				// (get) Token: 0x06011EAA RID: 73386 RVA: 0x00418C98 File Offset: 0x00416E98
				// (set) Token: 0x06011EAB RID: 73387 RVA: 0x0009BA6D File Offset: 0x00099C6D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D64 RID: 23908
				// (get) Token: 0x06011EAC RID: 73388 RVA: 0x00418CC0 File Offset: 0x00416EC0
				// (set) Token: 0x06011EAD RID: 73389 RVA: 0x0009BA88 File Offset: 0x00099C88
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D65 RID: 23909
				// (get) Token: 0x06011EAE RID: 73390 RVA: 0x00418CF0 File Offset: 0x00416EF0
				// (set) Token: 0x06011EAF RID: 73391 RVA: 0x0009BAA7 File Offset: 0x00099CA7
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D66 RID: 23910
				// (get) Token: 0x06011EB0 RID: 73392 RVA: 0x00418D20 File Offset: 0x00416F20
				// (set) Token: 0x06011EB1 RID: 73393 RVA: 0x0009BAC6 File Offset: 0x00099CC6
				public unsafe Vector3 yuumaPosition
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr_yuumaPosition);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr_yuumaPosition)) = value;
					}
				}

				// Token: 0x17005D67 RID: 23911
				// (get) Token: 0x06011EB2 RID: 73394 RVA: 0x00418D48 File Offset: 0x00416F48
				// (set) Token: 0x06011EB3 RID: 73395 RVA: 0x0009BAE1 File Offset: 0x00099CE1
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_2 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D68 RID: 23912
				// (get) Token: 0x06011EB4 RID: 73396 RVA: 0x00418D78 File Offset: 0x00416F78
				// (set) Token: 0x06011EB5 RID: 73397 RVA: 0x0009BB00 File Offset: 0x00099D00
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_3 __8__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___8__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_3>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D69 RID: 23913
				// (get) Token: 0x06011EB6 RID: 73398 RVA: 0x00418DA8 File Offset: 0x00416FA8
				// (set) Token: 0x06011EB7 RID: 73399 RVA: 0x0009BB1F File Offset: 0x00099D1F
				public unsafe List<GameObject> _eatingSprite_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr__eatingSprite_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuLi1GaObObUnique.NativeFieldInfoPtr__eatingSprite_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B58B RID: 46475
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B58C RID: 46476
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B58D RID: 46477
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B58E RID: 46478
				private static readonly IntPtr NativeFieldInfoPtr_yuumaPosition;

				// Token: 0x0400B58F RID: 46479
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B590 RID: 46480
				private static readonly IntPtr NativeFieldInfoPtr___8__2;

				// Token: 0x0400B591 RID: 46481
				private static readonly IntPtr NativeFieldInfoPtr__eatingSprite_5__2;

				// Token: 0x0400B592 RID: 46482
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B593 RID: 46483
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B594 RID: 46484
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B595 RID: 46485
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B596 RID: 46486
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B597 RID: 46487
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200106C RID: 4204
			[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_0+<<MainChallengeLoop>g__YuumaSpellNormal|28>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011EB8 RID: 73400 RVA: 0x00418DD8 File Offset: 0x00416FD8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique()
				{
					Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<<MainChallengeLoop>g__YuumaSpellNormal|28>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, "<>1__state");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, "<>2__current");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr_yuumaPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, "yuumaPosition");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, "<>4__this");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, "<>8__1");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, 100681527);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, 100681528);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, 100681529);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, 100681530);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, 100681531);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr, 100681532);
				}

				// Token: 0x06011EB9 RID: 73401 RVA: 0x00418EE0 File Offset: 0x004170E0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EBA RID: 73402 RVA: 0x00418F28 File Offset: 0x00417128
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EBB RID: 73403 RVA: 0x00418F5C File Offset: 0x0041715C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220503, XrefRangeEnd = 220631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D71 RID: 23921
				// (get) Token: 0x06011EBC RID: 73404 RVA: 0x00418F98 File Offset: 0x00417198
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011EBD RID: 73405 RVA: 0x00418FD8 File Offset: 0x004171D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220631, XrefRangeEnd = 220637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D72 RID: 23922
				// (get) Token: 0x06011EBE RID: 73406 RVA: 0x0041900C File Offset: 0x0041720C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011EBF RID: 73407 RVA: 0x0009BB3E File Offset: 0x00099D3E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D6C RID: 23916
				// (get) Token: 0x06011EC0 RID: 73408 RVA: 0x0041904C File Offset: 0x0041724C
				// (set) Token: 0x06011EC1 RID: 73409 RVA: 0x0009BB47 File Offset: 0x00099D47
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D6D RID: 23917
				// (get) Token: 0x06011EC2 RID: 73410 RVA: 0x00419074 File Offset: 0x00417274
				// (set) Token: 0x06011EC3 RID: 73411 RVA: 0x0009BB62 File Offset: 0x00099D62
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D6E RID: 23918
				// (get) Token: 0x06011EC4 RID: 73412 RVA: 0x004190A4 File Offset: 0x004172A4
				// (set) Token: 0x06011EC5 RID: 73413 RVA: 0x0009BB81 File Offset: 0x00099D81
				public unsafe Vector3 yuumaPosition
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr_yuumaPosition);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr_yuumaPosition)) = value;
					}
				}

				// Token: 0x17005D6F RID: 23919
				// (get) Token: 0x06011EC6 RID: 73414 RVA: 0x004190CC File Offset: 0x004172CC
				// (set) Token: 0x06011EC7 RID: 73415 RVA: 0x0009BB9C File Offset: 0x00099D9C
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D70 RID: 23920
				// (get) Token: 0x06011EC8 RID: 73416 RVA: 0x004190FC File Offset: 0x004172FC
				// (set) Token: 0x06011EC9 RID: 73417 RVA: 0x0009BBBB File Offset: 0x00099DBB
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_5 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_5>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeyuObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B598 RID: 46488
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B599 RID: 46489
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B59A RID: 46490
				private static readonly IntPtr NativeFieldInfoPtr_yuumaPosition;

				// Token: 0x0400B59B RID: 46491
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B59C RID: 46492
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B59D RID: 46493
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B59E RID: 46494
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B59F RID: 46495
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5A0 RID: 46496
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5A1 RID: 46497
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5A2 RID: 46498
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200106D RID: 4205
			[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_0+<<MainChallengeLoop>g__Phase3GuestSpawnLoop|30>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1 : Il2CppSystem.Object
			{
				// Token: 0x06011ECA RID: 73418 RVA: 0x0041912C File Offset: 0x0041732C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1()
				{
					Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase3GuestSpawnLoop|30>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>1__state");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>2__current");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>4__this");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681533);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681534);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681535);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681536);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681537);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681538);
				}

				// Token: 0x06011ECB RID: 73419 RVA: 0x0041920C File Offset: 0x0041740C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011ECC RID: 73420 RVA: 0x00419254 File Offset: 0x00417454
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011ECD RID: 73421 RVA: 0x00419288 File Offset: 0x00417488
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220637, XrefRangeEnd = 220664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D76 RID: 23926
				// (get) Token: 0x06011ECE RID: 73422 RVA: 0x004192C4 File Offset: 0x004174C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011ECF RID: 73423 RVA: 0x00419304 File Offset: 0x00417504
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220664, XrefRangeEnd = 220670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D77 RID: 23927
				// (get) Token: 0x06011ED0 RID: 73424 RVA: 0x00419338 File Offset: 0x00417538
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011ED1 RID: 73425 RVA: 0x0009BBDA File Offset: 0x00099DDA
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D73 RID: 23923
				// (get) Token: 0x06011ED2 RID: 73426 RVA: 0x00419378 File Offset: 0x00417578
				// (set) Token: 0x06011ED3 RID: 73427 RVA: 0x0009BBE3 File Offset: 0x00099DE3
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D74 RID: 23924
				// (get) Token: 0x06011ED4 RID: 73428 RVA: 0x004193A0 File Offset: 0x004175A0
				// (set) Token: 0x06011ED5 RID: 73429 RVA: 0x0009BBFE File Offset: 0x00099DFE
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D75 RID: 23925
				// (get) Token: 0x06011ED6 RID: 73430 RVA: 0x004193D0 File Offset: 0x004175D0
				// (set) Token: 0x06011ED7 RID: 73431 RVA: 0x0009BC1D File Offset: 0x00099E1D
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B5A3 RID: 46499
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B5A4 RID: 46500
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B5A5 RID: 46501
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B5A6 RID: 46502
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B5A7 RID: 46503
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5A8 RID: 46504
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5A9 RID: 46505
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5AA RID: 46506
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5AB RID: 46507
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200106E RID: 4206
			[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_0+<<MainChallengeLoop>g__Phase3OrderLoop|39>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2 : Il2CppSystem.Object
			{
				// Token: 0x06011ED8 RID: 73432 RVA: 0x00419400 File Offset: 0x00417600
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2()
				{
					Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase3OrderLoop|39>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, "<>1__state");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, "<>2__current");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, "<>4__this");
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681539);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681540);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681541);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681542);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681543);
					DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681544);
				}

				// Token: 0x06011ED9 RID: 73433 RVA: 0x004194E0 File Offset: 0x004176E0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EDA RID: 73434 RVA: 0x00419528 File Offset: 0x00417728
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EDB RID: 73435 RVA: 0x0041955C File Offset: 0x0041775C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220670, XrefRangeEnd = 220701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D7B RID: 23931
				// (get) Token: 0x06011EDC RID: 73436 RVA: 0x00419598 File Offset: 0x00417798
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011EDD RID: 73437 RVA: 0x004195D8 File Offset: 0x004177D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220701, XrefRangeEnd = 220707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D7C RID: 23932
				// (get) Token: 0x06011EDE RID: 73438 RVA: 0x0041960C File Offset: 0x0041780C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011EDF RID: 73439 RVA: 0x0009BC3C File Offset: 0x00099E3C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D78 RID: 23928
				// (get) Token: 0x06011EE0 RID: 73440 RVA: 0x0041964C File Offset: 0x0041784C
				// (set) Token: 0x06011EE1 RID: 73441 RVA: 0x0009BC45 File Offset: 0x00099E45
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D79 RID: 23929
				// (get) Token: 0x06011EE2 RID: 73442 RVA: 0x00419674 File Offset: 0x00417874
				// (set) Token: 0x06011EE3 RID: 73443 RVA: 0x0009BC60 File Offset: 0x00099E60
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D7A RID: 23930
				// (get) Token: 0x06011EE4 RID: 73444 RVA: 0x004196A4 File Offset: 0x004178A4
				// (set) Token: 0x06011EE5 RID: 73445 RVA: 0x0009BC7F File Offset: 0x00099E7F
				public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B5AC RID: 46508
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B5AD RID: 46509
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B5AE RID: 46510
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B5AF RID: 46511
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B5B0 RID: 46512
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5B1 RID: 46513
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5B2 RID: 46514
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5B3 RID: 46515
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5B4 RID: 46516
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000CBD RID: 3261
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_1")]
		public sealed class __c__DisplayClass26_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E9EC RID: 59884 RVA: 0x0037E6A0 File Offset: 0x0037C8A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_1()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_1>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_1.NativeFieldInfoPtr_canContinue2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_1>.NativeClassPtr, "canContinue2");
				DLC1_YuumaBossData.__c__DisplayClass26_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_1>.NativeClassPtr, 100681545);
				DLC1_YuumaBossData.__c__DisplayClass26_1.NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_1>.NativeClassPtr, 100681546);
				DLC1_YuumaBossData.__c__DisplayClass26_1.NativeMethodInfoPtr__MainChallengeLoop_b__53_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_1>.NativeClassPtr, 100681547);
			}

			// Token: 0x0600E9ED RID: 59885 RVA: 0x0037E71C File Offset: 0x0037C91C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9EE RID: 59886 RVA: 0x0037E758 File Offset: 0x0037C958
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221069, XrefRangeEnd = 221073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__52()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_1.NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9EF RID: 59887 RVA: 0x0037E78C File Offset: 0x0037C98C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__53()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_1.NativeMethodInfoPtr__MainChallengeLoop_b__53_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E9F0 RID: 59888 RVA: 0x0007D347 File Offset: 0x0007B547
			public __c__DisplayClass26_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C0D RID: 19469
			// (get) Token: 0x0600E9F1 RID: 59889 RVA: 0x0037E7C8 File Offset: 0x0037C9C8
			// (set) Token: 0x0600E9F2 RID: 59890 RVA: 0x0007D350 File Offset: 0x0007B550
			public unsafe bool canContinue2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_1.NativeFieldInfoPtr_canContinue2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_1.NativeFieldInfoPtr_canContinue2)) = value;
				}
			}

			// Token: 0x04009537 RID: 38199
			private static readonly IntPtr NativeFieldInfoPtr_canContinue2;

			// Token: 0x04009538 RID: 38200
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009539 RID: 38201
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Void_0;

			// Token: 0x0400953A RID: 38202
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__53_Internal_Boolean_0;
		}

		// Token: 0x02000CBE RID: 3262
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_2")]
		public sealed class __c__DisplayClass26_2 : Il2CppSystem.Object
		{
			// Token: 0x0600E9F3 RID: 59891 RVA: 0x0037E7F0 File Offset: 0x0037C9F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_2()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_2>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_2.NativeFieldInfoPtr_yuumaPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_2>.NativeClassPtr, "yuumaPosition");
				DLC1_YuumaBossData.__c__DisplayClass26_2.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_2>.NativeClassPtr, "CS$<>8__locals1");
				DLC1_YuumaBossData.__c__DisplayClass26_2.NativeFieldInfoPtr___9__69 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_2>.NativeClassPtr, "<>9__69");
				DLC1_YuumaBossData.__c__DisplayClass26_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_2>.NativeClassPtr, 100681548);
				DLC1_YuumaBossData.__c__DisplayClass26_2.NativeMethodInfoPtr__MainChallengeLoop_b__69_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_2>.NativeClassPtr, 100681549);
			}

			// Token: 0x0600E9F4 RID: 59892 RVA: 0x0037E880 File Offset: 0x0037CA80
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9F5 RID: 59893 RVA: 0x0037E8BC File Offset: 0x0037CABC
			[CallerCount(0)]
			public unsafe Vector3 _MainChallengeLoop_b__69()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_2.NativeMethodInfoPtr__MainChallengeLoop_b__69_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E9F6 RID: 59894 RVA: 0x0007D36B File Offset: 0x0007B56B
			public __c__DisplayClass26_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C0E RID: 19470
			// (get) Token: 0x0600E9F7 RID: 59895 RVA: 0x0037E8F8 File Offset: 0x0037CAF8
			// (set) Token: 0x0600E9F8 RID: 59896 RVA: 0x0007D374 File Offset: 0x0007B574
			public unsafe Vector3 yuumaPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_2.NativeFieldInfoPtr_yuumaPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_2.NativeFieldInfoPtr_yuumaPosition)) = value;
				}
			}

			// Token: 0x17004C0F RID: 19471
			// (get) Token: 0x0600E9F9 RID: 59897 RVA: 0x0037E920 File Offset: 0x0037CB20
			// (set) Token: 0x0600E9FA RID: 59898 RVA: 0x0007D38F File Offset: 0x0007B58F
			public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 field_Public___c__DisplayClass26_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_2.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_2.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C10 RID: 19472
			// (get) Token: 0x0600E9FB RID: 59899 RVA: 0x0037E950 File Offset: 0x0037CB50
			// (set) Token: 0x0600E9FC RID: 59900 RVA: 0x0007D3AE File Offset: 0x0007B5AE
			public unsafe Func<Vector3> __9__69
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_2.NativeFieldInfoPtr___9__69);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_2.NativeFieldInfoPtr___9__69), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400953B RID: 38203
			private static readonly IntPtr NativeFieldInfoPtr_yuumaPosition;

			// Token: 0x0400953C RID: 38204
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0;

			// Token: 0x0400953D RID: 38205
			private static readonly IntPtr NativeFieldInfoPtr___9__69;

			// Token: 0x0400953E RID: 38206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400953F RID: 38207
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__69_Internal_Vector3_0;
		}

		// Token: 0x02000CBF RID: 3263
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_3")]
		public sealed class __c__DisplayClass26_3 : Il2CppSystem.Object
		{
			// Token: 0x0600E9FD RID: 59901 RVA: 0x0037E980 File Offset: 0x0037CB80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_3()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_cookerOrderedResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr, "cookerOrderedResult");
				DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_targetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr, "targetType");
				DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr, "targets");
				DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_field_Public___c__DisplayClass26_2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr, "CS$<>8__locals2");
				DLC1_YuumaBossData.__c__DisplayClass26_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr, 100681550);
				DLC1_YuumaBossData.__c__DisplayClass26_3.NativeMethodInfoPtr__MainChallengeLoop_b__64_Internal_Boolean___f__AnonymousType2_2_CookerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr, 100681551);
				DLC1_YuumaBossData.__c__DisplayClass26_3.NativeMethodInfoPtr__MainChallengeLoop_b__65_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr, 100681552);
				DLC1_YuumaBossData.__c__DisplayClass26_3.NativeMethodInfoPtr__MainChallengeLoop_b__66_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr, 100681553);
			}

			// Token: 0x0600E9FE RID: 59902 RVA: 0x0037EA4C File Offset: 0x0037CC4C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E9FF RID: 59903 RVA: 0x0037EA88 File Offset: 0x0037CC88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221073, XrefRangeEnd = 221077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__64(__f__AnonymousType2<Cooker.CookerType, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeMethodInfoPtr__MainChallengeLoop_b__64_Internal_Boolean___f__AnonymousType2_2_CookerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA00 RID: 59904 RVA: 0x0037EAD8 File Offset: 0x0037CCD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221077, XrefRangeEnd = 221084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__65(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeMethodInfoPtr__MainChallengeLoop_b__65_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA01 RID: 59905 RVA: 0x0037EB24 File Offset: 0x0037CD24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221084, XrefRangeEnd = 221088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__66()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeMethodInfoPtr__MainChallengeLoop_b__66_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA02 RID: 59906 RVA: 0x0007D3CD File Offset: 0x0007B5CD
			public __c__DisplayClass26_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C11 RID: 19473
			// (get) Token: 0x0600EA03 RID: 59907 RVA: 0x0037EB58 File Offset: 0x0037CD58
			// (set) Token: 0x0600EA04 RID: 59908 RVA: 0x0007D3D6 File Offset: 0x0007B5D6
			public unsafe Il2CppReferenceArray<__f__AnonymousType2<Cooker.CookerType, int>> cookerOrderedResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_cookerOrderedResult);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<__f__AnonymousType2<Cooker.CookerType, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_cookerOrderedResult), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C12 RID: 19474
			// (get) Token: 0x0600EA05 RID: 59909 RVA: 0x0037EB88 File Offset: 0x0037CD88
			// (set) Token: 0x0600EA06 RID: 59910 RVA: 0x0007D3F5 File Offset: 0x0007B5F5
			public unsafe Cooker.CookerType targetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_targetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_targetType)) = value;
				}
			}

			// Token: 0x17004C13 RID: 19475
			// (get) Token: 0x0600EA07 RID: 59911 RVA: 0x0037EBB0 File Offset: 0x0037CDB0
			// (set) Token: 0x0600EA08 RID: 59912 RVA: 0x0007D410 File Offset: 0x0007B610
			public unsafe Il2CppStructArray<int> targets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_targets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C14 RID: 19476
			// (get) Token: 0x0600EA09 RID: 59913 RVA: 0x0037EBE0 File Offset: 0x0037CDE0
			// (set) Token: 0x0600EA0A RID: 59914 RVA: 0x0007D42F File Offset: 0x0007B62F
			public unsafe DLC1_YuumaBossData.__c__DisplayClass26_2 field_Public___c__DisplayClass26_2_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_field_Public___c__DisplayClass26_2_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_2>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_3.NativeFieldInfoPtr_field_Public___c__DisplayClass26_2_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009540 RID: 38208
			private static readonly IntPtr NativeFieldInfoPtr_cookerOrderedResult;

			// Token: 0x04009541 RID: 38209
			private static readonly IntPtr NativeFieldInfoPtr_targetType;

			// Token: 0x04009542 RID: 38210
			private static readonly IntPtr NativeFieldInfoPtr_targets;

			// Token: 0x04009543 RID: 38211
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass26_2_0;

			// Token: 0x04009544 RID: 38212
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009545 RID: 38213
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__64_Internal_Boolean___f__AnonymousType2_2_CookerType_Int32_0;

			// Token: 0x04009546 RID: 38214
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__65_Internal_Boolean_Int32_0;

			// Token: 0x04009547 RID: 38215
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__66_Internal_Void_0;
		}

		// Token: 0x02000CC0 RID: 3264
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_4")]
		public sealed class __c__DisplayClass26_4 : Il2CppSystem.Object
		{
			// Token: 0x0600EA0B RID: 59915 RVA: 0x0037EC10 File Offset: 0x0037CE10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_4()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_4>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_4.NativeFieldInfoPtr_controller1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_4>.NativeClassPtr, "controller1");
				DLC1_YuumaBossData.__c__DisplayClass26_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_4>.NativeClassPtr, 100681554);
				DLC1_YuumaBossData.__c__DisplayClass26_4.NativeMethodInfoPtr__MainChallengeLoop_b__68_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_4>.NativeClassPtr, 100681555);
			}

			// Token: 0x0600EA0C RID: 59916 RVA: 0x0037EC78 File Offset: 0x0037CE78
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA0D RID: 59917 RVA: 0x0037ECB4 File Offset: 0x0037CEB4
			[CallerCount(0)]
			public unsafe Vector3 _MainChallengeLoop_b__68()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_4.NativeMethodInfoPtr__MainChallengeLoop_b__68_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA0E RID: 59918 RVA: 0x0007D44E File Offset: 0x0007B64E
			public __c__DisplayClass26_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C15 RID: 19477
			// (get) Token: 0x0600EA0F RID: 59919 RVA: 0x0037ECF0 File Offset: 0x0037CEF0
			// (set) Token: 0x0600EA10 RID: 59920 RVA: 0x0007D457 File Offset: 0x0007B657
			public unsafe Vector2 controller1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_4.NativeFieldInfoPtr_controller1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_4.NativeFieldInfoPtr_controller1)) = value;
				}
			}

			// Token: 0x04009548 RID: 38216
			private static readonly IntPtr NativeFieldInfoPtr_controller1;

			// Token: 0x04009549 RID: 38217
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400954A RID: 38218
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__68_Internal_Vector3_0;
		}

		// Token: 0x02000CC1 RID: 3265
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_5")]
		public sealed class __c__DisplayClass26_5 : Il2CppSystem.Object
		{
			// Token: 0x0600EA11 RID: 59921 RVA: 0x0037ED18 File Offset: 0x0037CF18
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_5()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_5>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_5.NativeFieldInfoPtr_yuumaPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_5>.NativeClassPtr, "yuumaPosition");
				DLC1_YuumaBossData.__c__DisplayClass26_5.NativeFieldInfoPtr___9__71 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_5>.NativeClassPtr, "<>9__71");
				DLC1_YuumaBossData.__c__DisplayClass26_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_5>.NativeClassPtr, 100681556);
				DLC1_YuumaBossData.__c__DisplayClass26_5.NativeMethodInfoPtr__MainChallengeLoop_b__71_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_5>.NativeClassPtr, 100681557);
			}

			// Token: 0x0600EA12 RID: 59922 RVA: 0x0037ED94 File Offset: 0x0037CF94
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA13 RID: 59923 RVA: 0x0037EDD0 File Offset: 0x0037CFD0
			[CallerCount(0)]
			public unsafe Vector3 _MainChallengeLoop_b__71()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_5.NativeMethodInfoPtr__MainChallengeLoop_b__71_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA14 RID: 59924 RVA: 0x0007D472 File Offset: 0x0007B672
			public __c__DisplayClass26_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C16 RID: 19478
			// (get) Token: 0x0600EA15 RID: 59925 RVA: 0x0037EE0C File Offset: 0x0037D00C
			// (set) Token: 0x0600EA16 RID: 59926 RVA: 0x0007D47B File Offset: 0x0007B67B
			public unsafe Vector3 yuumaPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_5.NativeFieldInfoPtr_yuumaPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_5.NativeFieldInfoPtr_yuumaPosition)) = value;
				}
			}

			// Token: 0x17004C17 RID: 19479
			// (get) Token: 0x0600EA17 RID: 59927 RVA: 0x0037EE34 File Offset: 0x0037D034
			// (set) Token: 0x0600EA18 RID: 59928 RVA: 0x0007D496 File Offset: 0x0007B696
			public unsafe Func<Vector3> __9__71
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_5.NativeFieldInfoPtr___9__71);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_5.NativeFieldInfoPtr___9__71), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400954B RID: 38219
			private static readonly IntPtr NativeFieldInfoPtr_yuumaPosition;

			// Token: 0x0400954C RID: 38220
			private static readonly IntPtr NativeFieldInfoPtr___9__71;

			// Token: 0x0400954D RID: 38221
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400954E RID: 38222
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__71_Internal_Vector3_0;
		}

		// Token: 0x02000CC2 RID: 3266
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_6")]
		public sealed class __c__DisplayClass26_6 : Il2CppSystem.Object
		{
			// Token: 0x0600EA19 RID: 59929 RVA: 0x0037EE64 File Offset: 0x0037D064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_6()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_6>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_6.NativeFieldInfoPtr_controller1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_6>.NativeClassPtr, "controller1");
				DLC1_YuumaBossData.__c__DisplayClass26_6.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_6>.NativeClassPtr, 100681558);
				DLC1_YuumaBossData.__c__DisplayClass26_6.NativeMethodInfoPtr__MainChallengeLoop_b__70_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_6>.NativeClassPtr, 100681559);
			}

			// Token: 0x0600EA1A RID: 59930 RVA: 0x0037EECC File Offset: 0x0037D0CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_6() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_6>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_6.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA1B RID: 59931 RVA: 0x0037EF08 File Offset: 0x0037D108
			[CallerCount(0)]
			public unsafe Vector3 _MainChallengeLoop_b__70()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_6.NativeMethodInfoPtr__MainChallengeLoop_b__70_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA1C RID: 59932 RVA: 0x0007D4B5 File Offset: 0x0007B6B5
			public __c__DisplayClass26_6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C18 RID: 19480
			// (get) Token: 0x0600EA1D RID: 59933 RVA: 0x0037EF44 File Offset: 0x0037D144
			// (set) Token: 0x0600EA1E RID: 59934 RVA: 0x0007D4BE File Offset: 0x0007B6BE
			public unsafe Vector2 controller1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_6.NativeFieldInfoPtr_controller1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_6.NativeFieldInfoPtr_controller1)) = value;
				}
			}

			// Token: 0x0400954F RID: 38223
			private static readonly IntPtr NativeFieldInfoPtr_controller1;

			// Token: 0x04009550 RID: 38224
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009551 RID: 38225
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__70_Internal_Vector3_0;
		}

		// Token: 0x02000CC3 RID: 3267
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_7")]
		public sealed class __c__DisplayClass26_7 : Il2CppSystem.Object
		{
			// Token: 0x0600EA1F RID: 59935 RVA: 0x0037EF6C File Offset: 0x0037D16C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_7()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_7>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_7.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_7>.NativeClassPtr, "x");
				DLC1_YuumaBossData.__c__DisplayClass26_7.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_7>.NativeClassPtr, 100681560);
				DLC1_YuumaBossData.__c__DisplayClass26_7.NativeMethodInfoPtr__MainChallengeLoop_b__73_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_7>.NativeClassPtr, 100681561);
			}

			// Token: 0x0600EA20 RID: 59936 RVA: 0x0037EFD4 File Offset: 0x0037D1D4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_7() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_7>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_7.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA21 RID: 59937 RVA: 0x0037F010 File Offset: 0x0037D210
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221088, XrefRangeEnd = 221092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__73()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_7.NativeMethodInfoPtr__MainChallengeLoop_b__73_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA22 RID: 59938 RVA: 0x0007D4D9 File Offset: 0x0007B6D9
			public __c__DisplayClass26_7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C19 RID: 19481
			// (get) Token: 0x0600EA23 RID: 59939 RVA: 0x0037F044 File Offset: 0x0037D244
			// (set) Token: 0x0600EA24 RID: 59940 RVA: 0x0007D4E2 File Offset: 0x0007B6E2
			public unsafe GameObject x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_7.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_7.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009552 RID: 38226
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04009553 RID: 38227
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009554 RID: 38228
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__73_Internal_Void_0;
		}

		// Token: 0x02000CC4 RID: 3268
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_8")]
		public sealed class __c__DisplayClass26_8 : Il2CppSystem.Object
		{
			// Token: 0x0600EA25 RID: 59941 RVA: 0x0037F074 File Offset: 0x0037D274
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_8()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_8>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_8.NativeFieldInfoPtr_food = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_8>.NativeClassPtr, "food");
				DLC1_YuumaBossData.__c__DisplayClass26_8.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_8>.NativeClassPtr, "CS$<>8__locals3");
				DLC1_YuumaBossData.__c__DisplayClass26_8.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_8>.NativeClassPtr, 100681562);
				DLC1_YuumaBossData.__c__DisplayClass26_8.NativeMethodInfoPtr__MainChallengeLoop_b__83_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_8>.NativeClassPtr, 100681563);
			}

			// Token: 0x0600EA26 RID: 59942 RVA: 0x0037F0F0 File Offset: 0x0037D2F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_8() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_8>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_8.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA27 RID: 59943 RVA: 0x0037F12C File Offset: 0x0037D32C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221092, XrefRangeEnd = 221099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__83(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_8.NativeMethodInfoPtr__MainChallengeLoop_b__83_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA28 RID: 59944 RVA: 0x0007D501 File Offset: 0x0007B701
			public __c__DisplayClass26_8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C1A RID: 19482
			// (get) Token: 0x0600EA29 RID: 59945 RVA: 0x0037F178 File Offset: 0x0037D378
			// (set) Token: 0x0600EA2A RID: 59946 RVA: 0x0007D50A File Offset: 0x0007B70A
			public unsafe Sellable food
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_8.NativeFieldInfoPtr_food);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_8.NativeFieldInfoPtr_food), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C1B RID: 19483
			// (get) Token: 0x0600EA2B RID: 59947 RVA: 0x0037F1A8 File Offset: 0x0037D3A8
			// (set) Token: 0x0600EA2C RID: 59948 RVA: 0x0007D529 File Offset: 0x0007B729
			public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 field_Public___c__DisplayClass26_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_8.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_8.NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009555 RID: 38229
			private static readonly IntPtr NativeFieldInfoPtr_food;

			// Token: 0x04009556 RID: 38230
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass26_0_0;

			// Token: 0x04009557 RID: 38231
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009558 RID: 38232
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__83_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000CC5 RID: 3269
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c__DisplayClass26_9")]
		public sealed class __c__DisplayClass26_9 : Il2CppSystem.Object
		{
			// Token: 0x0600EA2D RID: 59949 RVA: 0x0037F1D8 File Offset: 0x0037D3D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass26_9()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c__DisplayClass26_9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_9>.NativeClassPtr);
				DLC1_YuumaBossData.__c__DisplayClass26_9.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_9>.NativeClassPtr, "order");
				DLC1_YuumaBossData.__c__DisplayClass26_9.NativeFieldInfoPtr_lastResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_9>.NativeClassPtr, "lastResult");
				DLC1_YuumaBossData.__c__DisplayClass26_9.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_9>.NativeClassPtr, 100681564);
				DLC1_YuumaBossData.__c__DisplayClass26_9.NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_9>.NativeClassPtr, 100681565);
				DLC1_YuumaBossData.__c__DisplayClass26_9.NativeMethodInfoPtr__MainChallengeLoop_b__85_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_9>.NativeClassPtr, 100681566);
			}

			// Token: 0x0600EA2E RID: 59950 RVA: 0x0037F268 File Offset: 0x0037D468
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass26_9() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c__DisplayClass26_9>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_9.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA2F RID: 59951 RVA: 0x0037F2A4 File Offset: 0x0037D4A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221099, XrefRangeEnd = 221105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_9.NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA30 RID: 59952 RVA: 0x0037F2E0 File Offset: 0x0037D4E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221105, XrefRangeEnd = 221108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__85(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c__DisplayClass26_9.NativeMethodInfoPtr__MainChallengeLoop_b__85_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA31 RID: 59953 RVA: 0x0007D548 File Offset: 0x0007B748
			public __c__DisplayClass26_9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C1C RID: 19484
			// (get) Token: 0x0600EA32 RID: 59954 RVA: 0x0037F32C File Offset: 0x0037D52C
			// (set) Token: 0x0600EA33 RID: 59955 RVA: 0x0007D551 File Offset: 0x0007B751
			public unsafe GuestsManager.OrderBase order
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_9.NativeFieldInfoPtr_order);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_9.NativeFieldInfoPtr_order), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C1D RID: 19485
			// (get) Token: 0x0600EA34 RID: 59956 RVA: 0x0037F35C File Offset: 0x0037D55C
			// (set) Token: 0x0600EA35 RID: 59957 RVA: 0x0007D570 File Offset: 0x0007B770
			public unsafe GuestGroupController.EvaluationResult lastResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_9.NativeFieldInfoPtr_lastResult);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData.__c__DisplayClass26_9.NativeFieldInfoPtr_lastResult)) = value;
				}
			}

			// Token: 0x04009559 RID: 38233
			private static readonly IntPtr NativeFieldInfoPtr_order;

			// Token: 0x0400955A RID: 38234
			private static readonly IntPtr NativeFieldInfoPtr_lastResult;

			// Token: 0x0400955B RID: 38235
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400955C RID: 38236
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0;

			// Token: 0x0400955D RID: 38237
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__85_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000CC6 RID: 3270
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EA36 RID: 59958 RVA: 0x0037F384 File Offset: 0x0037D584
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr);
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_0");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_1");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_6");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_7");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_8");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_11");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_15");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_54 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_54");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_67 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_67");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_60");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_61 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_61");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_62 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_62");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_63 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_63");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_72 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_72");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_74 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_74");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_76 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_76");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_78 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_78");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_79 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_79");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_31 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_31");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_32");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_33");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_34");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_86 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_86");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_87 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_87");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_47 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_47");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_49 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_49");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_50 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_50");
				DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_51 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, "<>9__26_51");
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681568);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681569);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681570);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_6_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681571);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_7_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681572);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_8_Internal_IEnumerable_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681573);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_11_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681574);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_15_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681575);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_54_Internal_Boolean_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681576);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_67_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681577);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_60_Internal_CookController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681578);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_61_Internal_CookerType_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681579);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_62_Internal_Int32_IGrouping_2_CookerType_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681580);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_63_Internal___f__AnonymousType2_2_CookerType_Int32_IGrouping_2_CookerType_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681581);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_72_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681582);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_74_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681583);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_76_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681584);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_78_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681585);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_79_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681586);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_31_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681587);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_32_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681588);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_33_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681589);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_34_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681590);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_86_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681591);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_87_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681592);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_47_Internal_Boolean_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681593);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_49_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681594);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_50_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681595);
				DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_51_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr, 100681596);
			}

			// Token: 0x0600EA37 RID: 59959 RVA: 0x0037F838 File Offset: 0x0037DA38
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA38 RID: 59960 RVA: 0x0037F874 File Offset: 0x0037DA74
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__26_0(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA39 RID: 59961 RVA: 0x0037F8C0 File Offset: 0x0037DAC0
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__26_1(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA3A RID: 59962 RVA: 0x0037F90C File Offset: 0x0037DB0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221108, XrefRangeEnd = 221113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__26_6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_6_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA3B RID: 59963 RVA: 0x0037F958 File Offset: 0x0037DB58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221113, XrefRangeEnd = 221118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__26_7(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_7_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA3C RID: 59964 RVA: 0x0037F9A4 File Offset: 0x0037DBA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _MainChallengeLoop_b__26_8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_8_Internal_IEnumerable_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600EA3D RID: 59965 RVA: 0x0037F9F0 File Offset: 0x0037DBF0
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__26_11(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_11_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA3E RID: 59966 RVA: 0x0037FA3C File Offset: 0x0037DC3C
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__26_15(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_15_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA3F RID: 59967 RVA: 0x0037FA8C File Offset: 0x0037DC8C
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__26_54(Coroutine x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_54_Internal_Boolean_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA40 RID: 59968 RVA: 0x0037FADC File Offset: 0x0037DCDC
			[CallerCount(0)]
			public unsafe IEnumerable<int> _MainChallengeLoop_b__26_67(IEnumerable<int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_67_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600EA41 RID: 59969 RVA: 0x0037FB2C File Offset: 0x0037DD2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221118, XrefRangeEnd = 221125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CookController _MainChallengeLoop_b__26_60(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_60_Internal_CookController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr3) : null;
			}

			// Token: 0x0600EA42 RID: 59970 RVA: 0x0037FB78 File Offset: 0x0037DD78
			[CallerCount(0)]
			public unsafe Cooker.CookerType _MainChallengeLoop_b__26_61(CookController item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_61_Internal_CookerType_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA43 RID: 59971 RVA: 0x0037FBC8 File Offset: 0x0037DDC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221125, XrefRangeEnd = 221128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__26_62(IGrouping<Cooker.CookerType, CookController> cookerTypeNum)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookerTypeNum);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_62_Internal_Int32_IGrouping_2_CookerType_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA44 RID: 59972 RVA: 0x0037FC18 File Offset: 0x0037DE18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221128, XrefRangeEnd = 221140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType2<Cooker.CookerType, int> _MainChallengeLoop_b__26_63(IGrouping<Cooker.CookerType, CookController> cookerTypeNum)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookerTypeNum);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_63_Internal___f__AnonymousType2_2_CookerType_Int32_IGrouping_2_CookerType_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType2<Cooker.CookerType, int>>(intPtr3) : null;
			}

			// Token: 0x0600EA45 RID: 59973 RVA: 0x0037FC68 File Offset: 0x0037DE68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221140, XrefRangeEnd = 221159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__26_72(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_72_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA46 RID: 59974 RVA: 0x0037FCAC File Offset: 0x0037DEAC
			[CallerCount(0)]
			public unsafe string _MainChallengeLoop_b__26_74(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_74_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EA47 RID: 59975 RVA: 0x0037FCF4 File Offset: 0x0037DEF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221159, XrefRangeEnd = 221172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__26_76(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_76_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA48 RID: 59976 RVA: 0x0037FD38 File Offset: 0x0037DF38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221172, XrefRangeEnd = 221180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__26_78(int requestFood, string _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref requestFood;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_78_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EA49 RID: 59977 RVA: 0x0037FD90 File Offset: 0x0037DF90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221180, XrefRangeEnd = 221188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__26_79(int requestBev, string _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref requestBev;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_79_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EA4A RID: 59978 RVA: 0x0037FDE8 File Offset: 0x0037DFE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221188, XrefRangeEnd = 221192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__26_31(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_31_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA4B RID: 59979 RVA: 0x0037FE38 File Offset: 0x0037E038
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__26_32(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_32_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA4C RID: 59980 RVA: 0x0037FE88 File Offset: 0x0037E088
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221192, XrefRangeEnd = 221195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__26_33(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_33_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA4D RID: 59981 RVA: 0x0037FED8 File Offset: 0x0037E0D8
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__26_34(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_34_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA4E RID: 59982 RVA: 0x0037FF28 File Offset: 0x0037E128
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221195, XrefRangeEnd = 221203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__26_86(int requestFood, string _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref requestFood;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_86_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EA4F RID: 59983 RVA: 0x0037FF80 File Offset: 0x0037E180
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221203, XrefRangeEnd = 221211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__26_87(int requestBev, string _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref requestBev;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_87_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EA50 RID: 59984 RVA: 0x0037FFD8 File Offset: 0x0037E1D8
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__26_47(Coroutine x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_47_Internal_Boolean_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EA51 RID: 59985 RVA: 0x00380028 File Offset: 0x0037E228
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__26_49(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_49_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EA52 RID: 59986 RVA: 0x0038006C File Offset: 0x0037E26C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__26_50(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_50_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EA53 RID: 59987 RVA: 0x003800B0 File Offset: 0x0037E2B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221211, XrefRangeEnd = 221220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__26_51()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__26_51_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA54 RID: 59988 RVA: 0x0007D58B File Offset: 0x0007B78B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C1E RID: 19486
			// (get) Token: 0x0600EA55 RID: 59989 RVA: 0x003800E4 File Offset: 0x0037E2E4
			// (set) Token: 0x0600EA56 RID: 59990 RVA: 0x0007D594 File Offset: 0x0007B794
			public unsafe static DLC1_YuumaBossData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C1F RID: 19487
			// (get) Token: 0x0600EA57 RID: 59991 RVA: 0x0038010C File Offset: 0x0037E30C
			// (set) Token: 0x0600EA58 RID: 59992 RVA: 0x0007D5A6 File Offset: 0x0007B7A6
			public unsafe static Func<Vector2Int, int> __9__26_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C20 RID: 19488
			// (get) Token: 0x0600EA59 RID: 59993 RVA: 0x00380134 File Offset: 0x0037E334
			// (set) Token: 0x0600EA5A RID: 59994 RVA: 0x0007D5B8 File Offset: 0x0007B7B8
			public unsafe static Func<Vector2Int, int> __9__26_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C21 RID: 19489
			// (get) Token: 0x0600EA5B RID: 59995 RVA: 0x0038015C File Offset: 0x0037E35C
			// (set) Token: 0x0600EA5C RID: 59996 RVA: 0x0007D5CA File Offset: 0x0007B7CA
			public unsafe static Func<int, bool> __9__26_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C22 RID: 19490
			// (get) Token: 0x0600EA5D RID: 59997 RVA: 0x00380184 File Offset: 0x0037E384
			// (set) Token: 0x0600EA5E RID: 59998 RVA: 0x0007D5DC File Offset: 0x0007B7DC
			public unsafe static Func<int, bool> __9__26_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C23 RID: 19491
			// (get) Token: 0x0600EA5F RID: 59999 RVA: 0x003801AC File Offset: 0x0037E3AC
			// (set) Token: 0x0600EA60 RID: 60000 RVA: 0x0007D5EE File Offset: 0x0007B7EE
			public unsafe static Func<int, IEnumerable<int>> __9__26_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C24 RID: 19492
			// (get) Token: 0x0600EA61 RID: 60001 RVA: 0x003801D4 File Offset: 0x0037E3D4
			// (set) Token: 0x0600EA62 RID: 60002 RVA: 0x0007D600 File Offset: 0x0007B800
			public unsafe static Func<int, bool> __9__26_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C25 RID: 19493
			// (get) Token: 0x0600EA63 RID: 60003 RVA: 0x003801FC File Offset: 0x0037E3FC
			// (set) Token: 0x0600EA64 RID: 60004 RVA: 0x0007D612 File Offset: 0x0007B812
			public unsafe static Func<CookController, bool> __9__26_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C26 RID: 19494
			// (get) Token: 0x0600EA65 RID: 60005 RVA: 0x00380224 File Offset: 0x0037E424
			// (set) Token: 0x0600EA66 RID: 60006 RVA: 0x0007D624 File Offset: 0x0007B824
			public unsafe static Func<Coroutine, bool> __9__26_54
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_54, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Coroutine, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_54, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C27 RID: 19495
			// (get) Token: 0x0600EA67 RID: 60007 RVA: 0x0038024C File Offset: 0x0037E44C
			// (set) Token: 0x0600EA68 RID: 60008 RVA: 0x0007D636 File Offset: 0x0007B836
			public unsafe static Func<IEnumerable<int>, IEnumerable<int>> __9__26_67
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_67, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_67, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C28 RID: 19496
			// (get) Token: 0x0600EA69 RID: 60009 RVA: 0x00380274 File Offset: 0x0037E474
			// (set) Token: 0x0600EA6A RID: 60010 RVA: 0x0007D648 File Offset: 0x0007B848
			public unsafe static Func<int, CookController> __9__26_60
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_60, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, CookController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_60, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C29 RID: 19497
			// (get) Token: 0x0600EA6B RID: 60011 RVA: 0x0038029C File Offset: 0x0037E49C
			// (set) Token: 0x0600EA6C RID: 60012 RVA: 0x0007D65A File Offset: 0x0007B85A
			public unsafe static Func<CookController, Cooker.CookerType> __9__26_61
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_61, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, Cooker.CookerType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_61, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C2A RID: 19498
			// (get) Token: 0x0600EA6D RID: 60013 RVA: 0x003802C4 File Offset: 0x0037E4C4
			// (set) Token: 0x0600EA6E RID: 60014 RVA: 0x0007D66C File Offset: 0x0007B86C
			public unsafe static Func<IGrouping<Cooker.CookerType, CookController>, int> __9__26_62
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_62, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<Cooker.CookerType, CookController>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_62, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C2B RID: 19499
			// (get) Token: 0x0600EA6F RID: 60015 RVA: 0x003802EC File Offset: 0x0037E4EC
			// (set) Token: 0x0600EA70 RID: 60016 RVA: 0x0007D67E File Offset: 0x0007B87E
			public unsafe static Func<IGrouping<Cooker.CookerType, CookController>, __f__AnonymousType2<Cooker.CookerType, int>> __9__26_63
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_63, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<Cooker.CookerType, CookController>, __f__AnonymousType2<Cooker.CookerType, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_63, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C2C RID: 19500
			// (get) Token: 0x0600EA71 RID: 60017 RVA: 0x00380314 File Offset: 0x0037E514
			// (set) Token: 0x0600EA72 RID: 60018 RVA: 0x0007D690 File Offset: 0x0007B890
			public unsafe static Action<GameObject> __9__26_72
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_72, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_72, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C2D RID: 19501
			// (get) Token: 0x0600EA73 RID: 60019 RVA: 0x0038033C File Offset: 0x0037E53C
			// (set) Token: 0x0600EA74 RID: 60020 RVA: 0x0007D6A2 File Offset: 0x0007B8A2
			public unsafe static Func<string, string> __9__26_74
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_74, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_74, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C2E RID: 19502
			// (get) Token: 0x0600EA75 RID: 60021 RVA: 0x00380364 File Offset: 0x0037E564
			// (set) Token: 0x0600EA76 RID: 60022 RVA: 0x0007D6B4 File Offset: 0x0007B8B4
			public unsafe static Action<GuestGroupController> __9__26_76
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_76, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_76, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C2F RID: 19503
			// (get) Token: 0x0600EA77 RID: 60023 RVA: 0x0038038C File Offset: 0x0037E58C
			// (set) Token: 0x0600EA78 RID: 60024 RVA: 0x0007D6C6 File Offset: 0x0007B8C6
			public unsafe static Func<int, string, string> __9__26_78
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_78, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_78, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C30 RID: 19504
			// (get) Token: 0x0600EA79 RID: 60025 RVA: 0x003803B4 File Offset: 0x0037E5B4
			// (set) Token: 0x0600EA7A RID: 60026 RVA: 0x0007D6D8 File Offset: 0x0007B8D8
			public unsafe static Func<int, string, string> __9__26_79
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_79, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_79, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C31 RID: 19505
			// (get) Token: 0x0600EA7B RID: 60027 RVA: 0x003803DC File Offset: 0x0037E5DC
			// (set) Token: 0x0600EA7C RID: 60028 RVA: 0x0007D6EA File Offset: 0x0007B8EA
			public unsafe static Func<Recipe, bool> __9__26_31
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_31, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_31, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C32 RID: 19506
			// (get) Token: 0x0600EA7D RID: 60029 RVA: 0x00380404 File Offset: 0x0037E604
			// (set) Token: 0x0600EA7E RID: 60030 RVA: 0x0007D6FC File Offset: 0x0007B8FC
			public unsafe static Func<Recipe, int> __9__26_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C33 RID: 19507
			// (get) Token: 0x0600EA7F RID: 60031 RVA: 0x0038042C File Offset: 0x0037E62C
			// (set) Token: 0x0600EA80 RID: 60032 RVA: 0x0007D70E File Offset: 0x0007B90E
			public unsafe static Func<Sellable, bool> __9__26_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C34 RID: 19508
			// (get) Token: 0x0600EA81 RID: 60033 RVA: 0x00380454 File Offset: 0x0037E654
			// (set) Token: 0x0600EA82 RID: 60034 RVA: 0x0007D720 File Offset: 0x0007B920
			public unsafe static Func<Sellable, int> __9__26_34
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_34, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_34, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C35 RID: 19509
			// (get) Token: 0x0600EA83 RID: 60035 RVA: 0x0038047C File Offset: 0x0037E67C
			// (set) Token: 0x0600EA84 RID: 60036 RVA: 0x0007D732 File Offset: 0x0007B932
			public unsafe static Func<int, string, string> __9__26_86
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_86, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_86, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C36 RID: 19510
			// (get) Token: 0x0600EA85 RID: 60037 RVA: 0x003804A4 File Offset: 0x0037E6A4
			// (set) Token: 0x0600EA86 RID: 60038 RVA: 0x0007D744 File Offset: 0x0007B944
			public unsafe static Func<int, string, string> __9__26_87
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_87, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_87, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C37 RID: 19511
			// (get) Token: 0x0600EA87 RID: 60039 RVA: 0x003804CC File Offset: 0x0037E6CC
			// (set) Token: 0x0600EA88 RID: 60040 RVA: 0x0007D756 File Offset: 0x0007B956
			public unsafe static Func<Coroutine, bool> __9__26_47
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_47, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Coroutine, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_47, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C38 RID: 19512
			// (get) Token: 0x0600EA89 RID: 60041 RVA: 0x003804F4 File Offset: 0x0037E6F4
			// (set) Token: 0x0600EA8A RID: 60042 RVA: 0x0007D768 File Offset: 0x0007B968
			public unsafe static Func<int, string> __9__26_49
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_49, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_49, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C39 RID: 19513
			// (get) Token: 0x0600EA8B RID: 60043 RVA: 0x0038051C File Offset: 0x0037E71C
			// (set) Token: 0x0600EA8C RID: 60044 RVA: 0x0007D77A File Offset: 0x0007B97A
			public unsafe static Func<int, string> __9__26_50
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_50, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_50, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C3A RID: 19514
			// (get) Token: 0x0600EA8D RID: 60045 RVA: 0x00380544 File Offset: 0x0037E744
			// (set) Token: 0x0600EA8E RID: 60046 RVA: 0x0007D78C File Offset: 0x0007B98C
			public unsafe static Action __9__26_51
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_51, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC1_YuumaBossData.__c.NativeFieldInfoPtr___9__26_51, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400955E RID: 38238
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400955F RID: 38239
			private static readonly IntPtr NativeFieldInfoPtr___9__26_0;

			// Token: 0x04009560 RID: 38240
			private static readonly IntPtr NativeFieldInfoPtr___9__26_1;

			// Token: 0x04009561 RID: 38241
			private static readonly IntPtr NativeFieldInfoPtr___9__26_6;

			// Token: 0x04009562 RID: 38242
			private static readonly IntPtr NativeFieldInfoPtr___9__26_7;

			// Token: 0x04009563 RID: 38243
			private static readonly IntPtr NativeFieldInfoPtr___9__26_8;

			// Token: 0x04009564 RID: 38244
			private static readonly IntPtr NativeFieldInfoPtr___9__26_11;

			// Token: 0x04009565 RID: 38245
			private static readonly IntPtr NativeFieldInfoPtr___9__26_15;

			// Token: 0x04009566 RID: 38246
			private static readonly IntPtr NativeFieldInfoPtr___9__26_54;

			// Token: 0x04009567 RID: 38247
			private static readonly IntPtr NativeFieldInfoPtr___9__26_67;

			// Token: 0x04009568 RID: 38248
			private static readonly IntPtr NativeFieldInfoPtr___9__26_60;

			// Token: 0x04009569 RID: 38249
			private static readonly IntPtr NativeFieldInfoPtr___9__26_61;

			// Token: 0x0400956A RID: 38250
			private static readonly IntPtr NativeFieldInfoPtr___9__26_62;

			// Token: 0x0400956B RID: 38251
			private static readonly IntPtr NativeFieldInfoPtr___9__26_63;

			// Token: 0x0400956C RID: 38252
			private static readonly IntPtr NativeFieldInfoPtr___9__26_72;

			// Token: 0x0400956D RID: 38253
			private static readonly IntPtr NativeFieldInfoPtr___9__26_74;

			// Token: 0x0400956E RID: 38254
			private static readonly IntPtr NativeFieldInfoPtr___9__26_76;

			// Token: 0x0400956F RID: 38255
			private static readonly IntPtr NativeFieldInfoPtr___9__26_78;

			// Token: 0x04009570 RID: 38256
			private static readonly IntPtr NativeFieldInfoPtr___9__26_79;

			// Token: 0x04009571 RID: 38257
			private static readonly IntPtr NativeFieldInfoPtr___9__26_31;

			// Token: 0x04009572 RID: 38258
			private static readonly IntPtr NativeFieldInfoPtr___9__26_32;

			// Token: 0x04009573 RID: 38259
			private static readonly IntPtr NativeFieldInfoPtr___9__26_33;

			// Token: 0x04009574 RID: 38260
			private static readonly IntPtr NativeFieldInfoPtr___9__26_34;

			// Token: 0x04009575 RID: 38261
			private static readonly IntPtr NativeFieldInfoPtr___9__26_86;

			// Token: 0x04009576 RID: 38262
			private static readonly IntPtr NativeFieldInfoPtr___9__26_87;

			// Token: 0x04009577 RID: 38263
			private static readonly IntPtr NativeFieldInfoPtr___9__26_47;

			// Token: 0x04009578 RID: 38264
			private static readonly IntPtr NativeFieldInfoPtr___9__26_49;

			// Token: 0x04009579 RID: 38265
			private static readonly IntPtr NativeFieldInfoPtr___9__26_50;

			// Token: 0x0400957A RID: 38266
			private static readonly IntPtr NativeFieldInfoPtr___9__26_51;

			// Token: 0x0400957B RID: 38267
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400957C RID: 38268
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_0_Internal_Int32_Vector2Int_0;

			// Token: 0x0400957D RID: 38269
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_1_Internal_Int32_Vector2Int_0;

			// Token: 0x0400957E RID: 38270
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_6_Internal_Boolean_Int32_0;

			// Token: 0x0400957F RID: 38271
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_7_Internal_Boolean_Int32_0;

			// Token: 0x04009580 RID: 38272
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_8_Internal_IEnumerable_1_Int32_Int32_0;

			// Token: 0x04009581 RID: 38273
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_11_Internal_Boolean_Int32_0;

			// Token: 0x04009582 RID: 38274
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_15_Internal_Boolean_CookController_0;

			// Token: 0x04009583 RID: 38275
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_54_Internal_Boolean_Coroutine_0;

			// Token: 0x04009584 RID: 38276
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_67_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

			// Token: 0x04009585 RID: 38277
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_60_Internal_CookController_Int32_0;

			// Token: 0x04009586 RID: 38278
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_61_Internal_CookerType_CookController_0;

			// Token: 0x04009587 RID: 38279
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_62_Internal_Int32_IGrouping_2_CookerType_CookController_0;

			// Token: 0x04009588 RID: 38280
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_63_Internal___f__AnonymousType2_2_CookerType_Int32_IGrouping_2_CookerType_CookController_0;

			// Token: 0x04009589 RID: 38281
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_72_Internal_Void_GameObject_0;

			// Token: 0x0400958A RID: 38282
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_74_Internal_String_String_0;

			// Token: 0x0400958B RID: 38283
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_76_Internal_Void_GuestGroupController_0;

			// Token: 0x0400958C RID: 38284
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_78_Internal_String_Int32_String_0;

			// Token: 0x0400958D RID: 38285
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_79_Internal_String_Int32_String_0;

			// Token: 0x0400958E RID: 38286
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_31_Internal_Boolean_Recipe_0;

			// Token: 0x0400958F RID: 38287
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_32_Internal_Int32_Recipe_0;

			// Token: 0x04009590 RID: 38288
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_33_Internal_Boolean_Sellable_0;

			// Token: 0x04009591 RID: 38289
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_34_Internal_Int32_Sellable_0;

			// Token: 0x04009592 RID: 38290
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_86_Internal_String_Int32_String_0;

			// Token: 0x04009593 RID: 38291
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_87_Internal_String_Int32_String_0;

			// Token: 0x04009594 RID: 38292
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_47_Internal_Boolean_Coroutine_0;

			// Token: 0x04009595 RID: 38293
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_49_Internal_String_Int32_0;

			// Token: 0x04009596 RID: 38294
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_50_Internal_String_Int32_0;

			// Token: 0x04009597 RID: 38295
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__26_51_Internal_Void_0;
		}

		// Token: 0x02000CC7 RID: 3271
		[ObfuscatedName("GameData.Profile.DLC1_YuumaBossData+<MainChallengeLoop>d__26")]
		public sealed class _MainChallengeLoop_d__26 : Il2CppSystem.Object
		{
			// Token: 0x0600EA8F RID: 60047 RVA: 0x0038056C File Offset: 0x0037E76C
			// Note: this type is marked as 'beforefieldinit'.
			static _MainChallengeLoop_d__26()
			{
				Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC1_YuumaBossData>.NativeClassPtr, "<MainChallengeLoop>d__26");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr);
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, "<>1__state");
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, "<>2__current");
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, "<>4__this");
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, "bossDataContext");
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, "<>8__1");
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, 100681597);
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, 100681598);
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, 100681599);
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, 100681600);
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, 100681601);
				DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr, 100681602);
			}

			// Token: 0x0600EA90 RID: 60048 RVA: 0x00380674 File Offset: 0x0037E874
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MainChallengeLoop_d__26(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC1_YuumaBossData._MainChallengeLoop_d__26>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA91 RID: 60049 RVA: 0x003806BC File Offset: 0x0037E8BC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EA92 RID: 60050 RVA: 0x003806F0 File Offset: 0x0037E8F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221220, XrefRangeEnd = 221963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004C40 RID: 19520
			// (get) Token: 0x0600EA93 RID: 60051 RVA: 0x0038072C File Offset: 0x0037E92C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EA94 RID: 60052 RVA: 0x0038076C File Offset: 0x0037E96C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221963, XrefRangeEnd = 221969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004C41 RID: 19521
			// (get) Token: 0x0600EA95 RID: 60053 RVA: 0x003807A0 File Offset: 0x0037E9A0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EA96 RID: 60054 RVA: 0x0007D79E File Offset: 0x0007B99E
			public _MainChallengeLoop_d__26(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C3B RID: 19515
			// (get) Token: 0x0600EA97 RID: 60055 RVA: 0x003807E0 File Offset: 0x0037E9E0
			// (set) Token: 0x0600EA98 RID: 60056 RVA: 0x0007D7A7 File Offset: 0x0007B9A7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004C3C RID: 19516
			// (get) Token: 0x0600EA99 RID: 60057 RVA: 0x00380808 File Offset: 0x0037EA08
			// (set) Token: 0x0600EA9A RID: 60058 RVA: 0x0007D7C2 File Offset: 0x0007B9C2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C3D RID: 19517
			// (get) Token: 0x0600EA9B RID: 60059 RVA: 0x00380838 File Offset: 0x0037EA38
			// (set) Token: 0x0600EA9C RID: 60060 RVA: 0x0007D7E1 File Offset: 0x0007B9E1
			public unsafe DLC1_YuumaBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C3E RID: 19518
			// (get) Token: 0x0600EA9D RID: 60061 RVA: 0x00380868 File Offset: 0x0037EA68
			// (set) Token: 0x0600EA9E RID: 60062 RVA: 0x0007D800 File Offset: 0x0007BA00
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004C3F RID: 19519
			// (get) Token: 0x0600EA9F RID: 60063 RVA: 0x00380898 File Offset: 0x0037EA98
			// (set) Token: 0x0600EAA0 RID: 60064 RVA: 0x0007D82E File Offset: 0x0007BA2E
			public unsafe DLC1_YuumaBossData.__c__DisplayClass26_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC1_YuumaBossData.__c__DisplayClass26_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC1_YuumaBossData._MainChallengeLoop_d__26.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009598 RID: 38296
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009599 RID: 38297
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400959A RID: 38298
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400959B RID: 38299
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x0400959C RID: 38300
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400959D RID: 38301
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400959E RID: 38302
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400959F RID: 38303
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095A0 RID: 38304
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095A1 RID: 38305
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095A2 RID: 38306
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
