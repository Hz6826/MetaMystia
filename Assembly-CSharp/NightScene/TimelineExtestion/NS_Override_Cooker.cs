using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200020B RID: 523
	public class NS_Override_Cooker : PlayableAsset
	{
		// Token: 0x06003D8B RID: 15755 RVA: 0x0016F098 File Offset: 0x0016D298
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Override_Cooker()
		{
			Il2CppClassPointerStore<NS_Override_Cooker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Override_Cooker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Override_Cooker>.NativeClassPtr);
			NS_Override_Cooker.NativeFieldInfoPtr_cookerArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Override_Cooker>.NativeClassPtr, "cookerArray");
			NS_Override_Cooker.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Cooker>.NativeClassPtr, 100674576);
			NS_Override_Cooker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Cooker>.NativeClassPtr, 100674577);
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x0016F104 File Offset: 0x0016D304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137282, XrefRangeEnd = 137295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Override_Cooker.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D8D RID: 15757 RVA: 0x0016F16C File Offset: 0x0016D36C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Override_Cooker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Override_Cooker>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Override_Cooker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x00022705 File Offset: 0x00020905
		public NS_Override_Cooker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001508 RID: 5384
		// (get) Token: 0x06003D8F RID: 15759 RVA: 0x0016F1A8 File Offset: 0x0016D3A8
		// (set) Token: 0x06003D90 RID: 15760 RVA: 0x0002270E File Offset: 0x0002090E
		public unsafe Il2CppStructArray<int> cookerArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Cooker.NativeFieldInfoPtr_cookerArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Cooker.NativeFieldInfoPtr_cookerArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400291A RID: 10522
		private static readonly IntPtr NativeFieldInfoPtr_cookerArray;

		// Token: 0x0400291B RID: 10523
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x0400291C RID: 10524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
