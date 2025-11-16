using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002E0 RID: 736
	public class MusicPackageProfile : ScriptableObject
	{
		// Token: 0x060059CB RID: 22987 RVA: 0x001CBB18 File Offset: 0x001C9D18
		// Note: this type is marked as 'beforefieldinit'.
		static MusicPackageProfile()
		{
			Il2CppClassPointerStore<MusicPackageProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "MusicPackageProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPackageProfile>.NativeClassPtr);
			MusicPackageProfile.NativeFieldInfoPtr_switchEntry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPackageProfile>.NativeClassPtr, "switchEntry");
			MusicPackageProfile.NativeFieldInfoPtr_musicChannel_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPackageProfile>.NativeClassPtr, "musicChannel_1");
			MusicPackageProfile.NativeFieldInfoPtr_musicChannel_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPackageProfile>.NativeClassPtr, "musicChannel_2");
			MusicPackageProfile.NativeFieldInfoPtr_musicChannel_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPackageProfile>.NativeClassPtr, "musicChannel_3");
			MusicPackageProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPackageProfile>.NativeClassPtr, 100681380);
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x001CBBAC File Offset: 0x001C9DAC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicPackageProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPackageProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPackageProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x000307C5 File Offset: 0x0002E9C5
		public MusicPackageProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x060059CE RID: 22990 RVA: 0x001CBBE8 File Offset: 0x001C9DE8
		// (set) Token: 0x060059CF RID: 22991 RVA: 0x000307CE File Offset: 0x0002E9CE
		public unsafe TextAsset switchEntry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.NativeFieldInfoPtr_switchEntry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.NativeFieldInfoPtr_switchEntry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x060059D0 RID: 22992 RVA: 0x001CBC18 File Offset: 0x001C9E18
		// (set) Token: 0x060059D1 RID: 22993 RVA: 0x000307ED File Offset: 0x0002E9ED
		public unsafe MusicPackageProfile.MusicChannel musicChannel_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.NativeFieldInfoPtr_musicChannel_1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicPackageProfile.MusicChannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.NativeFieldInfoPtr_musicChannel_1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x060059D2 RID: 22994 RVA: 0x001CBC48 File Offset: 0x001C9E48
		// (set) Token: 0x060059D3 RID: 22995 RVA: 0x0003080C File Offset: 0x0002EA0C
		public unsafe MusicPackageProfile.MusicChannel musicChannel_2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.NativeFieldInfoPtr_musicChannel_2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicPackageProfile.MusicChannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.NativeFieldInfoPtr_musicChannel_2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x060059D4 RID: 22996 RVA: 0x001CBC78 File Offset: 0x001C9E78
		// (set) Token: 0x060059D5 RID: 22997 RVA: 0x0003082B File Offset: 0x0002EA2B
		public unsafe MusicPackageProfile.MusicChannel musicChannel_3
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.NativeFieldInfoPtr_musicChannel_3);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicPackageProfile.MusicChannel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.NativeFieldInfoPtr_musicChannel_3), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BE1 RID: 15329
		private static readonly IntPtr NativeFieldInfoPtr_switchEntry;

		// Token: 0x04003BE2 RID: 15330
		private static readonly IntPtr NativeFieldInfoPtr_musicChannel_1;

		// Token: 0x04003BE3 RID: 15331
		private static readonly IntPtr NativeFieldInfoPtr_musicChannel_2;

		// Token: 0x04003BE4 RID: 15332
		private static readonly IntPtr NativeFieldInfoPtr_musicChannel_3;

		// Token: 0x04003BE5 RID: 15333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000CAD RID: 3245
		[Serializable]
		public class MusicChannel : Il2CppSystem.Object
		{
			// Token: 0x0600E8A8 RID: 59560 RVA: 0x0037ADEC File Offset: 0x00378FEC
			// Note: this type is marked as 'beforefieldinit'.
			static MusicChannel()
			{
				Il2CppClassPointerStore<MusicPackageProfile.MusicChannel>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicPackageProfile>.NativeClassPtr, "MusicChannel");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicPackageProfile.MusicChannel>.NativeClassPtr);
				MusicPackageProfile.MusicChannel.NativeFieldInfoPtr_musicData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPackageProfile.MusicChannel>.NativeClassPtr, "musicData");
				MusicPackageProfile.MusicChannel.NativeFieldInfoPtr_midiData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicPackageProfile.MusicChannel>.NativeClassPtr, "midiData");
				MusicPackageProfile.MusicChannel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicPackageProfile.MusicChannel>.NativeClassPtr, 100681381);
			}

			// Token: 0x0600E8A9 RID: 59561 RVA: 0x0037AE54 File Offset: 0x00379054
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MusicChannel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicPackageProfile.MusicChannel>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicPackageProfile.MusicChannel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8AA RID: 59562 RVA: 0x0007C63C File Offset: 0x0007A83C
			public MusicChannel(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004BA1 RID: 19361
			// (get) Token: 0x0600E8AB RID: 59563 RVA: 0x0037AE90 File Offset: 0x00379090
			// (set) Token: 0x0600E8AC RID: 59564 RVA: 0x0007C645 File Offset: 0x0007A845
			public unsafe LoopedBGMPackage musicData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.MusicChannel.NativeFieldInfoPtr_musicData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<LoopedBGMPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.MusicChannel.NativeFieldInfoPtr_musicData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BA2 RID: 19362
			// (get) Token: 0x0600E8AD RID: 59565 RVA: 0x0037AEC0 File Offset: 0x003790C0
			// (set) Token: 0x0600E8AE RID: 59566 RVA: 0x0007C664 File Offset: 0x0007A864
			public unsafe TextAsset midiData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.MusicChannel.NativeFieldInfoPtr_midiData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicPackageProfile.MusicChannel.NativeFieldInfoPtr_midiData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009466 RID: 37990
			private static readonly IntPtr NativeFieldInfoPtr_musicData;

			// Token: 0x04009467 RID: 37991
			private static readonly IntPtr NativeFieldInfoPtr_midiData;

			// Token: 0x04009468 RID: 37992
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
