using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Profile
{
	// Token: 0x020002CF RID: 719
	public class DaySceneMapProfile : ScriptableObject
	{
		// Token: 0x0600588F RID: 22671 RVA: 0x001C8D50 File Offset: 0x001C6F50
		// Note: this type is marked as 'beforefieldinit'.
		static DaySceneMapProfile()
		{
			Il2CppClassPointerStore<DaySceneMapProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DaySceneMapProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMapProfile>.NativeClassPtr);
			DaySceneMapProfile.NativeFieldInfoPtr_allMapNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapProfile>.NativeClassPtr, "allMapNodes");
			DaySceneMapProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DaySceneMapProfile>.NativeClassPtr, 100681268);
		}

		// Token: 0x06005890 RID: 22672 RVA: 0x001C8DA8 File Offset: 0x001C6FA8
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DaySceneMapProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMapProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DaySceneMapProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005891 RID: 22673 RVA: 0x0002F790 File Offset: 0x0002D990
		public DaySceneMapProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x06005892 RID: 22674 RVA: 0x001C8DE4 File Offset: 0x001C6FE4
		// (set) Token: 0x06005893 RID: 22675 RVA: 0x0002F799 File Offset: 0x0002D999
		public unsafe Il2CppReferenceArray<DaySceneMapProfile.MapNode> allMapNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.NativeFieldInfoPtr_allMapNodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DaySceneMapProfile.MapNode>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.NativeFieldInfoPtr_allMapNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B47 RID: 15175
		private static readonly IntPtr NativeFieldInfoPtr_allMapNodes;

		// Token: 0x04003B48 RID: 15176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C92 RID: 3218
		[Serializable]
		public sealed class MapNode : ValueType
		{
			// Token: 0x0600E71D RID: 59165 RVA: 0x00376C08 File Offset: 0x00374E08
			// Note: this type is marked as 'beforefieldinit'.
			static MapNode()
			{
				Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DaySceneMapProfile>.NativeClassPtr, "MapNode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr);
				DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr, "mapName");
				DaySceneMapProfile.MapNode.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr, "parent");
				DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapAssetReference = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr, "mapAssetReference");
				DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapCollectableLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr, "mapCollectableLabels");
				DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapSpawnMarkerLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr, "mapSpawnMarkerLabels");
				DaySceneMapProfile.MapNode.NativeFieldInfoPtr_level1IzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr, "level1IzakayaId");
				DaySceneMapProfile.MapNode.NativeFieldInfoPtr_level2IzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr, "level2IzakayaId");
				DaySceneMapProfile.MapNode.NativeFieldInfoPtr_level3IzakayaId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr, "level3IzakayaId");
			}

			// Token: 0x0600E71E RID: 59166 RVA: 0x0007B5A6 File Offset: 0x000797A6
			public MapNode(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E71F RID: 59167 RVA: 0x0007B5AF File Offset: 0x000797AF
			public MapNode() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DaySceneMapProfile.MapNode>.NativeClassPtr))
			{
			}

			// Token: 0x17004AF1 RID: 19185
			// (get) Token: 0x0600E720 RID: 59168 RVA: 0x00376CD4 File Offset: 0x00374ED4
			// (set) Token: 0x0600E721 RID: 59169 RVA: 0x0007B5C1 File Offset: 0x000797C1
			public unsafe string mapName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004AF2 RID: 19186
			// (get) Token: 0x0600E722 RID: 59170 RVA: 0x00376CFC File Offset: 0x00374EFC
			// (set) Token: 0x0600E723 RID: 59171 RVA: 0x0007B5E0 File Offset: 0x000797E0
			public unsafe string parent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_parent);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_parent), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004AF3 RID: 19187
			// (get) Token: 0x0600E724 RID: 59172 RVA: 0x00376D24 File Offset: 0x00374F24
			// (set) Token: 0x0600E725 RID: 59173 RVA: 0x0007B5FF File Offset: 0x000797FF
			public unsafe AssetReference mapAssetReference
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapAssetReference);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapAssetReference), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AF4 RID: 19188
			// (get) Token: 0x0600E726 RID: 59174 RVA: 0x00376D54 File Offset: 0x00374F54
			// (set) Token: 0x0600E727 RID: 59175 RVA: 0x0007B61E File Offset: 0x0007981E
			public unsafe Il2CppStringArray mapCollectableLabels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapCollectableLabels);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapCollectableLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AF5 RID: 19189
			// (get) Token: 0x0600E728 RID: 59176 RVA: 0x00376D84 File Offset: 0x00374F84
			// (set) Token: 0x0600E729 RID: 59177 RVA: 0x0007B63D File Offset: 0x0007983D
			public unsafe Il2CppStringArray mapSpawnMarkerLabels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapSpawnMarkerLabels);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_mapSpawnMarkerLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AF6 RID: 19190
			// (get) Token: 0x0600E72A RID: 59178 RVA: 0x00376DB4 File Offset: 0x00374FB4
			// (set) Token: 0x0600E72B RID: 59179 RVA: 0x0007B65C File Offset: 0x0007985C
			public unsafe Il2CppStructArray<int> level1IzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_level1IzakayaId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_level1IzakayaId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AF7 RID: 19191
			// (get) Token: 0x0600E72C RID: 59180 RVA: 0x00376DE4 File Offset: 0x00374FE4
			// (set) Token: 0x0600E72D RID: 59181 RVA: 0x0007B67B File Offset: 0x0007987B
			public unsafe Il2CppStructArray<int> level2IzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_level2IzakayaId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_level2IzakayaId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AF8 RID: 19192
			// (get) Token: 0x0600E72E RID: 59182 RVA: 0x00376E14 File Offset: 0x00375014
			// (set) Token: 0x0600E72F RID: 59183 RVA: 0x0007B69A File Offset: 0x0007989A
			public unsafe Il2CppStructArray<int> level3IzakayaId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_level3IzakayaId);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DaySceneMapProfile.MapNode.NativeFieldInfoPtr_level3IzakayaId), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009393 RID: 37779
			private static readonly IntPtr NativeFieldInfoPtr_mapName;

			// Token: 0x04009394 RID: 37780
			private static readonly IntPtr NativeFieldInfoPtr_parent;

			// Token: 0x04009395 RID: 37781
			private static readonly IntPtr NativeFieldInfoPtr_mapAssetReference;

			// Token: 0x04009396 RID: 37782
			private static readonly IntPtr NativeFieldInfoPtr_mapCollectableLabels;

			// Token: 0x04009397 RID: 37783
			private static readonly IntPtr NativeFieldInfoPtr_mapSpawnMarkerLabels;

			// Token: 0x04009398 RID: 37784
			private static readonly IntPtr NativeFieldInfoPtr_level1IzakayaId;

			// Token: 0x04009399 RID: 37785
			private static readonly IntPtr NativeFieldInfoPtr_level2IzakayaId;

			// Token: 0x0400939A RID: 37786
			private static readonly IntPtr NativeFieldInfoPtr_level3IzakayaId;
		}
	}
}
