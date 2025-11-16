using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001DA RID: 474
	public class COM_LogicBranch_Goto : PlayableAsset
	{
		// Token: 0x06003C13 RID: 15379 RVA: 0x0016AF20 File Offset: 0x00169120
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_Goto()
		{
			Il2CppClassPointerStore<COM_LogicBranch_Goto>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "COM_LogicBranch_Goto");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_Goto>.NativeClassPtr);
			COM_LogicBranch_Goto.NativeFieldInfoPtr_ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_Goto>.NativeClassPtr, "ticks");
			COM_LogicBranch_Goto.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_Goto>.NativeClassPtr, 100674465);
			COM_LogicBranch_Goto.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_Goto>.NativeClassPtr, 100674466);
		}

		// Token: 0x06003C14 RID: 15380 RVA: 0x0016AF8C File Offset: 0x0016918C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136655, XrefRangeEnd = 136667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_Goto.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C15 RID: 15381 RVA: 0x0016AFF4 File Offset: 0x001691F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_Goto() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_Goto>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_Goto.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C16 RID: 15382 RVA: 0x00021BC1 File Offset: 0x0001FDC1
		public COM_LogicBranch_Goto(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06003C17 RID: 15383 RVA: 0x0016B030 File Offset: 0x00169230
		// (set) Token: 0x06003C18 RID: 15384 RVA: 0x00021BCA File Offset: 0x0001FDCA
		public unsafe int ticks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_Goto.NativeFieldInfoPtr_ticks);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_Goto.NativeFieldInfoPtr_ticks)) = value;
			}
		}

		// Token: 0x0400285B RID: 10331
		private static readonly IntPtr NativeFieldInfoPtr_ticks;

		// Token: 0x0400285C RID: 10332
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x0400285D RID: 10333
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
