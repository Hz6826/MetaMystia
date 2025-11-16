using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x020002D6 RID: 726
	public class GameDataProfile : ScriptableObject
	{
		// Token: 0x06005978 RID: 22904 RVA: 0x001CACF8 File Offset: 0x001C8EF8
		// Note: this type is marked as 'beforefieldinit'.
		static GameDataProfile()
		{
			Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "GameDataProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr);
			GameDataProfile.NativeFieldInfoPtr_s_GetAssets_Profiler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "s_GetAssets_Profiler");
			GameDataProfile.NativeFieldInfoPtr_coreDataPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "coreDataPack");
			GameDataProfile.NativeFieldInfoPtr_dlcGameDataPacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "dlcGameDataPacks");
			GameDataProfile.NativeFieldInfoPtr_sharedGameDataPacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "sharedGameDataPacks");
			GameDataProfile.NativeFieldInfoPtr_m_ActiveDLCLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "m_ActiveDLCLabel");
			GameDataProfile.NativeFieldInfoPtr_m_AllGameDataPacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "m_AllGameDataPacks");
			GameDataProfile.NativeMethodInfoPtr_get_ActiveDLCLabel_Public_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, 100681316);
			GameDataProfile.NativeMethodInfoPtr_get_AllGameDataPacks_Private_get_Dictionary_2_String_List_1_ValueTuple_2_ExpandableGameDataPack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, 100681317);
			GameDataProfile.NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_Il2CppArrayBase_1_T_Func_2_ExpandableGameDataPack_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, 100681318);
			GameDataProfile.NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, 100681319);
			GameDataProfile.NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_AssetReference_Func_2_ExpandableGameDataPack_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, 100681320);
			GameDataProfile.NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_MultiLanguageAssetReference_Func_2_ExpandableGameDataPack_MultiLanguageAssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, 100681321);
			GameDataProfile.NativeMethodInfoPtr_GetAssets_Private_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_Func_2_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, 100681322);
			GameDataProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, 100681323);
			GameDataProfile.NativeMethodInfoPtr_Method_Private_List_1_ValueTuple_2_ExpandableGameDataPack_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, 100681325);
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x06005979 RID: 22905 RVA: 0x001CAE54 File Offset: 0x001C9054
		public unsafe List<string> ActiveDLCLabel
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 219327, RefRangeEnd = 219342, XrefRangeStart = 219300, XrefRangeEnd = 219327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.NativeMethodInfoPtr_get_ActiveDLCLabel_Public_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x0600597A RID: 22906 RVA: 0x001CAE94 File Offset: 0x001C9094
		public unsafe Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>> AllGameDataPacks
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 219491, RefRangeEnd = 219492, XrefRangeStart = 219342, XrefRangeEnd = 219491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.NativeMethodInfoPtr_get_AllGameDataPacks_Private_get_Dictionary_2_String_List_1_ValueTuple_2_ExpandableGameDataPack_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>>>(intPtr3) : null;
			}
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x001CAED4 File Offset: 0x001C90D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219504, RefRangeEnd = 219506, XrefRangeStart = 219492, XrefRangeEnd = 219504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<KeyValuePair<string, Il2CppArrayBase<T>>> GetAssets<T>(Func<ExpandableGameDataPack, Il2CppArrayBase<T>> getAssetCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getAssetCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.MethodInfoStoreGeneric_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_Il2CppArrayBase_1_T_Func_2_ExpandableGameDataPack_Il2CppArrayBase_1_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, Il2CppArrayBase<T>>>>(intPtr3) : null;
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x001CAF24 File Offset: 0x001C9124
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219504, RefRangeEnd = 219506, XrefRangeStart = 219504, XrefRangeEnd = 219506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<KeyValuePair<string, T>> GetAssets<T>(Func<ExpandableGameDataPack, T> getAssetCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getAssetCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.MethodInfoStoreGeneric_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, T>>>(intPtr3) : null;
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x001CAF74 File Offset: 0x001C9174
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 219525, RefRangeEnd = 219526, XrefRangeStart = 219506, XrefRangeEnd = 219525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<KeyValuePair<string, AssetReference>> GetAssets(Func<ExpandableGameDataPack, AssetReference> getAssetCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getAssetCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_AssetReference_Func_2_ExpandableGameDataPack_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, AssetReference>>>(intPtr3) : null;
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x001CAFC4 File Offset: 0x001C91C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219526, XrefRangeEnd = 219545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<KeyValuePair<string, MultiLanguageTextMesh.MultiLanguageAssetReference>> GetAssets(Func<ExpandableGameDataPack, MultiLanguageTextMesh.MultiLanguageAssetReference> getAssetCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getAssetCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_MultiLanguageAssetReference_Func_2_ExpandableGameDataPack_MultiLanguageAssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, MultiLanguageTextMesh.MultiLanguageAssetReference>>>(intPtr3) : null;
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x001CB014 File Offset: 0x001C9214
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219550, RefRangeEnd = 219552, XrefRangeStart = 219545, XrefRangeEnd = 219550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerable<KeyValuePair<string, T>> GetAssets<T>(Func<ExpandableGameDataPack, T> getAssetCallback, Func<T, bool> valifyAssetCallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(getAssetCallback);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valifyAssetCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.MethodInfoStoreGeneric_GetAssets_Private_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_Func_2_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<KeyValuePair<string, T>>>(intPtr3) : null;
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x001CB078 File Offset: 0x001C9278
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDataProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x001CB0B4 File Offset: 0x001C92B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 219564, RefRangeEnd = 219566, XrefRangeStart = 219552, XrefRangeEnd = 219564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ValueTuple<ExpandableGameDataPack, bool>> Method_Private_List_1_ValueTuple_2_ExpandableGameDataPack_Boolean_String_0(string dlcKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dlcKey);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.NativeMethodInfoPtr_Method_Private_List_1_ValueTuple_2_ExpandableGameDataPack_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<ExpandableGameDataPack, bool>>>(intPtr3) : null;
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x000304A5 File Offset: 0x0002E6A5
		public GameDataProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x06005983 RID: 22915 RVA: 0x001CB104 File Offset: 0x001C9304
		// (set) Token: 0x06005984 RID: 22916 RVA: 0x000304AE File Offset: 0x0002E6AE
		public unsafe static ProfilerMarker s_GetAssets_Profiler
		{
			get
			{
				ProfilerMarker result;
				IL2CPP.il2cpp_field_static_get_value(GameDataProfile.NativeFieldInfoPtr_s_GetAssets_Profiler, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameDataProfile.NativeFieldInfoPtr_s_GetAssets_Profiler, (void*)(&value));
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x06005985 RID: 22917 RVA: 0x001CB120 File Offset: 0x001C9320
		// (set) Token: 0x06005986 RID: 22918 RVA: 0x000304BC File Offset: 0x0002E6BC
		public unsafe ExpandableGameDataPack coreDataPack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_coreDataPack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandableGameDataPack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_coreDataPack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x06005987 RID: 22919 RVA: 0x001CB150 File Offset: 0x001C9350
		// (set) Token: 0x06005988 RID: 22920 RVA: 0x000304DB File Offset: 0x0002E6DB
		public unsafe Il2CppReferenceArray<GameDataProfile.DLCGameDataPack> dlcGameDataPacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_dlcGameDataPacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameDataProfile.DLCGameDataPack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_dlcGameDataPacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x06005989 RID: 22921 RVA: 0x001CB180 File Offset: 0x001C9380
		// (set) Token: 0x0600598A RID: 22922 RVA: 0x000304FA File Offset: 0x0002E6FA
		public unsafe Il2CppReferenceArray<GameDataProfile.SharedGameDataPack> sharedGameDataPacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_sharedGameDataPacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameDataProfile.SharedGameDataPack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_sharedGameDataPacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x0600598B RID: 22923 RVA: 0x001CB1B0 File Offset: 0x001C93B0
		// (set) Token: 0x0600598C RID: 22924 RVA: 0x00030519 File Offset: 0x0002E719
		public unsafe List<string> m_ActiveDLCLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_m_ActiveDLCLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_m_ActiveDLCLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x0600598D RID: 22925 RVA: 0x001CB1E0 File Offset: 0x001C93E0
		// (set) Token: 0x0600598E RID: 22926 RVA: 0x00030538 File Offset: 0x0002E738
		public unsafe Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>> m_AllGameDataPacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_m_AllGameDataPacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.NativeFieldInfoPtr_m_AllGameDataPacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003BB8 RID: 15288
		private static readonly IntPtr NativeFieldInfoPtr_s_GetAssets_Profiler;

		// Token: 0x04003BB9 RID: 15289
		private static readonly IntPtr NativeFieldInfoPtr_coreDataPack;

		// Token: 0x04003BBA RID: 15290
		private static readonly IntPtr NativeFieldInfoPtr_dlcGameDataPacks;

		// Token: 0x04003BBB RID: 15291
		private static readonly IntPtr NativeFieldInfoPtr_sharedGameDataPacks;

		// Token: 0x04003BBC RID: 15292
		private static readonly IntPtr NativeFieldInfoPtr_m_ActiveDLCLabel;

		// Token: 0x04003BBD RID: 15293
		private static readonly IntPtr NativeFieldInfoPtr_m_AllGameDataPacks;

		// Token: 0x04003BBE RID: 15294
		private static readonly IntPtr NativeMethodInfoPtr_get_ActiveDLCLabel_Public_get_List_1_String_0;

		// Token: 0x04003BBF RID: 15295
		private static readonly IntPtr NativeMethodInfoPtr_get_AllGameDataPacks_Private_get_Dictionary_2_String_List_1_ValueTuple_2_ExpandableGameDataPack_Boolean_0;

		// Token: 0x04003BC0 RID: 15296
		private static readonly IntPtr NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_Il2CppArrayBase_1_T_Func_2_ExpandableGameDataPack_Il2CppArrayBase_1_T_0;

		// Token: 0x04003BC1 RID: 15297
		private static readonly IntPtr NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_0;

		// Token: 0x04003BC2 RID: 15298
		private static readonly IntPtr NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_AssetReference_Func_2_ExpandableGameDataPack_AssetReference_0;

		// Token: 0x04003BC3 RID: 15299
		private static readonly IntPtr NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_MultiLanguageAssetReference_Func_2_ExpandableGameDataPack_MultiLanguageAssetReference_0;

		// Token: 0x04003BC4 RID: 15300
		private static readonly IntPtr NativeMethodInfoPtr_GetAssets_Private_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_Func_2_T_Boolean_0;

		// Token: 0x04003BC5 RID: 15301
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003BC6 RID: 15302
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_List_1_ValueTuple_2_ExpandableGameDataPack_Boolean_String_0;

		// Token: 0x02000C9E RID: 3230
		[Serializable]
		public sealed class DLCGameDataPack : ValueType
		{
			// Token: 0x0600E7F3 RID: 59379 RVA: 0x00378E74 File Offset: 0x00377074
			// Note: this type is marked as 'beforefieldinit'.
			static DLCGameDataPack()
			{
				Il2CppClassPointerStore<GameDataProfile.DLCGameDataPack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "DLCGameDataPack");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataProfile.DLCGameDataPack>.NativeClassPtr);
				GameDataProfile.DLCGameDataPack.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.DLCGameDataPack>.NativeClassPtr, "key");
				GameDataProfile.DLCGameDataPack.NativeFieldInfoPtr_sharedKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.DLCGameDataPack>.NativeClassPtr, "sharedKey");
				GameDataProfile.DLCGameDataPack.NativeFieldInfoPtr_dlcGameDataPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.DLCGameDataPack>.NativeClassPtr, "dlcGameDataPack");
			}

			// Token: 0x0600E7F4 RID: 59380 RVA: 0x0007BF09 File Offset: 0x0007A109
			public DLCGameDataPack(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E7F5 RID: 59381 RVA: 0x0007BF12 File Offset: 0x0007A112
			public DLCGameDataPack() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataProfile.DLCGameDataPack>.NativeClassPtr))
			{
			}

			// Token: 0x17004B5D RID: 19293
			// (get) Token: 0x0600E7F6 RID: 59382 RVA: 0x00378EDC File Offset: 0x003770DC
			// (set) Token: 0x0600E7F7 RID: 59383 RVA: 0x0007BF24 File Offset: 0x0007A124
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.DLCGameDataPack.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.DLCGameDataPack.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B5E RID: 19294
			// (get) Token: 0x0600E7F8 RID: 59384 RVA: 0x00378F04 File Offset: 0x00377104
			// (set) Token: 0x0600E7F9 RID: 59385 RVA: 0x0007BF43 File Offset: 0x0007A143
			public unsafe Il2CppStringArray sharedKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.DLCGameDataPack.NativeFieldInfoPtr_sharedKey);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.DLCGameDataPack.NativeFieldInfoPtr_sharedKey), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B5F RID: 19295
			// (get) Token: 0x0600E7FA RID: 59386 RVA: 0x00378F34 File Offset: 0x00377134
			// (set) Token: 0x0600E7FB RID: 59387 RVA: 0x0007BF62 File Offset: 0x0007A162
			public unsafe ExpandableGameDataPack dlcGameDataPack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.DLCGameDataPack.NativeFieldInfoPtr_dlcGameDataPack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandableGameDataPack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.DLCGameDataPack.NativeFieldInfoPtr_dlcGameDataPack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009405 RID: 37893
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04009406 RID: 37894
			private static readonly IntPtr NativeFieldInfoPtr_sharedKey;

			// Token: 0x04009407 RID: 37895
			private static readonly IntPtr NativeFieldInfoPtr_dlcGameDataPack;
		}

		// Token: 0x02000C9F RID: 3231
		[Serializable]
		public sealed class SharedGameDataPack : ValueType
		{
			// Token: 0x0600E7FC RID: 59388 RVA: 0x00378F64 File Offset: 0x00377164
			// Note: this type is marked as 'beforefieldinit'.
			static SharedGameDataPack()
			{
				Il2CppClassPointerStore<GameDataProfile.SharedGameDataPack>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "SharedGameDataPack");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataProfile.SharedGameDataPack>.NativeClassPtr);
				GameDataProfile.SharedGameDataPack.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.SharedGameDataPack>.NativeClassPtr, "key");
				GameDataProfile.SharedGameDataPack.NativeFieldInfoPtr_originKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.SharedGameDataPack>.NativeClassPtr, "originKey");
				GameDataProfile.SharedGameDataPack.NativeFieldInfoPtr_sharedGameDataPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.SharedGameDataPack>.NativeClassPtr, "sharedGameDataPack");
			}

			// Token: 0x0600E7FD RID: 59389 RVA: 0x0007BF81 File Offset: 0x0007A181
			public SharedGameDataPack(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E7FE RID: 59390 RVA: 0x0007BF8A File Offset: 0x0007A18A
			public SharedGameDataPack() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataProfile.SharedGameDataPack>.NativeClassPtr))
			{
			}

			// Token: 0x17004B60 RID: 19296
			// (get) Token: 0x0600E7FF RID: 59391 RVA: 0x00378FCC File Offset: 0x003771CC
			// (set) Token: 0x0600E800 RID: 59392 RVA: 0x0007BF9C File Offset: 0x0007A19C
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.SharedGameDataPack.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.SharedGameDataPack.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B61 RID: 19297
			// (get) Token: 0x0600E801 RID: 59393 RVA: 0x00378FF4 File Offset: 0x003771F4
			// (set) Token: 0x0600E802 RID: 59394 RVA: 0x0007BFBB File Offset: 0x0007A1BB
			public unsafe string originKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.SharedGameDataPack.NativeFieldInfoPtr_originKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.SharedGameDataPack.NativeFieldInfoPtr_originKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004B62 RID: 19298
			// (get) Token: 0x0600E803 RID: 59395 RVA: 0x0037901C File Offset: 0x0037721C
			// (set) Token: 0x0600E804 RID: 59396 RVA: 0x0007BFDA File Offset: 0x0007A1DA
			public unsafe ExpandableGameDataPack sharedGameDataPack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.SharedGameDataPack.NativeFieldInfoPtr_sharedGameDataPack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExpandableGameDataPack>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.SharedGameDataPack.NativeFieldInfoPtr_sharedGameDataPack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009408 RID: 37896
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04009409 RID: 37897
			private static readonly IntPtr NativeFieldInfoPtr_originKey;

			// Token: 0x0400940A RID: 37898
			private static readonly IntPtr NativeFieldInfoPtr_sharedGameDataPack;
		}

		// Token: 0x02000CA0 RID: 3232
		[ObfuscatedName("GameData.Profile.GameDataProfile+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E805 RID: 59397 RVA: 0x0037904C File Offset: 0x0037724C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<GameDataProfile.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataProfile.__c__DisplayClass9_0>.NativeClassPtr);
				GameDataProfile.__c__DisplayClass9_0.NativeFieldInfoPtr_sharedDataPack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.__c__DisplayClass9_0>.NativeClassPtr, "sharedDataPack");
				GameDataProfile.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c__DisplayClass9_0>.NativeClassPtr, 100681326);
				GameDataProfile.__c__DisplayClass9_0.NativeMethodInfoPtr__get_AllGameDataPacks_b__2_Internal_Boolean_ValueTuple_2_ExpandableGameDataPack_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c__DisplayClass9_0>.NativeClassPtr, 100681327);
			}

			// Token: 0x0600E806 RID: 59398 RVA: 0x003790B4 File Offset: 0x003772B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataProfile.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E807 RID: 59399 RVA: 0x003790F0 File Offset: 0x003772F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219175, XrefRangeEnd = 219219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_AllGameDataPacks_b__2(ValueTuple<ExpandableGameDataPack, bool> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c__DisplayClass9_0.NativeMethodInfoPtr__get_AllGameDataPacks_b__2_Internal_Boolean_ValueTuple_2_ExpandableGameDataPack_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E808 RID: 59400 RVA: 0x0007BFF9 File Offset: 0x0007A1F9
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B63 RID: 19299
			// (get) Token: 0x0600E809 RID: 59401 RVA: 0x00379144 File Offset: 0x00377344
			// (set) Token: 0x0600E80A RID: 59402 RVA: 0x0007C002 File Offset: 0x0007A202
			public GameDataProfile.SharedGameDataPack sharedDataPack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.__c__DisplayClass9_0.NativeFieldInfoPtr_sharedDataPack);
					return new GameDataProfile.SharedGameDataPack(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDataProfile.SharedGameDataPack>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile.__c__DisplayClass9_0.NativeFieldInfoPtr_sharedDataPack), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<GameDataProfile.SharedGameDataPack>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400940B RID: 37899
			private static readonly IntPtr NativeFieldInfoPtr_sharedDataPack;

			// Token: 0x0400940C RID: 37900
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400940D RID: 37901
			private static readonly IntPtr NativeMethodInfoPtr__get_AllGameDataPacks_b__2_Internal_Boolean_ValueTuple_2_ExpandableGameDataPack_Boolean_0;
		}

		// Token: 0x02000CA1 RID: 3233
		[ObfuscatedName("GameData.Profile.GameDataProfile+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E80B RID: 59403 RVA: 0x00379174 File Offset: 0x00377374
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr);
				GameDataProfile.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr, "<>9");
				GameDataProfile.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr, "<>9__9_1");
				GameDataProfile.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr, "<>9__12_0");
				GameDataProfile.__c.NativeFieldInfoPtr___9__13_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr, "<>9__13_0");
				GameDataProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr, 100681329);
				GameDataProfile.__c.NativeMethodInfoPtr__get_AllGameDataPacks_b__9_1_Internal_String_SharedGameDataPack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr, 100681330);
				GameDataProfile.__c.NativeMethodInfoPtr__GetAssets_b__12_0_Internal_Boolean_AssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr, 100681331);
				GameDataProfile.__c.NativeMethodInfoPtr__GetAssets_b__13_0_Internal_Boolean_MultiLanguageAssetReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr, 100681332);
			}

			// Token: 0x0600E80C RID: 59404 RVA: 0x00379240 File Offset: 0x00377440
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataProfile.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E80D RID: 59405 RVA: 0x0037927C File Offset: 0x0037747C
			[CallerCount(0)]
			public unsafe string _get_AllGameDataPacks_b__9_1(GameDataProfile.SharedGameDataPack x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c.NativeMethodInfoPtr__get_AllGameDataPacks_b__9_1_Internal_String_SharedGameDataPack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E80E RID: 59406 RVA: 0x003792CC File Offset: 0x003774CC
			[CallerCount(0)]
			public unsafe bool _GetAssets_b__12_0(AssetReference x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c.NativeMethodInfoPtr__GetAssets_b__12_0_Internal_Boolean_AssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E80F RID: 59407 RVA: 0x0037931C File Offset: 0x0037751C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219219, XrefRangeEnd = 219221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAssets_b__13_0(MultiLanguageTextMesh.MultiLanguageAssetReference x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c.NativeMethodInfoPtr__GetAssets_b__13_0_Internal_Boolean_MultiLanguageAssetReference_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E810 RID: 59408 RVA: 0x0007C030 File Offset: 0x0007A230
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B64 RID: 19300
			// (get) Token: 0x0600E811 RID: 59409 RVA: 0x0037936C File Offset: 0x0037756C
			// (set) Token: 0x0600E812 RID: 59410 RVA: 0x0007C039 File Offset: 0x0007A239
			public unsafe static GameDataProfile.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameDataProfile.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDataProfile.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameDataProfile.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B65 RID: 19301
			// (get) Token: 0x0600E813 RID: 59411 RVA: 0x00379394 File Offset: 0x00377594
			// (set) Token: 0x0600E814 RID: 59412 RVA: 0x0007C04B File Offset: 0x0007A24B
			public unsafe static Func<GameDataProfile.SharedGameDataPack, string> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameDataProfile.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameDataProfile.SharedGameDataPack, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameDataProfile.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B66 RID: 19302
			// (get) Token: 0x0600E815 RID: 59413 RVA: 0x003793BC File Offset: 0x003775BC
			// (set) Token: 0x0600E816 RID: 59414 RVA: 0x0007C05D File Offset: 0x0007A25D
			public unsafe static Func<AssetReference, bool> __9__12_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameDataProfile.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<AssetReference, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameDataProfile.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B67 RID: 19303
			// (get) Token: 0x0600E817 RID: 59415 RVA: 0x003793E4 File Offset: 0x003775E4
			// (set) Token: 0x0600E818 RID: 59416 RVA: 0x0007C06F File Offset: 0x0007A26F
			public unsafe static Func<MultiLanguageTextMesh.MultiLanguageAssetReference, bool> __9__13_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameDataProfile.__c.NativeFieldInfoPtr___9__13_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MultiLanguageTextMesh.MultiLanguageAssetReference, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameDataProfile.__c.NativeFieldInfoPtr___9__13_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400940E RID: 37902
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400940F RID: 37903
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04009410 RID: 37904
			private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

			// Token: 0x04009411 RID: 37905
			private static readonly IntPtr NativeFieldInfoPtr___9__13_0;

			// Token: 0x04009412 RID: 37906
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009413 RID: 37907
			private static readonly IntPtr NativeMethodInfoPtr__get_AllGameDataPacks_b__9_1_Internal_String_SharedGameDataPack_0;

			// Token: 0x04009414 RID: 37908
			private static readonly IntPtr NativeMethodInfoPtr__GetAssets_b__12_0_Internal_Boolean_AssetReference_0;

			// Token: 0x04009415 RID: 37909
			private static readonly IntPtr NativeMethodInfoPtr__GetAssets_b__13_0_Internal_Boolean_MultiLanguageAssetReference_0;
		}

		// Token: 0x02000CA2 RID: 3234
		[ObfuscatedName("GameData.Profile.GameDataProfile+<>c__10`1")]
		[Serializable]
		public sealed class __c__10<T> : Il2CppSystem.Object
		{
			// Token: 0x0600E819 RID: 59417 RVA: 0x0037940C File Offset: 0x0037760C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__10()
			{
				Il2CppClassPointerStore<GameDataProfile.__c__10<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "<>c__10`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataProfile.__c__10<T>>.NativeClassPtr);
				GameDataProfile.__c__10<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.__c__10<T>>.NativeClassPtr, "<>9");
				GameDataProfile.__c__10<T>.NativeFieldInfoPtr___9__10_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.__c__10<T>>.NativeClassPtr, "<>9__10_0");
				GameDataProfile.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c__10<T>>.NativeClassPtr, 100681334);
				GameDataProfile.__c__10<T>.NativeMethodInfoPtr__GetAssets_b__10_0_Internal_Boolean_Il2CppArrayBase_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c__10<T>>.NativeClassPtr, 100681335);
			}

			// Token: 0x0600E81A RID: 59418 RVA: 0x003794C4 File Offset: 0x003776C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__10() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataProfile.__c__10<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c__10<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E81B RID: 59419 RVA: 0x00379500 File Offset: 0x00377700
			[CallerCount(0)]
			public unsafe bool _GetAssets_b__10_0(Il2CppArrayBase<T> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c__10<T>.NativeMethodInfoPtr__GetAssets_b__10_0_Internal_Boolean_Il2CppArrayBase_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E81C RID: 59420 RVA: 0x0007C081 File Offset: 0x0007A281
			public __c__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B68 RID: 19304
			// (get) Token: 0x0600E81D RID: 59421 RVA: 0x00379550 File Offset: 0x00377750
			// (set) Token: 0x0600E81E RID: 59422 RVA: 0x0007C08A File Offset: 0x0007A28A
			public unsafe static GameDataProfile.__c__10<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameDataProfile.__c__10<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDataProfile.__c__10<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameDataProfile.__c__10<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B69 RID: 19305
			// (get) Token: 0x0600E81F RID: 59423 RVA: 0x00379578 File Offset: 0x00377778
			// (set) Token: 0x0600E820 RID: 59424 RVA: 0x0007C09C File Offset: 0x0007A29C
			public unsafe static Func<Il2CppArrayBase<T>, bool> __9__10_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameDataProfile.__c__10<T>.NativeFieldInfoPtr___9__10_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Il2CppArrayBase<T>, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameDataProfile.__c__10<T>.NativeFieldInfoPtr___9__10_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009416 RID: 37910
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04009417 RID: 37911
			private static readonly IntPtr NativeFieldInfoPtr___9__10_0;

			// Token: 0x04009418 RID: 37912
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009419 RID: 37913
			private static readonly IntPtr NativeMethodInfoPtr__GetAssets_b__10_0_Internal_Boolean_Il2CppArrayBase_1_T_0;
		}

		// Token: 0x02000CA3 RID: 3235
		[ObfuscatedName("GameData.Profile.GameDataProfile+<>c__11`1")]
		[Serializable]
		public sealed class __c__11<T> : Il2CppSystem.Object
		{
			// Token: 0x0600E821 RID: 59425 RVA: 0x003795A0 File Offset: 0x003777A0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__11()
			{
				Il2CppClassPointerStore<GameDataProfile.__c__11<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "<>c__11`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataProfile.__c__11<T>>.NativeClassPtr);
				GameDataProfile.__c__11<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.__c__11<T>>.NativeClassPtr, "<>9");
				GameDataProfile.__c__11<T>.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile.__c__11<T>>.NativeClassPtr, "<>9__11_0");
				GameDataProfile.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c__11<T>>.NativeClassPtr, 100681337);
				GameDataProfile.__c__11<T>.NativeMethodInfoPtr__GetAssets_b__11_0_Internal_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile.__c__11<T>>.NativeClassPtr, 100681338);
			}

			// Token: 0x0600E822 RID: 59426 RVA: 0x00379658 File Offset: 0x00377858
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__11() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataProfile.__c__11<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c__11<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E823 RID: 59427 RVA: 0x00379694 File Offset: 0x00377894
			[CallerCount(0)]
			public unsafe bool _GetAssets_b__11_0(T x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = x;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref x;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(GameDataProfile.__c__11<T>.NativeMethodInfoPtr__GetAssets_b__11_0_Internal_Boolean_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600E824 RID: 59428 RVA: 0x0007C0AE File Offset: 0x0007A2AE
			public __c__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B6A RID: 19306
			// (get) Token: 0x0600E825 RID: 59429 RVA: 0x00379718 File Offset: 0x00377918
			// (set) Token: 0x0600E826 RID: 59430 RVA: 0x0007C0B7 File Offset: 0x0007A2B7
			public unsafe static GameDataProfile.__c__11<T> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameDataProfile.__c__11<T>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDataProfile.__c__11<T>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameDataProfile.__c__11<T>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B6B RID: 19307
			// (get) Token: 0x0600E827 RID: 59431 RVA: 0x00379740 File Offset: 0x00377940
			// (set) Token: 0x0600E828 RID: 59432 RVA: 0x0007C0C9 File Offset: 0x0007A2C9
			public unsafe static Func<T, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameDataProfile.__c__11<T>.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameDataProfile.__c__11<T>.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400941A RID: 37914
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400941B RID: 37915
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x0400941C RID: 37916
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400941D RID: 37917
			private static readonly IntPtr NativeMethodInfoPtr__GetAssets_b__11_0_Internal_Boolean_T_0;
		}

		// Token: 0x02000CA4 RID: 3236
		[ObfuscatedName("GameData.Profile.GameDataProfile+<GetAssets>d__14`1")]
		public sealed class _GetAssets_d__14<T> : Il2CppSystem.Object
		{
			// Token: 0x0600E829 RID: 59433 RVA: 0x00379768 File Offset: 0x00377968
			// Note: this type is marked as 'beforefieldinit'.
			static _GetAssets_d__14()
			{
				Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr, "<GetAssets>d__14`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr);
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<>1__state");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<>2__current");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___l__initialThreadId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<>l__initialThreadId");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<>4__this");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr_getAssetCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "getAssetCallback");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___3__getAssetCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<>3__getAssetCallback");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr_valifyAssetCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "valifyAssetCallback");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___3__valifyAssetCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<>3__valifyAssetCallback");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr__handle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<handle>5__2");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<>7__wrap2");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr__dlcDataPair_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<dlcDataPair>5__4");
				GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___7__wrap4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, "<>7__wrap4");
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681339);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681340);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681341);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681342);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681343);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr___m__Finally3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681344);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681345);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681346);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681347);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681348);
				GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr, 100681349);
			}

			// Token: 0x0600E82A RID: 59434 RVA: 0x0037999C File Offset: 0x00377B9C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 78341, RefRangeEnd = 78342, XrefRangeStart = 78341, XrefRangeEnd = 78342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GetAssets_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDataProfile._GetAssets_d__14<T>>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E82B RID: 59435 RVA: 0x003799E4 File Offset: 0x00377BE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219221, XrefRangeEnd = 219227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E82C RID: 59436 RVA: 0x00379A18 File Offset: 0x00377C18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219227, XrefRangeEnd = 219275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E82D RID: 59437 RVA: 0x00379A54 File Offset: 0x00377C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219275, XrefRangeEnd = 219279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E82E RID: 59438 RVA: 0x00379A88 File Offset: 0x00377C88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219279, XrefRangeEnd = 219282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E82F RID: 59439 RVA: 0x00379ABC File Offset: 0x00377CBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219282, XrefRangeEnd = 219285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr___m__Finally3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B78 RID: 19320
			// (get) Token: 0x0600E830 RID: 59440 RVA: 0x00379AF0 File Offset: 0x00377CF0
			public unsafe KeyValuePair<string, T> prop_KeyValuePair_2_String_T_0
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr;
					IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
					Il2CppException.RaiseExceptionIfNecessary(intPtr);
					return new KeyValuePair<string, T>(pointer);
				}
			}

			// Token: 0x0600E831 RID: 59441 RVA: 0x00379B28 File Offset: 0x00377D28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219285, XrefRangeEnd = 219291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004B79 RID: 19321
			// (get) Token: 0x0600E832 RID: 59442 RVA: 0x00379B5C File Offset: 0x00377D5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219291, XrefRangeEnd = 219293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E833 RID: 59443 RVA: 0x00379B9C File Offset: 0x00377D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219293, XrefRangeEnd = 219300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator<KeyValuePair<string, T>> Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_T_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<KeyValuePair<string, T>>>(intPtr3) : null;
			}

			// Token: 0x0600E834 RID: 59444 RVA: 0x00379BDC File Offset: 0x00377DDC
			[CallerCount(0)]
			public unsafe IEnumerator System_Collections_IEnumerable_GetEnumerator()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDataProfile._GetAssets_d__14<T>.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E835 RID: 59445 RVA: 0x0007C0DB File Offset: 0x0007A2DB
			public _GetAssets_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004B6C RID: 19308
			// (get) Token: 0x0600E836 RID: 59446 RVA: 0x00379C1C File Offset: 0x00377E1C
			// (set) Token: 0x0600E837 RID: 59447 RVA: 0x0007C0E4 File Offset: 0x0007A2E4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004B6D RID: 19309
			// (get) Token: 0x0600E838 RID: 59448 RVA: 0x00379C44 File Offset: 0x00377E44
			// (set) Token: 0x0600E839 RID: 59449 RVA: 0x0007C0FF File Offset: 0x0007A2FF
			public KeyValuePair<string, T> __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___2__current);
					return new KeyValuePair<string, T>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, T>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___2__current), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, T>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004B6E RID: 19310
			// (get) Token: 0x0600E83A RID: 59450 RVA: 0x00379C74 File Offset: 0x00377E74
			// (set) Token: 0x0600E83B RID: 59451 RVA: 0x0007C12D File Offset: 0x0007A32D
			public unsafe int __l__initialThreadId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___l__initialThreadId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___l__initialThreadId)) = value;
				}
			}

			// Token: 0x17004B6F RID: 19311
			// (get) Token: 0x0600E83C RID: 59452 RVA: 0x00379C9C File Offset: 0x00377E9C
			// (set) Token: 0x0600E83D RID: 59453 RVA: 0x0007C148 File Offset: 0x0007A348
			public unsafe GameDataProfile __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameDataProfile>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B70 RID: 19312
			// (get) Token: 0x0600E83E RID: 59454 RVA: 0x00379CCC File Offset: 0x00377ECC
			// (set) Token: 0x0600E83F RID: 59455 RVA: 0x0007C167 File Offset: 0x0007A367
			public unsafe Func<ExpandableGameDataPack, T> getAssetCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr_getAssetCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ExpandableGameDataPack, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr_getAssetCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B71 RID: 19313
			// (get) Token: 0x0600E840 RID: 59456 RVA: 0x00379CFC File Offset: 0x00377EFC
			// (set) Token: 0x0600E841 RID: 59457 RVA: 0x0007C186 File Offset: 0x0007A386
			public unsafe Func<ExpandableGameDataPack, T> __3__getAssetCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___3__getAssetCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ExpandableGameDataPack, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___3__getAssetCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B72 RID: 19314
			// (get) Token: 0x0600E842 RID: 59458 RVA: 0x00379D2C File Offset: 0x00377F2C
			// (set) Token: 0x0600E843 RID: 59459 RVA: 0x0007C1A5 File Offset: 0x0007A3A5
			public unsafe Func<T, bool> valifyAssetCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr_valifyAssetCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr_valifyAssetCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B73 RID: 19315
			// (get) Token: 0x0600E844 RID: 59460 RVA: 0x00379D5C File Offset: 0x00377F5C
			// (set) Token: 0x0600E845 RID: 59461 RVA: 0x0007C1C4 File Offset: 0x0007A3C4
			public unsafe Func<T, bool> __3__valifyAssetCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___3__valifyAssetCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<T, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___3__valifyAssetCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004B74 RID: 19316
			// (get) Token: 0x0600E846 RID: 59462 RVA: 0x00379D8C File Offset: 0x00377F8C
			// (set) Token: 0x0600E847 RID: 59463 RVA: 0x0007C1E3 File Offset: 0x0007A3E3
			public unsafe ProfilerMarker.AutoScope _handle_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr__handle_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr__handle_5__2)) = value;
				}
			}

			// Token: 0x17004B75 RID: 19317
			// (get) Token: 0x0600E848 RID: 59464 RVA: 0x00379DB4 File Offset: 0x00377FB4
			// (set) Token: 0x0600E849 RID: 59465 RVA: 0x0007C1FE File Offset: 0x0007A3FE
			public Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___7__wrap2);
					return new Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<string, List<ValueTuple<ExpandableGameDataPack, bool>>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004B76 RID: 19318
			// (get) Token: 0x0600E84A RID: 59466 RVA: 0x00379DE4 File Offset: 0x00377FE4
			// (set) Token: 0x0600E84B RID: 59467 RVA: 0x0007C22C File Offset: 0x0007A42C
			public KeyValuePair<string, List<ValueTuple<ExpandableGameDataPack, bool>>> _dlcDataPair_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr__dlcDataPair_5__4);
					return new KeyValuePair<string, List<ValueTuple<ExpandableGameDataPack, bool>>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<string, List<ValueTuple<ExpandableGameDataPack, bool>>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr__dlcDataPair_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<string, List<ValueTuple<ExpandableGameDataPack, bool>>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004B77 RID: 19319
			// (get) Token: 0x0600E84C RID: 59468 RVA: 0x00379E14 File Offset: 0x00378014
			// (set) Token: 0x0600E84D RID: 59469 RVA: 0x0007C25A File Offset: 0x0007A45A
			public List<ValueTuple<ExpandableGameDataPack, bool>>.Enumerator __7__wrap4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___7__wrap4);
					return new List<ValueTuple<ExpandableGameDataPack, bool>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<ValueTuple<ExpandableGameDataPack, bool>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDataProfile._GetAssets_d__14<T>.NativeFieldInfoPtr___7__wrap4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<ValueTuple<ExpandableGameDataPack, bool>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400941E RID: 37918
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400941F RID: 37919
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009420 RID: 37920
			private static readonly IntPtr NativeFieldInfoPtr___l__initialThreadId;

			// Token: 0x04009421 RID: 37921
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009422 RID: 37922
			private static readonly IntPtr NativeFieldInfoPtr_getAssetCallback;

			// Token: 0x04009423 RID: 37923
			private static readonly IntPtr NativeFieldInfoPtr___3__getAssetCallback;

			// Token: 0x04009424 RID: 37924
			private static readonly IntPtr NativeFieldInfoPtr_valifyAssetCallback;

			// Token: 0x04009425 RID: 37925
			private static readonly IntPtr NativeFieldInfoPtr___3__valifyAssetCallback;

			// Token: 0x04009426 RID: 37926
			private static readonly IntPtr NativeFieldInfoPtr__handle_5__2;

			// Token: 0x04009427 RID: 37927
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04009428 RID: 37928
			private static readonly IntPtr NativeFieldInfoPtr__dlcDataPair_5__4;

			// Token: 0x04009429 RID: 37929
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap4;

			// Token: 0x0400942A RID: 37930
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400942B RID: 37931
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400942C RID: 37932
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400942D RID: 37933
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x0400942E RID: 37934
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x0400942F RID: 37935
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally3_Private_Void_0;

			// Token: 0x04009430 RID: 37936
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_get_KeyValuePair_2_String_T_0;

			// Token: 0x04009431 RID: 37937
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009432 RID: 37938
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04009433 RID: 37939
			private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Virtual_Final_New_IEnumerator_1_KeyValuePair_2_String_T_0;

			// Token: 0x04009434 RID: 37940
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;
		}

		// Token: 0x02000CA5 RID: 3237
		private sealed class MethodInfoStoreGeneric_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_Il2CppArrayBase_1_T_Func_2_ExpandableGameDataPack_Il2CppArrayBase_1_T_0<T>
		{
			// Token: 0x04009435 RID: 37941
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameDataProfile.NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_Il2CppArrayBase_1_T_Func_2_ExpandableGameDataPack_Il2CppArrayBase_1_T_0, Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000CA6 RID: 3238
		private sealed class MethodInfoStoreGeneric_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_0<T>
		{
			// Token: 0x04009436 RID: 37942
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameDataProfile.NativeMethodInfoPtr_GetAssets_Public_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_0, Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000CA7 RID: 3239
		private sealed class MethodInfoStoreGeneric_GetAssets_Private_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_Func_2_T_Boolean_0<T>
		{
			// Token: 0x04009437 RID: 37943
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(GameDataProfile.NativeMethodInfoPtr_GetAssets_Private_IEnumerable_1_KeyValuePair_2_String_T_Func_2_ExpandableGameDataPack_T_Func_2_T_Boolean_0, Il2CppClassPointerStore<GameDataProfile>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
