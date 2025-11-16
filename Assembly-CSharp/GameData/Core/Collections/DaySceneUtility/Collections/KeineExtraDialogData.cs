using System;
using Cysharp.Threading.Tasks;
using DayScene.UI;
using DEYU.AssetHandleUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.AddressableAssets;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002A1 RID: 673
	public class KeineExtraDialogData : SpecialGuestExtraDialogData
	{
		// Token: 0x0600558E RID: 21902 RVA: 0x001BEF2C File Offset: 0x001BD12C
		// Note: this type is marked as 'beforefieldinit'.
		static KeineExtraDialogData()
		{
			Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KeineExtraDialogData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr);
			KeineExtraDialogData.NativeFieldInfoPtr_PHRASE_KEY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, "PHRASE_KEY");
			KeineExtraDialogData.NativeFieldInfoPtr_m_PreEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, "m_PreEvent");
			KeineExtraDialogData.NativeFieldInfoPtr_m_StartTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, "m_StartTimeline");
			KeineExtraDialogData.NativeFieldInfoPtr_m_MemoryTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, "m_MemoryTimeline");
			KeineExtraDialogData.NativeFieldInfoPtr_m_FinishEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, "m_FinishEvent");
			KeineExtraDialogData.NativeFieldInfoPtr_m_AchievementEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, "m_AchievementEvent");
			KeineExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, 100680750);
			KeineExtraDialogData.NativeMethodInfoPtr_ReturnToMemory_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, 100680751);
			KeineExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, 100680752);
		}

		// Token: 0x0600558F RID: 21903 RVA: 0x001BF010 File Offset: 0x001BD210
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213583, XrefRangeEnd = 213600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeineExtraDialogData.NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr;
			prependSelection = ((intPtr5 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr5));
			IntPtr intPtr6 = intPtr2;
			appendSelections = ((intPtr6 == 0) ? null : new Il2CppReferenceArray<DaySceneChatSelectionPannel.GetSpecialNPCSelectionConfigurationCallback>(intPtr6));
		}

		// Token: 0x06005590 RID: 21904 RVA: 0x001BF090 File Offset: 0x001BD290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213600, XrefRangeEnd = 213625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReturnToMemory(DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData, out string title, out bool availability, out Action onInteract)
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
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.NativeMethodInfoPtr_ReturnToMemory_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06005591 RID: 21905 RVA: 0x001BF120 File Offset: 0x001BD320
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeineExtraDialogData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005592 RID: 21906 RVA: 0x0002E107 File Offset: 0x0002C307
		public KeineExtraDialogData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x001BF15C File Offset: 0x001BD35C
		// (set) Token: 0x06005594 RID: 21908 RVA: 0x0002E110 File Offset: 0x0002C310
		public unsafe static string PHRASE_KEY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KeineExtraDialogData.NativeFieldInfoPtr_PHRASE_KEY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KeineExtraDialogData.NativeFieldInfoPtr_PHRASE_KEY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06005595 RID: 21909 RVA: 0x001BF17C File Offset: 0x001BD37C
		// (set) Token: 0x06005596 RID: 21910 RVA: 0x0002E122 File Offset: 0x0002C322
		public unsafe string m_PreEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_PreEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_PreEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06005597 RID: 21911 RVA: 0x001BF1A4 File Offset: 0x001BD3A4
		// (set) Token: 0x06005598 RID: 21912 RVA: 0x0002E141 File Offset: 0x0002C341
		public unsafe PlayableAsset m_StartTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_StartTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayableAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_StartTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06005599 RID: 21913 RVA: 0x001BF1D4 File Offset: 0x001BD3D4
		// (set) Token: 0x0600559A RID: 21914 RVA: 0x0002E160 File Offset: 0x0002C360
		public unsafe AssetReference m_MemoryTimeline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_MemoryTimeline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_MemoryTimeline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x0600559B RID: 21915 RVA: 0x001BF204 File Offset: 0x001BD404
		// (set) Token: 0x0600559C RID: 21916 RVA: 0x0002E17F File Offset: 0x0002C37F
		public unsafe string m_FinishEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_FinishEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_FinishEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x0600559D RID: 21917 RVA: 0x001BF22C File Offset: 0x001BD42C
		// (set) Token: 0x0600559E RID: 21918 RVA: 0x0002E19E File Offset: 0x0002C39E
		public unsafe string m_AchievementEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_AchievementEvent);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.NativeFieldInfoPtr_m_AchievementEvent), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400396A RID: 14698
		private static readonly IntPtr NativeFieldInfoPtr_PHRASE_KEY;

		// Token: 0x0400396B RID: 14699
		private static readonly IntPtr NativeFieldInfoPtr_m_PreEvent;

		// Token: 0x0400396C RID: 14700
		private static readonly IntPtr NativeFieldInfoPtr_m_StartTimeline;

		// Token: 0x0400396D RID: 14701
		private static readonly IntPtr NativeFieldInfoPtr_m_MemoryTimeline;

		// Token: 0x0400396E RID: 14702
		private static readonly IntPtr NativeFieldInfoPtr_m_FinishEvent;

		// Token: 0x0400396F RID: 14703
		private static readonly IntPtr NativeFieldInfoPtr_m_AchievementEvent;

		// Token: 0x04003970 RID: 14704
		private static readonly IntPtr NativeMethodInfoPtr_GetSpecialGuestExtraDialogData_Public_Virtual_Void_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_byref_Il2CppReferenceArray_1_GetSpecialNPCSelectionConfigurationCallback_0;

		// Token: 0x04003971 RID: 14705
		private static readonly IntPtr NativeMethodInfoPtr_ReturnToMemory_Private_Void_SpecialNPCInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04003972 RID: 14706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C54 RID: 3156
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KeineExtraDialogData+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600E3F5 RID: 58357 RVA: 0x0036DAD8 File Offset: 0x0036BCD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr);
				KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "specialNPCInteractData");
				KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>4__this");
				KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>9__1");
				KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, "<>9__2");
				KeineExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680753);
				KeineExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ReturnToMemory_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680754);
				KeineExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ReturnToMemory_b__1_Internal_UniTask_1_IAssetHandle_1_TimelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680755);
				KeineExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ReturnToMemory_b__2_Internal_Void_IAssetHandle_1_TimelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr, 100680756);
			}

			// Token: 0x0600E3F6 RID: 58358 RVA: 0x0036DBA4 File Offset: 0x0036BDA4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3F7 RID: 58359 RVA: 0x0036DBE0 File Offset: 0x0036BDE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213427, XrefRangeEnd = 213455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReturnToMemory_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ReturnToMemory_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3F8 RID: 58360 RVA: 0x0036DC14 File Offset: 0x0036BE14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213455, XrefRangeEnd = 213458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<IAssetHandle<TimelineAsset>> _ReturnToMemory_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ReturnToMemory_b__1_Internal_UniTask_1_IAssetHandle_1_TimelineAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<IAssetHandle<TimelineAsset>>(pointer);
			}

			// Token: 0x0600E3F9 RID: 58361 RVA: 0x0036DC4C File Offset: 0x0036BE4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213458, XrefRangeEnd = 213504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReturnToMemory_b__2(IAssetHandle<TimelineAsset> handle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c__DisplayClass7_0.NativeMethodInfoPtr__ReturnToMemory_b__2_Internal_Void_IAssetHandle_1_TimelineAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E3FA RID: 58362 RVA: 0x00079950 File Offset: 0x00077B50
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049FA RID: 18938
			// (get) Token: 0x0600E3FB RID: 58363 RVA: 0x0036DC90 File Offset: 0x0036BE90
			// (set) Token: 0x0600E3FC RID: 58364 RVA: 0x00079959 File Offset: 0x00077B59
			public unsafe DaySceneChatSelectionPannel.SpecialNPCInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.SpecialNPCInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049FB RID: 18939
			// (get) Token: 0x0600E3FD RID: 58365 RVA: 0x0036DCC0 File Offset: 0x0036BEC0
			// (set) Token: 0x0600E3FE RID: 58366 RVA: 0x00079978 File Offset: 0x00077B78
			public unsafe KeineExtraDialogData __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeineExtraDialogData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049FC RID: 18940
			// (get) Token: 0x0600E3FF RID: 58367 RVA: 0x0036DCF0 File Offset: 0x0036BEF0
			// (set) Token: 0x0600E400 RID: 58368 RVA: 0x00079997 File Offset: 0x00077B97
			public unsafe Func<UniTask<IAssetHandle<TimelineAsset>>> __9__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<UniTask<IAssetHandle<TimelineAsset>>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049FD RID: 18941
			// (get) Token: 0x0600E401 RID: 58369 RVA: 0x0036DD20 File Offset: 0x0036BF20
			// (set) Token: 0x0600E402 RID: 58370 RVA: 0x000799B6 File Offset: 0x00077BB6
			public unsafe Action<IAssetHandle<TimelineAsset>> __9__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<IAssetHandle<TimelineAsset>>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_0.NativeFieldInfoPtr___9__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091B9 RID: 37305
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x040091BA RID: 37306
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091BB RID: 37307
			private static readonly IntPtr NativeFieldInfoPtr___9__1;

			// Token: 0x040091BC RID: 37308
			private static readonly IntPtr NativeFieldInfoPtr___9__2;

			// Token: 0x040091BD RID: 37309
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091BE RID: 37310
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToMemory_b__0_Internal_Void_0;

			// Token: 0x040091BF RID: 37311
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToMemory_b__1_Internal_UniTask_1_IAssetHandle_1_TimelineAsset_0;

			// Token: 0x040091C0 RID: 37312
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToMemory_b__2_Internal_Void_IAssetHandle_1_TimelineAsset_0;
		}

		// Token: 0x02000C55 RID: 3157
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KeineExtraDialogData+<>c__DisplayClass7_1")]
		public sealed class __c__DisplayClass7_1 : Object
		{
			// Token: 0x0600E403 RID: 58371 RVA: 0x0036DD50 File Offset: 0x0036BF50
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_1()
			{
				Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, "<>c__DisplayClass7_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr);
				KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_decorations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "decorations");
				KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "handle");
				KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "CS$<>8__locals1");
				KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr___9__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "<>9__7");
				KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "<>9__5");
				KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr___9__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, "<>9__6");
				KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680757);
				KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ReturnToMemory_b__4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680758);
				KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ReturnToMemory_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680759);
				KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ReturnToMemory_b__7_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680760);
				KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ReturnToMemory_b__6_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr, 100680761);
			}

			// Token: 0x0600E404 RID: 58372 RVA: 0x0036DE58 File Offset: 0x0036C058
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeineExtraDialogData.__c__DisplayClass7_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E405 RID: 58373 RVA: 0x0036DE94 File Offset: 0x0036C094
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213504, XrefRangeEnd = 213530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReturnToMemory_b__4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ReturnToMemory_b__4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E406 RID: 58374 RVA: 0x0036DEC8 File Offset: 0x0036C0C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213530, XrefRangeEnd = 213546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReturnToMemory_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ReturnToMemory_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E407 RID: 58375 RVA: 0x0036DEFC File Offset: 0x0036C0FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213546, XrefRangeEnd = 213561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReturnToMemory_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ReturnToMemory_b__7_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E408 RID: 58376 RVA: 0x0036DF30 File Offset: 0x0036C130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213561, XrefRangeEnd = 213583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _ReturnToMemory_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c__DisplayClass7_1.NativeMethodInfoPtr__ReturnToMemory_b__6_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E409 RID: 58377 RVA: 0x000799D5 File Offset: 0x00077BD5
			public __c__DisplayClass7_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170049FE RID: 18942
			// (get) Token: 0x0600E40A RID: 58378 RVA: 0x0036DF64 File Offset: 0x0036C164
			// (set) Token: 0x0600E40B RID: 58379 RVA: 0x000799DE File Offset: 0x00077BDE
			public unsafe Il2CppStructArray<int> decorations
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_decorations);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_decorations), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170049FF RID: 18943
			// (get) Token: 0x0600E40C RID: 58380 RVA: 0x0036DF94 File Offset: 0x0036C194
			// (set) Token: 0x0600E40D RID: 58381 RVA: 0x000799FD File Offset: 0x00077BFD
			public unsafe IAssetHandle<TimelineAsset> handle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_handle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<TimelineAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A00 RID: 18944
			// (get) Token: 0x0600E40E RID: 58382 RVA: 0x0036DFC4 File Offset: 0x0036C1C4
			// (set) Token: 0x0600E40F RID: 58383 RVA: 0x00079A1C File Offset: 0x00077C1C
			public unsafe KeineExtraDialogData.__c__DisplayClass7_0 field_Public___c__DisplayClass7_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeineExtraDialogData.__c__DisplayClass7_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A01 RID: 18945
			// (get) Token: 0x0600E410 RID: 58384 RVA: 0x0036DFF4 File Offset: 0x0036C1F4
			// (set) Token: 0x0600E411 RID: 58385 RVA: 0x00079A3B File Offset: 0x00077C3B
			public unsafe Action __9__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr___9__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr___9__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A02 RID: 18946
			// (get) Token: 0x0600E412 RID: 58386 RVA: 0x0036E024 File Offset: 0x0036C224
			// (set) Token: 0x0600E413 RID: 58387 RVA: 0x00079A5A File Offset: 0x00077C5A
			public unsafe Action __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A03 RID: 18947
			// (get) Token: 0x0600E414 RID: 58388 RVA: 0x0036E054 File Offset: 0x0036C254
			// (set) Token: 0x0600E415 RID: 58389 RVA: 0x00079A79 File Offset: 0x00077C79
			public unsafe Action __9__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr___9__6);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeineExtraDialogData.__c__DisplayClass7_1.NativeFieldInfoPtr___9__6), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091C1 RID: 37313
			private static readonly IntPtr NativeFieldInfoPtr_decorations;

			// Token: 0x040091C2 RID: 37314
			private static readonly IntPtr NativeFieldInfoPtr_handle;

			// Token: 0x040091C3 RID: 37315
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass7_0_0;

			// Token: 0x040091C4 RID: 37316
			private static readonly IntPtr NativeFieldInfoPtr___9__7;

			// Token: 0x040091C5 RID: 37317
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x040091C6 RID: 37318
			private static readonly IntPtr NativeFieldInfoPtr___9__6;

			// Token: 0x040091C7 RID: 37319
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091C8 RID: 37320
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToMemory_b__4_Internal_Void_0;

			// Token: 0x040091C9 RID: 37321
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToMemory_b__5_Internal_Void_0;

			// Token: 0x040091CA RID: 37322
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToMemory_b__7_Internal_Void_0;

			// Token: 0x040091CB RID: 37323
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToMemory_b__6_Internal_Void_0;
		}

		// Token: 0x02000C56 RID: 3158
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KeineExtraDialogData+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E416 RID: 58390 RVA: 0x0036E084 File Offset: 0x0036C284
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KeineExtraDialogData.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KeineExtraDialogData>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeineExtraDialogData.__c>.NativeClassPtr);
				KeineExtraDialogData.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c>.NativeClassPtr, "<>9");
				KeineExtraDialogData.__c.NativeFieldInfoPtr___9__7_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeineExtraDialogData.__c>.NativeClassPtr, "<>9__7_3");
				KeineExtraDialogData.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c>.NativeClassPtr, 100680763);
				KeineExtraDialogData.__c.NativeMethodInfoPtr__ReturnToMemory_b__7_3_Internal_Int32_Decoration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeineExtraDialogData.__c>.NativeClassPtr, 100680764);
			}

			// Token: 0x0600E417 RID: 58391 RVA: 0x0036E100 File Offset: 0x0036C300
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeineExtraDialogData.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E418 RID: 58392 RVA: 0x0036E13C File Offset: 0x0036C33C
			[CallerCount(0)]
			public unsafe int _ReturnToMemory_b__7_3(Decoration x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeineExtraDialogData.__c.NativeMethodInfoPtr__ReturnToMemory_b__7_3_Internal_Int32_Decoration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E419 RID: 58393 RVA: 0x00079A98 File Offset: 0x00077C98
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A04 RID: 18948
			// (get) Token: 0x0600E41A RID: 58394 RVA: 0x0036E18C File Offset: 0x0036C38C
			// (set) Token: 0x0600E41B RID: 58395 RVA: 0x00079AA1 File Offset: 0x00077CA1
			public unsafe static KeineExtraDialogData.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KeineExtraDialogData.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KeineExtraDialogData.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KeineExtraDialogData.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A05 RID: 18949
			// (get) Token: 0x0600E41C RID: 58396 RVA: 0x0036E1B4 File Offset: 0x0036C3B4
			// (set) Token: 0x0600E41D RID: 58397 RVA: 0x00079AB3 File Offset: 0x00077CB3
			public unsafe static Func<Decoration, int> __9__7_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KeineExtraDialogData.__c.NativeFieldInfoPtr___9__7_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Decoration, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KeineExtraDialogData.__c.NativeFieldInfoPtr___9__7_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091CC RID: 37324
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040091CD RID: 37325
			private static readonly IntPtr NativeFieldInfoPtr___9__7_3;

			// Token: 0x040091CE RID: 37326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091CF RID: 37327
			private static readonly IntPtr NativeMethodInfoPtr__ReturnToMemory_b__7_3_Internal_Int32_Decoration_0;
		}
	}
}
