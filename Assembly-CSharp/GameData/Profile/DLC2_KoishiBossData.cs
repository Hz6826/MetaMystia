using System;
using Common.CharacterUtility;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.CookingUtility;
using NightScene.EventUtility;
using NightScene.GuestManagementUtility;
using NightScene.UI;
using NightScene.UI.HUDUtility;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

namespace GameData.Profile
{
	// Token: 0x020002F7 RID: 759
	public class DLC2_KoishiBossData : BossData
	{
		// Token: 0x06005AC5 RID: 23237 RVA: 0x001CE104 File Offset: 0x001CC304
		// Note: this type is marked as 'beforefieldinit'.
		static DLC2_KoishiBossData()
		{
			Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DLC2_KoishiBossData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr);
			DLC2_KoishiBossData.NativeFieldInfoPtr_KOISHI_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "KOISHI_ID");
			DLC2_KoishiBossData.NativeFieldInfoPtr_koishidata = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "koishidata");
			DLC2_KoishiBossData.NativeFieldInfoPtr_koishiDataNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "koishiDataNormal");
			DLC2_KoishiBossData.NativeFieldInfoPtr_koishiDataHard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "koishiDataHard");
			DLC2_KoishiBossData.NativeFieldInfoPtr_koishiDataLunatic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "koishiDataLunatic");
			DLC2_KoishiBossData.NativeFieldInfoPtr_satoriColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "satoriColor");
			DLC2_KoishiBossData.NativeFieldInfoPtr_koishiColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "koishiColor");
			DLC2_KoishiBossData.NativeFieldInfoPtr_tipEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "tipEffect");
			DLC2_KoishiBossData.NativeFieldInfoPtr_waveEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "waveEffect");
			DLC2_KoishiBossData.NativeFieldInfoPtr_hideSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "hideSFX");
			DLC2_KoishiBossData.NativeFieldInfoPtr_radiusShake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "radiusShake");
			DLC2_KoishiBossData.NativeFieldInfoPtr_waitForGuestLeaveDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "waitForGuestLeaveDelay");
			DLC2_KoishiBossData.NativeMethodInfoPtr_GetBossData_Private_KoishiBossData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, 100681603);
			DLC2_KoishiBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, 100681604);
			DLC2_KoishiBossData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, 100681605);
			DLC2_KoishiBossData.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_byref_Int32_byref___c__DisplayClass12_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, 100681606);
		}

		// Token: 0x06005AC6 RID: 23238 RVA: 0x001CE274 File Offset: 0x001CC474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224514, XrefRangeEnd = 224614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC2_KoishiBossData.KoishiBossData GetBossData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.NativeMethodInfoPtr_GetBossData_Private_KoishiBossData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new DLC2_KoishiBossData.KoishiBossData(pointer);
		}

		// Token: 0x06005AC7 RID: 23239 RVA: 0x001CE2AC File Offset: 0x001CC4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224614, XrefRangeEnd = 224620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator MainChallengeLoop(BossData.BossDataContext bossDataContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(bossDataContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC2_KoishiBossData.NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005AC8 RID: 23240 RVA: 0x001CE30C File Offset: 0x001CC50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224620, XrefRangeEnd = 224621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC2_KoishiBossData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005AC9 RID: 23241 RVA: 0x001CE348 File Offset: 0x001CC548
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 224631, RefRangeEnd = 224658, XrefRangeStart = 224621, XrefRangeEnd = 224631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Method_Internal_Static_Boolean_Int32_byref_Int32_byref___c__DisplayClass12_0_0(int lineId, out int finalNum, ref DLC2_KoishiBossData.__c__DisplayClass12_0 A_2)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineId;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &finalNum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_byref_Int32_byref___c__DisplayClass12_0_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005ACA RID: 23242 RVA: 0x000311D2 File Offset: 0x0002F3D2
		public DLC2_KoishiBossData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06005ACB RID: 23243 RVA: 0x001CE3A8 File Offset: 0x001CC5A8
		// (set) Token: 0x06005ACC RID: 23244 RVA: 0x000311DB File Offset: 0x0002F3DB
		public unsafe static int KOISHI_ID
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.NativeFieldInfoPtr_KOISHI_ID, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.NativeFieldInfoPtr_KOISHI_ID, (void*)(&value));
			}
		}

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06005ACD RID: 23245 RVA: 0x001CE3C4 File Offset: 0x001CC5C4
		// (set) Token: 0x06005ACE RID: 23246 RVA: 0x000311E9 File Offset: 0x0002F3E9
		public DLC2_KoishiBossData.KoishiBossData koishidata
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishidata);
				return new DLC2_KoishiBossData.KoishiBossData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishidata), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06005ACF RID: 23247 RVA: 0x001CE3F4 File Offset: 0x001CC5F4
		// (set) Token: 0x06005AD0 RID: 23248 RVA: 0x00031217 File Offset: 0x0002F417
		public DLC2_KoishiBossData.KoishiBossData koishiDataNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishiDataNormal);
				return new DLC2_KoishiBossData.KoishiBossData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishiDataNormal), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06005AD1 RID: 23249 RVA: 0x001CE424 File Offset: 0x001CC624
		// (set) Token: 0x06005AD2 RID: 23250 RVA: 0x00031245 File Offset: 0x0002F445
		public DLC2_KoishiBossData.KoishiBossData koishiDataHard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishiDataHard);
				return new DLC2_KoishiBossData.KoishiBossData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishiDataHard), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06005AD3 RID: 23251 RVA: 0x001CE454 File Offset: 0x001CC654
		// (set) Token: 0x06005AD4 RID: 23252 RVA: 0x00031273 File Offset: 0x0002F473
		public DLC2_KoishiBossData.KoishiBossData koishiDataLunatic
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishiDataLunatic);
				return new DLC2_KoishiBossData.KoishiBossData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishiDataLunatic), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x06005AD5 RID: 23253 RVA: 0x001CE484 File Offset: 0x001CC684
		// (set) Token: 0x06005AD6 RID: 23254 RVA: 0x000312A1 File Offset: 0x0002F4A1
		public unsafe Color satoriColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_satoriColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_satoriColor)) = value;
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x06005AD7 RID: 23255 RVA: 0x001CE4AC File Offset: 0x001CC6AC
		// (set) Token: 0x06005AD8 RID: 23256 RVA: 0x000312BC File Offset: 0x0002F4BC
		public unsafe Color koishiColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishiColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_koishiColor)) = value;
			}
		}

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x06005AD9 RID: 23257 RVA: 0x001CE4D4 File Offset: 0x001CC6D4
		// (set) Token: 0x06005ADA RID: 23258 RVA: 0x000312D7 File Offset: 0x0002F4D7
		public unsafe GameObject tipEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_tipEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_tipEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x06005ADB RID: 23259 RVA: 0x001CE504 File Offset: 0x001CC704
		// (set) Token: 0x06005ADC RID: 23260 RVA: 0x000312F6 File Offset: 0x0002F4F6
		public unsafe GameObject waveEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_waveEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_waveEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x06005ADD RID: 23261 RVA: 0x001CE534 File Offset: 0x001CC734
		// (set) Token: 0x06005ADE RID: 23262 RVA: 0x00031315 File Offset: 0x0002F515
		public unsafe AudioClip hideSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_hideSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_hideSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x06005ADF RID: 23263 RVA: 0x001CE564 File Offset: 0x001CC764
		// (set) Token: 0x06005AE0 RID: 23264 RVA: 0x00031334 File Offset: 0x0002F534
		public unsafe float radiusShake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_radiusShake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_radiusShake)) = value;
			}
		}

		// Token: 0x17001F56 RID: 8022
		// (get) Token: 0x06005AE1 RID: 23265 RVA: 0x001CE58C File Offset: 0x001CC78C
		// (set) Token: 0x06005AE2 RID: 23266 RVA: 0x0003134F File Offset: 0x0002F54F
		public unsafe float waitForGuestLeaveDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_waitForGuestLeaveDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.NativeFieldInfoPtr_waitForGuestLeaveDelay)) = value;
			}
		}

		// Token: 0x04003C5B RID: 15451
		private static readonly IntPtr NativeFieldInfoPtr_KOISHI_ID;

		// Token: 0x04003C5C RID: 15452
		private static readonly IntPtr NativeFieldInfoPtr_koishidata;

		// Token: 0x04003C5D RID: 15453
		private static readonly IntPtr NativeFieldInfoPtr_koishiDataNormal;

		// Token: 0x04003C5E RID: 15454
		private static readonly IntPtr NativeFieldInfoPtr_koishiDataHard;

		// Token: 0x04003C5F RID: 15455
		private static readonly IntPtr NativeFieldInfoPtr_koishiDataLunatic;

		// Token: 0x04003C60 RID: 15456
		private static readonly IntPtr NativeFieldInfoPtr_satoriColor;

		// Token: 0x04003C61 RID: 15457
		private static readonly IntPtr NativeFieldInfoPtr_koishiColor;

		// Token: 0x04003C62 RID: 15458
		private static readonly IntPtr NativeFieldInfoPtr_tipEffect;

		// Token: 0x04003C63 RID: 15459
		private static readonly IntPtr NativeFieldInfoPtr_waveEffect;

		// Token: 0x04003C64 RID: 15460
		private static readonly IntPtr NativeFieldInfoPtr_hideSFX;

		// Token: 0x04003C65 RID: 15461
		private static readonly IntPtr NativeFieldInfoPtr_radiusShake;

		// Token: 0x04003C66 RID: 15462
		private static readonly IntPtr NativeFieldInfoPtr_waitForGuestLeaveDelay;

		// Token: 0x04003C67 RID: 15463
		private static readonly IntPtr NativeMethodInfoPtr_GetBossData_Private_KoishiBossData_0;

		// Token: 0x04003C68 RID: 15464
		private static readonly IntPtr NativeMethodInfoPtr_MainChallengeLoop_Public_Virtual_IEnumerator_BossDataContext_0;

		// Token: 0x04003C69 RID: 15465
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003C6A RID: 15466
		private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_Boolean_Int32_byref_Int32_byref___c__DisplayClass12_0_0;

		// Token: 0x02000CC8 RID: 3272
		[Serializable]
		public sealed class KoishiBossData : ValueType
		{
			// Token: 0x0600EAA1 RID: 60065 RVA: 0x003808C8 File Offset: 0x0037EAC8
			// Note: this type is marked as 'beforefieldinit'.
			static KoishiBossData()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "KoishiBossData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr);
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiBadgeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "koishiBadgeId");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiPhase1Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "koishiPhase1Time");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase1TargetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "phase1TargetScore");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_izakayaIndexArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "izakayaIndexArray");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_basicBaseFundRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "basicBaseFundRange");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_basicNormalGuestInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "basicNormalGuestInterval");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_closedKoishiEyeObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "closedKoishiEyeObject");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiPhase2Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "koishiPhase2Time");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase2TargetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "phase2TargetScore");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_wackyFoodTagPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "wackyFoodTagPool");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_banGuestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "banGuestId");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_satisfy1TagScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "satisfy1TagScore");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_notSatisfyTagScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "notSatisfyTagScore");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_tagRefreshTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "tagRefreshTime");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase2SpecialGuestInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "phase2SpecialGuestInterval");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiPhase3Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "koishiPhase3Time");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase3TargetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "phase3TargetScore");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_unconsciousTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "unconsciousTime");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_durationPerWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "durationPerWave");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_maxDamagePerWave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "maxDamagePerWave");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_lockHeartRecoverHp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "lockHeartRecoverHp");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_preferTagType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "preferTagType");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_levelToDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "levelToDamage");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_maxTimeTobreakShield = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "maxTimeTobreakShield");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase3TagRefreshTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "phase3TagRefreshTime");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "icon");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_iconSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "iconSprites");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_likeFoodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "likeFoodTag");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_hateFoodTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "hateFoodTag");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_likeBevTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "likeBevTag");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_highLightEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "highLightEffect");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_noHopeFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "noHopeFace");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_breakEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "breakEffect");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase3BanTagPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "phase3BanTagPool");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_ghostCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "ghostCharacter");
				DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_ghostCharacterEyes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, "ghostCharacterEyes");
			}

			// Token: 0x0600EAA2 RID: 60066 RVA: 0x0007D84D File Offset: 0x0007BA4D
			public KoishiBossData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600EAA3 RID: 60067 RVA: 0x0007D856 File Offset: 0x0007BA56
			public KoishiBossData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr))
			{
			}

			// Token: 0x17004C42 RID: 19522
			// (get) Token: 0x0600EAA4 RID: 60068 RVA: 0x00380BC4 File Offset: 0x0037EDC4
			// (set) Token: 0x0600EAA5 RID: 60069 RVA: 0x0007D868 File Offset: 0x0007BA68
			public unsafe int koishiBadgeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiBadgeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiBadgeId)) = value;
				}
			}

			// Token: 0x17004C43 RID: 19523
			// (get) Token: 0x0600EAA6 RID: 60070 RVA: 0x00380BEC File Offset: 0x0037EDEC
			// (set) Token: 0x0600EAA7 RID: 60071 RVA: 0x0007D883 File Offset: 0x0007BA83
			public unsafe int koishiPhase1Time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiPhase1Time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiPhase1Time)) = value;
				}
			}

			// Token: 0x17004C44 RID: 19524
			// (get) Token: 0x0600EAA8 RID: 60072 RVA: 0x00380C14 File Offset: 0x0037EE14
			// (set) Token: 0x0600EAA9 RID: 60073 RVA: 0x0007D89E File Offset: 0x0007BA9E
			public unsafe int phase1TargetScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase1TargetScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase1TargetScore)) = value;
				}
			}

			// Token: 0x17004C45 RID: 19525
			// (get) Token: 0x0600EAAA RID: 60074 RVA: 0x00380C3C File Offset: 0x0037EE3C
			// (set) Token: 0x0600EAAB RID: 60075 RVA: 0x0007D8B9 File Offset: 0x0007BAB9
			public unsafe Il2CppStructArray<int> izakayaIndexArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_izakayaIndexArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_izakayaIndexArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C46 RID: 19526
			// (get) Token: 0x0600EAAC RID: 60076 RVA: 0x00380C6C File Offset: 0x0037EE6C
			// (set) Token: 0x0600EAAD RID: 60077 RVA: 0x0007D8D8 File Offset: 0x0007BAD8
			public unsafe Vector2Int basicBaseFundRange
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_basicBaseFundRange);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_basicBaseFundRange)) = value;
				}
			}

			// Token: 0x17004C47 RID: 19527
			// (get) Token: 0x0600EAAE RID: 60078 RVA: 0x00380C94 File Offset: 0x0037EE94
			// (set) Token: 0x0600EAAF RID: 60079 RVA: 0x0007D8F3 File Offset: 0x0007BAF3
			public unsafe Vector2Int basicNormalGuestInterval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_basicNormalGuestInterval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_basicNormalGuestInterval)) = value;
				}
			}

			// Token: 0x17004C48 RID: 19528
			// (get) Token: 0x0600EAB0 RID: 60080 RVA: 0x00380CBC File Offset: 0x0037EEBC
			// (set) Token: 0x0600EAB1 RID: 60081 RVA: 0x0007D90E File Offset: 0x0007BB0E
			public unsafe Sprite closedKoishiEyeObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_closedKoishiEyeObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_closedKoishiEyeObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C49 RID: 19529
			// (get) Token: 0x0600EAB2 RID: 60082 RVA: 0x00380CEC File Offset: 0x0037EEEC
			// (set) Token: 0x0600EAB3 RID: 60083 RVA: 0x0007D92D File Offset: 0x0007BB2D
			public unsafe int koishiPhase2Time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiPhase2Time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiPhase2Time)) = value;
				}
			}

			// Token: 0x17004C4A RID: 19530
			// (get) Token: 0x0600EAB4 RID: 60084 RVA: 0x00380D14 File Offset: 0x0037EF14
			// (set) Token: 0x0600EAB5 RID: 60085 RVA: 0x0007D948 File Offset: 0x0007BB48
			public unsafe int phase2TargetScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase2TargetScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase2TargetScore)) = value;
				}
			}

			// Token: 0x17004C4B RID: 19531
			// (get) Token: 0x0600EAB6 RID: 60086 RVA: 0x00380D3C File Offset: 0x0037EF3C
			// (set) Token: 0x0600EAB7 RID: 60087 RVA: 0x0007D963 File Offset: 0x0007BB63
			public unsafe Il2CppStructArray<int> wackyFoodTagPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_wackyFoodTagPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_wackyFoodTagPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C4C RID: 19532
			// (get) Token: 0x0600EAB8 RID: 60088 RVA: 0x00380D6C File Offset: 0x0037EF6C
			// (set) Token: 0x0600EAB9 RID: 60089 RVA: 0x0007D982 File Offset: 0x0007BB82
			public unsafe Il2CppStructArray<int> banGuestId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_banGuestId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_banGuestId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C4D RID: 19533
			// (get) Token: 0x0600EABA RID: 60090 RVA: 0x00380D9C File Offset: 0x0037EF9C
			// (set) Token: 0x0600EABB RID: 60091 RVA: 0x0007D9A1 File Offset: 0x0007BBA1
			public unsafe int satisfy1TagScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_satisfy1TagScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_satisfy1TagScore)) = value;
				}
			}

			// Token: 0x17004C4E RID: 19534
			// (get) Token: 0x0600EABC RID: 60092 RVA: 0x00380DC4 File Offset: 0x0037EFC4
			// (set) Token: 0x0600EABD RID: 60093 RVA: 0x0007D9BC File Offset: 0x0007BBBC
			public unsafe int notSatisfyTagScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_notSatisfyTagScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_notSatisfyTagScore)) = value;
				}
			}

			// Token: 0x17004C4F RID: 19535
			// (get) Token: 0x0600EABE RID: 60094 RVA: 0x00380DEC File Offset: 0x0037EFEC
			// (set) Token: 0x0600EABF RID: 60095 RVA: 0x0007D9D7 File Offset: 0x0007BBD7
			public unsafe int tagRefreshTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_tagRefreshTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_tagRefreshTime)) = value;
				}
			}

			// Token: 0x17004C50 RID: 19536
			// (get) Token: 0x0600EAC0 RID: 60096 RVA: 0x00380E14 File Offset: 0x0037F014
			// (set) Token: 0x0600EAC1 RID: 60097 RVA: 0x0007D9F2 File Offset: 0x0007BBF2
			public unsafe Vector2Int phase2SpecialGuestInterval
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase2SpecialGuestInterval);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase2SpecialGuestInterval)) = value;
				}
			}

			// Token: 0x17004C51 RID: 19537
			// (get) Token: 0x0600EAC2 RID: 60098 RVA: 0x00380E3C File Offset: 0x0037F03C
			// (set) Token: 0x0600EAC3 RID: 60099 RVA: 0x0007DA0D File Offset: 0x0007BC0D
			public unsafe int koishiPhase3Time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiPhase3Time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_koishiPhase3Time)) = value;
				}
			}

			// Token: 0x17004C52 RID: 19538
			// (get) Token: 0x0600EAC4 RID: 60100 RVA: 0x00380E64 File Offset: 0x0037F064
			// (set) Token: 0x0600EAC5 RID: 60101 RVA: 0x0007DA28 File Offset: 0x0007BC28
			public unsafe int phase3TargetScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase3TargetScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase3TargetScore)) = value;
				}
			}

			// Token: 0x17004C53 RID: 19539
			// (get) Token: 0x0600EAC6 RID: 60102 RVA: 0x00380E8C File Offset: 0x0037F08C
			// (set) Token: 0x0600EAC7 RID: 60103 RVA: 0x0007DA43 File Offset: 0x0007BC43
			public unsafe int unconsciousTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_unconsciousTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_unconsciousTime)) = value;
				}
			}

			// Token: 0x17004C54 RID: 19540
			// (get) Token: 0x0600EAC8 RID: 60104 RVA: 0x00380EB4 File Offset: 0x0037F0B4
			// (set) Token: 0x0600EAC9 RID: 60105 RVA: 0x0007DA5E File Offset: 0x0007BC5E
			public unsafe int durationPerWave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_durationPerWave);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_durationPerWave)) = value;
				}
			}

			// Token: 0x17004C55 RID: 19541
			// (get) Token: 0x0600EACA RID: 60106 RVA: 0x00380EDC File Offset: 0x0037F0DC
			// (set) Token: 0x0600EACB RID: 60107 RVA: 0x0007DA79 File Offset: 0x0007BC79
			public unsafe int maxDamagePerWave
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_maxDamagePerWave);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_maxDamagePerWave)) = value;
				}
			}

			// Token: 0x17004C56 RID: 19542
			// (get) Token: 0x0600EACC RID: 60108 RVA: 0x00380F04 File Offset: 0x0037F104
			// (set) Token: 0x0600EACD RID: 60109 RVA: 0x0007DA94 File Offset: 0x0007BC94
			public unsafe int lockHeartRecoverHp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_lockHeartRecoverHp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_lockHeartRecoverHp)) = value;
				}
			}

			// Token: 0x17004C57 RID: 19543
			// (get) Token: 0x0600EACE RID: 60110 RVA: 0x00380F2C File Offset: 0x0037F12C
			// (set) Token: 0x0600EACF RID: 60111 RVA: 0x0007DAAF File Offset: 0x0007BCAF
			public unsafe Vector3Int preferTagType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_preferTagType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_preferTagType)) = value;
				}
			}

			// Token: 0x17004C58 RID: 19544
			// (get) Token: 0x0600EAD0 RID: 60112 RVA: 0x00380F54 File Offset: 0x0037F154
			// (set) Token: 0x0600EAD1 RID: 60113 RVA: 0x0007DACA File Offset: 0x0007BCCA
			public unsafe Il2CppStructArray<Vector2Int> levelToDamage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_levelToDamage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_levelToDamage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C59 RID: 19545
			// (get) Token: 0x0600EAD2 RID: 60114 RVA: 0x00380F84 File Offset: 0x0037F184
			// (set) Token: 0x0600EAD3 RID: 60115 RVA: 0x0007DAE9 File Offset: 0x0007BCE9
			public unsafe int maxTimeTobreakShield
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_maxTimeTobreakShield);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_maxTimeTobreakShield)) = value;
				}
			}

			// Token: 0x17004C5A RID: 19546
			// (get) Token: 0x0600EAD4 RID: 60116 RVA: 0x00380FAC File Offset: 0x0037F1AC
			// (set) Token: 0x0600EAD5 RID: 60117 RVA: 0x0007DB04 File Offset: 0x0007BD04
			public unsafe int phase3TagRefreshTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase3TagRefreshTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase3TagRefreshTime)) = value;
				}
			}

			// Token: 0x17004C5B RID: 19547
			// (get) Token: 0x0600EAD6 RID: 60118 RVA: 0x00380FD4 File Offset: 0x0037F1D4
			// (set) Token: 0x0600EAD7 RID: 60119 RVA: 0x0007DB1F File Offset: 0x0007BD1F
			public unsafe GameObject icon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_icon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_icon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C5C RID: 19548
			// (get) Token: 0x0600EAD8 RID: 60120 RVA: 0x00381004 File Offset: 0x0037F204
			// (set) Token: 0x0600EAD9 RID: 60121 RVA: 0x0007DB3E File Offset: 0x0007BD3E
			public unsafe Il2CppReferenceArray<Sprite> iconSprites
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_iconSprites);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Sprite>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_iconSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C5D RID: 19549
			// (get) Token: 0x0600EADA RID: 60122 RVA: 0x00381034 File Offset: 0x0037F234
			// (set) Token: 0x0600EADB RID: 60123 RVA: 0x0007DB5D File Offset: 0x0007BD5D
			public unsafe GameObject likeFoodTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_likeFoodTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_likeFoodTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C5E RID: 19550
			// (get) Token: 0x0600EADC RID: 60124 RVA: 0x00381064 File Offset: 0x0037F264
			// (set) Token: 0x0600EADD RID: 60125 RVA: 0x0007DB7C File Offset: 0x0007BD7C
			public unsafe GameObject hateFoodTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_hateFoodTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_hateFoodTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C5F RID: 19551
			// (get) Token: 0x0600EADE RID: 60126 RVA: 0x00381094 File Offset: 0x0037F294
			// (set) Token: 0x0600EADF RID: 60127 RVA: 0x0007DB9B File Offset: 0x0007BD9B
			public unsafe GameObject likeBevTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_likeBevTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_likeBevTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C60 RID: 19552
			// (get) Token: 0x0600EAE0 RID: 60128 RVA: 0x003810C4 File Offset: 0x0037F2C4
			// (set) Token: 0x0600EAE1 RID: 60129 RVA: 0x0007DBBA File Offset: 0x0007BDBA
			public unsafe GameObject highLightEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_highLightEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_highLightEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C61 RID: 19553
			// (get) Token: 0x0600EAE2 RID: 60130 RVA: 0x003810F4 File Offset: 0x0037F2F4
			// (set) Token: 0x0600EAE3 RID: 60131 RVA: 0x0007DBD9 File Offset: 0x0007BDD9
			public unsafe Sprite noHopeFace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_noHopeFace);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_noHopeFace), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C62 RID: 19554
			// (get) Token: 0x0600EAE4 RID: 60132 RVA: 0x00381124 File Offset: 0x0037F324
			// (set) Token: 0x0600EAE5 RID: 60133 RVA: 0x0007DBF8 File Offset: 0x0007BDF8
			public unsafe GameObject breakEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_breakEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_breakEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C63 RID: 19555
			// (get) Token: 0x0600EAE6 RID: 60134 RVA: 0x00381154 File Offset: 0x0037F354
			// (set) Token: 0x0600EAE7 RID: 60135 RVA: 0x0007DC17 File Offset: 0x0007BE17
			public unsafe Il2CppStructArray<int> phase3BanTagPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase3BanTagPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_phase3BanTagPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C64 RID: 19556
			// (get) Token: 0x0600EAE8 RID: 60136 RVA: 0x00381184 File Offset: 0x0037F384
			// (set) Token: 0x0600EAE9 RID: 60137 RVA: 0x0007DC36 File Offset: 0x0007BE36
			public unsafe Material ghostCharacter
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_ghostCharacter);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_ghostCharacter), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C65 RID: 19557
			// (get) Token: 0x0600EAEA RID: 60138 RVA: 0x003811B4 File Offset: 0x0037F3B4
			// (set) Token: 0x0600EAEB RID: 60139 RVA: 0x0007DC55 File Offset: 0x0007BE55
			public unsafe Material ghostCharacterEyes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_ghostCharacterEyes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.KoishiBossData.NativeFieldInfoPtr_ghostCharacterEyes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095A3 RID: 38307
			private static readonly IntPtr NativeFieldInfoPtr_koishiBadgeId;

			// Token: 0x040095A4 RID: 38308
			private static readonly IntPtr NativeFieldInfoPtr_koishiPhase1Time;

			// Token: 0x040095A5 RID: 38309
			private static readonly IntPtr NativeFieldInfoPtr_phase1TargetScore;

			// Token: 0x040095A6 RID: 38310
			private static readonly IntPtr NativeFieldInfoPtr_izakayaIndexArray;

			// Token: 0x040095A7 RID: 38311
			private static readonly IntPtr NativeFieldInfoPtr_basicBaseFundRange;

			// Token: 0x040095A8 RID: 38312
			private static readonly IntPtr NativeFieldInfoPtr_basicNormalGuestInterval;

			// Token: 0x040095A9 RID: 38313
			private static readonly IntPtr NativeFieldInfoPtr_closedKoishiEyeObject;

			// Token: 0x040095AA RID: 38314
			private static readonly IntPtr NativeFieldInfoPtr_koishiPhase2Time;

			// Token: 0x040095AB RID: 38315
			private static readonly IntPtr NativeFieldInfoPtr_phase2TargetScore;

			// Token: 0x040095AC RID: 38316
			private static readonly IntPtr NativeFieldInfoPtr_wackyFoodTagPool;

			// Token: 0x040095AD RID: 38317
			private static readonly IntPtr NativeFieldInfoPtr_banGuestId;

			// Token: 0x040095AE RID: 38318
			private static readonly IntPtr NativeFieldInfoPtr_satisfy1TagScore;

			// Token: 0x040095AF RID: 38319
			private static readonly IntPtr NativeFieldInfoPtr_notSatisfyTagScore;

			// Token: 0x040095B0 RID: 38320
			private static readonly IntPtr NativeFieldInfoPtr_tagRefreshTime;

			// Token: 0x040095B1 RID: 38321
			private static readonly IntPtr NativeFieldInfoPtr_phase2SpecialGuestInterval;

			// Token: 0x040095B2 RID: 38322
			private static readonly IntPtr NativeFieldInfoPtr_koishiPhase3Time;

			// Token: 0x040095B3 RID: 38323
			private static readonly IntPtr NativeFieldInfoPtr_phase3TargetScore;

			// Token: 0x040095B4 RID: 38324
			private static readonly IntPtr NativeFieldInfoPtr_unconsciousTime;

			// Token: 0x040095B5 RID: 38325
			private static readonly IntPtr NativeFieldInfoPtr_durationPerWave;

			// Token: 0x040095B6 RID: 38326
			private static readonly IntPtr NativeFieldInfoPtr_maxDamagePerWave;

			// Token: 0x040095B7 RID: 38327
			private static readonly IntPtr NativeFieldInfoPtr_lockHeartRecoverHp;

			// Token: 0x040095B8 RID: 38328
			private static readonly IntPtr NativeFieldInfoPtr_preferTagType;

			// Token: 0x040095B9 RID: 38329
			private static readonly IntPtr NativeFieldInfoPtr_levelToDamage;

			// Token: 0x040095BA RID: 38330
			private static readonly IntPtr NativeFieldInfoPtr_maxTimeTobreakShield;

			// Token: 0x040095BB RID: 38331
			private static readonly IntPtr NativeFieldInfoPtr_phase3TagRefreshTime;

			// Token: 0x040095BC RID: 38332
			private static readonly IntPtr NativeFieldInfoPtr_icon;

			// Token: 0x040095BD RID: 38333
			private static readonly IntPtr NativeFieldInfoPtr_iconSprites;

			// Token: 0x040095BE RID: 38334
			private static readonly IntPtr NativeFieldInfoPtr_likeFoodTag;

			// Token: 0x040095BF RID: 38335
			private static readonly IntPtr NativeFieldInfoPtr_hateFoodTag;

			// Token: 0x040095C0 RID: 38336
			private static readonly IntPtr NativeFieldInfoPtr_likeBevTag;

			// Token: 0x040095C1 RID: 38337
			private static readonly IntPtr NativeFieldInfoPtr_highLightEffect;

			// Token: 0x040095C2 RID: 38338
			private static readonly IntPtr NativeFieldInfoPtr_noHopeFace;

			// Token: 0x040095C3 RID: 38339
			private static readonly IntPtr NativeFieldInfoPtr_breakEffect;

			// Token: 0x040095C4 RID: 38340
			private static readonly IntPtr NativeFieldInfoPtr_phase3BanTagPool;

			// Token: 0x040095C5 RID: 38341
			private static readonly IntPtr NativeFieldInfoPtr_ghostCharacter;

			// Token: 0x040095C6 RID: 38342
			private static readonly IntPtr NativeFieldInfoPtr_ghostCharacterEyes;
		}

		// Token: 0x02000CC9 RID: 3273
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : ValueType
		{
			// Token: 0x0600EAEC RID: 60140 RVA: 0x0007DC74 File Offset: 0x0007BE74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass12_0>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass12_0.NativeFieldInfoPtr_lines = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass12_0>.NativeClassPtr, "lines");
			}

			// Token: 0x0600EAED RID: 60141 RVA: 0x0007DCA8 File Offset: 0x0007BEA8
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600EAEE RID: 60142 RVA: 0x0007DCB1 File Offset: 0x0007BEB1
			public __c__DisplayClass12_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass12_0>.NativeClassPtr))
			{
			}

			// Token: 0x17004C66 RID: 19558
			// (get) Token: 0x0600EAEF RID: 60143 RVA: 0x003811E4 File Offset: 0x0037F3E4
			// (set) Token: 0x0600EAF0 RID: 60144 RVA: 0x0007DCC3 File Offset: 0x0007BEC3
			public unsafe Il2CppStringArray lines
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass12_0.NativeFieldInfoPtr_lines);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass12_0.NativeFieldInfoPtr_lines), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095C7 RID: 38343
			private static readonly IntPtr NativeFieldInfoPtr_lines;
		}

		// Token: 0x02000CCA RID: 3274
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600EAF1 RID: 60145 RVA: 0x00381214 File Offset: 0x0037F414
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr);
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__12_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__12_1");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_4");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_63 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_63");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_64 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_64");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_6");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_66 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_66");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_68 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_68");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_69 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_69");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_70 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_70");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_15 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_15");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_25 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_25");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_26 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_26");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_27 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_27");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_28 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_28");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_29 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_29");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_30 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_30");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_32 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_32");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_33 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_33");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_34 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_34");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_35 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_35");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_36 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_36");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_37 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_37");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_38 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_38");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_78 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_78");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_91 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_91");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_94 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_94");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_111 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_111");
				DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_56 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, "<>9__13_56");
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681608);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__GetBossData_b__12_1_Internal_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681609);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_4_Internal_IEnumerable_1_NormalGuestGroup_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681610);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_63_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681611);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_6_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_Izakaya_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681612);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_64_Internal_Il2CppStructArray_1_Int32_NormalGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681613);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_66_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681614);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_68_Internal_IEnumerable_1_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681615);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_69_Internal_IEnumerable_1_Int32_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681616);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_70_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681617);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_15_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681618);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_25_Internal_GameObject_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681619);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_26_Internal_IEnumerable_1_SpriteRenderer_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681620);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_27_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681621);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_28_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681622);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_29_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681623);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_30_Internal_Int32_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681624);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_32_Internal_Int32_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681625);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_33_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681626);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_34_Internal_Int32_KeyValuePair_2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681627);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_35_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681628);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_36_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681629);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_37_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681630);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_38_Internal_Int32_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681631);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_78_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681632);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_91_Internal_Void_ValueTuple_2_UIElementCluster_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681633);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_94_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681634);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_111_Internal_Boolean_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681635);
				DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_56_Internal_Boolean_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr, 100681636);
			}

			// Token: 0x0600EAF2 RID: 60146 RVA: 0x003816C8 File Offset: 0x0037F8C8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EAF3 RID: 60147 RVA: 0x00381704 File Offset: 0x0037F904
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221975, XrefRangeEnd = 221976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetBossData_b__12_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__GetBossData_b__12_1_Internal_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EAF4 RID: 60148 RVA: 0x00381754 File Offset: 0x0037F954
			[CallerCount(0)]
			public unsafe IEnumerable<Izakaya.NormalGuestGroup> _MainChallengeLoop_b__13_4(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_4_Internal_IEnumerable_1_NormalGuestGroup_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Izakaya.NormalGuestGroup>>(intPtr3) : null;
			}

			// Token: 0x0600EAF5 RID: 60149 RVA: 0x003817A4 File Offset: 0x0037F9A4
			[CallerCount(0)]
			public unsafe string _MainChallengeLoop_b__13_63(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_63_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EAF6 RID: 60150 RVA: 0x003817EC File Offset: 0x0037F9EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221976, XrefRangeEnd = 221995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<Il2CppStructArray<int>> _MainChallengeLoop_b__13_6(Izakaya x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_6_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_Izakaya_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Il2CppStructArray<int>>>(intPtr3) : null;
			}

			// Token: 0x0600EAF7 RID: 60151 RVA: 0x0038183C File Offset: 0x0037FA3C
			[CallerCount(0)]
			public unsafe Il2CppStructArray<int> _MainChallengeLoop_b__13_64(Izakaya.NormalGuestGroup y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_64_Internal_Il2CppStructArray_1_Int32_NormalGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
			}

			// Token: 0x0600EAF8 RID: 60152 RVA: 0x0038188C File Offset: 0x0037FA8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221995, XrefRangeEnd = 221997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__13_66(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_66_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EAF9 RID: 60153 RVA: 0x003818D4 File Offset: 0x0037FAD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _MainChallengeLoop_b__13_68(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_68_Internal_IEnumerable_1_Int32_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600EAFA RID: 60154 RVA: 0x00381924 File Offset: 0x0037FB24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<int> _MainChallengeLoop_b__13_69(NormalGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_69_Internal_IEnumerable_1_Int32_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr3) : null;
			}

			// Token: 0x0600EAFB RID: 60155 RVA: 0x00381974 File Offset: 0x0037FB74
			[CallerCount(0)]
			public unsafe string _MainChallengeLoop_b__13_70(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_70_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EAFC RID: 60156 RVA: 0x003819BC File Offset: 0x0037FBBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 221997, XrefRangeEnd = 222007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__13_15(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_15_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EAFD RID: 60157 RVA: 0x00381A08 File Offset: 0x0037FC08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222007, XrefRangeEnd = 222013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GameObject _MainChallengeLoop_b__13_25(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_25_Internal_GameObject_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}

			// Token: 0x0600EAFE RID: 60158 RVA: 0x00381A54 File Offset: 0x0037FC54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222013, XrefRangeEnd = 222017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerable<SpriteRenderer> _MainChallengeLoop_b__13_26(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_26_Internal_IEnumerable_1_SpriteRenderer_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<SpriteRenderer>>(intPtr3) : null;
			}

			// Token: 0x0600EAFF RID: 60159 RVA: 0x00381AA4 File Offset: 0x0037FCA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222017, XrefRangeEnd = 222023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__13_27(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_27_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB00 RID: 60160 RVA: 0x00381AF4 File Offset: 0x0037FCF4
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__13_28(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_28_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB01 RID: 60161 RVA: 0x00381B44 File Offset: 0x0037FD44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222023, XrefRangeEnd = 222026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__13_29(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_29_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB02 RID: 60162 RVA: 0x00381B94 File Offset: 0x0037FD94
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__13_30(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_30_Internal_Int32_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB03 RID: 60163 RVA: 0x00381BE4 File Offset: 0x0037FDE4
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__13_32(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_32_Internal_Int32_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB04 RID: 60164 RVA: 0x00381C34 File Offset: 0x0037FE34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222026, XrefRangeEnd = 222030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__13_33(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_33_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB05 RID: 60165 RVA: 0x00381C80 File Offset: 0x0037FE80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222030, XrefRangeEnd = 222031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__13_34(KeyValuePair<int, string> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_34_Internal_Int32_KeyValuePair_2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB06 RID: 60166 RVA: 0x00381CD4 File Offset: 0x0037FED4
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__13_35(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_35_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB07 RID: 60167 RVA: 0x00381D20 File Offset: 0x0037FF20
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__13_36(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_36_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB08 RID: 60168 RVA: 0x00381D6C File Offset: 0x0037FF6C
			[CallerCount(0)]
			public unsafe int _MainChallengeLoop_b__13_37(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_37_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB09 RID: 60169 RVA: 0x00381DB8 File Offset: 0x0037FFB8
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 2790, RefRangeEnd = 2793, XrefRangeStart = 2790, XrefRangeEnd = 2793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _MainChallengeLoop_b__13_38(Vector2Int y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref y;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_38_Internal_Int32_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB0A RID: 60170 RVA: 0x00381E04 File Offset: 0x00380004
			[CallerCount(0)]
			public unsafe string _MainChallengeLoop_b__13_78(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_78_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EB0B RID: 60171 RVA: 0x00381E4C File Offset: 0x0038004C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222031, XrefRangeEnd = 222050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__13_91(ValueTuple<UIElementCluster, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_91_Internal_Void_ValueTuple_2_UIElementCluster_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB0C RID: 60172 RVA: 0x00381E94 File Offset: 0x00380094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222050, XrefRangeEnd = 222053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__13_94(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_94_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB0D RID: 60173 RVA: 0x00381ED8 File Offset: 0x003800D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222053, XrefRangeEnd = 222054, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__13_111(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_111_Internal_Boolean_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB0E RID: 60174 RVA: 0x00381F28 File Offset: 0x00380128
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__13_56(Coroutine x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c.NativeMethodInfoPtr__MainChallengeLoop_b__13_56_Internal_Boolean_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB0F RID: 60175 RVA: 0x0007DCE2 File Offset: 0x0007BEE2
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C67 RID: 19559
			// (get) Token: 0x0600EB10 RID: 60176 RVA: 0x00381F78 File Offset: 0x00380178
			// (set) Token: 0x0600EB11 RID: 60177 RVA: 0x0007DCEB File Offset: 0x0007BEEB
			public unsafe static DLC2_KoishiBossData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C68 RID: 19560
			// (get) Token: 0x0600EB12 RID: 60178 RVA: 0x00381FA0 File Offset: 0x003801A0
			// (set) Token: 0x0600EB13 RID: 60179 RVA: 0x0007DCFD File Offset: 0x0007BEFD
			public unsafe static Func<string, int> __9__12_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__12_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__12_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C69 RID: 19561
			// (get) Token: 0x0600EB14 RID: 60180 RVA: 0x00381FC8 File Offset: 0x003801C8
			// (set) Token: 0x0600EB15 RID: 60181 RVA: 0x0007DD0F File Offset: 0x0007BF0F
			public unsafe static Func<Izakaya, IEnumerable<Izakaya.NormalGuestGroup>> __9__13_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, IEnumerable<Izakaya.NormalGuestGroup>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C6A RID: 19562
			// (get) Token: 0x0600EB16 RID: 60182 RVA: 0x00381FF0 File Offset: 0x003801F0
			// (set) Token: 0x0600EB17 RID: 60183 RVA: 0x0007DD21 File Offset: 0x0007BF21
			public unsafe static Func<string, string> __9__13_63
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_63, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_63, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C6B RID: 19563
			// (get) Token: 0x0600EB18 RID: 60184 RVA: 0x00382018 File Offset: 0x00380218
			// (set) Token: 0x0600EB19 RID: 60185 RVA: 0x0007DD33 File Offset: 0x0007BF33
			public unsafe static Func<Izakaya.NormalGuestGroup, Il2CppStructArray<int>> __9__13_64
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_64, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya.NormalGuestGroup, Il2CppStructArray<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_64, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C6C RID: 19564
			// (get) Token: 0x0600EB1A RID: 60186 RVA: 0x00382040 File Offset: 0x00380240
			// (set) Token: 0x0600EB1B RID: 60187 RVA: 0x0007DD45 File Offset: 0x0007BF45
			public unsafe static Func<Izakaya, IEnumerable<Il2CppStructArray<int>>> __9__13_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Izakaya, IEnumerable<Il2CppStructArray<int>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C6D RID: 19565
			// (get) Token: 0x0600EB1C RID: 60188 RVA: 0x00382068 File Offset: 0x00380268
			// (set) Token: 0x0600EB1D RID: 60189 RVA: 0x0007DD57 File Offset: 0x0007BF57
			public unsafe static Func<string, string> __9__13_66
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_66, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_66, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C6E RID: 19566
			// (get) Token: 0x0600EB1E RID: 60190 RVA: 0x00382090 File Offset: 0x00380290
			// (set) Token: 0x0600EB1F RID: 60191 RVA: 0x0007DD69 File Offset: 0x0007BF69
			public unsafe static Func<NormalGuest, IEnumerable<int>> __9__13_68
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_68, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_68, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C6F RID: 19567
			// (get) Token: 0x0600EB20 RID: 60192 RVA: 0x003820B8 File Offset: 0x003802B8
			// (set) Token: 0x0600EB21 RID: 60193 RVA: 0x0007DD7B File Offset: 0x0007BF7B
			public unsafe static Func<NormalGuest, IEnumerable<int>> __9__13_69
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_69, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NormalGuest, IEnumerable<int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_69, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C70 RID: 19568
			// (get) Token: 0x0600EB22 RID: 60194 RVA: 0x003820E0 File Offset: 0x003802E0
			// (set) Token: 0x0600EB23 RID: 60195 RVA: 0x0007DD8D File Offset: 0x0007BF8D
			public unsafe static Func<string, string> __9__13_70
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_70, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_70, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C71 RID: 19569
			// (get) Token: 0x0600EB24 RID: 60196 RVA: 0x00382108 File Offset: 0x00380308
			// (set) Token: 0x0600EB25 RID: 60197 RVA: 0x0007DD9F File Offset: 0x0007BF9F
			public unsafe static Func<int, bool> __9__13_15
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_15, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_15, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C72 RID: 19570
			// (get) Token: 0x0600EB26 RID: 60198 RVA: 0x00382130 File Offset: 0x00380330
			// (set) Token: 0x0600EB27 RID: 60199 RVA: 0x0007DDB1 File Offset: 0x0007BFB1
			public unsafe static Func<Vector3Int, GameObject> __9__13_25
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_25, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_25, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C73 RID: 19571
			// (get) Token: 0x0600EB28 RID: 60200 RVA: 0x00382158 File Offset: 0x00380358
			// (set) Token: 0x0600EB29 RID: 60201 RVA: 0x0007DDC3 File Offset: 0x0007BFC3
			public unsafe static Func<GameObject, IEnumerable<SpriteRenderer>> __9__13_26
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_26, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, IEnumerable<SpriteRenderer>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_26, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C74 RID: 19572
			// (get) Token: 0x0600EB2A RID: 60202 RVA: 0x00382180 File Offset: 0x00380380
			// (set) Token: 0x0600EB2B RID: 60203 RVA: 0x0007DDD5 File Offset: 0x0007BFD5
			public unsafe static Func<Recipe, bool> __9__13_27
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_27, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_27, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C75 RID: 19573
			// (get) Token: 0x0600EB2C RID: 60204 RVA: 0x003821A8 File Offset: 0x003803A8
			// (set) Token: 0x0600EB2D RID: 60205 RVA: 0x0007DDE7 File Offset: 0x0007BFE7
			public unsafe static Func<Recipe, int> __9__13_28
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_28, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_28, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C76 RID: 19574
			// (get) Token: 0x0600EB2E RID: 60206 RVA: 0x003821D0 File Offset: 0x003803D0
			// (set) Token: 0x0600EB2F RID: 60207 RVA: 0x0007DDF9 File Offset: 0x0007BFF9
			public unsafe static Func<Sellable, bool> __9__13_29
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_29, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_29, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C77 RID: 19575
			// (get) Token: 0x0600EB30 RID: 60208 RVA: 0x003821F8 File Offset: 0x003803F8
			// (set) Token: 0x0600EB31 RID: 60209 RVA: 0x0007DE0B File Offset: 0x0007C00B
			public unsafe static Func<Sellable, int> __9__13_30
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_30, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Sellable, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_30, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C78 RID: 19576
			// (get) Token: 0x0600EB32 RID: 60210 RVA: 0x00382220 File Offset: 0x00380420
			// (set) Token: 0x0600EB33 RID: 60211 RVA: 0x0007DE1D File Offset: 0x0007C01D
			public unsafe static Func<Recipe, int> __9__13_32
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_32, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Recipe, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_32, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C79 RID: 19577
			// (get) Token: 0x0600EB34 RID: 60212 RVA: 0x00382248 File Offset: 0x00380448
			// (set) Token: 0x0600EB35 RID: 60213 RVA: 0x0007DE2F File Offset: 0x0007C02F
			public unsafe static Func<int, bool> __9__13_33
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_33, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_33, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C7A RID: 19578
			// (get) Token: 0x0600EB36 RID: 60214 RVA: 0x00382270 File Offset: 0x00380470
			// (set) Token: 0x0600EB37 RID: 60215 RVA: 0x0007DE41 File Offset: 0x0007C041
			public unsafe static Func<KeyValuePair<int, string>, int> __9__13_34
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_34, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, string>, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_34, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C7B RID: 19579
			// (get) Token: 0x0600EB38 RID: 60216 RVA: 0x00382298 File Offset: 0x00380498
			// (set) Token: 0x0600EB39 RID: 60217 RVA: 0x0007DE53 File Offset: 0x0007C053
			public unsafe static Func<int, bool> __9__13_35
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_35, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_35, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C7C RID: 19580
			// (get) Token: 0x0600EB3A RID: 60218 RVA: 0x003822C0 File Offset: 0x003804C0
			// (set) Token: 0x0600EB3B RID: 60219 RVA: 0x0007DE65 File Offset: 0x0007C065
			public unsafe static Func<int, bool> __9__13_36
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_36, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_36, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C7D RID: 19581
			// (get) Token: 0x0600EB3C RID: 60220 RVA: 0x003822E8 File Offset: 0x003804E8
			// (set) Token: 0x0600EB3D RID: 60221 RVA: 0x0007DE77 File Offset: 0x0007C077
			public unsafe static Func<Vector2Int, int> __9__13_37
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_37, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_37, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C7E RID: 19582
			// (get) Token: 0x0600EB3E RID: 60222 RVA: 0x00382310 File Offset: 0x00380510
			// (set) Token: 0x0600EB3F RID: 60223 RVA: 0x0007DE89 File Offset: 0x0007C089
			public unsafe static Func<Vector2Int, int> __9__13_38
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_38, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_38, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C7F RID: 19583
			// (get) Token: 0x0600EB40 RID: 60224 RVA: 0x00382338 File Offset: 0x00380538
			// (set) Token: 0x0600EB41 RID: 60225 RVA: 0x0007DE9B File Offset: 0x0007C09B
			public unsafe static Func<string, string> __9__13_78
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_78, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_78, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C80 RID: 19584
			// (get) Token: 0x0600EB42 RID: 60226 RVA: 0x00382360 File Offset: 0x00380560
			// (set) Token: 0x0600EB43 RID: 60227 RVA: 0x0007DEAD File Offset: 0x0007C0AD
			public unsafe static Action<ValueTuple<UIElementCluster, int>> __9__13_91
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_91, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ValueTuple<UIElementCluster, int>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_91, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C81 RID: 19585
			// (get) Token: 0x0600EB44 RID: 60228 RVA: 0x00382388 File Offset: 0x00380588
			// (set) Token: 0x0600EB45 RID: 60229 RVA: 0x0007DEBF File Offset: 0x0007C0BF
			public unsafe static Action<TextMeshProUGUI> __9__13_94
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_94, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TextMeshProUGUI>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_94, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C82 RID: 19586
			// (get) Token: 0x0600EB46 RID: 60230 RVA: 0x003823B0 File Offset: 0x003805B0
			// (set) Token: 0x0600EB47 RID: 60231 RVA: 0x0007DED1 File Offset: 0x0007C0D1
			public unsafe static Func<GuestGroupController, bool> __9__13_111
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_111, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GuestGroupController, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_111, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C83 RID: 19587
			// (get) Token: 0x0600EB48 RID: 60232 RVA: 0x003823D8 File Offset: 0x003805D8
			// (set) Token: 0x0600EB49 RID: 60233 RVA: 0x0007DEE3 File Offset: 0x0007C0E3
			public unsafe static Func<Coroutine, bool> __9__13_56
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_56, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Coroutine, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC2_KoishiBossData.__c.NativeFieldInfoPtr___9__13_56, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095C8 RID: 38344
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040095C9 RID: 38345
			private static readonly IntPtr NativeFieldInfoPtr___9__12_1;

			// Token: 0x040095CA RID: 38346
			private static readonly IntPtr NativeFieldInfoPtr___9__13_4;

			// Token: 0x040095CB RID: 38347
			private static readonly IntPtr NativeFieldInfoPtr___9__13_63;

			// Token: 0x040095CC RID: 38348
			private static readonly IntPtr NativeFieldInfoPtr___9__13_64;

			// Token: 0x040095CD RID: 38349
			private static readonly IntPtr NativeFieldInfoPtr___9__13_6;

			// Token: 0x040095CE RID: 38350
			private static readonly IntPtr NativeFieldInfoPtr___9__13_66;

			// Token: 0x040095CF RID: 38351
			private static readonly IntPtr NativeFieldInfoPtr___9__13_68;

			// Token: 0x040095D0 RID: 38352
			private static readonly IntPtr NativeFieldInfoPtr___9__13_69;

			// Token: 0x040095D1 RID: 38353
			private static readonly IntPtr NativeFieldInfoPtr___9__13_70;

			// Token: 0x040095D2 RID: 38354
			private static readonly IntPtr NativeFieldInfoPtr___9__13_15;

			// Token: 0x040095D3 RID: 38355
			private static readonly IntPtr NativeFieldInfoPtr___9__13_25;

			// Token: 0x040095D4 RID: 38356
			private static readonly IntPtr NativeFieldInfoPtr___9__13_26;

			// Token: 0x040095D5 RID: 38357
			private static readonly IntPtr NativeFieldInfoPtr___9__13_27;

			// Token: 0x040095D6 RID: 38358
			private static readonly IntPtr NativeFieldInfoPtr___9__13_28;

			// Token: 0x040095D7 RID: 38359
			private static readonly IntPtr NativeFieldInfoPtr___9__13_29;

			// Token: 0x040095D8 RID: 38360
			private static readonly IntPtr NativeFieldInfoPtr___9__13_30;

			// Token: 0x040095D9 RID: 38361
			private static readonly IntPtr NativeFieldInfoPtr___9__13_32;

			// Token: 0x040095DA RID: 38362
			private static readonly IntPtr NativeFieldInfoPtr___9__13_33;

			// Token: 0x040095DB RID: 38363
			private static readonly IntPtr NativeFieldInfoPtr___9__13_34;

			// Token: 0x040095DC RID: 38364
			private static readonly IntPtr NativeFieldInfoPtr___9__13_35;

			// Token: 0x040095DD RID: 38365
			private static readonly IntPtr NativeFieldInfoPtr___9__13_36;

			// Token: 0x040095DE RID: 38366
			private static readonly IntPtr NativeFieldInfoPtr___9__13_37;

			// Token: 0x040095DF RID: 38367
			private static readonly IntPtr NativeFieldInfoPtr___9__13_38;

			// Token: 0x040095E0 RID: 38368
			private static readonly IntPtr NativeFieldInfoPtr___9__13_78;

			// Token: 0x040095E1 RID: 38369
			private static readonly IntPtr NativeFieldInfoPtr___9__13_91;

			// Token: 0x040095E2 RID: 38370
			private static readonly IntPtr NativeFieldInfoPtr___9__13_94;

			// Token: 0x040095E3 RID: 38371
			private static readonly IntPtr NativeFieldInfoPtr___9__13_111;

			// Token: 0x040095E4 RID: 38372
			private static readonly IntPtr NativeFieldInfoPtr___9__13_56;

			// Token: 0x040095E5 RID: 38373
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095E6 RID: 38374
			private static readonly IntPtr NativeMethodInfoPtr__GetBossData_b__12_1_Internal_Int32_String_0;

			// Token: 0x040095E7 RID: 38375
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_4_Internal_IEnumerable_1_NormalGuestGroup_Izakaya_0;

			// Token: 0x040095E8 RID: 38376
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_63_Internal_String_String_0;

			// Token: 0x040095E9 RID: 38377
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_6_Internal_IEnumerable_1_Il2CppStructArray_1_Int32_Izakaya_0;

			// Token: 0x040095EA RID: 38378
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_64_Internal_Il2CppStructArray_1_Int32_NormalGuestGroup_0;

			// Token: 0x040095EB RID: 38379
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_66_Internal_String_String_0;

			// Token: 0x040095EC RID: 38380
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_68_Internal_IEnumerable_1_Int32_NormalGuest_0;

			// Token: 0x040095ED RID: 38381
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_69_Internal_IEnumerable_1_Int32_NormalGuest_0;

			// Token: 0x040095EE RID: 38382
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_70_Internal_String_String_0;

			// Token: 0x040095EF RID: 38383
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_15_Internal_Boolean_Int32_0;

			// Token: 0x040095F0 RID: 38384
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_25_Internal_GameObject_Vector3Int_0;

			// Token: 0x040095F1 RID: 38385
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_26_Internal_IEnumerable_1_SpriteRenderer_GameObject_0;

			// Token: 0x040095F2 RID: 38386
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_27_Internal_Boolean_Recipe_0;

			// Token: 0x040095F3 RID: 38387
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_28_Internal_Int32_Recipe_0;

			// Token: 0x040095F4 RID: 38388
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_29_Internal_Boolean_Sellable_0;

			// Token: 0x040095F5 RID: 38389
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_30_Internal_Int32_Sellable_0;

			// Token: 0x040095F6 RID: 38390
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_32_Internal_Int32_Recipe_0;

			// Token: 0x040095F7 RID: 38391
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_33_Internal_Boolean_Int32_0;

			// Token: 0x040095F8 RID: 38392
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_34_Internal_Int32_KeyValuePair_2_Int32_String_0;

			// Token: 0x040095F9 RID: 38393
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_35_Internal_Boolean_Int32_0;

			// Token: 0x040095FA RID: 38394
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_36_Internal_Boolean_Int32_0;

			// Token: 0x040095FB RID: 38395
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_37_Internal_Int32_Vector2Int_0;

			// Token: 0x040095FC RID: 38396
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_38_Internal_Int32_Vector2Int_0;

			// Token: 0x040095FD RID: 38397
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_78_Internal_String_String_0;

			// Token: 0x040095FE RID: 38398
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_91_Internal_Void_ValueTuple_2_UIElementCluster_Int32_0;

			// Token: 0x040095FF RID: 38399
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_94_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04009600 RID: 38400
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_111_Internal_Boolean_GuestGroupController_0;

			// Token: 0x04009601 RID: 38401
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__13_56_Internal_Boolean_Coroutine_0;
		}

		// Token: 0x02000CCB RID: 3275
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600EB4A RID: 60234 RVA: 0x00382400 File Offset: 0x00380600
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_isTimeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "isTimeEnd");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_thisSingleRoundDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "thisSingleRoundDuration");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_eventManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "eventManager");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_canContinue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "canContinue");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_currentScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "currentScore");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_statusDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "statusDisplayer");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_uiManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "uiManager");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_canContinueYieldInstruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "canContinueYieldInstruction");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_onChallengeEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "onChallengeEnd");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_guestsManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "guestsManager");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiBossData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "koishiBossData");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_phase1TargetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "phase1TargetScore");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_wackyTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "wackyTag");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allSpecialGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "allSpecialGuest");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_specialGuestInScene = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "specialGuestInScene");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_waitForTagSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "waitForTagSeconds");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_phase2TargetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "phase2TargetScore");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_postprocessCharacterCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "postprocessCharacterCallback");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_likeFoodTagNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "likeFoodTagNum");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "koishi");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "koishiTag");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allKoishiSelectedFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "allKoishiSelectedFood");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allFoodTagsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "allFoodTagsPool");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_hateFoodTagNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "hateFoodTagNum");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allBevTagsPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "allBevTagsPool");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_likeBevTagNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "likeBevTagNum");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_canSpawnStand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "canSpawnStand");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_interrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "interrupt");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_characterControllerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "characterControllerUnit");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_oldFace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "oldFace");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_highlightRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "highlightRenderer");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_highlightObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "highlightObject");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_phase3TargetScore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "phase3TargetScore");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_tagChangeLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "tagChangeLoop");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_isShieldRecovering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "isShieldRecovering");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_pannelCanvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "pannelCanvas");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiEye = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "koishiEye");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiTablePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "koishiTablePosition");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_isEasy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "isEasy");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_haveShieldBroken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "haveShieldBroken");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_mainLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "mainLoop");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_waitForShieldRespawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "waitForShieldRespawn");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "koishiData");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiObjectName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "koishiObjectName");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_interruptActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "interruptActions");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_types = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "types");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_typeAlpha = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "typeAlpha");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_orderDisplayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "orderDisplayer");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_cookControllersBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "cookControllersBase");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_cookingSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "cookingSystem");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_tryTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "tryTime");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "tags");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiSeatPostion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "koishiSeatPostion");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_icons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "icons");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiCorotine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "koishiCorotine");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allSelectedFood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "allSelectedFood");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allSelectedBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "allSelectedBev");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_levelToDamageDic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "levelToDamageDic");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_giveBadge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "giveBadge");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__73 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<>9__73");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__97 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<>9__97");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__102 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<>9__102");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__93 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<>9__93");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__110 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<>9__110");
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681637);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681638);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681639);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681640);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681641);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__62_Internal_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681642);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681643);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681644);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681645);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681646);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681647);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681648);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681649);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681650);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__12_Internal_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681651);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681652);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__14_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681653);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681654);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681655);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__73_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681656);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681657);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681658);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__19_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681659);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681660);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681661);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__22_Internal_Void_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681662);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__23_Internal_Action_1_AStarInputGeneratorComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681663);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__24_Internal_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681664);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__31_Internal_Boolean_Recipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681665);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681666);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681667);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__77_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681668);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__79_Internal_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681669);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681670);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681671);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681672);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681673);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681674);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681675);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681676);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681677);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681678);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__89_Internal_Single_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681679);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_5 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681680);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681681);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__90_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681682);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_6 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681683);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__97_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681684);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681685);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__102_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681686);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__93_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681687);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Boolean_Sellable_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681688);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__105_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681689);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681690);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__106_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681691);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681692);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__108_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681693);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__109_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681694);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__110_Internal_Void_EvaluationResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681695);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_3 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681696);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681697);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__57_Internal_Void_Coroutine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681698);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__58_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681699);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__59_Internal_Void_4 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681700);
				DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, 100681701);
			}

			// Token: 0x0600EB4B RID: 60235 RVA: 0x00382E54 File Offset: 0x00381054
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB4C RID: 60236 RVA: 0x00382E90 File Offset: 0x00381090
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 222562, RefRangeEnd = 222565, XrefRangeStart = 222556, XrefRangeEnd = 222562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Func_1_Boolean_0(Func<bool> extraTiming)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(extraTiming);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB4D RID: 60237 RVA: 0x00382EE0 File Offset: 0x003810E0
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB4E RID: 60238 RVA: 0x00382F1C File Offset: 0x0038111C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222565, XrefRangeEnd = 222567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_PDM_0(int score)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref score;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB4F RID: 60239 RVA: 0x00382F5C File Offset: 0x0038115C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 222572, RefRangeEnd = 222575, XrefRangeStart = 222567, XrefRangeEnd = 222572, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB50 RID: 60240 RVA: 0x00382F9C File Offset: 0x0038119C
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__62()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__62_Internal_Void_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB51 RID: 60241 RVA: 0x00382FD0 File Offset: 0x003811D0
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB52 RID: 60242 RVA: 0x00383004 File Offset: 0x00381204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222575, XrefRangeEnd = 222606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController group)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB53 RID: 60243 RVA: 0x00383048 File Offset: 0x00381248
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222606, XrefRangeEnd = 222614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestsManager.OrderBase Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0(GuestGroupController guestGroup, out string orderGenerationMessage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				orderGenerationMessage = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr4) : null;
			}

			// Token: 0x0600EB54 RID: 60244 RVA: 0x003830B4 File Offset: 0x003812B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222614, XrefRangeEnd = 222683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0(GuestGroupController.EvaluationResult lastResult, GuestGroupController thisGuest, bool oldComboProtect, out string newMessage, out bool comboProtect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref lastResult;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				newMessage = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600EB55 RID: 60245 RVA: 0x00383148 File Offset: 0x00381348
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB56 RID: 60246 RVA: 0x00383184 File Offset: 0x00381384
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222683, XrefRangeEnd = 222684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__9(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB57 RID: 60247 RVA: 0x003831C8 File Offset: 0x003813C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222684, XrefRangeEnd = 222685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__10(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB58 RID: 60248 RVA: 0x0038320C File Offset: 0x0038140C
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB59 RID: 60249 RVA: 0x00383240 File Offset: 0x00381440
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__12_Internal_Void_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB5A RID: 60250 RVA: 0x00383274 File Offset: 0x00381474
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222701, RefRangeEnd = 222703, XrefRangeStart = 222685, XrefRangeEnd = 222701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB5B RID: 60251 RVA: 0x003832A8 File Offset: 0x003814A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222703, XrefRangeEnd = 222714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__14(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__14_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB5C RID: 60252 RVA: 0x003832F4 File Offset: 0x003814F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222714, XrefRangeEnd = 222719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB5D RID: 60253 RVA: 0x00383334 File Offset: 0x00381534
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222719, XrefRangeEnd = 222735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_1(GuestGroupController.EvaluationResult lastEval, GuestGroupController thisGuest, bool oldComboProtect, out string newMessage, out bool comboProtect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref lastEval;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				newMessage = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600EB5E RID: 60254 RVA: 0x003833C8 File Offset: 0x003815C8
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__73(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__73_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB5F RID: 60255 RVA: 0x00383414 File Offset: 0x00381614
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222735, XrefRangeEnd = 222740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB60 RID: 60256 RVA: 0x00383454 File Offset: 0x00381654
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__18()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB61 RID: 60257 RVA: 0x00383490 File Offset: 0x00381690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__19(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__19_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB62 RID: 60258 RVA: 0x003834D4 File Offset: 0x003816D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__20(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB63 RID: 60259 RVA: 0x00383518 File Offset: 0x00381718
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__21()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB64 RID: 60260 RVA: 0x0038354C File Offset: 0x0038174C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222740, XrefRangeEnd = 222744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__22(AStarInputGeneratorComponent x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__22_Internal_Void_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB65 RID: 60261 RVA: 0x00383590 File Offset: 0x00381790
			[CallerCount(0)]
			public unsafe Action<AStarInputGeneratorComponent> _MainChallengeLoop_b__23()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__23_Internal_Action_1_AStarInputGeneratorComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr3) : null;
			}

			// Token: 0x0600EB66 RID: 60262 RVA: 0x003835D0 File Offset: 0x003817D0
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__24()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__24_Internal_Void_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB67 RID: 60263 RVA: 0x00383604 File Offset: 0x00381804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222744, XrefRangeEnd = 222745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__31(Recipe x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__31_Internal_Boolean_Recipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB68 RID: 60264 RVA: 0x00383654 File Offset: 0x00381854
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222819, RefRangeEnd = 222821, XrefRangeStart = 222745, XrefRangeEnd = 222819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB69 RID: 60265 RVA: 0x00383688 File Offset: 0x00381888
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222862, RefRangeEnd = 222864, XrefRangeStart = 222821, XrefRangeEnd = 222862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB6A RID: 60266 RVA: 0x003836BC File Offset: 0x003818BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222864, XrefRangeEnd = 222868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__77(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__77_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB6B RID: 60267 RVA: 0x00383708 File Offset: 0x00381908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222868, XrefRangeEnd = 222874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__79()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__79_Internal_Void_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB6C RID: 60268 RVA: 0x0038373C File Offset: 0x0038193C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222874, XrefRangeEnd = 222879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB6D RID: 60269 RVA: 0x0038377C File Offset: 0x0038197C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222879, XrefRangeEnd = 222884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB6E RID: 60270 RVA: 0x003837BC File Offset: 0x003819BC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222889, RefRangeEnd = 222891, XrefRangeStart = 222884, XrefRangeEnd = 222889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB6F RID: 60271 RVA: 0x003837FC File Offset: 0x003819FC
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 222896, RefRangeEnd = 222898, XrefRangeStart = 222891, XrefRangeEnd = 222896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Int32_0(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB70 RID: 60272 RVA: 0x00383848 File Offset: 0x00381A48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222898, XrefRangeEnd = 222903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB71 RID: 60273 RVA: 0x00383888 File Offset: 0x00381A88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222903, XrefRangeEnd = 222933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_PDM_1(int deskCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref deskCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB72 RID: 60274 RVA: 0x003838C8 File Offset: 0x00381AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222933, XrefRangeEnd = 222950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Int32_PDM_2(int id)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB73 RID: 60275 RVA: 0x00383908 File Offset: 0x00381B08
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 222961, RefRangeEnd = 222967, XrefRangeStart = 222950, XrefRangeEnd = 222961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB74 RID: 60276 RVA: 0x0038393C File Offset: 0x00381B3C
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 222998, RefRangeEnd = 223004, XrefRangeStart = 222967, XrefRangeEnd = 222998, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float Method_Internal_Single_Int32_0(int typeId)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref typeId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB75 RID: 60277 RVA: 0x00383988 File Offset: 0x00381B88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223004, XrefRangeEnd = 223006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _MainChallengeLoop_b__89(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__89_Internal_Single_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB76 RID: 60278 RVA: 0x003839DC File Offset: 0x00381BDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223006, XrefRangeEnd = 223011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_5, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB77 RID: 60279 RVA: 0x00383A1C File Offset: 0x00381C1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223011, XrefRangeEnd = 223049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB78 RID: 60280 RVA: 0x00383A50 File Offset: 0x00381C50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223049, XrefRangeEnd = 223050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__90(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__90_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB79 RID: 60281 RVA: 0x00383A94 File Offset: 0x00381C94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223050, XrefRangeEnd = 223055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_6, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB7A RID: 60282 RVA: 0x00383AD4 File Offset: 0x00381CD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223055, XrefRangeEnd = 223088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__97(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__97_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB7B RID: 60283 RVA: 0x00383B18 File Offset: 0x00381D18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223088, XrefRangeEnd = 223124, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_2(GuestGroupController.EvaluationResult lastResult, GuestGroupController thisGuestGroup, bool oldComboProtect, out string newMessage, out bool comboProtect)
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				newMessage = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600EB7C RID: 60284 RVA: 0x00383BAC File Offset: 0x00381DAC
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__102(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__102_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB7D RID: 60285 RVA: 0x00383BF8 File Offset: 0x00381DF8
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__93()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__93_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB7E RID: 60286 RVA: 0x00383C34 File Offset: 0x00381E34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223124, XrefRangeEnd = 223143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool Method_Internal_Boolean_Sellable_PDM_0(Sellable food)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(food);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Boolean_Sellable_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB7F RID: 60287 RVA: 0x00383C84 File Offset: 0x00381E84
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__105(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__105_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB80 RID: 60288 RVA: 0x00383CD0 File Offset: 0x00381ED0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223143, XrefRangeEnd = 223171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestsManager.OrderBase Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_1(GuestGroupController guestGroup, out string orderGenerationMessage)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				orderGenerationMessage = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<GuestsManager.OrderBase>(intPtr4) : null;
			}

			// Token: 0x0600EB81 RID: 60289 RVA: 0x00383D3C File Offset: 0x00381F3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223171, XrefRangeEnd = 223191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__106(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__106_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB82 RID: 60290 RVA: 0x00383D88 File Offset: 0x00381F88
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 223196, RefRangeEnd = 223198, XrefRangeStart = 223191, XrefRangeEnd = 223196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EB83 RID: 60291 RVA: 0x00383DC8 File Offset: 0x00381FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223198, XrefRangeEnd = 223218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__108()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__108_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB84 RID: 60292 RVA: 0x00383E04 File Offset: 0x00382004
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__109()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__109_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB85 RID: 60293 RVA: 0x00383E40 File Offset: 0x00382040
			[CallerCount(0)]
			public unsafe void _MainChallengeLoop_b__110(GuestGroupController.EvaluationResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__110_Internal_Void_EvaluationResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB86 RID: 60294 RVA: 0x00383E80 File Offset: 0x00382080
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223218, XrefRangeEnd = 223273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_3(GuestGroupController.EvaluationResult lastEvaluation, GuestGroupController _, bool oldComboProtect, out string newMessage, out bool comboProtect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref lastEvaluation;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_3, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				newMessage = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600EB87 RID: 60295 RVA: 0x00383F14 File Offset: 0x00382114
			[CallerCount(0)]
			public unsafe bool _MainChallengeLoop_b__55()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EB88 RID: 60296 RVA: 0x00383F50 File Offset: 0x00382150
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223273, XrefRangeEnd = 223275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__57(Coroutine x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__57_Internal_Void_Coroutine_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB89 RID: 60297 RVA: 0x00383F94 File Offset: 0x00382194
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__58(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__58_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB8A RID: 60298 RVA: 0x00383FD8 File Offset: 0x003821D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223275, XrefRangeEnd = 223276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__59()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr__MainChallengeLoop_b__59_Internal_Void_4, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB8B RID: 60299 RVA: 0x0038400C File Offset: 0x0038220C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223276, XrefRangeEnd = 223284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EB8C RID: 60300 RVA: 0x0007DEF5 File Offset: 0x0007C0F5
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004C84 RID: 19588
			// (get) Token: 0x0600EB8D RID: 60301 RVA: 0x00384040 File Offset: 0x00382240
			// (set) Token: 0x0600EB8E RID: 60302 RVA: 0x0007DEFE File Offset: 0x0007C0FE
			public unsafe bool isTimeEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_isTimeEnd);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_isTimeEnd)) = value;
				}
			}

			// Token: 0x17004C85 RID: 19589
			// (get) Token: 0x0600EB8F RID: 60303 RVA: 0x00384068 File Offset: 0x00382268
			// (set) Token: 0x0600EB90 RID: 60304 RVA: 0x0007DF19 File Offset: 0x0007C119
			public unsafe int thisSingleRoundDuration
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_thisSingleRoundDuration);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_thisSingleRoundDuration)) = value;
				}
			}

			// Token: 0x17004C86 RID: 19590
			// (get) Token: 0x0600EB91 RID: 60305 RVA: 0x00384090 File Offset: 0x00382290
			// (set) Token: 0x0600EB92 RID: 60306 RVA: 0x0007DF34 File Offset: 0x0007C134
			public unsafe EventManager eventManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_eventManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EventManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_eventManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C87 RID: 19591
			// (get) Token: 0x0600EB93 RID: 60307 RVA: 0x003840C0 File Offset: 0x003822C0
			// (set) Token: 0x0600EB94 RID: 60308 RVA: 0x0007DF53 File Offset: 0x0007C153
			public unsafe DLC2_KoishiBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C88 RID: 19592
			// (get) Token: 0x0600EB95 RID: 60309 RVA: 0x003840F0 File Offset: 0x003822F0
			// (set) Token: 0x0600EB96 RID: 60310 RVA: 0x0007DF72 File Offset: 0x0007C172
			public unsafe bool canContinue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_canContinue);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_canContinue)) = value;
				}
			}

			// Token: 0x17004C89 RID: 19593
			// (get) Token: 0x0600EB97 RID: 60311 RVA: 0x00384118 File Offset: 0x00382318
			// (set) Token: 0x0600EB98 RID: 60312 RVA: 0x0007DF8D File Offset: 0x0007C18D
			public unsafe int currentScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_currentScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_currentScore)) = value;
				}
			}

			// Token: 0x17004C8A RID: 19594
			// (get) Token: 0x0600EB99 RID: 60313 RVA: 0x00384140 File Offset: 0x00382340
			// (set) Token: 0x0600EB9A RID: 60314 RVA: 0x0007DFA8 File Offset: 0x0007C1A8
			public unsafe IncomeControllerKoishi statusDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_statusDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IncomeControllerKoishi>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_statusDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C8B RID: 19595
			// (get) Token: 0x0600EB9B RID: 60315 RVA: 0x00384170 File Offset: 0x00382370
			// (set) Token: 0x0600EB9C RID: 60316 RVA: 0x0007DFC7 File Offset: 0x0007C1C7
			public unsafe UIManager uiManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_uiManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_uiManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C8C RID: 19596
			// (get) Token: 0x0600EB9D RID: 60317 RVA: 0x003841A0 File Offset: 0x003823A0
			// (set) Token: 0x0600EB9E RID: 60318 RVA: 0x0007DFE6 File Offset: 0x0007C1E6
			public unsafe WaitUntil canContinueYieldInstruction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_canContinueYieldInstruction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_canContinueYieldInstruction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C8D RID: 19597
			// (get) Token: 0x0600EB9F RID: 60319 RVA: 0x003841D0 File Offset: 0x003823D0
			// (set) Token: 0x0600EBA0 RID: 60320 RVA: 0x0007E005 File Offset: 0x0007C205
			public unsafe Action onChallengeEnd
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_onChallengeEnd);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_onChallengeEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C8E RID: 19598
			// (get) Token: 0x0600EBA1 RID: 60321 RVA: 0x00384200 File Offset: 0x00382400
			// (set) Token: 0x0600EBA2 RID: 60322 RVA: 0x0007E024 File Offset: 0x0007C224
			public unsafe GuestsManager guestsManager
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_guestsManager);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestsManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_guestsManager), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C8F RID: 19599
			// (get) Token: 0x0600EBA3 RID: 60323 RVA: 0x00384230 File Offset: 0x00382430
			// (set) Token: 0x0600EBA4 RID: 60324 RVA: 0x0007E043 File Offset: 0x0007C243
			public DLC2_KoishiBossData.KoishiBossData koishiBossData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiBossData);
					return new DLC2_KoishiBossData.KoishiBossData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiBossData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC2_KoishiBossData.KoishiBossData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004C90 RID: 19600
			// (get) Token: 0x0600EBA5 RID: 60325 RVA: 0x00384260 File Offset: 0x00382460
			// (set) Token: 0x0600EBA6 RID: 60326 RVA: 0x0007E071 File Offset: 0x0007C271
			public unsafe int phase1TargetScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_phase1TargetScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_phase1TargetScore)) = value;
				}
			}

			// Token: 0x17004C91 RID: 19601
			// (get) Token: 0x0600EBA7 RID: 60327 RVA: 0x00384288 File Offset: 0x00382488
			// (set) Token: 0x0600EBA8 RID: 60328 RVA: 0x0007E08C File Offset: 0x0007C28C
			public unsafe int wackyTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_wackyTag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_wackyTag)) = value;
				}
			}

			// Token: 0x17004C92 RID: 19602
			// (get) Token: 0x0600EBA9 RID: 60329 RVA: 0x003842B0 File Offset: 0x003824B0
			// (set) Token: 0x0600EBAA RID: 60330 RVA: 0x0007E0A7 File Offset: 0x0007C2A7
			public unsafe List<int> allSpecialGuest
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allSpecialGuest);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allSpecialGuest), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C93 RID: 19603
			// (get) Token: 0x0600EBAB RID: 60331 RVA: 0x003842E0 File Offset: 0x003824E0
			// (set) Token: 0x0600EBAC RID: 60332 RVA: 0x0007E0C6 File Offset: 0x0007C2C6
			public unsafe HashSet<int> specialGuestInScene
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_specialGuestInScene);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_specialGuestInScene), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C94 RID: 19604
			// (get) Token: 0x0600EBAD RID: 60333 RVA: 0x00384310 File Offset: 0x00382510
			// (set) Token: 0x0600EBAE RID: 60334 RVA: 0x0007E0E5 File Offset: 0x0007C2E5
			public unsafe WaitForSeconds waitForTagSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_waitForTagSeconds);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_waitForTagSeconds), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C95 RID: 19605
			// (get) Token: 0x0600EBAF RID: 60335 RVA: 0x00384340 File Offset: 0x00382540
			// (set) Token: 0x0600EBB0 RID: 60336 RVA: 0x0007E104 File Offset: 0x0007C304
			public unsafe int phase2TargetScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_phase2TargetScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_phase2TargetScore)) = value;
				}
			}

			// Token: 0x17004C96 RID: 19606
			// (get) Token: 0x0600EBB1 RID: 60337 RVA: 0x00384368 File Offset: 0x00382568
			// (set) Token: 0x0600EBB2 RID: 60338 RVA: 0x0007E11F File Offset: 0x0007C31F
			public unsafe Action<AStarInputGeneratorComponent> postprocessCharacterCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_postprocessCharacterCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AStarInputGeneratorComponent>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_postprocessCharacterCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C97 RID: 19607
			// (get) Token: 0x0600EBB3 RID: 60339 RVA: 0x00384398 File Offset: 0x00382598
			// (set) Token: 0x0600EBB4 RID: 60340 RVA: 0x0007E13E File Offset: 0x0007C33E
			public unsafe int likeFoodTagNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_likeFoodTagNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_likeFoodTagNum)) = value;
				}
			}

			// Token: 0x17004C98 RID: 19608
			// (get) Token: 0x0600EBB5 RID: 60341 RVA: 0x003843C0 File Offset: 0x003825C0
			// (set) Token: 0x0600EBB6 RID: 60342 RVA: 0x0007E159 File Offset: 0x0007C359
			public unsafe GuestGroupController koishi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishi);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GuestGroupController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishi), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C99 RID: 19609
			// (get) Token: 0x0600EBB7 RID: 60343 RVA: 0x003843F0 File Offset: 0x003825F0
			// (set) Token: 0x0600EBB8 RID: 60344 RVA: 0x0007E178 File Offset: 0x0007C378
			public unsafe List<int> koishiTag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiTag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiTag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C9A RID: 19610
			// (get) Token: 0x0600EBB9 RID: 60345 RVA: 0x00384420 File Offset: 0x00382620
			// (set) Token: 0x0600EBBA RID: 60346 RVA: 0x0007E197 File Offset: 0x0007C397
			public unsafe IEnumerable<int> allKoishiSelectedFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allKoishiSelectedFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allKoishiSelectedFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C9B RID: 19611
			// (get) Token: 0x0600EBBB RID: 60347 RVA: 0x00384450 File Offset: 0x00382650
			// (set) Token: 0x0600EBBC RID: 60348 RVA: 0x0007E1B6 File Offset: 0x0007C3B6
			public unsafe List<int> allFoodTagsPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allFoodTagsPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allFoodTagsPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C9C RID: 19612
			// (get) Token: 0x0600EBBD RID: 60349 RVA: 0x00384480 File Offset: 0x00382680
			// (set) Token: 0x0600EBBE RID: 60350 RVA: 0x0007E1D5 File Offset: 0x0007C3D5
			public unsafe int hateFoodTagNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_hateFoodTagNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_hateFoodTagNum)) = value;
				}
			}

			// Token: 0x17004C9D RID: 19613
			// (get) Token: 0x0600EBBF RID: 60351 RVA: 0x003844A8 File Offset: 0x003826A8
			// (set) Token: 0x0600EBC0 RID: 60352 RVA: 0x0007E1F0 File Offset: 0x0007C3F0
			public unsafe List<int> allBevTagsPool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allBevTagsPool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allBevTagsPool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004C9E RID: 19614
			// (get) Token: 0x0600EBC1 RID: 60353 RVA: 0x003844D8 File Offset: 0x003826D8
			// (set) Token: 0x0600EBC2 RID: 60354 RVA: 0x0007E20F File Offset: 0x0007C40F
			public unsafe int likeBevTagNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_likeBevTagNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_likeBevTagNum)) = value;
				}
			}

			// Token: 0x17004C9F RID: 19615
			// (get) Token: 0x0600EBC3 RID: 60355 RVA: 0x00384500 File Offset: 0x00382700
			// (set) Token: 0x0600EBC4 RID: 60356 RVA: 0x0007E22A File Offset: 0x0007C42A
			public unsafe bool canSpawnStand
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_canSpawnStand);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_canSpawnStand)) = value;
				}
			}

			// Token: 0x17004CA0 RID: 19616
			// (get) Token: 0x0600EBC5 RID: 60357 RVA: 0x00384528 File Offset: 0x00382728
			// (set) Token: 0x0600EBC6 RID: 60358 RVA: 0x0007E245 File Offset: 0x0007C445
			public unsafe Action interrupt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_interrupt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_interrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA1 RID: 19617
			// (get) Token: 0x0600EBC7 RID: 60359 RVA: 0x00384558 File Offset: 0x00382758
			// (set) Token: 0x0600EBC8 RID: 60360 RVA: 0x0007E264 File Offset: 0x0007C464
			public unsafe CharacterControllerUnit characterControllerUnit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_characterControllerUnit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_characterControllerUnit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA2 RID: 19618
			// (get) Token: 0x0600EBC9 RID: 60361 RVA: 0x00384588 File Offset: 0x00382788
			// (set) Token: 0x0600EBCA RID: 60362 RVA: 0x0007E283 File Offset: 0x0007C483
			public unsafe Sprite oldFace
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_oldFace);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_oldFace), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA3 RID: 19619
			// (get) Token: 0x0600EBCB RID: 60363 RVA: 0x003845B8 File Offset: 0x003827B8
			// (set) Token: 0x0600EBCC RID: 60364 RVA: 0x0007E2A2 File Offset: 0x0007C4A2
			public unsafe SpriteRenderer highlightRenderer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_highlightRenderer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_highlightRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA4 RID: 19620
			// (get) Token: 0x0600EBCD RID: 60365 RVA: 0x003845E8 File Offset: 0x003827E8
			// (set) Token: 0x0600EBCE RID: 60366 RVA: 0x0007E2C1 File Offset: 0x0007C4C1
			public unsafe GameObject highlightObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_highlightObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_highlightObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA5 RID: 19621
			// (get) Token: 0x0600EBCF RID: 60367 RVA: 0x00384618 File Offset: 0x00382818
			// (set) Token: 0x0600EBD0 RID: 60368 RVA: 0x0007E2E0 File Offset: 0x0007C4E0
			public unsafe int phase3TargetScore
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_phase3TargetScore);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_phase3TargetScore)) = value;
				}
			}

			// Token: 0x17004CA6 RID: 19622
			// (get) Token: 0x0600EBD1 RID: 60369 RVA: 0x00384640 File Offset: 0x00382840
			// (set) Token: 0x0600EBD2 RID: 60370 RVA: 0x0007E2FB File Offset: 0x0007C4FB
			public unsafe Coroutine tagChangeLoop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_tagChangeLoop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_tagChangeLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA7 RID: 19623
			// (get) Token: 0x0600EBD3 RID: 60371 RVA: 0x00384670 File Offset: 0x00382870
			// (set) Token: 0x0600EBD4 RID: 60372 RVA: 0x0007E31A File Offset: 0x0007C51A
			public unsafe bool isShieldRecovering
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_isShieldRecovering);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_isShieldRecovering)) = value;
				}
			}

			// Token: 0x17004CA8 RID: 19624
			// (get) Token: 0x0600EBD5 RID: 60373 RVA: 0x00384698 File Offset: 0x00382898
			// (set) Token: 0x0600EBD6 RID: 60374 RVA: 0x0007E335 File Offset: 0x0007C535
			public unsafe PannelTransitionController pannelCanvas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_pannelCanvas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PannelTransitionController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_pannelCanvas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CA9 RID: 19625
			// (get) Token: 0x0600EBD7 RID: 60375 RVA: 0x003846C8 File Offset: 0x003828C8
			// (set) Token: 0x0600EBD8 RID: 60376 RVA: 0x0007E354 File Offset: 0x0007C554
			public unsafe SpriteRenderer koishiEye
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiEye);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiEye), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CAA RID: 19626
			// (get) Token: 0x0600EBD9 RID: 60377 RVA: 0x003846F8 File Offset: 0x003828F8
			// (set) Token: 0x0600EBDA RID: 60378 RVA: 0x0007E373 File Offset: 0x0007C573
			public unsafe Vector3 koishiTablePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiTablePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiTablePosition)) = value;
				}
			}

			// Token: 0x17004CAB RID: 19627
			// (get) Token: 0x0600EBDB RID: 60379 RVA: 0x00384720 File Offset: 0x00382920
			// (set) Token: 0x0600EBDC RID: 60380 RVA: 0x0007E38E File Offset: 0x0007C58E
			public unsafe bool isEasy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_isEasy);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_isEasy)) = value;
				}
			}

			// Token: 0x17004CAC RID: 19628
			// (get) Token: 0x0600EBDD RID: 60381 RVA: 0x00384748 File Offset: 0x00382948
			// (set) Token: 0x0600EBDE RID: 60382 RVA: 0x0007E3A9 File Offset: 0x0007C5A9
			public unsafe bool haveShieldBroken
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_haveShieldBroken);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_haveShieldBroken)) = value;
				}
			}

			// Token: 0x17004CAD RID: 19629
			// (get) Token: 0x0600EBDF RID: 60383 RVA: 0x00384770 File Offset: 0x00382970
			// (set) Token: 0x0600EBE0 RID: 60384 RVA: 0x0007E3C4 File Offset: 0x0007C5C4
			public unsafe Coroutine mainLoop
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_mainLoop);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_mainLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CAE RID: 19630
			// (get) Token: 0x0600EBE1 RID: 60385 RVA: 0x003847A0 File Offset: 0x003829A0
			// (set) Token: 0x0600EBE2 RID: 60386 RVA: 0x0007E3E3 File Offset: 0x0007C5E3
			public unsafe WaitForSeconds waitForShieldRespawn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_waitForShieldRespawn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_waitForShieldRespawn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CAF RID: 19631
			// (get) Token: 0x0600EBE3 RID: 60387 RVA: 0x003847D0 File Offset: 0x003829D0
			// (set) Token: 0x0600EBE4 RID: 60388 RVA: 0x0007E402 File Offset: 0x0007C602
			public unsafe SpecialGuest koishiData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB0 RID: 19632
			// (get) Token: 0x0600EBE5 RID: 60389 RVA: 0x00384800 File Offset: 0x00382A00
			// (set) Token: 0x0600EBE6 RID: 60390 RVA: 0x0007E421 File Offset: 0x0007C621
			public unsafe List<string> koishiObjectName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiObjectName);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiObjectName), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB1 RID: 19633
			// (get) Token: 0x0600EBE7 RID: 60391 RVA: 0x00384830 File Offset: 0x00382A30
			// (set) Token: 0x0600EBE8 RID: 60392 RVA: 0x0007E440 File Offset: 0x0007C640
			public unsafe Dictionary<int, Action> interruptActions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_interruptActions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Action>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_interruptActions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB2 RID: 19634
			// (get) Token: 0x0600EBE9 RID: 60393 RVA: 0x00384860 File Offset: 0x00382A60
			// (set) Token: 0x0600EBEA RID: 60394 RVA: 0x0007E45F File Offset: 0x0007C65F
			public unsafe Dictionary<int, int> types
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_types);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_types), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB3 RID: 19635
			// (get) Token: 0x0600EBEB RID: 60395 RVA: 0x00384890 File Offset: 0x00382A90
			// (set) Token: 0x0600EBEC RID: 60396 RVA: 0x0007E47E File Offset: 0x0007C67E
			public unsafe Il2CppStructArray<float> typeAlpha
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_typeAlpha);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_typeAlpha), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB4 RID: 19636
			// (get) Token: 0x0600EBED RID: 60397 RVA: 0x003848C0 File Offset: 0x00382AC0
			// (set) Token: 0x0600EBEE RID: 60398 RVA: 0x0007E49D File Offset: 0x0007C69D
			public unsafe CanvasGroup orderDisplayer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_orderDisplayer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_orderDisplayer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB5 RID: 19637
			// (get) Token: 0x0600EBEF RID: 60399 RVA: 0x003848F0 File Offset: 0x00382AF0
			// (set) Token: 0x0600EBF0 RID: 60400 RVA: 0x0007E4BC File Offset: 0x0007C6BC
			public unsafe Tilemap cookControllersBase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_cookControllersBase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Tilemap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_cookControllersBase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB6 RID: 19638
			// (get) Token: 0x0600EBF1 RID: 60401 RVA: 0x00384920 File Offset: 0x00382B20
			// (set) Token: 0x0600EBF2 RID: 60402 RVA: 0x0007E4DB File Offset: 0x0007C6DB
			public unsafe CookSystemManager cookingSystem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_cookingSystem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CookSystemManager>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_cookingSystem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB7 RID: 19639
			// (get) Token: 0x0600EBF3 RID: 60403 RVA: 0x00384950 File Offset: 0x00382B50
			// (set) Token: 0x0600EBF4 RID: 60404 RVA: 0x0007E4FA File Offset: 0x0007C6FA
			public unsafe int tryTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_tryTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_tryTime)) = value;
				}
			}

			// Token: 0x17004CB8 RID: 19640
			// (get) Token: 0x0600EBF5 RID: 60405 RVA: 0x00384978 File Offset: 0x00382B78
			// (set) Token: 0x0600EBF6 RID: 60406 RVA: 0x0007E515 File Offset: 0x0007C715
			public unsafe Dictionary<int, ValueTuple<UIElementCluster, int>> tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_tags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<UIElementCluster, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_tags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CB9 RID: 19641
			// (get) Token: 0x0600EBF7 RID: 60407 RVA: 0x003849A8 File Offset: 0x00382BA8
			// (set) Token: 0x0600EBF8 RID: 60408 RVA: 0x0007E534 File Offset: 0x0007C734
			public unsafe Vector3 koishiSeatPostion
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiSeatPostion);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiSeatPostion)) = value;
				}
			}

			// Token: 0x17004CBA RID: 19642
			// (get) Token: 0x0600EBF9 RID: 60409 RVA: 0x003849D0 File Offset: 0x00382BD0
			// (set) Token: 0x0600EBFA RID: 60410 RVA: 0x0007E54F File Offset: 0x0007C74F
			public unsafe Dictionary<int, GameObject> icons
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_icons);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_icons), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CBB RID: 19643
			// (get) Token: 0x0600EBFB RID: 60411 RVA: 0x00384A00 File Offset: 0x00382C00
			// (set) Token: 0x0600EBFC RID: 60412 RVA: 0x0007E56E File Offset: 0x0007C76E
			public unsafe List<Coroutine> koishiCorotine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiCorotine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Coroutine>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_koishiCorotine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CBC RID: 19644
			// (get) Token: 0x0600EBFD RID: 60413 RVA: 0x00384A30 File Offset: 0x00382C30
			// (set) Token: 0x0600EBFE RID: 60414 RVA: 0x0007E58D File Offset: 0x0007C78D
			public unsafe IEnumerable<int> allSelectedFood
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allSelectedFood);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allSelectedFood), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CBD RID: 19645
			// (get) Token: 0x0600EBFF RID: 60415 RVA: 0x00384A60 File Offset: 0x00382C60
			// (set) Token: 0x0600EC00 RID: 60416 RVA: 0x0007E5AC File Offset: 0x0007C7AC
			public unsafe IEnumerable<int> allSelectedBev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allSelectedBev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_allSelectedBev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CBE RID: 19646
			// (get) Token: 0x0600EC01 RID: 60417 RVA: 0x00384A90 File Offset: 0x00382C90
			// (set) Token: 0x0600EC02 RID: 60418 RVA: 0x0007E5CB File Offset: 0x0007C7CB
			public unsafe Dictionary<int, int> levelToDamageDic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_levelToDamageDic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_levelToDamageDic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CBF RID: 19647
			// (get) Token: 0x0600EC03 RID: 60419 RVA: 0x00384AC0 File Offset: 0x00382CC0
			// (set) Token: 0x0600EC04 RID: 60420 RVA: 0x0007E5EA File Offset: 0x0007C7EA
			public unsafe Stack<int> giveBadge
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_giveBadge);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr_giveBadge), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CC0 RID: 19648
			// (get) Token: 0x0600EC05 RID: 60421 RVA: 0x00384AF0 File Offset: 0x00382CF0
			// (set) Token: 0x0600EC06 RID: 60422 RVA: 0x0007E609 File Offset: 0x0007C809
			public unsafe Func<int, bool> __9__73
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__73);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__73), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CC1 RID: 19649
			// (get) Token: 0x0600EC07 RID: 60423 RVA: 0x00384B20 File Offset: 0x00382D20
			// (set) Token: 0x0600EC08 RID: 60424 RVA: 0x0007E628 File Offset: 0x0007C828
			public unsafe Action<GuestGroupController> __9__97
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__97);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__97), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CC2 RID: 19650
			// (get) Token: 0x0600EC09 RID: 60425 RVA: 0x00384B50 File Offset: 0x00382D50
			// (set) Token: 0x0600EC0A RID: 60426 RVA: 0x0007E647 File Offset: 0x0007C847
			public unsafe Func<int, bool> __9__102
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__102);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__102), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CC3 RID: 19651
			// (get) Token: 0x0600EC0B RID: 60427 RVA: 0x00384B80 File Offset: 0x00382D80
			// (set) Token: 0x0600EC0C RID: 60428 RVA: 0x0007E666 File Offset: 0x0007C866
			public unsafe Func<bool> __9__93
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__93);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__93), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CC4 RID: 19652
			// (get) Token: 0x0600EC0D RID: 60429 RVA: 0x00384BB0 File Offset: 0x00382DB0
			// (set) Token: 0x0600EC0E RID: 60430 RVA: 0x0007E685 File Offset: 0x0007C885
			public unsafe Action<GuestGroupController.EvaluationResult> __9__110
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__110);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GuestGroupController.EvaluationResult>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.NativeFieldInfoPtr___9__110), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009602 RID: 38402
			private static readonly IntPtr NativeFieldInfoPtr_isTimeEnd;

			// Token: 0x04009603 RID: 38403
			private static readonly IntPtr NativeFieldInfoPtr_thisSingleRoundDuration;

			// Token: 0x04009604 RID: 38404
			private static readonly IntPtr NativeFieldInfoPtr_eventManager;

			// Token: 0x04009605 RID: 38405
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009606 RID: 38406
			private static readonly IntPtr NativeFieldInfoPtr_canContinue;

			// Token: 0x04009607 RID: 38407
			private static readonly IntPtr NativeFieldInfoPtr_currentScore;

			// Token: 0x04009608 RID: 38408
			private static readonly IntPtr NativeFieldInfoPtr_statusDisplayer;

			// Token: 0x04009609 RID: 38409
			private static readonly IntPtr NativeFieldInfoPtr_uiManager;

			// Token: 0x0400960A RID: 38410
			private static readonly IntPtr NativeFieldInfoPtr_canContinueYieldInstruction;

			// Token: 0x0400960B RID: 38411
			private static readonly IntPtr NativeFieldInfoPtr_onChallengeEnd;

			// Token: 0x0400960C RID: 38412
			private static readonly IntPtr NativeFieldInfoPtr_guestsManager;

			// Token: 0x0400960D RID: 38413
			private static readonly IntPtr NativeFieldInfoPtr_koishiBossData;

			// Token: 0x0400960E RID: 38414
			private static readonly IntPtr NativeFieldInfoPtr_phase1TargetScore;

			// Token: 0x0400960F RID: 38415
			private static readonly IntPtr NativeFieldInfoPtr_wackyTag;

			// Token: 0x04009610 RID: 38416
			private static readonly IntPtr NativeFieldInfoPtr_allSpecialGuest;

			// Token: 0x04009611 RID: 38417
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestInScene;

			// Token: 0x04009612 RID: 38418
			private static readonly IntPtr NativeFieldInfoPtr_waitForTagSeconds;

			// Token: 0x04009613 RID: 38419
			private static readonly IntPtr NativeFieldInfoPtr_phase2TargetScore;

			// Token: 0x04009614 RID: 38420
			private static readonly IntPtr NativeFieldInfoPtr_postprocessCharacterCallback;

			// Token: 0x04009615 RID: 38421
			private static readonly IntPtr NativeFieldInfoPtr_likeFoodTagNum;

			// Token: 0x04009616 RID: 38422
			private static readonly IntPtr NativeFieldInfoPtr_koishi;

			// Token: 0x04009617 RID: 38423
			private static readonly IntPtr NativeFieldInfoPtr_koishiTag;

			// Token: 0x04009618 RID: 38424
			private static readonly IntPtr NativeFieldInfoPtr_allKoishiSelectedFood;

			// Token: 0x04009619 RID: 38425
			private static readonly IntPtr NativeFieldInfoPtr_allFoodTagsPool;

			// Token: 0x0400961A RID: 38426
			private static readonly IntPtr NativeFieldInfoPtr_hateFoodTagNum;

			// Token: 0x0400961B RID: 38427
			private static readonly IntPtr NativeFieldInfoPtr_allBevTagsPool;

			// Token: 0x0400961C RID: 38428
			private static readonly IntPtr NativeFieldInfoPtr_likeBevTagNum;

			// Token: 0x0400961D RID: 38429
			private static readonly IntPtr NativeFieldInfoPtr_canSpawnStand;

			// Token: 0x0400961E RID: 38430
			private static readonly IntPtr NativeFieldInfoPtr_interrupt;

			// Token: 0x0400961F RID: 38431
			private static readonly IntPtr NativeFieldInfoPtr_characterControllerUnit;

			// Token: 0x04009620 RID: 38432
			private static readonly IntPtr NativeFieldInfoPtr_oldFace;

			// Token: 0x04009621 RID: 38433
			private static readonly IntPtr NativeFieldInfoPtr_highlightRenderer;

			// Token: 0x04009622 RID: 38434
			private static readonly IntPtr NativeFieldInfoPtr_highlightObject;

			// Token: 0x04009623 RID: 38435
			private static readonly IntPtr NativeFieldInfoPtr_phase3TargetScore;

			// Token: 0x04009624 RID: 38436
			private static readonly IntPtr NativeFieldInfoPtr_tagChangeLoop;

			// Token: 0x04009625 RID: 38437
			private static readonly IntPtr NativeFieldInfoPtr_isShieldRecovering;

			// Token: 0x04009626 RID: 38438
			private static readonly IntPtr NativeFieldInfoPtr_pannelCanvas;

			// Token: 0x04009627 RID: 38439
			private static readonly IntPtr NativeFieldInfoPtr_koishiEye;

			// Token: 0x04009628 RID: 38440
			private static readonly IntPtr NativeFieldInfoPtr_koishiTablePosition;

			// Token: 0x04009629 RID: 38441
			private static readonly IntPtr NativeFieldInfoPtr_isEasy;

			// Token: 0x0400962A RID: 38442
			private static readonly IntPtr NativeFieldInfoPtr_haveShieldBroken;

			// Token: 0x0400962B RID: 38443
			private static readonly IntPtr NativeFieldInfoPtr_mainLoop;

			// Token: 0x0400962C RID: 38444
			private static readonly IntPtr NativeFieldInfoPtr_waitForShieldRespawn;

			// Token: 0x0400962D RID: 38445
			private static readonly IntPtr NativeFieldInfoPtr_koishiData;

			// Token: 0x0400962E RID: 38446
			private static readonly IntPtr NativeFieldInfoPtr_koishiObjectName;

			// Token: 0x0400962F RID: 38447
			private static readonly IntPtr NativeFieldInfoPtr_interruptActions;

			// Token: 0x04009630 RID: 38448
			private static readonly IntPtr NativeFieldInfoPtr_types;

			// Token: 0x04009631 RID: 38449
			private static readonly IntPtr NativeFieldInfoPtr_typeAlpha;

			// Token: 0x04009632 RID: 38450
			private static readonly IntPtr NativeFieldInfoPtr_orderDisplayer;

			// Token: 0x04009633 RID: 38451
			private static readonly IntPtr NativeFieldInfoPtr_cookControllersBase;

			// Token: 0x04009634 RID: 38452
			private static readonly IntPtr NativeFieldInfoPtr_cookingSystem;

			// Token: 0x04009635 RID: 38453
			private static readonly IntPtr NativeFieldInfoPtr_tryTime;

			// Token: 0x04009636 RID: 38454
			private static readonly IntPtr NativeFieldInfoPtr_tags;

			// Token: 0x04009637 RID: 38455
			private static readonly IntPtr NativeFieldInfoPtr_koishiSeatPostion;

			// Token: 0x04009638 RID: 38456
			private static readonly IntPtr NativeFieldInfoPtr_icons;

			// Token: 0x04009639 RID: 38457
			private static readonly IntPtr NativeFieldInfoPtr_koishiCorotine;

			// Token: 0x0400963A RID: 38458
			private static readonly IntPtr NativeFieldInfoPtr_allSelectedFood;

			// Token: 0x0400963B RID: 38459
			private static readonly IntPtr NativeFieldInfoPtr_allSelectedBev;

			// Token: 0x0400963C RID: 38460
			private static readonly IntPtr NativeFieldInfoPtr_levelToDamageDic;

			// Token: 0x0400963D RID: 38461
			private static readonly IntPtr NativeFieldInfoPtr_giveBadge;

			// Token: 0x0400963E RID: 38462
			private static readonly IntPtr NativeFieldInfoPtr___9__73;

			// Token: 0x0400963F RID: 38463
			private static readonly IntPtr NativeFieldInfoPtr___9__97;

			// Token: 0x04009640 RID: 38464
			private static readonly IntPtr NativeFieldInfoPtr___9__102;

			// Token: 0x04009641 RID: 38465
			private static readonly IntPtr NativeFieldInfoPtr___9__93;

			// Token: 0x04009642 RID: 38466
			private static readonly IntPtr NativeFieldInfoPtr___9__110;

			// Token: 0x04009643 RID: 38467
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009644 RID: 38468
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Func_1_Boolean_0;

			// Token: 0x04009645 RID: 38469
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__1_Internal_Boolean_0;

			// Token: 0x04009646 RID: 38470
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_0;

			// Token: 0x04009647 RID: 38471
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_0;

			// Token: 0x04009648 RID: 38472
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__62_Internal_Void_4;

			// Token: 0x04009649 RID: 38473
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__5_Internal_Void_4;

			// Token: 0x0400964A RID: 38474
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x0400964B RID: 38475
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_0;

			// Token: 0x0400964C RID: 38476
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0;

			// Token: 0x0400964D RID: 38477
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__8_Internal_Boolean_0;

			// Token: 0x0400964E RID: 38478
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__9_Internal_Void_GuestGroupController_0;

			// Token: 0x0400964F RID: 38479
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__10_Internal_Void_GuestGroupController_0;

			// Token: 0x04009650 RID: 38480
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__11_Internal_Void_4;

			// Token: 0x04009651 RID: 38481
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__12_Internal_Void_4;

			// Token: 0x04009652 RID: 38482
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04009653 RID: 38483
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__14_Internal_Boolean_Int32_0;

			// Token: 0x04009654 RID: 38484
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04009655 RID: 38485
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_1;

			// Token: 0x04009656 RID: 38486
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__73_Internal_Boolean_Int32_0;

			// Token: 0x04009657 RID: 38487
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x04009658 RID: 38488
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__18_Internal_Boolean_0;

			// Token: 0x04009659 RID: 38489
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__19_Internal_Void_GuestGroupController_0;

			// Token: 0x0400965A RID: 38490
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__20_Internal_Void_GuestGroupController_0;

			// Token: 0x0400965B RID: 38491
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__21_Internal_Void_4;

			// Token: 0x0400965C RID: 38492
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__22_Internal_Void_AStarInputGeneratorComponent_0;

			// Token: 0x0400965D RID: 38493
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__23_Internal_Action_1_AStarInputGeneratorComponent_0;

			// Token: 0x0400965E RID: 38494
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__24_Internal_Void_4;

			// Token: 0x0400965F RID: 38495
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__31_Internal_Boolean_Recipe_0;

			// Token: 0x04009660 RID: 38496
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_1;

			// Token: 0x04009661 RID: 38497
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_2;

			// Token: 0x04009662 RID: 38498
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__77_Internal_Boolean_Int32_0;

			// Token: 0x04009663 RID: 38499
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__79_Internal_Void_4;

			// Token: 0x04009664 RID: 38500
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_2;

			// Token: 0x04009665 RID: 38501
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_3;

			// Token: 0x04009666 RID: 38502
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_1;

			// Token: 0x04009667 RID: 38503
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Int32_0;

			// Token: 0x04009668 RID: 38504
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_4;

			// Token: 0x04009669 RID: 38505
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_1;

			// Token: 0x0400966A RID: 38506
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Int32_PDM_2;

			// Token: 0x0400966B RID: 38507
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_3;

			// Token: 0x0400966C RID: 38508
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Single_Int32_0;

			// Token: 0x0400966D RID: 38509
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__89_Internal_Single_KeyValuePair_2_Int32_Int32_0;

			// Token: 0x0400966E RID: 38510
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_5;

			// Token: 0x0400966F RID: 38511
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04009670 RID: 38512
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__90_Internal_Void_GuestGroupController_0;

			// Token: 0x04009671 RID: 38513
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_6;

			// Token: 0x04009672 RID: 38514
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__97_Internal_Void_GuestGroupController_0;

			// Token: 0x04009673 RID: 38515
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_2;

			// Token: 0x04009674 RID: 38516
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__102_Internal_Boolean_Int32_0;

			// Token: 0x04009675 RID: 38517
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__93_Internal_Boolean_0;

			// Token: 0x04009676 RID: 38518
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Boolean_Sellable_PDM_0;

			// Token: 0x04009677 RID: 38519
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__105_Internal_Boolean_Int32_0;

			// Token: 0x04009678 RID: 38520
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_OrderBase_GuestGroupController_byref_String_PDM_1;

			// Token: 0x04009679 RID: 38521
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__106_Internal_Boolean_Int32_0;

			// Token: 0x0400967A RID: 38522
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_2;

			// Token: 0x0400967B RID: 38523
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__108_Internal_Boolean_0;

			// Token: 0x0400967C RID: 38524
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__109_Internal_Boolean_0;

			// Token: 0x0400967D RID: 38525
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__110_Internal_Void_EvaluationResult_0;

			// Token: 0x0400967E RID: 38526
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_3;

			// Token: 0x0400967F RID: 38527
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__55_Internal_Boolean_0;

			// Token: 0x04009680 RID: 38528
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__57_Internal_Void_Coroutine_0;

			// Token: 0x04009681 RID: 38529
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__58_Internal_Void_GuestGroupController_0;

			// Token: 0x04009682 RID: 38530
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__59_Internal_Void_4;

			// Token: 0x04009683 RID: 38531
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_1;

			// Token: 0x0200106F RID: 4207
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__Timing|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011EE6 RID: 73446 RVA: 0x004196D4 File Offset: 0x004178D4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__Timing|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr_extraTiming = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "extraTiming");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__totalCountDown_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<totalCountDown>5__2");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__progress_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, "<progress>5__3");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681702);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681703);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681704);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681705);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681706);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr, 100681707);
				}

				// Token: 0x06011EE7 RID: 73447 RVA: 0x004197F0 File Offset: 0x004179F0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EE8 RID: 73448 RVA: 0x00419838 File Offset: 0x00417A38
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EE9 RID: 73449 RVA: 0x0041986C File Offset: 0x00417A6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222054, XrefRangeEnd = 222057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D83 RID: 23939
				// (get) Token: 0x06011EEA RID: 73450 RVA: 0x004198A8 File Offset: 0x00417AA8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011EEB RID: 73451 RVA: 0x004198E8 File Offset: 0x00417AE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222057, XrefRangeEnd = 222063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D84 RID: 23940
				// (get) Token: 0x06011EEC RID: 73452 RVA: 0x0041991C File Offset: 0x00417B1C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011EED RID: 73453 RVA: 0x0009BC9E File Offset: 0x00099E9E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D7D RID: 23933
				// (get) Token: 0x06011EEE RID: 73454 RVA: 0x0041995C File Offset: 0x00417B5C
				// (set) Token: 0x06011EEF RID: 73455 RVA: 0x0009BCA7 File Offset: 0x00099EA7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D7E RID: 23934
				// (get) Token: 0x06011EF0 RID: 73456 RVA: 0x00419984 File Offset: 0x00417B84
				// (set) Token: 0x06011EF1 RID: 73457 RVA: 0x0009BCC2 File Offset: 0x00099EC2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D7F RID: 23935
				// (get) Token: 0x06011EF2 RID: 73458 RVA: 0x004199B4 File Offset: 0x00417BB4
				// (set) Token: 0x06011EF3 RID: 73459 RVA: 0x0009BCE1 File Offset: 0x00099EE1
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D80 RID: 23936
				// (get) Token: 0x06011EF4 RID: 73460 RVA: 0x004199E4 File Offset: 0x00417BE4
				// (set) Token: 0x06011EF5 RID: 73461 RVA: 0x0009BD00 File Offset: 0x00099F00
				public unsafe Func<bool> extraTiming
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr_extraTiming);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr_extraTiming), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D81 RID: 23937
				// (get) Token: 0x06011EF6 RID: 73462 RVA: 0x00419A14 File Offset: 0x00417C14
				// (set) Token: 0x06011EF7 RID: 73463 RVA: 0x0009BD1F File Offset: 0x00099F1F
				public unsafe int _totalCountDown_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__totalCountDown_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__totalCountDown_5__2)) = value;
					}
				}

				// Token: 0x17005D82 RID: 23938
				// (get) Token: 0x06011EF8 RID: 73464 RVA: 0x00419A3C File Offset: 0x00417C3C
				// (set) Token: 0x06011EF9 RID: 73465 RVA: 0x0009BD3A File Offset: 0x00099F3A
				public unsafe float _progress_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__progress_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObFu1BoexSiInObObUnique.NativeFieldInfoPtr__progress_5__3)) = value;
					}
				}

				// Token: 0x0400B5B5 RID: 46517
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B5B6 RID: 46518
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B5B7 RID: 46519
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B5B8 RID: 46520
				private static readonly IntPtr NativeFieldInfoPtr_extraTiming;

				// Token: 0x0400B5B9 RID: 46521
				private static readonly IntPtr NativeFieldInfoPtr__totalCountDown_5__2;

				// Token: 0x0400B5BA RID: 46522
				private static readonly IntPtr NativeFieldInfoPtr__progress_5__3;

				// Token: 0x0400B5BB RID: 46523
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B5BC RID: 46524
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5BD RID: 46525
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5BE RID: 46526
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5BF RID: 46527
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5C0 RID: 46528
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001070 RID: 4208
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__OnFail|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0 : Il2CppSystem.Object
			{
				// Token: 0x06011EFA RID: 73466 RVA: 0x00419A64 File Offset: 0x00417C64
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__OnFail|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681708);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681709);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681710);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681711);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681712);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr, 100681713);
				}

				// Token: 0x06011EFB RID: 73467 RVA: 0x00419B44 File Offset: 0x00417D44
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EFC RID: 73468 RVA: 0x00419B8C File Offset: 0x00417D8C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011EFD RID: 73469 RVA: 0x00419BC0 File Offset: 0x00417DC0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222063, XrefRangeEnd = 222083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D88 RID: 23944
				// (get) Token: 0x06011EFE RID: 73470 RVA: 0x00419BFC File Offset: 0x00417DFC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011EFF RID: 73471 RVA: 0x00419C3C File Offset: 0x00417E3C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222083, XrefRangeEnd = 222089, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D89 RID: 23945
				// (get) Token: 0x06011F00 RID: 73472 RVA: 0x00419C70 File Offset: 0x00417E70
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F01 RID: 73473 RVA: 0x0009BD55 File Offset: 0x00099F55
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D85 RID: 23941
				// (get) Token: 0x06011F02 RID: 73474 RVA: 0x00419CB0 File Offset: 0x00417EB0
				// (set) Token: 0x06011F03 RID: 73475 RVA: 0x0009BD5E File Offset: 0x00099F5E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D86 RID: 23942
				// (get) Token: 0x06011F04 RID: 73476 RVA: 0x00419CD8 File Offset: 0x00417ED8
				// (set) Token: 0x06011F05 RID: 73477 RVA: 0x0009BD79 File Offset: 0x00099F79
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D87 RID: 23943
				// (get) Token: 0x06011F06 RID: 73478 RVA: 0x00419D08 File Offset: 0x00417F08
				// (set) Token: 0x06011F07 RID: 73479 RVA: 0x0009BD98 File Offset: 0x00099F98
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B5C1 RID: 46529
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B5C2 RID: 46530
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B5C3 RID: 46531
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B5C4 RID: 46532
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B5C5 RID: 46533
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5C6 RID: 46534
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5C7 RID: 46535
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5C8 RID: 46536
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5C9 RID: 46537
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001071 RID: 4209
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__Phase2GuestSpawnLoop|16>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011F08 RID: 73480 RVA: 0x00419D38 File Offset: 0x00417F38
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase2GuestSpawnLoop|16>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr__spawnInterval_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, "<spawnInterval>5__2");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100681714);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100681715);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100681716);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100681717);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100681718);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr, 100681719);
				}

				// Token: 0x06011F09 RID: 73481 RVA: 0x00419E2C File Offset: 0x0041802C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F0A RID: 73482 RVA: 0x00419E74 File Offset: 0x00418074
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F0B RID: 73483 RVA: 0x00419EA8 File Offset: 0x004180A8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222089, XrefRangeEnd = 222133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D8E RID: 23950
				// (get) Token: 0x06011F0C RID: 73484 RVA: 0x00419EE4 File Offset: 0x004180E4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F0D RID: 73485 RVA: 0x00419F24 File Offset: 0x00418124
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222133, XrefRangeEnd = 222139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D8F RID: 23951
				// (get) Token: 0x06011F0E RID: 73486 RVA: 0x00419F58 File Offset: 0x00418158
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F0F RID: 73487 RVA: 0x0009BDB7 File Offset: 0x00099FB7
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D8A RID: 23946
				// (get) Token: 0x06011F10 RID: 73488 RVA: 0x00419F98 File Offset: 0x00418198
				// (set) Token: 0x06011F11 RID: 73489 RVA: 0x0009BDC0 File Offset: 0x00099FC0
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D8B RID: 23947
				// (get) Token: 0x06011F12 RID: 73490 RVA: 0x00419FC0 File Offset: 0x004181C0
				// (set) Token: 0x06011F13 RID: 73491 RVA: 0x0009BDDB File Offset: 0x00099FDB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D8C RID: 23948
				// (get) Token: 0x06011F14 RID: 73492 RVA: 0x00419FF0 File Offset: 0x004181F0
				// (set) Token: 0x06011F15 RID: 73493 RVA: 0x0009BDFA File Offset: 0x00099FFA
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D8D RID: 23949
				// (get) Token: 0x06011F16 RID: 73494 RVA: 0x0041A020 File Offset: 0x00418220
				// (set) Token: 0x06011F17 RID: 73495 RVA: 0x0009BE19 File Offset: 0x0009A019
				public unsafe Vector2Int _spawnInterval_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr__spawnInterval_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeObObUnique.NativeFieldInfoPtr__spawnInterval_5__2)) = value;
					}
				}

				// Token: 0x0400B5CA RID: 46538
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B5CB RID: 46539
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B5CC RID: 46540
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B5CD RID: 46541
				private static readonly IntPtr NativeFieldInfoPtr__spawnInterval_5__2;

				// Token: 0x0400B5CE RID: 46542
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B5CF RID: 46543
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5D0 RID: 46544
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5D1 RID: 46545
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5D2 RID: 46546
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5D3 RID: 46547
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001072 RID: 4210
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__Phase2TimedChangeTag|17>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0 : Il2CppSystem.Object
			{
				// Token: 0x06011F18 RID: 73496 RVA: 0x0041A048 File Offset: 0x00418248
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase2TimedChangeTag|17>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr__tagRreshTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, "<tagRreshTime>5__2");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr__currentProgress_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, "<currentProgress>5__3");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, 100681720);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, 100681721);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, 100681722);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, 100681723);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, 100681724);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr, 100681725);
				}

				// Token: 0x06011F19 RID: 73497 RVA: 0x0041A150 File Offset: 0x00418350
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F1A RID: 73498 RVA: 0x0041A198 File Offset: 0x00418398
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F1B RID: 73499 RVA: 0x0041A1CC File Offset: 0x004183CC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222139, XrefRangeEnd = 222146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D95 RID: 23957
				// (get) Token: 0x06011F1C RID: 73500 RVA: 0x0041A208 File Offset: 0x00418408
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F1D RID: 73501 RVA: 0x0041A248 File Offset: 0x00418448
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222146, XrefRangeEnd = 222152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D96 RID: 23958
				// (get) Token: 0x06011F1E RID: 73502 RVA: 0x0041A27C File Offset: 0x0041847C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F1F RID: 73503 RVA: 0x0009BE34 File Offset: 0x0009A034
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D90 RID: 23952
				// (get) Token: 0x06011F20 RID: 73504 RVA: 0x0041A2BC File Offset: 0x004184BC
				// (set) Token: 0x06011F21 RID: 73505 RVA: 0x0009BE3D File Offset: 0x0009A03D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D91 RID: 23953
				// (get) Token: 0x06011F22 RID: 73506 RVA: 0x0041A2E4 File Offset: 0x004184E4
				// (set) Token: 0x06011F23 RID: 73507 RVA: 0x0009BE58 File Offset: 0x0009A058
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D92 RID: 23954
				// (get) Token: 0x06011F24 RID: 73508 RVA: 0x0041A314 File Offset: 0x00418514
				// (set) Token: 0x06011F25 RID: 73509 RVA: 0x0009BE77 File Offset: 0x0009A077
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D93 RID: 23955
				// (get) Token: 0x06011F26 RID: 73510 RVA: 0x0041A344 File Offset: 0x00418544
				// (set) Token: 0x06011F27 RID: 73511 RVA: 0x0009BE96 File Offset: 0x0009A096
				public unsafe int _tagRreshTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr__tagRreshTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr__tagRreshTime_5__2)) = value;
					}
				}

				// Token: 0x17005D94 RID: 23956
				// (get) Token: 0x06011F28 RID: 73512 RVA: 0x0041A36C File Offset: 0x0041856C
				// (set) Token: 0x06011F29 RID: 73513 RVA: 0x0009BEB1 File Offset: 0x0009A0B1
				public unsafe int _currentProgress_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr__currentProgress_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb0.NativeFieldInfoPtr__currentProgress_5__3)) = value;
					}
				}

				// Token: 0x0400B5D4 RID: 46548
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B5D5 RID: 46549
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B5D6 RID: 46550
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B5D7 RID: 46551
				private static readonly IntPtr NativeFieldInfoPtr__tagRreshTime_5__2;

				// Token: 0x0400B5D8 RID: 46552
				private static readonly IntPtr NativeFieldInfoPtr__currentProgress_5__3;

				// Token: 0x0400B5D9 RID: 46553
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B5DA RID: 46554
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5DB RID: 46555
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5DC RID: 46556
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5DD RID: 46557
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5DE RID: 46558
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001073 RID: 4211
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__HighlightFollow|41>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1 : Il2CppSystem.Object
			{
				// Token: 0x06011F2A RID: 73514 RVA: 0x0041A394 File Offset: 0x00418594
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__HighlightFollow|41>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681726);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681727);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681728);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681729);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681730);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr, 100681731);
				}

				// Token: 0x06011F2B RID: 73515 RVA: 0x0041A474 File Offset: 0x00418674
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F2C RID: 73516 RVA: 0x0041A4BC File Offset: 0x004186BC
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F2D RID: 73517 RVA: 0x0041A4F0 File Offset: 0x004186F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222152, XrefRangeEnd = 222162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D9A RID: 23962
				// (get) Token: 0x06011F2E RID: 73518 RVA: 0x0041A52C File Offset: 0x0041872C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F2F RID: 73519 RVA: 0x0041A56C File Offset: 0x0041876C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222162, XrefRangeEnd = 222168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D9B RID: 23963
				// (get) Token: 0x06011F30 RID: 73520 RVA: 0x0041A5A0 File Offset: 0x004187A0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F31 RID: 73521 RVA: 0x0009BECC File Offset: 0x0009A0CC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D97 RID: 23959
				// (get) Token: 0x06011F32 RID: 73522 RVA: 0x0041A5E0 File Offset: 0x004187E0
				// (set) Token: 0x06011F33 RID: 73523 RVA: 0x0009BED5 File Offset: 0x0009A0D5
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D98 RID: 23960
				// (get) Token: 0x06011F34 RID: 73524 RVA: 0x0041A608 File Offset: 0x00418808
				// (set) Token: 0x06011F35 RID: 73525 RVA: 0x0009BEF0 File Offset: 0x0009A0F0
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D99 RID: 23961
				// (get) Token: 0x06011F36 RID: 73526 RVA: 0x0041A638 File Offset: 0x00418838
				// (set) Token: 0x06011F37 RID: 73527 RVA: 0x0009BF0F File Offset: 0x0009A10F
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B5DF RID: 46559
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B5E0 RID: 46560
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B5E1 RID: 46561
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B5E2 RID: 46562
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B5E3 RID: 46563
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5E4 RID: 46564
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5E5 RID: 46565
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5E6 RID: 46566
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5E7 RID: 46567
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001074 RID: 4212
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__Phase3TimedShield|42>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique : Il2CppSystem.Object
			{
				// Token: 0x06011F38 RID: 73528 RVA: 0x0041A668 File Offset: 0x00418868
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase3TimedShield|42>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__thisScore_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, "<thisScore>5__2");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__durationPerWave_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, "<durationPerWave>5__3");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__maxScoreGet_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, "<maxScoreGet>5__4");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__currentProgress_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, "<currentProgress>5__5");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, 100681732);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, 100681733);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, 100681734);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, 100681735);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, 100681736);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr, 100681737);
				}

				// Token: 0x06011F39 RID: 73529 RVA: 0x0041A798 File Offset: 0x00418998
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F3A RID: 73530 RVA: 0x0041A7E0 File Offset: 0x004189E0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F3B RID: 73531 RVA: 0x0041A814 File Offset: 0x00418A14
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222168, XrefRangeEnd = 222209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DA3 RID: 23971
				// (get) Token: 0x06011F3C RID: 73532 RVA: 0x0041A850 File Offset: 0x00418A50
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F3D RID: 73533 RVA: 0x0041A890 File Offset: 0x00418A90
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222209, XrefRangeEnd = 222215, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DA4 RID: 23972
				// (get) Token: 0x06011F3E RID: 73534 RVA: 0x0041A8C4 File Offset: 0x00418AC4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F3F RID: 73535 RVA: 0x0009BF2E File Offset: 0x0009A12E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D9C RID: 23964
				// (get) Token: 0x06011F40 RID: 73536 RVA: 0x0041A904 File Offset: 0x00418B04
				// (set) Token: 0x06011F41 RID: 73537 RVA: 0x0009BF37 File Offset: 0x0009A137
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D9D RID: 23965
				// (get) Token: 0x06011F42 RID: 73538 RVA: 0x0041A92C File Offset: 0x00418B2C
				// (set) Token: 0x06011F43 RID: 73539 RVA: 0x0009BF52 File Offset: 0x0009A152
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D9E RID: 23966
				// (get) Token: 0x06011F44 RID: 73540 RVA: 0x0041A95C File Offset: 0x00418B5C
				// (set) Token: 0x06011F45 RID: 73541 RVA: 0x0009BF71 File Offset: 0x0009A171
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D9F RID: 23967
				// (get) Token: 0x06011F46 RID: 73542 RVA: 0x0041A98C File Offset: 0x00418B8C
				// (set) Token: 0x06011F47 RID: 73543 RVA: 0x0009BF90 File Offset: 0x0009A190
				public unsafe int _thisScore_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__thisScore_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__thisScore_5__2)) = value;
					}
				}

				// Token: 0x17005DA0 RID: 23968
				// (get) Token: 0x06011F48 RID: 73544 RVA: 0x0041A9B4 File Offset: 0x00418BB4
				// (set) Token: 0x06011F49 RID: 73545 RVA: 0x0009BFAB File Offset: 0x0009A1AB
				public unsafe int _durationPerWave_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__durationPerWave_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__durationPerWave_5__3)) = value;
					}
				}

				// Token: 0x17005DA1 RID: 23969
				// (get) Token: 0x06011F4A RID: 73546 RVA: 0x0041A9DC File Offset: 0x00418BDC
				// (set) Token: 0x06011F4B RID: 73547 RVA: 0x0009BFC6 File Offset: 0x0009A1C6
				public unsafe int _maxScoreGet_5__4
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__maxScoreGet_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__maxScoreGet_5__4)) = value;
					}
				}

				// Token: 0x17005DA2 RID: 23970
				// (get) Token: 0x06011F4C RID: 73548 RVA: 0x0041AA04 File Offset: 0x00418C04
				// (set) Token: 0x06011F4D RID: 73549 RVA: 0x0009BFE1 File Offset: 0x0009A1E1
				public unsafe int _currentProgress_5__5
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__currentProgress_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObInObInObInInUnique.NativeFieldInfoPtr__currentProgress_5__5)) = value;
					}
				}

				// Token: 0x0400B5E8 RID: 46568
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B5E9 RID: 46569
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B5EA RID: 46570
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B5EB RID: 46571
				private static readonly IntPtr NativeFieldInfoPtr__thisScore_5__2;

				// Token: 0x0400B5EC RID: 46572
				private static readonly IntPtr NativeFieldInfoPtr__durationPerWave_5__3;

				// Token: 0x0400B5ED RID: 46573
				private static readonly IntPtr NativeFieldInfoPtr__maxScoreGet_5__4;

				// Token: 0x0400B5EE RID: 46574
				private static readonly IntPtr NativeFieldInfoPtr__currentProgress_5__5;

				// Token: 0x0400B5EF RID: 46575
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B5F0 RID: 46576
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5F1 RID: 46577
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5F2 RID: 46578
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5F3 RID: 46579
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5F4 RID: 46580
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001075 RID: 4213
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__Phase3TimedChangeTag|43>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1 : Il2CppSystem.Object
			{
				// Token: 0x06011F4E RID: 73550 RVA: 0x0041AA2C File Offset: 0x00418C2C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase3TimedChangeTag|43>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr__tagRreshTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, "<tagRreshTime>5__2");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr__currentProgress_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, "<currentProgress>5__3");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, 100681738);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, 100681739);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, 100681740);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, 100681741);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, 100681742);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr, 100681743);
				}

				// Token: 0x06011F4F RID: 73551 RVA: 0x0041AB34 File Offset: 0x00418D34
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F50 RID: 73552 RVA: 0x0041AB7C File Offset: 0x00418D7C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F51 RID: 73553 RVA: 0x0041ABB0 File Offset: 0x00418DB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222215, XrefRangeEnd = 222221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DAA RID: 23978
				// (get) Token: 0x06011F52 RID: 73554 RVA: 0x0041ABEC File Offset: 0x00418DEC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F53 RID: 73555 RVA: 0x0041AC2C File Offset: 0x00418E2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222221, XrefRangeEnd = 222227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DAB RID: 23979
				// (get) Token: 0x06011F54 RID: 73556 RVA: 0x0041AC60 File Offset: 0x00418E60
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F55 RID: 73557 RVA: 0x0009BFFC File Offset: 0x0009A1FC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DA5 RID: 23973
				// (get) Token: 0x06011F56 RID: 73558 RVA: 0x0041ACA0 File Offset: 0x00418EA0
				// (set) Token: 0x06011F57 RID: 73559 RVA: 0x0009C005 File Offset: 0x0009A205
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DA6 RID: 23974
				// (get) Token: 0x06011F58 RID: 73560 RVA: 0x0041ACC8 File Offset: 0x00418EC8
				// (set) Token: 0x06011F59 RID: 73561 RVA: 0x0009C020 File Offset: 0x0009A220
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DA7 RID: 23975
				// (get) Token: 0x06011F5A RID: 73562 RVA: 0x0041ACF8 File Offset: 0x00418EF8
				// (set) Token: 0x06011F5B RID: 73563 RVA: 0x0009C03F File Offset: 0x0009A23F
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DA8 RID: 23976
				// (get) Token: 0x06011F5C RID: 73564 RVA: 0x0041AD28 File Offset: 0x00418F28
				// (set) Token: 0x06011F5D RID: 73565 RVA: 0x0009C05E File Offset: 0x0009A25E
				public unsafe int _tagRreshTime_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr__tagRreshTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr__tagRreshTime_5__2)) = value;
					}
				}

				// Token: 0x17005DA9 RID: 23977
				// (get) Token: 0x06011F5E RID: 73566 RVA: 0x0041AD50 File Offset: 0x00418F50
				// (set) Token: 0x06011F5F RID: 73567 RVA: 0x0009C079 File Offset: 0x0009A279
				public unsafe int _currentProgress_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr__currentProgress_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoInOb1.NativeFieldInfoPtr__currentProgress_5__3)) = value;
					}
				}

				// Token: 0x0400B5F5 RID: 46581
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B5F6 RID: 46582
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B5F7 RID: 46583
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B5F8 RID: 46584
				private static readonly IntPtr NativeFieldInfoPtr__tagRreshTime_5__2;

				// Token: 0x0400B5F9 RID: 46585
				private static readonly IntPtr NativeFieldInfoPtr__currentProgress_5__3;

				// Token: 0x0400B5FA RID: 46586
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B5FB RID: 46587
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5FC RID: 46588
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B5FD RID: 46589
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B5FE RID: 46590
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B5FF RID: 46591
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001076 RID: 4214
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__Delay|80>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2 : Il2CppSystem.Object
			{
				// Token: 0x06011F60 RID: 73568 RVA: 0x0041AD78 File Offset: 0x00418F78
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__Delay|80>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681744);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681745);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681746);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681747);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681748);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr, 100681749);
				}

				// Token: 0x06011F61 RID: 73569 RVA: 0x0041AE58 File Offset: 0x00419058
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F62 RID: 73570 RVA: 0x0041AEA0 File Offset: 0x004190A0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F63 RID: 73571 RVA: 0x0041AED4 File Offset: 0x004190D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222227, XrefRangeEnd = 222233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DAF RID: 23983
				// (get) Token: 0x06011F64 RID: 73572 RVA: 0x0041AF10 File Offset: 0x00419110
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F65 RID: 73573 RVA: 0x0041AF50 File Offset: 0x00419150
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222233, XrefRangeEnd = 222239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DB0 RID: 23984
				// (get) Token: 0x06011F66 RID: 73574 RVA: 0x0041AF84 File Offset: 0x00419184
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F67 RID: 73575 RVA: 0x0009C094 File Offset: 0x0009A294
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DAC RID: 23980
				// (get) Token: 0x06011F68 RID: 73576 RVA: 0x0041AFC4 File Offset: 0x004191C4
				// (set) Token: 0x06011F69 RID: 73577 RVA: 0x0009C09D File Offset: 0x0009A29D
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DAD RID: 23981
				// (get) Token: 0x06011F6A RID: 73578 RVA: 0x0041AFEC File Offset: 0x004191EC
				// (set) Token: 0x06011F6B RID: 73579 RVA: 0x0009C0B8 File Offset: 0x0009A2B8
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DAE RID: 23982
				// (get) Token: 0x06011F6C RID: 73580 RVA: 0x0041B01C File Offset: 0x0041921C
				// (set) Token: 0x06011F6D RID: 73581 RVA: 0x0009C0D7 File Offset: 0x0009A2D7
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B600 RID: 46592
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B601 RID: 46593
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B602 RID: 46594
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B603 RID: 46595
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B604 RID: 46596
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B605 RID: 46597
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B606 RID: 46598
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B607 RID: 46599
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B608 RID: 46600
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001077 RID: 4215
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__CompletelyHideTargetDesk|44>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011F6E RID: 73582 RVA: 0x0041B04C File Offset: 0x0041924C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__CompletelyHideTargetDesk|44>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, "id");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, "<>8__1");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, 100681750);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, 100681751);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, 100681752);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, 100681753);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, 100681754);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr, 100681755);
				}

				// Token: 0x06011F6F RID: 73583 RVA: 0x0041B154 File Offset: 0x00419354
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F70 RID: 73584 RVA: 0x0041B19C File Offset: 0x0041939C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F71 RID: 73585 RVA: 0x0041B1D0 File Offset: 0x004193D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222239, XrefRangeEnd = 222328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DB6 RID: 23990
				// (get) Token: 0x06011F72 RID: 73586 RVA: 0x0041B20C File Offset: 0x0041940C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F73 RID: 73587 RVA: 0x0041B24C File Offset: 0x0041944C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222328, XrefRangeEnd = 222334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DB7 RID: 23991
				// (get) Token: 0x06011F74 RID: 73588 RVA: 0x0041B280 File Offset: 0x00419480
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F75 RID: 73589 RVA: 0x0009C0F6 File Offset: 0x0009A2F6
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DB1 RID: 23985
				// (get) Token: 0x06011F76 RID: 73590 RVA: 0x0041B2C0 File Offset: 0x004194C0
				// (set) Token: 0x06011F77 RID: 73591 RVA: 0x0009C0FF File Offset: 0x0009A2FF
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DB2 RID: 23986
				// (get) Token: 0x06011F78 RID: 73592 RVA: 0x0041B2E8 File Offset: 0x004194E8
				// (set) Token: 0x06011F79 RID: 73593 RVA: 0x0009C11A File Offset: 0x0009A31A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DB3 RID: 23987
				// (get) Token: 0x06011F7A RID: 73594 RVA: 0x0041B318 File Offset: 0x00419518
				// (set) Token: 0x06011F7B RID: 73595 RVA: 0x0009C139 File Offset: 0x0009A339
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DB4 RID: 23988
				// (get) Token: 0x06011F7C RID: 73596 RVA: 0x0041B348 File Offset: 0x00419548
				// (set) Token: 0x06011F7D RID: 73597 RVA: 0x0009C158 File Offset: 0x0009A358
				public unsafe int id
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr_id);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr_id)) = value;
					}
				}

				// Token: 0x17005DB5 RID: 23989
				// (get) Token: 0x06011F7E RID: 73598 RVA: 0x0041B370 File Offset: 0x00419570
				// (set) Token: 0x06011F7F RID: 73599 RVA: 0x0009C173 File Offset: 0x0009A373
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_5 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_5>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObidInObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B609 RID: 46601
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B60A RID: 46602
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B60B RID: 46603
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B60C RID: 46604
				private static readonly IntPtr NativeFieldInfoPtr_id;

				// Token: 0x0400B60D RID: 46605
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B60E RID: 46606
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B60F RID: 46607
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B610 RID: 46608
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B611 RID: 46609
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B612 RID: 46610
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B613 RID: 46611
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001078 RID: 4216
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__TimingAlpha|48>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3 : Il2CppSystem.Object
			{
				// Token: 0x06011F80 RID: 73600 RVA: 0x0041B3A0 File Offset: 0x004195A0
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__TimingAlpha|48>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr, 100681756);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr, 100681757);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr, 100681758);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr, 100681759);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr, 100681760);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr, 100681761);
				}

				// Token: 0x06011F81 RID: 73601 RVA: 0x0041B480 File Offset: 0x00419680
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F82 RID: 73602 RVA: 0x0041B4C8 File Offset: 0x004196C8
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F83 RID: 73603 RVA: 0x0041B4FC File Offset: 0x004196FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222334, XrefRangeEnd = 222341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DBB RID: 23995
				// (get) Token: 0x06011F84 RID: 73604 RVA: 0x0041B538 File Offset: 0x00419738
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F85 RID: 73605 RVA: 0x0041B578 File Offset: 0x00419778
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222341, XrefRangeEnd = 222347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DBC RID: 23996
				// (get) Token: 0x06011F86 RID: 73606 RVA: 0x0041B5AC File Offset: 0x004197AC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F87 RID: 73607 RVA: 0x0009C192 File Offset: 0x0009A392
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DB8 RID: 23992
				// (get) Token: 0x06011F88 RID: 73608 RVA: 0x0041B5EC File Offset: 0x004197EC
				// (set) Token: 0x06011F89 RID: 73609 RVA: 0x0009C19B File Offset: 0x0009A39B
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DB9 RID: 23993
				// (get) Token: 0x06011F8A RID: 73610 RVA: 0x0041B614 File Offset: 0x00419814
				// (set) Token: 0x06011F8B RID: 73611 RVA: 0x0009C1B6 File Offset: 0x0009A3B6
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DBA RID: 23994
				// (get) Token: 0x06011F8C RID: 73612 RVA: 0x0041B644 File Offset: 0x00419844
				// (set) Token: 0x06011F8D RID: 73613 RVA: 0x0009C1D5 File Offset: 0x0009A3D5
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B614 RID: 46612
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B615 RID: 46613
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B616 RID: 46614
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B617 RID: 46615
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B618 RID: 46616
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B619 RID: 46617
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B61A RID: 46618
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B61B RID: 46619
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B61C RID: 46620
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001079 RID: 4217
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__Phase3GuestSpawnLoop|50>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4 : Il2CppSystem.Object
			{
				// Token: 0x06011F8E RID: 73614 RVA: 0x0041B674 File Offset: 0x00419874
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase3GuestSpawnLoop|50>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr, 100681762);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr, 100681763);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr, 100681764);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr, 100681765);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr, 100681766);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr, 100681767);
				}

				// Token: 0x06011F8F RID: 73615 RVA: 0x0041B754 File Offset: 0x00419954
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F90 RID: 73616 RVA: 0x0041B79C File Offset: 0x0041999C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F91 RID: 73617 RVA: 0x0041B7D0 File Offset: 0x004199D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222347, XrefRangeEnd = 222522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DC0 RID: 24000
				// (get) Token: 0x06011F92 RID: 73618 RVA: 0x0041B80C File Offset: 0x00419A0C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F93 RID: 73619 RVA: 0x0041B84C File Offset: 0x00419A4C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222522, XrefRangeEnd = 222528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DC1 RID: 24001
				// (get) Token: 0x06011F94 RID: 73620 RVA: 0x0041B880 File Offset: 0x00419A80
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011F95 RID: 73621 RVA: 0x0009C1F4 File Offset: 0x0009A3F4
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DBD RID: 23997
				// (get) Token: 0x06011F96 RID: 73622 RVA: 0x0041B8C0 File Offset: 0x00419AC0
				// (set) Token: 0x06011F97 RID: 73623 RVA: 0x0009C1FD File Offset: 0x0009A3FD
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DBE RID: 23998
				// (get) Token: 0x06011F98 RID: 73624 RVA: 0x0041B8E8 File Offset: 0x00419AE8
				// (set) Token: 0x06011F99 RID: 73625 RVA: 0x0009C218 File Offset: 0x0009A418
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DBF RID: 23999
				// (get) Token: 0x06011F9A RID: 73626 RVA: 0x0041B918 File Offset: 0x00419B18
				// (set) Token: 0x06011F9B RID: 73627 RVA: 0x0009C237 File Offset: 0x0009A437
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoObMoInVoBoObVo4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B61D RID: 46621
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B61E RID: 46622
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B61F RID: 46623
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B620 RID: 46624
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B621 RID: 46625
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B622 RID: 46626
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B623 RID: 46627
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B624 RID: 46628
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B625 RID: 46629
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x0200107A RID: 4218
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_0+<<MainChallengeLoop>g__Phase3OrderLoop|53>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011F9C RID: 73628 RVA: 0x0041B948 File Offset: 0x00419B48
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0>.NativeClassPtr, "<<MainChallengeLoop>g__Phase3OrderLoop|53>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__waitUnitlShieldRecover_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, "<waitUnitlShieldRecover>5__2");
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100681768);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100681769);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100681770);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100681771);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100681772);
					DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr, 100681773);
				}

				// Token: 0x06011F9D RID: 73629 RVA: 0x0041BA3C File Offset: 0x00419C3C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F9E RID: 73630 RVA: 0x0041BA84 File Offset: 0x00419C84
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011F9F RID: 73631 RVA: 0x0041BAB8 File Offset: 0x00419CB8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222528, XrefRangeEnd = 222550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DC6 RID: 24006
				// (get) Token: 0x06011FA0 RID: 73632 RVA: 0x0041BAF4 File Offset: 0x00419CF4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FA1 RID: 73633 RVA: 0x0041BB34 File Offset: 0x00419D34
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 222550, XrefRangeEnd = 222556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DC7 RID: 24007
				// (get) Token: 0x06011FA2 RID: 73634 RVA: 0x0041BB68 File Offset: 0x00419D68
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FA3 RID: 73635 RVA: 0x0009C256 File Offset: 0x0009A456
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DC2 RID: 24002
				// (get) Token: 0x06011FA4 RID: 73636 RVA: 0x0041BBA8 File Offset: 0x00419DA8
				// (set) Token: 0x06011FA5 RID: 73637 RVA: 0x0009C25F File Offset: 0x0009A45F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DC3 RID: 24003
				// (get) Token: 0x06011FA6 RID: 73638 RVA: 0x0041BBD0 File Offset: 0x00419DD0
				// (set) Token: 0x06011FA7 RID: 73639 RVA: 0x0009C27A File Offset: 0x0009A47A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DC4 RID: 24004
				// (get) Token: 0x06011FA8 RID: 73640 RVA: 0x0041BC00 File Offset: 0x00419E00
				// (set) Token: 0x06011FA9 RID: 73641 RVA: 0x0009C299 File Offset: 0x0009A499
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DC5 RID: 24005
				// (get) Token: 0x06011FAA RID: 73642 RVA: 0x0041BC30 File Offset: 0x00419E30
				// (set) Token: 0x06011FAB RID: 73643 RVA: 0x0009C2B8 File Offset: 0x0009A4B8
				public unsafe WaitUntil _waitUnitlShieldRecover_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__waitUnitlShieldRecover_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitUntil>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObWaObObUnique.NativeFieldInfoPtr__waitUnitlShieldRecover_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B626 RID: 46630
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B627 RID: 46631
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B628 RID: 46632
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B629 RID: 46633
				private static readonly IntPtr NativeFieldInfoPtr__waitUnitlShieldRecover_5__2;

				// Token: 0x0400B62A RID: 46634
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B62B RID: 46635
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B62C RID: 46636
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B62D RID: 46637
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B62E RID: 46638
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B62F RID: 46639
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000CCC RID: 3276
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_1")]
		public sealed class __c__DisplayClass13_1 : Il2CppSystem.Object
		{
			// Token: 0x0600EC0F RID: 60431 RVA: 0x00384BE0 File Offset: 0x00382DE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_1()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_1>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_1.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_1>.NativeClassPtr, "foods");
				DLC2_KoishiBossData.__c__DisplayClass13_1.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_1>.NativeClassPtr, "bevs");
				DLC2_KoishiBossData.__c__DisplayClass13_1.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_1>.NativeClassPtr, "ings");
				DLC2_KoishiBossData.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_1>.NativeClassPtr, 100681774);
				DLC2_KoishiBossData.__c__DisplayClass13_1.NativeMethodInfoPtr__MainChallengeLoop_b__61_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_1>.NativeClassPtr, 100681775);
			}

			// Token: 0x0600EC10 RID: 60432 RVA: 0x00384C70 File Offset: 0x00382E70
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC11 RID: 60433 RVA: 0x00384CAC File Offset: 0x00382EAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__61()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_1.NativeMethodInfoPtr__MainChallengeLoop_b__61_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC12 RID: 60434 RVA: 0x0007E6A4 File Offset: 0x0007C8A4
			public __c__DisplayClass13_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CC5 RID: 19653
			// (get) Token: 0x0600EC13 RID: 60435 RVA: 0x00384CE0 File Offset: 0x00382EE0
			// (set) Token: 0x0600EC14 RID: 60436 RVA: 0x0007E6AD File Offset: 0x0007C8AD
			public unsafe IEnumerable<KeyValuePair<int, int>> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_1.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_1.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CC6 RID: 19654
			// (get) Token: 0x0600EC15 RID: 60437 RVA: 0x00384D10 File Offset: 0x00382F10
			// (set) Token: 0x0600EC16 RID: 60438 RVA: 0x0007E6CC File Offset: 0x0007C8CC
			public unsafe IEnumerable<KeyValuePair<int, int>> bevs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_1.NativeFieldInfoPtr_bevs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_1.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CC7 RID: 19655
			// (get) Token: 0x0600EC17 RID: 60439 RVA: 0x00384D40 File Offset: 0x00382F40
			// (set) Token: 0x0600EC18 RID: 60440 RVA: 0x0007E6EB File Offset: 0x0007C8EB
			public unsafe IEnumerable<KeyValuePair<int, int>> ings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_1.NativeFieldInfoPtr_ings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<int, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_1.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009684 RID: 38532
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x04009685 RID: 38533
			private static readonly IntPtr NativeFieldInfoPtr_bevs;

			// Token: 0x04009686 RID: 38534
			private static readonly IntPtr NativeFieldInfoPtr_ings;

			// Token: 0x04009687 RID: 38535
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009688 RID: 38536
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__61_Internal_Void_0;
		}

		// Token: 0x02000CCD RID: 3277
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_2")]
		public sealed class __c__DisplayClass13_2 : Il2CppSystem.Object
		{
			// Token: 0x0600EC19 RID: 60441 RVA: 0x00384D70 File Offset: 0x00382F70
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_2()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_2>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_2.NativeFieldInfoPtr_selectedGuestGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_2>.NativeClassPtr, "selectedGuestGroup");
				DLC2_KoishiBossData.__c__DisplayClass13_2.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_2>.NativeClassPtr, "CS$<>8__locals1");
				DLC2_KoishiBossData.__c__DisplayClass13_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_2>.NativeClassPtr, 100681776);
				DLC2_KoishiBossData.__c__DisplayClass13_2.NativeMethodInfoPtr__MainChallengeLoop_b__72_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_2>.NativeClassPtr, 100681777);
			}

			// Token: 0x0600EC1A RID: 60442 RVA: 0x00384DEC File Offset: 0x00382FEC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC1B RID: 60443 RVA: 0x00384E28 File Offset: 0x00383028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223284, XrefRangeEnd = 223288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__72(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_2.NativeMethodInfoPtr__MainChallengeLoop_b__72_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC1C RID: 60444 RVA: 0x0007E70A File Offset: 0x0007C90A
			public __c__DisplayClass13_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CC8 RID: 19656
			// (get) Token: 0x0600EC1D RID: 60445 RVA: 0x00384E6C File Offset: 0x0038306C
			// (set) Token: 0x0600EC1E RID: 60446 RVA: 0x0007E713 File Offset: 0x0007C913
			public unsafe int selectedGuestGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_2.NativeFieldInfoPtr_selectedGuestGroup);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_2.NativeFieldInfoPtr_selectedGuestGroup)) = value;
				}
			}

			// Token: 0x17004CC9 RID: 19657
			// (get) Token: 0x0600EC1F RID: 60447 RVA: 0x00384E94 File Offset: 0x00383094
			// (set) Token: 0x0600EC20 RID: 60448 RVA: 0x0007E72E File Offset: 0x0007C92E
			public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_2.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_2.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009689 RID: 38537
			private static readonly IntPtr NativeFieldInfoPtr_selectedGuestGroup;

			// Token: 0x0400968A RID: 38538
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x0400968B RID: 38539
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400968C RID: 38540
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__72_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000CCE RID: 3278
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_3")]
		public sealed class __c__DisplayClass13_3 : Il2CppSystem.Object
		{
			// Token: 0x0600EC21 RID: 60449 RVA: 0x00384EC4 File Offset: 0x003830C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_3()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_3>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_3.NativeFieldInfoPtr_waitKoishiSeat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_3>.NativeClassPtr, "waitKoishiSeat");
				DLC2_KoishiBossData.__c__DisplayClass13_3.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_3>.NativeClassPtr, 100681778);
				DLC2_KoishiBossData.__c__DisplayClass13_3.NativeMethodInfoPtr__MainChallengeLoop_b__74_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_3>.NativeClassPtr, 100681779);
				DLC2_KoishiBossData.__c__DisplayClass13_3.NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_3>.NativeClassPtr, 100681780);
			}

			// Token: 0x0600EC22 RID: 60450 RVA: 0x00384F40 File Offset: 0x00383140
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_3() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_3>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_3.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC23 RID: 60451 RVA: 0x00384F7C File Offset: 0x0038317C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20797, RefRangeEnd = 20798, XrefRangeStart = 20797, XrefRangeEnd = 20798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__74()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_3.NativeMethodInfoPtr__MainChallengeLoop_b__74_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC24 RID: 60452 RVA: 0x00384FB0 File Offset: 0x003831B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 20798, RefRangeEnd = 20799, XrefRangeStart = 20798, XrefRangeEnd = 20799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__75()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_3.NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC25 RID: 60453 RVA: 0x0007E74D File Offset: 0x0007C94D
			public __c__DisplayClass13_3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CCA RID: 19658
			// (get) Token: 0x0600EC26 RID: 60454 RVA: 0x00384FEC File Offset: 0x003831EC
			// (set) Token: 0x0600EC27 RID: 60455 RVA: 0x0007E756 File Offset: 0x0007C956
			public unsafe bool waitKoishiSeat
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_3.NativeFieldInfoPtr_waitKoishiSeat);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_3.NativeFieldInfoPtr_waitKoishiSeat)) = value;
				}
			}

			// Token: 0x0400968D RID: 38541
			private static readonly IntPtr NativeFieldInfoPtr_waitKoishiSeat;

			// Token: 0x0400968E RID: 38542
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400968F RID: 38543
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__74_Internal_Void_0;

			// Token: 0x04009690 RID: 38544
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__75_Internal_Boolean_0;
		}

		// Token: 0x02000CCF RID: 3279
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_4")]
		public sealed class __c__DisplayClass13_4 : Il2CppSystem.Object
		{
			// Token: 0x0600EC28 RID: 60456 RVA: 0x00385014 File Offset: 0x00383214
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_4()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_4>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_4.NativeFieldInfoPtr_banTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_4>.NativeClassPtr, "banTags");
				DLC2_KoishiBossData.__c__DisplayClass13_4.NativeFieldInfoPtr_orderTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_4>.NativeClassPtr, "orderTags");
				DLC2_KoishiBossData.__c__DisplayClass13_4.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_4>.NativeClassPtr, 100681781);
				DLC2_KoishiBossData.__c__DisplayClass13_4.NativeMethodInfoPtr__MainChallengeLoop_b__76_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_4>.NativeClassPtr, 100681782);
			}

			// Token: 0x0600EC29 RID: 60457 RVA: 0x00385090 File Offset: 0x00383290
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_4() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_4>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_4.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC2A RID: 60458 RVA: 0x003850CC File Offset: 0x003832CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223288, XrefRangeEnd = 223305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__76(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_4.NativeMethodInfoPtr__MainChallengeLoop_b__76_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC2B RID: 60459 RVA: 0x0007E771 File Offset: 0x0007C971
			public __c__DisplayClass13_4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CCB RID: 19659
			// (get) Token: 0x0600EC2C RID: 60460 RVA: 0x00385118 File Offset: 0x00383318
			// (set) Token: 0x0600EC2D RID: 60461 RVA: 0x0007E77A File Offset: 0x0007C97A
			public unsafe List<int> banTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_4.NativeFieldInfoPtr_banTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_4.NativeFieldInfoPtr_banTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CCC RID: 19660
			// (get) Token: 0x0600EC2E RID: 60462 RVA: 0x00385148 File Offset: 0x00383348
			// (set) Token: 0x0600EC2F RID: 60463 RVA: 0x0007E799 File Offset: 0x0007C999
			public unsafe List<int> orderTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_4.NativeFieldInfoPtr_orderTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_4.NativeFieldInfoPtr_orderTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009691 RID: 38545
			private static readonly IntPtr NativeFieldInfoPtr_banTags;

			// Token: 0x04009692 RID: 38546
			private static readonly IntPtr NativeFieldInfoPtr_orderTags;

			// Token: 0x04009693 RID: 38547
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009694 RID: 38548
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__76_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000CD0 RID: 3280
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_5")]
		public sealed class __c__DisplayClass13_5 : Il2CppSystem.Object
		{
			// Token: 0x0600EC30 RID: 60464 RVA: 0x00385178 File Offset: 0x00383378
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_5()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, "text");
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, "id");
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, "CS$<>8__locals2");
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, 100681783);
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__81_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, 100681784);
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__82_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, 100681785);
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__83_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, 100681786);
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__84_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, 100681787);
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__85_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, 100681788);
				DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__86_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr, 100681789);
			}

			// Token: 0x0600EC31 RID: 60465 RVA: 0x0038526C File Offset: 0x0038346C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_5() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_5>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC32 RID: 60466 RVA: 0x003852A8 File Offset: 0x003834A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__81(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__81_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC33 RID: 60467 RVA: 0x003852EC File Offset: 0x003834EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__82(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__82_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC34 RID: 60468 RVA: 0x00385330 File Offset: 0x00383530
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__83(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__83_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC35 RID: 60469 RVA: 0x00385374 File Offset: 0x00383574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223305, XrefRangeEnd = 223308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__84(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__84_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC36 RID: 60470 RVA: 0x003853B8 File Offset: 0x003835B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223308, XrefRangeEnd = 223325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__85()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__85_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC37 RID: 60471 RVA: 0x003853EC File Offset: 0x003835EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223325, XrefRangeEnd = 223332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _MainChallengeLoop_b__86(int a, string b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref a;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeMethodInfoPtr__MainChallengeLoop_b__86_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600EC38 RID: 60472 RVA: 0x0007E7B8 File Offset: 0x0007C9B8
			public __c__DisplayClass13_5(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CCD RID: 19661
			// (get) Token: 0x0600EC39 RID: 60473 RVA: 0x00385444 File Offset: 0x00383644
			// (set) Token: 0x0600EC3A RID: 60474 RVA: 0x0007E7C1 File Offset: 0x0007C9C1
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004CCE RID: 19662
			// (get) Token: 0x0600EC3B RID: 60475 RVA: 0x0038546C File Offset: 0x0038366C
			// (set) Token: 0x0600EC3C RID: 60476 RVA: 0x0007E7E0 File Offset: 0x0007C9E0
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17004CCF RID: 19663
			// (get) Token: 0x0600EC3D RID: 60477 RVA: 0x00385494 File Offset: 0x00383694
			// (set) Token: 0x0600EC3E RID: 60478 RVA: 0x0007E7FB File Offset: 0x0007C9FB
			public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_5.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009695 RID: 38549
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x04009696 RID: 38550
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x04009697 RID: 38551
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x04009698 RID: 38552
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009699 RID: 38553
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__81_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400969A RID: 38554
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__82_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400969B RID: 38555
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__83_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400969C RID: 38556
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__84_Internal_Void_Image_0;

			// Token: 0x0400969D RID: 38557
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__85_Internal_Void_0;

			// Token: 0x0400969E RID: 38558
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__86_Internal_String_Int32_String_0;
		}

		// Token: 0x02000CD1 RID: 3281
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_6")]
		public sealed class __c__DisplayClass13_6 : Il2CppSystem.Object
		{
			// Token: 0x0600EC3F RID: 60479 RVA: 0x003854C4 File Offset: 0x003836C4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_6()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_6>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_6");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_6>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_6.NativeFieldInfoPtr_typeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_6>.NativeClassPtr, "typeId");
				DLC2_KoishiBossData.__c__DisplayClass13_6.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_6>.NativeClassPtr, 100681790);
				DLC2_KoishiBossData.__c__DisplayClass13_6.NativeMethodInfoPtr__MainChallengeLoop_b__88_Internal_Boolean_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_6>.NativeClassPtr, 100681791);
			}

			// Token: 0x0600EC40 RID: 60480 RVA: 0x0038552C File Offset: 0x0038372C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_6() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_6>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_6.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC41 RID: 60481 RVA: 0x00385568 File Offset: 0x00383768
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223332, XrefRangeEnd = 223333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__88(KeyValuePair<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_6.NativeMethodInfoPtr__MainChallengeLoop_b__88_Internal_Boolean_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC42 RID: 60482 RVA: 0x0007E81A File Offset: 0x0007CA1A
			public __c__DisplayClass13_6(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CD0 RID: 19664
			// (get) Token: 0x0600EC43 RID: 60483 RVA: 0x003855BC File Offset: 0x003837BC
			// (set) Token: 0x0600EC44 RID: 60484 RVA: 0x0007E823 File Offset: 0x0007CA23
			public unsafe int typeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_6.NativeFieldInfoPtr_typeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_6.NativeFieldInfoPtr_typeId)) = value;
				}
			}

			// Token: 0x0400969F RID: 38559
			private static readonly IntPtr NativeFieldInfoPtr_typeId;

			// Token: 0x040096A0 RID: 38560
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096A1 RID: 38561
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__88_Internal_Boolean_KeyValuePair_2_Int32_Int32_0;
		}

		// Token: 0x02000CD2 RID: 3282
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_7")]
		public sealed class __c__DisplayClass13_7 : Il2CppSystem.Object
		{
			// Token: 0x0600EC45 RID: 60485 RVA: 0x003855E4 File Offset: 0x003837E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_7()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_7>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_7.NativeFieldInfoPtr_tagObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_7>.NativeClassPtr, "tagObject");
				DLC2_KoishiBossData.__c__DisplayClass13_7.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_7>.NativeClassPtr, 100681792);
				DLC2_KoishiBossData.__c__DisplayClass13_7.NativeMethodInfoPtr__MainChallengeLoop_b__92_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_7>.NativeClassPtr, 100681793);
			}

			// Token: 0x0600EC46 RID: 60486 RVA: 0x0038564C File Offset: 0x0038384C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_7() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_7>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_7.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC47 RID: 60487 RVA: 0x00385688 File Offset: 0x00383888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223333, XrefRangeEnd = 223337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__92()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_7.NativeMethodInfoPtr__MainChallengeLoop_b__92_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC48 RID: 60488 RVA: 0x0007E83E File Offset: 0x0007CA3E
			public __c__DisplayClass13_7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CD1 RID: 19665
			// (get) Token: 0x0600EC49 RID: 60489 RVA: 0x003856BC File Offset: 0x003838BC
			// (set) Token: 0x0600EC4A RID: 60490 RVA: 0x0007E847 File Offset: 0x0007CA47
			public unsafe GameObject tagObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_7.NativeFieldInfoPtr_tagObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_7.NativeFieldInfoPtr_tagObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096A2 RID: 38562
			private static readonly IntPtr NativeFieldInfoPtr_tagObject;

			// Token: 0x040096A3 RID: 38563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096A4 RID: 38564
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__92_Internal_Void_0;
		}

		// Token: 0x02000CD3 RID: 3283
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_8")]
		public sealed class __c__DisplayClass13_8 : Il2CppSystem.Object
		{
			// Token: 0x0600EC4B RID: 60491 RVA: 0x003856EC File Offset: 0x003838EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_8()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_8>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_8");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_8>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_8.NativeFieldInfoPtr_group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_8>.NativeClassPtr, "group");
				DLC2_KoishiBossData.__c__DisplayClass13_8.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_8>.NativeClassPtr, "CS$<>8__locals3");
				DLC2_KoishiBossData.__c__DisplayClass13_8.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_8>.NativeClassPtr, 100681794);
				DLC2_KoishiBossData.__c__DisplayClass13_8.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_8>.NativeClassPtr, 100681795);
				DLC2_KoishiBossData.__c__DisplayClass13_8.NativeMethodInfoPtr__MainChallengeLoop_b__99_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_8>.NativeClassPtr, 100681796);
			}

			// Token: 0x0600EC4C RID: 60492 RVA: 0x0038577C File Offset: 0x0038397C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_8() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_8>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_8.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC4D RID: 60493 RVA: 0x003857B8 File Offset: 0x003839B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223337, XrefRangeEnd = 223378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_8.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC4E RID: 60494 RVA: 0x003857FC File Offset: 0x003839FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223378, XrefRangeEnd = 223411, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__99(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_8.NativeMethodInfoPtr__MainChallengeLoop_b__99_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC4F RID: 60495 RVA: 0x0007E866 File Offset: 0x0007CA66
			public __c__DisplayClass13_8(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CD2 RID: 19666
			// (get) Token: 0x0600EC50 RID: 60496 RVA: 0x00385840 File Offset: 0x00383A40
			// (set) Token: 0x0600EC51 RID: 60497 RVA: 0x0007E86F File Offset: 0x0007CA6F
			public unsafe SpecialGuestsController group
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_8.NativeFieldInfoPtr_group);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_8.NativeFieldInfoPtr_group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CD3 RID: 19667
			// (get) Token: 0x0600EC52 RID: 60498 RVA: 0x00385870 File Offset: 0x00383A70
			// (set) Token: 0x0600EC53 RID: 60499 RVA: 0x0007E88E File Offset: 0x0007CA8E
			public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_8.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_8.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096A5 RID: 38565
			private static readonly IntPtr NativeFieldInfoPtr_group;

			// Token: 0x040096A6 RID: 38566
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x040096A7 RID: 38567
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096A8 RID: 38568
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x040096A9 RID: 38569
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__99_Internal_Void_GuestGroupController_0;
		}

		// Token: 0x02000CD4 RID: 3284
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_9")]
		public sealed class __c__DisplayClass13_9 : Il2CppSystem.Object
		{
			// Token: 0x0600EC54 RID: 60500 RVA: 0x003858A0 File Offset: 0x00383AA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_9()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_9>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_9.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_9>.NativeClassPtr, "tag");
				DLC2_KoishiBossData.__c__DisplayClass13_9.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_9>.NativeClassPtr, 100681797);
				DLC2_KoishiBossData.__c__DisplayClass13_9.NativeMethodInfoPtr__MainChallengeLoop_b__98_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_9>.NativeClassPtr, 100681798);
			}

			// Token: 0x0600EC55 RID: 60501 RVA: 0x00385908 File Offset: 0x00383B08
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_9() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_9>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_9.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC56 RID: 60502 RVA: 0x00385944 File Offset: 0x00383B44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223411, XrefRangeEnd = 223415, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__98()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_9.NativeMethodInfoPtr__MainChallengeLoop_b__98_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC57 RID: 60503 RVA: 0x0007E8AD File Offset: 0x0007CAAD
			public __c__DisplayClass13_9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CD4 RID: 19668
			// (get) Token: 0x0600EC58 RID: 60504 RVA: 0x00385978 File Offset: 0x00383B78
			// (set) Token: 0x0600EC59 RID: 60505 RVA: 0x0007E8B6 File Offset: 0x0007CAB6
			public unsafe UIElementCluster tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_9.NativeFieldInfoPtr_tag);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_9.NativeFieldInfoPtr_tag), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096AA RID: 38570
			private static readonly IntPtr NativeFieldInfoPtr_tag;

			// Token: 0x040096AB RID: 38571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096AC RID: 38572
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__98_Internal_Void_0;
		}

		// Token: 0x02000CD5 RID: 3285
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_10")]
		public sealed class __c__DisplayClass13_10 : Il2CppSystem.Object
		{
			// Token: 0x0600EC5A RID: 60506 RVA: 0x003859A8 File Offset: 0x00383BA8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_10()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_10>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_10.NativeFieldInfoPtr_targetDeskIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_10>.NativeClassPtr, "targetDeskIcon");
				DLC2_KoishiBossData.__c__DisplayClass13_10.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_10>.NativeClassPtr, 100681799);
				DLC2_KoishiBossData.__c__DisplayClass13_10.NativeMethodInfoPtr__MainChallengeLoop_b__100_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_10>.NativeClassPtr, 100681800);
			}

			// Token: 0x0600EC5B RID: 60507 RVA: 0x00385A10 File Offset: 0x00383C10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_10() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_10>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_10.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC5C RID: 60508 RVA: 0x00385A4C File Offset: 0x00383C4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223415, XrefRangeEnd = 223419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__100()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_10.NativeMethodInfoPtr__MainChallengeLoop_b__100_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC5D RID: 60509 RVA: 0x0007E8D5 File Offset: 0x0007CAD5
			public __c__DisplayClass13_10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CD5 RID: 19669
			// (get) Token: 0x0600EC5E RID: 60510 RVA: 0x00385A80 File Offset: 0x00383C80
			// (set) Token: 0x0600EC5F RID: 60511 RVA: 0x0007E8DE File Offset: 0x0007CADE
			public unsafe GameObject targetDeskIcon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_10.NativeFieldInfoPtr_targetDeskIcon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_10.NativeFieldInfoPtr_targetDeskIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096AD RID: 38573
			private static readonly IntPtr NativeFieldInfoPtr_targetDeskIcon;

			// Token: 0x040096AE RID: 38574
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096AF RID: 38575
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__100_Internal_Void_0;
		}

		// Token: 0x02000CD6 RID: 3286
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_11")]
		public sealed class __c__DisplayClass13_11 : Il2CppSystem.Object
		{
			// Token: 0x0600EC60 RID: 60512 RVA: 0x00385AB0 File Offset: 0x00383CB0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_11()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentMaxPatient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr, "currentMaxPatient");
				DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentPatient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr, "currentPatient");
				DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentMaxPatient2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr, "currentMaxPatient2");
				DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentPatient2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr, "currentPatient2");
				DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr, "CS$<>8__locals4");
				DLC2_KoishiBossData.__c__DisplayClass13_11.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr, 100681801);
				DLC2_KoishiBossData.__c__DisplayClass13_11.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr, 100681802);
				DLC2_KoishiBossData.__c__DisplayClass13_11.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr, 100681803);
			}

			// Token: 0x0600EC61 RID: 60513 RVA: 0x00385B7C File Offset: 0x00383D7C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_11() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_11>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC62 RID: 60514 RVA: 0x00385BB8 File Offset: 0x00383DB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223419, XrefRangeEnd = 223432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC63 RID: 60515 RVA: 0x00385BFC File Offset: 0x00383DFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223432, XrefRangeEnd = 223445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_1(GuestGroupController guest)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guest);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC64 RID: 60516 RVA: 0x0007E8FD File Offset: 0x0007CAFD
			public __c__DisplayClass13_11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CD6 RID: 19670
			// (get) Token: 0x0600EC65 RID: 60517 RVA: 0x00385C40 File Offset: 0x00383E40
			// (set) Token: 0x0600EC66 RID: 60518 RVA: 0x0007E906 File Offset: 0x0007CB06
			public unsafe int currentMaxPatient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentMaxPatient);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentMaxPatient)) = value;
				}
			}

			// Token: 0x17004CD7 RID: 19671
			// (get) Token: 0x0600EC67 RID: 60519 RVA: 0x00385C68 File Offset: 0x00383E68
			// (set) Token: 0x0600EC68 RID: 60520 RVA: 0x0007E921 File Offset: 0x0007CB21
			public unsafe int currentPatient
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentPatient);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentPatient)) = value;
				}
			}

			// Token: 0x17004CD8 RID: 19672
			// (get) Token: 0x0600EC69 RID: 60521 RVA: 0x00385C90 File Offset: 0x00383E90
			// (set) Token: 0x0600EC6A RID: 60522 RVA: 0x0007E93C File Offset: 0x0007CB3C
			public unsafe int currentMaxPatient2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentMaxPatient2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentMaxPatient2)) = value;
				}
			}

			// Token: 0x17004CD9 RID: 19673
			// (get) Token: 0x0600EC6B RID: 60523 RVA: 0x00385CB8 File Offset: 0x00383EB8
			// (set) Token: 0x0600EC6C RID: 60524 RVA: 0x0007E957 File Offset: 0x0007CB57
			public unsafe int currentPatient2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentPatient2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_currentPatient2)) = value;
				}
			}

			// Token: 0x17004CDA RID: 19674
			// (get) Token: 0x0600EC6D RID: 60525 RVA: 0x00385CE0 File Offset: 0x00383EE0
			// (set) Token: 0x0600EC6E RID: 60526 RVA: 0x0007E972 File Offset: 0x0007CB72
			public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_11.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096B0 RID: 38576
			private static readonly IntPtr NativeFieldInfoPtr_currentMaxPatient;

			// Token: 0x040096B1 RID: 38577
			private static readonly IntPtr NativeFieldInfoPtr_currentPatient;

			// Token: 0x040096B2 RID: 38578
			private static readonly IntPtr NativeFieldInfoPtr_currentMaxPatient2;

			// Token: 0x040096B3 RID: 38579
			private static readonly IntPtr NativeFieldInfoPtr_currentPatient2;

			// Token: 0x040096B4 RID: 38580
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x040096B5 RID: 38581
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096B6 RID: 38582
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x040096B7 RID: 38583
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_1;
		}

		// Token: 0x02000CD7 RID: 3287
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_12")]
		public sealed class __c__DisplayClass13_12 : Il2CppSystem.Object
		{
			// Token: 0x0600EC6F RID: 60527 RVA: 0x00385D10 File Offset: 0x00383F10
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_12()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_12>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_12.NativeFieldInfoPtr_thisIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_12>.NativeClassPtr, "thisIndex");
				DLC2_KoishiBossData.__c__DisplayClass13_12.NativeFieldInfoPtr_field_Public___c__DisplayClass13_11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_12>.NativeClassPtr, "CS$<>8__locals5");
				DLC2_KoishiBossData.__c__DisplayClass13_12.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_12>.NativeClassPtr, 100681804);
				DLC2_KoishiBossData.__c__DisplayClass13_12.NativeMethodInfoPtr__MainChallengeLoop_b__104_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_12>.NativeClassPtr, 100681805);
			}

			// Token: 0x0600EC70 RID: 60528 RVA: 0x00385D8C File Offset: 0x00383F8C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_12() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_12>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_12.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC71 RID: 60529 RVA: 0x00385DC8 File Offset: 0x00383FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223445, XrefRangeEnd = 223454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _MainChallengeLoop_b__104(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_12.NativeMethodInfoPtr__MainChallengeLoop_b__104_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC72 RID: 60530 RVA: 0x0007E991 File Offset: 0x0007CB91
			public __c__DisplayClass13_12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CDB RID: 19675
			// (get) Token: 0x0600EC73 RID: 60531 RVA: 0x00385E0C File Offset: 0x0038400C
			// (set) Token: 0x0600EC74 RID: 60532 RVA: 0x0007E99A File Offset: 0x0007CB9A
			public unsafe int thisIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_12.NativeFieldInfoPtr_thisIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_12.NativeFieldInfoPtr_thisIndex)) = value;
				}
			}

			// Token: 0x17004CDC RID: 19676
			// (get) Token: 0x0600EC75 RID: 60533 RVA: 0x00385E34 File Offset: 0x00384034
			// (set) Token: 0x0600EC76 RID: 60534 RVA: 0x0007E9B5 File Offset: 0x0007CBB5
			public unsafe DLC2_KoishiBossData.__c__DisplayClass13_11 field_Public___c__DisplayClass13_11_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_12.NativeFieldInfoPtr_field_Public___c__DisplayClass13_11_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_11>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_12.NativeFieldInfoPtr_field_Public___c__DisplayClass13_11_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096B8 RID: 38584
			private static readonly IntPtr NativeFieldInfoPtr_thisIndex;

			// Token: 0x040096B9 RID: 38585
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_11_0;

			// Token: 0x040096BA RID: 38586
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096BB RID: 38587
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__104_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000CD8 RID: 3288
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_13")]
		public sealed class __c__DisplayClass13_13 : Il2CppSystem.Object
		{
			// Token: 0x0600EC77 RID: 60535 RVA: 0x00385E64 File Offset: 0x00384064
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_13()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_13>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_13.NativeFieldInfoPtr_seatableOne = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_13>.NativeClassPtr, "seatableOne");
				DLC2_KoishiBossData.__c__DisplayClass13_13.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_13>.NativeClassPtr, 100681806);
				DLC2_KoishiBossData.__c__DisplayClass13_13.NativeMethodInfoPtr__MainChallengeLoop_b__107_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_13>.NativeClassPtr, 100681807);
			}

			// Token: 0x0600EC78 RID: 60536 RVA: 0x00385ECC File Offset: 0x003840CC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_13() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_13>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_13.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC79 RID: 60537 RVA: 0x00385F08 File Offset: 0x00384108
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223454, XrefRangeEnd = 223457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__107()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_13.NativeMethodInfoPtr__MainChallengeLoop_b__107_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC7A RID: 60538 RVA: 0x0007E9D4 File Offset: 0x0007CBD4
			public __c__DisplayClass13_13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CDD RID: 19677
			// (get) Token: 0x0600EC7B RID: 60539 RVA: 0x00385F44 File Offset: 0x00384144
			// (set) Token: 0x0600EC7C RID: 60540 RVA: 0x0007E9DD File Offset: 0x0007CBDD
			public unsafe List<int> seatableOne
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_13.NativeFieldInfoPtr_seatableOne);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_13.NativeFieldInfoPtr_seatableOne), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096BC RID: 38588
			private static readonly IntPtr NativeFieldInfoPtr_seatableOne;

			// Token: 0x040096BD RID: 38589
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096BE RID: 38590
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__107_Internal_Boolean_0;
		}

		// Token: 0x02000CD9 RID: 3289
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_14")]
		public sealed class __c__DisplayClass13_14 : Il2CppSystem.Object
		{
			// Token: 0x0600EC7D RID: 60541 RVA: 0x00385F74 File Offset: 0x00384174
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_14()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_14>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_14.NativeFieldInfoPtr_serveBev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_14>.NativeClassPtr, "serveBev");
				DLC2_KoishiBossData.__c__DisplayClass13_14.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_14>.NativeClassPtr, "CS$<>8__locals6");
				DLC2_KoishiBossData.__c__DisplayClass13_14.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_14>.NativeClassPtr, 100681808);
				DLC2_KoishiBossData.__c__DisplayClass13_14.NativeMethodInfoPtr__MainChallengeLoop_b__112_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_14>.NativeClassPtr, 100681809);
			}

			// Token: 0x0600EC7E RID: 60542 RVA: 0x00385FF0 File Offset: 0x003841F0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_14() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_14>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_14.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC7F RID: 60543 RVA: 0x0038602C File Offset: 0x0038422C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223457, XrefRangeEnd = 223460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MainChallengeLoop_b__112(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_14.NativeMethodInfoPtr__MainChallengeLoop_b__112_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600EC80 RID: 60544 RVA: 0x0007E9FC File Offset: 0x0007CBFC
			public __c__DisplayClass13_14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CDE RID: 19678
			// (get) Token: 0x0600EC81 RID: 60545 RVA: 0x00386078 File Offset: 0x00384278
			// (set) Token: 0x0600EC82 RID: 60546 RVA: 0x0007EA05 File Offset: 0x0007CC05
			public unsafe Sellable serveBev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_14.NativeFieldInfoPtr_serveBev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_14.NativeFieldInfoPtr_serveBev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CDF RID: 19679
			// (get) Token: 0x0600EC83 RID: 60547 RVA: 0x003860A8 File Offset: 0x003842A8
			// (set) Token: 0x0600EC84 RID: 60548 RVA: 0x0007EA24 File Offset: 0x0007CC24
			public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_14.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_14.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096BF RID: 38591
			private static readonly IntPtr NativeFieldInfoPtr_serveBev;

			// Token: 0x040096C0 RID: 38592
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x040096C1 RID: 38593
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096C2 RID: 38594
			private static readonly IntPtr NativeMethodInfoPtr__MainChallengeLoop_b__112_Internal_Boolean_Int32_0;
		}

		// Token: 0x02000CDA RID: 3290
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_15")]
		public sealed class __c__DisplayClass13_15 : Il2CppSystem.Object
		{
			// Token: 0x0600EC85 RID: 60549 RVA: 0x003860D8 File Offset: 0x003842D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_15()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<>c__DisplayClass13_15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15>.NativeClassPtr);
				DLC2_KoishiBossData.__c__DisplayClass13_15.NativeFieldInfoPtr_koishiGuestInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15>.NativeClassPtr, "koishiGuestInstance");
				DLC2_KoishiBossData.__c__DisplayClass13_15.NativeFieldInfoPtr_oldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15>.NativeClassPtr, "oldPosition");
				DLC2_KoishiBossData.__c__DisplayClass13_15.NativeFieldInfoPtr_field_Public___c__DisplayClass13_14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15>.NativeClassPtr, "CS$<>8__locals7");
				DLC2_KoishiBossData.__c__DisplayClass13_15.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15>.NativeClassPtr, 100681810);
				DLC2_KoishiBossData.__c__DisplayClass13_15.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15>.NativeClassPtr, 100681811);
			}

			// Token: 0x0600EC86 RID: 60550 RVA: 0x00386168 File Offset: 0x00384368
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_15() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_15.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC87 RID: 60551 RVA: 0x003861A4 File Offset: 0x003843A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223471, XrefRangeEnd = 223476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_15.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600EC88 RID: 60552 RVA: 0x0007EA43 File Offset: 0x0007CC43
			public __c__DisplayClass13_15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CE0 RID: 19680
			// (get) Token: 0x0600EC89 RID: 60553 RVA: 0x003861E4 File Offset: 0x003843E4
			// (set) Token: 0x0600EC8A RID: 60554 RVA: 0x0007EA4C File Offset: 0x0007CC4C
			public unsafe AStarInputGeneratorComponent koishiGuestInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.NativeFieldInfoPtr_koishiGuestInstance);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AStarInputGeneratorComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.NativeFieldInfoPtr_koishiGuestInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CE1 RID: 19681
			// (get) Token: 0x0600EC8B RID: 60555 RVA: 0x00386214 File Offset: 0x00384414
			// (set) Token: 0x0600EC8C RID: 60556 RVA: 0x0007EA6B File Offset: 0x0007CC6B
			public unsafe Vector3 oldPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.NativeFieldInfoPtr_oldPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.NativeFieldInfoPtr_oldPosition)) = value;
				}
			}

			// Token: 0x17004CE2 RID: 19682
			// (get) Token: 0x0600EC8D RID: 60557 RVA: 0x0038623C File Offset: 0x0038443C
			// (set) Token: 0x0600EC8E RID: 60558 RVA: 0x0007EA86 File Offset: 0x0007CC86
			public unsafe DLC2_KoishiBossData.__c__DisplayClass13_14 field_Public___c__DisplayClass13_14_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.NativeFieldInfoPtr_field_Public___c__DisplayClass13_14_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_14>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.NativeFieldInfoPtr_field_Public___c__DisplayClass13_14_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096C3 RID: 38595
			private static readonly IntPtr NativeFieldInfoPtr_koishiGuestInstance;

			// Token: 0x040096C4 RID: 38596
			private static readonly IntPtr NativeFieldInfoPtr_oldPosition;

			// Token: 0x040096C5 RID: 38597
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_14_0;

			// Token: 0x040096C6 RID: 38598
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040096C7 RID: 38599
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0200107B RID: 4219
			[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<>c__DisplayClass13_15+<<MainChallengeLoop>g__SetKoishiShake|113>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011FAC RID: 73644 RVA: 0x0041BC60 File Offset: 0x00419E60
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15>.NativeClassPtr, "<<MainChallengeLoop>g__SetKoishiShake|113>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681812);
					DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681813);
					DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681814);
					DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681815);
					DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681816);
					DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100681817);
				}

				// Token: 0x06011FAD RID: 73645 RVA: 0x0041BD40 File Offset: 0x00419F40
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FAE RID: 73646 RVA: 0x0041BD88 File Offset: 0x00419F88
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011FAF RID: 73647 RVA: 0x0041BDBC File Offset: 0x00419FBC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223460, XrefRangeEnd = 223465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005DCB RID: 24011
				// (get) Token: 0x06011FB0 RID: 73648 RVA: 0x0041BDF8 File Offset: 0x00419FF8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FB1 RID: 73649 RVA: 0x0041BE38 File Offset: 0x0041A038
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223465, XrefRangeEnd = 223471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005DCC RID: 24012
				// (get) Token: 0x06011FB2 RID: 73650 RVA: 0x0041BE6C File Offset: 0x0041A06C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011FB3 RID: 73651 RVA: 0x0009C2D7 File Offset: 0x0009A4D7
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005DC8 RID: 24008
				// (get) Token: 0x06011FB4 RID: 73652 RVA: 0x0041BEAC File Offset: 0x0041A0AC
				// (set) Token: 0x06011FB5 RID: 73653 RVA: 0x0009C2E0 File Offset: 0x0009A4E0
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005DC9 RID: 24009
				// (get) Token: 0x06011FB6 RID: 73654 RVA: 0x0041BED4 File Offset: 0x0041A0D4
				// (set) Token: 0x06011FB7 RID: 73655 RVA: 0x0009C2FB File Offset: 0x0009A4FB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005DCA RID: 24010
				// (get) Token: 0x06011FB8 RID: 73656 RVA: 0x0041BF04 File Offset: 0x0041A104
				// (set) Token: 0x06011FB9 RID: 73657 RVA: 0x0009C31A File Offset: 0x0009A51A
				public unsafe DLC2_KoishiBossData.__c__DisplayClass13_15 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_15>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData.__c__DisplayClass13_15.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B630 RID: 46640
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B631 RID: 46641
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B632 RID: 46642
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B633 RID: 46643
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B634 RID: 46644
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B635 RID: 46645
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B636 RID: 46646
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B637 RID: 46647
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B638 RID: 46648
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000CDB RID: 3291
		[ObfuscatedName("GameData.Profile.DLC2_KoishiBossData+<MainChallengeLoop>d__13")]
		public sealed class _MainChallengeLoop_d__13 : Il2CppSystem.Object
		{
			// Token: 0x0600EC8F RID: 60559 RVA: 0x0038626C File Offset: 0x0038446C
			// Note: this type is marked as 'beforefieldinit'.
			static _MainChallengeLoop_d__13()
			{
				Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC2_KoishiBossData>.NativeClassPtr, "<MainChallengeLoop>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr);
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<>1__state");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<>2__current");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<>4__this");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr_bossDataContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "bossDataContext");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<>8__1");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__allIzakayas_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<allIzakayas>5__2");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__statusDisplayerTransition_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<statusDisplayerTransition>5__3");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__ptc_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<ptc>5__4");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__waitForGuestLeaveDelaySecond_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<waitForGuestLeaveDelaySecond>5__5");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__waitForAllGuestToLeave_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<waitForAllGuestToLeave>5__6");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__standSpawnLoop_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<standSpawnLoop>5__7");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__alphaLoop_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, "<alphaLoop>5__8");
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, 100681818);
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, 100681819);
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, 100681820);
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, 100681821);
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, 100681822);
				DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr, 100681823);
			}

			// Token: 0x0600EC90 RID: 60560 RVA: 0x00386400 File Offset: 0x00384600
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _MainChallengeLoop_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC2_KoishiBossData._MainChallengeLoop_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC91 RID: 60561 RVA: 0x00386448 File Offset: 0x00384648
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600EC92 RID: 60562 RVA: 0x0038647C File Offset: 0x0038467C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 223476, XrefRangeEnd = 224508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004CEF RID: 19695
			// (get) Token: 0x0600EC93 RID: 60563 RVA: 0x003864B8 File Offset: 0x003846B8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EC94 RID: 60564 RVA: 0x003864F8 File Offset: 0x003846F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224508, XrefRangeEnd = 224514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004CF0 RID: 19696
			// (get) Token: 0x0600EC95 RID: 60565 RVA: 0x0038652C File Offset: 0x0038472C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600EC96 RID: 60566 RVA: 0x0007EAA5 File Offset: 0x0007CCA5
			public _MainChallengeLoop_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004CE3 RID: 19683
			// (get) Token: 0x0600EC97 RID: 60567 RVA: 0x0038656C File Offset: 0x0038476C
			// (set) Token: 0x0600EC98 RID: 60568 RVA: 0x0007EAAE File Offset: 0x0007CCAE
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004CE4 RID: 19684
			// (get) Token: 0x0600EC99 RID: 60569 RVA: 0x00386594 File Offset: 0x00384794
			// (set) Token: 0x0600EC9A RID: 60570 RVA: 0x0007EAC9 File Offset: 0x0007CCC9
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CE5 RID: 19685
			// (get) Token: 0x0600EC9B RID: 60571 RVA: 0x003865C4 File Offset: 0x003847C4
			// (set) Token: 0x0600EC9C RID: 60572 RVA: 0x0007EAE8 File Offset: 0x0007CCE8
			public unsafe DLC2_KoishiBossData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CE6 RID: 19686
			// (get) Token: 0x0600EC9D RID: 60573 RVA: 0x003865F4 File Offset: 0x003847F4
			// (set) Token: 0x0600EC9E RID: 60574 RVA: 0x0007EB07 File Offset: 0x0007CD07
			public BossData.BossDataContext bossDataContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr_bossDataContext);
					return new BossData.BossDataContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr_bossDataContext), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BossData.BossDataContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004CE7 RID: 19687
			// (get) Token: 0x0600EC9F RID: 60575 RVA: 0x00386624 File Offset: 0x00384824
			// (set) Token: 0x0600ECA0 RID: 60576 RVA: 0x0007EB35 File Offset: 0x0007CD35
			public unsafe DLC2_KoishiBossData.__c__DisplayClass13_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC2_KoishiBossData.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CE8 RID: 19688
			// (get) Token: 0x0600ECA1 RID: 60577 RVA: 0x00386654 File Offset: 0x00384854
			// (set) Token: 0x0600ECA2 RID: 60578 RVA: 0x0007EB54 File Offset: 0x0007CD54
			public unsafe Il2CppReferenceArray<Izakaya> _allIzakayas_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__allIzakayas_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__allIzakayas_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CE9 RID: 19689
			// (get) Token: 0x0600ECA3 RID: 60579 RVA: 0x00386684 File Offset: 0x00384884
			// (set) Token: 0x0600ECA4 RID: 60580 RVA: 0x0007EB73 File Offset: 0x0007CD73
			public unsafe CanvasGroup _statusDisplayerTransition_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__statusDisplayerTransition_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__statusDisplayerTransition_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CEA RID: 19690
			// (get) Token: 0x0600ECA5 RID: 60581 RVA: 0x003866B4 File Offset: 0x003848B4
			// (set) Token: 0x0600ECA6 RID: 60582 RVA: 0x0007EB92 File Offset: 0x0007CD92
			public unsafe PannelTransitionController _ptc_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__ptc_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PannelTransitionController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__ptc_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CEB RID: 19691
			// (get) Token: 0x0600ECA7 RID: 60583 RVA: 0x003866E4 File Offset: 0x003848E4
			// (set) Token: 0x0600ECA8 RID: 60584 RVA: 0x0007EBB1 File Offset: 0x0007CDB1
			public unsafe WaitForSeconds _waitForGuestLeaveDelaySecond_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__waitForGuestLeaveDelaySecond_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__waitForGuestLeaveDelaySecond_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CEC RID: 19692
			// (get) Token: 0x0600ECA9 RID: 60585 RVA: 0x00386714 File Offset: 0x00384914
			// (set) Token: 0x0600ECAA RID: 60586 RVA: 0x0007EBD0 File Offset: 0x0007CDD0
			public unsafe IEnumerator _waitForAllGuestToLeave_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__waitForAllGuestToLeave_5__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__waitForAllGuestToLeave_5__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CED RID: 19693
			// (get) Token: 0x0600ECAB RID: 60587 RVA: 0x00386744 File Offset: 0x00384944
			// (set) Token: 0x0600ECAC RID: 60588 RVA: 0x0007EBEF File Offset: 0x0007CDEF
			public unsafe Coroutine _standSpawnLoop_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__standSpawnLoop_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__standSpawnLoop_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004CEE RID: 19694
			// (get) Token: 0x0600ECAD RID: 60589 RVA: 0x00386774 File Offset: 0x00384974
			// (set) Token: 0x0600ECAE RID: 60590 RVA: 0x0007EC0E File Offset: 0x0007CE0E
			public unsafe Coroutine _alphaLoop_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__alphaLoop_5__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC2_KoishiBossData._MainChallengeLoop_d__13.NativeFieldInfoPtr__alphaLoop_5__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040096C8 RID: 38600
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040096C9 RID: 38601
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040096CA RID: 38602
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040096CB RID: 38603
			private static readonly IntPtr NativeFieldInfoPtr_bossDataContext;

			// Token: 0x040096CC RID: 38604
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x040096CD RID: 38605
			private static readonly IntPtr NativeFieldInfoPtr__allIzakayas_5__2;

			// Token: 0x040096CE RID: 38606
			private static readonly IntPtr NativeFieldInfoPtr__statusDisplayerTransition_5__3;

			// Token: 0x040096CF RID: 38607
			private static readonly IntPtr NativeFieldInfoPtr__ptc_5__4;

			// Token: 0x040096D0 RID: 38608
			private static readonly IntPtr NativeFieldInfoPtr__waitForGuestLeaveDelaySecond_5__5;

			// Token: 0x040096D1 RID: 38609
			private static readonly IntPtr NativeFieldInfoPtr__waitForAllGuestToLeave_5__6;

			// Token: 0x040096D2 RID: 38610
			private static readonly IntPtr NativeFieldInfoPtr__standSpawnLoop_5__7;

			// Token: 0x040096D3 RID: 38611
			private static readonly IntPtr NativeFieldInfoPtr__alphaLoop_5__8;

			// Token: 0x040096D4 RID: 38612
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040096D5 RID: 38613
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040096D6 RID: 38614
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040096D7 RID: 38615
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040096D8 RID: 38616
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040096D9 RID: 38617
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
