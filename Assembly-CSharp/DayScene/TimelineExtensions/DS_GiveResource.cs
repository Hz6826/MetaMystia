using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x0200014E RID: 334
	public class DS_GiveResource : PlayableAsset
	{
		// Token: 0x060026E1 RID: 9953 RVA: 0x00120644 File Offset: 0x0011E844
		// Note: this type is marked as 'beforefieldinit'.
		static DS_GiveResource()
		{
			Il2CppClassPointerStore<DS_GiveResource>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_GiveResource");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_GiveResource>.NativeClassPtr);
			DS_GiveResource.NativeFieldInfoPtr_resourceCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_GiveResource>.NativeClassPtr, "resourceCode");
			DS_GiveResource.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_GiveResource>.NativeClassPtr, 100670232);
			DS_GiveResource.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_GiveResource>.NativeClassPtr, 100670233);
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x001206B0 File Offset: 0x0011E8B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90679, XrefRangeEnd = 90691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_GiveResource.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x00120718 File Offset: 0x0011E918
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_GiveResource() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_GiveResource>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_GiveResource.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x00016EB8 File Offset: 0x000150B8
		public DS_GiveResource(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x00120754 File Offset: 0x0011E954
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x00016EC1 File Offset: 0x000150C1
		public unsafe int resourceCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_GiveResource.NativeFieldInfoPtr_resourceCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_GiveResource.NativeFieldInfoPtr_resourceCode)) = value;
			}
		}

		// Token: 0x040019DF RID: 6623
		private static readonly IntPtr NativeFieldInfoPtr_resourceCode;

		// Token: 0x040019E0 RID: 6624
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040019E1 RID: 6625
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
