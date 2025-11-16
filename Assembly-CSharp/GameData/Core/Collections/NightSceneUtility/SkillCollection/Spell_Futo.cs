using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.GuestManagementUtility;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000264 RID: 612
	public class Spell_Futo : SpellBase
	{
		// Token: 0x06004BBD RID: 19389 RVA: 0x001A5458 File Offset: 0x001A3658
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Futo()
		{
			Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Futo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr);
			Spell_Futo.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "positiveDuration");
			Spell_Futo.NativeFieldInfoPtr_launchSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "launchSpeed");
			Spell_Futo.NativeFieldInfoPtr_launchHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "launchHeight");
			Spell_Futo.NativeFieldInfoPtr_leaveTrayNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "leaveTrayNum");
			Spell_Futo.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "negativeDuration");
			Spell_Futo.NativeFieldInfoPtr_plateGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "plateGameObject");
			Spell_Futo.NativeFieldInfoPtr_futoShip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "futoShip");
			Spell_Futo.NativeFieldInfoPtr_futoFire = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "futoFire");
			Spell_Futo.NativeFieldInfoPtr_futoExplosion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "futoExplosion");
			Spell_Futo.NativeFieldInfoPtr_burntTray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "burntTray");
			Spell_Futo.NativeFieldInfoPtr_boatSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "boatSFX");
			Spell_Futo.NativeFieldInfoPtr_itemSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "itemSFX");
			Spell_Futo.NativeFieldInfoPtr_fireSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "fireSFX");
			Spell_Futo.NativeFieldInfoPtr_plateExplosionSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "plateExplosionSFX");
			Spell_Futo.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, 100678546);
			Spell_Futo.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, 100678547);
			Spell_Futo.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, 100678548);
			Spell_Futo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, 100678549);
		}

		// Token: 0x06004BBE RID: 19390 RVA: 0x001A55F0 File Offset: 0x001A37F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196237, XrefRangeEnd = 196239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Futo.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004BBF RID: 19391 RVA: 0x001A5634 File Offset: 0x001A3834
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196239, XrefRangeEnd = 196245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Futo.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004BC0 RID: 19392 RVA: 0x001A5690 File Offset: 0x001A3890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196245, XrefRangeEnd = 196251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Futo.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004BC1 RID: 19393 RVA: 0x001A56EC File Offset: 0x001A38EC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Futo() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004BC2 RID: 19394 RVA: 0x00026FE9 File Offset: 0x000251E9
		public Spell_Futo(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x06004BC3 RID: 19395 RVA: 0x001A5728 File Offset: 0x001A3928
		// (set) Token: 0x06004BC4 RID: 19396 RVA: 0x00026FF2 File Offset: 0x000251F2
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x06004BC5 RID: 19397 RVA: 0x001A5750 File Offset: 0x001A3950
		// (set) Token: 0x06004BC6 RID: 19398 RVA: 0x0002700D File Offset: 0x0002520D
		public unsafe float launchSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_launchSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_launchSpeed)) = value;
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x06004BC7 RID: 19399 RVA: 0x001A5778 File Offset: 0x001A3978
		// (set) Token: 0x06004BC8 RID: 19400 RVA: 0x00027028 File Offset: 0x00025228
		public unsafe float launchHeight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_launchHeight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_launchHeight)) = value;
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x06004BC9 RID: 19401 RVA: 0x001A57A0 File Offset: 0x001A39A0
		// (set) Token: 0x06004BCA RID: 19402 RVA: 0x00027043 File Offset: 0x00025243
		public unsafe int leaveTrayNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_leaveTrayNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_leaveTrayNum)) = value;
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x06004BCB RID: 19403 RVA: 0x001A57C8 File Offset: 0x001A39C8
		// (set) Token: 0x06004BCC RID: 19404 RVA: 0x0002705E File Offset: 0x0002525E
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x06004BCD RID: 19405 RVA: 0x001A57F0 File Offset: 0x001A39F0
		// (set) Token: 0x06004BCE RID: 19406 RVA: 0x00027079 File Offset: 0x00025279
		public unsafe GameObject plateGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_plateGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_plateGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x06004BCF RID: 19407 RVA: 0x001A5820 File Offset: 0x001A3A20
		// (set) Token: 0x06004BD0 RID: 19408 RVA: 0x00027098 File Offset: 0x00025298
		public unsafe GameObject futoShip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_futoShip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_futoShip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x06004BD1 RID: 19409 RVA: 0x001A5850 File Offset: 0x001A3A50
		// (set) Token: 0x06004BD2 RID: 19410 RVA: 0x000270B7 File Offset: 0x000252B7
		public unsafe GameObject futoFire
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_futoFire);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_futoFire), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x06004BD3 RID: 19411 RVA: 0x001A5880 File Offset: 0x001A3A80
		// (set) Token: 0x06004BD4 RID: 19412 RVA: 0x000270D6 File Offset: 0x000252D6
		public unsafe GameObject futoExplosion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_futoExplosion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_futoExplosion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x001A58B0 File Offset: 0x001A3AB0
		// (set) Token: 0x06004BD6 RID: 19414 RVA: 0x000270F5 File Offset: 0x000252F5
		public unsafe GameObject burntTray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_burntTray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_burntTray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x001A58E0 File Offset: 0x001A3AE0
		// (set) Token: 0x06004BD8 RID: 19416 RVA: 0x00027114 File Offset: 0x00025314
		public SpellBase.DelayAudioClip boatSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_boatSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_boatSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06004BD9 RID: 19417 RVA: 0x001A5910 File Offset: 0x001A3B10
		// (set) Token: 0x06004BDA RID: 19418 RVA: 0x00027142 File Offset: 0x00025342
		public unsafe AudioClip itemSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_itemSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_itemSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x06004BDB RID: 19419 RVA: 0x001A5940 File Offset: 0x001A3B40
		// (set) Token: 0x06004BDC RID: 19420 RVA: 0x00027161 File Offset: 0x00025361
		public unsafe AudioClip fireSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_fireSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_fireSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x06004BDD RID: 19421 RVA: 0x001A5970 File Offset: 0x001A3B70
		// (set) Token: 0x06004BDE RID: 19422 RVA: 0x00027180 File Offset: 0x00025380
		public unsafe AudioClip plateExplosionSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_plateExplosionSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.NativeFieldInfoPtr_plateExplosionSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040033EB RID: 13291
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x040033EC RID: 13292
		private static readonly IntPtr NativeFieldInfoPtr_launchSpeed;

		// Token: 0x040033ED RID: 13293
		private static readonly IntPtr NativeFieldInfoPtr_launchHeight;

		// Token: 0x040033EE RID: 13294
		private static readonly IntPtr NativeFieldInfoPtr_leaveTrayNum;

		// Token: 0x040033EF RID: 13295
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x040033F0 RID: 13296
		private static readonly IntPtr NativeFieldInfoPtr_plateGameObject;

		// Token: 0x040033F1 RID: 13297
		private static readonly IntPtr NativeFieldInfoPtr_futoShip;

		// Token: 0x040033F2 RID: 13298
		private static readonly IntPtr NativeFieldInfoPtr_futoFire;

		// Token: 0x040033F3 RID: 13299
		private static readonly IntPtr NativeFieldInfoPtr_futoExplosion;

		// Token: 0x040033F4 RID: 13300
		private static readonly IntPtr NativeFieldInfoPtr_burntTray;

		// Token: 0x040033F5 RID: 13301
		private static readonly IntPtr NativeFieldInfoPtr_boatSFX;

		// Token: 0x040033F6 RID: 13302
		private static readonly IntPtr NativeFieldInfoPtr_itemSFX;

		// Token: 0x040033F7 RID: 13303
		private static readonly IntPtr NativeFieldInfoPtr_fireSFX;

		// Token: 0x040033F8 RID: 13304
		private static readonly IntPtr NativeFieldInfoPtr_plateExplosionSFX;

		// Token: 0x040033F9 RID: 13305
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040033FA RID: 13306
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033FB RID: 13307
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033FC RID: 13308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B1B RID: 2843
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Futo+<>c__DisplayClass15_0")]
		public new sealed class __c__DisplayClass15_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D2E4 RID: 53988 RVA: 0x0033A5F4 File Offset: 0x003387F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_0>.NativeClassPtr);
				Spell_Futo.__c__DisplayClass15_0.NativeFieldInfoPtr_trayTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_0>.NativeClassPtr, "trayTransform");
				Spell_Futo.__c__DisplayClass15_0.NativeFieldInfoPtr_burntEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_0>.NativeClassPtr, "burntEffect");
				Spell_Futo.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_0>.NativeClassPtr, 100678550);
				Spell_Futo.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_0>.NativeClassPtr, 100678551);
			}

			// Token: 0x0600D2E5 RID: 53989 RVA: 0x0033A670 File Offset: 0x00338870
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2E6 RID: 53990 RVA: 0x0033A6AC File Offset: 0x003388AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195928, XrefRangeEnd = 195960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass15_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2E7 RID: 53991 RVA: 0x00070F8B File Offset: 0x0006F18B
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A3 RID: 17571
			// (get) Token: 0x0600D2E8 RID: 53992 RVA: 0x0033A6E0 File Offset: 0x003388E0
			// (set) Token: 0x0600D2E9 RID: 53993 RVA: 0x00070F94 File Offset: 0x0006F194
			public unsafe Transform trayTransform
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_0.NativeFieldInfoPtr_trayTransform);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_0.NativeFieldInfoPtr_trayTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044A4 RID: 17572
			// (get) Token: 0x0600D2EA RID: 53994 RVA: 0x0033A710 File Offset: 0x00338910
			// (set) Token: 0x0600D2EB RID: 53995 RVA: 0x00070FB3 File Offset: 0x0006F1B3
			public unsafe List<GameObject> burntEffect
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_0.NativeFieldInfoPtr_burntEffect);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_0.NativeFieldInfoPtr_burntEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400876A RID: 34666
			private static readonly IntPtr NativeFieldInfoPtr_trayTransform;

			// Token: 0x0400876B RID: 34667
			private static readonly IntPtr NativeFieldInfoPtr_burntEffect;

			// Token: 0x0400876C RID: 34668
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400876D RID: 34669
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;
		}

		// Token: 0x02000B1C RID: 2844
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Futo+<>c__DisplayClass15_1")]
		public sealed class __c__DisplayClass15_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D2EC RID: 53996 RVA: 0x0033A740 File Offset: 0x00338940
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_1()
			{
				Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "<>c__DisplayClass15_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_1>.NativeClassPtr);
				Spell_Futo.__c__DisplayClass15_1.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_1>.NativeClassPtr, "i");
				Spell_Futo.__c__DisplayClass15_1.NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Futo.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_1>.NativeClassPtr, 100678552);
				Spell_Futo.__c__DisplayClass15_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_1>.NativeClassPtr, 100678553);
			}

			// Token: 0x0600D2ED RID: 53997 RVA: 0x0033A7BC File Offset: 0x003389BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass15_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2EE RID: 53998 RVA: 0x0033A7F8 File Offset: 0x003389F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195960, XrefRangeEnd = 195965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass15_1.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2EF RID: 53999 RVA: 0x00070FD2 File Offset: 0x0006F1D2
			public __c__DisplayClass15_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A5 RID: 17573
			// (get) Token: 0x0600D2F0 RID: 54000 RVA: 0x0033A83C File Offset: 0x00338A3C
			// (set) Token: 0x0600D2F1 RID: 54001 RVA: 0x00070FDB File Offset: 0x0006F1DB
			public unsafe int i
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_1.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_1.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x170044A6 RID: 17574
			// (get) Token: 0x0600D2F2 RID: 54002 RVA: 0x0033A864 File Offset: 0x00338A64
			// (set) Token: 0x0600D2F3 RID: 54003 RVA: 0x00070FF6 File Offset: 0x0006F1F6
			public unsafe Spell_Futo.__c__DisplayClass15_0 field_Public___c__DisplayClass15_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_1.NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Futo.__c__DisplayClass15_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_1.NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400876E RID: 34670
			private static readonly IntPtr NativeFieldInfoPtr_i;

			// Token: 0x0400876F RID: 34671
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass15_0_0;

			// Token: 0x04008770 RID: 34672
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008771 RID: 34673
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B1D RID: 2845
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Futo+<>c__DisplayClass15_2")]
		public sealed class __c__DisplayClass15_2 : Il2CppSystem.Object
		{
			// Token: 0x0600D2F4 RID: 54004 RVA: 0x0033A894 File Offset: 0x00338A94
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_2()
			{
				Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "<>c__DisplayClass15_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_2>.NativeClassPtr);
				Spell_Futo.__c__DisplayClass15_2.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_2>.NativeClassPtr, "item");
				Spell_Futo.__c__DisplayClass15_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_2>.NativeClassPtr, 100678554);
				Spell_Futo.__c__DisplayClass15_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_2>.NativeClassPtr, 100678555);
			}

			// Token: 0x0600D2F5 RID: 54005 RVA: 0x0033A8FC File Offset: 0x00338AFC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass15_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass15_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2F6 RID: 54006 RVA: 0x0033A938 File Offset: 0x00338B38
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195965, XrefRangeEnd = 195969, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass15_2.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2F7 RID: 54007 RVA: 0x00071015 File Offset: 0x0006F215
			public __c__DisplayClass15_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A7 RID: 17575
			// (get) Token: 0x0600D2F8 RID: 54008 RVA: 0x0033A96C File Offset: 0x00338B6C
			// (set) Token: 0x0600D2F9 RID: 54009 RVA: 0x0007101E File Offset: 0x0006F21E
			public unsafe GameObject item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_2.NativeFieldInfoPtr_item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass15_2.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008772 RID: 34674
			private static readonly IntPtr NativeFieldInfoPtr_item;

			// Token: 0x04008773 RID: 34675
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008774 RID: 34676
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0;
		}

		// Token: 0x02000B1E RID: 2846
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Futo+<OnNegativeBuffExecute>d__15")]
		public sealed class _OnNegativeBuffExecute_d__15 : Il2CppSystem.Object
		{
			// Token: 0x0600D2FA RID: 54010 RVA: 0x0033A99C File Offset: 0x00338B9C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__15()
			{
				Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "<OnNegativeBuffExecute>d__15");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr);
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, "<>1__state");
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, "<>2__current");
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, "<>4__this");
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, "spellExecutionContext");
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, "<>8__1");
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100678556);
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100678557);
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100678558);
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100678559);
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100678560);
				Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr, 100678561);
			}

			// Token: 0x0600D2FB RID: 54011 RVA: 0x0033AAA4 File Offset: 0x00338CA4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__15(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo._OnNegativeBuffExecute_d__15>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2FC RID: 54012 RVA: 0x0033AAEC File Offset: 0x00338CEC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D2FD RID: 54013 RVA: 0x0033AB20 File Offset: 0x00338D20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195969, XrefRangeEnd = 196047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044AD RID: 17581
			// (get) Token: 0x0600D2FE RID: 54014 RVA: 0x0033AB5C File Offset: 0x00338D5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D2FF RID: 54015 RVA: 0x0033AB9C File Offset: 0x00338D9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196047, XrefRangeEnd = 196053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044AE RID: 17582
			// (get) Token: 0x0600D300 RID: 54016 RVA: 0x0033ABD0 File Offset: 0x00338DD0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnNegativeBuffExecute_d__15.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D301 RID: 54017 RVA: 0x0007103D File Offset: 0x0006F23D
			public _OnNegativeBuffExecute_d__15(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044A8 RID: 17576
			// (get) Token: 0x0600D302 RID: 54018 RVA: 0x0033AC10 File Offset: 0x00338E10
			// (set) Token: 0x0600D303 RID: 54019 RVA: 0x00071046 File Offset: 0x0006F246
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044A9 RID: 17577
			// (get) Token: 0x0600D304 RID: 54020 RVA: 0x0033AC38 File Offset: 0x00338E38
			// (set) Token: 0x0600D305 RID: 54021 RVA: 0x00071061 File Offset: 0x0006F261
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044AA RID: 17578
			// (get) Token: 0x0600D306 RID: 54022 RVA: 0x0033AC68 File Offset: 0x00338E68
			// (set) Token: 0x0600D307 RID: 54023 RVA: 0x00071080 File Offset: 0x0006F280
			public unsafe Spell_Futo __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Futo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044AB RID: 17579
			// (get) Token: 0x0600D308 RID: 54024 RVA: 0x0033AC98 File Offset: 0x00338E98
			// (set) Token: 0x0600D309 RID: 54025 RVA: 0x0007109F File Offset: 0x0006F29F
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044AC RID: 17580
			// (get) Token: 0x0600D30A RID: 54026 RVA: 0x0033ACC8 File Offset: 0x00338EC8
			// (set) Token: 0x0600D30B RID: 54027 RVA: 0x000710BE File Offset: 0x0006F2BE
			public unsafe Spell_Futo.__c__DisplayClass15_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Futo.__c__DisplayClass15_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnNegativeBuffExecute_d__15.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008775 RID: 34677
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008776 RID: 34678
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008777 RID: 34679
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008778 RID: 34680
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008779 RID: 34681
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400877A RID: 34682
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400877B RID: 34683
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400877C RID: 34684
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400877D RID: 34685
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400877E RID: 34686
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400877F RID: 34687
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B1F RID: 2847
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Futo+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D30C RID: 54028 RVA: 0x0033ACF8 File Offset: 0x00338EF8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr);
				Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, "spellExecutionContext");
				Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, "<>4__this");
				Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr_shipAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, "shipAnim");
				Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr_ship = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, "ship");
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678562);
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678563);
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678564);
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678565);
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678566);
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678567);
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678568);
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678569);
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678570);
				Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_EvaluationResult_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, 100678571);
			}

			// Token: 0x0600D30D RID: 54029 RVA: 0x0033AE3C File Offset: 0x0033903C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D30E RID: 54030 RVA: 0x0033AE78 File Offset: 0x00339078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196094, XrefRangeEnd = 196098, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D30F RID: 54031 RVA: 0x0033AEB4 File Offset: 0x003390B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196098, XrefRangeEnd = 196099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D310 RID: 54032 RVA: 0x0033AEF0 File Offset: 0x003390F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196099, XrefRangeEnd = 196107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D311 RID: 54033 RVA: 0x0033AF30 File Offset: 0x00339130
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196107, XrefRangeEnd = 196118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__3(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D312 RID: 54034 RVA: 0x0033AF74 File Offset: 0x00339174
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196118, XrefRangeEnd = 196148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D313 RID: 54035 RVA: 0x0033AFA8 File Offset: 0x003391A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196148, XrefRangeEnd = 196159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__7(GuestGroupController x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D314 RID: 54036 RVA: 0x0033AFEC File Offset: 0x003391EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196159, XrefRangeEnd = 196170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_GuestGroupController_PDM_0(GuestGroupController guestGroup)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroup);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D315 RID: 54037 RVA: 0x0033B030 File Offset: 0x00339230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196170, XrefRangeEnd = 196184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GuestGroupController.EvaluationResult Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0(GuestGroupController.EvaluationResult result, GuestGroupController guestGroupController, bool oldComboProtect, out string message, out bool comboProtect)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref result;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref oldComboProtect;
				ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &comboProtect;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				message = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600D316 RID: 54038 RVA: 0x0033B0C4 File Offset: 0x003392C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196184, XrefRangeEnd = 196189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_EvaluationResult_PDM_0(GuestGroupController.EvaluationResult finalResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref finalResult;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_EvaluationResult_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D317 RID: 54039 RVA: 0x000710DD File Offset: 0x0006F2DD
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044AF RID: 17583
			// (get) Token: 0x0600D318 RID: 54040 RVA: 0x0033B110 File Offset: 0x00339310
			// (set) Token: 0x0600D319 RID: 54041 RVA: 0x000710E6 File Offset: 0x0006F2E6
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B0 RID: 17584
			// (get) Token: 0x0600D31A RID: 54042 RVA: 0x0033B140 File Offset: 0x00339340
			// (set) Token: 0x0600D31B RID: 54043 RVA: 0x00071105 File Offset: 0x0006F305
			public unsafe Spell_Futo __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Futo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B1 RID: 17585
			// (get) Token: 0x0600D31C RID: 54044 RVA: 0x0033B170 File Offset: 0x00339370
			// (set) Token: 0x0600D31D RID: 54045 RVA: 0x00071124 File Offset: 0x0006F324
			public unsafe Animator shipAnim
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr_shipAnim);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr_shipAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B2 RID: 17586
			// (get) Token: 0x0600D31E RID: 54046 RVA: 0x0033B1A0 File Offset: 0x003393A0
			// (set) Token: 0x0600D31F RID: 54047 RVA: 0x00071143 File Offset: 0x0006F343
			public unsafe GameObject ship
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr_ship);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.NativeFieldInfoPtr_ship), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008780 RID: 34688
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008781 RID: 34689
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008782 RID: 34690
			private static readonly IntPtr NativeFieldInfoPtr_shipAnim;

			// Token: 0x04008783 RID: 34691
			private static readonly IntPtr NativeFieldInfoPtr_ship;

			// Token: 0x04008784 RID: 34692
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008785 RID: 34693
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Vector3_0;

			// Token: 0x04008786 RID: 34694
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Vector3_0;

			// Token: 0x04008787 RID: 34695
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0;

			// Token: 0x04008788 RID: 34696
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_GuestGroupController_0;

			// Token: 0x04008789 RID: 34697
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x0400878A RID: 34698
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Void_GuestGroupController_0;

			// Token: 0x0400878B RID: 34699
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_GuestGroupController_PDM_0;

			// Token: 0x0400878C RID: 34700
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_EvaluationResult_EvaluationResult_GuestGroupController_Boolean_byref_String_byref_Boolean_PDM_0;

			// Token: 0x0400878D RID: 34701
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_EvaluationResult_PDM_0;

			// Token: 0x02001028 RID: 4136
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Futo+<>c__DisplayClass16_0+<<OnPositiveBuffExecute>g__ThrowPlate|8>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011B28 RID: 72488 RVA: 0x0040E16C File Offset: 0x0040C36C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__ThrowPlate|8>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr);
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr_finalResult = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, "finalResult");
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, "<>8__1");
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr__plate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, "<plate>5__2");
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, 100678572);
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, 100678573);
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, 100678574);
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, 100678575);
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, 100678576);
					Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr, 100678577);
				}

				// Token: 0x06011B29 RID: 72489 RVA: 0x0040E288 File Offset: 0x0040C488
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B2A RID: 72490 RVA: 0x0040E2D0 File Offset: 0x0040C4D0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B2B RID: 72491 RVA: 0x0040E304 File Offset: 0x0040C504
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196053, XrefRangeEnd = 196088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C1E RID: 23582
				// (get) Token: 0x06011B2C RID: 72492 RVA: 0x0040E340 File Offset: 0x0040C540
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B2D RID: 72493 RVA: 0x0040E380 File Offset: 0x0040C580
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196088, XrefRangeEnd = 196094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C1F RID: 23583
				// (get) Token: 0x06011B2E RID: 72494 RVA: 0x0040E3B4 File Offset: 0x0040C5B4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B2F RID: 72495 RVA: 0x00099D90 File Offset: 0x00097F90
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C18 RID: 23576
				// (get) Token: 0x06011B30 RID: 72496 RVA: 0x0040E3F4 File Offset: 0x0040C5F4
				// (set) Token: 0x06011B31 RID: 72497 RVA: 0x00099D99 File Offset: 0x00097F99
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C19 RID: 23577
				// (get) Token: 0x06011B32 RID: 72498 RVA: 0x0040E41C File Offset: 0x0040C61C
				// (set) Token: 0x06011B33 RID: 72499 RVA: 0x00099DB4 File Offset: 0x00097FB4
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C1A RID: 23578
				// (get) Token: 0x06011B34 RID: 72500 RVA: 0x0040E44C File Offset: 0x0040C64C
				// (set) Token: 0x06011B35 RID: 72501 RVA: 0x00099DD3 File Offset: 0x00097FD3
				public unsafe GuestGroupController.EvaluationResult finalResult
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr_finalResult);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr_finalResult)) = value;
					}
				}

				// Token: 0x17005C1B RID: 23579
				// (get) Token: 0x06011B36 RID: 72502 RVA: 0x0040E474 File Offset: 0x0040C674
				// (set) Token: 0x06011B37 RID: 72503 RVA: 0x00099DEE File Offset: 0x00097FEE
				public unsafe Spell_Futo.__c__DisplayClass16_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Futo.__c__DisplayClass16_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C1C RID: 23580
				// (get) Token: 0x06011B38 RID: 72504 RVA: 0x0040E4A4 File Offset: 0x0040C6A4
				// (set) Token: 0x06011B39 RID: 72505 RVA: 0x00099E0D File Offset: 0x0009800D
				public unsafe Spell_Futo.__c__DisplayClass16_2 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Futo.__c__DisplayClass16_2>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C1D RID: 23581
				// (get) Token: 0x06011B3A RID: 72506 RVA: 0x0040E4D4 File Offset: 0x0040C6D4
				// (set) Token: 0x06011B3B RID: 72507 RVA: 0x00099E2C File Offset: 0x0009802C
				public unsafe GameObject _plate_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr__plate_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEvfiGaObObUnique.NativeFieldInfoPtr__plate_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B2E5 RID: 45797
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B2E6 RID: 45798
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B2E7 RID: 45799
				private static readonly IntPtr NativeFieldInfoPtr_finalResult;

				// Token: 0x0400B2E8 RID: 45800
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B2E9 RID: 45801
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B2EA RID: 45802
				private static readonly IntPtr NativeFieldInfoPtr__plate_5__2;

				// Token: 0x0400B2EB RID: 45803
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B2EC RID: 45804
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2ED RID: 45805
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B2EE RID: 45806
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B2EF RID: 45807
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2F0 RID: 45808
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B20 RID: 2848
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Futo+<>c__DisplayClass16_1")]
		public sealed class __c__DisplayClass16_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D320 RID: 54048 RVA: 0x0033B1D0 File Offset: 0x003393D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_1()
			{
				Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "<>c__DisplayClass16_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_1>.NativeClassPtr);
				Spell_Futo.__c__DisplayClass16_1.NativeFieldInfoPtr_level = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_1>.NativeClassPtr, "level");
				Spell_Futo.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_1>.NativeClassPtr, 100678578);
				Spell_Futo.__c__DisplayClass16_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Boolean_Sellable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_1>.NativeClassPtr, 100678579);
			}

			// Token: 0x0600D321 RID: 54049 RVA: 0x0033B238 File Offset: 0x00339438
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D322 RID: 54050 RVA: 0x0033B274 File Offset: 0x00339474
			[CallerCount(0)]
			public unsafe bool _OnPositiveBuffExecute_b__9(Sellable x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Boolean_Sellable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D323 RID: 54051 RVA: 0x00071162 File Offset: 0x0006F362
			public __c__DisplayClass16_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B3 RID: 17587
			// (get) Token: 0x0600D324 RID: 54052 RVA: 0x0033B2C4 File Offset: 0x003394C4
			// (set) Token: 0x0600D325 RID: 54053 RVA: 0x0007116B File Offset: 0x0006F36B
			public unsafe int level
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_1.NativeFieldInfoPtr_level);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_1.NativeFieldInfoPtr_level)) = value;
				}
			}

			// Token: 0x0400878E RID: 34702
			private static readonly IntPtr NativeFieldInfoPtr_level;

			// Token: 0x0400878F RID: 34703
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008790 RID: 34704
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__9_Internal_Boolean_Sellable_0;
		}

		// Token: 0x02000B21 RID: 2849
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Futo+<>c__DisplayClass16_2")]
		public sealed class __c__DisplayClass16_2 : Il2CppSystem.Object
		{
			// Token: 0x0600D326 RID: 54054 RVA: 0x0033B2EC File Offset: 0x003394EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_2()
			{
				Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "<>c__DisplayClass16_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_2>.NativeClassPtr);
				Spell_Futo.__c__DisplayClass16_2.NativeFieldInfoPtr_bev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_2>.NativeClassPtr, "bev");
				Spell_Futo.__c__DisplayClass16_2.NativeFieldInfoPtr_beverageStorageUiPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_2>.NativeClassPtr, "beverageStorageUiPosition");
				Spell_Futo.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_2>.NativeClassPtr, 100678580);
				Spell_Futo.__c__DisplayClass16_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_2>.NativeClassPtr, 100678581);
				Spell_Futo.__c__DisplayClass16_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_2>.NativeClassPtr, 100678582);
			}

			// Token: 0x0600D327 RID: 54055 RVA: 0x0033B37C File Offset: 0x0033957C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo.__c__DisplayClass16_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D328 RID: 54056 RVA: 0x0033B3B8 File Offset: 0x003395B8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D329 RID: 54057 RVA: 0x0033B3FC File Offset: 0x003395FC
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__11()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo.__c__DisplayClass16_2.NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D32A RID: 54058 RVA: 0x00071186 File Offset: 0x0006F386
			public __c__DisplayClass16_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B4 RID: 17588
			// (get) Token: 0x0600D32B RID: 54059 RVA: 0x0033B438 File Offset: 0x00339638
			// (set) Token: 0x0600D32C RID: 54060 RVA: 0x0007118F File Offset: 0x0006F38F
			public unsafe Sellable bev
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_2.NativeFieldInfoPtr_bev);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sellable>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_2.NativeFieldInfoPtr_bev), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B5 RID: 17589
			// (get) Token: 0x0600D32D RID: 54061 RVA: 0x0033B468 File Offset: 0x00339668
			// (set) Token: 0x0600D32E RID: 54062 RVA: 0x000711AE File Offset: 0x0006F3AE
			public unsafe Vector3 beverageStorageUiPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_2.NativeFieldInfoPtr_beverageStorageUiPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo.__c__DisplayClass16_2.NativeFieldInfoPtr_beverageStorageUiPosition)) = value;
				}
			}

			// Token: 0x04008791 RID: 34705
			private static readonly IntPtr NativeFieldInfoPtr_bev;

			// Token: 0x04008792 RID: 34706
			private static readonly IntPtr NativeFieldInfoPtr_beverageStorageUiPosition;

			// Token: 0x04008793 RID: 34707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008794 RID: 34708
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__10_Internal_Void_Image_0;

			// Token: 0x04008795 RID: 34709
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__11_Internal_Vector3_0;
		}

		// Token: 0x02000B22 RID: 2850
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Futo+<OnPositiveBuffExecute>d__16")]
		public sealed class _OnPositiveBuffExecute_d__16 : Il2CppSystem.Object
		{
			// Token: 0x0600D32F RID: 54063 RVA: 0x0033B490 File Offset: 0x00339690
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__16()
			{
				Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Futo>.NativeClassPtr, "<OnPositiveBuffExecute>d__16");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr);
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>1__state");
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>2__current");
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, "spellExecutionContext");
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>4__this");
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, "<>8__1");
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100678583);
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100678584);
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100678585);
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100678586);
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100678587);
				Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr, 100678588);
			}

			// Token: 0x0600D330 RID: 54064 RVA: 0x0033B598 File Offset: 0x00339798
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__16(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Futo._OnPositiveBuffExecute_d__16>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D331 RID: 54065 RVA: 0x0033B5E0 File Offset: 0x003397E0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D332 RID: 54066 RVA: 0x0033B614 File Offset: 0x00339814
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196189, XrefRangeEnd = 196231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170044BB RID: 17595
			// (get) Token: 0x0600D333 RID: 54067 RVA: 0x0033B650 File Offset: 0x00339850
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D334 RID: 54068 RVA: 0x0033B690 File Offset: 0x00339890
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196231, XrefRangeEnd = 196237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170044BC RID: 17596
			// (get) Token: 0x0600D335 RID: 54069 RVA: 0x0033B6C4 File Offset: 0x003398C4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Futo._OnPositiveBuffExecute_d__16.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D336 RID: 54070 RVA: 0x000711C9 File Offset: 0x0006F3C9
			public _OnPositiveBuffExecute_d__16(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044B6 RID: 17590
			// (get) Token: 0x0600D337 RID: 54071 RVA: 0x0033B704 File Offset: 0x00339904
			// (set) Token: 0x0600D338 RID: 54072 RVA: 0x000711D2 File Offset: 0x0006F3D2
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044B7 RID: 17591
			// (get) Token: 0x0600D339 RID: 54073 RVA: 0x0033B72C File Offset: 0x0033992C
			// (set) Token: 0x0600D33A RID: 54074 RVA: 0x000711ED File Offset: 0x0006F3ED
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B8 RID: 17592
			// (get) Token: 0x0600D33B RID: 54075 RVA: 0x0033B75C File Offset: 0x0033995C
			// (set) Token: 0x0600D33C RID: 54076 RVA: 0x0007120C File Offset: 0x0006F40C
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044B9 RID: 17593
			// (get) Token: 0x0600D33D RID: 54077 RVA: 0x0033B78C File Offset: 0x0033998C
			// (set) Token: 0x0600D33E RID: 54078 RVA: 0x0007122B File Offset: 0x0006F42B
			public unsafe Spell_Futo __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Futo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044BA RID: 17594
			// (get) Token: 0x0600D33F RID: 54079 RVA: 0x0033B7BC File Offset: 0x003399BC
			// (set) Token: 0x0600D340 RID: 54080 RVA: 0x0007124A File Offset: 0x0006F44A
			public unsafe Spell_Futo.__c__DisplayClass16_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Futo.__c__DisplayClass16_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Futo._OnPositiveBuffExecute_d__16.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008796 RID: 34710
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008797 RID: 34711
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008798 RID: 34712
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008799 RID: 34713
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400879A RID: 34714
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400879B RID: 34715
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400879C RID: 34716
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400879D RID: 34717
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400879E RID: 34718
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400879F RID: 34719
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040087A0 RID: 34720
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
