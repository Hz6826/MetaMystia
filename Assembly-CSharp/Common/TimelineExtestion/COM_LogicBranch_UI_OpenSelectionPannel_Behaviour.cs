using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x02000427 RID: 1063
	public class COM_LogicBranch_UI_OpenSelectionPannel_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x0600787E RID: 30846 RVA: 0x0022ECD4 File Offset: 0x0022CED4
		// Note: this type is marked as 'beforefieldinit'.
		static COM_LogicBranch_UI_OpenSelectionPannel_Behaviour()
		{
			Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_LogicBranch_UI_OpenSelectionPannel_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr);
			COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeFieldInfoPtr_pannelGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, "pannelGameObject");
			COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeFieldInfoPtr_acceptAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, "acceptAddFrames");
			COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeFieldInfoPtr_refuseAddFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, "refuseAddFrames");
			COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, 100687637);
			COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr_ExecuteDelayed_Private_IEnumerator_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, 100687638);
			COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, 100687639);
			COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__3_0_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, 100687640);
			COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__3_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, 100687641);
			COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, 100687642);
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x0022EDB8 File Offset: 0x0022CFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293555, XrefRangeEnd = 293570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x0022EDF4 File Offset: 0x0022CFF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293570, XrefRangeEnd = 293575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ExecuteDelayed(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr_ExecuteDelayed_Private_IEnumerator_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x0022EE44 File Offset: 0x0022D044
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_LogicBranch_UI_OpenSelectionPannel_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x0022EE80 File Offset: 0x0022D080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293575, XrefRangeEnd = 293596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnBehaviourEnter_b__3_0(bool x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__3_0_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x0022EEC0 File Offset: 0x0022D0C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293596, XrefRangeEnd = 293631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnBehaviourEnter_b__3_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__3_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x0022EEF4 File Offset: 0x0022D0F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293631, XrefRangeEnd = 293636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x000412C7 File Offset: 0x0003F4C7
		public COM_LogicBranch_UI_OpenSelectionPannel_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x0022EF28 File Offset: 0x0022D128
		// (set) Token: 0x06007887 RID: 30855 RVA: 0x000412D0 File Offset: 0x0003F4D0
		public unsafe GameObject pannelGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeFieldInfoPtr_pannelGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeFieldInfoPtr_pannelGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028F6 RID: 10486
		// (get) Token: 0x06007888 RID: 30856 RVA: 0x0022EF58 File Offset: 0x0022D158
		// (set) Token: 0x06007889 RID: 30857 RVA: 0x000412EF File Offset: 0x0003F4EF
		public unsafe int acceptAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeFieldInfoPtr_acceptAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeFieldInfoPtr_acceptAddFrames)) = value;
			}
		}

		// Token: 0x170028F7 RID: 10487
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x0022EF80 File Offset: 0x0022D180
		// (set) Token: 0x0600788B RID: 30859 RVA: 0x0004130A File Offset: 0x0003F50A
		public unsafe int refuseAddFrames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeFieldInfoPtr_refuseAddFrames);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.NativeFieldInfoPtr_refuseAddFrames)) = value;
			}
		}

		// Token: 0x04004F70 RID: 20336
		private static readonly IntPtr NativeFieldInfoPtr_pannelGameObject;

		// Token: 0x04004F71 RID: 20337
		private static readonly IntPtr NativeFieldInfoPtr_acceptAddFrames;

		// Token: 0x04004F72 RID: 20338
		private static readonly IntPtr NativeFieldInfoPtr_refuseAddFrames;

		// Token: 0x04004F73 RID: 20339
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F74 RID: 20340
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDelayed_Private_IEnumerator_Action_0;

		// Token: 0x04004F75 RID: 20341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004F76 RID: 20342
		private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__3_0_Private_Void_Boolean_0;

		// Token: 0x04004F77 RID: 20343
		private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__3_2_Private_Void_0;

		// Token: 0x04004F78 RID: 20344
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x02000F82 RID: 3970
		[ObfuscatedName("Common.TimelineExtestion.COM_LogicBranch_UI_OpenSelectionPannel_Behaviour+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06011353 RID: 70483 RVA: 0x003F753C File Offset: 0x003F573C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c>.NativeClassPtr);
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c>.NativeClassPtr, "<>9");
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeFieldInfoPtr___9__3_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c>.NativeClassPtr, "<>9__3_3");
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c>.NativeClassPtr, 100687644);
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__3_3_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c>.NativeClassPtr, 100687645);
			}

			// Token: 0x06011354 RID: 70484 RVA: 0x003F75B8 File Offset: 0x003F57B8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011355 RID: 70485 RVA: 0x003F75F4 File Offset: 0x003F57F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293540, XrefRangeEnd = 293544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnter_b__3_3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__3_3_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011356 RID: 70486 RVA: 0x00095991 File Offset: 0x00093B91
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700596F RID: 22895
			// (get) Token: 0x06011357 RID: 70487 RVA: 0x003F7628 File Offset: 0x003F5828
			// (set) Token: 0x06011358 RID: 70488 RVA: 0x0009599A File Offset: 0x00093B9A
			public unsafe static COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005970 RID: 22896
			// (get) Token: 0x06011359 RID: 70489 RVA: 0x003F7650 File Offset: 0x003F5850
			// (set) Token: 0x0601135A RID: 70490 RVA: 0x000959AC File Offset: 0x00093BAC
			public unsafe static Action __9__3_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeFieldInfoPtr___9__3_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour.__c.NativeFieldInfoPtr___9__3_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE06 RID: 44550
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AE07 RID: 44551
			private static readonly IntPtr NativeFieldInfoPtr___9__3_3;

			// Token: 0x0400AE08 RID: 44552
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AE09 RID: 44553
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__3_3_Internal_Void_0;
		}

		// Token: 0x02000F83 RID: 3971
		[ObfuscatedName("Common.TimelineExtestion.COM_LogicBranch_UI_OpenSelectionPannel_Behaviour+<ExecuteDelayed>d__4")]
		public sealed class _ExecuteDelayed_d__4 : Il2CppSystem.Object
		{
			// Token: 0x0601135B RID: 70491 RVA: 0x003F7678 File Offset: 0x003F5878
			// Note: this type is marked as 'beforefieldinit'.
			static _ExecuteDelayed_d__4()
			{
				Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour>.NativeClassPtr, "<ExecuteDelayed>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr);
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr, "<>1__state");
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr, "<>2__current");
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr, "action");
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr, 100687646);
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr, 100687647);
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr, 100687648);
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr, 100687649);
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr, 100687650);
				COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr, 100687651);
			}

			// Token: 0x0601135C RID: 70492 RVA: 0x003F7758 File Offset: 0x003F5958
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ExecuteDelayed_d__4(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601135D RID: 70493 RVA: 0x003F77A0 File Offset: 0x003F59A0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601135E RID: 70494 RVA: 0x003F77D4 File Offset: 0x003F59D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293544, XrefRangeEnd = 293549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17005974 RID: 22900
			// (get) Token: 0x0601135F RID: 70495 RVA: 0x003F7810 File Offset: 0x003F5A10
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06011360 RID: 70496 RVA: 0x003F7850 File Offset: 0x003F5A50
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293549, XrefRangeEnd = 293555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17005975 RID: 22901
			// (get) Token: 0x06011361 RID: 70497 RVA: 0x003F7884 File Offset: 0x003F5A84
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x06011362 RID: 70498 RVA: 0x000959BE File Offset: 0x00093BBE
			public _ExecuteDelayed_d__4(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005971 RID: 22897
			// (get) Token: 0x06011363 RID: 70499 RVA: 0x003F78C4 File Offset: 0x003F5AC4
			// (set) Token: 0x06011364 RID: 70500 RVA: 0x000959C7 File Offset: 0x00093BC7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17005972 RID: 22898
			// (get) Token: 0x06011365 RID: 70501 RVA: 0x003F78EC File Offset: 0x003F5AEC
			// (set) Token: 0x06011366 RID: 70502 RVA: 0x000959E2 File Offset: 0x00093BE2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005973 RID: 22899
			// (get) Token: 0x06011367 RID: 70503 RVA: 0x003F791C File Offset: 0x003F5B1C
			// (set) Token: 0x06011368 RID: 70504 RVA: 0x00095A01 File Offset: 0x00093C01
			public unsafe Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_LogicBranch_UI_OpenSelectionPannel_Behaviour._ExecuteDelayed_d__4.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE0A RID: 44554
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400AE0B RID: 44555
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400AE0C RID: 44556
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x0400AE0D RID: 44557
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400AE0E RID: 44558
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE0F RID: 44559
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400AE10 RID: 44560
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400AE11 RID: 44561
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400AE12 RID: 44562
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
