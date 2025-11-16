using System;
using Common.UI.EscapeUtility;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine.InputSystem;

namespace Common.UI
{
	// Token: 0x0200037F RID: 895
	public class EscBindingSubPannel : UIPanel
	{
		// Token: 0x06006A3D RID: 27197 RVA: 0x0020100C File Offset: 0x001FF20C
		// Note: this type is marked as 'beforefieldinit'.
		static EscBindingSubPannel()
		{
			Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI", "EscBindingSubPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr);
			EscBindingSubPannel.NativeFieldInfoPtr_bindingIndicatorTitle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, "bindingIndicatorTitle");
			EscBindingSubPannel.NativeFieldInfoPtr__ActionGroupToRebind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, "<ActionGroupToRebind>k__BackingField");
			EscBindingSubPannel.NativeFieldInfoPtr__Groups_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, "<Groups>k__BackingField");
			EscBindingSubPannel.NativeFieldInfoPtr__Instances_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, "<Instances>k__BackingField");
			EscBindingSubPannel.NativeFieldInfoPtr__InputBindingDatas_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, "<InputBindingDatas>k__BackingField");
			EscBindingSubPannel.NativeMethodInfoPtr_get_ActionGroupToRebind_Private_get_InputBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685297);
			EscBindingSubPannel.NativeMethodInfoPtr_set_ActionGroupToRebind_Public_set_Void_InputBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685298);
			EscBindingSubPannel.NativeMethodInfoPtr_get_Groups_Private_get_Il2CppReferenceArray_1_StringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685299);
			EscBindingSubPannel.NativeMethodInfoPtr_set_Groups_Public_set_Void_Il2CppReferenceArray_1_StringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685300);
			EscBindingSubPannel.NativeMethodInfoPtr_get_Instances_Private_get_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685301);
			EscBindingSubPannel.NativeMethodInfoPtr_set_Instances_Public_set_Void_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685302);
			EscBindingSubPannel.NativeMethodInfoPtr_get_InputBindingDatas_Private_get_Il2CppReferenceArray_1_InputBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685303);
			EscBindingSubPannel.NativeMethodInfoPtr_set_InputBindingDatas_Public_set_Void_Il2CppReferenceArray_1_InputBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685304);
			EscBindingSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685305);
			EscBindingSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685306);
			EscBindingSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, 100685307);
		}

		// Token: 0x1700245F RID: 9311
		// (get) Token: 0x06006A3E RID: 27198 RVA: 0x0020117C File Offset: 0x001FF37C
		// (set) Token: 0x06006A3F RID: 27199 RVA: 0x002011B4 File Offset: 0x001FF3B4
		public unsafe EscBindingPannel.InputBindingData ActionGroupToRebind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.NativeMethodInfoPtr_get_ActionGroupToRebind_Private_get_InputBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new EscBindingPannel.InputBindingData(pointer);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270536, XrefRangeEnd = 270537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.NativeMethodInfoPtr_set_ActionGroupToRebind_Public_set_Void_InputBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x06006A40 RID: 27200 RVA: 0x002011FC File Offset: 0x001FF3FC
		// (set) Token: 0x06006A41 RID: 27201 RVA: 0x0020123C File Offset: 0x001FF43C
		public unsafe Il2CppReferenceArray<EscBindingPannel.StringArray> Groups
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.NativeMethodInfoPtr_get_Groups_Private_get_Il2CppReferenceArray_1_StringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.StringArray>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.NativeMethodInfoPtr_set_Groups_Public_set_Void_Il2CppReferenceArray_1_StringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x06006A42 RID: 27202 RVA: 0x00201280 File Offset: 0x001FF480
		// (set) Token: 0x06006A43 RID: 27203 RVA: 0x002012C0 File Offset: 0x001FF4C0
		public unsafe Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> Instances
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54846, RefRangeEnd = 54853, XrefRangeStart = 54846, XrefRangeEnd = 54853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.NativeMethodInfoPtr_get_Instances_Private_get_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.NativeMethodInfoPtr_set_Instances_Public_set_Void_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x06006A44 RID: 27204 RVA: 0x00201304 File Offset: 0x001FF504
		// (set) Token: 0x06006A45 RID: 27205 RVA: 0x00201344 File Offset: 0x001FF544
		public unsafe Il2CppReferenceArray<EscBindingPannel.InputBindingData> InputBindingDatas
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.NativeMethodInfoPtr_get_InputBindingDatas_Private_get_Il2CppReferenceArray_1_InputBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.InputBindingData>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.NativeMethodInfoPtr_set_InputBindingDatas_Public_set_Void_Il2CppReferenceArray_1_InputBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06006A46 RID: 27206 RVA: 0x00201388 File Offset: 0x001FF588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270537, XrefRangeEnd = 270694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscBindingSubPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A47 RID: 27207 RVA: 0x002013C4 File Offset: 0x001FF5C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270694, XrefRangeEnd = 270699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscBindingSubPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A48 RID: 27208 RVA: 0x00201400 File Offset: 0x001FF600
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 17727, RefRangeEnd = 17827, XrefRangeStart = 17727, XrefRangeEnd = 17827, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EscBindingSubPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A49 RID: 27209 RVA: 0x00039797 File Offset: 0x00037997
		public EscBindingSubPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700245A RID: 9306
		// (get) Token: 0x06006A4A RID: 27210 RVA: 0x0020143C File Offset: 0x001FF63C
		// (set) Token: 0x06006A4B RID: 27211 RVA: 0x000397A0 File Offset: 0x000379A0
		public unsafe TextMeshProUGUI bindingIndicatorTitle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr_bindingIndicatorTitle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr_bindingIndicatorTitle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700245B RID: 9307
		// (get) Token: 0x06006A4C RID: 27212 RVA: 0x0020146C File Offset: 0x001FF66C
		// (set) Token: 0x06006A4D RID: 27213 RVA: 0x000397BF File Offset: 0x000379BF
		public EscBindingPannel.InputBindingData _ActionGroupToRebind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr__ActionGroupToRebind_k__BackingField);
				return new EscBindingPannel.InputBindingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr__ActionGroupToRebind_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700245C RID: 9308
		// (get) Token: 0x06006A4E RID: 27214 RVA: 0x0020149C File Offset: 0x001FF69C
		// (set) Token: 0x06006A4F RID: 27215 RVA: 0x000397ED File Offset: 0x000379ED
		public unsafe Il2CppReferenceArray<EscBindingPannel.StringArray> _Groups_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr__Groups_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.StringArray>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr__Groups_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700245D RID: 9309
		// (get) Token: 0x06006A50 RID: 27216 RVA: 0x002014CC File Offset: 0x001FF6CC
		// (set) Token: 0x06006A51 RID: 27217 RVA: 0x0003980C File Offset: 0x00037A0C
		public unsafe Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> _Instances_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr__Instances_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr__Instances_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700245E RID: 9310
		// (get) Token: 0x06006A52 RID: 27218 RVA: 0x002014FC File Offset: 0x001FF6FC
		// (set) Token: 0x06006A53 RID: 27219 RVA: 0x0003982B File Offset: 0x00037A2B
		public unsafe Il2CppReferenceArray<EscBindingPannel.InputBindingData> _InputBindingDatas_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr__InputBindingDatas_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.InputBindingData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.NativeFieldInfoPtr__InputBindingDatas_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004671 RID: 18033
		private static readonly IntPtr NativeFieldInfoPtr_bindingIndicatorTitle;

		// Token: 0x04004672 RID: 18034
		private static readonly IntPtr NativeFieldInfoPtr__ActionGroupToRebind_k__BackingField;

		// Token: 0x04004673 RID: 18035
		private static readonly IntPtr NativeFieldInfoPtr__Groups_k__BackingField;

		// Token: 0x04004674 RID: 18036
		private static readonly IntPtr NativeFieldInfoPtr__Instances_k__BackingField;

		// Token: 0x04004675 RID: 18037
		private static readonly IntPtr NativeFieldInfoPtr__InputBindingDatas_k__BackingField;

		// Token: 0x04004676 RID: 18038
		private static readonly IntPtr NativeMethodInfoPtr_get_ActionGroupToRebind_Private_get_InputBindingData_0;

		// Token: 0x04004677 RID: 18039
		private static readonly IntPtr NativeMethodInfoPtr_set_ActionGroupToRebind_Public_set_Void_InputBindingData_0;

		// Token: 0x04004678 RID: 18040
		private static readonly IntPtr NativeMethodInfoPtr_get_Groups_Private_get_Il2CppReferenceArray_1_StringArray_0;

		// Token: 0x04004679 RID: 18041
		private static readonly IntPtr NativeMethodInfoPtr_set_Groups_Public_set_Void_Il2CppReferenceArray_1_StringArray_0;

		// Token: 0x0400467A RID: 18042
		private static readonly IntPtr NativeMethodInfoPtr_get_Instances_Private_get_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0;

		// Token: 0x0400467B RID: 18043
		private static readonly IntPtr NativeMethodInfoPtr_set_Instances_Public_set_Void_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0;

		// Token: 0x0400467C RID: 18044
		private static readonly IntPtr NativeMethodInfoPtr_get_InputBindingDatas_Private_get_Il2CppReferenceArray_1_InputBindingData_0;

		// Token: 0x0400467D RID: 18045
		private static readonly IntPtr NativeMethodInfoPtr_set_InputBindingDatas_Public_set_Void_Il2CppReferenceArray_1_InputBindingData_0;

		// Token: 0x0400467E RID: 18046
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x0400467F RID: 18047
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004680 RID: 18048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000E93 RID: 3731
		[ObfuscatedName("Common.UI.EscBindingSubPannel+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0601087E RID: 67710 RVA: 0x003D516C File Offset: 0x003D336C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr);
				EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_firstAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, "firstAction");
				EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_firstBinidingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, "firstBinidingIndex");
				EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, "titleKey");
				EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_bindingDataDicrionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, "bindingDataDicrionary");
				EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, "<>9__6");
				EscBindingSubPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, 100685308);
				EscBindingSubPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, 100685309);
				EscBindingSubPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, 100685310);
				EscBindingSubPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_StringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr, 100685311);
			}

			// Token: 0x0601087F RID: 67711 RVA: 0x003D5260 File Offset: 0x003D3460
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010880 RID: 67712 RVA: 0x003D529C File Offset: 0x003D349C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270347, XrefRangeEnd = 270358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__3(InputActionRebindingExtensions.RebindingOperation op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010881 RID: 67713 RVA: 0x003D52E0 File Offset: 0x003D34E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270358, XrefRangeEnd = 270462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__4(InputActionRebindingExtensions.RebindingOperation op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010882 RID: 67714 RVA: 0x003D5324 File Offset: 0x003D3524
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270462, XrefRangeEnd = 270465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPanelOpen_b__6(EscBindingPannel.StringArray g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_StringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010883 RID: 67715 RVA: 0x00090582 File Offset: 0x0008E782
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700564A RID: 22090
			// (get) Token: 0x06010884 RID: 67716 RVA: 0x003D5374 File Offset: 0x003D3574
			// (set) Token: 0x06010885 RID: 67717 RVA: 0x0009058B File Offset: 0x0008E78B
			public unsafe InputActionReference firstAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_firstAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_firstAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700564B RID: 22091
			// (get) Token: 0x06010886 RID: 67718 RVA: 0x003D53A4 File Offset: 0x003D35A4
			// (set) Token: 0x06010887 RID: 67719 RVA: 0x000905AA File Offset: 0x0008E7AA
			public unsafe EscBindingSubPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscBindingSubPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700564C RID: 22092
			// (get) Token: 0x06010888 RID: 67720 RVA: 0x003D53D4 File Offset: 0x003D35D4
			// (set) Token: 0x06010889 RID: 67721 RVA: 0x000905C9 File Offset: 0x0008E7C9
			public unsafe int firstBinidingIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_firstBinidingIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_firstBinidingIndex)) = value;
				}
			}

			// Token: 0x1700564D RID: 22093
			// (get) Token: 0x0601088A RID: 67722 RVA: 0x003D53FC File Offset: 0x003D35FC
			// (set) Token: 0x0601088B RID: 67723 RVA: 0x000905E4 File Offset: 0x0008E7E4
			public unsafe string titleKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_titleKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_titleKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700564E RID: 22094
			// (get) Token: 0x0601088C RID: 67724 RVA: 0x003D5424 File Offset: 0x003D3624
			// (set) Token: 0x0601088D RID: 67725 RVA: 0x00090603 File Offset: 0x0008E803
			public unsafe Dictionary<string, Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>> bindingDataDicrionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_bindingDataDicrionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_bindingDataDicrionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700564F RID: 22095
			// (get) Token: 0x0601088E RID: 67726 RVA: 0x003D5454 File Offset: 0x003D3654
			// (set) Token: 0x0601088F RID: 67727 RVA: 0x00090622 File Offset: 0x0008E822
			public unsafe Func<EscBindingPannel.StringArray, bool> __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EscBindingPannel.StringArray, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_0.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A752 RID: 42834
			private static readonly IntPtr NativeFieldInfoPtr_firstAction;

			// Token: 0x0400A753 RID: 42835
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400A754 RID: 42836
			private static readonly IntPtr NativeFieldInfoPtr_firstBinidingIndex;

			// Token: 0x0400A755 RID: 42837
			private static readonly IntPtr NativeFieldInfoPtr_titleKey;

			// Token: 0x0400A756 RID: 42838
			private static readonly IntPtr NativeFieldInfoPtr_bindingDataDicrionary;

			// Token: 0x0400A757 RID: 42839
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x0400A758 RID: 42840
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A759 RID: 42841
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__3_Internal_Void_RebindingOperation_0;

			// Token: 0x0400A75A RID: 42842
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__4_Internal_Void_RebindingOperation_0;

			// Token: 0x0400A75B RID: 42843
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__6_Internal_Boolean_StringArray_0;
		}

		// Token: 0x02000E94 RID: 3732
		[ObfuscatedName("Common.UI.EscBindingSubPannel+<>c__DisplayClass17_1")]
		public sealed class __c__DisplayClass17_1 : Object
		{
			// Token: 0x06010890 RID: 67728 RVA: 0x003D5484 File Offset: 0x003D3684
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_1>.NativeClassPtr);
				EscBindingSubPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_overridePath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_1>.NativeClassPtr, "overridePath");
				EscBindingSubPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_1>.NativeClassPtr, 100685312);
				EscBindingSubPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_InputActionReferencePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_1>.NativeClassPtr, 100685313);
			}

			// Token: 0x06010891 RID: 67729 RVA: 0x003D54EC File Offset: 0x003D36EC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingSubPannel.__c__DisplayClass17_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010892 RID: 67730 RVA: 0x003D5528 File Offset: 0x003D3728
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270465, XrefRangeEnd = 270511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__5(EscBindingPannel.InputBindingData.InputActionReferencePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_InputActionReferencePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010893 RID: 67731 RVA: 0x00090641 File Offset: 0x0008E841
			public __c__DisplayClass17_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005650 RID: 22096
			// (get) Token: 0x06010894 RID: 67732 RVA: 0x003D556C File Offset: 0x003D376C
			// (set) Token: 0x06010895 RID: 67733 RVA: 0x0009064A File Offset: 0x0008E84A
			public unsafe string overridePath
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_overridePath);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingSubPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_overridePath), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400A75C RID: 42844
			private static readonly IntPtr NativeFieldInfoPtr_overridePath;

			// Token: 0x0400A75D RID: 42845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A75E RID: 42846
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__5_Internal_Void_InputActionReferencePair_0;
		}

		// Token: 0x02000E95 RID: 3733
		[ObfuscatedName("Common.UI.EscBindingSubPannel+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06010896 RID: 67734 RVA: 0x003D5594 File Offset: 0x003D3794
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingSubPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr);
				EscBindingSubPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, "<>9");
				EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, "<>9__17_0");
				EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, "<>9__17_1");
				EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, "<>9__17_2");
				EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, "<>9__17_7");
				EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, "<>9__17_8");
				EscBindingSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, 100685315);
				EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_0_Internal_String_InputBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, 100685316);
				EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_1_Internal_Il2CppReferenceArray_1_InputActionReferencePair_InputBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, 100685317);
				EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_2_Internal_Void_RebindingOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, 100685318);
				EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_7_Internal_IEnumerable_1_String_StringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, 100685319);
				EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_8_Internal_Void_InputActionReferencePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr, 100685320);
			}

			// Token: 0x06010897 RID: 67735 RVA: 0x003D56B0 File Offset: 0x003D38B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingSubPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010898 RID: 67736 RVA: 0x003D56EC File Offset: 0x003D38EC
			[CallerCount(0)]
			public unsafe string _OnPanelOpen_b__17_0(EscBindingPannel.InputBindingData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_0_Internal_String_InputBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010899 RID: 67737 RVA: 0x003D573C File Offset: 0x003D393C
			[CallerCount(0)]
			public unsafe Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair> _OnPanelOpen_b__17_1(EscBindingPannel.InputBindingData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_1_Internal_Il2CppReferenceArray_1_InputActionReferencePair_InputBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>>(intPtr3) : null;
			}

			// Token: 0x0601089A RID: 67738 RVA: 0x003D5794 File Offset: 0x003D3994
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270511, XrefRangeEnd = 270530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__17_2(InputActionRebindingExtensions.RebindingOperation operation)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(operation);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_2_Internal_Void_RebindingOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601089B RID: 67739 RVA: 0x003D57D8 File Offset: 0x003D39D8
			[CallerCount(0)]
			public unsafe IEnumerable<string> _OnPanelOpen_b__17_7(EscBindingPannel.StringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_7_Internal_IEnumerable_1_String_StringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}

			// Token: 0x0601089C RID: 67740 RVA: 0x003D5828 File Offset: 0x003D3A28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 270530, XrefRangeEnd = 270536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__17_8(EscBindingPannel.InputBindingData.InputActionReferencePair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingSubPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__17_8_Internal_Void_InputActionReferencePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601089D RID: 67741 RVA: 0x00090669 File Offset: 0x0008E869
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005651 RID: 22097
			// (get) Token: 0x0601089E RID: 67742 RVA: 0x003D586C File Offset: 0x003D3A6C
			// (set) Token: 0x0601089F RID: 67743 RVA: 0x00090672 File Offset: 0x0008E872
			public unsafe static EscBindingSubPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscBindingSubPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005652 RID: 22098
			// (get) Token: 0x060108A0 RID: 67744 RVA: 0x003D5894 File Offset: 0x003D3A94
			// (set) Token: 0x060108A1 RID: 67745 RVA: 0x00090684 File Offset: 0x0008E884
			public unsafe static Func<EscBindingPannel.InputBindingData, string> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EscBindingPannel.InputBindingData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005653 RID: 22099
			// (get) Token: 0x060108A2 RID: 67746 RVA: 0x003D58BC File Offset: 0x003D3ABC
			// (set) Token: 0x060108A3 RID: 67747 RVA: 0x00090696 File Offset: 0x0008E896
			public unsafe static Func<EscBindingPannel.InputBindingData, Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EscBindingPannel.InputBindingData, Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005654 RID: 22100
			// (get) Token: 0x060108A4 RID: 67748 RVA: 0x003D58E4 File Offset: 0x003D3AE4
			// (set) Token: 0x060108A5 RID: 67749 RVA: 0x000906A8 File Offset: 0x0008E8A8
			public unsafe static Action<InputActionRebindingExtensions.RebindingOperation> __9__17_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<InputActionRebindingExtensions.RebindingOperation>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005655 RID: 22101
			// (get) Token: 0x060108A6 RID: 67750 RVA: 0x003D590C File Offset: 0x003D3B0C
			// (set) Token: 0x060108A7 RID: 67751 RVA: 0x000906BA File Offset: 0x0008E8BA
			public unsafe static Func<EscBindingPannel.StringArray, IEnumerable<string>> __9__17_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EscBindingPannel.StringArray, IEnumerable<string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005656 RID: 22102
			// (get) Token: 0x060108A8 RID: 67752 RVA: 0x003D5934 File Offset: 0x003D3B34
			// (set) Token: 0x060108A9 RID: 67753 RVA: 0x000906CC File Offset: 0x0008E8CC
			public unsafe static Action<EscBindingPannel.InputBindingData.InputActionReferencePair> __9__17_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<EscBindingPannel.InputBindingData.InputActionReferencePair>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingSubPannel.__c.NativeFieldInfoPtr___9__17_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400A75F RID: 42847
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400A760 RID: 42848
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400A761 RID: 42849
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x0400A762 RID: 42850
			private static readonly IntPtr NativeFieldInfoPtr___9__17_2;

			// Token: 0x0400A763 RID: 42851
			private static readonly IntPtr NativeFieldInfoPtr___9__17_7;

			// Token: 0x0400A764 RID: 42852
			private static readonly IntPtr NativeFieldInfoPtr___9__17_8;

			// Token: 0x0400A765 RID: 42853
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400A766 RID: 42854
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__17_0_Internal_String_InputBindingData_0;

			// Token: 0x0400A767 RID: 42855
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__17_1_Internal_Il2CppReferenceArray_1_InputActionReferencePair_InputBindingData_0;

			// Token: 0x0400A768 RID: 42856
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__17_2_Internal_Void_RebindingOperation_0;

			// Token: 0x0400A769 RID: 42857
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__17_7_Internal_IEnumerable_1_String_StringArray_0;

			// Token: 0x0400A76A RID: 42858
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__17_8_Internal_Void_InputActionReferencePair_0;
		}
	}
}
