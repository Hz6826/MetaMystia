using System;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
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
	// Token: 0x020002FD RID: 765
	public class YuyukoBossData : BossData
	{
		// Token: 0x06005C50 RID: 23632 RVA: 0x001D1B4C File Offset: 0x001CFD4C
		// Note: this type is marked as 'beforefieldinit'.
		static YuyukoBossData()
		{
			Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "YuyukoBossData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr);
			YuyukoBossData.NativeFieldInfoPtr_YUYUKO_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "YUYUKO_ID");
			YuyukoBossData.NativeFieldInfoPtr_CHALLENGE_YUYUKO_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "CHALLENGE_YUYUKO_ID");
			YuyukoBossData.NativeFieldInfoPtr_singleRoundDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "singleRoundDuration");
			YuyukoBossData.NativeFieldInfoPtr_phase1TargetPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase1TargetPoints");
			YuyukoBossData.NativeFieldInfoPtr_phase1GuestSpawnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase1GuestSpawnInterval");
			YuyukoBossData.NativeFieldInfoPtr_phase2TargetPositiveSpells = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase2TargetPositiveSpells");
			YuyukoBossData.NativeFieldInfoPtr_phase2GuestSpawnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase2GuestSpawnInterval");
			YuyukoBossData.NativeFieldInfoPtr_phase2NegativeSpellInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase2NegativeSpellInterval");
			YuyukoBossData.NativeFieldInfoPtr_phase3YuyukoTotalLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase3YuyukoTotalLife");
			YuyukoBossData.NativeFieldInfoPtr_phase3FoodLevelToYuyukoHpData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase3FoodLevelToYuyukoHpData");
			YuyukoBossData.NativeFieldInfoPtr_allLevel3IzakayaIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "allLevel3IzakayaIds");
			YuyukoBossData.NativeFieldInfoPtr_phase3ChallengeModePatienceDecreaseMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase3ChallengeModePatienceDecreaseMultiplier");
			YuyukoBossData.NativeFieldInfoPtr_phase3DamageWhenStandBeCompletelyDefeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase3DamageWhenStandBeCompletelyDefeated");
			YuyukoBossData.NativeFieldInfoPtr_phase3DamageWhenStandBeNormalDefeated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase3DamageWhenStandBeNormalDefeated");
			YuyukoBossData.NativeFieldInfoPtr_phase3YuyukoStandSpawnInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "phase3YuyukoStandSpawnInterval");
			YuyukoBossData.NativeFieldInfoPtr_yuyukoEatEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "yuyukoEatEffect");
			YuyukoBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, 100682259);
			YuyukoBossData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, 100682260);
			YuyukoBossData.NativeMethodInfoPtr_Method_Internal_Static_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, 100682261);
		}

		// Token: 0x06005C51 RID: 23633 RVA: 0x001D1CF8 File Offset: 0x001CFEF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232289, XrefRangeEnd = 232295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), YuyukoBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005C52 RID: 23634 RVA: 0x001D1D58 File Offset: 0x001CFF58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 230343, RefRangeEnd = 230345, XrefRangeStart = 230343, XrefRangeEnd = 230345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YuyukoBossData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005C53 RID: 23635 RVA: 0x001D1D94 File Offset: 0x001CFF94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232295, XrefRangeEnd = 232296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_PDM_0()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.NativeMethodInfoPtr_Method_Internal_Static_Boolean_PDM_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005C54 RID: 23636 RVA: 0x00032675 File Offset: 0x00030875
		public YuyukoBossData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FFA RID: 8186
		// (get) Token: 0x06005C55 RID: 23637 RVA: 0x001D1DC4 File Offset: 0x001CFFC4
		// (set) Token: 0x06005C56 RID: 23638 RVA: 0x0003267E File Offset: 0x0003087E
		public unsafe static int YUYUKO_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.NativeFieldInfoPtr_YUYUKO_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.NativeFieldInfoPtr_YUYUKO_ID, (void*)(&value));
			}
		}

		// Token: 0x17001FFB RID: 8187
		// (get) Token: 0x06005C57 RID: 23639 RVA: 0x001D1DE0 File Offset: 0x001CFFE0
		// (set) Token: 0x06005C58 RID: 23640 RVA: 0x0003268C File Offset: 0x0003088C
		public unsafe static int CHALLENGE_YUYUKO_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.NativeFieldInfoPtr_CHALLENGE_YUYUKO_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.NativeFieldInfoPtr_CHALLENGE_YUYUKO_ID, (void*)(&value));
			}
		}

		// Token: 0x17001FFC RID: 8188
		// (get) Token: 0x06005C59 RID: 23641 RVA: 0x001D1DFC File Offset: 0x001CFFFC
		// (set) Token: 0x06005C5A RID: 23642 RVA: 0x0003269A File Offset: 0x0003089A
		public unsafe int singleRoundDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_singleRoundDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_singleRoundDuration)) = value;
			}
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06005C5B RID: 23643 RVA: 0x001D1E24 File Offset: 0x001D0024
		// (set) Token: 0x06005C5C RID: 23644 RVA: 0x000326B5 File Offset: 0x000308B5
		public unsafe int phase1TargetPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase1TargetPoints);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase1TargetPoints)) = value;
			}
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06005C5D RID: 23645 RVA: 0x001D1E4C File Offset: 0x001D004C
		// (set) Token: 0x06005C5E RID: 23646 RVA: 0x000326D0 File Offset: 0x000308D0
		public unsafe int phase1GuestSpawnInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase1GuestSpawnInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase1GuestSpawnInterval)) = value;
			}
		}

		// Token: 0x17001FFF RID: 8191
		// (get) Token: 0x06005C5F RID: 23647 RVA: 0x001D1E74 File Offset: 0x001D0074
		// (set) Token: 0x06005C60 RID: 23648 RVA: 0x000326EB File Offset: 0x000308EB
		public unsafe int phase2TargetPositiveSpells
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase2TargetPositiveSpells);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase2TargetPositiveSpells)) = value;
			}
		}

		// Token: 0x17002000 RID: 8192
		// (get) Token: 0x06005C61 RID: 23649 RVA: 0x001D1E9C File Offset: 0x001D009C
		// (set) Token: 0x06005C62 RID: 23650 RVA: 0x00032706 File Offset: 0x00030906
		public unsafe int phase2GuestSpawnInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase2GuestSpawnInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase2GuestSpawnInterval)) = value;
			}
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x06005C63 RID: 23651 RVA: 0x001D1EC4 File Offset: 0x001D00C4
		// (set) Token: 0x06005C64 RID: 23652 RVA: 0x00032721 File Offset: 0x00030921
		public unsafe int phase2NegativeSpellInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase2NegativeSpellInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase2NegativeSpellInterval)) = value;
			}
		}

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x06005C65 RID: 23653 RVA: 0x001D1EEC File Offset: 0x001D00EC
		// (set) Token: 0x06005C66 RID: 23654 RVA: 0x0003273C File Offset: 0x0003093C
		public unsafe int phase3YuyukoTotalLife
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3YuyukoTotalLife);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3YuyukoTotalLife)) = value;
			}
		}

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x06005C67 RID: 23655 RVA: 0x001D1F14 File Offset: 0x001D0114
		// (set) Token: 0x06005C68 RID: 23656 RVA: 0x00032757 File Offset: 0x00030957
		public unsafe Il2CppStructArray<Vector2Int> phase3FoodLevelToYuyukoHpData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3FoodLevelToYuyukoHpData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3FoodLevelToYuyukoHpData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x06005C69 RID: 23657 RVA: 0x001D1F44 File Offset: 0x001D0144
		// (set) Token: 0x06005C6A RID: 23658 RVA: 0x00032776 File Offset: 0x00030976
		public unsafe Il2CppStructArray<int> allLevel3IzakayaIds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_allLevel3IzakayaIds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_allLevel3IzakayaIds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x06005C6B RID: 23659 RVA: 0x001D1F74 File Offset: 0x001D0174
		// (set) Token: 0x06005C6C RID: 23660 RVA: 0x00032795 File Offset: 0x00030995
		public unsafe float phase3ChallengeModePatienceDecreaseMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3ChallengeModePatienceDecreaseMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3ChallengeModePatienceDecreaseMultiplier)) = value;
			}
		}

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x06005C6D RID: 23661 RVA: 0x001D1F9C File Offset: 0x001D019C
		// (set) Token: 0x06005C6E RID: 23662 RVA: 0x000327B0 File Offset: 0x000309B0
		public unsafe int phase3DamageWhenStandBeCompletelyDefeated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3DamageWhenStandBeCompletelyDefeated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3DamageWhenStandBeCompletelyDefeated)) = value;
			}
		}

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x06005C6F RID: 23663 RVA: 0x001D1FC4 File Offset: 0x001D01C4
		// (set) Token: 0x06005C70 RID: 23664 RVA: 0x000327CB File Offset: 0x000309CB
		public unsafe int phase3DamageWhenStandBeNormalDefeated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3DamageWhenStandBeNormalDefeated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3DamageWhenStandBeNormalDefeated)) = value;
			}
		}

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x06005C71 RID: 23665 RVA: 0x001D1FEC File Offset: 0x001D01EC
		// (set) Token: 0x06005C72 RID: 23666 RVA: 0x000327E6 File Offset: 0x000309E6
		public unsafe int phase3YuyukoStandSpawnInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3YuyukoStandSpawnInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_phase3YuyukoStandSpawnInterval)) = value;
			}
		}

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x06005C73 RID: 23667 RVA: 0x001D2014 File Offset: 0x001D0214
		// (set) Token: 0x06005C74 RID: 23668 RVA: 0x00032801 File Offset: 0x00030A01
		public unsafe GameObject yuyukoEatEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_yuyukoEatEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.NativeFieldInfoPtr_yuyukoEatEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D2C RID: 15660
		private static readonly IntPtr NativeFieldInfoPtr_YUYUKO_ID;

		// Token: 0x04003D2D RID: 15661
		private static readonly IntPtr NativeFieldInfoPtr_CHALLENGE_YUYUKO_ID;

		// Token: 0x04003D2E RID: 15662
		private static readonly IntPtr NativeFieldInfoPtr_singleRoundDuration;

		// Token: 0x04003D2F RID: 15663
		private static readonly IntPtr NativeFieldInfoPtr_phase1TargetPoints;

		// Token: 0x04003D30 RID: 15664
		private static readonly IntPtr NativeFieldInfoPtr_phase1GuestSpawnInterval;

		// Token: 0x04003D31 RID: 15665
		private static readonly IntPtr NativeFieldInfoPtr_phase2TargetPositiveSpells;

		// Token: 0x04003D32 RID: 15666
		private static readonly IntPtr NativeFieldInfoPtr_phase2GuestSpawnInterval;

		// Token: 0x04003D33 RID: 15667
		private static readonly IntPtr NativeFieldInfoPtr_phase2NegativeSpellInterval;

		// Token: 0x04003D34 RID: 15668
		private static readonly IntPtr NativeFieldInfoPtr_phase3YuyukoTotalLife;

		// Token: 0x04003D35 RID: 15669
		private static readonly IntPtr NativeFieldInfoPtr_phase3FoodLevelToYuyukoHpData;

		// Token: 0x04003D36 RID: 15670
		private static readonly IntPtr NativeFieldInfoPtr_allLevel3IzakayaIds;

		// Token: 0x04003D37 RID: 15671
		private static readonly IntPtr NativeFieldInfoPtr_phase3ChallengeModePatienceDecreaseMultiplier;

		// Token: 0x04003D38 RID: 15672
		private static readonly IntPtr NativeFieldInfoPtr_phase3DamageWhenStandBeCompletelyDefeated;

		// Token: 0x04003D39 RID: 15673
		private static readonly IntPtr NativeFieldInfoPtr_phase3DamageWhenStandBeNormalDefeated;

		// Token: 0x04003D3A RID: 15674
		private static readonly IntPtr NativeFieldInfoPtr_phase3YuyukoStandSpawnInterval;

		// Token: 0x04003D3B RID: 15675
		private static readonly IntPtr NativeFieldInfoPtr_yuyukoEatEffect;

		// Token: 0x04003D3C RID: 15676
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0;

		// Token: 0x04003D3D RID: 15677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003D3E RID: 15678
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_PDM_0;

		// Token: 0x02000D1D RID: 3357
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600F194 RID: 61844 RVA: 0x00394804 File Offset: 0x00392A04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr);
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_thisSingleRoundDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "thisSingleRoundDuration");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "eventManager");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "canContinue");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "uiManager");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_canContinueYieldInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "canContinueYieldInstruction");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_guestsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "guestsManager");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_allNormalGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "allNormalGuests");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoSeatPostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "yuyukoSeatPostion");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_allSpecialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "allSpecialGuest");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_specialGuestInScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "specialGuestInScene");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_positiveSpellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "positiveSpellCount");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_statusDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "statusDisplayer");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyuko = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "yuyuko");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_dmgMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "dmgMultiplier");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_levelToHpReduction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "levelToHpReduction");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoTotalLife = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "yuyukoTotalLife");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_partnerManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "partnerManager");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoPicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "yuyukoPicture");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoSpellData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "yuyukoSpellData");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyuko_NomralData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "yuyuko_NomralData");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___9__36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "<>9__36");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___9__75 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "<>9__75");
				YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___9__76 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "<>9__76");
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682262);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682263);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682264);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682265);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__25_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682266);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682267);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682268);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682269);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682270);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682271);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682272);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__12_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682273);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682274);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682275);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialGuestsController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682276);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682277);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__19_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682278);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682279);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682280);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__22_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682281);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682282);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__36_Internal_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682283);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682284);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__37_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682285);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682286);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682287);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__76_Internal_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682288);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__54_Internal_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682289);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682290);
				YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__23_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, 100682291);
			}

			// Token: 0x0600F195 RID: 61845 RVA: 0x00394C68 File Offset: 0x00392E68
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F196 RID: 61846 RVA: 0x00394CA4 File Offset: 0x00392EA4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 231011, RefRangeEnd = 231015, XrefRangeStart = 231005, XrefRangeEnd = 231011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Func_1_Boolean_0(Func<bool> extraTiming)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extraTiming);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F197 RID: 61847 RVA: 0x00394CF4 File Offset: 0x00392EF4
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F198 RID: 61848 RVA: 0x00394D30 File Offset: 0x00392F30
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 231020, RefRangeEnd = 231023, XrefRangeStart = 231015, XrefRangeEnd = 231020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F199 RID: 61849 RVA: 0x00394D70 File Offset: 0x00392F70
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__25()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__25_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F19A RID: 61850 RVA: 0x00394DA4 File Offset: 0x00392FA4
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F19B RID: 61851 RVA: 0x00394DD8 File Offset: 0x00392FD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231023, XrefRangeEnd = 231028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F19C RID: 61852 RVA: 0x00394E18 File Offset: 0x00393018
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F19D RID: 61853 RVA: 0x00394E54 File Offset: 0x00393054
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231028, XrefRangeEnd = 231029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__9(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F19E RID: 61854 RVA: 0x00394E98 File Offset: 0x00393098
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231029, XrefRangeEnd = 231030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__10(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F19F RID: 61855 RVA: 0x00394EDC File Offset: 0x003930DC
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1A0 RID: 61856 RVA: 0x00394F10 File Offset: 0x00393110
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__12_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1A1 RID: 61857 RVA: 0x00394F44 File Offset: 0x00393144
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231030, XrefRangeEnd = 231035, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F1A2 RID: 61858 RVA: 0x00394F84 File Offset: 0x00393184
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231035, XrefRangeEnd = 231040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F1A3 RID: 61859 RVA: 0x00394FC4 File Offset: 0x003931C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231040, XrefRangeEnd = 231042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_SpecialGuestsController_PDM_0(SpecialGuestsController _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_SpecialGuestsController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1A4 RID: 61860 RVA: 0x00395008 File Offset: 0x00393208
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__18()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F1A5 RID: 61861 RVA: 0x00395044 File Offset: 0x00393244
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__19(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__19_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1A6 RID: 61862 RVA: 0x00395088 File Offset: 0x00393288
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__20(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1A7 RID: 61863 RVA: 0x003950CC File Offset: 0x003932CC
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__21()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1A8 RID: 61864 RVA: 0x00395100 File Offset: 0x00393300
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__22()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__22_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1A9 RID: 61865 RVA: 0x00395134 File Offset: 0x00393334
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231042, XrefRangeEnd = 231046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0(GuestGroupController.EvaluationResult lastResult, GuestGroupController __, bool oldComboProtect, out string message, out bool comboProtect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref lastResult;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(__);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				message = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600F1AA RID: 61866 RVA: 0x003951C8 File Offset: 0x003933C8
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__36(GuestGroupController.EvaluationResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__36_Internal_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1AB RID: 61867 RVA: 0x00395208 File Offset: 0x00393408
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__35()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F1AC RID: 61868 RVA: 0x00395244 File Offset: 0x00393444
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231046, XrefRangeEnd = 231048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__37()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__37_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1AD RID: 61869 RVA: 0x00395278 File Offset: 0x00393478
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231048, XrefRangeEnd = 231072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__56(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F1AE RID: 61870 RVA: 0x003952C4 File Offset: 0x003934C4
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__75(GuestGroupController.EvaluationResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1AF RID: 61871 RVA: 0x00395304 File Offset: 0x00393504
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__76(GuestGroupController.EvaluationResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__76_Internal_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1B0 RID: 61872 RVA: 0x00395344 File Offset: 0x00393544
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__54(Coroutine x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__54_Internal_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1B1 RID: 61873 RVA: 0x00395388 File Offset: 0x00393588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__55(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1B2 RID: 61874 RVA: 0x003953CC File Offset: 0x003935CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__23(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.NativeMethodInfoPtr__MainChallengeLoop_b__23_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1B3 RID: 61875 RVA: 0x00081B37 File Offset: 0x0007FD37
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004E95 RID: 20117
			// (get) Token: 0x0600F1B4 RID: 61876 RVA: 0x00395410 File Offset: 0x00393610
			// (set) Token: 0x0600F1B5 RID: 61877 RVA: 0x00081B40 File Offset: 0x0007FD40
			public unsafe int thisSingleRoundDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_thisSingleRoundDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_thisSingleRoundDuration)) = value;
				}
			}

			// Token: 0x17004E96 RID: 20118
			// (get) Token: 0x0600F1B6 RID: 61878 RVA: 0x00395438 File Offset: 0x00393638
			// (set) Token: 0x0600F1B7 RID: 61879 RVA: 0x00081B5B File Offset: 0x0007FD5B
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E97 RID: 20119
			// (get) Token: 0x0600F1B8 RID: 61880 RVA: 0x00395468 File Offset: 0x00393668
			// (set) Token: 0x0600F1B9 RID: 61881 RVA: 0x00081B7A File Offset: 0x0007FD7A
			public unsafe YuyukoBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E98 RID: 20120
			// (get) Token: 0x0600F1BA RID: 61882 RVA: 0x00395498 File Offset: 0x00393698
			// (set) Token: 0x0600F1BB RID: 61883 RVA: 0x00081B99 File Offset: 0x0007FD99
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x17004E99 RID: 20121
			// (get) Token: 0x0600F1BC RID: 61884 RVA: 0x003954C0 File Offset: 0x003936C0
			// (set) Token: 0x0600F1BD RID: 61885 RVA: 0x00081BB4 File Offset: 0x0007FDB4
			public unsafe UIManager uiManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_uiManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_uiManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E9A RID: 20122
			// (get) Token: 0x0600F1BE RID: 61886 RVA: 0x003954F0 File Offset: 0x003936F0
			// (set) Token: 0x0600F1BF RID: 61887 RVA: 0x00081BD3 File Offset: 0x0007FDD3
			public unsafe WaitUntil canContinueYieldInstruction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_canContinueYieldInstruction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_canContinueYieldInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E9B RID: 20123
			// (get) Token: 0x0600F1C0 RID: 61888 RVA: 0x00395520 File Offset: 0x00393720
			// (set) Token: 0x0600F1C1 RID: 61889 RVA: 0x00081BF2 File Offset: 0x0007FDF2
			public unsafe GuestsManager guestsManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_guestsManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_guestsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E9C RID: 20124
			// (get) Token: 0x0600F1C2 RID: 61890 RVA: 0x00395550 File Offset: 0x00393750
			// (set) Token: 0x0600F1C3 RID: 61891 RVA: 0x00081C11 File Offset: 0x0007FE11
			public unsafe IEnumerable<Il2CppStructArray<int>> allNormalGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_allNormalGuests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_allNormalGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E9D RID: 20125
			// (get) Token: 0x0600F1C4 RID: 61892 RVA: 0x00395580 File Offset: 0x00393780
			// (set) Token: 0x0600F1C5 RID: 61893 RVA: 0x00081C30 File Offset: 0x0007FE30
			public unsafe Vector3 yuyukoSeatPostion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoSeatPostion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoSeatPostion)) = value;
				}
			}

			// Token: 0x17004E9E RID: 20126
			// (get) Token: 0x0600F1C6 RID: 61894 RVA: 0x003955A8 File Offset: 0x003937A8
			// (set) Token: 0x0600F1C7 RID: 61895 RVA: 0x00081C4B File Offset: 0x0007FE4B
			public unsafe List<int> allSpecialGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_allSpecialGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_allSpecialGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004E9F RID: 20127
			// (get) Token: 0x0600F1C8 RID: 61896 RVA: 0x003955D8 File Offset: 0x003937D8
			// (set) Token: 0x0600F1C9 RID: 61897 RVA: 0x00081C6A File Offset: 0x0007FE6A
			public unsafe HashSet<int> specialGuestInScene
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_specialGuestInScene);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_specialGuestInScene), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EA0 RID: 20128
			// (get) Token: 0x0600F1CA RID: 61898 RVA: 0x00395608 File Offset: 0x00393808
			// (set) Token: 0x0600F1CB RID: 61899 RVA: 0x00081C89 File Offset: 0x0007FE89
			public unsafe int positiveSpellCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_positiveSpellCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_positiveSpellCount)) = value;
				}
			}

			// Token: 0x17004EA1 RID: 20129
			// (get) Token: 0x0600F1CC RID: 61900 RVA: 0x00395630 File Offset: 0x00393830
			// (set) Token: 0x0600F1CD RID: 61901 RVA: 0x00081CA4 File Offset: 0x0007FEA4
			public unsafe IncomeControllerYuyuko statusDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_statusDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerYuyuko>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_statusDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EA2 RID: 20130
			// (get) Token: 0x0600F1CE RID: 61902 RVA: 0x00395660 File Offset: 0x00393860
			// (set) Token: 0x0600F1CF RID: 61903 RVA: 0x00081CC3 File Offset: 0x0007FEC3
			public unsafe GuestGroupController yuyuko
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyuko);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyuko), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EA3 RID: 20131
			// (get) Token: 0x0600F1D0 RID: 61904 RVA: 0x00395690 File Offset: 0x00393890
			// (set) Token: 0x0600F1D1 RID: 61905 RVA: 0x00081CE2 File Offset: 0x0007FEE2
			public unsafe float dmgMultiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_dmgMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_dmgMultiplier)) = value;
				}
			}

			// Token: 0x17004EA4 RID: 20132
			// (get) Token: 0x0600F1D2 RID: 61906 RVA: 0x003956B8 File Offset: 0x003938B8
			// (set) Token: 0x0600F1D3 RID: 61907 RVA: 0x00081CFD File Offset: 0x0007FEFD
			public unsafe Dictionary<int, int> levelToHpReduction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_levelToHpReduction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_levelToHpReduction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EA5 RID: 20133
			// (get) Token: 0x0600F1D4 RID: 61908 RVA: 0x003956E8 File Offset: 0x003938E8
			// (set) Token: 0x0600F1D5 RID: 61909 RVA: 0x00081D1C File Offset: 0x0007FF1C
			public unsafe int yuyukoTotalLife
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoTotalLife);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoTotalLife)) = value;
				}
			}

			// Token: 0x17004EA6 RID: 20134
			// (get) Token: 0x0600F1D6 RID: 61910 RVA: 0x00395710 File Offset: 0x00393910
			// (set) Token: 0x0600F1D7 RID: 61911 RVA: 0x00081D37 File Offset: 0x0007FF37
			public unsafe PartnerManager partnerManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_partnerManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartnerManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_partnerManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EA7 RID: 20135
			// (get) Token: 0x0600F1D8 RID: 61912 RVA: 0x00395740 File Offset: 0x00393940
			// (set) Token: 0x0600F1D9 RID: 61913 RVA: 0x00081D56 File Offset: 0x0007FF56
			public unsafe SpecialGuest yuyukoPicture
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoPicture);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoPicture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EA8 RID: 20136
			// (get) Token: 0x0600F1DA RID: 61914 RVA: 0x00395770 File Offset: 0x00393970
			// (set) Token: 0x0600F1DB RID: 61915 RVA: 0x00081D75 File Offset: 0x0007FF75
			public unsafe Il2CppReferenceArray<LanguageBase> yuyukoSpellData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoSpellData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LanguageBase>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyukoSpellData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EA9 RID: 20137
			// (get) Token: 0x0600F1DC RID: 61916 RVA: 0x003957A0 File Offset: 0x003939A0
			// (set) Token: 0x0600F1DD RID: 61917 RVA: 0x00081D94 File Offset: 0x0007FF94
			public unsafe SpecialGuest yuyuko_NomralData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyuko_NomralData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr_yuyuko_NomralData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EAA RID: 20138
			// (get) Token: 0x0600F1DE RID: 61918 RVA: 0x003957D0 File Offset: 0x003939D0
			// (set) Token: 0x0600F1DF RID: 61919 RVA: 0x00081DB3 File Offset: 0x0007FFB3
			public unsafe Action<GuestGroupController.EvaluationResult> __9__36
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___9__36);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___9__36), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EAB RID: 20139
			// (get) Token: 0x0600F1E0 RID: 61920 RVA: 0x00395800 File Offset: 0x00393A00
			// (set) Token: 0x0600F1E1 RID: 61921 RVA: 0x00081DD2 File Offset: 0x0007FFD2
			public unsafe Action<GuestGroupController.EvaluationResult> __9__75
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___9__75);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___9__75), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EAC RID: 20140
			// (get) Token: 0x0600F1E2 RID: 61922 RVA: 0x00395830 File Offset: 0x00393A30
			// (set) Token: 0x0600F1E3 RID: 61923 RVA: 0x00081DF1 File Offset: 0x0007FFF1
			public unsafe Action<GuestGroupController.EvaluationResult> __9__76
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___9__76);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.NativeFieldInfoPtr___9__76), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099F0 RID: 39408
			private static readonly IntPtr NativeFieldInfoPtr_thisSingleRoundDuration;

			// Token: 0x040099F1 RID: 39409
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x040099F2 RID: 39410
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040099F3 RID: 39411
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x040099F4 RID: 39412
			private static readonly IntPtr NativeFieldInfoPtr_uiManager;

			// Token: 0x040099F5 RID: 39413
			private static readonly IntPtr NativeFieldInfoPtr_canContinueYieldInstruction;

			// Token: 0x040099F6 RID: 39414
			private static readonly IntPtr NativeFieldInfoPtr_guestsManager;

			// Token: 0x040099F7 RID: 39415
			private static readonly IntPtr NativeFieldInfoPtr_allNormalGuests;

			// Token: 0x040099F8 RID: 39416
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoSeatPostion;

			// Token: 0x040099F9 RID: 39417
			private static readonly IntPtr NativeFieldInfoPtr_allSpecialGuest;

			// Token: 0x040099FA RID: 39418
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestInScene;

			// Token: 0x040099FB RID: 39419
			private static readonly IntPtr NativeFieldInfoPtr_positiveSpellCount;

			// Token: 0x040099FC RID: 39420
			private static readonly IntPtr NativeFieldInfoPtr_statusDisplayer;

			// Token: 0x040099FD RID: 39421
			private static readonly IntPtr NativeFieldInfoPtr_yuyuko;

			// Token: 0x040099FE RID: 39422
			private static readonly IntPtr NativeFieldInfoPtr_dmgMultiplier;

			// Token: 0x040099FF RID: 39423
			private static readonly IntPtr NativeFieldInfoPtr_levelToHpReduction;

			// Token: 0x04009A00 RID: 39424
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoTotalLife;

			// Token: 0x04009A01 RID: 39425
			private static readonly IntPtr NativeFieldInfoPtr_partnerManager;

			// Token: 0x04009A02 RID: 39426
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoPicture;

			// Token: 0x04009A03 RID: 39427
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoSpellData;

			// Token: 0x04009A04 RID: 39428
			private static readonly IntPtr NativeFieldInfoPtr_yuyuko_NomralData;

			// Token: 0x04009A05 RID: 39429
			private static readonly IntPtr NativeFieldInfoPtr___9__36;

			// Token: 0x04009A06 RID: 39430
			private static readonly IntPtr NativeFieldInfoPtr___9__75;

			// Token: 0x04009A07 RID: 39431
			private static readonly IntPtr NativeFieldInfoPtr___9__76;

			// Token: 0x04009A08 RID: 39432
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A09 RID: 39433
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_0;

			// Token: 0x04009A0A RID: 39434
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__3_Internal_Boolean_0;

			// Token: 0x04009A0B RID: 39435
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x04009A0C RID: 39436
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__25_Internal_Void_0;

			// Token: 0x04009A0D RID: 39437
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_0;

			// Token: 0x04009A0E RID: 39438
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009A0F RID: 39439
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Boolean_0;

			// Token: 0x04009A10 RID: 39440
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_GuestGroupController_0;

			// Token: 0x04009A11 RID: 39441
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Void_GuestGroupController_0;

			// Token: 0x04009A12 RID: 39442
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_0;

			// Token: 0x04009A13 RID: 39443
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__12_Internal_Void_0;

			// Token: 0x04009A14 RID: 39444
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x04009A15 RID: 39445
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2;

			// Token: 0x04009A16 RID: 39446
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_SpecialGuestsController_PDM_0;

			// Token: 0x04009A17 RID: 39447
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Boolean_0;

			// Token: 0x04009A18 RID: 39448
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__19_Internal_Void_GuestGroupController_0;

			// Token: 0x04009A19 RID: 39449
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Void_GuestGroupController_0;

			// Token: 0x04009A1A RID: 39450
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_0;

			// Token: 0x04009A1B RID: 39451
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__22_Internal_Void_0;

			// Token: 0x04009A1C RID: 39452
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0;

			// Token: 0x04009A1D RID: 39453
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__36_Internal_Void_EvaluationResult_0;

			// Token: 0x04009A1E RID: 39454
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__35_Internal_Boolean_0;

			// Token: 0x04009A1F RID: 39455
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__37_Internal_Void_0;

			// Token: 0x04009A20 RID: 39456
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__56_Internal_Boolean_Int32_0;

			// Token: 0x04009A21 RID: 39457
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_Void_EvaluationResult_0;

			// Token: 0x04009A22 RID: 39458
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__76_Internal_Void_EvaluationResult_0;

			// Token: 0x04009A23 RID: 39459
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__54_Internal_Void_Coroutine_0;

			// Token: 0x04009A24 RID: 39460
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Void_GuestGroupController_0;

			// Token: 0x04009A25 RID: 39461
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__23_Internal_Void_GuestGroupController_0;

			// Token: 0x02001089 RID: 4233
			[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_0+<<MainChallengeLoop>g__Timing|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012072 RID: 73842 RVA: 0x0041E088 File Offset: 0x0041C288
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique()
				{
					Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "<<MainChallengeLoop>g__Timing|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<>1__state");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<>2__current");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<>4__this");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr_extraTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "extraTiming");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__totalCountDown_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<totalCountDown>5__2");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__progress_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<progress>5__3");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100682292);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100682293);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100682294);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100682295);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100682296);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100682297);
				}

				// Token: 0x06012073 RID: 73843 RVA: 0x0041E1A4 File Offset: 0x0041C3A4
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012074 RID: 73844 RVA: 0x0041E1EC File Offset: 0x0041C3EC
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012075 RID: 73845 RVA: 0x0041E220 File Offset: 0x0041C420
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230818, XrefRangeEnd = 230821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E18 RID: 24088
				// (get) Token: 0x06012076 RID: 73846 RVA: 0x0041E25C File Offset: 0x0041C45C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012077 RID: 73847 RVA: 0x0041E29C File Offset: 0x0041C49C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230821, XrefRangeEnd = 230827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E19 RID: 24089
				// (get) Token: 0x06012078 RID: 73848 RVA: 0x0041E2D0 File Offset: 0x0041C4D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012079 RID: 73849 RVA: 0x0009CA3C File Offset: 0x0009AC3C
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E12 RID: 24082
				// (get) Token: 0x0601207A RID: 73850 RVA: 0x0041E310 File Offset: 0x0041C510
				// (set) Token: 0x0601207B RID: 73851 RVA: 0x0009CA45 File Offset: 0x0009AC45
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E13 RID: 24083
				// (get) Token: 0x0601207C RID: 73852 RVA: 0x0041E338 File Offset: 0x0041C538
				// (set) Token: 0x0601207D RID: 73853 RVA: 0x0009CA60 File Offset: 0x0009AC60
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E14 RID: 24084
				// (get) Token: 0x0601207E RID: 73854 RVA: 0x0041E368 File Offset: 0x0041C568
				// (set) Token: 0x0601207F RID: 73855 RVA: 0x0009CA7F File Offset: 0x0009AC7F
				public unsafe YuyukoBossData.__c__DisplayClass16_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E15 RID: 24085
				// (get) Token: 0x06012080 RID: 73856 RVA: 0x0041E398 File Offset: 0x0041C598
				// (set) Token: 0x06012081 RID: 73857 RVA: 0x0009CA9E File Offset: 0x0009AC9E
				public unsafe Func<bool> extraTiming
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr_extraTiming);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr_extraTiming), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E16 RID: 24086
				// (get) Token: 0x06012082 RID: 73858 RVA: 0x0041E3C8 File Offset: 0x0041C5C8
				// (set) Token: 0x06012083 RID: 73859 RVA: 0x0009CABD File Offset: 0x0009ACBD
				public unsafe int _totalCountDown_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__totalCountDown_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__totalCountDown_5__2)) = value;
					}
				}

				// Token: 0x17005E17 RID: 24087
				// (get) Token: 0x06012084 RID: 73860 RVA: 0x0041E3F0 File Offset: 0x0041C5F0
				// (set) Token: 0x06012085 RID: 73861 RVA: 0x0009CAD8 File Offset: 0x0009ACD8
				public unsafe float _progress_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__progress_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__progress_5__3)) = value;
					}
				}

				// Token: 0x0400B6AF RID: 46767
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B6B0 RID: 46768
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B6B1 RID: 46769
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6B2 RID: 46770
				private static readonly IntPtr NativeFieldInfoPtr_extraTiming;

				// Token: 0x0400B6B3 RID: 46771
				private static readonly IntPtr NativeFieldInfoPtr__totalCountDown_5__2;

				// Token: 0x0400B6B4 RID: 46772
				private static readonly IntPtr NativeFieldInfoPtr__progress_5__3;

				// Token: 0x0400B6B5 RID: 46773
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B6B6 RID: 46774
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6B7 RID: 46775
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B6B8 RID: 46776
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B6B9 RID: 46777
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6BA RID: 46778
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200108A RID: 4234
			[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_0+<<MainChallengeLoop>g__OnFail|4>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06012086 RID: 73862 RVA: 0x0041E418 File Offset: 0x0041C618
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "<<MainChallengeLoop>g__OnFail|4>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682298);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682299);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682300);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682301);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682302);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682303);
				}

				// Token: 0x06012087 RID: 73863 RVA: 0x0041E4F8 File Offset: 0x0041C6F8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012088 RID: 73864 RVA: 0x0041E540 File Offset: 0x0041C740
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012089 RID: 73865 RVA: 0x0041E574 File Offset: 0x0041C774
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230827, XrefRangeEnd = 230845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E1D RID: 24093
				// (get) Token: 0x0601208A RID: 73866 RVA: 0x0041E5B0 File Offset: 0x0041C7B0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601208B RID: 73867 RVA: 0x0041E5F0 File Offset: 0x0041C7F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230845, XrefRangeEnd = 230851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E1E RID: 24094
				// (get) Token: 0x0601208C RID: 73868 RVA: 0x0041E624 File Offset: 0x0041C824
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601208D RID: 73869 RVA: 0x0009CAF3 File Offset: 0x0009ACF3
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E1A RID: 24090
				// (get) Token: 0x0601208E RID: 73870 RVA: 0x0041E664 File Offset: 0x0041C864
				// (set) Token: 0x0601208F RID: 73871 RVA: 0x0009CAFC File Offset: 0x0009ACFC
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E1B RID: 24091
				// (get) Token: 0x06012090 RID: 73872 RVA: 0x0041E68C File Offset: 0x0041C88C
				// (set) Token: 0x06012091 RID: 73873 RVA: 0x0009CB17 File Offset: 0x0009AD17
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E1C RID: 24092
				// (get) Token: 0x06012092 RID: 73874 RVA: 0x0041E6BC File Offset: 0x0041C8BC
				// (set) Token: 0x06012093 RID: 73875 RVA: 0x0009CB36 File Offset: 0x0009AD36
				public unsafe YuyukoBossData.__c__DisplayClass16_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B6BB RID: 46779
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B6BC RID: 46780
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B6BD RID: 46781
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6BE RID: 46782
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B6BF RID: 46783
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6C0 RID: 46784
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B6C1 RID: 46785
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B6C2 RID: 46786
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6C3 RID: 46787
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200108B RID: 4235
			[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_0+<<MainChallengeLoop>g__Phase1GuestSpawnLoop|7>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0 : Il2CppSystem.Object
			{
				// Token: 0x06012094 RID: 73876 RVA: 0x0041E6EC File Offset: 0x0041C8EC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0()
				{
					Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase1GuestSpawnLoop|7>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, "<>1__state");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, "<>2__current");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, "<>4__this");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr__waitForSeconds_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, "<waitForSeconds>5__2");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, 100682304);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, 100682305);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, 100682306);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, 100682307);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, 100682308);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr, 100682309);
				}

				// Token: 0x06012095 RID: 73877 RVA: 0x0041E7E0 File Offset: 0x0041C9E0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012096 RID: 73878 RVA: 0x0041E828 File Offset: 0x0041CA28
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012097 RID: 73879 RVA: 0x0041E85C File Offset: 0x0041CA5C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230851, XrefRangeEnd = 230887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E23 RID: 24099
				// (get) Token: 0x06012098 RID: 73880 RVA: 0x0041E898 File Offset: 0x0041CA98
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06012099 RID: 73881 RVA: 0x0041E8D8 File Offset: 0x0041CAD8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230887, XrefRangeEnd = 230893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E24 RID: 24100
				// (get) Token: 0x0601209A RID: 73882 RVA: 0x0041E90C File Offset: 0x0041CB0C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0601209B RID: 73883 RVA: 0x0009CB55 File Offset: 0x0009AD55
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E1F RID: 24095
				// (get) Token: 0x0601209C RID: 73884 RVA: 0x0041E94C File Offset: 0x0041CB4C
				// (set) Token: 0x0601209D RID: 73885 RVA: 0x0009CB5E File Offset: 0x0009AD5E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E20 RID: 24096
				// (get) Token: 0x0601209E RID: 73886 RVA: 0x0041E974 File Offset: 0x0041CB74
				// (set) Token: 0x0601209F RID: 73887 RVA: 0x0009CB79 File Offset: 0x0009AD79
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E21 RID: 24097
				// (get) Token: 0x060120A0 RID: 73888 RVA: 0x0041E9A4 File Offset: 0x0041CBA4
				// (set) Token: 0x060120A1 RID: 73889 RVA: 0x0009CB98 File Offset: 0x0009AD98
				public unsafe YuyukoBossData.__c__DisplayClass16_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E22 RID: 24098
				// (get) Token: 0x060120A2 RID: 73890 RVA: 0x0041E9D4 File Offset: 0x0041CBD4
				// (set) Token: 0x060120A3 RID: 73891 RVA: 0x0009CBB7 File Offset: 0x0009ADB7
				public unsafe WaitForSeconds _waitForSeconds_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr__waitForSeconds_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb0.NativeFieldInfoPtr__waitForSeconds_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B6C4 RID: 46788
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B6C5 RID: 46789
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B6C6 RID: 46790
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6C7 RID: 46791
				private static readonly IntPtr NativeFieldInfoPtr__waitForSeconds_5__2;

				// Token: 0x0400B6C8 RID: 46792
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B6C9 RID: 46793
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6CA RID: 46794
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B6CB RID: 46795
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B6CC RID: 46796
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6CD RID: 46797
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200108C RID: 4236
			[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_0+<<MainChallengeLoop>g__Phase2GuestSpawnLoop|15>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1 : Il2CppSystem.Object
			{
				// Token: 0x060120A4 RID: 73892 RVA: 0x0041EA04 File Offset: 0x0041CC04
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1()
				{
					Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase2GuestSpawnLoop|15>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, "<>1__state");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, "<>2__current");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, "<>4__this");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr__waitForSeconds_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, "<waitForSeconds>5__2");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, 100682310);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, 100682311);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, 100682312);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, 100682313);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, 100682314);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr, 100682315);
				}

				// Token: 0x060120A5 RID: 73893 RVA: 0x0041EAF8 File Offset: 0x0041CCF8
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120A6 RID: 73894 RVA: 0x0041EB40 File Offset: 0x0041CD40
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120A7 RID: 73895 RVA: 0x0041EB74 File Offset: 0x0041CD74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230893, XrefRangeEnd = 230941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E29 RID: 24105
				// (get) Token: 0x060120A8 RID: 73896 RVA: 0x0041EBB0 File Offset: 0x0041CDB0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120A9 RID: 73897 RVA: 0x0041EBF0 File Offset: 0x0041CDF0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230941, XrefRangeEnd = 230947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E2A RID: 24106
				// (get) Token: 0x060120AA RID: 73898 RVA: 0x0041EC24 File Offset: 0x0041CE24
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120AB RID: 73899 RVA: 0x0009CBD6 File Offset: 0x0009ADD6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E25 RID: 24101
				// (get) Token: 0x060120AC RID: 73900 RVA: 0x0041EC64 File Offset: 0x0041CE64
				// (set) Token: 0x060120AD RID: 73901 RVA: 0x0009CBDF File Offset: 0x0009ADDF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E26 RID: 24102
				// (get) Token: 0x060120AE RID: 73902 RVA: 0x0041EC8C File Offset: 0x0041CE8C
				// (set) Token: 0x060120AF RID: 73903 RVA: 0x0009CBFA File Offset: 0x0009ADFA
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E27 RID: 24103
				// (get) Token: 0x060120B0 RID: 73904 RVA: 0x0041ECBC File Offset: 0x0041CEBC
				// (set) Token: 0x060120B1 RID: 73905 RVA: 0x0009CC19 File Offset: 0x0009AE19
				public unsafe YuyukoBossData.__c__DisplayClass16_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E28 RID: 24104
				// (get) Token: 0x060120B2 RID: 73906 RVA: 0x0041ECEC File Offset: 0x0041CEEC
				// (set) Token: 0x060120B3 RID: 73907 RVA: 0x0009CC38 File Offset: 0x0009AE38
				public unsafe WaitForSeconds _waitForSeconds_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr__waitForSeconds_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb1.NativeFieldInfoPtr__waitForSeconds_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B6CE RID: 46798
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B6CF RID: 46799
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B6D0 RID: 46800
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6D1 RID: 46801
				private static readonly IntPtr NativeFieldInfoPtr__waitForSeconds_5__2;

				// Token: 0x0400B6D2 RID: 46802
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B6D3 RID: 46803
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6D4 RID: 46804
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B6D5 RID: 46805
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B6D6 RID: 46806
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6D7 RID: 46807
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200108D RID: 4237
			[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_0+<<MainChallengeLoop>g__Phase2TimedNegativeSpell|16>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2 : Il2CppSystem.Object
			{
				// Token: 0x060120B4 RID: 73908 RVA: 0x0041ED1C File Offset: 0x0041CF1C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2()
				{
					Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase2TimedNegativeSpell|16>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, "<>1__state");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, "<>2__current");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, "<>4__this");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr__waitForSeconds_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, "<waitForSeconds>5__2");
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, 100682316);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, 100682317);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, 100682318);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, 100682319);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, 100682320);
					YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr, 100682321);
				}

				// Token: 0x060120B5 RID: 73909 RVA: 0x0041EE10 File Offset: 0x0041D010
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120B6 RID: 73910 RVA: 0x0041EE58 File Offset: 0x0041D058
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120B7 RID: 73911 RVA: 0x0041EE8C File Offset: 0x0041D08C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230947, XrefRangeEnd = 230999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E2F RID: 24111
				// (get) Token: 0x060120B8 RID: 73912 RVA: 0x0041EEC8 File Offset: 0x0041D0C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120B9 RID: 73913 RVA: 0x0041EF08 File Offset: 0x0041D108
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 230999, XrefRangeEnd = 231005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E30 RID: 24112
				// (get) Token: 0x060120BA RID: 73914 RVA: 0x0041EF3C File Offset: 0x0041D13C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120BB RID: 73915 RVA: 0x0009CC57 File Offset: 0x0009AE57
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E2B RID: 24107
				// (get) Token: 0x060120BC RID: 73916 RVA: 0x0041EF7C File Offset: 0x0041D17C
				// (set) Token: 0x060120BD RID: 73917 RVA: 0x0009CC60 File Offset: 0x0009AE60
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E2C RID: 24108
				// (get) Token: 0x060120BE RID: 73918 RVA: 0x0041EFA4 File Offset: 0x0041D1A4
				// (set) Token: 0x060120BF RID: 73919 RVA: 0x0009CC7B File Offset: 0x0009AE7B
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E2D RID: 24109
				// (get) Token: 0x060120C0 RID: 73920 RVA: 0x0041EFD4 File Offset: 0x0041D1D4
				// (set) Token: 0x060120C1 RID: 73921 RVA: 0x0009CC9A File Offset: 0x0009AE9A
				public unsafe YuyukoBossData.__c__DisplayClass16_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E2E RID: 24110
				// (get) Token: 0x060120C2 RID: 73922 RVA: 0x0041F004 File Offset: 0x0041D204
				// (set) Token: 0x060120C3 RID: 73923 RVA: 0x0009CCB9 File Offset: 0x0009AEB9
				public unsafe WaitForSeconds _waitForSeconds_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr__waitForSeconds_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaVoObMoInVoBoOb2.NativeFieldInfoPtr__waitForSeconds_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B6D8 RID: 46808
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B6D9 RID: 46809
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B6DA RID: 46810
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6DB RID: 46811
				private static readonly IntPtr NativeFieldInfoPtr__waitForSeconds_5__2;

				// Token: 0x0400B6DC RID: 46812
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B6DD RID: 46813
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6DE RID: 46814
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B6DF RID: 46815
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B6E0 RID: 46816
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6E1 RID: 46817
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D1E RID: 3358
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_1")]
		public sealed class __c__DisplayClass16_1 : Il2CppSystem.Object
		{
			// Token: 0x0600F1E4 RID: 61924 RVA: 0x00395860 File Offset: 0x00393A60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_1()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c__DisplayClass16_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_1>.NativeClassPtr);
				YuyukoBossData.__c__DisplayClass16_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_1>.NativeClassPtr, "x");
				YuyukoBossData.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_1>.NativeClassPtr, 100682322);
				YuyukoBossData.__c__DisplayClass16_1.NativeMethodInfoPtr__MainChallengeLoop_b__27_Internal_Boolean_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_1>.NativeClassPtr, 100682323);
			}

			// Token: 0x0600F1E5 RID: 61925 RVA: 0x003958C8 File Offset: 0x00393AC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1E6 RID: 61926 RVA: 0x00395904 File Offset: 0x00393B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231072, XrefRangeEnd = 231077, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__27(Izakaya.SpecialGuestGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_1.NativeMethodInfoPtr__MainChallengeLoop_b__27_Internal_Boolean_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F1E7 RID: 61927 RVA: 0x00081E10 File Offset: 0x00080010
			public __c__DisplayClass16_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EAD RID: 20141
			// (get) Token: 0x0600F1E8 RID: 61928 RVA: 0x00395954 File Offset: 0x00393B54
			// (set) Token: 0x0600F1E9 RID: 61929 RVA: 0x00081E19 File Offset: 0x00080019
			public unsafe Izakaya x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A26 RID: 39462
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04009A27 RID: 39463
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A28 RID: 39464
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__27_Internal_Boolean_SpecialGuestGroup_0;
		}

		// Token: 0x02000D1F RID: 3359
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_2")]
		public sealed class __c__DisplayClass16_2 : Il2CppSystem.Object
		{
			// Token: 0x0600F1EA RID: 61930 RVA: 0x00395984 File Offset: 0x00393B84
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_2()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c__DisplayClass16_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_2>.NativeClassPtr);
				YuyukoBossData.__c__DisplayClass16_2.NativeFieldInfoPtr_selectedGuestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_2>.NativeClassPtr, "selectedGuestGroup");
				YuyukoBossData.__c__DisplayClass16_2.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_2>.NativeClassPtr, "CS$<>8__locals1");
				YuyukoBossData.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_2>.NativeClassPtr, 100682324);
				YuyukoBossData.__c__DisplayClass16_2.NativeMethodInfoPtr__MainChallengeLoop_b__29_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_2>.NativeClassPtr, 100682325);
			}

			// Token: 0x0600F1EB RID: 61931 RVA: 0x00395A00 File Offset: 0x00393C00
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1EC RID: 61932 RVA: 0x00395A3C File Offset: 0x00393C3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231077, XrefRangeEnd = 231084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__29(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_2.NativeMethodInfoPtr__MainChallengeLoop_b__29_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1ED RID: 61933 RVA: 0x00081E38 File Offset: 0x00080038
			public __c__DisplayClass16_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EAE RID: 20142
			// (get) Token: 0x0600F1EE RID: 61934 RVA: 0x00395A80 File Offset: 0x00393C80
			// (set) Token: 0x0600F1EF RID: 61935 RVA: 0x00081E41 File Offset: 0x00080041
			public Nullable<int> selectedGuestGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_2.NativeFieldInfoPtr_selectedGuestGroup);
					return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_2.NativeFieldInfoPtr_selectedGuestGroup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004EAF RID: 20143
			// (get) Token: 0x0600F1F0 RID: 61936 RVA: 0x00395AB0 File Offset: 0x00393CB0
			// (set) Token: 0x0600F1F1 RID: 61937 RVA: 0x00081E6F File Offset: 0x0008006F
			public unsafe YuyukoBossData.__c__DisplayClass16_0 field_Public___c__DisplayClass16_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_2.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_2.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A29 RID: 39465
			private static readonly IntPtr NativeFieldInfoPtr_selectedGuestGroup;

			// Token: 0x04009A2A RID: 39466
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0;

			// Token: 0x04009A2B RID: 39467
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A2C RID: 39468
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__29_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000D20 RID: 3360
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_3")]
		public sealed class __c__DisplayClass16_3 : Il2CppSystem.Object
		{
			// Token: 0x0600F1F2 RID: 61938 RVA: 0x00395AE0 File Offset: 0x00393CE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_3()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c__DisplayClass16_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_3>.NativeClassPtr);
				YuyukoBossData.__c__DisplayClass16_3.NativeFieldInfoPtr_canSpellContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_3>.NativeClassPtr, "canSpellContinue");
				YuyukoBossData.__c__DisplayClass16_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_3>.NativeClassPtr, 100682326);
				YuyukoBossData.__c__DisplayClass16_3.NativeMethodInfoPtr__MainChallengeLoop_b__31_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_3>.NativeClassPtr, 100682327);
				YuyukoBossData.__c__DisplayClass16_3.NativeMethodInfoPtr__MainChallengeLoop_b__32_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_3>.NativeClassPtr, 100682328);
			}

			// Token: 0x0600F1F3 RID: 61939 RVA: 0x00395B5C File Offset: 0x00393D5C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1F4 RID: 61940 RVA: 0x00395B98 File Offset: 0x00393D98
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__31()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_3.NativeMethodInfoPtr__MainChallengeLoop_b__31_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1F5 RID: 61941 RVA: 0x00395BCC File Offset: 0x00393DCC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__32()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_3.NativeMethodInfoPtr__MainChallengeLoop_b__32_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F1F6 RID: 61942 RVA: 0x00081E8E File Offset: 0x0008008E
			public __c__DisplayClass16_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EB0 RID: 20144
			// (get) Token: 0x0600F1F7 RID: 61943 RVA: 0x00395C08 File Offset: 0x00393E08
			// (set) Token: 0x0600F1F8 RID: 61944 RVA: 0x00081E97 File Offset: 0x00080097
			public unsafe bool canSpellContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_3.NativeFieldInfoPtr_canSpellContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_3.NativeFieldInfoPtr_canSpellContinue)) = value;
				}
			}

			// Token: 0x04009A2D RID: 39469
			private static readonly IntPtr NativeFieldInfoPtr_canSpellContinue;

			// Token: 0x04009A2E RID: 39470
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A2F RID: 39471
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__31_Internal_Void_0;

			// Token: 0x04009A30 RID: 39472
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__32_Internal_Boolean_0;
		}

		// Token: 0x02000D21 RID: 3361
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_4")]
		public sealed class __c__DisplayClass16_4 : Il2CppSystem.Object
		{
			// Token: 0x0600F1F9 RID: 61945 RVA: 0x00395C30 File Offset: 0x00393E30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_4()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c__DisplayClass16_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4>.NativeClassPtr);
				YuyukoBossData.__c__DisplayClass16_4.NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4>.NativeClassPtr, "yuyukoLikedFoodTagUnfolded");
				YuyukoBossData.__c__DisplayClass16_4.NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4>.NativeClassPtr, "yuyukoLikedBevTagUnfolded");
				YuyukoBossData.__c__DisplayClass16_4.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4>.NativeClassPtr, "CS$<>8__locals2");
				YuyukoBossData.__c__DisplayClass16_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4>.NativeClassPtr, 100682329);
				YuyukoBossData.__c__DisplayClass16_4.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4>.NativeClassPtr, 100682330);
			}

			// Token: 0x0600F1FA RID: 61946 RVA: 0x00395CC0 File Offset: 0x00393EC0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F1FB RID: 61947 RVA: 0x00395CFC File Offset: 0x00393EFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231118, XrefRangeEnd = 231123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_4.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F1FC RID: 61948 RVA: 0x00081EB2 File Offset: 0x000800B2
			public __c__DisplayClass16_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EB1 RID: 20145
			// (get) Token: 0x0600F1FD RID: 61949 RVA: 0x00395D3C File Offset: 0x00393F3C
			// (set) Token: 0x0600F1FE RID: 61950 RVA: 0x00081EBB File Offset: 0x000800BB
			public unsafe Il2CppStructArray<int> yuyukoLikedFoodTagUnfolded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EB2 RID: 20146
			// (get) Token: 0x0600F1FF RID: 61951 RVA: 0x00395D6C File Offset: 0x00393F6C
			// (set) Token: 0x0600F200 RID: 61952 RVA: 0x00081EDA File Offset: 0x000800DA
			public unsafe Il2CppStructArray<int> yuyukoLikedBevTagUnfolded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EB3 RID: 20147
			// (get) Token: 0x0600F201 RID: 61953 RVA: 0x00395D9C File Offset: 0x00393F9C
			// (set) Token: 0x0600F202 RID: 61954 RVA: 0x00081EF9 File Offset: 0x000800F9
			public unsafe YuyukoBossData.__c__DisplayClass16_0 field_Public___c__DisplayClass16_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A31 RID: 39473
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded;

			// Token: 0x04009A32 RID: 39474
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded;

			// Token: 0x04009A33 RID: 39475
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0;

			// Token: 0x04009A34 RID: 39476
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A35 RID: 39477
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200108E RID: 4238
			[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_4+<<MainChallengeLoop>g__Phase3OrderLoop|34>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060120C4 RID: 73924 RVA: 0x0041F034 File Offset: 0x0041D234
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4>.NativeClassPtr, "<<MainChallengeLoop>g__Phase3OrderLoop|34>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682331);
					YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682332);
					YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682333);
					YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682334);
					YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682335);
					YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682336);
				}

				// Token: 0x060120C5 RID: 73925 RVA: 0x0041F114 File Offset: 0x0041D314
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120C6 RID: 73926 RVA: 0x0041F15C File Offset: 0x0041D35C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120C7 RID: 73927 RVA: 0x0041F190 File Offset: 0x0041D390
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231084, XrefRangeEnd = 231112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E34 RID: 24116
				// (get) Token: 0x060120C8 RID: 73928 RVA: 0x0041F1CC File Offset: 0x0041D3CC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120C9 RID: 73929 RVA: 0x0041F20C File Offset: 0x0041D40C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231112, XrefRangeEnd = 231118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E35 RID: 24117
				// (get) Token: 0x060120CA RID: 73930 RVA: 0x0041F240 File Offset: 0x0041D440
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120CB RID: 73931 RVA: 0x0009CCD8 File Offset: 0x0009AED8
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E31 RID: 24113
				// (get) Token: 0x060120CC RID: 73932 RVA: 0x0041F280 File Offset: 0x0041D480
				// (set) Token: 0x060120CD RID: 73933 RVA: 0x0009CCE1 File Offset: 0x0009AEE1
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E32 RID: 24114
				// (get) Token: 0x060120CE RID: 73934 RVA: 0x0041F2A8 File Offset: 0x0041D4A8
				// (set) Token: 0x060120CF RID: 73935 RVA: 0x0009CCFC File Offset: 0x0009AEFC
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E33 RID: 24115
				// (get) Token: 0x060120D0 RID: 73936 RVA: 0x0041F2D8 File Offset: 0x0041D4D8
				// (set) Token: 0x060120D1 RID: 73937 RVA: 0x0009CD1B File Offset: 0x0009AF1B
				public unsafe YuyukoBossData.__c__DisplayClass16_4 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_4>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_4.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B6E2 RID: 46818
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B6E3 RID: 46819
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B6E4 RID: 46820
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6E5 RID: 46821
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B6E6 RID: 46822
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6E7 RID: 46823
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B6E8 RID: 46824
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B6E9 RID: 46825
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6EA RID: 46826
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D22 RID: 3362
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_5")]
		public sealed class __c__DisplayClass16_5 : Il2CppSystem.Object
		{
			// Token: 0x0600F203 RID: 61955 RVA: 0x00395DCC File Offset: 0x00393FCC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_5()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c__DisplayClass16_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr);
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_totalCookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "totalCookers");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_eatingGameObejct = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "eatingGameObejct");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_BossBuffend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "BossBuffend");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_interrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "interrupt");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "multiplier");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_ifYuyukoCouldOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "ifYuyukoCouldOrder");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_lockCookerCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "lockCookerCorotine");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "yuyukoLikedFoodTagUnfolded");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "yuyukoLikedBevTagUnfolded");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_allSelectedFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "allSelectedFood");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_allSelectedBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "allSelectedBev");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "CS$<>8__locals3");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__71 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "<>9__71");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__72 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "<>9__72");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__73 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "<>9__73");
				YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__74 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "<>9__74");
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682337);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682338);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682339);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682340);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682341);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__71_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682342);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682343);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__72_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682344);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__46_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682345);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__73_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682346);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682347);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682348);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682349);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__74_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682350);
				YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, 100682351);
			}

			// Token: 0x0600F204 RID: 61956 RVA: 0x00396064 File Offset: 0x00394264
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F205 RID: 61957 RVA: 0x003960A0 File Offset: 0x003942A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231305, XrefRangeEnd = 231306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F206 RID: 61958 RVA: 0x003960DC File Offset: 0x003942DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231306, XrefRangeEnd = 231311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Vector3_PDM_0(Vector3 yuyukoPosition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref yuyukoPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector3_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F207 RID: 61959 RVA: 0x00396128 File Offset: 0x00394328
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231311, XrefRangeEnd = 231333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F208 RID: 61960 RVA: 0x0039615C File Offset: 0x0039435C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231333, XrefRangeEnd = 231338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F209 RID: 61961 RVA: 0x0039619C File Offset: 0x0039439C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231338, XrefRangeEnd = 231350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__71(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__71_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F20A RID: 61962 RVA: 0x003961E0 File Offset: 0x003943E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231350, XrefRangeEnd = 231364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__44(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F20B RID: 61963 RVA: 0x00396230 File Offset: 0x00394430
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231364, XrefRangeEnd = 231367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__72(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__72_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F20C RID: 61964 RVA: 0x0039627C File Offset: 0x0039447C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231367, XrefRangeEnd = 231381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__46(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__46_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F20D RID: 61965 RVA: 0x003962CC File Offset: 0x003944CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231381, XrefRangeEnd = 231384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__73(int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__73_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F20E RID: 61966 RVA: 0x00396318 File Offset: 0x00394518
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231384, XrefRangeEnd = 231406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0(GuestGroupController.EvaluationResult lastResult, GuestGroupController thisGuestGroup, bool oldComboProtect, out string message, out bool comboProtect)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				message = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600F20F RID: 61967 RVA: 0x003963AC File Offset: 0x003945AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231406, XrefRangeEnd = 231427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestsManager.OrderBase Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0(GuestGroupController guestGroup, out string orderGenerationMessage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				orderGenerationMessage = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr4) : null;
			}

			// Token: 0x0600F210 RID: 61968 RVA: 0x00396418 File Offset: 0x00394618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231427, XrefRangeEnd = 231432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600F211 RID: 61969 RVA: 0x00396458 File Offset: 0x00394658
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__74()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__74_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F212 RID: 61970 RVA: 0x00396494 File Offset: 0x00394694
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__52()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F213 RID: 61971 RVA: 0x00081F18 File Offset: 0x00080118
			public __c__DisplayClass16_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EB4 RID: 20148
			// (get) Token: 0x0600F214 RID: 61972 RVA: 0x003964D0 File Offset: 0x003946D0
			// (set) Token: 0x0600F215 RID: 61973 RVA: 0x00081F21 File Offset: 0x00080121
			public unsafe int totalCookers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_totalCookers);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_totalCookers)) = value;
				}
			}

			// Token: 0x17004EB5 RID: 20149
			// (get) Token: 0x0600F216 RID: 61974 RVA: 0x003964F8 File Offset: 0x003946F8
			// (set) Token: 0x0600F217 RID: 61975 RVA: 0x00081F3C File Offset: 0x0008013C
			public unsafe List<GameObject> eatingGameObejct
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_eatingGameObejct);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_eatingGameObejct), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EB6 RID: 20150
			// (get) Token: 0x0600F218 RID: 61976 RVA: 0x00396528 File Offset: 0x00394728
			// (set) Token: 0x0600F219 RID: 61977 RVA: 0x00081F5B File Offset: 0x0008015B
			public unsafe Action BossBuffend
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_BossBuffend);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_BossBuffend), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EB7 RID: 20151
			// (get) Token: 0x0600F21A RID: 61978 RVA: 0x00396558 File Offset: 0x00394758
			// (set) Token: 0x0600F21B RID: 61979 RVA: 0x00081F7A File Offset: 0x0008017A
			public unsafe Action interrupt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_interrupt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_interrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EB8 RID: 20152
			// (get) Token: 0x0600F21C RID: 61980 RVA: 0x00396588 File Offset: 0x00394788
			// (set) Token: 0x0600F21D RID: 61981 RVA: 0x00081F99 File Offset: 0x00080199
			public unsafe float multiplier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_multiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_multiplier)) = value;
				}
			}

			// Token: 0x17004EB9 RID: 20153
			// (get) Token: 0x0600F21E RID: 61982 RVA: 0x003965B0 File Offset: 0x003947B0
			// (set) Token: 0x0600F21F RID: 61983 RVA: 0x00081FB4 File Offset: 0x000801B4
			public unsafe bool ifYuyukoCouldOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_ifYuyukoCouldOrder);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_ifYuyukoCouldOrder)) = value;
				}
			}

			// Token: 0x17004EBA RID: 20154
			// (get) Token: 0x0600F220 RID: 61984 RVA: 0x003965D8 File Offset: 0x003947D8
			// (set) Token: 0x0600F221 RID: 61985 RVA: 0x00081FCF File Offset: 0x000801CF
			public unsafe List<Coroutine> lockCookerCorotine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_lockCookerCorotine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Coroutine>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_lockCookerCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EBB RID: 20155
			// (get) Token: 0x0600F222 RID: 61986 RVA: 0x00396608 File Offset: 0x00394808
			// (set) Token: 0x0600F223 RID: 61987 RVA: 0x00081FEE File Offset: 0x000801EE
			public unsafe Il2CppStructArray<int> yuyukoLikedFoodTagUnfolded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EBC RID: 20156
			// (get) Token: 0x0600F224 RID: 61988 RVA: 0x00396638 File Offset: 0x00394838
			// (set) Token: 0x0600F225 RID: 61989 RVA: 0x0008200D File Offset: 0x0008020D
			public unsafe Il2CppStructArray<int> yuyukoLikedBevTagUnfolded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EBD RID: 20157
			// (get) Token: 0x0600F226 RID: 61990 RVA: 0x00396668 File Offset: 0x00394868
			// (set) Token: 0x0600F227 RID: 61991 RVA: 0x0008202C File Offset: 0x0008022C
			public unsafe Il2CppStructArray<int> allSelectedFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_allSelectedFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_allSelectedFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EBE RID: 20158
			// (get) Token: 0x0600F228 RID: 61992 RVA: 0x00396698 File Offset: 0x00394898
			// (set) Token: 0x0600F229 RID: 61993 RVA: 0x0008204B File Offset: 0x0008024B
			public unsafe Il2CppStructArray<int> allSelectedBev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_allSelectedBev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_allSelectedBev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EBF RID: 20159
			// (get) Token: 0x0600F22A RID: 61994 RVA: 0x003966C8 File Offset: 0x003948C8
			// (set) Token: 0x0600F22B RID: 61995 RVA: 0x0008206A File Offset: 0x0008026A
			public unsafe YuyukoBossData.__c__DisplayClass16_0 field_Public___c__DisplayClass16_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EC0 RID: 20160
			// (get) Token: 0x0600F22C RID: 61996 RVA: 0x003966F8 File Offset: 0x003948F8
			// (set) Token: 0x0600F22D RID: 61997 RVA: 0x00082089 File Offset: 0x00080289
			public unsafe Action<GuestGroupController> __9__71
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__71);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__71), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EC1 RID: 20161
			// (get) Token: 0x0600F22E RID: 61998 RVA: 0x00396728 File Offset: 0x00394928
			// (set) Token: 0x0600F22F RID: 61999 RVA: 0x000820A8 File Offset: 0x000802A8
			public unsafe Func<int, bool> __9__72
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__72);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__72), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EC2 RID: 20162
			// (get) Token: 0x0600F230 RID: 62000 RVA: 0x00396758 File Offset: 0x00394958
			// (set) Token: 0x0600F231 RID: 62001 RVA: 0x000820C7 File Offset: 0x000802C7
			public unsafe Func<int, bool> __9__73
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__73);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__73), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EC3 RID: 20163
			// (get) Token: 0x0600F232 RID: 62002 RVA: 0x00396788 File Offset: 0x00394988
			// (set) Token: 0x0600F233 RID: 62003 RVA: 0x000820E6 File Offset: 0x000802E6
			public unsafe Func<bool> __9__74
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__74);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.NativeFieldInfoPtr___9__74), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A36 RID: 39478
			private static readonly IntPtr NativeFieldInfoPtr_totalCookers;

			// Token: 0x04009A37 RID: 39479
			private static readonly IntPtr NativeFieldInfoPtr_eatingGameObejct;

			// Token: 0x04009A38 RID: 39480
			private static readonly IntPtr NativeFieldInfoPtr_BossBuffend;

			// Token: 0x04009A39 RID: 39481
			private static readonly IntPtr NativeFieldInfoPtr_interrupt;

			// Token: 0x04009A3A RID: 39482
			private static readonly IntPtr NativeFieldInfoPtr_multiplier;

			// Token: 0x04009A3B RID: 39483
			private static readonly IntPtr NativeFieldInfoPtr_ifYuyukoCouldOrder;

			// Token: 0x04009A3C RID: 39484
			private static readonly IntPtr NativeFieldInfoPtr_lockCookerCorotine;

			// Token: 0x04009A3D RID: 39485
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoLikedFoodTagUnfolded;

			// Token: 0x04009A3E RID: 39486
			private static readonly IntPtr NativeFieldInfoPtr_yuyukoLikedBevTagUnfolded;

			// Token: 0x04009A3F RID: 39487
			private static readonly IntPtr NativeFieldInfoPtr_allSelectedFood;

			// Token: 0x04009A40 RID: 39488
			private static readonly IntPtr NativeFieldInfoPtr_allSelectedBev;

			// Token: 0x04009A41 RID: 39489
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass16_0_0;

			// Token: 0x04009A42 RID: 39490
			private static readonly IntPtr NativeFieldInfoPtr___9__71;

			// Token: 0x04009A43 RID: 39491
			private static readonly IntPtr NativeFieldInfoPtr___9__72;

			// Token: 0x04009A44 RID: 39492
			private static readonly IntPtr NativeFieldInfoPtr___9__73;

			// Token: 0x04009A45 RID: 39493
			private static readonly IntPtr NativeFieldInfoPtr___9__74;

			// Token: 0x04009A46 RID: 39494
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A47 RID: 39495
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_PDM_0;

			// Token: 0x04009A48 RID: 39496
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector3_PDM_0;

			// Token: 0x04009A49 RID: 39497
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04009A4A RID: 39498
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009A4B RID: 39499
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__71_Internal_Void_GuestGroupController_0;

			// Token: 0x04009A4C RID: 39500
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__44_Internal_Boolean_Sellable_0;

			// Token: 0x04009A4D RID: 39501
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__72_Internal_Boolean_Int32_0;

			// Token: 0x04009A4E RID: 39502
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__46_Internal_Boolean_Sellable_0;

			// Token: 0x04009A4F RID: 39503
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__73_Internal_Boolean_Int32_0;

			// Token: 0x04009A50 RID: 39504
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0;

			// Token: 0x04009A51 RID: 39505
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0;

			// Token: 0x04009A52 RID: 39506
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x04009A53 RID: 39507
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__74_Internal_Boolean_0;

			// Token: 0x04009A54 RID: 39508
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__52_Internal_Boolean_0;

			// Token: 0x0200108F RID: 4239
			[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_5+<<MainChallengeLoop>g__LockCookersYuyuko|40>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060120D2 RID: 73938 RVA: 0x0041F308 File Offset: 0x0041D508
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique()
				{
					Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "<<MainChallengeLoop>g__LockCookersYuyuko|40>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, "<>1__state");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, "<>2__current");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, "<>4__this");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, "<>8__1");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr__spriteRenderer_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, "<spriteRenderer>5__2");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr__lockedCookController_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, "<lockedCookController>5__3");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, 100682352);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, 100682353);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, 100682354);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, 100682355);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, 100682356);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr, 100682357);
				}

				// Token: 0x060120D3 RID: 73939 RVA: 0x0041F424 File Offset: 0x0041D624
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120D4 RID: 73940 RVA: 0x0041F46C File Offset: 0x0041D66C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120D5 RID: 73941 RVA: 0x0041F4A0 File Offset: 0x0041D6A0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231123, XrefRangeEnd = 231184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E3C RID: 24124
				// (get) Token: 0x060120D6 RID: 73942 RVA: 0x0041F4DC File Offset: 0x0041D6DC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120D7 RID: 73943 RVA: 0x0041F51C File Offset: 0x0041D71C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231184, XrefRangeEnd = 231190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E3D RID: 24125
				// (get) Token: 0x060120D8 RID: 73944 RVA: 0x0041F550 File Offset: 0x0041D750
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120D9 RID: 73945 RVA: 0x0009CD3A File Offset: 0x0009AF3A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E36 RID: 24118
				// (get) Token: 0x060120DA RID: 73946 RVA: 0x0041F590 File Offset: 0x0041D790
				// (set) Token: 0x060120DB RID: 73947 RVA: 0x0009CD43 File Offset: 0x0009AF43
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E37 RID: 24119
				// (get) Token: 0x060120DC RID: 73948 RVA: 0x0041F5B8 File Offset: 0x0041D7B8
				// (set) Token: 0x060120DD RID: 73949 RVA: 0x0009CD5E File Offset: 0x0009AF5E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E38 RID: 24120
				// (get) Token: 0x060120DE RID: 73950 RVA: 0x0041F5E8 File Offset: 0x0041D7E8
				// (set) Token: 0x060120DF RID: 73951 RVA: 0x0009CD7D File Offset: 0x0009AF7D
				public unsafe YuyukoBossData.__c__DisplayClass16_5 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_5>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E39 RID: 24121
				// (get) Token: 0x060120E0 RID: 73952 RVA: 0x0041F618 File Offset: 0x0041D818
				// (set) Token: 0x060120E1 RID: 73953 RVA: 0x0009CD9C File Offset: 0x0009AF9C
				public unsafe YuyukoBossData.__c__DisplayClass16_6 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_6>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E3A RID: 24122
				// (get) Token: 0x060120E2 RID: 73954 RVA: 0x0041F648 File Offset: 0x0041D848
				// (set) Token: 0x060120E3 RID: 73955 RVA: 0x0009CDBB File Offset: 0x0009AFBB
				public unsafe SpriteRenderer _spriteRenderer_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr__spriteRenderer_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr__spriteRenderer_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E3B RID: 24123
				// (get) Token: 0x060120E4 RID: 73956 RVA: 0x0041F678 File Offset: 0x0041D878
				// (set) Token: 0x060120E5 RID: 73957 RVA: 0x0009CDDA File Offset: 0x0009AFDA
				public unsafe CookController _lockedCookController_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr__lockedCookController_5__3);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSpCoObObUnique.NativeFieldInfoPtr__lockedCookController_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B6EB RID: 46827
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B6EC RID: 46828
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B6ED RID: 46829
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6EE RID: 46830
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B6EF RID: 46831
				private static readonly IntPtr NativeFieldInfoPtr__spriteRenderer_5__2;

				// Token: 0x0400B6F0 RID: 46832
				private static readonly IntPtr NativeFieldInfoPtr__lockedCookController_5__3;

				// Token: 0x0400B6F1 RID: 46833
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B6F2 RID: 46834
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6F3 RID: 46835
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B6F4 RID: 46836
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B6F5 RID: 46837
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6F6 RID: 46838
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001090 RID: 4240
			[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_5+<<MainChallengeLoop>g__Phase3GuestSpawnLoop|42>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060120E6 RID: 73958 RVA: 0x0041F6A8 File Offset: 0x0041D8A8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique()
				{
					Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "<<MainChallengeLoop>g__Phase3GuestSpawnLoop|42>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>1__state");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>2__current");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>4__this");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__waitForSeconds_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<waitForSeconds>5__2");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682358);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682359);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682360);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682361);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682362);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100682363);
				}

				// Token: 0x060120E7 RID: 73959 RVA: 0x0041F79C File Offset: 0x0041D99C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120E8 RID: 73960 RVA: 0x0041F7E4 File Offset: 0x0041D9E4
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120E9 RID: 73961 RVA: 0x0041F818 File Offset: 0x0041DA18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231190, XrefRangeEnd = 231262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E42 RID: 24130
				// (get) Token: 0x060120EA RID: 73962 RVA: 0x0041F854 File Offset: 0x0041DA54
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120EB RID: 73963 RVA: 0x0041F894 File Offset: 0x0041DA94
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231262, XrefRangeEnd = 231268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E43 RID: 24131
				// (get) Token: 0x060120EC RID: 73964 RVA: 0x0041F8C8 File Offset: 0x0041DAC8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120ED RID: 73965 RVA: 0x0009CDF9 File Offset: 0x0009AFF9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E3E RID: 24126
				// (get) Token: 0x060120EE RID: 73966 RVA: 0x0041F908 File Offset: 0x0041DB08
				// (set) Token: 0x060120EF RID: 73967 RVA: 0x0009CE02 File Offset: 0x0009B002
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E3F RID: 24127
				// (get) Token: 0x060120F0 RID: 73968 RVA: 0x0041F930 File Offset: 0x0041DB30
				// (set) Token: 0x060120F1 RID: 73969 RVA: 0x0009CE1D File Offset: 0x0009B01D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E40 RID: 24128
				// (get) Token: 0x060120F2 RID: 73970 RVA: 0x0041F960 File Offset: 0x0041DB60
				// (set) Token: 0x060120F3 RID: 73971 RVA: 0x0009CE3C File Offset: 0x0009B03C
				public unsafe YuyukoBossData.__c__DisplayClass16_5 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_5>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E41 RID: 24129
				// (get) Token: 0x060120F4 RID: 73972 RVA: 0x0041F990 File Offset: 0x0041DB90
				// (set) Token: 0x060120F5 RID: 73973 RVA: 0x0009CE5B File Offset: 0x0009B05B
				public unsafe WaitForSeconds _waitForSeconds_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__waitForSeconds_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__waitForSeconds_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B6F7 RID: 46839
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B6F8 RID: 46840
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B6F9 RID: 46841
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B6FA RID: 46842
				private static readonly IntPtr NativeFieldInfoPtr__waitForSeconds_5__2;

				// Token: 0x0400B6FB RID: 46843
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B6FC RID: 46844
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B6FD RID: 46845
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B6FE RID: 46846
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B6FF RID: 46847
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B700 RID: 46848
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001091 RID: 4241
			[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_5+<<MainChallengeLoop>g__Phase3OrderLoop|51>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x060120F6 RID: 73974 RVA: 0x0041F9C0 File Offset: 0x0041DBC0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5>.NativeClassPtr, "<<MainChallengeLoop>g__Phase3OrderLoop|51>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682364);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682365);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682366);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682367);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682368);
					YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100682369);
				}

				// Token: 0x060120F7 RID: 73975 RVA: 0x0041FAA0 File Offset: 0x0041DCA0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120F8 RID: 73976 RVA: 0x0041FAE8 File Offset: 0x0041DCE8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060120F9 RID: 73977 RVA: 0x0041FB1C File Offset: 0x0041DD1C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231268, XrefRangeEnd = 231299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005E47 RID: 24135
				// (get) Token: 0x060120FA RID: 73978 RVA: 0x0041FB58 File Offset: 0x0041DD58
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120FB RID: 73979 RVA: 0x0041FB98 File Offset: 0x0041DD98
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231299, XrefRangeEnd = 231305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005E48 RID: 24136
				// (get) Token: 0x060120FC RID: 73980 RVA: 0x0041FBCC File Offset: 0x0041DDCC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x060120FD RID: 73981 RVA: 0x0009CE7A File Offset: 0x0009B07A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005E44 RID: 24132
				// (get) Token: 0x060120FE RID: 73982 RVA: 0x0041FC0C File Offset: 0x0041DE0C
				// (set) Token: 0x060120FF RID: 73983 RVA: 0x0009CE83 File Offset: 0x0009B083
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005E45 RID: 24133
				// (get) Token: 0x06012100 RID: 73984 RVA: 0x0041FC34 File Offset: 0x0041DE34
				// (set) Token: 0x06012101 RID: 73985 RVA: 0x0009CE9E File Offset: 0x0009B09E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005E46 RID: 24134
				// (get) Token: 0x06012102 RID: 73986 RVA: 0x0041FC64 File Offset: 0x0041DE64
				// (set) Token: 0x06012103 RID: 73987 RVA: 0x0009CEBD File Offset: 0x0009B0BD
				public unsafe YuyukoBossData.__c__DisplayClass16_5 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_5>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_5.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B701 RID: 46849
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B702 RID: 46850
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B703 RID: 46851
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B704 RID: 46852
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B705 RID: 46853
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B706 RID: 46854
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B707 RID: 46855
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B708 RID: 46856
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B709 RID: 46857
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000D23 RID: 3363
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_6")]
		public sealed class __c__DisplayClass16_6 : Il2CppSystem.Object
		{
			// Token: 0x0600F234 RID: 62004 RVA: 0x003967B8 File Offset: 0x003949B8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_6()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c__DisplayClass16_6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr);
				YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_cookerOrderedResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, "cookerOrderedResult");
				YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_targetType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, "targetType");
				YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_cookerPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, "cookerPosition");
				YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_targets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, "targets");
				YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_field_Public___c__DisplayClass16_5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, "CS$<>8__locals4");
				YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, 100682370);
				YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__MainChallengeLoop_b__61_Internal_Boolean___f__AnonymousType2_2_CookerType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, 100682371);
				YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__MainChallengeLoop_b__62_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, 100682372);
				YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__MainChallengeLoop_b__63_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, 100682373);
				YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__MainChallengeLoop_b__64_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr, 100682374);
			}

			// Token: 0x0600F235 RID: 62005 RVA: 0x003968AC File Offset: 0x00394AAC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_6() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_6>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F236 RID: 62006 RVA: 0x003968E8 File Offset: 0x00394AE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231432, XrefRangeEnd = 231436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__61(__f__AnonymousType2<Cooker.CookerType, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__MainChallengeLoop_b__61_Internal_Boolean___f__AnonymousType2_2_CookerType_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F237 RID: 62007 RVA: 0x00396938 File Offset: 0x00394B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231436, XrefRangeEnd = 231443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__62(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__MainChallengeLoop_b__62_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F238 RID: 62008 RVA: 0x00396984 File Offset: 0x00394B84
			[CallerCount(0)]
			public unsafe Vector3 _MainChallengeLoop_b__63()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__MainChallengeLoop_b__63_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F239 RID: 62009 RVA: 0x003969C0 File Offset: 0x00394BC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231443, XrefRangeEnd = 231447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__64()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_6.NativeMethodInfoPtr__MainChallengeLoop_b__64_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F23A RID: 62010 RVA: 0x00082105 File Offset: 0x00080305
			public __c__DisplayClass16_6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EC4 RID: 20164
			// (get) Token: 0x0600F23B RID: 62011 RVA: 0x003969F4 File Offset: 0x00394BF4
			// (set) Token: 0x0600F23C RID: 62012 RVA: 0x0008210E File Offset: 0x0008030E
			public unsafe Il2CppReferenceArray<__f__AnonymousType2<Cooker.CookerType, int>> cookerOrderedResult
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_cookerOrderedResult);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<__f__AnonymousType2<Cooker.CookerType, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_cookerOrderedResult), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EC5 RID: 20165
			// (get) Token: 0x0600F23D RID: 62013 RVA: 0x00396A24 File Offset: 0x00394C24
			// (set) Token: 0x0600F23E RID: 62014 RVA: 0x0008212D File Offset: 0x0008032D
			public unsafe Cooker.CookerType targetType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_targetType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_targetType)) = value;
				}
			}

			// Token: 0x17004EC6 RID: 20166
			// (get) Token: 0x0600F23F RID: 62015 RVA: 0x00396A4C File Offset: 0x00394C4C
			// (set) Token: 0x0600F240 RID: 62016 RVA: 0x00082148 File Offset: 0x00080348
			public unsafe Vector3Int cookerPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_cookerPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_cookerPosition)) = value;
				}
			}

			// Token: 0x17004EC7 RID: 20167
			// (get) Token: 0x0600F241 RID: 62017 RVA: 0x00396A74 File Offset: 0x00394C74
			// (set) Token: 0x0600F242 RID: 62018 RVA: 0x00082163 File Offset: 0x00080363
			public unsafe IEnumerable<int> targets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_targets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_targets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EC8 RID: 20168
			// (get) Token: 0x0600F243 RID: 62019 RVA: 0x00396AA4 File Offset: 0x00394CA4
			// (set) Token: 0x0600F244 RID: 62020 RVA: 0x00082182 File Offset: 0x00080382
			public unsafe YuyukoBossData.__c__DisplayClass16_5 field_Public___c__DisplayClass16_5_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_field_Public___c__DisplayClass16_5_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_5>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_6.NativeFieldInfoPtr_field_Public___c__DisplayClass16_5_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A55 RID: 39509
			private static readonly IntPtr NativeFieldInfoPtr_cookerOrderedResult;

			// Token: 0x04009A56 RID: 39510
			private static readonly IntPtr NativeFieldInfoPtr_targetType;

			// Token: 0x04009A57 RID: 39511
			private static readonly IntPtr NativeFieldInfoPtr_cookerPosition;

			// Token: 0x04009A58 RID: 39512
			private static readonly IntPtr NativeFieldInfoPtr_targets;

			// Token: 0x04009A59 RID: 39513
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass16_5_0;

			// Token: 0x04009A5A RID: 39514
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A5B RID: 39515
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__61_Internal_Boolean___f__AnonymousType2_2_CookerType_Int32_0;

			// Token: 0x04009A5C RID: 39516
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__62_Internal_Boolean_Int32_0;

			// Token: 0x04009A5D RID: 39517
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__63_Internal_Vector3_0;

			// Token: 0x04009A5E RID: 39518
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__64_Internal_Void_0;
		}

		// Token: 0x02000D24 RID: 3364
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_7")]
		public sealed class __c__DisplayClass16_7 : Il2CppSystem.Object
		{
			// Token: 0x0600F245 RID: 62021 RVA: 0x00396AD4 File Offset: 0x00394CD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_7()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c__DisplayClass16_7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_7>.NativeClassPtr);
				YuyukoBossData.__c__DisplayClass16_7.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_7>.NativeClassPtr, "x");
				YuyukoBossData.__c__DisplayClass16_7.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_7>.NativeClassPtr, 100682375);
				YuyukoBossData.__c__DisplayClass16_7.NativeMethodInfoPtr__MainChallengeLoop_b__67_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_7>.NativeClassPtr, 100682376);
			}

			// Token: 0x0600F246 RID: 62022 RVA: 0x00396B3C File Offset: 0x00394D3C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_7() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_7>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_7.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F247 RID: 62023 RVA: 0x00396B78 File Offset: 0x00394D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231447, XrefRangeEnd = 231451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__67()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_7.NativeMethodInfoPtr__MainChallengeLoop_b__67_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F248 RID: 62024 RVA: 0x000821A1 File Offset: 0x000803A1
			public __c__DisplayClass16_7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EC9 RID: 20169
			// (get) Token: 0x0600F249 RID: 62025 RVA: 0x00396BAC File Offset: 0x00394DAC
			// (set) Token: 0x0600F24A RID: 62026 RVA: 0x000821AA File Offset: 0x000803AA
			public unsafe GameObject x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_7.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_7.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A5F RID: 39519
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04009A60 RID: 39520
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A61 RID: 39521
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__67_Internal_Void_0;
		}

		// Token: 0x02000D25 RID: 3365
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c__DisplayClass16_8")]
		public sealed class __c__DisplayClass16_8 : Il2CppSystem.Object
		{
			// Token: 0x0600F24B RID: 62027 RVA: 0x00396BDC File Offset: 0x00394DDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_8()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c__DisplayClass16_8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_8>.NativeClassPtr);
				YuyukoBossData.__c__DisplayClass16_8.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_8>.NativeClassPtr, "group");
				YuyukoBossData.__c__DisplayClass16_8.NativeFieldInfoPtr_field_Public___c__DisplayClass16_5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_8>.NativeClassPtr, "CS$<>8__locals5");
				YuyukoBossData.__c__DisplayClass16_8.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_8>.NativeClassPtr, 100682377);
				YuyukoBossData.__c__DisplayClass16_8.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_8>.NativeClassPtr, 100682378);
			}

			// Token: 0x0600F24C RID: 62028 RVA: 0x00396C58 File Offset: 0x00394E58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_8() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c__DisplayClass16_8>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_8.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F24D RID: 62029 RVA: 0x00396C94 File Offset: 0x00394E94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231451, XrefRangeEnd = 231474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0(GuestGroupController.EvaluationResult lastResult, GuestGroupController thisGuestGroup, bool oldComboProtect, out string message, out bool comboProtect)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c__DisplayClass16_8.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				message = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600F24E RID: 62030 RVA: 0x000821C9 File Offset: 0x000803C9
			public __c__DisplayClass16_8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004ECA RID: 20170
			// (get) Token: 0x0600F24F RID: 62031 RVA: 0x00396D28 File Offset: 0x00394F28
			// (set) Token: 0x0600F250 RID: 62032 RVA: 0x000821D2 File Offset: 0x000803D2
			public unsafe SpecialGuestsController group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_8.NativeFieldInfoPtr_group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_8.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ECB RID: 20171
			// (get) Token: 0x0600F251 RID: 62033 RVA: 0x00396D58 File Offset: 0x00394F58
			// (set) Token: 0x0600F252 RID: 62034 RVA: 0x000821F1 File Offset: 0x000803F1
			public unsafe YuyukoBossData.__c__DisplayClass16_5 field_Public___c__DisplayClass16_5_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_8.NativeFieldInfoPtr_field_Public___c__DisplayClass16_5_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_5>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData.__c__DisplayClass16_8.NativeFieldInfoPtr_field_Public___c__DisplayClass16_5_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A62 RID: 39522
			private static readonly IntPtr NativeFieldInfoPtr_group;

			// Token: 0x04009A63 RID: 39523
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass16_5_0;

			// Token: 0x04009A64 RID: 39524
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A65 RID: 39525
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0;
		}

		// Token: 0x02000D26 RID: 3366
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600F253 RID: 62035 RVA: 0x00396D88 File Offset: 0x00394F88
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr);
				YuyukoBossData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_0");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_1");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_26");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_6");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_28");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_13");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_14");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_30");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_38 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_38");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_65 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_65");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_57 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_57");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_58 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_58");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_59 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_59");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_60 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_60");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_66 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_66");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_68 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_68");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_70 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_70");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_43 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_43");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_45 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_45");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_47 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_47");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_53 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_53");
				YuyukoBossData.__c.NativeFieldInfoPtr___9__16_24 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, "<>9__16_24");
				YuyukoBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682380);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_0_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682381);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_1_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682382);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_6_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682383);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_26_Internal_Il2CppStructArray_1_Int32_NormalGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682384);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_13_Internal_IEnumerable_1_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682385);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_28_Internal_Int32_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682386);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_14_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682387);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_30_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682388);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_38_Internal_Boolean_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682389);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_65_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682390);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_57_Internal_CookController_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682391);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_58_Internal_CookerType_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682392);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_59_Internal_Int32_IGrouping_2_CookerType_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682393);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_60_Internal___f__AnonymousType2_2_CookerType_Int32_IGrouping_2_CookerType_CookController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682394);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_66_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682395);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_68_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682396);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_70_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682397);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_43_Internal_Sellable_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682398);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_45_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682399);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_47_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682400);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_53_Internal_Boolean_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682401);
				YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_24_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr, 100682402);
			}

			// Token: 0x0600F254 RID: 62036 RVA: 0x0039714C File Offset: 0x0039534C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F255 RID: 62037 RVA: 0x00397188 File Offset: 0x00395388
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__16_0(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_0_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F256 RID: 62038 RVA: 0x003971D4 File Offset: 0x003953D4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__16_1(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_1_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F257 RID: 62039 RVA: 0x00397220 File Offset: 0x00395420
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231474, XrefRangeEnd = 231493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Il2CppStructArray<int>> _MainChallengeLoop_b__16_6(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_6_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppStructArray<int>>>(intPtr3) : null;
			}

			// Token: 0x0600F258 RID: 62040 RVA: 0x00397270 File Offset: 0x00395470
			[CallerCount(0)]
			public unsafe Il2CppStructArray<int> _MainChallengeLoop_b__16_26(Izakaya.NormalGuestGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_26_Internal_Il2CppStructArray_1_Int32_NormalGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}

			// Token: 0x0600F259 RID: 62041 RVA: 0x003972C0 File Offset: 0x003954C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231493, XrefRangeEnd = 231526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _MainChallengeLoop_b__16_13(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_13_Internal_IEnumerable_1_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600F25A RID: 62042 RVA: 0x00397310 File Offset: 0x00395510
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__16_28(Izakaya.SpecialGuestGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_28_Internal_Int32_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F25B RID: 62043 RVA: 0x00397360 File Offset: 0x00395560
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231526, XrefRangeEnd = 231533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__16_14(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_14_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F25C RID: 62044 RVA: 0x003973AC File Offset: 0x003955AC
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__16_30(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_30_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F25D RID: 62045 RVA: 0x003973FC File Offset: 0x003955FC
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__16_38(CookController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_38_Internal_Boolean_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F25E RID: 62046 RVA: 0x0039744C File Offset: 0x0039564C
			[CallerCount(0)]
			public unsafe IEnumerable<int> _MainChallengeLoop_b__16_65(IEnumerable<int> y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_65_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600F25F RID: 62047 RVA: 0x0039749C File Offset: 0x0039569C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231533, XrefRangeEnd = 231540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CookController _MainChallengeLoop_b__16_57(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_57_Internal_CookController_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CookController>(intPtr3) : null;
			}

			// Token: 0x0600F260 RID: 62048 RVA: 0x003974E8 File Offset: 0x003956E8
			[CallerCount(0)]
			public unsafe Cooker.CookerType _MainChallengeLoop_b__16_58(CookController item)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_58_Internal_CookerType_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F261 RID: 62049 RVA: 0x00397538 File Offset: 0x00395738
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231540, XrefRangeEnd = 231543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__16_59(IGrouping<Cooker.CookerType, CookController> cookerTypeNum)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookerTypeNum);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_59_Internal_Int32_IGrouping_2_CookerType_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F262 RID: 62050 RVA: 0x00397588 File Offset: 0x00395788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231543, XrefRangeEnd = 231555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __f__AnonymousType2<Cooker.CookerType, int> _MainChallengeLoop_b__16_60(IGrouping<Cooker.CookerType, CookController> cookerTypeNum)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cookerTypeNum);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_60_Internal___f__AnonymousType2_2_CookerType_Int32_IGrouping_2_CookerType_CookController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<__f__AnonymousType2<Cooker.CookerType, int>>(intPtr3) : null;
			}

			// Token: 0x0600F263 RID: 62051 RVA: 0x003975D8 File Offset: 0x003957D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231555, XrefRangeEnd = 231575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__16_66(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_66_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F264 RID: 62052 RVA: 0x0039761C File Offset: 0x0039581C
			[CallerCount(0)]
			public unsafe string _MainChallengeLoop_b__16_68(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_68_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F265 RID: 62053 RVA: 0x00397664 File Offset: 0x00395864
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231575, XrefRangeEnd = 231579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__16_70(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_70_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F266 RID: 62054 RVA: 0x003976A8 File Offset: 0x003958A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231579, XrefRangeEnd = 231581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sellable _MainChallengeLoop_b__16_43(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_43_Internal_Sellable_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr3) : null;
			}

			// Token: 0x0600F267 RID: 62055 RVA: 0x003976F8 File Offset: 0x003958F8
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__16_45(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_45_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F268 RID: 62056 RVA: 0x00397748 File Offset: 0x00395948
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__16_47(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_47_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F269 RID: 62057 RVA: 0x00397798 File Offset: 0x00395998
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__16_53(Coroutine x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_53_Internal_Boolean_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F26A RID: 62058 RVA: 0x003977E8 File Offset: 0x003959E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231581, XrefRangeEnd = 231590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__16_24()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__16_24_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F26B RID: 62059 RVA: 0x00082210 File Offset: 0x00080410
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004ECC RID: 20172
			// (get) Token: 0x0600F26C RID: 62060 RVA: 0x0039781C File Offset: 0x00395A1C
			// (set) Token: 0x0600F26D RID: 62061 RVA: 0x00082219 File Offset: 0x00080419
			public unsafe static YuyukoBossData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ECD RID: 20173
			// (get) Token: 0x0600F26E RID: 62062 RVA: 0x00397844 File Offset: 0x00395A44
			// (set) Token: 0x0600F26F RID: 62063 RVA: 0x0008222B File Offset: 0x0008042B
			public unsafe static Func<Vector2Int, int> __9__16_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ECE RID: 20174
			// (get) Token: 0x0600F270 RID: 62064 RVA: 0x0039786C File Offset: 0x00395A6C
			// (set) Token: 0x0600F271 RID: 62065 RVA: 0x0008223D File Offset: 0x0008043D
			public unsafe static Func<Vector2Int, int> __9__16_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ECF RID: 20175
			// (get) Token: 0x0600F272 RID: 62066 RVA: 0x00397894 File Offset: 0x00395A94
			// (set) Token: 0x0600F273 RID: 62067 RVA: 0x0008224F File Offset: 0x0008044F
			public unsafe static Func<Izakaya.NormalGuestGroup, Il2CppStructArray<int>> __9__16_26
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_26, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.NormalGuestGroup, Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_26, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED0 RID: 20176
			// (get) Token: 0x0600F274 RID: 62068 RVA: 0x003978BC File Offset: 0x00395ABC
			// (set) Token: 0x0600F275 RID: 62069 RVA: 0x00082261 File Offset: 0x00080461
			public unsafe static Func<Izakaya, IEnumerable<Il2CppStructArray<int>>> __9__16_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, IEnumerable<Il2CppStructArray<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED1 RID: 20177
			// (get) Token: 0x0600F276 RID: 62070 RVA: 0x003978E4 File Offset: 0x00395AE4
			// (set) Token: 0x0600F277 RID: 62071 RVA: 0x00082273 File Offset: 0x00080473
			public unsafe static Func<Izakaya.SpecialGuestGroup, int> __9__16_28
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_28, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.SpecialGuestGroup, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_28, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED2 RID: 20178
			// (get) Token: 0x0600F278 RID: 62072 RVA: 0x0039790C File Offset: 0x00395B0C
			// (set) Token: 0x0600F279 RID: 62073 RVA: 0x00082285 File Offset: 0x00080485
			public unsafe static Func<Izakaya, IEnumerable<int>> __9__16_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED3 RID: 20179
			// (get) Token: 0x0600F27A RID: 62074 RVA: 0x00397934 File Offset: 0x00395B34
			// (set) Token: 0x0600F27B RID: 62075 RVA: 0x00082297 File Offset: 0x00080497
			public unsafe static Func<int, bool> __9__16_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED4 RID: 20180
			// (get) Token: 0x0600F27C RID: 62076 RVA: 0x0039795C File Offset: 0x00395B5C
			// (set) Token: 0x0600F27D RID: 62077 RVA: 0x000822A9 File Offset: 0x000804A9
			public unsafe static Func<GuestGroupController, bool> __9__16_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED5 RID: 20181
			// (get) Token: 0x0600F27E RID: 62078 RVA: 0x00397984 File Offset: 0x00395B84
			// (set) Token: 0x0600F27F RID: 62079 RVA: 0x000822BB File Offset: 0x000804BB
			public unsafe static Func<CookController, bool> __9__16_38
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_38, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_38, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED6 RID: 20182
			// (get) Token: 0x0600F280 RID: 62080 RVA: 0x003979AC File Offset: 0x00395BAC
			// (set) Token: 0x0600F281 RID: 62081 RVA: 0x000822CD File Offset: 0x000804CD
			public unsafe static Func<IEnumerable<int>, IEnumerable<int>> __9__16_65
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_65, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IEnumerable<int>, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_65, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED7 RID: 20183
			// (get) Token: 0x0600F282 RID: 62082 RVA: 0x003979D4 File Offset: 0x00395BD4
			// (set) Token: 0x0600F283 RID: 62083 RVA: 0x000822DF File Offset: 0x000804DF
			public unsafe static Func<int, CookController> __9__16_57
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_57, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, CookController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_57, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED8 RID: 20184
			// (get) Token: 0x0600F284 RID: 62084 RVA: 0x003979FC File Offset: 0x00395BFC
			// (set) Token: 0x0600F285 RID: 62085 RVA: 0x000822F1 File Offset: 0x000804F1
			public unsafe static Func<CookController, Cooker.CookerType> __9__16_58
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_58, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CookController, Cooker.CookerType>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_58, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004ED9 RID: 20185
			// (get) Token: 0x0600F286 RID: 62086 RVA: 0x00397A24 File Offset: 0x00395C24
			// (set) Token: 0x0600F287 RID: 62087 RVA: 0x00082303 File Offset: 0x00080503
			public unsafe static Func<IGrouping<Cooker.CookerType, CookController>, int> __9__16_59
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_59, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<Cooker.CookerType, CookController>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_59, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EDA RID: 20186
			// (get) Token: 0x0600F288 RID: 62088 RVA: 0x00397A4C File Offset: 0x00395C4C
			// (set) Token: 0x0600F289 RID: 62089 RVA: 0x00082315 File Offset: 0x00080515
			public unsafe static Func<IGrouping<Cooker.CookerType, CookController>, __f__AnonymousType2<Cooker.CookerType, int>> __9__16_60
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_60, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGrouping<Cooker.CookerType, CookController>, __f__AnonymousType2<Cooker.CookerType, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_60, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EDB RID: 20187
			// (get) Token: 0x0600F28A RID: 62090 RVA: 0x00397A74 File Offset: 0x00395C74
			// (set) Token: 0x0600F28B RID: 62091 RVA: 0x00082327 File Offset: 0x00080527
			public unsafe static Action<GameObject> __9__16_66
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_66, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_66, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EDC RID: 20188
			// (get) Token: 0x0600F28C RID: 62092 RVA: 0x00397A9C File Offset: 0x00395C9C
			// (set) Token: 0x0600F28D RID: 62093 RVA: 0x00082339 File Offset: 0x00080539
			public unsafe static Func<string, string> __9__16_68
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_68, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_68, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EDD RID: 20189
			// (get) Token: 0x0600F28E RID: 62094 RVA: 0x00397AC4 File Offset: 0x00395CC4
			// (set) Token: 0x0600F28F RID: 62095 RVA: 0x0008234B File Offset: 0x0008054B
			public unsafe static Action<GuestGroupController> __9__16_70
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_70, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_70, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EDE RID: 20190
			// (get) Token: 0x0600F290 RID: 62096 RVA: 0x00397AEC File Offset: 0x00395CEC
			// (set) Token: 0x0600F291 RID: 62097 RVA: 0x0008235D File Offset: 0x0008055D
			public unsafe static Func<Recipe, Sellable> __9__16_43
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_43, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, Sellable>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_43, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EDF RID: 20191
			// (get) Token: 0x0600F292 RID: 62098 RVA: 0x00397B14 File Offset: 0x00395D14
			// (set) Token: 0x0600F293 RID: 62099 RVA: 0x0008236F File Offset: 0x0008056F
			public unsafe static Func<Sellable, int> __9__16_45
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_45, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_45, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EE0 RID: 20192
			// (get) Token: 0x0600F294 RID: 62100 RVA: 0x00397B3C File Offset: 0x00395D3C
			// (set) Token: 0x0600F295 RID: 62101 RVA: 0x00082381 File Offset: 0x00080581
			public unsafe static Func<Sellable, int> __9__16_47
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_47, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_47, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EE1 RID: 20193
			// (get) Token: 0x0600F296 RID: 62102 RVA: 0x00397B64 File Offset: 0x00395D64
			// (set) Token: 0x0600F297 RID: 62103 RVA: 0x00082393 File Offset: 0x00080593
			public unsafe static Func<Coroutine, bool> __9__16_53
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_53, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Coroutine, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_53, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EE2 RID: 20194
			// (get) Token: 0x0600F298 RID: 62104 RVA: 0x00397B8C File Offset: 0x00395D8C
			// (set) Token: 0x0600F299 RID: 62105 RVA: 0x000823A5 File Offset: 0x000805A5
			public unsafe static Action __9__16_24
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_24, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(YuyukoBossData.__c.NativeFieldInfoPtr___9__16_24, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A66 RID: 39526
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009A67 RID: 39527
			private static readonly IntPtr NativeFieldInfoPtr___9__16_0;

			// Token: 0x04009A68 RID: 39528
			private static readonly IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x04009A69 RID: 39529
			private static readonly IntPtr NativeFieldInfoPtr___9__16_26;

			// Token: 0x04009A6A RID: 39530
			private static readonly IntPtr NativeFieldInfoPtr___9__16_6;

			// Token: 0x04009A6B RID: 39531
			private static readonly IntPtr NativeFieldInfoPtr___9__16_28;

			// Token: 0x04009A6C RID: 39532
			private static readonly IntPtr NativeFieldInfoPtr___9__16_13;

			// Token: 0x04009A6D RID: 39533
			private static readonly IntPtr NativeFieldInfoPtr___9__16_14;

			// Token: 0x04009A6E RID: 39534
			private static readonly IntPtr NativeFieldInfoPtr___9__16_30;

			// Token: 0x04009A6F RID: 39535
			private static readonly IntPtr NativeFieldInfoPtr___9__16_38;

			// Token: 0x04009A70 RID: 39536
			private static readonly IntPtr NativeFieldInfoPtr___9__16_65;

			// Token: 0x04009A71 RID: 39537
			private static readonly IntPtr NativeFieldInfoPtr___9__16_57;

			// Token: 0x04009A72 RID: 39538
			private static readonly IntPtr NativeFieldInfoPtr___9__16_58;

			// Token: 0x04009A73 RID: 39539
			private static readonly IntPtr NativeFieldInfoPtr___9__16_59;

			// Token: 0x04009A74 RID: 39540
			private static readonly IntPtr NativeFieldInfoPtr___9__16_60;

			// Token: 0x04009A75 RID: 39541
			private static readonly IntPtr NativeFieldInfoPtr___9__16_66;

			// Token: 0x04009A76 RID: 39542
			private static readonly IntPtr NativeFieldInfoPtr___9__16_68;

			// Token: 0x04009A77 RID: 39543
			private static readonly IntPtr NativeFieldInfoPtr___9__16_70;

			// Token: 0x04009A78 RID: 39544
			private static readonly IntPtr NativeFieldInfoPtr___9__16_43;

			// Token: 0x04009A79 RID: 39545
			private static readonly IntPtr NativeFieldInfoPtr___9__16_45;

			// Token: 0x04009A7A RID: 39546
			private static readonly IntPtr NativeFieldInfoPtr___9__16_47;

			// Token: 0x04009A7B RID: 39547
			private static readonly IntPtr NativeFieldInfoPtr___9__16_53;

			// Token: 0x04009A7C RID: 39548
			private static readonly IntPtr NativeFieldInfoPtr___9__16_24;

			// Token: 0x04009A7D RID: 39549
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009A7E RID: 39550
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_0_Internal_Int32_Vector2Int_0;

			// Token: 0x04009A7F RID: 39551
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_1_Internal_Int32_Vector2Int_0;

			// Token: 0x04009A80 RID: 39552
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_6_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_Izakaya_0;

			// Token: 0x04009A81 RID: 39553
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_26_Internal_Il2CppStructArray_1_Int32_NormalGuestGroup_0;

			// Token: 0x04009A82 RID: 39554
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_13_Internal_IEnumerable_1_Int32_Izakaya_0;

			// Token: 0x04009A83 RID: 39555
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_28_Internal_Int32_SpecialGuestGroup_0;

			// Token: 0x04009A84 RID: 39556
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_14_Internal_Boolean_Int32_0;

			// Token: 0x04009A85 RID: 39557
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_30_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04009A86 RID: 39558
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_38_Internal_Boolean_CookController_0;

			// Token: 0x04009A87 RID: 39559
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_65_Internal_IEnumerable_1_Int32_IEnumerable_1_Int32_0;

			// Token: 0x04009A88 RID: 39560
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_57_Internal_CookController_Int32_0;

			// Token: 0x04009A89 RID: 39561
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_58_Internal_CookerType_CookController_0;

			// Token: 0x04009A8A RID: 39562
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_59_Internal_Int32_IGrouping_2_CookerType_CookController_0;

			// Token: 0x04009A8B RID: 39563
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_60_Internal___f__AnonymousType2_2_CookerType_Int32_IGrouping_2_CookerType_CookController_0;

			// Token: 0x04009A8C RID: 39564
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_66_Internal_Void_GameObject_0;

			// Token: 0x04009A8D RID: 39565
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_68_Internal_String_String_0;

			// Token: 0x04009A8E RID: 39566
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_70_Internal_Void_GuestGroupController_0;

			// Token: 0x04009A8F RID: 39567
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_43_Internal_Sellable_Recipe_0;

			// Token: 0x04009A90 RID: 39568
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_45_Internal_Int32_Sellable_0;

			// Token: 0x04009A91 RID: 39569
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_47_Internal_Int32_Sellable_0;

			// Token: 0x04009A92 RID: 39570
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_53_Internal_Boolean_Coroutine_0;

			// Token: 0x04009A93 RID: 39571
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__16_24_Internal_Void_0;
		}

		// Token: 0x02000D27 RID: 3367
		[ObfuscatedName("GameData.Profile.YuyukoBossData+<MainChallengeLoop>d__16")]
		public sealed class _MainChallengeLoop_d__16 : Il2CppSystem.Object
		{
			// Token: 0x0600F29A RID: 62106 RVA: 0x00397BB4 File Offset: 0x00395DB4
			// Note: this type is marked as 'beforefieldinit'.
			static _MainChallengeLoop_d__16()
			{
				Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoBossData>.NativeClassPtr, "<MainChallengeLoop>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr);
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<>1__state");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<>2__current");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<>4__this");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "bossDataContext");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<>8__1");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___8__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<>8__2");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___8__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<>8__3");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__isRetake_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<isRetake>5__2");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__allIzakayas_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<allIzakayas>5__3");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__statusDisplayerTransition_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<statusDisplayerTransition>5__4");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__ptc_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<ptc>5__5");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__mainLoop_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<mainLoop>5__6");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__negativeSpellLoop_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<negativeSpellLoop>5__7");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__yuyukoGuestData_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<yuyukoGuestData>5__8");
				YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__standSpawnLoop_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, "<standSpawnLoop>5__9");
				YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, 100682403);
				YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, 100682404);
				YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, 100682405);
				YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, 100682406);
				YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, 100682407);
				YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr, 100682408);
			}

			// Token: 0x0600F29B RID: 62107 RVA: 0x00397D84 File Offset: 0x00395F84
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MainChallengeLoop_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoBossData._MainChallengeLoop_d__16>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F29C RID: 62108 RVA: 0x00397DCC File Offset: 0x00395FCC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F29D RID: 62109 RVA: 0x00397E00 File Offset: 0x00396000
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231590, XrefRangeEnd = 232283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004EF2 RID: 20210
			// (get) Token: 0x0600F29E RID: 62110 RVA: 0x00397E3C File Offset: 0x0039603C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F29F RID: 62111 RVA: 0x00397E7C File Offset: 0x0039607C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232283, XrefRangeEnd = 232289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004EF3 RID: 20211
			// (get) Token: 0x0600F2A0 RID: 62112 RVA: 0x00397EB0 File Offset: 0x003960B0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoBossData._MainChallengeLoop_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600F2A1 RID: 62113 RVA: 0x000823B7 File Offset: 0x000805B7
			public _MainChallengeLoop_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004EE3 RID: 20195
			// (get) Token: 0x0600F2A2 RID: 62114 RVA: 0x00397EF0 File Offset: 0x003960F0
			// (set) Token: 0x0600F2A3 RID: 62115 RVA: 0x000823C0 File Offset: 0x000805C0
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004EE4 RID: 20196
			// (get) Token: 0x0600F2A4 RID: 62116 RVA: 0x00397F18 File Offset: 0x00396118
			// (set) Token: 0x0600F2A5 RID: 62117 RVA: 0x000823DB File Offset: 0x000805DB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EE5 RID: 20197
			// (get) Token: 0x0600F2A6 RID: 62118 RVA: 0x00397F48 File Offset: 0x00396148
			// (set) Token: 0x0600F2A7 RID: 62119 RVA: 0x000823FA File Offset: 0x000805FA
			public unsafe YuyukoBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EE6 RID: 20198
			// (get) Token: 0x0600F2A8 RID: 62120 RVA: 0x00397F78 File Offset: 0x00396178
			// (set) Token: 0x0600F2A9 RID: 62121 RVA: 0x00082419 File Offset: 0x00080619
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004EE7 RID: 20199
			// (get) Token: 0x0600F2AA RID: 62122 RVA: 0x00397FA8 File Offset: 0x003961A8
			// (set) Token: 0x0600F2AB RID: 62123 RVA: 0x00082447 File Offset: 0x00080647
			public unsafe YuyukoBossData.__c__DisplayClass16_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EE8 RID: 20200
			// (get) Token: 0x0600F2AC RID: 62124 RVA: 0x00397FD8 File Offset: 0x003961D8
			// (set) Token: 0x0600F2AD RID: 62125 RVA: 0x00082466 File Offset: 0x00080666
			public unsafe YuyukoBossData.__c__DisplayClass16_4 __8__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___8__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_4>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___8__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EE9 RID: 20201
			// (get) Token: 0x0600F2AE RID: 62126 RVA: 0x00398008 File Offset: 0x00396208
			// (set) Token: 0x0600F2AF RID: 62127 RVA: 0x00082485 File Offset: 0x00080685
			public unsafe YuyukoBossData.__c__DisplayClass16_5 __8__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___8__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoBossData.__c__DisplayClass16_5>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr___8__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EEA RID: 20202
			// (get) Token: 0x0600F2B0 RID: 62128 RVA: 0x00398038 File Offset: 0x00396238
			// (set) Token: 0x0600F2B1 RID: 62129 RVA: 0x000824A4 File Offset: 0x000806A4
			public unsafe bool _isRetake_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__isRetake_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__isRetake_5__2)) = value;
				}
			}

			// Token: 0x17004EEB RID: 20203
			// (get) Token: 0x0600F2B2 RID: 62130 RVA: 0x00398060 File Offset: 0x00396260
			// (set) Token: 0x0600F2B3 RID: 62131 RVA: 0x000824BF File Offset: 0x000806BF
			public unsafe IEnumerable<Izakaya> _allIzakayas_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__allIzakayas_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<Izakaya>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__allIzakayas_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EEC RID: 20204
			// (get) Token: 0x0600F2B4 RID: 62132 RVA: 0x00398090 File Offset: 0x00396290
			// (set) Token: 0x0600F2B5 RID: 62133 RVA: 0x000824DE File Offset: 0x000806DE
			public unsafe CanvasGroup _statusDisplayerTransition_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__statusDisplayerTransition_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__statusDisplayerTransition_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EED RID: 20205
			// (get) Token: 0x0600F2B6 RID: 62134 RVA: 0x003980C0 File Offset: 0x003962C0
			// (set) Token: 0x0600F2B7 RID: 62135 RVA: 0x000824FD File Offset: 0x000806FD
			public unsafe PannelTransitionController _ptc_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__ptc_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PannelTransitionController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__ptc_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EEE RID: 20206
			// (get) Token: 0x0600F2B8 RID: 62136 RVA: 0x003980F0 File Offset: 0x003962F0
			// (set) Token: 0x0600F2B9 RID: 62137 RVA: 0x0008251C File Offset: 0x0008071C
			public unsafe Coroutine _mainLoop_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__mainLoop_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__mainLoop_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EEF RID: 20207
			// (get) Token: 0x0600F2BA RID: 62138 RVA: 0x00398120 File Offset: 0x00396320
			// (set) Token: 0x0600F2BB RID: 62139 RVA: 0x0008253B File Offset: 0x0008073B
			public unsafe Coroutine _negativeSpellLoop_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__negativeSpellLoop_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__negativeSpellLoop_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EF0 RID: 20208
			// (get) Token: 0x0600F2BC RID: 62140 RVA: 0x00398150 File Offset: 0x00396350
			// (set) Token: 0x0600F2BD RID: 62141 RVA: 0x0008255A File Offset: 0x0008075A
			public unsafe SpecialGuest _yuyukoGuestData_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__yuyukoGuestData_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__yuyukoGuestData_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004EF1 RID: 20209
			// (get) Token: 0x0600F2BE RID: 62142 RVA: 0x00398180 File Offset: 0x00396380
			// (set) Token: 0x0600F2BF RID: 62143 RVA: 0x00082579 File Offset: 0x00080779
			public unsafe Coroutine _standSpawnLoop_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__standSpawnLoop_5__9);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoBossData._MainChallengeLoop_d__16.NativeFieldInfoPtr__standSpawnLoop_5__9), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009A94 RID: 39572
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009A95 RID: 39573
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009A96 RID: 39574
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009A97 RID: 39575
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x04009A98 RID: 39576
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04009A99 RID: 39577
			private static readonly IntPtr NativeFieldInfoPtr___8__2;

			// Token: 0x04009A9A RID: 39578
			private static readonly IntPtr NativeFieldInfoPtr___8__3;

			// Token: 0x04009A9B RID: 39579
			private static readonly IntPtr NativeFieldInfoPtr__isRetake_5__2;

			// Token: 0x04009A9C RID: 39580
			private static readonly IntPtr NativeFieldInfoPtr__allIzakayas_5__3;

			// Token: 0x04009A9D RID: 39581
			private static readonly IntPtr NativeFieldInfoPtr__statusDisplayerTransition_5__4;

			// Token: 0x04009A9E RID: 39582
			private static readonly IntPtr NativeFieldInfoPtr__ptc_5__5;

			// Token: 0x04009A9F RID: 39583
			private static readonly IntPtr NativeFieldInfoPtr__mainLoop_5__6;

			// Token: 0x04009AA0 RID: 39584
			private static readonly IntPtr NativeFieldInfoPtr__negativeSpellLoop_5__7;

			// Token: 0x04009AA1 RID: 39585
			private static readonly IntPtr NativeFieldInfoPtr__yuyukoGuestData_5__8;

			// Token: 0x04009AA2 RID: 39586
			private static readonly IntPtr NativeFieldInfoPtr__standSpawnLoop_5__9;

			// Token: 0x04009AA3 RID: 39587
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009AA4 RID: 39588
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009AA5 RID: 39589
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04009AA6 RID: 39590
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009AA7 RID: 39591
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009AA8 RID: 39592
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
