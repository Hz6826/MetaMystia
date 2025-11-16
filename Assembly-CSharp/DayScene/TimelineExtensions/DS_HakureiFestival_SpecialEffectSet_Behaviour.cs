using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200014C RID: 332
	public class DS_HakureiFestival_SpecialEffectSet_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060026AD RID: 9901 RVA: 0x0011FE68 File Offset: 0x0011E068
		// Note: this type is marked as 'beforefieldinit'.
		static DS_HakureiFestival_SpecialEffectSet_Behaviour()
		{
			Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_HakureiFestival_SpecialEffectSet_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr);
			DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr, "label");
			DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr, "open");
			DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr, "transitionDuration");
			DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_viewLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr, "viewLabel");
			DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr, "worldPosition");
			DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr, 100670210);
			DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr, 100670211);
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x0011FF24 File Offset: 0x0011E124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90322, XrefRangeEnd = 90339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x0011FF60 File Offset: 0x0011E160
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_HakureiFestival_SpecialEffectSet_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026B0 RID: 9904 RVA: 0x00016CBE File Offset: 0x00014EBE
		public DS_HakureiFestival_SpecialEffectSet_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D7A RID: 3450
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x0011FF9C File Offset: 0x0011E19C
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x00016CC7 File Offset: 0x00014EC7
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D7B RID: 3451
		// (get) Token: 0x060026B3 RID: 9907 RVA: 0x0011FFC4 File Offset: 0x0011E1C4
		// (set) Token: 0x060026B4 RID: 9908 RVA: 0x00016CE6 File Offset: 0x00014EE6
		public unsafe bool open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_open)) = value;
			}
		}

		// Token: 0x17000D7C RID: 3452
		// (get) Token: 0x060026B5 RID: 9909 RVA: 0x0011FFEC File Offset: 0x0011E1EC
		// (set) Token: 0x060026B6 RID: 9910 RVA: 0x00016D01 File Offset: 0x00014F01
		public unsafe float transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_transitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_transitionDuration)) = value;
			}
		}

		// Token: 0x17000D7D RID: 3453
		// (get) Token: 0x060026B7 RID: 9911 RVA: 0x00120014 File Offset: 0x0011E214
		// (set) Token: 0x060026B8 RID: 9912 RVA: 0x00016D1C File Offset: 0x00014F1C
		public unsafe HakureiFestivalMap.ViewLabel viewLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_viewLabel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_viewLabel)) = value;
			}
		}

		// Token: 0x17000D7E RID: 3454
		// (get) Token: 0x060026B9 RID: 9913 RVA: 0x0012003C File Offset: 0x0011E23C
		// (set) Token: 0x060026BA RID: 9914 RVA: 0x00016D37 File Offset: 0x00014F37
		public unsafe Vector2 worldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_worldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet_Behaviour.NativeFieldInfoPtr_worldPosition)) = value;
			}
		}

		// Token: 0x040019C3 RID: 6595
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040019C4 RID: 6596
		private static readonly IntPtr NativeFieldInfoPtr_open;

		// Token: 0x040019C5 RID: 6597
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x040019C6 RID: 6598
		private static readonly IntPtr NativeFieldInfoPtr_viewLabel;

		// Token: 0x040019C7 RID: 6599
		private static readonly IntPtr NativeFieldInfoPtr_worldPosition;

		// Token: 0x040019C8 RID: 6600
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019C9 RID: 6601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
