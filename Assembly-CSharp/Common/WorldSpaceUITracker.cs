using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common
{
	// Token: 0x0200033B RID: 827
	public class WorldSpaceUITracker : MonoBehaviour
	{
		// Token: 0x06006286 RID: 25222 RVA: 0x001E7BDC File Offset: 0x001E5DDC
		// Note: this type is marked as 'beforefieldinit'.
		static WorldSpaceUITracker()
		{
			Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common", "WorldSpaceUITracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr);
			WorldSpaceUITracker.NativeFieldInfoPtr_m_WorldOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, "m_WorldOffset");
			WorldSpaceUITracker.NativeFieldInfoPtr_m_Camera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, "m_Camera");
			WorldSpaceUITracker.NativeFieldInfoPtr_m_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, "m_Canvas");
			WorldSpaceUITracker.NativeFieldInfoPtr_m_FollowTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, "m_FollowTarget");
			WorldSpaceUITracker.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, 100684035);
			WorldSpaceUITracker.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, 100684036);
			WorldSpaceUITracker.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, 100684037);
			WorldSpaceUITracker.NativeMethodInfoPtr_FocusToTarget_Public_Void_Transform_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, 100684038);
			WorldSpaceUITracker.NativeMethodInfoPtr_RefreshPosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, 100684039);
			WorldSpaceUITracker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, 100684040);
			WorldSpaceUITracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr, 100684041);
		}

		// Token: 0x06006287 RID: 25223 RVA: 0x001E7CE8 File Offset: 0x001E5EE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255102, XrefRangeEnd = 255109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceUITracker.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x001E7D1C File Offset: 0x001E5F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255109, XrefRangeEnd = 255120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceUITracker.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006289 RID: 25225 RVA: 0x001E7D50 File Offset: 0x001E5F50
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceUITracker.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600628A RID: 25226 RVA: 0x001E7D84 File Offset: 0x001E5F84
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 255129, RefRangeEnd = 255131, XrefRangeStart = 255120, XrefRangeEnd = 255129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FocusToTarget(Transform followTarget, Vector3 worldOffset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(followTarget);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldOffset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceUITracker.NativeMethodInfoPtr_FocusToTarget_Public_Void_Transform_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600628B RID: 25227 RVA: 0x001E7DD4 File Offset: 0x001E5FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255131, XrefRangeEnd = 255139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceUITracker.NativeMethodInfoPtr_RefreshPosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x001E7E08 File Offset: 0x001E6008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 255139, XrefRangeEnd = 255142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WorldSpaceUITracker.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600628D RID: 25229 RVA: 0x001E7E44 File Offset: 0x001E6044
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldSpaceUITracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSpaceUITracker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldSpaceUITracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600628E RID: 25230 RVA: 0x000353F5 File Offset: 0x000335F5
		public WorldSpaceUITracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021E5 RID: 8677
		// (get) Token: 0x0600628F RID: 25231 RVA: 0x001E7E80 File Offset: 0x001E6080
		// (set) Token: 0x06006290 RID: 25232 RVA: 0x000353FE File Offset: 0x000335FE
		public unsafe Vector3 m_WorldOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceUITracker.NativeFieldInfoPtr_m_WorldOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceUITracker.NativeFieldInfoPtr_m_WorldOffset)) = value;
			}
		}

		// Token: 0x170021E6 RID: 8678
		// (get) Token: 0x06006291 RID: 25233 RVA: 0x001E7EA8 File Offset: 0x001E60A8
		// (set) Token: 0x06006292 RID: 25234 RVA: 0x00035419 File Offset: 0x00033619
		public unsafe Camera m_Camera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceUITracker.NativeFieldInfoPtr_m_Camera);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceUITracker.NativeFieldInfoPtr_m_Camera), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E7 RID: 8679
		// (get) Token: 0x06006293 RID: 25235 RVA: 0x001E7ED8 File Offset: 0x001E60D8
		// (set) Token: 0x06006294 RID: 25236 RVA: 0x00035438 File Offset: 0x00033638
		public unsafe Canvas m_Canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceUITracker.NativeFieldInfoPtr_m_Canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceUITracker.NativeFieldInfoPtr_m_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021E8 RID: 8680
		// (get) Token: 0x06006295 RID: 25237 RVA: 0x001E7F08 File Offset: 0x001E6108
		// (set) Token: 0x06006296 RID: 25238 RVA: 0x00035457 File Offset: 0x00033657
		public unsafe Transform m_FollowTarget
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceUITracker.NativeFieldInfoPtr_m_FollowTarget);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WorldSpaceUITracker.NativeFieldInfoPtr_m_FollowTarget), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400414F RID: 16719
		private static readonly IntPtr NativeFieldInfoPtr_m_WorldOffset;

		// Token: 0x04004150 RID: 16720
		private static readonly IntPtr NativeFieldInfoPtr_m_Camera;

		// Token: 0x04004151 RID: 16721
		private static readonly IntPtr NativeFieldInfoPtr_m_Canvas;

		// Token: 0x04004152 RID: 16722
		private static readonly IntPtr NativeFieldInfoPtr_m_FollowTarget;

		// Token: 0x04004153 RID: 16723
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004154 RID: 16724
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004155 RID: 16725
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004156 RID: 16726
		private static readonly IntPtr NativeMethodInfoPtr_FocusToTarget_Public_Void_Transform_Vector3_0;

		// Token: 0x04004157 RID: 16727
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPosition_Private_Void_0;

		// Token: 0x04004158 RID: 16728
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04004159 RID: 16729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
