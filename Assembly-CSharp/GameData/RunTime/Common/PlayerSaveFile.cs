using System;
using System.Runtime.InteropServices;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Story;
using UnityEngine;

namespace GameData.RunTime.Common
{
	// Token: 0x0200022B RID: 555
	[Serializable]
	public sealed class PlayerSaveFile : ValueType
	{
		// Token: 0x060041C7 RID: 16839 RVA: 0x0017FD4C File Offset: 0x0017DF4C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerSaveFile()
		{
			Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.RunTime.Common", "PlayerSaveFile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr);
			PlayerSaveFile.NativeFieldInfoPtr_CORE_DATA_DLC_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "CORE_DATA_DLC_KEY");
			PlayerSaveFile.NativeFieldInfoPtr_DLC1_DATA_DLC_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLC1_DATA_DLC_KEY");
			PlayerSaveFile.NativeFieldInfoPtr_DLC2_DATA_DLC_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLC2_DATA_DLC_KEY");
			PlayerSaveFile.NativeFieldInfoPtr_DLC3_DATA_DLC_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLC3_DATA_DLC_KEY");
			PlayerSaveFile.NativeFieldInfoPtr_DLCMUSIC_DATA_DLC_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLCMUSIC_DATA_DLC_KEY");
			PlayerSaveFile.NativeFieldInfoPtr_DLC4_DATA_DLC_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLC4_DATA_DLC_KEY");
			PlayerSaveFile.NativeFieldInfoPtr_DLC5_DATA_DLC_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLC5_DATA_DLC_KEY");
			PlayerSaveFile.NativeFieldInfoPtr_UNDEF_DATA_DLC_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "UNDEF_DATA_DLC_KEY");
			PlayerSaveFile.NativeFieldInfoPtr_DEFAULT_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DEFAULT_KEY");
			PlayerSaveFile.NativeFieldInfoPtr_DLCKeyComparer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLCKeyComparer");
			PlayerSaveFile.NativeFieldInfoPtr_fileVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "fileVersion");
			PlayerSaveFile.NativeFieldInfoPtr_realSaveTimeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "realSaveTimeCode");
			PlayerSaveFile.NativeFieldInfoPtr_storagePartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "storagePartial");
			PlayerSaveFile.NativeFieldInfoPtr_allActivatedDLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "allActivatedDLC");
			PlayerSaveFile.NativeFieldInfoPtr_storagePartialDLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "storagePartialDLC");
			PlayerSaveFile.NativeFieldInfoPtr_albumPartialDLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "albumPartialDLC");
			PlayerSaveFile.NativeFieldInfoPtr_dayScenePartialDLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "dayScenePartialDLC");
			PlayerSaveFile.NativeFieldInfoPtr_schedulerPartialDLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "schedulerPartialDLC");
			PlayerSaveFile.NativeFieldInfoPtr_albumPartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "albumPartial");
			PlayerSaveFile.NativeFieldInfoPtr_dayScenePartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "dayScenePartial");
			PlayerSaveFile.NativeFieldInfoPtr_playerPartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "playerPartial");
			PlayerSaveFile.NativeFieldInfoPtr_schedulerPartial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "schedulerPartial");
			PlayerSaveFile.NativeMethodInfoPtr__ctor_Public_Void_String_DateTime_RunTimePlayerSaveDataPartial_RunTimeStorageSaveDataPartial_RunTimeAlbumSaveDataPartial_RunTimeDaySceneSaveDataPartial_RunTimeSchedulerSaveDataPartial_Dictionary_2_String_RunTimeStorageSaveDataPartial_Dictionary_2_String_DLCAlbumSaveData_Dictionary_2_String_DLCDaySceneSaveData_Dictionary_2_String_DLCSchedulerSaveData_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, 100675771);
			PlayerSaveFile.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, 100675772);
			PlayerSaveFile.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_PlayerSaveFile_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, 100675773);
		}

		// Token: 0x060041C8 RID: 16840 RVA: 0x0017FF70 File Offset: 0x0017E170
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 166305, RefRangeEnd = 166308, XrefRangeStart = 166140, XrefRangeEnd = 166305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSaveFile(string fileVersion, DateTime saveTime, PlayerSaveFile.RunTimePlayerSaveDataPartial playerPartial, PlayerSaveFile.RunTimeStorageSaveDataPartial storagePartial, PlayerSaveFile.RunTimeAlbumSaveDataPartial albumPartial, PlayerSaveFile.RunTimeDaySceneSaveDataPartial dayScenePartial, PlayerSaveFile.RunTimeSchedulerSaveDataPartial schedulerPartial, Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial> notLoadedRunTimeStorageSaveDataPartial, Dictionary<string, PlayerSaveFile.DLCAlbumSaveData> notLoadedDLCAlbumSaveData, Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> notLoadedDLCDaySceneSaveData, Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData> notLoadedDLCSchedulerSaveData, bool bypassDLCMapping) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(fileVersion);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref saveTime;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(playerPartial));
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(storagePartial));
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(albumPartial));
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(dayScenePartial));
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(schedulerPartial));
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notLoadedRunTimeStorageSaveDataPartial);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notLoadedDLCAlbumSaveData);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notLoadedDLCDaySceneSaveData);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(notLoadedDLCSchedulerSaveData);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bypassDLCMapping;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.NativeMethodInfoPtr__ctor_Public_Void_String_DateTime_RunTimePlayerSaveDataPartial_RunTimeStorageSaveDataPartial_RunTimeAlbumSaveDataPartial_RunTimeDaySceneSaveDataPartial_RunTimeSchedulerSaveDataPartial_Dictionary_2_String_RunTimeStorageSaveDataPartial_Dictionary_2_String_DLCAlbumSaveData_Dictionary_2_String_DLCDaySceneSaveData_Dictionary_2_String_DLCSchedulerSaveData_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060041C9 RID: 16841 RVA: 0x001800A4 File Offset: 0x0017E2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166308, XrefRangeEnd = 166361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060041CA RID: 16842 RVA: 0x001800E0 File Offset: 0x0017E2E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166363, RefRangeEnd = 166364, XrefRangeStart = 166361, XrefRangeEnd = 166363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerSaveFile Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_PlayerSaveFile_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new PlayerSaveFile(pointer);
		}

		// Token: 0x060041CB RID: 16843 RVA: 0x000238E6 File Offset: 0x00021AE6
		public PlayerSaveFile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x060041CC RID: 16844 RVA: 0x000238EF File Offset: 0x00021AEF
		public PlayerSaveFile() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr))
		{
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x060041CD RID: 16845 RVA: 0x0018011C File Offset: 0x0017E31C
		// (set) Token: 0x060041CE RID: 16846 RVA: 0x00023901 File Offset: 0x00021B01
		public unsafe static string CORE_DATA_DLC_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_CORE_DATA_DLC_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_CORE_DATA_DLC_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x060041CF RID: 16847 RVA: 0x0018013C File Offset: 0x0017E33C
		// (set) Token: 0x060041D0 RID: 16848 RVA: 0x00023913 File Offset: 0x00021B13
		public unsafe static string DLC1_DATA_DLC_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_DLC1_DATA_DLC_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_DLC1_DATA_DLC_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x060041D1 RID: 16849 RVA: 0x0018015C File Offset: 0x0017E35C
		// (set) Token: 0x060041D2 RID: 16850 RVA: 0x00023925 File Offset: 0x00021B25
		public unsafe static string DLC2_DATA_DLC_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_DLC2_DATA_DLC_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_DLC2_DATA_DLC_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x060041D3 RID: 16851 RVA: 0x0018017C File Offset: 0x0017E37C
		// (set) Token: 0x060041D4 RID: 16852 RVA: 0x00023937 File Offset: 0x00021B37
		public unsafe static string DLC3_DATA_DLC_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_DLC3_DATA_DLC_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_DLC3_DATA_DLC_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x060041D5 RID: 16853 RVA: 0x0018019C File Offset: 0x0017E39C
		// (set) Token: 0x060041D6 RID: 16854 RVA: 0x00023949 File Offset: 0x00021B49
		public unsafe static string DLCMUSIC_DATA_DLC_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_DLCMUSIC_DATA_DLC_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_DLCMUSIC_DATA_DLC_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x001801BC File Offset: 0x0017E3BC
		// (set) Token: 0x060041D8 RID: 16856 RVA: 0x0002395B File Offset: 0x00021B5B
		public unsafe static string DLC4_DATA_DLC_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_DLC4_DATA_DLC_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_DLC4_DATA_DLC_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x001801DC File Offset: 0x0017E3DC
		// (set) Token: 0x060041DA RID: 16858 RVA: 0x0002396D File Offset: 0x00021B6D
		public unsafe static string DLC5_DATA_DLC_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_DLC5_DATA_DLC_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_DLC5_DATA_DLC_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x001801FC File Offset: 0x0017E3FC
		// (set) Token: 0x060041DC RID: 16860 RVA: 0x0002397F File Offset: 0x00021B7F
		public unsafe static string UNDEF_DATA_DLC_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_UNDEF_DATA_DLC_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_UNDEF_DATA_DLC_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x0018021C File Offset: 0x0017E41C
		// (set) Token: 0x060041DE RID: 16862 RVA: 0x00023991 File Offset: 0x00021B91
		public unsafe static string DEFAULT_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_DEFAULT_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_DEFAULT_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x060041DF RID: 16863 RVA: 0x0018023C File Offset: 0x0017E43C
		// (set) Token: 0x060041E0 RID: 16864 RVA: 0x000239A3 File Offset: 0x00021BA3
		public unsafe static PlayerSaveFile.CustomDLCKeyComparer DLCKeyComparer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.NativeFieldInfoPtr_DLCKeyComparer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSaveFile.CustomDLCKeyComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.NativeFieldInfoPtr_DLCKeyComparer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x060041E1 RID: 16865 RVA: 0x00180264 File Offset: 0x0017E464
		// (set) Token: 0x060041E2 RID: 16866 RVA: 0x000239B5 File Offset: 0x00021BB5
		public unsafe string fileVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_fileVersion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_fileVersion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x060041E3 RID: 16867 RVA: 0x0018028C File Offset: 0x0017E48C
		// (set) Token: 0x060041E4 RID: 16868 RVA: 0x000239D4 File Offset: 0x00021BD4
		public unsafe DateTime realSaveTimeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_realSaveTimeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_realSaveTimeCode)) = value;
			}
		}

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x060041E5 RID: 16869 RVA: 0x001802B4 File Offset: 0x0017E4B4
		// (set) Token: 0x060041E6 RID: 16870 RVA: 0x000239EF File Offset: 0x00021BEF
		public PlayerSaveFile.RunTimeStorageSaveDataPartial storagePartial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_storagePartial);
				return new PlayerSaveFile.RunTimeStorageSaveDataPartial(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_storagePartial), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x001802E4 File Offset: 0x0017E4E4
		// (set) Token: 0x060041E8 RID: 16872 RVA: 0x00023A1D File Offset: 0x00021C1D
		public unsafe List<string> allActivatedDLC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_allActivatedDLC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_allActivatedDLC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x060041E9 RID: 16873 RVA: 0x00180314 File Offset: 0x0017E514
		// (set) Token: 0x060041EA RID: 16874 RVA: 0x00023A3C File Offset: 0x00021C3C
		public unsafe Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial> storagePartialDLC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_storagePartialDLC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_storagePartialDLC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x060041EB RID: 16875 RVA: 0x00180344 File Offset: 0x0017E544
		// (set) Token: 0x060041EC RID: 16876 RVA: 0x00023A5B File Offset: 0x00021C5B
		public unsafe Dictionary<string, PlayerSaveFile.DLCAlbumSaveData> albumPartialDLC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_albumPartialDLC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PlayerSaveFile.DLCAlbumSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_albumPartialDLC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001639 RID: 5689
		// (get) Token: 0x060041ED RID: 16877 RVA: 0x00180374 File Offset: 0x0017E574
		// (set) Token: 0x060041EE RID: 16878 RVA: 0x00023A7A File Offset: 0x00021C7A
		public unsafe Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> dayScenePartialDLC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_dayScenePartialDLC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_dayScenePartialDLC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163A RID: 5690
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x001803A4 File Offset: 0x0017E5A4
		// (set) Token: 0x060041F0 RID: 16880 RVA: 0x00023A99 File Offset: 0x00021C99
		public unsafe Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData> schedulerPartialDLC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_schedulerPartialDLC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_schedulerPartialDLC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700163B RID: 5691
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x001803D4 File Offset: 0x0017E5D4
		// (set) Token: 0x060041F2 RID: 16882 RVA: 0x00023AB8 File Offset: 0x00021CB8
		public PlayerSaveFile.RunTimeAlbumSaveDataPartial albumPartial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_albumPartial);
				return new PlayerSaveFile.RunTimeAlbumSaveDataPartial(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_albumPartial), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700163C RID: 5692
		// (get) Token: 0x060041F3 RID: 16883 RVA: 0x00180404 File Offset: 0x0017E604
		// (set) Token: 0x060041F4 RID: 16884 RVA: 0x00023AE6 File Offset: 0x00021CE6
		public PlayerSaveFile.RunTimeDaySceneSaveDataPartial dayScenePartial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_dayScenePartial);
				return new PlayerSaveFile.RunTimeDaySceneSaveDataPartial(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_dayScenePartial), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700163D RID: 5693
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x00180434 File Offset: 0x0017E634
		// (set) Token: 0x060041F6 RID: 16886 RVA: 0x00023B14 File Offset: 0x00021D14
		public PlayerSaveFile.RunTimePlayerSaveDataPartial playerPartial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_playerPartial);
				return new PlayerSaveFile.RunTimePlayerSaveDataPartial(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_playerPartial), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700163E RID: 5694
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x00180464 File Offset: 0x0017E664
		// (set) Token: 0x060041F8 RID: 16888 RVA: 0x00023B42 File Offset: 0x00021D42
		public PlayerSaveFile.RunTimeSchedulerSaveDataPartial schedulerPartial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_schedulerPartial);
				return new PlayerSaveFile.RunTimeSchedulerSaveDataPartial(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.NativeFieldInfoPtr_schedulerPartial), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04002C5A RID: 11354
		private static readonly IntPtr NativeFieldInfoPtr_CORE_DATA_DLC_KEY;

		// Token: 0x04002C5B RID: 11355
		private static readonly IntPtr NativeFieldInfoPtr_DLC1_DATA_DLC_KEY;

		// Token: 0x04002C5C RID: 11356
		private static readonly IntPtr NativeFieldInfoPtr_DLC2_DATA_DLC_KEY;

		// Token: 0x04002C5D RID: 11357
		private static readonly IntPtr NativeFieldInfoPtr_DLC3_DATA_DLC_KEY;

		// Token: 0x04002C5E RID: 11358
		private static readonly IntPtr NativeFieldInfoPtr_DLCMUSIC_DATA_DLC_KEY;

		// Token: 0x04002C5F RID: 11359
		private static readonly IntPtr NativeFieldInfoPtr_DLC4_DATA_DLC_KEY;

		// Token: 0x04002C60 RID: 11360
		private static readonly IntPtr NativeFieldInfoPtr_DLC5_DATA_DLC_KEY;

		// Token: 0x04002C61 RID: 11361
		private static readonly IntPtr NativeFieldInfoPtr_UNDEF_DATA_DLC_KEY;

		// Token: 0x04002C62 RID: 11362
		private static readonly IntPtr NativeFieldInfoPtr_DEFAULT_KEY;

		// Token: 0x04002C63 RID: 11363
		private static readonly IntPtr NativeFieldInfoPtr_DLCKeyComparer;

		// Token: 0x04002C64 RID: 11364
		private static readonly IntPtr NativeFieldInfoPtr_fileVersion;

		// Token: 0x04002C65 RID: 11365
		private static readonly IntPtr NativeFieldInfoPtr_realSaveTimeCode;

		// Token: 0x04002C66 RID: 11366
		private static readonly IntPtr NativeFieldInfoPtr_storagePartial;

		// Token: 0x04002C67 RID: 11367
		private static readonly IntPtr NativeFieldInfoPtr_allActivatedDLC;

		// Token: 0x04002C68 RID: 11368
		private static readonly IntPtr NativeFieldInfoPtr_storagePartialDLC;

		// Token: 0x04002C69 RID: 11369
		private static readonly IntPtr NativeFieldInfoPtr_albumPartialDLC;

		// Token: 0x04002C6A RID: 11370
		private static readonly IntPtr NativeFieldInfoPtr_dayScenePartialDLC;

		// Token: 0x04002C6B RID: 11371
		private static readonly IntPtr NativeFieldInfoPtr_schedulerPartialDLC;

		// Token: 0x04002C6C RID: 11372
		private static readonly IntPtr NativeFieldInfoPtr_albumPartial;

		// Token: 0x04002C6D RID: 11373
		private static readonly IntPtr NativeFieldInfoPtr_dayScenePartial;

		// Token: 0x04002C6E RID: 11374
		private static readonly IntPtr NativeFieldInfoPtr_playerPartial;

		// Token: 0x04002C6F RID: 11375
		private static readonly IntPtr NativeFieldInfoPtr_schedulerPartial;

		// Token: 0x04002C70 RID: 11376
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_DateTime_RunTimePlayerSaveDataPartial_RunTimeStorageSaveDataPartial_RunTimeAlbumSaveDataPartial_RunTimeDaySceneSaveDataPartial_RunTimeSchedulerSaveDataPartial_Dictionary_2_String_RunTimeStorageSaveDataPartial_Dictionary_2_String_DLCAlbumSaveData_Dictionary_2_String_DLCDaySceneSaveData_Dictionary_2_String_DLCSchedulerSaveData_Boolean_0;

		// Token: 0x04002C71 RID: 11377
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04002C72 RID: 11378
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_PlayerSaveFile_0;

		// Token: 0x02000A19 RID: 2585
		public enum DefaultProp
		{
			// Token: 0x04007E0A RID: 32266
			Ingredients_SeaFood,
			// Token: 0x04007E0B RID: 32267
			Recipes,
			// Token: 0x04007E0C RID: 32268
			Beverages,
			// Token: 0x04007E0D RID: 32269
			Cookers,
			// Token: 0x04007E0E RID: 32270
			Ingredients_Meat,
			// Token: 0x04007E0F RID: 32271
			Ingredients_Vegetable,
			// Token: 0x04007E10 RID: 32272
			Ingredients_Other
		}

		// Token: 0x02000A1A RID: 2586
		public class IExtractable<T> : Il2CppObjectBase
		{
			// Token: 0x0600C3E1 RID: 50145 RVA: 0x0030C144 File Offset: 0x0030A344
			// Note: this type is marked as 'beforefieldinit'.
			static IExtractable()
			{
				Il2CppClassPointerStore<PlayerSaveFile.IExtractable<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "IExtractable`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				PlayerSaveFile.IExtractable<T>.NativeMethodInfoPtr_ExtractValid_Public_Abstract_Virtual_New_Void_byref_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.IExtractable<T>>.NativeClassPtr, 100675775);
			}

			// Token: 0x0600C3E2 RID: 50146 RVA: 0x0030C1B4 File Offset: 0x0030A3B4
			[CallerCount(0)]
			public unsafe virtual void ExtractValid(out T valid, out T invalid)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				IntPtr intPtr2;
				if (!typeof(T).IsValueType)
				{
					intPtr = 0;
					intPtr2 = &intPtr;
				}
				else
				{
					intPtr2 = ref valid;
				}
				ptr2 = intPtr2;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr3;
				IntPtr intPtr4;
				if (!typeof(T).IsValueType)
				{
					intPtr3 = 0;
					intPtr4 = &intPtr3;
				}
				else
				{
					intPtr4 = ref invalid;
				}
				ptr3 = intPtr4;
				IntPtr intPtr6;
				IntPtr intPtr5 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerSaveFile.IExtractable<T>.NativeMethodInfoPtr_ExtractValid_Public_Abstract_Virtual_New_Void_byref_T_byref_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr6);
				Il2CppException.RaiseExceptionIfNecessary(intPtr6);
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr7 = intPtr;
					valid = ((intPtr7 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr7, false, false));
				}
				if (!typeof(T).IsValueType)
				{
					IntPtr intPtr8 = intPtr3;
					invalid = ((intPtr8 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr8, false, false));
				}
			}

			// Token: 0x0600C3E3 RID: 50147 RVA: 0x000696B9 File Offset: 0x000678B9
			public IExtractable(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x04007E11 RID: 32273
			private static readonly IntPtr NativeMethodInfoPtr_ExtractValid_Public_Abstract_Virtual_New_Void_byref_T_byref_T_0;
		}

		// Token: 0x02000A1B RID: 2587
		public class CustomDLCKeyComparer : Il2CppSystem.Object
		{
			// Token: 0x0600C3E4 RID: 50148 RVA: 0x0030C28C File Offset: 0x0030A48C
			// Note: this type is marked as 'beforefieldinit'.
			static CustomDLCKeyComparer()
			{
				Il2CppClassPointerStore<PlayerSaveFile.CustomDLCKeyComparer>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "CustomDLCKeyComparer");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.CustomDLCKeyComparer>.NativeClassPtr);
				PlayerSaveFile.CustomDLCKeyComparer.NativeFieldInfoPtr_m_OrdererdDLCKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.CustomDLCKeyComparer>.NativeClassPtr, "m_OrdererdDLCKey");
				PlayerSaveFile.CustomDLCKeyComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.CustomDLCKeyComparer>.NativeClassPtr, 100675776);
				PlayerSaveFile.CustomDLCKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.CustomDLCKeyComparer>.NativeClassPtr, 100675777);
			}

			// Token: 0x0600C3E5 RID: 50149 RVA: 0x0030C2F4 File Offset: 0x0030A4F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163290, XrefRangeEnd = 163296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual int Compare(string x, string y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.CustomDLCKeyComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C3E6 RID: 50150 RVA: 0x0030C354 File Offset: 0x0030A554
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 163366, RefRangeEnd = 163367, XrefRangeStart = 163296, XrefRangeEnd = 163366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CustomDLCKeyComparer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.CustomDLCKeyComparer>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.CustomDLCKeyComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3E7 RID: 50151 RVA: 0x000696C2 File Offset: 0x000678C2
			public CustomDLCKeyComparer(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FAD RID: 16301
			// (get) Token: 0x0600C3E8 RID: 50152 RVA: 0x0030C390 File Offset: 0x0030A590
			// (set) Token: 0x0600C3E9 RID: 50153 RVA: 0x000696CB File Offset: 0x000678CB
			public unsafe Il2CppStringArray m_OrdererdDLCKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.CustomDLCKeyComparer.NativeFieldInfoPtr_m_OrdererdDLCKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.CustomDLCKeyComparer.NativeFieldInfoPtr_m_OrdererdDLCKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007E12 RID: 32274
			private static readonly IntPtr NativeFieldInfoPtr_m_OrdererdDLCKey;

			// Token: 0x04007E13 RID: 32275
			private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_String_String_0;

			// Token: 0x04007E14 RID: 32276
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A1C RID: 2588
		public sealed class DLCAlbumSaveData : ValueType
		{
			// Token: 0x0600C3EA RID: 50154 RVA: 0x0030C3C0 File Offset: 0x0030A5C0
			// Note: this type is marked as 'beforefieldinit'.
			static DLCAlbumSaveData()
			{
				Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLCAlbumSaveData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr);
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_nGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "nGuests");
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "foods");
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "bevs");
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "ings");
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_cookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "cookers");
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "items");
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_badges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "badges");
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_specialSkinSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "specialSkinSelection");
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_usedDecorations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "usedDecorations");
				PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_playerSkinSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "playerSkinSelection");
				PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_Dictionary_2_Int32_SpecialGuestRunTimeData_List_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, 100675778);
				PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr_Merge_Public_Static_DLCAlbumSaveData_DLCAlbumSaveData_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, 100675779);
				PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr_EnusreFieldNotNull_Private_Static_Void_byref_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, 100675780);
				PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr_ExtractValid_Public_Virtual_Final_New_Void_byref_DLCAlbumSaveData_byref_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, 100675781);
				PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, 100675782);
			}

			// Token: 0x0600C3EB RID: 50155 RVA: 0x0030C518 File Offset: 0x0030A718
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 163414, RefRangeEnd = 163419, XrefRangeStart = 163382, XrefRangeEnd = 163414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLCAlbumSaveData(List<int> nGuests, List<int> foods, List<int> bevs, List<int> ings, List<int> cookers, List<int> items, List<int> badges, Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> specialSkinSelection, List<int> usedDecorations, int playerSkinSelection) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nGuests);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foods);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bevs);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ings);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookers);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(badges);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialSkinSelection);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(usedDecorations);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerSkinSelection;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_Dictionary_2_Int32_SpecialGuestRunTimeData_List_1_Int32_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3EC RID: 50156 RVA: 0x0030C610 File Offset: 0x0030A810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163419, XrefRangeEnd = 163498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PlayerSaveFile.DLCAlbumSaveData Merge(PlayerSaveFile.DLCAlbumSaveData current, PlayerSaveFile.DLCAlbumSaveData next)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(current));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(next));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr_Merge_Public_Static_DLCAlbumSaveData_DLCAlbumSaveData_DLCAlbumSaveData_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.DLCAlbumSaveData(pointer);
			}

			// Token: 0x0600C3ED RID: 50157 RVA: 0x0030C668 File Offset: 0x0030A868
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 163518, RefRangeEnd = 163521, XrefRangeStart = 163498, XrefRangeEnd = 163518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void EnusreFieldNotNull(ref PlayerSaveFile.DLCAlbumSaveData data)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr_EnusreFieldNotNull_Private_Static_Void_byref_DLCAlbumSaveData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C3EE RID: 50158 RVA: 0x0030C6A0 File Offset: 0x0030A8A0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 163593, RefRangeEnd = 163594, XrefRangeStart = 163521, XrefRangeEnd = 163593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ExtractValid(out PlayerSaveFile.DLCAlbumSaveData valid, out PlayerSaveFile.DLCAlbumSaveData invalid)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr_ExtractValid_Public_Virtual_Final_New_Void_byref_DLCAlbumSaveData_byref_DLCAlbumSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				valid = ((intPtr5 == 0) ? null : new PlayerSaveFile.DLCAlbumSaveData(intPtr5));
				IntPtr intPtr6 = intPtr2;
				invalid = ((intPtr6 == 0) ? null : new PlayerSaveFile.DLCAlbumSaveData(intPtr6));
			}

			// Token: 0x0600C3EF RID: 50159 RVA: 0x0030C71C File Offset: 0x0030A91C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 163595, RefRangeEnd = 163596, XrefRangeStart = 163594, XrefRangeEnd = 163595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveFile.DLCAlbumSaveData Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCAlbumSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_DLCAlbumSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.DLCAlbumSaveData(pointer);
			}

			// Token: 0x0600C3F0 RID: 50160 RVA: 0x000696EA File Offset: 0x000678EA
			public DLCAlbumSaveData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C3F1 RID: 50161 RVA: 0x000696F3 File Offset: 0x000678F3
			public DLCAlbumSaveData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr))
			{
			}

			// Token: 0x17003FAE RID: 16302
			// (get) Token: 0x0600C3F2 RID: 50162 RVA: 0x0030C758 File Offset: 0x0030A958
			// (set) Token: 0x0600C3F3 RID: 50163 RVA: 0x00069705 File Offset: 0x00067905
			public unsafe List<int> nGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_nGuests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_nGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FAF RID: 16303
			// (get) Token: 0x0600C3F4 RID: 50164 RVA: 0x0030C788 File Offset: 0x0030A988
			// (set) Token: 0x0600C3F5 RID: 50165 RVA: 0x00069724 File Offset: 0x00067924
			public unsafe List<int> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB0 RID: 16304
			// (get) Token: 0x0600C3F6 RID: 50166 RVA: 0x0030C7B8 File Offset: 0x0030A9B8
			// (set) Token: 0x0600C3F7 RID: 50167 RVA: 0x00069743 File Offset: 0x00067943
			public unsafe List<int> bevs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_bevs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB1 RID: 16305
			// (get) Token: 0x0600C3F8 RID: 50168 RVA: 0x0030C7E8 File Offset: 0x0030A9E8
			// (set) Token: 0x0600C3F9 RID: 50169 RVA: 0x00069762 File Offset: 0x00067962
			public unsafe List<int> ings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_ings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB2 RID: 16306
			// (get) Token: 0x0600C3FA RID: 50170 RVA: 0x0030C818 File Offset: 0x0030AA18
			// (set) Token: 0x0600C3FB RID: 50171 RVA: 0x00069781 File Offset: 0x00067981
			public unsafe List<int> cookers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_cookers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_cookers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB3 RID: 16307
			// (get) Token: 0x0600C3FC RID: 50172 RVA: 0x0030C848 File Offset: 0x0030AA48
			// (set) Token: 0x0600C3FD RID: 50173 RVA: 0x000697A0 File Offset: 0x000679A0
			public unsafe List<int> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB4 RID: 16308
			// (get) Token: 0x0600C3FE RID: 50174 RVA: 0x0030C878 File Offset: 0x0030AA78
			// (set) Token: 0x0600C3FF RID: 50175 RVA: 0x000697BF File Offset: 0x000679BF
			public unsafe List<int> badges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_badges);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_badges), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB5 RID: 16309
			// (get) Token: 0x0600C400 RID: 50176 RVA: 0x0030C8A8 File Offset: 0x0030AAA8
			// (set) Token: 0x0600C401 RID: 50177 RVA: 0x000697DE File Offset: 0x000679DE
			public unsafe Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> specialSkinSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_specialSkinSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_specialSkinSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB6 RID: 16310
			// (get) Token: 0x0600C402 RID: 50178 RVA: 0x0030C8D8 File Offset: 0x0030AAD8
			// (set) Token: 0x0600C403 RID: 50179 RVA: 0x000697FD File Offset: 0x000679FD
			public unsafe List<int> usedDecorations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_usedDecorations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_usedDecorations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB7 RID: 16311
			// (get) Token: 0x0600C404 RID: 50180 RVA: 0x0030C908 File Offset: 0x0030AB08
			// (set) Token: 0x0600C405 RID: 50181 RVA: 0x0006981C File Offset: 0x00067A1C
			public unsafe int playerSkinSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_playerSkinSelection);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCAlbumSaveData.NativeFieldInfoPtr_playerSkinSelection)) = value;
				}
			}

			// Token: 0x04007E15 RID: 32277
			private static readonly IntPtr NativeFieldInfoPtr_nGuests;

			// Token: 0x04007E16 RID: 32278
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x04007E17 RID: 32279
			private static readonly IntPtr NativeFieldInfoPtr_bevs;

			// Token: 0x04007E18 RID: 32280
			private static readonly IntPtr NativeFieldInfoPtr_ings;

			// Token: 0x04007E19 RID: 32281
			private static readonly IntPtr NativeFieldInfoPtr_cookers;

			// Token: 0x04007E1A RID: 32282
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x04007E1B RID: 32283
			private static readonly IntPtr NativeFieldInfoPtr_badges;

			// Token: 0x04007E1C RID: 32284
			private static readonly IntPtr NativeFieldInfoPtr_specialSkinSelection;

			// Token: 0x04007E1D RID: 32285
			private static readonly IntPtr NativeFieldInfoPtr_usedDecorations;

			// Token: 0x04007E1E RID: 32286
			private static readonly IntPtr NativeFieldInfoPtr_playerSkinSelection;

			// Token: 0x04007E1F RID: 32287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_Dictionary_2_Int32_SpecialGuestRunTimeData_List_1_Int32_Int32_0;

			// Token: 0x04007E20 RID: 32288
			private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Static_DLCAlbumSaveData_DLCAlbumSaveData_DLCAlbumSaveData_0;

			// Token: 0x04007E21 RID: 32289
			private static readonly IntPtr NativeMethodInfoPtr_EnusreFieldNotNull_Private_Static_Void_byref_DLCAlbumSaveData_0;

			// Token: 0x04007E22 RID: 32290
			private static readonly IntPtr NativeMethodInfoPtr_ExtractValid_Public_Virtual_Final_New_Void_byref_DLCAlbumSaveData_byref_DLCAlbumSaveData_0;

			// Token: 0x04007E23 RID: 32291
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_DLCAlbumSaveData_0;

			// Token: 0x02001003 RID: 4099
			[ObfuscatedName("GameData.RunTime.Common.PlayerSaveFile+DLCAlbumSaveData+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x060118DB RID: 71899 RVA: 0x00407324 File Offset: 0x00405524
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData.__c>.NativeClassPtr);
					PlayerSaveFile.DLCAlbumSaveData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData.__c>.NativeClassPtr, "<>9");
					PlayerSaveFile.DLCAlbumSaveData.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData.__c>.NativeClassPtr, "<>9__11_0");
					PlayerSaveFile.DLCAlbumSaveData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData.__c>.NativeClassPtr, 100675784);
					PlayerSaveFile.DLCAlbumSaveData.__c.NativeMethodInfoPtr__Merge_b__11_0_Internal_SpecialGuestRunTimeData_SpecialGuestRunTimeData_SpecialGuestRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData.__c>.NativeClassPtr, 100675785);
				}

				// Token: 0x060118DC RID: 71900 RVA: 0x004073A0 File Offset: 0x004055A0
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.DLCAlbumSaveData.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCAlbumSaveData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060118DD RID: 71901 RVA: 0x004073DC File Offset: 0x004055DC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163367, XrefRangeEnd = 163382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe RunTimeAlbum.SpecialGuestRunTimeData _Merge_b__11_0(RunTimeAlbum.SpecialGuestRunTimeData prev, RunTimeAlbum.SpecialGuestRunTimeData next)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prev);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCAlbumSaveData.__c.NativeMethodInfoPtr__Merge_b__11_0_Internal_SpecialGuestRunTimeData_SpecialGuestRunTimeData_SpecialGuestRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<RunTimeAlbum.SpecialGuestRunTimeData>(intPtr3) : null;
				}

				// Token: 0x060118DE RID: 71902 RVA: 0x00098C2C File Offset: 0x00096E2C
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B4E RID: 23374
				// (get) Token: 0x060118DF RID: 71903 RVA: 0x00407440 File Offset: 0x00405640
				// (set) Token: 0x060118E0 RID: 71904 RVA: 0x00098C35 File Offset: 0x00096E35
				public unsafe static PlayerSaveFile.DLCAlbumSaveData.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.DLCAlbumSaveData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSaveFile.DLCAlbumSaveData.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.DLCAlbumSaveData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B4F RID: 23375
				// (get) Token: 0x060118E1 RID: 71905 RVA: 0x00407468 File Offset: 0x00405668
				// (set) Token: 0x060118E2 RID: 71906 RVA: 0x00098C47 File Offset: 0x00096E47
				public unsafe static Func<RunTimeAlbum.SpecialGuestRunTimeData, RunTimeAlbum.SpecialGuestRunTimeData, RunTimeAlbum.SpecialGuestRunTimeData> __9__11_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.DLCAlbumSaveData.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RunTimeAlbum.SpecialGuestRunTimeData, RunTimeAlbum.SpecialGuestRunTimeData, RunTimeAlbum.SpecialGuestRunTimeData>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.DLCAlbumSaveData.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B170 RID: 45424
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B171 RID: 45425
				private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

				// Token: 0x0400B172 RID: 45426
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B173 RID: 45427
				private static readonly IntPtr NativeMethodInfoPtr__Merge_b__11_0_Internal_SpecialGuestRunTimeData_SpecialGuestRunTimeData_SpecialGuestRunTimeData_0;
			}
		}

		// Token: 0x02000A1D RID: 2589
		public sealed class DLCDaySceneSaveData : ValueType
		{
			// Token: 0x0600C406 RID: 50182 RVA: 0x0030C930 File Offset: 0x0030AB30
			// Note: this type is marked as 'beforefieldinit'.
			static DLCDaySceneSaveData()
			{
				Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLCDaySceneSaveData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr);
				PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_alltrackedCollectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, "alltrackedCollectables");
				PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_alltrackedMerchants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, "alltrackedMerchants");
				PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_allTrackedNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, "allTrackedNPCs");
				PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_daySceneMapStatusData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, "daySceneMapStatusData");
				PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_kourindouStaticMerchandiseNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, "kourindouStaticMerchandiseNum");
				PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_flandreHomeFurnitureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, "flandreHomeFurnitureData");
				PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrackedCollectable_Il2CppReferenceArray_1_TrackedMerchant_Dictionary_2_String_Dictionary_2_String_TrackedNPC_Dictionary_2_String_Boolean_Il2CppReferenceArray_1_ValueTuple_2_String_Int32_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, 100675786);
				PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr_Merge_Public_Static_DLCDaySceneSaveData_DLCDaySceneSaveData_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, 100675787);
				PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr_EnsureFieldNotNull_Private_Static_Void_byref_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, 100675788);
				PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr_ExtractValid_Public_Virtual_Final_New_Void_byref_DLCDaySceneSaveData_byref_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, 100675789);
				PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, 100675790);
			}

			// Token: 0x0600C407 RID: 50183 RVA: 0x0030CA38 File Offset: 0x0030AC38
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 163629, RefRangeEnd = 163637, XrefRangeStart = 163607, XrefRangeEnd = 163629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLCDaySceneSaveData(Il2CppReferenceArray<TrackedCollectable> alltrackedCollectables, Il2CppReferenceArray<TrackedMerchant> alltrackedMerchants, Dictionary<string, Dictionary<string, TrackedNPC>> allTrackedNPCs, Dictionary<string, bool> daySceneMapStatusData, Il2CppReferenceArray<ValueTuple<string, int>> kourindouStaticMerchandiseNum, Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurnitureData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(alltrackedCollectables);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alltrackedMerchants);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allTrackedNPCs);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(daySceneMapStatusData);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(kourindouStaticMerchandiseNum);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flandreHomeFurnitureData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrackedCollectable_Il2CppReferenceArray_1_TrackedMerchant_Dictionary_2_String_Dictionary_2_String_TrackedNPC_Dictionary_2_String_Boolean_Il2CppReferenceArray_1_ValueTuple_2_String_Int32_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C408 RID: 50184 RVA: 0x0030CAE8 File Offset: 0x0030ACE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163637, XrefRangeEnd = 163702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PlayerSaveFile.DLCDaySceneSaveData Merge(PlayerSaveFile.DLCDaySceneSaveData current, PlayerSaveFile.DLCDaySceneSaveData next)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(current));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(next));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr_Merge_Public_Static_DLCDaySceneSaveData_DLCDaySceneSaveData_DLCDaySceneSaveData_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.DLCDaySceneSaveData(pointer);
			}

			// Token: 0x0600C409 RID: 50185 RVA: 0x0030CB40 File Offset: 0x0030AD40
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 163717, RefRangeEnd = 163720, XrefRangeStart = 163702, XrefRangeEnd = 163717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void EnsureFieldNotNull(ref PlayerSaveFile.DLCDaySceneSaveData data)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr_EnsureFieldNotNull_Private_Static_Void_byref_DLCDaySceneSaveData_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C40A RID: 50186 RVA: 0x0030CB78 File Offset: 0x0030AD78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163720, XrefRangeEnd = 163866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ExtractValid(out PlayerSaveFile.DLCDaySceneSaveData valid, out PlayerSaveFile.DLCDaySceneSaveData invalid)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr_ExtractValid_Public_Virtual_Final_New_Void_byref_DLCDaySceneSaveData_byref_DLCDaySceneSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				valid = ((intPtr5 == 0) ? null : new PlayerSaveFile.DLCDaySceneSaveData(intPtr5));
				IntPtr intPtr6 = intPtr2;
				invalid = ((intPtr6 == 0) ? null : new PlayerSaveFile.DLCDaySceneSaveData(intPtr6));
			}

			// Token: 0x0600C40B RID: 50187 RVA: 0x0030CBF4 File Offset: 0x0030ADF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163866, XrefRangeEnd = 163867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveFile.DLCDaySceneSaveData Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_DLCDaySceneSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.DLCDaySceneSaveData(pointer);
			}

			// Token: 0x0600C40C RID: 50188 RVA: 0x00069837 File Offset: 0x00067A37
			public DLCDaySceneSaveData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C40D RID: 50189 RVA: 0x00069840 File Offset: 0x00067A40
			public DLCDaySceneSaveData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr))
			{
			}

			// Token: 0x17003FB8 RID: 16312
			// (get) Token: 0x0600C40E RID: 50190 RVA: 0x0030CC30 File Offset: 0x0030AE30
			// (set) Token: 0x0600C40F RID: 50191 RVA: 0x00069852 File Offset: 0x00067A52
			public unsafe Il2CppReferenceArray<TrackedCollectable> alltrackedCollectables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_alltrackedCollectables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrackedCollectable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_alltrackedCollectables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FB9 RID: 16313
			// (get) Token: 0x0600C410 RID: 50192 RVA: 0x0030CC60 File Offset: 0x0030AE60
			// (set) Token: 0x0600C411 RID: 50193 RVA: 0x00069871 File Offset: 0x00067A71
			public unsafe Il2CppReferenceArray<TrackedMerchant> alltrackedMerchants
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_alltrackedMerchants);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrackedMerchant>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_alltrackedMerchants), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBA RID: 16314
			// (get) Token: 0x0600C412 RID: 50194 RVA: 0x0030CC90 File Offset: 0x0030AE90
			// (set) Token: 0x0600C413 RID: 50195 RVA: 0x00069890 File Offset: 0x00067A90
			public unsafe Dictionary<string, Dictionary<string, TrackedNPC>> allTrackedNPCs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_allTrackedNPCs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Dictionary<string, TrackedNPC>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_allTrackedNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBB RID: 16315
			// (get) Token: 0x0600C414 RID: 50196 RVA: 0x0030CCC0 File Offset: 0x0030AEC0
			// (set) Token: 0x0600C415 RID: 50197 RVA: 0x000698AF File Offset: 0x00067AAF
			public unsafe Dictionary<string, bool> daySceneMapStatusData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_daySceneMapStatusData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_daySceneMapStatusData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBC RID: 16316
			// (get) Token: 0x0600C416 RID: 50198 RVA: 0x0030CCF0 File Offset: 0x0030AEF0
			// (set) Token: 0x0600C417 RID: 50199 RVA: 0x000698CE File Offset: 0x00067ACE
			public unsafe Il2CppReferenceArray<ValueTuple<string, int>> kourindouStaticMerchandiseNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_kourindouStaticMerchandiseNum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<string, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_kourindouStaticMerchandiseNum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FBD RID: 16317
			// (get) Token: 0x0600C418 RID: 50200 RVA: 0x0030CD20 File Offset: 0x0030AF20
			// (set) Token: 0x0600C419 RID: 50201 RVA: 0x000698ED File Offset: 0x00067AED
			public unsafe Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurnitureData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_flandreHomeFurnitureData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<int, List<Vector2Int>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCDaySceneSaveData.NativeFieldInfoPtr_flandreHomeFurnitureData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007E24 RID: 32292
			private static readonly IntPtr NativeFieldInfoPtr_alltrackedCollectables;

			// Token: 0x04007E25 RID: 32293
			private static readonly IntPtr NativeFieldInfoPtr_alltrackedMerchants;

			// Token: 0x04007E26 RID: 32294
			private static readonly IntPtr NativeFieldInfoPtr_allTrackedNPCs;

			// Token: 0x04007E27 RID: 32295
			private static readonly IntPtr NativeFieldInfoPtr_daySceneMapStatusData;

			// Token: 0x04007E28 RID: 32296
			private static readonly IntPtr NativeFieldInfoPtr_kourindouStaticMerchandiseNum;

			// Token: 0x04007E29 RID: 32297
			private static readonly IntPtr NativeFieldInfoPtr_flandreHomeFurnitureData;

			// Token: 0x04007E2A RID: 32298
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrackedCollectable_Il2CppReferenceArray_1_TrackedMerchant_Dictionary_2_String_Dictionary_2_String_TrackedNPC_Dictionary_2_String_Boolean_Il2CppReferenceArray_1_ValueTuple_2_String_Int32_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0;

			// Token: 0x04007E2B RID: 32299
			private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Static_DLCDaySceneSaveData_DLCDaySceneSaveData_DLCDaySceneSaveData_0;

			// Token: 0x04007E2C RID: 32300
			private static readonly IntPtr NativeMethodInfoPtr_EnsureFieldNotNull_Private_Static_Void_byref_DLCDaySceneSaveData_0;

			// Token: 0x04007E2D RID: 32301
			private static readonly IntPtr NativeMethodInfoPtr_ExtractValid_Public_Virtual_Final_New_Void_byref_DLCDaySceneSaveData_byref_DLCDaySceneSaveData_0;

			// Token: 0x04007E2E RID: 32302
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_DLCDaySceneSaveData_0;

			// Token: 0x02001004 RID: 4100
			[ObfuscatedName("GameData.RunTime.Common.PlayerSaveFile+DLCDaySceneSaveData+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x060118E3 RID: 71907 RVA: 0x00407490 File Offset: 0x00405690
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr);
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, "<>9");
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, "<>9__7_0");
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, "<>9__7_1");
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, "<>9__9_0");
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, "<>9__9_1");
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__9_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, "<>9__9_2");
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, 100675792);
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__Merge_b__7_0_Internal_Dictionary_2_String_TrackedNPC_Dictionary_2_String_TrackedNPC_Dictionary_2_String_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, 100675793);
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__Merge_b__7_1_Internal_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, 100675794);
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__ExtractValid_b__9_0_Internal_Boolean_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, 100675795);
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__ExtractValid_b__9_1_Internal_Boolean_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, 100675796);
					PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__ExtractValid_b__9_2_Internal_Boolean_ValueTuple_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr, 100675797);
				}

				// Token: 0x060118E4 RID: 71908 RVA: 0x004075AC File Offset: 0x004057AC
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.DLCDaySceneSaveData.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060118E5 RID: 71909 RVA: 0x004075E8 File Offset: 0x004057E8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163596, XrefRangeEnd = 163602, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe Dictionary<string, TrackedNPC> _Merge_b__7_0(Dictionary<string, TrackedNPC> prev, Dictionary<string, TrackedNPC> next)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(prev);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(next);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__Merge_b__7_0_Internal_Dictionary_2_String_TrackedNPC_Dictionary_2_String_TrackedNPC_Dictionary_2_String_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TrackedNPC>>(intPtr3) : null;
				}

				// Token: 0x060118E6 RID: 71910 RVA: 0x0040764C File Offset: 0x0040584C
				[CallerCount(0)]
				public unsafe bool _Merge_b__7_1(bool prev, bool next)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref prev;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref next;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__Merge_b__7_1_Internal_Boolean_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060118E7 RID: 71911 RVA: 0x004076A4 File Offset: 0x004058A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163602, XrefRangeEnd = 163604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _ExtractValid_b__9_0(TrackedCollectable x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__ExtractValid_b__9_0_Internal_Boolean_TrackedCollectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060118E8 RID: 71912 RVA: 0x004076F4 File Offset: 0x004058F4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163604, XrefRangeEnd = 163606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _ExtractValid_b__9_1(TrackedMerchant x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__ExtractValid_b__9_1_Internal_Boolean_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060118E9 RID: 71913 RVA: 0x00407744 File Offset: 0x00405944
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163606, XrefRangeEnd = 163607, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool _ExtractValid_b__9_2(ValueTuple<string, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeMethodInfoPtr__ExtractValid_b__9_2_Internal_Boolean_ValueTuple_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x060118EA RID: 71914 RVA: 0x00098C59 File Offset: 0x00096E59
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B50 RID: 23376
				// (get) Token: 0x060118EB RID: 71915 RVA: 0x00407798 File Offset: 0x00405998
				// (set) Token: 0x060118EC RID: 71916 RVA: 0x00098C62 File Offset: 0x00096E62
				public unsafe static PlayerSaveFile.DLCDaySceneSaveData.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSaveFile.DLCDaySceneSaveData.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B51 RID: 23377
				// (get) Token: 0x060118ED RID: 71917 RVA: 0x004077C0 File Offset: 0x004059C0
				// (set) Token: 0x060118EE RID: 71918 RVA: 0x00098C74 File Offset: 0x00096E74
				public unsafe static Func<Dictionary<string, TrackedNPC>, Dictionary<string, TrackedNPC>, Dictionary<string, TrackedNPC>> __9__7_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Dictionary<string, TrackedNPC>, Dictionary<string, TrackedNPC>, Dictionary<string, TrackedNPC>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B52 RID: 23378
				// (get) Token: 0x060118EF RID: 71919 RVA: 0x004077E8 File Offset: 0x004059E8
				// (set) Token: 0x060118F0 RID: 71920 RVA: 0x00098C86 File Offset: 0x00096E86
				public unsafe static Func<bool, bool, bool> __9__7_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<bool, bool, bool>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B53 RID: 23379
				// (get) Token: 0x060118F1 RID: 71921 RVA: 0x00407810 File Offset: 0x00405A10
				// (set) Token: 0x060118F2 RID: 71922 RVA: 0x00098C98 File Offset: 0x00096E98
				public unsafe static Predicate<TrackedCollectable> __9__9_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<TrackedCollectable>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B54 RID: 23380
				// (get) Token: 0x060118F3 RID: 71923 RVA: 0x00407838 File Offset: 0x00405A38
				// (set) Token: 0x060118F4 RID: 71924 RVA: 0x00098CAA File Offset: 0x00096EAA
				public unsafe static Predicate<TrackedMerchant> __9__9_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<TrackedMerchant>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B55 RID: 23381
				// (get) Token: 0x060118F5 RID: 71925 RVA: 0x00407860 File Offset: 0x00405A60
				// (set) Token: 0x060118F6 RID: 71926 RVA: 0x00098CBC File Offset: 0x00096EBC
				public unsafe static Predicate<ValueTuple<string, int>> __9__9_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__9_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Predicate<ValueTuple<string, int>>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.DLCDaySceneSaveData.__c.NativeFieldInfoPtr___9__9_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B174 RID: 45428
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B175 RID: 45429
				private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

				// Token: 0x0400B176 RID: 45430
				private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

				// Token: 0x0400B177 RID: 45431
				private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

				// Token: 0x0400B178 RID: 45432
				private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

				// Token: 0x0400B179 RID: 45433
				private static readonly IntPtr NativeFieldInfoPtr___9__9_2;

				// Token: 0x0400B17A RID: 45434
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B17B RID: 45435
				private static readonly IntPtr NativeMethodInfoPtr__Merge_b__7_0_Internal_Dictionary_2_String_TrackedNPC_Dictionary_2_String_TrackedNPC_Dictionary_2_String_TrackedNPC_0;

				// Token: 0x0400B17C RID: 45436
				private static readonly IntPtr NativeMethodInfoPtr__Merge_b__7_1_Internal_Boolean_Boolean_Boolean_0;

				// Token: 0x0400B17D RID: 45437
				private static readonly IntPtr NativeMethodInfoPtr__ExtractValid_b__9_0_Internal_Boolean_TrackedCollectable_0;

				// Token: 0x0400B17E RID: 45438
				private static readonly IntPtr NativeMethodInfoPtr__ExtractValid_b__9_1_Internal_Boolean_TrackedMerchant_0;

				// Token: 0x0400B17F RID: 45439
				private static readonly IntPtr NativeMethodInfoPtr__ExtractValid_b__9_2_Internal_Boolean_ValueTuple_2_String_Int32_0;
			}
		}

		// Token: 0x02000A1E RID: 2590
		public sealed class DLCSchedulerSaveData : ValueType
		{
			// Token: 0x0600C41A RID: 50202 RVA: 0x0030CD50 File Offset: 0x0030AF50
			// Note: this type is marked as 'beforefieldinit'.
			static DLCSchedulerSaveData()
			{
				Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "DLCSchedulerSaveData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr);
				PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_dlcSaveDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr, "dlcSaveDate");
				PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_scheduledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr, "scheduledEvents");
				PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_scheduledNews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr, "scheduledNews");
				PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_scheduledNewsReplaceContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr, "scheduledNewsReplaceContents");
				PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_allTrackingMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr, "allTrackingMissions");
				PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_finishedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr, "finishedEvents");
				PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_finishedMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr, "finishedMissions");
				PlayerSaveFile.DLCSchedulerSaveData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_Dictionary_2_Int32_List_1_TrackedMissionData_Il2CppStringArray_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr, 100675798);
				PlayerSaveFile.DLCSchedulerSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_DLCSchedulerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr, 100675799);
			}

			// Token: 0x0600C41B RID: 50203 RVA: 0x0030CE30 File Offset: 0x0030B030
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 163923, RefRangeEnd = 163927, XrefRangeStart = 163867, XrefRangeEnd = 163923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DLCSchedulerSaveData(int dlcSaveDate, Dictionary<int, List<string>> scheduledEvents, Dictionary<int, List<string>> scheduledNews, Dictionary<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>> scheduledNewsReplaceContents, Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> allTrackingMissions, Il2CppStringArray finishedEvents, Il2CppStringArray finishedMissions) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref dlcSaveDate;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduledEvents);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduledNews);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduledNewsReplaceContents);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allTrackingMissions);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finishedEvents);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finishedMissions);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCSchedulerSaveData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_Dictionary_2_Int32_List_1_TrackedMissionData_Il2CppStringArray_Il2CppStringArray_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C41C RID: 50204 RVA: 0x0030CEEC File Offset: 0x0030B0EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163927, XrefRangeEnd = 163928, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveFile.DLCSchedulerSaveData Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.DLCSchedulerSaveData.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_DLCSchedulerSaveData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.DLCSchedulerSaveData(pointer);
			}

			// Token: 0x0600C41D RID: 50205 RVA: 0x0006990C File Offset: 0x00067B0C
			public DLCSchedulerSaveData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C41E RID: 50206 RVA: 0x00069915 File Offset: 0x00067B15
			public DLCSchedulerSaveData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.DLCSchedulerSaveData>.NativeClassPtr))
			{
			}

			// Token: 0x17003FBE RID: 16318
			// (get) Token: 0x0600C41F RID: 50207 RVA: 0x0030CF28 File Offset: 0x0030B128
			// (set) Token: 0x0600C420 RID: 50208 RVA: 0x00069927 File Offset: 0x00067B27
			public unsafe int dlcSaveDate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_dlcSaveDate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_dlcSaveDate)) = value;
				}
			}

			// Token: 0x17003FBF RID: 16319
			// (get) Token: 0x0600C421 RID: 50209 RVA: 0x0030CF50 File Offset: 0x0030B150
			// (set) Token: 0x0600C422 RID: 50210 RVA: 0x00069942 File Offset: 0x00067B42
			public unsafe Dictionary<int, List<string>> scheduledEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_scheduledEvents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_scheduledEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC0 RID: 16320
			// (get) Token: 0x0600C423 RID: 50211 RVA: 0x0030CF80 File Offset: 0x0030B180
			// (set) Token: 0x0600C424 RID: 50212 RVA: 0x00069961 File Offset: 0x00067B61
			public unsafe Dictionary<int, List<string>> scheduledNews
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_scheduledNews);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_scheduledNews), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC1 RID: 16321
			// (get) Token: 0x0600C425 RID: 50213 RVA: 0x0030CFB0 File Offset: 0x0030B1B0
			// (set) Token: 0x0600C426 RID: 50214 RVA: 0x00069980 File Offset: 0x00067B80
			public unsafe Dictionary<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>> scheduledNewsReplaceContents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_scheduledNewsReplaceContents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_scheduledNewsReplaceContents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC2 RID: 16322
			// (get) Token: 0x0600C427 RID: 50215 RVA: 0x0030CFE0 File Offset: 0x0030B1E0
			// (set) Token: 0x0600C428 RID: 50216 RVA: 0x0006999F File Offset: 0x00067B9F
			public unsafe Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> allTrackingMissions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_allTrackingMissions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<RunTimeScheduler.TrackedMissionData>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_allTrackingMissions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC3 RID: 16323
			// (get) Token: 0x0600C429 RID: 50217 RVA: 0x0030D010 File Offset: 0x0030B210
			// (set) Token: 0x0600C42A RID: 50218 RVA: 0x000699BE File Offset: 0x00067BBE
			public unsafe Il2CppStringArray finishedEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_finishedEvents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_finishedEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC4 RID: 16324
			// (get) Token: 0x0600C42B RID: 50219 RVA: 0x0030D040 File Offset: 0x0030B240
			// (set) Token: 0x0600C42C RID: 50220 RVA: 0x000699DD File Offset: 0x00067BDD
			public unsafe Il2CppStringArray finishedMissions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_finishedMissions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.DLCSchedulerSaveData.NativeFieldInfoPtr_finishedMissions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007E2F RID: 32303
			private static readonly IntPtr NativeFieldInfoPtr_dlcSaveDate;

			// Token: 0x04007E30 RID: 32304
			private static readonly IntPtr NativeFieldInfoPtr_scheduledEvents;

			// Token: 0x04007E31 RID: 32305
			private static readonly IntPtr NativeFieldInfoPtr_scheduledNews;

			// Token: 0x04007E32 RID: 32306
			private static readonly IntPtr NativeFieldInfoPtr_scheduledNewsReplaceContents;

			// Token: 0x04007E33 RID: 32307
			private static readonly IntPtr NativeFieldInfoPtr_allTrackingMissions;

			// Token: 0x04007E34 RID: 32308
			private static readonly IntPtr NativeFieldInfoPtr_finishedEvents;

			// Token: 0x04007E35 RID: 32309
			private static readonly IntPtr NativeFieldInfoPtr_finishedMissions;

			// Token: 0x04007E36 RID: 32310
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_Dictionary_2_Int32_List_1_TrackedMissionData_Il2CppStringArray_Il2CppStringArray_0;

			// Token: 0x04007E37 RID: 32311
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_DLCSchedulerSaveData_0;
		}

		// Token: 0x02000A1F RID: 2591
		public sealed class HistoryIzakayaMenuSelection : ValueType
		{
			// Token: 0x0600C42D RID: 50221 RVA: 0x0030D070 File Offset: 0x0030B270
			// Note: this type is marked as 'beforefieldinit'.
			static HistoryIzakayaMenuSelection()
			{
				Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "HistoryIzakayaMenuSelection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr);
				PlayerSaveFile.HistoryIzakayaMenuSelection.NativeFieldInfoPtr_recipeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr, "recipeList");
				PlayerSaveFile.HistoryIzakayaMenuSelection.NativeFieldInfoPtr_beverageList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr, "beverageList");
				PlayerSaveFile.HistoryIzakayaMenuSelection.NativeFieldInfoPtr_cookerList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr, "cookerList");
				PlayerSaveFile.HistoryIzakayaMenuSelection.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_List_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr, 100675800);
				PlayerSaveFile.HistoryIzakayaMenuSelection.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_HistoryIzakayaMenuSelection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr, 100675801);
			}

			// Token: 0x0600C42E RID: 50222 RVA: 0x0030D100 File Offset: 0x0030B300
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 163938, RefRangeEnd = 163940, XrefRangeStart = 163928, XrefRangeEnd = 163938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe HistoryIzakayaMenuSelection(List<int> recipeList, List<int> beverageList, List<int> cookerList) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipeList);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beverageList);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookerList);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.HistoryIzakayaMenuSelection.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_List_1_Int32_List_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C42F RID: 50223 RVA: 0x0030D174 File Offset: 0x0030B374
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163940, XrefRangeEnd = 163941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveFile.HistoryIzakayaMenuSelection Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.HistoryIzakayaMenuSelection.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_HistoryIzakayaMenuSelection_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.HistoryIzakayaMenuSelection(pointer);
			}

			// Token: 0x0600C430 RID: 50224 RVA: 0x000699FC File Offset: 0x00067BFC
			public HistoryIzakayaMenuSelection(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C431 RID: 50225 RVA: 0x00069A05 File Offset: 0x00067C05
			public HistoryIzakayaMenuSelection() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.HistoryIzakayaMenuSelection>.NativeClassPtr))
			{
			}

			// Token: 0x17003FC5 RID: 16325
			// (get) Token: 0x0600C432 RID: 50226 RVA: 0x0030D1B0 File Offset: 0x0030B3B0
			// (set) Token: 0x0600C433 RID: 50227 RVA: 0x00069A17 File Offset: 0x00067C17
			public unsafe List<int> recipeList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.HistoryIzakayaMenuSelection.NativeFieldInfoPtr_recipeList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.HistoryIzakayaMenuSelection.NativeFieldInfoPtr_recipeList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC6 RID: 16326
			// (get) Token: 0x0600C434 RID: 50228 RVA: 0x0030D1E0 File Offset: 0x0030B3E0
			// (set) Token: 0x0600C435 RID: 50229 RVA: 0x00069A36 File Offset: 0x00067C36
			public unsafe List<int> beverageList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.HistoryIzakayaMenuSelection.NativeFieldInfoPtr_beverageList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.HistoryIzakayaMenuSelection.NativeFieldInfoPtr_beverageList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC7 RID: 16327
			// (get) Token: 0x0600C436 RID: 50230 RVA: 0x0030D210 File Offset: 0x0030B410
			// (set) Token: 0x0600C437 RID: 50231 RVA: 0x00069A55 File Offset: 0x00067C55
			public unsafe List<int> cookerList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.HistoryIzakayaMenuSelection.NativeFieldInfoPtr_cookerList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.HistoryIzakayaMenuSelection.NativeFieldInfoPtr_cookerList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007E38 RID: 32312
			private static readonly IntPtr NativeFieldInfoPtr_recipeList;

			// Token: 0x04007E39 RID: 32313
			private static readonly IntPtr NativeFieldInfoPtr_beverageList;

			// Token: 0x04007E3A RID: 32314
			private static readonly IntPtr NativeFieldInfoPtr_cookerList;

			// Token: 0x04007E3B RID: 32315
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_List_1_Int32_List_1_Int32_0;

			// Token: 0x04007E3C RID: 32316
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_HistoryIzakayaMenuSelection_0;
		}

		// Token: 0x02000A20 RID: 2592
		public sealed class RunTimeAlbumSaveDataPartial : ValueType
		{
			// Token: 0x0600C438 RID: 50232 RVA: 0x0030D240 File Offset: 0x0030B440
			// Note: this type is marked as 'beforefieldinit'.
			static RunTimeAlbumSaveDataPartial()
			{
				Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "RunTimeAlbumSaveDataPartial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr);
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_nGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "nGuests");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "foods");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "bevs");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "ings");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_cookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "cookers");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "items");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_badges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "badges");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_playerSkinSelectionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "playerSkinSelectionData");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_nightBGM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "nightBGM");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_nightBGMIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "nightBGMIndex");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_specialSkinSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "specialSkinSelection");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_historyCollectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "historyCollectables");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_usedDecorations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "usedDecorations");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_useCurrentSkinAtNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "useCurrentSkinAtNight");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_useSpecialShopSkinAtNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "useSpecialShopSkinAtNight");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_ingCollectCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "ingCollectCount");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_unsatisfiedTagCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "unsatisfiedTagCount");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_evictGuestsCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "evictGuestsCount");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_cookingCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "cookingCount");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_strongBuyAndSellCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "strongBuyAndSellCount");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_rewardSpellTriggerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "rewardSpellTriggerCount");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_punishmentSpellTriggerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "punishmentSpellTriggerCount");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_effectiveSGuestsMappingRules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "effectiveSGuestsMappingRules");
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_Int32_Int32_Int32_Dictionary_2_Int32_SpecialGuestRunTimeData_List_1_String_List_1_Int32_Boolean_Boolean_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Int32_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, 100675802);
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_DLCAlbumSaveData_List_1_String_Boolean_Boolean_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, 100675803);
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimeAlbumSaveDataPartial_byref_RunTimeAlbumSaveDataPartial_byref_Dictionary_2_String_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, 100675804);
				PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeAlbumSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, 100675805);
			}

			// Token: 0x0600C439 RID: 50233 RVA: 0x0030D488 File Offset: 0x0030B688
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 164063, RefRangeEnd = 164066, XrefRangeStart = 163997, XrefRangeEnd = 164063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunTimeAlbumSaveDataPartial(List<int> nGuests, List<int> foods, List<int> bevs, List<int> ings, List<int> cookers, List<int> items, List<int> badges, int playerSkinSelectionData, int nightBGM, int nightBGMIndex, Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> specialSkinSelection, List<string> historyCollectables, List<int> usedDecorations, bool useCurrentSkinAtNight, bool useSpecialShopSkinAtNight, Dictionary<int, int> ingCollectCount, Dictionary<int, int> unsatisfiedTagCount, int evictGuestsCount, Dictionary<int, int> cookingCount, int strongBuyAndSellCount, int rewardSpellTriggerCount, int punishmentSpellTriggerCount, List<int> effectiveSGuestsMappingRules) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)23) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(nGuests);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(foods);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bevs);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ings);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookers);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(badges);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerSkinSelectionData;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nightBGM;
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nightBGMIndex;
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialSkinSelection);
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(historyCollectables);
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(usedDecorations);
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCurrentSkinAtNight;
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSpecialShopSkinAtNight;
				ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingCollectCount);
				ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unsatisfiedTagCount);
				ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evictGuestsCount;
				ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookingCount);
				ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strongBuyAndSellCount;
				ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rewardSpellTriggerCount;
				ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punishmentSpellTriggerCount;
				ptr[checked(unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectiveSGuestsMappingRules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_Int32_Int32_Int32_Dictionary_2_Int32_SpecialGuestRunTimeData_List_1_String_List_1_Int32_Boolean_Boolean_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Int32_Int32_List_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C43A RID: 50234 RVA: 0x0030D65C File Offset: 0x0030B85C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 164080, RefRangeEnd = 164081, XrefRangeStart = 164066, XrefRangeEnd = 164080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunTimeAlbumSaveDataPartial(PlayerSaveFile.DLCAlbumSaveData defaultDLCSaveData, List<string> historyCollectables, bool useCurrentSkinAtNight, bool useSpecialShopSkinAtNight, Dictionary<int, int> ingCollectCount, Dictionary<int, int> unsatisfiedTagCount, int evictGuestsCount, Dictionary<int, int> cookingCount, int strongBuyAndSellCount, int rewardSpellTriggerCount, int punishmentSpellTriggerCount, int nightBGM, int nightBGMIndex, List<int> effectiveSGuestsMappingRules) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(defaultDLCSaveData));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(historyCollectables);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCurrentSkinAtNight;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useSpecialShopSkinAtNight;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingCollectCount);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unsatisfiedTagCount);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref evictGuestsCount;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookingCount);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref strongBuyAndSellCount;
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rewardSpellTriggerCount;
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref punishmentSpellTriggerCount;
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nightBGM;
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref nightBGMIndex;
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectiveSGuestsMappingRules);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_DLCAlbumSaveData_List_1_String_Boolean_Boolean_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C43B RID: 50235 RVA: 0x0030D788 File Offset: 0x0030B988
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 164448, RefRangeEnd = 164449, XrefRangeStart = 164081, XrefRangeEnd = 164448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Classify([In] ref PlayerSaveFile.RunTimeAlbumSaveDataPartial albumPartial, ref PlayerSaveFile.RunTimeAlbumSaveDataPartial albumPartialSaveData, ref Dictionary<string, PlayerSaveFile.DLCAlbumSaveData> albumPartialDLCSaveData)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(albumPartial);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(albumPartialSaveData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(albumPartialDLCSaveData);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimeAlbumSaveDataPartial_byref_RunTimeAlbumSaveDataPartial_byref_Dictionary_2_String_DLCAlbumSaveData_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				albumPartialDLCSaveData = ((intPtr4 == 0) ? null : new Dictionary<string, PlayerSaveFile.DLCAlbumSaveData>(intPtr4));
			}

			// Token: 0x0600C43C RID: 50236 RVA: 0x0030D7FC File Offset: 0x0030B9FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164449, XrefRangeEnd = 164451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveFile.RunTimeAlbumSaveDataPartial Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeAlbumSaveDataPartial_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.RunTimeAlbumSaveDataPartial(pointer);
			}

			// Token: 0x0600C43D RID: 50237 RVA: 0x00069A74 File Offset: 0x00067C74
			public RunTimeAlbumSaveDataPartial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C43E RID: 50238 RVA: 0x00069A7D File Offset: 0x00067C7D
			public RunTimeAlbumSaveDataPartial() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr))
			{
			}

			// Token: 0x17003FC8 RID: 16328
			// (get) Token: 0x0600C43F RID: 50239 RVA: 0x0030D838 File Offset: 0x0030BA38
			// (set) Token: 0x0600C440 RID: 50240 RVA: 0x00069A8F File Offset: 0x00067C8F
			public unsafe List<int> nGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_nGuests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_nGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FC9 RID: 16329
			// (get) Token: 0x0600C441 RID: 50241 RVA: 0x0030D868 File Offset: 0x0030BA68
			// (set) Token: 0x0600C442 RID: 50242 RVA: 0x00069AAE File Offset: 0x00067CAE
			public unsafe List<int> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCA RID: 16330
			// (get) Token: 0x0600C443 RID: 50243 RVA: 0x0030D898 File Offset: 0x0030BA98
			// (set) Token: 0x0600C444 RID: 50244 RVA: 0x00069ACD File Offset: 0x00067CCD
			public unsafe List<int> bevs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_bevs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCB RID: 16331
			// (get) Token: 0x0600C445 RID: 50245 RVA: 0x0030D8C8 File Offset: 0x0030BAC8
			// (set) Token: 0x0600C446 RID: 50246 RVA: 0x00069AEC File Offset: 0x00067CEC
			public unsafe List<int> ings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_ings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCC RID: 16332
			// (get) Token: 0x0600C447 RID: 50247 RVA: 0x0030D8F8 File Offset: 0x0030BAF8
			// (set) Token: 0x0600C448 RID: 50248 RVA: 0x00069B0B File Offset: 0x00067D0B
			public unsafe List<int> cookers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_cookers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_cookers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCD RID: 16333
			// (get) Token: 0x0600C449 RID: 50249 RVA: 0x0030D928 File Offset: 0x0030BB28
			// (set) Token: 0x0600C44A RID: 50250 RVA: 0x00069B2A File Offset: 0x00067D2A
			public unsafe List<int> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCE RID: 16334
			// (get) Token: 0x0600C44B RID: 50251 RVA: 0x0030D958 File Offset: 0x0030BB58
			// (set) Token: 0x0600C44C RID: 50252 RVA: 0x00069B49 File Offset: 0x00067D49
			public unsafe List<int> badges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_badges);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_badges), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FCF RID: 16335
			// (get) Token: 0x0600C44D RID: 50253 RVA: 0x0030D988 File Offset: 0x0030BB88
			// (set) Token: 0x0600C44E RID: 50254 RVA: 0x00069B68 File Offset: 0x00067D68
			public unsafe int playerSkinSelectionData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_playerSkinSelectionData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_playerSkinSelectionData)) = value;
				}
			}

			// Token: 0x17003FD0 RID: 16336
			// (get) Token: 0x0600C44F RID: 50255 RVA: 0x0030D9B0 File Offset: 0x0030BBB0
			// (set) Token: 0x0600C450 RID: 50256 RVA: 0x00069B83 File Offset: 0x00067D83
			public unsafe int nightBGM
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_nightBGM);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_nightBGM)) = value;
				}
			}

			// Token: 0x17003FD1 RID: 16337
			// (get) Token: 0x0600C451 RID: 50257 RVA: 0x0030D9D8 File Offset: 0x0030BBD8
			// (set) Token: 0x0600C452 RID: 50258 RVA: 0x00069B9E File Offset: 0x00067D9E
			public unsafe int nightBGMIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_nightBGMIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_nightBGMIndex)) = value;
				}
			}

			// Token: 0x17003FD2 RID: 16338
			// (get) Token: 0x0600C453 RID: 50259 RVA: 0x0030DA00 File Offset: 0x0030BC00
			// (set) Token: 0x0600C454 RID: 50260 RVA: 0x00069BB9 File Offset: 0x00067DB9
			public unsafe Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData> specialSkinSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_specialSkinSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, RunTimeAlbum.SpecialGuestRunTimeData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_specialSkinSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD3 RID: 16339
			// (get) Token: 0x0600C455 RID: 50261 RVA: 0x0030DA30 File Offset: 0x0030BC30
			// (set) Token: 0x0600C456 RID: 50262 RVA: 0x00069BD8 File Offset: 0x00067DD8
			public unsafe List<string> historyCollectables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_historyCollectables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_historyCollectables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD4 RID: 16340
			// (get) Token: 0x0600C457 RID: 50263 RVA: 0x0030DA60 File Offset: 0x0030BC60
			// (set) Token: 0x0600C458 RID: 50264 RVA: 0x00069BF7 File Offset: 0x00067DF7
			public unsafe List<int> usedDecorations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_usedDecorations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_usedDecorations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD5 RID: 16341
			// (get) Token: 0x0600C459 RID: 50265 RVA: 0x0030DA90 File Offset: 0x0030BC90
			// (set) Token: 0x0600C45A RID: 50266 RVA: 0x00069C16 File Offset: 0x00067E16
			public unsafe bool useCurrentSkinAtNight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_useCurrentSkinAtNight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_useCurrentSkinAtNight)) = value;
				}
			}

			// Token: 0x17003FD6 RID: 16342
			// (get) Token: 0x0600C45B RID: 50267 RVA: 0x0030DAB8 File Offset: 0x0030BCB8
			// (set) Token: 0x0600C45C RID: 50268 RVA: 0x00069C31 File Offset: 0x00067E31
			public unsafe bool useSpecialShopSkinAtNight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_useSpecialShopSkinAtNight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_useSpecialShopSkinAtNight)) = value;
				}
			}

			// Token: 0x17003FD7 RID: 16343
			// (get) Token: 0x0600C45D RID: 50269 RVA: 0x0030DAE0 File Offset: 0x0030BCE0
			// (set) Token: 0x0600C45E RID: 50270 RVA: 0x00069C4C File Offset: 0x00067E4C
			public unsafe Dictionary<int, int> ingCollectCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_ingCollectCount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_ingCollectCount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD8 RID: 16344
			// (get) Token: 0x0600C45F RID: 50271 RVA: 0x0030DB10 File Offset: 0x0030BD10
			// (set) Token: 0x0600C460 RID: 50272 RVA: 0x00069C6B File Offset: 0x00067E6B
			public unsafe Dictionary<int, int> unsatisfiedTagCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_unsatisfiedTagCount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_unsatisfiedTagCount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FD9 RID: 16345
			// (get) Token: 0x0600C461 RID: 50273 RVA: 0x0030DB40 File Offset: 0x0030BD40
			// (set) Token: 0x0600C462 RID: 50274 RVA: 0x00069C8A File Offset: 0x00067E8A
			public unsafe int evictGuestsCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_evictGuestsCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_evictGuestsCount)) = value;
				}
			}

			// Token: 0x17003FDA RID: 16346
			// (get) Token: 0x0600C463 RID: 50275 RVA: 0x0030DB68 File Offset: 0x0030BD68
			// (set) Token: 0x0600C464 RID: 50276 RVA: 0x00069CA5 File Offset: 0x00067EA5
			public unsafe Dictionary<int, int> cookingCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_cookingCount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_cookingCount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FDB RID: 16347
			// (get) Token: 0x0600C465 RID: 50277 RVA: 0x0030DB98 File Offset: 0x0030BD98
			// (set) Token: 0x0600C466 RID: 50278 RVA: 0x00069CC4 File Offset: 0x00067EC4
			public unsafe int strongBuyAndSellCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_strongBuyAndSellCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_strongBuyAndSellCount)) = value;
				}
			}

			// Token: 0x17003FDC RID: 16348
			// (get) Token: 0x0600C467 RID: 50279 RVA: 0x0030DBC0 File Offset: 0x0030BDC0
			// (set) Token: 0x0600C468 RID: 50280 RVA: 0x00069CDF File Offset: 0x00067EDF
			public unsafe int rewardSpellTriggerCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_rewardSpellTriggerCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_rewardSpellTriggerCount)) = value;
				}
			}

			// Token: 0x17003FDD RID: 16349
			// (get) Token: 0x0600C469 RID: 50281 RVA: 0x0030DBE8 File Offset: 0x0030BDE8
			// (set) Token: 0x0600C46A RID: 50282 RVA: 0x00069CFA File Offset: 0x00067EFA
			public unsafe int punishmentSpellTriggerCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_punishmentSpellTriggerCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_punishmentSpellTriggerCount)) = value;
				}
			}

			// Token: 0x17003FDE RID: 16350
			// (get) Token: 0x0600C46B RID: 50283 RVA: 0x0030DC10 File Offset: 0x0030BE10
			// (set) Token: 0x0600C46C RID: 50284 RVA: 0x00069D15 File Offset: 0x00067F15
			public unsafe List<int> effectiveSGuestsMappingRules
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_effectiveSGuestsMappingRules);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeAlbumSaveDataPartial.NativeFieldInfoPtr_effectiveSGuestsMappingRules), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007E3D RID: 32317
			private static readonly IntPtr NativeFieldInfoPtr_nGuests;

			// Token: 0x04007E3E RID: 32318
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x04007E3F RID: 32319
			private static readonly IntPtr NativeFieldInfoPtr_bevs;

			// Token: 0x04007E40 RID: 32320
			private static readonly IntPtr NativeFieldInfoPtr_ings;

			// Token: 0x04007E41 RID: 32321
			private static readonly IntPtr NativeFieldInfoPtr_cookers;

			// Token: 0x04007E42 RID: 32322
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x04007E43 RID: 32323
			private static readonly IntPtr NativeFieldInfoPtr_badges;

			// Token: 0x04007E44 RID: 32324
			private static readonly IntPtr NativeFieldInfoPtr_playerSkinSelectionData;

			// Token: 0x04007E45 RID: 32325
			private static readonly IntPtr NativeFieldInfoPtr_nightBGM;

			// Token: 0x04007E46 RID: 32326
			private static readonly IntPtr NativeFieldInfoPtr_nightBGMIndex;

			// Token: 0x04007E47 RID: 32327
			private static readonly IntPtr NativeFieldInfoPtr_specialSkinSelection;

			// Token: 0x04007E48 RID: 32328
			private static readonly IntPtr NativeFieldInfoPtr_historyCollectables;

			// Token: 0x04007E49 RID: 32329
			private static readonly IntPtr NativeFieldInfoPtr_usedDecorations;

			// Token: 0x04007E4A RID: 32330
			private static readonly IntPtr NativeFieldInfoPtr_useCurrentSkinAtNight;

			// Token: 0x04007E4B RID: 32331
			private static readonly IntPtr NativeFieldInfoPtr_useSpecialShopSkinAtNight;

			// Token: 0x04007E4C RID: 32332
			private static readonly IntPtr NativeFieldInfoPtr_ingCollectCount;

			// Token: 0x04007E4D RID: 32333
			private static readonly IntPtr NativeFieldInfoPtr_unsatisfiedTagCount;

			// Token: 0x04007E4E RID: 32334
			private static readonly IntPtr NativeFieldInfoPtr_evictGuestsCount;

			// Token: 0x04007E4F RID: 32335
			private static readonly IntPtr NativeFieldInfoPtr_cookingCount;

			// Token: 0x04007E50 RID: 32336
			private static readonly IntPtr NativeFieldInfoPtr_strongBuyAndSellCount;

			// Token: 0x04007E51 RID: 32337
			private static readonly IntPtr NativeFieldInfoPtr_rewardSpellTriggerCount;

			// Token: 0x04007E52 RID: 32338
			private static readonly IntPtr NativeFieldInfoPtr_punishmentSpellTriggerCount;

			// Token: 0x04007E53 RID: 32339
			private static readonly IntPtr NativeFieldInfoPtr_effectiveSGuestsMappingRules;

			// Token: 0x04007E54 RID: 32340
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_Int32_Int32_Int32_Dictionary_2_Int32_SpecialGuestRunTimeData_List_1_String_List_1_Int32_Boolean_Boolean_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Int32_Int32_List_1_Int32_0;

			// Token: 0x04007E55 RID: 32341
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLCAlbumSaveData_List_1_String_Boolean_Boolean_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Dictionary_2_Int32_Int32_Int32_Int32_Int32_Int32_Int32_List_1_Int32_0;

			// Token: 0x04007E56 RID: 32342
			private static readonly IntPtr NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimeAlbumSaveDataPartial_byref_RunTimeAlbumSaveDataPartial_byref_Dictionary_2_String_DLCAlbumSaveData_0;

			// Token: 0x04007E57 RID: 32343
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeAlbumSaveDataPartial_0;

			// Token: 0x02001005 RID: 4101
			[ObfuscatedName("GameData.RunTime.Common.PlayerSaveFile+RunTimeAlbumSaveDataPartial+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x060118F7 RID: 71927 RVA: 0x00407888 File Offset: 0x00405A88
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_0");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_1");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_2");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_3");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_4");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_5");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_6");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_7");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_8");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, "<>9__25_9");
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675807);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675808);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_1_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675809);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_2_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675810);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_3_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675811);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_4_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675812);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_5_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675813);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_6_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675814);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_7_Internal_String_KeyValuePair_2_Int32_SpecialGuestRunTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675815);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_8_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675816);
					PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_9_Internal_DLCAlbumSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr, 100675817);
				}

				// Token: 0x060118F8 RID: 71928 RVA: 0x00407A6C File Offset: 0x00405C6C
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060118F9 RID: 71929 RVA: 0x00407AA8 File Offset: 0x00405CA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163941, XrefRangeEnd = 163945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__25_0(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060118FA RID: 71930 RVA: 0x00407AEC File Offset: 0x00405CEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163945, XrefRangeEnd = 163946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__25_1(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_1_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060118FB RID: 71931 RVA: 0x00407B30 File Offset: 0x00405D30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163946, XrefRangeEnd = 163947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__25_2(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_2_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060118FC RID: 71932 RVA: 0x00407B74 File Offset: 0x00405D74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163947, XrefRangeEnd = 163948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__25_3(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_3_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060118FD RID: 71933 RVA: 0x00407BB8 File Offset: 0x00405DB8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163948, XrefRangeEnd = 163949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__25_4(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_4_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060118FE RID: 71934 RVA: 0x00407BFC File Offset: 0x00405DFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163949, XrefRangeEnd = 163950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__25_5(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_5_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x060118FF RID: 71935 RVA: 0x00407C40 File Offset: 0x00405E40
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163950, XrefRangeEnd = 163951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__25_6(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_6_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011900 RID: 71936 RVA: 0x00407C84 File Offset: 0x00405E84
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163951, XrefRangeEnd = 163956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__25_7(KeyValuePair<int, RunTimeAlbum.SpecialGuestRunTimeData> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_7_Internal_String_KeyValuePair_2_Int32_SpecialGuestRunTimeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011901 RID: 71937 RVA: 0x00407CD4 File Offset: 0x00405ED4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__25_8(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_8_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011902 RID: 71938 RVA: 0x00407D18 File Offset: 0x00405F18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 163956, XrefRangeEnd = 163997, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PlayerSaveFile.DLCAlbumSaveData _Classify_b__25_9()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__25_9_Internal_DLCAlbumSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new PlayerSaveFile.DLCAlbumSaveData(pointer);
				}

				// Token: 0x06011903 RID: 71939 RVA: 0x00098CCE File Offset: 0x00096ECE
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B56 RID: 23382
				// (get) Token: 0x06011904 RID: 71940 RVA: 0x00407D50 File Offset: 0x00405F50
				// (set) Token: 0x06011905 RID: 71941 RVA: 0x00098CD7 File Offset: 0x00096ED7
				public unsafe static PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B57 RID: 23383
				// (get) Token: 0x06011906 RID: 71942 RVA: 0x00407D78 File Offset: 0x00405F78
				// (set) Token: 0x06011907 RID: 71943 RVA: 0x00098CE9 File Offset: 0x00096EE9
				public unsafe static Func<int, string> __9__25_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B58 RID: 23384
				// (get) Token: 0x06011908 RID: 71944 RVA: 0x00407DA0 File Offset: 0x00405FA0
				// (set) Token: 0x06011909 RID: 71945 RVA: 0x00098CFB File Offset: 0x00096EFB
				public unsafe static Func<int, string> __9__25_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B59 RID: 23385
				// (get) Token: 0x0601190A RID: 71946 RVA: 0x00407DC8 File Offset: 0x00405FC8
				// (set) Token: 0x0601190B RID: 71947 RVA: 0x00098D0D File Offset: 0x00096F0D
				public unsafe static Func<int, string> __9__25_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B5A RID: 23386
				// (get) Token: 0x0601190C RID: 71948 RVA: 0x00407DF0 File Offset: 0x00405FF0
				// (set) Token: 0x0601190D RID: 71949 RVA: 0x00098D1F File Offset: 0x00096F1F
				public unsafe static Func<int, string> __9__25_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B5B RID: 23387
				// (get) Token: 0x0601190E RID: 71950 RVA: 0x00407E18 File Offset: 0x00406018
				// (set) Token: 0x0601190F RID: 71951 RVA: 0x00098D31 File Offset: 0x00096F31
				public unsafe static Func<int, string> __9__25_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B5C RID: 23388
				// (get) Token: 0x06011910 RID: 71952 RVA: 0x00407E40 File Offset: 0x00406040
				// (set) Token: 0x06011911 RID: 71953 RVA: 0x00098D43 File Offset: 0x00096F43
				public unsafe static Func<int, string> __9__25_5
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_5, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_5, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B5D RID: 23389
				// (get) Token: 0x06011912 RID: 71954 RVA: 0x00407E68 File Offset: 0x00406068
				// (set) Token: 0x06011913 RID: 71955 RVA: 0x00098D55 File Offset: 0x00096F55
				public unsafe static Func<int, string> __9__25_6
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_6, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_6, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B5E RID: 23390
				// (get) Token: 0x06011914 RID: 71956 RVA: 0x00407E90 File Offset: 0x00406090
				// (set) Token: 0x06011915 RID: 71957 RVA: 0x00098D67 File Offset: 0x00096F67
				public unsafe static Func<KeyValuePair<int, RunTimeAlbum.SpecialGuestRunTimeData>, string> __9__25_7
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_7, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, RunTimeAlbum.SpecialGuestRunTimeData>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_7, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B5F RID: 23391
				// (get) Token: 0x06011916 RID: 71958 RVA: 0x00407EB8 File Offset: 0x004060B8
				// (set) Token: 0x06011917 RID: 71959 RVA: 0x00098D79 File Offset: 0x00096F79
				public unsafe static Func<int, string> __9__25_8
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_8, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_8, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B60 RID: 23392
				// (get) Token: 0x06011918 RID: 71960 RVA: 0x00407EE0 File Offset: 0x004060E0
				// (set) Token: 0x06011919 RID: 71961 RVA: 0x00098D8B File Offset: 0x00096F8B
				public unsafe static Func<PlayerSaveFile.DLCAlbumSaveData> __9__25_9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCAlbumSaveData>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeAlbumSaveDataPartial.__c.NativeFieldInfoPtr___9__25_9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B180 RID: 45440
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B181 RID: 45441
				private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

				// Token: 0x0400B182 RID: 45442
				private static readonly IntPtr NativeFieldInfoPtr___9__25_1;

				// Token: 0x0400B183 RID: 45443
				private static readonly IntPtr NativeFieldInfoPtr___9__25_2;

				// Token: 0x0400B184 RID: 45444
				private static readonly IntPtr NativeFieldInfoPtr___9__25_3;

				// Token: 0x0400B185 RID: 45445
				private static readonly IntPtr NativeFieldInfoPtr___9__25_4;

				// Token: 0x0400B186 RID: 45446
				private static readonly IntPtr NativeFieldInfoPtr___9__25_5;

				// Token: 0x0400B187 RID: 45447
				private static readonly IntPtr NativeFieldInfoPtr___9__25_6;

				// Token: 0x0400B188 RID: 45448
				private static readonly IntPtr NativeFieldInfoPtr___9__25_7;

				// Token: 0x0400B189 RID: 45449
				private static readonly IntPtr NativeFieldInfoPtr___9__25_8;

				// Token: 0x0400B18A RID: 45450
				private static readonly IntPtr NativeFieldInfoPtr___9__25_9;

				// Token: 0x0400B18B RID: 45451
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B18C RID: 45452
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_0_Internal_String_Int32_0;

				// Token: 0x0400B18D RID: 45453
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_1_Internal_String_Int32_0;

				// Token: 0x0400B18E RID: 45454
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_2_Internal_String_Int32_0;

				// Token: 0x0400B18F RID: 45455
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_3_Internal_String_Int32_0;

				// Token: 0x0400B190 RID: 45456
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_4_Internal_String_Int32_0;

				// Token: 0x0400B191 RID: 45457
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_5_Internal_String_Int32_0;

				// Token: 0x0400B192 RID: 45458
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_6_Internal_String_Int32_0;

				// Token: 0x0400B193 RID: 45459
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_7_Internal_String_KeyValuePair_2_Int32_SpecialGuestRunTimeData_0;

				// Token: 0x0400B194 RID: 45460
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_8_Internal_String_Int32_0;

				// Token: 0x0400B195 RID: 45461
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__25_9_Internal_DLCAlbumSaveData_0;
			}
		}

		// Token: 0x02000A21 RID: 2593
		public sealed class RunTimeDaySceneSaveDataPartial : ValueType
		{
			// Token: 0x0600C46D RID: 50285 RVA: 0x0030DC40 File Offset: 0x0030BE40
			// Note: this type is marked as 'beforefieldinit'.
			static RunTimeDaySceneSaveDataPartial()
			{
				Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "RunTimeDaySceneSaveDataPartial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr);
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_alltrackedCollectables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "alltrackedCollectables");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_alltrackedMerchants = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "alltrackedMerchants");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_allTrackedNPCs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "allTrackedNPCs");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_daySceneMapStatusData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "daySceneMapStatusData");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_trackedInteradctables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "trackedInteradctables");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_trackedSwitch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "trackedSwitch");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_kourindoStaticMerchandise = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "kourindoStaticMerchandise");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_kourindouStaticMerchandiseNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "kourindouStaticMerchandiseNum");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_trackedCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "trackedCount");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_musicgameMusicalsNoteSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "musicgameMusicalsNoteSpeed");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_flandreHomeFurnitureData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "flandreHomeFurnitureData");
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrackedCollectable_Il2CppReferenceArray_1_TrackedMerchant_Dictionary_2_String_Dictionary_2_String_TrackedNPC_Dictionary_2_String_Boolean_Il2CppReferenceArray_1_TrackedInteractable_Dictionary_2_String_Boolean_Il2CppReferenceArray_1_ValueTuple_2_String_Int32_Dictionary_2_String_Int32_Dictionary_2_String_ValueTuple_2_Single_Single_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, 100675818);
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_DLCDaySceneSaveData_Il2CppReferenceArray_1_TrackedInteractable_Dictionary_2_String_Boolean_Dictionary_2_String_Int32_Dictionary_2_String_ValueTuple_2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, 100675819);
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimeDaySceneSaveDataPartial_byref_RunTimeDaySceneSaveDataPartial_byref_Dictionary_2_String_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, 100675820);
				PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeDaySceneSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, 100675821);
			}

			// Token: 0x0600C46E RID: 50286 RVA: 0x0030DD98 File Offset: 0x0030BF98
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 164530, RefRangeEnd = 164533, XrefRangeStart = 164492, XrefRangeEnd = 164530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunTimeDaySceneSaveDataPartial(Il2CppReferenceArray<TrackedCollectable> alltrackedCollectables, Il2CppReferenceArray<TrackedMerchant> alltrackedMerchants, Dictionary<string, Dictionary<string, TrackedNPC>> allTrackedNPCs, Dictionary<string, bool> daySceneMapStatusData, Il2CppReferenceArray<TrackedInteractable> trackedInteractables, Dictionary<string, bool> trackedSwitch, Il2CppReferenceArray<ValueTuple<string, int>> kourindouStaticMerchandiseNum, Dictionary<string, int> trackedCount, Dictionary<string, ValueTuple<float, float>> musicgameMusicalsNoteSpeed, Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurnitureData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(alltrackedCollectables);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(alltrackedMerchants);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allTrackedNPCs);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(daySceneMapStatusData);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trackedInteractables);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trackedSwitch);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(kourindouStaticMerchandiseNum);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trackedCount);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(musicgameMusicalsNoteSpeed);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(flandreHomeFurnitureData);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrackedCollectable_Il2CppReferenceArray_1_TrackedMerchant_Dictionary_2_String_Dictionary_2_String_TrackedNPC_Dictionary_2_String_Boolean_Il2CppReferenceArray_1_TrackedInteractable_Dictionary_2_String_Boolean_Il2CppReferenceArray_1_ValueTuple_2_String_Int32_Dictionary_2_String_Int32_Dictionary_2_String_ValueTuple_2_Single_Single_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C46F RID: 50287 RVA: 0x0030DE94 File Offset: 0x0030C094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164533, XrefRangeEnd = 164544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunTimeDaySceneSaveDataPartial(PlayerSaveFile.DLCDaySceneSaveData defaultDLCDaySaveData, Il2CppReferenceArray<TrackedInteractable> trackedInteractables, Dictionary<string, bool> trackedSwitch, Dictionary<string, int> trackedCount, Dictionary<string, ValueTuple<float, float>> musicgameMusicalsNoteSpeed) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(defaultDLCDaySaveData));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trackedInteractables);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trackedSwitch);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trackedCount);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(musicgameMusicalsNoteSpeed);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_DLCDaySceneSaveData_Il2CppReferenceArray_1_TrackedInteractable_Dictionary_2_String_Boolean_Dictionary_2_String_Int32_Dictionary_2_String_ValueTuple_2_Single_Single_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C470 RID: 50288 RVA: 0x0030DF34 File Offset: 0x0030C134
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 164908, RefRangeEnd = 164909, XrefRangeStart = 164544, XrefRangeEnd = 164908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Classify([In] ref PlayerSaveFile.RunTimeDaySceneSaveDataPartial dayScenePartial, ref PlayerSaveFile.RunTimeDaySceneSaveDataPartial dayScenePartialSaveData, ref Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData> dayScenePartialDLCSaveData)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(dayScenePartial);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(dayScenePartialSaveData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(dayScenePartialDLCSaveData);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimeDaySceneSaveDataPartial_byref_RunTimeDaySceneSaveDataPartial_byref_Dictionary_2_String_DLCDaySceneSaveData_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				dayScenePartialDLCSaveData = ((intPtr4 == 0) ? null : new Dictionary<string, PlayerSaveFile.DLCDaySceneSaveData>(intPtr4));
			}

			// Token: 0x0600C471 RID: 50289 RVA: 0x0030DFA8 File Offset: 0x0030C1A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164909, XrefRangeEnd = 164910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveFile.RunTimeDaySceneSaveDataPartial Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeDaySceneSaveDataPartial_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.RunTimeDaySceneSaveDataPartial(pointer);
			}

			// Token: 0x0600C472 RID: 50290 RVA: 0x00069D34 File Offset: 0x00067F34
			public RunTimeDaySceneSaveDataPartial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C473 RID: 50291 RVA: 0x00069D3D File Offset: 0x00067F3D
			public RunTimeDaySceneSaveDataPartial() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr))
			{
			}

			// Token: 0x17003FDF RID: 16351
			// (get) Token: 0x0600C474 RID: 50292 RVA: 0x0030DFE4 File Offset: 0x0030C1E4
			// (set) Token: 0x0600C475 RID: 50293 RVA: 0x00069D4F File Offset: 0x00067F4F
			public unsafe Il2CppReferenceArray<TrackedCollectable> alltrackedCollectables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_alltrackedCollectables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrackedCollectable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_alltrackedCollectables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE0 RID: 16352
			// (get) Token: 0x0600C476 RID: 50294 RVA: 0x0030E014 File Offset: 0x0030C214
			// (set) Token: 0x0600C477 RID: 50295 RVA: 0x00069D6E File Offset: 0x00067F6E
			public unsafe Il2CppReferenceArray<TrackedMerchant> alltrackedMerchants
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_alltrackedMerchants);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrackedMerchant>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_alltrackedMerchants), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE1 RID: 16353
			// (get) Token: 0x0600C478 RID: 50296 RVA: 0x0030E044 File Offset: 0x0030C244
			// (set) Token: 0x0600C479 RID: 50297 RVA: 0x00069D8D File Offset: 0x00067F8D
			public unsafe Dictionary<string, Dictionary<string, TrackedNPC>> allTrackedNPCs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_allTrackedNPCs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Dictionary<string, TrackedNPC>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_allTrackedNPCs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE2 RID: 16354
			// (get) Token: 0x0600C47A RID: 50298 RVA: 0x0030E074 File Offset: 0x0030C274
			// (set) Token: 0x0600C47B RID: 50299 RVA: 0x00069DAC File Offset: 0x00067FAC
			public unsafe Dictionary<string, bool> daySceneMapStatusData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_daySceneMapStatusData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_daySceneMapStatusData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE3 RID: 16355
			// (get) Token: 0x0600C47C RID: 50300 RVA: 0x0030E0A4 File Offset: 0x0030C2A4
			// (set) Token: 0x0600C47D RID: 50301 RVA: 0x00069DCB File Offset: 0x00067FCB
			public unsafe Il2CppReferenceArray<TrackedInteractable> trackedInteradctables
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_trackedInteradctables);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrackedInteractable>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_trackedInteradctables), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE4 RID: 16356
			// (get) Token: 0x0600C47E RID: 50302 RVA: 0x0030E0D4 File Offset: 0x0030C2D4
			// (set) Token: 0x0600C47F RID: 50303 RVA: 0x00069DEA File Offset: 0x00067FEA
			public unsafe Dictionary<string, bool> trackedSwitch
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_trackedSwitch);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_trackedSwitch), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE5 RID: 16357
			// (get) Token: 0x0600C480 RID: 50304 RVA: 0x0030E104 File Offset: 0x0030C304
			// (set) Token: 0x0600C481 RID: 50305 RVA: 0x00069E09 File Offset: 0x00068009
			public unsafe Il2CppStringArray kourindoStaticMerchandise
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_kourindoStaticMerchandise);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_kourindoStaticMerchandise), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE6 RID: 16358
			// (get) Token: 0x0600C482 RID: 50306 RVA: 0x0030E134 File Offset: 0x0030C334
			// (set) Token: 0x0600C483 RID: 50307 RVA: 0x00069E28 File Offset: 0x00068028
			public unsafe Il2CppReferenceArray<ValueTuple<string, int>> kourindouStaticMerchandiseNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_kourindouStaticMerchandiseNum);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<string, int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_kourindouStaticMerchandiseNum), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE7 RID: 16359
			// (get) Token: 0x0600C484 RID: 50308 RVA: 0x0030E164 File Offset: 0x0030C364
			// (set) Token: 0x0600C485 RID: 50309 RVA: 0x00069E47 File Offset: 0x00068047
			public unsafe Dictionary<string, int> trackedCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_trackedCount);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_trackedCount), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE8 RID: 16360
			// (get) Token: 0x0600C486 RID: 50310 RVA: 0x0030E194 File Offset: 0x0030C394
			// (set) Token: 0x0600C487 RID: 50311 RVA: 0x00069E66 File Offset: 0x00068066
			public unsafe Dictionary<string, ValueTuple<float, float>> musicgameMusicalsNoteSpeed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_musicgameMusicalsNoteSpeed);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ValueTuple<float, float>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_musicgameMusicalsNoteSpeed), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FE9 RID: 16361
			// (get) Token: 0x0600C488 RID: 50312 RVA: 0x0030E1C4 File Offset: 0x0030C3C4
			// (set) Token: 0x0600C489 RID: 50313 RVA: 0x00069E85 File Offset: 0x00068085
			public unsafe Dictionary<int, ValueTuple<int, List<Vector2Int>>> flandreHomeFurnitureData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_flandreHomeFurnitureData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, ValueTuple<int, List<Vector2Int>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.NativeFieldInfoPtr_flandreHomeFurnitureData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007E58 RID: 32344
			private static readonly IntPtr NativeFieldInfoPtr_alltrackedCollectables;

			// Token: 0x04007E59 RID: 32345
			private static readonly IntPtr NativeFieldInfoPtr_alltrackedMerchants;

			// Token: 0x04007E5A RID: 32346
			private static readonly IntPtr NativeFieldInfoPtr_allTrackedNPCs;

			// Token: 0x04007E5B RID: 32347
			private static readonly IntPtr NativeFieldInfoPtr_daySceneMapStatusData;

			// Token: 0x04007E5C RID: 32348
			private static readonly IntPtr NativeFieldInfoPtr_trackedInteradctables;

			// Token: 0x04007E5D RID: 32349
			private static readonly IntPtr NativeFieldInfoPtr_trackedSwitch;

			// Token: 0x04007E5E RID: 32350
			private static readonly IntPtr NativeFieldInfoPtr_kourindoStaticMerchandise;

			// Token: 0x04007E5F RID: 32351
			private static readonly IntPtr NativeFieldInfoPtr_kourindouStaticMerchandiseNum;

			// Token: 0x04007E60 RID: 32352
			private static readonly IntPtr NativeFieldInfoPtr_trackedCount;

			// Token: 0x04007E61 RID: 32353
			private static readonly IntPtr NativeFieldInfoPtr_musicgameMusicalsNoteSpeed;

			// Token: 0x04007E62 RID: 32354
			private static readonly IntPtr NativeFieldInfoPtr_flandreHomeFurnitureData;

			// Token: 0x04007E63 RID: 32355
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_TrackedCollectable_Il2CppReferenceArray_1_TrackedMerchant_Dictionary_2_String_Dictionary_2_String_TrackedNPC_Dictionary_2_String_Boolean_Il2CppReferenceArray_1_TrackedInteractable_Dictionary_2_String_Boolean_Il2CppReferenceArray_1_ValueTuple_2_String_Int32_Dictionary_2_String_Int32_Dictionary_2_String_ValueTuple_2_Single_Single_Dictionary_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0;

			// Token: 0x04007E64 RID: 32356
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLCDaySceneSaveData_Il2CppReferenceArray_1_TrackedInteractable_Dictionary_2_String_Boolean_Dictionary_2_String_Int32_Dictionary_2_String_ValueTuple_2_Single_Single_0;

			// Token: 0x04007E65 RID: 32357
			private static readonly IntPtr NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimeDaySceneSaveDataPartial_byref_RunTimeDaySceneSaveDataPartial_byref_Dictionary_2_String_DLCDaySceneSaveData_0;

			// Token: 0x04007E66 RID: 32358
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeDaySceneSaveDataPartial_0;

			// Token: 0x02001006 RID: 4102
			[ObfuscatedName("GameData.RunTime.Common.PlayerSaveFile+RunTimeDaySceneSaveDataPartial+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x0601191A RID: 71962 RVA: 0x00407F08 File Offset: 0x00406108
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr);
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, "<>9");
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, "<>9__13_0");
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, "<>9__13_1");
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, "<>9__13_6");
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, "<>9__13_2");
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, "<>9__13_3");
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, "<>9__13_4");
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, "<>9__13_5");
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, 100675823);
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_0_Internal_String_TrackedCollectable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, 100675824);
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_1_Internal_String_TrackedMerchant_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, 100675825);
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_6_Internal_String_KeyValuePair_2_String_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, 100675826);
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_2_Internal_String_KeyValuePair_2_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, 100675827);
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_3_Internal_String_ValueTuple_2_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, 100675828);
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_4_Internal_String_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, 100675829);
					PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_5_Internal_DLCDaySceneSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr, 100675830);
				}

				// Token: 0x0601191B RID: 71963 RVA: 0x00408074 File Offset: 0x00406274
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601191C RID: 71964 RVA: 0x004080B0 File Offset: 0x004062B0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164451, XrefRangeEnd = 164453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_0(TrackedCollectable x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_0_Internal_String_TrackedCollectable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601191D RID: 71965 RVA: 0x004080F8 File Offset: 0x004062F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164453, XrefRangeEnd = 164455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_1(TrackedMerchant x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_1_Internal_String_TrackedMerchant_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601191E RID: 71966 RVA: 0x00408140 File Offset: 0x00406340
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164455, XrefRangeEnd = 164457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_6(KeyValuePair<string, TrackedNPC> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_6_Internal_String_KeyValuePair_2_String_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601191F RID: 71967 RVA: 0x00408190 File Offset: 0x00406390
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164457, XrefRangeEnd = 164459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_2(KeyValuePair<string, bool> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_2_Internal_String_KeyValuePair_2_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011920 RID: 71968 RVA: 0x004081E0 File Offset: 0x004063E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164459, XrefRangeEnd = 164460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_3(ValueTuple<string, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_3_Internal_String_ValueTuple_2_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011921 RID: 71969 RVA: 0x00408230 File Offset: 0x00406430
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164460, XrefRangeEnd = 164462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_4(KeyValuePair<int, ValueTuple<int, List<Vector2Int>>> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_4_Internal_String_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011922 RID: 71970 RVA: 0x00408280 File Offset: 0x00406480
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 164462, XrefRangeEnd = 164492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PlayerSaveFile.DLCDaySceneSaveData _Classify_b__13_5()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_5_Internal_DLCDaySceneSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new PlayerSaveFile.DLCDaySceneSaveData(pointer);
				}

				// Token: 0x06011923 RID: 71971 RVA: 0x00098D9D File Offset: 0x00096F9D
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B61 RID: 23393
				// (get) Token: 0x06011924 RID: 71972 RVA: 0x004082B8 File Offset: 0x004064B8
				// (set) Token: 0x06011925 RID: 71973 RVA: 0x00098DA6 File Offset: 0x00096FA6
				public unsafe static PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B62 RID: 23394
				// (get) Token: 0x06011926 RID: 71974 RVA: 0x004082E0 File Offset: 0x004064E0
				// (set) Token: 0x06011927 RID: 71975 RVA: 0x00098DB8 File Offset: 0x00096FB8
				public unsafe static Func<TrackedCollectable, string> __9__13_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrackedCollectable, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B63 RID: 23395
				// (get) Token: 0x06011928 RID: 71976 RVA: 0x00408308 File Offset: 0x00406508
				// (set) Token: 0x06011929 RID: 71977 RVA: 0x00098DCA File Offset: 0x00096FCA
				public unsafe static Func<TrackedMerchant, string> __9__13_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<TrackedMerchant, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B64 RID: 23396
				// (get) Token: 0x0601192A RID: 71978 RVA: 0x00408330 File Offset: 0x00406530
				// (set) Token: 0x0601192B RID: 71979 RVA: 0x00098DDC File Offset: 0x00096FDC
				public unsafe static Func<KeyValuePair<string, TrackedNPC>, string> __9__13_6
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_6, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, TrackedNPC>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_6, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B65 RID: 23397
				// (get) Token: 0x0601192C RID: 71980 RVA: 0x00408358 File Offset: 0x00406558
				// (set) Token: 0x0601192D RID: 71981 RVA: 0x00098DEE File Offset: 0x00096FEE
				public unsafe static Func<KeyValuePair<string, bool>, string> __9__13_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, bool>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B66 RID: 23398
				// (get) Token: 0x0601192E RID: 71982 RVA: 0x00408380 File Offset: 0x00406580
				// (set) Token: 0x0601192F RID: 71983 RVA: 0x00098E00 File Offset: 0x00097000
				public unsafe static Func<ValueTuple<string, int>, string> __9__13_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<string, int>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B67 RID: 23399
				// (get) Token: 0x06011930 RID: 71984 RVA: 0x004083A8 File Offset: 0x004065A8
				// (set) Token: 0x06011931 RID: 71985 RVA: 0x00098E12 File Offset: 0x00097012
				public unsafe static Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, string> __9__13_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, ValueTuple<int, List<Vector2Int>>>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B68 RID: 23400
				// (get) Token: 0x06011932 RID: 71986 RVA: 0x004083D0 File Offset: 0x004065D0
				// (set) Token: 0x06011933 RID: 71987 RVA: 0x00098E24 File Offset: 0x00097024
				public unsafe static Func<PlayerSaveFile.DLCDaySceneSaveData> __9__13_5
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_5, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.DLCDaySceneSaveData>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeDaySceneSaveDataPartial.__c.NativeFieldInfoPtr___9__13_5, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B196 RID: 45462
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B197 RID: 45463
				private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

				// Token: 0x0400B198 RID: 45464
				private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

				// Token: 0x0400B199 RID: 45465
				private static readonly IntPtr NativeFieldInfoPtr___9__13_6;

				// Token: 0x0400B19A RID: 45466
				private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

				// Token: 0x0400B19B RID: 45467
				private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

				// Token: 0x0400B19C RID: 45468
				private static readonly IntPtr NativeFieldInfoPtr___9__13_4;

				// Token: 0x0400B19D RID: 45469
				private static readonly IntPtr NativeFieldInfoPtr___9__13_5;

				// Token: 0x0400B19E RID: 45470
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B19F RID: 45471
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_0_Internal_String_TrackedCollectable_0;

				// Token: 0x0400B1A0 RID: 45472
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_1_Internal_String_TrackedMerchant_0;

				// Token: 0x0400B1A1 RID: 45473
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_6_Internal_String_KeyValuePair_2_String_TrackedNPC_0;

				// Token: 0x0400B1A2 RID: 45474
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_2_Internal_String_KeyValuePair_2_String_Boolean_0;

				// Token: 0x0400B1A3 RID: 45475
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_3_Internal_String_ValueTuple_2_String_Int32_0;

				// Token: 0x0400B1A4 RID: 45476
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_4_Internal_String_KeyValuePair_2_Int32_ValueTuple_2_Int32_List_1_Vector2Int_0;

				// Token: 0x0400B1A5 RID: 45477
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_5_Internal_DLCDaySceneSaveData_0;
			}
		}

		// Token: 0x02000A22 RID: 2594
		public sealed class RunTimePlayerSaveDataPartial : ValueType
		{
			// Token: 0x0600C48A RID: 50314 RVA: 0x0030E1F4 File Offset: 0x0030C3F4
			// Note: this type is marked as 'beforefieldinit'.
			static RunTimePlayerSaveDataPartial()
			{
				Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "RunTimePlayerSaveDataPartial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr);
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_gameDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "gameDate");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_fund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "fund");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_exp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "exp");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "level");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_canPerform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "canPerform");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_canOpenNoteStorageEscape = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "canOpenNoteStorageEscape");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldSpawnSpecialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "shouldSpawnSpecialGuests");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldShowSpecialGuestsInDay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "shouldShowSpecialGuestsInDay");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldHaveLevel5KizunaEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "shouldHaveLevel5KizunaEvent");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldSpawnTewi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "shouldSpawnTewi");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_currentLevelCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "currentLevelCap");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_bufferedExp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "bufferedExp");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_enableMultiPartner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "enableMultiPartner");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_maxPartnerCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "maxPartnerCount");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_historyPartnerSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "historyPartnerSelection");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_userIzakayaPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "userIzakayaPresets");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_collabStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "collabStatus");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popLikeFoodTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "popLikeFoodTags");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popLikeBevTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "popLikeBevTags");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popHateFoodTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "popHateFoodTags");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popHateBevTags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "popHateBevTags");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_rewindMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "rewindMode");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_prdTryTimeRecord = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "prdTryTimeRecord");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_hakureiMoneyBoxDonateNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "hakureiMoneyBoxDonateNum");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_defaultPropSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "defaultPropSelection");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_musicChapterStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "musicChapterStatus");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_haveChattedSGuestLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "haveChattedSGuestLabel");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_lockedRecipeList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "lockedRecipeList");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_lockingEventName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "lockingEventName");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_lockedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "lockedEvents");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_tryToUnLockEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "tryToUnLockEvents");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_controlledSpecialGuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "controlledSpecialGuests");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_useCreatorBoxData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "useCreatorBoxData");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_selectedCreatorBoxData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "selectedCreatorBoxData");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_selectedCreatorBoxDataPresets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "selectedCreatorBoxDataPresets");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_infiniteIngredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "infiniteIngredients");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_dlcLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, "dlcLock");
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, 100675831);
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_GameDate_Int64_Int32_Int32_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Boolean_Int32_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_Boolean_Dictionary_2_String_Boolean_Dictionary_2_String_Int32_Int64_Dictionary_2_DefaultProp_List_1_Int32_Dictionary_2_Int32_List_1_HistoryIzakayaMenuSelection_List_1_String_Dictionary_2_String_List_1_String_List_1_Int32_String_List_1_String_List_1_String_List_1_Cont = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, 100675832);
				PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimePlayerSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr, 100675833);
			}

			// Token: 0x0600C48B RID: 50315 RVA: 0x0030E540 File Offset: 0x0030C740
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 164923, RefRangeEnd = 164924, XrefRangeStart = 164910, XrefRangeEnd = 164923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600C48C RID: 50316 RVA: 0x0030E57C File Offset: 0x0030C77C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 165036, RefRangeEnd = 165039, XrefRangeStart = 164924, XrefRangeEnd = 165036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunTimePlayerSaveDataPartial(GameDate gameDate, long fund, int exp, int level, bool canPerform, bool canOpenNoteAndStorage, bool shouldSpawnSpecialGuests, bool shouldShowSpecialGuestsInDay, bool shouldHaveLevel5KizunaEvent, bool shouldSpawnTewi, int currentLevelCap, int bufferedExp, bool enableMultiPartner, int maxPartnerCount, Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> historyPartnerSelection, List<int> popLikeFoodTags, List<int> popLikeBevTags, List<int> popHateFoodTags, List<int> popHateBevTags, bool rewindMode, Dictionary<string, bool> collabStatus, Dictionary<string, int> prdTryTimeRecord, long hakureiMoneyBoxDonateNum, Dictionary<PlayerSaveFile.DefaultProp, List<int>> defaultPropSelection, Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>> userIzakayaPresets, List<string> haveChattedSGuestLabel, Dictionary<string, List<string>> musicChapterStatus, List<int> lockedRecipeList, string lockingEventName, List<string> lockedEvents, List<string> tryToUnLockEvents, List<ControlledSpecialGuest> controlledSpecialGuests, bool useCreatorBoxData, Nullable<CreatorBoxData> selectedCreatorBoxData, Il2CppReferenceArray<Nullable<CreatorBoxData>> selectedCreatorBoxDataPresets, List<Nullable<int>> infiniteIngredients, HashSet<string> dlcLock) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)37) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref gameDate;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fund;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exp;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref level;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canPerform;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref canOpenNoteAndStorage;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldSpawnSpecialGuests;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldShowSpecialGuestsInDay;
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldHaveLevel5KizunaEvent;
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldSpawnTewi;
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentLevelCap;
				ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bufferedExp;
				ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableMultiPartner;
				ptr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxPartnerCount;
				ptr[checked(unchecked((UIntPtr)14) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(historyPartnerSelection);
				ptr[checked(unchecked((UIntPtr)15) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(popLikeFoodTags);
				ptr[checked(unchecked((UIntPtr)16) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(popLikeBevTags);
				ptr[checked(unchecked((UIntPtr)17) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(popHateFoodTags);
				ptr[checked(unchecked((UIntPtr)18) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(popHateBevTags);
				ptr[checked(unchecked((UIntPtr)19) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rewindMode;
				ptr[checked(unchecked((UIntPtr)20) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(collabStatus);
				ptr[checked(unchecked((UIntPtr)21) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(prdTryTimeRecord);
				ptr[checked(unchecked((UIntPtr)22) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hakureiMoneyBoxDonateNum;
				ptr[checked(unchecked((UIntPtr)23) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultPropSelection);
				ptr[checked(unchecked((UIntPtr)24) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(userIzakayaPresets);
				ptr[checked(unchecked((UIntPtr)25) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(haveChattedSGuestLabel);
				ptr[checked(unchecked((UIntPtr)26) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(musicChapterStatus);
				ptr[checked(unchecked((UIntPtr)27) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockedRecipeList);
				ptr[checked(unchecked((UIntPtr)28) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lockingEventName);
				ptr[checked(unchecked((UIntPtr)29) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lockedEvents);
				ptr[checked(unchecked((UIntPtr)30) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tryToUnLockEvents);
				ptr[checked(unchecked((UIntPtr)31) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(controlledSpecialGuests);
				ptr[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref useCreatorBoxData;
				ptr[checked(unchecked((UIntPtr)33) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(selectedCreatorBoxData));
				ptr[checked(unchecked((UIntPtr)34) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(selectedCreatorBoxDataPresets);
				ptr[checked(unchecked((UIntPtr)35) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(infiniteIngredients);
				ptr[checked(unchecked((UIntPtr)36) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dlcLock);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_GameDate_Int64_Int32_Int32_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Boolean_Int32_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_Boolean_Dictionary_2_String_Boolean_Dictionary_2_String_Int32_Int64_Dictionary_2_DefaultProp_List_1_Int32_Dictionary_2_Int32_List_1_HistoryIzakayaMenuSelection_List_1_String_Dictionary_2_String_List_1_String_List_1_Int32_String_List_1_String_List_1_String_List_1_Cont, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C48D RID: 50317 RVA: 0x0030E848 File Offset: 0x0030CA48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165039, XrefRangeEnd = 165041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveFile.RunTimePlayerSaveDataPartial Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimePlayerSaveDataPartial_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.RunTimePlayerSaveDataPartial(pointer);
			}

			// Token: 0x0600C48E RID: 50318 RVA: 0x00069EA4 File Offset: 0x000680A4
			public RunTimePlayerSaveDataPartial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C48F RID: 50319 RVA: 0x00069EAD File Offset: 0x000680AD
			public RunTimePlayerSaveDataPartial() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimePlayerSaveDataPartial>.NativeClassPtr))
			{
			}

			// Token: 0x17003FEA RID: 16362
			// (get) Token: 0x0600C490 RID: 50320 RVA: 0x0030E884 File Offset: 0x0030CA84
			// (set) Token: 0x0600C491 RID: 50321 RVA: 0x00069EBF File Offset: 0x000680BF
			public unsafe GameDate gameDate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_gameDate);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_gameDate)) = value;
				}
			}

			// Token: 0x17003FEB RID: 16363
			// (get) Token: 0x0600C492 RID: 50322 RVA: 0x0030E8AC File Offset: 0x0030CAAC
			// (set) Token: 0x0600C493 RID: 50323 RVA: 0x00069EDA File Offset: 0x000680DA
			public unsafe long fund
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_fund);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_fund)) = value;
				}
			}

			// Token: 0x17003FEC RID: 16364
			// (get) Token: 0x0600C494 RID: 50324 RVA: 0x0030E8D4 File Offset: 0x0030CAD4
			// (set) Token: 0x0600C495 RID: 50325 RVA: 0x00069EF5 File Offset: 0x000680F5
			public unsafe int exp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_exp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_exp)) = value;
				}
			}

			// Token: 0x17003FED RID: 16365
			// (get) Token: 0x0600C496 RID: 50326 RVA: 0x0030E8FC File Offset: 0x0030CAFC
			// (set) Token: 0x0600C497 RID: 50327 RVA: 0x00069F10 File Offset: 0x00068110
			public unsafe int level
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_level);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_level)) = value;
				}
			}

			// Token: 0x17003FEE RID: 16366
			// (get) Token: 0x0600C498 RID: 50328 RVA: 0x0030E924 File Offset: 0x0030CB24
			// (set) Token: 0x0600C499 RID: 50329 RVA: 0x00069F2B File Offset: 0x0006812B
			public unsafe bool canPerform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_canPerform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_canPerform)) = value;
				}
			}

			// Token: 0x17003FEF RID: 16367
			// (get) Token: 0x0600C49A RID: 50330 RVA: 0x0030E94C File Offset: 0x0030CB4C
			// (set) Token: 0x0600C49B RID: 50331 RVA: 0x00069F46 File Offset: 0x00068146
			public unsafe bool canOpenNoteStorageEscape
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_canOpenNoteStorageEscape);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_canOpenNoteStorageEscape)) = value;
				}
			}

			// Token: 0x17003FF0 RID: 16368
			// (get) Token: 0x0600C49C RID: 50332 RVA: 0x0030E974 File Offset: 0x0030CB74
			// (set) Token: 0x0600C49D RID: 50333 RVA: 0x00069F61 File Offset: 0x00068161
			public unsafe bool shouldSpawnSpecialGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldSpawnSpecialGuests);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldSpawnSpecialGuests)) = value;
				}
			}

			// Token: 0x17003FF1 RID: 16369
			// (get) Token: 0x0600C49E RID: 50334 RVA: 0x0030E99C File Offset: 0x0030CB9C
			// (set) Token: 0x0600C49F RID: 50335 RVA: 0x00069F7C File Offset: 0x0006817C
			public unsafe bool shouldShowSpecialGuestsInDay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldShowSpecialGuestsInDay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldShowSpecialGuestsInDay)) = value;
				}
			}

			// Token: 0x17003FF2 RID: 16370
			// (get) Token: 0x0600C4A0 RID: 50336 RVA: 0x0030E9C4 File Offset: 0x0030CBC4
			// (set) Token: 0x0600C4A1 RID: 50337 RVA: 0x00069F97 File Offset: 0x00068197
			public unsafe bool shouldHaveLevel5KizunaEvent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldHaveLevel5KizunaEvent);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldHaveLevel5KizunaEvent)) = value;
				}
			}

			// Token: 0x17003FF3 RID: 16371
			// (get) Token: 0x0600C4A2 RID: 50338 RVA: 0x0030E9EC File Offset: 0x0030CBEC
			// (set) Token: 0x0600C4A3 RID: 50339 RVA: 0x00069FB2 File Offset: 0x000681B2
			public unsafe bool shouldSpawnTewi
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldSpawnTewi);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_shouldSpawnTewi)) = value;
				}
			}

			// Token: 0x17003FF4 RID: 16372
			// (get) Token: 0x0600C4A4 RID: 50340 RVA: 0x0030EA14 File Offset: 0x0030CC14
			// (set) Token: 0x0600C4A5 RID: 50341 RVA: 0x00069FCD File Offset: 0x000681CD
			public unsafe int currentLevelCap
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_currentLevelCap);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_currentLevelCap)) = value;
				}
			}

			// Token: 0x17003FF5 RID: 16373
			// (get) Token: 0x0600C4A6 RID: 50342 RVA: 0x0030EA3C File Offset: 0x0030CC3C
			// (set) Token: 0x0600C4A7 RID: 50343 RVA: 0x00069FE8 File Offset: 0x000681E8
			public unsafe int bufferedExp
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_bufferedExp);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_bufferedExp)) = value;
				}
			}

			// Token: 0x17003FF6 RID: 16374
			// (get) Token: 0x0600C4A8 RID: 50344 RVA: 0x0030EA64 File Offset: 0x0030CC64
			// (set) Token: 0x0600C4A9 RID: 50345 RVA: 0x0006A003 File Offset: 0x00068203
			public unsafe bool enableMultiPartner
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_enableMultiPartner);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_enableMultiPartner)) = value;
				}
			}

			// Token: 0x17003FF7 RID: 16375
			// (get) Token: 0x0600C4AA RID: 50346 RVA: 0x0030EA8C File Offset: 0x0030CC8C
			// (set) Token: 0x0600C4AB RID: 50347 RVA: 0x0006A01E File Offset: 0x0006821E
			public unsafe int maxPartnerCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_maxPartnerCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_maxPartnerCount)) = value;
				}
			}

			// Token: 0x17003FF8 RID: 16376
			// (get) Token: 0x0600C4AC RID: 50348 RVA: 0x0030EAB4 File Offset: 0x0030CCB4
			// (set) Token: 0x0600C4AD RID: 50349 RVA: 0x0006A039 File Offset: 0x00068239
			public unsafe Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>> historyPartnerSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_historyPartnerSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ValueTuple<int, PartnerBase.PartnerType>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_historyPartnerSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FF9 RID: 16377
			// (get) Token: 0x0600C4AE RID: 50350 RVA: 0x0030EAE4 File Offset: 0x0030CCE4
			// (set) Token: 0x0600C4AF RID: 50351 RVA: 0x0006A058 File Offset: 0x00068258
			public unsafe Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>> userIzakayaPresets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_userIzakayaPresets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<PlayerSaveFile.HistoryIzakayaMenuSelection>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_userIzakayaPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFA RID: 16378
			// (get) Token: 0x0600C4B0 RID: 50352 RVA: 0x0030EB14 File Offset: 0x0030CD14
			// (set) Token: 0x0600C4B1 RID: 50353 RVA: 0x0006A077 File Offset: 0x00068277
			public unsafe Dictionary<string, bool> collabStatus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_collabStatus);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_collabStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFB RID: 16379
			// (get) Token: 0x0600C4B2 RID: 50354 RVA: 0x0030EB44 File Offset: 0x0030CD44
			// (set) Token: 0x0600C4B3 RID: 50355 RVA: 0x0006A096 File Offset: 0x00068296
			public unsafe List<int> popLikeFoodTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popLikeFoodTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popLikeFoodTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFC RID: 16380
			// (get) Token: 0x0600C4B4 RID: 50356 RVA: 0x0030EB74 File Offset: 0x0030CD74
			// (set) Token: 0x0600C4B5 RID: 50357 RVA: 0x0006A0B5 File Offset: 0x000682B5
			public unsafe List<int> popLikeBevTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popLikeBevTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popLikeBevTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFD RID: 16381
			// (get) Token: 0x0600C4B6 RID: 50358 RVA: 0x0030EBA4 File Offset: 0x0030CDA4
			// (set) Token: 0x0600C4B7 RID: 50359 RVA: 0x0006A0D4 File Offset: 0x000682D4
			public unsafe List<int> popHateFoodTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popHateFoodTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popHateFoodTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFE RID: 16382
			// (get) Token: 0x0600C4B8 RID: 50360 RVA: 0x0030EBD4 File Offset: 0x0030CDD4
			// (set) Token: 0x0600C4B9 RID: 50361 RVA: 0x0006A0F3 File Offset: 0x000682F3
			public unsafe List<int> popHateBevTags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popHateBevTags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_popHateBevTags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003FFF RID: 16383
			// (get) Token: 0x0600C4BA RID: 50362 RVA: 0x0030EC04 File Offset: 0x0030CE04
			// (set) Token: 0x0600C4BB RID: 50363 RVA: 0x0006A112 File Offset: 0x00068312
			public unsafe bool rewindMode
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_rewindMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_rewindMode)) = value;
				}
			}

			// Token: 0x17004000 RID: 16384
			// (get) Token: 0x0600C4BC RID: 50364 RVA: 0x0030EC2C File Offset: 0x0030CE2C
			// (set) Token: 0x0600C4BD RID: 50365 RVA: 0x0006A12D File Offset: 0x0006832D
			public unsafe Dictionary<string, int> prdTryTimeRecord
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_prdTryTimeRecord);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_prdTryTimeRecord), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004001 RID: 16385
			// (get) Token: 0x0600C4BE RID: 50366 RVA: 0x0030EC5C File Offset: 0x0030CE5C
			// (set) Token: 0x0600C4BF RID: 50367 RVA: 0x0006A14C File Offset: 0x0006834C
			public unsafe long hakureiMoneyBoxDonateNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_hakureiMoneyBoxDonateNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_hakureiMoneyBoxDonateNum)) = value;
				}
			}

			// Token: 0x17004002 RID: 16386
			// (get) Token: 0x0600C4C0 RID: 50368 RVA: 0x0030EC84 File Offset: 0x0030CE84
			// (set) Token: 0x0600C4C1 RID: 50369 RVA: 0x0006A167 File Offset: 0x00068367
			public unsafe Dictionary<PlayerSaveFile.DefaultProp, List<int>> defaultPropSelection
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_defaultPropSelection);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<PlayerSaveFile.DefaultProp, List<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_defaultPropSelection), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004003 RID: 16387
			// (get) Token: 0x0600C4C2 RID: 50370 RVA: 0x0030ECB4 File Offset: 0x0030CEB4
			// (set) Token: 0x0600C4C3 RID: 50371 RVA: 0x0006A186 File Offset: 0x00068386
			public unsafe Dictionary<string, List<string>> musicChapterStatus
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_musicChapterStatus);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_musicChapterStatus), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004004 RID: 16388
			// (get) Token: 0x0600C4C4 RID: 50372 RVA: 0x0030ECE4 File Offset: 0x0030CEE4
			// (set) Token: 0x0600C4C5 RID: 50373 RVA: 0x0006A1A5 File Offset: 0x000683A5
			public unsafe List<string> haveChattedSGuestLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_haveChattedSGuestLabel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_haveChattedSGuestLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004005 RID: 16389
			// (get) Token: 0x0600C4C6 RID: 50374 RVA: 0x0030ED14 File Offset: 0x0030CF14
			// (set) Token: 0x0600C4C7 RID: 50375 RVA: 0x0006A1C4 File Offset: 0x000683C4
			public unsafe List<int> lockedRecipeList
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_lockedRecipeList);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_lockedRecipeList), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004006 RID: 16390
			// (get) Token: 0x0600C4C8 RID: 50376 RVA: 0x0030ED44 File Offset: 0x0030CF44
			// (set) Token: 0x0600C4C9 RID: 50377 RVA: 0x0006A1E3 File Offset: 0x000683E3
			public unsafe string lockingEventName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_lockingEventName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_lockingEventName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004007 RID: 16391
			// (get) Token: 0x0600C4CA RID: 50378 RVA: 0x0030ED6C File Offset: 0x0030CF6C
			// (set) Token: 0x0600C4CB RID: 50379 RVA: 0x0006A202 File Offset: 0x00068402
			public unsafe List<string> lockedEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_lockedEvents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_lockedEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004008 RID: 16392
			// (get) Token: 0x0600C4CC RID: 50380 RVA: 0x0030ED9C File Offset: 0x0030CF9C
			// (set) Token: 0x0600C4CD RID: 50381 RVA: 0x0006A221 File Offset: 0x00068421
			public unsafe List<string> tryToUnLockEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_tryToUnLockEvents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_tryToUnLockEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004009 RID: 16393
			// (get) Token: 0x0600C4CE RID: 50382 RVA: 0x0030EDCC File Offset: 0x0030CFCC
			// (set) Token: 0x0600C4CF RID: 50383 RVA: 0x0006A240 File Offset: 0x00068440
			public unsafe List<ControlledSpecialGuest> controlledSpecialGuests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_controlledSpecialGuests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ControlledSpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_controlledSpecialGuests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700400A RID: 16394
			// (get) Token: 0x0600C4D0 RID: 50384 RVA: 0x0030EDFC File Offset: 0x0030CFFC
			// (set) Token: 0x0600C4D1 RID: 50385 RVA: 0x0006A25F File Offset: 0x0006845F
			public unsafe bool useCreatorBoxData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_useCreatorBoxData);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_useCreatorBoxData)) = value;
				}
			}

			// Token: 0x1700400B RID: 16395
			// (get) Token: 0x0600C4D2 RID: 50386 RVA: 0x0030EE24 File Offset: 0x0030D024
			// (set) Token: 0x0600C4D3 RID: 50387 RVA: 0x0006A27A File Offset: 0x0006847A
			public Nullable<CreatorBoxData> selectedCreatorBoxData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_selectedCreatorBoxData);
					return new Nullable<CreatorBoxData>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<CreatorBoxData>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_selectedCreatorBoxData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<CreatorBoxData>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700400C RID: 16396
			// (get) Token: 0x0600C4D4 RID: 50388 RVA: 0x0030EE54 File Offset: 0x0030D054
			// (set) Token: 0x0600C4D5 RID: 50389 RVA: 0x0006A2A8 File Offset: 0x000684A8
			public unsafe Il2CppReferenceArray<Nullable<CreatorBoxData>> selectedCreatorBoxDataPresets
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_selectedCreatorBoxDataPresets);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Nullable<CreatorBoxData>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_selectedCreatorBoxDataPresets), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700400D RID: 16397
			// (get) Token: 0x0600C4D6 RID: 50390 RVA: 0x0030EE84 File Offset: 0x0030D084
			// (set) Token: 0x0600C4D7 RID: 50391 RVA: 0x0006A2C7 File Offset: 0x000684C7
			public unsafe List<Nullable<int>> infiniteIngredients
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_infiniteIngredients);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Nullable<int>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_infiniteIngredients), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700400E RID: 16398
			// (get) Token: 0x0600C4D8 RID: 50392 RVA: 0x0030EEB4 File Offset: 0x0030D0B4
			// (set) Token: 0x0600C4D9 RID: 50393 RVA: 0x0006A2E6 File Offset: 0x000684E6
			public unsafe HashSet<string> dlcLock
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_dlcLock);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimePlayerSaveDataPartial.NativeFieldInfoPtr_dlcLock), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007E67 RID: 32359
			private static readonly IntPtr NativeFieldInfoPtr_gameDate;

			// Token: 0x04007E68 RID: 32360
			private static readonly IntPtr NativeFieldInfoPtr_fund;

			// Token: 0x04007E69 RID: 32361
			private static readonly IntPtr NativeFieldInfoPtr_exp;

			// Token: 0x04007E6A RID: 32362
			private static readonly IntPtr NativeFieldInfoPtr_level;

			// Token: 0x04007E6B RID: 32363
			private static readonly IntPtr NativeFieldInfoPtr_canPerform;

			// Token: 0x04007E6C RID: 32364
			private static readonly IntPtr NativeFieldInfoPtr_canOpenNoteStorageEscape;

			// Token: 0x04007E6D RID: 32365
			private static readonly IntPtr NativeFieldInfoPtr_shouldSpawnSpecialGuests;

			// Token: 0x04007E6E RID: 32366
			private static readonly IntPtr NativeFieldInfoPtr_shouldShowSpecialGuestsInDay;

			// Token: 0x04007E6F RID: 32367
			private static readonly IntPtr NativeFieldInfoPtr_shouldHaveLevel5KizunaEvent;

			// Token: 0x04007E70 RID: 32368
			private static readonly IntPtr NativeFieldInfoPtr_shouldSpawnTewi;

			// Token: 0x04007E71 RID: 32369
			private static readonly IntPtr NativeFieldInfoPtr_currentLevelCap;

			// Token: 0x04007E72 RID: 32370
			private static readonly IntPtr NativeFieldInfoPtr_bufferedExp;

			// Token: 0x04007E73 RID: 32371
			private static readonly IntPtr NativeFieldInfoPtr_enableMultiPartner;

			// Token: 0x04007E74 RID: 32372
			private static readonly IntPtr NativeFieldInfoPtr_maxPartnerCount;

			// Token: 0x04007E75 RID: 32373
			private static readonly IntPtr NativeFieldInfoPtr_historyPartnerSelection;

			// Token: 0x04007E76 RID: 32374
			private static readonly IntPtr NativeFieldInfoPtr_userIzakayaPresets;

			// Token: 0x04007E77 RID: 32375
			private static readonly IntPtr NativeFieldInfoPtr_collabStatus;

			// Token: 0x04007E78 RID: 32376
			private static readonly IntPtr NativeFieldInfoPtr_popLikeFoodTags;

			// Token: 0x04007E79 RID: 32377
			private static readonly IntPtr NativeFieldInfoPtr_popLikeBevTags;

			// Token: 0x04007E7A RID: 32378
			private static readonly IntPtr NativeFieldInfoPtr_popHateFoodTags;

			// Token: 0x04007E7B RID: 32379
			private static readonly IntPtr NativeFieldInfoPtr_popHateBevTags;

			// Token: 0x04007E7C RID: 32380
			private static readonly IntPtr NativeFieldInfoPtr_rewindMode;

			// Token: 0x04007E7D RID: 32381
			private static readonly IntPtr NativeFieldInfoPtr_prdTryTimeRecord;

			// Token: 0x04007E7E RID: 32382
			private static readonly IntPtr NativeFieldInfoPtr_hakureiMoneyBoxDonateNum;

			// Token: 0x04007E7F RID: 32383
			private static readonly IntPtr NativeFieldInfoPtr_defaultPropSelection;

			// Token: 0x04007E80 RID: 32384
			private static readonly IntPtr NativeFieldInfoPtr_musicChapterStatus;

			// Token: 0x04007E81 RID: 32385
			private static readonly IntPtr NativeFieldInfoPtr_haveChattedSGuestLabel;

			// Token: 0x04007E82 RID: 32386
			private static readonly IntPtr NativeFieldInfoPtr_lockedRecipeList;

			// Token: 0x04007E83 RID: 32387
			private static readonly IntPtr NativeFieldInfoPtr_lockingEventName;

			// Token: 0x04007E84 RID: 32388
			private static readonly IntPtr NativeFieldInfoPtr_lockedEvents;

			// Token: 0x04007E85 RID: 32389
			private static readonly IntPtr NativeFieldInfoPtr_tryToUnLockEvents;

			// Token: 0x04007E86 RID: 32390
			private static readonly IntPtr NativeFieldInfoPtr_controlledSpecialGuests;

			// Token: 0x04007E87 RID: 32391
			private static readonly IntPtr NativeFieldInfoPtr_useCreatorBoxData;

			// Token: 0x04007E88 RID: 32392
			private static readonly IntPtr NativeFieldInfoPtr_selectedCreatorBoxData;

			// Token: 0x04007E89 RID: 32393
			private static readonly IntPtr NativeFieldInfoPtr_selectedCreatorBoxDataPresets;

			// Token: 0x04007E8A RID: 32394
			private static readonly IntPtr NativeFieldInfoPtr_infiniteIngredients;

			// Token: 0x04007E8B RID: 32395
			private static readonly IntPtr NativeFieldInfoPtr_dlcLock;

			// Token: 0x04007E8C RID: 32396
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04007E8D RID: 32397
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameDate_Int64_Int32_Int32_Boolean_Boolean_Boolean_Boolean_Boolean_Boolean_Int32_Int32_Boolean_Int32_Il2CppReferenceArray_1_ValueTuple_2_Int32_PartnerType_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_Boolean_Dictionary_2_String_Boolean_Dictionary_2_String_Int32_Int64_Dictionary_2_DefaultProp_List_1_Int32_Dictionary_2_Int32_List_1_HistoryIzakayaMenuSelection_List_1_String_Dictionary_2_String_List_1_String_List_1_Int32_String_List_1_String_List_1_String_List_1_Cont;

			// Token: 0x04007E8E RID: 32398
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimePlayerSaveDataPartial_0;
		}

		// Token: 0x02000A23 RID: 2595
		public sealed class RunTimeSchedulerSaveDataPartial : ValueType
		{
			// Token: 0x0600C4DA RID: 50394 RVA: 0x0030EEE4 File Offset: 0x0030D0E4
			// Note: this type is marked as 'beforefieldinit'.
			static RunTimeSchedulerSaveDataPartial()
			{
				Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "RunTimeSchedulerSaveDataPartial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr);
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_lastMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "lastMission");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_scheduledEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "scheduledEvents");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_scheduledNews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "scheduledNews");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_scheduledNewsReplaceContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "scheduledNewsReplaceContents");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_allTrackingMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "allTrackingMissions");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_finishedEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "finishedEvents");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_finishedMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "finishedMissions");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_newsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "newsData");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_newsDataArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "newsDataArray");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_registeredObjectPriceModifierMem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "registeredObjectPriceModifierMem");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_CACHED_YUYUKO_TUTORIAL_FINISHED_MARK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "CACHED_YUYUKO_TUTORIAL_FINISHED_MARK");
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_Dictionary_2_Int32_List_1_TrackedMissionData_Il2CppStringArray_Il2CppStringArray_List_1_KeyValuePair_2_KeyValuePair_2_ObjectType_Int32_Single_Il2CppReferenceArray_1_HistoryNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, 100675834);
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_DLCSchedulerSaveData_String_List_1_KeyValuePair_2_KeyValuePair_2_ObjectType_Int32_Single_Il2CppReferenceArray_1_HistoryNewsData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, 100675835);
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimePlayerSaveDataPartial_byref_RunTimeSchedulerSaveDataPartial_byref_RunTimeSchedulerSaveDataPartial_byref_Dictionary_2_String_DLCSchedulerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, 100675836);
				PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeSchedulerSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, 100675837);
			}

			// Token: 0x0600C4DB RID: 50395 RVA: 0x0030F03C File Offset: 0x0030D23C
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 165111, RefRangeEnd = 165114, XrefRangeStart = 165075, XrefRangeEnd = 165111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunTimeSchedulerSaveDataPartial(string lastMission, Dictionary<int, List<string>> scheduledEvents, Dictionary<int, List<string>> scheduledNews, Dictionary<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>> scheduledNewsReplaceContents, Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> allTrackingMissions, Il2CppStringArray finishedEvents, Il2CppStringArray finishedMissions, List<KeyValuePair<KeyValuePair<SchedulerNode.Reward.ObjectType, int>, float>> registeredObjectPriceModifierMem, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData> newsDataArray) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lastMission);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduledEvents);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduledNews);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(scheduledNewsReplaceContents);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(allTrackingMissions);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finishedEvents);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(finishedMissions);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registeredObjectPriceModifierMem);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newsDataArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_Dictionary_2_Int32_List_1_TrackedMissionData_Il2CppStringArray_Il2CppStringArray_List_1_KeyValuePair_2_KeyValuePair_2_ObjectType_Int32_Single_Il2CppReferenceArray_1_HistoryNewsData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4DC RID: 50396 RVA: 0x0030F124 File Offset: 0x0030D324
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 165127, RefRangeEnd = 165128, XrefRangeStart = 165114, XrefRangeEnd = 165127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunTimeSchedulerSaveDataPartial(PlayerSaveFile.DLCSchedulerSaveData defaultDLCSchedulerSaveData, string lastMission, List<KeyValuePair<KeyValuePair<SchedulerNode.Reward.ObjectType, int>, float>> registeredObjectPriceModifierMem, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData> newsDataArray) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(defaultDLCSchedulerSaveData));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(lastMission);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(registeredObjectPriceModifierMem);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(newsDataArray);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_DLCSchedulerSaveData_String_List_1_KeyValuePair_2_KeyValuePair_2_ObjectType_Int32_Single_Il2CppReferenceArray_1_HistoryNewsData_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4DD RID: 50397 RVA: 0x0030F1B0 File Offset: 0x0030D3B0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 165386, RefRangeEnd = 165387, XrefRangeStart = 165128, XrefRangeEnd = 165386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Classify([In] ref PlayerSaveFile.RunTimePlayerSaveDataPartial playerPartial, [In] ref PlayerSaveFile.RunTimeSchedulerSaveDataPartial schedulerPartial, ref PlayerSaveFile.RunTimeSchedulerSaveDataPartial schedulerPartialSaveData, ref Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData> schedulerPartialDLCSaveData)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(playerPartial);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(schedulerPartial);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(schedulerPartialSaveData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(schedulerPartialDLCSaveData);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimePlayerSaveDataPartial_byref_RunTimeSchedulerSaveDataPartial_byref_RunTimeSchedulerSaveDataPartial_byref_Dictionary_2_String_DLCSchedulerSaveData_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				schedulerPartialDLCSaveData = ((intPtr4 == 0) ? null : new Dictionary<string, PlayerSaveFile.DLCSchedulerSaveData>(intPtr4));
			}

			// Token: 0x0600C4DE RID: 50398 RVA: 0x0030F234 File Offset: 0x0030D434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165387, XrefRangeEnd = 165388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveFile.RunTimeSchedulerSaveDataPartial Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeSchedulerSaveDataPartial_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.RunTimeSchedulerSaveDataPartial(pointer);
			}

			// Token: 0x0600C4DF RID: 50399 RVA: 0x0006A305 File Offset: 0x00068505
			public RunTimeSchedulerSaveDataPartial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C4E0 RID: 50400 RVA: 0x0006A30E File Offset: 0x0006850E
			public RunTimeSchedulerSaveDataPartial() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr))
			{
			}

			// Token: 0x1700400F RID: 16399
			// (get) Token: 0x0600C4E1 RID: 50401 RVA: 0x0030F270 File Offset: 0x0030D470
			// (set) Token: 0x0600C4E2 RID: 50402 RVA: 0x0006A320 File Offset: 0x00068520
			public unsafe string lastMission
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_lastMission);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_lastMission), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004010 RID: 16400
			// (get) Token: 0x0600C4E3 RID: 50403 RVA: 0x0030F298 File Offset: 0x0030D498
			// (set) Token: 0x0600C4E4 RID: 50404 RVA: 0x0006A33F File Offset: 0x0006853F
			public unsafe Dictionary<int, List<string>> scheduledEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_scheduledEvents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_scheduledEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004011 RID: 16401
			// (get) Token: 0x0600C4E5 RID: 50405 RVA: 0x0030F2C8 File Offset: 0x0030D4C8
			// (set) Token: 0x0600C4E6 RID: 50406 RVA: 0x0006A35E File Offset: 0x0006855E
			public unsafe Dictionary<int, List<string>> scheduledNews
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_scheduledNews);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<string>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_scheduledNews), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004012 RID: 16402
			// (get) Token: 0x0600C4E7 RID: 50407 RVA: 0x0030F2F8 File Offset: 0x0030D4F8
			// (set) Token: 0x0600C4E8 RID: 50408 RVA: 0x0006A37D File Offset: 0x0006857D
			public unsafe Dictionary<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>> scheduledNewsReplaceContents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_scheduledNewsReplaceContents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_scheduledNewsReplaceContents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004013 RID: 16403
			// (get) Token: 0x0600C4E9 RID: 50409 RVA: 0x0030F328 File Offset: 0x0030D528
			// (set) Token: 0x0600C4EA RID: 50410 RVA: 0x0006A39C File Offset: 0x0006859C
			public unsafe Dictionary<int, List<RunTimeScheduler.TrackedMissionData>> allTrackingMissions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_allTrackingMissions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, List<RunTimeScheduler.TrackedMissionData>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_allTrackingMissions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004014 RID: 16404
			// (get) Token: 0x0600C4EB RID: 50411 RVA: 0x0030F358 File Offset: 0x0030D558
			// (set) Token: 0x0600C4EC RID: 50412 RVA: 0x0006A3BB File Offset: 0x000685BB
			public unsafe Il2CppStringArray finishedEvents
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_finishedEvents);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_finishedEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004015 RID: 16405
			// (get) Token: 0x0600C4ED RID: 50413 RVA: 0x0030F388 File Offset: 0x0030D588
			// (set) Token: 0x0600C4EE RID: 50414 RVA: 0x0006A3DA File Offset: 0x000685DA
			public unsafe Il2CppStringArray finishedMissions
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_finishedMissions);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_finishedMissions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004016 RID: 16406
			// (get) Token: 0x0600C4EF RID: 50415 RVA: 0x0030F3B8 File Offset: 0x0030D5B8
			// (set) Token: 0x0600C4F0 RID: 50416 RVA: 0x0006A3F9 File Offset: 0x000685F9
			public unsafe Il2CppReferenceArray<Tuple<Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData>, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData>>> newsData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_newsData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Tuple<Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData>, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_newsData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004017 RID: 16407
			// (get) Token: 0x0600C4F1 RID: 50417 RVA: 0x0030F3E8 File Offset: 0x0030D5E8
			// (set) Token: 0x0600C4F2 RID: 50418 RVA: 0x0006A418 File Offset: 0x00068618
			public unsafe Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData> newsDataArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_newsDataArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_newsDataArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004018 RID: 16408
			// (get) Token: 0x0600C4F3 RID: 50419 RVA: 0x0030F418 File Offset: 0x0030D618
			// (set) Token: 0x0600C4F4 RID: 50420 RVA: 0x0006A437 File Offset: 0x00068637
			public unsafe List<KeyValuePair<KeyValuePair<SchedulerNode.Reward.ObjectType, int>, float>> registeredObjectPriceModifierMem
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_registeredObjectPriceModifierMem);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<KeyValuePair<KeyValuePair<SchedulerNode.Reward.ObjectType, int>, float>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_registeredObjectPriceModifierMem), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004019 RID: 16409
			// (get) Token: 0x0600C4F5 RID: 50421 RVA: 0x0030F448 File Offset: 0x0030D648
			// (set) Token: 0x0600C4F6 RID: 50422 RVA: 0x0006A456 File Offset: 0x00068656
			public unsafe static string CACHED_YUYUKO_TUTORIAL_FINISHED_MARK
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_CACHED_YUYUKO_TUTORIAL_FINISHED_MARK, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.NativeFieldInfoPtr_CACHED_YUYUKO_TUTORIAL_FINISHED_MARK, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04007E8F RID: 32399
			private static readonly IntPtr NativeFieldInfoPtr_lastMission;

			// Token: 0x04007E90 RID: 32400
			private static readonly IntPtr NativeFieldInfoPtr_scheduledEvents;

			// Token: 0x04007E91 RID: 32401
			private static readonly IntPtr NativeFieldInfoPtr_scheduledNews;

			// Token: 0x04007E92 RID: 32402
			private static readonly IntPtr NativeFieldInfoPtr_scheduledNewsReplaceContents;

			// Token: 0x04007E93 RID: 32403
			private static readonly IntPtr NativeFieldInfoPtr_allTrackingMissions;

			// Token: 0x04007E94 RID: 32404
			private static readonly IntPtr NativeFieldInfoPtr_finishedEvents;

			// Token: 0x04007E95 RID: 32405
			private static readonly IntPtr NativeFieldInfoPtr_finishedMissions;

			// Token: 0x04007E96 RID: 32406
			private static readonly IntPtr NativeFieldInfoPtr_newsData;

			// Token: 0x04007E97 RID: 32407
			private static readonly IntPtr NativeFieldInfoPtr_newsDataArray;

			// Token: 0x04007E98 RID: 32408
			private static readonly IntPtr NativeFieldInfoPtr_registeredObjectPriceModifierMem;

			// Token: 0x04007E99 RID: 32409
			private static readonly IntPtr NativeFieldInfoPtr_CACHED_YUYUKO_TUTORIAL_FINISHED_MARK;

			// Token: 0x04007E9A RID: 32410
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_String_Dictionary_2_Int32_List_1_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_Dictionary_2_Int32_List_1_TrackedMissionData_Il2CppStringArray_Il2CppStringArray_List_1_KeyValuePair_2_KeyValuePair_2_ObjectType_Int32_Single_Il2CppReferenceArray_1_HistoryNewsData_0;

			// Token: 0x04007E9B RID: 32411
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLCSchedulerSaveData_String_List_1_KeyValuePair_2_KeyValuePair_2_ObjectType_Int32_Single_Il2CppReferenceArray_1_HistoryNewsData_0;

			// Token: 0x04007E9C RID: 32412
			private static readonly IntPtr NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimePlayerSaveDataPartial_byref_RunTimeSchedulerSaveDataPartial_byref_RunTimeSchedulerSaveDataPartial_byref_Dictionary_2_String_DLCSchedulerSaveData_0;

			// Token: 0x04007E9D RID: 32413
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeSchedulerSaveDataPartial_0;

			// Token: 0x02001007 RID: 4103
			[ObfuscatedName("GameData.RunTime.Common.PlayerSaveFile+RunTimeSchedulerSaveDataPartial+<>c__DisplayClass13_0")]
			public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
			{
				// Token: 0x06011934 RID: 71988 RVA: 0x004083F8 File Offset: 0x004065F8
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass13_0()
				{
					Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "<>c__DisplayClass13_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0>.NativeClassPtr);
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0.NativeFieldInfoPtr_currentDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0>.NativeClassPtr, "currentDate");
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0>.NativeClassPtr, 100675838);
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0.NativeMethodInfoPtr__Classify_b__6_Internal_DLCSchedulerSaveData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0>.NativeClassPtr, 100675839);
				}

				// Token: 0x06011935 RID: 71989 RVA: 0x00408460 File Offset: 0x00406660
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011936 RID: 71990 RVA: 0x0040849C File Offset: 0x0040669C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165041, XrefRangeEnd = 165069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PlayerSaveFile.DLCSchedulerSaveData _Classify_b__6()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0.NativeMethodInfoPtr__Classify_b__6_Internal_DLCSchedulerSaveData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new PlayerSaveFile.DLCSchedulerSaveData(pointer);
				}

				// Token: 0x06011937 RID: 71991 RVA: 0x00098E36 File Offset: 0x00097036
				public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B69 RID: 23401
				// (get) Token: 0x06011938 RID: 71992 RVA: 0x004084D4 File Offset: 0x004066D4
				// (set) Token: 0x06011939 RID: 71993 RVA: 0x00098E3F File Offset: 0x0009703F
				public unsafe int currentDate
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0.NativeFieldInfoPtr_currentDate);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c__DisplayClass13_0.NativeFieldInfoPtr_currentDate)) = value;
					}
				}

				// Token: 0x0400B1A6 RID: 45478
				private static readonly IntPtr NativeFieldInfoPtr_currentDate;

				// Token: 0x0400B1A7 RID: 45479
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B1A8 RID: 45480
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__6_Internal_DLCSchedulerSaveData_0;
			}

			// Token: 0x02001008 RID: 4104
			[ObfuscatedName("GameData.RunTime.Common.PlayerSaveFile+RunTimeSchedulerSaveDataPartial+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x0601193A RID: 71994 RVA: 0x004084FC File Offset: 0x004066FC
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr);
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, "<>9");
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, "<>9__13_0");
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, "<>9__13_1");
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, "<>9__13_2");
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, "<>9__13_3");
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, "<>9__13_4");
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, "<>9__13_5");
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, 100675841);
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, 100675842);
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, 100675843);
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_2_Internal_String_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, 100675844);
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_3_Internal_String_TrackedMissionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, 100675845);
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_4_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, 100675846);
					PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_5_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr, 100675847);
				}

				// Token: 0x0601193B RID: 71995 RVA: 0x00408640 File Offset: 0x00406840
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0601193C RID: 71996 RVA: 0x0040867C File Offset: 0x0040687C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165069, XrefRangeEnd = 165070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_0(string x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601193D RID: 71997 RVA: 0x004086C4 File Offset: 0x004068C4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165070, XrefRangeEnd = 165071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_1(string x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601193E RID: 71998 RVA: 0x0040870C File Offset: 0x0040690C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165071, XrefRangeEnd = 165073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_2(KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_2_Internal_String_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601193F RID: 71999 RVA: 0x0040875C File Offset: 0x0040695C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165073, XrefRangeEnd = 165075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_3(RunTimeScheduler.TrackedMissionData x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_3_Internal_String_TrackedMissionData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011940 RID: 72000 RVA: 0x004087A4 File Offset: 0x004069A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_4(string x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_4_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011941 RID: 72001 RVA: 0x004087EC File Offset: 0x004069EC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__13_5(string x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__13_5_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011942 RID: 72002 RVA: 0x00098E5A File Offset: 0x0009705A
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B6A RID: 23402
				// (get) Token: 0x06011943 RID: 72003 RVA: 0x00408834 File Offset: 0x00406A34
				// (set) Token: 0x06011944 RID: 72004 RVA: 0x00098E63 File Offset: 0x00097063
				public unsafe static PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B6B RID: 23403
				// (get) Token: 0x06011945 RID: 72005 RVA: 0x0040885C File Offset: 0x00406A5C
				// (set) Token: 0x06011946 RID: 72006 RVA: 0x00098E75 File Offset: 0x00097075
				public unsafe static Func<string, string> __9__13_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B6C RID: 23404
				// (get) Token: 0x06011947 RID: 72007 RVA: 0x00408884 File Offset: 0x00406A84
				// (set) Token: 0x06011948 RID: 72008 RVA: 0x00098E87 File Offset: 0x00097087
				public unsafe static Func<string, string> __9__13_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B6D RID: 23405
				// (get) Token: 0x06011949 RID: 72009 RVA: 0x004088AC File Offset: 0x00406AAC
				// (set) Token: 0x0601194A RID: 72010 RVA: 0x00098E99 File Offset: 0x00097099
				public unsafe static Func<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>, string> __9__13_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Il2CppReferenceArray<RunTimeScheduler.HistoryNewsData.ReplaceContent>>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B6E RID: 23406
				// (get) Token: 0x0601194B RID: 72011 RVA: 0x004088D4 File Offset: 0x00406AD4
				// (set) Token: 0x0601194C RID: 72012 RVA: 0x00098EAB File Offset: 0x000970AB
				public unsafe static Func<RunTimeScheduler.TrackedMissionData, string> __9__13_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<RunTimeScheduler.TrackedMissionData, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B6F RID: 23407
				// (get) Token: 0x0601194D RID: 72013 RVA: 0x004088FC File Offset: 0x00406AFC
				// (set) Token: 0x0601194E RID: 72014 RVA: 0x00098EBD File Offset: 0x000970BD
				public unsafe static Func<string, string> __9__13_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B70 RID: 23408
				// (get) Token: 0x0601194F RID: 72015 RVA: 0x00408924 File Offset: 0x00406B24
				// (set) Token: 0x06011950 RID: 72016 RVA: 0x00098ECF File Offset: 0x000970CF
				public unsafe static Func<string, string> __9__13_5
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_5, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeSchedulerSaveDataPartial.__c.NativeFieldInfoPtr___9__13_5, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B1A9 RID: 45481
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B1AA RID: 45482
				private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

				// Token: 0x0400B1AB RID: 45483
				private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

				// Token: 0x0400B1AC RID: 45484
				private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

				// Token: 0x0400B1AD RID: 45485
				private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

				// Token: 0x0400B1AE RID: 45486
				private static readonly IntPtr NativeFieldInfoPtr___9__13_4;

				// Token: 0x0400B1AF RID: 45487
				private static readonly IntPtr NativeFieldInfoPtr___9__13_5;

				// Token: 0x0400B1B0 RID: 45488
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B1B1 RID: 45489
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_0_Internal_String_String_0;

				// Token: 0x0400B1B2 RID: 45490
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_1_Internal_String_String_0;

				// Token: 0x0400B1B3 RID: 45491
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_2_Internal_String_KeyValuePair_2_String_Il2CppReferenceArray_1_ReplaceContent_0;

				// Token: 0x0400B1B4 RID: 45492
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_3_Internal_String_TrackedMissionData_0;

				// Token: 0x0400B1B5 RID: 45493
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_4_Internal_String_String_0;

				// Token: 0x0400B1B6 RID: 45494
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__13_5_Internal_String_String_0;
			}
		}

		// Token: 0x02000A24 RID: 2596
		[Serializable]
		public sealed class RunTimeStorageSaveDataPartial : ValueType
		{
			// Token: 0x0600C4F7 RID: 50423 RVA: 0x0030F468 File Offset: 0x0030D668
			// Note: this type is marked as 'beforefieldinit'.
			static RunTimeStorageSaveDataPartial()
			{
				Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile>.NativeClassPtr, "RunTimeStorageSaveDataPartial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr);
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_foods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "foods");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_beverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "beverages");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_ingredients = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "ingredients");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_cookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "cookers");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "items");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_badges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "badges");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_trophies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "trophies");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_itemsShouldDeleteTomorrow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "itemsShouldDeleteTomorrow");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_recipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "recipes");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_izakayas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "izakayas");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_unlockedPartners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "unlockedPartners");
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, 100675848);
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_ExtractValid_Public_Virtual_Final_New_Void_byref_RunTimeStorageSaveDataPartial_byref_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, 100675849);
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_Merge_Public_Static_RunTimeStorageSaveDataPartial_RunTimeStorageSaveDataPartial_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, 100675850);
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_EnusreFieldNotNull_Private_Static_Void_byref_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, 100675851);
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimeStorageSaveDataPartial_byref_RunTimeStorageSaveDataPartial_byref_Dictionary_2_String_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, 100675852);
				PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, 100675853);
			}

			// Token: 0x0600C4F8 RID: 50424 RVA: 0x0030F5E8 File Offset: 0x0030D7E8
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 165491, RefRangeEnd = 165498, XrefRangeStart = 165456, XrefRangeEnd = 165491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RunTimeStorageSaveDataPartial(Dictionary<int, int> foods, Dictionary<int, int> beverages, Dictionary<int, int> ingredients, Dictionary<int, int> cookers, Dictionary<int, int> items, Dictionary<int, int> badges, List<int> trophies, List<int> itemsShouldDeleteTomorrow, List<int> recipes, List<int> izakayas, List<int> unlockedPartners) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(foods);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(beverages);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ingredients);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookers);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(badges);
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trophies);
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(itemsShouldDeleteTomorrow);
				ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(recipes);
				ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(izakayas);
				ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unlockedPartners);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4F9 RID: 50425 RVA: 0x0030F6F8 File Offset: 0x0030D8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165498, XrefRangeEnd = 165582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ExtractValid(out PlayerSaveFile.RunTimeStorageSaveDataPartial valid, out PlayerSaveFile.RunTimeStorageSaveDataPartial invalid)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_ExtractValid_Public_Virtual_Final_New_Void_byref_RunTimeStorageSaveDataPartial_byref_RunTimeStorageSaveDataPartial_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				IntPtr intPtr5 = intPtr;
				valid = ((intPtr5 == 0) ? null : new PlayerSaveFile.RunTimeStorageSaveDataPartial(intPtr5));
				IntPtr intPtr6 = intPtr2;
				invalid = ((intPtr6 == 0) ? null : new PlayerSaveFile.RunTimeStorageSaveDataPartial(intPtr6));
			}

			// Token: 0x0600C4FA RID: 50426 RVA: 0x0030F774 File Offset: 0x0030D974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165582, XrefRangeEnd = 165686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static PlayerSaveFile.RunTimeStorageSaveDataPartial Merge(PlayerSaveFile.RunTimeStorageSaveDataPartial current, PlayerSaveFile.RunTimeStorageSaveDataPartial next)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(current));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(next));
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_Merge_Public_Static_RunTimeStorageSaveDataPartial_RunTimeStorageSaveDataPartial_RunTimeStorageSaveDataPartial_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.RunTimeStorageSaveDataPartial(pointer);
			}

			// Token: 0x0600C4FB RID: 50427 RVA: 0x0030F7CC File Offset: 0x0030D9CC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 165708, RefRangeEnd = 165711, XrefRangeStart = 165686, XrefRangeEnd = 165708, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void EnusreFieldNotNull(ref PlayerSaveFile.RunTimeStorageSaveDataPartial data)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_EnusreFieldNotNull_Private_Static_Void_byref_RunTimeStorageSaveDataPartial_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C4FC RID: 50428 RVA: 0x0030F804 File Offset: 0x0030DA04
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 166138, RefRangeEnd = 166139, XrefRangeStart = 165711, XrefRangeEnd = 166138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Classify([In] ref PlayerSaveFile.RunTimeStorageSaveDataPartial storagePartial, ref PlayerSaveFile.RunTimeStorageSaveDataPartial storagePartialSaveData, ref Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial> storagePartialDLCSaveData)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(storagePartial);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(storagePartialSaveData);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(storagePartialDLCSaveData);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimeStorageSaveDataPartial_byref_RunTimeStorageSaveDataPartial_byref_Dictionary_2_String_RunTimeStorageSaveDataPartial_0, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				storagePartialDLCSaveData = ((intPtr4 == 0) ? null : new Dictionary<string, PlayerSaveFile.RunTimeStorageSaveDataPartial>(intPtr4));
			}

			// Token: 0x0600C4FD RID: 50429 RVA: 0x0030F878 File Offset: 0x0030DA78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166139, XrefRangeEnd = 166140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PlayerSaveFile.RunTimeStorageSaveDataPartial Clone()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeStorageSaveDataPartial_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new PlayerSaveFile.RunTimeStorageSaveDataPartial(pointer);
			}

			// Token: 0x0600C4FE RID: 50430 RVA: 0x0006A468 File Offset: 0x00068668
			public RunTimeStorageSaveDataPartial(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C4FF RID: 50431 RVA: 0x0006A471 File Offset: 0x00068671
			public RunTimeStorageSaveDataPartial() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr))
			{
			}

			// Token: 0x1700401A RID: 16410
			// (get) Token: 0x0600C500 RID: 50432 RVA: 0x0030F8B4 File Offset: 0x0030DAB4
			// (set) Token: 0x0600C501 RID: 50433 RVA: 0x0006A483 File Offset: 0x00068683
			public unsafe Dictionary<int, int> foods
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_foods);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_foods), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401B RID: 16411
			// (get) Token: 0x0600C502 RID: 50434 RVA: 0x0030F8E4 File Offset: 0x0030DAE4
			// (set) Token: 0x0600C503 RID: 50435 RVA: 0x0006A4A2 File Offset: 0x000686A2
			public unsafe Dictionary<int, int> beverages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_beverages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_beverages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401C RID: 16412
			// (get) Token: 0x0600C504 RID: 50436 RVA: 0x0030F914 File Offset: 0x0030DB14
			// (set) Token: 0x0600C505 RID: 50437 RVA: 0x0006A4C1 File Offset: 0x000686C1
			public unsafe Dictionary<int, int> ingredients
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_ingredients);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_ingredients), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401D RID: 16413
			// (get) Token: 0x0600C506 RID: 50438 RVA: 0x0030F944 File Offset: 0x0030DB44
			// (set) Token: 0x0600C507 RID: 50439 RVA: 0x0006A4E0 File Offset: 0x000686E0
			public unsafe Dictionary<int, int> cookers
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_cookers);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_cookers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401E RID: 16414
			// (get) Token: 0x0600C508 RID: 50440 RVA: 0x0030F974 File Offset: 0x0030DB74
			// (set) Token: 0x0600C509 RID: 50441 RVA: 0x0006A4FF File Offset: 0x000686FF
			public unsafe Dictionary<int, int> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401F RID: 16415
			// (get) Token: 0x0600C50A RID: 50442 RVA: 0x0030F9A4 File Offset: 0x0030DBA4
			// (set) Token: 0x0600C50B RID: 50443 RVA: 0x0006A51E File Offset: 0x0006871E
			public unsafe Dictionary<int, int> badges
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_badges);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_badges), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004020 RID: 16416
			// (get) Token: 0x0600C50C RID: 50444 RVA: 0x0030F9D4 File Offset: 0x0030DBD4
			// (set) Token: 0x0600C50D RID: 50445 RVA: 0x0006A53D File Offset: 0x0006873D
			public unsafe List<int> trophies
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_trophies);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_trophies), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004021 RID: 16417
			// (get) Token: 0x0600C50E RID: 50446 RVA: 0x0030FA04 File Offset: 0x0030DC04
			// (set) Token: 0x0600C50F RID: 50447 RVA: 0x0006A55C File Offset: 0x0006875C
			public unsafe List<int> itemsShouldDeleteTomorrow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_itemsShouldDeleteTomorrow);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_itemsShouldDeleteTomorrow), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004022 RID: 16418
			// (get) Token: 0x0600C510 RID: 50448 RVA: 0x0030FA34 File Offset: 0x0030DC34
			// (set) Token: 0x0600C511 RID: 50449 RVA: 0x0006A57B File Offset: 0x0006877B
			public unsafe List<int> recipes
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_recipes);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_recipes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004023 RID: 16419
			// (get) Token: 0x0600C512 RID: 50450 RVA: 0x0030FA64 File Offset: 0x0030DC64
			// (set) Token: 0x0600C513 RID: 50451 RVA: 0x0006A59A File Offset: 0x0006879A
			public unsafe List<int> izakayas
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_izakayas);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_izakayas), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004024 RID: 16420
			// (get) Token: 0x0600C514 RID: 50452 RVA: 0x0030FA94 File Offset: 0x0030DC94
			// (set) Token: 0x0600C515 RID: 50453 RVA: 0x0006A5B9 File Offset: 0x000687B9
			public unsafe List<int> unlockedPartners
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_unlockedPartners);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerSaveFile.RunTimeStorageSaveDataPartial.NativeFieldInfoPtr_unlockedPartners), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04007E9E RID: 32414
			private static readonly IntPtr NativeFieldInfoPtr_foods;

			// Token: 0x04007E9F RID: 32415
			private static readonly IntPtr NativeFieldInfoPtr_beverages;

			// Token: 0x04007EA0 RID: 32416
			private static readonly IntPtr NativeFieldInfoPtr_ingredients;

			// Token: 0x04007EA1 RID: 32417
			private static readonly IntPtr NativeFieldInfoPtr_cookers;

			// Token: 0x04007EA2 RID: 32418
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x04007EA3 RID: 32419
			private static readonly IntPtr NativeFieldInfoPtr_badges;

			// Token: 0x04007EA4 RID: 32420
			private static readonly IntPtr NativeFieldInfoPtr_trophies;

			// Token: 0x04007EA5 RID: 32421
			private static readonly IntPtr NativeFieldInfoPtr_itemsShouldDeleteTomorrow;

			// Token: 0x04007EA6 RID: 32422
			private static readonly IntPtr NativeFieldInfoPtr_recipes;

			// Token: 0x04007EA7 RID: 32423
			private static readonly IntPtr NativeFieldInfoPtr_izakayas;

			// Token: 0x04007EA8 RID: 32424
			private static readonly IntPtr NativeFieldInfoPtr_unlockedPartners;

			// Token: 0x04007EA9 RID: 32425
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_Dictionary_2_Int32_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_List_1_Int32_0;

			// Token: 0x04007EAA RID: 32426
			private static readonly IntPtr NativeMethodInfoPtr_ExtractValid_Public_Virtual_Final_New_Void_byref_RunTimeStorageSaveDataPartial_byref_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04007EAB RID: 32427
			private static readonly IntPtr NativeMethodInfoPtr_Merge_Public_Static_RunTimeStorageSaveDataPartial_RunTimeStorageSaveDataPartial_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04007EAC RID: 32428
			private static readonly IntPtr NativeMethodInfoPtr_EnusreFieldNotNull_Private_Static_Void_byref_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04007EAD RID: 32429
			private static readonly IntPtr NativeMethodInfoPtr_Classify_Public_Static_Void_byref_RunTimeStorageSaveDataPartial_byref_RunTimeStorageSaveDataPartial_byref_Dictionary_2_String_RunTimeStorageSaveDataPartial_0;

			// Token: 0x04007EAE RID: 32430
			private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_RunTimeStorageSaveDataPartial_0;

			// Token: 0x02001009 RID: 4105
			[ObfuscatedName("GameData.RunTime.Common.PlayerSaveFile+RunTimeStorageSaveDataPartial+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x06011951 RID: 72017 RVA: 0x0040894C File Offset: 0x00406B4C
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__13_0");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__13_1");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__13_2");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__13_3");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__13_4");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__13_5");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_0");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_1");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_2");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_3");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_4");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_5");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_6");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_7");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_8");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_9");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_10");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, "<>9__15_11");
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675855);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_0_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675856);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_1_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675857);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_2_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675858);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_3_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675859);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_4_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675860);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_5_Internal_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675861);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_0_Internal_String_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675862);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_1_Internal_String_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675863);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_2_Internal_String_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675864);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_3_Internal_String_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675865);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_4_Internal_String_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675866);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_5_Internal_String_KeyValuePair_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675867);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_6_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675868);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_7_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675869);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_8_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675870);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_9_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675871);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_10_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675872);
					PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_11_Internal_RunTimeStorageSaveDataPartial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr, 100675873);
				}

				// Token: 0x06011952 RID: 72018 RVA: 0x00408C70 File Offset: 0x00406E70
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011953 RID: 72019 RVA: 0x00408CAC File Offset: 0x00406EAC
				[CallerCount(0)]
				public unsafe int _Merge_b__13_0(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_0_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011954 RID: 72020 RVA: 0x00408D04 File Offset: 0x00406F04
				[CallerCount(0)]
				public unsafe int _Merge_b__13_1(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_1_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011955 RID: 72021 RVA: 0x00408D5C File Offset: 0x00406F5C
				[CallerCount(0)]
				public unsafe int _Merge_b__13_2(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_2_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011956 RID: 72022 RVA: 0x00408DB4 File Offset: 0x00406FB4
				[CallerCount(0)]
				public unsafe int _Merge_b__13_3(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_3_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011957 RID: 72023 RVA: 0x00408E0C File Offset: 0x0040700C
				[CallerCount(0)]
				public unsafe int _Merge_b__13_4(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_4_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011958 RID: 72024 RVA: 0x00408E64 File Offset: 0x00407064
				[CallerCount(0)]
				public unsafe int _Merge_b__13_5(int a, int b)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref a;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Merge_b__13_5_Internal_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x06011959 RID: 72025 RVA: 0x00408EBC File Offset: 0x004070BC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165388, XrefRangeEnd = 165390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_0(KeyValuePair<int, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_0_Internal_String_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601195A RID: 72026 RVA: 0x00408F0C File Offset: 0x0040710C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165390, XrefRangeEnd = 165392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_1(KeyValuePair<int, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_1_Internal_String_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601195B RID: 72027 RVA: 0x00408F5C File Offset: 0x0040715C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165392, XrefRangeEnd = 165394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_2(KeyValuePair<int, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_2_Internal_String_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601195C RID: 72028 RVA: 0x00408FAC File Offset: 0x004071AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165394, XrefRangeEnd = 165396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_3(KeyValuePair<int, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_3_Internal_String_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601195D RID: 72029 RVA: 0x00408FFC File Offset: 0x004071FC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165396, XrefRangeEnd = 165398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_4(KeyValuePair<int, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_4_Internal_String_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601195E RID: 72030 RVA: 0x0040904C File Offset: 0x0040724C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165398, XrefRangeEnd = 165400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_5(KeyValuePair<int, int> x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_5_Internal_String_KeyValuePair_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601195F RID: 72031 RVA: 0x0040909C File Offset: 0x0040729C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165400, XrefRangeEnd = 165401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_6(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_6_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011960 RID: 72032 RVA: 0x004090E0 File Offset: 0x004072E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_7(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_7_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011961 RID: 72033 RVA: 0x00409124 File Offset: 0x00407324
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165401, XrefRangeEnd = 165402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_8(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_8_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011962 RID: 72034 RVA: 0x00409168 File Offset: 0x00407368
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165402, XrefRangeEnd = 165403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_9(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_9_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011963 RID: 72035 RVA: 0x004091AC File Offset: 0x004073AC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165403, XrefRangeEnd = 165407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _Classify_b__15_10(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_10_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06011964 RID: 72036 RVA: 0x004091F0 File Offset: 0x004073F0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 165407, XrefRangeEnd = 165456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe PlayerSaveFile.RunTimeStorageSaveDataPartial _Classify_b__15_11()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeMethodInfoPtr__Classify_b__15_11_Internal_RunTimeStorageSaveDataPartial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new PlayerSaveFile.RunTimeStorageSaveDataPartial(pointer);
				}

				// Token: 0x06011965 RID: 72037 RVA: 0x00098EE1 File Offset: 0x000970E1
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005B71 RID: 23409
				// (get) Token: 0x06011966 RID: 72038 RVA: 0x00409228 File Offset: 0x00407428
				// (set) Token: 0x06011967 RID: 72039 RVA: 0x00098EEA File Offset: 0x000970EA
				public unsafe static PlayerSaveFile.RunTimeStorageSaveDataPartial.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerSaveFile.RunTimeStorageSaveDataPartial.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B72 RID: 23410
				// (get) Token: 0x06011968 RID: 72040 RVA: 0x00409250 File Offset: 0x00407450
				// (set) Token: 0x06011969 RID: 72041 RVA: 0x00098EFC File Offset: 0x000970FC
				public unsafe static Func<int, int, int> __9__13_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B73 RID: 23411
				// (get) Token: 0x0601196A RID: 72042 RVA: 0x00409278 File Offset: 0x00407478
				// (set) Token: 0x0601196B RID: 72043 RVA: 0x00098F0E File Offset: 0x0009710E
				public unsafe static Func<int, int, int> __9__13_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B74 RID: 23412
				// (get) Token: 0x0601196C RID: 72044 RVA: 0x004092A0 File Offset: 0x004074A0
				// (set) Token: 0x0601196D RID: 72045 RVA: 0x00098F20 File Offset: 0x00097120
				public unsafe static Func<int, int, int> __9__13_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B75 RID: 23413
				// (get) Token: 0x0601196E RID: 72046 RVA: 0x004092C8 File Offset: 0x004074C8
				// (set) Token: 0x0601196F RID: 72047 RVA: 0x00098F32 File Offset: 0x00097132
				public unsafe static Func<int, int, int> __9__13_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B76 RID: 23414
				// (get) Token: 0x06011970 RID: 72048 RVA: 0x004092F0 File Offset: 0x004074F0
				// (set) Token: 0x06011971 RID: 72049 RVA: 0x00098F44 File Offset: 0x00097144
				public unsafe static Func<int, int, int> __9__13_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B77 RID: 23415
				// (get) Token: 0x06011972 RID: 72050 RVA: 0x00409318 File Offset: 0x00407518
				// (set) Token: 0x06011973 RID: 72051 RVA: 0x00098F56 File Offset: 0x00097156
				public unsafe static Func<int, int, int> __9__13_5
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_5, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, int, int>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__13_5, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B78 RID: 23416
				// (get) Token: 0x06011974 RID: 72052 RVA: 0x00409340 File Offset: 0x00407540
				// (set) Token: 0x06011975 RID: 72053 RVA: 0x00098F68 File Offset: 0x00097168
				public unsafe static Func<KeyValuePair<int, int>, string> __9__15_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B79 RID: 23417
				// (get) Token: 0x06011976 RID: 72054 RVA: 0x00409368 File Offset: 0x00407568
				// (set) Token: 0x06011977 RID: 72055 RVA: 0x00098F7A File Offset: 0x0009717A
				public unsafe static Func<KeyValuePair<int, int>, string> __9__15_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B7A RID: 23418
				// (get) Token: 0x06011978 RID: 72056 RVA: 0x00409390 File Offset: 0x00407590
				// (set) Token: 0x06011979 RID: 72057 RVA: 0x00098F8C File Offset: 0x0009718C
				public unsafe static Func<KeyValuePair<int, int>, string> __9__15_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B7B RID: 23419
				// (get) Token: 0x0601197A RID: 72058 RVA: 0x004093B8 File Offset: 0x004075B8
				// (set) Token: 0x0601197B RID: 72059 RVA: 0x00098F9E File Offset: 0x0009719E
				public unsafe static Func<KeyValuePair<int, int>, string> __9__15_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B7C RID: 23420
				// (get) Token: 0x0601197C RID: 72060 RVA: 0x004093E0 File Offset: 0x004075E0
				// (set) Token: 0x0601197D RID: 72061 RVA: 0x00098FB0 File Offset: 0x000971B0
				public unsafe static Func<KeyValuePair<int, int>, string> __9__15_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B7D RID: 23421
				// (get) Token: 0x0601197E RID: 72062 RVA: 0x00409408 File Offset: 0x00407608
				// (set) Token: 0x0601197F RID: 72063 RVA: 0x00098FC2 File Offset: 0x000971C2
				public unsafe static Func<KeyValuePair<int, int>, string> __9__15_5
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_5, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<int, int>, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_5, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B7E RID: 23422
				// (get) Token: 0x06011980 RID: 72064 RVA: 0x00409430 File Offset: 0x00407630
				// (set) Token: 0x06011981 RID: 72065 RVA: 0x00098FD4 File Offset: 0x000971D4
				public unsafe static Func<int, string> __9__15_6
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_6, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_6, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B7F RID: 23423
				// (get) Token: 0x06011982 RID: 72066 RVA: 0x00409458 File Offset: 0x00407658
				// (set) Token: 0x06011983 RID: 72067 RVA: 0x00098FE6 File Offset: 0x000971E6
				public unsafe static Func<int, string> __9__15_7
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_7, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_7, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B80 RID: 23424
				// (get) Token: 0x06011984 RID: 72068 RVA: 0x00409480 File Offset: 0x00407680
				// (set) Token: 0x06011985 RID: 72069 RVA: 0x00098FF8 File Offset: 0x000971F8
				public unsafe static Func<int, string> __9__15_8
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_8, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_8, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B81 RID: 23425
				// (get) Token: 0x06011986 RID: 72070 RVA: 0x004094A8 File Offset: 0x004076A8
				// (set) Token: 0x06011987 RID: 72071 RVA: 0x0009900A File Offset: 0x0009720A
				public unsafe static Func<int, string> __9__15_9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B82 RID: 23426
				// (get) Token: 0x06011988 RID: 72072 RVA: 0x004094D0 File Offset: 0x004076D0
				// (set) Token: 0x06011989 RID: 72073 RVA: 0x0009901C File Offset: 0x0009721C
				public unsafe static Func<int, string> __9__15_10
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_10, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_10, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005B83 RID: 23427
				// (get) Token: 0x0601198A RID: 72074 RVA: 0x004094F8 File Offset: 0x004076F8
				// (set) Token: 0x0601198B RID: 72075 RVA: 0x0009902E File Offset: 0x0009722E
				public unsafe static Func<PlayerSaveFile.RunTimeStorageSaveDataPartial> __9__15_11
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_11, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PlayerSaveFile.RunTimeStorageSaveDataPartial>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(PlayerSaveFile.RunTimeStorageSaveDataPartial.__c.NativeFieldInfoPtr___9__15_11, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B1B7 RID: 45495
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B1B8 RID: 45496
				private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

				// Token: 0x0400B1B9 RID: 45497
				private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

				// Token: 0x0400B1BA RID: 45498
				private static readonly IntPtr NativeFieldInfoPtr___9__13_2;

				// Token: 0x0400B1BB RID: 45499
				private static readonly IntPtr NativeFieldInfoPtr___9__13_3;

				// Token: 0x0400B1BC RID: 45500
				private static readonly IntPtr NativeFieldInfoPtr___9__13_4;

				// Token: 0x0400B1BD RID: 45501
				private static readonly IntPtr NativeFieldInfoPtr___9__13_5;

				// Token: 0x0400B1BE RID: 45502
				private static readonly IntPtr NativeFieldInfoPtr___9__15_0;

				// Token: 0x0400B1BF RID: 45503
				private static readonly IntPtr NativeFieldInfoPtr___9__15_1;

				// Token: 0x0400B1C0 RID: 45504
				private static readonly IntPtr NativeFieldInfoPtr___9__15_2;

				// Token: 0x0400B1C1 RID: 45505
				private static readonly IntPtr NativeFieldInfoPtr___9__15_3;

				// Token: 0x0400B1C2 RID: 45506
				private static readonly IntPtr NativeFieldInfoPtr___9__15_4;

				// Token: 0x0400B1C3 RID: 45507
				private static readonly IntPtr NativeFieldInfoPtr___9__15_5;

				// Token: 0x0400B1C4 RID: 45508
				private static readonly IntPtr NativeFieldInfoPtr___9__15_6;

				// Token: 0x0400B1C5 RID: 45509
				private static readonly IntPtr NativeFieldInfoPtr___9__15_7;

				// Token: 0x0400B1C6 RID: 45510
				private static readonly IntPtr NativeFieldInfoPtr___9__15_8;

				// Token: 0x0400B1C7 RID: 45511
				private static readonly IntPtr NativeFieldInfoPtr___9__15_9;

				// Token: 0x0400B1C8 RID: 45512
				private static readonly IntPtr NativeFieldInfoPtr___9__15_10;

				// Token: 0x0400B1C9 RID: 45513
				private static readonly IntPtr NativeFieldInfoPtr___9__15_11;

				// Token: 0x0400B1CA RID: 45514
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B1CB RID: 45515
				private static readonly IntPtr NativeMethodInfoPtr__Merge_b__13_0_Internal_Int32_Int32_Int32_0;

				// Token: 0x0400B1CC RID: 45516
				private static readonly IntPtr NativeMethodInfoPtr__Merge_b__13_1_Internal_Int32_Int32_Int32_0;

				// Token: 0x0400B1CD RID: 45517
				private static readonly IntPtr NativeMethodInfoPtr__Merge_b__13_2_Internal_Int32_Int32_Int32_0;

				// Token: 0x0400B1CE RID: 45518
				private static readonly IntPtr NativeMethodInfoPtr__Merge_b__13_3_Internal_Int32_Int32_Int32_0;

				// Token: 0x0400B1CF RID: 45519
				private static readonly IntPtr NativeMethodInfoPtr__Merge_b__13_4_Internal_Int32_Int32_Int32_0;

				// Token: 0x0400B1D0 RID: 45520
				private static readonly IntPtr NativeMethodInfoPtr__Merge_b__13_5_Internal_Int32_Int32_Int32_0;

				// Token: 0x0400B1D1 RID: 45521
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_0_Internal_String_KeyValuePair_2_Int32_Int32_0;

				// Token: 0x0400B1D2 RID: 45522
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_1_Internal_String_KeyValuePair_2_Int32_Int32_0;

				// Token: 0x0400B1D3 RID: 45523
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_2_Internal_String_KeyValuePair_2_Int32_Int32_0;

				// Token: 0x0400B1D4 RID: 45524
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_3_Internal_String_KeyValuePair_2_Int32_Int32_0;

				// Token: 0x0400B1D5 RID: 45525
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_4_Internal_String_KeyValuePair_2_Int32_Int32_0;

				// Token: 0x0400B1D6 RID: 45526
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_5_Internal_String_KeyValuePair_2_Int32_Int32_0;

				// Token: 0x0400B1D7 RID: 45527
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_6_Internal_String_Int32_0;

				// Token: 0x0400B1D8 RID: 45528
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_7_Internal_String_Int32_0;

				// Token: 0x0400B1D9 RID: 45529
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_8_Internal_String_Int32_0;

				// Token: 0x0400B1DA RID: 45530
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_9_Internal_String_Int32_0;

				// Token: 0x0400B1DB RID: 45531
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_10_Internal_String_Int32_0;

				// Token: 0x0400B1DC RID: 45532
				private static readonly IntPtr NativeMethodInfoPtr__Classify_b__15_11_Internal_RunTimeStorageSaveDataPartial_0;
			}
		}
	}
}
