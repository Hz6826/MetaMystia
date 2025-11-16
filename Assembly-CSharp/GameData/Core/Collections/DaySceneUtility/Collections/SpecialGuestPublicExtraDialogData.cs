using System;
using DayScene.UI;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002B6 RID: 694
	public class SpecialGuestPublicExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x06005690 RID: 22160 RVA: 0x001C227C File Offset: 0x001C047C
		// Note: this type is marked as 'beforefieldinit'.
		static SpecialGuestPublicExtraDialogData()
		{
			Il2CppClassPointerStore<SpecialGuestPublicExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "SpecialGuestPublicExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpecialGuestPublicExtraDialogData>.NativeClassPtr);
			SpecialGuestPublicExtraDialogData.NativeFieldInfoPtr_targetSpecialGuestLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpecialGuestPublicExtraDialogData>.NativeClassPtr, "targetSpecialGuestLabel");
			SpecialGuestPublicExtraDialogData.NativeMethodInfoPtr_get_TargetSpecialGuestLabel_Public_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestPublicExtraDialogData>.NativeClassPtr, 100680903);
			SpecialGuestPublicExtraDialogData.NativeMethodInfoPtr_CheckIsTargetSGuest_Public_Boolean_SpecialNPCInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestPublicExtraDialogData>.NativeClassPtr, 100680904);
			SpecialGuestPublicExtraDialogData.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpecialGuestPublicExtraDialogData>.NativeClassPtr, 100680905);
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x06005691 RID: 22161 RVA: 0x001C22FC File Offset: 0x001C04FC
		public unsafe Il2CppStringArray TargetSpecialGuestLabel
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestPublicExtraDialogData.NativeMethodInfoPtr_get_TargetSpecialGuestLabel_Public_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x06005692 RID: 22162 RVA: 0x001C233C File Offset: 0x001C053C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214691, XrefRangeEnd = 214695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckIsTargetSGuest(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestPublicExtraDialogData.NativeMethodInfoPtr_CheckIsTargetSGuest_Public_Boolean_SpecialNPCInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005693 RID: 22163 RVA: 0x001C238C File Offset: 0x001C058C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpecialGuestPublicExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpecialGuestPublicExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpecialGuestPublicExtraDialogData.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005694 RID: 22164 RVA: 0x0002E95D File Offset: 0x0002CB5D
		public SpecialGuestPublicExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x06005695 RID: 22165 RVA: 0x001C23C8 File Offset: 0x001C05C8
		// (set) Token: 0x06005696 RID: 22166 RVA: 0x0002E966 File Offset: 0x0002CB66
		public unsafe Il2CppStringArray targetSpecialGuestLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestPublicExtraDialogData.NativeFieldInfoPtr_targetSpecialGuestLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpecialGuestPublicExtraDialogData.NativeFieldInfoPtr_targetSpecialGuestLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039FE RID: 14846
		private static readonly IntPtr NativeFieldInfoPtr_targetSpecialGuestLabel;

		// Token: 0x040039FF RID: 14847
		private static readonly IntPtr NativeMethodInfoPtr_get_TargetSpecialGuestLabel_Public_get_Il2CppStringArray_0;

		// Token: 0x04003A00 RID: 14848
		private static readonly IntPtr NativeMethodInfoPtr_CheckIsTargetSGuest_Public_Boolean_SpecialNPCInteractData_0;

		// Token: 0x04003A01 RID: 14849
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
