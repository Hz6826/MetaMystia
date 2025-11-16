using System;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Utils
{
	// Token: 0x0200021B RID: 539
	public sealed class LoadedSaveDataInfo : ValueType
	{
		// Token: 0x06003F4E RID: 16206 RVA: 0x0017649C File Offset: 0x0017469C
		// Note: this type is marked as 'beforefieldinit'.
		static LoadedSaveDataInfo()
		{
			Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Utils", "LoadedSaveDataInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr);
			LoadedSaveDataInfo.NativeFieldInfoPtr_fileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr, "fileData");
			LoadedSaveDataInfo.NativeFieldInfoPtr_loadError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr, "loadError");
			LoadedSaveDataInfo.NativeFieldInfoPtr_fileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr, "fileName");
			LoadedSaveDataInfo.NativeFieldInfoPtr_loadException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr, "loadException");
			LoadedSaveDataInfo.NativeFieldInfoPtr_testFlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr, "testFlight");
			LoadedSaveDataInfo.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_PlayerSaveFile_Boolean_String_Exception_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr, 100675201);
			LoadedSaveDataInfo.NativeMethodInfoPtr_get_NullInfo_Public_Static_get_LoadedSaveDataInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr, 100675202);
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x00176558 File Offset: 0x00174758
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 155898, RefRangeEnd = 155901, XrefRangeStart = 155895, XrefRangeEnd = 155898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadedSaveDataInfo(Nullable<PlayerSaveFile> fileData, bool loadError, string fileName, Exception loadException, bool testFlight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fileData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadError;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadException);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref testFlight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedSaveDataInfo.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_PlayerSaveFile_Boolean_String_Exception_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x06003F50 RID: 16208 RVA: 0x001765F0 File Offset: 0x001747F0
		public unsafe static LoadedSaveDataInfo NullInfo
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 155901, XrefRangeEnd = 155906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LoadedSaveDataInfo.NativeMethodInfoPtr_get_NullInfo_Public_Static_get_LoadedSaveDataInfo_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new LoadedSaveDataInfo(pointer);
			}
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x00022DF1 File Offset: 0x00020FF1
		public LoadedSaveDataInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x00022DFA File Offset: 0x00020FFA
		public LoadedSaveDataInfo() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadedSaveDataInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x0017661C File Offset: 0x0017481C
		// (set) Token: 0x06003F54 RID: 16212 RVA: 0x00022E0C File Offset: 0x0002100C
		public Nullable<PlayerSaveFile> fileData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_fileData);
				return new Nullable<PlayerSaveFile>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<PlayerSaveFile>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_fileData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<PlayerSaveFile>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06003F55 RID: 16213 RVA: 0x0017664C File Offset: 0x0017484C
		// (set) Token: 0x06003F56 RID: 16214 RVA: 0x00022E3A File Offset: 0x0002103A
		public unsafe bool loadError
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_loadError);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_loadError)) = value;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06003F57 RID: 16215 RVA: 0x00176674 File Offset: 0x00174874
		// (set) Token: 0x06003F58 RID: 16216 RVA: 0x00022E55 File Offset: 0x00021055
		public unsafe string fileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_fileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_fileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06003F59 RID: 16217 RVA: 0x0017669C File Offset: 0x0017489C
		// (set) Token: 0x06003F5A RID: 16218 RVA: 0x00022E74 File Offset: 0x00021074
		public unsafe Exception loadException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_loadException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_loadException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x06003F5B RID: 16219 RVA: 0x001766CC File Offset: 0x001748CC
		// (set) Token: 0x06003F5C RID: 16220 RVA: 0x00022E93 File Offset: 0x00021093
		public unsafe bool testFlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_testFlight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedSaveDataInfo.NativeFieldInfoPtr_testFlight)) = value;
			}
		}

		// Token: 0x04002A71 RID: 10865
		private static readonly IntPtr NativeFieldInfoPtr_fileData;

		// Token: 0x04002A72 RID: 10866
		private static readonly IntPtr NativeFieldInfoPtr_loadError;

		// Token: 0x04002A73 RID: 10867
		private static readonly IntPtr NativeFieldInfoPtr_fileName;

		// Token: 0x04002A74 RID: 10868
		private static readonly IntPtr NativeFieldInfoPtr_loadException;

		// Token: 0x04002A75 RID: 10869
		private static readonly IntPtr NativeFieldInfoPtr_testFlight;

		// Token: 0x04002A76 RID: 10870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_PlayerSaveFile_Boolean_String_Exception_Boolean_0;

		// Token: 0x04002A77 RID: 10871
		private static readonly IntPtr NativeMethodInfoPtr_get_NullInfo_Public_Static_get_LoadedSaveDataInfo_0;
	}
}
