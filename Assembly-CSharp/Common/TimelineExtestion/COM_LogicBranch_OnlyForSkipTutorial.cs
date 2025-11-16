using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003FE RID: 1022
	public class COM_LogicBranch_OnlyForSkipTutorial : PlayableAsset
	{
		// Token: 0x06007722 RID: 30498 RVA: 0x0022B0E8 File Offset: 0x002292E8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_OnlyForSkipTutorial()
		{
			Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_LogicBranch_OnlyForSkipTutorial");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial>.NativeClassPtr);
			COM_LogicBranch_OnlyForSkipTutorial.NativeFieldInfoPtr_skipSkipTutorialFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial>.NativeClassPtr, "skipSkipTutorialFrames");
			COM_LogicBranch_OnlyForSkipTutorial.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial>.NativeClassPtr, 100687551);
			COM_LogicBranch_OnlyForSkipTutorial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial>.NativeClassPtr, 100687552);
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x0022B154 File Offset: 0x00229354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293055, XrefRangeEnd = 293067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_OnlyForSkipTutorial.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x0022B1BC File Offset: 0x002293BC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_OnlyForSkipTutorial() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_OnlyForSkipTutorial>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_OnlyForSkipTutorial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x00040720 File Offset: 0x0003E920
		public COM_LogicBranch_OnlyForSkipTutorial(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700289B RID: 10395
		// (get) Token: 0x06007726 RID: 30502 RVA: 0x0022B1F8 File Offset: 0x002293F8
		// (set) Token: 0x06007727 RID: 30503 RVA: 0x00040729 File Offset: 0x0003E929
		public unsafe int skipSkipTutorialFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_OnlyForSkipTutorial.NativeFieldInfoPtr_skipSkipTutorialFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_OnlyForSkipTutorial.NativeFieldInfoPtr_skipSkipTutorialFrames)) = value;
			}
		}

		// Token: 0x04004EC0 RID: 20160
		private static readonly IntPtr NativeFieldInfoPtr_skipSkipTutorialFrames;

		// Token: 0x04004EC1 RID: 20161
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004EC2 RID: 20162
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
