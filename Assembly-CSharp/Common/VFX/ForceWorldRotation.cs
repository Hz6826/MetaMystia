using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Common.VFX
{
	// Token: 0x0200034D RID: 845
	public class ForceWorldRotation : MonoBehaviour
	{
		// Token: 0x06006431 RID: 25649 RVA: 0x001ED1EC File Offset: 0x001EB3EC
		// Note: this type is marked as 'beforefieldinit'.
		static ForceWorldRotation()
		{
			Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.VFX", "ForceWorldRotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr);
			ForceWorldRotation.NativeFieldInfoPtr_worldEulerAngles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr, "worldEulerAngles");
			ForceWorldRotation.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr, 100684286);
			ForceWorldRotation.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr, 100684287);
			ForceWorldRotation.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr, 100684288);
			ForceWorldRotation.NativeMethodInfoPtr_UpdateEuler_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr, 100684289);
			ForceWorldRotation.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr, 100684290);
			ForceWorldRotation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr, 100684291);
		}

		// Token: 0x06006432 RID: 25650 RVA: 0x001ED2A8 File Offset: 0x001EB4A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257718, XrefRangeEnd = 257720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceWorldRotation.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006433 RID: 25651 RVA: 0x001ED2DC File Offset: 0x001EB4DC
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceWorldRotation.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006434 RID: 25652 RVA: 0x001ED310 File Offset: 0x001EB510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceWorldRotation.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006435 RID: 25653 RVA: 0x001ED344 File Offset: 0x001EB544
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateEuler()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceWorldRotation.NativeMethodInfoPtr_UpdateEuler_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006436 RID: 25654 RVA: 0x001ED378 File Offset: 0x001EB578
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForceWorldRotation.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006437 RID: 25655 RVA: 0x001ED3B4 File Offset: 0x001EB5B4
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForceWorldRotation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForceWorldRotation>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForceWorldRotation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006438 RID: 25656 RVA: 0x0003633E File Offset: 0x0003453E
		public ForceWorldRotation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002282 RID: 8834
		// (get) Token: 0x06006439 RID: 25657 RVA: 0x001ED3F0 File Offset: 0x001EB5F0
		// (set) Token: 0x0600643A RID: 25658 RVA: 0x00036347 File Offset: 0x00034547
		public unsafe Vector3 worldEulerAngles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceWorldRotation.NativeFieldInfoPtr_worldEulerAngles);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ForceWorldRotation.NativeFieldInfoPtr_worldEulerAngles)) = value;
			}
		}

		// Token: 0x04004270 RID: 17008
		private static readonly IntPtr NativeFieldInfoPtr_worldEulerAngles;

		// Token: 0x04004271 RID: 17009
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004272 RID: 17010
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04004273 RID: 17011
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04004274 RID: 17012
		private static readonly IntPtr NativeMethodInfoPtr_UpdateEuler_Private_Void_0;

		// Token: 0x04004275 RID: 17013
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04004276 RID: 17014
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
