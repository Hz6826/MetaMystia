using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.Interactables;
using DayScene.Interactables.Collections.BehaviourComponents;
using DEYU.AssetHandleUtility;
using GameData.Core.Collections.NightSceneUtility;
using GameData.Profile;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;

namespace DayScene
{
	// Token: 0x020000B5 RID: 181
	public class PartyStageMap : DaySceneMap
	{
		// Token: 0x06001378 RID: 4984 RVA: 0x000DFE14 File Offset: 0x000DE014
		// Note: this type is marked as 'beforefieldinit'.
		static PartyStageMap()
		{
			Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene", "PartyStageMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr);
			PartyStageMap.NativeFieldInfoPtr_KYOUKO_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "KYOUKO_KEY");
			PartyStageMap.NativeFieldInfoPtr_level5CharacterData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "level5CharacterData");
			PartyStageMap.NativeFieldInfoPtr_level5CharacterDataDLC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "level5CharacterDataDLC");
			PartyStageMap.NativeFieldInfoPtr_m_Vfxs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "m_Vfxs");
			PartyStageMap.NativeFieldInfoPtr_m_CharacterStageDataDispose = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "m_CharacterStageDataDispose");
			PartyStageMap.NativeMethodInfoPtr_GenerateSpawnMarkerData_Protected_Virtual_Dictionary_2_String_SpawnMarker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, 100666660);
			PartyStageMap.NativeMethodInfoPtr_OnPostLeaveScene_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, 100666661);
			PartyStageMap.NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, 100666662);
			PartyStageMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, 100666663);
			PartyStageMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, 100666664);
		}

		// Token: 0x06001379 RID: 4985 RVA: 0x000DFF0C File Offset: 0x000DE10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53738, XrefRangeEnd = 53771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Dictionary<string, SpawnMarker> GenerateSpawnMarkerData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartyStageMap.NativeMethodInfoPtr_GenerateSpawnMarkerData_Protected_Virtual_Dictionary_2_String_SpawnMarker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<string, SpawnMarker>>(intPtr3) : null;
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x000DFF58 File Offset: 0x000DE158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53771, XrefRangeEnd = 53791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPostLeaveScene()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartyStageMap.NativeMethodInfoPtr_OnPostLeaveScene_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x000DFF94 File Offset: 0x000DE194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53791, XrefRangeEnd = 53797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override UniTask OnPostEnterSceneAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartyStageMap.NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_UniTask_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x000DFFD8 File Offset: 0x000DE1D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53797, XrefRangeEnd = 53813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PartyStageMap.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x000E0014 File Offset: 0x000DE214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53813, XrefRangeEnd = 53825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PartyStageMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0000C446 File Offset: 0x0000A646
		public PartyStageMap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700061F RID: 1567
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x000E0050 File Offset: 0x000DE250
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x0000C44F File Offset: 0x0000A64F
		public unsafe static string KYOUKO_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PartyStageMap.NativeFieldInfoPtr_KYOUKO_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PartyStageMap.NativeFieldInfoPtr_KYOUKO_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000620 RID: 1568
		// (get) Token: 0x06001381 RID: 4993 RVA: 0x000E0070 File Offset: 0x000DE270
		// (set) Token: 0x06001382 RID: 4994 RVA: 0x0000C461 File Offset: 0x0000A661
		public unsafe Il2CppReferenceArray<PartyStageMap.CharacterStageData> level5CharacterData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.NativeFieldInfoPtr_level5CharacterData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PartyStageMap.CharacterStageData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.NativeFieldInfoPtr_level5CharacterData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000621 RID: 1569
		// (get) Token: 0x06001383 RID: 4995 RVA: 0x000E00A0 File Offset: 0x000DE2A0
		// (set) Token: 0x06001384 RID: 4996 RVA: 0x0000C480 File Offset: 0x0000A680
		public unsafe Il2CppReferenceArray<PartyStageMap.CharacterStageData> level5CharacterDataDLC
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.NativeFieldInfoPtr_level5CharacterDataDLC);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PartyStageMap.CharacterStageData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.NativeFieldInfoPtr_level5CharacterDataDLC), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000622 RID: 1570
		// (get) Token: 0x06001385 RID: 4997 RVA: 0x000E00D0 File Offset: 0x000DE2D0
		// (set) Token: 0x06001386 RID: 4998 RVA: 0x0000C49F File Offset: 0x0000A69F
		public unsafe List<GameObject> m_Vfxs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.NativeFieldInfoPtr_m_Vfxs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.NativeFieldInfoPtr_m_Vfxs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000623 RID: 1571
		// (get) Token: 0x06001387 RID: 4999 RVA: 0x000E0100 File Offset: 0x000DE300
		// (set) Token: 0x06001388 RID: 5000 RVA: 0x0000C4BE File Offset: 0x0000A6BE
		public unsafe Action m_CharacterStageDataDispose
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.NativeFieldInfoPtr_m_CharacterStageDataDispose);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.NativeFieldInfoPtr_m_CharacterStageDataDispose), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D2A RID: 3370
		private static readonly IntPtr NativeFieldInfoPtr_KYOUKO_KEY;

		// Token: 0x04000D2B RID: 3371
		private static readonly IntPtr NativeFieldInfoPtr_level5CharacterData;

		// Token: 0x04000D2C RID: 3372
		private static readonly IntPtr NativeFieldInfoPtr_level5CharacterDataDLC;

		// Token: 0x04000D2D RID: 3373
		private static readonly IntPtr NativeFieldInfoPtr_m_Vfxs;

		// Token: 0x04000D2E RID: 3374
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterStageDataDispose;

		// Token: 0x04000D2F RID: 3375
		private static readonly IntPtr NativeMethodInfoPtr_GenerateSpawnMarkerData_Protected_Virtual_Dictionary_2_String_SpawnMarker_0;

		// Token: 0x04000D30 RID: 3376
		private static readonly IntPtr NativeMethodInfoPtr_OnPostLeaveScene_Public_Virtual_Void_0;

		// Token: 0x04000D31 RID: 3377
		private static readonly IntPtr NativeMethodInfoPtr_OnPostEnterSceneAsync_Public_Virtual_UniTask_0;

		// Token: 0x04000D32 RID: 3378
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04000D33 RID: 3379
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020005CE RID: 1486
		[Serializable]
		public sealed class CharacterStageData : ValueType
		{
			// Token: 0x06008D45 RID: 36165 RVA: 0x0026BBAC File Offset: 0x00269DAC
			// Note: this type is marked as 'beforefieldinit'.
			static CharacterStageData()
			{
				Il2CppClassPointerStore<PartyStageMap.CharacterStageData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "CharacterStageData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyStageMap.CharacterStageData>.NativeClassPtr);
				PartyStageMap.CharacterStageData.NativeFieldInfoPtr_characterSpawnMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.CharacterStageData>.NativeClassPtr, "characterSpawnMarker");
				PartyStageMap.CharacterStageData.NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.CharacterStageData>.NativeClassPtr, "eventType");
				PartyStageMap.CharacterStageData.NativeFieldInfoPtr_chatDialogReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.CharacterStageData>.NativeClassPtr, "chatDialogReference");
				PartyStageMap.CharacterStageData.NativeFieldInfoPtr_chatTimelineReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.CharacterStageData>.NativeClassPtr, "chatTimelineReference");
				PartyStageMap.CharacterStageData.NativeFieldInfoPtr_ExtraEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.CharacterStageData>.NativeClassPtr, "ExtraEffect");
				PartyStageMap.CharacterStageData.NativeMethodInfoPtr_LoadAssetsAsync_Public_UniTask_1_ValueTuple_2_IAssetHandle_1_DialogPackage_IAssetHandle_1_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.CharacterStageData>.NativeClassPtr, 100666665);
			}

			// Token: 0x06008D46 RID: 36166 RVA: 0x0026BC50 File Offset: 0x00269E50
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 53343, RefRangeEnd = 53344, XrefRangeStart = 53323, XrefRangeEnd = 53343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>> LoadAssetsAsync()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.CharacterStageData.NativeMethodInfoPtr_LoadAssetsAsync_Public_UniTask_1_ValueTuple_2_IAssetHandle_1_DialogPackage_IAssetHandle_1_PlayableAsset_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>(pointer);
			}

			// Token: 0x06008D47 RID: 36167 RVA: 0x0004BF56 File Offset: 0x0004A156
			public CharacterStageData(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008D48 RID: 36168 RVA: 0x0004BF5F File Offset: 0x0004A15F
			public CharacterStageData() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartyStageMap.CharacterStageData>.NativeClassPtr))
			{
			}

			// Token: 0x17002F3B RID: 12091
			// (get) Token: 0x06008D49 RID: 36169 RVA: 0x0026BC8C File Offset: 0x00269E8C
			// (set) Token: 0x06008D4A RID: 36170 RVA: 0x0004BF71 File Offset: 0x0004A171
			public unsafe SpawnMarker characterSpawnMarker
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_characterSpawnMarker);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpawnMarker>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_characterSpawnMarker), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F3C RID: 12092
			// (get) Token: 0x06008D4B RID: 36171 RVA: 0x0026BCBC File Offset: 0x00269EBC
			// (set) Token: 0x06008D4C RID: 36172 RVA: 0x0004BF90 File Offset: 0x0004A190
			public unsafe CharacterStageBehaviourComponent.EventType eventType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_eventType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_eventType)) = value;
				}
			}

			// Token: 0x17002F3D RID: 12093
			// (get) Token: 0x06008D4D RID: 36173 RVA: 0x0026BCE4 File Offset: 0x00269EE4
			// (set) Token: 0x06008D4E RID: 36174 RVA: 0x0004BFAB File Offset: 0x0004A1AB
			public unsafe AssetReference chatDialogReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_chatDialogReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_chatDialogReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F3E RID: 12094
			// (get) Token: 0x06008D4F RID: 36175 RVA: 0x0026BD14 File Offset: 0x00269F14
			// (set) Token: 0x06008D50 RID: 36176 RVA: 0x0004BFCA File Offset: 0x0004A1CA
			public unsafe AssetReference chatTimelineReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_chatTimelineReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_chatTimelineReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F3F RID: 12095
			// (get) Token: 0x06008D51 RID: 36177 RVA: 0x0026BD44 File Offset: 0x00269F44
			// (set) Token: 0x06008D52 RID: 36178 RVA: 0x0004BFE9 File Offset: 0x0004A1E9
			public unsafe GameObject ExtraEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_ExtraEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.CharacterStageData.NativeFieldInfoPtr_ExtraEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C55 RID: 23637
			private static readonly IntPtr NativeFieldInfoPtr_characterSpawnMarker;

			// Token: 0x04005C56 RID: 23638
			private static readonly IntPtr NativeFieldInfoPtr_eventType;

			// Token: 0x04005C57 RID: 23639
			private static readonly IntPtr NativeFieldInfoPtr_chatDialogReference;

			// Token: 0x04005C58 RID: 23640
			private static readonly IntPtr NativeFieldInfoPtr_chatTimelineReference;

			// Token: 0x04005C59 RID: 23641
			private static readonly IntPtr NativeFieldInfoPtr_ExtraEffect;

			// Token: 0x04005C5A RID: 23642
			private static readonly IntPtr NativeMethodInfoPtr_LoadAssetsAsync_Public_UniTask_1_ValueTuple_2_IAssetHandle_1_DialogPackage_IAssetHandle_1_PlayableAsset_0;
		}

		// Token: 0x020005CF RID: 1487
		[ObfuscatedName("DayScene.PartyStageMap+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Il2CppSystem.Object
		{
			// Token: 0x06008D53 RID: 36179 RVA: 0x0026BD74 File Offset: 0x00269F74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_0>.NativeClassPtr);
				PartyStageMap.__c__DisplayClass7_0.NativeFieldInfoPtr_allLevel5Guests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_0>.NativeClassPtr, "allLevel5Guests");
				PartyStageMap.__c__DisplayClass7_0.NativeFieldInfoPtr_allGuestsOldData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_0>.NativeClassPtr, "allGuestsOldData");
				PartyStageMap.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_0>.NativeClassPtr, 100666666);
				PartyStageMap.__c__DisplayClass7_0.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__4_Internal_Boolean_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_0>.NativeClassPtr, 100666667);
				PartyStageMap.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_0>.NativeClassPtr, 100666668);
			}

			// Token: 0x06008D54 RID: 36180 RVA: 0x0026BE04 File Offset: 0x0026A004
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D55 RID: 36181 RVA: 0x0026BE40 File Offset: 0x0026A040
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53344, XrefRangeEnd = 53359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPostEnterSceneAsync_b__4(MappedSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c__DisplayClass7_0.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__4_Internal_Boolean_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008D56 RID: 36182 RVA: 0x0026BE90 File Offset: 0x0026A090
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53359, XrefRangeEnd = 53379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c__DisplayClass7_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D57 RID: 36183 RVA: 0x0004C008 File Offset: 0x0004A208
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F40 RID: 12096
			// (get) Token: 0x06008D58 RID: 36184 RVA: 0x0026BEC4 File Offset: 0x0026A0C4
			// (set) Token: 0x06008D59 RID: 36185 RVA: 0x0004C011 File Offset: 0x0004A211
			public unsafe IEnumerable<SpecialGuest> allLevel5Guests
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.__c__DisplayClass7_0.NativeFieldInfoPtr_allLevel5Guests);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerable<SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.__c__DisplayClass7_0.NativeFieldInfoPtr_allLevel5Guests), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F41 RID: 12097
			// (get) Token: 0x06008D5A RID: 36186 RVA: 0x0026BEF4 File Offset: 0x0026A0F4
			// (set) Token: 0x06008D5B RID: 36187 RVA: 0x0004C030 File Offset: 0x0004A230
			public unsafe Dictionary<string, TrackedNPC.OverridePosition> allGuestsOldData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.__c__DisplayClass7_0.NativeFieldInfoPtr_allGuestsOldData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, TrackedNPC.OverridePosition>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.__c__DisplayClass7_0.NativeFieldInfoPtr_allGuestsOldData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C5B RID: 23643
			private static readonly IntPtr NativeFieldInfoPtr_allLevel5Guests;

			// Token: 0x04005C5C RID: 23644
			private static readonly IntPtr NativeFieldInfoPtr_allGuestsOldData;

			// Token: 0x04005C5D RID: 23645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C5E RID: 23646
			private static readonly IntPtr NativeMethodInfoPtr__OnPostEnterSceneAsync_b__4_Internal_Boolean_MappedSpecialGuest_0;

			// Token: 0x04005C5F RID: 23647
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x020005D0 RID: 1488
		[ObfuscatedName("DayScene.PartyStageMap+<>c__DisplayClass7_1")]
		public sealed class __c__DisplayClass7_1 : Il2CppSystem.Object
		{
			// Token: 0x06008D5C RID: 36188 RVA: 0x0026BF24 File Offset: 0x0026A124
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_1()
			{
				Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "<>c__DisplayClass7_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_1>.NativeClassPtr);
				PartyStageMap.__c__DisplayClass7_1.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_1>.NativeClassPtr, "x");
				PartyStageMap.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_1>.NativeClassPtr, 100666669);
				PartyStageMap.__c__DisplayClass7_1.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__9_Internal_Boolean_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_1>.NativeClassPtr, 100666670);
			}

			// Token: 0x06008D5D RID: 36189 RVA: 0x0026BF8C File Offset: 0x0026A18C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartyStageMap.__c__DisplayClass7_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D5E RID: 36190 RVA: 0x0026BFC8 File Offset: 0x0026A1C8
			[CallerCount(0)]
			public unsafe bool _OnPostEnterSceneAsync_b__9(SpecialGuest y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c__DisplayClass7_1.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__9_Internal_Boolean_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008D5F RID: 36191 RVA: 0x0004C04F File Offset: 0x0004A24F
			public __c__DisplayClass7_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F42 RID: 12098
			// (get) Token: 0x06008D60 RID: 36192 RVA: 0x0026C018 File Offset: 0x0026A218
			// (set) Token: 0x06008D61 RID: 36193 RVA: 0x0004C058 File Offset: 0x0004A258
			public unsafe MappedSpecialGuest x
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.__c__DisplayClass7_1.NativeFieldInfoPtr_x);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MappedSpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap.__c__DisplayClass7_1.NativeFieldInfoPtr_x), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C60 RID: 23648
			private static readonly IntPtr NativeFieldInfoPtr_x;

			// Token: 0x04005C61 RID: 23649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C62 RID: 23650
			private static readonly IntPtr NativeMethodInfoPtr__OnPostEnterSceneAsync_b__9_Internal_Boolean_SpecialGuest_0;
		}

		// Token: 0x020005D1 RID: 1489
		[ObfuscatedName("DayScene.PartyStageMap+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06008D62 RID: 36194 RVA: 0x0026C048 File Offset: 0x0026A248
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr);
				PartyStageMap.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, "<>9");
				PartyStageMap.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, "<>9__7_0");
				PartyStageMap.__c.NativeFieldInfoPtr___9__7_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, "<>9__7_1");
				PartyStageMap.__c.NativeFieldInfoPtr___9__7_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, "<>9__7_2");
				PartyStageMap.__c.NativeFieldInfoPtr___9__7_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, "<>9__7_3");
				PartyStageMap.__c.NativeFieldInfoPtr___9__7_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, "<>9__7_5");
				PartyStageMap.__c.NativeFieldInfoPtr___9__7_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, "<>9__7_6");
				PartyStageMap.__c.NativeFieldInfoPtr___9__7_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, "<>9__7_8");
				PartyStageMap.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, 100666672);
				PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_0_Internal_Boolean_CharacterStageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, 100666673);
				PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_1_Internal_String_CharacterStageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, 100666674);
				PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_2_Internal_SpecialGuest_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, 100666675);
				PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_3_Internal_String_CharacterStageData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, 100666676);
				PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_5_Internal_String_MappedSpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, 100666677);
				PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_6_Internal_String_SpecialGuest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, 100666678);
				PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr, 100666679);
			}

			// Token: 0x06008D63 RID: 36195 RVA: 0x0026C1B4 File Offset: 0x0026A3B4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartyStageMap.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D64 RID: 36196 RVA: 0x0026C1F0 File Offset: 0x0026A3F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53379, XrefRangeEnd = 53382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnPostEnterSceneAsync_b__7_0(PartyStageMap.CharacterStageData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_0_Internal_Boolean_CharacterStageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06008D65 RID: 36197 RVA: 0x0026C244 File Offset: 0x0026A444
			[CallerCount(0)]
			public unsafe string _OnPostEnterSceneAsync_b__7_1(PartyStageMap.CharacterStageData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_1_Internal_String_CharacterStageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008D66 RID: 36198 RVA: 0x0026C294 File Offset: 0x0026A494
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53382, XrefRangeEnd = 53386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SpecialGuest _OnPostEnterSceneAsync_b__7_2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_2_Internal_SpecialGuest_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpecialGuest>(intPtr3) : null;
			}

			// Token: 0x06008D67 RID: 36199 RVA: 0x0026C2E0 File Offset: 0x0026A4E0
			[CallerCount(0)]
			public unsafe string _OnPostEnterSceneAsync_b__7_3(PartyStageMap.CharacterStageData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_3_Internal_String_CharacterStageData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008D68 RID: 36200 RVA: 0x0026C330 File Offset: 0x0026A530
			[CallerCount(0)]
			public unsafe string _OnPostEnterSceneAsync_b__7_5(MappedSpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_5_Internal_String_MappedSpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008D69 RID: 36201 RVA: 0x0026C378 File Offset: 0x0026A578
			[CallerCount(0)]
			public unsafe string _OnPostEnterSceneAsync_b__7_6(SpecialGuest x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_6_Internal_String_SpecialGuest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x06008D6A RID: 36202 RVA: 0x0026C3C0 File Offset: 0x0026A5C0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 53386, XrefRangeEnd = 53391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPostEnterSceneAsync_b__7_8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap.__c.NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D6B RID: 36203 RVA: 0x0004C077 File Offset: 0x0004A277
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002F43 RID: 12099
			// (get) Token: 0x06008D6C RID: 36204 RVA: 0x0026C3F4 File Offset: 0x0026A5F4
			// (set) Token: 0x06008D6D RID: 36205 RVA: 0x0004C080 File Offset: 0x0004A280
			public unsafe static PartyStageMap.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartyStageMap.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartyStageMap.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartyStageMap.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F44 RID: 12100
			// (get) Token: 0x06008D6E RID: 36206 RVA: 0x0026C41C File Offset: 0x0026A61C
			// (set) Token: 0x06008D6F RID: 36207 RVA: 0x0004C092 File Offset: 0x0004A292
			public unsafe static Func<PartyStageMap.CharacterStageData, bool> __9__7_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartyStageMap.CharacterStageData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F45 RID: 12101
			// (get) Token: 0x06008D70 RID: 36208 RVA: 0x0026C444 File Offset: 0x0026A644
			// (set) Token: 0x06008D71 RID: 36209 RVA: 0x0004C0A4 File Offset: 0x0004A2A4
			public unsafe static Func<PartyStageMap.CharacterStageData, string> __9__7_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartyStageMap.CharacterStageData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F46 RID: 12102
			// (get) Token: 0x06008D72 RID: 36210 RVA: 0x0026C46C File Offset: 0x0026A66C
			// (set) Token: 0x06008D73 RID: 36211 RVA: 0x0004C0B6 File Offset: 0x0004A2B6
			public unsafe static Func<int, SpecialGuest> __9__7_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, SpecialGuest>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F47 RID: 12103
			// (get) Token: 0x06008D74 RID: 36212 RVA: 0x0026C494 File Offset: 0x0026A694
			// (set) Token: 0x06008D75 RID: 36213 RVA: 0x0004C0C8 File Offset: 0x0004A2C8
			public unsafe static Func<PartyStageMap.CharacterStageData, string> __9__7_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<PartyStageMap.CharacterStageData, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F48 RID: 12104
			// (get) Token: 0x06008D76 RID: 36214 RVA: 0x0026C4BC File Offset: 0x0026A6BC
			// (set) Token: 0x06008D77 RID: 36215 RVA: 0x0004C0DA File Offset: 0x0004A2DA
			public unsafe static Func<MappedSpecialGuest, string> __9__7_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MappedSpecialGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F49 RID: 12105
			// (get) Token: 0x06008D78 RID: 36216 RVA: 0x0026C4E4 File Offset: 0x0026A6E4
			// (set) Token: 0x06008D79 RID: 36217 RVA: 0x0004C0EC File Offset: 0x0004A2EC
			public unsafe static Func<SpecialGuest, string> __9__7_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SpecialGuest, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F4A RID: 12106
			// (get) Token: 0x06008D7A RID: 36218 RVA: 0x0026C50C File Offset: 0x0026A70C
			// (set) Token: 0x06008D7B RID: 36219 RVA: 0x0004C0FE File Offset: 0x0004A2FE
			public unsafe static Action __9__7_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PartyStageMap.__c.NativeFieldInfoPtr___9__7_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005C63 RID: 23651
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005C64 RID: 23652
			private static readonly IntPtr NativeFieldInfoPtr___9__7_0;

			// Token: 0x04005C65 RID: 23653
			private static readonly IntPtr NativeFieldInfoPtr___9__7_1;

			// Token: 0x04005C66 RID: 23654
			private static readonly IntPtr NativeFieldInfoPtr___9__7_2;

			// Token: 0x04005C67 RID: 23655
			private static readonly IntPtr NativeFieldInfoPtr___9__7_3;

			// Token: 0x04005C68 RID: 23656
			private static readonly IntPtr NativeFieldInfoPtr___9__7_5;

			// Token: 0x04005C69 RID: 23657
			private static readonly IntPtr NativeFieldInfoPtr___9__7_6;

			// Token: 0x04005C6A RID: 23658
			private static readonly IntPtr NativeFieldInfoPtr___9__7_8;

			// Token: 0x04005C6B RID: 23659
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005C6C RID: 23660
			private static readonly IntPtr NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_0_Internal_Boolean_CharacterStageData_0;

			// Token: 0x04005C6D RID: 23661
			private static readonly IntPtr NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_1_Internal_String_CharacterStageData_0;

			// Token: 0x04005C6E RID: 23662
			private static readonly IntPtr NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_2_Internal_SpecialGuest_Int32_0;

			// Token: 0x04005C6F RID: 23663
			private static readonly IntPtr NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_3_Internal_String_CharacterStageData_0;

			// Token: 0x04005C70 RID: 23664
			private static readonly IntPtr NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_5_Internal_String_MappedSpecialGuest_0;

			// Token: 0x04005C71 RID: 23665
			private static readonly IntPtr NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_6_Internal_String_SpecialGuest_0;

			// Token: 0x04005C72 RID: 23666
			private static readonly IntPtr NativeMethodInfoPtr__OnPostEnterSceneAsync_b__7_8_Internal_Void_0;
		}

		// Token: 0x020005D2 RID: 1490
		[ObfuscatedName("DayScene.PartyStageMap+<OnPostEnterSceneAsync>d__7")]
		public sealed class _OnPostEnterSceneAsync_d__7 : ValueType
		{
			// Token: 0x06008D7C RID: 36220 RVA: 0x0026C534 File Offset: 0x0026A734
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPostEnterSceneAsync_d__7()
			{
				Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PartyStageMap>.NativeClassPtr, "<OnPostEnterSceneAsync>d__7");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr);
				PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr, "<>1__state");
				PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr, "<>t__builder");
				PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr, "<>4__this");
				PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr__handle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr, "<handle>5__2");
				PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr, "<>7__wrap2");
				PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr__data_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr, "<data>5__4");
				PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr, "<>u__1");
				PartyStageMap._OnPostEnterSceneAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr, 100666680);
				PartyStageMap._OnPostEnterSceneAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr, 100666681);
			}

			// Token: 0x06008D7D RID: 36221 RVA: 0x0026C614 File Offset: 0x0026A814
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 53736, RefRangeEnd = 53738, XrefRangeStart = 53391, XrefRangeEnd = 53736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D7E RID: 36222 RVA: 0x0026C64C File Offset: 0x0026A84C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06008D7F RID: 36223 RVA: 0x0004C110 File Offset: 0x0004A310
			public _OnPostEnterSceneAsync_d__7(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06008D80 RID: 36224 RVA: 0x0004C119 File Offset: 0x0004A319
			public _OnPostEnterSceneAsync_d__7() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PartyStageMap._OnPostEnterSceneAsync_d__7>.NativeClassPtr))
			{
			}

			// Token: 0x17002F4B RID: 12107
			// (get) Token: 0x06008D81 RID: 36225 RVA: 0x0026C694 File Offset: 0x0026A894
			// (set) Token: 0x06008D82 RID: 36226 RVA: 0x0004C12B File Offset: 0x0004A32B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002F4C RID: 12108
			// (get) Token: 0x06008D83 RID: 36227 RVA: 0x0026C6BC File Offset: 0x0026A8BC
			// (set) Token: 0x06008D84 RID: 36228 RVA: 0x0004C146 File Offset: 0x0004A346
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F4D RID: 12109
			// (get) Token: 0x06008D85 RID: 36229 RVA: 0x0026C6EC File Offset: 0x0026A8EC
			// (set) Token: 0x06008D86 RID: 36230 RVA: 0x0004C174 File Offset: 0x0004A374
			public unsafe PartyStageMap __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PartyStageMap>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F4E RID: 12110
			// (get) Token: 0x06008D87 RID: 36231 RVA: 0x0026C71C File Offset: 0x0026A91C
			// (set) Token: 0x06008D88 RID: 36232 RVA: 0x0004C193 File Offset: 0x0004A393
			public unsafe IDisposable _handle_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr__handle_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr__handle_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002F4F RID: 12111
			// (get) Token: 0x06008D89 RID: 36233 RVA: 0x0026C74C File Offset: 0x0026A94C
			// (set) Token: 0x06008D8A RID: 36234 RVA: 0x0004C1B2 File Offset: 0x0004A3B2
			public Dictionary<CharacterStageBehaviourComponent, UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>>.Enumerator __7__wrap2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___7__wrap2);
					return new Dictionary<CharacterStageBehaviourComponent, UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Dictionary<CharacterStageBehaviourComponent, UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Dictionary<CharacterStageBehaviourComponent, UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F50 RID: 12112
			// (get) Token: 0x06008D8B RID: 36235 RVA: 0x0026C77C File Offset: 0x0026A97C
			// (set) Token: 0x06008D8C RID: 36236 RVA: 0x0004C1E0 File Offset: 0x0004A3E0
			public KeyValuePair<CharacterStageBehaviourComponent, UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>> _data_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr__data_5__4);
					return new KeyValuePair<CharacterStageBehaviourComponent, UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyValuePair<CharacterStageBehaviourComponent, UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>>>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr__data_5__4), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<KeyValuePair<CharacterStageBehaviourComponent, UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>>>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17002F51 RID: 12113
			// (get) Token: 0x06008D8D RID: 36237 RVA: 0x0026C7AC File Offset: 0x0026A9AC
			// (set) Token: 0x06008D8E RID: 36238 RVA: 0x0004C20E File Offset: 0x0004A40E
			public UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___u__1);
					return new UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PartyStageMap._OnPostEnterSceneAsync_d__7.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<ValueTuple<IAssetHandle<DialogPackage>, IAssetHandle<PlayableAsset>>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04005C73 RID: 23667
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005C74 RID: 23668
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04005C75 RID: 23669
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005C76 RID: 23670
			private static readonly IntPtr NativeFieldInfoPtr__handle_5__2;

			// Token: 0x04005C77 RID: 23671
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap2;

			// Token: 0x04005C78 RID: 23672
			private static readonly IntPtr NativeFieldInfoPtr__data_5__4;

			// Token: 0x04005C79 RID: 23673
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04005C7A RID: 23674
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005C7B RID: 23675
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
