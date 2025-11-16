using System;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Runtime.CompilerServices;

namespace Common.TimelineExtestion
{
	// Token: 0x02000435 RID: 1077
	public class COM_ACharacter_SetClothes_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06007907 RID: 30983 RVA: 0x002302BC File Offset: 0x0022E4BC
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_SetClothes_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_SetClothes_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr);
			COM_ACharacter_SetClothes_Behaviour.NativeFieldInfoPtr_m_SourceClothesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr, "m_SourceClothesId");
			COM_ACharacter_SetClothes_Behaviour.NativeFieldInfoPtr_clothesId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr, "clothesId");
			COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr, 100687682);
			COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr_OnBehaviourEnterAsync_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr, 100687683);
			COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr_TryGetSourceClothesId_Public_Static_Boolean_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr, 100687684);
			COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr, 100687685);
			COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__3_0_Private_UniTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr, 100687687);
		}

		// Token: 0x06007908 RID: 30984 RVA: 0x00230378 File Offset: 0x0022E578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293836, XrefRangeEnd = 293849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007909 RID: 30985 RVA: 0x002303B4 File Offset: 0x0022E5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293849, XrefRangeEnd = 293855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask OnBehaviourEnterAsync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr_OnBehaviourEnterAsync_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x002303EC File Offset: 0x0022E5EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293855, XrefRangeEnd = 293860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetSourceClothesId(out int clothesId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &clothesId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr_TryGetSourceClothesId_Public_Static_Boolean_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x0023042C File Offset: 0x0022E62C
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_SetClothes_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x00230468 File Offset: 0x0022E668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293860, XrefRangeEnd = 293865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UniTask _OnBehaviourEnterAsync_b__3_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SetClothes_Behaviour.NativeMethodInfoPtr__OnBehaviourEnterAsync_b__3_0_Private_UniTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new UniTask(pointer);
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x0004177F File Offset: 0x0003F97F
		public COM_ACharacter_SetClothes_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700291B RID: 10523
		// (get) Token: 0x0600790E RID: 30990 RVA: 0x002304A0 File Offset: 0x0022E6A0
		// (set) Token: 0x0600790F RID: 30991 RVA: 0x00041788 File Offset: 0x0003F988
		public unsafe static int m_SourceClothesId
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(COM_ACharacter_SetClothes_Behaviour.NativeFieldInfoPtr_m_SourceClothesId, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(COM_ACharacter_SetClothes_Behaviour.NativeFieldInfoPtr_m_SourceClothesId, (void*)(&value));
			}
		}

		// Token: 0x1700291C RID: 10524
		// (get) Token: 0x06007910 RID: 30992 RVA: 0x002304BC File Offset: 0x0022E6BC
		// (set) Token: 0x06007911 RID: 30993 RVA: 0x00041796 File Offset: 0x0003F996
		public unsafe int clothesId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour.NativeFieldInfoPtr_clothesId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour.NativeFieldInfoPtr_clothesId)) = value;
			}
		}

		// Token: 0x04004FB7 RID: 20407
		private static readonly IntPtr NativeFieldInfoPtr_m_SourceClothesId;

		// Token: 0x04004FB8 RID: 20408
		private static readonly IntPtr NativeFieldInfoPtr_clothesId;

		// Token: 0x04004FB9 RID: 20409
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FBA RID: 20410
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnterAsync_Private_UniTask_0;

		// Token: 0x04004FBB RID: 20411
		private static readonly IntPtr NativeMethodInfoPtr_TryGetSourceClothesId_Public_Static_Boolean_byref_Int32_0;

		// Token: 0x04004FBC RID: 20412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004FBD RID: 20413
		private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnterAsync_b__3_0_Private_UniTask_0;

		// Token: 0x02000F87 RID: 3975
		[ObfuscatedName("Common.TimelineExtestion.COM_ACharacter_SetClothes_Behaviour+<OnBehaviourEnterAsync>d__3")]
		public sealed class _OnBehaviourEnterAsync_d__3 : ValueType
		{
			// Token: 0x06011371 RID: 70513 RVA: 0x003F7A88 File Offset: 0x003F5C88
			// Note: this type is marked as 'beforefieldinit'.
			static _OnBehaviourEnterAsync_d__3()
			{
				Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour>.NativeClassPtr, "<OnBehaviourEnterAsync>d__3");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3>.NativeClassPtr);
				COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3>.NativeClassPtr, "<>1__state");
				COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___t__builder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3>.NativeClassPtr, "<>t__builder");
				COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3>.NativeClassPtr, "<>4__this");
				COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___u__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3>.NativeClassPtr, "<>u__1");
				COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3>.NativeClassPtr, 100687688);
				COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3>.NativeClassPtr, 100687689);
			}

			// Token: 0x06011372 RID: 70514 RVA: 0x003F7B2C File Offset: 0x003F5D2C
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 293832, RefRangeEnd = 293836, XrefRangeStart = 293796, XrefRangeEnd = 293832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011373 RID: 70515 RVA: 0x003F7B64 File Offset: 0x003F5D64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stateMachine);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011374 RID: 70516 RVA: 0x00095A4D File Offset: 0x00093C4D
			public _OnBehaviourEnterAsync_d__3(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x06011375 RID: 70517 RVA: 0x00095A56 File Offset: 0x00093C56
			public _OnBehaviourEnterAsync_d__3() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3>.NativeClassPtr))
			{
			}

			// Token: 0x17005978 RID: 22904
			// (get) Token: 0x06011376 RID: 70518 RVA: 0x003F7BAC File Offset: 0x003F5DAC
			// (set) Token: 0x06011377 RID: 70519 RVA: 0x00095A68 File Offset: 0x00093C68
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005979 RID: 22905
			// (get) Token: 0x06011378 RID: 70520 RVA: 0x003F7BD4 File Offset: 0x003F5DD4
			// (set) Token: 0x06011379 RID: 70521 RVA: 0x00095A83 File Offset: 0x00093C83
			public AsyncUniTaskMethodBuilder __t__builder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___t__builder);
					return new AsyncUniTaskMethodBuilder(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___t__builder), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AsyncUniTaskMethodBuilder>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700597A RID: 22906
			// (get) Token: 0x0601137A RID: 70522 RVA: 0x003F7C04 File Offset: 0x003F5E04
			// (set) Token: 0x0601137B RID: 70523 RVA: 0x00095AB1 File Offset: 0x00093CB1
			public unsafe COM_ACharacter_SetClothes_Behaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<COM_ACharacter_SetClothes_Behaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700597B RID: 22907
			// (get) Token: 0x0601137C RID: 70524 RVA: 0x003F7C34 File Offset: 0x003F5E34
			// (set) Token: 0x0601137D RID: 70525 RVA: 0x00095AD0 File Offset: 0x00093CD0
			public UniTask.Awaiter __u__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___u__1);
					return new UniTask.Awaiter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_SetClothes_Behaviour._OnBehaviourEnterAsync_d__3.NativeFieldInfoPtr___u__1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<UniTask.Awaiter>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x0400AE1F RID: 44575
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AE20 RID: 44576
			private static readonly IntPtr NativeFieldInfoPtr___t__builder;

			// Token: 0x0400AE21 RID: 44577
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400AE22 RID: 44578
			private static readonly IntPtr NativeFieldInfoPtr___u__1;

			// Token: 0x0400AE23 RID: 44579
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE24 RID: 44580
			private static readonly IntPtr NativeMethodInfoPtr_SetStateMachine_Private_Virtual_Final_New_Void_IAsyncStateMachine_0;
		}
	}
}
