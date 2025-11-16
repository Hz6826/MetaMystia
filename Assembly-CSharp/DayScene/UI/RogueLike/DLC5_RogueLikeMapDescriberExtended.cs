using System;
using Common.UI.GlobalMap;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000115 RID: 277
	public class DLC5_RogueLikeMapDescriberExtended : DLC5_RogueLikeMapDescriber
	{
		// Token: 0x06001E5E RID: 7774 RVA: 0x00103F34 File Offset: 0x00102134
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeMapDescriberExtended()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeMapDescriberExtended");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr);
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_IzakayaDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_IzakayaDescription");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_SpecCharacterPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_SpecCharacterPrefab");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_ItemPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_ItemPrefab");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_InviteGuestField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_InviteGuestField");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_ResourceField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_ResourceField");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CookerViewer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_CookerViewer");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CookerField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_CookerField");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_Partner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_Partner");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_Decoration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_Decoration");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_ClothesField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_ClothesField");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_NeighbourText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_NeighbourText");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_DLCLabelText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_DLCLabelText");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectRateText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_CollectRateText");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectRecipeText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_CollectRecipeText");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectItemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_CollectItemText");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectPartnerText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_CollectPartnerText");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectIzakayaText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "m_CollectIzakayaText");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allInviteCharacterInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "allInviteCharacterInstancePool");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allResourceInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "allResourceInstancePool");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allRecipeInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "allRecipeInstancePool");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allCookerInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "allCookerInstancePool");
			DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allClothesInstancePool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "allClothesInstancePool");
			DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr_get_Max_Protected_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, 100668689);
			DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr_Describe_Public_Virtual_Void_DLC5_RogueLikeMapDescriberOpenContext_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, 100668690);
			DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr_ProcessObject_Private_Static_Void_UIElementCluster_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, 100668691);
			DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, 100668692);
			DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, 100668693);
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06001E5F RID: 7775 RVA: 0x00104180 File Offset: 0x00102380
		public unsafe override int Max
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr_get_Max_Protected_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x001041C8 File Offset: 0x001023C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75450, XrefRangeEnd = 75702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Describe(DLC5_RogueLikeMapDescriber.DLC5_RogueLikeMapDescriberOpenContext data, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr_Describe_Public_Virtual_Void_DLC5_RogueLikeMapDescriberOpenContext_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x00104234 File Offset: 0x00102434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75702, XrefRangeEnd = 75715, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessObject(UIElementCluster uiElementCluster, Sprite sprite)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElementCluster);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr_ProcessObject_Private_Static_Void_UIElementCluster_Sprite_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0010427C File Offset: 0x0010247C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75715, XrefRangeEnd = 75765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x001042B8 File Offset: 0x001024B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75765, XrefRangeEnd = 75818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeMapDescriberExtended() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x00012593 File Offset: 0x00010793
		public DLC5_RogueLikeMapDescriberExtended(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06001E65 RID: 7781 RVA: 0x001042F4 File Offset: 0x001024F4
		// (set) Token: 0x06001E66 RID: 7782 RVA: 0x0001259C File Offset: 0x0001079C
		public unsafe TextMeshProUGUI m_IzakayaDescription
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_IzakayaDescription);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_IzakayaDescription), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x00104324 File Offset: 0x00102524
		// (set) Token: 0x06001E68 RID: 7784 RVA: 0x000125BB File Offset: 0x000107BB
		public unsafe GameObject m_SpecCharacterPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_SpecCharacterPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_SpecCharacterPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x00104354 File Offset: 0x00102554
		// (set) Token: 0x06001E6A RID: 7786 RVA: 0x000125DA File Offset: 0x000107DA
		public unsafe GameObject m_ItemPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_ItemPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_ItemPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06001E6B RID: 7787 RVA: 0x00104384 File Offset: 0x00102584
		// (set) Token: 0x06001E6C RID: 7788 RVA: 0x000125F9 File Offset: 0x000107F9
		public unsafe RectTransform m_InviteGuestField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_InviteGuestField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_InviteGuestField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06001E6D RID: 7789 RVA: 0x001043B4 File Offset: 0x001025B4
		// (set) Token: 0x06001E6E RID: 7790 RVA: 0x00012618 File Offset: 0x00010818
		public unsafe RectTransform m_ResourceField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_ResourceField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_ResourceField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06001E6F RID: 7791 RVA: 0x001043E4 File Offset: 0x001025E4
		// (set) Token: 0x06001E70 RID: 7792 RVA: 0x00012637 File Offset: 0x00010837
		public unsafe GameObject m_CookerViewer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CookerViewer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CookerViewer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x00104414 File Offset: 0x00102614
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x00012656 File Offset: 0x00010856
		public unsafe RectTransform m_CookerField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CookerField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CookerField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x00104444 File Offset: 0x00102644
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x00012675 File Offset: 0x00010875
		public unsafe UIElementCluster m_Partner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_Partner);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_Partner), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x00104474 File Offset: 0x00102674
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x00012694 File Offset: 0x00010894
		public unsafe UIElementCluster m_Decoration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_Decoration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_Decoration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x001044A4 File Offset: 0x001026A4
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x000126B3 File Offset: 0x000108B3
		public unsafe RectTransform m_ClothesField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_ClothesField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_ClothesField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x001044D4 File Offset: 0x001026D4
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x000126D2 File Offset: 0x000108D2
		public unsafe TextMeshProUGUI m_NeighbourText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_NeighbourText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_NeighbourText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00104504 File Offset: 0x00102704
		// (set) Token: 0x06001E7C RID: 7804 RVA: 0x000126F1 File Offset: 0x000108F1
		public unsafe TextMeshProUGUI m_DLCLabelText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_DLCLabelText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_DLCLabelText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00104534 File Offset: 0x00102734
		// (set) Token: 0x06001E7E RID: 7806 RVA: 0x00012710 File Offset: 0x00010910
		public unsafe TextMeshProUGUI m_CollectRateText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectRateText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectRateText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x00104564 File Offset: 0x00102764
		// (set) Token: 0x06001E80 RID: 7808 RVA: 0x0001272F File Offset: 0x0001092F
		public unsafe TextMeshProUGUI m_CollectRecipeText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectRecipeText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectRecipeText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06001E81 RID: 7809 RVA: 0x00104594 File Offset: 0x00102794
		// (set) Token: 0x06001E82 RID: 7810 RVA: 0x0001274E File Offset: 0x0001094E
		public unsafe TextMeshProUGUI m_CollectItemText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectItemText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectItemText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06001E83 RID: 7811 RVA: 0x001045C4 File Offset: 0x001027C4
		// (set) Token: 0x06001E84 RID: 7812 RVA: 0x0001276D File Offset: 0x0001096D
		public unsafe TextMeshProUGUI m_CollectPartnerText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectPartnerText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectPartnerText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06001E85 RID: 7813 RVA: 0x001045F4 File Offset: 0x001027F4
		// (set) Token: 0x06001E86 RID: 7814 RVA: 0x0001278C File Offset: 0x0001098C
		public unsafe TextMeshProUGUI m_CollectIzakayaText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectIzakayaText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_m_CollectIzakayaText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06001E87 RID: 7815 RVA: 0x00104624 File Offset: 0x00102824
		// (set) Token: 0x06001E88 RID: 7816 RVA: 0x000127AB File Offset: 0x000109AB
		public unsafe List<GameObject> allInviteCharacterInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allInviteCharacterInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allInviteCharacterInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06001E89 RID: 7817 RVA: 0x00104654 File Offset: 0x00102854
		// (set) Token: 0x06001E8A RID: 7818 RVA: 0x000127CA File Offset: 0x000109CA
		public unsafe List<GameObject> allResourceInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allResourceInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allResourceInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06001E8B RID: 7819 RVA: 0x00104684 File Offset: 0x00102884
		// (set) Token: 0x06001E8C RID: 7820 RVA: 0x000127E9 File Offset: 0x000109E9
		public unsafe List<GameObject> allRecipeInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allRecipeInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allRecipeInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06001E8D RID: 7821 RVA: 0x001046B4 File Offset: 0x001028B4
		// (set) Token: 0x06001E8E RID: 7822 RVA: 0x00012808 File Offset: 0x00010A08
		public unsafe List<GameObject> allCookerInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allCookerInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allCookerInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06001E8F RID: 7823 RVA: 0x001046E4 File Offset: 0x001028E4
		// (set) Token: 0x06001E90 RID: 7824 RVA: 0x00012827 File Offset: 0x00010A27
		public unsafe List<GameObject> allClothesInstancePool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allClothesInstancePool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.NativeFieldInfoPtr_allClothesInstancePool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001436 RID: 5174
		private static readonly IntPtr NativeFieldInfoPtr_m_IzakayaDescription;

		// Token: 0x04001437 RID: 5175
		private static readonly IntPtr NativeFieldInfoPtr_m_SpecCharacterPrefab;

		// Token: 0x04001438 RID: 5176
		private static readonly IntPtr NativeFieldInfoPtr_m_ItemPrefab;

		// Token: 0x04001439 RID: 5177
		private static readonly IntPtr NativeFieldInfoPtr_m_InviteGuestField;

		// Token: 0x0400143A RID: 5178
		private static readonly IntPtr NativeFieldInfoPtr_m_ResourceField;

		// Token: 0x0400143B RID: 5179
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerViewer;

		// Token: 0x0400143C RID: 5180
		private static readonly IntPtr NativeFieldInfoPtr_m_CookerField;

		// Token: 0x0400143D RID: 5181
		private static readonly IntPtr NativeFieldInfoPtr_m_Partner;

		// Token: 0x0400143E RID: 5182
		private static readonly IntPtr NativeFieldInfoPtr_m_Decoration;

		// Token: 0x0400143F RID: 5183
		private static readonly IntPtr NativeFieldInfoPtr_m_ClothesField;

		// Token: 0x04001440 RID: 5184
		private static readonly IntPtr NativeFieldInfoPtr_m_NeighbourText;

		// Token: 0x04001441 RID: 5185
		private static readonly IntPtr NativeFieldInfoPtr_m_DLCLabelText;

		// Token: 0x04001442 RID: 5186
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectRateText;

		// Token: 0x04001443 RID: 5187
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectRecipeText;

		// Token: 0x04001444 RID: 5188
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectItemText;

		// Token: 0x04001445 RID: 5189
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectPartnerText;

		// Token: 0x04001446 RID: 5190
		private static readonly IntPtr NativeFieldInfoPtr_m_CollectIzakayaText;

		// Token: 0x04001447 RID: 5191
		private static readonly IntPtr NativeFieldInfoPtr_allInviteCharacterInstancePool;

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr_allResourceInstancePool;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeFieldInfoPtr_allRecipeInstancePool;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeFieldInfoPtr_allCookerInstancePool;

		// Token: 0x0400144B RID: 5195
		private static readonly IntPtr NativeFieldInfoPtr_allClothesInstancePool;

		// Token: 0x0400144C RID: 5196
		private static readonly IntPtr NativeMethodInfoPtr_get_Max_Protected_Virtual_get_Int32_0;

		// Token: 0x0400144D RID: 5197
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Virtual_Void_DLC5_RogueLikeMapDescriberOpenContext_CancellationToken_0;

		// Token: 0x0400144E RID: 5198
		private static readonly IntPtr NativeMethodInfoPtr_ProcessObject_Private_Static_Void_UIElementCluster_Sprite_0;

		// Token: 0x0400144F RID: 5199
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001450 RID: 5200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020006F0 RID: 1776
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMapDescriberExtended+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x06009B14 RID: 39700 RVA: 0x002936CC File Offset: 0x002918CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr, "data");
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr, 100668694);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr, 100668695);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr, 100668696);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr, 100668697);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr, 100668698);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__12_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr, 100668699);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__13_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr, 100668700);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__14_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr, 100668701);
			}

			// Token: 0x06009B15 RID: 39701 RVA: 0x002937AC File Offset: 0x002919AC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B16 RID: 39702 RVA: 0x002937E8 File Offset: 0x002919E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75325, XrefRangeEnd = 75328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B17 RID: 39703 RVA: 0x0029382C File Offset: 0x00291A2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B18 RID: 39704 RVA: 0x00293870 File Offset: 0x00291A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75328, XrefRangeEnd = 75331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B19 RID: 39705 RVA: 0x002938B4 File Offset: 0x00291AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B1A RID: 39706 RVA: 0x002938F8 File Offset: 0x00291AF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__12(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__12_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B1B RID: 39707 RVA: 0x0029393C File Offset: 0x00291B3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__13(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__13_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B1C RID: 39708 RVA: 0x00293980 File Offset: 0x00291B80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__14(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeMethodInfoPtr__Describe_b__14_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B1D RID: 39709 RVA: 0x00053F52 File Offset: 0x00052152
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700337A RID: 13178
			// (get) Token: 0x06009B1E RID: 39710 RVA: 0x002939C4 File Offset: 0x00291BC4
			// (set) Token: 0x06009B1F RID: 39711 RVA: 0x00053F5B File Offset: 0x0005215B
			public ValueTuple<string, CharacterSpriteSetFull> data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeFieldInfoPtr_data);
					return new ValueTuple<string, CharacterSpriteSetFull>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, CharacterSpriteSetFull>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass24_0.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, CharacterSpriteSetFull>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040064CB RID: 25803
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x040064CC RID: 25804
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064CD RID: 25805
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__8_Internal_Void_Image_0;

			// Token: 0x040064CE RID: 25806
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__9_Internal_Void_Image_0;

			// Token: 0x040064CF RID: 25807
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__10_Internal_Void_Image_0;

			// Token: 0x040064D0 RID: 25808
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__11_Internal_Void_Image_0;

			// Token: 0x040064D1 RID: 25809
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__12_Internal_Void_Image_0;

			// Token: 0x040064D2 RID: 25810
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__13_Internal_Void_Image_0;

			// Token: 0x040064D3 RID: 25811
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__14_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x020006F1 RID: 1777
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMapDescriberExtended+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009B20 RID: 39712 RVA: 0x002939F4 File Offset: 0x00291BF4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr);
				DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, "<>9__24_0");
				DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, "<>9__24_1");
				DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, "<>9__24_2");
				DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, "<>9__24_3");
				DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, "<>9__24_4");
				DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, "<>9__24_5");
				DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, "<>9__24_7");
				DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, "<>9__24_6");
				DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, 100668703);
				DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_0_Internal_String_IGuideMapSpot_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, 100668704);
				DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_1_Internal_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, 100668705);
				DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_2_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, 100668706);
				DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_3_Internal_Sprite_IngredientRange_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, 100668707);
				DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_4_Internal_Sprite_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, 100668708);
				DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_5_Internal_ValueTuple_2_String_CharacterSpriteSetFull_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, 100668709);
				DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_6_Internal_Void_UIElementCluster_ValueTuple_2_String_CharacterSpriteSetFull_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, 100668710);
				DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr, 100668711);
			}

			// Token: 0x06009B21 RID: 39713 RVA: 0x00293B88 File Offset: 0x00291D88
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B22 RID: 39714 RVA: 0x00293BC4 File Offset: 0x00291DC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75331, XrefRangeEnd = 75337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _Describe_b__24_0(IGuideMapSpot x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_0_Internal_String_IGuideMapSpot_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009B23 RID: 39715 RVA: 0x00293C0C File Offset: 0x00291E0C
			[CallerCount(0)]
			public unsafe int _Describe_b__24_1(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_1_Internal_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06009B24 RID: 39716 RVA: 0x00293C58 File Offset: 0x00291E58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75337, XrefRangeEnd = 75345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, CharacterSpriteSetCompact> _Describe_b__24_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_2_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<string, CharacterSpriteSetCompact>(pointer);
			}

			// Token: 0x06009B25 RID: 39717 RVA: 0x00293C9C File Offset: 0x00291E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75345, XrefRangeEnd = 75346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _Describe_b__24_3(DLC5_RogueLikeDataProfile.MapSetup.IngredientRange x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_3_Internal_Sprite_IngredientRange_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x06009B26 RID: 39718 RVA: 0x00293CE8 File Offset: 0x00291EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75346, XrefRangeEnd = 75348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Sprite _Describe_b__24_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_4_Internal_Sprite_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr3) : null;
			}

			// Token: 0x06009B27 RID: 39719 RVA: 0x00293D34 File Offset: 0x00291F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75348, XrefRangeEnd = 75365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ValueTuple<string, CharacterSpriteSetFull> _Describe_b__24_5(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_5_Internal_ValueTuple_2_String_CharacterSpriteSetFull_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new ValueTuple<string, CharacterSpriteSetFull>(pointer);
			}

			// Token: 0x06009B28 RID: 39720 RVA: 0x00293D78 File Offset: 0x00291F78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75365, XrefRangeEnd = 75443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__24_6(UIElementCluster visual, ValueTuple<string, CharacterSpriteSetFull> data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_6_Internal_Void_UIElementCluster_ValueTuple_2_String_CharacterSpriteSetFull_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B29 RID: 39721 RVA: 0x00293DD4 File Offset: 0x00291FD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75443, XrefRangeEnd = 75450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Describe_b__24_7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c.NativeMethodInfoPtr__Describe_b__24_7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B2A RID: 39722 RVA: 0x00053F89 File Offset: 0x00052189
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700337B RID: 13179
			// (get) Token: 0x06009B2B RID: 39723 RVA: 0x00293E18 File Offset: 0x00292018
			// (set) Token: 0x06009B2C RID: 39724 RVA: 0x00053F92 File Offset: 0x00052192
			public unsafe static DLC5_RogueLikeMapDescriberExtended.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeMapDescriberExtended.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700337C RID: 13180
			// (get) Token: 0x06009B2D RID: 39725 RVA: 0x00293E40 File Offset: 0x00292040
			// (set) Token: 0x06009B2E RID: 39726 RVA: 0x00053FA4 File Offset: 0x000521A4
			public unsafe static Func<IGuideMapSpot, string> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IGuideMapSpot, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700337D RID: 13181
			// (get) Token: 0x06009B2F RID: 39727 RVA: 0x00293E68 File Offset: 0x00292068
			// (set) Token: 0x06009B30 RID: 39728 RVA: 0x00053FB6 File Offset: 0x000521B6
			public unsafe static Func<int, int> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700337E RID: 13182
			// (get) Token: 0x06009B31 RID: 39729 RVA: 0x00293E90 File Offset: 0x00292090
			// (set) Token: 0x06009B32 RID: 39730 RVA: 0x00053FC8 File Offset: 0x000521C8
			public unsafe static Func<int, ValueTuple<string, CharacterSpriteSetCompact>> __9__24_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, ValueTuple<string, CharacterSpriteSetCompact>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700337F RID: 13183
			// (get) Token: 0x06009B33 RID: 39731 RVA: 0x00293EB8 File Offset: 0x002920B8
			// (set) Token: 0x06009B34 RID: 39732 RVA: 0x00053FDA File Offset: 0x000521DA
			public unsafe static Func<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange, Sprite> __9__24_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeDataProfile.MapSetup.IngredientRange, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003380 RID: 13184
			// (get) Token: 0x06009B35 RID: 39733 RVA: 0x00293EE0 File Offset: 0x002920E0
			// (set) Token: 0x06009B36 RID: 39734 RVA: 0x00053FEC File Offset: 0x000521EC
			public unsafe static Func<int, Sprite> __9__24_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Sprite>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003381 RID: 13185
			// (get) Token: 0x06009B37 RID: 39735 RVA: 0x00293F08 File Offset: 0x00292108
			// (set) Token: 0x06009B38 RID: 39736 RVA: 0x00053FFE File Offset: 0x000521FE
			public unsafe static Func<int, ValueTuple<string, CharacterSpriteSetFull>> __9__24_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, ValueTuple<string, CharacterSpriteSetFull>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003382 RID: 13186
			// (get) Token: 0x06009B39 RID: 39737 RVA: 0x00293F30 File Offset: 0x00292130
			// (set) Token: 0x06009B3A RID: 39738 RVA: 0x00054010 File Offset: 0x00052210
			public unsafe static Action<Image> __9__24_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003383 RID: 13187
			// (get) Token: 0x06009B3B RID: 39739 RVA: 0x00293F58 File Offset: 0x00292158
			// (set) Token: 0x06009B3C RID: 39740 RVA: 0x00054022 File Offset: 0x00052222
			public unsafe static Action<UIElementCluster, ValueTuple<string, CharacterSpriteSetFull>> __9__24_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster, ValueTuple<string, CharacterSpriteSetFull>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeMapDescriberExtended.__c.NativeFieldInfoPtr___9__24_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064D4 RID: 25812
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040064D5 RID: 25813
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x040064D6 RID: 25814
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x040064D7 RID: 25815
			private static readonly IntPtr NativeFieldInfoPtr___9__24_2;

			// Token: 0x040064D8 RID: 25816
			private static readonly IntPtr NativeFieldInfoPtr___9__24_3;

			// Token: 0x040064D9 RID: 25817
			private static readonly IntPtr NativeFieldInfoPtr___9__24_4;

			// Token: 0x040064DA RID: 25818
			private static readonly IntPtr NativeFieldInfoPtr___9__24_5;

			// Token: 0x040064DB RID: 25819
			private static readonly IntPtr NativeFieldInfoPtr___9__24_7;

			// Token: 0x040064DC RID: 25820
			private static readonly IntPtr NativeFieldInfoPtr___9__24_6;

			// Token: 0x040064DD RID: 25821
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064DE RID: 25822
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__24_0_Internal_String_IGuideMapSpot_0;

			// Token: 0x040064DF RID: 25823
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__24_1_Internal_Int32_Int32_0;

			// Token: 0x040064E0 RID: 25824
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__24_2_Internal_ValueTuple_2_String_CharacterSpriteSetCompact_Int32_0;

			// Token: 0x040064E1 RID: 25825
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__24_3_Internal_Sprite_IngredientRange_0;

			// Token: 0x040064E2 RID: 25826
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__24_4_Internal_Sprite_Int32_0;

			// Token: 0x040064E3 RID: 25827
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__24_5_Internal_ValueTuple_2_String_CharacterSpriteSetFull_Int32_0;

			// Token: 0x040064E4 RID: 25828
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__24_6_Internal_Void_UIElementCluster_ValueTuple_2_String_CharacterSpriteSetFull_0;

			// Token: 0x040064E5 RID: 25829
			private static readonly IntPtr NativeMethodInfoPtr__Describe_b__24_7_Internal_Void_Image_0;
		}

		// Token: 0x020006F2 RID: 1778
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeMapDescriberExtended+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x06009B3D RID: 39741 RVA: 0x00293F80 File Offset: 0x00292180
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0>.NativeClassPtr);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0.NativeFieldInfoPtr_sprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0>.NativeClassPtr, "sprite");
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0>.NativeClassPtr, 100668712);
				DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessObject_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0>.NativeClassPtr, 100668713);
			}

			// Token: 0x06009B3E RID: 39742 RVA: 0x00293FE8 File Offset: 0x002921E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B3F RID: 39743 RVA: 0x00294024 File Offset: 0x00292224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ProcessObject_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0.NativeMethodInfoPtr__ProcessObject_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009B40 RID: 39744 RVA: 0x00054034 File Offset: 0x00052234
			public __c__DisplayClass25_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003384 RID: 13188
			// (get) Token: 0x06009B41 RID: 39745 RVA: 0x00294068 File Offset: 0x00292268
			// (set) Token: 0x06009B42 RID: 39746 RVA: 0x0005403D File Offset: 0x0005223D
			public unsafe Sprite sprite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0.NativeFieldInfoPtr_sprite);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeMapDescriberExtended.__c__DisplayClass25_0.NativeFieldInfoPtr_sprite), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040064E6 RID: 25830
			private static readonly IntPtr NativeFieldInfoPtr_sprite;

			// Token: 0x040064E7 RID: 25831
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040064E8 RID: 25832
			private static readonly IntPtr NativeMethodInfoPtr__ProcessObject_b__0_Internal_Void_Image_0;
		}
	}
}
