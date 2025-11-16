using System;
using DayScene.UI;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002BB RID: 699
	public class YuyukoExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x060056F3 RID: 22259 RVA: 0x001C363C File Offset: 0x001C183C
		// Note: this type is marked as 'beforefieldinit'.
		static YuyukoExtraDialogData()
		{
			Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "YuyukoExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr);
			YuyukoExtraDialogData.NativeFieldInfoPtr_CHAT_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr, "CHAT_KEY");
			YuyukoExtraDialogData.NativeFieldInfoPtr_challengeStartDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr, "challengeStartDialog");
			YuyukoExtraDialogData.NativeFieldInfoPtr_challengeStartEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr, "challengeStartEvent");
			YuyukoExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr, 100680995);
			YuyukoExtraDialogData.NativeMethodInfoPtr_Yuyuko_Challenge_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr, 100680996);
			YuyukoExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr, 100680997);
		}

		// Token: 0x060056F4 RID: 22260 RVA: 0x001C36E4 File Offset: 0x001C18E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215942, XrefRangeEnd = 215959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetSpecialGuestExtraDialogData(out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> prependSelection, out Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback> appendSelections)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), YuyukoExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x001C3764 File Offset: 0x001C1964
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215959, XrefRangeEnd = 215976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Yuyuko_Challenge(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(YuyukoExtraDialogData.NativeMethodInfoPtr_Yuyuko_Challenge_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x001C37F4 File Offset: 0x001C19F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe YuyukoExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x0002ED24 File Offset: 0x0002CF24
		public YuyukoExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x060056F8 RID: 22264 RVA: 0x001C3830 File Offset: 0x001C1A30
		// (set) Token: 0x060056F9 RID: 22265 RVA: 0x0002ED2D File Offset: 0x0002CF2D
		public unsafe static string CHAT_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(YuyukoExtraDialogData.NativeFieldInfoPtr_CHAT_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(YuyukoExtraDialogData.NativeFieldInfoPtr_CHAT_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x060056FA RID: 22266 RVA: 0x001C3850 File Offset: 0x001C1A50
		// (set) Token: 0x060056FB RID: 22267 RVA: 0x0002ED3F File Offset: 0x0002CF3F
		public unsafe DialogPackage challengeStartDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.NativeFieldInfoPtr_challengeStartDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.NativeFieldInfoPtr_challengeStartDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x060056FC RID: 22268 RVA: 0x001C3880 File Offset: 0x001C1A80
		// (set) Token: 0x060056FD RID: 22269 RVA: 0x0002ED5E File Offset: 0x0002CF5E
		public unsafe string challengeStartEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.NativeFieldInfoPtr_challengeStartEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.NativeFieldInfoPtr_challengeStartEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003A37 RID: 14903
		private static readonly IntPtr NativeFieldInfoPtr_CHAT_KEY;

		// Token: 0x04003A38 RID: 14904
		private static readonly IntPtr NativeFieldInfoPtr_challengeStartDialog;

		// Token: 0x04003A39 RID: 14905
		private static readonly IntPtr NativeFieldInfoPtr_challengeStartEvent;

		// Token: 0x04003A3A RID: 14906
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x04003A3B RID: 14907
		private static readonly IntPtr NativeMethodInfoPtr_Yuyuko_Challenge_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003A3C RID: 14908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C80 RID: 3200
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.YuyukoExtraDialogData+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600E601 RID: 58881 RVA: 0x003734A4 File Offset: 0x003716A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<YuyukoExtraDialogData>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr);
				YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr, "specialNPCInteractData");
				YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr, "<>4__this");
				YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr, "<>9__2");
				YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr, "<>9__1");
				YuyukoExtraDialogData.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr, 100680998);
				YuyukoExtraDialogData.__c__DisplayClass4_0.NativeMethodInfoPtr__Yuyuko_Challenge_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr, 100680999);
				YuyukoExtraDialogData.__c__DisplayClass4_0.NativeMethodInfoPtr__Yuyuko_Challenge_b__1_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr, 100681000);
				YuyukoExtraDialogData.__c__DisplayClass4_0.NativeMethodInfoPtr__Yuyuko_Challenge_b__2_Internal_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr, 100681001);
			}

			// Token: 0x0600E602 RID: 58882 RVA: 0x00373570 File Offset: 0x00371770
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<YuyukoExtraDialogData.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E603 RID: 58883 RVA: 0x003735AC File Offset: 0x003717AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215911, XrefRangeEnd = 215922, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Yuyuko_Challenge_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeMethodInfoPtr__Yuyuko_Challenge_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E604 RID: 58884 RVA: 0x003735E0 File Offset: 0x003717E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215922, XrefRangeEnd = 215934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Yuyuko_Challenge_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeMethodInfoPtr__Yuyuko_Challenge_b__1_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E605 RID: 58885 RVA: 0x00373614 File Offset: 0x00371814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215934, XrefRangeEnd = 215942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Yuyuko_Challenge_b__2(bool confirm)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref confirm;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeMethodInfoPtr__Yuyuko_Challenge_b__2_Internal_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E606 RID: 58886 RVA: 0x0007AD0F File Offset: 0x00078F0F
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A94 RID: 19092
			// (get) Token: 0x0600E607 RID: 58887 RVA: 0x00373654 File Offset: 0x00371854
			// (set) Token: 0x0600E608 RID: 58888 RVA: 0x0007AD18 File Offset: 0x00078F18
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A95 RID: 19093
			// (get) Token: 0x0600E609 RID: 58889 RVA: 0x00373684 File Offset: 0x00371884
			// (set) Token: 0x0600E60A RID: 58890 RVA: 0x0007AD37 File Offset: 0x00078F37
			public unsafe YuyukoExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<YuyukoExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A96 RID: 19094
			// (get) Token: 0x0600E60B RID: 58891 RVA: 0x003736B4 File Offset: 0x003718B4
			// (set) Token: 0x0600E60C RID: 58892 RVA: 0x0007AD56 File Offset: 0x00078F56
			public unsafe Action<bool> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A97 RID: 19095
			// (get) Token: 0x0600E60D RID: 58893 RVA: 0x003736E4 File Offset: 0x003718E4
			// (set) Token: 0x0600E60E RID: 58894 RVA: 0x0007AD75 File Offset: 0x00078F75
			public unsafe Action __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(YuyukoExtraDialogData.__c__DisplayClass4_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040092DE RID: 37598
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x040092DF RID: 37599
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040092E0 RID: 37600
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040092E1 RID: 37601
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040092E2 RID: 37602
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040092E3 RID: 37603
			private static readonly IntPtr NativeMethodInfoPtr__Yuyuko_Challenge_b__0_Internal_Void_0;

			// Token: 0x040092E4 RID: 37604
			private static readonly IntPtr NativeMethodInfoPtr__Yuyuko_Challenge_b__1_Internal_Void_0;

			// Token: 0x040092E5 RID: 37605
			private static readonly IntPtr NativeMethodInfoPtr__Yuyuko_Challenge_b__2_Internal_Void_Boolean_0;
		}
	}
}
