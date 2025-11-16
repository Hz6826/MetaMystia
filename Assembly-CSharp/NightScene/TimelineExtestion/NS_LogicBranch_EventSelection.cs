using System;
using DayScene.TimelineExtensions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001FE RID: 510
	public class NS_LogicBranch_EventSelection : PlayableAsset
	{
		// Token: 0x06003D19 RID: 15641 RVA: 0x0016DC78 File Offset: 0x0016BE78
		// Note: this type is marked as 'beforefieldinit'.
		static NS_LogicBranch_EventSelection()
		{
			Il2CppClassPointerStore<NS_LogicBranch_EventSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_LogicBranch_EventSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_LogicBranch_EventSelection>.NativeClassPtr);
			NS_LogicBranch_EventSelection.NativeFieldInfoPtr_eventOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_LogicBranch_EventSelection>.NativeClassPtr, "eventOptions");
			NS_LogicBranch_EventSelection.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_EventSelection>.NativeClassPtr, 100674550);
			NS_LogicBranch_EventSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_EventSelection>.NativeClassPtr, 100674551);
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x0016DCE4 File Offset: 0x0016BEE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 137078, XrefRangeEnd = 137091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_LogicBranch_EventSelection.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003D1B RID: 15643 RVA: 0x0016DD4C File Offset: 0x0016BF4C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_LogicBranch_EventSelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_LogicBranch_EventSelection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_LogicBranch_EventSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003D1C RID: 15644 RVA: 0x0002231B File Offset: 0x0002051B
		public NS_LogicBranch_EventSelection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x0016DD88 File Offset: 0x0016BF88
		// (set) Token: 0x06003D1E RID: 15646 RVA: 0x00022324 File Offset: 0x00020524
		public unsafe Il2CppReferenceArray<DS_LogicBranch_EventSelection.EventOption> eventOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_EventSelection.NativeFieldInfoPtr_eventOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DS_LogicBranch_EventSelection.EventOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_EventSelection.NativeFieldInfoPtr_eventOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040028E1 RID: 10465
		private static readonly IntPtr NativeFieldInfoPtr_eventOptions;

		// Token: 0x040028E2 RID: 10466
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x040028E3 RID: 10467
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
