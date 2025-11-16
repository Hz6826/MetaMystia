using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x02000411 RID: 1041
	public class COM_WorldOverlay_Set : PlayableAsset
	{
		// Token: 0x0600779E RID: 30622 RVA: 0x0022C96C File Offset: 0x0022AB6C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_Set()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_Set");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr);
			COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "spriteGameObject");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectEN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "spriteGameObjectEN");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectJP = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "spriteGameObjectJP");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectKO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "spriteGameObjectKO");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectCNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "spriteGameObjectCNT");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_characterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "characterMode");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "characterLabel");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "worldPosition");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "label");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "transitionDuration");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_uiMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "uiMode");
			COM_WorldOverlay_Set.NativeFieldInfoPtr_tutorialMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, "tutorialMode");
			COM_WorldOverlay_Set.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, 100687589);
			COM_WorldOverlay_Set.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr, 100687590);
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x0022CAB4 File Offset: 0x0022ACB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293304, XrefRangeEnd = 293350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_Set.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x0022CB1C File Offset: 0x0022AD1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293350, XrefRangeEnd = 293351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_Set() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_Set>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_Set.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x00040A8F File Offset: 0x0003EC8F
		public COM_WorldOverlay_Set(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x060077A2 RID: 30626 RVA: 0x0022CB58 File Offset: 0x0022AD58
		// (set) Token: 0x060077A3 RID: 30627 RVA: 0x00040A98 File Offset: 0x0003EC98
		public unsafe GameObject spriteGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x060077A4 RID: 30628 RVA: 0x0022CB88 File Offset: 0x0022AD88
		// (set) Token: 0x060077A5 RID: 30629 RVA: 0x00040AB7 File Offset: 0x0003ECB7
		public unsafe GameObject spriteGameObjectEN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectEN);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectEN), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B5 RID: 10421
		// (get) Token: 0x060077A6 RID: 30630 RVA: 0x0022CBB8 File Offset: 0x0022ADB8
		// (set) Token: 0x060077A7 RID: 30631 RVA: 0x00040AD6 File Offset: 0x0003ECD6
		public unsafe GameObject spriteGameObjectJP
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectJP);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectJP), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B6 RID: 10422
		// (get) Token: 0x060077A8 RID: 30632 RVA: 0x0022CBE8 File Offset: 0x0022ADE8
		// (set) Token: 0x060077A9 RID: 30633 RVA: 0x00040AF5 File Offset: 0x0003ECF5
		public unsafe GameObject spriteGameObjectKO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectKO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectKO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B7 RID: 10423
		// (get) Token: 0x060077AA RID: 30634 RVA: 0x0022CC18 File Offset: 0x0022AE18
		// (set) Token: 0x060077AB RID: 30635 RVA: 0x00040B14 File Offset: 0x0003ED14
		public unsafe GameObject spriteGameObjectCNT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectCNT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_spriteGameObjectCNT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028B8 RID: 10424
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x0022CC48 File Offset: 0x0022AE48
		// (set) Token: 0x060077AD RID: 30637 RVA: 0x00040B33 File Offset: 0x0003ED33
		public unsafe bool characterMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_characterMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_characterMode)) = value;
			}
		}

		// Token: 0x170028B9 RID: 10425
		// (get) Token: 0x060077AE RID: 30638 RVA: 0x0022CC70 File Offset: 0x0022AE70
		// (set) Token: 0x060077AF RID: 30639 RVA: 0x00040B4E File Offset: 0x0003ED4E
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028BA RID: 10426
		// (get) Token: 0x060077B0 RID: 30640 RVA: 0x0022CC98 File Offset: 0x0022AE98
		// (set) Token: 0x060077B1 RID: 30641 RVA: 0x00040B6D File Offset: 0x0003ED6D
		public unsafe Vector2 worldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_worldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_worldPosition)) = value;
			}
		}

		// Token: 0x170028BB RID: 10427
		// (get) Token: 0x060077B2 RID: 30642 RVA: 0x0022CCC0 File Offset: 0x0022AEC0
		// (set) Token: 0x060077B3 RID: 30643 RVA: 0x00040B88 File Offset: 0x0003ED88
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028BC RID: 10428
		// (get) Token: 0x060077B4 RID: 30644 RVA: 0x0022CCE8 File Offset: 0x0022AEE8
		// (set) Token: 0x060077B5 RID: 30645 RVA: 0x00040BA7 File Offset: 0x0003EDA7
		public unsafe float transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_transitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_transitionDuration)) = value;
			}
		}

		// Token: 0x170028BD RID: 10429
		// (get) Token: 0x060077B6 RID: 30646 RVA: 0x0022CD10 File Offset: 0x0022AF10
		// (set) Token: 0x060077B7 RID: 30647 RVA: 0x00040BC2 File Offset: 0x0003EDC2
		public unsafe bool uiMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_uiMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_uiMode)) = value;
			}
		}

		// Token: 0x170028BE RID: 10430
		// (get) Token: 0x060077B8 RID: 30648 RVA: 0x0022CD38 File Offset: 0x0022AF38
		// (set) Token: 0x060077B9 RID: 30649 RVA: 0x00040BDD File Offset: 0x0003EDDD
		public unsafe bool tutorialMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_tutorialMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set.NativeFieldInfoPtr_tutorialMode)) = value;
			}
		}

		// Token: 0x04004EFE RID: 20222
		private static readonly IntPtr NativeFieldInfoPtr_spriteGameObject;

		// Token: 0x04004EFF RID: 20223
		private static readonly IntPtr NativeFieldInfoPtr_spriteGameObjectEN;

		// Token: 0x04004F00 RID: 20224
		private static readonly IntPtr NativeFieldInfoPtr_spriteGameObjectJP;

		// Token: 0x04004F01 RID: 20225
		private static readonly IntPtr NativeFieldInfoPtr_spriteGameObjectKO;

		// Token: 0x04004F02 RID: 20226
		private static readonly IntPtr NativeFieldInfoPtr_spriteGameObjectCNT;

		// Token: 0x04004F03 RID: 20227
		private static readonly IntPtr NativeFieldInfoPtr_characterMode;

		// Token: 0x04004F04 RID: 20228
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04004F05 RID: 20229
		private static readonly IntPtr NativeFieldInfoPtr_worldPosition;

		// Token: 0x04004F06 RID: 20230
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F07 RID: 20231
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x04004F08 RID: 20232
		private static readonly IntPtr NativeFieldInfoPtr_uiMode;

		// Token: 0x04004F09 RID: 20233
		private static readonly IntPtr NativeFieldInfoPtr_tutorialMode;

		// Token: 0x04004F0A RID: 20234
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004F0B RID: 20235
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
