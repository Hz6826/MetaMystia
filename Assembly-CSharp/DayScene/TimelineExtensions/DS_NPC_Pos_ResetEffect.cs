using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000159 RID: 345
	public class DS_NPC_Pos_ResetEffect : PlayableAsset
	{
		// Token: 0x0600275D RID: 10077 RVA: 0x00121AA0 File Offset: 0x0011FCA0
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Pos_ResetEffect()
		{
			Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Pos_ResetEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr);
			DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, "characterLabel");
			DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_characterResetDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, "characterResetDelay");
			DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, "shouldWaitForFinish");
			DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, "effectLabel");
			DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, "effectPrefab");
			DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, "effectPositionOffset");
			DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectDestroyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, "effectDestroyDelay");
			DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectTransitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, "effectTransitionDuration");
			DS_NPC_Pos_ResetEffect.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, 100670254);
			DS_NPC_Pos_ResetEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr, 100670255);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00121B98 File Offset: 0x0011FD98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90873, XrefRangeEnd = 90888, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_ResetEffect.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00121C00 File Offset: 0x0011FE00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90888, XrefRangeEnd = 90889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Pos_ResetEffect() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_ResetEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_ResetEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00017393 File Offset: 0x00015593
		public DS_NPC_Pos_ResetEffect(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DB6 RID: 3510
		// (get) Token: 0x06002761 RID: 10081 RVA: 0x00121C3C File Offset: 0x0011FE3C
		// (set) Token: 0x06002762 RID: 10082 RVA: 0x0001739C File Offset: 0x0001559C
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DB7 RID: 3511
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x00121C64 File Offset: 0x0011FE64
		// (set) Token: 0x06002764 RID: 10084 RVA: 0x000173BB File Offset: 0x000155BB
		public unsafe float characterResetDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_characterResetDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_characterResetDelay)) = value;
			}
		}

		// Token: 0x17000DB8 RID: 3512
		// (get) Token: 0x06002765 RID: 10085 RVA: 0x00121C8C File Offset: 0x0011FE8C
		// (set) Token: 0x06002766 RID: 10086 RVA: 0x000173D6 File Offset: 0x000155D6
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06002767 RID: 10087 RVA: 0x00121CB4 File Offset: 0x0011FEB4
		// (set) Token: 0x06002768 RID: 10088 RVA: 0x000173F1 File Offset: 0x000155F1
		public unsafe string effectLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06002769 RID: 10089 RVA: 0x00121CDC File Offset: 0x0011FEDC
		// (set) Token: 0x0600276A RID: 10090 RVA: 0x00017410 File Offset: 0x00015610
		public unsafe GameObject effectPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x0600276B RID: 10091 RVA: 0x00121D0C File Offset: 0x0011FF0C
		// (set) Token: 0x0600276C RID: 10092 RVA: 0x0001742F File Offset: 0x0001562F
		public unsafe Vector2 effectPositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectPositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectPositionOffset)) = value;
			}
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x00121D34 File Offset: 0x0011FF34
		// (set) Token: 0x0600276E RID: 10094 RVA: 0x0001744A File Offset: 0x0001564A
		public unsafe float effectDestroyDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectDestroyDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectDestroyDelay)) = value;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x00121D5C File Offset: 0x0011FF5C
		// (set) Token: 0x06002770 RID: 10096 RVA: 0x00017465 File Offset: 0x00015665
		public unsafe float effectTransitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectTransitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_ResetEffect.NativeFieldInfoPtr_effectTransitionDuration)) = value;
			}
		}

		// Token: 0x04001A1D RID: 6685
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04001A1E RID: 6686
		private static readonly IntPtr NativeFieldInfoPtr_characterResetDelay;

		// Token: 0x04001A1F RID: 6687
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04001A20 RID: 6688
		private static readonly IntPtr NativeFieldInfoPtr_effectLabel;

		// Token: 0x04001A21 RID: 6689
		private static readonly IntPtr NativeFieldInfoPtr_effectPrefab;

		// Token: 0x04001A22 RID: 6690
		private static readonly IntPtr NativeFieldInfoPtr_effectPositionOffset;

		// Token: 0x04001A23 RID: 6691
		private static readonly IntPtr NativeFieldInfoPtr_effectDestroyDelay;

		// Token: 0x04001A24 RID: 6692
		private static readonly IntPtr NativeFieldInfoPtr_effectTransitionDuration;

		// Token: 0x04001A25 RID: 6693
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04001A26 RID: 6694
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
