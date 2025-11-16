using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Common.DialogUtility.History
{
	// Token: 0x02000348 RID: 840
	public sealed class DialogHistory : ValueType
	{
		// Token: 0x060063CC RID: 25548 RVA: 0x001EBF84 File Offset: 0x001EA184
		// Note: this type is marked as 'beforefieldinit'.
		static DialogHistory()
		{
			Il2CppClassPointerStore<DialogHistory>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility.History", "DialogHistory");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogHistory>.NativeClassPtr);
			DialogHistory.NativeFieldInfoPtr_SpeakerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistory>.NativeClassPtr, "SpeakerName");
			DialogHistory.NativeFieldInfoPtr_SpeakContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistory>.NativeClassPtr, "SpeakContent");
			DialogHistory.NativeFieldInfoPtr_DialogPackageCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogHistory>.NativeClassPtr, "DialogPackageCount");
			DialogHistory.NativeMethodInfoPtr__ctor_Public_Void_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogHistory>.NativeClassPtr, 100684242);
		}

		// Token: 0x060063CD RID: 25549 RVA: 0x001EC004 File Offset: 0x001EA204
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 257419, RefRangeEnd = 257420, XrefRangeStart = 257417, XrefRangeEnd = 257419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogHistory(string speakerName, string speakContent, uint dialogPackageCount) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogHistory>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(speakerName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(speakContent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dialogPackageCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogHistory.NativeMethodInfoPtr__ctor_Public_Void_String_String_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060063CE RID: 25550 RVA: 0x00035F6B File Offset: 0x0003416B
		public DialogHistory(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060063CF RID: 25551 RVA: 0x00035F74 File Offset: 0x00034174
		public DialogHistory() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogHistory>.NativeClassPtr))
		{
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x060063D0 RID: 25552 RVA: 0x001EC074 File Offset: 0x001EA274
		// (set) Token: 0x060063D1 RID: 25553 RVA: 0x00035F86 File Offset: 0x00034186
		public unsafe string SpeakerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistory.NativeFieldInfoPtr_SpeakerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistory.NativeFieldInfoPtr_SpeakerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x060063D2 RID: 25554 RVA: 0x001EC09C File Offset: 0x001EA29C
		// (set) Token: 0x060063D3 RID: 25555 RVA: 0x00035FA5 File Offset: 0x000341A5
		public unsafe string SpeakContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistory.NativeFieldInfoPtr_SpeakContent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistory.NativeFieldInfoPtr_SpeakContent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x060063D4 RID: 25556 RVA: 0x001EC0C4 File Offset: 0x001EA2C4
		// (set) Token: 0x060063D5 RID: 25557 RVA: 0x00035FC4 File Offset: 0x000341C4
		public unsafe uint DialogPackageCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistory.NativeFieldInfoPtr_DialogPackageCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogHistory.NativeFieldInfoPtr_DialogPackageCount)) = value;
			}
		}

		// Token: 0x04004235 RID: 16949
		private static readonly IntPtr NativeFieldInfoPtr_SpeakerName;

		// Token: 0x04004236 RID: 16950
		private static readonly IntPtr NativeFieldInfoPtr_SpeakContent;

		// Token: 0x04004237 RID: 16951
		private static readonly IntPtr NativeFieldInfoPtr_DialogPackageCount;

		// Token: 0x04004238 RID: 16952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_UInt32_0;
	}
}
