using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.TimelineExtestion
{
	// Token: 0x02000439 RID: 1081
	public class COM_ADialog_Manual_Init_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x06007926 RID: 31014 RVA: 0x00230898 File Offset: 0x0022EA98
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ADialog_Manual_Init_Behaviour()
		{
			Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ADialog_Manual_Init_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr);
			COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_startPlay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr, "startPlay");
			COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_exit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr, "exit");
			COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr, "dialogPackage");
			COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_PreservePreviousPannelVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr, "PreservePreviousPannelVisual");
			COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_shouldHaveBlackBackgroundInDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr, "shouldHaveBlackBackgroundInDefault");
			COM_ADialog_Manual_Init_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr, 100687702);
			COM_ADialog_Manual_Init_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr, 100687703);
		}

		// Token: 0x06007927 RID: 31015 RVA: 0x00230954 File Offset: 0x0022EB54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293965, XrefRangeEnd = 294008, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ADialog_Manual_Init_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x00230990 File Offset: 0x0022EB90
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ADialog_Manual_Init_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Manual_Init_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007929 RID: 31017 RVA: 0x00041818 File Offset: 0x0003FA18
		public COM_ADialog_Manual_Init_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002920 RID: 10528
		// (get) Token: 0x0600792A RID: 31018 RVA: 0x002309CC File Offset: 0x0022EBCC
		// (set) Token: 0x0600792B RID: 31019 RVA: 0x00041821 File Offset: 0x0003FA21
		public unsafe static Action startPlay
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_startPlay, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_startPlay, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002921 RID: 10529
		// (get) Token: 0x0600792C RID: 31020 RVA: 0x002309F4 File Offset: 0x0022EBF4
		// (set) Token: 0x0600792D RID: 31021 RVA: 0x00041833 File Offset: 0x0003FA33
		public unsafe static Action exit
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_exit, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_exit, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002922 RID: 10530
		// (get) Token: 0x0600792E RID: 31022 RVA: 0x00230A1C File Offset: 0x0022EC1C
		// (set) Token: 0x0600792F RID: 31023 RVA: 0x00041845 File Offset: 0x0003FA45
		public unsafe DialogPackage dialogPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_dialogPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002923 RID: 10531
		// (get) Token: 0x06007930 RID: 31024 RVA: 0x00230A4C File Offset: 0x0022EC4C
		// (set) Token: 0x06007931 RID: 31025 RVA: 0x00041864 File Offset: 0x0003FA64
		public unsafe bool PreservePreviousPannelVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_PreservePreviousPannelVisual);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_PreservePreviousPannelVisual)) = value;
			}
		}

		// Token: 0x17002924 RID: 10532
		// (get) Token: 0x06007932 RID: 31026 RVA: 0x00230A74 File Offset: 0x0022EC74
		// (set) Token: 0x06007933 RID: 31027 RVA: 0x0004187F File Offset: 0x0003FA7F
		public unsafe bool shouldHaveBlackBackgroundInDefault
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_shouldHaveBlackBackgroundInDefault);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Manual_Init_Behaviour.NativeFieldInfoPtr_shouldHaveBlackBackgroundInDefault)) = value;
			}
		}

		// Token: 0x04004FC9 RID: 20425
		private static readonly IntPtr NativeFieldInfoPtr_startPlay;

		// Token: 0x04004FCA RID: 20426
		private static readonly IntPtr NativeFieldInfoPtr_exit;

		// Token: 0x04004FCB RID: 20427
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

		// Token: 0x04004FCC RID: 20428
		private static readonly IntPtr NativeFieldInfoPtr_PreservePreviousPannelVisual;

		// Token: 0x04004FCD RID: 20429
		private static readonly IntPtr NativeFieldInfoPtr_shouldHaveBlackBackgroundInDefault;

		// Token: 0x04004FCE RID: 20430
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004FCF RID: 20431
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F8A RID: 3978
		[ObfuscatedName("Common.TimelineExtestion.COM_ADialog_Manual_Init_Behaviour+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0601138F RID: 70543 RVA: 0x003F7F00 File Offset: 0x003F6100
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour.__c>.NativeClassPtr);
				COM_ADialog_Manual_Init_Behaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour.__c>.NativeClassPtr, "<>9");
				COM_ADialog_Manual_Init_Behaviour.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour.__c>.NativeClassPtr, "<>9__5_0");
				COM_ADialog_Manual_Init_Behaviour.__c.NativeFieldInfoPtr___9__5_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour.__c>.NativeClassPtr, "<>9__5_1");
				COM_ADialog_Manual_Init_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour.__c>.NativeClassPtr, 100687705);
				COM_ADialog_Manual_Init_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__5_0_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour.__c>.NativeClassPtr, 100687706);
				COM_ADialog_Manual_Init_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__5_1_Internal_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour.__c>.NativeClassPtr, 100687707);
			}

			// Token: 0x06011390 RID: 70544 RVA: 0x003F7FA4 File Offset: 0x003F61A4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ADialog_Manual_Init_Behaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Manual_Init_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011391 RID: 70545 RVA: 0x003F7FE0 File Offset: 0x003F61E0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293957, XrefRangeEnd = 293961, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnter_b__5_0(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Manual_Init_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__5_0_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011392 RID: 70546 RVA: 0x003F8024 File Offset: 0x003F6224
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293961, XrefRangeEnd = 293965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnter_b__5_1(Action x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Manual_Init_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__5_1_Internal_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06011393 RID: 70547 RVA: 0x00095BB4 File Offset: 0x00093DB4
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005980 RID: 22912
			// (get) Token: 0x06011394 RID: 70548 RVA: 0x003F8068 File Offset: 0x003F6268
			// (set) Token: 0x06011395 RID: 70549 RVA: 0x00095BBD File Offset: 0x00093DBD
			public unsafe static COM_ADialog_Manual_Init_Behaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(COM_ADialog_Manual_Init_Behaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<COM_ADialog_Manual_Init_Behaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(COM_ADialog_Manual_Init_Behaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005981 RID: 22913
			// (get) Token: 0x06011396 RID: 70550 RVA: 0x003F8090 File Offset: 0x003F6290
			// (set) Token: 0x06011397 RID: 70551 RVA: 0x00095BCF File Offset: 0x00093DCF
			public unsafe static Action<Action> __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(COM_ADialog_Manual_Init_Behaviour.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(COM_ADialog_Manual_Init_Behaviour.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005982 RID: 22914
			// (get) Token: 0x06011398 RID: 70552 RVA: 0x003F80B8 File Offset: 0x003F62B8
			// (set) Token: 0x06011399 RID: 70553 RVA: 0x00095BE1 File Offset: 0x00093DE1
			public unsafe static Action<Action> __9__5_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(COM_ADialog_Manual_Init_Behaviour.__c.NativeFieldInfoPtr___9__5_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(COM_ADialog_Manual_Init_Behaviour.__c.NativeFieldInfoPtr___9__5_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE2D RID: 44589
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AE2E RID: 44590
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400AE2F RID: 44591
			private static readonly IntPtr NativeFieldInfoPtr___9__5_1;

			// Token: 0x0400AE30 RID: 44592
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AE31 RID: 44593
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__5_0_Internal_Void_Action_0;

			// Token: 0x0400AE32 RID: 44594
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__5_1_Internal_Void_Action_0;
		}
	}
}
