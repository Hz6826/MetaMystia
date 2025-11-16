using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001FC RID: 508
	public class NS_BackToMainMenu : PlayableAsset
	{
		// Token: 0x06003D0D RID: 15629 RVA: 0x0016DA08 File Offset: 0x0016BC08
		// Note: this type is marked as 'beforefieldinit'.
		static NS_BackToMainMenu()
		{
			Il2CppClassPointerStore<NS_BackToMainMenu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_BackToMainMenu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_BackToMainMenu>.NativeClassPtr);
			NS_BackToMainMenu.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_BackToMainMenu>.NativeClassPtr, 100674546);
			NS_BackToMainMenu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_BackToMainMenu>.NativeClassPtr, 100674547);
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x0016DA60 File Offset: 0x0016BC60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137055, XrefRangeEnd = 137064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_BackToMainMenu.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D0F RID: 15631 RVA: 0x0016DAC8 File Offset: 0x0016BCC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_BackToMainMenu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_BackToMainMenu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_BackToMainMenu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x000222D3 File Offset: 0x000204D3
		public NS_BackToMainMenu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040028DB RID: 10459
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028DC RID: 10460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
