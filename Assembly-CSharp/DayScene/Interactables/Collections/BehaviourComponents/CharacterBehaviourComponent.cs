using System;
using Common.CharacterUtility;
using DayScene.Interactables.Collections.ConditionComponents;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000174 RID: 372
	public class CharacterBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x060028FD RID: 10493 RVA: 0x00126DB8 File Offset: 0x00124FB8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterBehaviourComponent()
		{
			Il2CppClassPointerStore<CharacterBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "CharacterBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterBehaviourComponent>.NativeClassPtr);
			CharacterBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBehaviourComponent>.NativeClassPtr, 100670467);
			CharacterBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBehaviourComponent>.NativeClassPtr, 100670468);
			CharacterBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBehaviourComponent>.NativeClassPtr, 100670469);
		}

		// Token: 0x060028FE RID: 10494 RVA: 0x00126E24 File Offset: 0x00125024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92816, XrefRangeEnd = 92845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028FF RID: 10495 RVA: 0x00126E60 File Offset: 0x00125060
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002900 RID: 10496 RVA: 0x00126E9C File Offset: 0x0012509C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002901 RID: 10497 RVA: 0x00017FD4 File Offset: 0x000161D4
		public CharacterBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001B22 RID: 6946
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B23 RID: 6947
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B24 RID: 6948
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000795 RID: 1941
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.CharacterBehaviourComponent+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x0600A3A2 RID: 41890 RVA: 0x002AE41C File Offset: 0x002AC61C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<CharacterBehaviourComponent.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterBehaviourComponent.__c__DisplayClass0_0>.NativeClassPtr);
				CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_characterConditionComponent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBehaviourComponent.__c__DisplayClass0_0>.NativeClassPtr, "characterConditionComponent");
				CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_oldIsOverridePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBehaviourComponent.__c__DisplayClass0_0>.NativeClassPtr, "oldIsOverridePosition");
				CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBehaviourComponent.__c__DisplayClass0_0>.NativeClassPtr, "controller");
				CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_oldRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterBehaviourComponent.__c__DisplayClass0_0>.NativeClassPtr, "oldRotation");
				CharacterBehaviourComponent.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBehaviourComponent.__c__DisplayClass0_0>.NativeClassPtr, 100670470);
				CharacterBehaviourComponent.__c__DisplayClass0_0.NativeMethodInfoPtr__OnInteract_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterBehaviourComponent.__c__DisplayClass0_0>.NativeClassPtr, 100670471);
			}

			// Token: 0x0600A3A3 RID: 41891 RVA: 0x002AE4C0 File Offset: 0x002AC6C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterBehaviourComponent.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3A4 RID: 41892 RVA: 0x002AE4FC File Offset: 0x002AC6FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92812, XrefRangeEnd = 92816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeMethodInfoPtr__OnInteract_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3A5 RID: 41893 RVA: 0x00058594 File Offset: 0x00056794
			public __c__DisplayClass0_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035F6 RID: 13814
			// (get) Token: 0x0600A3A6 RID: 41894 RVA: 0x002AE530 File Offset: 0x002AC730
			// (set) Token: 0x0600A3A7 RID: 41895 RVA: 0x0005859D File Offset: 0x0005679D
			public unsafe CharacterConditionComponent characterConditionComponent
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_characterConditionComponent);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterConditionComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_characterConditionComponent), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035F7 RID: 13815
			// (get) Token: 0x0600A3A8 RID: 41896 RVA: 0x002AE560 File Offset: 0x002AC760
			// (set) Token: 0x0600A3A9 RID: 41897 RVA: 0x000585BC File Offset: 0x000567BC
			public unsafe bool oldIsOverridePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_oldIsOverridePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_oldIsOverridePosition)) = value;
				}
			}

			// Token: 0x170035F8 RID: 13816
			// (get) Token: 0x0600A3AA RID: 41898 RVA: 0x002AE588 File Offset: 0x002AC788
			// (set) Token: 0x0600A3AB RID: 41899 RVA: 0x000585D7 File Offset: 0x000567D7
			public unsafe CharacterControllerUnit controller
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_controller);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035F9 RID: 13817
			// (get) Token: 0x0600A3AC RID: 41900 RVA: 0x002AE5B8 File Offset: 0x002AC7B8
			// (set) Token: 0x0600A3AD RID: 41901 RVA: 0x000585F6 File Offset: 0x000567F6
			public unsafe int oldRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_oldRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterBehaviourComponent.__c__DisplayClass0_0.NativeFieldInfoPtr_oldRotation)) = value;
				}
			}

			// Token: 0x040069EE RID: 27118
			private static readonly IntPtr NativeFieldInfoPtr_characterConditionComponent;

			// Token: 0x040069EF RID: 27119
			private static readonly IntPtr NativeFieldInfoPtr_oldIsOverridePosition;

			// Token: 0x040069F0 RID: 27120
			private static readonly IntPtr NativeFieldInfoPtr_controller;

			// Token: 0x040069F1 RID: 27121
			private static readonly IntPtr NativeFieldInfoPtr_oldRotation;

			// Token: 0x040069F2 RID: 27122
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069F3 RID: 27123
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__0_Internal_Void_0;
		}
	}
}
