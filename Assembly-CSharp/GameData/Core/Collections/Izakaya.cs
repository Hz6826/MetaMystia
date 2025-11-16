using System;
using GameData.Core.Collections.NightSceneUtility;
using GameData.CoreLanguage;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections
{
	// Token: 0x02000241 RID: 577
	[Serializable]
	public class Izakaya : NonTradableObjectBase
	{
		// Token: 0x060047E4 RID: 18404 RVA: 0x00197884 File Offset: 0x00195A84
		// Note: this type is marked as 'beforefieldinit'.
		static Izakaya()
		{
			Il2CppClassPointerStore<Izakaya>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections", "Izakaya");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Izakaya>.NativeClassPtr);
			Izakaya.NativeFieldInfoPtr_baseFundRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "baseFundRange");
			Izakaya.NativeFieldInfoPtr_normalGuestSpanInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "normalGuestSpanInterval");
			Izakaya.NativeFieldInfoPtr_spawnPasserbyGuest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "spawnPasserbyGuest");
			Izakaya.NativeFieldInfoPtr_passerbyGuestSpanInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "passerbyGuestSpanInterval");
			Izakaya.NativeFieldInfoPtr_normalGuestPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "normalGuestPool");
			Izakaya.NativeFieldInfoPtr_specialGuestGachaInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "specialGuestGachaInterval");
			Izakaya.NativeFieldInfoPtr_specialGuestPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "specialGuestPool");
			Izakaya.NativeFieldInfoPtr_mapAssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "mapAssetReference");
			Izakaya.NativeFieldInfoPtr_mapSkinAssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "mapSkinAssetReference");
			Izakaya.NativeFieldInfoPtr_musicPackageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "musicPackageIndex");
			Izakaya.NativeFieldInfoPtr_musicPackageOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "musicPackageOverride");
			Izakaya.NativeFieldInfoPtr_daySceneMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "daySceneMapLabel");
			Izakaya.NativeFieldInfoPtr_guestTableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "guestTableCount");
			Izakaya.NativeFieldInfoPtr_cookTableCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "cookTableCount");
			Izakaya.NativeMethodInfoPtr__ctor_Public_Void_Int32_Vector2Int_Vector2_Il2CppReferenceArray_1_NormalGuestGroup_Single_Il2CppReferenceArray_1_SpecialGuestGroup_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677674);
			Izakaya.NativeMethodInfoPtr_get_BaseFundRange_Public_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677675);
			Izakaya.NativeMethodInfoPtr_get_NormalGuestSpanInterval_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677676);
			Izakaya.NativeMethodInfoPtr_get_SpawnPasserbyGuest_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677677);
			Izakaya.NativeMethodInfoPtr_get_PasserbyGuestSpanInterval_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677678);
			Izakaya.NativeMethodInfoPtr_get_NormalGuestPool_Public_get_Il2CppReferenceArray_1_NormalGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677679);
			Izakaya.NativeMethodInfoPtr_set_NormalGuestPool_Public_set_Void_Il2CppReferenceArray_1_NormalGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677680);
			Izakaya.NativeMethodInfoPtr_get_SpecialGuestGachaInterval_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677681);
			Izakaya.NativeMethodInfoPtr_get_SpecialGuestPool_Public_get_Il2CppReferenceArray_1_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677682);
			Izakaya.NativeMethodInfoPtr_set_SpecialGuestPool_Public_set_Void_Il2CppReferenceArray_1_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677683);
			Izakaya.NativeMethodInfoPtr_get_OriginalSpecialGuestPool_Public_get_Il2CppReferenceArray_1_SpecialGuestGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677684);
			Izakaya.NativeMethodInfoPtr_get_MusicPackageIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677685);
			Izakaya.NativeMethodInfoPtr_get_MusicPackageOverride_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677686);
			Izakaya.NativeMethodInfoPtr_get_DaySceneMapLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677687);
			Izakaya.NativeMethodInfoPtr_get_DaySceneMapName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677688);
			Izakaya.NativeMethodInfoPtr_get_IzakayaLevel_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677689);
			Izakaya.NativeMethodInfoPtr_get_MapAssetReference_Public_get_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677690);
			Izakaya.NativeMethodInfoPtr_get_MapSkinAssetReferences_Public_get_IEnumerable_1_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677691);
			Izakaya.NativeMethodInfoPtr_get_MapSkinAssetReference_Public_get_Il2CppReferenceArray_1_AssetReferenceIdPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677692);
			Izakaya.NativeMethodInfoPtr_set_MapSkinAssetReference_Public_set_Void_Il2CppReferenceArray_1_AssetReferenceIdPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677693);
			Izakaya.NativeMethodInfoPtr_GetMap_Public_AssetReference_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677694);
			Izakaya.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677695);
			Izakaya.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, 100677696);
		}

		// Token: 0x060047E5 RID: 18405 RVA: 0x00197B98 File Offset: 0x00195D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189664, XrefRangeEnd = 189670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Izakaya(int id, Vector2Int baseFundRange, Vector2 normalGuestSpanInterval, Il2CppReferenceArray<Izakaya.NormalGuestGroup> normalGuestPool, float specialGuestGachaInterval, Il2CppReferenceArray<Izakaya.SpecialGuestGroup> specialGuestPool, int musicPackageIndex, string daySceneMapLabel) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Izakaya>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref baseFundRange;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref normalGuestSpanInterval;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(normalGuestPool);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref specialGuestGachaInterval;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(specialGuestPool);
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref musicPackageIndex;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(daySceneMapLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr__ctor_Public_Void_Int32_Vector2Int_Vector2_Il2CppReferenceArray_1_NormalGuestGroup_Single_Il2CppReferenceArray_1_SpecialGuestGroup_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x060047E6 RID: 18406 RVA: 0x00197C50 File Offset: 0x00195E50
		public unsafe Vector2Int BaseFundRange
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_BaseFundRange_Public_get_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x060047E7 RID: 18407 RVA: 0x00197C8C File Offset: 0x00195E8C
		public unsafe Vector2 NormalGuestSpanInterval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_NormalGuestSpanInterval_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x060047E8 RID: 18408 RVA: 0x00197CC8 File Offset: 0x00195EC8
		public unsafe bool SpawnPasserbyGuest
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_SpawnPasserbyGuest_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017FC RID: 6140
		// (get) Token: 0x060047E9 RID: 18409 RVA: 0x00197D04 File Offset: 0x00195F04
		public unsafe Vector2 PasserbyGuestSpanInterval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_PasserbyGuestSpanInterval_Public_get_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017FD RID: 6141
		// (get) Token: 0x060047EA RID: 18410 RVA: 0x00197D40 File Offset: 0x00195F40
		// (set) Token: 0x060047EB RID: 18411 RVA: 0x00197D80 File Offset: 0x00195F80
		public unsafe Il2CppReferenceArray<Izakaya.NormalGuestGroup> NormalGuestPool
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 47603, RefRangeEnd = 47610, XrefRangeStart = 47603, XrefRangeEnd = 47610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_NormalGuestPool_Public_get_Il2CppReferenceArray_1_NormalGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya.NormalGuestGroup>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 98510, RefRangeEnd = 98511, XrefRangeStart = 98510, XrefRangeEnd = 98511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_set_NormalGuestPool_Public_set_Void_Il2CppReferenceArray_1_NormalGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170017FE RID: 6142
		// (get) Token: 0x060047EC RID: 18412 RVA: 0x00197DC4 File Offset: 0x00195FC4
		public unsafe float SpecialGuestGachaInterval
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_SpecialGuestGachaInterval_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170017FF RID: 6143
		// (get) Token: 0x060047ED RID: 18413 RVA: 0x00197E00 File Offset: 0x00196000
		// (set) Token: 0x060047EE RID: 18414 RVA: 0x00197E40 File Offset: 0x00196040
		public unsafe Il2CppReferenceArray<Izakaya.SpecialGuestGroup> SpecialGuestPool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_SpecialGuestPool_Public_get_Il2CppReferenceArray_1_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya.SpecialGuestGroup>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 157648, RefRangeEnd = 157649, XrefRangeStart = 157648, XrefRangeEnd = 157649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_set_SpecialGuestPool_Public_set_Void_Il2CppReferenceArray_1_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001800 RID: 6144
		// (get) Token: 0x060047EF RID: 18415 RVA: 0x00197E84 File Offset: 0x00196084
		public unsafe Il2CppReferenceArray<Izakaya.SpecialGuestGroup> OriginalSpecialGuestPool
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_OriginalSpecialGuestPool_Public_get_Il2CppReferenceArray_1_SpecialGuestGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya.SpecialGuestGroup>>(intPtr3) : null;
			}
		}

		// Token: 0x17001801 RID: 6145
		// (get) Token: 0x060047F0 RID: 18416 RVA: 0x00197EC4 File Offset: 0x001960C4
		public unsafe int MusicPackageIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_MusicPackageIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001802 RID: 6146
		// (get) Token: 0x060047F1 RID: 18417 RVA: 0x00197F00 File Offset: 0x00196100
		public unsafe bool MusicPackageOverride
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_MusicPackageOverride_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001803 RID: 6147
		// (get) Token: 0x060047F2 RID: 18418 RVA: 0x00197F3C File Offset: 0x0019613C
		public unsafe string DaySceneMapLabel
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 40571, RefRangeEnd = 40586, XrefRangeStart = 40571, XrefRangeEnd = 40586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_DaySceneMapLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001804 RID: 6148
		// (get) Token: 0x060047F3 RID: 18419 RVA: 0x00197F74 File Offset: 0x00196174
		public unsafe string DaySceneMapName
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 189673, RefRangeEnd = 189677, XrefRangeStart = 189670, XrefRangeEnd = 189673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_DaySceneMapName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17001805 RID: 6149
		// (get) Token: 0x060047F4 RID: 18420 RVA: 0x00197FAC File Offset: 0x001961AC
		public unsafe int IzakayaLevel
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 189678, RefRangeEnd = 189683, XrefRangeStart = 189677, XrefRangeEnd = 189678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_IzakayaLevel_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001806 RID: 6150
		// (get) Token: 0x060047F5 RID: 18421 RVA: 0x00197FE8 File Offset: 0x001961E8
		public unsafe AssetReference MapAssetReference
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 73874, RefRangeEnd = 73875, XrefRangeStart = 73874, XrefRangeEnd = 73875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_MapAssetReference_Public_get_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x060047F6 RID: 18422 RVA: 0x00198028 File Offset: 0x00196228
		public unsafe IEnumerable<AssetReference> MapSkinAssetReferences
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189683, XrefRangeEnd = 189702, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_MapSkinAssetReferences_Public_get_IEnumerable_1_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<AssetReference>>(intPtr3) : null;
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x060047F7 RID: 18423 RVA: 0x00198068 File Offset: 0x00196268
		// (set) Token: 0x060047F8 RID: 18424 RVA: 0x001980A8 File Offset: 0x001962A8
		public unsafe Il2CppReferenceArray<ExpandableGameDataPack.AssetReferenceIdPair> MapSkinAssetReference
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_get_MapSkinAssetReference_Public_get_Il2CppReferenceArray_1_AssetReferenceIdPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.AssetReferenceIdPair>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 43501, RefRangeEnd = 43502, XrefRangeStart = 43501, XrefRangeEnd = 43502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_set_MapSkinAssetReference_Public_set_Void_Il2CppReferenceArray_1_AssetReferenceIdPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047F9 RID: 18425 RVA: 0x001980EC File Offset: 0x001962EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189702, XrefRangeEnd = 189723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssetReference GetMap(int skinOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref skinOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NativeMethodInfoPtr_GetMap_Public_AssetReference_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
		}

		// Token: 0x060047FA RID: 18426 RVA: 0x00198138 File Offset: 0x00196338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189723, XrefRangeEnd = 189729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppSystem.Object Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Izakaya.NativeMethodInfoPtr_Clone_Public_Virtual_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
		}

		// Token: 0x060047FB RID: 18427 RVA: 0x00198184 File Offset: 0x00196384
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189729, XrefRangeEnd = 189734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ObjectLanguageBase GetText(int id)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Izakaya.NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectLanguageBase>(intPtr3) : null;
		}

		// Token: 0x060047FC RID: 18428 RVA: 0x00024FE9 File Offset: 0x000231E9
		public Izakaya(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x060047FD RID: 18429 RVA: 0x001981DC File Offset: 0x001963DC
		// (set) Token: 0x060047FE RID: 18430 RVA: 0x00024FF2 File Offset: 0x000231F2
		public unsafe Vector2Int baseFundRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_baseFundRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_baseFundRange)) = value;
			}
		}

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x060047FF RID: 18431 RVA: 0x00198204 File Offset: 0x00196404
		// (set) Token: 0x06004800 RID: 18432 RVA: 0x0002500D File Offset: 0x0002320D
		public unsafe Vector2 normalGuestSpanInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_normalGuestSpanInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_normalGuestSpanInterval)) = value;
			}
		}

		// Token: 0x170017ED RID: 6125
		// (get) Token: 0x06004801 RID: 18433 RVA: 0x0019822C File Offset: 0x0019642C
		// (set) Token: 0x06004802 RID: 18434 RVA: 0x00025028 File Offset: 0x00023228
		public unsafe bool spawnPasserbyGuest
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_spawnPasserbyGuest);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_spawnPasserbyGuest)) = value;
			}
		}

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06004803 RID: 18435 RVA: 0x00198254 File Offset: 0x00196454
		// (set) Token: 0x06004804 RID: 18436 RVA: 0x00025043 File Offset: 0x00023243
		public unsafe Vector2 passerbyGuestSpanInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_passerbyGuestSpanInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_passerbyGuestSpanInterval)) = value;
			}
		}

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06004805 RID: 18437 RVA: 0x0019827C File Offset: 0x0019647C
		// (set) Token: 0x06004806 RID: 18438 RVA: 0x0002505E File Offset: 0x0002325E
		public unsafe Il2CppReferenceArray<Izakaya.NormalGuestGroup> normalGuestPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_normalGuestPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya.NormalGuestGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_normalGuestPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F0 RID: 6128
		// (get) Token: 0x06004807 RID: 18439 RVA: 0x001982AC File Offset: 0x001964AC
		// (set) Token: 0x06004808 RID: 18440 RVA: 0x0002507D File Offset: 0x0002327D
		public unsafe float specialGuestGachaInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_specialGuestGachaInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_specialGuestGachaInterval)) = value;
			}
		}

		// Token: 0x170017F1 RID: 6129
		// (get) Token: 0x06004809 RID: 18441 RVA: 0x001982D4 File Offset: 0x001964D4
		// (set) Token: 0x0600480A RID: 18442 RVA: 0x00025098 File Offset: 0x00023298
		public unsafe Il2CppReferenceArray<Izakaya.SpecialGuestGroup> specialGuestPool
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_specialGuestPool);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Izakaya.SpecialGuestGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_specialGuestPool), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F2 RID: 6130
		// (get) Token: 0x0600480B RID: 18443 RVA: 0x00198304 File Offset: 0x00196504
		// (set) Token: 0x0600480C RID: 18444 RVA: 0x000250B7 File Offset: 0x000232B7
		public unsafe AssetReference mapAssetReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_mapAssetReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_mapAssetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F3 RID: 6131
		// (get) Token: 0x0600480D RID: 18445 RVA: 0x00198334 File Offset: 0x00196534
		// (set) Token: 0x0600480E RID: 18446 RVA: 0x000250D6 File Offset: 0x000232D6
		public unsafe Il2CppReferenceArray<ExpandableGameDataPack.AssetReferenceIdPair> mapSkinAssetReference
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_mapSkinAssetReference);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ExpandableGameDataPack.AssetReferenceIdPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_mapSkinAssetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170017F4 RID: 6132
		// (get) Token: 0x0600480F RID: 18447 RVA: 0x00198364 File Offset: 0x00196564
		// (set) Token: 0x06004810 RID: 18448 RVA: 0x000250F5 File Offset: 0x000232F5
		public unsafe int musicPackageIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_musicPackageIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_musicPackageIndex)) = value;
			}
		}

		// Token: 0x170017F5 RID: 6133
		// (get) Token: 0x06004811 RID: 18449 RVA: 0x0019838C File Offset: 0x0019658C
		// (set) Token: 0x06004812 RID: 18450 RVA: 0x00025110 File Offset: 0x00023310
		public unsafe bool musicPackageOverride
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_musicPackageOverride);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_musicPackageOverride)) = value;
			}
		}

		// Token: 0x170017F6 RID: 6134
		// (get) Token: 0x06004813 RID: 18451 RVA: 0x001983B4 File Offset: 0x001965B4
		// (set) Token: 0x06004814 RID: 18452 RVA: 0x0002512B File Offset: 0x0002332B
		public unsafe string daySceneMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_daySceneMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_daySceneMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170017F7 RID: 6135
		// (get) Token: 0x06004815 RID: 18453 RVA: 0x001983DC File Offset: 0x001965DC
		// (set) Token: 0x06004816 RID: 18454 RVA: 0x0002514A File Offset: 0x0002334A
		public unsafe int guestTableCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_guestTableCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_guestTableCount)) = value;
			}
		}

		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x06004817 RID: 18455 RVA: 0x00198404 File Offset: 0x00196604
		// (set) Token: 0x06004818 RID: 18456 RVA: 0x00025165 File Offset: 0x00023365
		public unsafe int cookTableCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_cookTableCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NativeFieldInfoPtr_cookTableCount)) = value;
			}
		}

		// Token: 0x0400315E RID: 12638
		private static readonly IntPtr NativeFieldInfoPtr_baseFundRange;

		// Token: 0x0400315F RID: 12639
		private static readonly IntPtr NativeFieldInfoPtr_normalGuestSpanInterval;

		// Token: 0x04003160 RID: 12640
		private static readonly IntPtr NativeFieldInfoPtr_spawnPasserbyGuest;

		// Token: 0x04003161 RID: 12641
		private static readonly IntPtr NativeFieldInfoPtr_passerbyGuestSpanInterval;

		// Token: 0x04003162 RID: 12642
		private static readonly IntPtr NativeFieldInfoPtr_normalGuestPool;

		// Token: 0x04003163 RID: 12643
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestGachaInterval;

		// Token: 0x04003164 RID: 12644
		private static readonly IntPtr NativeFieldInfoPtr_specialGuestPool;

		// Token: 0x04003165 RID: 12645
		private static readonly IntPtr NativeFieldInfoPtr_mapAssetReference;

		// Token: 0x04003166 RID: 12646
		private static readonly IntPtr NativeFieldInfoPtr_mapSkinAssetReference;

		// Token: 0x04003167 RID: 12647
		private static readonly IntPtr NativeFieldInfoPtr_musicPackageIndex;

		// Token: 0x04003168 RID: 12648
		private static readonly IntPtr NativeFieldInfoPtr_musicPackageOverride;

		// Token: 0x04003169 RID: 12649
		private static readonly IntPtr NativeFieldInfoPtr_daySceneMapLabel;

		// Token: 0x0400316A RID: 12650
		private static readonly IntPtr NativeFieldInfoPtr_guestTableCount;

		// Token: 0x0400316B RID: 12651
		private static readonly IntPtr NativeFieldInfoPtr_cookTableCount;

		// Token: 0x0400316C RID: 12652
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Vector2Int_Vector2_Il2CppReferenceArray_1_NormalGuestGroup_Single_Il2CppReferenceArray_1_SpecialGuestGroup_Int32_String_0;

		// Token: 0x0400316D RID: 12653
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseFundRange_Public_get_Vector2Int_0;

		// Token: 0x0400316E RID: 12654
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestSpanInterval_Public_get_Vector2_0;

		// Token: 0x0400316F RID: 12655
		private static readonly IntPtr NativeMethodInfoPtr_get_SpawnPasserbyGuest_Public_get_Boolean_0;

		// Token: 0x04003170 RID: 12656
		private static readonly IntPtr NativeMethodInfoPtr_get_PasserbyGuestSpanInterval_Public_get_Vector2_0;

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeMethodInfoPtr_get_NormalGuestPool_Public_get_Il2CppReferenceArray_1_NormalGuestGroup_0;

		// Token: 0x04003172 RID: 12658
		private static readonly IntPtr NativeMethodInfoPtr_set_NormalGuestPool_Public_set_Void_Il2CppReferenceArray_1_NormalGuestGroup_0;

		// Token: 0x04003173 RID: 12659
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestGachaInterval_Public_get_Single_0;

		// Token: 0x04003174 RID: 12660
		private static readonly IntPtr NativeMethodInfoPtr_get_SpecialGuestPool_Public_get_Il2CppReferenceArray_1_SpecialGuestGroup_0;

		// Token: 0x04003175 RID: 12661
		private static readonly IntPtr NativeMethodInfoPtr_set_SpecialGuestPool_Public_set_Void_Il2CppReferenceArray_1_SpecialGuestGroup_0;

		// Token: 0x04003176 RID: 12662
		private static readonly IntPtr NativeMethodInfoPtr_get_OriginalSpecialGuestPool_Public_get_Il2CppReferenceArray_1_SpecialGuestGroup_0;

		// Token: 0x04003177 RID: 12663
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicPackageIndex_Public_get_Int32_0;

		// Token: 0x04003178 RID: 12664
		private static readonly IntPtr NativeMethodInfoPtr_get_MusicPackageOverride_Public_get_Boolean_0;

		// Token: 0x04003179 RID: 12665
		private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneMapLabel_Public_get_String_0;

		// Token: 0x0400317A RID: 12666
		private static readonly IntPtr NativeMethodInfoPtr_get_DaySceneMapName_Public_get_String_0;

		// Token: 0x0400317B RID: 12667
		private static readonly IntPtr NativeMethodInfoPtr_get_IzakayaLevel_Public_get_Int32_0;

		// Token: 0x0400317C RID: 12668
		private static readonly IntPtr NativeMethodInfoPtr_get_MapAssetReference_Public_get_AssetReference_0;

		// Token: 0x0400317D RID: 12669
		private static readonly IntPtr NativeMethodInfoPtr_get_MapSkinAssetReferences_Public_get_IEnumerable_1_AssetReference_0;

		// Token: 0x0400317E RID: 12670
		private static readonly IntPtr NativeMethodInfoPtr_get_MapSkinAssetReference_Public_get_Il2CppReferenceArray_1_AssetReferenceIdPair_0;

		// Token: 0x0400317F RID: 12671
		private static readonly IntPtr NativeMethodInfoPtr_set_MapSkinAssetReference_Public_set_Void_Il2CppReferenceArray_1_AssetReferenceIdPair_0;

		// Token: 0x04003180 RID: 12672
		private static readonly IntPtr NativeMethodInfoPtr_GetMap_Public_AssetReference_Int32_0;

		// Token: 0x04003181 RID: 12673
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Object_0;

		// Token: 0x04003182 RID: 12674
		private static readonly IntPtr NativeMethodInfoPtr_GetText_Protected_Virtual_ObjectLanguageBase_Int32_0;

		// Token: 0x02000AB8 RID: 2744
		[Serializable]
		public class NormalGuestGroup : Il2CppSystem.Object
		{
			// Token: 0x0600CDB9 RID: 52665 RVA: 0x0032B7A4 File Offset: 0x003299A4
			// Note: this type is marked as 'beforefieldinit'.
			static NormalGuestGroup()
			{
				Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "NormalGuestGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr);
				Izakaya.NormalGuestGroup.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr, "data");
				Izakaya.NormalGuestGroup.NativeFieldInfoPtr_weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr, "weight");
				Izakaya.NormalGuestGroup.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr, 100677697);
				Izakaya.NormalGuestGroup.NativeMethodInfoPtr_get_Expanded_Public_get_IEnumerable_1_IEnumerable_1_NormalGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr, 100677698);
				Izakaya.NormalGuestGroup.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr, 100677699);
				Izakaya.NormalGuestGroup.NativeMethodInfoPtr_get_Weight_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr, 100677700);
			}

			// Token: 0x0600CDBA RID: 52666 RVA: 0x0032B848 File Offset: 0x00329A48
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 189633, RefRangeEnd = 189637, XrefRangeStart = 189631, XrefRangeEnd = 189633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NormalGuestGroup(Il2CppStructArray<int> data, int weight) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref weight;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NormalGuestGroup.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042E1 RID: 17121
			// (get) Token: 0x0600CDBB RID: 52667 RVA: 0x0032B8A4 File Offset: 0x00329AA4
			public unsafe IEnumerable<IEnumerable<NormalGuest>> Expanded
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 189659, RefRangeEnd = 189663, XrefRangeStart = 189637, XrefRangeEnd = 189659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NormalGuestGroup.NativeMethodInfoPtr_get_Expanded_Public_get_IEnumerable_1_IEnumerable_1_NormalGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IEnumerable<NormalGuest>>>(intPtr3) : null;
				}
			}

			// Token: 0x170042E2 RID: 17122
			// (get) Token: 0x0600CDBC RID: 52668 RVA: 0x0032B8E4 File Offset: 0x00329AE4
			public unsafe Il2CppStructArray<int> Data
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 44, RefRangeEnd = 58, XrefRangeStart = 44, XrefRangeEnd = 58, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NormalGuestGroup.NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
			}

			// Token: 0x170042E3 RID: 17123
			// (get) Token: 0x0600CDBD RID: 52669 RVA: 0x0032B924 File Offset: 0x00329B24
			public unsafe int Weight
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NormalGuestGroup.NativeMethodInfoPtr_get_Weight_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CDBE RID: 52670 RVA: 0x0006E39A File Offset: 0x0006C59A
			public NormalGuestGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042DF RID: 17119
			// (get) Token: 0x0600CDBF RID: 52671 RVA: 0x0032B960 File Offset: 0x00329B60
			// (set) Token: 0x0600CDC0 RID: 52672 RVA: 0x0006E3A3 File Offset: 0x0006C5A3
			public unsafe Il2CppStructArray<int> data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NormalGuestGroup.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NormalGuestGroup.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E0 RID: 17120
			// (get) Token: 0x0600CDC1 RID: 52673 RVA: 0x0032B990 File Offset: 0x00329B90
			// (set) Token: 0x0600CDC2 RID: 52674 RVA: 0x0006E3C2 File Offset: 0x0006C5C2
			public unsafe int weight
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NormalGuestGroup.NativeFieldInfoPtr_weight);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.NormalGuestGroup.NativeFieldInfoPtr_weight)) = value;
				}
			}

			// Token: 0x04008446 RID: 33862
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04008447 RID: 33863
			private static readonly IntPtr NativeFieldInfoPtr_weight;

			// Token: 0x04008448 RID: 33864
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStructArray_1_Int32_Int32_0;

			// Token: 0x04008449 RID: 33865
			private static readonly IntPtr NativeMethodInfoPtr_get_Expanded_Public_get_IEnumerable_1_IEnumerable_1_NormalGuest_0;

			// Token: 0x0400844A RID: 33866
			private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_get_Il2CppStructArray_1_Int32_0;

			// Token: 0x0400844B RID: 33867
			private static readonly IntPtr NativeMethodInfoPtr_get_Weight_Public_get_Int32_0;

			// Token: 0x02001017 RID: 4119
			[ObfuscatedName("GameData.Core.Collections.Izakaya+NormalGuestGroup+<>c")]
			[Serializable]
			public sealed class __c : Il2CppSystem.Object
			{
				// Token: 0x06011A16 RID: 72214 RVA: 0x0040AE84 File Offset: 0x00409084
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<Izakaya.NormalGuestGroup.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Izakaya.NormalGuestGroup>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Izakaya.NormalGuestGroup.__c>.NativeClassPtr);
					Izakaya.NormalGuestGroup.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.NormalGuestGroup.__c>.NativeClassPtr, "<>9");
					Izakaya.NormalGuestGroup.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.NormalGuestGroup.__c>.NativeClassPtr, "<>9__4_0");
					Izakaya.NormalGuestGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.NormalGuestGroup.__c>.NativeClassPtr, 100677702);
					Izakaya.NormalGuestGroup.__c.NativeMethodInfoPtr__get_Expanded_b__4_0_Internal_NormalGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.NormalGuestGroup.__c>.NativeClassPtr, 100677703);
				}

				// Token: 0x06011A17 RID: 72215 RVA: 0x0040AF00 File Offset: 0x00409100
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Izakaya.NormalGuestGroup.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NormalGuestGroup.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011A18 RID: 72216 RVA: 0x0040AF3C File Offset: 0x0040913C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189627, XrefRangeEnd = 189631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe NormalGuest _get_Expanded_b__4_0(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.NormalGuestGroup.__c.NativeMethodInfoPtr__get_Expanded_b__4_0_Internal_NormalGuest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<NormalGuest>(intPtr3) : null;
				}

				// Token: 0x06011A19 RID: 72217 RVA: 0x00099456 File Offset: 0x00097656
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BAF RID: 23471
				// (get) Token: 0x06011A1A RID: 72218 RVA: 0x0040AF88 File Offset: 0x00409188
				// (set) Token: 0x06011A1B RID: 72219 RVA: 0x0009945F File Offset: 0x0009765F
				public unsafe static Izakaya.NormalGuestGroup.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Izakaya.NormalGuestGroup.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya.NormalGuestGroup.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Izakaya.NormalGuestGroup.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BB0 RID: 23472
				// (get) Token: 0x06011A1C RID: 72220 RVA: 0x0040AFB0 File Offset: 0x004091B0
				// (set) Token: 0x06011A1D RID: 72221 RVA: 0x00099471 File Offset: 0x00097671
				public unsafe static Func<int, NormalGuest> __9__4_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Izakaya.NormalGuestGroup.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, NormalGuest>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Izakaya.NormalGuestGroup.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B23A RID: 45626
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B23B RID: 45627
				private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

				// Token: 0x0400B23C RID: 45628
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B23D RID: 45629
				private static readonly IntPtr NativeMethodInfoPtr__get_Expanded_b__4_0_Internal_NormalGuest_Int32_0;
			}
		}

		// Token: 0x02000AB9 RID: 2745
		[Serializable]
		public class SpecialGuestGroup : Il2CppSystem.Object
		{
			// Token: 0x0600CDC3 RID: 52675 RVA: 0x0032B9B8 File Offset: 0x00329BB8
			// Note: this type is marked as 'beforefieldinit'.
			static SpecialGuestGroup()
			{
				Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "SpecialGuestGroup");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr);
				Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_groupId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr, "groupId");
				Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_probPerDraw = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr, "probPerDraw");
				Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_onlySpawnAfterUnlocking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr, "onlySpawnAfterUnlocking");
				Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_onlySpawnWhenPlaceBeRecorded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr, "onlySpawnWhenPlaceBeRecorded");
				Izakaya.SpecialGuestGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr, 100677704);
				Izakaya.SpecialGuestGroup.NativeMethodInfoPtr_get_GroupId_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr, 100677705);
				Izakaya.SpecialGuestGroup.NativeMethodInfoPtr_get_ProbPerDraw_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr, 100677706);
				Izakaya.SpecialGuestGroup.NativeMethodInfoPtr_get_OnlySpawnAfterUnlocking_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr, 100677707);
				Izakaya.SpecialGuestGroup.NativeMethodInfoPtr_get_OnlySpawnWhenPlaceBeRecorded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr, 100677708);
			}

			// Token: 0x0600CDC4 RID: 52676 RVA: 0x0032BA98 File Offset: 0x00329C98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 189663, XrefRangeEnd = 189664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuestGroup(int groupId, float probPerDraw, bool onlySpawnAfterUnlocking, bool onlySpawnWhenPlaceBeRecorded) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Izakaya.SpecialGuestGroup>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref groupId;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref probPerDraw;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlySpawnAfterUnlocking;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref onlySpawnWhenPlaceBeRecorded;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.SpecialGuestGroup.NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042E8 RID: 17128
			// (get) Token: 0x0600CDC5 RID: 52677 RVA: 0x0032BB0C File Offset: 0x00329D0C
			public unsafe int GroupId
			{
				[CallerCount(6)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 6, XrefRangeStart = 0, XrefRangeEnd = 6, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.SpecialGuestGroup.NativeMethodInfoPtr_get_GroupId_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170042E9 RID: 17129
			// (get) Token: 0x0600CDC6 RID: 52678 RVA: 0x0032BB48 File Offset: 0x00329D48
			public unsafe float ProbPerDraw
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.SpecialGuestGroup.NativeMethodInfoPtr_get_ProbPerDraw_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170042EA RID: 17130
			// (get) Token: 0x0600CDC7 RID: 52679 RVA: 0x0032BB84 File Offset: 0x00329D84
			public unsafe bool OnlySpawnAfterUnlocking
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 24573, RefRangeEnd = 24574, XrefRangeStart = 24573, XrefRangeEnd = 24574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.SpecialGuestGroup.NativeMethodInfoPtr_get_OnlySpawnAfterUnlocking_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170042EB RID: 17131
			// (get) Token: 0x0600CDC8 RID: 52680 RVA: 0x0032BBC0 File Offset: 0x00329DC0
			public unsafe bool OnlySpawnWhenPlaceBeRecorded
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.SpecialGuestGroup.NativeMethodInfoPtr_get_OnlySpawnWhenPlaceBeRecorded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600CDC9 RID: 52681 RVA: 0x0006E3DD File Offset: 0x0006C5DD
			public SpecialGuestGroup(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E4 RID: 17124
			// (get) Token: 0x0600CDCA RID: 52682 RVA: 0x0032BBFC File Offset: 0x00329DFC
			// (set) Token: 0x0600CDCB RID: 52683 RVA: 0x0006E3E6 File Offset: 0x0006C5E6
			public unsafe int groupId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_groupId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_groupId)) = value;
				}
			}

			// Token: 0x170042E5 RID: 17125
			// (get) Token: 0x0600CDCC RID: 52684 RVA: 0x0032BC24 File Offset: 0x00329E24
			// (set) Token: 0x0600CDCD RID: 52685 RVA: 0x0006E401 File Offset: 0x0006C601
			public unsafe float probPerDraw
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_probPerDraw);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_probPerDraw)) = value;
				}
			}

			// Token: 0x170042E6 RID: 17126
			// (get) Token: 0x0600CDCE RID: 52686 RVA: 0x0032BC4C File Offset: 0x00329E4C
			// (set) Token: 0x0600CDCF RID: 52687 RVA: 0x0006E41C File Offset: 0x0006C61C
			public unsafe bool onlySpawnAfterUnlocking
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_onlySpawnAfterUnlocking);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_onlySpawnAfterUnlocking)) = value;
				}
			}

			// Token: 0x170042E7 RID: 17127
			// (get) Token: 0x0600CDD0 RID: 52688 RVA: 0x0032BC74 File Offset: 0x00329E74
			// (set) Token: 0x0600CDD1 RID: 52689 RVA: 0x0006E437 File Offset: 0x0006C637
			public unsafe bool onlySpawnWhenPlaceBeRecorded
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_onlySpawnWhenPlaceBeRecorded);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.SpecialGuestGroup.NativeFieldInfoPtr_onlySpawnWhenPlaceBeRecorded)) = value;
				}
			}

			// Token: 0x0400844C RID: 33868
			private static readonly IntPtr NativeFieldInfoPtr_groupId;

			// Token: 0x0400844D RID: 33869
			private static readonly IntPtr NativeFieldInfoPtr_probPerDraw;

			// Token: 0x0400844E RID: 33870
			private static readonly IntPtr NativeFieldInfoPtr_onlySpawnAfterUnlocking;

			// Token: 0x0400844F RID: 33871
			private static readonly IntPtr NativeFieldInfoPtr_onlySpawnWhenPlaceBeRecorded;

			// Token: 0x04008450 RID: 33872
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Single_Boolean_Boolean_0;

			// Token: 0x04008451 RID: 33873
			private static readonly IntPtr NativeMethodInfoPtr_get_GroupId_Public_get_Int32_0;

			// Token: 0x04008452 RID: 33874
			private static readonly IntPtr NativeMethodInfoPtr_get_ProbPerDraw_Public_get_Single_0;

			// Token: 0x04008453 RID: 33875
			private static readonly IntPtr NativeMethodInfoPtr_get_OnlySpawnAfterUnlocking_Public_get_Boolean_0;

			// Token: 0x04008454 RID: 33876
			private static readonly IntPtr NativeMethodInfoPtr_get_OnlySpawnWhenPlaceBeRecorded_Public_get_Boolean_0;
		}

		// Token: 0x02000ABA RID: 2746
		[ObfuscatedName("GameData.Core.Collections.Izakaya+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CDD2 RID: 52690 RVA: 0x0032BC9C File Offset: 0x00329E9C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Izakaya.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Izakaya.__c>.NativeClassPtr);
				Izakaya.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.__c>.NativeClassPtr, "<>9");
				Izakaya.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.__c>.NativeClassPtr, "<>9__46_0");
				Izakaya.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.__c>.NativeClassPtr, 100677710);
				Izakaya.__c.NativeMethodInfoPtr__get_MapSkinAssetReferences_b__46_0_Internal_AssetReference_AssetReferenceIdPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.__c>.NativeClassPtr, 100677711);
			}

			// Token: 0x0600CDD3 RID: 52691 RVA: 0x0032BD18 File Offset: 0x00329F18
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Izakaya.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDD4 RID: 52692 RVA: 0x0032BD54 File Offset: 0x00329F54
			[CallerCount(0)]
			public unsafe AssetReference _get_MapSkinAssetReferences_b__46_0(ExpandableGameDataPack.AssetReferenceIdPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.__c.NativeMethodInfoPtr__get_MapSkinAssetReferences_b__46_0_Internal_AssetReference_AssetReferenceIdPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr3) : null;
			}

			// Token: 0x0600CDD5 RID: 52693 RVA: 0x0006E452 File Offset: 0x0006C652
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EC RID: 17132
			// (get) Token: 0x0600CDD6 RID: 52694 RVA: 0x0032BDAC File Offset: 0x00329FAC
			// (set) Token: 0x0600CDD7 RID: 52695 RVA: 0x0006E45B File Offset: 0x0006C65B
			public unsafe static Izakaya.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Izakaya.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Izakaya.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Izakaya.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042ED RID: 17133
			// (get) Token: 0x0600CDD8 RID: 52696 RVA: 0x0032BDD4 File Offset: 0x00329FD4
			// (set) Token: 0x0600CDD9 RID: 52697 RVA: 0x0006E46D File Offset: 0x0006C66D
			public unsafe static Func<ExpandableGameDataPack.AssetReferenceIdPair, AssetReference> __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Izakaya.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ExpandableGameDataPack.AssetReferenceIdPair, AssetReference>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Izakaya.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008455 RID: 33877
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008456 RID: 33878
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x04008457 RID: 33879
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008458 RID: 33880
			private static readonly IntPtr NativeMethodInfoPtr__get_MapSkinAssetReferences_b__46_0_Internal_AssetReference_AssetReferenceIdPair_0;
		}

		// Token: 0x02000ABB RID: 2747
		[ObfuscatedName("GameData.Core.Collections.Izakaya+<>c__DisplayClass50_0")]
		public sealed class __c__DisplayClass50_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CDDA RID: 52698 RVA: 0x0032BDFC File Offset: 0x00329FFC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass50_0()
			{
				Il2CppClassPointerStore<Izakaya.__c__DisplayClass50_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Izakaya>.NativeClassPtr, "<>c__DisplayClass50_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Izakaya.__c__DisplayClass50_0>.NativeClassPtr);
				Izakaya.__c__DisplayClass50_0.NativeFieldInfoPtr_skinOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Izakaya.__c__DisplayClass50_0>.NativeClassPtr, "skinOffset");
				Izakaya.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.__c__DisplayClass50_0>.NativeClassPtr, 100677712);
				Izakaya.__c__DisplayClass50_0.NativeMethodInfoPtr__GetMap_b__0_Internal_Boolean_AssetReferenceIdPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.__c__DisplayClass50_0>.NativeClassPtr, 100677713);
				Izakaya.__c__DisplayClass50_0.NativeMethodInfoPtr__GetMap_b__1_Internal_Boolean_AssetReferenceIdPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Izakaya.__c__DisplayClass50_0>.NativeClassPtr, 100677714);
			}

			// Token: 0x0600CDDB RID: 52699 RVA: 0x0032BE78 File Offset: 0x0032A078
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass50_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Izakaya.__c__DisplayClass50_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.__c__DisplayClass50_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDDC RID: 52700 RVA: 0x0032BEB4 File Offset: 0x0032A0B4
			[CallerCount(0)]
			public unsafe bool _GetMap_b__0(ExpandableGameDataPack.AssetReferenceIdPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.__c__DisplayClass50_0.NativeMethodInfoPtr__GetMap_b__0_Internal_Boolean_AssetReferenceIdPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDDD RID: 52701 RVA: 0x0032BF08 File Offset: 0x0032A108
			[CallerCount(0)]
			public unsafe bool _GetMap_b__1(ExpandableGameDataPack.AssetReferenceIdPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Izakaya.__c__DisplayClass50_0.NativeMethodInfoPtr__GetMap_b__1_Internal_Boolean_AssetReferenceIdPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDDE RID: 52702 RVA: 0x0006E47F File Offset: 0x0006C67F
			public __c__DisplayClass50_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042EE RID: 17134
			// (get) Token: 0x0600CDDF RID: 52703 RVA: 0x0032BF5C File Offset: 0x0032A15C
			// (set) Token: 0x0600CDE0 RID: 52704 RVA: 0x0006E488 File Offset: 0x0006C688
			public unsafe int skinOffset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.__c__DisplayClass50_0.NativeFieldInfoPtr_skinOffset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Izakaya.__c__DisplayClass50_0.NativeFieldInfoPtr_skinOffset)) = value;
				}
			}

			// Token: 0x04008459 RID: 33881
			private static readonly IntPtr NativeFieldInfoPtr_skinOffset;

			// Token: 0x0400845A RID: 33882
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400845B RID: 33883
			private static readonly IntPtr NativeMethodInfoPtr__GetMap_b__0_Internal_Boolean_AssetReferenceIdPair_0;

			// Token: 0x0400845C RID: 33884
			private static readonly IntPtr NativeMethodInfoPtr__GetMap_b__1_Internal_Boolean_AssetReferenceIdPair_0;
		}
	}
}
