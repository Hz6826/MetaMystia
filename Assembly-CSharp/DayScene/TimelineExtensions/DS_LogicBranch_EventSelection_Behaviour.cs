using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000145 RID: 325
	public class DS_LogicBranch_EventSelection_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06002670 RID: 9840 RVA: 0x0011F4A8 File Offset: 0x0011D6A8
		// Note: this type is marked as 'beforefieldinit'.
		static DS_LogicBranch_EventSelection_Behaviour()
		{
			Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_LogicBranch_EventSelection_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr);
			DS_LogicBranch_EventSelection_Behaviour.NativeFieldInfoPtr_eventOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr, "eventOptions");
			DS_LogicBranch_EventSelection_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr, 100670193);
			DS_LogicBranch_EventSelection_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr, 100670194);
		}

		// Token: 0x06002671 RID: 9841 RVA: 0x0011F514 File Offset: 0x0011D714
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90241, XrefRangeEnd = 90273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_LogicBranch_EventSelection_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002672 RID: 9842 RVA: 0x0011F550 File Offset: 0x0011D750
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_LogicBranch_EventSelection_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_LogicBranch_EventSelection_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002673 RID: 9843 RVA: 0x00016AB3 File Offset: 0x00014CB3
		public DS_LogicBranch_EventSelection_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002674 RID: 9844 RVA: 0x0011F58C File Offset: 0x0011D78C
		// (set) Token: 0x06002675 RID: 9845 RVA: 0x00016ABC File Offset: 0x00014CBC
		public unsafe Il2CppReferenceArray<DS_LogicBranch_EventSelection.EventOption> eventOptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection_Behaviour.NativeFieldInfoPtr_eventOptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DS_LogicBranch_EventSelection.EventOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection_Behaviour.NativeFieldInfoPtr_eventOptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019A4 RID: 6564
		private static readonly IntPtr NativeFieldInfoPtr_eventOptions;

		// Token: 0x040019A5 RID: 6565
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x040019A6 RID: 6566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000782 RID: 1922
		[ObfuscatedName("DayScene.TimelineExtensions.DS_LogicBranch_EventSelection_Behaviour+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600A2D2 RID: 41682 RVA: 0x002ABED0 File Offset: 0x002AA0D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr);
				DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_eventOption = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr, "eventOption");
				DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr, 100670195);
				DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__OnBehaviourEnter_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr, 100670196);
			}

			// Token: 0x0600A2D3 RID: 41683 RVA: 0x002ABF38 File Offset: 0x002AA138
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2D4 RID: 41684 RVA: 0x002ABF74 File Offset: 0x002AA174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90236, XrefRangeEnd = 90241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnter_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__OnBehaviourEnter_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2D5 RID: 41685 RVA: 0x00057F70 File Offset: 0x00056170
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035BD RID: 13757
			// (get) Token: 0x0600A2D6 RID: 41686 RVA: 0x002ABFA8 File Offset: 0x002AA1A8
			// (set) Token: 0x0600A2D7 RID: 41687 RVA: 0x00057F79 File Offset: 0x00056179
			public DS_LogicBranch_EventSelection.EventOption eventOption
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_eventOption);
					return new DS_LogicBranch_EventSelection.EventOption(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DS_LogicBranch_EventSelection.EventOption>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_LogicBranch_EventSelection_Behaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_eventOption), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DS_LogicBranch_EventSelection.EventOption>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400696E RID: 26990
			private static readonly IntPtr NativeFieldInfoPtr_eventOption;

			// Token: 0x0400696F RID: 26991
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006970 RID: 26992
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__0_Internal_Void_0;
		}
	}
}
