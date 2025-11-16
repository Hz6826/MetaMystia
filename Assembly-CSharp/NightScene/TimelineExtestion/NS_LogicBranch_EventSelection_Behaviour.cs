using System;
using Common.TimelineExtestion;
using DayScene.TimelineExtensions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace NightScene.TimelineExtestion
{
	// Token: 0x020001E8 RID: 488
	public class NS_LogicBranch_EventSelection_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06003C8A RID: 15498 RVA: 0x0016C32C File Offset: 0x0016A52C
		// Note: this type is marked as 'beforefieldinit'.
		static NS_LogicBranch_EventSelection_Behaviour()
		{
			Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "NightScene.TimelineExtestion", "NS_LogicBranch_EventSelection_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr);
			NS_LogicBranch_EventSelection_Behaviour.NativeFieldInfoPtr_eventOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr, "eventOptions");
			NS_LogicBranch_EventSelection_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr, 100674502);
			NS_LogicBranch_EventSelection_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr, 100674503);
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x0016C398 File Offset: 0x0016A598
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136883, XrefRangeEnd = 136915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NS_LogicBranch_EventSelection_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x0016C3D4 File Offset: 0x0016A5D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NS_LogicBranch_EventSelection_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_LogicBranch_EventSelection_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x00021F5D File Offset: 0x0002015D
		public NS_LogicBranch_EventSelection_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014CD RID: 5325
		// (get) Token: 0x06003C8E RID: 15502 RVA: 0x0016C410 File Offset: 0x0016A610
		// (set) Token: 0x06003C8F RID: 15503 RVA: 0x00021F66 File Offset: 0x00020166
		public unsafe Il2CppReferenceArray<DS_LogicBranch_EventSelection.EventOption> eventOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_EventSelection_Behaviour.NativeFieldInfoPtr_eventOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DS_LogicBranch_EventSelection.EventOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_EventSelection_Behaviour.NativeFieldInfoPtr_eventOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002899 RID: 10393
		private static readonly IntPtr NativeFieldInfoPtr_eventOptions;

		// Token: 0x0400289A RID: 10394
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x0400289B RID: 10395
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200097D RID: 2429
		[ObfuscatedName("NightScene.TimelineExtestion.NS_LogicBranch_EventSelection_Behaviour+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600BC67 RID: 48231 RVA: 0x002F60E8 File Offset: 0x002F42E8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr);
				NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_eventOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr, "eventOption");
				NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr, 100674504);
				NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__OnBehaviourEnter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr, 100674505);
			}

			// Token: 0x0600BC68 RID: 48232 RVA: 0x002F6150 File Offset: 0x002F4350
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC69 RID: 48233 RVA: 0x002F618C File Offset: 0x002F438C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136878, XrefRangeEnd = 136883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnter_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__OnBehaviourEnter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600BC6A RID: 48234 RVA: 0x000658AB File Offset: 0x00063AAB
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003D90 RID: 15760
			// (get) Token: 0x0600BC6B RID: 48235 RVA: 0x002F61C0 File Offset: 0x002F43C0
			// (set) Token: 0x0600BC6C RID: 48236 RVA: 0x000658B4 File Offset: 0x00063AB4
			public DS_LogicBranch_EventSelection.EventOption eventOption
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_eventOption);
					return new DS_LogicBranch_EventSelection.EventOption(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DS_LogicBranch_EventSelection.EventOption>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_eventOption), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DS_LogicBranch_EventSelection.EventOption>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040079AE RID: 31150
			private static readonly IntPtr NativeFieldInfoPtr_eventOption;

			// Token: 0x040079AF RID: 31151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040079B0 RID: 31152
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__0_Internal_Void_0;
		}
	}
}
