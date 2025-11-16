using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x0200040B RID: 1035
	public class COM_UI_Buttons_Enable : PlayableAsset
	{
		// Token: 0x06007772 RID: 30578 RVA: 0x0022C11C File Offset: 0x0022A31C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_UI_Buttons_Enable()
		{
			Il2CppClassPointerStore<COM_UI_Buttons_Enable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_UI_Buttons_Enable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_UI_Buttons_Enable>.NativeClassPtr);
			COM_UI_Buttons_Enable.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_Buttons_Enable>.NativeClassPtr, 100687577);
			COM_UI_Buttons_Enable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_UI_Buttons_Enable>.NativeClassPtr, 100687578);
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x0022C174 File Offset: 0x0022A374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293218, XrefRangeEnd = 293227, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_UI_Buttons_Enable.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x0022C1DC File Offset: 0x0022A3DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_UI_Buttons_Enable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_UI_Buttons_Enable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_UI_Buttons_Enable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x0004092F File Offset: 0x0003EB2F
		public COM_UI_Buttons_Enable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004EE8 RID: 20200
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EE9 RID: 20201
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
