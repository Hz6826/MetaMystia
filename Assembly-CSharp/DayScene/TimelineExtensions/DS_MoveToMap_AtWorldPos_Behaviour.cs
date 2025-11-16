using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000149 RID: 329
	public class DS_MoveToMap_AtWorldPos_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002690 RID: 9872 RVA: 0x0011F9D0 File Offset: 0x0011DBD0
		// Note: this type is marked as 'beforefieldinit'.
		static DS_MoveToMap_AtWorldPos_Behaviour()
		{
			Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_MoveToMap_AtWorldPos_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr);
			DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr, "position");
			DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_shouldCostAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr, "shouldCostAction");
			DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_shouldFadeInFadeOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr, "shouldFadeInFadeOut");
			DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_targetMapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr, "targetMapLabel");
			DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_triggerEnterMapEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr, "triggerEnterMapEvent");
			DS_MoveToMap_AtWorldPos_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr, 100670203);
			DS_MoveToMap_AtWorldPos_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr, 100670204);
			DS_MoveToMap_AtWorldPos_Behaviour.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr, 100670205);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x0011FAA0 File Offset: 0x0011DCA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90293, XrefRangeEnd = 90303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_MoveToMap_AtWorldPos_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x0011FADC File Offset: 0x0011DCDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_MoveToMap_AtWorldPos_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_MoveToMap_AtWorldPos_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_MoveToMap_AtWorldPos_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x0011FB18 File Offset: 0x0011DD18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90303, XrefRangeEnd = 90311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_MoveToMap_AtWorldPos_Behaviour.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x00016BBF File Offset: 0x00014DBF
		public DS_MoveToMap_AtWorldPos_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x0011FB4C File Offset: 0x0011DD4C
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x00016BC8 File Offset: 0x00014DC8
		public unsafe Vector2 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x0011FB74 File Offset: 0x0011DD74
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x00016BE3 File Offset: 0x00014DE3
		public unsafe bool shouldCostAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_shouldCostAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_shouldCostAction)) = value;
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x0011FB9C File Offset: 0x0011DD9C
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x00016BFE File Offset: 0x00014DFE
		public unsafe bool shouldFadeInFadeOut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_shouldFadeInFadeOut);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_shouldFadeInFadeOut)) = value;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x0011FBC4 File Offset: 0x0011DDC4
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x00016C19 File Offset: 0x00014E19
		public unsafe string targetMapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_targetMapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_targetMapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x0011FBEC File Offset: 0x0011DDEC
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x00016C38 File Offset: 0x00014E38
		public unsafe bool triggerEnterMapEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_triggerEnterMapEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_MoveToMap_AtWorldPos_Behaviour.NativeFieldInfoPtr_triggerEnterMapEvent)) = value;
			}
		}

		// Token: 0x040019B4 RID: 6580
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x040019B5 RID: 6581
		private static readonly IntPtr NativeFieldInfoPtr_shouldCostAction;

		// Token: 0x040019B6 RID: 6582
		private static readonly IntPtr NativeFieldInfoPtr_shouldFadeInFadeOut;

		// Token: 0x040019B7 RID: 6583
		private static readonly IntPtr NativeFieldInfoPtr_targetMapLabel;

		// Token: 0x040019B8 RID: 6584
		private static readonly IntPtr NativeFieldInfoPtr_triggerEnterMapEvent;

		// Token: 0x040019B9 RID: 6585
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019BA RID: 6586
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040019BB RID: 6587
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;
	}
}
