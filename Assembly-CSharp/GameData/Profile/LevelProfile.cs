using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002DC RID: 732
	public class LevelProfile : ScriptableObject
	{
		// Token: 0x060059B2 RID: 22962 RVA: 0x001CB730 File Offset: 0x001C9930
		// Note: this type is marked as 'beforefieldinit'.
		static LevelProfile()
		{
			Il2CppClassPointerStore<LevelProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "LevelProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelProfile>.NativeClassPtr);
			LevelProfile.NativeFieldInfoPtr_profiles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelProfile>.NativeClassPtr, "profiles");
			LevelProfile.NativeFieldInfoPtr_tsvBackup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelProfile>.NativeClassPtr, "tsvBackup");
			LevelProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelProfile>.NativeClassPtr, 100681358);
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x001CB79C File Offset: 0x001C999C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LevelProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x000306E7 File Offset: 0x0002E8E7
		public LevelProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x060059B5 RID: 22965 RVA: 0x001CB7D8 File Offset: 0x001C99D8
		// (set) Token: 0x060059B6 RID: 22966 RVA: 0x000306F0 File Offset: 0x0002E8F0
		public unsafe Il2CppReferenceArray<LevelProfile.LevelPropertiesPair> profiles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelProfile.NativeFieldInfoPtr_profiles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<LevelProfile.LevelPropertiesPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelProfile.NativeFieldInfoPtr_profiles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x060059B7 RID: 22967 RVA: 0x001CB808 File Offset: 0x001C9A08
		// (set) Token: 0x060059B8 RID: 22968 RVA: 0x0003070F File Offset: 0x0002E90F
		public unsafe TextAsset tsvBackup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelProfile.NativeFieldInfoPtr_tsvBackup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelProfile.NativeFieldInfoPtr_tsvBackup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BD6 RID: 15318
		private static readonly IntPtr NativeFieldInfoPtr_profiles;

		// Token: 0x04003BD7 RID: 15319
		private static readonly IntPtr NativeFieldInfoPtr_tsvBackup;

		// Token: 0x04003BD8 RID: 15320
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CA9 RID: 3241
		[Serializable]
		public class LevelPropertiesPair : Il2CppSystem.Object
		{
			// Token: 0x0600E85E RID: 59486 RVA: 0x0037A168 File Offset: 0x00378368
			// Note: this type is marked as 'beforefieldinit'.
			static LevelPropertiesPair()
			{
				Il2CppClassPointerStore<LevelProfile.LevelPropertiesPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LevelProfile>.NativeClassPtr, "LevelPropertiesPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LevelProfile.LevelPropertiesPair>.NativeClassPtr);
				LevelProfile.LevelPropertiesPair.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelProfile.LevelPropertiesPair>.NativeClassPtr, "level");
				LevelProfile.LevelPropertiesPair.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LevelProfile.LevelPropertiesPair>.NativeClassPtr, "properties");
				LevelProfile.LevelPropertiesPair.NativeMethodInfoPtr__ctor_Public_Void_Int32_LevelProperties_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LevelProfile.LevelPropertiesPair>.NativeClassPtr, 100681359);
			}

			// Token: 0x0600E85F RID: 59487 RVA: 0x0037A1D0 File Offset: 0x003783D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219573, XrefRangeEnd = 219575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LevelPropertiesPair(int level, DataBaseCore.LevelProperties properties) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LevelProfile.LevelPropertiesPair>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref level;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(properties));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LevelProfile.LevelPropertiesPair.NativeMethodInfoPtr__ctor_Public_Void_Int32_LevelProperties_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E860 RID: 59488 RVA: 0x0007C32A File Offset: 0x0007A52A
			public LevelPropertiesPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B7E RID: 19326
			// (get) Token: 0x0600E861 RID: 59489 RVA: 0x0037A230 File Offset: 0x00378430
			// (set) Token: 0x0600E862 RID: 59490 RVA: 0x0007C333 File Offset: 0x0007A533
			public unsafe int level
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelProfile.LevelPropertiesPair.NativeFieldInfoPtr_level);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelProfile.LevelPropertiesPair.NativeFieldInfoPtr_level)) = value;
				}
			}

			// Token: 0x17004B7F RID: 19327
			// (get) Token: 0x0600E863 RID: 59491 RVA: 0x0037A258 File Offset: 0x00378458
			// (set) Token: 0x0600E864 RID: 59492 RVA: 0x0007C34E File Offset: 0x0007A54E
			public DataBaseCore.LevelProperties properties
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelProfile.LevelPropertiesPair.NativeFieldInfoPtr_properties);
					return new DataBaseCore.LevelProperties(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LevelProfile.LevelPropertiesPair.NativeFieldInfoPtr_properties), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DataBaseCore.LevelProperties>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400943E RID: 37950
			private static readonly IntPtr NativeFieldInfoPtr_level;

			// Token: 0x0400943F RID: 37951
			private static readonly IntPtr NativeFieldInfoPtr_properties;

			// Token: 0x04009440 RID: 37952
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_LevelProperties_0;
		}
	}
}
