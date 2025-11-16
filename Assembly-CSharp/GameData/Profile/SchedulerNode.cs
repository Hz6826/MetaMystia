using System;
using System.Runtime.InteropServices;
using Common;
using GameData.Core.Collections.CharacterUtility;
using GameData.Core.Collections.DaySceneUtility.Collections;
using GameData.CoreLanguage;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using NightScene;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;

namespace GameData.Profile
{
	// Token: 0x020002EA RID: 746
	public class SchedulerNode : ScriptableObject
	{
		// Token: 0x06005A19 RID: 23065 RVA: 0x001CC7E0 File Offset: 0x001CA9E0
		// Note: this type is marked as 'beforefieldinit'.
		static SchedulerNode()
		{
			Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "SchedulerNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr);
			SchedulerNode.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "label");
			SchedulerNode.NativeFieldInfoPtr_debugLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "debugLabel");
			SchedulerNode.NativeFieldInfoPtr_rewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "rewards");
			SchedulerNode.NativeFieldInfoPtr_postRewards = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "postRewards");
			SchedulerNode.NativeFieldInfoPtr_postEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "postEvents");
			SchedulerNode.NativeFieldInfoPtr_postMissions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "postMissions");
			SchedulerNode.NativeFieldInfoPtr_postMissionsAfterPerformance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "postMissionsAfterPerformance");
			SchedulerNode.NativeFieldInfoPtr_preNodes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "preNodes");
			SchedulerNode.NativeFieldInfoPtr_missionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "missionType");
			SchedulerNode.NativeMethodInfoPtr_GetNodeType_Public_Abstract_Virtual_New_NodeType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, 100681405);
			SchedulerNode.NativeMethodInfoPtr_PostIntializeClone_Protected_Abstract_Virtual_New_Void_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, 100681406);
			SchedulerNode.NativeMethodInfoPtr_InternalGetNodeType_Protected_Abstract_Virtual_New_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, 100681407);
			SchedulerNode.NativeMethodInfoPtr_Clone_Public_SchedulerNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, 100681408);
			SchedulerNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, 100681409);
			SchedulerNode.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, 100681410);
		}

		// Token: 0x06005A1A RID: 23066 RVA: 0x001CC93C File Offset: 0x001CAB3C
		[CallerCount(0)]
		public unsafe virtual SchedulerNode.NodeType GetNodeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerNode.NativeMethodInfoPtr_GetNodeType_Public_Abstract_Virtual_New_NodeType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A1B RID: 23067 RVA: 0x001CC984 File Offset: 0x001CAB84
		[CallerCount(0)]
		public unsafe virtual void PostIntializeClone(SchedulerNode instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerNode.NativeMethodInfoPtr_PostIntializeClone_Protected_Abstract_Virtual_New_Void_SchedulerNode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x001CC9D4 File Offset: 0x001CABD4
		[CallerCount(0)]
		public unsafe virtual Type InternalGetNodeType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerNode.NativeMethodInfoPtr_InternalGetNodeType_Protected_Abstract_Virtual_New_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x001CCA20 File Offset: 0x001CAC20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219809, XrefRangeEnd = 219859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchedulerNode Clone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.NativeMethodInfoPtr_Clone_Public_SchedulerNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SchedulerNode>(intPtr3) : null;
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x001CCA60 File Offset: 0x001CAC60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SchedulerNode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005A1F RID: 23071 RVA: 0x001CCAA4 File Offset: 0x001CACA4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 219880, RefRangeEnd = 219883, XrefRangeStart = 219859, XrefRangeEnd = 219880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SchedulerNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A20 RID: 23072 RVA: 0x00030A85 File Offset: 0x0002EC85
		public SchedulerNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06005A21 RID: 23073 RVA: 0x001CCAE0 File Offset: 0x001CACE0
		// (set) Token: 0x06005A22 RID: 23074 RVA: 0x00030A8E File Offset: 0x0002EC8E
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06005A23 RID: 23075 RVA: 0x001CCB08 File Offset: 0x001CAD08
		// (set) Token: 0x06005A24 RID: 23076 RVA: 0x00030AAD File Offset: 0x0002ECAD
		public unsafe string debugLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_debugLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_debugLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06005A25 RID: 23077 RVA: 0x001CCB30 File Offset: 0x001CAD30
		// (set) Token: 0x06005A26 RID: 23078 RVA: 0x00030ACC File Offset: 0x0002ECCC
		public unsafe Il2CppReferenceArray<SchedulerNode.Reward> rewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_rewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SchedulerNode.Reward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_rewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06005A27 RID: 23079 RVA: 0x001CCB60 File Offset: 0x001CAD60
		// (set) Token: 0x06005A28 RID: 23080 RVA: 0x00030AEB File Offset: 0x0002ECEB
		public unsafe Il2CppReferenceArray<SchedulerNode.Reward> postRewards
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_postRewards);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SchedulerNode.Reward>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_postRewards), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x06005A29 RID: 23081 RVA: 0x001CCB90 File Offset: 0x001CAD90
		// (set) Token: 0x06005A2A RID: 23082 RVA: 0x00030B0A File Offset: 0x0002ED0A
		public unsafe Il2CppStringArray postEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_postEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_postEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x06005A2B RID: 23083 RVA: 0x001CCBC0 File Offset: 0x001CADC0
		// (set) Token: 0x06005A2C RID: 23084 RVA: 0x00030B29 File Offset: 0x0002ED29
		public unsafe Il2CppStringArray postMissions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_postMissions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_postMissions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06005A2D RID: 23085 RVA: 0x001CCBF0 File Offset: 0x001CADF0
		// (set) Token: 0x06005A2E RID: 23086 RVA: 0x00030B48 File Offset: 0x0002ED48
		public unsafe Il2CppStringArray postMissionsAfterPerformance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_postMissionsAfterPerformance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_postMissionsAfterPerformance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06005A2F RID: 23087 RVA: 0x001CCC20 File Offset: 0x001CAE20
		// (set) Token: 0x06005A30 RID: 23088 RVA: 0x00030B67 File Offset: 0x0002ED67
		public unsafe Il2CppStringArray preNodes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_preNodes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_preNodes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06005A31 RID: 23089 RVA: 0x001CCC50 File Offset: 0x001CAE50
		// (set) Token: 0x06005A32 RID: 23090 RVA: 0x00030B86 File Offset: 0x0002ED86
		public unsafe SchedulerNode.SchedulerType missionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_missionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.NativeFieldInfoPtr_missionType)) = value;
			}
		}

		// Token: 0x04003C06 RID: 15366
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04003C07 RID: 15367
		private static readonly IntPtr NativeFieldInfoPtr_debugLabel;

		// Token: 0x04003C08 RID: 15368
		private static readonly IntPtr NativeFieldInfoPtr_rewards;

		// Token: 0x04003C09 RID: 15369
		private static readonly IntPtr NativeFieldInfoPtr_postRewards;

		// Token: 0x04003C0A RID: 15370
		private static readonly IntPtr NativeFieldInfoPtr_postEvents;

		// Token: 0x04003C0B RID: 15371
		private static readonly IntPtr NativeFieldInfoPtr_postMissions;

		// Token: 0x04003C0C RID: 15372
		private static readonly IntPtr NativeFieldInfoPtr_postMissionsAfterPerformance;

		// Token: 0x04003C0D RID: 15373
		private static readonly IntPtr NativeFieldInfoPtr_preNodes;

		// Token: 0x04003C0E RID: 15374
		private static readonly IntPtr NativeFieldInfoPtr_missionType;

		// Token: 0x04003C0F RID: 15375
		private static readonly IntPtr NativeMethodInfoPtr_GetNodeType_Public_Abstract_Virtual_New_NodeType_0;

		// Token: 0x04003C10 RID: 15376
		private static readonly IntPtr NativeMethodInfoPtr_PostIntializeClone_Protected_Abstract_Virtual_New_Void_SchedulerNode_0;

		// Token: 0x04003C11 RID: 15377
		private static readonly IntPtr NativeMethodInfoPtr_InternalGetNodeType_Protected_Abstract_Virtual_New_Type_0;

		// Token: 0x04003C12 RID: 15378
		private static readonly IntPtr NativeMethodInfoPtr_Clone_Public_SchedulerNode_0;

		// Token: 0x04003C13 RID: 15379
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04003C14 RID: 15380
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000CB0 RID: 3248
		public enum NodeType
		{
			// Token: 0x04009475 RID: 38005
			Event,
			// Token: 0x04009476 RID: 38006
			Mission,
			// Token: 0x04009477 RID: 38007
			Aya
		}

		// Token: 0x02000CB1 RID: 3249
		public enum SchedulerType
		{
			// Token: 0x04009479 RID: 38009
			Main,
			// Token: 0x0400947A RID: 38010
			Side,
			// Token: 0x0400947B RID: 38011
			Kitsuna
		}

		// Token: 0x02000CB2 RID: 3250
		[Serializable]
		public sealed class Trigger : ValueType
		{
			// Token: 0x0600E8C4 RID: 59588 RVA: 0x0037B2AC File Offset: 0x003794AC
			// Note: this type is marked as 'beforefieldinit'.
			static Trigger()
			{
				Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "Trigger");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr);
				SchedulerNode.Trigger.NativeFieldInfoPtr_triggerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "triggerType");
				SchedulerNode.Trigger.NativeFieldInfoPtr_triggerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "triggerId");
				SchedulerNode.Trigger.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "time");
				SchedulerNode.Trigger.NativeFieldInfoPtr_izakayaLockType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "izakayaLockType");
				SchedulerNode.Trigger.NativeFieldInfoPtr_izakayaMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "izakayaMappings");
				SchedulerNode.Trigger.NativeFieldInfoPtr_challengeEndContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "challengeEndContext");
				SchedulerNode.Trigger.NativeFieldInfoPtr_overrideIzakayaIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "overrideIzakayaIndex");
				SchedulerNode.Trigger.NativeFieldInfoPtr_product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "product");
				SchedulerNode.Trigger.NativeFieldInfoPtr_anyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "anyTime");
				SchedulerNode.Trigger.NativeFieldInfoPtr_scheduleAtFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "scheduleAtFirst");
				SchedulerNode.Trigger.NativeFieldInfoPtr_executeOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "executeOrder");
				SchedulerNode.Trigger.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "amount");
				SchedulerNode.Trigger.NativeFieldInfoPtr_labels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "labels");
			}

			// Token: 0x0600E8C5 RID: 59589 RVA: 0x0007C717 File Offset: 0x0007A917
			public Trigger(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E8C6 RID: 59590 RVA: 0x0007C720 File Offset: 0x0007A920
			public Trigger() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr))
			{
			}

			// Token: 0x17004BAA RID: 19370
			// (get) Token: 0x0600E8C7 RID: 59591 RVA: 0x0037B3DC File Offset: 0x003795DC
			// (set) Token: 0x0600E8C8 RID: 59592 RVA: 0x0007C732 File Offset: 0x0007A932
			public unsafe SchedulerNode.Trigger.TriggerType triggerType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_triggerType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_triggerType)) = value;
				}
			}

			// Token: 0x17004BAB RID: 19371
			// (get) Token: 0x0600E8C9 RID: 59593 RVA: 0x0037B404 File Offset: 0x00379604
			// (set) Token: 0x0600E8CA RID: 59594 RVA: 0x0007C74D File Offset: 0x0007A94D
			public unsafe string triggerId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_triggerId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_triggerId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004BAC RID: 19372
			// (get) Token: 0x0600E8CB RID: 59595 RVA: 0x0037B42C File Offset: 0x0037962C
			// (set) Token: 0x0600E8CC RID: 59596 RVA: 0x0007C76C File Offset: 0x0007A96C
			public unsafe SchedulerNode.Day time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x17004BAD RID: 19373
			// (get) Token: 0x0600E8CD RID: 59597 RVA: 0x0037B454 File Offset: 0x00379654
			// (set) Token: 0x0600E8CE RID: 59598 RVA: 0x0007C787 File Offset: 0x0007A987
			public unsafe SchedulerNode.Trigger.IzakayaLockType izakayaLockType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_izakayaLockType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_izakayaLockType)) = value;
				}
			}

			// Token: 0x17004BAE RID: 19374
			// (get) Token: 0x0600E8CF RID: 59599 RVA: 0x0037B47C File Offset: 0x0037967C
			// (set) Token: 0x0600E8D0 RID: 59600 RVA: 0x0007C7A2 File Offset: 0x0007A9A2
			public unsafe Il2CppStructArray<SchedulerNode.Trigger.IzakayaMapping> izakayaMappings
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_izakayaMappings);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SchedulerNode.Trigger.IzakayaMapping>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_izakayaMappings), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BAF RID: 19375
			// (get) Token: 0x0600E8D1 RID: 59601 RVA: 0x0037B4AC File Offset: 0x003796AC
			// (set) Token: 0x0600E8D2 RID: 59602 RVA: 0x0007C7C1 File Offset: 0x0007A9C1
			public unsafe NightSceneDirector.ChallengeType challengeEndContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_challengeEndContext);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_challengeEndContext)) = value;
				}
			}

			// Token: 0x17004BB0 RID: 19376
			// (get) Token: 0x0600E8D3 RID: 59603 RVA: 0x0037B4D4 File Offset: 0x003796D4
			// (set) Token: 0x0600E8D4 RID: 59604 RVA: 0x0007C7DC File Offset: 0x0007A9DC
			public unsafe int overrideIzakayaIndex
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_overrideIzakayaIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_overrideIzakayaIndex)) = value;
				}
			}

			// Token: 0x17004BB1 RID: 19377
			// (get) Token: 0x0600E8D5 RID: 59605 RVA: 0x0037B4FC File Offset: 0x003796FC
			// (set) Token: 0x0600E8D6 RID: 59606 RVA: 0x0007C7F7 File Offset: 0x0007A9F7
			public Product product
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_product);
					return new Product(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Product>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_product), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Product>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004BB2 RID: 19378
			// (get) Token: 0x0600E8D7 RID: 59607 RVA: 0x0037B52C File Offset: 0x0037972C
			// (set) Token: 0x0600E8D8 RID: 59608 RVA: 0x0007C825 File Offset: 0x0007AA25
			public unsafe bool anyTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_anyTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_anyTime)) = value;
				}
			}

			// Token: 0x17004BB3 RID: 19379
			// (get) Token: 0x0600E8D9 RID: 59609 RVA: 0x0037B554 File Offset: 0x00379754
			// (set) Token: 0x0600E8DA RID: 59610 RVA: 0x0007C840 File Offset: 0x0007AA40
			public unsafe bool scheduleAtFirst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_scheduleAtFirst);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_scheduleAtFirst)) = value;
				}
			}

			// Token: 0x17004BB4 RID: 19380
			// (get) Token: 0x0600E8DB RID: 59611 RVA: 0x0037B57C File Offset: 0x0037977C
			// (set) Token: 0x0600E8DC RID: 59612 RVA: 0x0007C85B File Offset: 0x0007AA5B
			public unsafe int executeOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_executeOrder);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_executeOrder)) = value;
				}
			}

			// Token: 0x17004BB5 RID: 19381
			// (get) Token: 0x0600E8DD RID: 59613 RVA: 0x0037B5A4 File Offset: 0x003797A4
			// (set) Token: 0x0600E8DE RID: 59614 RVA: 0x0007C876 File Offset: 0x0007AA76
			public unsafe int amount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_amount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_amount)) = value;
				}
			}

			// Token: 0x17004BB6 RID: 19382
			// (get) Token: 0x0600E8DF RID: 59615 RVA: 0x0037B5CC File Offset: 0x003797CC
			// (set) Token: 0x0600E8E0 RID: 59616 RVA: 0x0007C891 File Offset: 0x0007AA91
			public unsafe Il2CppStringArray labels
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_labels);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Trigger.NativeFieldInfoPtr_labels), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400947C RID: 38012
			private static readonly IntPtr NativeFieldInfoPtr_triggerType;

			// Token: 0x0400947D RID: 38013
			private static readonly IntPtr NativeFieldInfoPtr_triggerId;

			// Token: 0x0400947E RID: 38014
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x0400947F RID: 38015
			private static readonly IntPtr NativeFieldInfoPtr_izakayaLockType;

			// Token: 0x04009480 RID: 38016
			private static readonly IntPtr NativeFieldInfoPtr_izakayaMappings;

			// Token: 0x04009481 RID: 38017
			private static readonly IntPtr NativeFieldInfoPtr_challengeEndContext;

			// Token: 0x04009482 RID: 38018
			private static readonly IntPtr NativeFieldInfoPtr_overrideIzakayaIndex;

			// Token: 0x04009483 RID: 38019
			private static readonly IntPtr NativeFieldInfoPtr_product;

			// Token: 0x04009484 RID: 38020
			private static readonly IntPtr NativeFieldInfoPtr_anyTime;

			// Token: 0x04009485 RID: 38021
			private static readonly IntPtr NativeFieldInfoPtr_scheduleAtFirst;

			// Token: 0x04009486 RID: 38022
			private static readonly IntPtr NativeFieldInfoPtr_executeOrder;

			// Token: 0x04009487 RID: 38023
			private static readonly IntPtr NativeFieldInfoPtr_amount;

			// Token: 0x04009488 RID: 38024
			private static readonly IntPtr NativeFieldInfoPtr_labels;

			// Token: 0x02001060 RID: 4192
			public enum IzakayaLockType
			{
				// Token: 0x0400B500 RID: 46336
				Unlocked,
				// Token: 0x0400B501 RID: 46337
				Locked,
				// Token: 0x0400B502 RID: 46338
				Masked
			}

			// Token: 0x02001061 RID: 4193
			public enum TriggerType
			{
				// Token: 0x0400B504 RID: 46340
				OnEnterDaySceneMap,
				// Token: 0x0400B505 RID: 46341
				OnEnterDayScene,
				// Token: 0x0400B506 RID: 46342
				OnWorkEnd,
				// Token: 0x0400B507 RID: 46343
				OnTalkWithCharacter,
				// Token: 0x0400B508 RID: 46344
				OnBeforeWorkStart,
				// Token: 0x0400B509 RID: 46345
				KizunaCheckPoint,
				// Token: 0x0400B50A RID: 46346
				OnDayEnd,
				// Token: 0x0400B50B RID: 46347
				LevelCheckPoint,
				// Token: 0x0400B50C RID: 46348
				BuyCount,
				// Token: 0x0400B50D RID: 46349
				OnBeforeChallengeStart,
				// Token: 0x0400B50E RID: 46350
				OnChallengeEnd,
				// Token: 0x0400B50F RID: 46351
				Obsolete_OnChallengePhaseChange,
				// Token: 0x0400B510 RID: 46352
				OnChallengeFailed,
				// Token: 0x0400B511 RID: 46353
				OnChallengeSucceed,
				// Token: 0x0400B512 RID: 46354
				OnAfterDayEnd,
				// Token: 0x0400B513 RID: 46355
				OnBeforeIzakayaConfigure,
				// Token: 0x0400B514 RID: 46356
				OnEnterDaySceneTriggerArea,
				// Token: 0x0400B515 RID: 46357
				TriggerFinishImmediate,
				// Token: 0x0400B516 RID: 46358
				OnAfterDayEndIzakayaSelectionOpen,
				// Token: 0x0400B517 RID: 46359
				CompleteSpecifiedFollowingEvents,
				// Token: 0x0400B518 RID: 46360
				ImpossibleFinish,
				// Token: 0x0400B519 RID: 46361
				OnAnyKizunaExpFull
			}

			// Token: 0x02001062 RID: 4194
			[Serializable]
			[StructLayout(2)]
			public struct IzakayaMapping
			{
				// Token: 0x06011E6E RID: 73326 RVA: 0x00418034 File Offset: 0x00416234
				// Note: this type is marked as 'beforefieldinit'.
				static IzakayaMapping()
				{
					Il2CppClassPointerStore<SchedulerNode.Trigger.IzakayaMapping>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, "IzakayaMapping");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerNode.Trigger.IzakayaMapping>.NativeClassPtr);
					SchedulerNode.Trigger.IzakayaMapping.NativeFieldInfoPtr_sourceId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger.IzakayaMapping>.NativeClassPtr, "sourceId");
					SchedulerNode.Trigger.IzakayaMapping.NativeFieldInfoPtr_targetId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Trigger.IzakayaMapping>.NativeClassPtr, "targetId");
				}

				// Token: 0x06011E6F RID: 73327 RVA: 0x0009B8BC File Offset: 0x00099ABC
				public Il2CppSystem.Object BoxIl2CppObject()
				{
					return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Trigger.IzakayaMapping>.NativeClassPtr, ref this));
				}

				// Token: 0x0400B51A RID: 46362
				private static readonly IntPtr NativeFieldInfoPtr_sourceId;

				// Token: 0x0400B51B RID: 46363
				private static readonly IntPtr NativeFieldInfoPtr_targetId;

				// Token: 0x0400B51C RID: 46364
				[FieldOffset(0)]
				public int sourceId;

				// Token: 0x0400B51D RID: 46365
				[FieldOffset(4)]
				public int targetId;
			}
		}

		// Token: 0x02000CB3 RID: 3251
		[Serializable]
		[StructLayout(2)]
		public struct Day
		{
			// Token: 0x0600E8E1 RID: 59617 RVA: 0x0037B5FC File Offset: 0x003797FC
			// Note: this type is marked as 'beforefieldinit'.
			static Day()
			{
				Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "Day");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr);
				SchedulerNode.Day.NativeFieldInfoPtr_dayType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr, "dayType");
				SchedulerNode.Day.NativeFieldInfoPtr_dayCalcType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr, "dayCalcType");
				SchedulerNode.Day.NativeFieldInfoPtr_day = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr, "day");
				SchedulerNode.Day.NativeFieldInfoPtr_dayRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr, "dayRange");
				SchedulerNode.Day.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr, 100681411);
				SchedulerNode.Day.NativeMethodInfoPtr_GetDayCount_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr, 100681412);
				SchedulerNode.Day.NativeMethodInfoPtr_GetAbsoluteDay_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr, 100681413);
			}

			// Token: 0x0600E8E2 RID: 59618 RVA: 0x0037B6B4 File Offset: 0x003798B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219694, XrefRangeEnd = 219706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Day.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E8E3 RID: 59619 RVA: 0x0037B6E0 File Offset: 0x003798E0
			[CallerCount(0)]
			public unsafe int GetDayCount()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Day.NativeMethodInfoPtr_GetDayCount_Private_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E8E4 RID: 59620 RVA: 0x0037B710 File Offset: 0x00379910
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 219707, RefRangeEnd = 219712, XrefRangeStart = 219706, XrefRangeEnd = 219707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int GetAbsoluteDay()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Day.NativeMethodInfoPtr_GetAbsoluteDay_Public_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E8E5 RID: 59621 RVA: 0x0007C8B0 File Offset: 0x0007AAB0
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Day>.NativeClassPtr, ref this));
			}

			// Token: 0x04009489 RID: 38025
			private static readonly IntPtr NativeFieldInfoPtr_dayType;

			// Token: 0x0400948A RID: 38026
			private static readonly IntPtr NativeFieldInfoPtr_dayCalcType;

			// Token: 0x0400948B RID: 38027
			private static readonly IntPtr NativeFieldInfoPtr_day;

			// Token: 0x0400948C RID: 38028
			private static readonly IntPtr NativeFieldInfoPtr_dayRange;

			// Token: 0x0400948D RID: 38029
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x0400948E RID: 38030
			private static readonly IntPtr NativeMethodInfoPtr_GetDayCount_Private_Int32_0;

			// Token: 0x0400948F RID: 38031
			private static readonly IntPtr NativeMethodInfoPtr_GetAbsoluteDay_Public_Int32_0;

			// Token: 0x04009490 RID: 38032
			[FieldOffset(0)]
			public SchedulerNode.Day.DayType dayType;

			// Token: 0x04009491 RID: 38033
			[FieldOffset(4)]
			public SchedulerNode.Day.CalculateType dayCalcType;

			// Token: 0x04009492 RID: 38034
			[FieldOffset(8)]
			public int day;

			// Token: 0x04009493 RID: 38035
			[FieldOffset(12)]
			public Vector2Int dayRange;

			// Token: 0x02001063 RID: 4195
			public enum CalculateType
			{
				// Token: 0x0400B51F RID: 46367
				Constant,
				// Token: 0x0400B520 RID: 46368
				Random
			}

			// Token: 0x02001064 RID: 4196
			public enum DayType
			{
				// Token: 0x0400B522 RID: 46370
				Relative,
				// Token: 0x0400B523 RID: 46371
				Absolute
			}
		}

		// Token: 0x02000CB4 RID: 3252
		[Serializable]
		public sealed class Event : ValueType
		{
			// Token: 0x0600E8E6 RID: 59622 RVA: 0x0037B740 File Offset: 0x00379940
			// Note: this type is marked as 'beforefieldinit'.
			static Event()
			{
				Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "Event");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr);
				SchedulerNode.Event.NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, "eventType");
				SchedulerNode.Event.NativeFieldInfoPtr_eventTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, "eventTimeline");
				SchedulerNode.Event.NativeFieldInfoPtr_eventDialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, "eventDialogPackage");
				SchedulerNode.Event.NativeFieldInfoPtr_runtimeTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, "runtimeTimeline");
				SchedulerNode.Event.NativeFieldInfoPtr_runtimeDialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, "runtimeDialogPackage");
				SchedulerNode.Event.NativeFieldInfoPtr_doNotHideBackgroundUIInDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, "doNotHideBackgroundUIInDialog");
				SchedulerNode.Event.NativeMethodInfoPtr_DialogEvent_Public_Static_Event_DialogPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, 100681414);
				SchedulerNode.Event.NativeMethodInfoPtr_TimelineEvent_Public_Static_Event_PlayableAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, 100681415);
				SchedulerNode.Event.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, 100681416);
			}

			// Token: 0x0600E8E7 RID: 59623 RVA: 0x0037B820 File Offset: 0x00379A20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219712, XrefRangeEnd = 219713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static SchedulerNode.Event DialogEvent(DialogPackage dialogPackage)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackage);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Event.NativeMethodInfoPtr_DialogEvent_Public_Static_Event_DialogPackage_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new SchedulerNode.Event(pointer);
			}

			// Token: 0x0600E8E8 RID: 59624 RVA: 0x0037B85C File Offset: 0x00379A5C
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 219714, RefRangeEnd = 219725, XrefRangeStart = 219713, XrefRangeEnd = 219714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static SchedulerNode.Event TimelineEvent(PlayableAsset timeline)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(timeline);
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Event.NativeMethodInfoPtr_TimelineEvent_Public_Static_Event_PlayableAsset_0, 0, (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new SchedulerNode.Event(pointer);
			}

			// Token: 0x0600E8E9 RID: 59625 RVA: 0x0037B898 File Offset: 0x00379A98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219725, XrefRangeEnd = 219731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Event.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E8EA RID: 59626 RVA: 0x0007C8C2 File Offset: 0x0007AAC2
			public Event(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E8EB RID: 59627 RVA: 0x0007C8CB File Offset: 0x0007AACB
			public Event() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr))
			{
			}

			// Token: 0x17004BB7 RID: 19383
			// (get) Token: 0x0600E8EC RID: 59628 RVA: 0x0037B8D4 File Offset: 0x00379AD4
			// (set) Token: 0x0600E8ED RID: 59629 RVA: 0x0007C8DD File Offset: 0x0007AADD
			public unsafe SchedulerNode.Event.EventType eventType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_eventType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_eventType)) = value;
				}
			}

			// Token: 0x17004BB8 RID: 19384
			// (get) Token: 0x0600E8EE RID: 59630 RVA: 0x0037B8FC File Offset: 0x00379AFC
			// (set) Token: 0x0600E8EF RID: 59631 RVA: 0x0007C8F8 File Offset: 0x0007AAF8
			public unsafe AssetReference eventTimeline
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_eventTimeline);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_eventTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BB9 RID: 19385
			// (get) Token: 0x0600E8F0 RID: 59632 RVA: 0x0037B92C File Offset: 0x00379B2C
			// (set) Token: 0x0600E8F1 RID: 59633 RVA: 0x0007C917 File Offset: 0x0007AB17
			public unsafe AssetReference eventDialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_eventDialogPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_eventDialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BBA RID: 19386
			// (get) Token: 0x0600E8F2 RID: 59634 RVA: 0x0037B95C File Offset: 0x00379B5C
			// (set) Token: 0x0600E8F3 RID: 59635 RVA: 0x0007C936 File Offset: 0x0007AB36
			public unsafe PlayableAsset runtimeTimeline
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_runtimeTimeline);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_runtimeTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BBB RID: 19387
			// (get) Token: 0x0600E8F4 RID: 59636 RVA: 0x0037B98C File Offset: 0x00379B8C
			// (set) Token: 0x0600E8F5 RID: 59637 RVA: 0x0007C955 File Offset: 0x0007AB55
			public unsafe DialogPackage runtimeDialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_runtimeDialogPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_runtimeDialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BBC RID: 19388
			// (get) Token: 0x0600E8F6 RID: 59638 RVA: 0x0037B9BC File Offset: 0x00379BBC
			// (set) Token: 0x0600E8F7 RID: 59639 RVA: 0x0007C974 File Offset: 0x0007AB74
			public unsafe bool doNotHideBackgroundUIInDialog
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_doNotHideBackgroundUIInDialog);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Event.NativeFieldInfoPtr_doNotHideBackgroundUIInDialog)) = value;
				}
			}

			// Token: 0x04009494 RID: 38036
			private static readonly IntPtr NativeFieldInfoPtr_eventType;

			// Token: 0x04009495 RID: 38037
			private static readonly IntPtr NativeFieldInfoPtr_eventTimeline;

			// Token: 0x04009496 RID: 38038
			private static readonly IntPtr NativeFieldInfoPtr_eventDialogPackage;

			// Token: 0x04009497 RID: 38039
			private static readonly IntPtr NativeFieldInfoPtr_runtimeTimeline;

			// Token: 0x04009498 RID: 38040
			private static readonly IntPtr NativeFieldInfoPtr_runtimeDialogPackage;

			// Token: 0x04009499 RID: 38041
			private static readonly IntPtr NativeFieldInfoPtr_doNotHideBackgroundUIInDialog;

			// Token: 0x0400949A RID: 38042
			private static readonly IntPtr NativeMethodInfoPtr_DialogEvent_Public_Static_Event_DialogPackage_0;

			// Token: 0x0400949B RID: 38043
			private static readonly IntPtr NativeMethodInfoPtr_TimelineEvent_Public_Static_Event_PlayableAsset_0;

			// Token: 0x0400949C RID: 38044
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x02001065 RID: 4197
			public enum EventType
			{
				// Token: 0x0400B525 RID: 46373
				Null,
				// Token: 0x0400B526 RID: 46374
				Timeline,
				// Token: 0x0400B527 RID: 46375
				Dialog
			}
		}

		// Token: 0x02000CB5 RID: 3253
		[Serializable]
		[StructLayout(2)]
		public struct Character
		{
			// Token: 0x0600E8F8 RID: 59640 RVA: 0x0037B9E4 File Offset: 0x00379BE4
			// Note: this type is marked as 'beforefieldinit'.
			static Character()
			{
				Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "Character");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr);
				SchedulerNode.Character.NativeFieldInfoPtr_characterIdentity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr, "characterIdentity");
				SchedulerNode.Character.NativeFieldInfoPtr_characterId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr, "characterId");
				SchedulerNode.Character.NativeMethodInfoPtr__ctor_Public_Void_Identity_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr, 100681417);
				SchedulerNode.Character.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Character_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr, 100681418);
				SchedulerNode.Character.NativeMethodInfoPtr_GetLanguageData_Public_LanguageBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr, 100681419);
				SchedulerNode.Character.NativeMethodInfoPtr_GetVisual_Public_CharacterSpriteSetCompact_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr, 100681420);
				SchedulerNode.Character.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr, 100681421);
			}

			// Token: 0x0600E8F9 RID: 59641 RVA: 0x0037BA9C File Offset: 0x00379C9C
			[CallerCount(104)]
			[CachedScanResults(RefRangeStart = 395, RefRangeEnd = 499, XrefRangeStart = 395, XrefRangeEnd = 499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Character(SceneDirector.Identity characterIdentity, int characterId)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref characterIdentity;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Character.NativeMethodInfoPtr__ctor_Public_Void_Identity_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E8FA RID: 59642 RVA: 0x0037BADC File Offset: 0x00379CDC
			[CallerCount(0)]
			public unsafe bool Equals(SchedulerNode.Character other)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Character.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Character_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E8FB RID: 59643 RVA: 0x0037BB1C File Offset: 0x00379D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219731, XrefRangeEnd = 219733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LanguageBase GetLanguageData()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Character.NativeMethodInfoPtr_GetLanguageData_Public_LanguageBase_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LanguageBase>(intPtr3) : null;
			}

			// Token: 0x0600E8FC RID: 59644 RVA: 0x0037BB50 File Offset: 0x00379D50
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 219741, RefRangeEnd = 219742, XrefRangeStart = 219733, XrefRangeEnd = 219741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CharacterSpriteSetCompact GetVisual()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Character.NativeMethodInfoPtr_GetVisual_Public_CharacterSpriteSetCompact_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr3) : null;
			}

			// Token: 0x0600E8FD RID: 59645 RVA: 0x0037BB84 File Offset: 0x00379D84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219742, XrefRangeEnd = 219751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Character.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E8FE RID: 59646 RVA: 0x0007C98F File Offset: 0x0007AB8F
			public Il2CppSystem.Object BoxIl2CppObject()
			{
				return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Character>.NativeClassPtr, ref this));
			}

			// Token: 0x0400949D RID: 38045
			private static readonly IntPtr NativeFieldInfoPtr_characterIdentity;

			// Token: 0x0400949E RID: 38046
			private static readonly IntPtr NativeFieldInfoPtr_characterId;

			// Token: 0x0400949F RID: 38047
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Identity_Int32_0;

			// Token: 0x040094A0 RID: 38048
			private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Character_0;

			// Token: 0x040094A1 RID: 38049
			private static readonly IntPtr NativeMethodInfoPtr_GetLanguageData_Public_LanguageBase_0;

			// Token: 0x040094A2 RID: 38050
			private static readonly IntPtr NativeMethodInfoPtr_GetVisual_Public_CharacterSpriteSetCompact_0;

			// Token: 0x040094A3 RID: 38051
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x040094A4 RID: 38052
			[FieldOffset(0)]
			public SceneDirector.Identity characterIdentity;

			// Token: 0x040094A5 RID: 38053
			[FieldOffset(4)]
			public int characterId;
		}

		// Token: 0x02000CB6 RID: 3254
		[Serializable]
		public sealed class ScheduledEvent : ValueType
		{
			// Token: 0x0600E8FF RID: 59647 RVA: 0x0037BBB0 File Offset: 0x00379DB0
			// Note: this type is marked as 'beforefieldinit'.
			static ScheduledEvent()
			{
				Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "ScheduledEvent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr);
				SchedulerNode.ScheduledEvent.NativeFieldInfoPtr_trigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr, "trigger");
				SchedulerNode.ScheduledEvent.NativeFieldInfoPtr_eventData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr, "eventData");
				SchedulerNode.ScheduledEvent.NativeMethodInfoPtr__ctor_Public_Void_Trigger_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr, 100681422);
				SchedulerNode.ScheduledEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr, 100681423);
			}

			// Token: 0x0600E900 RID: 59648 RVA: 0x0037BC2C File Offset: 0x00379E2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219751, XrefRangeEnd = 219753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ScheduledEvent(SchedulerNode.Trigger trigger, SchedulerNode.Event eventData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(trigger));
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(eventData));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.ScheduledEvent.NativeMethodInfoPtr__ctor_Public_Void_Trigger_Event_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E901 RID: 59649 RVA: 0x0037BC98 File Offset: 0x00379E98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219753, XrefRangeEnd = 219762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.ScheduledEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E902 RID: 59650 RVA: 0x0007C9A1 File Offset: 0x0007ABA1
			public ScheduledEvent(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E903 RID: 59651 RVA: 0x0007C9AA File Offset: 0x0007ABAA
			public ScheduledEvent() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerNode.ScheduledEvent>.NativeClassPtr))
			{
			}

			// Token: 0x17004BBD RID: 19389
			// (get) Token: 0x0600E904 RID: 59652 RVA: 0x0037BCD4 File Offset: 0x00379ED4
			// (set) Token: 0x0600E905 RID: 59653 RVA: 0x0007C9BC File Offset: 0x0007ABBC
			public SchedulerNode.Trigger trigger
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.ScheduledEvent.NativeFieldInfoPtr_trigger);
					return new SchedulerNode.Trigger(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.ScheduledEvent.NativeFieldInfoPtr_trigger), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SchedulerNode.Trigger>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004BBE RID: 19390
			// (get) Token: 0x0600E906 RID: 59654 RVA: 0x0037BD04 File Offset: 0x00379F04
			// (set) Token: 0x0600E907 RID: 59655 RVA: 0x0007C9EA File Offset: 0x0007ABEA
			public SchedulerNode.Event eventData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.ScheduledEvent.NativeFieldInfoPtr_eventData);
					return new SchedulerNode.Event(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.ScheduledEvent.NativeFieldInfoPtr_eventData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SchedulerNode.Event>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040094A6 RID: 38054
			private static readonly IntPtr NativeFieldInfoPtr_trigger;

			// Token: 0x040094A7 RID: 38055
			private static readonly IntPtr NativeFieldInfoPtr_eventData;

			// Token: 0x040094A8 RID: 38056
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Trigger_Event_0;

			// Token: 0x040094A9 RID: 38057
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
		}

		// Token: 0x02000CB7 RID: 3255
		[Serializable]
		public sealed class Reward : ValueType
		{
			// Token: 0x0600E908 RID: 59656 RVA: 0x0037BD34 File Offset: 0x00379F34
			// Note: this type is marked as 'beforefieldinit'.
			static Reward()
			{
				Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SchedulerNode>.NativeClassPtr, "Reward");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr);
				SchedulerNode.Reward.NativeFieldInfoPtr_rewardType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "rewardType");
				SchedulerNode.Reward.NativeFieldInfoPtr_rewardId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "rewardId");
				SchedulerNode.Reward.NativeFieldInfoPtr_rewardAltId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "rewardAltId");
				SchedulerNode.Reward.NativeFieldInfoPtr_rewardAltAltId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "rewardAltAltId");
				SchedulerNode.Reward.NativeFieldInfoPtr_rewardIdArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "rewardIdArray");
				SchedulerNode.Reward.NativeFieldInfoPtr_rewardIntArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "rewardIntArray");
				SchedulerNode.Reward.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "time");
				SchedulerNode.Reward.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "id");
				SchedulerNode.Reward.NativeFieldInfoPtr_popType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "popType");
				SchedulerNode.Reward.NativeFieldInfoPtr_tagType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "tagType");
				SchedulerNode.Reward.NativeFieldInfoPtr_objectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "objectType");
				SchedulerNode.Reward.NativeFieldInfoPtr_should = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "should");
				SchedulerNode.Reward.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "value");
				SchedulerNode.Reward.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "position");
				SchedulerNode.Reward.NativeFieldInfoPtr_challengeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, "challengeType");
				SchedulerNode.Reward.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr, 100681424);
			}

			// Token: 0x0600E909 RID: 59657 RVA: 0x0037BEA0 File Offset: 0x0037A0A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 219762, XrefRangeEnd = 219809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override string ToString()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SchedulerNode.Reward.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E90A RID: 59658 RVA: 0x0007CA18 File Offset: 0x0007AC18
			public Reward(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E90B RID: 59659 RVA: 0x0007CA21 File Offset: 0x0007AC21
			public Reward() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SchedulerNode.Reward>.NativeClassPtr))
			{
			}

			// Token: 0x17004BBF RID: 19391
			// (get) Token: 0x0600E90C RID: 59660 RVA: 0x0037BEDC File Offset: 0x0037A0DC
			// (set) Token: 0x0600E90D RID: 59661 RVA: 0x0007CA33 File Offset: 0x0007AC33
			public unsafe SchedulerNode.Reward.RewardType rewardType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardType)) = value;
				}
			}

			// Token: 0x17004BC0 RID: 19392
			// (get) Token: 0x0600E90E RID: 59662 RVA: 0x0037BF04 File Offset: 0x0037A104
			// (set) Token: 0x0600E90F RID: 59663 RVA: 0x0007CA4E File Offset: 0x0007AC4E
			public unsafe string rewardId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004BC1 RID: 19393
			// (get) Token: 0x0600E910 RID: 59664 RVA: 0x0037BF2C File Offset: 0x0037A12C
			// (set) Token: 0x0600E911 RID: 59665 RVA: 0x0007CA6D File Offset: 0x0007AC6D
			public unsafe string rewardAltId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardAltId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardAltId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004BC2 RID: 19394
			// (get) Token: 0x0600E912 RID: 59666 RVA: 0x0037BF54 File Offset: 0x0037A154
			// (set) Token: 0x0600E913 RID: 59667 RVA: 0x0007CA8C File Offset: 0x0007AC8C
			public unsafe string rewardAltAltId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardAltAltId);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardAltAltId), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004BC3 RID: 19395
			// (get) Token: 0x0600E914 RID: 59668 RVA: 0x0037BF7C File Offset: 0x0037A17C
			// (set) Token: 0x0600E915 RID: 59669 RVA: 0x0007CAAB File Offset: 0x0007ACAB
			public unsafe Il2CppStringArray rewardIdArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardIdArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardIdArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BC4 RID: 19396
			// (get) Token: 0x0600E916 RID: 59670 RVA: 0x0037BFAC File Offset: 0x0037A1AC
			// (set) Token: 0x0600E917 RID: 59671 RVA: 0x0007CACA File Offset: 0x0007ACCA
			public unsafe Il2CppStructArray<int> rewardIntArray
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardIntArray);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_rewardIntArray), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004BC5 RID: 19397
			// (get) Token: 0x0600E918 RID: 59672 RVA: 0x0037BFDC File Offset: 0x0037A1DC
			// (set) Token: 0x0600E919 RID: 59673 RVA: 0x0007CAE9 File Offset: 0x0007ACE9
			public unsafe SchedulerNode.Day time
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x17004BC6 RID: 19398
			// (get) Token: 0x0600E91A RID: 59674 RVA: 0x0037C004 File Offset: 0x0037A204
			// (set) Token: 0x0600E91B RID: 59675 RVA: 0x0007CB04 File Offset: 0x0007AD04
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17004BC7 RID: 19399
			// (get) Token: 0x0600E91C RID: 59676 RVA: 0x0037C02C File Offset: 0x0037A22C
			// (set) Token: 0x0600E91D RID: 59677 RVA: 0x0007CB1F File Offset: 0x0007AD1F
			public unsafe RunTimePlayerData.PopType popType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_popType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_popType)) = value;
				}
			}

			// Token: 0x17004BC8 RID: 19400
			// (get) Token: 0x0600E91E RID: 59678 RVA: 0x0037C054 File Offset: 0x0037A254
			// (set) Token: 0x0600E91F RID: 59679 RVA: 0x0007CB3A File Offset: 0x0007AD3A
			public unsafe RunTimePlayerData.TagType tagType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_tagType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_tagType)) = value;
				}
			}

			// Token: 0x17004BC9 RID: 19401
			// (get) Token: 0x0600E920 RID: 59680 RVA: 0x0037C07C File Offset: 0x0037A27C
			// (set) Token: 0x0600E921 RID: 59681 RVA: 0x0007CB55 File Offset: 0x0007AD55
			public unsafe SchedulerNode.Reward.ObjectType objectType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_objectType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_objectType)) = value;
				}
			}

			// Token: 0x17004BCA RID: 19402
			// (get) Token: 0x0600E922 RID: 59682 RVA: 0x0037C0A4 File Offset: 0x0037A2A4
			// (set) Token: 0x0600E923 RID: 59683 RVA: 0x0007CB70 File Offset: 0x0007AD70
			public unsafe bool should
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_should);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_should)) = value;
				}
			}

			// Token: 0x17004BCB RID: 19403
			// (get) Token: 0x0600E924 RID: 59684 RVA: 0x0037C0CC File Offset: 0x0037A2CC
			// (set) Token: 0x0600E925 RID: 59685 RVA: 0x0007CB8B File Offset: 0x0007AD8B
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x17004BCC RID: 19404
			// (get) Token: 0x0600E926 RID: 59686 RVA: 0x0037C0F4 File Offset: 0x0037A2F4
			// (set) Token: 0x0600E927 RID: 59687 RVA: 0x0007CBA6 File Offset: 0x0007ADA6
			public unsafe Vector2 position
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17004BCD RID: 19405
			// (get) Token: 0x0600E928 RID: 59688 RVA: 0x0037C11C File Offset: 0x0037A31C
			// (set) Token: 0x0600E929 RID: 59689 RVA: 0x0007CBC1 File Offset: 0x0007ADC1
			public unsafe NightSceneDirector.ChallengeType challengeType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_challengeType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SchedulerNode.Reward.NativeFieldInfoPtr_challengeType)) = value;
				}
			}

			// Token: 0x040094AA RID: 38058
			private static readonly IntPtr NativeFieldInfoPtr_rewardType;

			// Token: 0x040094AB RID: 38059
			private static readonly IntPtr NativeFieldInfoPtr_rewardId;

			// Token: 0x040094AC RID: 38060
			private static readonly IntPtr NativeFieldInfoPtr_rewardAltId;

			// Token: 0x040094AD RID: 38061
			private static readonly IntPtr NativeFieldInfoPtr_rewardAltAltId;

			// Token: 0x040094AE RID: 38062
			private static readonly IntPtr NativeFieldInfoPtr_rewardIdArray;

			// Token: 0x040094AF RID: 38063
			private static readonly IntPtr NativeFieldInfoPtr_rewardIntArray;

			// Token: 0x040094B0 RID: 38064
			private static readonly IntPtr NativeFieldInfoPtr_time;

			// Token: 0x040094B1 RID: 38065
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040094B2 RID: 38066
			private static readonly IntPtr NativeFieldInfoPtr_popType;

			// Token: 0x040094B3 RID: 38067
			private static readonly IntPtr NativeFieldInfoPtr_tagType;

			// Token: 0x040094B4 RID: 38068
			private static readonly IntPtr NativeFieldInfoPtr_objectType;

			// Token: 0x040094B5 RID: 38069
			private static readonly IntPtr NativeFieldInfoPtr_should;

			// Token: 0x040094B6 RID: 38070
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x040094B7 RID: 38071
			private static readonly IntPtr NativeFieldInfoPtr_position;

			// Token: 0x040094B8 RID: 38072
			private static readonly IntPtr NativeFieldInfoPtr_challengeType;

			// Token: 0x040094B9 RID: 38073
			private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

			// Token: 0x02001066 RID: 4198
			public enum ObjectType
			{
				// Token: 0x0400B529 RID: 46377
				Food,
				// Token: 0x0400B52A RID: 46378
				Ingredient,
				// Token: 0x0400B52B RID: 46379
				Beverage,
				// Token: 0x0400B52C RID: 46380
				Item,
				// Token: 0x0400B52D RID: 46381
				Recipe,
				// Token: 0x0400B52E RID: 46382
				Izakaya,
				// Token: 0x0400B52F RID: 46383
				Partner,
				// Token: 0x0400B530 RID: 46384
				Badge,
				// Token: 0x0400B531 RID: 46385
				Cooker
			}

			// Token: 0x02001067 RID: 4199
			public enum RewardType
			{
				// Token: 0x0400B533 RID: 46387
				UnlockNPC,
				// Token: 0x0400B534 RID: 46388
				ScheduleNews,
				// Token: 0x0400B535 RID: 46389
				DismissNews,
				// Token: 0x0400B536 RID: 46390
				ModifyPopSystem,
				// Token: 0x0400B537 RID: 46391
				ToggleResourcePoint,
				// Token: 0x0400B538 RID: 46392
				SetGlobalGuestFundModifier,
				// Token: 0x0400B539 RID: 46393
				SetObjectPriceModifier,
				// Token: 0x0400B53A RID: 46394
				DismissEvents,
				// Token: 0x0400B53B RID: 46395
				RequestNPC,
				// Token: 0x0400B53C RID: 46396
				DismissNPC,
				// Token: 0x0400B53D RID: 46397
				AddNPCDialog,
				// Token: 0x0400B53E RID: 46398
				RemoveNPCDialog,
				// Token: 0x0400B53F RID: 46399
				ToggleInteractableEntity,
				// Token: 0x0400B540 RID: 46400
				UnlockMap,
				// Token: 0x0400B541 RID: 46401
				SetEnableInteractablesUI,
				// Token: 0x0400B542 RID: 46402
				SetIzakayaIndex,
				// Token: 0x0400B543 RID: 46403
				GiveItem,
				// Token: 0x0400B544 RID: 46404
				SetDaySpecialNPCVisibility,
				// Token: 0x0400B545 RID: 46405
				SetNPCDialog,
				// Token: 0x0400B546 RID: 46406
				UpgradeKizunaLevel,
				// Token: 0x0400B547 RID: 46407
				SetCanHaveLevel5Kizuna,
				// Token: 0x0400B548 RID: 46408
				GetFund,
				// Token: 0x0400B549 RID: 46409
				ToggleSwitchEntity,
				// Token: 0x0400B54A RID: 46410
				SetLevelCap,
				// Token: 0x0400B54B RID: 46411
				CouldSpawnTewi,
				// Token: 0x0400B54C RID: 46412
				TewiSpawnTonight,
				// Token: 0x0400B54D RID: 46413
				AskReimuProtectYou,
				// Token: 0x0400B54E RID: 46414
				AddToKourindoStaticMerchandise,
				// Token: 0x0400B54F RID: 46415
				EnableMultiPartnerMode,
				// Token: 0x0400B550 RID: 46416
				SetPartnerCount,
				// Token: 0x0400B551 RID: 46417
				MoveToChallenge,
				// Token: 0x0400B552 RID: 46418
				CancelEvent,
				// Token: 0x0400B553 RID: 46419
				MoveToStaff,
				// Token: 0x0400B554 RID: 46420
				EnableSpecialGuestSpawnInNight,
				// Token: 0x0400B555 RID: 46421
				EnableSGuestSpawnInTargetIzakayaById,
				// Token: 0x0400B556 RID: 46422
				EnableSGuestSpawnInTargetIzakayaByMap,
				// Token: 0x0400B557 RID: 46423
				UnlockSGuestInNotebook,
				// Token: 0x0400B558 RID: 46424
				SetTargetMissionFulfilled,
				// Token: 0x0400B559 RID: 46425
				UnlockMusicGameChapter,
				// Token: 0x0400B55A RID: 46426
				RemoveKourindouMerchandise,
				// Token: 0x0400B55B RID: 46427
				FinishFakeMission,
				// Token: 0x0400B55C RID: 46428
				ForceCompleteMission,
				// Token: 0x0400B55D RID: 46429
				RefreshRandomSpawnNpc,
				// Token: 0x0400B55E RID: 46430
				AddLockedRecipe,
				// Token: 0x0400B55F RID: 46431
				ClearLockedRecipe,
				// Token: 0x0400B560 RID: 46432
				AddEffectiveSGuestMapping,
				// Token: 0x0400B561 RID: 46433
				RemoveEffectiveSGuestMapping,
				// Token: 0x0400B562 RID: 46434
				FinishEvent,
				// Token: 0x0400B563 RID: 46435
				StartOrContinueRogueLike,
				// Token: 0x0400B564 RID: 46436
				ControlSpecialGuestScheduled,
				// Token: 0x0400B565 RID: 46437
				CancelControlSpecialGuestScheduled,
				// Token: 0x0400B566 RID: 46438
				IgnoreSpecialGuest,
				// Token: 0x0400B567 RID: 46439
				AddDLCLock,
				// Token: 0x0400B568 RID: 46440
				RemoveDLCLock,
				// Token: 0x0400B569 RID: 46441
				StopAllUnmanagedMovingProcess,
				// Token: 0x0400B56A RID: 46442
				NotifySpecialGuestSpawnInNight,
				// Token: 0x0400B56B RID: 46443
				SetAndSavePlayerPref
			}
		}
	}
}
