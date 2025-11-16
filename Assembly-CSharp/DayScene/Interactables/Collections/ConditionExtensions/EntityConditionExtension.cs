using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionExtensions
{
	// Token: 0x02000166 RID: 358
	public class EntityConditionExtension : MonoBehaviour
	{
		// Token: 0x06002848 RID: 10312 RVA: 0x001246CC File Offset: 0x001228CC
		// Note: this type is marked as 'beforefieldinit'.
		static EntityConditionExtension()
		{
			Il2CppClassPointerStore<EntityConditionExtension>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionExtensions", "EntityConditionExtension");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityConditionExtension>.NativeClassPtr);
			EntityConditionExtension.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionExtension>.NativeClassPtr, 100670371);
			EntityConditionExtension.NativeMethodInfoPtr_OnGetExtensionAvailability_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionExtension>.NativeClassPtr, 100670372);
			EntityConditionExtension.NativeMethodInfoPtr_OnGetExtensionType_Public_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionExtension>.NativeClassPtr, 100670373);
			EntityConditionExtension.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionExtension>.NativeClassPtr, 100670374);
			EntityConditionExtension.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConditionExtension>.NativeClassPtr, 100670375);
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00124760 File Offset: 0x00122960
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 27675, RefRangeEnd = 27686, XrefRangeStart = 27675, XrefRangeEnd = 27686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionExtension.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00124794 File Offset: 0x00122994
		[CallerCount(0)]
		public unsafe virtual bool OnGetExtensionAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionExtension.NativeMethodInfoPtr_OnGetExtensionAvailability_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x001247DC File Offset: 0x001229DC
		[CallerCount(0)]
		public unsafe virtual Type OnGetExtensionType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionExtension.NativeMethodInfoPtr_OnGetExtensionType_Public_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00124828 File Offset: 0x00122A28
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConditionExtension.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00124864 File Offset: 0x00122A64
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityConditionExtension() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityConditionExtension>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConditionExtension.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x00017BA5 File Offset: 0x00015DA5
		public EntityConditionExtension(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001AAB RID: 6827
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04001AAC RID: 6828
		private static readonly IntPtr NativeMethodInfoPtr_OnGetExtensionAvailability_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x04001AAD RID: 6829
		private static readonly IntPtr NativeMethodInfoPtr_OnGetExtensionType_Public_Abstract_Virtual_New_Type_0;

		// Token: 0x04001AAE RID: 6830
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x04001AAF RID: 6831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
