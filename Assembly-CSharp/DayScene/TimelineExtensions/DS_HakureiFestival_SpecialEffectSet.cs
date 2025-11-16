using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200014F RID: 335
	public class DS_HakureiFestival_SpecialEffectSet : PlayableAsset
	{
		// Token: 0x060026E7 RID: 9959 RVA: 0x0012077C File Offset: 0x0011E97C
		// Note: this type is marked as 'beforefieldinit'.
		static DS_HakureiFestival_SpecialEffectSet()
		{
			Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_HakureiFestival_SpecialEffectSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr);
			DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_viewLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr, "viewLabel");
			DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_open = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr, "open");
			DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr, "worldPosition");
			DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr, "label");
			DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr, "transitionDuration");
			DS_HakureiFestival_SpecialEffectSet.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr, 100670234);
			DS_HakureiFestival_SpecialEffectSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr, 100670235);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00120838 File Offset: 0x0011EA38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90691, XrefRangeEnd = 90712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_HakureiFestival_SpecialEffectSet.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x001208A0 File Offset: 0x0011EAA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_HakureiFestival_SpecialEffectSet() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_HakureiFestival_SpecialEffectSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_HakureiFestival_SpecialEffectSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x00016EDC File Offset: 0x000150DC
		public DS_HakureiFestival_SpecialEffectSet(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x001208DC File Offset: 0x0011EADC
		// (set) Token: 0x060026EC RID: 9964 RVA: 0x00016EE5 File Offset: 0x000150E5
		public unsafe HakureiFestivalMap.ViewLabel viewLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_viewLabel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_viewLabel)) = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x00120904 File Offset: 0x0011EB04
		// (set) Token: 0x060026EE RID: 9966 RVA: 0x00016F00 File Offset: 0x00015100
		public unsafe bool open
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_open);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_open)) = value;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x060026EF RID: 9967 RVA: 0x0012092C File Offset: 0x0011EB2C
		// (set) Token: 0x060026F0 RID: 9968 RVA: 0x00016F1B File Offset: 0x0001511B
		public unsafe Vector2 worldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_worldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_worldPosition)) = value;
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x060026F1 RID: 9969 RVA: 0x00120954 File Offset: 0x0011EB54
		// (set) Token: 0x060026F2 RID: 9970 RVA: 0x00016F36 File Offset: 0x00015136
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x0012097C File Offset: 0x0011EB7C
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x00016F55 File Offset: 0x00015155
		public unsafe float transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_transitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_HakureiFestival_SpecialEffectSet.NativeFieldInfoPtr_transitionDuration)) = value;
			}
		}

		// Token: 0x040019E2 RID: 6626
		private static readonly IntPtr NativeFieldInfoPtr_viewLabel;

		// Token: 0x040019E3 RID: 6627
		private static readonly IntPtr NativeFieldInfoPtr_open;

		// Token: 0x040019E4 RID: 6628
		private static readonly IntPtr NativeFieldInfoPtr_worldPosition;

		// Token: 0x040019E5 RID: 6629
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x040019E6 RID: 6630
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x040019E7 RID: 6631
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040019E8 RID: 6632
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
