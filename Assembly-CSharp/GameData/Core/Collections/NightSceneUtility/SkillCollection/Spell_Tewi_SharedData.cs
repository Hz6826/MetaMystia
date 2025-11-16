using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000289 RID: 649
	public class Spell_Tewi_SharedData : ScriptableObject
	{
		// Token: 0x0600520B RID: 21003 RVA: 0x001B520C File Offset: 0x001B340C
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Tewi_SharedData()
		{
			Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Tewi_SharedData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr);
			Spell_Tewi_SharedData.NativeFieldInfoPtr_noComboDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "noComboDuration");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_tewiHardSellParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "tewiHardSellParent");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_rumiaSellProductAmountRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "rumiaSellProductAmountRange");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_rumiaSellProductPriceMultiplierRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "rumiaSellProductPriceMultiplierRange");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_onLeaveDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "onLeaveDialog");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_onLeaveHardSellDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "onLeaveHardSellDialog");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_onPurchaseDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "onPurchaseDialog");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_onNonPurchaseDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "onNonPurchaseDialog");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_onCheatDialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "onCheatDialog");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_giveItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "giveItemId");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_luckySFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "luckySFX");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_luckyEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "luckyEffect");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_positiveEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "positiveEffectDuration");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_comboDestroyEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "comboDestroyEffect");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeEffectDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "negativeEffectDuration");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeSFXA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "negativeSFXA");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeSFXB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "negativeSFXB");
			Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeSFXDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, "negativeSFXDelay");
			Spell_Tewi_SharedData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr, 100679922);
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x001B53B8 File Offset: 0x001B35B8
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Tewi_SharedData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Tewi_SharedData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Tewi_SharedData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600520D RID: 21005 RVA: 0x0002BC39 File Offset: 0x00029E39
		public Spell_Tewi_SharedData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C08 RID: 7176
		// (get) Token: 0x0600520E RID: 21006 RVA: 0x001B53F4 File Offset: 0x001B35F4
		// (set) Token: 0x0600520F RID: 21007 RVA: 0x0002BC42 File Offset: 0x00029E42
		public unsafe int noComboDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_noComboDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_noComboDuration)) = value;
			}
		}

		// Token: 0x17001C09 RID: 7177
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x001B541C File Offset: 0x001B361C
		// (set) Token: 0x06005211 RID: 21009 RVA: 0x0002BC5D File Offset: 0x00029E5D
		public unsafe GameObject tewiHardSellParent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_tewiHardSellParent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_tewiHardSellParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0A RID: 7178
		// (get) Token: 0x06005212 RID: 21010 RVA: 0x001B544C File Offset: 0x001B364C
		// (set) Token: 0x06005213 RID: 21011 RVA: 0x0002BC7C File Offset: 0x00029E7C
		public unsafe Vector2Int rumiaSellProductAmountRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_rumiaSellProductAmountRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_rumiaSellProductAmountRange)) = value;
			}
		}

		// Token: 0x17001C0B RID: 7179
		// (get) Token: 0x06005214 RID: 21012 RVA: 0x001B5474 File Offset: 0x001B3674
		// (set) Token: 0x06005215 RID: 21013 RVA: 0x0002BC97 File Offset: 0x00029E97
		public unsafe Vector2Int rumiaSellProductPriceMultiplierRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_rumiaSellProductPriceMultiplierRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_rumiaSellProductPriceMultiplierRange)) = value;
			}
		}

		// Token: 0x17001C0C RID: 7180
		// (get) Token: 0x06005216 RID: 21014 RVA: 0x001B549C File Offset: 0x001B369C
		// (set) Token: 0x06005217 RID: 21015 RVA: 0x0002BCB2 File Offset: 0x00029EB2
		public unsafe Il2CppReferenceArray<DialogPackage> onLeaveDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onLeaveDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onLeaveDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x06005218 RID: 21016 RVA: 0x001B54CC File Offset: 0x001B36CC
		// (set) Token: 0x06005219 RID: 21017 RVA: 0x0002BCD1 File Offset: 0x00029ED1
		public unsafe Il2CppReferenceArray<DialogPackage> onLeaveHardSellDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onLeaveHardSellDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onLeaveHardSellDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x001B54FC File Offset: 0x001B36FC
		// (set) Token: 0x0600521B RID: 21019 RVA: 0x0002BCF0 File Offset: 0x00029EF0
		public unsafe Il2CppReferenceArray<DialogPackage> onPurchaseDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onPurchaseDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onPurchaseDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x0600521C RID: 21020 RVA: 0x001B552C File Offset: 0x001B372C
		// (set) Token: 0x0600521D RID: 21021 RVA: 0x0002BD0F File Offset: 0x00029F0F
		public unsafe Il2CppReferenceArray<DialogPackage> onNonPurchaseDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onNonPurchaseDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onNonPurchaseDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x001B555C File Offset: 0x001B375C
		// (set) Token: 0x0600521F RID: 21023 RVA: 0x0002BD2E File Offset: 0x00029F2E
		public unsafe Il2CppReferenceArray<DialogPackage> onCheatDialog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onCheatDialog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_onCheatDialog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06005220 RID: 21024 RVA: 0x001B558C File Offset: 0x001B378C
		// (set) Token: 0x06005221 RID: 21025 RVA: 0x0002BD4D File Offset: 0x00029F4D
		public unsafe int giveItemId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_giveItemId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_giveItemId)) = value;
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x001B55B4 File Offset: 0x001B37B4
		// (set) Token: 0x06005223 RID: 21027 RVA: 0x0002BD68 File Offset: 0x00029F68
		public unsafe AudioClip luckySFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_luckySFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_luckySFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06005224 RID: 21028 RVA: 0x001B55E4 File Offset: 0x001B37E4
		// (set) Token: 0x06005225 RID: 21029 RVA: 0x0002BD87 File Offset: 0x00029F87
		public unsafe GameObject luckyEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_luckyEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_luckyEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x06005226 RID: 21030 RVA: 0x001B5614 File Offset: 0x001B3814
		// (set) Token: 0x06005227 RID: 21031 RVA: 0x0002BDA6 File Offset: 0x00029FA6
		public unsafe float positiveEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_positiveEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_positiveEffectDuration)) = value;
			}
		}

		// Token: 0x17001C15 RID: 7189
		// (get) Token: 0x06005228 RID: 21032 RVA: 0x001B563C File Offset: 0x001B383C
		// (set) Token: 0x06005229 RID: 21033 RVA: 0x0002BDC1 File Offset: 0x00029FC1
		public unsafe GameObject comboDestroyEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_comboDestroyEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_comboDestroyEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x0600522A RID: 21034 RVA: 0x001B566C File Offset: 0x001B386C
		// (set) Token: 0x0600522B RID: 21035 RVA: 0x0002BDE0 File Offset: 0x00029FE0
		public unsafe float negativeEffectDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeEffectDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeEffectDuration)) = value;
			}
		}

		// Token: 0x17001C17 RID: 7191
		// (get) Token: 0x0600522C RID: 21036 RVA: 0x001B5694 File Offset: 0x001B3894
		// (set) Token: 0x0600522D RID: 21037 RVA: 0x0002BDFB File Offset: 0x00029FFB
		public unsafe AudioClip negativeSFXA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeSFXA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeSFXA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C18 RID: 7192
		// (get) Token: 0x0600522E RID: 21038 RVA: 0x001B56C4 File Offset: 0x001B38C4
		// (set) Token: 0x0600522F RID: 21039 RVA: 0x0002BE1A File Offset: 0x0002A01A
		public unsafe AudioClip negativeSFXB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeSFXB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeSFXB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C19 RID: 7193
		// (get) Token: 0x06005230 RID: 21040 RVA: 0x001B56F4 File Offset: 0x001B38F4
		// (set) Token: 0x06005231 RID: 21041 RVA: 0x0002BE39 File Offset: 0x0002A039
		public unsafe float negativeSFXDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeSFXDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Tewi_SharedData.NativeFieldInfoPtr_negativeSFXDelay)) = value;
			}
		}

		// Token: 0x04003760 RID: 14176
		private static readonly IntPtr NativeFieldInfoPtr_noComboDuration;

		// Token: 0x04003761 RID: 14177
		private static readonly IntPtr NativeFieldInfoPtr_tewiHardSellParent;

		// Token: 0x04003762 RID: 14178
		private static readonly IntPtr NativeFieldInfoPtr_rumiaSellProductAmountRange;

		// Token: 0x04003763 RID: 14179
		private static readonly IntPtr NativeFieldInfoPtr_rumiaSellProductPriceMultiplierRange;

		// Token: 0x04003764 RID: 14180
		private static readonly IntPtr NativeFieldInfoPtr_onLeaveDialog;

		// Token: 0x04003765 RID: 14181
		private static readonly IntPtr NativeFieldInfoPtr_onLeaveHardSellDialog;

		// Token: 0x04003766 RID: 14182
		private static readonly IntPtr NativeFieldInfoPtr_onPurchaseDialog;

		// Token: 0x04003767 RID: 14183
		private static readonly IntPtr NativeFieldInfoPtr_onNonPurchaseDialog;

		// Token: 0x04003768 RID: 14184
		private static readonly IntPtr NativeFieldInfoPtr_onCheatDialog;

		// Token: 0x04003769 RID: 14185
		private static readonly IntPtr NativeFieldInfoPtr_giveItemId;

		// Token: 0x0400376A RID: 14186
		private static readonly IntPtr NativeFieldInfoPtr_luckySFX;

		// Token: 0x0400376B RID: 14187
		private static readonly IntPtr NativeFieldInfoPtr_luckyEffect;

		// Token: 0x0400376C RID: 14188
		private static readonly IntPtr NativeFieldInfoPtr_positiveEffectDuration;

		// Token: 0x0400376D RID: 14189
		private static readonly IntPtr NativeFieldInfoPtr_comboDestroyEffect;

		// Token: 0x0400376E RID: 14190
		private static readonly IntPtr NativeFieldInfoPtr_negativeEffectDuration;

		// Token: 0x0400376F RID: 14191
		private static readonly IntPtr NativeFieldInfoPtr_negativeSFXA;

		// Token: 0x04003770 RID: 14192
		private static readonly IntPtr NativeFieldInfoPtr_negativeSFXB;

		// Token: 0x04003771 RID: 14193
		private static readonly IntPtr NativeFieldInfoPtr_negativeSFXDelay;

		// Token: 0x04003772 RID: 14194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
