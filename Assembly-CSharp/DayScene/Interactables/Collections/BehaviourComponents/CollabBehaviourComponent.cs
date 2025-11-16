using System;
using DayScene.UI;
using GameData.Core.Collections;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x0200017C RID: 380
	public class CollabBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x0600298B RID: 10635 RVA: 0x00128990 File Offset: 0x00126B90
		// Note: this type is marked as 'beforefieldinit'.
		static CollabBehaviourComponent()
		{
			Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "CollabBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr);
			CollabBehaviourComponent.NativeFieldInfoPtr_welcomeDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, "welcomeDialog");
			CollabBehaviourComponent.NativeFieldInfoPtr_closeCollabConfirmDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, "closeCollabConfirmDialog");
			CollabBehaviourComponent.NativeFieldInfoPtr_collabClosedDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, "collabClosedDialog");
			CollabBehaviourComponent.NativeFieldInfoPtr_pannelCloseDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, "pannelCloseDialog");
			CollabBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, 100670542);
			CollabBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, 100670543);
			CollabBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, 100670544);
		}

		// Token: 0x0600298C RID: 10636 RVA: 0x00128A4C File Offset: 0x00126C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93564, XrefRangeEnd = 93637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollabBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298D RID: 10637 RVA: 0x00128A88 File Offset: 0x00126C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93637, XrefRangeEnd = 93642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CollabBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298E RID: 10638 RVA: 0x00128AC4 File Offset: 0x00126CC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollabBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600298F RID: 10639 RVA: 0x00018474 File Offset: 0x00016674
		public CollabBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E48 RID: 3656
		// (get) Token: 0x06002990 RID: 10640 RVA: 0x00128B00 File Offset: 0x00126D00
		// (set) Token: 0x06002991 RID: 10641 RVA: 0x0001847D File Offset: 0x0001667D
		public unsafe DialogPackage welcomeDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.NativeFieldInfoPtr_welcomeDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.NativeFieldInfoPtr_welcomeDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E49 RID: 3657
		// (get) Token: 0x06002992 RID: 10642 RVA: 0x00128B30 File Offset: 0x00126D30
		// (set) Token: 0x06002993 RID: 10643 RVA: 0x0001849C File Offset: 0x0001669C
		public unsafe DialogPackage closeCollabConfirmDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.NativeFieldInfoPtr_closeCollabConfirmDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.NativeFieldInfoPtr_closeCollabConfirmDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x00128B60 File Offset: 0x00126D60
		// (set) Token: 0x06002995 RID: 10645 RVA: 0x000184BB File Offset: 0x000166BB
		public unsafe DialogPackage collabClosedDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.NativeFieldInfoPtr_collabClosedDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.NativeFieldInfoPtr_collabClosedDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x06002996 RID: 10646 RVA: 0x00128B90 File Offset: 0x00126D90
		// (set) Token: 0x06002997 RID: 10647 RVA: 0x000184DA File Offset: 0x000166DA
		public unsafe DialogPackage pannelCloseDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.NativeFieldInfoPtr_pannelCloseDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.NativeFieldInfoPtr_pannelCloseDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B79 RID: 7033
		private static readonly IntPtr NativeFieldInfoPtr_welcomeDialog;

		// Token: 0x04001B7A RID: 7034
		private static readonly IntPtr NativeFieldInfoPtr_closeCollabConfirmDialog;

		// Token: 0x04001B7B RID: 7035
		private static readonly IntPtr NativeFieldInfoPtr_collabClosedDialog;

		// Token: 0x04001B7C RID: 7036
		private static readonly IntPtr NativeFieldInfoPtr_pannelCloseDialog;

		// Token: 0x04001B7D RID: 7037
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B7E RID: 7038
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B7F RID: 7039
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200079D RID: 1949
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.CollabBehaviourComponent+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600A3F6 RID: 41974 RVA: 0x002AF4D4 File Offset: 0x002AD6D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr);
				CollabBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				CollabBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr_allDialogSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, "allDialogSelections");
				CollabBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, 100670545);
				CollabBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, 100670546);
				CollabBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, 100670547);
			}

			// Token: 0x0600A3F7 RID: 41975 RVA: 0x002AF564 File Offset: 0x002AD764
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3F8 RID: 41976 RVA: 0x002AF5A0 File Offset: 0x002AD7A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93430, XrefRangeEnd = 93445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3F9 RID: 41977 RVA: 0x002AF5D4 File Offset: 0x002AD7D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93445, XrefRangeEnd = 93464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Action_PDM_0(Action closePannelCallback)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(closePannelCallback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr_Method_Internal_Void_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3FA RID: 41978 RVA: 0x00058839 File Offset: 0x00056A39
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700360C RID: 13836
			// (get) Token: 0x0600A3FB RID: 41979 RVA: 0x002AF618 File Offset: 0x002AD818
			// (set) Token: 0x0600A3FC RID: 41980 RVA: 0x00058842 File Offset: 0x00056A42
			public unsafe CollabBehaviourComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollabBehaviourComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700360D RID: 13837
			// (get) Token: 0x0600A3FD RID: 41981 RVA: 0x002AF648 File Offset: 0x002AD848
			// (set) Token: 0x0600A3FE RID: 41982 RVA: 0x00058861 File Offset: 0x00056A61
			public unsafe List<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback> allDialogSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr_allDialogSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DaySceneChatSelectionPannel.GetSelectionConfigurationCallback>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr_allDialogSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A21 RID: 27169
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006A22 RID: 27170
			private static readonly IntPtr NativeFieldInfoPtr_allDialogSelections;

			// Token: 0x04006A23 RID: 27171
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A24 RID: 27172
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04006A25 RID: 27173
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Action_PDM_0;
		}

		// Token: 0x0200079E RID: 1950
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.CollabBehaviourComponent+<>c__DisplayClass4_1")]
		public sealed class __c__DisplayClass4_1 : Object
		{
			// Token: 0x0600A3FF RID: 41983 RVA: 0x002AF678 File Offset: 0x002AD878
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_1()
			{
				Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass4_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_1>.NativeClassPtr);
				CollabBehaviourComponent.__c__DisplayClass4_1.NativeFieldInfoPtr_thisCollabPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_1>.NativeClassPtr, "thisCollabPackage");
				CollabBehaviourComponent.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_1>.NativeClassPtr, "CS$<>8__locals1");
				CollabBehaviourComponent.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_1>.NativeClassPtr, 100670548);
				CollabBehaviourComponent.__c__DisplayClass4_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_1>.NativeClassPtr, 100670549);
			}

			// Token: 0x0600A400 RID: 41984 RVA: 0x002AF6F4 File Offset: 0x002AD8F4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A401 RID: 41985 RVA: 0x002AF730 File Offset: 0x002AD930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93464, XrefRangeEnd = 93488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
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
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600A402 RID: 41986 RVA: 0x00058880 File Offset: 0x00056A80
			public __c__DisplayClass4_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700360E RID: 13838
			// (get) Token: 0x0600A403 RID: 41987 RVA: 0x002AF7C0 File Offset: 0x002AD9C0
			// (set) Token: 0x0600A404 RID: 41988 RVA: 0x00058889 File Offset: 0x00056A89
			public unsafe CollabPackage thisCollabPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_1.NativeFieldInfoPtr_thisCollabPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollabPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_1.NativeFieldInfoPtr_thisCollabPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700360F RID: 13839
			// (get) Token: 0x0600A405 RID: 41989 RVA: 0x002AF7F0 File Offset: 0x002AD9F0
			// (set) Token: 0x0600A406 RID: 41990 RVA: 0x000588A8 File Offset: 0x00056AA8
			public unsafe CollabBehaviourComponent.__c__DisplayClass4_0 field_Public___c__DisplayClass4_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollabBehaviourComponent.__c__DisplayClass4_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_1.NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A26 RID: 27174
			private static readonly IntPtr NativeFieldInfoPtr_thisCollabPackage;

			// Token: 0x04006A27 RID: 27175
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass4_0_0;

			// Token: 0x04006A28 RID: 27176
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A29 RID: 27177
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;
		}

		// Token: 0x0200079F RID: 1951
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.CollabBehaviourComponent+<>c__DisplayClass4_2")]
		public sealed class __c__DisplayClass4_2 : Object
		{
			// Token: 0x0600A407 RID: 41991 RVA: 0x002AF820 File Offset: 0x002ADA20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_2()
			{
				Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass4_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr);
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr_exit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, "exit");
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, "label");
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr_field_Public___c__DisplayClass4_1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, "CS$<>8__locals2");
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, "<>9__5");
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, "<>9__7");
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, "<>9__8");
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, "<>9__10");
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, 100670550);
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, 100670551);
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, 100670552);
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, 100670553);
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, 100670554);
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, 100670555);
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__8_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, 100670556);
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, 100670557);
				CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__10_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr, 100670558);
			}

			// Token: 0x0600A408 RID: 41992 RVA: 0x002AF98C File Offset: 0x002ADB8C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollabBehaviourComponent.__c__DisplayClass4_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A409 RID: 41993 RVA: 0x002AF9C8 File Offset: 0x002ADBC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93488, XrefRangeEnd = 93499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A40A RID: 41994 RVA: 0x002AF9FC File Offset: 0x002ADBFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93499, XrefRangeEnd = 93510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A40B RID: 41995 RVA: 0x002AFA30 File Offset: 0x002ADC30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93510, XrefRangeEnd = 93521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_0(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A40C RID: 41996 RVA: 0x002AFA70 File Offset: 0x002ADC70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93521, XrefRangeEnd = 93525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A40D RID: 41997 RVA: 0x002AFAA4 File Offset: 0x002ADCA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93525, XrefRangeEnd = 93536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A40E RID: 41998 RVA: 0x002AFAD8 File Offset: 0x002ADCD8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93536, XrefRangeEnd = 93547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__8()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__8_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A40F RID: 41999 RVA: 0x002AFB0C File Offset: 0x002ADD0C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93547, XrefRangeEnd = 93558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Boolean_PDM_1(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A410 RID: 42000 RVA: 0x002AFB4C File Offset: 0x002ADD4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93558, XrefRangeEnd = 93562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__10()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c__DisplayClass4_2.NativeMethodInfoPtr__OnInteract_b__10_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A411 RID: 42001 RVA: 0x000588C7 File Offset: 0x00056AC7
			public __c__DisplayClass4_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003610 RID: 13840
			// (get) Token: 0x0600A412 RID: 42002 RVA: 0x002AFB80 File Offset: 0x002ADD80
			// (set) Token: 0x0600A413 RID: 42003 RVA: 0x000588D0 File Offset: 0x00056AD0
			public unsafe Action exit
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr_exit);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr_exit), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003611 RID: 13841
			// (get) Token: 0x0600A414 RID: 42004 RVA: 0x002AFBB0 File Offset: 0x002ADDB0
			// (set) Token: 0x0600A415 RID: 42005 RVA: 0x000588EF File Offset: 0x00056AEF
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003612 RID: 13842
			// (get) Token: 0x0600A416 RID: 42006 RVA: 0x002AFBD8 File Offset: 0x002ADDD8
			// (set) Token: 0x0600A417 RID: 42007 RVA: 0x0005890E File Offset: 0x00056B0E
			public unsafe CollabBehaviourComponent.__c__DisplayClass4_1 field_Public___c__DisplayClass4_1_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr_field_Public___c__DisplayClass4_1_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollabBehaviourComponent.__c__DisplayClass4_1>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr_field_Public___c__DisplayClass4_1_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003613 RID: 13843
			// (get) Token: 0x0600A418 RID: 42008 RVA: 0x002AFC08 File Offset: 0x002ADE08
			// (set) Token: 0x0600A419 RID: 42009 RVA: 0x0005892D File Offset: 0x00056B2D
			public unsafe Action __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003614 RID: 13844
			// (get) Token: 0x0600A41A RID: 42010 RVA: 0x002AFC38 File Offset: 0x002ADE38
			// (set) Token: 0x0600A41B RID: 42011 RVA: 0x0005894C File Offset: 0x00056B4C
			public unsafe Action __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003615 RID: 13845
			// (get) Token: 0x0600A41C RID: 42012 RVA: 0x002AFC68 File Offset: 0x002ADE68
			// (set) Token: 0x0600A41D RID: 42013 RVA: 0x0005896B File Offset: 0x00056B6B
			public unsafe Action __9__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__8);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__8), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003616 RID: 13846
			// (get) Token: 0x0600A41E RID: 42014 RVA: 0x002AFC98 File Offset: 0x002ADE98
			// (set) Token: 0x0600A41F RID: 42015 RVA: 0x0005898A File Offset: 0x00056B8A
			public unsafe Action __9__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__10);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollabBehaviourComponent.__c__DisplayClass4_2.NativeFieldInfoPtr___9__10), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A2A RID: 27178
			private static readonly IntPtr NativeFieldInfoPtr_exit;

			// Token: 0x04006A2B RID: 27179
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x04006A2C RID: 27180
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass4_1_0;

			// Token: 0x04006A2D RID: 27181
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x04006A2E RID: 27182
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x04006A2F RID: 27183
			private static readonly IntPtr NativeFieldInfoPtr___9__8;

			// Token: 0x04006A30 RID: 27184
			private static readonly IntPtr NativeFieldInfoPtr___9__10;

			// Token: 0x04006A31 RID: 27185
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A32 RID: 27186
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__3_Internal_Void_0;

			// Token: 0x04006A33 RID: 27187
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__5_Internal_Void_0;

			// Token: 0x04006A34 RID: 27188
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_0;

			// Token: 0x04006A35 RID: 27189
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__7_Internal_Void_0;

			// Token: 0x04006A36 RID: 27190
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__4_Internal_Void_0;

			// Token: 0x04006A37 RID: 27191
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__8_Internal_Void_0;

			// Token: 0x04006A38 RID: 27192
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Boolean_PDM_1;

			// Token: 0x04006A39 RID: 27193
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__10_Internal_Void_0;
		}

		// Token: 0x020007A0 RID: 1952
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.CollabBehaviourComponent+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600A420 RID: 42016 RVA: 0x002AFCC8 File Offset: 0x002ADEC8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CollabBehaviourComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CollabBehaviourComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollabBehaviourComponent.__c>.NativeClassPtr);
				CollabBehaviourComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c>.NativeClassPtr, "<>9");
				CollabBehaviourComponent.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c>.NativeClassPtr, "<>9__4_0");
				CollabBehaviourComponent.__c.NativeFieldInfoPtr___9__4_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollabBehaviourComponent.__c>.NativeClassPtr, "<>9__4_12");
				CollabBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c>.NativeClassPtr, 100670560);
				CollabBehaviourComponent.__c.NativeMethodInfoPtr__OnInteract_b__4_0_Internal_Boolean_CollabPackage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c>.NativeClassPtr, 100670561);
				CollabBehaviourComponent.__c.NativeMethodInfoPtr__OnInteract_b__4_12_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollabBehaviourComponent.__c>.NativeClassPtr, 100670562);
			}

			// Token: 0x0600A421 RID: 42017 RVA: 0x002AFD6C File Offset: 0x002ADF6C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollabBehaviourComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A422 RID: 42018 RVA: 0x002AFDA8 File Offset: 0x002ADFA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93562, XrefRangeEnd = 93564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnInteract_b__4_0(CollabPackage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c.NativeMethodInfoPtr__OnInteract_b__4_0_Internal_Boolean_CollabPackage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A423 RID: 42019 RVA: 0x002AFDF8 File Offset: 0x002ADFF8
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__4_12()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollabBehaviourComponent.__c.NativeMethodInfoPtr__OnInteract_b__4_12_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A424 RID: 42020 RVA: 0x000589A9 File Offset: 0x00056BA9
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003617 RID: 13847
			// (get) Token: 0x0600A425 RID: 42021 RVA: 0x002AFE2C File Offset: 0x002AE02C
			// (set) Token: 0x0600A426 RID: 42022 RVA: 0x000589B2 File Offset: 0x00056BB2
			public unsafe static CollabBehaviourComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CollabBehaviourComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CollabBehaviourComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CollabBehaviourComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003618 RID: 13848
			// (get) Token: 0x0600A427 RID: 42023 RVA: 0x002AFE54 File Offset: 0x002AE054
			// (set) Token: 0x0600A428 RID: 42024 RVA: 0x000589C4 File Offset: 0x00056BC4
			public unsafe static Func<CollabPackage, bool> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CollabBehaviourComponent.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<CollabPackage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CollabBehaviourComponent.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003619 RID: 13849
			// (get) Token: 0x0600A429 RID: 42025 RVA: 0x002AFE7C File Offset: 0x002AE07C
			// (set) Token: 0x0600A42A RID: 42026 RVA: 0x000589D6 File Offset: 0x00056BD6
			public unsafe static Action __9__4_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CollabBehaviourComponent.__c.NativeFieldInfoPtr___9__4_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CollabBehaviourComponent.__c.NativeFieldInfoPtr___9__4_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006A3A RID: 27194
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006A3B RID: 27195
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x04006A3C RID: 27196
			private static readonly IntPtr NativeFieldInfoPtr___9__4_12;

			// Token: 0x04006A3D RID: 27197
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006A3E RID: 27198
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__4_0_Internal_Boolean_CollabPackage_0;

			// Token: 0x04006A3F RID: 27199
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__4_12_Internal_Void_0;
		}
	}
}
