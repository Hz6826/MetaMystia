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
	// Token: 0x020002AA RID: 682
	[Serializable]
	public class KyoukoTutorialData_WhatIsQTE : KyoukoTutorialData
	{
		// Token: 0x0600561C RID: 22044 RVA: 0x001C0C04 File Offset: 0x001BEE04
		// Note: this type is marked as 'beforefieldinit'.
		static KyoukoTutorialData_WhatIsQTE()
		{
			Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.DaySceneUtility.Collections", "KyoukoTutorialData_WhatIsQTE");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE>.NativeClassPtr);
			KyoukoTutorialData_WhatIsQTE.NativeFieldInfoPtr_qteTutorial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE>.NativeClassPtr, "qteTutorial");
			KyoukoTutorialData_WhatIsQTE.NativeMethodInfoPtr_OnButtonInteractAsync_Private_UniTask_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE>.NativeClassPtr, 100680843);
			KyoukoTutorialData_WhatIsQTE.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE>.NativeClassPtr, 100680844);
			KyoukoTutorialData_WhatIsQTE.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE>.NativeClassPtr, 100680845);
		}

		// Token: 0x0600561D RID: 22045 RVA: 0x001C0C84 File Offset: 0x001BEE84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214238, XrefRangeEnd = 214245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OnButtonInteractAsync(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_WhatIsQTE.NativeMethodInfoPtr_OnButtonInteractAsync_Private_UniTask_BaseInteractData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600561E RID: 22046 RVA: 0x001C0CCC File Offset: 0x001BEECC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214245, XrefRangeEnd = 214259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnButtonInteractDialogPackageClose(DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(specialNPCInteractData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KyoukoTutorialData_WhatIsQTE.NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600561F RID: 22047 RVA: 0x001C0D1C File Offset: 0x001BEF1C
		[CallerCount(2138)]
		[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KyoukoTutorialData_WhatIsQTE() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_WhatIsQTE.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005620 RID: 22048 RVA: 0x0002E5A5 File Offset: 0x0002C7A5
		public KyoukoTutorialData_WhatIsQTE(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D87 RID: 7559
		// (get) Token: 0x06005621 RID: 22049 RVA: 0x001C0D58 File Offset: 0x001BEF58
		// (set) Token: 0x06005622 RID: 22050 RVA: 0x0002E5AE File Offset: 0x0002C7AE
		public unsafe AssetReference qteTutorial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE.NativeFieldInfoPtr_qteTutorial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE.NativeFieldInfoPtr_qteTutorial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039C0 RID: 14784
		private static readonly IntPtr NativeFieldInfoPtr_qteTutorial;

		// Token: 0x040039C1 RID: 14785
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractAsync_Private_UniTask_BaseInteractData_0;

		// Token: 0x040039C2 RID: 14786
		private static readonly IntPtr NativeMethodInfoPtr_OnButtonInteractDialogPackageClose_Protected_Virtual_Void_BaseInteractData_0;

		// Token: 0x040039C3 RID: 14787
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C64 RID: 3172
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData_WhatIsQTE+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E49C RID: 58524 RVA: 0x0036F72C File Offset: 0x0036D92C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0>.NativeClassPtr);
				KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
				KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeFieldInfoPtr_prefabHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0>.NativeClassPtr, "prefabHandle");
				KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0>.NativeClassPtr, 100680846);
				KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeMethodInfoPtr__OnButtonInteractAsync_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0>.NativeClassPtr, 100680847);
			}

			// Token: 0x0600E49D RID: 58525 RVA: 0x0036F7BC File Offset: 0x0036D9BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E49E RID: 58526 RVA: 0x0036F7F8 File Offset: 0x0036D9F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 214188, XrefRangeEnd = 214197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnButtonInteractAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeMethodInfoPtr__OnButtonInteractAsync_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E49F RID: 58527 RVA: 0x00079F4E File Offset: 0x0007814E
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004A28 RID: 18984
			// (get) Token: 0x0600E4A0 RID: 58528 RVA: 0x0036F82C File Offset: 0x0036DA2C
			// (set) Token: 0x0600E4A1 RID: 58529 RVA: 0x00079F57 File Offset: 0x00078157
			public unsafe KyoukoTutorialData_WhatIsQTE __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_WhatIsQTE>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A29 RID: 18985
			// (get) Token: 0x0600E4A2 RID: 58530 RVA: 0x0036F85C File Offset: 0x0036DA5C
			// (set) Token: 0x0600E4A3 RID: 58531 RVA: 0x00079F76 File Offset: 0x00078176
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A2A RID: 18986
			// (get) Token: 0x0600E4A4 RID: 58532 RVA: 0x0036F88C File Offset: 0x0036DA8C
			// (set) Token: 0x0600E4A5 RID: 58533 RVA: 0x00079F95 File Offset: 0x00078195
			public unsafe IAssetHandle<GameObject> prefabHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeFieldInfoPtr_prefabHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAssetHandle<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0.NativeFieldInfoPtr_prefabHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009211 RID: 37393
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009212 RID: 37394
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x04009213 RID: 37395
			private static readonly IntPtr NativeFieldInfoPtr_prefabHandle;

			// Token: 0x04009214 RID: 37396
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009215 RID: 37397
			private static readonly IntPtr NativeMethodInfoPtr__OnButtonInteractAsync_b__0_Internal_Void_0;
		}

		// Token: 0x02000C65 RID: 3173
		[ObfuscatedName("GameData.Core.Collections.DaySceneUtility.Collections.KyoukoTutorialData_WhatIsQTE+<OnButtonInteractAsync>d__1")]
		public sealed class _OnButtonInteractAsync_d__1 : ValueType
		{
			// Token: 0x0600E4A6 RID: 58534 RVA: 0x0036F8BC File Offset: 0x0036DABC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnButtonInteractAsync_d__1()
			{
				Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE>.NativeClassPtr, "<OnButtonInteractAsync>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr);
				KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>1__state");
				KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>t__builder");
				KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>4__this");
				KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr_specialNPCInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr, "specialNPCInteractData");
				KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>8__1");
				KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr, "<>u__1");
				KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr, 100680848);
				KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr, 100680849);
			}

			// Token: 0x0600E4A7 RID: 58535 RVA: 0x0036F988 File Offset: 0x0036DB88
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 214234, RefRangeEnd = 214238, XrefRangeStart = 214197, XrefRangeEnd = 214234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4A8 RID: 58536 RVA: 0x0036F9C0 File Offset: 0x0036DBC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E4A9 RID: 58537 RVA: 0x00079FB4 File Offset: 0x000781B4
			public _OnButtonInteractAsync_d__1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E4AA RID: 58538 RVA: 0x00079FBD File Offset: 0x000781BD
			public _OnButtonInteractAsync_d__1() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x17004A2B RID: 18987
			// (get) Token: 0x0600E4AB RID: 58539 RVA: 0x0036FA08 File Offset: 0x0036DC08
			// (set) Token: 0x0600E4AC RID: 58540 RVA: 0x00079FCF File Offset: 0x000781CF
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004A2C RID: 18988
			// (get) Token: 0x0600E4AD RID: 58541 RVA: 0x0036FA30 File Offset: 0x0036DC30
			// (set) Token: 0x0600E4AE RID: 58542 RVA: 0x00079FEA File Offset: 0x000781EA
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x17004A2D RID: 18989
			// (get) Token: 0x0600E4AF RID: 58543 RVA: 0x0036FA60 File Offset: 0x0036DC60
			// (set) Token: 0x0600E4B0 RID: 58544 RVA: 0x0007A018 File Offset: 0x00078218
			public unsafe KyoukoTutorialData_WhatIsQTE __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_WhatIsQTE>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A2E RID: 18990
			// (get) Token: 0x0600E4B1 RID: 58545 RVA: 0x0036FA90 File Offset: 0x0036DC90
			// (set) Token: 0x0600E4B2 RID: 58546 RVA: 0x0007A037 File Offset: 0x00078237
			public unsafe DaySceneChatSelectionPannel.BaseInteractData specialNPCInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr_specialNPCInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr_specialNPCInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A2F RID: 18991
			// (get) Token: 0x0600E4B3 RID: 58547 RVA: 0x0036FAC0 File Offset: 0x0036DCC0
			// (set) Token: 0x0600E4B4 RID: 58548 RVA: 0x0007A056 File Offset: 0x00078256
			public unsafe KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<KyoukoTutorialData_WhatIsQTE.__c__DisplayClass1_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004A30 RID: 18992
			// (get) Token: 0x0600E4B5 RID: 58549 RVA: 0x0036FAF0 File Offset: 0x0036DCF0
			// (set) Token: 0x0600E4B6 RID: 58550 RVA: 0x0007A075 File Offset: 0x00078275
			public UniTask<IAssetHandle<GameObject>>.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___u__1);
					return new UniTask<IAssetHandle<GameObject>>.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KyoukoTutorialData_WhatIsQTE._OnButtonInteractAsync_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask<IAssetHandle<GameObject>>.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x04009216 RID: 37398
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009217 RID: 37399
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x04009218 RID: 37400
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009219 RID: 37401
			private static readonly IntPtr NativeFieldInfoPtr_specialNPCInteractData;

			// Token: 0x0400921A RID: 37402
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400921B RID: 37403
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400921C RID: 37404
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400921D RID: 37405
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
