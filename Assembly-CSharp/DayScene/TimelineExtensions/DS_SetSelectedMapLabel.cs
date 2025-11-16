using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200015B RID: 347
	public class DS_SetSelectedMapLabel : PlayableAsset
	{
		// Token: 0x06002783 RID: 10115 RVA: 0x00122044 File Offset: 0x00120244
		// Note: this type is marked as 'beforefieldinit'.
		static DS_SetSelectedMapLabel()
		{
			Il2CppClassPointerStore<DS_SetSelectedMapLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_SetSelectedMapLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_SetSelectedMapLabel>.NativeClassPtr);
			DS_SetSelectedMapLabel.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_SetSelectedMapLabel>.NativeClassPtr, "mapLabel");
			DS_SetSelectedMapLabel.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_SetSelectedMapLabel>.NativeClassPtr, 100670258);
			DS_SetSelectedMapLabel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_SetSelectedMapLabel>.NativeClassPtr, 100670259);
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x001220B0 File Offset: 0x001202B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90917, XrefRangeEnd = 90930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_SetSelectedMapLabel.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x00122118 File Offset: 0x00120318
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_SetSelectedMapLabel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_SetSelectedMapLabel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_SetSelectedMapLabel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00017556 File Offset: 0x00015756
		public DS_SetSelectedMapLabel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x00122154 File Offset: 0x00120354
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x0001755F File Offset: 0x0001575F
		public unsafe string mapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSelectedMapLabel.NativeFieldInfoPtr_mapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_SetSelectedMapLabel.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001A30 RID: 6704
		private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

		// Token: 0x04001A31 RID: 6705
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A32 RID: 6706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
