using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Night.BossBattle.DLC4_BossBattle
{
	// Token: 0x0200009A RID: 154
	public class ThrowState : DLC4_FlandreEnemyState
	{
		// Token: 0x06000FAC RID: 4012 RVA: 0x000D37B4 File Offset: 0x000D19B4
		// Note: this type is marked as 'beforefieldinit'.
		static ThrowState()
		{
			Il2CppClassPointerStore<ThrowState>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Night.BossBattle.DLC4_BossBattle", "ThrowState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowState>.NativeClassPtr);
			ThrowState.NativeFieldInfoPtr_throwCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowState>.NativeClassPtr, "throwCoroutine");
			ThrowState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState>.NativeClassPtr, 100666049);
			ThrowState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState>.NativeClassPtr, 100666050);
			ThrowState.NativeMethodInfoPtr_OnEnterState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState>.NativeClassPtr, 100666051);
			ThrowState.NativeMethodInfoPtr_StartThrowIEnumerator_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState>.NativeClassPtr, 100666052);
			ThrowState.NativeMethodInfoPtr_OnExitState_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState>.NativeClassPtr, 100666053);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x000D385C File Offset: 0x000D1A5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 48315, RefRangeEnd = 48317, XrefRangeStart = 48315, XrefRangeEnd = 48317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ThrowState(DLC4_FlandreEnemyCharacterController controller, Action enterCallback, Action exitCallback, bool moveStateWhenEnter) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThrowState>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(controller);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(enterCallback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exitCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveStateWhenEnter;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowState.NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x000D38DC File Offset: 0x000D1ADC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 48392, RefRangeEnd = 48393, XrefRangeStart = 48392, XrefRangeEnd = 48392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DLC4_FlandreEnemyCharacterController.CharacterState GetCharacterState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThrowState.NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x000D3924 File Offset: 0x000D1B24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48393, XrefRangeEnd = 48401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnEnterState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThrowState.NativeMethodInfoPtr_OnEnterState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000D3960 File Offset: 0x000D1B60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48401, XrefRangeEnd = 48406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator StartThrowIEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowState.NativeMethodInfoPtr_StartThrowIEnumerator_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000D39A0 File Offset: 0x000D1BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnExitState()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ThrowState.NativeMethodInfoPtr_OnExitState_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x0000A0C3 File Offset: 0x000082C3
		public ThrowState(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06000FB3 RID: 4019 RVA: 0x000D39DC File Offset: 0x000D1BDC
		// (set) Token: 0x06000FB4 RID: 4020 RVA: 0x0000A0CC File Offset: 0x000082CC
		public unsafe Coroutine throwCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowState.NativeFieldInfoPtr_throwCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowState.NativeFieldInfoPtr_throwCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AB2 RID: 2738
		private static readonly IntPtr NativeFieldInfoPtr_throwCoroutine;

		// Token: 0x04000AB3 RID: 2739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DLC4_FlandreEnemyCharacterController_Action_Action_Boolean_0;

		// Token: 0x04000AB4 RID: 2740
		private static readonly IntPtr NativeMethodInfoPtr_GetCharacterState_Public_Virtual_CharacterState_0;

		// Token: 0x04000AB5 RID: 2741
		private static readonly IntPtr NativeMethodInfoPtr_OnEnterState_Public_Virtual_Void_0;

		// Token: 0x04000AB6 RID: 2742
		private static readonly IntPtr NativeMethodInfoPtr_StartThrowIEnumerator_Private_IEnumerator_0;

		// Token: 0x04000AB7 RID: 2743
		private static readonly IntPtr NativeMethodInfoPtr_OnExitState_Public_Virtual_Void_0;

		// Token: 0x0200057A RID: 1402
		[ObfuscatedName("Night.BossBattle.DLC4_BossBattle.ThrowState+<StartThrowIEnumerator>d__4")]
		public sealed class _StartThrowIEnumerator_d__4 : Il2CppSystem.Object
		{
			// Token: 0x060089F1 RID: 35313 RVA: 0x002625D4 File Offset: 0x002607D4
			// Note: this type is marked as 'beforefieldinit'.
			static _StartThrowIEnumerator_d__4()
			{
				Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ThrowState>.NativeClassPtr, "<StartThrowIEnumerator>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr);
				ThrowState._StartThrowIEnumerator_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr, "<>1__state");
				ThrowState._StartThrowIEnumerator_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr, "<>2__current");
				ThrowState._StartThrowIEnumerator_d__4.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr, "<>4__this");
				ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr, 100666054);
				ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr, 100666055);
				ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr, 100666056);
				ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr, 100666057);
				ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr, 100666058);
				ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr, 100666059);
			}

			// Token: 0x060089F2 RID: 35314 RVA: 0x002626B4 File Offset: 0x002608B4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _StartThrowIEnumerator_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ThrowState._StartThrowIEnumerator_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089F3 RID: 35315 RVA: 0x002626FC File Offset: 0x002608FC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060089F4 RID: 35316 RVA: 0x00262730 File Offset: 0x00260930
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48384, XrefRangeEnd = 48386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17002E40 RID: 11840
			// (get) Token: 0x060089F5 RID: 35317 RVA: 0x0026276C File Offset: 0x0026096C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060089F6 RID: 35318 RVA: 0x002627AC File Offset: 0x002609AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 48386, XrefRangeEnd = 48392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17002E41 RID: 11841
			// (get) Token: 0x060089F7 RID: 35319 RVA: 0x002627E0 File Offset: 0x002609E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ThrowState._StartThrowIEnumerator_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x060089F8 RID: 35320 RVA: 0x0004A2B4 File Offset: 0x000484B4
			public _StartThrowIEnumerator_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002E3D RID: 11837
			// (get) Token: 0x060089F9 RID: 35321 RVA: 0x00262820 File Offset: 0x00260A20
			// (set) Token: 0x060089FA RID: 35322 RVA: 0x0004A2BD File Offset: 0x000484BD
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowState._StartThrowIEnumerator_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowState._StartThrowIEnumerator_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17002E3E RID: 11838
			// (get) Token: 0x060089FB RID: 35323 RVA: 0x00262848 File Offset: 0x00260A48
			// (set) Token: 0x060089FC RID: 35324 RVA: 0x0004A2D8 File Offset: 0x000484D8
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowState._StartThrowIEnumerator_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowState._StartThrowIEnumerator_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002E3F RID: 11839
			// (get) Token: 0x060089FD RID: 35325 RVA: 0x00262878 File Offset: 0x00260A78
			// (set) Token: 0x060089FE RID: 35326 RVA: 0x0004A2F7 File Offset: 0x000484F7
			public unsafe ThrowState __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowState._StartThrowIEnumerator_d__4.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThrowState>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ThrowState._StartThrowIEnumerator_d__4.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005A5C RID: 23132
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04005A5D RID: 23133
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04005A5E RID: 23134
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005A5F RID: 23135
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04005A60 RID: 23136
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A61 RID: 23137
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04005A62 RID: 23138
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04005A63 RID: 23139
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04005A64 RID: 23140
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
