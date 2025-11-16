using System;
using Cysharp.Threading.Tasks;
using DayScene.UI;
using DEYU.AssetHandleUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.AddressableAssets;
using UnityEngine.Timeline;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002A9 RID: 681
	[Serializable]
	public class KyoukoTutorialData_HowToSatisfySpecialGuest : KyoukoTutorialDataContainsTimeline
	{
		// Token: 0x06005616 RID: 22038 RVA: 0x001C0ADC File Offset: 0x001BECDC
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_HowToSatisfySpecialGuest()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_HowToSatisfySpecialGuest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest>.NativeClassPtr);
			KyoukoTutorialData_HowToSatisfySpecialGuest.NativeFieldInfoPtr_backToDayTimelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest>.NativeClassPtr, "backToDayTimelineAsset");
			KyoukoTutorialData_HowToSatisfySpecialGuest.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest>.NativeClassPtr, 100680831);
			KyoukoTutorialData_HowToSatisfySpecialGuest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest>.NativeClassPtr, 100680832);
		}

		// Token: 0x06005617 RID: 22039 RVA: 0x001C0B48 File Offset: 0x001BED48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214151, XrefRangeEnd = 214188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_HowToSatisfySpecialGuest.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005618 RID: 22040 RVA: 0x001C0B98 File Offset: 0x001BED98
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_HowToSatisfySpecialGuest() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005619 RID: 22041 RVA: 0x0002E57D File Offset: 0x0002C77D
		public KyoukoTutorialData_HowToSatisfySpecialGuest(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D86 RID: 7558
		// (get) Token: 0x0600561A RID: 22042 RVA: 0x001C0BD4 File Offset: 0x001BEDD4
		// (set) Token: 0x0600561B RID: 22043 RVA: 0x0002E586 File Offset: 0x0002C786
		public unsafe AssetReference backToDayTimelineAsset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.NativeFieldInfoPtr_backToDayTimelineAsset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.NativeFieldInfoPtr_backToDayTimelineAsset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039BD RID: 14781
		private static readonly IntPtr NativeFieldInfoPtr_backToDayTimelineAsset;

		// Token: 0x040039BE RID: 14782
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0;

		// Token: 0x040039BF RID: 14783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C61 RID: 3169
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData_HowToSatisfySpecialGuest+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600E47B RID: 58491 RVA: 0x0036F1A4 File Offset: 0x0036D3A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>.NativeClassPtr);
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeFieldInfoPtr_canPerform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>.NativeClassPtr, "canPerform");
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>.NativeClassPtr, 100680833);
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__0_Internal_UniTask_1_ValueTuple_2_IAssetHandle_1_TimelineAsset_IAssetHandle_1_TimelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>.NativeClassPtr, 100680834);
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__1_Internal_Void_ValueTuple_2_IAssetHandle_1_TimelineAsset_IAssetHandle_1_TimelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>.NativeClassPtr, 100680835);
			}

			// Token: 0x0600E47C RID: 58492 RVA: 0x0036F248 File Offset: 0x0036D448
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E47D RID: 58493 RVA: 0x0036F284 File Offset: 0x0036D484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214042, XrefRangeEnd = 214053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask<ValueTuple<IAssetHandle<TimelineAsset>, IAssetHandle<TimelineAsset>>> _OnButtonInteractDialogPackageClose_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__0_Internal_UniTask_1_ValueTuple_2_IAssetHandle_1_TimelineAsset_IAssetHandle_1_TimelineAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask<ValueTuple<IAssetHandle<TimelineAsset>, IAssetHandle<TimelineAsset>>>(pointer);
			}

			// Token: 0x0600E47E RID: 58494 RVA: 0x0036F2BC File Offset: 0x0036D4BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214053, XrefRangeEnd = 214075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnButtonInteractDialogPackageClose_b__1(ValueTuple<IAssetHandle<TimelineAsset>, IAssetHandle<TimelineAsset>> handle)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(handle));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__1_Internal_Void_ValueTuple_2_IAssetHandle_1_TimelineAsset_IAssetHandle_1_TimelineAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E47F RID: 58495 RVA: 0x00079E3A File Offset: 0x0007803A
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A1F RID: 18975
			// (get) Token: 0x0600E480 RID: 58496 RVA: 0x0036F304 File Offset: 0x0036D504
			// (set) Token: 0x0600E481 RID: 58497 RVA: 0x00079E43 File Offset: 0x00078043
			public unsafe KyoukoTutorialData_HowToSatisfySpecialGuest __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_HowToSatisfySpecialGuest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A20 RID: 18976
			// (get) Token: 0x0600E482 RID: 58498 RVA: 0x0036F334 File Offset: 0x0036D534
			// (set) Token: 0x0600E483 RID: 58499 RVA: 0x00079E62 File Offset: 0x00078062
			public unsafe bool canPerform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeFieldInfoPtr_canPerform);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeFieldInfoPtr_canPerform)) = value;
				}
			}

			// Token: 0x17004A21 RID: 18977
			// (get) Token: 0x0600E484 RID: 58500 RVA: 0x0036F35C File Offset: 0x0036D55C
			// (set) Token: 0x0600E485 RID: 58501 RVA: 0x00079E7D File Offset: 0x0007807D
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091FF RID: 37375
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009200 RID: 37376
			private static readonly IntPtr NativeFieldInfoPtr_canPerform;

			// Token: 0x04009201 RID: 37377
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009202 RID: 37378
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009203 RID: 37379
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__0_Internal_UniTask_1_ValueTuple_2_IAssetHandle_1_TimelineAsset_IAssetHandle_1_TimelineAsset_0;

			// Token: 0x04009204 RID: 37380
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__1_Internal_Void_ValueTuple_2_IAssetHandle_1_TimelineAsset_IAssetHandle_1_TimelineAsset_0;
		}

		// Token: 0x02000C62 RID: 3170
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData_HowToSatisfySpecialGuest+<>c__DisplayClass1_1")]
		public sealed class __c__DisplayClass1_1 : Object
		{
			// Token: 0x0600E486 RID: 58502 RVA: 0x0036F38C File Offset: 0x0036D58C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_1()
			{
				Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest>.NativeClassPtr, "<>c__DisplayClass1_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr);
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr, "a");
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr_b = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr, "b");
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr, "CS$<>8__locals1");
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr___9__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr, "<>9__5");
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr, 100680836);
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr, 100680837);
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr, 100680838);
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr, 100680839);
			}

			// Token: 0x0600E487 RID: 58503 RVA: 0x0036F458 File Offset: 0x0036D658
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E488 RID: 58504 RVA: 0x0036F494 File Offset: 0x0036D694
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214075, XrefRangeEnd = 214106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnButtonInteractDialogPackageClose_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E489 RID: 58505 RVA: 0x0036F4C8 File Offset: 0x0036D6C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214106, XrefRangeEnd = 214129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnButtonInteractDialogPackageClose_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E48A RID: 58506 RVA: 0x0036F4FC File Offset: 0x0036D6FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214129, XrefRangeEnd = 214140, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnButtonInteractDialogPackageClose_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E48B RID: 58507 RVA: 0x00079E9C File Offset: 0x0007809C
			public __c__DisplayClass1_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A22 RID: 18978
			// (get) Token: 0x0600E48C RID: 58508 RVA: 0x0036F530 File Offset: 0x0036D730
			// (set) Token: 0x0600E48D RID: 58509 RVA: 0x00079EA5 File Offset: 0x000780A5
			public unsafe IAssetHandle<TimelineAsset> a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr_a);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<TimelineAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr_a), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A23 RID: 18979
			// (get) Token: 0x0600E48E RID: 58510 RVA: 0x0036F560 File Offset: 0x0036D760
			// (set) Token: 0x0600E48F RID: 58511 RVA: 0x00079EC4 File Offset: 0x000780C4
			public unsafe IAssetHandle<TimelineAsset> b
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr_b);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<TimelineAsset>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr_b), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A24 RID: 18980
			// (get) Token: 0x0600E490 RID: 58512 RVA: 0x0036F590 File Offset: 0x0036D790
			// (set) Token: 0x0600E491 RID: 58513 RVA: 0x00079EE3 File Offset: 0x000780E3
			public unsafe KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0 field_Public___c__DisplayClass1_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A25 RID: 18981
			// (get) Token: 0x0600E492 RID: 58514 RVA: 0x0036F5C0 File Offset: 0x0036D7C0
			// (set) Token: 0x0600E493 RID: 58515 RVA: 0x00079F02 File Offset: 0x00078102
			public unsafe Action __9__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr___9__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_HowToSatisfySpecialGuest.__c__DisplayClass1_1.NativeFieldInfoPtr___9__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009205 RID: 37381
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x04009206 RID: 37382
			private static readonly IntPtr NativeFieldInfoPtr_b;

			// Token: 0x04009207 RID: 37383
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass1_0_0;

			// Token: 0x04009208 RID: 37384
			private static readonly IntPtr NativeFieldInfoPtr___9__5;

			// Token: 0x04009209 RID: 37385
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400920A RID: 37386
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__2_Internal_Void_0;

			// Token: 0x0400920B RID: 37387
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__3_Internal_Void_0;

			// Token: 0x0400920C RID: 37388
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__5_Internal_Void_0;
		}

		// Token: 0x02000C63 RID: 3171
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData_HowToSatisfySpecialGuest+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600E494 RID: 58516 RVA: 0x0036F5F0 File Offset: 0x0036D7F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c>.NativeClassPtr);
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c>.NativeClassPtr, "<>9");
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeFieldInfoPtr___9__1_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c>.NativeClassPtr, "<>9__1_4");
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c>.NativeClassPtr, 100680841);
				KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__1_4_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c>.NativeClassPtr, 100680842);
			}

			// Token: 0x0600E495 RID: 58517 RVA: 0x0036F66C File Offset: 0x0036D86C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_HowToSatisfySpecialGuest.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E496 RID: 58518 RVA: 0x0036F6A8 File Offset: 0x0036D8A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214140, XrefRangeEnd = 214151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnButtonInteractDialogPackageClose_b__1_4()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__1_4_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E497 RID: 58519 RVA: 0x00079F21 File Offset: 0x00078121
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A26 RID: 18982
			// (get) Token: 0x0600E498 RID: 58520 RVA: 0x0036F6DC File Offset: 0x0036D8DC
			// (set) Token: 0x0600E499 RID: 58521 RVA: 0x00079F2A File Offset: 0x0007812A
			public unsafe static KyoukoTutorialData_HowToSatisfySpecialGuest.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_HowToSatisfySpecialGuest.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A27 RID: 18983
			// (get) Token: 0x0600E49A RID: 58522 RVA: 0x0036F704 File Offset: 0x0036D904
			// (set) Token: 0x0600E49B RID: 58523 RVA: 0x00079F3C File Offset: 0x0007813C
			public unsafe static Action __9__1_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeFieldInfoPtr___9__1_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialData_HowToSatisfySpecialGuest.__c.NativeFieldInfoPtr___9__1_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400920D RID: 37389
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400920E RID: 37390
			private static readonly IntPtr NativeFieldInfoPtr___9__1_4;

			// Token: 0x0400920F RID: 37391
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009210 RID: 37392
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteractDialogPackageClose_b__1_4_Internal_Void_0;
		}
	}
}
