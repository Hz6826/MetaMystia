using System;
using Common.UI.GlobalMap;
using GameData.Core.Collections;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000114 RID: 276
	public class DLC5_RogueLikeMapDescriber : MonoBehaviour
	{
		// Token: 0x06001E36 RID: 7734 RVA: 0x001038AC File Offset: 0x00101AAC
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeMapDescriber()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeMapDescriber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr);
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_IzakayaName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_IzakayaName");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_CookingDeskAmount1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_CookingDeskAmount1");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_CookingDeskAmount2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_CookingDeskAmount2");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_GuestTableAmount1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_GuestTableAmount1");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_GuestTableAmount2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_GuestTableAmount2");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_CharacterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_CharacterPrefab");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_SpecialGuestModule");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestModule = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_NormalGuestModule");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_NormalGuestField");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_SpecialGuestField");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestsMoreIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_NormalGuestsMoreIndicator");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestsMoreIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_SpecialGuestsMoreIndicator");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_allNormalCharacterInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "allNormalCharacterInstancePool");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_allSpecialCharacterInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "allSpecialCharacterInstancePool");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestPrintingCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_SpecialGuestPrintingCache");
			DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestPrintingCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "m_NormalGuestPrintingCache");
			DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_get_Max_Protected_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, 100668671);
			DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_get_CharacterPrefab_Protected_get_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, 100668672);
			DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_New_Void_DLC5_RogueLikeMapDescriberOpenContext_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, 100668673);
			DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, 100668674);
			DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, 100668675);
			DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, 100668676);
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x00103A94 File Offset: 0x00101C94
		public unsafe virtual int Max
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48392, RefRangeEnd = 48393, XrefRangeStart = 48392, XrefRangeEnd = 48393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_get_Max_Protected_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06001E38 RID: 7736 RVA: 0x00103ADC File Offset: 0x00101CDC
		public unsafe GameObject CharacterPrefab
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73515, RefRangeEnd = 73516, XrefRangeStart = 73515, XrefRangeEnd = 73516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_get_CharacterPrefab_Protected_get_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00103B1C File Offset: 0x00101D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75276, RefRangeEnd = 75277, XrefRangeStart = 75171, XrefRangeEnd = 75276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Describe(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext data, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_Describe_Public_Virtual_New_Void_DLC5_RogueLikeMapDescriberOpenContext_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00103B88 File Offset: 0x00101D88
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DescribeNull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00103BBC File Offset: 0x00101DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75277, XrefRangeEnd = 75299, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00103BF8 File Offset: 0x00101DF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75299, XrefRangeEnd = 75325, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeMapDescriber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x0001239A File Offset: 0x0001059A
		public DLC5_RogueLikeMapDescriber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06001E3E RID: 7742 RVA: 0x00103C34 File Offset: 0x00101E34
		// (set) Token: 0x06001E3F RID: 7743 RVA: 0x000123A3 File Offset: 0x000105A3
		public unsafe TextMeshProUGUI m_IzakayaName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_IzakayaName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_IzakayaName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06001E40 RID: 7744 RVA: 0x00103C64 File Offset: 0x00101E64
		// (set) Token: 0x06001E41 RID: 7745 RVA: 0x000123C2 File Offset: 0x000105C2
		public unsafe TextMeshProUGUI m_CookingDeskAmount1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_CookingDeskAmount1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_CookingDeskAmount1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06001E42 RID: 7746 RVA: 0x00103C94 File Offset: 0x00101E94
		// (set) Token: 0x06001E43 RID: 7747 RVA: 0x000123E1 File Offset: 0x000105E1
		public unsafe TextMeshProUGUI m_CookingDeskAmount2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_CookingDeskAmount2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_CookingDeskAmount2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06001E44 RID: 7748 RVA: 0x00103CC4 File Offset: 0x00101EC4
		// (set) Token: 0x06001E45 RID: 7749 RVA: 0x00012400 File Offset: 0x00010600
		public unsafe TextMeshProUGUI m_GuestTableAmount1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_GuestTableAmount1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_GuestTableAmount1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x00103CF4 File Offset: 0x00101EF4
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x0001241F File Offset: 0x0001061F
		public unsafe TextMeshProUGUI m_GuestTableAmount2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_GuestTableAmount2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_GuestTableAmount2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00103D24 File Offset: 0x00101F24
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x0001243E File Offset: 0x0001063E
		public unsafe GameObject m_CharacterPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_CharacterPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_CharacterPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06001E4A RID: 7754 RVA: 0x00103D54 File Offset: 0x00101F54
		// (set) Token: 0x06001E4B RID: 7755 RVA: 0x0001245D File Offset: 0x0001065D
		public unsafe GameObject m_SpecialGuestModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06001E4C RID: 7756 RVA: 0x00103D84 File Offset: 0x00101F84
		// (set) Token: 0x06001E4D RID: 7757 RVA: 0x0001247C File Offset: 0x0001067C
		public unsafe GameObject m_NormalGuestModule
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestModule);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestModule), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06001E4E RID: 7758 RVA: 0x00103DB4 File Offset: 0x00101FB4
		// (set) Token: 0x06001E4F RID: 7759 RVA: 0x0001249B File Offset: 0x0001069B
		public unsafe RectTransform m_NormalGuestField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06001E50 RID: 7760 RVA: 0x00103DE4 File Offset: 0x00101FE4
		// (set) Token: 0x06001E51 RID: 7761 RVA: 0x000124BA File Offset: 0x000106BA
		public unsafe RectTransform m_SpecialGuestField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06001E52 RID: 7762 RVA: 0x00103E14 File Offset: 0x00102014
		// (set) Token: 0x06001E53 RID: 7763 RVA: 0x000124D9 File Offset: 0x000106D9
		public unsafe CanvasGroup m_NormalGuestsMoreIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestsMoreIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestsMoreIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06001E54 RID: 7764 RVA: 0x00103E44 File Offset: 0x00102044
		// (set) Token: 0x06001E55 RID: 7765 RVA: 0x000124F8 File Offset: 0x000106F8
		public unsafe CanvasGroup m_SpecialGuestsMoreIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestsMoreIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestsMoreIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06001E56 RID: 7766 RVA: 0x00103E74 File Offset: 0x00102074
		// (set) Token: 0x06001E57 RID: 7767 RVA: 0x00012517 File Offset: 0x00010717
		public unsafe List<GameObject> allNormalCharacterInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_allNormalCharacterInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_allNormalCharacterInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06001E58 RID: 7768 RVA: 0x00103EA4 File Offset: 0x001020A4
		// (set) Token: 0x06001E59 RID: 7769 RVA: 0x00012536 File Offset: 0x00010736
		public unsafe List<GameObject> allSpecialCharacterInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_allSpecialCharacterInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_allSpecialCharacterInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06001E5A RID: 7770 RVA: 0x00103ED4 File Offset: 0x001020D4
		// (set) Token: 0x06001E5B RID: 7771 RVA: 0x00012555 File Offset: 0x00010755
		public unsafe List<ValueTuple<string, CharacterSpriteSetCompact>> m_SpecialGuestPrintingCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestPrintingCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, CharacterSpriteSetCompact>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_SpecialGuestPrintingCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06001E5C RID: 7772 RVA: 0x00103F04 File Offset: 0x00102104
		// (set) Token: 0x06001E5D RID: 7773 RVA: 0x00012574 File Offset: 0x00010774
		public unsafe List<ValueTuple<string, CharacterSpriteSetCompact>> m_NormalGuestPrintingCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestPrintingCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, CharacterSpriteSetCompact>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.NativeFieldInfoPtr_m_NormalGuestPrintingCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaName;

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeFieldInfoPtr_m_CookingDeskAmount1;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeFieldInfoPtr_m_CookingDeskAmount2;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeFieldInfoPtr_m_GuestTableAmount1;

		// Token: 0x04001424 RID: 5156
		private static readonly IntPtr NativeFieldInfoPtr_m_GuestTableAmount2;

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterPrefab;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestModule;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuestModule;

		// Token: 0x04001428 RID: 5160
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuestField;

		// Token: 0x04001429 RID: 5161
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestField;

		// Token: 0x0400142A RID: 5162
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuestsMoreIndicator;

		// Token: 0x0400142B RID: 5163
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestsMoreIndicator;

		// Token: 0x0400142C RID: 5164
		private static readonly IntPtr NativeFieldInfoPtr_allNormalCharacterInstancePool;

		// Token: 0x0400142D RID: 5165
		private static readonly IntPtr NativeFieldInfoPtr_allSpecialCharacterInstancePool;

		// Token: 0x0400142E RID: 5166
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecialGuestPrintingCache;

		// Token: 0x0400142F RID: 5167
		private static readonly IntPtr NativeFieldInfoPtr_m_NormalGuestPrintingCache;

		// Token: 0x04001430 RID: 5168
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Protected_Virtual_New_get_Int32_0;

		// Token: 0x04001431 RID: 5169
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterPrefab_Protected_get_GameObject_0;

		// Token: 0x04001432 RID: 5170
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_New_Void_DLC5_RogueLikeMapDescriberOpenContext_CancellationToken_0;

		// Token: 0x04001433 RID: 5171
		private static readonly IntPtr NativeMethodInfoPtr_DescribeNull_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001434 RID: 5172
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001435 RID: 5173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006EC RID: 1772
		public sealed class DLC5_RogueLikeMapDescriberOpenContext : ValueType
		{
			// Token: 0x06009AE6 RID: 39654 RVA: 0x00292E74 File Offset: 0x00291074
			// Note: this type is marked as 'beforefieldinit'.
			static DLC5_RogueLikeMapDescriberOpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "DLC5_RogueLikeMapDescriberOpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr);
				DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_MapSetup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr, "MapSetup");
				DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_Izakaya = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr, "Izakaya");
				DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_RunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr, "RunTimeData");
				DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_DlcAreaCollectRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr, "DlcAreaCollectRate");
				DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_GetNeighbourCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr, "GetNeighbourCallback");
				DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeMethodInfoPtr__ctor_Public_Void_MapSetup_Izakaya_RogueLikeRunTimeData_DLCAreaCollectRate_IEnumerable_1_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr, 100668677);
			}

			// Token: 0x06009AE7 RID: 39655 RVA: 0x00292F18 File Offset: 0x00291118
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 75134, RefRangeEnd = 75135, XrefRangeStart = 75130, XrefRangeEnd = 75134, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLC5_RogueLikeMapDescriberOpenContext(DLC5_RogueLikeDataProfile.MapSetup mapSetup, Izakaya izakaya, RogueLikeRunTimeData runTimeData, RogueLikeRunTimeData.DLCAreaCollectRate dlcAreaCollectRate, IEnumerable<IGuideMapSpot> getNeighbourCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(mapSetup));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakaya);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(runTimeData);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dlcAreaCollectRate));
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getNeighbourCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeMethodInfoPtr__ctor_Public_Void_MapSetup_Izakaya_RogueLikeRunTimeData_DLCAreaCollectRate_IEnumerable_1_IGuideMapSpot_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AE8 RID: 39656 RVA: 0x00053DA1 File Offset: 0x00051FA1
			public DLC5_RogueLikeMapDescriberOpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009AE9 RID: 39657 RVA: 0x00053DAA File Offset: 0x00051FAA
			public DLC5_RogueLikeMapDescriberOpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x1700336D RID: 13165
			// (get) Token: 0x06009AEA RID: 39658 RVA: 0x00292FBC File Offset: 0x002911BC
			// (set) Token: 0x06009AEB RID: 39659 RVA: 0x00053DBC File Offset: 0x00051FBC
			public DLC5_RogueLikeDataProfile.MapSetup MapSetup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_MapSetup);
					return new DLC5_RogueLikeDataProfile.MapSetup(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_MapSetup), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700336E RID: 13166
			// (get) Token: 0x06009AEC RID: 39660 RVA: 0x00292FEC File Offset: 0x002911EC
			// (set) Token: 0x06009AED RID: 39661 RVA: 0x00053DEA File Offset: 0x00051FEA
			public unsafe Izakaya Izakaya
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_Izakaya);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_Izakaya), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700336F RID: 13167
			// (get) Token: 0x06009AEE RID: 39662 RVA: 0x0029301C File Offset: 0x0029121C
			// (set) Token: 0x06009AEF RID: 39663 RVA: 0x00053E09 File Offset: 0x00052009
			public unsafe RogueLikeRunTimeData RunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_RunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_RunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003370 RID: 13168
			// (get) Token: 0x06009AF0 RID: 39664 RVA: 0x0029304C File Offset: 0x0029124C
			// (set) Token: 0x06009AF1 RID: 39665 RVA: 0x00053E28 File Offset: 0x00052028
			public RogueLikeRunTimeData.DLCAreaCollectRate DlcAreaCollectRate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_DlcAreaCollectRate);
					return new RogueLikeRunTimeData.DLCAreaCollectRate(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RogueLikeRunTimeData.DLCAreaCollectRate>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_DlcAreaCollectRate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<RogueLikeRunTimeData.DLCAreaCollectRate>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003371 RID: 13169
			// (get) Token: 0x06009AF2 RID: 39666 RVA: 0x0029307C File Offset: 0x0029127C
			// (set) Token: 0x06009AF3 RID: 39667 RVA: 0x00053E56 File Offset: 0x00052056
			public unsafe IEnumerable<IGuideMapSpot> GetNeighbourCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_GetNeighbourCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<IGuideMapSpot>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext.NativeFieldInfoPtr_GetNeighbourCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064B3 RID: 25779
			private static readonly IntPtr NativeFieldInfoPtr_MapSetup;

			// Token: 0x040064B4 RID: 25780
			private static readonly IntPtr NativeFieldInfoPtr_Izakaya;

			// Token: 0x040064B5 RID: 25781
			private static readonly IntPtr NativeFieldInfoPtr_RunTimeData;

			// Token: 0x040064B6 RID: 25782
			private static readonly IntPtr NativeFieldInfoPtr_DlcAreaCollectRate;

			// Token: 0x040064B7 RID: 25783
			private static readonly IntPtr NativeFieldInfoPtr_GetNeighbourCallback;

			// Token: 0x040064B8 RID: 25784
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_MapSetup_Izakaya_RogueLikeRunTimeData_DLCAreaCollectRate_IEnumerable_1_IGuideMapSpot_0;
		}

		// Token: 0x020006ED RID: 1773
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMapDescriber+<>c__DisplayClass21_0")]
		public sealed class __c__DisplayClass21_0 : Il2CppSystem.Object
		{
			// Token: 0x06009AF4 RID: 39668 RVA: 0x002930AC File Offset: 0x002912AC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "<>c__DisplayClass21_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0>.NativeClassPtr);
				DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeFieldInfoPtr_mapInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0>.NativeClassPtr, "mapInfo");
				DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeFieldInfoPtr_roguelikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0>.NativeClassPtr, "roguelikeRunTimeData");
				DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0>.NativeClassPtr, 100668678);
				DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeMethodInfoPtr__Describe_b__1_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0>.NativeClassPtr, 100668679);
				DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeMethodInfoPtr__Describe_b__2_Internal_ConditionalSpecialGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0>.NativeClassPtr, 100668680);
			}

			// Token: 0x06009AF5 RID: 39669 RVA: 0x0029313C File Offset: 0x0029133C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AF6 RID: 39670 RVA: 0x00293178 File Offset: 0x00291378
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75135, XrefRangeEnd = 75155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Describe_b__1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeMethodInfoPtr__Describe_b__1_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009AF7 RID: 39671 RVA: 0x002931C4 File Offset: 0x002913C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75155, XrefRangeEnd = 75158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest _Describe_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeMethodInfoPtr__Describe_b__2_Internal_ConditionalSpecialGuest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest(pointer);
			}

			// Token: 0x06009AF8 RID: 39672 RVA: 0x00053E75 File Offset: 0x00052075
			public __c__DisplayClass21_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003372 RID: 13170
			// (get) Token: 0x06009AF9 RID: 39673 RVA: 0x00293208 File Offset: 0x00291408
			// (set) Token: 0x06009AFA RID: 39674 RVA: 0x00053E7E File Offset: 0x0005207E
			public DLC5_RogueLikeDataProfile.MapSetup mapInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeFieldInfoPtr_mapInfo);
					return new DLC5_RogueLikeDataProfile.MapSetup(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeFieldInfoPtr_mapInfo), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC5_RogueLikeDataProfile.MapSetup>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003373 RID: 13171
			// (get) Token: 0x06009AFB RID: 39675 RVA: 0x00293238 File Offset: 0x00291438
			// (set) Token: 0x06009AFC RID: 39676 RVA: 0x00053EAC File Offset: 0x000520AC
			public unsafe RogueLikeRunTimeData roguelikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeFieldInfoPtr_roguelikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_0.NativeFieldInfoPtr_roguelikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064B9 RID: 25785
			private static readonly IntPtr NativeFieldInfoPtr_mapInfo;

			// Token: 0x040064BA RID: 25786
			private static readonly IntPtr NativeFieldInfoPtr_roguelikeRunTimeData;

			// Token: 0x040064BB RID: 25787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064BC RID: 25788
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__1_Internal_Boolean_Int32_0;

			// Token: 0x040064BD RID: 25789
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__2_Internal_ConditionalSpecialGuest_Int32_0;
		}

		// Token: 0x020006EE RID: 1774
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMapDescriber+<>c__DisplayClass21_1")]
		public sealed class __c__DisplayClass21_1 : Il2CppSystem.Object
		{
			// Token: 0x06009AFD RID: 39677 RVA: 0x00293268 File Offset: 0x00291468
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass21_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "<>c__DisplayClass21_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1>.NativeClassPtr);
				DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1>.NativeClassPtr, "x");
				DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1>.NativeClassPtr, 100668681);
				DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__6_Internal_Boolean_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1>.NativeClassPtr, 100668682);
			}

			// Token: 0x06009AFE RID: 39678 RVA: 0x002932D0 File Offset: 0x002914D0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass21_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009AFF RID: 39679 RVA: 0x0029330C File Offset: 0x0029150C
			[CallerCount(0)]
			public unsafe bool _Describe_b__6(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(y));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1.NativeMethodInfoPtr__Describe_b__6_Internal_Boolean_ConditionalSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009B00 RID: 39680 RVA: 0x00053ECB File Offset: 0x000520CB
			public __c__DisplayClass21_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003374 RID: 13172
			// (get) Token: 0x06009B01 RID: 39681 RVA: 0x00293360 File Offset: 0x00291560
			// (set) Token: 0x06009B02 RID: 39682 RVA: 0x00053ED4 File Offset: 0x000520D4
			public unsafe int x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1.NativeFieldInfoPtr_x);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriber.__c__DisplayClass21_1.NativeFieldInfoPtr_x)) = value;
				}
			}

			// Token: 0x040064BE RID: 25790
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x040064BF RID: 25791
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064C0 RID: 25792
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__6_Internal_Boolean_ConditionalSpecialGuest_0;
		}

		// Token: 0x020006EF RID: 1775
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMapDescriber+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009B03 RID: 39683 RVA: 0x00293388 File Offset: 0x00291588
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr);
				DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, "<>9__21_0");
				DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, "<>9__21_3");
				DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, "<>9__21_4");
				DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, "<>9__21_5");
				DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, 100668684);
				DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__Describe_b__21_0_Internal_Int32_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, 100668685);
				DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__Describe_b__21_3_Internal_Int32_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, 100668686);
				DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__Describe_b__21_4_Internal_Boolean_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, 100668687);
				DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__Describe_b__21_5_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_ConditionalSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr, 100668688);
			}

			// Token: 0x06009B04 RID: 39684 RVA: 0x0029347C File Offset: 0x0029167C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriber.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B05 RID: 39685 RVA: 0x002934B8 File Offset: 0x002916B8
			[CallerCount(0)]
			public unsafe int _Describe_b__21_0(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__Describe_b__21_0_Internal_Int32_ConditionalSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009B06 RID: 39686 RVA: 0x0029350C File Offset: 0x0029170C
			[CallerCount(0)]
			public unsafe int _Describe_b__21_3(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__Describe_b__21_3_Internal_Int32_ConditionalSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009B07 RID: 39687 RVA: 0x00293560 File Offset: 0x00291760
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75158, XrefRangeEnd = 75162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _Describe_b__21_4(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__Describe_b__21_4_Internal_Boolean_ConditionalSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009B08 RID: 39688 RVA: 0x002935B4 File Offset: 0x002917B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75162, XrefRangeEnd = 75171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, CharacterSpriteSetCompact> _Describe_b__21_5(DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriber.__c.NativeMethodInfoPtr__Describe_b__21_5_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_ConditionalSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<string, CharacterSpriteSetCompact>(pointer);
			}

			// Token: 0x06009B09 RID: 39689 RVA: 0x00053EEF File Offset: 0x000520EF
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003375 RID: 13173
			// (get) Token: 0x06009B0A RID: 39690 RVA: 0x00293604 File Offset: 0x00291804
			// (set) Token: 0x06009B0B RID: 39691 RVA: 0x00053EF8 File Offset: 0x000520F8
			public unsafe static DLC5_RogueLikeMapDescriber.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMapDescriber.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003376 RID: 13174
			// (get) Token: 0x06009B0C RID: 39692 RVA: 0x0029362C File Offset: 0x0029182C
			// (set) Token: 0x06009B0D RID: 39693 RVA: 0x00053F0A File Offset: 0x0005210A
			public unsafe static Func<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest, int> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003377 RID: 13175
			// (get) Token: 0x06009B0E RID: 39694 RVA: 0x00293654 File Offset: 0x00291854
			// (set) Token: 0x06009B0F RID: 39695 RVA: 0x00053F1C File Offset: 0x0005211C
			public unsafe static Func<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest, int> __9__21_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003378 RID: 13176
			// (get) Token: 0x06009B10 RID: 39696 RVA: 0x0029367C File Offset: 0x0029187C
			// (set) Token: 0x06009B11 RID: 39697 RVA: 0x00053F2E File Offset: 0x0005212E
			public unsafe static Func<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest, bool> __9__21_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003379 RID: 13177
			// (get) Token: 0x06009B12 RID: 39698 RVA: 0x002936A4 File Offset: 0x002918A4
			// (set) Token: 0x06009B13 RID: 39699 RVA: 0x00053F40 File Offset: 0x00052140
			public unsafe static Func<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest, ValueTuple<string, CharacterSpriteSetCompact>> __9__21_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.MapSetup.ConditionalSpecialGuest, ValueTuple<string, CharacterSpriteSetCompact>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriber.__c.NativeFieldInfoPtr___9__21_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064C1 RID: 25793
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040064C2 RID: 25794
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x040064C3 RID: 25795
			private static readonly IntPtr NativeFieldInfoPtr___9__21_3;

			// Token: 0x040064C4 RID: 25796
			private static readonly IntPtr NativeFieldInfoPtr___9__21_4;

			// Token: 0x040064C5 RID: 25797
			private static readonly IntPtr NativeFieldInfoPtr___9__21_5;

			// Token: 0x040064C6 RID: 25798
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064C7 RID: 25799
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__21_0_Internal_Int32_ConditionalSpecialGuest_0;

			// Token: 0x040064C8 RID: 25800
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__21_3_Internal_Int32_ConditionalSpecialGuest_0;

			// Token: 0x040064C9 RID: 25801
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__21_4_Internal_Boolean_ConditionalSpecialGuest_0;

			// Token: 0x040064CA RID: 25802
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__21_5_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_ConditionalSpecialGuest_0;
		}
	}
}
