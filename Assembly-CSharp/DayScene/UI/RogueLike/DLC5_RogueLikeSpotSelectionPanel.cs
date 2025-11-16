using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000123 RID: 291
	public class DLC5_RogueLikeSpotSelectionPanel : UIPanelParam<ValueTuple<IReadOnlyDictionary<string, UnlockedIzakayaInfo>, string, bool, bool>, ValueTuple<string, UnlockedIzakayaInfo>>
	{
		// Token: 0x0600216E RID: 8558 RVA: 0x0010D290 File Offset: 0x0010B490
		// Note: this type is marked as 'beforefieldinit'.
		static DLC5_RogueLikeSpotSelectionPanel()
		{
			Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "DLC5_RogueLikeSpotSelectionPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr);
			DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_MapConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "m_MapConnections");
			DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_LayoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "m_LayoutGroup");
			DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_ElementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "m_ElementPrefab");
			DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "m_Group");
			DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_MapConnectionDictionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "m_MapConnectionDictionary");
			DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_DataSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "m_DataSet");
			DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_MapExploredData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "m_MapExploredData");
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669274);
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669275);
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_OnSelectMap_Private_UniTaskVoid_ValueTuple_2_String_UnlockedIzakayaInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669276);
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_4_IReadOnlyDictionary_2_String_UnlockedIzakayaInfo_String_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669277);
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_AddSpotToDataSet_Private_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669278);
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669279);
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669280);
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669281);
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_2_Private_Void_ValueTuple_2_String_UnlockedIzakayaInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669282);
			DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_3_Private_Void_ValueTuple_2_String_UnlockedIzakayaInfo_UIElementCluster_UIButtonSimple_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, 100669283);
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x0010D414 File Offset: 0x0010B614
		[CallerCount(0)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x0010D45C File Offset: 0x0010B65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81849, XrefRangeEnd = 81911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x0010D498 File Offset: 0x0010B698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81911, XrefRangeEnd = 81917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTaskVoid OnSelectMap(ValueTuple<string, UnlockedIzakayaInfo> tuple)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tuple));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_OnSelectMap_Private_UniTaskVoid_ValueTuple_2_String_UnlockedIzakayaInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x0010D4EC File Offset: 0x0010B6EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81917, XrefRangeEnd = 81962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen(ValueTuple<IReadOnlyDictionary<string, UnlockedIzakayaInfo>, string, bool, bool> openParam)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(openParam));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_4_IReadOnlyDictionary_2_String_UnlockedIzakayaInfo_String_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x0010D540 File Offset: 0x0010B740
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 81967, RefRangeEnd = 81969, XrefRangeStart = 81962, XrefRangeEnd = 81967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSpotToDataSet(string spotCandidateName, int level)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(spotCandidateName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_AddSpotToDataSet_Private_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0010D590 File Offset: 0x0010B790
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0010D5CC File Offset: 0x0010B7CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81969, XrefRangeEnd = 81981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0010D608 File Offset: 0x0010B808
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81981, XrefRangeEnd = 81999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC5_RogueLikeSpotSelectionPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x0010D644 File Offset: 0x0010B844
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81999, XrefRangeEnd = 82023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_2(ValueTuple<string, UnlockedIzakayaInfo> tuple, UIElementCluster cluster, UIButtonSimple _)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tuple));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cluster);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_2_Private_Void_ValueTuple_2_String_UnlockedIzakayaInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x0010D6B0 File Offset: 0x0010B8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82023, XrefRangeEnd = 82037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPanelInitialize_b__9_3(ValueTuple<string, UnlockedIzakayaInfo> tuple, UIElementCluster _, UIButtonSimple button)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(tuple));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(button);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.NativeMethodInfoPtr__OnPanelInitialize_b__9_3_Private_Void_ValueTuple_2_String_UnlockedIzakayaInfo_UIElementCluster_UIButtonSimple_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00014618 File Offset: 0x00012818
		public DLC5_RogueLikeSpotSelectionPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x0600217A RID: 8570 RVA: 0x0010D71C File Offset: 0x0010B91C
		// (set) Token: 0x0600217B RID: 8571 RVA: 0x00014621 File Offset: 0x00012821
		public unsafe Il2CppReferenceArray<DLC5_RogueLikeSpotSelectionPanel.MapConnections> m_MapConnections
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_MapConnections);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DLC5_RogueLikeSpotSelectionPanel.MapConnections>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_MapConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x0600217C RID: 8572 RVA: 0x0010D74C File Offset: 0x0010B94C
		// (set) Token: 0x0600217D RID: 8573 RVA: 0x00014640 File Offset: 0x00012840
		public unsafe GridLayoutGroup m_LayoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_LayoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GridLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_LayoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x0600217E RID: 8574 RVA: 0x0010D77C File Offset: 0x0010B97C
		// (set) Token: 0x0600217F RID: 8575 RVA: 0x0001465F File Offset: 0x0001285F
		public unsafe GameObject m_ElementPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_ElementPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_ElementPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002180 RID: 8576 RVA: 0x0010D7AC File Offset: 0x0010B9AC
		// (set) Token: 0x06002181 RID: 8577 RVA: 0x0001467E File Offset: 0x0001287E
		public unsafe StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<string, UnlockedIzakayaInfo>, UIElementCluster, UIButtonSimple> m_Group
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_Group);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StaticVerticalGridScrollListUILogicalGroupT<ValueTuple<string, UnlockedIzakayaInfo>, UIElementCluster, UIButtonSimple>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002182 RID: 8578 RVA: 0x0010D7DC File Offset: 0x0010B9DC
		// (set) Token: 0x06002183 RID: 8579 RVA: 0x0001469D File Offset: 0x0001289D
		public unsafe Dictionary<string, HashSet<string>> m_MapConnectionDictionary
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_MapConnectionDictionary);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, HashSet<string>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_MapConnectionDictionary), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x0010D80C File Offset: 0x0010BA0C
		// (set) Token: 0x06002185 RID: 8581 RVA: 0x000146BC File Offset: 0x000128BC
		public unsafe List<ValueTuple<string, UnlockedIzakayaInfo>> m_DataSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_DataSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<string, UnlockedIzakayaInfo>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_DataSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002186 RID: 8582 RVA: 0x0010D83C File Offset: 0x0010BA3C
		// (set) Token: 0x06002187 RID: 8583 RVA: 0x000146DB File Offset: 0x000128DB
		public unsafe List<string> m_MapExploredData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_MapExploredData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.NativeFieldInfoPtr_m_MapExploredData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001630 RID: 5680
		private static readonly IntPtr NativeFieldInfoPtr_m_MapConnections;

		// Token: 0x04001631 RID: 5681
		private static readonly IntPtr NativeFieldInfoPtr_m_LayoutGroup;

		// Token: 0x04001632 RID: 5682
		private static readonly IntPtr NativeFieldInfoPtr_m_ElementPrefab;

		// Token: 0x04001633 RID: 5683
		private static readonly IntPtr NativeFieldInfoPtr_m_Group;

		// Token: 0x04001634 RID: 5684
		private static readonly IntPtr NativeFieldInfoPtr_m_MapConnectionDictionary;

		// Token: 0x04001635 RID: 5685
		private static readonly IntPtr NativeFieldInfoPtr_m_DataSet;

		// Token: 0x04001636 RID: 5686
		private static readonly IntPtr NativeFieldInfoPtr_m_MapExploredData;

		// Token: 0x04001637 RID: 5687
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04001638 RID: 5688
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001639 RID: 5689
		private static readonly IntPtr NativeMethodInfoPtr_OnSelectMap_Private_UniTaskVoid_ValueTuple_2_String_UnlockedIzakayaInfo_0;

		// Token: 0x0400163A RID: 5690
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_ValueTuple_4_IReadOnlyDictionary_2_String_UnlockedIzakayaInfo_String_Boolean_Boolean_0;

		// Token: 0x0400163B RID: 5691
		private static readonly IntPtr NativeMethodInfoPtr_AddSpotToDataSet_Private_Void_String_Int32_0;

		// Token: 0x0400163C RID: 5692
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelDestroyed_Protected_Virtual_Void_0;

		// Token: 0x0400163D RID: 5693
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x0400163E RID: 5694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400163F RID: 5695
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_2_Private_Void_ValueTuple_2_String_UnlockedIzakayaInfo_UIElementCluster_UIButtonSimple_0;

		// Token: 0x04001640 RID: 5696
		private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_3_Private_Void_ValueTuple_2_String_UnlockedIzakayaInfo_UIElementCluster_UIButtonSimple_0;

		// Token: 0x02000737 RID: 1847
		[Serializable]
		public sealed class MapConnections : ValueType
		{
			// Token: 0x06009E4D RID: 40525 RVA: 0x0029E988 File Offset: 0x0029CB88
			// Note: this type is marked as 'beforefieldinit'.
			static MapConnections()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.MapConnections>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "MapConnections");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.MapConnections>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeFieldInfoPtr_m_MapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.MapConnections>.NativeClassPtr, "m_MapName");
				DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeFieldInfoPtr_m_MapConnections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.MapConnections>.NativeClassPtr, "m_MapConnections");
				DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeMethodInfoPtr_get_MapName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.MapConnections>.NativeClassPtr, 100669284);
				DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeMethodInfoPtr_get_MapConnectionsInfo_Public_get_IReadOnlyList_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.MapConnections>.NativeClassPtr, 100669285);
			}

			// Token: 0x17003450 RID: 13392
			// (get) Token: 0x06009E4E RID: 40526 RVA: 0x0029EA04 File Offset: 0x0029CC04
			public unsafe string MapName
			{
				[CallerCount(96)]
				[CachedScanResults(RefRangeStart = 2638, RefRangeEnd = 2734, XrefRangeStart = 2638, XrefRangeEnd = 2734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeMethodInfoPtr_get_MapName_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17003451 RID: 13393
			// (get) Token: 0x06009E4F RID: 40527 RVA: 0x0029EA40 File Offset: 0x0029CC40
			public unsafe IReadOnlyList<string> MapConnectionsInfo
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeMethodInfoPtr_get_MapConnectionsInfo_Public_get_IReadOnlyList_1_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReadOnlyList<string>>(intPtr3) : null;
				}
			}

			// Token: 0x06009E50 RID: 40528 RVA: 0x000556A0 File Offset: 0x000538A0
			public MapConnections(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009E51 RID: 40529 RVA: 0x000556A9 File Offset: 0x000538A9
			public MapConnections() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.MapConnections>.NativeClassPtr))
			{
			}

			// Token: 0x1700344E RID: 13390
			// (get) Token: 0x06009E52 RID: 40530 RVA: 0x0029EA84 File Offset: 0x0029CC84
			// (set) Token: 0x06009E53 RID: 40531 RVA: 0x000556BB File Offset: 0x000538BB
			public unsafe string m_MapName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeFieldInfoPtr_m_MapName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeFieldInfoPtr_m_MapName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700344F RID: 13391
			// (get) Token: 0x06009E54 RID: 40532 RVA: 0x0029EAAC File Offset: 0x0029CCAC
			// (set) Token: 0x06009E55 RID: 40533 RVA: 0x000556DA File Offset: 0x000538DA
			public unsafe Il2CppStringArray m_MapConnections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeFieldInfoPtr_m_MapConnections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.MapConnections.NativeFieldInfoPtr_m_MapConnections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040066C6 RID: 26310
			private static readonly IntPtr NativeFieldInfoPtr_m_MapName;

			// Token: 0x040066C7 RID: 26311
			private static readonly IntPtr NativeFieldInfoPtr_m_MapConnections;

			// Token: 0x040066C8 RID: 26312
			private static readonly IntPtr NativeMethodInfoPtr_get_MapName_Public_get_String_0;

			// Token: 0x040066C9 RID: 26313
			private static readonly IntPtr NativeMethodInfoPtr_get_MapConnectionsInfo_Public_get_IReadOnlyList_1_String_0;
		}

		// Token: 0x02000738 RID: 1848
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x06009E56 RID: 40534 RVA: 0x0029EADC File Offset: 0x0029CCDC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_tuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, "tuple");
				DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100669286);
				DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr, 100669287);
			}

			// Token: 0x06009E57 RID: 40535 RVA: 0x0029EB58 File Offset: 0x0029CD58
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E58 RID: 40536 RVA: 0x0029EB94 File Offset: 0x0029CD94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81822, XrefRangeEnd = 81827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E59 RID: 40537 RVA: 0x000556F9 File Offset: 0x000538F9
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003452 RID: 13394
			// (get) Token: 0x06009E5A RID: 40538 RVA: 0x0029EBD8 File Offset: 0x0029CDD8
			// (set) Token: 0x06009E5B RID: 40539 RVA: 0x00055702 File Offset: 0x00053902
			public ValueTuple<string, UnlockedIzakayaInfo> tuple
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_tuple);
					return new ValueTuple<string, UnlockedIzakayaInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, UnlockedIzakayaInfo>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr_tuple), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, UnlockedIzakayaInfo>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003453 RID: 13395
			// (get) Token: 0x06009E5C RID: 40540 RVA: 0x0029EC08 File Offset: 0x0029CE08
			// (set) Token: 0x06009E5D RID: 40541 RVA: 0x00055730 File Offset: 0x00053930
			public unsafe DLC5_RogueLikeSpotSelectionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040066CA RID: 26314
			private static readonly IntPtr NativeFieldInfoPtr_tuple;

			// Token: 0x040066CB RID: 26315
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040066CC RID: 26316
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040066CD RID: 26317
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_Image_0;
		}

		// Token: 0x02000739 RID: 1849
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel+<>c__DisplayClass9_1")]
		public sealed class __c__DisplayClass9_1 : Il2CppSystem.Object
		{
			// Token: 0x06009E5E RID: 40542 RVA: 0x0029EC38 File Offset: 0x0029CE38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_1()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "<>c__DisplayClass9_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_tuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, "tuple");
				DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, 100669288);
				DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr, 100669289);
			}

			// Token: 0x06009E5F RID: 40543 RVA: 0x0029ECB4 File Offset: 0x0029CEB4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E60 RID: 40544 RVA: 0x0029ECF0 File Offset: 0x0029CEF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81827, XrefRangeEnd = 81834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E61 RID: 40545 RVA: 0x0005574F File Offset: 0x0005394F
			public __c__DisplayClass9_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003454 RID: 13396
			// (get) Token: 0x06009E62 RID: 40546 RVA: 0x0029ED24 File Offset: 0x0029CF24
			// (set) Token: 0x06009E63 RID: 40547 RVA: 0x00055758 File Offset: 0x00053958
			public ValueTuple<string, UnlockedIzakayaInfo> tuple
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_tuple);
					return new ValueTuple<string, UnlockedIzakayaInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, UnlockedIzakayaInfo>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr_tuple), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, UnlockedIzakayaInfo>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17003455 RID: 13397
			// (get) Token: 0x06009E64 RID: 40548 RVA: 0x0029ED54 File Offset: 0x0029CF54
			// (set) Token: 0x06009E65 RID: 40549 RVA: 0x00055786 File Offset: 0x00053986
			public unsafe DLC5_RogueLikeSpotSelectionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel.__c__DisplayClass9_1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040066CE RID: 26318
			private static readonly IntPtr NativeFieldInfoPtr_tuple;

			// Token: 0x040066CF RID: 26319
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040066D0 RID: 26320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040066D1 RID: 26321
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_0;
		}

		// Token: 0x0200073A RID: 1850
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06009E66 RID: 40550 RVA: 0x0029ED84 File Offset: 0x0029CF84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c>.NativeClassPtr, "<>9");
				DLC5_RogueLikeSpotSelectionPanel.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c>.NativeClassPtr, "<>9__9_0");
				DLC5_RogueLikeSpotSelectionPanel.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c>.NativeClassPtr, "<>9__9_1");
				DLC5_RogueLikeSpotSelectionPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c>.NativeClassPtr, 100669291);
				DLC5_RogueLikeSpotSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Internal_String_MapConnections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c>.NativeClassPtr, 100669292);
				DLC5_RogueLikeSpotSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Internal_HashSet_1_String_MapConnections_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c>.NativeClassPtr, 100669293);
			}

			// Token: 0x06009E67 RID: 40551 RVA: 0x0029EE28 File Offset: 0x0029D028
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E68 RID: 40552 RVA: 0x0029EE64 File Offset: 0x0029D064
			[CallerCount(0)]
			public unsafe string _OnPanelInitialize_b__9_0(DLC5_RogueLikeSpotSelectionPanel.MapConnections x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Internal_String_MapConnections_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06009E69 RID: 40553 RVA: 0x0029EEB4 File Offset: 0x0029D0B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81834, XrefRangeEnd = 81837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HashSet<string> _OnPanelInitialize_b__9_1(DLC5_RogueLikeSpotSelectionPanel.MapConnections x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Internal_HashSet_1_String_MapConnections_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}

			// Token: 0x06009E6A RID: 40554 RVA: 0x000557A5 File Offset: 0x000539A5
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003456 RID: 13398
			// (get) Token: 0x06009E6B RID: 40555 RVA: 0x0029EF0C File Offset: 0x0029D10C
			// (set) Token: 0x06009E6C RID: 40556 RVA: 0x000557AE File Offset: 0x000539AE
			public unsafe static DLC5_RogueLikeSpotSelectionPanel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003457 RID: 13399
			// (get) Token: 0x06009E6D RID: 40557 RVA: 0x0029EF34 File Offset: 0x0029D134
			// (set) Token: 0x06009E6E RID: 40558 RVA: 0x000557C0 File Offset: 0x000539C0
			public unsafe static Func<DLC5_RogueLikeSpotSelectionPanel.MapConnections, string> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeSpotSelectionPanel.MapConnections, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003458 RID: 13400
			// (get) Token: 0x06009E6F RID: 40559 RVA: 0x0029EF5C File Offset: 0x0029D15C
			// (set) Token: 0x06009E70 RID: 40560 RVA: 0x000557D2 File Offset: 0x000539D2
			public unsafe static Func<DLC5_RogueLikeSpotSelectionPanel.MapConnections, HashSet<string>> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DLC5_RogueLikeSpotSelectionPanel.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<DLC5_RogueLikeSpotSelectionPanel.MapConnections, HashSet<string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DLC5_RogueLikeSpotSelectionPanel.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040066D2 RID: 26322
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040066D3 RID: 26323
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x040066D4 RID: 26324
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x040066D5 RID: 26325
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040066D6 RID: 26326
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_0_Internal_String_MapConnections_0;

			// Token: 0x040066D7 RID: 26327
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__9_1_Internal_HashSet_1_String_MapConnections_0;
		}

		// Token: 0x0200073B RID: 1851
		[ObfuscatedName("DayScene.UI.RogueLike.DLC5_RogueLikeSpotSelectionPanel+<OnSelectMap>d__10")]
		public sealed class _OnSelectMap_d__10 : ValueType
		{
			// Token: 0x06009E71 RID: 40561 RVA: 0x0029EF84 File Offset: 0x0029D184
			// Note: this type is marked as 'beforefieldinit'.
			static _OnSelectMap_d__10()
			{
				Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel>.NativeClassPtr, "<OnSelectMap>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr);
				DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr, "<>1__state");
				DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr, "<>t__builder");
				DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr, "<>4__this");
				DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr_tuple = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr, "tuple");
				DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr, "<>u__1");
				DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr, 100669294);
				DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr, 100669295);
			}

			// Token: 0x06009E72 RID: 40562 RVA: 0x0029F03C File Offset: 0x0029D23C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 81847, RefRangeEnd = 81849, XrefRangeStart = 81837, XrefRangeEnd = 81847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E73 RID: 40563 RVA: 0x0029F074 File Offset: 0x0029D274
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06009E74 RID: 40564 RVA: 0x000557E4 File Offset: 0x000539E4
			public _OnSelectMap_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06009E75 RID: 40565 RVA: 0x000557ED File Offset: 0x000539ED
			public _OnSelectMap_d__10() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10>.NativeClassPtr))
			{
			}

			// Token: 0x17003459 RID: 13401
			// (get) Token: 0x06009E76 RID: 40566 RVA: 0x0029F0BC File Offset: 0x0029D2BC
			// (set) Token: 0x06009E77 RID: 40567 RVA: 0x000557FF File Offset: 0x000539FF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700345A RID: 13402
			// (get) Token: 0x06009E78 RID: 40568 RVA: 0x0029F0E4 File Offset: 0x0029D2E4
			// (set) Token: 0x06009E79 RID: 40569 RVA: 0x0005581A File Offset: 0x00053A1A
			public AsyncUniTaskVoidMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskVoidMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskVoidMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700345B RID: 13403
			// (get) Token: 0x06009E7A RID: 40570 RVA: 0x0029F114 File Offset: 0x0029D314
			// (set) Token: 0x06009E7B RID: 40571 RVA: 0x00055848 File Offset: 0x00053A48
			public unsafe DLC5_RogueLikeSpotSelectionPanel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DLC5_RogueLikeSpotSelectionPanel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700345C RID: 13404
			// (get) Token: 0x06009E7C RID: 40572 RVA: 0x0029F144 File Offset: 0x0029D344
			// (set) Token: 0x06009E7D RID: 40573 RVA: 0x00055867 File Offset: 0x00053A67
			public ValueTuple<string, UnlockedIzakayaInfo> tuple
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr_tuple);
					return new ValueTuple<string, UnlockedIzakayaInfo>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValueTuple<string, UnlockedIzakayaInfo>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr_tuple), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValueTuple<string, UnlockedIzakayaInfo>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700345D RID: 13405
			// (get) Token: 0x06009E7E RID: 40574 RVA: 0x0029F174 File Offset: 0x0029D374
			// (set) Token: 0x06009E7F RID: 40575 RVA: 0x00055895 File Offset: 0x00053A95
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC5_RogueLikeSpotSelectionPanel._OnSelectMap_d__10.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040066D8 RID: 26328
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040066D9 RID: 26329
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040066DA RID: 26330
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040066DB RID: 26331
			private static readonly IntPtr NativeFieldInfoPtr_tuple;

			// Token: 0x040066DC RID: 26332
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040066DD RID: 26333
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040066DE RID: 26334
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
