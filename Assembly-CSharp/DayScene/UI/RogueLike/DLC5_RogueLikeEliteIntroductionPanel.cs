using System;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x0200010D RID: 269
	public class DLC5_RogueLikeEliteIntroductionPanel : UISubPanelParamOpen<DLC5_RogueLikeSpotSelectionPanel_New, DLC5_RogueLikeEliteIntroductionPanel.OpenContext>
	{
		// Token: 0x06001D6E RID: 7534 RVA: 0x001011FC File Offset: 0x000FF3FC
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeEliteIntroductionPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeEliteIntroductionPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr);
			DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteTitleName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, "m_EliteTitleName");
			DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteDes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, "m_EliteDes");
			DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, "m_EliteReward");
			DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteRewardRectTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, "m_EliteRewardRectTransform");
			DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_Cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, "m_Cluster");
			DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_RewardInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, "m_RewardInstance");
			DLC5_RogueLikeEliteIntroductionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, 100668565);
			DLC5_RogueLikeEliteIntroductionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, 100668566);
			DLC5_RogueLikeEliteIntroductionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, 100668567);
			DLC5_RogueLikeEliteIntroductionPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, 100668568);
		}

		// Token: 0x06001D6F RID: 7535 RVA: 0x001012F4 File Offset: 0x000FF4F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73954, XrefRangeEnd = 73958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteIntroductionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D70 RID: 7536 RVA: 0x00101330 File Offset: 0x000FF530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73958, XrefRangeEnd = 74042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(DLC5_RogueLikeEliteIntroductionPanel.OpenContext openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteIntroductionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D71 RID: 7537 RVA: 0x00101384 File Offset: 0x000FF584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74042, XrefRangeEnd = 74051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeEliteIntroductionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D72 RID: 7538 RVA: 0x001013C0 File Offset: 0x000FF5C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 74051, XrefRangeEnd = 74062, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeEliteIntroductionPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001D73 RID: 7539 RVA: 0x00011C8B File Offset: 0x0000FE8B
		public DLC5_RogueLikeEliteIntroductionPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06001D74 RID: 7540 RVA: 0x001013FC File Offset: 0x000FF5FC
		// (set) Token: 0x06001D75 RID: 7541 RVA: 0x00011C94 File Offset: 0x0000FE94
		public unsafe TextMeshProUGUI m_EliteTitleName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteTitleName);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteTitleName), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06001D76 RID: 7542 RVA: 0x0010142C File Offset: 0x000FF62C
		// (set) Token: 0x06001D77 RID: 7543 RVA: 0x00011CB3 File Offset: 0x0000FEB3
		public unsafe TextMeshProUGUI m_EliteDes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteDes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteDes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06001D78 RID: 7544 RVA: 0x0010145C File Offset: 0x000FF65C
		// (set) Token: 0x06001D79 RID: 7545 RVA: 0x00011CD2 File Offset: 0x0000FED2
		public unsafe GameObject m_EliteReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteReward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteReward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06001D7A RID: 7546 RVA: 0x0010148C File Offset: 0x000FF68C
		// (set) Token: 0x06001D7B RID: 7547 RVA: 0x00011CF1 File Offset: 0x0000FEF1
		public unsafe RectTransform m_EliteRewardRectTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteRewardRectTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_EliteRewardRectTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x001014BC File Offset: 0x000FF6BC
		// (set) Token: 0x06001D7D RID: 7549 RVA: 0x00011D10 File Offset: 0x0000FF10
		public unsafe UIElementCluster m_Cluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_Cluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_Cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06001D7E RID: 7550 RVA: 0x001014EC File Offset: 0x000FF6EC
		// (set) Token: 0x06001D7F RID: 7551 RVA: 0x00011D2F File Offset: 0x0000FF2F
		public unsafe List<GameObject> m_RewardInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_RewardInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.NativeFieldInfoPtr_m_RewardInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013A0 RID: 5024
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteTitleName;

		// Token: 0x040013A1 RID: 5025
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteDes;

		// Token: 0x040013A2 RID: 5026
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteReward;

		// Token: 0x040013A3 RID: 5027
		private static readonly IntPtr NativeFieldInfoPtr_m_EliteRewardRectTransform;

		// Token: 0x040013A4 RID: 5028
		private static readonly IntPtr NativeFieldInfoPtr_m_Cluster;

		// Token: 0x040013A5 RID: 5029
		private static readonly IntPtr NativeFieldInfoPtr_m_RewardInstance;

		// Token: 0x040013A6 RID: 5030
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_OpenContext_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006DE RID: 1758
		public sealed class OpenContext : ValueType
		{
			// Token: 0x06009A60 RID: 39520 RVA: 0x00291778 File Offset: 0x0028F978
			// Note: this type is marked as 'beforefieldinit'.
			static OpenContext()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, "OpenContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr);
				DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr, "RogueLikeRunTimeData");
				DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeFieldInfoPtr_EliteChallengeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr, "EliteChallengeCache");
				DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeFieldInfoPtr_MapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr, "MapLabel");
				DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_EliteChallengeCache_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr, 100668569);
			}

			// Token: 0x06009A61 RID: 39521 RVA: 0x002917F4 File Offset: 0x0028F9F4
			[CallerCount(35)]
			[CachedScanResults(RefRangeStart = 73879, RefRangeEnd = 73914, XrefRangeStart = 73876, XrefRangeEnd = 73879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OpenContext(RogueLikeRunTimeData rogueLikeRunTimeData, RogueLikeRunTimeData.EliteChallengeCache eliteChallengeCache, string mapLabel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rogueLikeRunTimeData);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eliteChallengeCache);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(mapLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_EliteChallengeCache_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A62 RID: 39522 RVA: 0x0005387E File Offset: 0x00051A7E
			public OpenContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009A63 RID: 39523 RVA: 0x00053887 File Offset: 0x00051A87
			public OpenContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr))
			{
			}

			// Token: 0x17003349 RID: 13129
			// (get) Token: 0x06009A64 RID: 39524 RVA: 0x00291868 File Offset: 0x0028FA68
			// (set) Token: 0x06009A65 RID: 39525 RVA: 0x00053899 File Offset: 0x00051A99
			public unsafe RogueLikeRunTimeData RogueLikeRunTimeData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeFieldInfoPtr_RogueLikeRunTimeData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700334A RID: 13130
			// (get) Token: 0x06009A66 RID: 39526 RVA: 0x00291898 File Offset: 0x0028FA98
			// (set) Token: 0x06009A67 RID: 39527 RVA: 0x000538B8 File Offset: 0x00051AB8
			public unsafe RogueLikeRunTimeData.EliteChallengeCache EliteChallengeCache
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeFieldInfoPtr_EliteChallengeCache);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RogueLikeRunTimeData.EliteChallengeCache>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeFieldInfoPtr_EliteChallengeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700334B RID: 13131
			// (get) Token: 0x06009A68 RID: 39528 RVA: 0x002918C8 File Offset: 0x0028FAC8
			// (set) Token: 0x06009A69 RID: 39529 RVA: 0x000538D7 File Offset: 0x00051AD7
			public unsafe string MapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeFieldInfoPtr_MapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.OpenContext.NativeFieldInfoPtr_MapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04006465 RID: 25701
			private static readonly IntPtr NativeFieldInfoPtr_RogueLikeRunTimeData;

			// Token: 0x04006466 RID: 25702
			private static readonly IntPtr NativeFieldInfoPtr_EliteChallengeCache;

			// Token: 0x04006467 RID: 25703
			private static readonly IntPtr NativeFieldInfoPtr_MapLabel;

			// Token: 0x04006468 RID: 25704
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RogueLikeRunTimeData_EliteChallengeCache_String_0;
		}

		// Token: 0x020006DF RID: 1759
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteIntroductionPanel+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x06009A6A RID: 39530 RVA: 0x002918F0 File Offset: 0x0028FAF0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_characterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr, "characterVisual");
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_openParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr, "openParam");
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr, 100668570);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr, 100668571);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr, 100668572);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr, 100668573);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr, 100668574);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_2_EliteReward_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr, 100668575);
			}

			// Token: 0x06009A6B RID: 39531 RVA: 0x002919BC File Offset: 0x0028FBBC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A6C RID: 39532 RVA: 0x002919F8 File Offset: 0x0028FBF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A6D RID: 39533 RVA: 0x00291A3C File Offset: 0x0028FC3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A6E RID: 39534 RVA: 0x00291A80 File Offset: 0x0028FC80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A6F RID: 39535 RVA: 0x00291AC4 File Offset: 0x0028FCC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A70 RID: 39536 RVA: 0x00291B08 File Offset: 0x0028FD08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73914, XrefRangeEnd = 73950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIElementCluster_ValueTuple_2_EliteReward_Boolean_PDM_0(UIElementCluster cluster, ValueTuple<RogueLikeRunTimeData.EliteChallengeBase.EliteReward, bool> eliteRewardPair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cluster);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eliteRewardPair));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_2_EliteReward_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A71 RID: 39537 RVA: 0x000538F6 File Offset: 0x00051AF6
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700334C RID: 13132
			// (get) Token: 0x06009A72 RID: 39538 RVA: 0x00291B64 File Offset: 0x0028FD64
			// (set) Token: 0x06009A73 RID: 39539 RVA: 0x000538FF File Offset: 0x00051AFF
			public unsafe CharacterSpriteSetCompact characterVisual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_characterVisual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_characterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700334D RID: 13133
			// (get) Token: 0x06009A74 RID: 39540 RVA: 0x00291B94 File Offset: 0x0028FD94
			// (set) Token: 0x06009A75 RID: 39541 RVA: 0x0005391E File Offset: 0x00051B1E
			public DLC5_RogueLikeEliteIntroductionPanel.OpenContext openParam
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_openParam);
					return new DLC5_RogueLikeEliteIntroductionPanel.OpenContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_0.NativeFieldInfoPtr_openParam), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.OpenContext>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04006469 RID: 25705
			private static readonly IntPtr NativeFieldInfoPtr_characterVisual;

			// Token: 0x0400646A RID: 25706
			private static readonly IntPtr NativeFieldInfoPtr_openParam;

			// Token: 0x0400646B RID: 25707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400646C RID: 25708
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__0_Internal_Void_Image_0;

			// Token: 0x0400646D RID: 25709
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__1_Internal_Void_Image_0;

			// Token: 0x0400646E RID: 25710
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__2_Internal_Void_Image_0;

			// Token: 0x0400646F RID: 25711
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_Image_0;

			// Token: 0x04006470 RID: 25712
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_ValueTuple_2_EliteReward_Boolean_PDM_0;
		}

		// Token: 0x020006E0 RID: 1760
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeEliteIntroductionPanel+<>c__DisplayClass8_1")]
		public sealed class __c__DisplayClass8_1 : Il2CppSystem.Object
		{
			// Token: 0x06009A76 RID: 39542 RVA: 0x00291BC4 File Offset: 0x0028FDC4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel>.NativeClassPtr, "<>c__DisplayClass8_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_rewardDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr, "rewardDescription");
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_isNotLast = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr, "isNotLast");
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_shouldStrikethrough = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr, "shouldStrikethrough");
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr, 100668576);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr, 100668577);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr, 100668578);
				DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr, 100668579);
			}

			// Token: 0x06009A77 RID: 39543 RVA: 0x00291C7C File Offset: 0x0028FE7C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A78 RID: 39544 RVA: 0x00291CB8 File Offset: 0x0028FEB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__5(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A79 RID: 39545 RVA: 0x00291CFC File Offset: 0x0028FEFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A7A RID: 39546 RVA: 0x00291D40 File Offset: 0x0028FF40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 73950, XrefRangeEnd = 73954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__7(RectTransform x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009A7B RID: 39547 RVA: 0x0005394C File Offset: 0x00051B4C
			public __c__DisplayClass8_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700334E RID: 13134
			// (get) Token: 0x06009A7C RID: 39548 RVA: 0x00291D84 File Offset: 0x0028FF84
			// (set) Token: 0x06009A7D RID: 39549 RVA: 0x00053955 File Offset: 0x00051B55
			public unsafe string rewardDescription
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_rewardDescription);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_rewardDescription), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700334F RID: 13135
			// (get) Token: 0x06009A7E RID: 39550 RVA: 0x00291DAC File Offset: 0x0028FFAC
			// (set) Token: 0x06009A7F RID: 39551 RVA: 0x00053974 File Offset: 0x00051B74
			public unsafe bool isNotLast
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_isNotLast);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_isNotLast)) = value;
				}
			}

			// Token: 0x17003350 RID: 13136
			// (get) Token: 0x06009A80 RID: 39552 RVA: 0x00291DD4 File Offset: 0x0028FFD4
			// (set) Token: 0x06009A81 RID: 39553 RVA: 0x0005398F File Offset: 0x00051B8F
			public unsafe bool shouldStrikethrough
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_shouldStrikethrough);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeEliteIntroductionPanel.__c__DisplayClass8_1.NativeFieldInfoPtr_shouldStrikethrough)) = value;
				}
			}

			// Token: 0x04006471 RID: 25713
			private static readonly IntPtr NativeFieldInfoPtr_rewardDescription;

			// Token: 0x04006472 RID: 25714
			private static readonly IntPtr NativeFieldInfoPtr_isNotLast;

			// Token: 0x04006473 RID: 25715
			private static readonly IntPtr NativeFieldInfoPtr_shouldStrikethrough;

			// Token: 0x04006474 RID: 25716
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006475 RID: 25717
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04006476 RID: 25718
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Void_Image_0;

			// Token: 0x04006477 RID: 25719
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__7_Internal_Void_RectTransform_0;
		}
	}
}
