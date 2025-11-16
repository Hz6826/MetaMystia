using System;
using DayScene.UI;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002A6 RID: 678
	[Serializable]
	public class KyoukoTutorialDataMultipleChoice : KyoukoTutorialData
	{
		// Token: 0x060055FB RID: 22011 RVA: 0x001C0508 File Offset: 0x001BE708
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialDataMultipleChoice()
		{
			Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialDataMultipleChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr);
			KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Abstract_Virtual_New_get_Il2CppReferenceArray_1_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, 100680810);
			KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_get_HaveFinishedTutorial_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, 100680811);
			KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, 100680812);
			KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_ChildSelectionExtraCheck_Protected_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, 100680813);
			KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_OpenChildData_Protected_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, 100680814);
			KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, 100680815);
			KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, 100680816);
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x060055FC RID: 22012 RVA: 0x001C05C4 File Offset: 0x001BE7C4
		public unsafe virtual Il2CppReferenceArray<KyoukoTutorialData> ChildKyoukoTutorialData
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Abstract_Virtual_New_get_Il2CppReferenceArray_1_KyoukoTutorialData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KyoukoTutorialData>>(intPtr3) : null;
			}
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x060055FD RID: 22013 RVA: 0x001C0610 File Offset: 0x001BE810
		public unsafe override bool HaveFinishedTutorial
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213912, XrefRangeEnd = 213931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_get_HaveFinishedTutorial_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x060055FE RID: 22014 RVA: 0x001C0658 File Offset: 0x001BE858
		public unsafe override bool NeedToShow
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213931, XrefRangeEnd = 213950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060055FF RID: 22015 RVA: 0x001C06A0 File Offset: 0x001BE8A0
		[CallerCount(0)]
		public unsafe virtual bool ChildSelectionExtraCheck(bool baseAvailability)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref baseAvailability;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_ChildSelectionExtraCheck_Protected_Virtual_New_Boolean_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005600 RID: 22016 RVA: 0x001C06F4 File Offset: 0x001BE8F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 214000, RefRangeEnd = 214001, XrefRangeStart = 213950, XrefRangeEnd = 214000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OpenChildData(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_OpenChildData_Protected_Void_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005601 RID: 22017 RVA: 0x001C0738 File Offset: 0x001BE938
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214001, XrefRangeEnd = 214002, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005602 RID: 22018 RVA: 0x001C0788 File Offset: 0x001BE988
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialDataMultipleChoice() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataMultipleChoice.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005603 RID: 22019 RVA: 0x0002E4C7 File Offset: 0x0002C6C7
		public KyoukoTutorialDataMultipleChoice(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x040039AD RID: 14765
		private static readonly IntPtr NativeMethodInfoPtr_get_ChildKyoukoTutorialData_Protected_Abstract_Virtual_New_get_Il2CppReferenceArray_1_KyoukoTutorialData_0;

		// Token: 0x040039AE RID: 14766
		private static readonly IntPtr NativeMethodInfoPtr_get_HaveFinishedTutorial_Public_Virtual_get_Boolean_0;

		// Token: 0x040039AF RID: 14767
		private static readonly IntPtr NativeMethodInfoPtr_get_NeedToShow_Public_Virtual_get_Boolean_0;

		// Token: 0x040039B0 RID: 14768
		private static readonly IntPtr NativeMethodInfoPtr_ChildSelectionExtraCheck_Protected_Virtual_New_Boolean_Boolean_0;

		// Token: 0x040039B1 RID: 14769
		private static readonly IntPtr NativeMethodInfoPtr_OpenChildData_Protected_Void_BaseInteractData_0;

		// Token: 0x040039B2 RID: 14770
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0;

		// Token: 0x040039B3 RID: 14771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000C5D RID: 3165
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialDataMultipleChoice+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E458 RID: 58456 RVA: 0x0036EB6C File Offset: 0x0036CD6C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c>.NativeClassPtr);
				KyoukoTutorialDataMultipleChoice.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c>.NativeClassPtr, "<>9");
				KyoukoTutorialDataMultipleChoice.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c>.NativeClassPtr, "<>9__3_0");
				KyoukoTutorialDataMultipleChoice.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c>.NativeClassPtr, "<>9__5_0");
				KyoukoTutorialDataMultipleChoice.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c>.NativeClassPtr, 100680818);
				KyoukoTutorialDataMultipleChoice.__c.NativeMethodInfoPtr__get_HaveFinishedTutorial_b__3_0_Internal_Boolean_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c>.NativeClassPtr, 100680819);
				KyoukoTutorialDataMultipleChoice.__c.NativeMethodInfoPtr__get_NeedToShow_b__5_0_Internal_Boolean_KyoukoTutorialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c>.NativeClassPtr, 100680820);
			}

			// Token: 0x0600E459 RID: 58457 RVA: 0x0036EC10 File Offset: 0x0036CE10
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataMultipleChoice.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E45A RID: 58458 RVA: 0x0036EC4C File Offset: 0x0036CE4C
			[CallerCount(0)]
			public unsafe bool _get_HaveFinishedTutorial_b__3_0(KyoukoTutorialData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataMultipleChoice.__c.NativeMethodInfoPtr__get_HaveFinishedTutorial_b__3_0_Internal_Boolean_KyoukoTutorialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E45B RID: 58459 RVA: 0x0036EC9C File Offset: 0x0036CE9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213906, XrefRangeEnd = 213907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _get_NeedToShow_b__5_0(KyoukoTutorialData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataMultipleChoice.__c.NativeMethodInfoPtr__get_NeedToShow_b__5_0_Internal_Boolean_KyoukoTutorialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E45C RID: 58460 RVA: 0x00079D26 File Offset: 0x00077F26
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A16 RID: 18966
			// (get) Token: 0x0600E45D RID: 58461 RVA: 0x0036ECEC File Offset: 0x0036CEEC
			// (set) Token: 0x0600E45E RID: 58462 RVA: 0x00079D2F File Offset: 0x00077F2F
			public unsafe static KyoukoTutorialDataMultipleChoice.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialDataMultipleChoice.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialDataMultipleChoice.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialDataMultipleChoice.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A17 RID: 18967
			// (get) Token: 0x0600E45F RID: 58463 RVA: 0x0036ED14 File Offset: 0x0036CF14
			// (set) Token: 0x0600E460 RID: 58464 RVA: 0x00079D41 File Offset: 0x00077F41
			public unsafe static Func<KyoukoTutorialData, bool> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialDataMultipleChoice.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KyoukoTutorialData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialDataMultipleChoice.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A18 RID: 18968
			// (get) Token: 0x0600E461 RID: 58465 RVA: 0x0036ED3C File Offset: 0x0036CF3C
			// (set) Token: 0x0600E462 RID: 58466 RVA: 0x00079D53 File Offset: 0x00077F53
			public unsafe static Func<KyoukoTutorialData, bool> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialDataMultipleChoice.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KyoukoTutorialData, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialDataMultipleChoice.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091ED RID: 37357
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040091EE RID: 37358
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x040091EF RID: 37359
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x040091F0 RID: 37360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091F1 RID: 37361
			private static readonly IntPtr NativeMethodInfoPtr__get_HaveFinishedTutorial_b__3_0_Internal_Boolean_KyoukoTutorialData_0;

			// Token: 0x040091F2 RID: 37362
			private static readonly IntPtr NativeMethodInfoPtr__get_NeedToShow_b__5_0_Internal_Boolean_KyoukoTutorialData_0;
		}

		// Token: 0x02000C5E RID: 3166
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialDataMultipleChoice+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600E463 RID: 58467 RVA: 0x0036ED64 File Offset: 0x0036CF64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0>.NativeClassPtr);
				KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0>.NativeClassPtr, 100680821);
				KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeMethodInfoPtr__OpenChildData_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0>.NativeClassPtr, 100680822);
			}

			// Token: 0x0600E464 RID: 58468 RVA: 0x0036EDE0 File Offset: 0x0036CFE0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E465 RID: 58469 RVA: 0x0036EE1C File Offset: 0x0036D01C
			[CallerCount(0)]
			public unsafe void _OpenChildData_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeMethodInfoPtr__OpenChildData_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E466 RID: 58470 RVA: 0x00079D65 File Offset: 0x00077F65
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A19 RID: 18969
			// (get) Token: 0x0600E467 RID: 58471 RVA: 0x0036EE50 File Offset: 0x0036D050
			// (set) Token: 0x0600E468 RID: 58472 RVA: 0x00079D6E File Offset: 0x00077F6E
			public unsafe KyoukoTutorialDataMultipleChoice __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialDataMultipleChoice>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A1A RID: 18970
			// (get) Token: 0x0600E469 RID: 58473 RVA: 0x0036EE80 File Offset: 0x0036D080
			// (set) Token: 0x0600E46A RID: 58474 RVA: 0x00079D8D File Offset: 0x00077F8D
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091F3 RID: 37363
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091F4 RID: 37364
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x040091F5 RID: 37365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091F6 RID: 37366
			private static readonly IntPtr NativeMethodInfoPtr__OpenChildData_b__0_Internal_Void_0;
		}

		// Token: 0x02000C5F RID: 3167
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialDataMultipleChoice+<>c__DisplayClass7_1")]
		public sealed class __c__DisplayClass7_1 : Object
		{
			// Token: 0x0600E46B RID: 58475 RVA: 0x0036EEB0 File Offset: 0x0036D0B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_1()
			{
				Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice>.NativeClassPtr, "<>c__DisplayClass7_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1>.NativeClassPtr);
				KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeFieldInfoPtr_tutorialData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1>.NativeClassPtr, "tutorialData");
				KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1>.NativeClassPtr, "CS$<>8__locals1");
				KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1>.NativeClassPtr, 100680823);
				KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1>.NativeClassPtr, 100680824);
			}

			// Token: 0x0600E46C RID: 58476 RVA: 0x0036EF2C File Offset: 0x0036D12C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E46D RID: 58477 RVA: 0x0036EF68 File Offset: 0x0036D168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213907, XrefRangeEnd = 213912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0(DaySceneChatSelectionPannel.BaseInteractData baseInteractData3, out string title3, out bool availability3, out Action onInteract3)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData3);
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability3;
				ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr2 = 0;
				ptr3 = &intPtr2;
				IntPtr intPtr4;
				IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
				Il2CppException.RaiseExceptionIfNecessary(intPtr4);
				title3 = IL2CPP.Il2CppStringToManaged(intPtr);
				IntPtr intPtr5 = intPtr2;
				onInteract3 = ((intPtr5 == 0) ? null : new Action(intPtr5));
			}

			// Token: 0x0600E46E RID: 58478 RVA: 0x00079DAC File Offset: 0x00077FAC
			public __c__DisplayClass7_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A1B RID: 18971
			// (get) Token: 0x0600E46F RID: 58479 RVA: 0x0036EFF8 File Offset: 0x0036D1F8
			// (set) Token: 0x0600E470 RID: 58480 RVA: 0x00079DB5 File Offset: 0x00077FB5
			public unsafe KyoukoTutorialData tutorialData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeFieldInfoPtr_tutorialData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeFieldInfoPtr_tutorialData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A1C RID: 18972
			// (get) Token: 0x0600E471 RID: 58481 RVA: 0x0036F028 File Offset: 0x0036D228
			// (set) Token: 0x0600E472 RID: 58482 RVA: 0x00079DD4 File Offset: 0x00077FD4
			public unsafe KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataMultipleChoice.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091F7 RID: 37367
			private static readonly IntPtr NativeFieldInfoPtr_tutorialData;

			// Token: 0x040091F8 RID: 37368
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;

			// Token: 0x040091F9 RID: 37369
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091FA RID: 37370
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_PDM_0;
		}
	}
}
