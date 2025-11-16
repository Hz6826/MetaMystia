using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Common.TimelineExtestion
{
	// Token: 0x0200042A RID: 1066
	public class COM_ACharacter_Move_Behaviour : NormalPlayableBehaviour
	{
		// Token: 0x06007898 RID: 30872 RVA: 0x0022F1C0 File Offset: 0x0022D3C0
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ACharacter_Move_Behaviour()
		{
			Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ACharacter_Move_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr);
			COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr, "label");
			COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr, "shouldWaitForFinish");
			COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_speedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr, "speedMultiplier");
			COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_wayPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr, "wayPoints");
			COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_noAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr, "noAnimation");
			COM_ACharacter_Move_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr, 100687656);
			COM_ACharacter_Move_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr, 100687657);
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x0022F27C File Offset: 0x0022D47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293670, XrefRangeEnd = 293692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ACharacter_Move_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600789A RID: 30874 RVA: 0x0022F2B8 File Offset: 0x0022D4B8
		[CallerCount(201)]
		[CachedScanResults(RefRangeStart = 42926, RefRangeEnd = 43127, XrefRangeStart = 42926, XrefRangeEnd = 43127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ACharacter_Move_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Move_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600789B RID: 30875 RVA: 0x00041371 File Offset: 0x0003F571
		public COM_ACharacter_Move_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x0600789C RID: 30876 RVA: 0x0022F2F4 File Offset: 0x0022D4F4
		// (set) Token: 0x0600789D RID: 30877 RVA: 0x0004137A File Offset: 0x0003F57A
		public unsafe string label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x0600789E RID: 30878 RVA: 0x0022F31C File Offset: 0x0022D51C
		// (set) Token: 0x0600789F RID: 30879 RVA: 0x00041399 File Offset: 0x0003F599
		public unsafe bool shouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_shouldWaitForFinish)) = value;
			}
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x0022F344 File Offset: 0x0022D544
		// (set) Token: 0x060078A1 RID: 30881 RVA: 0x000413B4 File Offset: 0x0003F5B4
		public unsafe float speedMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_speedMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_speedMultiplier)) = value;
			}
		}

		// Token: 0x170028FD RID: 10493
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x0022F36C File Offset: 0x0022D56C
		// (set) Token: 0x060078A3 RID: 30883 RVA: 0x000413CF File Offset: 0x0003F5CF
		public unsafe Il2CppStructArray<Vector2> wayPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_wayPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_wayPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170028FE RID: 10494
		// (get) Token: 0x060078A4 RID: 30884 RVA: 0x0022F39C File Offset: 0x0022D59C
		// (set) Token: 0x060078A5 RID: 30885 RVA: 0x000413EE File Offset: 0x0003F5EE
		public unsafe bool noAnimation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_noAnimation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ACharacter_Move_Behaviour.NativeFieldInfoPtr_noAnimation)) = value;
			}
		}

		// Token: 0x04004F7F RID: 20351
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04004F80 RID: 20352
		private static readonly IntPtr NativeFieldInfoPtr_shouldWaitForFinish;

		// Token: 0x04004F81 RID: 20353
		private static readonly IntPtr NativeFieldInfoPtr_speedMultiplier;

		// Token: 0x04004F82 RID: 20354
		private static readonly IntPtr NativeFieldInfoPtr_wayPoints;

		// Token: 0x04004F83 RID: 20355
		private static readonly IntPtr NativeFieldInfoPtr_noAnimation;

		// Token: 0x04004F84 RID: 20356
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04004F85 RID: 20357
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000F84 RID: 3972
		[ObfuscatedName("Common.TimelineExtestion.COM_ACharacter_Move_Behaviour+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06011369 RID: 70505 RVA: 0x003F794C File Offset: 0x003F5B4C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour.__c>.NativeClassPtr);
				COM_ACharacter_Move_Behaviour.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour.__c>.NativeClassPtr, "<>9");
				COM_ACharacter_Move_Behaviour.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour.__c>.NativeClassPtr, "<>9__5_0");
				COM_ACharacter_Move_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour.__c>.NativeClassPtr, 100687659);
				COM_ACharacter_Move_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__5_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour.__c>.NativeClassPtr, 100687660);
			}

			// Token: 0x0601136A RID: 70506 RVA: 0x003F79C8 File Offset: 0x003F5BC8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ACharacter_Move_Behaviour.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Move_Behaviour.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601136B RID: 70507 RVA: 0x003F7A04 File Offset: 0x003F5C04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 293667, XrefRangeEnd = 293670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnBehaviourEnter_b__5_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ACharacter_Move_Behaviour.__c.NativeMethodInfoPtr__OnBehaviourEnter_b__5_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0601136C RID: 70508 RVA: 0x00095A20 File Offset: 0x00093C20
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17005976 RID: 22902
			// (get) Token: 0x0601136D RID: 70509 RVA: 0x003F7A38 File Offset: 0x003F5C38
			// (set) Token: 0x0601136E RID: 70510 RVA: 0x00095A29 File Offset: 0x00093C29
			public unsafe static COM_ACharacter_Move_Behaviour.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(COM_ACharacter_Move_Behaviour.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<COM_ACharacter_Move_Behaviour.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(COM_ACharacter_Move_Behaviour.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17005977 RID: 22903
			// (get) Token: 0x0601136F RID: 70511 RVA: 0x003F7A60 File Offset: 0x003F5C60
			// (set) Token: 0x06011370 RID: 70512 RVA: 0x00095A3B File Offset: 0x00093C3B
			public unsafe static Action __9__5_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(COM_ACharacter_Move_Behaviour.__c.NativeFieldInfoPtr___9__5_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(COM_ACharacter_Move_Behaviour.__c.NativeFieldInfoPtr___9__5_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400AE13 RID: 44563
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400AE14 RID: 44564
			private static readonly IntPtr NativeFieldInfoPtr___9__5_0;

			// Token: 0x0400AE15 RID: 44565
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400AE16 RID: 44566
			private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__5_0_Internal_Void_0;
		}
	}
}
