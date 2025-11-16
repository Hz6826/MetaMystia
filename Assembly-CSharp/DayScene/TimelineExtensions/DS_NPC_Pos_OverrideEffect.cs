using System;
using DayScene.Input;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000157 RID: 343
	public class DS_NPC_Pos_OverrideEffect : PlayableAsset
	{
		// Token: 0x0600273D RID: 10045 RVA: 0x001215D0 File Offset: 0x0011F7D0
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Pos_OverrideEffect()
		{
			Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Pos_OverrideEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr);
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "characterLabel");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_mapLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "mapLabel");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "position");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "rotation");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_characterSetDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "characterSetDelay");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "shouldWaitForFinish");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "effectLabel");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "effectPrefab");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "effectPositionOffset");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectDestroyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "effectDestroyDelay");
			DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectTransitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, "effectTransitionDuration");
			DS_NPC_Pos_OverrideEffect.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, 100670250);
			DS_NPC_Pos_OverrideEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr, 100670251);
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x00121704 File Offset: 0x0011F904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90837, XrefRangeEnd = 90859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_OverrideEffect.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0012176C File Offset: 0x0011F96C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90859, XrefRangeEnd = 90860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Pos_OverrideEffect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_OverrideEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_OverrideEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x00017229 File Offset: 0x00015429
		public DS_NPC_Pos_OverrideEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DAA RID: 3498
		// (get) Token: 0x06002741 RID: 10049 RVA: 0x001217A8 File Offset: 0x0011F9A8
		// (set) Token: 0x06002742 RID: 10050 RVA: 0x00017232 File Offset: 0x00015432
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (get) Token: 0x06002743 RID: 10051 RVA: 0x001217D0 File Offset: 0x0011F9D0
		// (set) Token: 0x06002744 RID: 10052 RVA: 0x00017251 File Offset: 0x00015451
		public unsafe string mapLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_mapLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_mapLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DAC RID: 3500
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x001217F8 File Offset: 0x0011F9F8
		// (set) Token: 0x06002746 RID: 10054 RVA: 0x00017270 File Offset: 0x00015470
		public unsafe Vector2 position
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_position);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_position)) = value;
			}
		}

		// Token: 0x17000DAD RID: 3501
		// (get) Token: 0x06002747 RID: 10055 RVA: 0x00121820 File Offset: 0x0011FA20
		// (set) Token: 0x06002748 RID: 10056 RVA: 0x0001728B File Offset: 0x0001548B
		public unsafe DayScenePlayerInputGenerator.CharacterRotation rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x17000DAE RID: 3502
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x00121848 File Offset: 0x0011FA48
		// (set) Token: 0x0600274A RID: 10058 RVA: 0x000172A6 File Offset: 0x000154A6
		public unsafe float characterSetDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_characterSetDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_characterSetDelay)) = value;
			}
		}

		// Token: 0x17000DAF RID: 3503
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x00121870 File Offset: 0x0011FA70
		// (set) Token: 0x0600274C RID: 10060 RVA: 0x000172C1 File Offset: 0x000154C1
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x17000DB0 RID: 3504
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x00121898 File Offset: 0x0011FA98
		// (set) Token: 0x0600274E RID: 10062 RVA: 0x000172DC File Offset: 0x000154DC
		public unsafe string effectLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DB1 RID: 3505
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x001218C0 File Offset: 0x0011FAC0
		// (set) Token: 0x06002750 RID: 10064 RVA: 0x000172FB File Offset: 0x000154FB
		public unsafe GameObject effectPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DB2 RID: 3506
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x001218F0 File Offset: 0x0011FAF0
		// (set) Token: 0x06002752 RID: 10066 RVA: 0x0001731A File Offset: 0x0001551A
		public unsafe Vector2 effectPositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectPositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectPositionOffset)) = value;
			}
		}

		// Token: 0x17000DB3 RID: 3507
		// (get) Token: 0x06002753 RID: 10067 RVA: 0x00121918 File Offset: 0x0011FB18
		// (set) Token: 0x06002754 RID: 10068 RVA: 0x00017335 File Offset: 0x00015535
		public unsafe float effectDestroyDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectDestroyDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectDestroyDelay)) = value;
			}
		}

		// Token: 0x17000DB4 RID: 3508
		// (get) Token: 0x06002755 RID: 10069 RVA: 0x00121940 File Offset: 0x0011FB40
		// (set) Token: 0x06002756 RID: 10070 RVA: 0x00017350 File Offset: 0x00015550
		public unsafe float effectTransitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectTransitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_OverrideEffect.NativeFieldInfoPtr_effectTransitionDuration)) = value;
			}
		}

		// Token: 0x04001A0D RID: 6669
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04001A0E RID: 6670
		private static readonly IntPtr NativeFieldInfoPtr_mapLabel;

		// Token: 0x04001A0F RID: 6671
		private static readonly IntPtr NativeFieldInfoPtr_position;

		// Token: 0x04001A10 RID: 6672
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x04001A11 RID: 6673
		private static readonly IntPtr NativeFieldInfoPtr_characterSetDelay;

		// Token: 0x04001A12 RID: 6674
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04001A13 RID: 6675
		private static readonly IntPtr NativeFieldInfoPtr_effectLabel;

		// Token: 0x04001A14 RID: 6676
		private static readonly IntPtr NativeFieldInfoPtr_effectPrefab;

		// Token: 0x04001A15 RID: 6677
		private static readonly IntPtr NativeFieldInfoPtr_effectPositionOffset;

		// Token: 0x04001A16 RID: 6678
		private static readonly IntPtr NativeFieldInfoPtr_effectDestroyDelay;

		// Token: 0x04001A17 RID: 6679
		private static readonly IntPtr NativeFieldInfoPtr_effectTransitionDuration;

		// Token: 0x04001A18 RID: 6680
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A19 RID: 6681
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
