using System;
using DayScene.Input;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200026C RID: 620
	public class Spell_Luize : SpellBase
	{
		// Token: 0x06004D33 RID: 19763 RVA: 0x001A8EF0 File Offset: 0x001A70F0
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Luize()
		{
			Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Luize");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr);
			Spell_Luize.NativeFieldInfoPtr_timeForWaitToEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "timeForWaitToEnd");
			Spell_Luize.NativeFieldInfoPtr_luizeShoe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "luizeShoe");
			Spell_Luize.NativeFieldInfoPtr_luizeShoeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "luizeShoeDuration");
			Spell_Luize.NativeFieldInfoPtr_cameraSpawnVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "cameraSpawnVfx");
			Spell_Luize.NativeFieldInfoPtr_cameraVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "cameraVfx");
			Spell_Luize.NativeFieldInfoPtr_photoDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "photoDelay");
			Spell_Luize.NativeFieldInfoPtr_photoVfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "photoVfx");
			Spell_Luize.NativeFieldInfoPtr_photoVfx_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "photoVfx_2");
			Spell_Luize.NativeFieldInfoPtr_photoLeaveDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "photoLeaveDelay");
			Spell_Luize.NativeFieldInfoPtr_photoReleaseDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "photoReleaseDelay");
			Spell_Luize.NativeFieldInfoPtr_photoSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "photoSpace");
			Spell_Luize.NativeFieldInfoPtr_photoOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "photoOffset");
			Spell_Luize.NativeFieldInfoPtr_positiveSfxCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "positiveSfxCamera");
			Spell_Luize.NativeFieldInfoPtr_positiveSfxShot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "positiveSfxShot");
			Spell_Luize.NativeFieldInfoPtr_positiveSfxInstantiate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "positiveSfxInstantiate");
			Spell_Luize.NativeFieldInfoPtr_positiveSfxEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "positiveSfxEnd");
			Spell_Luize.NativeFieldInfoPtr_negativeSfxClock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "negativeSfxClock");
			Spell_Luize.NativeFieldInfoPtr_negativeSfxGlassBroken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "negativeSfxGlassBroken");
			Spell_Luize.NativeFieldInfoPtr_LUIZE_PHOTO_RELEASE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "LUIZE_PHOTO_RELEASE");
			Spell_Luize.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678823);
			Spell_Luize.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678824);
			Spell_Luize.NativeMethodInfoPtr_CheckLeave_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678825);
			Spell_Luize.NativeMethodInfoPtr_TryRecordGuest_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678826);
			Spell_Luize.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678827);
			Spell_Luize.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678828);
			Spell_Luize.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678829);
			Spell_Luize.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_1_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678830);
			Spell_Luize.NativeMethodInfoPtr__OnNegativeBuffExecute_b__23_1_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678831);
			Spell_Luize.NativeMethodInfoPtr__OnNegativeBuffExecute_b__23_2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678832);
			Spell_Luize.NativeMethodInfoPtr_Method_Private_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678833);
			Spell_Luize.NativeMethodInfoPtr__OnNegativeBuffExecute_b__23_3_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, 100678834);
		}

		// Token: 0x06004D34 RID: 19764 RVA: 0x001A918C File Offset: 0x001A738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198636, XrefRangeEnd = 198638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Luize.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D35 RID: 19765 RVA: 0x001A91D0 File Offset: 0x001A73D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198638, XrefRangeEnd = 198643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Luize.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D36 RID: 19766 RVA: 0x001A922C File Offset: 0x001A742C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198643, XrefRangeEnd = 198655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckLeave(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.NativeMethodInfoPtr_CheckLeave_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D37 RID: 19767 RVA: 0x001A9270 File Offset: 0x001A7470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198655, XrefRangeEnd = 198674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryRecordGuest(GuestGroupController guestsController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestsController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.NativeMethodInfoPtr_TryRecordGuest_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D38 RID: 19768 RVA: 0x001A92B4 File Offset: 0x001A74B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198674, XrefRangeEnd = 198679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Luize.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004D39 RID: 19769 RVA: 0x001A9310 File Offset: 0x001A7510
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198679, XrefRangeEnd = 198680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Luize() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3A RID: 19770 RVA: 0x001A934C File Offset: 0x001A754C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198680, XrefRangeEnd = 198700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__20_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3B RID: 19771 RVA: 0x001A9380 File Offset: 0x001A7580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198700, XrefRangeEnd = 198712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__20_1(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_1_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3C RID: 19772 RVA: 0x001A93C4 File Offset: 0x001A75C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198712, XrefRangeEnd = 198717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _OnNegativeBuffExecute_b__23_1(string des)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(des);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.NativeMethodInfoPtr__OnNegativeBuffExecute_b__23_1_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004D3D RID: 19773 RVA: 0x001A940C File Offset: 0x001A760C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198717, XrefRangeEnd = 198731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnNegativeBuffExecute_b__23_2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.NativeMethodInfoPtr__OnNegativeBuffExecute_b__23_2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3E RID: 19774 RVA: 0x001A9440 File Offset: 0x001A7640
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198731, XrefRangeEnd = 198744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.NativeMethodInfoPtr_Method_Private_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D3F RID: 19775 RVA: 0x001A9474 File Offset: 0x001A7674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198744, XrefRangeEnd = 198754, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnNegativeBuffExecute_b__23_3()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.NativeMethodInfoPtr__OnNegativeBuffExecute_b__23_3_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004D40 RID: 19776 RVA: 0x000281C9 File Offset: 0x000263C9
		public Spell_Luize(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x06004D41 RID: 19777 RVA: 0x001A94A8 File Offset: 0x001A76A8
		// (set) Token: 0x06004D42 RID: 19778 RVA: 0x000281D2 File Offset: 0x000263D2
		public unsafe int timeForWaitToEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_timeForWaitToEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_timeForWaitToEnd)) = value;
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x06004D43 RID: 19779 RVA: 0x001A94D0 File Offset: 0x001A76D0
		// (set) Token: 0x06004D44 RID: 19780 RVA: 0x000281ED File Offset: 0x000263ED
		public unsafe GameObject luizeShoe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_luizeShoe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_luizeShoe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x06004D45 RID: 19781 RVA: 0x001A9500 File Offset: 0x001A7700
		// (set) Token: 0x06004D46 RID: 19782 RVA: 0x0002820C File Offset: 0x0002640C
		public unsafe float luizeShoeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_luizeShoeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_luizeShoeDuration)) = value;
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x06004D47 RID: 19783 RVA: 0x001A9528 File Offset: 0x001A7728
		// (set) Token: 0x06004D48 RID: 19784 RVA: 0x00028227 File Offset: 0x00026427
		public unsafe GameObject cameraSpawnVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_cameraSpawnVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_cameraSpawnVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x06004D49 RID: 19785 RVA: 0x001A9558 File Offset: 0x001A7758
		// (set) Token: 0x06004D4A RID: 19786 RVA: 0x00028246 File Offset: 0x00026446
		public unsafe GameObject cameraVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_cameraVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_cameraVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x06004D4B RID: 19787 RVA: 0x001A9588 File Offset: 0x001A7788
		// (set) Token: 0x06004D4C RID: 19788 RVA: 0x00028265 File Offset: 0x00026465
		public unsafe float photoDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoDelay)) = value;
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x06004D4D RID: 19789 RVA: 0x001A95B0 File Offset: 0x001A77B0
		// (set) Token: 0x06004D4E RID: 19790 RVA: 0x00028280 File Offset: 0x00026480
		public unsafe GameObject photoVfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoVfx);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoVfx), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x06004D4F RID: 19791 RVA: 0x001A95E0 File Offset: 0x001A77E0
		// (set) Token: 0x06004D50 RID: 19792 RVA: 0x0002829F File Offset: 0x0002649F
		public unsafe GameObject photoVfx_2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoVfx_2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoVfx_2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x06004D51 RID: 19793 RVA: 0x001A9610 File Offset: 0x001A7810
		// (set) Token: 0x06004D52 RID: 19794 RVA: 0x000282BE File Offset: 0x000264BE
		public unsafe float photoLeaveDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoLeaveDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoLeaveDelay)) = value;
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x06004D53 RID: 19795 RVA: 0x001A9638 File Offset: 0x001A7838
		// (set) Token: 0x06004D54 RID: 19796 RVA: 0x000282D9 File Offset: 0x000264D9
		public unsafe float photoReleaseDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoReleaseDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoReleaseDelay)) = value;
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x06004D55 RID: 19797 RVA: 0x001A9660 File Offset: 0x001A7860
		// (set) Token: 0x06004D56 RID: 19798 RVA: 0x000282F4 File Offset: 0x000264F4
		public unsafe float photoSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoSpace)) = value;
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x06004D57 RID: 19799 RVA: 0x001A9688 File Offset: 0x001A7888
		// (set) Token: 0x06004D58 RID: 19800 RVA: 0x0002830F File Offset: 0x0002650F
		public unsafe Vector3 photoOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_photoOffset)) = value;
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x06004D59 RID: 19801 RVA: 0x001A96B0 File Offset: 0x001A78B0
		// (set) Token: 0x06004D5A RID: 19802 RVA: 0x0002832A File Offset: 0x0002652A
		public SpellBase.DelayAudioClip positiveSfxCamera
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_positiveSfxCamera);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_positiveSfxCamera), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x06004D5B RID: 19803 RVA: 0x001A96E0 File Offset: 0x001A78E0
		// (set) Token: 0x06004D5C RID: 19804 RVA: 0x00028358 File Offset: 0x00026558
		public SpellBase.DelayAudioClip positiveSfxShot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_positiveSfxShot);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_positiveSfxShot), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x06004D5D RID: 19805 RVA: 0x001A9710 File Offset: 0x001A7910
		// (set) Token: 0x06004D5E RID: 19806 RVA: 0x00028386 File Offset: 0x00026586
		public SpellBase.DelayAudioClip positiveSfxInstantiate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_positiveSfxInstantiate);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_positiveSfxInstantiate), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x06004D5F RID: 19807 RVA: 0x001A9740 File Offset: 0x001A7940
		// (set) Token: 0x06004D60 RID: 19808 RVA: 0x000283B4 File Offset: 0x000265B4
		public SpellBase.DelayAudioClip positiveSfxEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_positiveSfxEnd);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_positiveSfxEnd), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06004D61 RID: 19809 RVA: 0x001A9770 File Offset: 0x001A7970
		// (set) Token: 0x06004D62 RID: 19810 RVA: 0x000283E2 File Offset: 0x000265E2
		public SpellBase.DelayAudioClip negativeSfxClock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_negativeSfxClock);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_negativeSfxClock), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x06004D63 RID: 19811 RVA: 0x001A97A0 File Offset: 0x001A79A0
		// (set) Token: 0x06004D64 RID: 19812 RVA: 0x00028410 File Offset: 0x00026610
		public SpellBase.DelayAudioClip negativeSfxGlassBroken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_negativeSfxGlassBroken);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.NativeFieldInfoPtr_negativeSfxGlassBroken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06004D65 RID: 19813 RVA: 0x001A97D0 File Offset: 0x001A79D0
		// (set) Token: 0x06004D66 RID: 19814 RVA: 0x0002843E File Offset: 0x0002663E
		public unsafe static string LUIZE_PHOTO_RELEASE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Luize.NativeFieldInfoPtr_LUIZE_PHOTO_RELEASE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Luize.NativeFieldInfoPtr_LUIZE_PHOTO_RELEASE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040034B7 RID: 13495
		private static readonly IntPtr NativeFieldInfoPtr_timeForWaitToEnd;

		// Token: 0x040034B8 RID: 13496
		private static readonly IntPtr NativeFieldInfoPtr_luizeShoe;

		// Token: 0x040034B9 RID: 13497
		private static readonly IntPtr NativeFieldInfoPtr_luizeShoeDuration;

		// Token: 0x040034BA RID: 13498
		private static readonly IntPtr NativeFieldInfoPtr_cameraSpawnVfx;

		// Token: 0x040034BB RID: 13499
		private static readonly IntPtr NativeFieldInfoPtr_cameraVfx;

		// Token: 0x040034BC RID: 13500
		private static readonly IntPtr NativeFieldInfoPtr_photoDelay;

		// Token: 0x040034BD RID: 13501
		private static readonly IntPtr NativeFieldInfoPtr_photoVfx;

		// Token: 0x040034BE RID: 13502
		private static readonly IntPtr NativeFieldInfoPtr_photoVfx_2;

		// Token: 0x040034BF RID: 13503
		private static readonly IntPtr NativeFieldInfoPtr_photoLeaveDelay;

		// Token: 0x040034C0 RID: 13504
		private static readonly IntPtr NativeFieldInfoPtr_photoReleaseDelay;

		// Token: 0x040034C1 RID: 13505
		private static readonly IntPtr NativeFieldInfoPtr_photoSpace;

		// Token: 0x040034C2 RID: 13506
		private static readonly IntPtr NativeFieldInfoPtr_photoOffset;

		// Token: 0x040034C3 RID: 13507
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfxCamera;

		// Token: 0x040034C4 RID: 13508
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfxShot;

		// Token: 0x040034C5 RID: 13509
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfxInstantiate;

		// Token: 0x040034C6 RID: 13510
		private static readonly IntPtr NativeFieldInfoPtr_positiveSfxEnd;

		// Token: 0x040034C7 RID: 13511
		private static readonly IntPtr NativeFieldInfoPtr_negativeSfxClock;

		// Token: 0x040034C8 RID: 13512
		private static readonly IntPtr NativeFieldInfoPtr_negativeSfxGlassBroken;

		// Token: 0x040034C9 RID: 13513
		private static readonly IntPtr NativeFieldInfoPtr_LUIZE_PHOTO_RELEASE;

		// Token: 0x040034CA RID: 13514
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x040034CB RID: 13515
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040034CC RID: 13516
		private static readonly IntPtr NativeMethodInfoPtr_CheckLeave_Private_Void_GuestGroupController_0;

		// Token: 0x040034CD RID: 13517
		private static readonly IntPtr NativeMethodInfoPtr_TryRecordGuest_Private_Void_GuestGroupController_0;

		// Token: 0x040034CE RID: 13518
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040034CF RID: 13519
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040034D0 RID: 13520
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_0_Private_Void_0;

		// Token: 0x040034D1 RID: 13521
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__20_1_Private_Void_GuestGroupController_0;

		// Token: 0x040034D2 RID: 13522
		private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__23_1_Private_String_String_0;

		// Token: 0x040034D3 RID: 13523
		private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__23_2_Private_Void_0;

		// Token: 0x040034D4 RID: 13524
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_PDM_0;

		// Token: 0x040034D5 RID: 13525
		private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__23_3_Private_Void_0;

		// Token: 0x02000B42 RID: 2882
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Luize+<OnPositiveBuffExecute>d__20")]
		public sealed class _OnPositiveBuffExecute_d__20 : Il2CppSystem.Object
		{
			// Token: 0x0600D523 RID: 54563 RVA: 0x003413D4 File Offset: 0x0033F5D4
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__20()
			{
				Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "<OnPositiveBuffExecute>d__20");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr);
				Spell_Luize._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>1__state");
				Spell_Luize._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>2__current");
				Spell_Luize._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr, "<>4__this");
				Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100678835);
				Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100678836);
				Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100678837);
				Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100678838);
				Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100678839);
				Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr, 100678840);
			}

			// Token: 0x0600D524 RID: 54564 RVA: 0x003414B4 File Offset: 0x0033F6B4
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__20(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Luize._OnPositiveBuffExecute_d__20>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D525 RID: 54565 RVA: 0x003414FC File Offset: 0x0033F6FC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D526 RID: 54566 RVA: 0x00341530 File Offset: 0x0033F730
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198242, XrefRangeEnd = 198277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700455B RID: 17755
			// (get) Token: 0x0600D527 RID: 54567 RVA: 0x0034156C File Offset: 0x0033F76C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D528 RID: 54568 RVA: 0x003415AC File Offset: 0x0033F7AC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198277, XrefRangeEnd = 198283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700455C RID: 17756
			// (get) Token: 0x0600D529 RID: 54569 RVA: 0x003415E0 File Offset: 0x0033F7E0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnPositiveBuffExecute_d__20.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D52A RID: 54570 RVA: 0x00072180 File Offset: 0x00070380
			public _OnPositiveBuffExecute_d__20(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004558 RID: 17752
			// (get) Token: 0x0600D52B RID: 54571 RVA: 0x00341620 File Offset: 0x0033F820
			// (set) Token: 0x0600D52C RID: 54572 RVA: 0x00072189 File Offset: 0x00070389
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004559 RID: 17753
			// (get) Token: 0x0600D52D RID: 54573 RVA: 0x00341648 File Offset: 0x0033F848
			// (set) Token: 0x0600D52E RID: 54574 RVA: 0x000721A4 File Offset: 0x000703A4
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700455A RID: 17754
			// (get) Token: 0x0600D52F RID: 54575 RVA: 0x00341678 File Offset: 0x0033F878
			// (set) Token: 0x0600D530 RID: 54576 RVA: 0x000721C3 File Offset: 0x000703C3
			public unsafe Spell_Luize __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Luize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnPositiveBuffExecute_d__20.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088C6 RID: 35014
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088C7 RID: 35015
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088C8 RID: 35016
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088C9 RID: 35017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088CA RID: 35018
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088CB RID: 35019
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088CC RID: 35020
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088CD RID: 35021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088CE RID: 35022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B43 RID: 2883
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Luize+<>c__DisplayClass22_0")]
		public sealed class __c__DisplayClass22_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D531 RID: 54577 RVA: 0x003416A8 File Offset: 0x0033F8A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_0()
			{
				Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "<>c__DisplayClass22_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0>.NativeClassPtr);
				Spell_Luize.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0>.NativeClassPtr, "<>4__this");
				Spell_Luize.__c__DisplayClass22_0.NativeFieldInfoPtr_specialGuestsController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0>.NativeClassPtr, "specialGuestsController");
				Spell_Luize.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0>.NativeClassPtr, 100678841);
				Spell_Luize.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0>.NativeClassPtr, 100678842);
				Spell_Luize.__c__DisplayClass22_0.NativeMethodInfoPtr__TryRecordGuest_b__7_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0>.NativeClassPtr, 100678843);
			}

			// Token: 0x0600D532 RID: 54578 RVA: 0x00341738 File Offset: 0x0033F938
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D533 RID: 54579 RVA: 0x00341774 File Offset: 0x0033F974
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198356, XrefRangeEnd = 198361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D534 RID: 54580 RVA: 0x003417B4 File Offset: 0x0033F9B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198361, XrefRangeEnd = 198366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _TryRecordGuest_b__7(string title)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(title);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_0.NativeMethodInfoPtr__TryRecordGuest_b__7_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D535 RID: 54581 RVA: 0x000721E2 File Offset: 0x000703E2
			public __c__DisplayClass22_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455D RID: 17757
			// (get) Token: 0x0600D536 RID: 54582 RVA: 0x003417FC File Offset: 0x0033F9FC
			// (set) Token: 0x0600D537 RID: 54583 RVA: 0x000721EB File Offset: 0x000703EB
			public unsafe Spell_Luize __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Luize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700455E RID: 17758
			// (get) Token: 0x0600D538 RID: 54584 RVA: 0x0034182C File Offset: 0x0033FA2C
			// (set) Token: 0x0600D539 RID: 54585 RVA: 0x0007220A File Offset: 0x0007040A
			public unsafe SpecialGuestsController specialGuestsController
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.NativeFieldInfoPtr_specialGuestsController);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpecialGuestsController>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.NativeFieldInfoPtr_specialGuestsController), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088CF RID: 35023
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088D0 RID: 35024
			private static readonly IntPtr NativeFieldInfoPtr_specialGuestsController;

			// Token: 0x040088D1 RID: 35025
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088D2 RID: 35026
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040088D3 RID: 35027
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__7_Internal_String_String_0;

			// Token: 0x0200102C RID: 4140
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Luize+<>c__DisplayClass22_0+<<TryRecordGuest>g__Shot|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011B66 RID: 72550 RVA: 0x0040ED80 File Offset: 0x0040CF80
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0>.NativeClassPtr, "<<TryRecordGuest>g__Shot|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr);
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>8__1");
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__photo_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<photo>5__2");
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678844);
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678845);
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678846);
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678847);
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678848);
					Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678849);
				}

				// Token: 0x06011B67 RID: 72551 RVA: 0x0040EE88 File Offset: 0x0040D088
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B68 RID: 72552 RVA: 0x0040EED0 File Offset: 0x0040D0D0
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B69 RID: 72553 RVA: 0x0040EF04 File Offset: 0x0040D104
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198283, XrefRangeEnd = 198350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C34 RID: 23604
				// (get) Token: 0x06011B6A RID: 72554 RVA: 0x0040EF40 File Offset: 0x0040D140
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B6B RID: 72555 RVA: 0x0040EF80 File Offset: 0x0040D180
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198350, XrefRangeEnd = 198356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C35 RID: 23605
				// (get) Token: 0x06011B6C RID: 72556 RVA: 0x0040EFB4 File Offset: 0x0040D1B4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B6D RID: 72557 RVA: 0x00099F71 File Offset: 0x00098171
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C2F RID: 23599
				// (get) Token: 0x06011B6E RID: 72558 RVA: 0x0040EFF4 File Offset: 0x0040D1F4
				// (set) Token: 0x06011B6F RID: 72559 RVA: 0x00099F7A File Offset: 0x0009817A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C30 RID: 23600
				// (get) Token: 0x06011B70 RID: 72560 RVA: 0x0040F01C File Offset: 0x0040D21C
				// (set) Token: 0x06011B71 RID: 72561 RVA: 0x00099F95 File Offset: 0x00098195
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C31 RID: 23601
				// (get) Token: 0x06011B72 RID: 72562 RVA: 0x0040F04C File Offset: 0x0040D24C
				// (set) Token: 0x06011B73 RID: 72563 RVA: 0x00099FB4 File Offset: 0x000981B4
				public unsafe Spell_Luize.__c__DisplayClass22_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Luize.__c__DisplayClass22_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C32 RID: 23602
				// (get) Token: 0x06011B74 RID: 72564 RVA: 0x0040F07C File Offset: 0x0040D27C
				// (set) Token: 0x06011B75 RID: 72565 RVA: 0x00099FD3 File Offset: 0x000981D3
				public unsafe Spell_Luize.__c__DisplayClass22_1 __8__1
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___8__1);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Luize.__c__DisplayClass22_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C33 RID: 23603
				// (get) Token: 0x06011B76 RID: 72566 RVA: 0x0040F0AC File Offset: 0x0040D2AC
				// (set) Token: 0x06011B77 RID: 72567 RVA: 0x00099FF2 File Offset: 0x000981F2
				public unsafe GameObject _photo_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__photo_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__photo_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B30C RID: 45836
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B30D RID: 45837
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B30E RID: 45838
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B30F RID: 45839
				private static readonly IntPtr NativeFieldInfoPtr___8__1;

				// Token: 0x0400B310 RID: 45840
				private static readonly IntPtr NativeFieldInfoPtr__photo_5__2;

				// Token: 0x0400B311 RID: 45841
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B312 RID: 45842
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B313 RID: 45843
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B314 RID: 45844
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B315 RID: 45845
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B316 RID: 45846
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B44 RID: 2884
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Luize+<>c__DisplayClass22_1")]
		public sealed class __c__DisplayClass22_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D53A RID: 54586 RVA: 0x0034185C File Offset: 0x0033FA5C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass22_1()
			{
				Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "<>c__DisplayClass22_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr);
				Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, "pixel");
				Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_remainingOrderCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, "remainingOrderCount");
				Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_remainingFund = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, "remainingFund");
				Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_interruptThisBuffCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, "interruptThisBuffCallback");
				Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_maxFundCarry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, "maxFundCarry");
				Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678850);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__1_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678851);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__2_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678852);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__3_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678853);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__4_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678854);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__6_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678855);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678856);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678857);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__14_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678858);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__15_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678859);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__16_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678860);
				Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__17_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, 100678861);
			}

			// Token: 0x0600D53B RID: 54587 RVA: 0x003419F0 File Offset: 0x0033FBF0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass22_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D53C RID: 54588 RVA: 0x00341A2C File Offset: 0x0033FC2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198544, XrefRangeEnd = 198547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryRecordGuest_b__1(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__1_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D53D RID: 54589 RVA: 0x00341A70 File Offset: 0x0033FC70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198547, XrefRangeEnd = 198550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryRecordGuest_b__2(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__2_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D53E RID: 54590 RVA: 0x00341AB4 File Offset: 0x0033FCB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198550, XrefRangeEnd = 198551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryRecordGuest_b__3(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__3_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D53F RID: 54591 RVA: 0x00341AF8 File Offset: 0x0033FCF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198551, XrefRangeEnd = 198552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryRecordGuest_b__4(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__4_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D540 RID: 54592 RVA: 0x00341B3C File Offset: 0x0033FD3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198552, XrefRangeEnd = 198569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _TryRecordGuest_b__6(string des)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(des);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__6_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D541 RID: 54593 RVA: 0x00341B84 File Offset: 0x0033FD84
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198569, XrefRangeEnd = 198576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D542 RID: 54594 RVA: 0x00341BB8 File Offset: 0x0033FDB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198576, XrefRangeEnd = 198581, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D543 RID: 54595 RVA: 0x00341BF8 File Offset: 0x0033FDF8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryRecordGuest_b__14(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__14_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D544 RID: 54596 RVA: 0x00341C3C File Offset: 0x0033FE3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryRecordGuest_b__15(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__15_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D545 RID: 54597 RVA: 0x00341C80 File Offset: 0x0033FE80
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryRecordGuest_b__16(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__16_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D546 RID: 54598 RVA: 0x00341CC4 File Offset: 0x0033FEC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryRecordGuest_b__17(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.NativeMethodInfoPtr__TryRecordGuest_b__17_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D547 RID: 54599 RVA: 0x00072229 File Offset: 0x00070429
			public __c__DisplayClass22_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700455F RID: 17759
			// (get) Token: 0x0600D548 RID: 54600 RVA: 0x00341D08 File Offset: 0x0033FF08
			// (set) Token: 0x0600D549 RID: 54601 RVA: 0x00072232 File Offset: 0x00070432
			public unsafe CharacterSpriteSetCompact pixel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_pixel);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004560 RID: 17760
			// (get) Token: 0x0600D54A RID: 54602 RVA: 0x00341D38 File Offset: 0x0033FF38
			// (set) Token: 0x0600D54B RID: 54603 RVA: 0x00072251 File Offset: 0x00070451
			public unsafe int remainingOrderCount
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_remainingOrderCount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_remainingOrderCount)) = value;
				}
			}

			// Token: 0x17004561 RID: 17761
			// (get) Token: 0x0600D54C RID: 54604 RVA: 0x00341D60 File Offset: 0x0033FF60
			// (set) Token: 0x0600D54D RID: 54605 RVA: 0x0007226C File Offset: 0x0007046C
			public unsafe int remainingFund
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_remainingFund);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_remainingFund)) = value;
				}
			}

			// Token: 0x17004562 RID: 17762
			// (get) Token: 0x0600D54E RID: 54606 RVA: 0x00341D88 File Offset: 0x0033FF88
			// (set) Token: 0x0600D54F RID: 54607 RVA: 0x00072287 File Offset: 0x00070487
			public unsafe Action interruptThisBuffCallback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_interruptThisBuffCallback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_interruptThisBuffCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004563 RID: 17763
			// (get) Token: 0x0600D550 RID: 54608 RVA: 0x00341DB8 File Offset: 0x0033FFB8
			// (set) Token: 0x0600D551 RID: 54609 RVA: 0x000722A6 File Offset: 0x000704A6
			public unsafe int maxFundCarry
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_maxFundCarry);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_maxFundCarry)) = value;
				}
			}

			// Token: 0x17004564 RID: 17764
			// (get) Token: 0x0600D552 RID: 54610 RVA: 0x00341DE0 File Offset: 0x0033FFE0
			// (set) Token: 0x0600D553 RID: 54611 RVA: 0x000722C1 File Offset: 0x000704C1
			public unsafe Spell_Luize.__c__DisplayClass22_0 field_Public___c__DisplayClass22_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Luize.__c__DisplayClass22_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088D4 RID: 35028
			private static readonly IntPtr NativeFieldInfoPtr_pixel;

			// Token: 0x040088D5 RID: 35029
			private static readonly IntPtr NativeFieldInfoPtr_remainingOrderCount;

			// Token: 0x040088D6 RID: 35030
			private static readonly IntPtr NativeFieldInfoPtr_remainingFund;

			// Token: 0x040088D7 RID: 35031
			private static readonly IntPtr NativeFieldInfoPtr_interruptThisBuffCallback;

			// Token: 0x040088D8 RID: 35032
			private static readonly IntPtr NativeFieldInfoPtr_maxFundCarry;

			// Token: 0x040088D9 RID: 35033
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass22_0_0;

			// Token: 0x040088DA RID: 35034
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088DB RID: 35035
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__1_Internal_Void_SpriteRenderer_0;

			// Token: 0x040088DC RID: 35036
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__2_Internal_Void_SpriteRenderer_0;

			// Token: 0x040088DD RID: 35037
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__3_Internal_Void_SpriteRenderer_0;

			// Token: 0x040088DE RID: 35038
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__4_Internal_Void_SpriteRenderer_0;

			// Token: 0x040088DF RID: 35039
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__6_Internal_String_String_0;

			// Token: 0x040088E0 RID: 35040
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x040088E1 RID: 35041
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x040088E2 RID: 35042
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__14_Internal_Void_SpriteRenderer_0;

			// Token: 0x040088E3 RID: 35043
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__15_Internal_Void_SpriteRenderer_0;

			// Token: 0x040088E4 RID: 35044
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__16_Internal_Void_SpriteRenderer_0;

			// Token: 0x040088E5 RID: 35045
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__17_Internal_Void_SpriteRenderer_0;

			// Token: 0x0200102D RID: 4141
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Luize+<>c__DisplayClass22_1+<<TryRecordGuest>g__SpawnCharacter|9>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011B78 RID: 72568 RVA: 0x0040F0DC File Offset: 0x0040D2DC
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1>.NativeClassPtr, "<<TryRecordGuest>g__SpawnCharacter|9>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr);
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__newPhoto_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, "<newPhoto>5__2");
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678862);
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678863);
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678864);
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678865);
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678866);
					Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr, 100678867);
				}

				// Token: 0x06011B79 RID: 72569 RVA: 0x0040F1D0 File Offset: 0x0040D3D0
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B7A RID: 72570 RVA: 0x0040F218 File Offset: 0x0040D418
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011B7B RID: 72571 RVA: 0x0040F24C File Offset: 0x0040D44C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198366, XrefRangeEnd = 198538, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C3A RID: 23610
				// (get) Token: 0x06011B7C RID: 72572 RVA: 0x0040F288 File Offset: 0x0040D488
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B7D RID: 72573 RVA: 0x0040F2C8 File Offset: 0x0040D4C8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198538, XrefRangeEnd = 198544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C3B RID: 23611
				// (get) Token: 0x06011B7E RID: 72574 RVA: 0x0040F2FC File Offset: 0x0040D4FC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011B7F RID: 72575 RVA: 0x0009A011 File Offset: 0x00098211
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C36 RID: 23606
				// (get) Token: 0x06011B80 RID: 72576 RVA: 0x0040F33C File Offset: 0x0040D53C
				// (set) Token: 0x06011B81 RID: 72577 RVA: 0x0009A01A File Offset: 0x0009821A
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C37 RID: 23607
				// (get) Token: 0x06011B82 RID: 72578 RVA: 0x0040F364 File Offset: 0x0040D564
				// (set) Token: 0x06011B83 RID: 72579 RVA: 0x0009A035 File Offset: 0x00098235
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C38 RID: 23608
				// (get) Token: 0x06011B84 RID: 72580 RVA: 0x0040F394 File Offset: 0x0040D594
				// (set) Token: 0x06011B85 RID: 72581 RVA: 0x0009A054 File Offset: 0x00098254
				public unsafe Spell_Luize.__c__DisplayClass22_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Luize.__c__DisplayClass22_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C39 RID: 23609
				// (get) Token: 0x06011B86 RID: 72582 RVA: 0x0040F3C4 File Offset: 0x0040D5C4
				// (set) Token: 0x06011B87 RID: 72583 RVA: 0x0009A073 File Offset: 0x00098273
				public unsafe GameObject _newPhoto_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__newPhoto_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize.__c__DisplayClass22_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObGaObObUnique.NativeFieldInfoPtr__newPhoto_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B317 RID: 45847
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B318 RID: 45848
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B319 RID: 45849
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B31A RID: 45850
				private static readonly IntPtr NativeFieldInfoPtr__newPhoto_5__2;

				// Token: 0x0400B31B RID: 45851
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B31C RID: 45852
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B31D RID: 45853
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B31E RID: 45854
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B31F RID: 45855
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B320 RID: 45856
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B45 RID: 2885
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Luize+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D554 RID: 54612 RVA: 0x00341E10 File Offset: 0x00340010
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr);
				Spell_Luize.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, "<>9");
				Spell_Luize.__c.NativeFieldInfoPtr___9__22_5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, "<>9__22_5");
				Spell_Luize.__c.NativeFieldInfoPtr___9__22_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, "<>9__22_10");
				Spell_Luize.__c.NativeFieldInfoPtr___9__22_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, "<>9__22_11");
				Spell_Luize.__c.NativeFieldInfoPtr___9__22_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, "<>9__22_12");
				Spell_Luize.__c.NativeFieldInfoPtr___9__22_13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, "<>9__22_13");
				Spell_Luize.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, 100678869);
				Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_5_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, 100678870);
				Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_10_Internal_Vector3Int_ValueTuple_2_Vector3Int_CharacterRotation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, 100678871);
				Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_11_Internal_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, 100678872);
				Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_12_Internal_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, 100678873);
				Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_13_Internal_Int32_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr, 100678874);
			}

			// Token: 0x0600D555 RID: 54613 RVA: 0x00341F2C File Offset: 0x0034012C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Luize.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D556 RID: 54614 RVA: 0x00341F68 File Offset: 0x00340168
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198581, XrefRangeEnd = 198584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _TryRecordGuest_b__22_5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_5_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D557 RID: 54615 RVA: 0x00341FA4 File Offset: 0x003401A4
			[CallerCount(0)]
			public unsafe Vector3Int _TryRecordGuest_b__22_10(ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation> x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_10_Internal_Vector3Int_ValueTuple_2_Vector3Int_CharacterRotation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D558 RID: 54616 RVA: 0x00341FF8 File Offset: 0x003401F8
			[CallerCount(0)]
			public unsafe int _TryRecordGuest_b__22_11(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_11_Internal_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D559 RID: 54617 RVA: 0x00342044 File Offset: 0x00340244
			[CallerCount(0)]
			public unsafe int _TryRecordGuest_b__22_12(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_12_Internal_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D55A RID: 54618 RVA: 0x00342090 File Offset: 0x00340290
			[CallerCount(0)]
			public unsafe int _TryRecordGuest_b__22_13(Vector3Int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize.__c.NativeMethodInfoPtr__TryRecordGuest_b__22_13_Internal_Int32_Vector3Int_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D55B RID: 54619 RVA: 0x000722E0 File Offset: 0x000704E0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004565 RID: 17765
			// (get) Token: 0x0600D55C RID: 54620 RVA: 0x003420DC File Offset: 0x003402DC
			// (set) Token: 0x0600D55D RID: 54621 RVA: 0x000722E9 File Offset: 0x000704E9
			public unsafe static Spell_Luize.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Luize.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Luize.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Luize.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004566 RID: 17766
			// (get) Token: 0x0600D55E RID: 54622 RVA: 0x00342104 File Offset: 0x00340304
			// (set) Token: 0x0600D55F RID: 54623 RVA: 0x000722FB File Offset: 0x000704FB
			public unsafe static Func<Vector3> __9__22_5
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_5, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_5, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004567 RID: 17767
			// (get) Token: 0x0600D560 RID: 54624 RVA: 0x0034212C File Offset: 0x0034032C
			// (set) Token: 0x0600D561 RID: 54625 RVA: 0x0007230D File Offset: 0x0007050D
			public unsafe static Func<ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation>, Vector3Int> __9__22_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ValueTuple<Vector3Int, DayScenePlayerInputGenerator.CharacterRotation>, Vector3Int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004568 RID: 17768
			// (get) Token: 0x0600D562 RID: 54626 RVA: 0x00342154 File Offset: 0x00340354
			// (set) Token: 0x0600D563 RID: 54627 RVA: 0x0007231F File Offset: 0x0007051F
			public unsafe static Func<Vector3Int, int> __9__22_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004569 RID: 17769
			// (get) Token: 0x0600D564 RID: 54628 RVA: 0x0034217C File Offset: 0x0034037C
			// (set) Token: 0x0600D565 RID: 54629 RVA: 0x00072331 File Offset: 0x00070531
			public unsafe static Func<Vector3Int, int> __9__22_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456A RID: 17770
			// (get) Token: 0x0600D566 RID: 54630 RVA: 0x003421A4 File Offset: 0x003403A4
			// (set) Token: 0x0600D567 RID: 54631 RVA: 0x00072343 File Offset: 0x00070543
			public unsafe static Func<Vector3Int, int> __9__22_13
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_13, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3Int, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Luize.__c.NativeFieldInfoPtr___9__22_13, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088E6 RID: 35046
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040088E7 RID: 35047
			private static readonly IntPtr NativeFieldInfoPtr___9__22_5;

			// Token: 0x040088E8 RID: 35048
			private static readonly IntPtr NativeFieldInfoPtr___9__22_10;

			// Token: 0x040088E9 RID: 35049
			private static readonly IntPtr NativeFieldInfoPtr___9__22_11;

			// Token: 0x040088EA RID: 35050
			private static readonly IntPtr NativeFieldInfoPtr___9__22_12;

			// Token: 0x040088EB RID: 35051
			private static readonly IntPtr NativeFieldInfoPtr___9__22_13;

			// Token: 0x040088EC RID: 35052
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040088ED RID: 35053
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__22_5_Internal_Vector3_0;

			// Token: 0x040088EE RID: 35054
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__22_10_Internal_Vector3Int_ValueTuple_2_Vector3Int_CharacterRotation_0;

			// Token: 0x040088EF RID: 35055
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__22_11_Internal_Int32_Vector3Int_0;

			// Token: 0x040088F0 RID: 35056
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__22_12_Internal_Int32_Vector3Int_0;

			// Token: 0x040088F1 RID: 35057
			private static readonly IntPtr NativeMethodInfoPtr__TryRecordGuest_b__22_13_Internal_Int32_Vector3Int_0;
		}

		// Token: 0x02000B46 RID: 2886
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Luize+<OnNegativeBuffExecute>d__23")]
		public sealed class _OnNegativeBuffExecute_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600D568 RID: 54632 RVA: 0x003421CC File Offset: 0x003403CC
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__23()
			{
				Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Luize>.NativeClassPtr, "<OnNegativeBuffExecute>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr);
				Spell_Luize._OnNegativeBuffExecute_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr, "<>1__state");
				Spell_Luize._OnNegativeBuffExecute_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr, "<>2__current");
				Spell_Luize._OnNegativeBuffExecute_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr, "<>4__this");
				Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr, 100678875);
				Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr, 100678876);
				Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr, 100678877);
				Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr, 100678878);
				Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr, 100678879);
				Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr, 100678880);
			}

			// Token: 0x0600D569 RID: 54633 RVA: 0x003422AC File Offset: 0x003404AC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Luize._OnNegativeBuffExecute_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D56A RID: 54634 RVA: 0x003422F4 File Offset: 0x003404F4
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D56B RID: 54635 RVA: 0x00342328 File Offset: 0x00340528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198584, XrefRangeEnd = 198630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700456E RID: 17774
			// (get) Token: 0x0600D56C RID: 54636 RVA: 0x00342364 File Offset: 0x00340564
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D56D RID: 54637 RVA: 0x003423A4 File Offset: 0x003405A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198630, XrefRangeEnd = 198636, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700456F RID: 17775
			// (get) Token: 0x0600D56E RID: 54638 RVA: 0x003423D8 File Offset: 0x003405D8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Luize._OnNegativeBuffExecute_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D56F RID: 54639 RVA: 0x00072355 File Offset: 0x00070555
			public _OnNegativeBuffExecute_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700456B RID: 17771
			// (get) Token: 0x0600D570 RID: 54640 RVA: 0x00342418 File Offset: 0x00340618
			// (set) Token: 0x0600D571 RID: 54641 RVA: 0x0007235E File Offset: 0x0007055E
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnNegativeBuffExecute_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnNegativeBuffExecute_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700456C RID: 17772
			// (get) Token: 0x0600D572 RID: 54642 RVA: 0x00342440 File Offset: 0x00340640
			// (set) Token: 0x0600D573 RID: 54643 RVA: 0x00072379 File Offset: 0x00070579
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnNegativeBuffExecute_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnNegativeBuffExecute_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700456D RID: 17773
			// (get) Token: 0x0600D574 RID: 54644 RVA: 0x00342470 File Offset: 0x00340670
			// (set) Token: 0x0600D575 RID: 54645 RVA: 0x00072398 File Offset: 0x00070598
			public unsafe Spell_Luize __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnNegativeBuffExecute_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Luize>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Luize._OnNegativeBuffExecute_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040088F2 RID: 35058
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040088F3 RID: 35059
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040088F4 RID: 35060
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040088F5 RID: 35061
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040088F6 RID: 35062
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088F7 RID: 35063
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040088F8 RID: 35064
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040088F9 RID: 35065
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040088FA RID: 35066
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
