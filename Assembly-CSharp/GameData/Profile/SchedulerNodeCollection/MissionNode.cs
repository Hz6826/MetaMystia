using System;
using GameData.Core.Collections;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Profile.SchedulerNodeCollection
{
	// Token: 0x02000334 RID: 820
	public class MissionNode : SchedulerNode
	{
		// Token: 0x060060F3 RID: 24819 RVA: 0x001E21C4 File Offset: 0x001E03C4
		// Note: this type is marked as 'beforefieldinit'.
		static MissionNode()
		{
			Il2CppClassPointerStore<MissionNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile.SchedulerNodeCollection", "MissionNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionNode>.NativeClassPtr);
			MissionNode.NativeFieldInfoPtr_isTimedMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "isTimedMission");
			MissionNode.NativeFieldInfoPtr_loopedMission = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "loopedMission");
			MissionNode.NativeFieldInfoPtr_missionTimeLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "missionTimeLimit");
			MissionNode.NativeFieldInfoPtr_missionFailedEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "missionFailedEvent");
			MissionNode.NativeFieldInfoPtr_missionFailedAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "missionFailedAction");
			MissionNode.NativeFieldInfoPtr_hasSender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "hasSender");
			MissionNode.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "sender");
			MissionNode.NativeFieldInfoPtr_hasReciever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "hasReciever");
			MissionNode.NativeFieldInfoPtr_reciever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "reciever");
			MissionNode.NativeFieldInfoPtr_hideReciever = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "hideReciever");
			MissionNode.NativeFieldInfoPtr_finishCondition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "finishCondition");
			MissionNode.NativeFieldInfoPtr_missionFinishEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "missionFinishEvent");
			MissionNode.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, 100683291);
			MissionNode.NativeMethodInfoPtr_PostIntializeClone_Protected_Virtual_Void_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, 100683292);
			MissionNode.NativeMethodInfoPtr_InternalGetNodeType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, 100683293);
			MissionNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, 100683294);
		}

		// Token: 0x060060F4 RID: 24820 RVA: 0x001E2334 File Offset: 0x001E0534
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43557, RefRangeEnd = 43560, XrefRangeStart = 43557, XrefRangeEnd = 43560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SchedulerNode.NodeType GetNodeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissionNode.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060F5 RID: 24821 RVA: 0x001E237C File Offset: 0x001E057C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240497, XrefRangeEnd = 240516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostIntializeClone(SchedulerNode instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissionNode.NativeMethodInfoPtr_PostIntializeClone_Protected_Virtual_Void_SchedulerNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060F6 RID: 24822 RVA: 0x001E23CC File Offset: 0x001E05CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240516, XrefRangeEnd = 240522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type InternalGetNodeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissionNode.NativeMethodInfoPtr_InternalGetNodeType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060060F7 RID: 24823 RVA: 0x001E2418 File Offset: 0x001E0618
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240522, XrefRangeEnd = 240523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissionNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060F8 RID: 24824 RVA: 0x000348AB File Offset: 0x00032AAB
		public MissionNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002169 RID: 8553
		// (get) Token: 0x060060F9 RID: 24825 RVA: 0x001E2454 File Offset: 0x001E0654
		// (set) Token: 0x060060FA RID: 24826 RVA: 0x000348B4 File Offset: 0x00032AB4
		public unsafe bool isTimedMission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_isTimedMission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_isTimedMission)) = value;
			}
		}

		// Token: 0x1700216A RID: 8554
		// (get) Token: 0x060060FB RID: 24827 RVA: 0x001E247C File Offset: 0x001E067C
		// (set) Token: 0x060060FC RID: 24828 RVA: 0x000348CF File Offset: 0x00032ACF
		public unsafe bool loopedMission
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_loopedMission);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_loopedMission)) = value;
			}
		}

		// Token: 0x1700216B RID: 8555
		// (get) Token: 0x060060FD RID: 24829 RVA: 0x001E24A4 File Offset: 0x001E06A4
		// (set) Token: 0x060060FE RID: 24830 RVA: 0x000348EA File Offset: 0x00032AEA
		public SchedulerNode.Trigger missionTimeLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_missionTimeLimit);
				return new SchedulerNode.Trigger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_missionTimeLimit), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x060060FF RID: 24831 RVA: 0x001E24D4 File Offset: 0x001E06D4
		// (set) Token: 0x06006100 RID: 24832 RVA: 0x00034918 File Offset: 0x00032B18
		public SchedulerNode.Event missionFailedEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_missionFailedEvent);
				return new SchedulerNode.Event(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_missionFailedEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06006101 RID: 24833 RVA: 0x001E2504 File Offset: 0x001E0704
		// (set) Token: 0x06006102 RID: 24834 RVA: 0x00034946 File Offset: 0x00032B46
		public unsafe MissionNode.MissionFailedAction missionFailedAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_missionFailedAction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_missionFailedAction)) = value;
			}
		}

		// Token: 0x1700216E RID: 8558
		// (get) Token: 0x06006103 RID: 24835 RVA: 0x001E252C File Offset: 0x001E072C
		// (set) Token: 0x06006104 RID: 24836 RVA: 0x00034961 File Offset: 0x00032B61
		public unsafe bool hasSender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_hasSender);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_hasSender)) = value;
			}
		}

		// Token: 0x1700216F RID: 8559
		// (get) Token: 0x06006105 RID: 24837 RVA: 0x001E2554 File Offset: 0x001E0754
		// (set) Token: 0x06006106 RID: 24838 RVA: 0x0003497C File Offset: 0x00032B7C
		public unsafe string sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_sender);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_sender), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002170 RID: 8560
		// (get) Token: 0x06006107 RID: 24839 RVA: 0x001E257C File Offset: 0x001E077C
		// (set) Token: 0x06006108 RID: 24840 RVA: 0x0003499B File Offset: 0x00032B9B
		public unsafe bool hasReciever
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_hasReciever);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_hasReciever)) = value;
			}
		}

		// Token: 0x17002171 RID: 8561
		// (get) Token: 0x06006109 RID: 24841 RVA: 0x001E25A4 File Offset: 0x001E07A4
		// (set) Token: 0x0600610A RID: 24842 RVA: 0x000349B6 File Offset: 0x00032BB6
		public unsafe string reciever
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_reciever);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_reciever), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002172 RID: 8562
		// (get) Token: 0x0600610B RID: 24843 RVA: 0x001E25CC File Offset: 0x001E07CC
		// (set) Token: 0x0600610C RID: 24844 RVA: 0x000349D5 File Offset: 0x00032BD5
		public unsafe bool hideReciever
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_hideReciever);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_hideReciever)) = value;
			}
		}

		// Token: 0x17002173 RID: 8563
		// (get) Token: 0x0600610D RID: 24845 RVA: 0x001E25F4 File Offset: 0x001E07F4
		// (set) Token: 0x0600610E RID: 24846 RVA: 0x000349F0 File Offset: 0x00032BF0
		public unsafe Il2CppReferenceArray<MissionNode.FinishCondition> finishCondition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_finishCondition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MissionNode.FinishCondition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_finishCondition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002174 RID: 8564
		// (get) Token: 0x0600610F RID: 24847 RVA: 0x001E2624 File Offset: 0x001E0824
		// (set) Token: 0x06006110 RID: 24848 RVA: 0x00034A0F File Offset: 0x00032C0F
		public SchedulerNode.Event missionFinishEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_missionFinishEvent);
				return new SchedulerNode.Event(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.NativeFieldInfoPtr_missionFinishEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x0400403A RID: 16442
		private static readonly IntPtr NativeFieldInfoPtr_isTimedMission;

		// Token: 0x0400403B RID: 16443
		private static readonly IntPtr NativeFieldInfoPtr_loopedMission;

		// Token: 0x0400403C RID: 16444
		private static readonly IntPtr NativeFieldInfoPtr_missionTimeLimit;

		// Token: 0x0400403D RID: 16445
		private static readonly IntPtr NativeFieldInfoPtr_missionFailedEvent;

		// Token: 0x0400403E RID: 16446
		private static readonly IntPtr NativeFieldInfoPtr_missionFailedAction;

		// Token: 0x0400403F RID: 16447
		private static readonly IntPtr NativeFieldInfoPtr_hasSender;

		// Token: 0x04004040 RID: 16448
		private static readonly IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x04004041 RID: 16449
		private static readonly IntPtr NativeFieldInfoPtr_hasReciever;

		// Token: 0x04004042 RID: 16450
		private static readonly IntPtr NativeFieldInfoPtr_reciever;

		// Token: 0x04004043 RID: 16451
		private static readonly IntPtr NativeFieldInfoPtr_hideReciever;

		// Token: 0x04004044 RID: 16452
		private static readonly IntPtr NativeFieldInfoPtr_finishCondition;

		// Token: 0x04004045 RID: 16453
		private static readonly IntPtr NativeFieldInfoPtr_missionFinishEvent;

		// Token: 0x04004046 RID: 16454
		private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeType_0;

		// Token: 0x04004047 RID: 16455
		private static readonly IntPtr NativeMethodInfoPtr_PostIntializeClone_Protected_Virtual_Void_SchedulerNode_0;

		// Token: 0x04004048 RID: 16456
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNodeType_Protected_Virtual_Type_0;

		// Token: 0x04004049 RID: 16457
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D8B RID: 3467
		public enum MissionFailedAction
		{
			// Token: 0x04009D44 RID: 40260
			BackToMainMenu,
			// Token: 0x04009D45 RID: 40261
			Rewind,
			// Token: 0x04009D46 RID: 40262
			None
		}

		// Token: 0x02000D8C RID: 3468
		[Serializable]
		public sealed class FinishCondition : ValueType
		{
			// Token: 0x0600F6E7 RID: 63207 RVA: 0x003A3FB8 File Offset: 0x003A21B8
			// Note: this type is marked as 'beforefieldinit'.
			static FinishCondition()
			{
				Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MissionNode>.NativeClassPtr, "FinishCondition");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr);
				MissionNode.FinishCondition.NativeFieldInfoPtr_conditionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "conditionType");
				MissionNode.FinishCondition.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "amount");
				MissionNode.FinishCondition.NativeFieldInfoPtr_tag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "tag");
				MissionNode.FinishCondition.NativeFieldInfoPtr_tags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "tags");
				MissionNode.FinishCondition.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "label");
				MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "additionalString");
				MissionNode.FinishCondition.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "product");
				MissionNode.FinishCondition.NativeFieldInfoPtr_sellableType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "sellableType");
				MissionNode.FinishCondition.NativeFieldInfoPtr_valify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "valify");
				MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "additionalString2");
				MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "additionalString3");
				MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "additionalString4");
				MissionNode.FinishCondition.NativeFieldInfoPtr_labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "labels");
				MissionNode.FinishCondition.NativeFieldInfoPtr_labelKeyValuePairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "labelKeyValuePairs");
				MissionNode.FinishCondition.NativeFieldInfoPtr_contradictionCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "contradictionCheck");
				MissionNode.FinishCondition.NativeFieldInfoPtr_missionLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "missionLabel");
				MissionNode.FinishCondition.NativeMethodInfoPtr_SetMissionLabel_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683295);
				MissionNode.FinishCondition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683296);
				MissionNode.FinishCondition.NativeMethodInfoPtr_GetText_Public_String_MissionStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683297);
				MissionNode.FinishCondition.NativeMethodInfoPtr_GetText_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683298);
				MissionNode.FinishCondition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683299);
				MissionNode.FinishCondition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683300);
				MissionNode.FinishCondition.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FinishCondition_FinishCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683301);
				MissionNode.FinishCondition.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FinishCondition_FinishCondition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683302);
				MissionNode.FinishCondition.NativeMethodInfoPtr_Method_Internal_Static_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683303);
				MissionNode.FinishCondition.NativeMethodInfoPtr_Method_Internal_Static_String_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683304);
				MissionNode.FinishCondition.NativeMethodInfoPtr_Method_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683305);
				MissionNode.FinishCondition.NativeMethodInfoPtr_Method_Internal_Static_String_String_String_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, 100683306);
			}

			// Token: 0x0600F6E8 RID: 63208 RVA: 0x003A4214 File Offset: 0x003A2414
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetMissionLabel(string missionLabel)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(missionLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_SetMissionLabel_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600F6E9 RID: 63209 RVA: 0x003A425C File Offset: 0x003A245C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239975, XrefRangeEnd = 240148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F6EA RID: 63210 RVA: 0x003A4298 File Offset: 0x003A2498
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 240178, RefRangeEnd = 240180, XrefRangeStart = 240148, XrefRangeEnd = 240178, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetText(RunTimeScheduler.MissionStatus missionStatus)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref missionStatus;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_GetText_Public_String_MissionStatus_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F6EB RID: 63211 RVA: 0x003A42E4 File Offset: 0x003A24E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240180, XrefRangeEnd = 240386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string GetText()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_GetText_Public_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F6EC RID: 63212 RVA: 0x003A4320 File Offset: 0x003A2520
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 240401, RefRangeEnd = 240403, XrefRangeStart = 240386, XrefRangeEnd = 240401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool Equals(Object obj)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6ED RID: 63213 RVA: 0x003A4374 File Offset: 0x003A2574
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240403, XrefRangeEnd = 240440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetHashCode()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6EE RID: 63214 RVA: 0x003A43B8 File Offset: 0x003A25B8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 240444, RefRangeEnd = 240446, XrefRangeStart = 240440, XrefRangeEnd = 240444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator ==(MissionNode.FinishCondition left, MissionNode.FinishCondition right)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FinishCondition_FinishCondition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6EF RID: 63215 RVA: 0x003A4418 File Offset: 0x003A2618
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240446, XrefRangeEnd = 240450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static bool operator !=(MissionNode.FinishCondition left, MissionNode.FinishCondition right)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(left));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(right));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FinishCondition_FinishCondition_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600F6F0 RID: 63216 RVA: 0x003A4478 File Offset: 0x003A2678
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 240485, RefRangeEnd = 240487, XrefRangeStart = 240450, XrefRangeEnd = 240485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Method_Internal_Static_String_String_String_0(string text, string colorLabel)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(colorLabel);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_Method_Internal_Static_String_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F6F1 RID: 63217 RVA: 0x003A44C8 File Offset: 0x003A26C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240487, XrefRangeEnd = 240492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Method_Internal_Static_String_String_PDM_0(string text)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_Method_Internal_Static_String_String_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F6F2 RID: 63218 RVA: 0x003A4504 File Offset: 0x003A2704
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Method_Internal_Static_String_String_0(string key)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_Method_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F6F3 RID: 63219 RVA: 0x003A4540 File Offset: 0x003A2740
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 240492, XrefRangeEnd = 240497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string Method_Internal_Static_String_String_String_PDM_0(string key, string data)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.NativeMethodInfoPtr_Method_Internal_Static_String_String_String_PDM_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600F6F4 RID: 63220 RVA: 0x000848AF File Offset: 0x00082AAF
			public FinishCondition(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600F6F5 RID: 63221 RVA: 0x000848B8 File Offset: 0x00082AB8
			public FinishCondition() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr))
			{
			}

			// Token: 0x1700503A RID: 20538
			// (get) Token: 0x0600F6F6 RID: 63222 RVA: 0x003A4590 File Offset: 0x003A2790
			// (set) Token: 0x0600F6F7 RID: 63223 RVA: 0x000848CA File Offset: 0x00082ACA
			public unsafe MissionNode.FinishCondition.ConditionType conditionType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_conditionType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_conditionType)) = value;
				}
			}

			// Token: 0x1700503B RID: 20539
			// (get) Token: 0x0600F6F8 RID: 63224 RVA: 0x003A45B8 File Offset: 0x003A27B8
			// (set) Token: 0x0600F6F9 RID: 63225 RVA: 0x000848E5 File Offset: 0x00082AE5
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x1700503C RID: 20540
			// (get) Token: 0x0600F6FA RID: 63226 RVA: 0x003A45E0 File Offset: 0x003A27E0
			// (set) Token: 0x0600F6FB RID: 63227 RVA: 0x00084900 File Offset: 0x00082B00
			public unsafe int tag
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_tag);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_tag)) = value;
				}
			}

			// Token: 0x1700503D RID: 20541
			// (get) Token: 0x0600F6FC RID: 63228 RVA: 0x003A4608 File Offset: 0x003A2808
			// (set) Token: 0x0600F6FD RID: 63229 RVA: 0x0008491B File Offset: 0x00082B1B
			public unsafe Il2CppStructArray<int> tags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_tags);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_tags), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700503E RID: 20542
			// (get) Token: 0x0600F6FE RID: 63230 RVA: 0x003A4638 File Offset: 0x003A2838
			// (set) Token: 0x0600F6FF RID: 63231 RVA: 0x0008493A File Offset: 0x00082B3A
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700503F RID: 20543
			// (get) Token: 0x0600F700 RID: 63232 RVA: 0x003A4660 File Offset: 0x003A2860
			// (set) Token: 0x0600F701 RID: 63233 RVA: 0x00084959 File Offset: 0x00082B59
			public unsafe string additionalString
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005040 RID: 20544
			// (get) Token: 0x0600F702 RID: 63234 RVA: 0x003A4688 File Offset: 0x003A2888
			// (set) Token: 0x0600F703 RID: 63235 RVA: 0x00084978 File Offset: 0x00082B78
			public Product product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_product);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17005041 RID: 20545
			// (get) Token: 0x0600F704 RID: 63236 RVA: 0x003A46B8 File Offset: 0x003A28B8
			// (set) Token: 0x0600F705 RID: 63237 RVA: 0x000849A6 File Offset: 0x00082BA6
			public unsafe Sellable.SellableType sellableType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_sellableType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_sellableType)) = value;
				}
			}

			// Token: 0x17005042 RID: 20546
			// (get) Token: 0x0600F706 RID: 63238 RVA: 0x003A46E0 File Offset: 0x003A28E0
			// (set) Token: 0x0600F707 RID: 63239 RVA: 0x000849C1 File Offset: 0x00082BC1
			public unsafe bool valify
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_valify);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_valify)) = value;
				}
			}

			// Token: 0x17005043 RID: 20547
			// (get) Token: 0x0600F708 RID: 63240 RVA: 0x003A4708 File Offset: 0x003A2908
			// (set) Token: 0x0600F709 RID: 63241 RVA: 0x000849DC File Offset: 0x00082BDC
			public unsafe string additionalString2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString2);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString2), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005044 RID: 20548
			// (get) Token: 0x0600F70A RID: 63242 RVA: 0x003A4730 File Offset: 0x003A2930
			// (set) Token: 0x0600F70B RID: 63243 RVA: 0x000849FB File Offset: 0x00082BFB
			public unsafe string additionalString3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005045 RID: 20549
			// (get) Token: 0x0600F70C RID: 63244 RVA: 0x003A4758 File Offset: 0x003A2958
			// (set) Token: 0x0600F70D RID: 63245 RVA: 0x00084A1A File Offset: 0x00082C1A
			public unsafe string additionalString4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString4);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_additionalString4), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17005046 RID: 20550
			// (get) Token: 0x0600F70E RID: 63246 RVA: 0x003A4780 File Offset: 0x003A2980
			// (set) Token: 0x0600F70F RID: 63247 RVA: 0x00084A39 File Offset: 0x00082C39
			public unsafe Il2CppStringArray labels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_labels);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_labels), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005047 RID: 20551
			// (get) Token: 0x0600F710 RID: 63248 RVA: 0x003A47B0 File Offset: 0x003A29B0
			// (set) Token: 0x0600F711 RID: 63249 RVA: 0x00084A58 File Offset: 0x00082C58
			public unsafe Il2CppReferenceArray<MissionNode.FinishCondition.KeyValuePair> labelKeyValuePairs
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_labelKeyValuePairs);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MissionNode.FinishCondition.KeyValuePair>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_labelKeyValuePairs), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005048 RID: 20552
			// (get) Token: 0x0600F712 RID: 63250 RVA: 0x003A47E0 File Offset: 0x003A29E0
			// (set) Token: 0x0600F713 RID: 63251 RVA: 0x00084A77 File Offset: 0x00082C77
			public unsafe bool contradictionCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_contradictionCheck);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_contradictionCheck)) = value;
				}
			}

			// Token: 0x17005049 RID: 20553
			// (get) Token: 0x0600F714 RID: 63252 RVA: 0x003A4808 File Offset: 0x003A2A08
			// (set) Token: 0x0600F715 RID: 63253 RVA: 0x00084A92 File Offset: 0x00082C92
			public unsafe string missionLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_missionLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.NativeFieldInfoPtr_missionLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009D47 RID: 40263
			private static readonly IntPtr NativeFieldInfoPtr_conditionType;

			// Token: 0x04009D48 RID: 40264
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04009D49 RID: 40265
			private static readonly IntPtr NativeFieldInfoPtr_tag;

			// Token: 0x04009D4A RID: 40266
			private static readonly IntPtr NativeFieldInfoPtr_tags;

			// Token: 0x04009D4B RID: 40267
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04009D4C RID: 40268
			private static readonly IntPtr NativeFieldInfoPtr_additionalString;

			// Token: 0x04009D4D RID: 40269
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04009D4E RID: 40270
			private static readonly IntPtr NativeFieldInfoPtr_sellableType;

			// Token: 0x04009D4F RID: 40271
			private static readonly IntPtr NativeFieldInfoPtr_valify;

			// Token: 0x04009D50 RID: 40272
			private static readonly IntPtr NativeFieldInfoPtr_additionalString2;

			// Token: 0x04009D51 RID: 40273
			private static readonly IntPtr NativeFieldInfoPtr_additionalString3;

			// Token: 0x04009D52 RID: 40274
			private static readonly IntPtr NativeFieldInfoPtr_additionalString4;

			// Token: 0x04009D53 RID: 40275
			private static readonly IntPtr NativeFieldInfoPtr_labels;

			// Token: 0x04009D54 RID: 40276
			private static readonly IntPtr NativeFieldInfoPtr_labelKeyValuePairs;

			// Token: 0x04009D55 RID: 40277
			private static readonly IntPtr NativeFieldInfoPtr_contradictionCheck;

			// Token: 0x04009D56 RID: 40278
			private static readonly IntPtr NativeFieldInfoPtr_missionLabel;

			// Token: 0x04009D57 RID: 40279
			private static readonly IntPtr NativeMethodInfoPtr_SetMissionLabel_Public_Void_String_0;

			// Token: 0x04009D58 RID: 40280
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x04009D59 RID: 40281
			private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_String_MissionStatus_0;

			// Token: 0x04009D5A RID: 40282
			private static readonly IntPtr NativeMethodInfoPtr_GetText_Public_String_0;

			// Token: 0x04009D5B RID: 40283
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

			// Token: 0x04009D5C RID: 40284
			private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

			// Token: 0x04009D5D RID: 40285
			private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_FinishCondition_FinishCondition_0;

			// Token: 0x04009D5E RID: 40286
			private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_FinishCondition_FinishCondition_0;

			// Token: 0x04009D5F RID: 40287
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_String_String_0;

			// Token: 0x04009D60 RID: 40288
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_String_PDM_0;

			// Token: 0x04009D61 RID: 40289
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_String_0;

			// Token: 0x04009D62 RID: 40290
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Static_String_String_String_PDM_0;

			// Token: 0x0200109F RID: 4255
			public enum CharacterType
			{
				// Token: 0x0400B79E RID: 47006
				Normal,
				// Token: 0x0400B79F RID: 47007
				Special
			}

			// Token: 0x020010A0 RID: 4256
			public enum ConditionType
			{
				// Token: 0x0400B7A1 RID: 47009
				BillRepayment,
				// Token: 0x0400B7A2 RID: 47010
				TalkWithCharacter,
				// Token: 0x0400B7A3 RID: 47011
				InspectInteractable,
				// Token: 0x0400B7A4 RID: 47012
				SubmitItem,
				// Token: 0x0400B7A5 RID: 47013
				ServeInWork,
				// Token: 0x0400B7A6 RID: 47014
				SubmitByTag,
				// Token: 0x0400B7A7 RID: 47015
				SubmitByTags,
				// Token: 0x0400B7A8 RID: 47016
				SellInWork,
				// Token: 0x0400B7A9 RID: 47017
				SubmitByIngredients,
				// Token: 0x0400B7AA RID: 47018
				CompleteSpecifiedFollowingTasks,
				// Token: 0x0400B7AB RID: 47019
				CompleteSpecifiedFollowingTasksSubCondition,
				// Token: 0x0400B7AC RID: 47020
				ReachTargetCharacterKisunaLevel,
				// Token: 0x0400B7AD RID: 47021
				FakeMission,
				// Token: 0x0400B7AE RID: 47022
				SubmitByAnyOneTag,
				// Token: 0x0400B7AF RID: 47023
				CompleteSpecifiedFollowingEvents,
				// Token: 0x0400B7B0 RID: 47024
				SubmitByLevel
			}

			// Token: 0x020010A1 RID: 4257
			[Serializable]
			public sealed class KeyValuePair : ValueType
			{
				// Token: 0x060121F6 RID: 74230 RVA: 0x00422908 File Offset: 0x00420B08
				// Note: this type is marked as 'beforefieldinit'.
				static KeyValuePair()
				{
					Il2CppClassPointerStore<MissionNode.FinishCondition.KeyValuePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "KeyValuePair");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionNode.FinishCondition.KeyValuePair>.NativeClassPtr);
					MissionNode.FinishCondition.KeyValuePair.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.KeyValuePair>.NativeClassPtr, "Key");
					MissionNode.FinishCondition.KeyValuePair.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.KeyValuePair>.NativeClassPtr, "Value");
				}

				// Token: 0x060121F7 RID: 74231 RVA: 0x0009D754 File Offset: 0x0009B954
				public KeyValuePair(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x060121F8 RID: 74232 RVA: 0x0009D75D File Offset: 0x0009B95D
				public KeyValuePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionNode.FinishCondition.KeyValuePair>.NativeClassPtr))
				{
				}

				// Token: 0x17005EA8 RID: 24232
				// (get) Token: 0x060121F9 RID: 74233 RVA: 0x0042295C File Offset: 0x00420B5C
				// (set) Token: 0x060121FA RID: 74234 RVA: 0x0009D76F File Offset: 0x0009B96F
				public unsafe string Key
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.KeyValuePair.NativeFieldInfoPtr_Key);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.KeyValuePair.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17005EA9 RID: 24233
				// (get) Token: 0x060121FB RID: 74235 RVA: 0x00422984 File Offset: 0x00420B84
				// (set) Token: 0x060121FC RID: 74236 RVA: 0x0009D78E File Offset: 0x0009B98E
				public unsafe string Value
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.KeyValuePair.NativeFieldInfoPtr_Value);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.KeyValuePair.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400B7B1 RID: 47025
				private static readonly IntPtr NativeFieldInfoPtr_Key;

				// Token: 0x0400B7B2 RID: 47026
				private static readonly IntPtr NativeFieldInfoPtr_Value;
			}

			// Token: 0x020010A2 RID: 4258
			[ObfuscatedName("GameData.Profile.SchedulerNodeCollection.MissionNode+FinishCondition+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060121FD RID: 74237 RVA: 0x004229AC File Offset: 0x00420BAC
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr);
					MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, "<>9");
					MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__19_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, "<>9__19_0");
					MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, "<>9__19_1");
					MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, "<>9__21_2");
					MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, "<>9__21_3");
					MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, "<>9__21_4");
					MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, "<>9__21_5");
					MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, "<>9__21_6");
					MissionNode.FinishCondition.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, 100683308);
					MissionNode.FinishCondition.__c.NativeMethodInfoPtr__ToString_b__19_0_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, 100683309);
					MissionNode.FinishCondition.__c.NativeMethodInfoPtr__ToString_b__19_1_Internal_String_KeyValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, 100683310);
					MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_2_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, 100683311);
					MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_3_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, 100683312);
					MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_4_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, 100683313);
					MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_5_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, 100683314);
					MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_6_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr, 100683315);
				}

				// Token: 0x060121FE RID: 74238 RVA: 0x00422B18 File Offset: 0x00420D18
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionNode.FinishCondition.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060121FF RID: 74239 RVA: 0x00422B54 File Offset: 0x00420D54
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239934, XrefRangeEnd = 239937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _ToString_b__19_0(string x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c.NativeMethodInfoPtr__ToString_b__19_0_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012200 RID: 74240 RVA: 0x00422B9C File Offset: 0x00420D9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239937, XrefRangeEnd = 239938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _ToString_b__19_1(MissionNode.FinishCondition.KeyValuePair x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c.NativeMethodInfoPtr__ToString_b__19_1_Internal_String_KeyValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012201 RID: 74241 RVA: 0x00422BEC File Offset: 0x00420DEC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__21_2(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_2_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012202 RID: 74242 RVA: 0x00422C30 File Offset: 0x00420E30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__21_3(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_3_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012203 RID: 74243 RVA: 0x00422C74 File Offset: 0x00420E74
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__21_4(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_4_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012204 RID: 74244 RVA: 0x00422CB8 File Offset: 0x00420EB8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__21_5(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_5_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012205 RID: 74245 RVA: 0x00422CFC File Offset: 0x00420EFC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__21_6(int x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref x;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c.NativeMethodInfoPtr__GetText_b__21_6_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x06012206 RID: 74246 RVA: 0x0009D7AD File Offset: 0x0009B9AD
				public __c(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005EAA RID: 24234
				// (get) Token: 0x06012207 RID: 74247 RVA: 0x00422D40 File Offset: 0x00420F40
				// (set) Token: 0x06012208 RID: 74248 RVA: 0x0009D7B6 File Offset: 0x0009B9B6
				public unsafe static MissionNode.FinishCondition.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MissionNode.FinishCondition.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EAB RID: 24235
				// (get) Token: 0x06012209 RID: 74249 RVA: 0x00422D68 File Offset: 0x00420F68
				// (set) Token: 0x0601220A RID: 74250 RVA: 0x0009D7C8 File Offset: 0x0009B9C8
				public unsafe static Func<string, string> __9__19_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__19_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__19_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EAC RID: 24236
				// (get) Token: 0x0601220B RID: 74251 RVA: 0x00422D90 File Offset: 0x00420F90
				// (set) Token: 0x0601220C RID: 74252 RVA: 0x0009D7DA File Offset: 0x0009B9DA
				public unsafe static Func<MissionNode.FinishCondition.KeyValuePair, string> __9__19_1
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<MissionNode.FinishCondition.KeyValuePair, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EAD RID: 24237
				// (get) Token: 0x0601220D RID: 74253 RVA: 0x00422DB8 File Offset: 0x00420FB8
				// (set) Token: 0x0601220E RID: 74254 RVA: 0x0009D7EC File Offset: 0x0009B9EC
				public unsafe static Func<int, string> __9__21_2
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_2, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_2, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EAE RID: 24238
				// (get) Token: 0x0601220F RID: 74255 RVA: 0x00422DE0 File Offset: 0x00420FE0
				// (set) Token: 0x06012210 RID: 74256 RVA: 0x0009D7FE File Offset: 0x0009B9FE
				public unsafe static Func<int, string> __9__21_3
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_3, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_3, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EAF RID: 24239
				// (get) Token: 0x06012211 RID: 74257 RVA: 0x00422E08 File Offset: 0x00421008
				// (set) Token: 0x06012212 RID: 74258 RVA: 0x0009D810 File Offset: 0x0009BA10
				public unsafe static Func<int, string> __9__21_4
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_4, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_4, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EB0 RID: 24240
				// (get) Token: 0x06012213 RID: 74259 RVA: 0x00422E30 File Offset: 0x00421030
				// (set) Token: 0x06012214 RID: 74260 RVA: 0x0009D822 File Offset: 0x0009BA22
				public unsafe static Func<int, string> __9__21_5
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_5, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_5, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005EB1 RID: 24241
				// (get) Token: 0x06012215 RID: 74261 RVA: 0x00422E58 File Offset: 0x00421058
				// (set) Token: 0x06012216 RID: 74262 RVA: 0x0009D834 File Offset: 0x0009BA34
				public unsafe static Func<int, string> __9__21_6
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_6, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(MissionNode.FinishCondition.__c.NativeFieldInfoPtr___9__21_6, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B7B3 RID: 47027
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x0400B7B4 RID: 47028
				private static readonly IntPtr NativeFieldInfoPtr___9__19_0;

				// Token: 0x0400B7B5 RID: 47029
				private static readonly IntPtr NativeFieldInfoPtr___9__19_1;

				// Token: 0x0400B7B6 RID: 47030
				private static readonly IntPtr NativeFieldInfoPtr___9__21_2;

				// Token: 0x0400B7B7 RID: 47031
				private static readonly IntPtr NativeFieldInfoPtr___9__21_3;

				// Token: 0x0400B7B8 RID: 47032
				private static readonly IntPtr NativeFieldInfoPtr___9__21_4;

				// Token: 0x0400B7B9 RID: 47033
				private static readonly IntPtr NativeFieldInfoPtr___9__21_5;

				// Token: 0x0400B7BA RID: 47034
				private static readonly IntPtr NativeFieldInfoPtr___9__21_6;

				// Token: 0x0400B7BB RID: 47035
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B7BC RID: 47036
				private static readonly IntPtr NativeMethodInfoPtr__ToString_b__19_0_Internal_String_String_0;

				// Token: 0x0400B7BD RID: 47037
				private static readonly IntPtr NativeMethodInfoPtr__ToString_b__19_1_Internal_String_KeyValuePair_0;

				// Token: 0x0400B7BE RID: 47038
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__21_2_Internal_String_Int32_0;

				// Token: 0x0400B7BF RID: 47039
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__21_3_Internal_String_Int32_0;

				// Token: 0x0400B7C0 RID: 47040
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__21_4_Internal_String_Int32_0;

				// Token: 0x0400B7C1 RID: 47041
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__21_5_Internal_String_Int32_0;

				// Token: 0x0400B7C2 RID: 47042
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__21_6_Internal_String_Int32_0;
			}

			// Token: 0x020010A3 RID: 4259
			[ObfuscatedName("GameData.Profile.SchedulerNodeCollection.MissionNode+FinishCondition+<>c__DisplayClass20_0")]
			public sealed class __c__DisplayClass20_0 : Object
			{
				// Token: 0x06012217 RID: 74263 RVA: 0x00422E80 File Offset: 0x00421080
				// Note: this type is marked as 'beforefieldinit'.
				static __c__DisplayClass20_0()
				{
					Il2CppClassPointerStore<MissionNode.FinishCondition.__c__DisplayClass20_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MissionNode.FinishCondition>.NativeClassPtr, "<>c__DisplayClass20_0");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissionNode.FinishCondition.__c__DisplayClass20_0>.NativeClassPtr);
					MissionNode.FinishCondition.__c__DisplayClass20_0.NativeFieldInfoPtr_missionStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c__DisplayClass20_0>.NativeClassPtr, "missionStatus");
					MissionNode.FinishCondition.__c__DisplayClass20_0.NativeFieldInfoPtr_extra = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissionNode.FinishCondition.__c__DisplayClass20_0>.NativeClassPtr, "extra");
					MissionNode.FinishCondition.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c__DisplayClass20_0>.NativeClassPtr, 100683316);
					MissionNode.FinishCondition.__c__DisplayClass20_0.NativeMethodInfoPtr__GetText_b__2_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c__DisplayClass20_0>.NativeClassPtr, 100683317);
					MissionNode.FinishCondition.__c__DisplayClass20_0.NativeMethodInfoPtr__GetText_b__3_Internal_String_KeyValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissionNode.FinishCondition.__c__DisplayClass20_0>.NativeClassPtr, 100683318);
				}

				// Token: 0x06012218 RID: 74264 RVA: 0x00422F10 File Offset: 0x00421110
				[CallerCount(2138)]
				[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c__DisplayClass20_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissionNode.FinishCondition.__c__DisplayClass20_0>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c__DisplayClass20_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06012219 RID: 74265 RVA: 0x00422F4C File Offset: 0x0042114C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239938, XrefRangeEnd = 239956, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__2(string x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c__DisplayClass20_0.NativeMethodInfoPtr__GetText_b__2_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601221A RID: 74266 RVA: 0x00422F94 File Offset: 0x00421194
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239956, XrefRangeEnd = 239975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe string _GetText_b__3(MissionNode.FinishCondition.KeyValuePair x)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissionNode.FinishCondition.__c__DisplayClass20_0.NativeMethodInfoPtr__GetText_b__3_Internal_String_KeyValuePair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}

				// Token: 0x0601221B RID: 74267 RVA: 0x0009D846 File Offset: 0x0009BA46
				public __c__DisplayClass20_0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005EB2 RID: 24242
				// (get) Token: 0x0601221C RID: 74268 RVA: 0x00422FE4 File Offset: 0x004211E4
				// (set) Token: 0x0601221D RID: 74269 RVA: 0x0009D84F File Offset: 0x0009BA4F
				public unsafe RunTimeScheduler.MissionStatus missionStatus
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.__c__DisplayClass20_0.NativeFieldInfoPtr_missionStatus);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.__c__DisplayClass20_0.NativeFieldInfoPtr_missionStatus)) = value;
					}
				}

				// Token: 0x17005EB3 RID: 24243
				// (get) Token: 0x0601221E RID: 74270 RVA: 0x0042300C File Offset: 0x0042120C
				// (set) Token: 0x0601221F RID: 74271 RVA: 0x0009D86A File Offset: 0x0009BA6A
				public unsafe string extra
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.__c__DisplayClass20_0.NativeFieldInfoPtr_extra);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissionNode.FinishCondition.__c__DisplayClass20_0.NativeFieldInfoPtr_extra), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x0400B7C3 RID: 47043
				private static readonly IntPtr NativeFieldInfoPtr_missionStatus;

				// Token: 0x0400B7C4 RID: 47044
				private static readonly IntPtr NativeFieldInfoPtr_extra;

				// Token: 0x0400B7C5 RID: 47045
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x0400B7C6 RID: 47046
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__2_Internal_String_String_0;

				// Token: 0x0400B7C7 RID: 47047
				private static readonly IntPtr NativeMethodInfoPtr__GetText_b__3_Internal_String_KeyValuePair_0;
			}
		}
	}
}
