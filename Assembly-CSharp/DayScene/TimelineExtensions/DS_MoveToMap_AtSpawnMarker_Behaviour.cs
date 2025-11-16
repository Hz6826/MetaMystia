using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000148 RID: 328
	public class DS_MoveToMap_AtSpawnMarker_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002682 RID: 9858 RVA: 0x0011F7D4 File Offset: 0x0011D9D4
		// Note: this type is marked as 'beforefieldinit'.
		static DS_MoveToMap_AtSpawnMarker_Behaviour()
		{
			Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_MoveToMap_AtSpawnMarker_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr);
			DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_targetMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr, "targetMapLabel");
			DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_targetMarkerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr, "targetMarkerName");
			DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_shouldCostAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr, "shouldCostAction");
			DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_shouldFadeInFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr, "shouldFadeInFadeOut");
			DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_triggerEnterMapEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr, "triggerEnterMapEvent");
			DS_MoveToMap_AtSpawnMarker_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr, 100670201);
			DS_MoveToMap_AtSpawnMarker_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr, 100670202);
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x0011F890 File Offset: 0x0011DA90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90283, XrefRangeEnd = 90293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_MoveToMap_AtSpawnMarker_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x0011F8CC File Offset: 0x0011DACC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_MoveToMap_AtSpawnMarker_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_MoveToMap_AtSpawnMarker_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002685 RID: 9861 RVA: 0x00016B27 File Offset: 0x00014D27
		public DS_MoveToMap_AtSpawnMarker_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002686 RID: 9862 RVA: 0x0011F908 File Offset: 0x0011DB08
		// (set) Token: 0x06002687 RID: 9863 RVA: 0x00016B30 File Offset: 0x00014D30
		public unsafe string targetMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_targetMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_targetMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x0011F930 File Offset: 0x0011DB30
		// (set) Token: 0x06002689 RID: 9865 RVA: 0x00016B4F File Offset: 0x00014D4F
		public unsafe string targetMarkerName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_targetMarkerName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_targetMarkerName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x0600268A RID: 9866 RVA: 0x0011F958 File Offset: 0x0011DB58
		// (set) Token: 0x0600268B RID: 9867 RVA: 0x00016B6E File Offset: 0x00014D6E
		public unsafe bool shouldCostAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_shouldCostAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_shouldCostAction)) = value;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x0011F980 File Offset: 0x0011DB80
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x00016B89 File Offset: 0x00014D89
		public unsafe bool shouldFadeInFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_shouldFadeInFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_shouldFadeInFadeOut)) = value;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x0600268E RID: 9870 RVA: 0x0011F9A8 File Offset: 0x0011DBA8
		// (set) Token: 0x0600268F RID: 9871 RVA: 0x00016BA4 File Offset: 0x00014DA4
		public unsafe bool triggerEnterMapEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_triggerEnterMapEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtSpawnMarker_Behaviour.NativeFieldInfoPtr_triggerEnterMapEvent)) = value;
			}
		}

		// Token: 0x040019AD RID: 6573
		private static readonly IntPtr NativeFieldInfoPtr_targetMapLabel;

		// Token: 0x040019AE RID: 6574
		private static readonly IntPtr NativeFieldInfoPtr_targetMarkerName;

		// Token: 0x040019AF RID: 6575
		private static readonly IntPtr NativeFieldInfoPtr_shouldCostAction;

		// Token: 0x040019B0 RID: 6576
		private static readonly IntPtr NativeFieldInfoPtr_shouldFadeInFadeOut;

		// Token: 0x040019B1 RID: 6577
		private static readonly IntPtr NativeFieldInfoPtr_triggerEnterMapEvent;

		// Token: 0x040019B2 RID: 6578
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019B3 RID: 6579
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
