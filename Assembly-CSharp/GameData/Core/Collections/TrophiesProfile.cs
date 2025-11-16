using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Core.Collections
{
	// Token: 0x02000239 RID: 569
	public class TrophiesProfile : ScriptableObject
	{
		// Token: 0x060046B3 RID: 18099 RVA: 0x00192FC0 File Offset: 0x001911C0
		// Note: this type is marked as 'beforefieldinit'.
		static TrophiesProfile()
		{
			Il2CppClassPointerStore<TrophiesProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "TrophiesProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrophiesProfile>.NativeClassPtr);
			TrophiesProfile.NativeFieldInfoPtr_trophies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrophiesProfile>.NativeClassPtr, "trophies");
			TrophiesProfile.NativeFieldInfoPtr_previewName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrophiesProfile>.NativeClassPtr, "previewName");
			TrophiesProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrophiesProfile>.NativeClassPtr, 100677326);
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x0019302C File Offset: 0x0019122C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrophiesProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrophiesProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrophiesProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x00024B71 File Offset: 0x00022D71
		public TrophiesProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700178D RID: 6029
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x00193068 File Offset: 0x00191268
		// (set) Token: 0x060046B7 RID: 18103 RVA: 0x00024B7A File Offset: 0x00022D7A
		public unsafe Il2CppReferenceArray<TrophiesProfile.Trophy> trophies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrophiesProfile.NativeFieldInfoPtr_trophies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TrophiesProfile.Trophy>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrophiesProfile.NativeFieldInfoPtr_trophies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700178E RID: 6030
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x00193098 File Offset: 0x00191298
		// (set) Token: 0x060046B9 RID: 18105 RVA: 0x00024B99 File Offset: 0x00022D99
		public unsafe string previewName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrophiesProfile.NativeFieldInfoPtr_previewName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrophiesProfile.NativeFieldInfoPtr_previewName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003070 RID: 12400
		private static readonly IntPtr NativeFieldInfoPtr_trophies;

		// Token: 0x04003071 RID: 12401
		private static readonly IntPtr NativeFieldInfoPtr_previewName;

		// Token: 0x04003072 RID: 12402
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AA8 RID: 2728
		[Serializable]
		public class Trophy : Item
		{
			// Token: 0x0600CC5E RID: 52318 RVA: 0x00326D24 File Offset: 0x00324F24
			// Note: this type is marked as 'beforefieldinit'.
			static Trophy()
			{
				Il2CppClassPointerStore<TrophiesProfile.Trophy>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrophiesProfile>.NativeClassPtr, "Trophy");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrophiesProfile.Trophy>.NativeClassPtr);
				TrophiesProfile.Trophy.NativeFieldInfoPtr_daySceneMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrophiesProfile.Trophy>.NativeClassPtr, "daySceneMapLabel");
				TrophiesProfile.Trophy.NativeFieldInfoPtr_dlcLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrophiesProfile.Trophy>.NativeClassPtr, "dlcLabel");
				TrophiesProfile.Trophy.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrophiesProfile.Trophy>.NativeClassPtr, 100677327);
				TrophiesProfile.Trophy.NativeMethodInfoPtr_get_DaySceneMapLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrophiesProfile.Trophy>.NativeClassPtr, 100677328);
				TrophiesProfile.Trophy.NativeMethodInfoPtr_get_DLCLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrophiesProfile.Trophy>.NativeClassPtr, 100677329);
			}

			// Token: 0x0600CC5F RID: 52319 RVA: 0x00326DB4 File Offset: 0x00324FB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186310, XrefRangeEnd = 186311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Trophy(int id) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrophiesProfile.Trophy>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrophiesProfile.Trophy.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004250 RID: 16976
			// (get) Token: 0x0600CC60 RID: 52320 RVA: 0x00326DFC File Offset: 0x00324FFC
			public unsafe string DaySceneMapLabel
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrophiesProfile.Trophy.NativeMethodInfoPtr_get_DaySceneMapLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x17004251 RID: 16977
			// (get) Token: 0x0600CC61 RID: 52321 RVA: 0x00326E34 File Offset: 0x00325034
			public unsafe string DLCLabel
			{
				[CallerCount(2)]
				[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrophiesProfile.Trophy.NativeMethodInfoPtr_get_DLCLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x0600CC62 RID: 52322 RVA: 0x0006DA39 File Offset: 0x0006BC39
			public Trophy(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700424E RID: 16974
			// (get) Token: 0x0600CC63 RID: 52323 RVA: 0x00326E6C File Offset: 0x0032506C
			// (set) Token: 0x0600CC64 RID: 52324 RVA: 0x0006DA42 File Offset: 0x0006BC42
			public unsafe string daySceneMapLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrophiesProfile.Trophy.NativeFieldInfoPtr_daySceneMapLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrophiesProfile.Trophy.NativeFieldInfoPtr_daySceneMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700424F RID: 16975
			// (get) Token: 0x0600CC65 RID: 52325 RVA: 0x00326E94 File Offset: 0x00325094
			// (set) Token: 0x0600CC66 RID: 52326 RVA: 0x0006DA61 File Offset: 0x0006BC61
			public unsafe string dlcLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrophiesProfile.Trophy.NativeFieldInfoPtr_dlcLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrophiesProfile.Trophy.NativeFieldInfoPtr_dlcLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400834F RID: 33615
			private static readonly IntPtr NativeFieldInfoPtr_daySceneMapLabel;

			// Token: 0x04008350 RID: 33616
			private static readonly IntPtr NativeFieldInfoPtr_dlcLabel;

			// Token: 0x04008351 RID: 33617
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008352 RID: 33618
			private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneMapLabel_Public_get_String_0;

			// Token: 0x04008353 RID: 33619
			private static readonly IntPtr NativeMethodInfoPtr_get_DLCLabel_Public_get_String_0;
		}
	}
}
