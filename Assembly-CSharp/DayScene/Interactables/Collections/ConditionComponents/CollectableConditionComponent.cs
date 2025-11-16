using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x02000168 RID: 360
	public class CollectableConditionComponent : EntityConditionComponent
	{
		// Token: 0x06002876 RID: 10358 RVA: 0x001250E4 File Offset: 0x001232E4
		// Note: this type is marked as 'beforefieldinit'.
		static CollectableConditionComponent()
		{
			Il2CppClassPointerStore<CollectableConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "CollectableConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectableConditionComponent>.NativeClassPtr);
			CollectableConditionComponent.NativeFieldInfoPtr_collectableKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectableConditionComponent>.NativeClassPtr, "collectableKey");
			CollectableConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Final_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectableConditionComponent>.NativeClassPtr, 100670393);
			CollectableConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectableConditionComponent>.NativeClassPtr, 100670394);
			CollectableConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectableConditionComponent>.NativeClassPtr, 100670395);
			CollectableConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectableConditionComponent>.NativeClassPtr, 100670396);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00125178 File Offset: 0x00123378
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92311, XrefRangeEnd = 92312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectableConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Final_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x001251B4 File Offset: 0x001233B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92312, XrefRangeEnd = 92318, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectableConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00125200 File Offset: 0x00123400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92318, XrefRangeEnd = 92321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollectableConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x0012523C File Offset: 0x0012343C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92321, XrefRangeEnd = 92329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectableConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectableConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectableConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x00017CC7 File Offset: 0x00015EC7
		public CollectableConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x0600287C RID: 10364 RVA: 0x00125278 File Offset: 0x00123478
		// (set) Token: 0x0600287D RID: 10365 RVA: 0x00017CD0 File Offset: 0x00015ED0
		public unsafe string collectableKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectableConditionComponent.NativeFieldInfoPtr_collectableKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectableConditionComponent.NativeFieldInfoPtr_collectableKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001ACB RID: 6859
		private static readonly IntPtr NativeFieldInfoPtr_collectableKey;

		// Token: 0x04001ACC RID: 6860
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Final_Boolean_0;

		// Token: 0x04001ACD RID: 6861
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001ACE RID: 6862
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001ACF RID: 6863
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
