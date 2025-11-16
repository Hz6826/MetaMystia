using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI
{
	// Token: 0x020000BC RID: 188
	public class DaySceneClosetPannel : UIPanel
	{
		// Token: 0x060014F1 RID: 5361 RVA: 0x000E5128 File Offset: 0x000E3328
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneClosetPannel()
		{
			Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI", "DaySceneClosetPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr);
			DaySceneClosetPannel.NativeFieldInfoPtr_clothesElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "clothesElement");
			DaySceneClosetPannel.NativeFieldInfoPtr_clothesDescrierCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "clothesDescrierCluster");
			DaySceneClosetPannel.NativeFieldInfoPtr_clothesPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "clothesPannel");
			DaySceneClosetPannel.NativeFieldInfoPtr_scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "scroller");
			DaySceneClosetPannel.NativeFieldInfoPtr_SubPannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "SubPannel");
			DaySceneClosetPannel.NativeFieldInfoPtr_m_ClothesList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "m_ClothesList");
			DaySceneClosetPannel.NativeFieldInfoPtr_m_ClothesGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "m_ClothesGroup");
			DaySceneClosetPannel.NativeFieldInfoPtr__CurrentSelectedClothesIndex_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "<CurrentSelectedClothesIndex>k__BackingField");
			DaySceneClosetPannel.NativeMethodInfoPtr_get_CurrentSelectedClothesIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667055);
			DaySceneClosetPannel.NativeMethodInfoPtr_set_CurrentSelectedClothesIndex_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667056);
			DaySceneClosetPannel.NativeMethodInfoPtr_UpdateVisual_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667057);
			DaySceneClosetPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667058);
			DaySceneClosetPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667059);
			DaySceneClosetPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_Clothes_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667060);
			DaySceneClosetPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_Clothes_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667061);
			DaySceneClosetPannel.NativeMethodInfoPtr_ShowConfigPannel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667062);
			DaySceneClosetPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667063);
			DaySceneClosetPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667064);
			DaySceneClosetPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, 100667065);
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x000E52D4 File Offset: 0x000E34D4
		// (set) Token: 0x060014F3 RID: 5363 RVA: 0x000E5310 File Offset: 0x000E3510
		public unsafe int CurrentSelectedClothesIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.NativeMethodInfoPtr_get_CurrentSelectedClothesIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.NativeMethodInfoPtr_set_CurrentSelectedClothesIndex_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x000E5350 File Offset: 0x000E3550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59635, XrefRangeEnd = 59639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisual()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.NativeMethodInfoPtr_UpdateVisual_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x000E5384 File Offset: 0x000E3584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneClosetPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x000E53C0 File Offset: 0x000E35C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59639, XrefRangeEnd = 59679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneClosetPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000E53FC File Offset: 0x000E35FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59679, XrefRangeEnd = 59774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementEnabled(ClothesProfile.Clothes clothesData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clothesData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.NativeMethodInfoPtr_OnElementEnabled_Private_Void_Clothes_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x000E5464 File Offset: 0x000E3664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59774, XrefRangeEnd = 59884, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnElementSelected(ClothesProfile.Clothes clothesData, UIElementCluster cluster, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(clothesData);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.NativeMethodInfoPtr_OnElementSelected_Private_Void_Clothes_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000E54CC File Offset: 0x000E36CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59884, XrefRangeEnd = 59893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowConfigPannel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.NativeMethodInfoPtr_ShowConfigPannel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x000E5500 File Offset: 0x000E3700
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59893, XrefRangeEnd = 59898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneClosetPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x000E553C File Offset: 0x000E373C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59898, XrefRangeEnd = 59908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DaySceneClosetPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x000E5578 File Offset: 0x000E3778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59908, XrefRangeEnd = 59917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneClosetPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x0000D0BB File Offset: 0x0000B2BB
		public DaySceneClosetPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x060014FE RID: 5374 RVA: 0x000E55B4 File Offset: 0x000E37B4
		// (set) Token: 0x060014FF RID: 5375 RVA: 0x0000D0C4 File Offset: 0x0000B2C4
		public unsafe GameObject clothesElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_clothesElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_clothesElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x000E55E4 File Offset: 0x000E37E4
		// (set) Token: 0x06001501 RID: 5377 RVA: 0x0000D0E3 File Offset: 0x0000B2E3
		public unsafe UIElementCluster clothesDescrierCluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_clothesDescrierCluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_clothesDescrierCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x000E5614 File Offset: 0x000E3814
		// (set) Token: 0x06001503 RID: 5379 RVA: 0x0000D102 File Offset: 0x0000B302
		public unsafe GridLayoutGroup clothesPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_clothesPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_clothesPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x000E5644 File Offset: 0x000E3844
		// (set) Token: 0x06001505 RID: 5381 RVA: 0x0000D121 File Offset: 0x0000B321
		public unsafe AdpProgressIndicatorComponent scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpProgressIndicatorComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x000E5674 File Offset: 0x000E3874
		// (set) Token: 0x06001507 RID: 5383 RVA: 0x0000D140 File Offset: 0x0000B340
		public unsafe DaySceneClosetSubPannel SubPannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_SubPannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneClosetSubPannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_SubPannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x000E56A4 File Offset: 0x000E38A4
		// (set) Token: 0x06001509 RID: 5385 RVA: 0x0000D15F File Offset: 0x0000B35F
		public unsafe List<ClothesProfile.Clothes> m_ClothesList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_m_ClothesList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ClothesProfile.Clothes>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_m_ClothesList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x000E56D4 File Offset: 0x000E38D4
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x0000D17E File Offset: 0x0000B37E
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<ClothesProfile.Clothes, UIElementCluster, UIButtonSimple> m_ClothesGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_m_ClothesGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<ClothesProfile.Clothes, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr_m_ClothesGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x000E5704 File Offset: 0x000E3904
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x0000D19D File Offset: 0x0000B39D
		public unsafe int _CurrentSelectedClothesIndex_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr__CurrentSelectedClothesIndex_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.NativeFieldInfoPtr__CurrentSelectedClothesIndex_k__BackingField)) = value;
			}
		}

		// Token: 0x04000E29 RID: 3625
		private static readonly IntPtr NativeFieldInfoPtr_clothesElement;

		// Token: 0x04000E2A RID: 3626
		private static readonly IntPtr NativeFieldInfoPtr_clothesDescrierCluster;

		// Token: 0x04000E2B RID: 3627
		private static readonly IntPtr NativeFieldInfoPtr_clothesPannel;

		// Token: 0x04000E2C RID: 3628
		private static readonly IntPtr NativeFieldInfoPtr_scroller;

		// Token: 0x04000E2D RID: 3629
		private static readonly IntPtr NativeFieldInfoPtr_SubPannel;

		// Token: 0x04000E2E RID: 3630
		private static readonly IntPtr NativeFieldInfoPtr_m_ClothesList;

		// Token: 0x04000E2F RID: 3631
		private static readonly IntPtr NativeFieldInfoPtr_m_ClothesGroup;

		// Token: 0x04000E30 RID: 3632
		private static readonly IntPtr NativeFieldInfoPtr__CurrentSelectedClothesIndex_k__BackingField;

		// Token: 0x04000E31 RID: 3633
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSelectedClothesIndex_Public_get_Int32_0;

		// Token: 0x04000E32 RID: 3634
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentSelectedClothesIndex_Private_set_Void_Int32_0;

		// Token: 0x04000E33 RID: 3635
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisual_Public_Void_0;

		// Token: 0x04000E34 RID: 3636
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04000E35 RID: 3637
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04000E36 RID: 3638
		private static readonly IntPtr NativeMethodInfoPtr_OnElementEnabled_Private_Void_Clothes_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000E37 RID: 3639
		private static readonly IntPtr NativeMethodInfoPtr_OnElementSelected_Private_Void_Clothes_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04000E38 RID: 3640
		private static readonly IntPtr NativeMethodInfoPtr_ShowConfigPannel_Private_Void_0;

		// Token: 0x04000E39 RID: 3641
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04000E3A RID: 3642
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000E3B RID: 3643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000620 RID: 1568
		[ObfuscatedName("DayScene.UI.DaySceneClosetPannel+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x06009183 RID: 37251 RVA: 0x00277590 File Offset: 0x00275790
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass14_0>.NativeClassPtr);
				DaySceneClosetPannel.__c__DisplayClass14_0.NativeFieldInfoPtr_skinSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass14_0>.NativeClassPtr, "skinSprite");
				DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass14_0>.NativeClassPtr, 100667066);
				DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass14_0>.NativeClassPtr, 100667067);
				DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass14_0>.NativeClassPtr, 100667068);
				DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass14_0>.NativeClassPtr, 100667069);
				DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass14_0>.NativeClassPtr, 100667070);
			}

			// Token: 0x06009184 RID: 37252 RVA: 0x00277634 File Offset: 0x00275834
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009185 RID: 37253 RVA: 0x00277670 File Offset: 0x00275870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009186 RID: 37254 RVA: 0x002776B4 File Offset: 0x002758B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009187 RID: 37255 RVA: 0x002776F8 File Offset: 0x002758F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009188 RID: 37256 RVA: 0x0027773C File Offset: 0x0027593C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass14_0.NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009189 RID: 37257 RVA: 0x0004EDC8 File Offset: 0x0004CFC8
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003091 RID: 12433
			// (get) Token: 0x0600918A RID: 37258 RVA: 0x00277780 File Offset: 0x00275980
			// (set) Token: 0x0600918B RID: 37259 RVA: 0x0004EDD1 File Offset: 0x0004CFD1
			public unsafe CharacterSpriteSetCompact skinSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.__c__DisplayClass14_0.NativeFieldInfoPtr_skinSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.__c__DisplayClass14_0.NativeFieldInfoPtr_skinSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E8E RID: 24206
			private static readonly IntPtr NativeFieldInfoPtr_skinSprite;

			// Token: 0x04005E8F RID: 24207
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E90 RID: 24208
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__2_Internal_Void_Image_0;

			// Token: 0x04005E91 RID: 24209
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__3_Internal_Void_Image_0;

			// Token: 0x04005E92 RID: 24210
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__4_Internal_Void_Image_0;

			// Token: 0x04005E93 RID: 24211
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__5_Internal_Void_Image_0;
		}

		// Token: 0x02000621 RID: 1569
		[ObfuscatedName("DayScene.UI.DaySceneClosetPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600918C RID: 37260 RVA: 0x002777B0 File Offset: 0x002759B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr);
				DaySceneClosetPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, "<>9");
				DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, "<>9__14_0");
				DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, "<>9__14_1");
				DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__14_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, "<>9__14_6");
				DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__15_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, "<>9__15_8");
				DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__15_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, "<>9__15_9");
				DaySceneClosetPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, 100667072);
				DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementEnabled_b__14_0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, 100667073);
				DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementEnabled_b__14_1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, 100667074);
				DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementEnabled_b__14_6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, 100667075);
				DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementSelected_b__15_8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, 100667076);
				DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementSelected_b__15_9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr, 100667077);
			}

			// Token: 0x0600918D RID: 37261 RVA: 0x002778CC File Offset: 0x00275ACC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneClosetPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600918E RID: 37262 RVA: 0x00277908 File Offset: 0x00275B08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59611, XrefRangeEnd = 59614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__14_0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementEnabled_b__14_0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600918F RID: 37263 RVA: 0x0027794C File Offset: 0x00275B4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59614, XrefRangeEnd = 59617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__14_1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementEnabled_b__14_1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009190 RID: 37264 RVA: 0x00277990 File Offset: 0x00275B90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59617, XrefRangeEnd = 59623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementEnabled_b__14_6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementEnabled_b__14_6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009191 RID: 37265 RVA: 0x002779D4 File Offset: 0x00275BD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59623, XrefRangeEnd = 59629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__15_8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementSelected_b__15_8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009192 RID: 37266 RVA: 0x00277A18 File Offset: 0x00275C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59629, XrefRangeEnd = 59635, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__15_9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c.NativeMethodInfoPtr__OnElementSelected_b__15_9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009193 RID: 37267 RVA: 0x0004EDF0 File Offset: 0x0004CFF0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003092 RID: 12434
			// (get) Token: 0x06009194 RID: 37268 RVA: 0x00277A5C File Offset: 0x00275C5C
			// (set) Token: 0x06009195 RID: 37269 RVA: 0x0004EDF9 File Offset: 0x0004CFF9
			public unsafe static DaySceneClosetPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneClosetPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003093 RID: 12435
			// (get) Token: 0x06009196 RID: 37270 RVA: 0x00277A84 File Offset: 0x00275C84
			// (set) Token: 0x06009197 RID: 37271 RVA: 0x0004EE0B File Offset: 0x0004D00B
			public unsafe static Action<Image> __9__14_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003094 RID: 12436
			// (get) Token: 0x06009198 RID: 37272 RVA: 0x00277AAC File Offset: 0x00275CAC
			// (set) Token: 0x06009199 RID: 37273 RVA: 0x0004EE1D File Offset: 0x0004D01D
			public unsafe static Action<Image> __9__14_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003095 RID: 12437
			// (get) Token: 0x0600919A RID: 37274 RVA: 0x00277AD4 File Offset: 0x00275CD4
			// (set) Token: 0x0600919B RID: 37275 RVA: 0x0004EE2F File Offset: 0x0004D02F
			public unsafe static Action<Image> __9__14_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__14_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__14_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003096 RID: 12438
			// (get) Token: 0x0600919C RID: 37276 RVA: 0x00277AFC File Offset: 0x00275CFC
			// (set) Token: 0x0600919D RID: 37277 RVA: 0x0004EE41 File Offset: 0x0004D041
			public unsafe static Action<Image> __9__15_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__15_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__15_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003097 RID: 12439
			// (get) Token: 0x0600919E RID: 37278 RVA: 0x00277B24 File Offset: 0x00275D24
			// (set) Token: 0x0600919F RID: 37279 RVA: 0x0004EE53 File Offset: 0x0004D053
			public unsafe static Action<Image> __9__15_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__15_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DaySceneClosetPannel.__c.NativeFieldInfoPtr___9__15_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005E94 RID: 24212
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005E95 RID: 24213
			private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

			// Token: 0x04005E96 RID: 24214
			private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

			// Token: 0x04005E97 RID: 24215
			private static readonly IntPtr NativeFieldInfoPtr___9__14_6;

			// Token: 0x04005E98 RID: 24216
			private static readonly IntPtr NativeFieldInfoPtr___9__15_8;

			// Token: 0x04005E99 RID: 24217
			private static readonly IntPtr NativeFieldInfoPtr___9__15_9;

			// Token: 0x04005E9A RID: 24218
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005E9B RID: 24219
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__14_0_Internal_Void_Image_0;

			// Token: 0x04005E9C RID: 24220
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__14_1_Internal_Void_Image_0;

			// Token: 0x04005E9D RID: 24221
			private static readonly IntPtr NativeMethodInfoPtr__OnElementEnabled_b__14_6_Internal_Void_Image_0;

			// Token: 0x04005E9E RID: 24222
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__15_8_Internal_Void_Image_0;

			// Token: 0x04005E9F RID: 24223
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__15_9_Internal_Void_Image_0;
		}

		// Token: 0x02000622 RID: 1570
		[ObfuscatedName("DayScene.UI.DaySceneClosetPannel+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x060091A0 RID: 37280 RVA: 0x00277B4C File Offset: 0x00275D4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneClosetPannel>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr);
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_skinSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, "skinSprite");
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, 100667078);
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, 100667079);
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, 100667080);
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, 100667081);
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, 100667082);
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, 100667083);
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, 100667084);
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, 100667085);
				DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr, 100667086);
			}

			// Token: 0x060091A1 RID: 37281 RVA: 0x00277C40 File Offset: 0x00275E40
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneClosetPannel.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091A2 RID: 37282 RVA: 0x00277C7C File Offset: 0x00275E7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091A3 RID: 37283 RVA: 0x00277CC0 File Offset: 0x00275EC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091A4 RID: 37284 RVA: 0x00277D04 File Offset: 0x00275F04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091A5 RID: 37285 RVA: 0x00277D48 File Offset: 0x00275F48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091A6 RID: 37286 RVA: 0x00277D8C File Offset: 0x00275F8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091A7 RID: 37287 RVA: 0x00277DD0 File Offset: 0x00275FD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091A8 RID: 37288 RVA: 0x00277E14 File Offset: 0x00276014
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091A9 RID: 37289 RVA: 0x00277E58 File Offset: 0x00276058
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnElementSelected_b__7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneClosetPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnElementSelected_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060091AA RID: 37290 RVA: 0x0004EE65 File Offset: 0x0004D065
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003098 RID: 12440
			// (get) Token: 0x060091AB RID: 37291 RVA: 0x00277E9C File Offset: 0x0027609C
			// (set) Token: 0x060091AC RID: 37292 RVA: 0x0004EE6E File Offset: 0x0004D06E
			public unsafe CharacterSpriteSetCompact skinSprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_skinSprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneClosetPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_skinSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005EA0 RID: 24224
			private static readonly IntPtr NativeFieldInfoPtr_skinSprite;

			// Token: 0x04005EA1 RID: 24225
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005EA2 RID: 24226
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__0_Internal_Void_Image_0;

			// Token: 0x04005EA3 RID: 24227
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__1_Internal_Void_Image_0;

			// Token: 0x04005EA4 RID: 24228
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__2_Internal_Void_Image_0;

			// Token: 0x04005EA5 RID: 24229
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__3_Internal_Void_Image_0;

			// Token: 0x04005EA6 RID: 24230
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__4_Internal_Void_Image_0;

			// Token: 0x04005EA7 RID: 24231
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__5_Internal_Void_Image_0;

			// Token: 0x04005EA8 RID: 24232
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__6_Internal_Void_Image_0;

			// Token: 0x04005EA9 RID: 24233
			private static readonly IntPtr NativeMethodInfoPtr__OnElementSelected_b__7_Internal_Void_Image_0;
		}
	}
}
