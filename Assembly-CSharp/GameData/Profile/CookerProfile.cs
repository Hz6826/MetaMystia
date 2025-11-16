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
	// Token: 0x020002CC RID: 716
	public class CookerProfile : ScriptableObject
	{
		// Token: 0x0600587C RID: 22652 RVA: 0x001C8A84 File Offset: 0x001C6C84
		// Note: this type is marked as 'beforefieldinit'.
		static CookerProfile()
		{
			Il2CppClassPointerStore<CookerProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "CookerProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookerProfile>.NativeClassPtr);
			CookerProfile.NativeFieldInfoPtr_cookers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerProfile>.NativeClassPtr, "cookers");
			CookerProfile.NativeFieldInfoPtr_cookersPreview = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerProfile>.NativeClassPtr, "cookersPreview");
			CookerProfile.NativeFieldInfoPtr_cookerSeriesPicMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerProfile>.NativeClassPtr, "cookerSeriesPicMappings");
			CookerProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CookerProfile>.NativeClassPtr, 100681265);
		}

		// Token: 0x0600587D RID: 22653 RVA: 0x001C8B04 File Offset: 0x001C6D04
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CookerProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookerProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CookerProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600587E RID: 22654 RVA: 0x0002F6DE File Offset: 0x0002D8DE
		public CookerProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x0600587F RID: 22655 RVA: 0x001C8B40 File Offset: 0x001C6D40
		// (set) Token: 0x06005880 RID: 22656 RVA: 0x0002F6E7 File Offset: 0x0002D8E7
		public unsafe Il2CppReferenceArray<Cooker> cookers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.NativeFieldInfoPtr_cookers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Cooker>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.NativeFieldInfoPtr_cookers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x06005881 RID: 22657 RVA: 0x001C8B70 File Offset: 0x001C6D70
		// (set) Token: 0x06005882 RID: 22658 RVA: 0x0002F706 File Offset: 0x0002D906
		public unsafe TextAsset cookersPreview
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.NativeFieldInfoPtr_cookersPreview);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.NativeFieldInfoPtr_cookersPreview), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06005883 RID: 22659 RVA: 0x001C8BA0 File Offset: 0x001C6DA0
		// (set) Token: 0x06005884 RID: 22660 RVA: 0x0002F725 File Offset: 0x0002D925
		public unsafe Il2CppReferenceArray<CookerProfile.CookerSeriesPicMapping> cookerSeriesPicMappings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.NativeFieldInfoPtr_cookerSeriesPicMappings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CookerProfile.CookerSeriesPicMapping>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.NativeFieldInfoPtr_cookerSeriesPicMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B3F RID: 15167
		private static readonly IntPtr NativeFieldInfoPtr_cookers;

		// Token: 0x04003B40 RID: 15168
		private static readonly IntPtr NativeFieldInfoPtr_cookersPreview;

		// Token: 0x04003B41 RID: 15169
		private static readonly IntPtr NativeFieldInfoPtr_cookerSeriesPicMappings;

		// Token: 0x04003B42 RID: 15170
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C91 RID: 3217
		public sealed class CookerSeriesPicMapping : ValueType
		{
			// Token: 0x0600E716 RID: 59158 RVA: 0x00376B5C File Offset: 0x00374D5C
			// Note: this type is marked as 'beforefieldinit'.
			static CookerSeriesPicMapping()
			{
				Il2CppClassPointerStore<CookerProfile.CookerSeriesPicMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CookerProfile>.NativeClassPtr, "CookerSeriesPicMapping");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CookerProfile.CookerSeriesPicMapping>.NativeClassPtr);
				CookerProfile.CookerSeriesPicMapping.NativeFieldInfoPtr_Series = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerProfile.CookerSeriesPicMapping>.NativeClassPtr, "Series");
				CookerProfile.CookerSeriesPicMapping.NativeFieldInfoPtr_bgPic = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CookerProfile.CookerSeriesPicMapping>.NativeClassPtr, "bgPic");
			}

			// Token: 0x0600E717 RID: 59159 RVA: 0x0007B551 File Offset: 0x00079751
			public CookerSeriesPicMapping(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E718 RID: 59160 RVA: 0x0007B55A File Offset: 0x0007975A
			public CookerSeriesPicMapping() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CookerProfile.CookerSeriesPicMapping>.NativeClassPtr))
			{
			}

			// Token: 0x17004AEF RID: 19183
			// (get) Token: 0x0600E719 RID: 59161 RVA: 0x00376BB0 File Offset: 0x00374DB0
			// (set) Token: 0x0600E71A RID: 59162 RVA: 0x0007B56C File Offset: 0x0007976C
			public unsafe Cooker.CookerSeries Series
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.CookerSeriesPicMapping.NativeFieldInfoPtr_Series);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.CookerSeriesPicMapping.NativeFieldInfoPtr_Series)) = value;
				}
			}

			// Token: 0x17004AF0 RID: 19184
			// (get) Token: 0x0600E71B RID: 59163 RVA: 0x00376BD8 File Offset: 0x00374DD8
			// (set) Token: 0x0600E71C RID: 59164 RVA: 0x0007B587 File Offset: 0x00079787
			public unsafe Sprite bgPic
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.CookerSeriesPicMapping.NativeFieldInfoPtr_bgPic);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CookerProfile.CookerSeriesPicMapping.NativeFieldInfoPtr_bgPic), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009391 RID: 37777
			private static readonly IntPtr NativeFieldInfoPtr_Series;

			// Token: 0x04009392 RID: 37778
			private static readonly IntPtr NativeFieldInfoPtr_bgPic;
		}
	}
}
