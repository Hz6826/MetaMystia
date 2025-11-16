using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001DB RID: 475
	public class COM_LogicBranch_SchedulerNodeFinished : PlayableAsset
	{
		// Token: 0x06003C19 RID: 15385 RVA: 0x0016B058 File Offset: 0x00169258
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_SchedulerNodeFinished()
		{
			Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "COM_LogicBranch_SchedulerNodeFinished");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished>.NativeClassPtr);
			COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_nodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished>.NativeClassPtr, "nodeLabel");
			COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_nodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished>.NativeClassPtr, "nodeType");
			COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_trueAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished>.NativeClassPtr, "trueAddFrames");
			COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_falseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished>.NativeClassPtr, "falseAddFrames");
			COM_LogicBranch_SchedulerNodeFinished.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished>.NativeClassPtr, 100674467);
			COM_LogicBranch_SchedulerNodeFinished.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished>.NativeClassPtr, 100674468);
		}

		// Token: 0x06003C1A RID: 15386 RVA: 0x0016B100 File Offset: 0x00169300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136667, XrefRangeEnd = 136686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_SchedulerNodeFinished.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x0016B168 File Offset: 0x00169368
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_SchedulerNodeFinished() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_SchedulerNodeFinished.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C1C RID: 15388 RVA: 0x00021BE5 File Offset: 0x0001FDE5
		public COM_LogicBranch_SchedulerNodeFinished(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x0016B1A4 File Offset: 0x001693A4
		// (set) Token: 0x06003C1E RID: 15390 RVA: 0x00021BEE File Offset: 0x0001FDEE
		public unsafe string nodeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_nodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_nodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06003C1F RID: 15391 RVA: 0x0016B1CC File Offset: 0x001693CC
		// (set) Token: 0x06003C20 RID: 15392 RVA: 0x00021C0D File Offset: 0x0001FE0D
		public unsafe SchedulerNode.NodeType nodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_nodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_nodeType)) = value;
			}
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x0016B1F4 File Offset: 0x001693F4
		// (set) Token: 0x06003C22 RID: 15394 RVA: 0x00021C28 File Offset: 0x0001FE28
		public unsafe int trueAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_trueAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_trueAddFrames)) = value;
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x0016B21C File Offset: 0x0016941C
		// (set) Token: 0x06003C24 RID: 15396 RVA: 0x00021C43 File Offset: 0x0001FE43
		public unsafe int falseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_falseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished.NativeFieldInfoPtr_falseAddFrames)) = value;
			}
		}

		// Token: 0x0400285E RID: 10334
		private static readonly IntPtr NativeFieldInfoPtr_nodeLabel;

		// Token: 0x0400285F RID: 10335
		private static readonly IntPtr NativeFieldInfoPtr_nodeType;

		// Token: 0x04002860 RID: 10336
		private static readonly IntPtr NativeFieldInfoPtr_trueAddFrames;

		// Token: 0x04002861 RID: 10337
		private static readonly IntPtr NativeFieldInfoPtr_falseAddFrames;

		// Token: 0x04002862 RID: 10338
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04002863 RID: 10339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
