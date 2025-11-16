using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000415 RID: 1045
	public class COM_WorldOverlay_Set_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x060077CD RID: 30669 RVA: 0x0022D17C File Offset: 0x0022B37C
		// Note: this type is marked as 'beforefieldinit'.
		static COM_WorldOverlay_Set_Behaviour()
		{
			Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_WorldOverlay_Set_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr);
			COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_characterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, "characterLabel");
			COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_characterMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, "characterMode");
			COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, "label");
			COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_spriteGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, "spriteGameObject");
			COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_transitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, "transitionDuration");
			COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_tutorialMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, "tutorialMode");
			COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_uiMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, "uiMode");
			COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_worldPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, "worldPosition");
			COM_WorldOverlay_Set_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, 100687600);
			COM_WorldOverlay_Set_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr, 100687601);
		}

		// Token: 0x060077CE RID: 30670 RVA: 0x0022D274 File Offset: 0x0022B474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293415, XrefRangeEnd = 293419, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_WorldOverlay_Set_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077CF RID: 30671 RVA: 0x0022D2B0 File Offset: 0x0022B4B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293419, XrefRangeEnd = 293420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_WorldOverlay_Set_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_WorldOverlay_Set_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_WorldOverlay_Set_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060077D0 RID: 30672 RVA: 0x00040C51 File Offset: 0x0003EE51
		public COM_WorldOverlay_Set_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028C1 RID: 10433
		// (get) Token: 0x060077D1 RID: 30673 RVA: 0x0022D2EC File Offset: 0x0022B4EC
		// (set) Token: 0x060077D2 RID: 30674 RVA: 0x00040C5A File Offset: 0x0003EE5A
		public unsafe string characterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_characterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_characterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028C2 RID: 10434
		// (get) Token: 0x060077D3 RID: 30675 RVA: 0x0022D314 File Offset: 0x0022B514
		// (set) Token: 0x060077D4 RID: 30676 RVA: 0x00040C79 File Offset: 0x0003EE79
		public unsafe bool characterMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_characterMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_characterMode)) = value;
			}
		}

		// Token: 0x170028C3 RID: 10435
		// (get) Token: 0x060077D5 RID: 30677 RVA: 0x0022D33C File Offset: 0x0022B53C
		// (set) Token: 0x060077D6 RID: 30678 RVA: 0x00040C94 File Offset: 0x0003EE94
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x060077D7 RID: 30679 RVA: 0x0022D364 File Offset: 0x0022B564
		// (set) Token: 0x060077D8 RID: 30680 RVA: 0x00040CB3 File Offset: 0x0003EEB3
		public unsafe GameObject spriteGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_spriteGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_spriteGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x060077D9 RID: 30681 RVA: 0x0022D394 File Offset: 0x0022B594
		// (set) Token: 0x060077DA RID: 30682 RVA: 0x00040CD2 File Offset: 0x0003EED2
		public unsafe float transitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_transitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_transitionDuration)) = value;
			}
		}

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x060077DB RID: 30683 RVA: 0x0022D3BC File Offset: 0x0022B5BC
		// (set) Token: 0x060077DC RID: 30684 RVA: 0x00040CED File Offset: 0x0003EEED
		public unsafe bool tutorialMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_tutorialMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_tutorialMode)) = value;
			}
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x060077DD RID: 30685 RVA: 0x0022D3E4 File Offset: 0x0022B5E4
		// (set) Token: 0x060077DE RID: 30686 RVA: 0x00040D08 File Offset: 0x0003EF08
		public unsafe bool uiMode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_uiMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_uiMode)) = value;
			}
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x060077DF RID: 30687 RVA: 0x0022D40C File Offset: 0x0022B60C
		// (set) Token: 0x060077E0 RID: 30688 RVA: 0x00040D23 File Offset: 0x0003EF23
		public unsafe Vector2 worldPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_worldPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_WorldOverlay_Set_Behaviour.NativeFieldInfoPtr_worldPosition)) = value;
			}
		}

		// Token: 0x04004F17 RID: 20247
		private static readonly IntPtr NativeFieldInfoPtr_characterLabel;

		// Token: 0x04004F18 RID: 20248
		private static readonly IntPtr NativeFieldInfoPtr_characterMode;

		// Token: 0x04004F19 RID: 20249
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F1A RID: 20250
		private static readonly IntPtr NativeFieldInfoPtr_spriteGameObject;

		// Token: 0x04004F1B RID: 20251
		private static readonly IntPtr NativeFieldInfoPtr_transitionDuration;

		// Token: 0x04004F1C RID: 20252
		private static readonly IntPtr NativeFieldInfoPtr_tutorialMode;

		// Token: 0x04004F1D RID: 20253
		private static readonly IntPtr NativeFieldInfoPtr_uiMode;

		// Token: 0x04004F1E RID: 20254
		private static readonly IntPtr NativeFieldInfoPtr_worldPosition;

		// Token: 0x04004F1F RID: 20255
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F20 RID: 20256
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
