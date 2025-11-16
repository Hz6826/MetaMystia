using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x02000169 RID: 361
	public sealed class MapTransitionConditionComponent : EntityConditionComponent
	{
		// Token: 0x0600287E RID: 10366 RVA: 0x001252A0 File Offset: 0x001234A0
		// Note: this type is marked as 'beforefieldinit'.
		static MapTransitionConditionComponent()
		{
			Il2CppClassPointerStore<MapTransitionConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "MapTransitionConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapTransitionConditionComponent>.NativeClassPtr);
			MapTransitionConditionComponent.NativeFieldInfoPtr_transitionData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapTransitionConditionComponent>.NativeClassPtr, "transitionData");
			MapTransitionConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionConditionComponent>.NativeClassPtr, 100670397);
			MapTransitionConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionConditionComponent>.NativeClassPtr, 100670398);
			MapTransitionConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionConditionComponent>.NativeClassPtr, 100670399);
			MapTransitionConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapTransitionConditionComponent>.NativeClassPtr, 100670400);
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x00125334 File Offset: 0x00123534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92329, XrefRangeEnd = 92331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00125370 File Offset: 0x00123570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92331, XrefRangeEnd = 92337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x001253B0 File Offset: 0x001235B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x001253E4 File Offset: 0x001235E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92337, XrefRangeEnd = 92345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapTransitionConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapTransitionConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapTransitionConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x00017CEF File Offset: 0x00015EEF
		public MapTransitionConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x06002884 RID: 10372 RVA: 0x00125420 File Offset: 0x00123620
		// (set) Token: 0x06002885 RID: 10373 RVA: 0x00017CF8 File Offset: 0x00015EF8
		public unsafe MapTransitionData transitionData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionConditionComponent.NativeFieldInfoPtr_transitionData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MapTransitionData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapTransitionConditionComponent.NativeFieldInfoPtr_transitionData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AD0 RID: 6864
		private static readonly IntPtr NativeFieldInfoPtr_transitionData;

		// Token: 0x04001AD1 RID: 6865
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001AD2 RID: 6866
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001AD3 RID: 6867
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001AD4 RID: 6868
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
