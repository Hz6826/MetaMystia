using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200017D RID: 381
	public class CreatorBoxBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x00128BC0 File Offset: 0x00126DC0
		// Note: this type is marked as 'beforefieldinit'.
		static CreatorBoxBehaviourComponent()
		{
			Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "CreatorBoxBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr);
			CreatorBoxBehaviourComponent.NativeFieldInfoPtr_activeSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, "activeSprite");
			CreatorBoxBehaviourComponent.NativeFieldInfoPtr_inactiveSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, "inactiveSprite");
			CreatorBoxBehaviourComponent.NativeFieldInfoPtr_baseSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, "baseSpriteRenderer");
			CreatorBoxBehaviourComponent.NativeFieldInfoPtr_outlineSpriteRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, "outlineSpriteRenderer");
			CreatorBoxBehaviourComponent.NativeFieldInfoPtr_manualDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, "manualDialog");
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670563);
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr_UpdateAppearance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670564);
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670565);
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr_OpenOption_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670566);
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr_get_CheckOpenStatus_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670567);
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr_SetCreatorBoxActive_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670568);
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr_EditCreatorBox_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670569);
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr_Manual_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670570);
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr_OnCloseButtonSubmit_Private_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670571);
			CreatorBoxBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, 100670572);
		}

		// Token: 0x06002999 RID: 10649 RVA: 0x00128D1C File Offset: 0x00126F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93670, XrefRangeEnd = 93672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreatorBoxBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x00128D58 File Offset: 0x00126F58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93678, RefRangeEnd = 93680, XrefRangeStart = 93672, XrefRangeEnd = 93678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.NativeMethodInfoPtr_UpdateAppearance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x00128D8C File Offset: 0x00126F8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93680, XrefRangeEnd = 93682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CreatorBoxBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x00128DC8 File Offset: 0x00126FC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 93719, RefRangeEnd = 93720, XrefRangeStart = 93682, XrefRangeEnd = 93719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenOption()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.NativeMethodInfoPtr_OpenOption_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x0600299D RID: 10653 RVA: 0x00128DFC File Offset: 0x00126FFC
		public unsafe bool CheckOpenStatus
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 93728, RefRangeEnd = 93730, XrefRangeStart = 93720, XrefRangeEnd = 93728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.NativeMethodInfoPtr_get_CheckOpenStatus_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x00128E38 File Offset: 0x00127038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93730, XrefRangeEnd = 93759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCreatorBoxActive(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.NativeMethodInfoPtr_SetCreatorBoxActive_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00128EC8 File Offset: 0x001270C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93759, XrefRangeEnd = 93776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditCreatorBox(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.NativeMethodInfoPtr_EditCreatorBox_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x00128F58 File Offset: 0x00127158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93776, XrefRangeEnd = 93794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Manual(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.NativeMethodInfoPtr_Manual_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x00128FE8 File Offset: 0x001271E8
		[CallerCount(0)]
		public unsafe static void OnCloseButtonSubmit(Action action)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.NativeMethodInfoPtr_OnCloseButtonSubmit_Private_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x00129020 File Offset: 0x00127220
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreatorBoxBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000184F9 File Offset: 0x000166F9
		public CreatorBoxBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E4C RID: 3660
		// (get) Token: 0x060029A4 RID: 10660 RVA: 0x0012905C File Offset: 0x0012725C
		// (set) Token: 0x060029A5 RID: 10661 RVA: 0x00018502 File Offset: 0x00016702
		public unsafe Sprite activeSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_activeSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_activeSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4D RID: 3661
		// (get) Token: 0x060029A6 RID: 10662 RVA: 0x0012908C File Offset: 0x0012728C
		// (set) Token: 0x060029A7 RID: 10663 RVA: 0x00018521 File Offset: 0x00016721
		public unsafe Sprite inactiveSprite
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_inactiveSprite);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_inactiveSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x060029A8 RID: 10664 RVA: 0x001290BC File Offset: 0x001272BC
		// (set) Token: 0x060029A9 RID: 10665 RVA: 0x00018540 File Offset: 0x00016740
		public unsafe SpriteRenderer baseSpriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_baseSpriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_baseSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x060029AA RID: 10666 RVA: 0x001290EC File Offset: 0x001272EC
		// (set) Token: 0x060029AB RID: 10667 RVA: 0x0001855F File Offset: 0x0001675F
		public unsafe SpriteRenderer outlineSpriteRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_outlineSpriteRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_outlineSpriteRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E50 RID: 3664
		// (get) Token: 0x060029AC RID: 10668 RVA: 0x0012911C File Offset: 0x0012731C
		// (set) Token: 0x060029AD RID: 10669 RVA: 0x0001857E File Offset: 0x0001677E
		public unsafe DialogPackage manualDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_manualDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.NativeFieldInfoPtr_manualDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B80 RID: 7040
		private static readonly IntPtr NativeFieldInfoPtr_activeSprite;

		// Token: 0x04001B81 RID: 7041
		private static readonly IntPtr NativeFieldInfoPtr_inactiveSprite;

		// Token: 0x04001B82 RID: 7042
		private static readonly IntPtr NativeFieldInfoPtr_baseSpriteRenderer;

		// Token: 0x04001B83 RID: 7043
		private static readonly IntPtr NativeFieldInfoPtr_outlineSpriteRenderer;

		// Token: 0x04001B84 RID: 7044
		private static readonly IntPtr NativeFieldInfoPtr_manualDialog;

		// Token: 0x04001B85 RID: 7045
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001B86 RID: 7046
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAppearance_Private_Void_0;

		// Token: 0x04001B87 RID: 7047
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B88 RID: 7048
		private static readonly IntPtr NativeMethodInfoPtr_OpenOption_Private_Void_0;

		// Token: 0x04001B89 RID: 7049
		private static readonly IntPtr NativeMethodInfoPtr_get_CheckOpenStatus_Private_get_Boolean_0;

		// Token: 0x04001B8A RID: 7050
		private static readonly IntPtr NativeMethodInfoPtr_SetCreatorBoxActive_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001B8B RID: 7051
		private static readonly IntPtr NativeMethodInfoPtr_EditCreatorBox_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001B8C RID: 7052
		private static readonly IntPtr NativeMethodInfoPtr_Manual_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001B8D RID: 7053
		private static readonly IntPtr NativeMethodInfoPtr_OnCloseButtonSubmit_Private_Static_Void_Action_0;

		// Token: 0x04001B8E RID: 7054
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007A1 RID: 1953
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.CreatorBoxBehaviourComponent+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A42B RID: 42027 RVA: 0x002AFEA4 File Offset: 0x002AE0A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass11_0>.NativeClassPtr);
				CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass11_0>.NativeClassPtr, "baseInteractData");
				CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_opened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass11_0>.NativeClassPtr, "opened");
				CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass11_0>.NativeClassPtr, 100670573);
				CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__SetCreatorBoxActive_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass11_0>.NativeClassPtr, 100670574);
			}

			// Token: 0x0600A42C RID: 42028 RVA: 0x002AFF34 File Offset: 0x002AE134
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A42D RID: 42029 RVA: 0x002AFF70 File Offset: 0x002AE170
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93642, XrefRangeEnd = 93660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetCreatorBoxActive_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeMethodInfoPtr__SetCreatorBoxActive_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A42E RID: 42030 RVA: 0x000589E8 File Offset: 0x00056BE8
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700361A RID: 13850
			// (get) Token: 0x0600A42F RID: 42031 RVA: 0x002AFFA4 File Offset: 0x002AE1A4
			// (set) Token: 0x0600A430 RID: 42032 RVA: 0x000589F1 File Offset: 0x00056BF1
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700361B RID: 13851
			// (get) Token: 0x0600A431 RID: 42033 RVA: 0x002AFFD4 File Offset: 0x002AE1D4
			// (set) Token: 0x0600A432 RID: 42034 RVA: 0x00058A10 File Offset: 0x00056C10
			public unsafe bool opened
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_opened);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeFieldInfoPtr_opened)) = value;
				}
			}

			// Token: 0x1700361C RID: 13852
			// (get) Token: 0x0600A433 RID: 42035 RVA: 0x002AFFFC File Offset: 0x002AE1FC
			// (set) Token: 0x0600A434 RID: 42036 RVA: 0x00058A2B File Offset: 0x00056C2B
			public unsafe CreatorBoxBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorBoxBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A40 RID: 27200
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006A41 RID: 27201
			private static readonly IntPtr NativeFieldInfoPtr_opened;

			// Token: 0x04006A42 RID: 27202
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A43 RID: 27203
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A44 RID: 27204
			private static readonly IntPtr NativeMethodInfoPtr__SetCreatorBoxActive_b__0_Internal_Void_0;
		}

		// Token: 0x020007A2 RID: 1954
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.CreatorBoxBehaviourComponent+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A435 RID: 42037 RVA: 0x002B002C File Offset: 0x002AE22C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass12_0>.NativeClassPtr);
				CreatorBoxBehaviourComponent.__c__DisplayClass12_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass12_0>.NativeClassPtr, "baseInteractData");
				CreatorBoxBehaviourComponent.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass12_0>.NativeClassPtr, 100670575);
				CreatorBoxBehaviourComponent.__c__DisplayClass12_0.NativeMethodInfoPtr__EditCreatorBox_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass12_0>.NativeClassPtr, 100670576);
			}

			// Token: 0x0600A436 RID: 42038 RVA: 0x002B0094 File Offset: 0x002AE294
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A437 RID: 42039 RVA: 0x002B00D0 File Offset: 0x002AE2D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _EditCreatorBox_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.__c__DisplayClass12_0.NativeMethodInfoPtr__EditCreatorBox_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A438 RID: 42040 RVA: 0x00058A4A File Offset: 0x00056C4A
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700361D RID: 13853
			// (get) Token: 0x0600A439 RID: 42041 RVA: 0x002B0104 File Offset: 0x002AE304
			// (set) Token: 0x0600A43A RID: 42042 RVA: 0x00058A53 File Offset: 0x00056C53
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass12_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass12_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A45 RID: 27205
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006A46 RID: 27206
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A47 RID: 27207
			private static readonly IntPtr NativeMethodInfoPtr__EditCreatorBox_b__0_Internal_Void_0;
		}

		// Token: 0x020007A3 RID: 1955
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.CreatorBoxBehaviourComponent+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A43B RID: 42043 RVA: 0x002B0134 File Offset: 0x002AE334
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CreatorBoxBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass13_0>.NativeClassPtr);
				CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass13_0>.NativeClassPtr, "baseInteractData");
				CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass13_0>.NativeClassPtr, 100670577);
				CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__Manual_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass13_0>.NativeClassPtr, 100670578);
			}

			// Token: 0x0600A43C RID: 42044 RVA: 0x002B01B0 File Offset: 0x002AE3B0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreatorBoxBehaviourComponent.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A43D RID: 42045 RVA: 0x002B01EC File Offset: 0x002AE3EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93660, XrefRangeEnd = 93670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Manual_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeMethodInfoPtr__Manual_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A43E RID: 42046 RVA: 0x00058A72 File Offset: 0x00056C72
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700361E RID: 13854
			// (get) Token: 0x0600A43F RID: 42047 RVA: 0x002B0220 File Offset: 0x002AE420
			// (set) Token: 0x0600A440 RID: 42048 RVA: 0x00058A7B File Offset: 0x00056C7B
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700361F RID: 13855
			// (get) Token: 0x0600A441 RID: 42049 RVA: 0x002B0250 File Offset: 0x002AE450
			// (set) Token: 0x0600A442 RID: 42050 RVA: 0x00058A9A File Offset: 0x00056C9A
			public unsafe CreatorBoxBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CreatorBoxBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CreatorBoxBehaviourComponent.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A48 RID: 27208
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006A49 RID: 27209
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A4A RID: 27210
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A4B RID: 27211
			private static readonly IntPtr NativeMethodInfoPtr__Manual_b__0_Internal_Void_0;
		}
	}
}
