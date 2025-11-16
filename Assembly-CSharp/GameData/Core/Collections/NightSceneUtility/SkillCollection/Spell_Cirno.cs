using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000261 RID: 609
	public class Spell_Cirno : SpellBase
	{
		// Token: 0x06004B44 RID: 19268 RVA: 0x001A416C File Offset: 0x001A236C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Cirno()
		{
			Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Cirno");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr);
			Spell_Cirno.NativeFieldInfoPtr_giveIceNumMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "giveIceNumMin");
			Spell_Cirno.NativeFieldInfoPtr_giveIceNumMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "giveIceNumMax");
			Spell_Cirno.NativeFieldInfoPtr_giveBevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "giveBevNum");
			Spell_Cirno.NativeFieldInfoPtr_iceItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceItemId");
			Spell_Cirno.NativeFieldInfoPtr_iceAvailableBevTagId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceAvailableBevTagId");
			Spell_Cirno.NativeFieldInfoPtr_bevMaxPrice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "bevMaxPrice");
			Spell_Cirno.NativeFieldInfoPtr_lockCookerNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "lockCookerNum");
			Spell_Cirno.NativeFieldInfoPtr_lockCookerDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "lockCookerDuration");
			Spell_Cirno.NativeFieldInfoPtr_giveIceItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "giveIceItem");
			Spell_Cirno.NativeFieldInfoPtr_iceInAirSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceInAirSFX");
			Spell_Cirno.NativeFieldInfoPtr_itemGetSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "itemGetSFX");
			Spell_Cirno.NativeFieldInfoPtr_intervalGameObjectTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "intervalGameObjectTime");
			Spell_Cirno.NativeFieldInfoPtr_iceFlyingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceFlyingTime");
			Spell_Cirno.NativeFieldInfoPtr_waitIceMeltingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "waitIceMeltingTime");
			Spell_Cirno.NativeFieldInfoPtr_itemMinDashDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "itemMinDashDistance");
			Spell_Cirno.NativeFieldInfoPtr_itemMaxDashDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "itemMaxDashDistance");
			Spell_Cirno.NativeFieldInfoPtr_itemControlPoint1AngularOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "itemControlPoint1AngularOffset");
			Spell_Cirno.NativeFieldInfoPtr_itemControlPoint2AngularOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "itemControlPoint2AngularOffset");
			Spell_Cirno.NativeFieldInfoPtr_iceInAirDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceInAirDuration");
			Spell_Cirno.NativeFieldInfoPtr_iceInAirEndOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceInAirEndOffset");
			Spell_Cirno.NativeFieldInfoPtr_endIceEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "endIceEffect");
			Spell_Cirno.NativeFieldInfoPtr_endIceDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "endIceDuration");
			Spell_Cirno.NativeFieldInfoPtr_perfectFreezeEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "perfectFreezeEffect");
			Spell_Cirno.NativeFieldInfoPtr_iceFieldSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceFieldSFX");
			Spell_Cirno.NativeFieldInfoPtr_negativeEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "negativeEffectDuration");
			Spell_Cirno.NativeFieldInfoPtr_iceGenerateSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceGenerateSFX");
			Spell_Cirno.NativeFieldInfoPtr_iceFogEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceFogEffect");
			Spell_Cirno.NativeFieldInfoPtr_iceFogOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceFogOffset");
			Spell_Cirno.NativeFieldInfoPtr_iceMeltTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "iceMeltTime");
			Spell_Cirno.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, 100678441);
			Spell_Cirno.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, 100678442);
			Spell_Cirno.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, 100678443);
			Spell_Cirno.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, 100678444);
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x001A4430 File Offset: 0x001A2630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195651, XrefRangeEnd = 195653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Cirno.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x001A4474 File Offset: 0x001A2674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195653, XrefRangeEnd = 195659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Cirno.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x001A44D0 File Offset: 0x001A26D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195659, XrefRangeEnd = 195665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Cirno.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x001A452C File Offset: 0x001A272C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Cirno() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x00026A23 File Offset: 0x00024C23
		public Spell_Cirno(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001946 RID: 6470
		// (get) Token: 0x06004B4A RID: 19274 RVA: 0x001A4568 File Offset: 0x001A2768
		// (set) Token: 0x06004B4B RID: 19275 RVA: 0x00026A2C File Offset: 0x00024C2C
		public unsafe int giveIceNumMin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_giveIceNumMin);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_giveIceNumMin)) = value;
			}
		}

		// Token: 0x17001947 RID: 6471
		// (get) Token: 0x06004B4C RID: 19276 RVA: 0x001A4590 File Offset: 0x001A2790
		// (set) Token: 0x06004B4D RID: 19277 RVA: 0x00026A47 File Offset: 0x00024C47
		public unsafe int giveIceNumMax
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_giveIceNumMax);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_giveIceNumMax)) = value;
			}
		}

		// Token: 0x17001948 RID: 6472
		// (get) Token: 0x06004B4E RID: 19278 RVA: 0x001A45B8 File Offset: 0x001A27B8
		// (set) Token: 0x06004B4F RID: 19279 RVA: 0x00026A62 File Offset: 0x00024C62
		public unsafe int giveBevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_giveBevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_giveBevNum)) = value;
			}
		}

		// Token: 0x17001949 RID: 6473
		// (get) Token: 0x06004B50 RID: 19280 RVA: 0x001A45E0 File Offset: 0x001A27E0
		// (set) Token: 0x06004B51 RID: 19281 RVA: 0x00026A7D File Offset: 0x00024C7D
		public unsafe int iceItemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceItemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceItemId)) = value;
			}
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x06004B52 RID: 19282 RVA: 0x001A4608 File Offset: 0x001A2808
		// (set) Token: 0x06004B53 RID: 19283 RVA: 0x00026A98 File Offset: 0x00024C98
		public unsafe int iceAvailableBevTagId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceAvailableBevTagId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceAvailableBevTagId)) = value;
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x06004B54 RID: 19284 RVA: 0x001A4630 File Offset: 0x001A2830
		// (set) Token: 0x06004B55 RID: 19285 RVA: 0x00026AB3 File Offset: 0x00024CB3
		public unsafe int bevMaxPrice
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_bevMaxPrice);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_bevMaxPrice)) = value;
			}
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x06004B56 RID: 19286 RVA: 0x001A4658 File Offset: 0x001A2858
		// (set) Token: 0x06004B57 RID: 19287 RVA: 0x00026ACE File Offset: 0x00024CCE
		public unsafe int lockCookerNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_lockCookerNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_lockCookerNum)) = value;
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x06004B58 RID: 19288 RVA: 0x001A4680 File Offset: 0x001A2880
		// (set) Token: 0x06004B59 RID: 19289 RVA: 0x00026AE9 File Offset: 0x00024CE9
		public unsafe int lockCookerDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_lockCookerDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_lockCookerDuration)) = value;
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x06004B5A RID: 19290 RVA: 0x001A46A8 File Offset: 0x001A28A8
		// (set) Token: 0x06004B5B RID: 19291 RVA: 0x00026B04 File Offset: 0x00024D04
		public unsafe GameObject giveIceItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_giveIceItem);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_giveIceItem), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x06004B5C RID: 19292 RVA: 0x001A46D8 File Offset: 0x001A28D8
		// (set) Token: 0x06004B5D RID: 19293 RVA: 0x00026B23 File Offset: 0x00024D23
		public unsafe AudioClip iceInAirSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceInAirSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceInAirSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x06004B5E RID: 19294 RVA: 0x001A4708 File Offset: 0x001A2908
		// (set) Token: 0x06004B5F RID: 19295 RVA: 0x00026B42 File Offset: 0x00024D42
		public unsafe AudioClip itemGetSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemGetSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemGetSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001951 RID: 6481
		// (get) Token: 0x06004B60 RID: 19296 RVA: 0x001A4738 File Offset: 0x001A2938
		// (set) Token: 0x06004B61 RID: 19297 RVA: 0x00026B61 File Offset: 0x00024D61
		public unsafe float intervalGameObjectTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_intervalGameObjectTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_intervalGameObjectTime)) = value;
			}
		}

		// Token: 0x17001952 RID: 6482
		// (get) Token: 0x06004B62 RID: 19298 RVA: 0x001A4760 File Offset: 0x001A2960
		// (set) Token: 0x06004B63 RID: 19299 RVA: 0x00026B7C File Offset: 0x00024D7C
		public unsafe float iceFlyingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceFlyingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceFlyingTime)) = value;
			}
		}

		// Token: 0x17001953 RID: 6483
		// (get) Token: 0x06004B64 RID: 19300 RVA: 0x001A4788 File Offset: 0x001A2988
		// (set) Token: 0x06004B65 RID: 19301 RVA: 0x00026B97 File Offset: 0x00024D97
		public unsafe float waitIceMeltingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_waitIceMeltingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_waitIceMeltingTime)) = value;
			}
		}

		// Token: 0x17001954 RID: 6484
		// (get) Token: 0x06004B66 RID: 19302 RVA: 0x001A47B0 File Offset: 0x001A29B0
		// (set) Token: 0x06004B67 RID: 19303 RVA: 0x00026BB2 File Offset: 0x00024DB2
		public unsafe float itemMinDashDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemMinDashDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemMinDashDistance)) = value;
			}
		}

		// Token: 0x17001955 RID: 6485
		// (get) Token: 0x06004B68 RID: 19304 RVA: 0x001A47D8 File Offset: 0x001A29D8
		// (set) Token: 0x06004B69 RID: 19305 RVA: 0x00026BCD File Offset: 0x00024DCD
		public unsafe float itemMaxDashDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemMaxDashDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemMaxDashDistance)) = value;
			}
		}

		// Token: 0x17001956 RID: 6486
		// (get) Token: 0x06004B6A RID: 19306 RVA: 0x001A4800 File Offset: 0x001A2A00
		// (set) Token: 0x06004B6B RID: 19307 RVA: 0x00026BE8 File Offset: 0x00024DE8
		public unsafe float itemControlPoint1AngularOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemControlPoint1AngularOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemControlPoint1AngularOffset)) = value;
			}
		}

		// Token: 0x17001957 RID: 6487
		// (get) Token: 0x06004B6C RID: 19308 RVA: 0x001A4828 File Offset: 0x001A2A28
		// (set) Token: 0x06004B6D RID: 19309 RVA: 0x00026C03 File Offset: 0x00024E03
		public unsafe float itemControlPoint2AngularOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemControlPoint2AngularOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_itemControlPoint2AngularOffset)) = value;
			}
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06004B6E RID: 19310 RVA: 0x001A4850 File Offset: 0x001A2A50
		// (set) Token: 0x06004B6F RID: 19311 RVA: 0x00026C1E File Offset: 0x00024E1E
		public unsafe float iceInAirDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceInAirDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceInAirDuration)) = value;
			}
		}

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06004B70 RID: 19312 RVA: 0x001A4878 File Offset: 0x001A2A78
		// (set) Token: 0x06004B71 RID: 19313 RVA: 0x00026C39 File Offset: 0x00024E39
		public unsafe float iceInAirEndOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceInAirEndOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceInAirEndOffset)) = value;
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06004B72 RID: 19314 RVA: 0x001A48A0 File Offset: 0x001A2AA0
		// (set) Token: 0x06004B73 RID: 19315 RVA: 0x00026C54 File Offset: 0x00024E54
		public unsafe GameObject endIceEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_endIceEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_endIceEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195B RID: 6491
		// (get) Token: 0x06004B74 RID: 19316 RVA: 0x001A48D0 File Offset: 0x001A2AD0
		// (set) Token: 0x06004B75 RID: 19317 RVA: 0x00026C73 File Offset: 0x00024E73
		public unsafe float endIceDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_endIceDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_endIceDuration)) = value;
			}
		}

		// Token: 0x1700195C RID: 6492
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x001A48F8 File Offset: 0x001A2AF8
		// (set) Token: 0x06004B77 RID: 19319 RVA: 0x00026C8E File Offset: 0x00024E8E
		public unsafe GameObject perfectFreezeEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_perfectFreezeEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_perfectFreezeEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195D RID: 6493
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x001A4928 File Offset: 0x001A2B28
		// (set) Token: 0x06004B79 RID: 19321 RVA: 0x00026CAD File Offset: 0x00024EAD
		public unsafe AudioClip iceFieldSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceFieldSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceFieldSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700195E RID: 6494
		// (get) Token: 0x06004B7A RID: 19322 RVA: 0x001A4958 File Offset: 0x001A2B58
		// (set) Token: 0x06004B7B RID: 19323 RVA: 0x00026CCC File Offset: 0x00024ECC
		public unsafe float negativeEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_negativeEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_negativeEffectDuration)) = value;
			}
		}

		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x06004B7C RID: 19324 RVA: 0x001A4980 File Offset: 0x001A2B80
		// (set) Token: 0x06004B7D RID: 19325 RVA: 0x00026CE7 File Offset: 0x00024EE7
		public unsafe AudioClip iceGenerateSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceGenerateSFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceGenerateSFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x001A49B0 File Offset: 0x001A2BB0
		// (set) Token: 0x06004B7F RID: 19327 RVA: 0x00026D06 File Offset: 0x00024F06
		public unsafe GameObject iceFogEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceFogEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceFogEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x06004B80 RID: 19328 RVA: 0x001A49E0 File Offset: 0x001A2BE0
		// (set) Token: 0x06004B81 RID: 19329 RVA: 0x00026D25 File Offset: 0x00024F25
		public unsafe float iceFogOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceFogOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceFogOffset)) = value;
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x06004B82 RID: 19330 RVA: 0x001A4A08 File Offset: 0x001A2C08
		// (set) Token: 0x06004B83 RID: 19331 RVA: 0x00026D40 File Offset: 0x00024F40
		public unsafe float iceMeltTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceMeltTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.NativeFieldInfoPtr_iceMeltTime)) = value;
			}
		}

		// Token: 0x040033A9 RID: 13225
		private static readonly IntPtr NativeFieldInfoPtr_giveIceNumMin;

		// Token: 0x040033AA RID: 13226
		private static readonly IntPtr NativeFieldInfoPtr_giveIceNumMax;

		// Token: 0x040033AB RID: 13227
		private static readonly IntPtr NativeFieldInfoPtr_giveBevNum;

		// Token: 0x040033AC RID: 13228
		private static readonly IntPtr NativeFieldInfoPtr_iceItemId;

		// Token: 0x040033AD RID: 13229
		private static readonly IntPtr NativeFieldInfoPtr_iceAvailableBevTagId;

		// Token: 0x040033AE RID: 13230
		private static readonly IntPtr NativeFieldInfoPtr_bevMaxPrice;

		// Token: 0x040033AF RID: 13231
		private static readonly IntPtr NativeFieldInfoPtr_lockCookerNum;

		// Token: 0x040033B0 RID: 13232
		private static readonly IntPtr NativeFieldInfoPtr_lockCookerDuration;

		// Token: 0x040033B1 RID: 13233
		private static readonly IntPtr NativeFieldInfoPtr_giveIceItem;

		// Token: 0x040033B2 RID: 13234
		private static readonly IntPtr NativeFieldInfoPtr_iceInAirSFX;

		// Token: 0x040033B3 RID: 13235
		private static readonly IntPtr NativeFieldInfoPtr_itemGetSFX;

		// Token: 0x040033B4 RID: 13236
		private static readonly IntPtr NativeFieldInfoPtr_intervalGameObjectTime;

		// Token: 0x040033B5 RID: 13237
		private static readonly IntPtr NativeFieldInfoPtr_iceFlyingTime;

		// Token: 0x040033B6 RID: 13238
		private static readonly IntPtr NativeFieldInfoPtr_waitIceMeltingTime;

		// Token: 0x040033B7 RID: 13239
		private static readonly IntPtr NativeFieldInfoPtr_itemMinDashDistance;

		// Token: 0x040033B8 RID: 13240
		private static readonly IntPtr NativeFieldInfoPtr_itemMaxDashDistance;

		// Token: 0x040033B9 RID: 13241
		private static readonly IntPtr NativeFieldInfoPtr_itemControlPoint1AngularOffset;

		// Token: 0x040033BA RID: 13242
		private static readonly IntPtr NativeFieldInfoPtr_itemControlPoint2AngularOffset;

		// Token: 0x040033BB RID: 13243
		private static readonly IntPtr NativeFieldInfoPtr_iceInAirDuration;

		// Token: 0x040033BC RID: 13244
		private static readonly IntPtr NativeFieldInfoPtr_iceInAirEndOffset;

		// Token: 0x040033BD RID: 13245
		private static readonly IntPtr NativeFieldInfoPtr_endIceEffect;

		// Token: 0x040033BE RID: 13246
		private static readonly IntPtr NativeFieldInfoPtr_endIceDuration;

		// Token: 0x040033BF RID: 13247
		private static readonly IntPtr NativeFieldInfoPtr_perfectFreezeEffect;

		// Token: 0x040033C0 RID: 13248
		private static readonly IntPtr NativeFieldInfoPtr_iceFieldSFX;

		// Token: 0x040033C1 RID: 13249
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectDuration;

		// Token: 0x040033C2 RID: 13250
		private static readonly IntPtr NativeFieldInfoPtr_iceGenerateSFX;

		// Token: 0x040033C3 RID: 13251
		private static readonly IntPtr NativeFieldInfoPtr_iceFogEffect;

		// Token: 0x040033C4 RID: 13252
		private static readonly IntPtr NativeFieldInfoPtr_iceFogOffset;

		// Token: 0x040033C5 RID: 13253
		private static readonly IntPtr NativeFieldInfoPtr_iceMeltTime;

		// Token: 0x040033C6 RID: 13254
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040033C7 RID: 13255
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033C8 RID: 13256
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040033C9 RID: 13257
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B0F RID: 2831
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Cirno+<>c__DisplayClass30_0")]
		public sealed class __c__DisplayClass30_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D234 RID: 53812 RVA: 0x00338510 File Offset: 0x00336710
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass30_0()
			{
				Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "<>c__DisplayClass30_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0>.NativeClassPtr);
				Spell_Cirno.__c__DisplayClass30_0.NativeFieldInfoPtr_effectQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0>.NativeClassPtr, "effectQueue");
				Spell_Cirno.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0>.NativeClassPtr, "<>4__this");
				Spell_Cirno.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0>.NativeClassPtr, 100678445);
				Spell_Cirno.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0>.NativeClassPtr, 100678446);
				Spell_Cirno.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0>.NativeClassPtr, 100678447);
			}

			// Token: 0x0600D235 RID: 53813 RVA: 0x003385A0 File Offset: 0x003367A0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass30_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass30_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D236 RID: 53814 RVA: 0x003385DC File Offset: 0x003367DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195316, XrefRangeEnd = 195323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D237 RID: 53815 RVA: 0x00338610 File Offset: 0x00336810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195323, XrefRangeEnd = 195328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass30_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D238 RID: 53816 RVA: 0x000709B2 File Offset: 0x0006EBB2
			public __c__DisplayClass30_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004468 RID: 17512
			// (get) Token: 0x0600D239 RID: 53817 RVA: 0x00338650 File Offset: 0x00336850
			// (set) Token: 0x0600D23A RID: 53818 RVA: 0x000709BB File Offset: 0x0006EBBB
			public unsafe Queue<ParticleSystem> effectQueue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.NativeFieldInfoPtr_effectQueue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<ParticleSystem>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.NativeFieldInfoPtr_effectQueue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004469 RID: 17513
			// (get) Token: 0x0600D23B RID: 53819 RVA: 0x00338680 File Offset: 0x00336880
			// (set) Token: 0x0600D23C RID: 53820 RVA: 0x000709DA File Offset: 0x0006EBDA
			public unsafe Spell_Cirno __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Cirno>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008701 RID: 34561
			private static readonly IntPtr NativeFieldInfoPtr_effectQueue;

			// Token: 0x04008702 RID: 34562
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008703 RID: 34563
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008704 RID: 34564
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x04008705 RID: 34565
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02001023 RID: 4131
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Cirno+<>c__DisplayClass30_0+<<OnNegativeBuffExecute>g__Del|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011ACA RID: 72394 RVA: 0x0040D048 File Offset: 0x0040B248
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Del|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678448);
					Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678449);
					Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678450);
					Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678451);
					Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678452);
					Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100678453);
				}

				// Token: 0x06011ACB RID: 72395 RVA: 0x0040D128 File Offset: 0x0040B328
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011ACC RID: 72396 RVA: 0x0040D170 File Offset: 0x0040B370
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011ACD RID: 72397 RVA: 0x0040D1A4 File Offset: 0x0040B3A4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195267, XrefRangeEnd = 195310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BF6 RID: 23542
				// (get) Token: 0x06011ACE RID: 72398 RVA: 0x0040D1E0 File Offset: 0x0040B3E0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011ACF RID: 72399 RVA: 0x0040D220 File Offset: 0x0040B420
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195310, XrefRangeEnd = 195316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BF7 RID: 23543
				// (get) Token: 0x06011AD0 RID: 72400 RVA: 0x0040D254 File Offset: 0x0040B454
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011AD1 RID: 72401 RVA: 0x00099A3B File Offset: 0x00097C3B
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BF3 RID: 23539
				// (get) Token: 0x06011AD2 RID: 72402 RVA: 0x0040D294 File Offset: 0x0040B494
				// (set) Token: 0x06011AD3 RID: 72403 RVA: 0x00099A44 File Offset: 0x00097C44
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BF4 RID: 23540
				// (get) Token: 0x06011AD4 RID: 72404 RVA: 0x0040D2BC File Offset: 0x0040B4BC
				// (set) Token: 0x06011AD5 RID: 72405 RVA: 0x00099A5F File Offset: 0x00097C5F
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BF5 RID: 23541
				// (get) Token: 0x06011AD6 RID: 72406 RVA: 0x0040D2EC File Offset: 0x0040B4EC
				// (set) Token: 0x06011AD7 RID: 72407 RVA: 0x00099A7E File Offset: 0x00097C7E
				public unsafe Spell_Cirno.__c__DisplayClass30_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Cirno.__c__DisplayClass30_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass30_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B2AC RID: 45740
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B2AD RID: 45741
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B2AE RID: 45742
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B2AF RID: 45743
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B2B0 RID: 45744
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2B1 RID: 45745
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B2B2 RID: 45746
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B2B3 RID: 45747
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2B4 RID: 45748
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B10 RID: 2832
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Cirno+<OnNegativeBuffExecute>d__30")]
		public sealed class _OnNegativeBuffExecute_d__30 : Il2CppSystem.Object
		{
			// Token: 0x0600D23D RID: 53821 RVA: 0x003386B0 File Offset: 0x003368B0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__30()
			{
				Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "<OnNegativeBuffExecute>d__30");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr);
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<>1__state");
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<>2__current");
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<>4__this");
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, "spellExecutionContext");
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, "<>8__1");
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678454);
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678455);
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678456);
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678457);
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678458);
				Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr, 100678459);
			}

			// Token: 0x0600D23E RID: 53822 RVA: 0x003387B8 File Offset: 0x003369B8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__30(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno._OnNegativeBuffExecute_d__30>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D23F RID: 53823 RVA: 0x00338800 File Offset: 0x00336A00
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D240 RID: 53824 RVA: 0x00338834 File Offset: 0x00336A34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195328, XrefRangeEnd = 195383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700446F RID: 17519
			// (get) Token: 0x0600D241 RID: 53825 RVA: 0x00338870 File Offset: 0x00336A70
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D242 RID: 53826 RVA: 0x003388B0 File Offset: 0x00336AB0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195383, XrefRangeEnd = 195389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004470 RID: 17520
			// (get) Token: 0x0600D243 RID: 53827 RVA: 0x003388E4 File Offset: 0x00336AE4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D244 RID: 53828 RVA: 0x000709F9 File Offset: 0x0006EBF9
			public _OnNegativeBuffExecute_d__30(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700446A RID: 17514
			// (get) Token: 0x0600D245 RID: 53829 RVA: 0x00338924 File Offset: 0x00336B24
			// (set) Token: 0x0600D246 RID: 53830 RVA: 0x00070A02 File Offset: 0x0006EC02
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700446B RID: 17515
			// (get) Token: 0x0600D247 RID: 53831 RVA: 0x0033894C File Offset: 0x00336B4C
			// (set) Token: 0x0600D248 RID: 53832 RVA: 0x00070A1D File Offset: 0x0006EC1D
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700446C RID: 17516
			// (get) Token: 0x0600D249 RID: 53833 RVA: 0x0033897C File Offset: 0x00336B7C
			// (set) Token: 0x0600D24A RID: 53834 RVA: 0x00070A3C File Offset: 0x0006EC3C
			public unsafe Spell_Cirno __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Cirno>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700446D RID: 17517
			// (get) Token: 0x0600D24B RID: 53835 RVA: 0x003389AC File Offset: 0x00336BAC
			// (set) Token: 0x0600D24C RID: 53836 RVA: 0x00070A5B File Offset: 0x0006EC5B
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700446E RID: 17518
			// (get) Token: 0x0600D24D RID: 53837 RVA: 0x003389DC File Offset: 0x00336BDC
			// (set) Token: 0x0600D24E RID: 53838 RVA: 0x00070A7A File Offset: 0x0006EC7A
			public unsafe Spell_Cirno.__c__DisplayClass30_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Cirno.__c__DisplayClass30_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnNegativeBuffExecute_d__30.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008706 RID: 34566
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008707 RID: 34567
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008708 RID: 34568
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008709 RID: 34569
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400870A RID: 34570
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400870B RID: 34571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400870C RID: 34572
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400870D RID: 34573
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400870E RID: 34574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400870F RID: 34575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008710 RID: 34576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B11 RID: 2833
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Cirno+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D24F RID: 53839 RVA: 0x00338A0C File Offset: 0x00336C0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr);
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_characterPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "characterPosition");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_bevSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "bevSelections");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_bevStartAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "bevStartAngle");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_waitForSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "waitForSpawn");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_iceSelections = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "iceSelections");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_iceStartAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "iceStartAngle");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_giveIceNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "giveIceNum");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_hasAnyItemGetSFXPlayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "hasAnyItemGetSFXPlayed");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "<>9__3");
				Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr___9__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "<>9__4");
				Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, 100678460);
				Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, 100678461);
				Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, 100678462);
				Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, 100678463);
				Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, 100678464);
				Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_SelectedValue_Single_Action_1_Single_Int32_Vector3_Vector3_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, 100678465);
			}

			// Token: 0x0600D250 RID: 53840 RVA: 0x00338B8C File Offset: 0x00336D8C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D251 RID: 53841 RVA: 0x00338BC8 File Offset: 0x00336DC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195560, XrefRangeEnd = 195565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D252 RID: 53842 RVA: 0x00338C08 File Offset: 0x00336E08
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 195565, RefRangeEnd = 195568, XrefRangeStart = 195565, XrefRangeEnd = 195565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__3(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D253 RID: 53843 RVA: 0x00338C48 File Offset: 0x00336E48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195568, XrefRangeEnd = 195573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D254 RID: 53844 RVA: 0x00338C88 File Offset: 0x00336E88
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 195573, RefRangeEnd = 195574, XrefRangeStart = 195573, XrefRangeEnd = 195573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__4(float x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D255 RID: 53845 RVA: 0x00338CC8 File Offset: 0x00336EC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195574, XrefRangeEnd = 195582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_Transform_SelectedValue_Single_Action_1_Single_Int32_Vector3_Vector3_PDM_0(Transform itemTransform, EventManager.SelectedValue giveData, float startAngle, Action<float> setStartAngleCallback, int giveNum, Vector3 targetStoragePosition, Vector3 targetStorageUiPosition)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemTransform);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(giveData));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startAngle;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(setStartAngleCallback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref giveNum;
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetStoragePosition;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref targetStorageUiPosition;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_SelectedValue_Single_Action_1_Single_Int32_Vector3_Vector3_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D256 RID: 53846 RVA: 0x00070A99 File Offset: 0x0006EC99
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004471 RID: 17521
			// (get) Token: 0x0600D257 RID: 53847 RVA: 0x00338D7C File Offset: 0x00336F7C
			// (set) Token: 0x0600D258 RID: 53848 RVA: 0x00070AA2 File Offset: 0x0006ECA2
			public unsafe Spell_Cirno __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Cirno>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004472 RID: 17522
			// (get) Token: 0x0600D259 RID: 53849 RVA: 0x00338DAC File Offset: 0x00336FAC
			// (set) Token: 0x0600D25A RID: 53850 RVA: 0x00070AC1 File Offset: 0x0006ECC1
			public unsafe Vector3 characterPosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_characterPosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_characterPosition)) = value;
				}
			}

			// Token: 0x17004473 RID: 17523
			// (get) Token: 0x0600D25B RID: 53851 RVA: 0x00338DD4 File Offset: 0x00336FD4
			// (set) Token: 0x0600D25C RID: 53852 RVA: 0x00070ADC File Offset: 0x0006ECDC
			public unsafe List<EventManager.SelectedValue> bevSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_bevSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventManager.SelectedValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_bevSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004474 RID: 17524
			// (get) Token: 0x0600D25D RID: 53853 RVA: 0x00338E04 File Offset: 0x00337004
			// (set) Token: 0x0600D25E RID: 53854 RVA: 0x00070AFB File Offset: 0x0006ECFB
			public unsafe float bevStartAngle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_bevStartAngle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_bevStartAngle)) = value;
				}
			}

			// Token: 0x17004475 RID: 17525
			// (get) Token: 0x0600D25F RID: 53855 RVA: 0x00338E2C File Offset: 0x0033702C
			// (set) Token: 0x0600D260 RID: 53856 RVA: 0x00070B16 File Offset: 0x0006ED16
			public unsafe WaitForSeconds waitForSpawn
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_waitForSpawn);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WaitForSeconds>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_waitForSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004476 RID: 17526
			// (get) Token: 0x0600D261 RID: 53857 RVA: 0x00338E5C File Offset: 0x0033705C
			// (set) Token: 0x0600D262 RID: 53858 RVA: 0x00070B35 File Offset: 0x0006ED35
			public unsafe List<EventManager.SelectedValue> iceSelections
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_iceSelections);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EventManager.SelectedValue>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_iceSelections), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004477 RID: 17527
			// (get) Token: 0x0600D263 RID: 53859 RVA: 0x00338E8C File Offset: 0x0033708C
			// (set) Token: 0x0600D264 RID: 53860 RVA: 0x00070B54 File Offset: 0x0006ED54
			public unsafe float iceStartAngle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_iceStartAngle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_iceStartAngle)) = value;
				}
			}

			// Token: 0x17004478 RID: 17528
			// (get) Token: 0x0600D265 RID: 53861 RVA: 0x00338EB4 File Offset: 0x003370B4
			// (set) Token: 0x0600D266 RID: 53862 RVA: 0x00070B6F File Offset: 0x0006ED6F
			public unsafe int giveIceNum
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_giveIceNum);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_giveIceNum)) = value;
				}
			}

			// Token: 0x17004479 RID: 17529
			// (get) Token: 0x0600D267 RID: 53863 RVA: 0x00338EDC File Offset: 0x003370DC
			// (set) Token: 0x0600D268 RID: 53864 RVA: 0x00070B8A File Offset: 0x0006ED8A
			public unsafe bool hasAnyItemGetSFXPlayed
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_hasAnyItemGetSFXPlayed);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr_hasAnyItemGetSFXPlayed)) = value;
				}
			}

			// Token: 0x1700447A RID: 17530
			// (get) Token: 0x0600D269 RID: 53865 RVA: 0x00338F04 File Offset: 0x00337104
			// (set) Token: 0x0600D26A RID: 53866 RVA: 0x00070BA5 File Offset: 0x0006EDA5
			public unsafe Action<float> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700447B RID: 17531
			// (get) Token: 0x0600D26B RID: 53867 RVA: 0x00338F34 File Offset: 0x00337134
			// (set) Token: 0x0600D26C RID: 53868 RVA: 0x00070BC4 File Offset: 0x0006EDC4
			public unsafe Action<float> __9__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr___9__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.NativeFieldInfoPtr___9__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008711 RID: 34577
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008712 RID: 34578
			private static readonly IntPtr NativeFieldInfoPtr_characterPosition;

			// Token: 0x04008713 RID: 34579
			private static readonly IntPtr NativeFieldInfoPtr_bevSelections;

			// Token: 0x04008714 RID: 34580
			private static readonly IntPtr NativeFieldInfoPtr_bevStartAngle;

			// Token: 0x04008715 RID: 34581
			private static readonly IntPtr NativeFieldInfoPtr_waitForSpawn;

			// Token: 0x04008716 RID: 34582
			private static readonly IntPtr NativeFieldInfoPtr_iceSelections;

			// Token: 0x04008717 RID: 34583
			private static readonly IntPtr NativeFieldInfoPtr_iceStartAngle;

			// Token: 0x04008718 RID: 34584
			private static readonly IntPtr NativeFieldInfoPtr_giveIceNum;

			// Token: 0x04008719 RID: 34585
			private static readonly IntPtr NativeFieldInfoPtr_hasAnyItemGetSFXPlayed;

			// Token: 0x0400871A RID: 34586
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x0400871B RID: 34587
			private static readonly IntPtr NativeFieldInfoPtr___9__4;

			// Token: 0x0400871C RID: 34588
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400871D RID: 34589
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400871E RID: 34590
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_Single_0;

			// Token: 0x0400871F RID: 34591
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_1;

			// Token: 0x04008720 RID: 34592
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__4_Internal_Void_Single_0;

			// Token: 0x04008721 RID: 34593
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_Transform_SelectedValue_Single_Action_1_Single_Int32_Vector3_Vector3_PDM_0;

			// Token: 0x02001024 RID: 4132
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Cirno+<>c__DisplayClass31_0+<<OnPositiveBuffExecute>g__SpawnBevItem|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0 : Il2CppSystem.Object
			{
				// Token: 0x06011AD8 RID: 72408 RVA: 0x0040D31C File Offset: 0x0040B51C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0()
				{
					Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__SpawnBevItem|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, "<>1__state");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, "<>2__current");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, "<>4__this");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, "<i>5__2");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100678466);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100678467);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100678468);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100678469);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100678470);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr, 100678471);
				}

				// Token: 0x06011AD9 RID: 72409 RVA: 0x0040D410 File Offset: 0x0040B610
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011ADA RID: 72410 RVA: 0x0040D458 File Offset: 0x0040B658
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011ADB RID: 72411 RVA: 0x0040D48C File Offset: 0x0040B68C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195389, XrefRangeEnd = 195439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005BFC RID: 23548
				// (get) Token: 0x06011ADC RID: 72412 RVA: 0x0040D4C8 File Offset: 0x0040B6C8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011ADD RID: 72413 RVA: 0x0040D508 File Offset: 0x0040B708
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195439, XrefRangeEnd = 195445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005BFD RID: 23549
				// (get) Token: 0x06011ADE RID: 72414 RVA: 0x0040D53C File Offset: 0x0040B73C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011ADF RID: 72415 RVA: 0x00099A9D File Offset: 0x00097C9D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BF8 RID: 23544
				// (get) Token: 0x06011AE0 RID: 72416 RVA: 0x0040D57C File Offset: 0x0040B77C
				// (set) Token: 0x06011AE1 RID: 72417 RVA: 0x00099AA6 File Offset: 0x00097CA6
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BF9 RID: 23545
				// (get) Token: 0x06011AE2 RID: 72418 RVA: 0x0040D5A4 File Offset: 0x0040B7A4
				// (set) Token: 0x06011AE3 RID: 72419 RVA: 0x00099AC1 File Offset: 0x00097CC1
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BFA RID: 23546
				// (get) Token: 0x06011AE4 RID: 72420 RVA: 0x0040D5D4 File Offset: 0x0040B7D4
				// (set) Token: 0x06011AE5 RID: 72421 RVA: 0x00099AE0 File Offset: 0x00097CE0
				public unsafe Spell_Cirno.__c__DisplayClass31_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Cirno.__c__DisplayClass31_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005BFB RID: 23547
				// (get) Token: 0x06011AE6 RID: 72422 RVA: 0x0040D604 File Offset: 0x0040B804
				// (set) Token: 0x06011AE7 RID: 72423 RVA: 0x00099AFF File Offset: 0x00097CFF
				public unsafe int _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn0.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400B2B5 RID: 45749
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B2B6 RID: 45750
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B2B7 RID: 45751
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B2B8 RID: 45752
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400B2B9 RID: 45753
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B2BA RID: 45754
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2BB RID: 45755
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B2BC RID: 45756
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B2BD RID: 45757
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2BE RID: 45758
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001025 RID: 4133
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Cirno+<>c__DisplayClass31_0+<<OnPositiveBuffExecute>g__SpawnIceItem|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1 : Il2CppSystem.Object
			{
				// Token: 0x06011AE8 RID: 72424 RVA: 0x0040D62C File Offset: 0x0040B82C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1()
				{
					Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__SpawnIceItem|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, "<>1__state");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, "<>2__current");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, "<>4__this");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr__i_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, "<i>5__2");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100678472);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100678473);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100678474);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100678475);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100678476);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr, 100678477);
				}

				// Token: 0x06011AE9 RID: 72425 RVA: 0x0040D720 File Offset: 0x0040B920
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011AEA RID: 72426 RVA: 0x0040D768 File Offset: 0x0040B968
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011AEB RID: 72427 RVA: 0x0040D79C File Offset: 0x0040B99C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195445, XrefRangeEnd = 195495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C02 RID: 23554
				// (get) Token: 0x06011AEC RID: 72428 RVA: 0x0040D7D8 File Offset: 0x0040B9D8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011AED RID: 72429 RVA: 0x0040D818 File Offset: 0x0040BA18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195495, XrefRangeEnd = 195501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C03 RID: 23555
				// (get) Token: 0x06011AEE RID: 72430 RVA: 0x0040D84C File Offset: 0x0040BA4C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011AEF RID: 72431 RVA: 0x00099B1A File Offset: 0x00097D1A
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005BFE RID: 23550
				// (get) Token: 0x06011AF0 RID: 72432 RVA: 0x0040D88C File Offset: 0x0040BA8C
				// (set) Token: 0x06011AF1 RID: 72433 RVA: 0x00099B23 File Offset: 0x00097D23
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005BFF RID: 23551
				// (get) Token: 0x06011AF2 RID: 72434 RVA: 0x0040D8B4 File Offset: 0x0040BAB4
				// (set) Token: 0x06011AF3 RID: 72435 RVA: 0x00099B3E File Offset: 0x00097D3E
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C00 RID: 23552
				// (get) Token: 0x06011AF4 RID: 72436 RVA: 0x0040D8E4 File Offset: 0x0040BAE4
				// (set) Token: 0x06011AF5 RID: 72437 RVA: 0x00099B5D File Offset: 0x00097D5D
				public unsafe Spell_Cirno.__c__DisplayClass31_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Cirno.__c__DisplayClass31_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C01 RID: 23553
				// (get) Token: 0x06011AF6 RID: 72438 RVA: 0x0040D914 File Offset: 0x0040BB14
				// (set) Token: 0x06011AF7 RID: 72439 RVA: 0x00099B7C File Offset: 0x00097D7C
				public unsafe int _i_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr__i_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVoInObMoVoBoObIn1.NativeFieldInfoPtr__i_5__2)) = value;
					}
				}

				// Token: 0x0400B2BF RID: 45759
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B2C0 RID: 45760
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B2C1 RID: 45761
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B2C2 RID: 45762
				private static readonly IntPtr NativeFieldInfoPtr__i_5__2;

				// Token: 0x0400B2C3 RID: 45763
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B2C4 RID: 45764
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2C5 RID: 45765
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B2C6 RID: 45766
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B2C7 RID: 45767
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2C8 RID: 45768
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}

			// Token: 0x02001026 RID: 4134
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Cirno+<>c__DisplayClass31_0+<<OnPositiveBuffExecute>g__MoveToStorage|2>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique : Il2CppSystem.Object
			{
				// Token: 0x06011AF8 RID: 72440 RVA: 0x0040D93C File Offset: 0x0040BB3C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique()
				{
					Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0>.NativeClassPtr, "<<OnPositiveBuffExecute>g__MoveToStorage|2>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "<>1__state");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "<>2__current");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_targetStoragePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "targetStoragePosition");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_itemTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "itemTransform");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_startAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "startAngle");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_giveNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "giveNum");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_setStartAngleCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "setStartAngleCallback");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "<>4__this");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_targetStorageUiPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "targetStorageUiPosition");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_giveData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "giveData");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr__thisItemTransform_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, "<thisItemTransform>5__2");
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, 100678478);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, 100678479);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, 100678480);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, 100678481);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, 100678482);
					Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr, 100678483);
				}

				// Token: 0x06011AF9 RID: 72441 RVA: 0x0040DABC File Offset: 0x0040BCBC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011AFA RID: 72442 RVA: 0x0040DB04 File Offset: 0x0040BD04
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011AFB RID: 72443 RVA: 0x0040DB38 File Offset: 0x0040BD38
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195501, XrefRangeEnd = 195554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C0F RID: 23567
				// (get) Token: 0x06011AFC RID: 72444 RVA: 0x0040DB74 File Offset: 0x0040BD74
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011AFD RID: 72445 RVA: 0x0040DBB4 File Offset: 0x0040BDB4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195554, XrefRangeEnd = 195560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C10 RID: 23568
				// (get) Token: 0x06011AFE RID: 72446 RVA: 0x0040DBE8 File Offset: 0x0040BDE8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011AFF RID: 72447 RVA: 0x00099B97 File Offset: 0x00097D97
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C04 RID: 23556
				// (get) Token: 0x06011B00 RID: 72448 RVA: 0x0040DC28 File Offset: 0x0040BE28
				// (set) Token: 0x06011B01 RID: 72449 RVA: 0x00099BA0 File Offset: 0x00097DA0
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C05 RID: 23557
				// (get) Token: 0x06011B02 RID: 72450 RVA: 0x0040DC50 File Offset: 0x0040BE50
				// (set) Token: 0x06011B03 RID: 72451 RVA: 0x00099BBB File Offset: 0x00097DBB
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C06 RID: 23558
				// (get) Token: 0x06011B04 RID: 72452 RVA: 0x0040DC80 File Offset: 0x0040BE80
				// (set) Token: 0x06011B05 RID: 72453 RVA: 0x00099BDA File Offset: 0x00097DDA
				public unsafe Vector3 targetStoragePosition
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_targetStoragePosition);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_targetStoragePosition)) = value;
					}
				}

				// Token: 0x17005C07 RID: 23559
				// (get) Token: 0x06011B06 RID: 72454 RVA: 0x0040DCA8 File Offset: 0x0040BEA8
				// (set) Token: 0x06011B07 RID: 72455 RVA: 0x00099BF5 File Offset: 0x00097DF5
				public unsafe Transform itemTransform
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_itemTransform);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_itemTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C08 RID: 23560
				// (get) Token: 0x06011B08 RID: 72456 RVA: 0x0040DCD8 File Offset: 0x0040BED8
				// (set) Token: 0x06011B09 RID: 72457 RVA: 0x00099C14 File Offset: 0x00097E14
				public unsafe float startAngle
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_startAngle);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_startAngle)) = value;
					}
				}

				// Token: 0x17005C09 RID: 23561
				// (get) Token: 0x06011B0A RID: 72458 RVA: 0x0040DD00 File Offset: 0x0040BF00
				// (set) Token: 0x06011B0B RID: 72459 RVA: 0x00099C2F File Offset: 0x00097E2F
				public unsafe int giveNum
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_giveNum);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_giveNum)) = value;
					}
				}

				// Token: 0x17005C0A RID: 23562
				// (get) Token: 0x06011B0C RID: 72460 RVA: 0x0040DD28 File Offset: 0x0040BF28
				// (set) Token: 0x06011B0D RID: 72461 RVA: 0x00099C4A File Offset: 0x00097E4A
				public unsafe Action<float> setStartAngleCallback
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_setStartAngleCallback);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<float>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_setStartAngleCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C0B RID: 23563
				// (get) Token: 0x06011B0E RID: 72462 RVA: 0x0040DD58 File Offset: 0x0040BF58
				// (set) Token: 0x06011B0F RID: 72463 RVA: 0x00099C69 File Offset: 0x00097E69
				public unsafe Spell_Cirno.__c__DisplayClass31_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Cirno.__c__DisplayClass31_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C0C RID: 23564
				// (get) Token: 0x06011B10 RID: 72464 RVA: 0x0040DD88 File Offset: 0x0040BF88
				// (set) Token: 0x06011B11 RID: 72465 RVA: 0x00099C88 File Offset: 0x00097E88
				public unsafe Vector3 targetStorageUiPosition
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_targetStorageUiPosition);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_targetStorageUiPosition)) = value;
					}
				}

				// Token: 0x17005C0D RID: 23565
				// (get) Token: 0x06011B12 RID: 72466 RVA: 0x0040DDB0 File Offset: 0x0040BFB0
				// (set) Token: 0x06011B13 RID: 72467 RVA: 0x00099CA3 File Offset: 0x00097EA3
				public EventManager.SelectedValue giveData
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_giveData);
						return new EventManager.SelectedValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, intPtr));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr_giveData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, (UIntPtr)0));
					}
				}

				// Token: 0x17005C0E RID: 23566
				// (get) Token: 0x06011B14 RID: 72468 RVA: 0x0040DDE0 File Offset: 0x0040BFE0
				// (set) Token: 0x06011B15 RID: 72469 RVA: 0x00099CD1 File Offset: 0x00097ED1
				public unsafe Transform _thisItemTransform_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr__thisItemTransform_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVetaTritSistgiInUnique.NativeFieldInfoPtr__thisItemTransform_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B2C9 RID: 45769
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B2CA RID: 45770
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B2CB RID: 45771
				private static readonly IntPtr NativeFieldInfoPtr_targetStoragePosition;

				// Token: 0x0400B2CC RID: 45772
				private static readonly IntPtr NativeFieldInfoPtr_itemTransform;

				// Token: 0x0400B2CD RID: 45773
				private static readonly IntPtr NativeFieldInfoPtr_startAngle;

				// Token: 0x0400B2CE RID: 45774
				private static readonly IntPtr NativeFieldInfoPtr_giveNum;

				// Token: 0x0400B2CF RID: 45775
				private static readonly IntPtr NativeFieldInfoPtr_setStartAngleCallback;

				// Token: 0x0400B2D0 RID: 45776
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B2D1 RID: 45777
				private static readonly IntPtr NativeFieldInfoPtr_targetStorageUiPosition;

				// Token: 0x0400B2D2 RID: 45778
				private static readonly IntPtr NativeFieldInfoPtr_giveData;

				// Token: 0x0400B2D3 RID: 45779
				private static readonly IntPtr NativeFieldInfoPtr__thisItemTransform_5__2;

				// Token: 0x0400B2D4 RID: 45780
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B2D5 RID: 45781
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2D6 RID: 45782
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B2D7 RID: 45783
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B2D8 RID: 45784
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B2D9 RID: 45785
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B12 RID: 2834
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Cirno+<>c__DisplayClass31_1")]
		public sealed class __c__DisplayClass31_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D26D RID: 53869 RVA: 0x00338F64 File Offset: 0x00337164
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_1()
			{
				Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "<>c__DisplayClass31_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr);
				Spell_Cirno.__c__DisplayClass31_1.NativeFieldInfoPtr_targetPos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr, "targetPos1");
				Spell_Cirno.__c__DisplayClass31_1.NativeFieldInfoPtr_targetPos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr, "targetPos2");
				Spell_Cirno.__c__DisplayClass31_1.NativeFieldInfoPtr_targetStoragePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr, "targetStoragePosition");
				Spell_Cirno.__c__DisplayClass31_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr, 100678484);
				Spell_Cirno.__c__DisplayClass31_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr, 100678485);
				Spell_Cirno.__c__DisplayClass31_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr, 100678486);
				Spell_Cirno.__c__DisplayClass31_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr, 100678487);
			}

			// Token: 0x0600D26E RID: 53870 RVA: 0x0033901C File Offset: 0x0033721C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno.__c__DisplayClass31_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D26F RID: 53871 RVA: 0x00339058 File Offset: 0x00337258
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D270 RID: 53872 RVA: 0x00339094 File Offset: 0x00337294
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__6()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D271 RID: 53873 RVA: 0x003390D0 File Offset: 0x003372D0
			[CallerCount(0)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__7()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno.__c__DisplayClass31_1.NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D272 RID: 53874 RVA: 0x00070BE3 File Offset: 0x0006EDE3
			public __c__DisplayClass31_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447C RID: 17532
			// (get) Token: 0x0600D273 RID: 53875 RVA: 0x0033910C File Offset: 0x0033730C
			// (set) Token: 0x0600D274 RID: 53876 RVA: 0x00070BEC File Offset: 0x0006EDEC
			public unsafe Vector3 targetPos1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_1.NativeFieldInfoPtr_targetPos1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_1.NativeFieldInfoPtr_targetPos1)) = value;
				}
			}

			// Token: 0x1700447D RID: 17533
			// (get) Token: 0x0600D275 RID: 53877 RVA: 0x00339134 File Offset: 0x00337334
			// (set) Token: 0x0600D276 RID: 53878 RVA: 0x00070C07 File Offset: 0x0006EE07
			public unsafe Vector3 targetPos2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_1.NativeFieldInfoPtr_targetPos2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_1.NativeFieldInfoPtr_targetPos2)) = value;
				}
			}

			// Token: 0x1700447E RID: 17534
			// (get) Token: 0x0600D277 RID: 53879 RVA: 0x0033915C File Offset: 0x0033735C
			// (set) Token: 0x0600D278 RID: 53880 RVA: 0x00070C22 File Offset: 0x0006EE22
			public unsafe Vector3 targetStoragePosition
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_1.NativeFieldInfoPtr_targetStoragePosition);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno.__c__DisplayClass31_1.NativeFieldInfoPtr_targetStoragePosition)) = value;
				}
			}

			// Token: 0x04008722 RID: 34594
			private static readonly IntPtr NativeFieldInfoPtr_targetPos1;

			// Token: 0x04008723 RID: 34595
			private static readonly IntPtr NativeFieldInfoPtr_targetPos2;

			// Token: 0x04008724 RID: 34596
			private static readonly IntPtr NativeFieldInfoPtr_targetStoragePosition;

			// Token: 0x04008725 RID: 34597
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008726 RID: 34598
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__5_Internal_Vector3_0;

			// Token: 0x04008727 RID: 34599
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__6_Internal_Vector3_0;

			// Token: 0x04008728 RID: 34600
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__7_Internal_Vector3_0;
		}

		// Token: 0x02000B13 RID: 2835
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Cirno+<OnPositiveBuffExecute>d__31")]
		public sealed class _OnPositiveBuffExecute_d__31 : Il2CppSystem.Object
		{
			// Token: 0x0600D279 RID: 53881 RVA: 0x00339184 File Offset: 0x00337384
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__31()
			{
				Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Cirno>.NativeClassPtr, "<OnPositiveBuffExecute>d__31");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr);
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, "<>1__state");
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, "<>2__current");
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, "<>4__this");
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, "spellExecutionContext");
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100678488);
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100678489);
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100678490);
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100678491);
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100678492);
				Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr, 100678493);
			}

			// Token: 0x0600D27A RID: 53882 RVA: 0x00339278 File Offset: 0x00337478
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__31(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Cirno._OnPositiveBuffExecute_d__31>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D27B RID: 53883 RVA: 0x003392C0 File Offset: 0x003374C0
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D27C RID: 53884 RVA: 0x003392F4 File Offset: 0x003374F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195582, XrefRangeEnd = 195645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004483 RID: 17539
			// (get) Token: 0x0600D27D RID: 53885 RVA: 0x00339330 File Offset: 0x00337530
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D27E RID: 53886 RVA: 0x00339370 File Offset: 0x00337570
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 195645, XrefRangeEnd = 195651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004484 RID: 17540
			// (get) Token: 0x0600D27F RID: 53887 RVA: 0x003393A4 File Offset: 0x003375A4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D280 RID: 53888 RVA: 0x00070C3D File Offset: 0x0006EE3D
			public _OnPositiveBuffExecute_d__31(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700447F RID: 17535
			// (get) Token: 0x0600D281 RID: 53889 RVA: 0x003393E4 File Offset: 0x003375E4
			// (set) Token: 0x0600D282 RID: 53890 RVA: 0x00070C46 File Offset: 0x0006EE46
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004480 RID: 17536
			// (get) Token: 0x0600D283 RID: 53891 RVA: 0x0033940C File Offset: 0x0033760C
			// (set) Token: 0x0600D284 RID: 53892 RVA: 0x00070C61 File Offset: 0x0006EE61
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004481 RID: 17537
			// (get) Token: 0x0600D285 RID: 53893 RVA: 0x0033943C File Offset: 0x0033763C
			// (set) Token: 0x0600D286 RID: 53894 RVA: 0x00070C80 File Offset: 0x0006EE80
			public unsafe Spell_Cirno __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Cirno>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004482 RID: 17538
			// (get) Token: 0x0600D287 RID: 53895 RVA: 0x0033946C File Offset: 0x0033766C
			// (set) Token: 0x0600D288 RID: 53896 RVA: 0x00070C9F File Offset: 0x0006EE9F
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Cirno._OnPositiveBuffExecute_d__31.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008729 RID: 34601
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400872A RID: 34602
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400872B RID: 34603
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400872C RID: 34604
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x0400872D RID: 34605
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400872E RID: 34606
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400872F RID: 34607
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008730 RID: 34608
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008731 RID: 34609
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008732 RID: 34610
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
