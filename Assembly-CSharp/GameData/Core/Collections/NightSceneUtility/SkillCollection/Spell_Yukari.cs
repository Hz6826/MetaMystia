using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Night.EventSystem.Spells.SpecialItem;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000293 RID: 659
	public class Spell_Yukari : SpellBase
	{
		// Token: 0x06005375 RID: 21365 RVA: 0x001B8D4C File Offset: 0x001B6F4C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Yukari()
		{
			Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Yukari");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr);
			Spell_Yukari.NativeFieldInfoPtr_checkTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "checkTime");
			Spell_Yukari.NativeFieldInfoPtr_maxCouldAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "maxCouldAdd");
			Spell_Yukari.NativeFieldInfoPtr_kimaNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "kimaNum");
			Spell_Yukari.NativeFieldInfoPtr_kimaDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "kimaDuration");
			Spell_Yukari.NativeFieldInfoPtr_kimaChangePositionInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "kimaChangePositionInterval");
			Spell_Yukari.NativeFieldInfoPtr_kimaObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "kimaObject");
			Spell_Yukari.NativeFieldInfoPtr_frozenVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "frozenVfx");
			Spell_Yukari.NativeFieldInfoPtr_YUKARI_BUFF_TIME_SET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "YUKARI_BUFF_TIME_SET");
			Spell_Yukari.NativeFieldInfoPtr_YUKARI_KIMA_SPAWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "YUKARI_KIMA_SPAWN");
			Spell_Yukari.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, 100680279);
			Spell_Yukari.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, 100680280);
			Spell_Yukari.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, 100680281);
			Spell_Yukari.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, 100680282);
			Spell_Yukari.NativeMethodInfoPtr_Method_Private_Boolean_Int32_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, 100680283);
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x001B8E94 File Offset: 0x001B7094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208803, XrefRangeEnd = 208805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yukari.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x001B8ED8 File Offset: 0x001B70D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208805, XrefRangeEnd = 208810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yukari.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x001B8F34 File Offset: 0x001B7134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208810, XrefRangeEnd = 208815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Yukari.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x001B8F90 File Offset: 0x001B7190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208815, XrefRangeEnd = 208820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Yukari() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600537A RID: 21370 RVA: 0x001B8FCC File Offset: 0x001B71CC
		[CallerCount(0)]
		public unsafe bool Method_Private_Boolean_Int32_PDM_0(int currentTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.NativeMethodInfoPtr_Method_Private_Boolean_Int32_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600537B RID: 21371 RVA: 0x0002CD49 File Offset: 0x0002AF49
		public Spell_Yukari(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x0600537C RID: 21372 RVA: 0x001B9018 File Offset: 0x001B7218
		// (set) Token: 0x0600537D RID: 21373 RVA: 0x0002CD52 File Offset: 0x0002AF52
		public unsafe int checkTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_checkTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_checkTime)) = value;
			}
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x0600537E RID: 21374 RVA: 0x001B9040 File Offset: 0x001B7240
		// (set) Token: 0x0600537F RID: 21375 RVA: 0x0002CD6D File Offset: 0x0002AF6D
		public unsafe int maxCouldAdd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_maxCouldAdd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_maxCouldAdd)) = value;
			}
		}

		// Token: 0x17001C98 RID: 7320
		// (get) Token: 0x06005380 RID: 21376 RVA: 0x001B9068 File Offset: 0x001B7268
		// (set) Token: 0x06005381 RID: 21377 RVA: 0x0002CD88 File Offset: 0x0002AF88
		public unsafe int kimaNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_kimaNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_kimaNum)) = value;
			}
		}

		// Token: 0x17001C99 RID: 7321
		// (get) Token: 0x06005382 RID: 21378 RVA: 0x001B9090 File Offset: 0x001B7290
		// (set) Token: 0x06005383 RID: 21379 RVA: 0x0002CDA3 File Offset: 0x0002AFA3
		public unsafe int kimaDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_kimaDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_kimaDuration)) = value;
			}
		}

		// Token: 0x17001C9A RID: 7322
		// (get) Token: 0x06005384 RID: 21380 RVA: 0x001B90B8 File Offset: 0x001B72B8
		// (set) Token: 0x06005385 RID: 21381 RVA: 0x0002CDBE File Offset: 0x0002AFBE
		public unsafe int kimaChangePositionInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_kimaChangePositionInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_kimaChangePositionInterval)) = value;
			}
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x06005386 RID: 21382 RVA: 0x001B90E0 File Offset: 0x001B72E0
		// (set) Token: 0x06005387 RID: 21383 RVA: 0x0002CDD9 File Offset: 0x0002AFD9
		public unsafe GameObject kimaObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_kimaObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_kimaObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06005388 RID: 21384 RVA: 0x001B9110 File Offset: 0x001B7310
		// (set) Token: 0x06005389 RID: 21385 RVA: 0x0002CDF8 File Offset: 0x0002AFF8
		public unsafe GameObject frozenVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_frozenVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_frozenVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x0600538A RID: 21386 RVA: 0x001B9140 File Offset: 0x001B7340
		// (set) Token: 0x0600538B RID: 21387 RVA: 0x0002CE17 File Offset: 0x0002B017
		public unsafe static string YUKARI_BUFF_TIME_SET
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Yukari.NativeFieldInfoPtr_YUKARI_BUFF_TIME_SET, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Yukari.NativeFieldInfoPtr_YUKARI_BUFF_TIME_SET, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x0600538C RID: 21388 RVA: 0x001B9160 File Offset: 0x001B7360
		// (set) Token: 0x0600538D RID: 21389 RVA: 0x0002CE29 File Offset: 0x0002B029
		public unsafe string YUKARI_KIMA_SPAWN
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_YUKARI_KIMA_SPAWN);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.NativeFieldInfoPtr_YUKARI_KIMA_SPAWN), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04003828 RID: 14376
		private static readonly IntPtr NativeFieldInfoPtr_checkTime;

		// Token: 0x04003829 RID: 14377
		private static readonly IntPtr NativeFieldInfoPtr_maxCouldAdd;

		// Token: 0x0400382A RID: 14378
		private static readonly IntPtr NativeFieldInfoPtr_kimaNum;

		// Token: 0x0400382B RID: 14379
		private static readonly IntPtr NativeFieldInfoPtr_kimaDuration;

		// Token: 0x0400382C RID: 14380
		private static readonly IntPtr NativeFieldInfoPtr_kimaChangePositionInterval;

		// Token: 0x0400382D RID: 14381
		private static readonly IntPtr NativeFieldInfoPtr_kimaObject;

		// Token: 0x0400382E RID: 14382
		private static readonly IntPtr NativeFieldInfoPtr_frozenVfx;

		// Token: 0x0400382F RID: 14383
		private static readonly IntPtr NativeFieldInfoPtr_YUKARI_BUFF_TIME_SET;

		// Token: 0x04003830 RID: 14384
		private static readonly IntPtr NativeFieldInfoPtr_YUKARI_KIMA_SPAWN;

		// Token: 0x04003831 RID: 14385
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003832 RID: 14386
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003833 RID: 14387
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x04003834 RID: 14388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003835 RID: 14389
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Boolean_Int32_PDM_0;

		// Token: 0x02000C15 RID: 3093
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yukari+<>c__DisplayClass9_0")]
		public sealed class __c__DisplayClass9_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E084 RID: 57476 RVA: 0x00363624 File Offset: 0x00361824
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_0()
			{
				Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "<>c__DisplayClass9_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_0>.NativeClassPtr);
				Spell_Yukari.__c__DisplayClass9_0.NativeFieldInfoPtr_interrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_0>.NativeClassPtr, "interrupt");
				Spell_Yukari.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_0>.NativeClassPtr, "<>4__this");
				Spell_Yukari.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_0>.NativeClassPtr, 100680284);
				Spell_Yukari.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_0>.NativeClassPtr, 100680285);
			}

			// Token: 0x0600E085 RID: 57477 RVA: 0x003636A0 File Offset: 0x003618A0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass9_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E086 RID: 57478 RVA: 0x003636DC File Offset: 0x003618DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208402, XrefRangeEnd = 208422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass9_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E087 RID: 57479 RVA: 0x00077D00 File Offset: 0x00075F00
			public __c__DisplayClass9_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048EE RID: 18670
			// (get) Token: 0x0600E088 RID: 57480 RVA: 0x00363710 File Offset: 0x00361910
			// (set) Token: 0x0600E089 RID: 57481 RVA: 0x00077D09 File Offset: 0x00075F09
			public unsafe Action interrupt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass9_0.NativeFieldInfoPtr_interrupt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass9_0.NativeFieldInfoPtr_interrupt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048EF RID: 18671
			// (get) Token: 0x0600E08A RID: 57482 RVA: 0x00363740 File Offset: 0x00361940
			// (set) Token: 0x0600E08B RID: 57483 RVA: 0x00077D28 File Offset: 0x00075F28
			public unsafe Spell_Yukari __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yukari>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass9_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FA7 RID: 36775
			private static readonly IntPtr NativeFieldInfoPtr_interrupt;

			// Token: 0x04008FA8 RID: 36776
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FA9 RID: 36777
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FAA RID: 36778
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000C16 RID: 3094
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yukari+<>c__DisplayClass9_1")]
		public sealed class __c__DisplayClass9_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E08C RID: 57484 RVA: 0x00363770 File Offset: 0x00361970
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass9_1()
			{
				Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "<>c__DisplayClass9_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_1>.NativeClassPtr);
				Spell_Yukari.__c__DisplayClass9_1.NativeFieldInfoPtr_timedBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_1>.NativeClassPtr, "timedBuff");
				Spell_Yukari.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_1>.NativeClassPtr, 100680286);
				Spell_Yukari.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Boolean_ValueTuple_2_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_1>.NativeClassPtr, 100680287);
			}

			// Token: 0x0600E08D RID: 57485 RVA: 0x003637D8 File Offset: 0x003619D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass9_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass9_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass9_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E08E RID: 57486 RVA: 0x00363814 File Offset: 0x00361A14
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__3(ValueTuple<int, int> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass9_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Boolean_ValueTuple_2_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E08F RID: 57487 RVA: 0x00077D47 File Offset: 0x00075F47
			public __c__DisplayClass9_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048F0 RID: 18672
			// (get) Token: 0x0600E090 RID: 57488 RVA: 0x00363868 File Offset: 0x00361A68
			// (set) Token: 0x0600E091 RID: 57489 RVA: 0x00077D50 File Offset: 0x00075F50
			public unsafe EventManager.BuffType timedBuff
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass9_1.NativeFieldInfoPtr_timedBuff);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass9_1.NativeFieldInfoPtr_timedBuff)) = value;
				}
			}

			// Token: 0x04008FAB RID: 36779
			private static readonly IntPtr NativeFieldInfoPtr_timedBuff;

			// Token: 0x04008FAC RID: 36780
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FAD RID: 36781
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Boolean_ValueTuple_2_Int32_Int32_0;
		}

		// Token: 0x02000C17 RID: 3095
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yukari+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600E092 RID: 57490 RVA: 0x00363890 File Offset: 0x00361A90
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr);
				Spell_Yukari.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, "<>9");
				Spell_Yukari.__c.NativeFieldInfoPtr___9__9_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, "<>9__9_1");
				Spell_Yukari.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, "<>9__11_0");
				Spell_Yukari.__c.NativeFieldInfoPtr___9__11_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, "<>9__11_5");
				Spell_Yukari.__c.NativeFieldInfoPtr___9__11_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, "<>9__11_6");
				Spell_Yukari.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, 100680289);
				Spell_Yukari.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_1_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, 100680290);
				Spell_Yukari.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_0_Internal_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, 100680291);
				Spell_Yukari.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_5_Internal_Yukari_Kima_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, 100680292);
				Spell_Yukari.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_6_Internal_Vector2Int_Yukari_Kima_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr, 100680293);
			}

			// Token: 0x0600E093 RID: 57491 RVA: 0x00363984 File Offset: 0x00361B84
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yukari.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E094 RID: 57492 RVA: 0x003639C0 File Offset: 0x00361BC0
			[CallerCount(0)]
			public unsafe string _OnPositiveBuffExecute_b__9_1(string x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_1_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600E095 RID: 57493 RVA: 0x00363A08 File Offset: 0x00361C08
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208422, XrefRangeEnd = 208428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _OnNegativeBuffExecute_b__11_0(Vector2Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_0_Internal_Boolean_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E096 RID: 57494 RVA: 0x00363A54 File Offset: 0x00361C54
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208428, XrefRangeEnd = 208432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Yukari_Kima _OnNegativeBuffExecute_b__11_5(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_5_Internal_Yukari_Kima_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Yukari_Kima>(intPtr3) : null;
			}

			// Token: 0x0600E097 RID: 57495 RVA: 0x00363AA4 File Offset: 0x00361CA4
			[CallerCount(0)]
			public unsafe Vector2Int _OnNegativeBuffExecute_b__11_6(Yukari_Kima x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_6_Internal_Vector2Int_Yukari_Kima_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600E098 RID: 57496 RVA: 0x00077D6B File Offset: 0x00075F6B
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048F1 RID: 18673
			// (get) Token: 0x0600E099 RID: 57497 RVA: 0x00363AF4 File Offset: 0x00361CF4
			// (set) Token: 0x0600E09A RID: 57498 RVA: 0x00077D74 File Offset: 0x00075F74
			public unsafe static Spell_Yukari.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yukari.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yukari.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yukari.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048F2 RID: 18674
			// (get) Token: 0x0600E09B RID: 57499 RVA: 0x00363B1C File Offset: 0x00361D1C
			// (set) Token: 0x0600E09C RID: 57500 RVA: 0x00077D86 File Offset: 0x00075F86
			public unsafe static Func<string, string> __9__9_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yukari.__c.NativeFieldInfoPtr___9__9_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yukari.__c.NativeFieldInfoPtr___9__9_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048F3 RID: 18675
			// (get) Token: 0x0600E09D RID: 57501 RVA: 0x00363B44 File Offset: 0x00361D44
			// (set) Token: 0x0600E09E RID: 57502 RVA: 0x00077D98 File Offset: 0x00075F98
			public unsafe static Func<Vector2Int, bool> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yukari.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector2Int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yukari.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048F4 RID: 18676
			// (get) Token: 0x0600E09F RID: 57503 RVA: 0x00363B6C File Offset: 0x00361D6C
			// (set) Token: 0x0600E0A0 RID: 57504 RVA: 0x00077DAA File Offset: 0x00075FAA
			public unsafe static Func<GameObject, Yukari_Kima> __9__11_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yukari.__c.NativeFieldInfoPtr___9__11_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GameObject, Yukari_Kima>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yukari.__c.NativeFieldInfoPtr___9__11_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048F5 RID: 18677
			// (get) Token: 0x0600E0A1 RID: 57505 RVA: 0x00363B94 File Offset: 0x00361D94
			// (set) Token: 0x0600E0A2 RID: 57506 RVA: 0x00077DBC File Offset: 0x00075FBC
			public unsafe static Func<Yukari_Kima, Vector2Int> __9__11_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Yukari.__c.NativeFieldInfoPtr___9__11_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Yukari_Kima, Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Yukari.__c.NativeFieldInfoPtr___9__11_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FAE RID: 36782
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008FAF RID: 36783
			private static readonly IntPtr NativeFieldInfoPtr___9__9_1;

			// Token: 0x04008FB0 RID: 36784
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04008FB1 RID: 36785
			private static readonly IntPtr NativeFieldInfoPtr___9__11_5;

			// Token: 0x04008FB2 RID: 36786
			private static readonly IntPtr NativeFieldInfoPtr___9__11_6;

			// Token: 0x04008FB3 RID: 36787
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FB4 RID: 36788
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_1_Internal_String_String_0;

			// Token: 0x04008FB5 RID: 36789
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_0_Internal_Boolean_Vector2Int_0;

			// Token: 0x04008FB6 RID: 36790
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_5_Internal_Yukari_Kima_GameObject_0;

			// Token: 0x04008FB7 RID: 36791
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__11_6_Internal_Vector2Int_Yukari_Kima_0;
		}

		// Token: 0x02000C18 RID: 3096
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yukari+<OnPositiveBuffExecute>d__9")]
		public sealed class _OnPositiveBuffExecute_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600E0A3 RID: 57507 RVA: 0x00363BBC File Offset: 0x00361DBC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__9()
			{
				Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "<OnPositiveBuffExecute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr);
				Spell_Yukari._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr, "<>1__state");
				Spell_Yukari._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr, "<>2__current");
				Spell_Yukari._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr, "<>4__this");
				Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680294);
				Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680295);
				Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680296);
				Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680297);
				Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680298);
				Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr, 100680299);
			}

			// Token: 0x0600E0A4 RID: 57508 RVA: 0x00363C9C File Offset: 0x00361E9C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yukari._OnPositiveBuffExecute_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0A5 RID: 57509 RVA: 0x00363CE4 File Offset: 0x00361EE4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0A6 RID: 57510 RVA: 0x00363D18 File Offset: 0x00361F18
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208432, XrefRangeEnd = 208567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170048F9 RID: 18681
			// (get) Token: 0x0600E0A7 RID: 57511 RVA: 0x00363D54 File Offset: 0x00361F54
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E0A8 RID: 57512 RVA: 0x00363D94 File Offset: 0x00361F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208567, XrefRangeEnd = 208573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170048FA RID: 18682
			// (get) Token: 0x0600E0A9 RID: 57513 RVA: 0x00363DC8 File Offset: 0x00361FC8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E0AA RID: 57514 RVA: 0x00077DCE File Offset: 0x00075FCE
			public _OnPositiveBuffExecute_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048F6 RID: 18678
			// (get) Token: 0x0600E0AB RID: 57515 RVA: 0x00363E08 File Offset: 0x00362008
			// (set) Token: 0x0600E0AC RID: 57516 RVA: 0x00077DD7 File Offset: 0x00075FD7
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170048F7 RID: 18679
			// (get) Token: 0x0600E0AD RID: 57517 RVA: 0x00363E30 File Offset: 0x00362030
			// (set) Token: 0x0600E0AE RID: 57518 RVA: 0x00077DF2 File Offset: 0x00075FF2
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048F8 RID: 18680
			// (get) Token: 0x0600E0AF RID: 57519 RVA: 0x00363E60 File Offset: 0x00362060
			// (set) Token: 0x0600E0B0 RID: 57520 RVA: 0x00077E11 File Offset: 0x00076011
			public unsafe Spell_Yukari __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yukari>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnPositiveBuffExecute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FB8 RID: 36792
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FB9 RID: 36793
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FBA RID: 36794
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FBB RID: 36795
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FBC RID: 36796
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FBD RID: 36797
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FBE RID: 36798
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FBF RID: 36799
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FC0 RID: 36800
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000C19 RID: 3097
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yukari+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E0B1 RID: 57521 RVA: 0x00363E90 File Offset: 0x00362090
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr);
				Spell_Yukari.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				Spell_Yukari.__c__DisplayClass11_0.NativeFieldInfoPtr_allKima = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr, "allKima");
				Spell_Yukari.__c__DisplayClass11_0.NativeFieldInfoPtr_positionAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr, "positionAvailable");
				Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr, 100680300);
				Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Nullable_1_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr, 100680301);
				Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr, 100680302);
				Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr, 100680303);
				Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_Yukari_Kima_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr, 100680304);
			}

			// Token: 0x0600E0B2 RID: 57522 RVA: 0x00363F5C File Offset: 0x0036215C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0B3 RID: 57523 RVA: 0x00363F98 File Offset: 0x00362198
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 208662, RefRangeEnd = 208664, XrefRangeStart = 208600, XrefRangeEnd = 208662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Nullable<Vector2Int> Method_Internal_Nullable_1_Vector2Int_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr;
				IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Nullable_1_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
				Il2CppException.RaiseExceptionIfNecessary(intPtr);
				return new Nullable<Vector2Int>(pointer);
			}

			// Token: 0x0600E0B4 RID: 57524 RVA: 0x00363FD0 File Offset: 0x003621D0
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 208669, RefRangeEnd = 208670, XrefRangeStart = 208664, XrefRangeEnd = 208669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Vector2Int_0(Vector2Int point)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector2Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600E0B5 RID: 57525 RVA: 0x0036401C File Offset: 0x0036221C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208670, XrefRangeEnd = 208719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GameObject_PDM_0(GameObject currentKima)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentKima);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0B6 RID: 57526 RVA: 0x00364060 File Offset: 0x00362260
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208719, XrefRangeEnd = 208728, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_Yukari_Kima_PDM_0(Yukari_Kima currentKima)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(currentKima);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_Void_Yukari_Kima_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0B7 RID: 57527 RVA: 0x00077E30 File Offset: 0x00076030
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048FB RID: 18683
			// (get) Token: 0x0600E0B8 RID: 57528 RVA: 0x003640A4 File Offset: 0x003622A4
			// (set) Token: 0x0600E0B9 RID: 57529 RVA: 0x00077E39 File Offset: 0x00076039
			public unsafe Spell_Yukari __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yukari>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048FC RID: 18684
			// (get) Token: 0x0600E0BA RID: 57530 RVA: 0x003640D4 File Offset: 0x003622D4
			// (set) Token: 0x0600E0BB RID: 57531 RVA: 0x00077E58 File Offset: 0x00076058
			public unsafe List<Yukari_Kima> allKima
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.NativeFieldInfoPtr_allKima);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Yukari_Kima>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.NativeFieldInfoPtr_allKima), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048FD RID: 18685
			// (get) Token: 0x0600E0BC RID: 57532 RVA: 0x00364104 File Offset: 0x00362304
			// (set) Token: 0x0600E0BD RID: 57533 RVA: 0x00077E77 File Offset: 0x00076077
			public unsafe HashSet<Vector2Int> positionAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.NativeFieldInfoPtr_positionAvailable);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Vector2Int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.NativeFieldInfoPtr_positionAvailable), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FC1 RID: 36801
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FC2 RID: 36802
			private static readonly IntPtr NativeFieldInfoPtr_allKima;

			// Token: 0x04008FC3 RID: 36803
			private static readonly IntPtr NativeFieldInfoPtr_positionAvailable;

			// Token: 0x04008FC4 RID: 36804
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FC5 RID: 36805
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Nullable_1_Vector2Int_0;

			// Token: 0x04008FC6 RID: 36806
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Vector2Int_0;

			// Token: 0x04008FC7 RID: 36807
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GameObject_PDM_0;

			// Token: 0x04008FC8 RID: 36808
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_Yukari_Kima_PDM_0;

			// Token: 0x02001050 RID: 4176
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yukari+<>c__DisplayClass11_0+<<OnNegativeBuffExecute>g__SpawnKima|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011DA4 RID: 73124 RVA: 0x00415C24 File Offset: 0x00413E24
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique()
				{
					Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__SpawnKima|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr);
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, "point");
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, "<>8__1");
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, 100680305);
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, 100680306);
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, 100680307);
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, 100680308);
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, 100680309);
					Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr, 100680310);
				}

				// Token: 0x06011DA5 RID: 73125 RVA: 0x00415D2C File Offset: 0x00413F2C
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DA6 RID: 73126 RVA: 0x00415D74 File Offset: 0x00413F74
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011DA7 RID: 73127 RVA: 0x00415DA8 File Offset: 0x00413FA8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208573, XrefRangeEnd = 208594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005D0B RID: 23819
				// (get) Token: 0x06011DA8 RID: 73128 RVA: 0x00415DE4 File Offset: 0x00413FE4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DA9 RID: 73129 RVA: 0x00415E24 File Offset: 0x00414024
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208594, XrefRangeEnd = 208600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005D0C RID: 23820
				// (get) Token: 0x06011DAA RID: 73130 RVA: 0x00415E58 File Offset: 0x00414058
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011DAB RID: 73131 RVA: 0x0009B13A File Offset: 0x0009933A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005D06 RID: 23814
				// (get) Token: 0x06011DAC RID: 73132 RVA: 0x00415E98 File Offset: 0x00414098
				// (set) Token: 0x06011DAD RID: 73133 RVA: 0x0009B143 File Offset: 0x00099343
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005D07 RID: 23815
				// (get) Token: 0x06011DAE RID: 73134 RVA: 0x00415EC0 File Offset: 0x004140C0
				// (set) Token: 0x06011DAF RID: 73135 RVA: 0x0009B15E File Offset: 0x0009935E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D08 RID: 23816
				// (get) Token: 0x06011DB0 RID: 73136 RVA: 0x00415EF0 File Offset: 0x004140F0
				// (set) Token: 0x06011DB1 RID: 73137 RVA: 0x0009B17D File Offset: 0x0009937D
				public unsafe Spell_Yukari.__c__DisplayClass11_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yukari.__c__DisplayClass11_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005D09 RID: 23817
				// (get) Token: 0x06011DB2 RID: 73138 RVA: 0x00415F20 File Offset: 0x00414120
				// (set) Token: 0x06011DB3 RID: 73139 RVA: 0x0009B19C File Offset: 0x0009939C
				public unsafe Vector2Int point
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr_point);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr_point)) = value;
					}
				}

				// Token: 0x17005D0A RID: 23818
				// (get) Token: 0x06011DB4 RID: 73140 RVA: 0x00415F48 File Offset: 0x00414148
				// (set) Token: 0x06011DB5 RID: 73141 RVA: 0x0009B1B7 File Offset: 0x000993B7
				public unsafe Spell_Yukari.__c__DisplayClass11_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yukari.__c__DisplayClass11_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVepoObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B473 RID: 46195
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B474 RID: 46196
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B475 RID: 46197
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B476 RID: 46198
				private static readonly IntPtr NativeFieldInfoPtr_point;

				// Token: 0x0400B477 RID: 46199
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B478 RID: 46200
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B479 RID: 46201
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B47A RID: 46202
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B47B RID: 46203
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B47C RID: 46204
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B47D RID: 46205
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000C1A RID: 3098
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yukari+<>c__DisplayClass11_1")]
		public sealed class __c__DisplayClass11_1 : Il2CppSystem.Object
		{
			// Token: 0x0600E0BE RID: 57534 RVA: 0x00364134 File Offset: 0x00362334
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_1()
			{
				Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "<>c__DisplayClass11_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_1>.NativeClassPtr);
				Spell_Yukari.__c__DisplayClass11_1.NativeFieldInfoPtr_kima = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_1>.NativeClassPtr, "kima");
				Spell_Yukari.__c__DisplayClass11_1.NativeFieldInfoPtr_point = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_1>.NativeClassPtr, "point");
				Spell_Yukari.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Yukari.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_1>.NativeClassPtr, 100680311);
				Spell_Yukari.__c__DisplayClass11_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_1>.NativeClassPtr, 100680312);
			}

			// Token: 0x0600E0BF RID: 57535 RVA: 0x003641C4 File Offset: 0x003623C4
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yukari.__c__DisplayClass11_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0C0 RID: 57536 RVA: 0x00364200 File Offset: 0x00362400
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208728, XrefRangeEnd = 208751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__7(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari.__c__DisplayClass11_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0C1 RID: 57537 RVA: 0x00077E96 File Offset: 0x00076096
			public __c__DisplayClass11_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170048FE RID: 18686
			// (get) Token: 0x0600E0C2 RID: 57538 RVA: 0x00364244 File Offset: 0x00362444
			// (set) Token: 0x0600E0C3 RID: 57539 RVA: 0x00077E9F File Offset: 0x0007609F
			public unsafe GameObject kima
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_1.NativeFieldInfoPtr_kima);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_1.NativeFieldInfoPtr_kima), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170048FF RID: 18687
			// (get) Token: 0x0600E0C4 RID: 57540 RVA: 0x00364274 File Offset: 0x00362474
			// (set) Token: 0x0600E0C5 RID: 57541 RVA: 0x00077EBE File Offset: 0x000760BE
			public unsafe Vector2Int point
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_1.NativeFieldInfoPtr_point);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_1.NativeFieldInfoPtr_point)) = value;
				}
			}

			// Token: 0x17004900 RID: 18688
			// (get) Token: 0x0600E0C6 RID: 57542 RVA: 0x0036429C File Offset: 0x0036249C
			// (set) Token: 0x0600E0C7 RID: 57543 RVA: 0x00077ED9 File Offset: 0x000760D9
			public unsafe Spell_Yukari.__c__DisplayClass11_0 field_Public___c__DisplayClass11_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yukari.__c__DisplayClass11_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari.__c__DisplayClass11_1.NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FC9 RID: 36809
			private static readonly IntPtr NativeFieldInfoPtr_kima;

			// Token: 0x04008FCA RID: 36810
			private static readonly IntPtr NativeFieldInfoPtr_point;

			// Token: 0x04008FCB RID: 36811
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass11_0_0;

			// Token: 0x04008FCC RID: 36812
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008FCD RID: 36813
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__7_Internal_Void_GameObject_0;
		}

		// Token: 0x02000C1B RID: 3099
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Yukari+<OnNegativeBuffExecute>d__11")]
		public sealed class _OnNegativeBuffExecute_d__11 : Il2CppSystem.Object
		{
			// Token: 0x0600E0C8 RID: 57544 RVA: 0x003642CC File Offset: 0x003624CC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__11()
			{
				Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Yukari>.NativeClassPtr, "<OnNegativeBuffExecute>d__11");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr);
				Spell_Yukari._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>1__state");
				Spell_Yukari._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>2__current");
				Spell_Yukari._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr, "<>4__this");
				Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680313);
				Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680314);
				Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680315);
				Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680316);
				Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680317);
				Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr, 100680318);
			}

			// Token: 0x0600E0C9 RID: 57545 RVA: 0x003643AC File Offset: 0x003625AC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__11(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Yukari._OnNegativeBuffExecute_d__11>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0CA RID: 57546 RVA: 0x003643F4 File Offset: 0x003625F4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600E0CB RID: 57547 RVA: 0x00364428 File Offset: 0x00362628
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208751, XrefRangeEnd = 208797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004904 RID: 18692
			// (get) Token: 0x0600E0CC RID: 57548 RVA: 0x00364464 File Offset: 0x00362664
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E0CD RID: 57549 RVA: 0x003644A4 File Offset: 0x003626A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 208797, XrefRangeEnd = 208803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004905 RID: 18693
			// (get) Token: 0x0600E0CE RID: 57550 RVA: 0x003644D8 File Offset: 0x003626D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600E0CF RID: 57551 RVA: 0x00077EF8 File Offset: 0x000760F8
			public _OnNegativeBuffExecute_d__11(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004901 RID: 18689
			// (get) Token: 0x0600E0D0 RID: 57552 RVA: 0x00364518 File Offset: 0x00362718
			// (set) Token: 0x0600E0D1 RID: 57553 RVA: 0x00077F01 File Offset: 0x00076101
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004902 RID: 18690
			// (get) Token: 0x0600E0D2 RID: 57554 RVA: 0x00364540 File Offset: 0x00362740
			// (set) Token: 0x0600E0D3 RID: 57555 RVA: 0x00077F1C File Offset: 0x0007611C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004903 RID: 18691
			// (get) Token: 0x0600E0D4 RID: 57556 RVA: 0x00364570 File Offset: 0x00362770
			// (set) Token: 0x0600E0D5 RID: 57557 RVA: 0x00077F3B File Offset: 0x0007613B
			public unsafe Spell_Yukari __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Yukari>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Yukari._OnNegativeBuffExecute_d__11.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FCE RID: 36814
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008FCF RID: 36815
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008FD0 RID: 36816
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FD1 RID: 36817
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008FD2 RID: 36818
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FD3 RID: 36819
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008FD4 RID: 36820
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008FD5 RID: 36821
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008FD6 RID: 36822
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
