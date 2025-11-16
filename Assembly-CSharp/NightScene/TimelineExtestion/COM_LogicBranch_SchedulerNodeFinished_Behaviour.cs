using System;
using Common.TimelineExtestion;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E6 RID: 486
	public class COM_LogicBranch_SchedulerNodeFinished_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06003C74 RID: 15476 RVA: 0x0016BF80 File Offset: 0x0016A180
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_SchedulerNodeFinished_Behaviour()
		{
			Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "COM_LogicBranch_SchedulerNodeFinished_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr);
			COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_falseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr, "falseAddFrames");
			COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_nodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr, "nodeLabel");
			COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_nodeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr, "nodeType");
			COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_trueAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr, "trueAddFrames");
			COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr, 100674496);
			COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeMethodInfoPtr_IsFinished_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr, 100674497);
			COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr, 100674498);
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x0016C03C File Offset: 0x0016A23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136820, XrefRangeEnd = 136844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x0016C078 File Offset: 0x0016A278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136844, XrefRangeEnd = 136860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFinished()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeMethodInfoPtr_IsFinished_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x0016C0B4 File Offset: 0x0016A2B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_SchedulerNodeFinished_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_SchedulerNodeFinished_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x00021EA5 File Offset: 0x000200A5
		public COM_LogicBranch_SchedulerNodeFinished_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06003C79 RID: 15481 RVA: 0x0016C0F0 File Offset: 0x0016A2F0
		// (set) Token: 0x06003C7A RID: 15482 RVA: 0x00021EAE File Offset: 0x000200AE
		public unsafe int falseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_falseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_falseAddFrames)) = value;
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x0016C118 File Offset: 0x0016A318
		// (set) Token: 0x06003C7C RID: 15484 RVA: 0x00021EC9 File Offset: 0x000200C9
		public unsafe string nodeLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_nodeLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_nodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x0016C140 File Offset: 0x0016A340
		// (set) Token: 0x06003C7E RID: 15486 RVA: 0x00021EE8 File Offset: 0x000200E8
		public unsafe SchedulerNode.NodeType nodeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_nodeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_nodeType)) = value;
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x06003C7F RID: 15487 RVA: 0x0016C168 File Offset: 0x0016A368
		// (set) Token: 0x06003C80 RID: 15488 RVA: 0x00021F03 File Offset: 0x00020103
		public unsafe int trueAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_trueAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_SchedulerNodeFinished_Behaviour.NativeFieldInfoPtr_trueAddFrames)) = value;
			}
		}

		// Token: 0x0400288D RID: 10381
		private static readonly IntPtr NativeFieldInfoPtr_falseAddFrames;

		// Token: 0x0400288E RID: 10382
		private static readonly IntPtr NativeFieldInfoPtr_nodeLabel;

		// Token: 0x0400288F RID: 10383
		private static readonly IntPtr NativeFieldInfoPtr_nodeType;

		// Token: 0x04002890 RID: 10384
		private static readonly IntPtr NativeFieldInfoPtr_trueAddFrames;

		// Token: 0x04002891 RID: 10385
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04002892 RID: 10386
		private static readonly IntPtr NativeMethodInfoPtr_IsFinished_Private_Boolean_0;

		// Token: 0x04002893 RID: 10387
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
