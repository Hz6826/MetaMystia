using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DayScene.UI;
using DEYU.AssetHandleUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace GameData.Core.Collections.DaySceneUtility.Collections
{
	// Token: 0x020002A5 RID: 677
	[Serializable]
	public class KyoukoTutorialDataWithPrefab : KyoukoTutorialData
	{
		// Token: 0x060055F2 RID: 22002 RVA: 0x001C0350 File Offset: 0x001BE550
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialDataWithPrefab()
		{
			Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialDataWithPrefab");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab>.NativeClassPtr);
			KyoukoTutorialDataWithPrefab.NativeFieldInfoPtr_TUTORIAL_LABEL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab>.NativeClassPtr, "TUTORIAL_LABEL");
			KyoukoTutorialDataWithPrefab.NativeFieldInfoPtr_dialogPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab>.NativeClassPtr, "dialogPrefab");
			KyoukoTutorialDataWithPrefab.NativeMethodInfoPtr_OnButtonInteractAsync_Private_UniTask_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab>.NativeClassPtr, 100680805);
			KyoukoTutorialDataWithPrefab.NativeMethodInfoPtr_OnButtonInteract_Protected_Virtual_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab>.NativeClassPtr, 100680806);
			KyoukoTutorialDataWithPrefab.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab>.NativeClassPtr, 100680807);
		}

		// Token: 0x060055F3 RID: 22003 RVA: 0x001C03E4 File Offset: 0x001BE5E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213885, XrefRangeEnd = 213892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OnButtonInteractAsync(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataWithPrefab.NativeMethodInfoPtr_OnButtonInteractAsync_Private_UniTask_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x060055F4 RID: 22004 RVA: 0x001C042C File Offset: 0x001BE62C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213892, XrefRangeEnd = 213906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnButtonInteract(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialDataWithPrefab.NativeMethodInfoPtr_OnButtonInteract_Protected_Virtual_Void_BaseInteractData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055F5 RID: 22005 RVA: 0x001C047C File Offset: 0x001BE67C
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialDataWithPrefab() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataWithPrefab.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060055F6 RID: 22006 RVA: 0x0002E48D File Offset: 0x0002C68D
		public KyoukoTutorialDataWithPrefab(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D7B RID: 7547
		// (get) Token: 0x060055F7 RID: 22007 RVA: 0x001C04B8 File Offset: 0x001BE6B8
		// (set) Token: 0x060055F8 RID: 22008 RVA: 0x0002E496 File Offset: 0x0002C696
		public unsafe static string TUTORIAL_LABEL
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KyoukoTutorialDataWithPrefab.NativeFieldInfoPtr_TUTORIAL_LABEL, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KyoukoTutorialDataWithPrefab.NativeFieldInfoPtr_TUTORIAL_LABEL, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D7C RID: 7548
		// (get) Token: 0x060055F9 RID: 22009 RVA: 0x001C04D8 File Offset: 0x001BE6D8
		// (set) Token: 0x060055FA RID: 22010 RVA: 0x0002E4A8 File Offset: 0x0002C6A8
		public unsafe AssetReference dialogPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab.NativeFieldInfoPtr_dialogPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab.NativeFieldInfoPtr_dialogPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039A8 RID: 14760
		private static readonly IntPtr NativeFieldInfoPtr_TUTORIAL_LABEL;

		// Token: 0x040039A9 RID: 14761
		private static readonly IntPtr NativeFieldInfoPtr_dialogPrefab;

		// Token: 0x040039AA RID: 14762
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractAsync_Private_UniTask_BaseInteractData_0;

		// Token: 0x040039AB RID: 14763
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteract_Protected_Virtual_Void_BaseInteractData_0;

		// Token: 0x040039AC RID: 14764
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C5C RID: 3164
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialDataWithPrefab+<OnButtonInteractAsync>d__2")]
		public sealed class _OnButtonInteractAsync_d__2 : ValueType
		{
			// Token: 0x0600E445 RID: 58437 RVA: 0x0036E8C4 File Offset: 0x0036CAC4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnButtonInteractAsync_d__2()
			{
				Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab>.NativeClassPtr, "<OnButtonInteractAsync>d__2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr);
				KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr, "<>1__state");
				KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr, "<>t__builder");
				KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr, "<>4__this");
				KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr__prefabHandle_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr, "<prefabHandle>5__2");
				KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr, "<>u__1");
				KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___u__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr, "<>u__2");
				KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr, 100680808);
				KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr, 100680809);
			}

			// Token: 0x0600E446 RID: 58438 RVA: 0x0036E9A4 File Offset: 0x0036CBA4
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 213881, RefRangeEnd = 213885, XrefRangeStart = 213844, XrefRangeEnd = 213881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E447 RID: 58439 RVA: 0x0036E9DC File Offset: 0x0036CBDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E448 RID: 58440 RVA: 0x00079C09 File Offset: 0x00077E09
			public _OnButtonInteractAsync_d__2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E449 RID: 58441 RVA: 0x00079C12 File Offset: 0x00077E12
			public _OnButtonInteractAsync_d__2() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2>.NativeClassPtr))
			{
			}

			// Token: 0x17004A0F RID: 18959
			// (get) Token: 0x0600E44A RID: 58442 RVA: 0x0036EA24 File Offset: 0x0036CC24
			// (set) Token: 0x0600E44B RID: 58443 RVA: 0x00079C24 File Offset: 0x00077E24
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A10 RID: 18960
			// (get) Token: 0x0600E44C RID: 58444 RVA: 0x0036EA4C File Offset: 0x0036CC4C
			// (set) Token: 0x0600E44D RID: 58445 RVA: 0x00079C3F File Offset: 0x00077E3F
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004A11 RID: 18961
			// (get) Token: 0x0600E44E RID: 58446 RVA: 0x0036EA7C File Offset: 0x0036CC7C
			// (set) Token: 0x0600E44F RID: 58447 RVA: 0x00079C6D File Offset: 0x00077E6D
			public unsafe KyoukoTutorialDataWithPrefab __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialDataWithPrefab>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A12 RID: 18962
			// (get) Token: 0x0600E450 RID: 58448 RVA: 0x0036EAAC File Offset: 0x0036CCAC
			// (set) Token: 0x0600E451 RID: 58449 RVA: 0x00079C8C File Offset: 0x00077E8C
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A13 RID: 18963
			// (get) Token: 0x0600E452 RID: 58450 RVA: 0x0036EADC File Offset: 0x0036CCDC
			// (set) Token: 0x0600E453 RID: 58451 RVA: 0x00079CAB File Offset: 0x00077EAB
			public unsafe IAssetHandle<GameObject> _prefabHandle_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr__prefabHandle_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr__prefabHandle_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A14 RID: 18964
			// (get) Token: 0x0600E454 RID: 58452 RVA: 0x0036EB0C File Offset: 0x0036CD0C
			// (set) Token: 0x0600E455 RID: 58453 RVA: 0x00079CCA File Offset: 0x00077ECA
			public UniTask<IAssetHandle<GameObject>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<GameObject>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004A15 RID: 18965
			// (get) Token: 0x0600E456 RID: 58454 RVA: 0x0036EB3C File Offset: 0x0036CD3C
			// (set) Token: 0x0600E457 RID: 58455 RVA: 0x00079CF8 File Offset: 0x00077EF8
			public UniTask.Awaiter __u__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___u__2);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialDataWithPrefab._OnButtonInteractAsync_d__2.NativeFieldInfoPtr___u__2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x040091E4 RID: 37348
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040091E5 RID: 37349
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x040091E6 RID: 37350
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040091E7 RID: 37351
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x040091E8 RID: 37352
			private static readonly IntPtr NativeFieldInfoPtr__prefabHandle_5__2;

			// Token: 0x040091E9 RID: 37353
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x040091EA RID: 37354
			private static readonly IntPtr NativeFieldInfoPtr___u__2;

			// Token: 0x040091EB RID: 37355
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x040091EC RID: 37356
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
