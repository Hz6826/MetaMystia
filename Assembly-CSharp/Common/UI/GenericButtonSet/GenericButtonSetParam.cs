using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Common.UI.GenericButtonSet
{
	// Token: 0x020003A4 RID: 932
	public sealed class GenericButtonSetParam : ValueType
	{
		// Token: 0x060070EA RID: 28906 RVA: 0x0021639C File Offset: 0x0021459C
		// Note: this type is marked as 'beforefieldinit'.
		static GenericButtonSetParam()
		{
			Il2CppClassPointerStore<GenericButtonSetParam>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.GenericButtonSet", "GenericButtonSetParam");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericButtonSetParam>.NativeClassPtr);
			GenericButtonSetParam.NativeFieldInfoPtr_ButtonTexts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericButtonSetParam>.NativeClassPtr, "ButtonTexts");
			GenericButtonSetParam.NativeFieldInfoPtr_OnButtonSubmitHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericButtonSetParam>.NativeClassPtr, "OnButtonSubmitHandler");
			GenericButtonSetParam.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetParam>.NativeClassPtr, 100686322);
			GenericButtonSetParam.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_IEnumerable_1_String_byref_Action_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericButtonSetParam>.NativeClassPtr, 100686323);
		}

		// Token: 0x060070EB RID: 28907 RVA: 0x0021641C File Offset: 0x0021461C
		[CallerCount(272)]
		[CachedScanResults(RefRangeStart = 17829, RefRangeEnd = 18101, XrefRangeStart = 17829, XrefRangeEnd = 18101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericButtonSetParam(IEnumerable<string> buttonTexts, Action<int> onButtonSubmitHandler) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericButtonSetParam>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(buttonTexts);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onButtonSubmitHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericButtonSetParam.NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_Action_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060070EC RID: 28908 RVA: 0x00216480 File Offset: 0x00214680
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 281827, XrefRangeEnd = 281829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Deconstruct(out IEnumerable<string> buttonTexts, out Action<int> onButtonSubmitHandler)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(GenericButtonSetParam.NativeMethodInfoPtr_Deconstruct_Public_Void_byref_IEnumerable_1_String_byref_Action_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			buttonTexts = ((intPtr5 == 0) ? null : new IEnumerable<string>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			onButtonSubmitHandler = ((intPtr6 == 0) ? null : new Action<int>(intPtr6));
		}

		// Token: 0x060070ED RID: 28909 RVA: 0x0003D5AF File Offset: 0x0003B7AF
		public GenericButtonSetParam(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060070EE RID: 28910 RVA: 0x0003D5B8 File Offset: 0x0003B7B8
		public GenericButtonSetParam() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericButtonSetParam>.NativeClassPtr))
		{
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x060070EF RID: 28911 RVA: 0x002164FC File Offset: 0x002146FC
		// (set) Token: 0x060070F0 RID: 28912 RVA: 0x0003D5CA File Offset: 0x0003B7CA
		public unsafe IEnumerable<string> ButtonTexts
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetParam.NativeFieldInfoPtr_ButtonTexts);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetParam.NativeFieldInfoPtr_ButtonTexts), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x060070F1 RID: 28913 RVA: 0x0021652C File Offset: 0x0021472C
		// (set) Token: 0x060070F2 RID: 28914 RVA: 0x0003D5E9 File Offset: 0x0003B7E9
		public unsafe Action<int> OnButtonSubmitHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetParam.NativeFieldInfoPtr_OnButtonSubmitHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericButtonSetParam.NativeFieldInfoPtr_OnButtonSubmitHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004AC5 RID: 19141
		private static readonly IntPtr NativeFieldInfoPtr_ButtonTexts;

		// Token: 0x04004AC6 RID: 19142
		private static readonly IntPtr NativeFieldInfoPtr_OnButtonSubmitHandler;

		// Token: 0x04004AC7 RID: 19143
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IEnumerable_1_String_Action_1_Int32_0;

		// Token: 0x04004AC8 RID: 19144
		private static readonly IntPtr NativeMethodInfoPtr_Deconstruct_Public_Void_byref_IEnumerable_1_String_byref_Action_1_Int32_0;
	}
}
