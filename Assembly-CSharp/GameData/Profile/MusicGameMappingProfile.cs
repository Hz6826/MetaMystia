using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002DF RID: 735
	public class MusicGameMappingProfile : ScriptableObject
	{
		// Token: 0x060059C6 RID: 22982 RVA: 0x001CBA54 File Offset: 0x001C9C54
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameMappingProfile()
		{
			Il2CppClassPointerStore<MusicGameMappingProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "MusicGameMappingProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMappingProfile>.NativeClassPtr);
			MusicGameMappingProfile.NativeFieldInfoPtr_musicMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMappingProfile>.NativeClassPtr, "musicMappings");
			MusicGameMappingProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMappingProfile>.NativeClassPtr, 100681379);
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x001CBAAC File Offset: 0x001C9CAC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameMappingProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMappingProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMappingProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x0003079D File Offset: 0x0002E99D
		public MusicGameMappingProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x060059C9 RID: 22985 RVA: 0x001CBAE8 File Offset: 0x001C9CE8
		// (set) Token: 0x060059CA RID: 22986 RVA: 0x000307A6 File Offset: 0x0002E9A6
		public unsafe Il2CppReferenceArray<MusicGameMappingProfile.MusicMapping> musicMappings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.NativeFieldInfoPtr_musicMappings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MusicGameMappingProfile.MusicMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.NativeFieldInfoPtr_musicMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BDF RID: 15327
		private static readonly IntPtr NativeFieldInfoPtr_musicMappings;

		// Token: 0x04003BE0 RID: 15328
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CAC RID: 3244
		[Serializable]
		public sealed class MusicMapping : ValueType
		{
			// Token: 0x0600E897 RID: 59543 RVA: 0x0037AC0C File Offset: 0x00378E0C
			// Note: this type is marked as 'beforefieldinit'.
			static MusicMapping()
			{
				Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMappingProfile>.NativeClassPtr, "MusicMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr);
				MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr, "mapLabel");
				MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_alternativeMapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr, "alternativeMapName");
				MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_DLCMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr, "DLCMapping");
				MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_musicChapters = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr, "musicChapters");
				MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_unlockedMapLabelAfterFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr, "unlockedMapLabelAfterFinish");
				MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_easyBadgeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr, "easyBadgeId");
				MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_hardBadgeId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr, "hardBadgeId");
			}

			// Token: 0x0600E898 RID: 59544 RVA: 0x0007C550 File Offset: 0x0007A750
			public MusicMapping(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E899 RID: 59545 RVA: 0x0007C559 File Offset: 0x0007A759
			public MusicMapping() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMappingProfile.MusicMapping>.NativeClassPtr))
			{
			}

			// Token: 0x17004B9A RID: 19354
			// (get) Token: 0x0600E89A RID: 59546 RVA: 0x0037ACC4 File Offset: 0x00378EC4
			// (set) Token: 0x0600E89B RID: 59547 RVA: 0x0007C56B File Offset: 0x0007A76B
			public unsafe string mapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_mapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B9B RID: 19355
			// (get) Token: 0x0600E89C RID: 59548 RVA: 0x0037ACEC File Offset: 0x00378EEC
			// (set) Token: 0x0600E89D RID: 59549 RVA: 0x0007C58A File Offset: 0x0007A78A
			public unsafe string alternativeMapName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_alternativeMapName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_alternativeMapName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B9C RID: 19356
			// (get) Token: 0x0600E89E RID: 59550 RVA: 0x0037AD14 File Offset: 0x00378F14
			// (set) Token: 0x0600E89F RID: 59551 RVA: 0x0007C5A9 File Offset: 0x0007A7A9
			public unsafe string DLCMapping
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_DLCMapping);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_DLCMapping), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B9D RID: 19357
			// (get) Token: 0x0600E8A0 RID: 59552 RVA: 0x0037AD3C File Offset: 0x00378F3C
			// (set) Token: 0x0600E8A1 RID: 59553 RVA: 0x0007C5C8 File Offset: 0x0007A7C8
			public unsafe Il2CppStringArray musicChapters
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_musicChapters);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_musicChapters), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B9E RID: 19358
			// (get) Token: 0x0600E8A2 RID: 59554 RVA: 0x0037AD6C File Offset: 0x00378F6C
			// (set) Token: 0x0600E8A3 RID: 59555 RVA: 0x0007C5E7 File Offset: 0x0007A7E7
			public unsafe Il2CppStringArray unlockedMapLabelAfterFinish
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_unlockedMapLabelAfterFinish);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_unlockedMapLabelAfterFinish), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B9F RID: 19359
			// (get) Token: 0x0600E8A4 RID: 59556 RVA: 0x0037AD9C File Offset: 0x00378F9C
			// (set) Token: 0x0600E8A5 RID: 59557 RVA: 0x0007C606 File Offset: 0x0007A806
			public unsafe int easyBadgeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_easyBadgeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_easyBadgeId)) = value;
				}
			}

			// Token: 0x17004BA0 RID: 19360
			// (get) Token: 0x0600E8A6 RID: 59558 RVA: 0x0037ADC4 File Offset: 0x00378FC4
			// (set) Token: 0x0600E8A7 RID: 59559 RVA: 0x0007C621 File Offset: 0x0007A821
			public unsafe int hardBadgeId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_hardBadgeId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMappingProfile.MusicMapping.NativeFieldInfoPtr_hardBadgeId)) = value;
				}
			}

			// Token: 0x0400945F RID: 37983
			private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

			// Token: 0x04009460 RID: 37984
			private static readonly IntPtr NativeFieldInfoPtr_alternativeMapName;

			// Token: 0x04009461 RID: 37985
			private static readonly IntPtr NativeFieldInfoPtr_DLCMapping;

			// Token: 0x04009462 RID: 37986
			private static readonly IntPtr NativeFieldInfoPtr_musicChapters;

			// Token: 0x04009463 RID: 37987
			private static readonly IntPtr NativeFieldInfoPtr_unlockedMapLabelAfterFinish;

			// Token: 0x04009464 RID: 37988
			private static readonly IntPtr NativeFieldInfoPtr_easyBadgeId;

			// Token: 0x04009465 RID: 37989
			private static readonly IntPtr NativeFieldInfoPtr_hardBadgeId;
		}
	}
}
