using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Story
{
	// Token: 0x02000033 RID: 51
	[StructLayout(2)]
	public struct ControlledSpecialGuest
	{
		// Token: 0x06000542 RID: 1346 RVA: 0x000AF3A0 File Offset: 0x000AD5A0
		// Note: this type is marked as 'beforefieldinit'.
		static ControlledSpecialGuest()
		{
			Il2CppClassPointerStore<ControlledSpecialGuest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Story", "ControlledSpecialGuest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlledSpecialGuest>.NativeClassPtr);
			ControlledSpecialGuest.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlledSpecialGuest>.NativeClassPtr, "Id");
			ControlledSpecialGuest.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlledSpecialGuest>.NativeClassPtr, "Status");
			ControlledSpecialGuest.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControlStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlledSpecialGuest>.NativeClassPtr, 100664016);
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x000AF40C File Offset: 0x000AD60C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 24037, RefRangeEnd = 24059, XrefRangeStart = 24037, XrefRangeEnd = 24037, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlledSpecialGuest(int id, ControlStatus status)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref status;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlledSpecialGuest.NativeMethodInfoPtr__ctor_Public_Void_Int32_ControlStatus_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x000050B8 File Offset: 0x000032B8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ControlledSpecialGuest>.NativeClassPtr, ref this));
		}

		// Token: 0x0400035E RID: 862
		private static readonly IntPtr NativeFieldInfoPtr_Id;

		// Token: 0x0400035F RID: 863
		private static readonly IntPtr NativeFieldInfoPtr_Status;

		// Token: 0x04000360 RID: 864
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_ControlStatus_0;

		// Token: 0x04000361 RID: 865
		[FieldOffset(0)]
		public int Id;

		// Token: 0x04000362 RID: 866
		[FieldOffset(4)]
		public ControlStatus Status;
	}
}
