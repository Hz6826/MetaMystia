using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x0200020C RID: 524
	public class NS_Override_Passion : PlayableAsset
	{
		// Token: 0x06003D91 RID: 15761 RVA: 0x0016F1D8 File Offset: 0x0016D3D8
		// Note: this type is marked as 'beforefieldinit'.
		static NS_Override_Passion()
		{
			Il2CppClassPointerStore<NS_Override_Passion>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_Override_Passion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_Override_Passion>.NativeClassPtr);
			NS_Override_Passion.NativeFieldInfoPtr_newPassion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_Override_Passion>.NativeClassPtr, "newPassion");
			NS_Override_Passion.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Passion>.NativeClassPtr, 100674578);
			NS_Override_Passion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_Override_Passion>.NativeClassPtr, 100674579);
		}

		// Token: 0x06003D92 RID: 15762 RVA: 0x0016F244 File Offset: 0x0016D444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137295, XrefRangeEnd = 137307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_Override_Passion.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D93 RID: 15763 RVA: 0x0016F2AC File Offset: 0x0016D4AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_Override_Passion() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_Override_Passion>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_Override_Passion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D94 RID: 15764 RVA: 0x0002272D File Offset: 0x0002092D
		public NS_Override_Passion(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x06003D95 RID: 15765 RVA: 0x0016F2E8 File Offset: 0x0016D4E8
		// (set) Token: 0x06003D96 RID: 15766 RVA: 0x00022736 File Offset: 0x00020936
		public unsafe int newPassion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Passion.NativeFieldInfoPtr_newPassion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_Override_Passion.NativeFieldInfoPtr_newPassion)) = value;
			}
		}

		// Token: 0x0400291D RID: 10525
		private static readonly IntPtr NativeFieldInfoPtr_newPassion;

		// Token: 0x0400291E RID: 10526
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x0400291F RID: 10527
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
