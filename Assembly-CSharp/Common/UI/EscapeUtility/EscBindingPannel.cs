using System;
using DEYU.AdpUISystem.ComponentCollection;
using DEYU.AdpUISystem.LogicalCollection;
using DEYU.AdpUISystem.PanelCollection;
using DEYU.AdpUISystem.Utils;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Common.UI.EscapeUtility
{
	// Token: 0x020003BC RID: 956
	public class EscBindingPannel : UISubPanel<EscMainPannel>
	{
		// Token: 0x060071BF RID: 29119 RVA: 0x00219B50 File Offset: 0x00217D50
		// Note: this type is marked as 'beforefieldinit'.
		static EscBindingPannel()
		{
			Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.EscapeUtility", "EscBindingPannel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr);
			EscBindingPannel.NativeFieldInfoPtr_inputBindingDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "inputBindingDatas");
			EscBindingPannel.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "groups");
			EscBindingPannel.NativeFieldInfoPtr_bindingSettingParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "bindingSettingParent");
			EscBindingPannel.NativeFieldInfoPtr_bindingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "bindingField");
			EscBindingPannel.NativeFieldInfoPtr_Scroller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "Scroller");
			EscBindingPannel.NativeFieldInfoPtr_PlayStationStyledInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "PlayStationStyledInput");
			EscBindingPannel.NativeFieldInfoPtr_XBoxStyeldInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "XBoxStyeldInput");
			EscBindingPannel.NativeFieldInfoPtr_ResetBindingBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "ResetBindingBtn");
			EscBindingPannel.NativeFieldInfoPtr_PlayStationIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "PlayStationIndicator");
			EscBindingPannel.NativeFieldInfoPtr_XboxIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "XboxIndicator");
			EscBindingPannel.NativeFieldInfoPtr_AllGameObjectInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "AllGameObjectInstances");
			EscBindingPannel.NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "instances");
			EscBindingPannel.NativeFieldInfoPtr_m_AllChildrenInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "m_AllChildrenInstances");
			EscBindingPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, 100686729);
			EscBindingPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, 100686730);
			EscBindingPannel.NativeMethodInfoPtr_GetCommonPhraseCallback_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, 100686731);
			EscBindingPannel.NativeMethodInfoPtr_DrawBindingElements_Public_Static_Void_GameObject_RectTransform_Il2CppReferenceArray_1_InputBindingData_List_1_GameObject_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_Il2CppReferenceArray_1_StringArray_Action_1_RectTransform_UILogicalGroupT_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, 100686732);
			EscBindingPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, 100686733);
			EscBindingPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, 100686734);
			EscBindingPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, 100686735);
			EscBindingPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, 100686736);
			EscBindingPannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, 100686737);
		}

		// Token: 0x1700270A RID: 9994
		// (get) Token: 0x060071C0 RID: 29120 RVA: 0x00219D38 File Offset: 0x00217F38
		public unsafe override bool MutePanelCloseAudio
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscBindingPannel.NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060071C1 RID: 29121 RVA: 0x00219D80 File Offset: 0x00217F80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284402, XrefRangeEnd = 284545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscBindingPannel.NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071C2 RID: 29122 RVA: 0x00219DBC File Offset: 0x00217FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCommonPhraseCallback(string x)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.NativeMethodInfoPtr_GetCommonPhraseCallback_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060071C3 RID: 29123 RVA: 0x00219DF8 File Offset: 0x00217FF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 284606, RefRangeEnd = 284608, XrefRangeStart = 284545, XrefRangeEnd = 284606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DrawBindingElements(GameObject bindingSettingParent, RectTransform bindingField, Il2CppReferenceArray<EscBindingPannel.InputBindingData> inputBindingDatas, List<GameObject> allGameObjectInstances, Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances, Il2CppReferenceArray<EscBindingPannel.StringArray> groups, Action<RectTransform> onScrollCallback, UILogicalGroupT<string> allChildrenInstancesLogicalGroup)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bindingSettingParent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingField);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputBindingDatas);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allGameObjectInstances);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instances);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(groups);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onScrollCallback);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allChildrenInstancesLogicalGroup);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.NativeMethodInfoPtr_DrawBindingElements_Public_Static_Void_GameObject_RectTransform_Il2CppReferenceArray_1_InputBindingData_List_1_GameObject_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_Il2CppReferenceArray_1_StringArray_Action_1_RectTransform_UILogicalGroupT_1_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071C4 RID: 29124 RVA: 0x00219EB0 File Offset: 0x002180B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284608, XrefRangeEnd = 284632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelOpen()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscBindingPannel.NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071C5 RID: 29125 RVA: 0x00219EEC File Offset: 0x002180EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284632, XrefRangeEnd = 284637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPanelClose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscBindingPannel.NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071C6 RID: 29126 RVA: 0x00219F28 File Offset: 0x00218128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284637, XrefRangeEnd = 284639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetDuration()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscBindingPannel.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060071C7 RID: 29127 RVA: 0x00219F70 File Offset: 0x00218170
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284639, XrefRangeEnd = 284656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EscBindingPannel.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071C8 RID: 29128 RVA: 0x00219FAC File Offset: 0x002181AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284656, XrefRangeEnd = 284681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EscBindingPannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060071C9 RID: 29129 RVA: 0x0003D9CC File Offset: 0x0003BBCC
		public EscBindingPannel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x060071CA RID: 29130 RVA: 0x00219FE8 File Offset: 0x002181E8
		// (set) Token: 0x060071CB RID: 29131 RVA: 0x0003D9D5 File Offset: 0x0003BBD5
		public unsafe Il2CppReferenceArray<EscBindingPannel.InputBindingData> inputBindingDatas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_inputBindingDatas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.InputBindingData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_inputBindingDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026FE RID: 9982
		// (get) Token: 0x060071CC RID: 29132 RVA: 0x0021A018 File Offset: 0x00218218
		// (set) Token: 0x060071CD RID: 29133 RVA: 0x0003D9F4 File Offset: 0x0003BBF4
		public unsafe Il2CppReferenceArray<EscBindingPannel.StringArray> groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.StringArray>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026FF RID: 9983
		// (get) Token: 0x060071CE RID: 29134 RVA: 0x0021A048 File Offset: 0x00218248
		// (set) Token: 0x060071CF RID: 29135 RVA: 0x0003DA13 File Offset: 0x0003BC13
		public unsafe GameObject bindingSettingParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_bindingSettingParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_bindingSettingParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002700 RID: 9984
		// (get) Token: 0x060071D0 RID: 29136 RVA: 0x0021A078 File Offset: 0x00218278
		// (set) Token: 0x060071D1 RID: 29137 RVA: 0x0003DA32 File Offset: 0x0003BC32
		public unsafe RectTransform bindingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_bindingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_bindingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002701 RID: 9985
		// (get) Token: 0x060071D2 RID: 29138 RVA: 0x0021A0A8 File Offset: 0x002182A8
		// (set) Token: 0x060071D3 RID: 29139 RVA: 0x0003DA51 File Offset: 0x0003BC51
		public unsafe AdpScrollListAdaptiveComponent Scroller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_Scroller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpScrollListAdaptiveComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_Scroller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002702 RID: 9986
		// (get) Token: 0x060071D4 RID: 29140 RVA: 0x0021A0D8 File Offset: 0x002182D8
		// (set) Token: 0x060071D5 RID: 29141 RVA: 0x0003DA70 File Offset: 0x0003BC70
		public unsafe UIButtonSimple PlayStationStyledInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_PlayStationStyledInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_PlayStationStyledInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002703 RID: 9987
		// (get) Token: 0x060071D6 RID: 29142 RVA: 0x0021A108 File Offset: 0x00218308
		// (set) Token: 0x060071D7 RID: 29143 RVA: 0x0003DA8F File Offset: 0x0003BC8F
		public unsafe UIButtonSimple XBoxStyeldInput
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_XBoxStyeldInput);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_XBoxStyeldInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x060071D8 RID: 29144 RVA: 0x0021A138 File Offset: 0x00218338
		// (set) Token: 0x060071D9 RID: 29145 RVA: 0x0003DAAE File Offset: 0x0003BCAE
		public unsafe UIButtonHold ResetBindingBtn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_ResetBindingBtn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonHold>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_ResetBindingBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x060071DA RID: 29146 RVA: 0x0021A168 File Offset: 0x00218368
		// (set) Token: 0x060071DB RID: 29147 RVA: 0x0003DACD File Offset: 0x0003BCCD
		public unsafe Image PlayStationIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_PlayStationIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_PlayStationIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x060071DC RID: 29148 RVA: 0x0021A198 File Offset: 0x00218398
		// (set) Token: 0x060071DD RID: 29149 RVA: 0x0003DAEC File Offset: 0x0003BCEC
		public unsafe Image XboxIndicator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_XboxIndicator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_XboxIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x060071DE RID: 29150 RVA: 0x0021A1C8 File Offset: 0x002183C8
		// (set) Token: 0x060071DF RID: 29151 RVA: 0x0003DB0B File Offset: 0x0003BD0B
		public unsafe List<GameObject> AllGameObjectInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_AllGameObjectInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_AllGameObjectInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x060071E0 RID: 29152 RVA: 0x0021A1F8 File Offset: 0x002183F8
		// (set) Token: 0x060071E1 RID: 29153 RVA: 0x0003DB2A File Offset: 0x0003BD2A
		public unsafe Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_instances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_instances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002709 RID: 9993
		// (get) Token: 0x060071E2 RID: 29154 RVA: 0x0021A228 File Offset: 0x00218428
		// (set) Token: 0x060071E3 RID: 29155 RVA: 0x0003DB49 File Offset: 0x0003BD49
		public unsafe UILogicalGroupT<string> m_AllChildrenInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_m_AllChildrenInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.NativeFieldInfoPtr_m_AllChildrenInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B58 RID: 19288
		private static readonly IntPtr NativeFieldInfoPtr_inputBindingDatas;

		// Token: 0x04004B59 RID: 19289
		private static readonly IntPtr NativeFieldInfoPtr_groups;

		// Token: 0x04004B5A RID: 19290
		private static readonly IntPtr NativeFieldInfoPtr_bindingSettingParent;

		// Token: 0x04004B5B RID: 19291
		private static readonly IntPtr NativeFieldInfoPtr_bindingField;

		// Token: 0x04004B5C RID: 19292
		private static readonly IntPtr NativeFieldInfoPtr_Scroller;

		// Token: 0x04004B5D RID: 19293
		private static readonly IntPtr NativeFieldInfoPtr_PlayStationStyledInput;

		// Token: 0x04004B5E RID: 19294
		private static readonly IntPtr NativeFieldInfoPtr_XBoxStyeldInput;

		// Token: 0x04004B5F RID: 19295
		private static readonly IntPtr NativeFieldInfoPtr_ResetBindingBtn;

		// Token: 0x04004B60 RID: 19296
		private static readonly IntPtr NativeFieldInfoPtr_PlayStationIndicator;

		// Token: 0x04004B61 RID: 19297
		private static readonly IntPtr NativeFieldInfoPtr_XboxIndicator;

		// Token: 0x04004B62 RID: 19298
		private static readonly IntPtr NativeFieldInfoPtr_AllGameObjectInstances;

		// Token: 0x04004B63 RID: 19299
		private static readonly IntPtr NativeFieldInfoPtr_instances;

		// Token: 0x04004B64 RID: 19300
		private static readonly IntPtr NativeFieldInfoPtr_m_AllChildrenInstances;

		// Token: 0x04004B65 RID: 19301
		private static readonly IntPtr NativeMethodInfoPtr_get_MutePanelCloseAudio_Public_Virtual_get_Boolean_0;

		// Token: 0x04004B66 RID: 19302
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelInitialize_Protected_Virtual_Void_0;

		// Token: 0x04004B67 RID: 19303
		private static readonly IntPtr NativeMethodInfoPtr_GetCommonPhraseCallback_Private_Static_String_String_0;

		// Token: 0x04004B68 RID: 19304
		private static readonly IntPtr NativeMethodInfoPtr_DrawBindingElements_Public_Static_Void_GameObject_RectTransform_Il2CppReferenceArray_1_InputBindingData_List_1_GameObject_Dictionary_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_Il2CppReferenceArray_1_StringArray_Action_1_RectTransform_UILogicalGroupT_1_String_0;

		// Token: 0x04004B69 RID: 19305
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelOpen_Protected_Virtual_Void_0;

		// Token: 0x04004B6A RID: 19306
		private static readonly IntPtr NativeMethodInfoPtr_OnPanelClose_Protected_Virtual_Void_0;

		// Token: 0x04004B6B RID: 19307
		private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;

		// Token: 0x04004B6C RID: 19308
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04004B6D RID: 19309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F2F RID: 3887
		[Serializable]
		public sealed class InputBindingData : ValueType
		{
			// Token: 0x06010F5B RID: 69467 RVA: 0x003EBC60 File Offset: 0x003E9E60
			// Note: this type is marked as 'beforefieldinit'.
			static InputBindingData()
			{
				Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "InputBindingData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr);
				EscBindingPannel.InputBindingData.NativeFieldInfoPtr_focusingInputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, "focusingInputAction");
				EscBindingPannel.InputBindingData.NativeFieldInfoPtr_titleKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, "titleKey");
			}

			// Token: 0x06010F5C RID: 69468 RVA: 0x00093645 File Offset: 0x00091845
			public InputBindingData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06010F5D RID: 69469 RVA: 0x0009364E File Offset: 0x0009184E
			public InputBindingData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr))
			{
			}

			// Token: 0x1700583C RID: 22588
			// (get) Token: 0x06010F5E RID: 69470 RVA: 0x003EBCB4 File Offset: 0x003E9EB4
			// (set) Token: 0x06010F5F RID: 69471 RVA: 0x00093660 File Offset: 0x00091860
			public unsafe Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair> focusingInputAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.InputBindingData.NativeFieldInfoPtr_focusingInputAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.InputBindingData.NativeFieldInfoPtr_focusingInputAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700583D RID: 22589
			// (get) Token: 0x06010F60 RID: 69472 RVA: 0x003EBCE4 File Offset: 0x003E9EE4
			// (set) Token: 0x06010F61 RID: 69473 RVA: 0x0009367F File Offset: 0x0009187F
			public unsafe string titleKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.InputBindingData.NativeFieldInfoPtr_titleKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.InputBindingData.NativeFieldInfoPtr_titleKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400AB99 RID: 43929
			private static readonly IntPtr NativeFieldInfoPtr_focusingInputAction;

			// Token: 0x0400AB9A RID: 43930
			private static readonly IntPtr NativeFieldInfoPtr_titleKey;

			// Token: 0x020010D5 RID: 4309
			[Serializable]
			public class InputActionReferencePair : Il2CppSystem.Object
			{
				// Token: 0x060123F3 RID: 74739 RVA: 0x00428B90 File Offset: 0x00426D90
				// Note: this type is marked as 'beforefieldinit'.
				static InputActionReferencePair()
				{
					Il2CppClassPointerStore<EscBindingPannel.InputBindingData.InputActionReferencePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, "InputActionReferencePair");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingPannel.InputBindingData.InputActionReferencePair>.NativeClassPtr);
					EscBindingPannel.InputBindingData.InputActionReferencePair.NativeFieldInfoPtr_focusingInputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.InputBindingData.InputActionReferencePair>.NativeClassPtr, "focusingInputAction");
					EscBindingPannel.InputBindingData.InputActionReferencePair.NativeFieldInfoPtr_overrideBindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.InputBindingData.InputActionReferencePair>.NativeClassPtr, "overrideBindingIndex");
					EscBindingPannel.InputBindingData.InputActionReferencePair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.InputBindingData.InputActionReferencePair>.NativeClassPtr, 100686738);
				}

				// Token: 0x060123F4 RID: 74740 RVA: 0x00428BF8 File Offset: 0x00426DF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283870, XrefRangeEnd = 283871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe InputActionReferencePair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingPannel.InputBindingData.InputActionReferencePair>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.InputBindingData.InputActionReferencePair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060123F5 RID: 74741 RVA: 0x0009E38D File Offset: 0x0009C58D
				public InputActionReferencePair(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005F6F RID: 24431
				// (get) Token: 0x060123F6 RID: 74742 RVA: 0x00428C34 File Offset: 0x00426E34
				// (set) Token: 0x060123F7 RID: 74743 RVA: 0x0009E396 File Offset: 0x0009C596
				public unsafe InputActionReference focusingInputAction
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.InputBindingData.InputActionReferencePair.NativeFieldInfoPtr_focusingInputAction);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.InputBindingData.InputActionReferencePair.NativeFieldInfoPtr_focusingInputAction), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005F70 RID: 24432
				// (get) Token: 0x060123F8 RID: 74744 RVA: 0x00428C64 File Offset: 0x00426E64
				// (set) Token: 0x060123F9 RID: 74745 RVA: 0x0009E3B5 File Offset: 0x0009C5B5
				public unsafe int overrideBindingIndex
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.InputBindingData.InputActionReferencePair.NativeFieldInfoPtr_overrideBindingIndex);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.InputBindingData.InputActionReferencePair.NativeFieldInfoPtr_overrideBindingIndex)) = value;
					}
				}

				// Token: 0x0400B8FC RID: 47356
				private static readonly IntPtr NativeFieldInfoPtr_focusingInputAction;

				// Token: 0x0400B8FD RID: 47357
				private static readonly IntPtr NativeFieldInfoPtr_overrideBindingIndex;

				// Token: 0x0400B8FE RID: 47358
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
			}
		}

		// Token: 0x02000F30 RID: 3888
		[Serializable]
		public class StringArray : Il2CppSystem.Object
		{
			// Token: 0x06010F62 RID: 69474 RVA: 0x003EBD0C File Offset: 0x003E9F0C
			// Note: this type is marked as 'beforefieldinit'.
			static StringArray()
			{
				Il2CppClassPointerStore<EscBindingPannel.StringArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "StringArray");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingPannel.StringArray>.NativeClassPtr);
				EscBindingPannel.StringArray.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.StringArray>.NativeClassPtr, "array");
				EscBindingPannel.StringArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.StringArray>.NativeClassPtr, 100686739);
				EscBindingPannel.StringArray.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.StringArray>.NativeClassPtr, 100686740);
				EscBindingPannel.StringArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.StringArray>.NativeClassPtr, 100686741);
			}

			// Token: 0x06010F63 RID: 69475 RVA: 0x003EBD88 File Offset: 0x003E9F88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283871, XrefRangeEnd = 283875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator<string> GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.StringArray.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
			}

			// Token: 0x06010F64 RID: 69476 RVA: 0x003EBDC8 File Offset: 0x003E9FC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283875, XrefRangeEnd = 283886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.StringArray.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x06010F65 RID: 69477 RVA: 0x003EBE08 File Offset: 0x003EA008
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringArray() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingPannel.StringArray>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.StringArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F66 RID: 69478 RVA: 0x0009369E File Offset: 0x0009189E
			public StringArray(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700583E RID: 22590
			// (get) Token: 0x06010F67 RID: 69479 RVA: 0x003EBE44 File Offset: 0x003EA044
			// (set) Token: 0x06010F68 RID: 69480 RVA: 0x000936A7 File Offset: 0x000918A7
			public unsafe Il2CppStringArray array
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.StringArray.NativeFieldInfoPtr_array);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.StringArray.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB9B RID: 43931
			private static readonly IntPtr NativeFieldInfoPtr_array;

			// Token: 0x0400AB9C RID: 43932
			private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0;

			// Token: 0x0400AB9D RID: 43933
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

			// Token: 0x0400AB9E RID: 43934
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000F31 RID: 3889
		[ObfuscatedName("Common.UI.EscapeUtility.EscBindingPannel+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x06010F69 RID: 69481 RVA: 0x003EBE74 File Offset: 0x003EA074
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr);
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_isPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "isPS");
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_uiSubmit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "uiSubmit");
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "<>4__this");
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_playerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "playerInput");
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_playerInputWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "playerInputWrapper");
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_uiCancel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "uiCancel");
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_dayInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "dayInteract");
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_daySprint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "daySprint");
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_nightInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "nightInteract");
				EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_nightThrowDeliver = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, "nightThrowDeliver");
				EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, 100686742);
				EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, 100686743);
				EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, 100686744);
				EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, 100686745);
				EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, 100686746);
				EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, 100686747);
				EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, 100686748);
				EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr, 100686749);
			}

			// Token: 0x06010F6A RID: 69482 RVA: 0x003EC008 File Offset: 0x003EA208
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F6B RID: 69483 RVA: 0x003EC044 File Offset: 0x003EA244
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 283896, RefRangeEnd = 283900, XrefRangeStart = 283886, XrefRangeEnd = 283896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F6C RID: 69484 RVA: 0x003EC078 File Offset: 0x003EA278
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283900, XrefRangeEnd = 283910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F6D RID: 69485 RVA: 0x003EC0AC File Offset: 0x003EA2AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283910, XrefRangeEnd = 283931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F6E RID: 69486 RVA: 0x003EC0E0 File Offset: 0x003EA2E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 283931, XrefRangeEnd = 284007, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F6F RID: 69487 RVA: 0x003EC114 File Offset: 0x003EA314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284007, XrefRangeEnd = 284083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F70 RID: 69488 RVA: 0x003EC148 File Offset: 0x003EA348
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284083, XrefRangeEnd = 284104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F71 RID: 69489 RVA: 0x003EC17C File Offset: 0x003EA37C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284104, XrefRangeEnd = 284125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass15_0.NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F72 RID: 69490 RVA: 0x000936C6 File Offset: 0x000918C6
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700583F RID: 22591
			// (get) Token: 0x06010F73 RID: 69491 RVA: 0x003EC1B0 File Offset: 0x003EA3B0
			// (set) Token: 0x06010F74 RID: 69492 RVA: 0x000936CF File Offset: 0x000918CF
			public unsafe bool isPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_isPS);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_isPS)) = value;
				}
			}

			// Token: 0x17005840 RID: 22592
			// (get) Token: 0x06010F75 RID: 69493 RVA: 0x003EC1D8 File Offset: 0x003EA3D8
			// (set) Token: 0x06010F76 RID: 69494 RVA: 0x000936EA File Offset: 0x000918EA
			public unsafe InputAction uiSubmit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_uiSubmit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_uiSubmit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005841 RID: 22593
			// (get) Token: 0x06010F77 RID: 69495 RVA: 0x003EC208 File Offset: 0x003EA408
			// (set) Token: 0x06010F78 RID: 69496 RVA: 0x00093709 File Offset: 0x00091909
			public unsafe EscBindingPannel __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscBindingPannel>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005842 RID: 22594
			// (get) Token: 0x06010F79 RID: 69497 RVA: 0x003EC238 File Offset: 0x003EA438
			// (set) Token: 0x06010F7A RID: 69498 RVA: 0x00093728 File Offset: 0x00091928
			public unsafe PlayerInput playerInput
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_playerInput);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_playerInput), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005843 RID: 22595
			// (get) Token: 0x06010F7B RID: 69499 RVA: 0x003EC268 File Offset: 0x003EA468
			// (set) Token: 0x06010F7C RID: 69500 RVA: 0x00093747 File Offset: 0x00091947
			public unsafe AdpPlayerInputWrapper playerInputWrapper
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_playerInputWrapper);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpPlayerInputWrapper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_playerInputWrapper), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005844 RID: 22596
			// (get) Token: 0x06010F7D RID: 69501 RVA: 0x003EC298 File Offset: 0x003EA498
			// (set) Token: 0x06010F7E RID: 69502 RVA: 0x00093766 File Offset: 0x00091966
			public unsafe InputAction uiCancel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_uiCancel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_uiCancel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005845 RID: 22597
			// (get) Token: 0x06010F7F RID: 69503 RVA: 0x003EC2C8 File Offset: 0x003EA4C8
			// (set) Token: 0x06010F80 RID: 69504 RVA: 0x00093785 File Offset: 0x00091985
			public unsafe InputAction dayInteract
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_dayInteract);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_dayInteract), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005846 RID: 22598
			// (get) Token: 0x06010F81 RID: 69505 RVA: 0x003EC2F8 File Offset: 0x003EA4F8
			// (set) Token: 0x06010F82 RID: 69506 RVA: 0x000937A4 File Offset: 0x000919A4
			public unsafe InputAction daySprint
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_daySprint);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_daySprint), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005847 RID: 22599
			// (get) Token: 0x06010F83 RID: 69507 RVA: 0x003EC328 File Offset: 0x003EA528
			// (set) Token: 0x06010F84 RID: 69508 RVA: 0x000937C3 File Offset: 0x000919C3
			public unsafe InputAction nightInteract
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_nightInteract);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_nightInteract), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005848 RID: 22600
			// (get) Token: 0x06010F85 RID: 69509 RVA: 0x003EC358 File Offset: 0x003EA558
			// (set) Token: 0x06010F86 RID: 69510 RVA: 0x000937E2 File Offset: 0x000919E2
			public unsafe InputAction nightThrowDeliver
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_nightThrowDeliver);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass15_0.NativeFieldInfoPtr_nightThrowDeliver), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AB9F RID: 43935
			private static readonly IntPtr NativeFieldInfoPtr_isPS;

			// Token: 0x0400ABA0 RID: 43936
			private static readonly IntPtr NativeFieldInfoPtr_uiSubmit;

			// Token: 0x0400ABA1 RID: 43937
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400ABA2 RID: 43938
			private static readonly IntPtr NativeFieldInfoPtr_playerInput;

			// Token: 0x0400ABA3 RID: 43939
			private static readonly IntPtr NativeFieldInfoPtr_playerInputWrapper;

			// Token: 0x0400ABA4 RID: 43940
			private static readonly IntPtr NativeFieldInfoPtr_uiCancel;

			// Token: 0x0400ABA5 RID: 43941
			private static readonly IntPtr NativeFieldInfoPtr_dayInteract;

			// Token: 0x0400ABA6 RID: 43942
			private static readonly IntPtr NativeFieldInfoPtr_daySprint;

			// Token: 0x0400ABA7 RID: 43943
			private static readonly IntPtr NativeFieldInfoPtr_nightInteract;

			// Token: 0x0400ABA8 RID: 43944
			private static readonly IntPtr NativeFieldInfoPtr_nightThrowDeliver;

			// Token: 0x0400ABA9 RID: 43945
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ABAA RID: 43946
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x0400ABAB RID: 43947
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__1_Internal_Void_1;

			// Token: 0x0400ABAC RID: 43948
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__2_Internal_Void_1;

			// Token: 0x0400ABAD RID: 43949
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__3_Internal_Void_1;

			// Token: 0x0400ABAE RID: 43950
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__4_Internal_Void_1;

			// Token: 0x0400ABAF RID: 43951
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__5_Internal_Void_1;

			// Token: 0x0400ABB0 RID: 43952
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__6_Internal_Void_1;
		}

		// Token: 0x02000F32 RID: 3890
		[ObfuscatedName("Common.UI.EscapeUtility.EscBindingPannel+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06010F87 RID: 69511 RVA: 0x003EC388 File Offset: 0x003EA588
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr);
				EscBindingPannel.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__15_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__15_9");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__15_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__15_8");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__15_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__15_11");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__15_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__15_10");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__15_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__15_13");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__15_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__15_12");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__15_14 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__15_14");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__15_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__15_7");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__17_0");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__17_1");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__17_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__17_10");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__17_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__17_7");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__17_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__17_9");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__17_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__17_11");
				EscBindingPannel.__c.NativeFieldInfoPtr___9__18_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, "<>9__18_0");
				EscBindingPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686751);
				EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_8_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686752);
				EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686753);
				EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_10_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686754);
				EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686755);
				EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_12_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686756);
				EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_13_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686757);
				EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_7_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686758);
				EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_14_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686759);
				EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_0_Internal_String_InputBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686760);
				EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_1_Internal_Il2CppReferenceArray_1_InputActionReferencePair_InputBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686761);
				EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_7_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686762);
				EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686763);
				EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_9_Internal_IEnumerable_1_String_StringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686764);
				EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686765);
				EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__18_0_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr, 100686766);
			}

			// Token: 0x06010F88 RID: 69512 RVA: 0x003EC634 File Offset: 0x003EA834
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingPannel.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F89 RID: 69513 RVA: 0x003EC670 File Offset: 0x003EA870
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284125, XrefRangeEnd = 284144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15_8(KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_8_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F8A RID: 69514 RVA: 0x003EC6B8 File Offset: 0x003EA8B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15_9(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F8B RID: 69515 RVA: 0x003EC6FC File Offset: 0x003EA8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284144, XrefRangeEnd = 284163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15_10(KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_10_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F8C RID: 69516 RVA: 0x003EC744 File Offset: 0x003EA944
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15_11(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F8D RID: 69517 RVA: 0x003EC788 File Offset: 0x003EA988
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284163, XrefRangeEnd = 284182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15_12(KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_12_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F8E RID: 69518 RVA: 0x003EC7D0 File Offset: 0x003EA9D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15_13(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_13_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F8F RID: 69519 RVA: 0x003EC814 File Offset: 0x003EAA14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284182, XrefRangeEnd = 284201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15_7(KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_7_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F90 RID: 69520 RVA: 0x003EC85C File Offset: 0x003EAA5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelInitialize_b__15_14(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelInitialize_b__15_14_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F91 RID: 69521 RVA: 0x003EC8A0 File Offset: 0x003EAAA0
			[CallerCount(0)]
			public unsafe string _DrawBindingElements_b__17_0(EscBindingPannel.InputBindingData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_0_Internal_String_InputBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010F92 RID: 69522 RVA: 0x003EC8F0 File Offset: 0x003EAAF0
			[CallerCount(0)]
			public unsafe Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair> _DrawBindingElements_b__17_1(EscBindingPannel.InputBindingData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_1_Internal_Il2CppReferenceArray_1_InputActionReferencePair_InputBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>>(intPtr3) : null;
			}

			// Token: 0x06010F93 RID: 69523 RVA: 0x003EC948 File Offset: 0x003EAB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284201, XrefRangeEnd = 284220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DrawBindingElements_b__17_7(KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_7_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F94 RID: 69524 RVA: 0x003EC990 File Offset: 0x003EAB90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DrawBindingElements_b__17_10(Image y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F95 RID: 69525 RVA: 0x003EC9D4 File Offset: 0x003EABD4
			[CallerCount(0)]
			public unsafe IEnumerable<string> _DrawBindingElements_b__17_9(EscBindingPannel.StringArray x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_9_Internal_IEnumerable_1_String_StringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}

			// Token: 0x06010F96 RID: 69526 RVA: 0x003ECA24 File Offset: 0x003EAC24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DrawBindingElements_b__17_11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__DrawBindingElements_b__17_11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F97 RID: 69527 RVA: 0x003ECA68 File Offset: 0x003EAC68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284220, XrefRangeEnd = 284226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPanelOpen_b__18_0(KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c.NativeMethodInfoPtr__OnPanelOpen_b__18_0_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010F98 RID: 69528 RVA: 0x00093801 File Offset: 0x00091A01
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005849 RID: 22601
			// (get) Token: 0x06010F99 RID: 69529 RVA: 0x003ECAB0 File Offset: 0x003EACB0
			// (set) Token: 0x06010F9A RID: 69530 RVA: 0x0009380A File Offset: 0x00091A0A
			public unsafe static EscBindingPannel.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscBindingPannel.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700584A RID: 22602
			// (get) Token: 0x06010F9B RID: 69531 RVA: 0x003ECAD8 File Offset: 0x003EACD8
			// (set) Token: 0x06010F9C RID: 69532 RVA: 0x0009381C File Offset: 0x00091A1C
			public unsafe static Action<Image> __9__15_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700584B RID: 22603
			// (get) Token: 0x06010F9D RID: 69533 RVA: 0x003ECB00 File Offset: 0x003EAD00
			// (set) Token: 0x06010F9E RID: 69534 RVA: 0x0009382E File Offset: 0x00091A2E
			public unsafe static Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>> __9__15_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700584C RID: 22604
			// (get) Token: 0x06010F9F RID: 69535 RVA: 0x003ECB28 File Offset: 0x003EAD28
			// (set) Token: 0x06010FA0 RID: 69536 RVA: 0x00093840 File Offset: 0x00091A40
			public unsafe static Action<Image> __9__15_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700584D RID: 22605
			// (get) Token: 0x06010FA1 RID: 69537 RVA: 0x003ECB50 File Offset: 0x003EAD50
			// (set) Token: 0x06010FA2 RID: 69538 RVA: 0x00093852 File Offset: 0x00091A52
			public unsafe static Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>> __9__15_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700584E RID: 22606
			// (get) Token: 0x06010FA3 RID: 69539 RVA: 0x003ECB78 File Offset: 0x003EAD78
			// (set) Token: 0x06010FA4 RID: 69540 RVA: 0x00093864 File Offset: 0x00091A64
			public unsafe static Action<Image> __9__15_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700584F RID: 22607
			// (get) Token: 0x06010FA5 RID: 69541 RVA: 0x003ECBA0 File Offset: 0x003EADA0
			// (set) Token: 0x06010FA6 RID: 69542 RVA: 0x00093876 File Offset: 0x00091A76
			public unsafe static Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>> __9__15_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005850 RID: 22608
			// (get) Token: 0x06010FA7 RID: 69543 RVA: 0x003ECBC8 File Offset: 0x003EADC8
			// (set) Token: 0x06010FA8 RID: 69544 RVA: 0x00093888 File Offset: 0x00091A88
			public unsafe static Action<Image> __9__15_14
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_14, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_14, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005851 RID: 22609
			// (get) Token: 0x06010FA9 RID: 69545 RVA: 0x003ECBF0 File Offset: 0x003EADF0
			// (set) Token: 0x06010FAA RID: 69546 RVA: 0x0009389A File Offset: 0x00091A9A
			public unsafe static Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>> __9__15_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__15_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005852 RID: 22610
			// (get) Token: 0x06010FAB RID: 69547 RVA: 0x003ECC18 File Offset: 0x003EAE18
			// (set) Token: 0x06010FAC RID: 69548 RVA: 0x000938AC File Offset: 0x00091AAC
			public unsafe static Func<EscBindingPannel.InputBindingData, string> __9__17_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EscBindingPannel.InputBindingData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005853 RID: 22611
			// (get) Token: 0x06010FAD RID: 69549 RVA: 0x003ECC40 File Offset: 0x003EAE40
			// (set) Token: 0x06010FAE RID: 69550 RVA: 0x000938BE File Offset: 0x00091ABE
			public unsafe static Func<EscBindingPannel.InputBindingData, Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>> __9__17_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EscBindingPannel.InputBindingData, Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005854 RID: 22612
			// (get) Token: 0x06010FAF RID: 69551 RVA: 0x003ECC68 File Offset: 0x003EAE68
			// (set) Token: 0x06010FB0 RID: 69552 RVA: 0x000938D0 File Offset: 0x00091AD0
			public unsafe static Action<Image> __9__17_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005855 RID: 22613
			// (get) Token: 0x06010FB1 RID: 69553 RVA: 0x003ECC90 File Offset: 0x003EAE90
			// (set) Token: 0x06010FB2 RID: 69554 RVA: 0x000938E2 File Offset: 0x00091AE2
			public unsafe static Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>> __9__17_7
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_7, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_7, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005856 RID: 22614
			// (get) Token: 0x06010FB3 RID: 69555 RVA: 0x003ECCB8 File Offset: 0x003EAEB8
			// (set) Token: 0x06010FB4 RID: 69556 RVA: 0x000938F4 File Offset: 0x00091AF4
			public unsafe static Func<EscBindingPannel.StringArray, IEnumerable<string>> __9__17_9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EscBindingPannel.StringArray, IEnumerable<string>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005857 RID: 22615
			// (get) Token: 0x06010FB5 RID: 69557 RVA: 0x003ECCE0 File Offset: 0x003EAEE0
			// (set) Token: 0x06010FB6 RID: 69558 RVA: 0x00093906 File Offset: 0x00091B06
			public unsafe static Action<Image> __9__17_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__17_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005858 RID: 22616
			// (get) Token: 0x06010FB7 RID: 69559 RVA: 0x003ECD08 File Offset: 0x003EAF08
			// (set) Token: 0x06010FB8 RID: 69560 RVA: 0x00093918 File Offset: 0x00091B18
			public unsafe static Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>> __9__18_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__18_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<KeyValuePair<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(EscBindingPannel.__c.NativeFieldInfoPtr___9__18_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ABB1 RID: 43953
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400ABB2 RID: 43954
			private static readonly IntPtr NativeFieldInfoPtr___9__15_9;

			// Token: 0x0400ABB3 RID: 43955
			private static readonly IntPtr NativeFieldInfoPtr___9__15_8;

			// Token: 0x0400ABB4 RID: 43956
			private static readonly IntPtr NativeFieldInfoPtr___9__15_11;

			// Token: 0x0400ABB5 RID: 43957
			private static readonly IntPtr NativeFieldInfoPtr___9__15_10;

			// Token: 0x0400ABB6 RID: 43958
			private static readonly IntPtr NativeFieldInfoPtr___9__15_13;

			// Token: 0x0400ABB7 RID: 43959
			private static readonly IntPtr NativeFieldInfoPtr___9__15_12;

			// Token: 0x0400ABB8 RID: 43960
			private static readonly IntPtr NativeFieldInfoPtr___9__15_14;

			// Token: 0x0400ABB9 RID: 43961
			private static readonly IntPtr NativeFieldInfoPtr___9__15_7;

			// Token: 0x0400ABBA RID: 43962
			private static readonly IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x0400ABBB RID: 43963
			private static readonly IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x0400ABBC RID: 43964
			private static readonly IntPtr NativeFieldInfoPtr___9__17_10;

			// Token: 0x0400ABBD RID: 43965
			private static readonly IntPtr NativeFieldInfoPtr___9__17_7;

			// Token: 0x0400ABBE RID: 43966
			private static readonly IntPtr NativeFieldInfoPtr___9__17_9;

			// Token: 0x0400ABBF RID: 43967
			private static readonly IntPtr NativeFieldInfoPtr___9__17_11;

			// Token: 0x0400ABC0 RID: 43968
			private static readonly IntPtr NativeFieldInfoPtr___9__18_0;

			// Token: 0x0400ABC1 RID: 43969
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ABC2 RID: 43970
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_8_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0;

			// Token: 0x0400ABC3 RID: 43971
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_9_Internal_Void_Image_0;

			// Token: 0x0400ABC4 RID: 43972
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_10_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0;

			// Token: 0x0400ABC5 RID: 43973
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_11_Internal_Void_Image_0;

			// Token: 0x0400ABC6 RID: 43974
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_12_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0;

			// Token: 0x0400ABC7 RID: 43975
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_13_Internal_Void_Image_0;

			// Token: 0x0400ABC8 RID: 43976
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_7_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0;

			// Token: 0x0400ABC9 RID: 43977
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelInitialize_b__15_14_Internal_Void_Image_0;

			// Token: 0x0400ABCA RID: 43978
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__17_0_Internal_String_InputBindingData_0;

			// Token: 0x0400ABCB RID: 43979
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__17_1_Internal_Il2CppReferenceArray_1_InputActionReferencePair_InputBindingData_0;

			// Token: 0x0400ABCC RID: 43980
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__17_7_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0;

			// Token: 0x0400ABCD RID: 43981
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__17_10_Internal_Void_Image_0;

			// Token: 0x0400ABCE RID: 43982
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__17_9_Internal_IEnumerable_1_String_StringArray_0;

			// Token: 0x0400ABCF RID: 43983
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__17_11_Internal_Void_Image_0;

			// Token: 0x0400ABD0 RID: 43984
			private static readonly IntPtr NativeMethodInfoPtr__OnPanelOpen_b__18_0_Internal_Void_KeyValuePair_2_String_ValueTuple_3_UILogicalUnit_UIElementCluster_Func_1_String_0;
		}

		// Token: 0x02000F33 RID: 3891
		[ObfuscatedName("Common.UI.EscapeUtility.EscBindingPannel+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x06010FB9 RID: 69561 RVA: 0x003ECD30 File Offset: 0x003EAF30
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr);
				EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_playerInputWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, "playerInputWrapper");
				EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_bindingDataDicrionary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, "bindingDataDicrionary");
				EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, "groups");
				EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_instances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, "instances");
				EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_inputBindingDatas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, "inputBindingDatas");
				EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_onScrollCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, "onScrollCallback");
				EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_allChildrenInstancesLogicalGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, "allChildrenInstancesLogicalGroup");
				EscBindingPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, 100686767);
				EscBindingPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__DrawBindingElements_b__2_Internal_Void_UIElementCluster_InputBindingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, 100686768);
				EscBindingPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_InputBindingData_AdpPlayerInputWrapper_Dictionary_2_String_Il2CppReferenceArray_1_InputActionReferencePair_Func_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr, 100686769);
			}

			// Token: 0x06010FBA RID: 69562 RVA: 0x003ECE24 File Offset: 0x003EB024
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FBB RID: 69563 RVA: 0x003ECE60 File Offset: 0x003EB060
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284226, XrefRangeEnd = 284233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DrawBindingElements_b__2(UIElementCluster uiElements, EscBindingPannel.InputBindingData data)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElements);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass17_0.NativeMethodInfoPtr__DrawBindingElements_b__2_Internal_Void_UIElementCluster_InputBindingData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FBC RID: 69564 RVA: 0x003ECEBC File Offset: 0x003EB0BC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 284305, RefRangeEnd = 284306, XrefRangeStart = 284233, XrefRangeEnd = 284305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_UIElementCluster_InputBindingData_AdpPlayerInputWrapper_Dictionary_2_String_Il2CppReferenceArray_1_InputActionReferencePair_Func_2_String_String_0(UIElementCluster uiElements, EscBindingPannel.InputBindingData data, AdpPlayerInputWrapper playerInputWrapper, Dictionary<string, Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>> bindingDataDicrionary, Func<string, string> getCommonPhraseCallback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(uiElements);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(data));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(playerInputWrapper);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bindingDataDicrionary);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(getCommonPhraseCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_InputBindingData_AdpPlayerInputWrapper_Dictionary_2_String_Il2CppReferenceArray_1_InputActionReferencePair_Func_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FBD RID: 69565 RVA: 0x0009392A File Offset: 0x00091B2A
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005859 RID: 22617
			// (get) Token: 0x06010FBE RID: 69566 RVA: 0x003ECF50 File Offset: 0x003EB150
			// (set) Token: 0x06010FBF RID: 69567 RVA: 0x00093933 File Offset: 0x00091B33
			public unsafe AdpPlayerInputWrapper playerInputWrapper
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_playerInputWrapper);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AdpPlayerInputWrapper>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_playerInputWrapper), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700585A RID: 22618
			// (get) Token: 0x06010FC0 RID: 69568 RVA: 0x003ECF80 File Offset: 0x003EB180
			// (set) Token: 0x06010FC1 RID: 69569 RVA: 0x00093952 File Offset: 0x00091B52
			public unsafe Dictionary<string, Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>> bindingDataDicrionary
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_bindingDataDicrionary);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Il2CppReferenceArray<EscBindingPannel.InputBindingData.InputActionReferencePair>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_bindingDataDicrionary), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700585B RID: 22619
			// (get) Token: 0x06010FC2 RID: 69570 RVA: 0x003ECFB0 File Offset: 0x003EB1B0
			// (set) Token: 0x06010FC3 RID: 69571 RVA: 0x00093971 File Offset: 0x00091B71
			public unsafe Il2CppReferenceArray<EscBindingPannel.StringArray> groups
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_groups);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.StringArray>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_groups), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700585C RID: 22620
			// (get) Token: 0x06010FC4 RID: 69572 RVA: 0x003ECFE0 File Offset: 0x003EB1E0
			// (set) Token: 0x06010FC5 RID: 69573 RVA: 0x00093990 File Offset: 0x00091B90
			public unsafe Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>> instances
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_instances);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<UILogicalUnit, UIElementCluster, Func<string>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_instances), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700585D RID: 22621
			// (get) Token: 0x06010FC6 RID: 69574 RVA: 0x003ED010 File Offset: 0x003EB210
			// (set) Token: 0x06010FC7 RID: 69575 RVA: 0x000939AF File Offset: 0x00091BAF
			public unsafe Il2CppReferenceArray<EscBindingPannel.InputBindingData> inputBindingDatas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_inputBindingDatas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<EscBindingPannel.InputBindingData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_inputBindingDatas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700585E RID: 22622
			// (get) Token: 0x06010FC8 RID: 69576 RVA: 0x003ED040 File Offset: 0x003EB240
			// (set) Token: 0x06010FC9 RID: 69577 RVA: 0x000939CE File Offset: 0x00091BCE
			public unsafe Action<RectTransform> onScrollCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_onScrollCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RectTransform>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_onScrollCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700585F RID: 22623
			// (get) Token: 0x06010FCA RID: 69578 RVA: 0x003ED070 File Offset: 0x003EB270
			// (set) Token: 0x06010FCB RID: 69579 RVA: 0x000939ED File Offset: 0x00091BED
			public unsafe UILogicalGroupT<string> allChildrenInstancesLogicalGroup
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_allChildrenInstancesLogicalGroup);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UILogicalGroupT<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_0.NativeFieldInfoPtr_allChildrenInstancesLogicalGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ABD1 RID: 43985
			private static readonly IntPtr NativeFieldInfoPtr_playerInputWrapper;

			// Token: 0x0400ABD2 RID: 43986
			private static readonly IntPtr NativeFieldInfoPtr_bindingDataDicrionary;

			// Token: 0x0400ABD3 RID: 43987
			private static readonly IntPtr NativeFieldInfoPtr_groups;

			// Token: 0x0400ABD4 RID: 43988
			private static readonly IntPtr NativeFieldInfoPtr_instances;

			// Token: 0x0400ABD5 RID: 43989
			private static readonly IntPtr NativeFieldInfoPtr_inputBindingDatas;

			// Token: 0x0400ABD6 RID: 43990
			private static readonly IntPtr NativeFieldInfoPtr_onScrollCallback;

			// Token: 0x0400ABD7 RID: 43991
			private static readonly IntPtr NativeFieldInfoPtr_allChildrenInstancesLogicalGroup;

			// Token: 0x0400ABD8 RID: 43992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ABD9 RID: 43993
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__2_Internal_Void_UIElementCluster_InputBindingData_0;

			// Token: 0x0400ABDA RID: 43994
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_UIElementCluster_InputBindingData_AdpPlayerInputWrapper_Dictionary_2_String_Il2CppReferenceArray_1_InputActionReferencePair_Func_2_String_String_0;
		}

		// Token: 0x02000F34 RID: 3892
		[ObfuscatedName("Common.UI.EscapeUtility.EscBindingPannel+<>c__DisplayClass17_1")]
		public sealed class __c__DisplayClass17_1 : Il2CppSystem.Object
		{
			// Token: 0x06010FCC RID: 69580 RVA: 0x003ED0A0 File Offset: 0x003EB2A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<EscBindingPannel>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr);
				EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, "data");
				EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_thisData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, "thisData");
				EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_kbdBtn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, "kbdBtn");
				EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_firstAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, "firstAction");
				EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_finalFirstBindingIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, "finalFirstBindingIndex");
				EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, "CS$<>8__locals1");
				EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, "<>9__8");
				EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, 100686770);
				EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__DrawBindingElements_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, 100686771);
				EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__DrawBindingElements_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, 100686772);
				EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__DrawBindingElements_b__8_Internal_Boolean_StringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, 100686773);
				EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__DrawBindingElements_b__6_Internal_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr, 100686774);
			}

			// Token: 0x06010FCD RID: 69581 RVA: 0x003ED1BC File Offset: 0x003EB3BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EscBindingPannel.__c__DisplayClass17_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FCE RID: 69582 RVA: 0x003ED1F8 File Offset: 0x003EB3F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284306, XrefRangeEnd = 284310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DrawBindingElements_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__DrawBindingElements_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FCF RID: 69583 RVA: 0x003ED22C File Offset: 0x003EB42C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284310, XrefRangeEnd = 284393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _DrawBindingElements_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__DrawBindingElements_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06010FD0 RID: 69584 RVA: 0x003ED260 File Offset: 0x003EB460
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284393, XrefRangeEnd = 284396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _DrawBindingElements_b__8(EscBindingPannel.StringArray g)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(g);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__DrawBindingElements_b__8_Internal_Boolean_StringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06010FD1 RID: 69585 RVA: 0x003ED2B0 File Offset: 0x003EB4B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 284396, XrefRangeEnd = 284402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _DrawBindingElements_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EscBindingPannel.__c__DisplayClass17_1.NativeMethodInfoPtr__DrawBindingElements_b__6_Internal_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06010FD2 RID: 69586 RVA: 0x00093A0C File Offset: 0x00091C0C
			public __c__DisplayClass17_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005860 RID: 22624
			// (get) Token: 0x06010FD3 RID: 69587 RVA: 0x003ED2E8 File Offset: 0x003EB4E8
			// (set) Token: 0x06010FD4 RID: 69588 RVA: 0x00093A15 File Offset: 0x00091C15
			public EscBindingPannel.InputBindingData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_data);
					return new EscBindingPannel.InputBindingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_data), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005861 RID: 22625
			// (get) Token: 0x06010FD5 RID: 69589 RVA: 0x003ED318 File Offset: 0x003EB518
			// (set) Token: 0x06010FD6 RID: 69590 RVA: 0x00093A43 File Offset: 0x00091C43
			public EscBindingPannel.InputBindingData thisData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_thisData);
					return new EscBindingPannel.InputBindingData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_thisData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EscBindingPannel.InputBindingData>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005862 RID: 22626
			// (get) Token: 0x06010FD7 RID: 69591 RVA: 0x003ED348 File Offset: 0x003EB548
			// (set) Token: 0x06010FD8 RID: 69592 RVA: 0x00093A71 File Offset: 0x00091C71
			public unsafe UIButtonSimple kbdBtn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_kbdBtn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_kbdBtn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005863 RID: 22627
			// (get) Token: 0x06010FD9 RID: 69593 RVA: 0x003ED378 File Offset: 0x003EB578
			// (set) Token: 0x06010FDA RID: 69594 RVA: 0x00093A90 File Offset: 0x00091C90
			public unsafe InputActionReference firstAction
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_firstAction);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_firstAction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005864 RID: 22628
			// (get) Token: 0x06010FDB RID: 69595 RVA: 0x003ED3A8 File Offset: 0x003EB5A8
			// (set) Token: 0x06010FDC RID: 69596 RVA: 0x00093AAF File Offset: 0x00091CAF
			public unsafe int finalFirstBindingIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_finalFirstBindingIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_finalFirstBindingIndex)) = value;
				}
			}

			// Token: 0x17005865 RID: 22629
			// (get) Token: 0x06010FDD RID: 69597 RVA: 0x003ED3D0 File Offset: 0x003EB5D0
			// (set) Token: 0x06010FDE RID: 69598 RVA: 0x00093ACA File Offset: 0x00091CCA
			public unsafe EscBindingPannel.__c__DisplayClass17_0 field_Public___c__DisplayClass17_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<EscBindingPannel.__c__DisplayClass17_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005866 RID: 22630
			// (get) Token: 0x06010FDF RID: 69599 RVA: 0x003ED400 File Offset: 0x003EB600
			// (set) Token: 0x06010FE0 RID: 69600 RVA: 0x00093AE9 File Offset: 0x00091CE9
			public unsafe Func<EscBindingPannel.StringArray, bool> __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EscBindingPannel.StringArray, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EscBindingPannel.__c__DisplayClass17_1.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400ABDB RID: 43995
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x0400ABDC RID: 43996
			private static readonly IntPtr NativeFieldInfoPtr_thisData;

			// Token: 0x0400ABDD RID: 43997
			private static readonly IntPtr NativeFieldInfoPtr_kbdBtn;

			// Token: 0x0400ABDE RID: 43998
			private static readonly IntPtr NativeFieldInfoPtr_firstAction;

			// Token: 0x0400ABDF RID: 43999
			private static readonly IntPtr NativeFieldInfoPtr_finalFirstBindingIndex;

			// Token: 0x0400ABE0 RID: 44000
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass17_0_0;

			// Token: 0x0400ABE1 RID: 44001
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x0400ABE2 RID: 44002
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400ABE3 RID: 44003
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__4_Internal_Void_0;

			// Token: 0x0400ABE4 RID: 44004
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__5_Internal_Void_0;

			// Token: 0x0400ABE5 RID: 44005
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__8_Internal_Boolean_StringArray_0;

			// Token: 0x0400ABE6 RID: 44006
			private static readonly IntPtr NativeMethodInfoPtr__DrawBindingElements_b__6_Internal_String_0;
		}
	}
}
