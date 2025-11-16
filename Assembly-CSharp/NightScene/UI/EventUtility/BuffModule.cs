using System;
using DEYU.UniversalUISystem;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace NightScene.UI.EventUtility
{
	// Token: 0x020001D1 RID: 465
	public class BuffModule : MonoBehaviour
	{
		// Token: 0x06003A3D RID: 14909 RVA: 0x00165138 File Offset: 0x00163338
		// Note: this type is marked as 'beforefieldinit'.
		static BuffModule()
		{
			Il2CppClassPointerStore<BuffModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.UI.EventUtility", "BuffModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModule>.NativeClassPtr);
			BuffModule.NativeFieldInfoPtr_BUFF_ELEMENT_RANDOM_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "BUFF_ELEMENT_RANDOM_RANGE");
			BuffModule.NativeFieldInfoPtr_buffElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "buffElement");
			BuffModule.NativeFieldInfoPtr_buffField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "buffField");
			BuffModule.NativeFieldInfoPtr_descriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "descriptor");
			BuffModule.NativeFieldInfoPtr_canvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "canvasGroup");
			BuffModule.NativeFieldInfoPtr_buffDescriberStayDuraion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "buffDescriberStayDuraion");
			BuffModule.NativeFieldInfoPtr_cachedBuffElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "cachedBuffElement");
			BuffModule.NativeFieldInfoPtr_m_FourCornerWorldBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "m_FourCornerWorldBuffer");
			BuffModule.NativeFieldInfoPtr_registeredBuffElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "registeredBuffElement");
			BuffModule.NativeFieldInfoPtr_currentFocusingBuffIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "currentFocusingBuffIndex");
			BuffModule.NativeFieldInfoPtr_onCancelLastSubscriptionCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "onCancelLastSubscriptionCallback");
			BuffModule.NativeFieldInfoPtr_isFoucusing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "isFoucusing");
			BuffModule.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674127);
			BuffModule.NativeMethodInfoPtr_TryGetBuffElement_Public_Boolean_Guid_byref_BuffElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674128);
			BuffModule.NativeMethodInfoPtr_RegisterBuff_Public_Void_Sprite_String_Guid_byref_Action_2_String_Single_byref_Action_2_String_Int32_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674129);
			BuffModule.NativeMethodInfoPtr_GetTargetElementTransform_Public_Void_Guid_byref_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674130);
			BuffModule.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674131);
			BuffModule.NativeMethodInfoPtr_UpdateCurrentFocusingDescriptor_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674132);
			BuffModule.NativeMethodInfoPtr_OnExecuteNavigateAction_Public_Void_CallbackContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674133);
			BuffModule.NativeMethodInfoPtr_CloseCurrentSelection_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674134);
			BuffModule.NativeMethodInfoPtr_UpdatePannelAlpha_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674135);
			BuffModule.NativeMethodInfoPtr_NotifyBuffDescriptor_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674136);
			BuffModule.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674137);
			BuffModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674138);
			BuffModule.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674139);
			BuffModule.NativeMethodInfoPtr_Method_Private_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674140);
			BuffModule.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674141);
			BuffModule.NativeMethodInfoPtr__NotifyBuffDescriptor_b__21_3_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, 100674142);
		}

		// Token: 0x06003A3E RID: 14910 RVA: 0x00165398 File Offset: 0x00163598
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A3F RID: 14911 RVA: 0x001653CC File Offset: 0x001635CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132488, XrefRangeEnd = 132509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetBuffElement(Guid buffId, out BuffElement buffElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref buffId;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_TryGetBuffElement_Public_Boolean_Guid_byref_BuffElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			buffElement = ((intPtr4 == 0) ? null : new BuffElement(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06003A40 RID: 14912 RVA: 0x00165438 File Offset: 0x00163638
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132589, RefRangeEnd = 132592, XrefRangeStart = 132509, XrefRangeEnd = 132589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterBuff(Sprite visual, string buffTitle, Guid guid, out Action<string, float> onBuffUpdate, out Action<string, int> onBuffCountUpdate, out Action onBuffEnd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visual);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(buffTitle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref guid;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			ref IntPtr ptr4 = ref ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr3 = 0;
			ptr4 = &intPtr3;
			IntPtr intPtr5;
			IntPtr intPtr4 = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_RegisterBuff_Public_Void_Sprite_String_Guid_byref_Action_2_String_Single_byref_Action_2_String_Int32_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr5);
			Il2CppException.RaiseExceptionIfNecessary(intPtr5);
			IntPtr intPtr6 = intPtr;
			onBuffUpdate = ((intPtr6 == 0) ? null : new Action<string, float>(intPtr6));
			IntPtr intPtr7 = intPtr2;
			onBuffCountUpdate = ((intPtr7 == 0) ? null : new Action<string, int>(intPtr7));
			IntPtr intPtr8 = intPtr3;
			onBuffEnd = ((intPtr8 == 0) ? null : new Action(intPtr8));
		}

		// Token: 0x06003A41 RID: 14913 RVA: 0x00165504 File Offset: 0x00163704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132629, RefRangeEnd = 132630, XrefRangeStart = 132592, XrefRangeEnd = 132629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetTargetElementTransform(Guid guid, out Transform targetTransform)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_GetTargetElementTransform_Public_Void_Guid_byref_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			targetTransform = ((intPtr4 == 0) ? null : new Transform(intPtr4));
		}

		// Token: 0x06003A42 RID: 14914 RVA: 0x00165564 File Offset: 0x00163764
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132632, RefRangeEnd = 132633, XrefRangeStart = 132630, XrefRangeEnd = 132632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A43 RID: 14915 RVA: 0x00165598 File Offset: 0x00163798
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 132717, RefRangeEnd = 132720, XrefRangeStart = 132633, XrefRangeEnd = 132717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCurrentFocusingDescriptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_UpdateCurrentFocusingDescriptor_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A44 RID: 14916 RVA: 0x001655CC File Offset: 0x001637CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132720, XrefRangeEnd = 132733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnExecuteNavigateAction(InputAction.CallbackContext callbackContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(callbackContext));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_OnExecuteNavigateAction_Public_Void_CallbackContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A45 RID: 14917 RVA: 0x00165614 File Offset: 0x00163814
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 132738, RefRangeEnd = 132740, XrefRangeStart = 132733, XrefRangeEnd = 132738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CloseCurrentSelection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_CloseCurrentSelection_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A46 RID: 14918 RVA: 0x00165648 File Offset: 0x00163848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132740, XrefRangeEnd = 132742, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePannelAlpha(float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref alpha;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_UpdatePannelAlpha_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x00165688 File Offset: 0x00163888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132742, XrefRangeEnd = 132750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NotifyBuffDescriptor()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_NotifyBuffDescriptor_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x001656BC File Offset: 0x001638BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132750, XrefRangeEnd = 132761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuffModule.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x001656F8 File Offset: 0x001638F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132761, XrefRangeEnd = 132781, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuffModule() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x00165734 File Offset: 0x00163934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132781, XrefRangeEnd = 132786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x00165774 File Offset: 0x00163974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132786, XrefRangeEnd = 132791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Method_Private_Boolean_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_Method_Private_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x001657B0 File Offset: 0x001639B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 132795, RefRangeEnd = 132796, XrefRangeStart = 132791, XrefRangeEnd = 132795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x001657E4 File Offset: 0x001639E4
		[CallerCount(0)]
		public unsafe bool _NotifyBuffDescriptor_b__21_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.NativeMethodInfoPtr__NotifyBuffDescriptor_b__21_3_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x00020A0E File Offset: 0x0001EC0E
		public BuffModule(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x00165820 File Offset: 0x00163A20
		// (set) Token: 0x06003A50 RID: 14928 RVA: 0x00020A17 File Offset: 0x0001EC17
		public unsafe static float BUFF_ELEMENT_RANDOM_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(BuffModule.NativeFieldInfoPtr_BUFF_ELEMENT_RANDOM_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BuffModule.NativeFieldInfoPtr_BUFF_ELEMENT_RANDOM_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x0016583C File Offset: 0x00163A3C
		// (set) Token: 0x06003A52 RID: 14930 RVA: 0x00020A25 File Offset: 0x0001EC25
		public unsafe GameObject buffElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_buffElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_buffElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x0016586C File Offset: 0x00163A6C
		// (set) Token: 0x06003A54 RID: 14932 RVA: 0x00020A44 File Offset: 0x0001EC44
		public unsafe RectTransform buffField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_buffField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_buffField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x06003A55 RID: 14933 RVA: 0x0016589C File Offset: 0x00163A9C
		// (set) Token: 0x06003A56 RID: 14934 RVA: 0x00020A63 File Offset: 0x0001EC63
		public unsafe UIElementCluster descriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_descriptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_descriptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x001658CC File Offset: 0x00163ACC
		// (set) Token: 0x06003A58 RID: 14936 RVA: 0x00020A82 File Offset: 0x0001EC82
		public unsafe CanvasGroup canvasGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_canvasGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_canvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x001658FC File Offset: 0x00163AFC
		// (set) Token: 0x06003A5A RID: 14938 RVA: 0x00020AA1 File Offset: 0x0001ECA1
		public unsafe float buffDescriberStayDuraion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_buffDescriberStayDuraion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_buffDescriberStayDuraion)) = value;
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x00165924 File Offset: 0x00163B24
		// (set) Token: 0x06003A5C RID: 14940 RVA: 0x00020ABC File Offset: 0x0001ECBC
		public unsafe Queue<BuffElement> cachedBuffElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_cachedBuffElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<BuffElement>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_cachedBuffElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x00165954 File Offset: 0x00163B54
		// (set) Token: 0x06003A5E RID: 14942 RVA: 0x00020ADB File Offset: 0x0001ECDB
		public unsafe Il2CppStructArray<Vector3> m_FourCornerWorldBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_m_FourCornerWorldBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_m_FourCornerWorldBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x06003A5F RID: 14943 RVA: 0x00165984 File Offset: 0x00163B84
		// (set) Token: 0x06003A60 RID: 14944 RVA: 0x00020AFA File Offset: 0x0001ECFA
		public unsafe List<ValueTuple<Guid, BuffElement>> registeredBuffElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_registeredBuffElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<Guid, BuffElement>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_registeredBuffElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x06003A61 RID: 14945 RVA: 0x001659B4 File Offset: 0x00163BB4
		// (set) Token: 0x06003A62 RID: 14946 RVA: 0x00020B19 File Offset: 0x0001ED19
		public unsafe int currentFocusingBuffIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_currentFocusingBuffIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_currentFocusingBuffIndex)) = value;
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06003A63 RID: 14947 RVA: 0x001659DC File Offset: 0x00163BDC
		// (set) Token: 0x06003A64 RID: 14948 RVA: 0x00020B34 File Offset: 0x0001ED34
		public unsafe Action onCancelLastSubscriptionCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_onCancelLastSubscriptionCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_onCancelLastSubscriptionCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x00165A0C File Offset: 0x00163C0C
		// (set) Token: 0x06003A66 RID: 14950 RVA: 0x00020B53 File Offset: 0x0001ED53
		public unsafe bool isFoucusing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_isFoucusing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.NativeFieldInfoPtr_isFoucusing)) = value;
			}
		}

		// Token: 0x04002729 RID: 10025
		private static readonly IntPtr NativeFieldInfoPtr_BUFF_ELEMENT_RANDOM_RANGE;

		// Token: 0x0400272A RID: 10026
		private static readonly IntPtr NativeFieldInfoPtr_buffElement;

		// Token: 0x0400272B RID: 10027
		private static readonly IntPtr NativeFieldInfoPtr_buffField;

		// Token: 0x0400272C RID: 10028
		private static readonly IntPtr NativeFieldInfoPtr_descriptor;

		// Token: 0x0400272D RID: 10029
		private static readonly IntPtr NativeFieldInfoPtr_canvasGroup;

		// Token: 0x0400272E RID: 10030
		private static readonly IntPtr NativeFieldInfoPtr_buffDescriberStayDuraion;

		// Token: 0x0400272F RID: 10031
		private static readonly IntPtr NativeFieldInfoPtr_cachedBuffElement;

		// Token: 0x04002730 RID: 10032
		private static readonly IntPtr NativeFieldInfoPtr_m_FourCornerWorldBuffer;

		// Token: 0x04002731 RID: 10033
		private static readonly IntPtr NativeFieldInfoPtr_registeredBuffElement;

		// Token: 0x04002732 RID: 10034
		private static readonly IntPtr NativeFieldInfoPtr_currentFocusingBuffIndex;

		// Token: 0x04002733 RID: 10035
		private static readonly IntPtr NativeFieldInfoPtr_onCancelLastSubscriptionCallback;

		// Token: 0x04002734 RID: 10036
		private static readonly IntPtr NativeFieldInfoPtr_isFoucusing;

		// Token: 0x04002735 RID: 10037
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x04002736 RID: 10038
		private static readonly IntPtr NativeMethodInfoPtr_TryGetBuffElement_Public_Boolean_Guid_byref_BuffElement_0;

		// Token: 0x04002737 RID: 10039
		private static readonly IntPtr NativeMethodInfoPtr_RegisterBuff_Public_Void_Sprite_String_Guid_byref_Action_2_String_Single_byref_Action_2_String_Int32_byref_Action_0;

		// Token: 0x04002738 RID: 10040
		private static readonly IntPtr NativeMethodInfoPtr_GetTargetElementTransform_Public_Void_Guid_byref_Transform_0;

		// Token: 0x04002739 RID: 10041
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x0400273A RID: 10042
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCurrentFocusingDescriptor_Private_Void_1;

		// Token: 0x0400273B RID: 10043
		private static readonly IntPtr NativeMethodInfoPtr_OnExecuteNavigateAction_Public_Void_CallbackContext_0;

		// Token: 0x0400273C RID: 10044
		private static readonly IntPtr NativeMethodInfoPtr_CloseCurrentSelection_Private_Void_1;

		// Token: 0x0400273D RID: 10045
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePannelAlpha_Private_Void_Single_0;

		// Token: 0x0400273E RID: 10046
		private static readonly IntPtr NativeMethodInfoPtr_NotifyBuffDescriptor_Private_Void_1;

		// Token: 0x0400273F RID: 10047
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04002740 RID: 10048
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002741 RID: 10049
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x04002742 RID: 10050
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Boolean_PDM_0;

		// Token: 0x04002743 RID: 10051
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x04002744 RID: 10052
		private static readonly IntPtr NativeMethodInfoPtr__NotifyBuffDescriptor_b__21_3_Private_Boolean_0;

		// Token: 0x02000951 RID: 2385
		[ObfuscatedName("NightScene.UI.EventUtility.BuffModule+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BA76 RID: 47734 RVA: 0x002F02E4 File Offset: 0x002EE4E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<BuffModule.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModule.__c__DisplayClass13_0>.NativeClassPtr);
				BuffModule.__c__DisplayClass13_0.NativeFieldInfoPtr_buffId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass13_0>.NativeClassPtr, "buffId");
				BuffModule.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass13_0>.NativeClassPtr, 100674143);
				BuffModule.__c__DisplayClass13_0.NativeMethodInfoPtr__TryGetBuffElement_b__0_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass13_0>.NativeClassPtr, 100674144);
			}

			// Token: 0x0600BA77 RID: 47735 RVA: 0x002F034C File Offset: 0x002EE54C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffModule.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA78 RID: 47736 RVA: 0x002F0388 File Offset: 0x002EE588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132396, XrefRangeEnd = 132397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _TryGetBuffElement_b__0(ValueTuple<Guid, BuffElement> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass13_0.NativeMethodInfoPtr__TryGetBuffElement_b__0_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA79 RID: 47737 RVA: 0x00064A26 File Offset: 0x00062C26
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D0F RID: 15631
			// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x002F03DC File Offset: 0x002EE5DC
			// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x00064A2F File Offset: 0x00062C2F
			public unsafe Guid buffId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass13_0.NativeFieldInfoPtr_buffId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass13_0.NativeFieldInfoPtr_buffId)) = value;
				}
			}

			// Token: 0x0400787D RID: 30845
			private static readonly IntPtr NativeFieldInfoPtr_buffId;

			// Token: 0x0400787E RID: 30846
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400787F RID: 30847
			private static readonly IntPtr NativeMethodInfoPtr__TryGetBuffElement_b__0_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0;
		}

		// Token: 0x02000952 RID: 2386
		[ObfuscatedName("NightScene.UI.EventUtility.BuffModule+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BA7C RID: 47740 RVA: 0x002F0404 File Offset: 0x002EE604
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr);
				BuffModule.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, "<>4__this");
				BuffModule.__c__DisplayClass14_0.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, "guid");
				BuffModule.__c__DisplayClass14_0.NativeFieldInfoPtr_spawnedElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, "spawnedElement");
				BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, 100674145);
				BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, 100674146);
				BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, 100674147);
				BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__RegisterBuff_b__5_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, 100674148);
				BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__RegisterBuff_b__2_Internal_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, 100674149);
				BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__RegisterBuff_b__3_Internal_Void_2 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, 100674150);
				BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, 100674151);
				BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__RegisterBuff_b__6_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr, 100674152);
			}

			// Token: 0x0600BA7D RID: 47741 RVA: 0x002F050C File Offset: 0x002EE70C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffModule.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA7E RID: 47742 RVA: 0x002F0548 File Offset: 0x002EE748
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 132412, RefRangeEnd = 132414, XrefRangeStart = 132397, XrefRangeEnd = 132412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA7F RID: 47743 RVA: 0x002F057C File Offset: 0x002EE77C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 132426, RefRangeEnd = 132428, XrefRangeStart = 132414, XrefRangeEnd = 132426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA80 RID: 47744 RVA: 0x002F05B0 File Offset: 0x002EE7B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132428, XrefRangeEnd = 132429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RegisterBuff_b__5(ValueTuple<Guid, BuffElement> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__RegisterBuff_b__5_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA81 RID: 47745 RVA: 0x002F0604 File Offset: 0x002EE804
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132429, XrefRangeEnd = 132430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterBuff_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__RegisterBuff_b__2_Internal_Void_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA82 RID: 47746 RVA: 0x002F0638 File Offset: 0x002EE838
			[CallerCount(0)]
			public unsafe void _RegisterBuff_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__RegisterBuff_b__3_Internal_Void_2, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA83 RID: 47747 RVA: 0x002F066C File Offset: 0x002EE86C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132430, XrefRangeEnd = 132453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA84 RID: 47748 RVA: 0x002F06A0 File Offset: 0x002EE8A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RegisterBuff_b__6(ValueTuple<Guid, BuffElement> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass14_0.NativeMethodInfoPtr__RegisterBuff_b__6_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA85 RID: 47749 RVA: 0x00064A4A File Offset: 0x00062C4A
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D10 RID: 15632
			// (get) Token: 0x0600BA86 RID: 47750 RVA: 0x002F06F4 File Offset: 0x002EE8F4
			// (set) Token: 0x0600BA87 RID: 47751 RVA: 0x00064A53 File Offset: 0x00062C53
			public unsafe BuffModule __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuffModule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass14_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D11 RID: 15633
			// (get) Token: 0x0600BA88 RID: 47752 RVA: 0x002F0724 File Offset: 0x002EE924
			// (set) Token: 0x0600BA89 RID: 47753 RVA: 0x00064A72 File Offset: 0x00062C72
			public unsafe Guid guid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass14_0.NativeFieldInfoPtr_guid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass14_0.NativeFieldInfoPtr_guid)) = value;
				}
			}

			// Token: 0x17003D12 RID: 15634
			// (get) Token: 0x0600BA8A RID: 47754 RVA: 0x002F074C File Offset: 0x002EE94C
			// (set) Token: 0x0600BA8B RID: 47755 RVA: 0x00064A8D File Offset: 0x00062C8D
			public unsafe BuffElement spawnedElement
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass14_0.NativeFieldInfoPtr_spawnedElement);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuffElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass14_0.NativeFieldInfoPtr_spawnedElement), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007880 RID: 30848
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007881 RID: 30849
			private static readonly IntPtr NativeFieldInfoPtr_guid;

			// Token: 0x04007882 RID: 30850
			private static readonly IntPtr NativeFieldInfoPtr_spawnedElement;

			// Token: 0x04007883 RID: 30851
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007884 RID: 30852
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04007885 RID: 30853
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_1;

			// Token: 0x04007886 RID: 30854
			private static readonly IntPtr NativeMethodInfoPtr__RegisterBuff_b__5_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0;

			// Token: 0x04007887 RID: 30855
			private static readonly IntPtr NativeMethodInfoPtr__RegisterBuff_b__2_Internal_Void_2;

			// Token: 0x04007888 RID: 30856
			private static readonly IntPtr NativeMethodInfoPtr__RegisterBuff_b__3_Internal_Void_2;

			// Token: 0x04007889 RID: 30857
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400788A RID: 30858
			private static readonly IntPtr NativeMethodInfoPtr__RegisterBuff_b__6_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0;
		}

		// Token: 0x02000953 RID: 2387
		[ObfuscatedName("NightScene.UI.EventUtility.BuffModule+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BA8C RID: 47756 RVA: 0x002F077C File Offset: 0x002EE97C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<BuffModule.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModule.__c__DisplayClass15_0>.NativeClassPtr);
				BuffModule.__c__DisplayClass15_0.NativeFieldInfoPtr_guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass15_0>.NativeClassPtr, "guid");
				BuffModule.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass15_0>.NativeClassPtr, 100674153);
				BuffModule.__c__DisplayClass15_0.NativeMethodInfoPtr__GetTargetElementTransform_b__1_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass15_0>.NativeClassPtr, 100674154);
			}

			// Token: 0x0600BA8D RID: 47757 RVA: 0x002F07E4 File Offset: 0x002EE9E4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffModule.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA8E RID: 47758 RVA: 0x002F0820 File Offset: 0x002EEA20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTargetElementTransform_b__1(ValueTuple<Guid, BuffElement> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass15_0.NativeMethodInfoPtr__GetTargetElementTransform_b__1_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA8F RID: 47759 RVA: 0x00064AAC File Offset: 0x00062CAC
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D13 RID: 15635
			// (get) Token: 0x0600BA90 RID: 47760 RVA: 0x002F0874 File Offset: 0x002EEA74
			// (set) Token: 0x0600BA91 RID: 47761 RVA: 0x00064AB5 File Offset: 0x00062CB5
			public unsafe Guid guid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass15_0.NativeFieldInfoPtr_guid);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass15_0.NativeFieldInfoPtr_guid)) = value;
				}
			}

			// Token: 0x0400788B RID: 30859
			private static readonly IntPtr NativeFieldInfoPtr_guid;

			// Token: 0x0400788C RID: 30860
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400788D RID: 30861
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetElementTransform_b__1_Internal_Boolean_ValueTuple_2_Guid_BuffElement_0;
		}

		// Token: 0x02000954 RID: 2388
		[ObfuscatedName("NightScene.UI.EventUtility.BuffModule+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600BA92 RID: 47762 RVA: 0x002F089C File Offset: 0x002EEA9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<BuffModule.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModule.__c>.NativeClassPtr);
				BuffModule.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c>.NativeClassPtr, "<>9");
				BuffModule.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c>.NativeClassPtr, "<>9__15_0");
				BuffModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c>.NativeClassPtr, 100674156);
				BuffModule.__c.NativeMethodInfoPtr__GetTargetElementTransform_b__15_0_Internal_Guid_ValueTuple_2_Guid_BuffElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c>.NativeClassPtr, 100674157);
			}

			// Token: 0x0600BA93 RID: 47763 RVA: 0x002F0918 File Offset: 0x002EEB18
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffModule.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA94 RID: 47764 RVA: 0x002F0954 File Offset: 0x002EEB54
			[CallerCount(0)]
			public unsafe Guid _GetTargetElementTransform_b__15_0(ValueTuple<Guid, BuffElement> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c.NativeMethodInfoPtr__GetTargetElementTransform_b__15_0_Internal_Guid_ValueTuple_2_Guid_BuffElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600BA95 RID: 47765 RVA: 0x00064AD0 File Offset: 0x00062CD0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D14 RID: 15636
			// (get) Token: 0x0600BA96 RID: 47766 RVA: 0x002F09A8 File Offset: 0x002EEBA8
			// (set) Token: 0x0600BA97 RID: 47767 RVA: 0x00064AD9 File Offset: 0x00062CD9
			public unsafe static BuffModule.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BuffModule.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuffModule.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuffModule.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D15 RID: 15637
			// (get) Token: 0x0600BA98 RID: 47768 RVA: 0x002F09D0 File Offset: 0x002EEBD0
			// (set) Token: 0x0600BA99 RID: 47769 RVA: 0x00064AEB File Offset: 0x00062CEB
			public unsafe static Func<ValueTuple<Guid, BuffElement>, Guid> __9__15_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(BuffModule.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Guid, BuffElement>, Guid>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BuffModule.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400788E RID: 30862
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400788F RID: 30863
			private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

			// Token: 0x04007890 RID: 30864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007891 RID: 30865
			private static readonly IntPtr NativeMethodInfoPtr__GetTargetElementTransform_b__15_0_Internal_Guid_ValueTuple_2_Guid_BuffElement_0;
		}

		// Token: 0x02000955 RID: 2389
		[ObfuscatedName("NightScene.UI.EventUtility.BuffModule+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600BA9A RID: 47770 RVA: 0x002F09F8 File Offset: 0x002EEBF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr);
				BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr, "<>4__this");
				BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr_title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr, "title");
				BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr_currentDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr, "currentDescription");
				BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr_visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr, "visual");
				BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr, 100674158);
				BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr, 100674159);
				BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr, 100674160);
				BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__2_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr, 100674161);
				BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr, 100674162);
			}

			// Token: 0x0600BA9B RID: 47771 RVA: 0x002F0AD8 File Offset: 0x002EECD8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA9C RID: 47772 RVA: 0x002F0B14 File Offset: 0x002EED14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132453, XrefRangeEnd = 132466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_String_PDM_0(string newDescription)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newDescription);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr_Method_Internal_Void_String_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA9D RID: 47773 RVA: 0x002F0B58 File Offset: 0x002EED58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCurrentFocusingDescriptor_b__1(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA9E RID: 47774 RVA: 0x002F0B9C File Offset: 0x002EED9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCurrentFocusingDescriptor_b__2(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__2_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BA9F RID: 47775 RVA: 0x002F0BE0 File Offset: 0x002EEDE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132466, XrefRangeEnd = 132468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCurrentFocusingDescriptor_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass17_0.NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAA0 RID: 47776 RVA: 0x00064AFD File Offset: 0x00062CFD
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D16 RID: 15638
			// (get) Token: 0x0600BAA1 RID: 47777 RVA: 0x002F0C24 File Offset: 0x002EEE24
			// (set) Token: 0x0600BAA2 RID: 47778 RVA: 0x00064B06 File Offset: 0x00062D06
			public unsafe BuffModule __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuffModule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D17 RID: 15639
			// (get) Token: 0x0600BAA3 RID: 47779 RVA: 0x002F0C54 File Offset: 0x002EEE54
			// (set) Token: 0x0600BAA4 RID: 47780 RVA: 0x00064B25 File Offset: 0x00062D25
			public unsafe string title
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr_title);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr_title), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003D18 RID: 15640
			// (get) Token: 0x0600BAA5 RID: 47781 RVA: 0x002F0C7C File Offset: 0x002EEE7C
			// (set) Token: 0x0600BAA6 RID: 47782 RVA: 0x00064B44 File Offset: 0x00062D44
			public unsafe string currentDescription
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr_currentDescription);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr_currentDescription), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003D19 RID: 15641
			// (get) Token: 0x0600BAA7 RID: 47783 RVA: 0x002F0CA4 File Offset: 0x002EEEA4
			// (set) Token: 0x0600BAA8 RID: 47784 RVA: 0x00064B63 File Offset: 0x00062D63
			public unsafe Sprite visual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr_visual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_0.NativeFieldInfoPtr_visual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007892 RID: 30866
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04007893 RID: 30867
			private static readonly IntPtr NativeFieldInfoPtr_title;

			// Token: 0x04007894 RID: 30868
			private static readonly IntPtr NativeFieldInfoPtr_currentDescription;

			// Token: 0x04007895 RID: 30869
			private static readonly IntPtr NativeFieldInfoPtr_visual;

			// Token: 0x04007896 RID: 30870
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04007897 RID: 30871
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_String_PDM_0;

			// Token: 0x04007898 RID: 30872
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04007899 RID: 30873
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__2_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x0400789A RID: 30874
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__3_Internal_Void_Image_0;
		}

		// Token: 0x02000956 RID: 2390
		[ObfuscatedName("NightScene.UI.EventUtility.BuffModule+<>c__DisplayClass17_1")]
		public sealed class __c__DisplayClass17_1 : Il2CppSystem.Object
		{
			// Token: 0x0600BAA9 RID: 47785 RVA: 0x002F0CD4 File Offset: 0x002EEED4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_1()
			{
				Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "<>c__DisplayClass17_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_1>.NativeClassPtr);
				BuffModule.__c__DisplayClass17_1.NativeFieldInfoPtr_newDescription = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_1>.NativeClassPtr, "newDescription");
				BuffModule.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_1>.NativeClassPtr, 100674163);
				BuffModule.__c__DisplayClass17_1.NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__4_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_1>.NativeClassPtr, 100674164);
			}

			// Token: 0x0600BAAA RID: 47786 RVA: 0x002F0D3C File Offset: 0x002EEF3C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffModule.__c__DisplayClass17_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass17_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAAB RID: 47787 RVA: 0x002F0D78 File Offset: 0x002EEF78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _UpdateCurrentFocusingDescriptor_b__4(TextMeshProUGUI x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.__c__DisplayClass17_1.NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__4_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAAC RID: 47788 RVA: 0x00064B82 File Offset: 0x00062D82
			public __c__DisplayClass17_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D1A RID: 15642
			// (get) Token: 0x0600BAAD RID: 47789 RVA: 0x002F0DBC File Offset: 0x002EEFBC
			// (set) Token: 0x0600BAAE RID: 47790 RVA: 0x00064B8B File Offset: 0x00062D8B
			public unsafe string newDescription
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_1.NativeFieldInfoPtr_newDescription);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.__c__DisplayClass17_1.NativeFieldInfoPtr_newDescription), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400789B RID: 30875
			private static readonly IntPtr NativeFieldInfoPtr_newDescription;

			// Token: 0x0400789C RID: 30876
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400789D RID: 30877
			private static readonly IntPtr NativeMethodInfoPtr__UpdateCurrentFocusingDescriptor_b__4_Internal_Void_TextMeshProUGUI_0;
		}

		// Token: 0x02000957 RID: 2391
		[ObfuscatedName("NightScene.UI.EventUtility.BuffModule+<<NotifyBuffDescriptor>g__Loop|21_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600BAAF RID: 47791 RVA: 0x002F0DE4 File Offset: 0x002EEFE4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique()
			{
				Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BuffModule>.NativeClassPtr, "<<NotifyBuffDescriptor>g__Loop|21_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr);
				BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr, "<>1__state");
				BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr, "<>2__current");
				BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr, "<>4__this");
				BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr, 100674165);
				BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr, 100674166);
				BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr, 100674167);
				BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr, 100674168);
				BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr, 100674169);
				BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr, 100674170);
			}

			// Token: 0x0600BAB0 RID: 47792 RVA: 0x002F0EC4 File Offset: 0x002EF0C4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAB1 RID: 47793 RVA: 0x002F0F0C File Offset: 0x002EF10C
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BAB2 RID: 47794 RVA: 0x002F0F40 File Offset: 0x002EF140
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132468, XrefRangeEnd = 132482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003D1E RID: 15646
			// (get) Token: 0x0600BAB3 RID: 47795 RVA: 0x002F0F7C File Offset: 0x002EF17C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BAB4 RID: 47796 RVA: 0x002F0FBC File Offset: 0x002EF1BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 132482, XrefRangeEnd = 132488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003D1F RID: 15647
			// (get) Token: 0x0600BAB5 RID: 47797 RVA: 0x002F0FF0 File Offset: 0x002EF1F0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600BAB6 RID: 47798 RVA: 0x00064BAA File Offset: 0x00062DAA
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D1B RID: 15643
			// (get) Token: 0x0600BAB7 RID: 47799 RVA: 0x002F1030 File Offset: 0x002EF230
			// (set) Token: 0x0600BAB8 RID: 47800 RVA: 0x00064BB3 File Offset: 0x00062DB3
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003D1C RID: 15644
			// (get) Token: 0x0600BAB9 RID: 47801 RVA: 0x002F1058 File Offset: 0x002EF258
			// (set) Token: 0x0600BABA RID: 47802 RVA: 0x00064BCE File Offset: 0x00062DCE
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003D1D RID: 15645
			// (get) Token: 0x0600BABB RID: 47803 RVA: 0x002F1088 File Offset: 0x002EF288
			// (set) Token: 0x0600BABC RID: 47804 RVA: 0x00064BED File Offset: 0x00062DED
			public unsafe BuffModule __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuffModule>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuffModule.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBuObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400789E RID: 30878
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400789F RID: 30879
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040078A0 RID: 30880
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040078A1 RID: 30881
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040078A2 RID: 30882
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040078A3 RID: 30883
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040078A4 RID: 30884
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040078A5 RID: 30885
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040078A6 RID: 30886
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
