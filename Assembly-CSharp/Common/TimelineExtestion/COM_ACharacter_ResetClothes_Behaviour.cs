using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;

namespace Common.TimelineExtestion
{
	// Token: 0x02000436 RID: 1078
	public class COM_ACharacter_ResetClothes_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06007912 RID: 30994 RVA: 0x002304E4 File Offset: 0x0022E6E4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_ResetClothes_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_ResetClothes_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour>.NativeClassPtr);
			COM_ACharacter_ResetClothes_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour>.NativeClassPtr, 100687690);
			COM_ACharacter_ResetClothes_Behaviour.NativeMethodInfoPtr_OnBehaviourEnterAsync_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour>.NativeClassPtr, 100687691);
			COM_ACharacter_ResetClothes_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour>.NativeClassPtr, 100687692);
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x00230550 File Offset: 0x0022E750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293912, XrefRangeEnd = 293924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_ResetClothes_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x0023058C File Offset: 0x0022E78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293924, XrefRangeEnd = 293929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OnBehaviourEnterAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_ResetClothes_Behaviour.NativeMethodInfoPtr_OnBehaviourEnterAsync_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x002305C4 File Offset: 0x0022E7C4
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_ResetClothes_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_ResetClothes_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x000417B1 File Offset: 0x0003F9B1
		public COM_ACharacter_ResetClothes_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004FBE RID: 20414
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FBF RID: 20415
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnterAsync_Private_UniTask_0;

		// Token: 0x04004FC0 RID: 20416
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F88 RID: 3976
		[ObfuscatedName("Common.TimelineExtestion.COM_ACharacter_ResetClothes_Behaviour+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0601137E RID: 70526 RVA: 0x003F7C64 File Offset: 0x003F5E64
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0>.NativeClassPtr);
				COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_clothesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0>.NativeClassPtr, "clothesId");
				COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0>.NativeClassPtr, 100687693);
				COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__0_Internal_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0>.NativeClassPtr, 100687694);
			}

			// Token: 0x0601137F RID: 70527 RVA: 0x003F7CCC File Offset: 0x003F5ECC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011380 RID: 70528 RVA: 0x003F7D08 File Offset: 0x003F5F08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293865, XrefRangeEnd = 293870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UniTask _OnBehaviourEnterAsync_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__0_Internal_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new UniTask(pointer);
			}

			// Token: 0x06011381 RID: 70529 RVA: 0x00095AFE File Offset: 0x00093CFE
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700597C RID: 22908
			// (get) Token: 0x06011382 RID: 70530 RVA: 0x003F7D40 File Offset: 0x003F5F40
			// (set) Token: 0x06011383 RID: 70531 RVA: 0x00095B07 File Offset: 0x00093D07
			public unsafe int clothesId
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_clothesId);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetClothes_Behaviour.__c__DisplayClass1_0.NativeFieldInfoPtr_clothesId)) = value;
				}
			}

			// Token: 0x0400AE25 RID: 44581
			private static readonly IntPtr NativeFieldInfoPtr_clothesId;

			// Token: 0x0400AE26 RID: 44582
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AE27 RID: 44583
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__0_Internal_UniTask_0;
		}

		// Token: 0x02000F89 RID: 3977
		[ObfuscatedName("Common.TimelineExtestion.COM_ACharacter_ResetClothes_Behaviour+<OnBehaviourEnterAsync>d__1")]
		public sealed class _OnBehaviourEnterAsync_d__1 : ValueType
		{
			// Token: 0x06011384 RID: 70532 RVA: 0x003F7D68 File Offset: 0x003F5F68
			// Note: this type is marked as 'beforefieldinit'.
			static _OnBehaviourEnterAsync_d__1()
			{
				Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour>.NativeClassPtr, "<OnBehaviourEnterAsync>d__1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1>.NativeClassPtr);
				COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1>.NativeClassPtr, "<>1__state");
				COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1>.NativeClassPtr, "<>t__builder");
				COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1>.NativeClassPtr, "<>u__1");
				COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1>.NativeClassPtr, 100687695);
				COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1>.NativeClassPtr, 100687696);
			}

			// Token: 0x06011385 RID: 70533 RVA: 0x003F7DF8 File Offset: 0x003F5FF8
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 293908, RefRangeEnd = 293912, XrefRangeStart = 293870, XrefRangeEnd = 293908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011386 RID: 70534 RVA: 0x003F7E30 File Offset: 0x003F6030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011387 RID: 70535 RVA: 0x00095B22 File Offset: 0x00093D22
			public _OnBehaviourEnterAsync_d__1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06011388 RID: 70536 RVA: 0x00095B2B File Offset: 0x00093D2B
			public _OnBehaviourEnterAsync_d__1() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1>.NativeClassPtr))
			{
			}

			// Token: 0x1700597D RID: 22909
			// (get) Token: 0x06011389 RID: 70537 RVA: 0x003F7E78 File Offset: 0x003F6078
			// (set) Token: 0x0601138A RID: 70538 RVA: 0x00095B3D File Offset: 0x00093D3D
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700597E RID: 22910
			// (get) Token: 0x0601138B RID: 70539 RVA: 0x003F7EA0 File Offset: 0x003F60A0
			// (set) Token: 0x0601138C RID: 70540 RVA: 0x00095B58 File Offset: 0x00093D58
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700597F RID: 22911
			// (get) Token: 0x0601138D RID: 70541 RVA: 0x003F7ED0 File Offset: 0x003F60D0
			// (set) Token: 0x0601138E RID: 70542 RVA: 0x00095B86 File Offset: 0x00093D86
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_ResetClothes_Behaviour._OnBehaviourEnterAsync_d__1.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AE28 RID: 44584
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AE29 RID: 44585
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400AE2A RID: 44586
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400AE2B RID: 44587
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE2C RID: 44588
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
