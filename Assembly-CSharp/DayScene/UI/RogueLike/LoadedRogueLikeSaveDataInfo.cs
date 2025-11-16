using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.UI.RogueLike
{
	// Token: 0x02000134 RID: 308
	public sealed class LoadedRogueLikeSaveDataInfo : ValueType
	{
		// Token: 0x060024FB RID: 9467 RVA: 0x0011A9BC File Offset: 0x00118BBC
		// Note: this type is marked as 'beforefieldinit'.
		static LoadedRogueLikeSaveDataInfo()
		{
			Il2CppClassPointerStore<LoadedRogueLikeSaveDataInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.UI.RogueLike", "LoadedRogueLikeSaveDataInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadedRogueLikeSaveDataInfo>.NativeClassPtr);
			LoadedRogueLikeSaveDataInfo.NativeFieldInfoPtr_FileData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedRogueLikeSaveDataInfo>.NativeClassPtr, "FileData");
			LoadedRogueLikeSaveDataInfo.NativeFieldInfoPtr_LoadException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedRogueLikeSaveDataInfo>.NativeClassPtr, "LoadException");
			LoadedRogueLikeSaveDataInfo.NativeFieldInfoPtr_FileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedRogueLikeSaveDataInfo>.NativeClassPtr, "FileName");
			LoadedRogueLikeSaveDataInfo.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RogueLikeSaveData_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedRogueLikeSaveDataInfo>.NativeClassPtr, 100669946);
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x0011AA3C File Offset: 0x00118C3C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 88380, RefRangeEnd = 88383, XrefRangeStart = 88377, XrefRangeEnd = 88380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadedRogueLikeSaveDataInfo(Nullable<RogueLikeSaveData> fileData, Exception loadException, string fileName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadedRogueLikeSaveDataInfo>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fileData));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loadException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fileName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedRogueLikeSaveDataInfo.NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RogueLikeSaveData_Exception_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x00015EC5 File Offset: 0x000140C5
		public LoadedRogueLikeSaveDataInfo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x00015ECE File Offset: 0x000140CE
		public LoadedRogueLikeSaveDataInfo() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadedRogueLikeSaveDataInfo>.NativeClassPtr))
		{
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060024FF RID: 9471 RVA: 0x0011AAB8 File Offset: 0x00118CB8
		// (set) Token: 0x06002500 RID: 9472 RVA: 0x00015EE0 File Offset: 0x000140E0
		public Nullable<RogueLikeSaveData> FileData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedRogueLikeSaveDataInfo.NativeFieldInfoPtr_FileData);
				return new Nullable<RogueLikeSaveData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RogueLikeSaveData>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedRogueLikeSaveDataInfo.NativeFieldInfoPtr_FileData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RogueLikeSaveData>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x0011AAE8 File Offset: 0x00118CE8
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x00015F0E File Offset: 0x0001410E
		public unsafe Exception LoadException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedRogueLikeSaveDataInfo.NativeFieldInfoPtr_LoadException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedRogueLikeSaveDataInfo.NativeFieldInfoPtr_LoadException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x06002503 RID: 9475 RVA: 0x0011AB18 File Offset: 0x00118D18
		// (set) Token: 0x06002504 RID: 9476 RVA: 0x00015F2D File Offset: 0x0001412D
		public unsafe string FileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedRogueLikeSaveDataInfo.NativeFieldInfoPtr_FileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedRogueLikeSaveDataInfo.NativeFieldInfoPtr_FileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040018C6 RID: 6342
		private static readonly IntPtr NativeFieldInfoPtr_FileData;

		// Token: 0x040018C7 RID: 6343
		private static readonly IntPtr NativeFieldInfoPtr_LoadException;

		// Token: 0x040018C8 RID: 6344
		private static readonly IntPtr NativeFieldInfoPtr_FileName;

		// Token: 0x040018C9 RID: 6345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Nullable_1_RogueLikeSaveData_Exception_String_0;
	}
}
