using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.GuestManagementUtility;
using NightScene.UI.EventUtility;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200027E RID: 638
	public class Spell_Rin : SpellBase
	{
		// Token: 0x06005081 RID: 20609 RVA: 0x001B0F18 File Offset: 0x001AF118
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Rin()
		{
			Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Rin");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr);
			Spell_Rin.NativeFieldInfoPtr_RIN_BUFF_MARK = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "RIN_BUFF_MARK");
			Spell_Rin.NativeFieldInfoPtr_RIN_EXTRA_ORDER_NUM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "RIN_EXTRA_ORDER_NUM");
			Spell_Rin.NativeFieldInfoPtr_negativeMultiper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "negativeMultiper");
			Spell_Rin.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "negativeDuration");
			Spell_Rin.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "positiveDuration");
			Spell_Rin.NativeFieldInfoPtr_addOrderNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "addOrderNum");
			Spell_Rin.NativeFieldInfoPtr_addRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "addRate");
			Spell_Rin.NativeFieldInfoPtr_extraOrderVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "extraOrderVFX");
			Spell_Rin.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, 100679485);
			Spell_Rin.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, 100679486);
			Spell_Rin.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, 100679487);
			Spell_Rin.NativeMethodInfoPtr_GetEffectDisplayer_Private_Boolean_GuestGroupController_byref_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, 100679488);
			Spell_Rin.NativeMethodInfoPtr_RefreshDisplayer_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, 100679489);
			Spell_Rin.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, 100679490);
			Spell_Rin.NativeMethodInfoPtr__OnPositiveBuffExecute_b__10_0_Private_Void_GuestGroupController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, 100679491);
			Spell_Rin.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, 100679492);
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x001B1088 File Offset: 0x001AF288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202806, XrefRangeEnd = 202808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Rin.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005083 RID: 20611 RVA: 0x001B10CC File Offset: 0x001AF2CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202808, XrefRangeEnd = 202813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Rin.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005084 RID: 20612 RVA: 0x001B1128 File Offset: 0x001AF328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202813, XrefRangeEnd = 202818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Rin.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06005085 RID: 20613 RVA: 0x001B1184 File Offset: 0x001AF384
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 202848, RefRangeEnd = 202849, XrefRangeStart = 202818, XrefRangeEnd = 202848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetEffectDisplayer(GuestGroupController x, out GameObject effectDisplayer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.NativeMethodInfoPtr_GetEffectDisplayer_Private_Boolean_GuestGroupController_byref_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			effectDisplayer = ((intPtr4 == 0) ? null : new GameObject(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005086 RID: 20614 RVA: 0x001B11F4 File Offset: 0x001AF3F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 202880, RefRangeEnd = 202882, XrefRangeStart = 202849, XrefRangeEnd = 202880, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshDisplayer(GuestGroupController x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.NativeMethodInfoPtr_RefreshDisplayer_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005087 RID: 20615 RVA: 0x001B1238 File Offset: 0x001AF438
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Rin() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005088 RID: 20616 RVA: 0x001B1274 File Offset: 0x001AF474
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202882, XrefRangeEnd = 202909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__10_0(GuestGroupController thisGuest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(thisGuest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.NativeMethodInfoPtr__OnPositiveBuffExecute_b__10_0_Private_Void_GuestGroupController_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005089 RID: 20617 RVA: 0x001B12B8 File Offset: 0x001AF4B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202909, XrefRangeEnd = 202913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_GuestGroupController_PDM_0(GuestGroupController guestGroupController)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(guestGroupController);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600508A RID: 20618 RVA: 0x0002AACB File Offset: 0x00028CCB
		public Spell_Rin(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x0600508B RID: 20619 RVA: 0x001B12FC File Offset: 0x001AF4FC
		// (set) Token: 0x0600508C RID: 20620 RVA: 0x0002AAD4 File Offset: 0x00028CD4
		public unsafe static GuestBuffMarkModule.GuestBuffMark RIN_BUFF_MARK
		{
			get
			{
				GuestBuffMarkModule.GuestBuffMark result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Rin.NativeFieldInfoPtr_RIN_BUFF_MARK, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Rin.NativeFieldInfoPtr_RIN_BUFF_MARK, (void*)(&value));
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x0600508D RID: 20621 RVA: 0x001B1318 File Offset: 0x001AF518
		// (set) Token: 0x0600508E RID: 20622 RVA: 0x0002AAE2 File Offset: 0x00028CE2
		public unsafe static string RIN_EXTRA_ORDER_NUM
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Rin.NativeFieldInfoPtr_RIN_EXTRA_ORDER_NUM, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Rin.NativeFieldInfoPtr_RIN_EXTRA_ORDER_NUM, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x001B1338 File Offset: 0x001AF538
		// (set) Token: 0x06005090 RID: 20624 RVA: 0x0002AAF4 File Offset: 0x00028CF4
		public unsafe float negativeMultiper
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_negativeMultiper);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_negativeMultiper)) = value;
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06005091 RID: 20625 RVA: 0x001B1360 File Offset: 0x001AF560
		// (set) Token: 0x06005092 RID: 20626 RVA: 0x0002AB0F File Offset: 0x00028D0F
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06005093 RID: 20627 RVA: 0x001B1388 File Offset: 0x001AF588
		// (set) Token: 0x06005094 RID: 20628 RVA: 0x0002AB2A File Offset: 0x00028D2A
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06005095 RID: 20629 RVA: 0x001B13B0 File Offset: 0x001AF5B0
		// (set) Token: 0x06005096 RID: 20630 RVA: 0x0002AB45 File Offset: 0x00028D45
		public unsafe int addOrderNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_addOrderNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_addOrderNum)) = value;
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06005097 RID: 20631 RVA: 0x001B13D8 File Offset: 0x001AF5D8
		// (set) Token: 0x06005098 RID: 20632 RVA: 0x0002AB60 File Offset: 0x00028D60
		public unsafe float addRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_addRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_addRate)) = value;
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06005099 RID: 20633 RVA: 0x001B1400 File Offset: 0x001AF600
		// (set) Token: 0x0600509A RID: 20634 RVA: 0x0002AB7B File Offset: 0x00028D7B
		public unsafe GameObject extraOrderVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_extraOrderVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.NativeFieldInfoPtr_extraOrderVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003680 RID: 13952
		private static readonly IntPtr NativeFieldInfoPtr_RIN_BUFF_MARK;

		// Token: 0x04003681 RID: 13953
		private static readonly IntPtr NativeFieldInfoPtr_RIN_EXTRA_ORDER_NUM;

		// Token: 0x04003682 RID: 13954
		private static readonly IntPtr NativeFieldInfoPtr_negativeMultiper;

		// Token: 0x04003683 RID: 13955
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x04003684 RID: 13956
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x04003685 RID: 13957
		private static readonly IntPtr NativeFieldInfoPtr_addOrderNum;

		// Token: 0x04003686 RID: 13958
		private static readonly IntPtr NativeFieldInfoPtr_addRate;

		// Token: 0x04003687 RID: 13959
		private static readonly IntPtr NativeFieldInfoPtr_extraOrderVFX;

		// Token: 0x04003688 RID: 13960
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x04003689 RID: 13961
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400368A RID: 13962
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400368B RID: 13963
		private static readonly IntPtr NativeMethodInfoPtr_GetEffectDisplayer_Private_Boolean_GuestGroupController_byref_GameObject_0;

		// Token: 0x0400368C RID: 13964
		private static readonly IntPtr NativeMethodInfoPtr_RefreshDisplayer_Private_Void_GuestGroupController_0;

		// Token: 0x0400368D RID: 13965
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400368E RID: 13966
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__10_0_Private_Void_GuestGroupController_0;

		// Token: 0x0400368F RID: 13967
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_GuestGroupController_PDM_0;

		// Token: 0x02000BA7 RID: 2983
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rin+<OnNegativeBuffExecute>d__9")]
		public sealed class _OnNegativeBuffExecute_d__9 : Il2CppSystem.Object
		{
			// Token: 0x0600DA6B RID: 55915 RVA: 0x00350F3C File Offset: 0x0034F13C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__9()
			{
				Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "<OnNegativeBuffExecute>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr);
				Spell_Rin._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr, "<>1__state");
				Spell_Rin._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr, "<>2__current");
				Spell_Rin._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr, "<>4__this");
				Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679493);
				Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679494);
				Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679495);
				Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679496);
				Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679497);
				Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr, 100679498);
			}

			// Token: 0x0600DA6C RID: 55916 RVA: 0x0035101C File Offset: 0x0034F21C
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__9(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rin._OnNegativeBuffExecute_d__9>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA6D RID: 55917 RVA: 0x00351064 File Offset: 0x0034F264
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA6E RID: 55918 RVA: 0x00351098 File Offset: 0x0034F298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202749, XrefRangeEnd = 202752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004707 RID: 18183
			// (get) Token: 0x0600DA6F RID: 55919 RVA: 0x003510D4 File Offset: 0x0034F2D4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA70 RID: 55920 RVA: 0x00351114 File Offset: 0x0034F314
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202752, XrefRangeEnd = 202758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004708 RID: 18184
			// (get) Token: 0x0600DA71 RID: 55921 RVA: 0x00351148 File Offset: 0x0034F348
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnNegativeBuffExecute_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA72 RID: 55922 RVA: 0x00074CFC File Offset: 0x00072EFC
			public _OnNegativeBuffExecute_d__9(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004704 RID: 18180
			// (get) Token: 0x0600DA73 RID: 55923 RVA: 0x00351188 File Offset: 0x0034F388
			// (set) Token: 0x0600DA74 RID: 55924 RVA: 0x00074D05 File Offset: 0x00072F05
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004705 RID: 18181
			// (get) Token: 0x0600DA75 RID: 55925 RVA: 0x003511B0 File Offset: 0x0034F3B0
			// (set) Token: 0x0600DA76 RID: 55926 RVA: 0x00074D20 File Offset: 0x00072F20
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004706 RID: 18182
			// (get) Token: 0x0600DA77 RID: 55927 RVA: 0x003511E0 File Offset: 0x0034F3E0
			// (set) Token: 0x0600DA78 RID: 55928 RVA: 0x00074D3F File Offset: 0x00072F3F
			public unsafe Spell_Rin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnNegativeBuffExecute_d__9.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BF6 RID: 35830
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008BF7 RID: 35831
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008BF8 RID: 35832
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008BF9 RID: 35833
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008BFA RID: 35834
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BFB RID: 35835
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008BFC RID: 35836
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008BFD RID: 35837
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008BFE RID: 35838
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA8 RID: 2984
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rin+<OnPositiveBuffExecute>d__10")]
		public sealed class _OnPositiveBuffExecute_d__10 : Il2CppSystem.Object
		{
			// Token: 0x0600DA79 RID: 55929 RVA: 0x00351210 File Offset: 0x0034F410
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__10()
			{
				Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "<OnPositiveBuffExecute>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr);
				Spell_Rin._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>1__state");
				Spell_Rin._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>2__current");
				Spell_Rin._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr, "<>4__this");
				Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679499);
				Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679500);
				Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679501);
				Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679502);
				Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679503);
				Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr, 100679504);
			}

			// Token: 0x0600DA7A RID: 55930 RVA: 0x003512F0 File Offset: 0x0034F4F0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__10(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rin._OnPositiveBuffExecute_d__10>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA7B RID: 55931 RVA: 0x00351338 File Offset: 0x0034F538
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA7C RID: 55932 RVA: 0x0035136C File Offset: 0x0034F56C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202758, XrefRangeEnd = 202769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700470C RID: 18188
			// (get) Token: 0x0600DA7D RID: 55933 RVA: 0x003513A8 File Offset: 0x0034F5A8
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA7E RID: 55934 RVA: 0x003513E8 File Offset: 0x0034F5E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202769, XrefRangeEnd = 202775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700470D RID: 18189
			// (get) Token: 0x0600DA7F RID: 55935 RVA: 0x0035141C File Offset: 0x0034F61C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin._OnPositiveBuffExecute_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600DA80 RID: 55936 RVA: 0x00074D5E File Offset: 0x00072F5E
			public _OnPositiveBuffExecute_d__10(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004709 RID: 18185
			// (get) Token: 0x0600DA81 RID: 55937 RVA: 0x0035145C File Offset: 0x0034F65C
			// (set) Token: 0x0600DA82 RID: 55938 RVA: 0x00074D67 File Offset: 0x00072F67
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700470A RID: 18186
			// (get) Token: 0x0600DA83 RID: 55939 RVA: 0x00351484 File Offset: 0x0034F684
			// (set) Token: 0x0600DA84 RID: 55940 RVA: 0x00074D82 File Offset: 0x00072F82
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700470B RID: 18187
			// (get) Token: 0x0600DA85 RID: 55941 RVA: 0x003514B4 File Offset: 0x0034F6B4
			// (set) Token: 0x0600DA86 RID: 55942 RVA: 0x00074DA1 File Offset: 0x00072FA1
			public unsafe Spell_Rin __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rin>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin._OnPositiveBuffExecute_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008BFF RID: 35839
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C00 RID: 35840
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C01 RID: 35841
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C02 RID: 35842
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C03 RID: 35843
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C04 RID: 35844
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C05 RID: 35845
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C06 RID: 35846
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C07 RID: 35847
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000BA9 RID: 2985
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rin+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA87 RID: 55943 RVA: 0x003514E4 File Offset: 0x0034F6E4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass11_0>.NativeClassPtr);
				Spell_Rin.__c__DisplayClass11_0.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass11_0>.NativeClassPtr, "y");
				Spell_Rin.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass11_0>.NativeClassPtr, 100679505);
				Spell_Rin.__c__DisplayClass11_0.NativeMethodInfoPtr__GetEffectDisplayer_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass11_0>.NativeClassPtr, 100679506);
			}

			// Token: 0x0600DA88 RID: 55944 RVA: 0x0035154C File Offset: 0x0034F74C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass11_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA89 RID: 55945 RVA: 0x00351588 File Offset: 0x0034F788
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202775, XrefRangeEnd = 202779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.__c__DisplayClass11_0.NativeMethodInfoPtr__GetEffectDisplayer_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA8A RID: 55946 RVA: 0x00074DC0 File Offset: 0x00072FC0
			public __c__DisplayClass11_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700470E RID: 18190
			// (get) Token: 0x0600DA8B RID: 55947 RVA: 0x003515BC File Offset: 0x0034F7BC
			// (set) Token: 0x0600DA8C RID: 55948 RVA: 0x00074DC9 File Offset: 0x00072FC9
			public unsafe GameObject y
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.__c__DisplayClass11_0.NativeFieldInfoPtr_y);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.__c__DisplayClass11_0.NativeFieldInfoPtr_y), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C08 RID: 35848
			private static readonly IntPtr NativeFieldInfoPtr_y;

			// Token: 0x04008C09 RID: 35849
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C0A RID: 35850
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__2_Internal_Void_0;
		}

		// Token: 0x02000BAA RID: 2986
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rin+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600DA8D RID: 55949 RVA: 0x003515EC File Offset: 0x0034F7EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Rin.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rin.__c>.NativeClassPtr);
				Spell_Rin.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin.__c>.NativeClassPtr, "<>9");
				Spell_Rin.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin.__c>.NativeClassPtr, "<>9__11_0");
				Spell_Rin.__c.NativeFieldInfoPtr___9__11_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin.__c>.NativeClassPtr, "<>9__11_1");
				Spell_Rin.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin.__c>.NativeClassPtr, 100679508);
				Spell_Rin.__c.NativeMethodInfoPtr__GetEffectDisplayer_b__11_0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin.__c>.NativeClassPtr, 100679509);
				Spell_Rin.__c.NativeMethodInfoPtr__GetEffectDisplayer_b__11_1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin.__c>.NativeClassPtr, 100679510);
			}

			// Token: 0x0600DA8E RID: 55950 RVA: 0x00351690 File Offset: 0x0034F890
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rin.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA8F RID: 55951 RVA: 0x003516CC File Offset: 0x0034F8CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202779, XrefRangeEnd = 202786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__11_0(GameObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.__c.NativeMethodInfoPtr__GetEffectDisplayer_b__11_0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA90 RID: 55952 RVA: 0x00351710 File Offset: 0x0034F910
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202786, XrefRangeEnd = 202804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _GetEffectDisplayer_b__11_1(GameObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(y);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.__c.NativeMethodInfoPtr__GetEffectDisplayer_b__11_1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA91 RID: 55953 RVA: 0x00074DE8 File Offset: 0x00072FE8
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700470F RID: 18191
			// (get) Token: 0x0600DA92 RID: 55954 RVA: 0x00351754 File Offset: 0x0034F954
			// (set) Token: 0x0600DA93 RID: 55955 RVA: 0x00074DF1 File Offset: 0x00072FF1
			public unsafe static Spell_Rin.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Rin.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Rin.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Rin.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004710 RID: 18192
			// (get) Token: 0x0600DA94 RID: 55956 RVA: 0x0035177C File Offset: 0x0034F97C
			// (set) Token: 0x0600DA95 RID: 55957 RVA: 0x00074E03 File Offset: 0x00073003
			public unsafe static Action<GameObject> __9__11_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Rin.__c.NativeFieldInfoPtr___9__11_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Rin.__c.NativeFieldInfoPtr___9__11_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004711 RID: 18193
			// (get) Token: 0x0600DA96 RID: 55958 RVA: 0x003517A4 File Offset: 0x0034F9A4
			// (set) Token: 0x0600DA97 RID: 55959 RVA: 0x00074E15 File Offset: 0x00073015
			public unsafe static Action<GameObject> __9__11_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Rin.__c.NativeFieldInfoPtr___9__11_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Rin.__c.NativeFieldInfoPtr___9__11_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008C0B RID: 35851
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008C0C RID: 35852
			private static readonly IntPtr NativeFieldInfoPtr___9__11_0;

			// Token: 0x04008C0D RID: 35853
			private static readonly IntPtr NativeFieldInfoPtr___9__11_1;

			// Token: 0x04008C0E RID: 35854
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C0F RID: 35855
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__11_0_Internal_Void_GameObject_0;

			// Token: 0x04008C10 RID: 35856
			private static readonly IntPtr NativeMethodInfoPtr__GetEffectDisplayer_b__11_1_Internal_Void_GameObject_0;
		}

		// Token: 0x02000BAB RID: 2987
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Rin+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DA98 RID: 55960 RVA: 0x003517CC File Offset: 0x0034F9CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Rin>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass12_0>.NativeClassPtr);
				Spell_Rin.__c__DisplayClass12_0.NativeFieldInfoPtr_count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass12_0>.NativeClassPtr, "count");
				Spell_Rin.__c__DisplayClass12_0.NativeFieldInfoPtr_checkThisOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass12_0>.NativeClassPtr, "checkThisOrder");
				Spell_Rin.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass12_0>.NativeClassPtr, 100679511);
				Spell_Rin.__c__DisplayClass12_0.NativeMethodInfoPtr__RefreshDisplayer_b__0_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass12_0>.NativeClassPtr, 100679512);
				Spell_Rin.__c__DisplayClass12_0.NativeMethodInfoPtr__RefreshDisplayer_b__1_Internal_Void_TextMeshProUGUI_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass12_0>.NativeClassPtr, 100679513);
				Spell_Rin.__c__DisplayClass12_0.NativeMethodInfoPtr__RefreshDisplayer_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass12_0>.NativeClassPtr, 100679514);
			}

			// Token: 0x0600DA99 RID: 55961 RVA: 0x00351870 File Offset: 0x0034FA70
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Rin.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA9A RID: 55962 RVA: 0x003518AC File Offset: 0x0034FAAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshDisplayer_b__0(TextMeshProUGUI z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(z);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.__c__DisplayClass12_0.NativeMethodInfoPtr__RefreshDisplayer_b__0_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA9B RID: 55963 RVA: 0x003518F0 File Offset: 0x0034FAF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshDisplayer_b__1(TextMeshProUGUI z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(z);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.__c__DisplayClass12_0.NativeMethodInfoPtr__RefreshDisplayer_b__1_Internal_Void_TextMeshProUGUI_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA9C RID: 55964 RVA: 0x00351934 File Offset: 0x0034FB34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 202804, XrefRangeEnd = 202806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RefreshDisplayer_b__2(Image z)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(z);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Rin.__c__DisplayClass12_0.NativeMethodInfoPtr__RefreshDisplayer_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600DA9D RID: 55965 RVA: 0x00074E27 File Offset: 0x00073027
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004712 RID: 18194
			// (get) Token: 0x0600DA9E RID: 55966 RVA: 0x00351978 File Offset: 0x0034FB78
			// (set) Token: 0x0600DA9F RID: 55967 RVA: 0x00074E30 File Offset: 0x00073030
			public unsafe int count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.__c__DisplayClass12_0.NativeFieldInfoPtr_count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.__c__DisplayClass12_0.NativeFieldInfoPtr_count)) = value;
				}
			}

			// Token: 0x17004713 RID: 18195
			// (get) Token: 0x0600DAA0 RID: 55968 RVA: 0x003519A0 File Offset: 0x0034FBA0
			// (set) Token: 0x0600DAA1 RID: 55969 RVA: 0x00074E4B File Offset: 0x0007304B
			public unsafe bool checkThisOrder
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.__c__DisplayClass12_0.NativeFieldInfoPtr_checkThisOrder);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Rin.__c__DisplayClass12_0.NativeFieldInfoPtr_checkThisOrder)) = value;
				}
			}

			// Token: 0x04008C11 RID: 35857
			private static readonly IntPtr NativeFieldInfoPtr_count;

			// Token: 0x04008C12 RID: 35858
			private static readonly IntPtr NativeFieldInfoPtr_checkThisOrder;

			// Token: 0x04008C13 RID: 35859
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C14 RID: 35860
			private static readonly IntPtr NativeMethodInfoPtr__RefreshDisplayer_b__0_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04008C15 RID: 35861
			private static readonly IntPtr NativeMethodInfoPtr__RefreshDisplayer_b__1_Internal_Void_TextMeshProUGUI_0;

			// Token: 0x04008C16 RID: 35862
			private static readonly IntPtr NativeMethodInfoPtr__RefreshDisplayer_b__2_Internal_Void_Image_0;
		}
	}
}
