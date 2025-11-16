using System;
using DayScene.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace DayScene.Interactables
{
	// Token: 0x02000160 RID: 352
	public class SpawnMarker : MonoBehaviour
	{
		// Token: 0x060027D6 RID: 10198 RVA: 0x001231B8 File Offset: 0x001213B8
		// Note: this type is marked as 'beforefieldinit'.
		static SpawnMarker()
		{
			Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables", "SpawnMarker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr);
			SpawnMarker.NativeFieldInfoPtr_spawnMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr, "spawnMarkerName");
			SpawnMarker.NativeFieldInfoPtr_targetRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr, "targetRotation");
			SpawnMarker.NativeFieldInfoPtr_shouldOverrideRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr, "shouldOverrideRadius");
			SpawnMarker.NativeFieldInfoPtr_overrideRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr, "overrideRadius");
			SpawnMarker.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr, 100670311);
			SpawnMarker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr, 100670312);
			SpawnMarker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr, 100670313);
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x00123274 File Offset: 0x00121474
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnMarker.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x001232A8 File Offset: 0x001214A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 72640, RefRangeEnd = 72641, XrefRangeStart = 72640, XrefRangeEnd = 72641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SpawnMarker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x001232E4 File Offset: 0x001214E4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpawnMarker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnMarker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpawnMarker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027DA RID: 10202 RVA: 0x000177B4 File Offset: 0x000159B4
		public SpawnMarker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DD9 RID: 3545
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x00123320 File Offset: 0x00121520
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x000177BD File Offset: 0x000159BD
		public unsafe string spawnMarkerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnMarker.NativeFieldInfoPtr_spawnMarkerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnMarker.NativeFieldInfoPtr_spawnMarkerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DDA RID: 3546
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x00123348 File Offset: 0x00121548
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x000177DC File Offset: 0x000159DC
		public unsafe DayScenePlayerInputGenerator.CharacterRotation targetRotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnMarker.NativeFieldInfoPtr_targetRotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnMarker.NativeFieldInfoPtr_targetRotation)) = value;
			}
		}

		// Token: 0x17000DDB RID: 3547
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x00123370 File Offset: 0x00121570
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x000177F7 File Offset: 0x000159F7
		public unsafe bool shouldOverrideRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnMarker.NativeFieldInfoPtr_shouldOverrideRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnMarker.NativeFieldInfoPtr_shouldOverrideRadius)) = value;
			}
		}

		// Token: 0x17000DDC RID: 3548
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x00123398 File Offset: 0x00121598
		// (set) Token: 0x060027E2 RID: 10210 RVA: 0x00017812 File Offset: 0x00015A12
		public unsafe float overrideRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnMarker.NativeFieldInfoPtr_overrideRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpawnMarker.NativeFieldInfoPtr_overrideRadius)) = value;
			}
		}

		// Token: 0x04001A66 RID: 6758
		private static readonly IntPtr NativeFieldInfoPtr_spawnMarkerName;

		// Token: 0x04001A67 RID: 6759
		private static readonly IntPtr NativeFieldInfoPtr_targetRotation;

		// Token: 0x04001A68 RID: 6760
		private static readonly IntPtr NativeFieldInfoPtr_shouldOverrideRadius;

		// Token: 0x04001A69 RID: 6761
		private static readonly IntPtr NativeFieldInfoPtr_overrideRadius;

		// Token: 0x04001A6A RID: 6762
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001A6B RID: 6763
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001A6C RID: 6764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
