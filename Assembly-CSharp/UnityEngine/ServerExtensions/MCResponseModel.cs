using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.ServerExtensions
{
	// Token: 0x0200045A RID: 1114
	public class MCResponseModel : Object
	{
		// Token: 0x06007B27 RID: 31527 RVA: 0x002370AC File Offset: 0x002352AC
		// Note: this type is marked as 'beforefieldinit'.
		static MCResponseModel()
		{
			Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.ServerExtensions", "MCResponseModel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr);
			MCResponseModel.NativeFieldInfoPtr__Key_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, "<Key>k__BackingField");
			MCResponseModel.NativeFieldInfoPtr__Code_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, "<Code>k__BackingField");
			MCResponseModel.NativeFieldInfoPtr__FailMessage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, "<FailMessage>k__BackingField");
			MCResponseModel.NativeMethodInfoPtr_get_Key_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, 100687944);
			MCResponseModel.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, 100687945);
			MCResponseModel.NativeMethodInfoPtr_get_Code_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, 100687946);
			MCResponseModel.NativeMethodInfoPtr_set_Code_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, 100687947);
			MCResponseModel.NativeMethodInfoPtr_get_FailMessage_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, 100687948);
			MCResponseModel.NativeMethodInfoPtr_set_FailMessage_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, 100687949);
			MCResponseModel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr, 100687950);
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x06007B28 RID: 31528 RVA: 0x002371A4 File Offset: 0x002353A4
		// (set) Token: 0x06007B29 RID: 31529 RVA: 0x002371DC File Offset: 0x002353DC
		public unsafe string Key
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCResponseModel.NativeMethodInfoPtr_get_Key_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 44253, RefRangeEnd = 44271, XrefRangeStart = 44253, XrefRangeEnd = 44271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCResponseModel.NativeMethodInfoPtr_set_Key_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x06007B2A RID: 31530 RVA: 0x00237220 File Offset: 0x00235420
		// (set) Token: 0x06007B2B RID: 31531 RVA: 0x0023725C File Offset: 0x0023545C
		public unsafe int Code
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCResponseModel.NativeMethodInfoPtr_get_Code_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 82111, RefRangeEnd = 82113, XrefRangeStart = 82111, XrefRangeEnd = 82113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCResponseModel.NativeMethodInfoPtr_set_Code_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x06007B2C RID: 31532 RVA: 0x0023729C File Offset: 0x0023549C
		// (set) Token: 0x06007B2D RID: 31533 RVA: 0x002372D4 File Offset: 0x002354D4
		public unsafe string FailMessage
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCResponseModel.NativeMethodInfoPtr_get_FailMessage_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCResponseModel.NativeMethodInfoPtr_set_FailMessage_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x00237318 File Offset: 0x00235518
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MCResponseModel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MCResponseModel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MCResponseModel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x0004271E File Offset: 0x0004091E
		public MCResponseModel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x06007B30 RID: 31536 RVA: 0x00237354 File Offset: 0x00235554
		// (set) Token: 0x06007B31 RID: 31537 RVA: 0x00042727 File Offset: 0x00040927
		public unsafe string _Key_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MCResponseModel.NativeFieldInfoPtr__Key_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MCResponseModel.NativeFieldInfoPtr__Key_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x06007B32 RID: 31538 RVA: 0x0023737C File Offset: 0x0023557C
		// (set) Token: 0x06007B33 RID: 31539 RVA: 0x00042746 File Offset: 0x00040946
		public unsafe int _Code_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MCResponseModel.NativeFieldInfoPtr__Code_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MCResponseModel.NativeFieldInfoPtr__Code_k__BackingField)) = value;
			}
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x06007B34 RID: 31540 RVA: 0x002373A4 File Offset: 0x002355A4
		// (set) Token: 0x06007B35 RID: 31541 RVA: 0x00042761 File Offset: 0x00040961
		public unsafe string _FailMessage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MCResponseModel.NativeFieldInfoPtr__FailMessage_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MCResponseModel.NativeFieldInfoPtr__FailMessage_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04005109 RID: 20745
		private static readonly IntPtr NativeFieldInfoPtr__Key_k__BackingField;

		// Token: 0x0400510A RID: 20746
		private static readonly IntPtr NativeFieldInfoPtr__Code_k__BackingField;

		// Token: 0x0400510B RID: 20747
		private static readonly IntPtr NativeFieldInfoPtr__FailMessage_k__BackingField;

		// Token: 0x0400510C RID: 20748
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_String_0;

		// Token: 0x0400510D RID: 20749
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_String_0;

		// Token: 0x0400510E RID: 20750
		private static readonly IntPtr NativeMethodInfoPtr_get_Code_Public_get_Int32_0;

		// Token: 0x0400510F RID: 20751
		private static readonly IntPtr NativeMethodInfoPtr_set_Code_Public_set_Void_Int32_0;

		// Token: 0x04005110 RID: 20752
		private static readonly IntPtr NativeMethodInfoPtr_get_FailMessage_Public_get_String_0;

		// Token: 0x04005111 RID: 20753
		private static readonly IntPtr NativeMethodInfoPtr_set_FailMessage_Public_set_Void_String_0;

		// Token: 0x04005112 RID: 20754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
