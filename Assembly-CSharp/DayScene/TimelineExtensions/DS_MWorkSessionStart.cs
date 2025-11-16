using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000154 RID: 340
	public class DS_MWorkSessionStart : PlayableAsset
	{
		// Token: 0x0600271F RID: 10015 RVA: 0x001210A8 File Offset: 0x0011F2A8
		// Note: this type is marked as 'beforefieldinit'.
		static DS_MWorkSessionStart()
		{
			Il2CppClassPointerStore<DS_MWorkSessionStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_MWorkSessionStart");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_MWorkSessionStart>.NativeClassPtr);
			DS_MWorkSessionStart.NativeFieldInfoPtr_izakayaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MWorkSessionStart>.NativeClassPtr, "izakayaIndex");
			DS_MWorkSessionStart.NativeFieldInfoPtr_dailyRecipes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MWorkSessionStart>.NativeClassPtr, "dailyRecipes");
			DS_MWorkSessionStart.NativeFieldInfoPtr_dailyBeverages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MWorkSessionStart>.NativeClassPtr, "dailyBeverages");
			DS_MWorkSessionStart.NativeFieldInfoPtr_cookerConfigurations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MWorkSessionStart>.NativeClassPtr, "cookerConfigurations");
			DS_MWorkSessionStart.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MWorkSessionStart>.NativeClassPtr, 100670244);
			DS_MWorkSessionStart.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MWorkSessionStart>.NativeClassPtr, 100670245);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00121150 File Offset: 0x0011F350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90783, XrefRangeEnd = 90804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_MWorkSessionStart.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x001211B8 File Offset: 0x0011F3B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_MWorkSessionStart() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_MWorkSessionStart>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_MWorkSessionStart.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00017103 File Offset: 0x00015303
		public DS_MWorkSessionStart(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06002723 RID: 10019 RVA: 0x001211F4 File Offset: 0x0011F3F4
		// (set) Token: 0x06002724 RID: 10020 RVA: 0x0001710C File Offset: 0x0001530C
		public unsafe int izakayaIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart.NativeFieldInfoPtr_izakayaIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart.NativeFieldInfoPtr_izakayaIndex)) = value;
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002725 RID: 10021 RVA: 0x0012121C File Offset: 0x0011F41C
		// (set) Token: 0x06002726 RID: 10022 RVA: 0x00017127 File Offset: 0x00015327
		public unsafe Il2CppStructArray<int> dailyRecipes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart.NativeFieldInfoPtr_dailyRecipes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart.NativeFieldInfoPtr_dailyRecipes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x0012124C File Offset: 0x0011F44C
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x00017146 File Offset: 0x00015346
		public unsafe Il2CppStructArray<int> dailyBeverages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart.NativeFieldInfoPtr_dailyBeverages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart.NativeFieldInfoPtr_dailyBeverages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x0012127C File Offset: 0x0011F47C
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x00017165 File Offset: 0x00015365
		public unsafe Il2CppStructArray<DaySceneDirector.IndexCookerPair> cookerConfigurations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart.NativeFieldInfoPtr_cookerConfigurations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<DaySceneDirector.IndexCookerPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MWorkSessionStart.NativeFieldInfoPtr_cookerConfigurations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019FE RID: 6654
		private static readonly IntPtr NativeFieldInfoPtr_izakayaIndex;

		// Token: 0x040019FF RID: 6655
		private static readonly IntPtr NativeFieldInfoPtr_dailyRecipes;

		// Token: 0x04001A00 RID: 6656
		private static readonly IntPtr NativeFieldInfoPtr_dailyBeverages;

		// Token: 0x04001A01 RID: 6657
		private static readonly IntPtr NativeFieldInfoPtr_cookerConfigurations;

		// Token: 0x04001A02 RID: 6658
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A03 RID: 6659
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
