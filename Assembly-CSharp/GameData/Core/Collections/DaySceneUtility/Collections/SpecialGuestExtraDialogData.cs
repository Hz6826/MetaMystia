using System;
using DayScene.UI;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002B8 RID: 696
	public class SpecialGuestExtraDialogData : ScriptableObject
	{
		// Token: 0x060056AB RID: 22187 RVA: 0x001C281C File Offset: 0x001C0A1C
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialGuestExtraDialogData()
		{
			Il2CppClassPointerStore<SpecialGuestExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "SpecialGuestExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestExtraDialogData>.NativeClassPtr);
			SpecialGuestExtraDialogData.NativeMethodInfoPtr_get_DoNotSkipGreeting_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestExtraDialogData>.NativeClassPtr, 100680926);
			SpecialGuestExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Abstract_Virtual_New_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestExtraDialogData>.NativeClassPtr, 100680927);
			SpecialGuestExtraDialogData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestExtraDialogData>.NativeClassPtr, 100680928);
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x060056AC RID: 22188 RVA: 0x001C2888 File Offset: 0x001C0A88
		public unsafe virtual bool DoNotSkipGreeting
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestExtraDialogData.NativeMethodInfoPtr_get_DoNotSkipGreeting_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x001C28D0 File Offset: 0x001C0AD0
		[CallerCount(0)]
		public unsafe virtual void GetSpecialGuestExtraDialogData(out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> prependSelection, out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> appendSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpecialGuestExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Abstract_Virtual_New_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x060056AE RID: 22190 RVA: 0x001C2950 File Offset: 0x001C0B50
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuestExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestExtraDialogData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056AF RID: 22191 RVA: 0x0002EA5A File Offset: 0x0002CC5A
		public SpecialGuestExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003A0D RID: 14861
		private static readonly IntPtr NativeMethodInfoPtr_get_DoNotSkipGreeting_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003A0E RID: 14862
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Abstract_Virtual_New_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x04003A0F RID: 14863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
