using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace Common
{
	// Token: 0x02000336 RID: 822
	public class IZKYAESStreamProcessor : Object
	{
		// Token: 0x06006117 RID: 24855 RVA: 0x001E27F4 File Offset: 0x001E09F4
		// Note: this type is marked as 'beforefieldinit'.
		static IZKYAESStreamProcessor()
		{
			Il2CppClassPointerStore<IZKYAESStreamProcessor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common", "IZKYAESStreamProcessor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IZKYAESStreamProcessor>.NativeClassPtr);
			IZKYAESStreamProcessor.NativeMethodInfoPtr_CreateReadStream_Public_Virtual_Final_New_Stream_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor>.NativeClassPtr, 100683323);
			IZKYAESStreamProcessor.NativeMethodInfoPtr_CreateWriteStream_Public_Virtual_Final_New_Stream_Stream_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor>.NativeClassPtr, 100683324);
			IZKYAESStreamProcessor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor>.NativeClassPtr, 100683325);
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x001E2860 File Offset: 0x001E0A60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240622, XrefRangeEnd = 240630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Stream CreateReadStream(Stream input, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IZKYAESStreamProcessor.NativeMethodInfoPtr_CreateReadStream_Public_Virtual_Final_New_Stream_Stream_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x001E28C4 File Offset: 0x001E0AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240630, XrefRangeEnd = 240638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Stream CreateWriteStream(Stream input, string id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IZKYAESStreamProcessor.NativeMethodInfoPtr_CreateWriteStream_Public_Virtual_Final_New_Stream_Stream_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr3) : null;
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x001E2928 File Offset: 0x001E0B28
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IZKYAESStreamProcessor() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IZKYAESStreamProcessor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IZKYAESStreamProcessor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600611B RID: 24859 RVA: 0x00034A46 File Offset: 0x00032C46
		public IZKYAESStreamProcessor(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400404E RID: 16462
		private static readonly IntPtr NativeMethodInfoPtr_CreateReadStream_Public_Virtual_Final_New_Stream_Stream_String_0;

		// Token: 0x0400404F RID: 16463
		private static readonly IntPtr NativeMethodInfoPtr_CreateWriteStream_Public_Virtual_Final_New_Stream_Stream_String_0;

		// Token: 0x04004050 RID: 16464
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D8D RID: 3469
		public class EncryptStream : Stream
		{
			// Token: 0x0600F716 RID: 63254 RVA: 0x003A4830 File Offset: 0x003A2A30
			// Note: this type is marked as 'beforefieldinit'.
			static EncryptStream()
			{
				Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IZKYAESStreamProcessor>.NativeClassPtr, "EncryptStream");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr);
				IZKYAESStreamProcessor.EncryptStream.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, "_stream");
				IZKYAESStreamProcessor.EncryptStream.NativeFieldInfoPtr__identifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, "_identifier");
				IZKYAESStreamProcessor.EncryptStream.NativeFieldInfoPtr_keyBytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, "keyBytes");
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683326);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683327);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683328);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683329);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683330);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683331);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683332);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683333);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683334);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683335);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683336);
				IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, 100683337);
			}

			// Token: 0x1700504D RID: 20557
			// (get) Token: 0x0600F717 RID: 63255 RVA: 0x003A4988 File Offset: 0x003A2B88
			public unsafe override bool CanRead
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240529, XrefRangeEnd = 240530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700504E RID: 20558
			// (get) Token: 0x0600F718 RID: 63256 RVA: 0x003A49D0 File Offset: 0x003A2BD0
			public unsafe override bool CanSeek
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240530, XrefRangeEnd = 240531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x1700504F RID: 20559
			// (get) Token: 0x0600F719 RID: 63257 RVA: 0x003A4A18 File Offset: 0x003A2C18
			public unsafe override bool CanWrite
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240531, XrefRangeEnd = 240532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17005050 RID: 20560
			// (get) Token: 0x0600F71A RID: 63258 RVA: 0x003A4A60 File Offset: 0x003A2C60
			public unsafe override long Length
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240532, XrefRangeEnd = 240533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x17005051 RID: 20561
			// (get) Token: 0x0600F71B RID: 63259 RVA: 0x003A4AA8 File Offset: 0x003A2CA8
			// (set) Token: 0x0600F71C RID: 63260 RVA: 0x003A4AF0 File Offset: 0x003A2CF0
			public unsafe override long Position
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240533, XrefRangeEnd = 240534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240534, XrefRangeEnd = 240535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600F71D RID: 63261 RVA: 0x003A4B3C File Offset: 0x003A2D3C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 240607, RefRangeEnd = 240609, XrefRangeStart = 240535, XrefRangeEnd = 240607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EncryptStream(Stream stream, string key, string identifier) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(key);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(identifier);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr__ctor_Public_Void_Stream_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F71E RID: 63262 RVA: 0x003A4BAC File Offset: 0x003A2DAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240609, XrefRangeEnd = 240612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read(Il2CppStructArray<byte> array, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F71F RID: 63263 RVA: 0x003A4C20 File Offset: 0x003A2E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240612, XrefRangeEnd = 240617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<byte> array, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F720 RID: 63264 RVA: 0x003A4C8C File Offset: 0x003A2E8C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 240618, RefRangeEnd = 240620, XrefRangeStart = 240617, XrefRangeEnd = 240618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Flush()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F721 RID: 63265 RVA: 0x003A4CC8 File Offset: 0x003A2EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240620, XrefRangeEnd = 240621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override long Seek(long offset, SeekOrigin origin)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref offset;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F722 RID: 63266 RVA: 0x003A4D2C File Offset: 0x003A2F2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240621, XrefRangeEnd = 240622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void SetLength(long value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IZKYAESStreamProcessor.EncryptStream.NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F723 RID: 63267 RVA: 0x00084AB1 File Offset: 0x00082CB1
			public EncryptStream(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700504A RID: 20554
			// (get) Token: 0x0600F724 RID: 63268 RVA: 0x003A4D78 File Offset: 0x003A2F78
			// (set) Token: 0x0600F725 RID: 63269 RVA: 0x00084ABA File Offset: 0x00082CBA
			public unsafe Stream _stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IZKYAESStreamProcessor.EncryptStream.NativeFieldInfoPtr__stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IZKYAESStreamProcessor.EncryptStream.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700504B RID: 20555
			// (get) Token: 0x0600F726 RID: 63270 RVA: 0x003A4DA8 File Offset: 0x003A2FA8
			// (set) Token: 0x0600F727 RID: 63271 RVA: 0x00084AD9 File Offset: 0x00082CD9
			public unsafe int _identifier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IZKYAESStreamProcessor.EncryptStream.NativeFieldInfoPtr__identifier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IZKYAESStreamProcessor.EncryptStream.NativeFieldInfoPtr__identifier)) = value;
				}
			}

			// Token: 0x1700504C RID: 20556
			// (get) Token: 0x0600F728 RID: 63272 RVA: 0x003A4DD0 File Offset: 0x003A2FD0
			// (set) Token: 0x0600F729 RID: 63273 RVA: 0x00084AF4 File Offset: 0x00082CF4
			public unsafe int keyBytes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IZKYAESStreamProcessor.EncryptStream.NativeFieldInfoPtr_keyBytes);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IZKYAESStreamProcessor.EncryptStream.NativeFieldInfoPtr_keyBytes)) = value;
				}
			}

			// Token: 0x04009D63 RID: 40291
			private static readonly IntPtr NativeFieldInfoPtr__stream;

			// Token: 0x04009D64 RID: 40292
			private static readonly IntPtr NativeFieldInfoPtr__identifier;

			// Token: 0x04009D65 RID: 40293
			private static readonly IntPtr NativeFieldInfoPtr_keyBytes;

			// Token: 0x04009D66 RID: 40294
			private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

			// Token: 0x04009D67 RID: 40295
			private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

			// Token: 0x04009D68 RID: 40296
			private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

			// Token: 0x04009D69 RID: 40297
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

			// Token: 0x04009D6A RID: 40298
			private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

			// Token: 0x04009D6B RID: 40299
			private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

			// Token: 0x04009D6C RID: 40300
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Stream_String_String_0;

			// Token: 0x04009D6D RID: 40301
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x04009D6E RID: 40302
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x04009D6F RID: 40303
			private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

			// Token: 0x04009D70 RID: 40304
			private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;

			// Token: 0x04009D71 RID: 40305
			private static readonly IntPtr NativeMethodInfoPtr_SetLength_Public_Virtual_Void_Int64_0;

			// Token: 0x020010A4 RID: 4260
			[ObfuscatedName("Common.IZKYAESStreamProcessor+EncryptStream+<>c")]
			[Serializable]
			public new sealed class __c : Object
			{
				// Token: 0x06012220 RID: 74272 RVA: 0x00423034 File Offset: 0x00421234
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr);
					IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, "<>9");
					IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, "<>9__14_0");
					IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, "<>9__14_1");
					IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, "<>9__14_2");
					IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, "<>9__14_3");
					IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, 100683339);
					IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, 100683340);
					IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr___ctor_b__14_1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, 100683341);
					IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr___ctor_b__14_2_Internal_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, 100683342);
					IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr___ctor_b__14_3_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr, 100683343);
				}

				// Token: 0x06012221 RID: 74273 RVA: 0x00423128 File Offset: 0x00421328
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IZKYAESStreamProcessor.EncryptStream.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012222 RID: 74274 RVA: 0x00423164 File Offset: 0x00421364
				[CallerCount(0)]
				public unsafe int __ctor_b__14_0(byte x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr___ctor_b__14_0_Internal_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012223 RID: 74275 RVA: 0x004231B0 File Offset: 0x004213B0
				[CallerCount(0)]
				public unsafe int __ctor_b__14_1(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr___ctor_b__14_1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012224 RID: 74276 RVA: 0x00423208 File Offset: 0x00421408
				[CallerCount(0)]
				public unsafe int __ctor_b__14_2(byte x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr___ctor_b__14_2_Internal_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012225 RID: 74277 RVA: 0x00423254 File Offset: 0x00421454
				[CallerCount(0)]
				public unsafe int __ctor_b__14_3(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IZKYAESStreamProcessor.EncryptStream.__c.NativeMethodInfoPtr___ctor_b__14_3_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06012226 RID: 74278 RVA: 0x0009D889 File Offset: 0x0009BA89
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005EB4 RID: 24244
				// (get) Token: 0x06012227 RID: 74279 RVA: 0x004232AC File Offset: 0x004214AC
				// (set) Token: 0x06012228 RID: 74280 RVA: 0x0009D892 File Offset: 0x0009BA92
				public unsafe static IZKYAESStreamProcessor.EncryptStream.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<IZKYAESStreamProcessor.EncryptStream.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EB5 RID: 24245
				// (get) Token: 0x06012229 RID: 74281 RVA: 0x004232D4 File Offset: 0x004214D4
				// (set) Token: 0x0601222A RID: 74282 RVA: 0x0009D8A4 File Offset: 0x0009BAA4
				public unsafe static Func<byte, int> __9__14_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<byte, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EB6 RID: 24246
				// (get) Token: 0x0601222B RID: 74283 RVA: 0x004232FC File Offset: 0x004214FC
				// (set) Token: 0x0601222C RID: 74284 RVA: 0x0009D8B6 File Offset: 0x0009BAB6
				public unsafe static Func<int, int, int> __9__14_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EB7 RID: 24247
				// (get) Token: 0x0601222D RID: 74285 RVA: 0x00423324 File Offset: 0x00421524
				// (set) Token: 0x0601222E RID: 74286 RVA: 0x0009D8C8 File Offset: 0x0009BAC8
				public unsafe static Func<byte, int> __9__14_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<byte, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EB8 RID: 24248
				// (get) Token: 0x0601222F RID: 74287 RVA: 0x0042334C File Offset: 0x0042154C
				// (set) Token: 0x06012230 RID: 74288 RVA: 0x0009D8DA File Offset: 0x0009BADA
				public unsafe static Func<int, int, int> __9__14_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(IZKYAESStreamProcessor.EncryptStream.__c.NativeFieldInfoPtr___9__14_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B7C8 RID: 47048
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B7C9 RID: 47049
				private static readonly IntPtr NativeFieldInfoPtr___9__14_0;

				// Token: 0x0400B7CA RID: 47050
				private static readonly IntPtr NativeFieldInfoPtr___9__14_1;

				// Token: 0x0400B7CB RID: 47051
				private static readonly IntPtr NativeFieldInfoPtr___9__14_2;

				// Token: 0x0400B7CC RID: 47052
				private static readonly IntPtr NativeFieldInfoPtr___9__14_3;

				// Token: 0x0400B7CD RID: 47053
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B7CE RID: 47054
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Internal_Int32_Byte_0;

				// Token: 0x0400B7CF RID: 47055
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_1_Internal_Int32_Int32_Int32_0;

				// Token: 0x0400B7D0 RID: 47056
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_2_Internal_Int32_Byte_0;

				// Token: 0x0400B7D1 RID: 47057
				private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_3_Internal_Int32_Int32_Int32_0;
			}
		}
	}
}
