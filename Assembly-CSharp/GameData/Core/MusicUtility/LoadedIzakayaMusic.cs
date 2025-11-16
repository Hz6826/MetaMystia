using System;
using DEYU.Singletons;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace GameData.Core.MusicUtility
{
	// Token: 0x02000238 RID: 568
	public class LoadedIzakayaMusic : Singleton<LoadedIzakayaMusic>
	{
		// Token: 0x060046A6 RID: 18086 RVA: 0x00192CB8 File Offset: 0x00190EB8
		// Note: this type is marked as 'beforefieldinit'.
		static LoadedIzakayaMusic()
		{
			Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.MusicUtility", "LoadedIzakayaMusic");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr);
			LoadedIzakayaMusic.NativeFieldInfoPtr_musicIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr, "musicIndex");
			LoadedIzakayaMusic.NativeFieldInfoPtr__MusicProfile_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr, "<MusicProfile>k__BackingField");
			LoadedIzakayaMusic.NativeMethodInfoPtr_get_MusicProfile_Private_get_IzakayaMusicProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr, 100677319);
			LoadedIzakayaMusic.NativeMethodInfoPtr_set_MusicProfile_Private_set_Void_IzakayaMusicProfile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr, 100677320);
			LoadedIzakayaMusic.NativeMethodInfoPtr_GetEntry_Public_Il2CppStructArray_1_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr, 100677321);
			LoadedIzakayaMusic.NativeMethodInfoPtr_SetValue_Public_Void_IzakayaMusicProfile_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr, 100677322);
			LoadedIzakayaMusic.NativeMethodInfoPtr_GetPackages_Public_Il2CppReferenceArray_1_MusicChannelPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr, 100677323);
			LoadedIzakayaMusic.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr, 100677324);
			LoadedIzakayaMusic.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr, 100677325);
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x060046A7 RID: 18087 RVA: 0x00192D9C File Offset: 0x00190F9C
		// (set) Token: 0x060046A8 RID: 18088 RVA: 0x00192DDC File Offset: 0x00190FDC
		public unsafe IzakayaMusicProfile MusicProfile
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedIzakayaMusic.NativeMethodInfoPtr_get_MusicProfile_Private_get_IzakayaMusicProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IzakayaMusicProfile>(intPtr3) : null;
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 157625, RefRangeEnd = 157629, XrefRangeStart = 157625, XrefRangeEnd = 157629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedIzakayaMusic.NativeMethodInfoPtr_set_MusicProfile_Private_set_Void_IzakayaMusicProfile_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x00192E20 File Offset: 0x00191020
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186285, RefRangeEnd = 186286, XrefRangeStart = 186278, XrefRangeEnd = 186285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<long> GetEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedIzakayaMusic.NativeMethodInfoPtr_GetEntry_Public_Il2CppStructArray_1_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr3) : null;
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x00192E60 File Offset: 0x00191060
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186287, RefRangeEnd = 186288, XrefRangeStart = 186286, XrefRangeEnd = 186287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetValue(IzakayaMusicProfile loadedMusicPackages, int musicIndex = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(loadedMusicPackages);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedIzakayaMusic.NativeMethodInfoPtr_SetValue_Public_Void_IzakayaMusicProfile_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x00192EB0 File Offset: 0x001910B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186296, RefRangeEnd = 186297, XrefRangeStart = 186288, XrefRangeEnd = 186296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<IzakayaMusic.MusicChannelPackage> GetPackages()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedIzakayaMusic.NativeMethodInfoPtr_GetPackages_Public_Il2CppReferenceArray_1_MusicChannelPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IzakayaMusic.MusicChannelPackage>>(intPtr3) : null;
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x00192EF0 File Offset: 0x001910F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186297, XrefRangeEnd = 186307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LoadedIzakayaMusic.NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x00192F2C File Offset: 0x0019112C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186307, XrefRangeEnd = 186310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadedIzakayaMusic() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadedIzakayaMusic>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadedIzakayaMusic.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x00024B2E File Offset: 0x00022D2E
		public LoadedIzakayaMusic(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x060046AF RID: 18095 RVA: 0x00192F68 File Offset: 0x00191168
		// (set) Token: 0x060046B0 RID: 18096 RVA: 0x00024B37 File Offset: 0x00022D37
		public unsafe int musicIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedIzakayaMusic.NativeFieldInfoPtr_musicIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedIzakayaMusic.NativeFieldInfoPtr_musicIndex)) = value;
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x060046B1 RID: 18097 RVA: 0x00192F90 File Offset: 0x00191190
		// (set) Token: 0x060046B2 RID: 18098 RVA: 0x00024B52 File Offset: 0x00022D52
		public unsafe IzakayaMusicProfile _MusicProfile_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedIzakayaMusic.NativeFieldInfoPtr__MusicProfile_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IzakayaMusicProfile>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadedIzakayaMusic.NativeFieldInfoPtr__MusicProfile_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003067 RID: 12391
		private static readonly IntPtr NativeFieldInfoPtr_musicIndex;

		// Token: 0x04003068 RID: 12392
		private static readonly IntPtr NativeFieldInfoPtr__MusicProfile_k__BackingField;

		// Token: 0x04003069 RID: 12393
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicProfile_Private_get_IzakayaMusicProfile_0;

		// Token: 0x0400306A RID: 12394
		private static readonly IntPtr NativeMethodInfoPtr_set_MusicProfile_Private_set_Void_IzakayaMusicProfile_0;

		// Token: 0x0400306B RID: 12395
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_Il2CppStructArray_1_Int64_0;

		// Token: 0x0400306C RID: 12396
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Void_IzakayaMusicProfile_Int32_0;

		// Token: 0x0400306D RID: 12397
		private static readonly IntPtr NativeMethodInfoPtr_GetPackages_Public_Il2CppReferenceArray_1_MusicChannelPackage_0;

		// Token: 0x0400306E RID: 12398
		private static readonly IntPtr NativeMethodInfoPtr_OnDispose_Protected_Virtual_Void_0;

		// Token: 0x0400306F RID: 12399
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
