using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x0200045C RID: 1116
	public class AbstractFlowLayoutGroup : LayoutGroup
	{
		// Token: 0x06007B51 RID: 31569 RVA: 0x002379D4 File Offset: 0x00235BD4
		// Note: this type is marked as 'beforefieldinit'.
		static AbstractFlowLayoutGroup()
		{
			Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.UI", "AbstractFlowLayoutGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr);
			AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_Spacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, "m_Spacing");
			AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_LineSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, "m_LineSpacing");
			AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, "m_ChildControlWidth");
			AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, "m_ChildControlHeight");
			AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, "m_ChildScaleWidth");
			AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, "m_ChildScaleHeight");
			AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, "m_ReverseArrangement");
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687966);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687967);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687968);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687969);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687970);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_Spacing_Public_Virtual_New_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687971);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687972);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687973);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687974);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687975);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687976);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687977);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687978);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687979);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687980);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687981);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687982);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_GetWidth_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687983);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_GetHeight_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687984);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687985);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687986);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687987);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_Method_Private_Single_Single_byref___c__DisplayClass36_0_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687988);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_Method_Private_List_1_List_1_RectTransform_byref___c__DisplayClass36_0_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687989);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_Method_Private_Single_Int32_byref___c__DisplayClass36_0_byref___c__DisplayClass36_1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687990);
			AbstractFlowLayoutGroup.NativeMethodInfoPtr_Method_Private_Single_Int32_byref___c__DisplayClass36_0_byref___c__DisplayClass36_1_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, 100687991);
		}

		// Token: 0x06007B52 RID: 31570 RVA: 0x00237C98 File Offset: 0x00235E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295813, XrefRangeEnd = 295819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractFlowLayoutGroup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x06007B53 RID: 31571 RVA: 0x00237CD4 File Offset: 0x00235ED4
		// (set) Token: 0x06007B54 RID: 31572 RVA: 0x00237D10 File Offset: 0x00235F10
		public unsafe float spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_spacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295819, XrefRangeEnd = 295822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x06007B55 RID: 31573 RVA: 0x00237D50 File Offset: 0x00235F50
		// (set) Token: 0x06007B56 RID: 31574 RVA: 0x00237D8C File Offset: 0x00235F8C
		public unsafe float lineSpacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295822, XrefRangeEnd = 295825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x06007B57 RID: 31575 RVA: 0x00237DCC File Offset: 0x00235FCC
		public unsafe virtual Vector2 Spacing
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_Spacing_Public_Virtual_New_get_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x06007B58 RID: 31576 RVA: 0x00237E14 File Offset: 0x00236014
		// (set) Token: 0x06007B59 RID: 31577 RVA: 0x00237E50 File Offset: 0x00236050
		public unsafe bool childControlWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295825, XrefRangeEnd = 295828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x06007B5A RID: 31578 RVA: 0x00237E90 File Offset: 0x00236090
		// (set) Token: 0x06007B5B RID: 31579 RVA: 0x00237ECC File Offset: 0x002360CC
		public unsafe bool childControlHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295828, XrefRangeEnd = 295831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x06007B5C RID: 31580 RVA: 0x00237F0C File Offset: 0x0023610C
		// (set) Token: 0x06007B5D RID: 31581 RVA: 0x00237F48 File Offset: 0x00236148
		public unsafe bool childScaleWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295831, XrefRangeEnd = 295834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x06007B5E RID: 31582 RVA: 0x00237F88 File Offset: 0x00236188
		// (set) Token: 0x06007B5F RID: 31583 RVA: 0x00237FC4 File Offset: 0x002361C4
		public unsafe bool childScaleHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295834, XrefRangeEnd = 295837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x06007B60 RID: 31584 RVA: 0x00238004 File Offset: 0x00236204
		// (set) Token: 0x06007B61 RID: 31585 RVA: 0x00238040 File Offset: 0x00236240
		public unsafe bool reverseArrangement
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295837, XrefRangeEnd = 295840, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007B62 RID: 31586 RVA: 0x00238080 File Offset: 0x00236280
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 295896, RefRangeEnd = 295904, XrefRangeStart = 295840, XrefRangeEnd = 295896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CalcAlongAxis(int axis, bool isVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref axis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x06007B63 RID: 31587 RVA: 0x002380CC File Offset: 0x002362CC
		public unsafe float GetWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295904, XrefRangeEnd = 295908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_GetWidth_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x06007B64 RID: 31588 RVA: 0x00238108 File Offset: 0x00236308
		public unsafe float GetHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295908, XrefRangeEnd = 295911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_get_GetHeight_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x00238144 File Offset: 0x00236344
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 296029, RefRangeEnd = 296037, XrefRangeStart = 295911, XrefRangeEnd = 296029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetChildrenAlongAxis(int axis, bool isVertical)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref axis;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isVertical;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x00238190 File Offset: 0x00236390
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296037, XrefRangeEnd = 296040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetChildSizes(RectTransform child, int axis, bool controlSize, bool childForceExpand, out float min, out float preferred, out float flexible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(child);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref axis;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlSize;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref childForceExpand;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &min;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &preferred;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &flexible;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x0023822C File Offset: 0x0023642C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296040, XrefRangeEnd = 296041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbstractFlowLayoutGroup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B68 RID: 31592 RVA: 0x00238268 File Offset: 0x00236468
		[CallerCount(0)]
		public unsafe float Method_Private_Single_Single_byref___c__DisplayClass36_0_PDM_0(float delta, ref AbstractFlowLayoutGroup.__c__DisplayClass36_0 A_2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref delta;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_Method_Private_Single_Single_byref___c__DisplayClass36_0_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x002382C4 File Offset: 0x002364C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296087, RefRangeEnd = 296088, XrefRangeStart = 296041, XrefRangeEnd = 296087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<List<RectTransform>> Method_Private_List_1_List_1_RectTransform_byref___c__DisplayClass36_0_0(ref AbstractFlowLayoutGroup.__c__DisplayClass36_0 A_1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_Method_Private_List_1_List_1_RectTransform_byref___c__DisplayClass36_0_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<List<RectTransform>>>(intPtr3) : null;
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x00238318 File Offset: 0x00236518
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296111, RefRangeEnd = 296113, XrefRangeStart = 296088, XrefRangeEnd = 296111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Method_Private_Single_Int32_byref___c__DisplayClass36_0_byref___c__DisplayClass36_1_0(int index, ref AbstractFlowLayoutGroup.__c__DisplayClass36_0 A_2, ref AbstractFlowLayoutGroup.__c__DisplayClass36_1 A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_Method_Private_Single_Int32_byref___c__DisplayClass36_0_byref___c__DisplayClass36_1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x00238388 File Offset: 0x00236588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296113, XrefRangeEnd = 296114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float Method_Private_Single_Int32_byref___c__DisplayClass36_0_byref___c__DisplayClass36_1_PDM_0(int index, ref AbstractFlowLayoutGroup.__c__DisplayClass36_0 A_2, ref AbstractFlowLayoutGroup.__c__DisplayClass36_1 A_3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref index;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_2);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(A_3);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbstractFlowLayoutGroup.NativeMethodInfoPtr_Method_Private_Single_Int32_byref___c__DisplayClass36_0_byref___c__DisplayClass36_1_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x00042817 File Offset: 0x00040A17
		public AbstractFlowLayoutGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x06007B6D RID: 31597 RVA: 0x002383F8 File Offset: 0x002365F8
		// (set) Token: 0x06007B6E RID: 31598 RVA: 0x00042820 File Offset: 0x00040A20
		public unsafe float m_Spacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_Spacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_Spacing)) = value;
			}
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x06007B6F RID: 31599 RVA: 0x00238420 File Offset: 0x00236620
		// (set) Token: 0x06007B70 RID: 31600 RVA: 0x0004283B File Offset: 0x00040A3B
		public unsafe float m_LineSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_LineSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_LineSpacing)) = value;
			}
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x06007B71 RID: 31601 RVA: 0x00238448 File Offset: 0x00236648
		// (set) Token: 0x06007B72 RID: 31602 RVA: 0x00042856 File Offset: 0x00040A56
		public unsafe bool m_ChildControlWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildControlWidth)) = value;
			}
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x06007B73 RID: 31603 RVA: 0x00238470 File Offset: 0x00236670
		// (set) Token: 0x06007B74 RID: 31604 RVA: 0x00042871 File Offset: 0x00040A71
		public unsafe bool m_ChildControlHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildControlHeight)) = value;
			}
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x06007B75 RID: 31605 RVA: 0x00238498 File Offset: 0x00236698
		// (set) Token: 0x06007B76 RID: 31606 RVA: 0x0004288C File Offset: 0x00040A8C
		public unsafe bool m_ChildScaleWidth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildScaleWidth)) = value;
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x06007B77 RID: 31607 RVA: 0x002384C0 File Offset: 0x002366C0
		// (set) Token: 0x06007B78 RID: 31608 RVA: 0x000428A7 File Offset: 0x00040AA7
		public unsafe bool m_ChildScaleHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ChildScaleHeight)) = value;
			}
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x06007B79 RID: 31609 RVA: 0x002384E8 File Offset: 0x002366E8
		// (set) Token: 0x06007B7A RID: 31610 RVA: 0x000428C2 File Offset: 0x00040AC2
		public unsafe bool m_ReverseArrangement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.NativeFieldInfoPtr_m_ReverseArrangement)) = value;
			}
		}

		// Token: 0x04005127 RID: 20775
		private static readonly IntPtr NativeFieldInfoPtr_m_Spacing;

		// Token: 0x04005128 RID: 20776
		private static readonly IntPtr NativeFieldInfoPtr_m_LineSpacing;

		// Token: 0x04005129 RID: 20777
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlWidth;

		// Token: 0x0400512A RID: 20778
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildControlHeight;

		// Token: 0x0400512B RID: 20779
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleWidth;

		// Token: 0x0400512C RID: 20780
		private static readonly IntPtr NativeFieldInfoPtr_m_ChildScaleHeight;

		// Token: 0x0400512D RID: 20781
		private static readonly IntPtr NativeFieldInfoPtr_m_ReverseArrangement;

		// Token: 0x0400512E RID: 20782
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400512F RID: 20783
		private static readonly IntPtr NativeMethodInfoPtr_get_spacing_Public_get_Single_0;

		// Token: 0x04005130 RID: 20784
		private static readonly IntPtr NativeMethodInfoPtr_set_spacing_Public_set_Void_Single_0;

		// Token: 0x04005131 RID: 20785
		private static readonly IntPtr NativeMethodInfoPtr_get_lineSpacing_Public_get_Single_0;

		// Token: 0x04005132 RID: 20786
		private static readonly IntPtr NativeMethodInfoPtr_set_lineSpacing_Public_set_Void_Single_0;

		// Token: 0x04005133 RID: 20787
		private static readonly IntPtr NativeMethodInfoPtr_get_Spacing_Public_Virtual_New_get_Vector2_0;

		// Token: 0x04005134 RID: 20788
		private static readonly IntPtr NativeMethodInfoPtr_get_childControlWidth_Public_get_Boolean_0;

		// Token: 0x04005135 RID: 20789
		private static readonly IntPtr NativeMethodInfoPtr_set_childControlWidth_Public_set_Void_Boolean_0;

		// Token: 0x04005136 RID: 20790
		private static readonly IntPtr NativeMethodInfoPtr_get_childControlHeight_Public_get_Boolean_0;

		// Token: 0x04005137 RID: 20791
		private static readonly IntPtr NativeMethodInfoPtr_set_childControlHeight_Public_set_Void_Boolean_0;

		// Token: 0x04005138 RID: 20792
		private static readonly IntPtr NativeMethodInfoPtr_get_childScaleWidth_Public_get_Boolean_0;

		// Token: 0x04005139 RID: 20793
		private static readonly IntPtr NativeMethodInfoPtr_set_childScaleWidth_Public_set_Void_Boolean_0;

		// Token: 0x0400513A RID: 20794
		private static readonly IntPtr NativeMethodInfoPtr_get_childScaleHeight_Public_get_Boolean_0;

		// Token: 0x0400513B RID: 20795
		private static readonly IntPtr NativeMethodInfoPtr_set_childScaleHeight_Public_set_Void_Boolean_0;

		// Token: 0x0400513C RID: 20796
		private static readonly IntPtr NativeMethodInfoPtr_get_reverseArrangement_Public_get_Boolean_0;

		// Token: 0x0400513D RID: 20797
		private static readonly IntPtr NativeMethodInfoPtr_set_reverseArrangement_Public_set_Void_Boolean_0;

		// Token: 0x0400513E RID: 20798
		private static readonly IntPtr NativeMethodInfoPtr_CalcAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x0400513F RID: 20799
		private static readonly IntPtr NativeMethodInfoPtr_get_GetWidth_Public_get_Single_0;

		// Token: 0x04005140 RID: 20800
		private static readonly IntPtr NativeMethodInfoPtr_get_GetHeight_Public_get_Single_0;

		// Token: 0x04005141 RID: 20801
		private static readonly IntPtr NativeMethodInfoPtr_SetChildrenAlongAxis_Protected_Void_Int32_Boolean_0;

		// Token: 0x04005142 RID: 20802
		private static readonly IntPtr NativeMethodInfoPtr_GetChildSizes_Private_Void_RectTransform_Int32_Boolean_Boolean_byref_Single_byref_Single_byref_Single_0;

		// Token: 0x04005143 RID: 20803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04005144 RID: 20804
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Single_Single_byref___c__DisplayClass36_0_PDM_0;

		// Token: 0x04005145 RID: 20805
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_List_1_List_1_RectTransform_byref___c__DisplayClass36_0_0;

		// Token: 0x04005146 RID: 20806
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Single_Int32_byref___c__DisplayClass36_0_byref___c__DisplayClass36_1_0;

		// Token: 0x04005147 RID: 20807
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Single_Int32_byref___c__DisplayClass36_0_byref___c__DisplayClass36_1_PDM_0;

		// Token: 0x02000F97 RID: 3991
		[ObfuscatedName("UnityEngine.UI.AbstractFlowLayoutGroup+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : ValueType
		{
			// Token: 0x06011425 RID: 70693 RVA: 0x003F9A38 File Offset: 0x003F7C38
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr);
				AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_axis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr, "axis");
				AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr, "<>4__this");
				AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_startIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr, "startIndex");
				AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_controlSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr, "controlSize");
				AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_useScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr, "useScale");
				AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_innerSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr, "innerSize");
				AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_increment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr, "increment");
				AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_endIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr, "endIndex");
			}

			// Token: 0x06011426 RID: 70694 RVA: 0x0009608A File Offset: 0x0009428A
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06011427 RID: 70695 RVA: 0x00096093 File Offset: 0x00094293
			public __c__DisplayClass36_0() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_0>.NativeClassPtr))
			{
			}

			// Token: 0x170059B5 RID: 22965
			// (get) Token: 0x06011428 RID: 70696 RVA: 0x003F9B04 File Offset: 0x003F7D04
			// (set) Token: 0x06011429 RID: 70697 RVA: 0x000960A5 File Offset: 0x000942A5
			public unsafe int axis
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_axis);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_axis)) = value;
				}
			}

			// Token: 0x170059B6 RID: 22966
			// (get) Token: 0x0601142A RID: 70698 RVA: 0x003F9B2C File Offset: 0x003F7D2C
			// (set) Token: 0x0601142B RID: 70699 RVA: 0x000960C0 File Offset: 0x000942C0
			public unsafe AbstractFlowLayoutGroup __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AbstractFlowLayoutGroup>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170059B7 RID: 22967
			// (get) Token: 0x0601142C RID: 70700 RVA: 0x003F9B5C File Offset: 0x003F7D5C
			// (set) Token: 0x0601142D RID: 70701 RVA: 0x000960DF File Offset: 0x000942DF
			public unsafe int startIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_startIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_startIndex)) = value;
				}
			}

			// Token: 0x170059B8 RID: 22968
			// (get) Token: 0x0601142E RID: 70702 RVA: 0x003F9B84 File Offset: 0x003F7D84
			// (set) Token: 0x0601142F RID: 70703 RVA: 0x000960FA File Offset: 0x000942FA
			public unsafe bool controlSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_controlSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_controlSize)) = value;
				}
			}

			// Token: 0x170059B9 RID: 22969
			// (get) Token: 0x06011430 RID: 70704 RVA: 0x003F9BAC File Offset: 0x003F7DAC
			// (set) Token: 0x06011431 RID: 70705 RVA: 0x00096115 File Offset: 0x00094315
			public unsafe bool useScale
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_useScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_useScale)) = value;
				}
			}

			// Token: 0x170059BA RID: 22970
			// (get) Token: 0x06011432 RID: 70706 RVA: 0x003F9BD4 File Offset: 0x003F7DD4
			// (set) Token: 0x06011433 RID: 70707 RVA: 0x00096130 File Offset: 0x00094330
			public unsafe float innerSize
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_innerSize);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_innerSize)) = value;
				}
			}

			// Token: 0x170059BB RID: 22971
			// (get) Token: 0x06011434 RID: 70708 RVA: 0x003F9BFC File Offset: 0x003F7DFC
			// (set) Token: 0x06011435 RID: 70709 RVA: 0x0009614B File Offset: 0x0009434B
			public unsafe int increment
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_increment);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_increment)) = value;
				}
			}

			// Token: 0x170059BC RID: 22972
			// (get) Token: 0x06011436 RID: 70710 RVA: 0x003F9C24 File Offset: 0x003F7E24
			// (set) Token: 0x06011437 RID: 70711 RVA: 0x00096166 File Offset: 0x00094366
			public unsafe int endIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_endIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_0.NativeFieldInfoPtr_endIndex)) = value;
				}
			}

			// Token: 0x0400AE8C RID: 44684
			private static readonly IntPtr NativeFieldInfoPtr_axis;

			// Token: 0x0400AE8D RID: 44685
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AE8E RID: 44686
			private static readonly IntPtr NativeFieldInfoPtr_startIndex;

			// Token: 0x0400AE8F RID: 44687
			private static readonly IntPtr NativeFieldInfoPtr_controlSize;

			// Token: 0x0400AE90 RID: 44688
			private static readonly IntPtr NativeFieldInfoPtr_useScale;

			// Token: 0x0400AE91 RID: 44689
			private static readonly IntPtr NativeFieldInfoPtr_innerSize;

			// Token: 0x0400AE92 RID: 44690
			private static readonly IntPtr NativeFieldInfoPtr_increment;

			// Token: 0x0400AE93 RID: 44691
			private static readonly IntPtr NativeFieldInfoPtr_endIndex;
		}

		// Token: 0x02000F98 RID: 3992
		[ObfuscatedName("UnityEngine.UI.AbstractFlowLayoutGroup+<>c__DisplayClass36_1")]
		public sealed class __c__DisplayClass36_1 : ValueType
		{
			// Token: 0x06011438 RID: 70712 RVA: 0x00096181 File Offset: 0x00094381
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_1()
			{
				Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbstractFlowLayoutGroup>.NativeClassPtr, "<>c__DisplayClass36_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_1>.NativeClassPtr);
				AbstractFlowLayoutGroup.__c__DisplayClass36_1.NativeFieldInfoPtr_rows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_1>.NativeClassPtr, "rows");
			}

			// Token: 0x06011439 RID: 70713 RVA: 0x000961B5 File Offset: 0x000943B5
			public __c__DisplayClass36_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0601143A RID: 70714 RVA: 0x000961BE File Offset: 0x000943BE
			public __c__DisplayClass36_1() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbstractFlowLayoutGroup.__c__DisplayClass36_1>.NativeClassPtr))
			{
			}

			// Token: 0x170059BD RID: 22973
			// (get) Token: 0x0601143B RID: 70715 RVA: 0x003F9C4C File Offset: 0x003F7E4C
			// (set) Token: 0x0601143C RID: 70716 RVA: 0x000961D0 File Offset: 0x000943D0
			public unsafe List<List<RectTransform>> rows
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_1.NativeFieldInfoPtr_rows);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<List<RectTransform>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbstractFlowLayoutGroup.__c__DisplayClass36_1.NativeFieldInfoPtr_rows), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE94 RID: 44692
			private static readonly IntPtr NativeFieldInfoPtr_rows;
		}
	}
}
