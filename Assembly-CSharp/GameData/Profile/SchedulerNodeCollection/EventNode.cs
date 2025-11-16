using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Profile.SchedulerNodeCollection
{
	// Token: 0x02000333 RID: 819
	public class EventNode : SchedulerNode
	{
		// Token: 0x060060DF RID: 24799 RVA: 0x001E1E78 File Offset: 0x001E0078
		// Note: this type is marked as 'beforefieldinit'.
		static EventNode()
		{
			Il2CppClassPointerStore<EventNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile.SchedulerNodeCollection", "EventNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EventNode>.NativeClassPtr);
			EventNode.NativeFieldInfoPtr_scheduleOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventNode>.NativeClassPtr, "scheduleOnce");
			EventNode.NativeFieldInfoPtr_saveToArchiveOnce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventNode>.NativeClassPtr, "saveToArchiveOnce");
			EventNode.NativeFieldInfoPtr_upgradeShopEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventNode>.NativeClassPtr, "upgradeShopEvent");
			EventNode.NativeFieldInfoPtr_autoCompleteAtDayEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventNode>.NativeClassPtr, "autoCompleteAtDayEnd");
			EventNode.NativeFieldInfoPtr_eventLockMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventNode>.NativeClassPtr, "eventLockMode");
			EventNode.NativeFieldInfoPtr_scheduledEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventNode>.NativeClassPtr, "scheduledEvent");
			EventNode.NativeFieldInfoPtr_disableInNX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EventNode>.NativeClassPtr, "disableInNX");
			EventNode.NativeMethodInfoPtr_PostIntializeClone_Protected_Virtual_Void_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventNode>.NativeClassPtr, 100683287);
			EventNode.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventNode>.NativeClassPtr, 100683288);
			EventNode.NativeMethodInfoPtr_InternalGetNodeType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventNode>.NativeClassPtr, 100683289);
			EventNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EventNode>.NativeClassPtr, 100683290);
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x001E1F84 File Offset: 0x001E0184
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239924, XrefRangeEnd = 239927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostIntializeClone(SchedulerNode instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventNode.NativeMethodInfoPtr_PostIntializeClone_Protected_Virtual_Void_SchedulerNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060E1 RID: 24801 RVA: 0x001E1FD4 File Offset: 0x001E01D4
		[CallerCount(84)]
		[CachedScanResults(RefRangeStart = 43609, RefRangeEnd = 43693, XrefRangeStart = 43609, XrefRangeEnd = 43693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SchedulerNode.NodeType GetNodeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventNode.NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060060E2 RID: 24802 RVA: 0x001E201C File Offset: 0x001E021C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239927, XrefRangeEnd = 239933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type InternalGetNodeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EventNode.NativeMethodInfoPtr_InternalGetNodeType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060060E3 RID: 24803 RVA: 0x001E2068 File Offset: 0x001E0268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239933, XrefRangeEnd = 239934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EventNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EventNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EventNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x000347D2 File Offset: 0x000329D2
		public EventNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x060060E5 RID: 24805 RVA: 0x001E20A4 File Offset: 0x001E02A4
		// (set) Token: 0x060060E6 RID: 24806 RVA: 0x000347DB File Offset: 0x000329DB
		public unsafe bool scheduleOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_scheduleOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_scheduleOnce)) = value;
			}
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x060060E7 RID: 24807 RVA: 0x001E20CC File Offset: 0x001E02CC
		// (set) Token: 0x060060E8 RID: 24808 RVA: 0x000347F6 File Offset: 0x000329F6
		public unsafe bool saveToArchiveOnce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_saveToArchiveOnce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_saveToArchiveOnce)) = value;
			}
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x060060E9 RID: 24809 RVA: 0x001E20F4 File Offset: 0x001E02F4
		// (set) Token: 0x060060EA RID: 24810 RVA: 0x00034811 File Offset: 0x00032A11
		public unsafe bool upgradeShopEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_upgradeShopEvent);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_upgradeShopEvent)) = value;
			}
		}

		// Token: 0x17002165 RID: 8549
		// (get) Token: 0x060060EB RID: 24811 RVA: 0x001E211C File Offset: 0x001E031C
		// (set) Token: 0x060060EC RID: 24812 RVA: 0x0003482C File Offset: 0x00032A2C
		public unsafe bool autoCompleteAtDayEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_autoCompleteAtDayEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_autoCompleteAtDayEnd)) = value;
			}
		}

		// Token: 0x17002166 RID: 8550
		// (get) Token: 0x060060ED RID: 24813 RVA: 0x001E2144 File Offset: 0x001E0344
		// (set) Token: 0x060060EE RID: 24814 RVA: 0x00034847 File Offset: 0x00032A47
		public unsafe EventNode.EventLockMode eventLockMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_eventLockMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_eventLockMode)) = value;
			}
		}

		// Token: 0x17002167 RID: 8551
		// (get) Token: 0x060060EF RID: 24815 RVA: 0x001E216C File Offset: 0x001E036C
		// (set) Token: 0x060060F0 RID: 24816 RVA: 0x00034862 File Offset: 0x00032A62
		public SchedulerNode.ScheduledEvent scheduledEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_scheduledEvent);
				return new SchedulerNode.ScheduledEvent(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_scheduledEvent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002168 RID: 8552
		// (get) Token: 0x060060F1 RID: 24817 RVA: 0x001E219C File Offset: 0x001E039C
		// (set) Token: 0x060060F2 RID: 24818 RVA: 0x00034890 File Offset: 0x00032A90
		public unsafe bool disableInNX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_disableInNX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EventNode.NativeFieldInfoPtr_disableInNX)) = value;
			}
		}

		// Token: 0x0400402F RID: 16431
		private static readonly IntPtr NativeFieldInfoPtr_scheduleOnce;

		// Token: 0x04004030 RID: 16432
		private static readonly IntPtr NativeFieldInfoPtr_saveToArchiveOnce;

		// Token: 0x04004031 RID: 16433
		private static readonly IntPtr NativeFieldInfoPtr_upgradeShopEvent;

		// Token: 0x04004032 RID: 16434
		private static readonly IntPtr NativeFieldInfoPtr_autoCompleteAtDayEnd;

		// Token: 0x04004033 RID: 16435
		private static readonly IntPtr NativeFieldInfoPtr_eventLockMode;

		// Token: 0x04004034 RID: 16436
		private static readonly IntPtr NativeFieldInfoPtr_scheduledEvent;

		// Token: 0x04004035 RID: 16437
		private static readonly IntPtr NativeFieldInfoPtr_disableInNX;

		// Token: 0x04004036 RID: 16438
		private static readonly IntPtr NativeMethodInfoPtr_PostIntializeClone_Protected_Virtual_Void_SchedulerNode_0;

		// Token: 0x04004037 RID: 16439
		private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Virtual_NodeType_0;

		// Token: 0x04004038 RID: 16440
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNodeType_Protected_Virtual_Type_0;

		// Token: 0x04004039 RID: 16441
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000D8A RID: 3466
		public enum EventLockMode
		{
			// Token: 0x04009D40 RID: 40256
			None,
			// Token: 0x04009D41 RID: 40257
			Lock,
			// Token: 0x04009D42 RID: 40258
			Unlock
		}
	}
}
