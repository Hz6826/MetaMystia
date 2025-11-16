using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200017F RID: 383
	public class DLC3PalmCivetBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x060029B4 RID: 10676 RVA: 0x001292C8 File Offset: 0x001274C8
		// Note: this type is marked as 'beforefieldinit'.
		static DLC3PalmCivetBehaviourComponent()
		{
			Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "DLC3PalmCivetBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr);
			DLC3PalmCivetBehaviourComponent.NativeFieldInfoPtr_m_TipIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr, "m_TipIcon");
			DLC3PalmCivetBehaviourComponent.NativeFieldInfoPtr_m_ExecuteTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr, "m_ExecuteTimeline");
			DLC3PalmCivetBehaviourComponent.NativeFieldInfoPtr_m_ScheduledEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr, "m_ScheduledEvent");
			DLC3PalmCivetBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr, 100670583);
			DLC3PalmCivetBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr, 100670584);
			DLC3PalmCivetBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr, 100670585);
			DLC3PalmCivetBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__3_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr, 100670586);
		}

		// Token: 0x060029B5 RID: 10677 RVA: 0x00129384 File Offset: 0x00127584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93800, XrefRangeEnd = 93816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3PalmCivetBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B6 RID: 10678 RVA: 0x001293C0 File Offset: 0x001275C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93816, XrefRangeEnd = 93820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DLC3PalmCivetBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B7 RID: 10679 RVA: 0x001293FC File Offset: 0x001275FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DLC3PalmCivetBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DLC3PalmCivetBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3PalmCivetBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B8 RID: 10680 RVA: 0x00129438 File Offset: 0x00127638
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93820, XrefRangeEnd = 93829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteract_b__3_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DLC3PalmCivetBehaviourComponent.NativeMethodInfoPtr__OnInteract_b__3_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029B9 RID: 10681 RVA: 0x000185A6 File Offset: 0x000167A6
		public DLC3PalmCivetBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x060029BA RID: 10682 RVA: 0x0012946C File Offset: 0x0012766C
		// (set) Token: 0x060029BB RID: 10683 RVA: 0x000185AF File Offset: 0x000167AF
		public unsafe GameObject m_TipIcon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3PalmCivetBehaviourComponent.NativeFieldInfoPtr_m_TipIcon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3PalmCivetBehaviourComponent.NativeFieldInfoPtr_m_TipIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x060029BC RID: 10684 RVA: 0x0012949C File Offset: 0x0012769C
		// (set) Token: 0x060029BD RID: 10685 RVA: 0x000185CE File Offset: 0x000167CE
		public unsafe PlayableAsset m_ExecuteTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3PalmCivetBehaviourComponent.NativeFieldInfoPtr_m_ExecuteTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3PalmCivetBehaviourComponent.NativeFieldInfoPtr_m_ExecuteTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060029BE RID: 10686 RVA: 0x001294CC File Offset: 0x001276CC
		// (set) Token: 0x060029BF RID: 10687 RVA: 0x000185ED File Offset: 0x000167ED
		public unsafe string m_ScheduledEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3PalmCivetBehaviourComponent.NativeFieldInfoPtr_m_ScheduledEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DLC3PalmCivetBehaviourComponent.NativeFieldInfoPtr_m_ScheduledEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B93 RID: 7059
		private static readonly IntPtr NativeFieldInfoPtr_m_TipIcon;

		// Token: 0x04001B94 RID: 7060
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecuteTimeline;

		// Token: 0x04001B95 RID: 7061
		private static readonly IntPtr NativeFieldInfoPtr_m_ScheduledEvent;

		// Token: 0x04001B96 RID: 7062
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B97 RID: 7063
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B98 RID: 7064
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001B99 RID: 7065
		private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__3_0_Private_Void_0;
	}
}
