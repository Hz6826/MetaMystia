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
	// Token: 0x020002AB RID: 683
	[Serializable]
	public class KyoukoTutorialData_AboutToutetsu : KyoukoTutorialData
	{
		// Token: 0x06005623 RID: 22051 RVA: 0x001C0D88 File Offset: 0x001BEF88
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_AboutToutetsu()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_AboutToutetsu");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu>.NativeClassPtr);
			KyoukoTutorialData_AboutToutetsu.NativeFieldInfoPtr_yuumaTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu>.NativeClassPtr, "yuumaTutorial");
			KyoukoTutorialData_AboutToutetsu.NativeMethodInfoPtr_OnButtonInteractAsync_Private_UniTask_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu>.NativeClassPtr, 100680850);
			KyoukoTutorialData_AboutToutetsu.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu>.NativeClassPtr, 100680851);
			KyoukoTutorialData_AboutToutetsu.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu>.NativeClassPtr, 100680852);
		}

		// Token: 0x06005624 RID: 22052 RVA: 0x001C0E08 File Offset: 0x001BF008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214309, XrefRangeEnd = 214316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OnButtonInteractAsync(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_AboutToutetsu.NativeMethodInfoPtr_OnButtonInteractAsync_Private_UniTask_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06005625 RID: 22053 RVA: 0x001C0E50 File Offset: 0x001BF050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214316, XrefRangeEnd = 214330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_AboutToutetsu.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005626 RID: 22054 RVA: 0x001C0EA0 File Offset: 0x001BF0A0
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_AboutToutetsu() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_AboutToutetsu.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x0002E5CD File Offset: 0x0002C7CD
		public KyoukoTutorialData_AboutToutetsu(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D88 RID: 7560
		// (get) Token: 0x06005628 RID: 22056 RVA: 0x001C0EDC File Offset: 0x001BF0DC
		// (set) Token: 0x06005629 RID: 22057 RVA: 0x0002E5D6 File Offset: 0x0002C7D6
		public unsafe AssetReference yuumaTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu.NativeFieldInfoPtr_yuumaTutorial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu.NativeFieldInfoPtr_yuumaTutorial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039C4 RID: 14788
		private static readonly IntPtr NativeFieldInfoPtr_yuumaTutorial;

		// Token: 0x040039C5 RID: 14789
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractAsync_Private_UniTask_BaseInteractData_0;

		// Token: 0x040039C6 RID: 14790
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0;

		// Token: 0x040039C7 RID: 14791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C66 RID: 3174
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData_AboutToutetsu+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E4B7 RID: 58551 RVA: 0x0036FB20 File Offset: 0x0036DD20
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0>.NativeClassPtr);
				KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeFieldInfoPtr_prefabHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0>.NativeClassPtr, "prefabHandle");
				KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0>.NativeClassPtr, 100680853);
				KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeMethodInfoPtr__OnButtonInteractAsync_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0>.NativeClassPtr, 100680854);
			}

			// Token: 0x0600E4B8 RID: 58552 RVA: 0x0036FBB0 File Offset: 0x0036DDB0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4B9 RID: 58553 RVA: 0x0036FBEC File Offset: 0x0036DDEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214259, XrefRangeEnd = 214268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnButtonInteractAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeMethodInfoPtr__OnButtonInteractAsync_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4BA RID: 58554 RVA: 0x0007A0A3 File Offset: 0x000782A3
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A31 RID: 18993
			// (get) Token: 0x0600E4BB RID: 58555 RVA: 0x0036FC20 File Offset: 0x0036DE20
			// (set) Token: 0x0600E4BC RID: 58556 RVA: 0x0007A0AC File Offset: 0x000782AC
			public unsafe KyoukoTutorialData_AboutToutetsu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_AboutToutetsu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A32 RID: 18994
			// (get) Token: 0x0600E4BD RID: 58557 RVA: 0x0036FC50 File Offset: 0x0036DE50
			// (set) Token: 0x0600E4BE RID: 58558 RVA: 0x0007A0CB File Offset: 0x000782CB
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A33 RID: 18995
			// (get) Token: 0x0600E4BF RID: 58559 RVA: 0x0036FC80 File Offset: 0x0036DE80
			// (set) Token: 0x0600E4C0 RID: 58560 RVA: 0x0007A0EA File Offset: 0x000782EA
			public unsafe IAssetHandle<GameObject> prefabHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeFieldInfoPtr_prefabHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0.NativeFieldInfoPtr_prefabHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400921E RID: 37406
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400921F RID: 37407
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009220 RID: 37408
			private static readonly IntPtr NativeFieldInfoPtr_prefabHandle;

			// Token: 0x04009221 RID: 37409
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009222 RID: 37410
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteractAsync_b__0_Internal_Void_0;
		}

		// Token: 0x02000C67 RID: 3175
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData_AboutToutetsu+<OnButtonInteractAsync>d__1")]
		public sealed class _OnButtonInteractAsync_d__1 : ValueType
		{
			// Token: 0x0600E4C1 RID: 58561 RVA: 0x0036FCB0 File Offset: 0x0036DEB0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnButtonInteractAsync_d__1()
			{
				Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu>.NativeClassPtr, "<OnButtonInteractAsync>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr);
				KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>1__state");
				KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>t__builder");
				KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>4__this");
				KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>8__1");
				KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>u__1");
				KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr, 100680855);
				KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr, 100680856);
			}

			// Token: 0x0600E4C2 RID: 58562 RVA: 0x0036FD7C File Offset: 0x0036DF7C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 214305, RefRangeEnd = 214309, XrefRangeStart = 214268, XrefRangeEnd = 214305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4C3 RID: 58563 RVA: 0x0036FDB4 File Offset: 0x0036DFB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4C4 RID: 58564 RVA: 0x0007A109 File Offset: 0x00078309
			public _OnButtonInteractAsync_d__1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E4C5 RID: 58565 RVA: 0x0007A112 File Offset: 0x00078312
			public _OnButtonInteractAsync_d__1() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x17004A34 RID: 18996
			// (get) Token: 0x0600E4C6 RID: 58566 RVA: 0x0036FDFC File Offset: 0x0036DFFC
			// (set) Token: 0x0600E4C7 RID: 58567 RVA: 0x0007A124 File Offset: 0x00078324
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A35 RID: 18997
			// (get) Token: 0x0600E4C8 RID: 58568 RVA: 0x0036FE24 File Offset: 0x0036E024
			// (set) Token: 0x0600E4C9 RID: 58569 RVA: 0x0007A13F File Offset: 0x0007833F
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004A36 RID: 18998
			// (get) Token: 0x0600E4CA RID: 58570 RVA: 0x0036FE54 File Offset: 0x0036E054
			// (set) Token: 0x0600E4CB RID: 58571 RVA: 0x0007A16D File Offset: 0x0007836D
			public unsafe KyoukoTutorialData_AboutToutetsu __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_AboutToutetsu>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A37 RID: 18999
			// (get) Token: 0x0600E4CC RID: 58572 RVA: 0x0036FE84 File Offset: 0x0036E084
			// (set) Token: 0x0600E4CD RID: 58573 RVA: 0x0007A18C File Offset: 0x0007838C
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A38 RID: 19000
			// (get) Token: 0x0600E4CE RID: 58574 RVA: 0x0036FEB4 File Offset: 0x0036E0B4
			// (set) Token: 0x0600E4CF RID: 58575 RVA: 0x0007A1AB File Offset: 0x000783AB
			public unsafe KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_AboutToutetsu.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A39 RID: 19001
			// (get) Token: 0x0600E4D0 RID: 58576 RVA: 0x0036FEE4 File Offset: 0x0036E0E4
			// (set) Token: 0x0600E4D1 RID: 58577 RVA: 0x0007A1CA File Offset: 0x000783CA
			public UniTask<IAssetHandle<GameObject>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<GameObject>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_AboutToutetsu._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04009223 RID: 37411
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009224 RID: 37412
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04009225 RID: 37413
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009226 RID: 37414
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009227 RID: 37415
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04009228 RID: 37416
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x04009229 RID: 37417
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400922A RID: 37418
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
