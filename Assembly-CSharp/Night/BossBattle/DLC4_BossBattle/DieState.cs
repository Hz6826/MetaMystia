using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x02000099 RID: 153
	public class DieState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000FA3 RID: 4003 RVA: 0x000D355C File Offset: 0x000D175C
		// Note: this type is marked as 'beforefieldinit'.
		static DieState()
		{
			Il2CppClassPointerStore<DieState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "DieState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DieState>.NativeClassPtr);
			DieState.NativeFieldInfoPtr_dieCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DieState>.NativeClassPtr, "dieCoroutine");
			DieState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState>.NativeClassPtr, 100666038);
			DieState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState>.NativeClassPtr, 100666039);
			DieState.NativeMethodInfoPtr_OnEnterState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState>.NativeClassPtr, 100666040);
			DieState.NativeMethodInfoPtr_StartDieIEnumerator_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState>.NativeClassPtr, 100666041);
			DieState.NativeMethodInfoPtr_OnExitState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState>.NativeClassPtr, 100666042);
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x000D3604 File Offset: 0x000D1804
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48315, RefRangeEnd = 48317, XrefRangeStart = 48315, XrefRangeEnd = 48317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DieState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DieState>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enterCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveStateWhenEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000D3684 File Offset: 0x000D1884
		[CallerCount(0)]
		public unsafe override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DieState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x000D36CC File Offset: 0x000D18CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48370, XrefRangeEnd = 48378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnterState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DieState.NativeMethodInfoPtr_OnEnterState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x000D3708 File Offset: 0x000D1908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48378, XrefRangeEnd = 48383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartDieIEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieState.NativeMethodInfoPtr_StartDieIEnumerator_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000D3748 File Offset: 0x000D1948
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48383, XrefRangeEnd = 48384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DieState.NativeMethodInfoPtr_OnExitState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0000A09B File Offset: 0x0000829B
		public DieState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06000FAA RID: 4010 RVA: 0x000D3784 File Offset: 0x000D1984
		// (set) Token: 0x06000FAB RID: 4011 RVA: 0x0000A0A4 File Offset: 0x000082A4
		public unsafe Coroutine dieCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DieState.NativeFieldInfoPtr_dieCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DieState.NativeFieldInfoPtr_dieCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeFieldInfoPtr_dieCoroutine;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterState_Public_Virtual_Void_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_StartDieIEnumerator_Private_IEnumerator_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_OnExitState_Public_Virtual_Void_0;

		// Token: 0x02000579 RID: 1401
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.DieState+<StartDieIEnumerator>d__4")]
		public sealed class _StartDieIEnumerator_d__4 : Il2CppSystem.Object
		{
			// Token: 0x060089E3 RID: 35299 RVA: 0x00262300 File Offset: 0x00260500
			// Note: this type is marked as 'beforefieldinit'.
			static _StartDieIEnumerator_d__4()
			{
				Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DieState>.NativeClassPtr, "<StartDieIEnumerator>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr);
				DieState._StartDieIEnumerator_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr, "<>1__state");
				DieState._StartDieIEnumerator_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr, "<>2__current");
				DieState._StartDieIEnumerator_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr, "<>4__this");
				DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr, 100666043);
				DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr, 100666044);
				DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr, 100666045);
				DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr, 100666046);
				DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr, 100666047);
				DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr, 100666048);
			}

			// Token: 0x060089E4 RID: 35300 RVA: 0x002623E0 File Offset: 0x002605E0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StartDieIEnumerator_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DieState._StartDieIEnumerator_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089E5 RID: 35301 RVA: 0x00262428 File Offset: 0x00260628
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089E6 RID: 35302 RVA: 0x0026245C File Offset: 0x0026065C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48362, XrefRangeEnd = 48364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E3B RID: 11835
			// (get) Token: 0x060089E7 RID: 35303 RVA: 0x00262498 File Offset: 0x00260698
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060089E8 RID: 35304 RVA: 0x002624D8 File Offset: 0x002606D8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48364, XrefRangeEnd = 48370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E3C RID: 11836
			// (get) Token: 0x060089E9 RID: 35305 RVA: 0x0026250C File Offset: 0x0026070C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DieState._StartDieIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060089EA RID: 35306 RVA: 0x0004A252 File Offset: 0x00048452
			public _StartDieIEnumerator_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E38 RID: 11832
			// (get) Token: 0x060089EB RID: 35307 RVA: 0x0026254C File Offset: 0x0026074C
			// (set) Token: 0x060089EC RID: 35308 RVA: 0x0004A25B File Offset: 0x0004845B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DieState._StartDieIEnumerator_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DieState._StartDieIEnumerator_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E39 RID: 11833
			// (get) Token: 0x060089ED RID: 35309 RVA: 0x00262574 File Offset: 0x00260774
			// (set) Token: 0x060089EE RID: 35310 RVA: 0x0004A276 File Offset: 0x00048476
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DieState._StartDieIEnumerator_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DieState._StartDieIEnumerator_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E3A RID: 11834
			// (get) Token: 0x060089EF RID: 35311 RVA: 0x002625A4 File Offset: 0x002607A4
			// (set) Token: 0x060089F0 RID: 35312 RVA: 0x0004A295 File Offset: 0x00048495
			public unsafe DieState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DieState._StartDieIEnumerator_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DieState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DieState._StartDieIEnumerator_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A53 RID: 23123
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005A54 RID: 23124
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005A55 RID: 23125
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A56 RID: 23126
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005A57 RID: 23127
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A58 RID: 23128
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005A59 RID: 23129
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005A5A RID: 23130
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A5B RID: 23131
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
