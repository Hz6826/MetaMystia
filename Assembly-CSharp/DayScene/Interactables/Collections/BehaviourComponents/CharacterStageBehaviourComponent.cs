using System;
using Common.CharacterUtility;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000175 RID: 373
	public class CharacterStageBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x06002902 RID: 10498 RVA: 0x00126ED8 File Offset: 0x001250D8
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterStageBehaviourComponent()
		{
			Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "CharacterStageBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr);
			CharacterStageBehaviourComponent.NativeFieldInfoPtr_eventType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr, "eventType");
			CharacterStageBehaviourComponent.NativeFieldInfoPtr_chatDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr, "chatDialog");
			CharacterStageBehaviourComponent.NativeFieldInfoPtr_chatTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr, "chatTimeline");
			CharacterStageBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr, 100670472);
			CharacterStageBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr, 100670473);
			CharacterStageBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr, 100670474);
		}

		// Token: 0x06002903 RID: 10499 RVA: 0x00126F80 File Offset: 0x00125180
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92853, XrefRangeEnd = 92883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterStageBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002904 RID: 10500 RVA: 0x00126FBC File Offset: 0x001251BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92883, XrefRangeEnd = 92886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterStageBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002905 RID: 10501 RVA: 0x00126FF8 File Offset: 0x001251F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterStageBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterStageBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002906 RID: 10502 RVA: 0x00017FDD File Offset: 0x000161DD
		public CharacterStageBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x00127034 File Offset: 0x00125234
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x00017FE6 File Offset: 0x000161E6
		public unsafe CharacterStageBehaviourComponent.EventType eventType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.NativeFieldInfoPtr_eventType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.NativeFieldInfoPtr_eventType)) = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x0012705C File Offset: 0x0012525C
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x00018001 File Offset: 0x00016201
		public unsafe DialogPackage chatDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.NativeFieldInfoPtr_chatDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.NativeFieldInfoPtr_chatDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x0600290B RID: 10507 RVA: 0x0012708C File Offset: 0x0012528C
		// (set) Token: 0x0600290C RID: 10508 RVA: 0x00018020 File Offset: 0x00016220
		public unsafe PlayableAsset chatTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.NativeFieldInfoPtr_chatTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.NativeFieldInfoPtr_chatTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B25 RID: 6949
		private static readonly IntPtr NativeFieldInfoPtr_eventType;

		// Token: 0x04001B26 RID: 6950
		private static readonly IntPtr NativeFieldInfoPtr_chatDialog;

		// Token: 0x04001B27 RID: 6951
		private static readonly IntPtr NativeFieldInfoPtr_chatTimeline;

		// Token: 0x04001B28 RID: 6952
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B29 RID: 6953
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B2A RID: 6954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000796 RID: 1942
		public enum EventType : byte
		{
			// Token: 0x040069F5 RID: 27125
			Dialog,
			// Token: 0x040069F6 RID: 27126
			Timeline
		}

		// Token: 0x02000797 RID: 1943
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.CharacterStageBehaviourComponent+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600A3AE RID: 41902 RVA: 0x002AE5E0 File Offset: 0x002AC7E0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CharacterStageBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterStageBehaviourComponent>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterStageBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr);
				CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterStageBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, "controller");
				CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr_oldRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterStageBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, "oldRotation");
				CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterStageBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, 100670475);
				CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr__OnInteract_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterStageBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, 100670476);
				CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr__OnInteract_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterStageBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr, 100670477);
			}

			// Token: 0x0600A3AF RID: 41903 RVA: 0x002AE670 File Offset: 0x002AC870
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterStageBehaviourComponent.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3B0 RID: 41904 RVA: 0x002AE6AC File Offset: 0x002AC8AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92845, XrefRangeEnd = 92847, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr__OnInteract_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3B1 RID: 41905 RVA: 0x002AE6E0 File Offset: 0x002AC8E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92847, XrefRangeEnd = 92853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnInteract_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeMethodInfoPtr__OnInteract_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A3B2 RID: 41906 RVA: 0x00058611 File Offset: 0x00056811
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035FA RID: 13818
			// (get) Token: 0x0600A3B3 RID: 41907 RVA: 0x002AE714 File Offset: 0x002AC914
			// (set) Token: 0x0600A3B4 RID: 41908 RVA: 0x0005861A File Offset: 0x0005681A
			public unsafe CharacterControllerUnit controller
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr_controller);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035FB RID: 13819
			// (get) Token: 0x0600A3B5 RID: 41909 RVA: 0x002AE744 File Offset: 0x002AC944
			// (set) Token: 0x0600A3B6 RID: 41910 RVA: 0x00058639 File Offset: 0x00056839
			public unsafe int oldRotation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr_oldRotation);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterStageBehaviourComponent.__c__DisplayClass4_0.NativeFieldInfoPtr_oldRotation)) = value;
				}
			}

			// Token: 0x040069F7 RID: 27127
			private static readonly IntPtr NativeFieldInfoPtr_controller;

			// Token: 0x040069F8 RID: 27128
			private static readonly IntPtr NativeFieldInfoPtr_oldRotation;

			// Token: 0x040069F9 RID: 27129
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040069FA RID: 27130
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__0_Internal_Void_0;

			// Token: 0x040069FB RID: 27131
			private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__1_Internal_Void_0;
		}
	}
}
