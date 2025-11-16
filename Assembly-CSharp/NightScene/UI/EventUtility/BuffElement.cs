using System;
using DEYU.AdpUISystem.LogicalCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace NightScene.UI.EventUtility
{
	// Token: 0x020001D0 RID: 464
	public class BuffElement : MonoBehaviour
	{
		// Token: 0x06003A1A RID: 14874 RVA: 0x001649CC File Offset: 0x00162BCC
		// Note: this type is marked as 'beforefieldinit'.
		static BuffElement()
		{
			Il2CppClassPointerStore<BuffElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.EventUtility", "BuffElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffElement>.NativeClassPtr);
			BuffElement.NativeFieldInfoPtr_elementTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "elementTransform");
			BuffElement.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "count");
			BuffElement.NativeFieldInfoPtr_altCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "altCount");
			BuffElement.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "visual");
			BuffElement.NativeFieldInfoPtr_visualOutline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "visualOutline");
			BuffElement.NativeFieldInfoPtr_progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "progress");
			BuffElement.NativeFieldInfoPtr_previewPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "previewPoint");
			BuffElement.NativeFieldInfoPtr_interactableBase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "interactableBase");
			BuffElement.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "title");
			BuffElement.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "description");
			BuffElement.NativeFieldInfoPtr_onUpdateDescriptionCallack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, "onUpdateDescriptionCallack");
			BuffElement.NativeMethodInfoPtr_set_Count_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674116);
			BuffElement.NativeMethodInfoPtr_set_Visual_Private_set_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674117);
			BuffElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674118);
			BuffElement.NativeMethodInfoPtr_InitializeVisual_Public_Void_Sprite_String_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674119);
			BuffElement.NativeMethodInfoPtr_UpdateBuff_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674120);
			BuffElement.NativeMethodInfoPtr_UpdateBuff_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674121);
			BuffElement.NativeMethodInfoPtr_GetBuffInformation_Public_Void_Action_1_String_byref_Sprite_byref_String_byref_String_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674122);
			BuffElement.NativeMethodInfoPtr_ToggleHighlight_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674123);
			BuffElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674124);
			BuffElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674125);
			BuffElement.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffElement>.NativeClassPtr, 100674126);
		}

		// Token: 0x17001411 RID: 5137
		// (set) Token: 0x06003A1B RID: 14875 RVA: 0x00164BB4 File Offset: 0x00162DB4
		public unsafe string Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132351, XrefRangeEnd = 132352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr_set_Count_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001412 RID: 5138
		// (set) Token: 0x06003A1C RID: 14876 RVA: 0x00164BF8 File Offset: 0x00162DF8
		public unsafe Sprite Visual
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132352, XrefRangeEnd = 132356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr_set_Visual_Private_set_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003A1D RID: 14877 RVA: 0x00164C3C File Offset: 0x00162E3C
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x00164C70 File Offset: 0x00162E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132356, XrefRangeEnd = 132366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeVisual(Sprite visual, string title, Action onPointerFocusToBuffCallback, Action onPointExitBuffCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(title);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPointerFocusToBuffCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onPointExitBuffCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr_InitializeVisual_Public_Void_Sprite_String_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x00164CEC File Offset: 0x00162EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132366, XrefRangeEnd = 132368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBuff(string context, float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr_UpdateBuff_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x00164D3C File Offset: 0x00162F3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132368, XrefRangeEnd = 132370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateBuff(string context, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(context);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr_UpdateBuff_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00164D8C File Offset: 0x00162F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132370, XrefRangeEnd = 132382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetBuffInformation(Action<string> onUpdateDescriptionCallack, out Sprite visual, out string title, out string currentDescription, out Action onCancelSubscriptionCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(onUpdateDescriptionCallack);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr4 = 0;
			ptr5 = &intPtr4;
			IntPtr intPtr6;
			IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr_GetBuffInformation_Public_Void_Action_1_String_byref_Sprite_byref_String_byref_String_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
			Il2CppException.RaiseExceptionIfNecessary(intPtr6);
			IntPtr intPtr7 = intPtr;
			visual = ((intPtr7 == 0) ? null : new Sprite(intPtr7));
			title = IL2CPP.Il2CppStringToManaged(intPtr2);
			currentDescription = IL2CPP.Il2CppStringToManaged(intPtr3);
			IntPtr intPtr8 = intPtr4;
			onCancelSubscriptionCallback = ((intPtr8 == 0) ? null : new Action(intPtr8));
		}

		// Token: 0x06003A22 RID: 14882 RVA: 0x00164E4C File Offset: 0x0016304C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132382, XrefRangeEnd = 132384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleHighlight(bool doHighlight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref doHighlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr_ToggleHighlight_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x00164E8C File Offset: 0x0016308C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132384, XrefRangeEnd = 132395, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuffElement.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x00164EC8 File Offset: 0x001630C8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuffElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x00164F04 File Offset: 0x00163104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132395, XrefRangeEnd = 132396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffElement.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x000208B0 File Offset: 0x0001EAB0
		public BuffElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x06003A27 RID: 14887 RVA: 0x00164F38 File Offset: 0x00163138
		// (set) Token: 0x06003A28 RID: 14888 RVA: 0x000208B9 File Offset: 0x0001EAB9
		public unsafe RectTransform elementTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_elementTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_elementTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x00164F68 File Offset: 0x00163168
		// (set) Token: 0x06003A2A RID: 14890 RVA: 0x000208D8 File Offset: 0x0001EAD8
		public unsafe TextMeshProUGUI count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_count);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_count), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x00164F98 File Offset: 0x00163198
		// (set) Token: 0x06003A2C RID: 14892 RVA: 0x000208F7 File Offset: 0x0001EAF7
		public unsafe TextMeshProUGUI altCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_altCount);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_altCount), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x00164FC8 File Offset: 0x001631C8
		// (set) Token: 0x06003A2E RID: 14894 RVA: 0x00020916 File Offset: 0x0001EB16
		public unsafe Image visual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_visual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x00164FF8 File Offset: 0x001631F8
		// (set) Token: 0x06003A30 RID: 14896 RVA: 0x00020935 File Offset: 0x0001EB35
		public unsafe Image visualOutline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_visualOutline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_visualOutline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06003A31 RID: 14897 RVA: 0x00165028 File Offset: 0x00163228
		// (set) Token: 0x06003A32 RID: 14898 RVA: 0x00020954 File Offset: 0x0001EB54
		public unsafe Image progress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_progress);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_progress), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06003A33 RID: 14899 RVA: 0x00165058 File Offset: 0x00163258
		// (set) Token: 0x06003A34 RID: 14900 RVA: 0x00020973 File Offset: 0x0001EB73
		public unsafe Transform previewPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_previewPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_previewPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x00165088 File Offset: 0x00163288
		// (set) Token: 0x06003A36 RID: 14902 RVA: 0x00020992 File Offset: 0x0001EB92
		public unsafe UIButtonSimple interactableBase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_interactableBase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIButtonSimple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_interactableBase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06003A37 RID: 14903 RVA: 0x001650B8 File Offset: 0x001632B8
		// (set) Token: 0x06003A38 RID: 14904 RVA: 0x000209B1 File Offset: 0x0001EBB1
		public unsafe string title
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_title);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06003A39 RID: 14905 RVA: 0x001650E0 File Offset: 0x001632E0
		// (set) Token: 0x06003A3A RID: 14906 RVA: 0x000209D0 File Offset: 0x0001EBD0
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06003A3B RID: 14907 RVA: 0x00165108 File Offset: 0x00163308
		// (set) Token: 0x06003A3C RID: 14908 RVA: 0x000209EF File Offset: 0x0001EBEF
		public unsafe Action<string> onUpdateDescriptionCallack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_onUpdateDescriptionCallack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffElement.NativeFieldInfoPtr_onUpdateDescriptionCallack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002713 RID: 10003
		private static readonly IntPtr NativeFieldInfoPtr_elementTransform;

		// Token: 0x04002714 RID: 10004
		private static readonly IntPtr NativeFieldInfoPtr_count;

		// Token: 0x04002715 RID: 10005
		private static readonly IntPtr NativeFieldInfoPtr_altCount;

		// Token: 0x04002716 RID: 10006
		private static readonly IntPtr NativeFieldInfoPtr_visual;

		// Token: 0x04002717 RID: 10007
		private static readonly IntPtr NativeFieldInfoPtr_visualOutline;

		// Token: 0x04002718 RID: 10008
		private static readonly IntPtr NativeFieldInfoPtr_progress;

		// Token: 0x04002719 RID: 10009
		private static readonly IntPtr NativeFieldInfoPtr_previewPoint;

		// Token: 0x0400271A RID: 10010
		private static readonly IntPtr NativeFieldInfoPtr_interactableBase;

		// Token: 0x0400271B RID: 10011
		private static readonly IntPtr NativeFieldInfoPtr_title;

		// Token: 0x0400271C RID: 10012
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x0400271D RID: 10013
		private static readonly IntPtr NativeFieldInfoPtr_onUpdateDescriptionCallack;

		// Token: 0x0400271E RID: 10014
		private static readonly IntPtr NativeMethodInfoPtr_set_Count_Private_set_Void_String_0;

		// Token: 0x0400271F RID: 10015
		private static readonly IntPtr NativeMethodInfoPtr_set_Visual_Private_set_Void_Sprite_0;

		// Token: 0x04002720 RID: 10016
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04002721 RID: 10017
		private static readonly IntPtr NativeMethodInfoPtr_InitializeVisual_Public_Void_Sprite_String_Action_Action_0;

		// Token: 0x04002722 RID: 10018
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBuff_Public_Void_String_Single_0;

		// Token: 0x04002723 RID: 10019
		private static readonly IntPtr NativeMethodInfoPtr_UpdateBuff_Public_Void_String_Int32_0;

		// Token: 0x04002724 RID: 10020
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffInformation_Public_Void_Action_1_String_byref_Sprite_byref_String_byref_String_byref_Action_0;

		// Token: 0x04002725 RID: 10021
		private static readonly IntPtr NativeMethodInfoPtr_ToggleHighlight_Public_Void_Boolean_0;

		// Token: 0x04002726 RID: 10022
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002727 RID: 10023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002728 RID: 10024
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
