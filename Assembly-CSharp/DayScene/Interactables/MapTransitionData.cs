using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace DayScene.Interactables
{
	// Token: 0x0200015F RID: 351
	public class MapTransitionData : MonoBehaviour
	{
		// Token: 0x060027C8 RID: 10184 RVA: 0x00122F58 File Offset: 0x00121158
		// Note: this type is marked as 'beforefieldinit'.
		static MapTransitionData()
		{
			Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables", "MapTransitionData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr);
			MapTransitionData.NativeFieldInfoPtr_shouldCostAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr, "shouldCostAction");
			MapTransitionData.NativeFieldInfoPtr_transitionClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr, "transitionClip");
			MapTransitionData.NativeFieldInfoPtr_targetSceneLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr, "targetSceneLabel");
			MapTransitionData.NativeFieldInfoPtr_targetSceneSpawnMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr, "targetSceneSpawnMarker");
			MapTransitionData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr, 100670307);
			MapTransitionData.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr, 100670308);
			MapTransitionData.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr, 100670309);
			MapTransitionData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr, 100670310);
		}

		// Token: 0x17000DD8 RID: 3544
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x00123028 File Offset: 0x00121228
		public unsafe bool Unlocked
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91585, XrefRangeEnd = 91586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionData.NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00123064 File Offset: 0x00121264
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionData.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CB RID: 10187 RVA: 0x00123098 File Offset: 0x00121298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 91586, XrefRangeEnd = 91589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapTransitionData.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x001230D4 File Offset: 0x001212D4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapTransitionData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTransitionData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00017733 File Offset: 0x00015933
		public MapTransitionData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DD4 RID: 3540
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x00123110 File Offset: 0x00121310
		// (set) Token: 0x060027CF RID: 10191 RVA: 0x0001773C File Offset: 0x0001593C
		public unsafe bool shouldCostAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionData.NativeFieldInfoPtr_shouldCostAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionData.NativeFieldInfoPtr_shouldCostAction)) = value;
			}
		}

		// Token: 0x17000DD5 RID: 3541
		// (get) Token: 0x060027D0 RID: 10192 RVA: 0x00123138 File Offset: 0x00121338
		// (set) Token: 0x060027D1 RID: 10193 RVA: 0x00017757 File Offset: 0x00015957
		public unsafe AudioClip transitionClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionData.NativeFieldInfoPtr_transitionClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionData.NativeFieldInfoPtr_transitionClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DD6 RID: 3542
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x00123168 File Offset: 0x00121368
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x00017776 File Offset: 0x00015976
		public unsafe string targetSceneLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionData.NativeFieldInfoPtr_targetSceneLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionData.NativeFieldInfoPtr_targetSceneLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DD7 RID: 3543
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x00123190 File Offset: 0x00121390
		// (set) Token: 0x060027D5 RID: 10197 RVA: 0x00017795 File Offset: 0x00015995
		public unsafe string targetSceneSpawnMarker
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionData.NativeFieldInfoPtr_targetSceneSpawnMarker);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionData.NativeFieldInfoPtr_targetSceneSpawnMarker), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeFieldInfoPtr_shouldCostAction;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeFieldInfoPtr_transitionClip;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeFieldInfoPtr_targetSceneLabel;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeFieldInfoPtr_targetSceneSpawnMarker;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr_get_Unlocked_Public_get_Boolean_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001A64 RID: 6756
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001A65 RID: 6757
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
