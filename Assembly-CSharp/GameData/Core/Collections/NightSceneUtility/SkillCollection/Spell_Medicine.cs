using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.EventUtility;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x0200026F RID: 623
	public class Spell_Medicine : SpellBase
	{
		// Token: 0x06004DC2 RID: 19906 RVA: 0x001AA5B8 File Offset: 0x001A87B8
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Medicine()
		{
			Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Medicine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr);
			Spell_Medicine.NativeFieldInfoPtr_MIDDLE_BERVERAGE_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "MIDDLE_BERVERAGE_TAG");
			Spell_Medicine.NativeFieldInfoPtr_MEDICINE_SPECIAL_FOOD_TAG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "MEDICINE_SPECIAL_FOOD_TAG");
			Spell_Medicine.NativeFieldInfoPtr_LINGLING_ARRIVE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "LINGLING_ARRIVE");
			Spell_Medicine.NativeFieldInfoPtr_LINGLING_END = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "LINGLING_END");
			Spell_Medicine.NativeFieldInfoPtr_giveBevNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "giveBevNum");
			Spell_Medicine.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "positiveDuration");
			Spell_Medicine.NativeFieldInfoPtr_negativeDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "negativeDuration");
			Spell_Medicine.NativeFieldInfoPtr_suspiciousStewVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "suspiciousStewVFX");
			Spell_Medicine.NativeFieldInfoPtr_rewardAnimDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "rewardAnimDuration");
			Spell_Medicine.NativeFieldInfoPtr_rewardSpawnDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "rewardSpawnDuration");
			Spell_Medicine.NativeFieldInfoPtr_rewardFlyDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "rewardFlyDuration");
			Spell_Medicine.NativeFieldInfoPtr_rewardFlyOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "rewardFlyOffset");
			Spell_Medicine.NativeFieldInfoPtr_linglingVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingVFX");
			Spell_Medicine.NativeFieldInfoPtr_poisonVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "poisonVFX");
			Spell_Medicine.NativeFieldInfoPtr_poisonVFXDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "poisonVFXDuration");
			Spell_Medicine.NativeFieldInfoPtr_linglingSpawnOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingSpawnOffset");
			Spell_Medicine.NativeFieldInfoPtr_linglingAppearDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingAppearDuration");
			Spell_Medicine.NativeFieldInfoPtr_linglingArriveTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingArriveTime");
			Spell_Medicine.NativeFieldInfoPtr_linglingSinAmplitude = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingSinAmplitude");
			Spell_Medicine.NativeFieldInfoPtr_linglingSinPeriodicity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingSinPeriodicity");
			Spell_Medicine.NativeFieldInfoPtr_linglingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingSpeed");
			Spell_Medicine.NativeFieldInfoPtr_linglingSinOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingSinOffset");
			Spell_Medicine.NativeFieldInfoPtr_linglingSinArrivePointOffsetX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingSinArrivePointOffsetX");
			Spell_Medicine.NativeFieldInfoPtr_linglingMinDashDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingMinDashDistance");
			Spell_Medicine.NativeFieldInfoPtr_linglingMaxDashDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingMaxDashDistance");
			Spell_Medicine.NativeFieldInfoPtr_linglingControlPoint1AngularOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingControlPoint1AngularOffset");
			Spell_Medicine.NativeFieldInfoPtr_linglingControlPoint2AngularOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingControlPoint2AngularOffset");
			Spell_Medicine.NativeFieldInfoPtr_linglingEndHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingEndHide");
			Spell_Medicine.NativeFieldInfoPtr_linglingDisAppearTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "linglingDisAppearTime");
			Spell_Medicine.NativeFieldInfoPtr_craftSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "craftSfx");
			Spell_Medicine.NativeFieldInfoPtr_resultSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "resultSfx");
			Spell_Medicine.NativeFieldInfoPtr_dashSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "dashSfx");
			Spell_Medicine.NativeFieldInfoPtr_poisonSfx = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "poisonSfx");
			Spell_Medicine.NativeFieldInfoPtr_s_Arrive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "s_Arrive");
			Spell_Medicine.NativeFieldInfoPtr_s_End = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "s_End");
			Spell_Medicine.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, 100678950);
			Spell_Medicine.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, 100678951);
			Spell_Medicine.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, 100678952);
			Spell_Medicine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, 100678953);
		}

		// Token: 0x06004DC3 RID: 19907 RVA: 0x001AA8F4 File Offset: 0x001A8AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199620, XrefRangeEnd = 199622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Medicine.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004DC4 RID: 19908 RVA: 0x001AA938 File Offset: 0x001A8B38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199622, XrefRangeEnd = 199628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Medicine.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004DC5 RID: 19909 RVA: 0x001AA994 File Offset: 0x001A8B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199628, XrefRangeEnd = 199633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Medicine.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004DC6 RID: 19910 RVA: 0x001AA9F0 File Offset: 0x001A8BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199633, XrefRangeEnd = 199640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Medicine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004DC7 RID: 19911 RVA: 0x000288A2 File Offset: 0x00026AA2
		public Spell_Medicine(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06004DC8 RID: 19912 RVA: 0x001AAA2C File Offset: 0x001A8C2C
		// (set) Token: 0x06004DC9 RID: 19913 RVA: 0x000288AB File Offset: 0x00026AAB
		public unsafe static int MIDDLE_BERVERAGE_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Medicine.NativeFieldInfoPtr_MIDDLE_BERVERAGE_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Medicine.NativeFieldInfoPtr_MIDDLE_BERVERAGE_TAG, (void*)(&value));
			}
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06004DCA RID: 19914 RVA: 0x001AAA48 File Offset: 0x001A8C48
		// (set) Token: 0x06004DCB RID: 19915 RVA: 0x000288B9 File Offset: 0x00026AB9
		public unsafe static int MEDICINE_SPECIAL_FOOD_TAG
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Spell_Medicine.NativeFieldInfoPtr_MEDICINE_SPECIAL_FOOD_TAG, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Medicine.NativeFieldInfoPtr_MEDICINE_SPECIAL_FOOD_TAG, (void*)(&value));
			}
		}

		// Token: 0x17001A4C RID: 6732
		// (get) Token: 0x06004DCC RID: 19916 RVA: 0x001AAA64 File Offset: 0x001A8C64
		// (set) Token: 0x06004DCD RID: 19917 RVA: 0x000288C7 File Offset: 0x00026AC7
		public unsafe static string LINGLING_ARRIVE
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Medicine.NativeFieldInfoPtr_LINGLING_ARRIVE, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Medicine.NativeFieldInfoPtr_LINGLING_ARRIVE, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A4D RID: 6733
		// (get) Token: 0x06004DCE RID: 19918 RVA: 0x001AAA84 File Offset: 0x001A8C84
		// (set) Token: 0x06004DCF RID: 19919 RVA: 0x000288D9 File Offset: 0x00026AD9
		public unsafe static string LINGLING_END
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Spell_Medicine.NativeFieldInfoPtr_LINGLING_END, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Spell_Medicine.NativeFieldInfoPtr_LINGLING_END, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001A4E RID: 6734
		// (get) Token: 0x06004DD0 RID: 19920 RVA: 0x001AAAA4 File Offset: 0x001A8CA4
		// (set) Token: 0x06004DD1 RID: 19921 RVA: 0x000288EB File Offset: 0x00026AEB
		public unsafe int giveBevNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_giveBevNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_giveBevNum)) = value;
			}
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x06004DD2 RID: 19922 RVA: 0x001AAACC File Offset: 0x001A8CCC
		// (set) Token: 0x06004DD3 RID: 19923 RVA: 0x00028906 File Offset: 0x00026B06
		public unsafe int positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x06004DD4 RID: 19924 RVA: 0x001AAAF4 File Offset: 0x001A8CF4
		// (set) Token: 0x06004DD5 RID: 19925 RVA: 0x00028921 File Offset: 0x00026B21
		public unsafe int negativeDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_negativeDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_negativeDuration)) = value;
			}
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x06004DD6 RID: 19926 RVA: 0x001AAB1C File Offset: 0x001A8D1C
		// (set) Token: 0x06004DD7 RID: 19927 RVA: 0x0002893C File Offset: 0x00026B3C
		public unsafe GameObject suspiciousStewVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_suspiciousStewVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_suspiciousStewVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A52 RID: 6738
		// (get) Token: 0x06004DD8 RID: 19928 RVA: 0x001AAB4C File Offset: 0x001A8D4C
		// (set) Token: 0x06004DD9 RID: 19929 RVA: 0x0002895B File Offset: 0x00026B5B
		public unsafe float rewardAnimDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_rewardAnimDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_rewardAnimDuration)) = value;
			}
		}

		// Token: 0x17001A53 RID: 6739
		// (get) Token: 0x06004DDA RID: 19930 RVA: 0x001AAB74 File Offset: 0x001A8D74
		// (set) Token: 0x06004DDB RID: 19931 RVA: 0x00028976 File Offset: 0x00026B76
		public unsafe float rewardSpawnDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_rewardSpawnDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_rewardSpawnDuration)) = value;
			}
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06004DDC RID: 19932 RVA: 0x001AAB9C File Offset: 0x001A8D9C
		// (set) Token: 0x06004DDD RID: 19933 RVA: 0x00028991 File Offset: 0x00026B91
		public unsafe float rewardFlyDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_rewardFlyDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_rewardFlyDuration)) = value;
			}
		}

		// Token: 0x17001A55 RID: 6741
		// (get) Token: 0x06004DDE RID: 19934 RVA: 0x001AABC4 File Offset: 0x001A8DC4
		// (set) Token: 0x06004DDF RID: 19935 RVA: 0x000289AC File Offset: 0x00026BAC
		public unsafe float rewardFlyOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_rewardFlyOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_rewardFlyOffset)) = value;
			}
		}

		// Token: 0x17001A56 RID: 6742
		// (get) Token: 0x06004DE0 RID: 19936 RVA: 0x001AABEC File Offset: 0x001A8DEC
		// (set) Token: 0x06004DE1 RID: 19937 RVA: 0x000289C7 File Offset: 0x00026BC7
		public unsafe GameObject linglingVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A57 RID: 6743
		// (get) Token: 0x06004DE2 RID: 19938 RVA: 0x001AAC1C File Offset: 0x001A8E1C
		// (set) Token: 0x06004DE3 RID: 19939 RVA: 0x000289E6 File Offset: 0x00026BE6
		public unsafe GameObject poisonVFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_poisonVFX);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_poisonVFX), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001A58 RID: 6744
		// (get) Token: 0x06004DE4 RID: 19940 RVA: 0x001AAC4C File Offset: 0x001A8E4C
		// (set) Token: 0x06004DE5 RID: 19941 RVA: 0x00028A05 File Offset: 0x00026C05
		public unsafe float poisonVFXDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_poisonVFXDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_poisonVFXDuration)) = value;
			}
		}

		// Token: 0x17001A59 RID: 6745
		// (get) Token: 0x06004DE6 RID: 19942 RVA: 0x001AAC74 File Offset: 0x001A8E74
		// (set) Token: 0x06004DE7 RID: 19943 RVA: 0x00028A20 File Offset: 0x00026C20
		public unsafe Vector3 linglingSpawnOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSpawnOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSpawnOffset)) = value;
			}
		}

		// Token: 0x17001A5A RID: 6746
		// (get) Token: 0x06004DE8 RID: 19944 RVA: 0x001AAC9C File Offset: 0x001A8E9C
		// (set) Token: 0x06004DE9 RID: 19945 RVA: 0x00028A3B File Offset: 0x00026C3B
		public unsafe float linglingAppearDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingAppearDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingAppearDuration)) = value;
			}
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06004DEA RID: 19946 RVA: 0x001AACC4 File Offset: 0x001A8EC4
		// (set) Token: 0x06004DEB RID: 19947 RVA: 0x00028A56 File Offset: 0x00026C56
		public unsafe float linglingArriveTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingArriveTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingArriveTime)) = value;
			}
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06004DEC RID: 19948 RVA: 0x001AACEC File Offset: 0x001A8EEC
		// (set) Token: 0x06004DED RID: 19949 RVA: 0x00028A71 File Offset: 0x00026C71
		public unsafe float linglingSinAmplitude
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSinAmplitude);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSinAmplitude)) = value;
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06004DEE RID: 19950 RVA: 0x001AAD14 File Offset: 0x001A8F14
		// (set) Token: 0x06004DEF RID: 19951 RVA: 0x00028A8C File Offset: 0x00026C8C
		public unsafe float linglingSinPeriodicity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSinPeriodicity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSinPeriodicity)) = value;
			}
		}

		// Token: 0x17001A5E RID: 6750
		// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x001AAD3C File Offset: 0x001A8F3C
		// (set) Token: 0x06004DF1 RID: 19953 RVA: 0x00028AA7 File Offset: 0x00026CA7
		public unsafe float linglingSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSpeed)) = value;
			}
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x06004DF2 RID: 19954 RVA: 0x001AAD64 File Offset: 0x001A8F64
		// (set) Token: 0x06004DF3 RID: 19955 RVA: 0x00028AC2 File Offset: 0x00026CC2
		public unsafe Vector2 linglingSinOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSinOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSinOffset)) = value;
			}
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x001AAD8C File Offset: 0x001A8F8C
		// (set) Token: 0x06004DF5 RID: 19957 RVA: 0x00028ADD File Offset: 0x00026CDD
		public unsafe float linglingSinArrivePointOffsetX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSinArrivePointOffsetX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingSinArrivePointOffsetX)) = value;
			}
		}

		// Token: 0x17001A61 RID: 6753
		// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x001AADB4 File Offset: 0x001A8FB4
		// (set) Token: 0x06004DF7 RID: 19959 RVA: 0x00028AF8 File Offset: 0x00026CF8
		public unsafe float linglingMinDashDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingMinDashDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingMinDashDistance)) = value;
			}
		}

		// Token: 0x17001A62 RID: 6754
		// (get) Token: 0x06004DF8 RID: 19960 RVA: 0x001AADDC File Offset: 0x001A8FDC
		// (set) Token: 0x06004DF9 RID: 19961 RVA: 0x00028B13 File Offset: 0x00026D13
		public unsafe float linglingMaxDashDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingMaxDashDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingMaxDashDistance)) = value;
			}
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x06004DFA RID: 19962 RVA: 0x001AAE04 File Offset: 0x001A9004
		// (set) Token: 0x06004DFB RID: 19963 RVA: 0x00028B2E File Offset: 0x00026D2E
		public unsafe float linglingControlPoint1AngularOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingControlPoint1AngularOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingControlPoint1AngularOffset)) = value;
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x06004DFC RID: 19964 RVA: 0x001AAE2C File Offset: 0x001A902C
		// (set) Token: 0x06004DFD RID: 19965 RVA: 0x00028B49 File Offset: 0x00026D49
		public unsafe float linglingControlPoint2AngularOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingControlPoint2AngularOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingControlPoint2AngularOffset)) = value;
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06004DFE RID: 19966 RVA: 0x001AAE54 File Offset: 0x001A9054
		// (set) Token: 0x06004DFF RID: 19967 RVA: 0x00028B64 File Offset: 0x00026D64
		public unsafe float linglingEndHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingEndHide);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingEndHide)) = value;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06004E00 RID: 19968 RVA: 0x001AAE7C File Offset: 0x001A907C
		// (set) Token: 0x06004E01 RID: 19969 RVA: 0x00028B7F File Offset: 0x00026D7F
		public unsafe float linglingDisAppearTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingDisAppearTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_linglingDisAppearTime)) = value;
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06004E02 RID: 19970 RVA: 0x001AAEA4 File Offset: 0x001A90A4
		// (set) Token: 0x06004E03 RID: 19971 RVA: 0x00028B9A File Offset: 0x00026D9A
		public SpellBase.DelayAudioClip craftSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_craftSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_craftSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06004E04 RID: 19972 RVA: 0x001AAED4 File Offset: 0x001A90D4
		// (set) Token: 0x06004E05 RID: 19973 RVA: 0x00028BC8 File Offset: 0x00026DC8
		public SpellBase.DelayAudioClip resultSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_resultSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_resultSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x06004E06 RID: 19974 RVA: 0x001AAF04 File Offset: 0x001A9104
		// (set) Token: 0x06004E07 RID: 19975 RVA: 0x00028BF6 File Offset: 0x00026DF6
		public SpellBase.DelayAudioClip dashSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_dashSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_dashSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x001AAF34 File Offset: 0x001A9134
		// (set) Token: 0x06004E09 RID: 19977 RVA: 0x00028C24 File Offset: 0x00026E24
		public SpellBase.DelayAudioClip poisonSfx
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_poisonSfx);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_poisonSfx), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x06004E0A RID: 19978 RVA: 0x001AAF64 File Offset: 0x001A9164
		// (set) Token: 0x06004E0B RID: 19979 RVA: 0x00028C52 File Offset: 0x00026E52
		public unsafe int s_Arrive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_s_Arrive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_s_Arrive)) = value;
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x06004E0C RID: 19980 RVA: 0x001AAF8C File Offset: 0x001A918C
		// (set) Token: 0x06004E0D RID: 19981 RVA: 0x00028C6D File Offset: 0x00026E6D
		public unsafe int s_End
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_s_End);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.NativeFieldInfoPtr_s_End)) = value;
			}
		}

		// Token: 0x04003507 RID: 13575
		private static readonly IntPtr NativeFieldInfoPtr_MIDDLE_BERVERAGE_TAG;

		// Token: 0x04003508 RID: 13576
		private static readonly IntPtr NativeFieldInfoPtr_MEDICINE_SPECIAL_FOOD_TAG;

		// Token: 0x04003509 RID: 13577
		private static readonly IntPtr NativeFieldInfoPtr_LINGLING_ARRIVE;

		// Token: 0x0400350A RID: 13578
		private static readonly IntPtr NativeFieldInfoPtr_LINGLING_END;

		// Token: 0x0400350B RID: 13579
		private static readonly IntPtr NativeFieldInfoPtr_giveBevNum;

		// Token: 0x0400350C RID: 13580
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x0400350D RID: 13581
		private static readonly IntPtr NativeFieldInfoPtr_negativeDuration;

		// Token: 0x0400350E RID: 13582
		private static readonly IntPtr NativeFieldInfoPtr_suspiciousStewVFX;

		// Token: 0x0400350F RID: 13583
		private static readonly IntPtr NativeFieldInfoPtr_rewardAnimDuration;

		// Token: 0x04003510 RID: 13584
		private static readonly IntPtr NativeFieldInfoPtr_rewardSpawnDuration;

		// Token: 0x04003511 RID: 13585
		private static readonly IntPtr NativeFieldInfoPtr_rewardFlyDuration;

		// Token: 0x04003512 RID: 13586
		private static readonly IntPtr NativeFieldInfoPtr_rewardFlyOffset;

		// Token: 0x04003513 RID: 13587
		private static readonly IntPtr NativeFieldInfoPtr_linglingVFX;

		// Token: 0x04003514 RID: 13588
		private static readonly IntPtr NativeFieldInfoPtr_poisonVFX;

		// Token: 0x04003515 RID: 13589
		private static readonly IntPtr NativeFieldInfoPtr_poisonVFXDuration;

		// Token: 0x04003516 RID: 13590
		private static readonly IntPtr NativeFieldInfoPtr_linglingSpawnOffset;

		// Token: 0x04003517 RID: 13591
		private static readonly IntPtr NativeFieldInfoPtr_linglingAppearDuration;

		// Token: 0x04003518 RID: 13592
		private static readonly IntPtr NativeFieldInfoPtr_linglingArriveTime;

		// Token: 0x04003519 RID: 13593
		private static readonly IntPtr NativeFieldInfoPtr_linglingSinAmplitude;

		// Token: 0x0400351A RID: 13594
		private static readonly IntPtr NativeFieldInfoPtr_linglingSinPeriodicity;

		// Token: 0x0400351B RID: 13595
		private static readonly IntPtr NativeFieldInfoPtr_linglingSpeed;

		// Token: 0x0400351C RID: 13596
		private static readonly IntPtr NativeFieldInfoPtr_linglingSinOffset;

		// Token: 0x0400351D RID: 13597
		private static readonly IntPtr NativeFieldInfoPtr_linglingSinArrivePointOffsetX;

		// Token: 0x0400351E RID: 13598
		private static readonly IntPtr NativeFieldInfoPtr_linglingMinDashDistance;

		// Token: 0x0400351F RID: 13599
		private static readonly IntPtr NativeFieldInfoPtr_linglingMaxDashDistance;

		// Token: 0x04003520 RID: 13600
		private static readonly IntPtr NativeFieldInfoPtr_linglingControlPoint1AngularOffset;

		// Token: 0x04003521 RID: 13601
		private static readonly IntPtr NativeFieldInfoPtr_linglingControlPoint2AngularOffset;

		// Token: 0x04003522 RID: 13602
		private static readonly IntPtr NativeFieldInfoPtr_linglingEndHide;

		// Token: 0x04003523 RID: 13603
		private static readonly IntPtr NativeFieldInfoPtr_linglingDisAppearTime;

		// Token: 0x04003524 RID: 13604
		private static readonly IntPtr NativeFieldInfoPtr_craftSfx;

		// Token: 0x04003525 RID: 13605
		private static readonly IntPtr NativeFieldInfoPtr_resultSfx;

		// Token: 0x04003526 RID: 13606
		private static readonly IntPtr NativeFieldInfoPtr_dashSfx;

		// Token: 0x04003527 RID: 13607
		private static readonly IntPtr NativeFieldInfoPtr_poisonSfx;

		// Token: 0x04003528 RID: 13608
		private static readonly IntPtr NativeFieldInfoPtr_s_Arrive;

		// Token: 0x04003529 RID: 13609
		private static readonly IntPtr NativeFieldInfoPtr_s_End;

		// Token: 0x0400352A RID: 13610
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400352B RID: 13611
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400352C RID: 13612
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x0400352D RID: 13613
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B56 RID: 2902
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Medicine+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D624 RID: 54820 RVA: 0x00344424 File Offset: 0x00342624
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr);
				Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr_targetPos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, "targetPos1");
				Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr_targetPos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, "targetPos2");
				Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr_targetsFirst = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, "targetsFirst");
				Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, "<>4__this");
				Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, 100678954);
				Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, 100678955);
				Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, 100678956);
				Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, 100678957);
				Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_ParticleSystem_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, 100678958);
				Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, 100678959);
			}

			// Token: 0x0600D625 RID: 54821 RVA: 0x00344518 File Offset: 0x00342718
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D626 RID: 54822 RVA: 0x00344554 File Offset: 0x00342754
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D627 RID: 54823 RVA: 0x00344590 File Offset: 0x00342790
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D628 RID: 54824 RVA: 0x003445CC File Offset: 0x003427CC
			[CallerCount(0)]
			public unsafe Vector3 _OnNegativeBuffExecute_b__3()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D629 RID: 54825 RVA: 0x00344608 File Offset: 0x00342808
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199307, XrefRangeEnd = 199313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_ParticleSystem_PDM_0(ParticleSystem particles)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particles);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_ParticleSystem_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D62A RID: 54826 RVA: 0x00344658 File Offset: 0x00342858
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199313, XrefRangeEnd = 199316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__5()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D62B RID: 54827 RVA: 0x000729B0 File Offset: 0x00070BB0
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A6 RID: 17830
			// (get) Token: 0x0600D62C RID: 54828 RVA: 0x0034468C File Offset: 0x0034288C
			// (set) Token: 0x0600D62D RID: 54829 RVA: 0x000729B9 File Offset: 0x00070BB9
			public unsafe Vector3 targetPos1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr_targetPos1);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr_targetPos1)) = value;
				}
			}

			// Token: 0x170045A7 RID: 17831
			// (get) Token: 0x0600D62E RID: 54830 RVA: 0x003446B4 File Offset: 0x003428B4
			// (set) Token: 0x0600D62F RID: 54831 RVA: 0x000729D4 File Offset: 0x00070BD4
			public unsafe Vector3 targetPos2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr_targetPos2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr_targetPos2)) = value;
				}
			}

			// Token: 0x170045A8 RID: 17832
			// (get) Token: 0x0600D630 RID: 54832 RVA: 0x003446DC File Offset: 0x003428DC
			// (set) Token: 0x0600D631 RID: 54833 RVA: 0x000729EF File Offset: 0x00070BEF
			public unsafe Vector2 targetsFirst
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr_targetsFirst);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr_targetsFirst)) = value;
				}
			}

			// Token: 0x170045A9 RID: 17833
			// (get) Token: 0x0600D632 RID: 54834 RVA: 0x00344704 File Offset: 0x00342904
			// (set) Token: 0x0600D633 RID: 54835 RVA: 0x00072A0A File Offset: 0x00070C0A
			public unsafe Spell_Medicine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Medicine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400895D RID: 35165
			private static readonly IntPtr NativeFieldInfoPtr_targetPos1;

			// Token: 0x0400895E RID: 35166
			private static readonly IntPtr NativeFieldInfoPtr_targetPos2;

			// Token: 0x0400895F RID: 35167
			private static readonly IntPtr NativeFieldInfoPtr_targetsFirst;

			// Token: 0x04008960 RID: 35168
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008961 RID: 35169
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008962 RID: 35170
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__1_Internal_Vector3_0;

			// Token: 0x04008963 RID: 35171
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Vector3_0;

			// Token: 0x04008964 RID: 35172
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__3_Internal_Vector3_0;

			// Token: 0x04008965 RID: 35173
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_ParticleSystem_PDM_0;

			// Token: 0x04008966 RID: 35174
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__5_Internal_Void_0;

			// Token: 0x0200102F RID: 4143
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Medicine+<>c__DisplayClass36_0+<<OnNegativeBuffExecute>g__SpawnPoisonFog|4>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011BA2 RID: 72610 RVA: 0x0040F840 File Offset: 0x0040DA40
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique()
				{
					Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__SpawnPoisonFog|4>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr);
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr_particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, "particles");
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, 100678960);
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, 100678961);
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, 100678962);
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, 100678963);
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, 100678964);
					Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr, 100678965);
				}

				// Token: 0x06011BA3 RID: 72611 RVA: 0x0040F934 File Offset: 0x0040DB34
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BA4 RID: 72612 RVA: 0x0040F97C File Offset: 0x0040DB7C
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BA5 RID: 72613 RVA: 0x0040F9B0 File Offset: 0x0040DBB0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199296, XrefRangeEnd = 199301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C4B RID: 23627
				// (get) Token: 0x06011BA6 RID: 72614 RVA: 0x0040F9EC File Offset: 0x0040DBEC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BA7 RID: 72615 RVA: 0x0040FA2C File Offset: 0x0040DC2C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199301, XrefRangeEnd = 199307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C4C RID: 23628
				// (get) Token: 0x06011BA8 RID: 72616 RVA: 0x0040FA60 File Offset: 0x0040DC60
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BA9 RID: 72617 RVA: 0x0009A19E File Offset: 0x0009839E
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C47 RID: 23623
				// (get) Token: 0x06011BAA RID: 72618 RVA: 0x0040FAA0 File Offset: 0x0040DCA0
				// (set) Token: 0x06011BAB RID: 72619 RVA: 0x0009A1A7 File Offset: 0x000983A7
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C48 RID: 23624
				// (get) Token: 0x06011BAC RID: 72620 RVA: 0x0040FAC8 File Offset: 0x0040DCC8
				// (set) Token: 0x06011BAD RID: 72621 RVA: 0x0009A1C2 File Offset: 0x000983C2
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C49 RID: 23625
				// (get) Token: 0x06011BAE RID: 72622 RVA: 0x0040FAF8 File Offset: 0x0040DCF8
				// (set) Token: 0x06011BAF RID: 72623 RVA: 0x0009A1E1 File Offset: 0x000983E1
				public unsafe Spell_Medicine.__c__DisplayClass36_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Medicine.__c__DisplayClass36_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C4A RID: 23626
				// (get) Token: 0x06011BB0 RID: 72624 RVA: 0x0040FB28 File Offset: 0x0040DD28
				// (set) Token: 0x06011BB1 RID: 72625 RVA: 0x0009A200 File Offset: 0x00098400
				public unsafe ParticleSystem particles
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr_particles);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass36_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObPapaObObUnique.NativeFieldInfoPtr_particles), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B330 RID: 45872
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B331 RID: 45873
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B332 RID: 45874
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B333 RID: 45875
				private static readonly IntPtr NativeFieldInfoPtr_particles;

				// Token: 0x0400B334 RID: 45876
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B335 RID: 45877
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B336 RID: 45878
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B337 RID: 45879
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B338 RID: 45880
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B339 RID: 45881
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B57 RID: 2903
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Medicine+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D634 RID: 54836 RVA: 0x00344734 File Offset: 0x00342934
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Medicine.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Medicine.__c>.NativeClassPtr);
				Spell_Medicine.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c>.NativeClassPtr, "<>9");
				Spell_Medicine.__c.NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c>.NativeClassPtr, "<>9__36_0");
				Spell_Medicine.__c.NativeFieldInfoPtr___9__36_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c>.NativeClassPtr, "<>9__36_6");
				Spell_Medicine.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c>.NativeClassPtr, 100678967);
				Spell_Medicine.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__36_0_Internal_Vector2_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c>.NativeClassPtr, 100678968);
				Spell_Medicine.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__36_6_Internal_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c>.NativeClassPtr, 100678969);
			}

			// Token: 0x0600D635 RID: 54837 RVA: 0x003447D8 File Offset: 0x003429D8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Medicine.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D636 RID: 54838 RVA: 0x00344814 File Offset: 0x00342A14
			[CallerCount(0)]
			public unsafe Vector2 _OnNegativeBuffExecute_b__36_0(Vector3 x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__36_0_Internal_Vector2_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D637 RID: 54839 RVA: 0x00344860 File Offset: 0x00342A60
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199316, XrefRangeEnd = 199324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string _OnNegativeBuffExecute_b__36_6(int i, string s)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref i;
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__36_6_Internal_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600D638 RID: 54840 RVA: 0x00072A29 File Offset: 0x00070C29
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045AA RID: 17834
			// (get) Token: 0x0600D639 RID: 54841 RVA: 0x003448B8 File Offset: 0x00342AB8
			// (set) Token: 0x0600D63A RID: 54842 RVA: 0x00072A32 File Offset: 0x00070C32
			public unsafe static Spell_Medicine.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Medicine.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Medicine.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Medicine.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AB RID: 17835
			// (get) Token: 0x0600D63B RID: 54843 RVA: 0x003448E0 File Offset: 0x00342AE0
			// (set) Token: 0x0600D63C RID: 54844 RVA: 0x00072A44 File Offset: 0x00070C44
			public unsafe static Func<Vector3, Vector2> __9__36_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Medicine.__c.NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Vector3, Vector2>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Medicine.__c.NativeFieldInfoPtr___9__36_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AC RID: 17836
			// (get) Token: 0x0600D63D RID: 54845 RVA: 0x00344908 File Offset: 0x00342B08
			// (set) Token: 0x0600D63E RID: 54846 RVA: 0x00072A56 File Offset: 0x00070C56
			public unsafe static Func<int, string, string> __9__36_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Medicine.__c.NativeFieldInfoPtr___9__36_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, string, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Medicine.__c.NativeFieldInfoPtr___9__36_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008967 RID: 35175
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008968 RID: 35176
			private static readonly IntPtr NativeFieldInfoPtr___9__36_0;

			// Token: 0x04008969 RID: 35177
			private static readonly IntPtr NativeFieldInfoPtr___9__36_6;

			// Token: 0x0400896A RID: 35178
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400896B RID: 35179
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__36_0_Internal_Vector2_Vector3_0;

			// Token: 0x0400896C RID: 35180
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__36_6_Internal_String_Int32_String_0;
		}

		// Token: 0x02000B58 RID: 2904
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Medicine+<OnNegativeBuffExecute>d__36")]
		public sealed class _OnNegativeBuffExecute_d__36 : Il2CppSystem.Object
		{
			// Token: 0x0600D63F RID: 54847 RVA: 0x00344930 File Offset: 0x00342B30
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__36()
			{
				Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "<OnNegativeBuffExecute>d__36");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr);
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<>1__state");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<>2__current");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<>4__this");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr_spellExecutionContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "spellExecutionContext");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<>8__1");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<startPosition>5__2");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__lingling_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<lingling>5__3");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__allControllers_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<allControllers>5__4");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__cookerCount_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<cookerCount>5__5");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__targetsLast_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<targetsLast>5__6");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__animator_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<animator>5__7");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__currentCooker_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<currentCooker>5__8");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__currentX_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<currentX>5__9");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__currentY_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, "<currentY>5__10");
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, 100678970);
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, 100678971);
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, 100678972);
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, 100678973);
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, 100678974);
				Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr, 100678975);
			}

			// Token: 0x0600D640 RID: 54848 RVA: 0x00344AEC File Offset: 0x00342CEC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__36(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Medicine._OnNegativeBuffExecute_d__36>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D641 RID: 54849 RVA: 0x00344B34 File Offset: 0x00342D34
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D642 RID: 54850 RVA: 0x00344B68 File Offset: 0x00342D68
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199324, XrefRangeEnd = 199494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045BB RID: 17851
			// (get) Token: 0x0600D643 RID: 54851 RVA: 0x00344BA4 File Offset: 0x00342DA4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D644 RID: 54852 RVA: 0x00344BE4 File Offset: 0x00342DE4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199494, XrefRangeEnd = 199500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045BC RID: 17852
			// (get) Token: 0x0600D645 RID: 54853 RVA: 0x00344C18 File Offset: 0x00342E18
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D646 RID: 54854 RVA: 0x00072A68 File Offset: 0x00070C68
			public _OnNegativeBuffExecute_d__36(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045AD RID: 17837
			// (get) Token: 0x0600D647 RID: 54855 RVA: 0x00344C58 File Offset: 0x00342E58
			// (set) Token: 0x0600D648 RID: 54856 RVA: 0x00072A71 File Offset: 0x00070C71
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045AE RID: 17838
			// (get) Token: 0x0600D649 RID: 54857 RVA: 0x00344C80 File Offset: 0x00342E80
			// (set) Token: 0x0600D64A RID: 54858 RVA: 0x00072A8C File Offset: 0x00070C8C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AF RID: 17839
			// (get) Token: 0x0600D64B RID: 54859 RVA: 0x00344CB0 File Offset: 0x00342EB0
			// (set) Token: 0x0600D64C RID: 54860 RVA: 0x00072AAB File Offset: 0x00070CAB
			public unsafe Spell_Medicine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Medicine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045B0 RID: 17840
			// (get) Token: 0x0600D64D RID: 54861 RVA: 0x00344CE0 File Offset: 0x00342EE0
			// (set) Token: 0x0600D64E RID: 54862 RVA: 0x00072ACA File Offset: 0x00070CCA
			public unsafe SpellExecutionContext spellExecutionContext
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr_spellExecutionContext);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpellExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr_spellExecutionContext), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045B1 RID: 17841
			// (get) Token: 0x0600D64F RID: 54863 RVA: 0x00344D10 File Offset: 0x00342F10
			// (set) Token: 0x0600D650 RID: 54864 RVA: 0x00072AE9 File Offset: 0x00070CE9
			public unsafe Spell_Medicine.__c__DisplayClass36_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Medicine.__c__DisplayClass36_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045B2 RID: 17842
			// (get) Token: 0x0600D651 RID: 54865 RVA: 0x00344D40 File Offset: 0x00342F40
			// (set) Token: 0x0600D652 RID: 54866 RVA: 0x00072B08 File Offset: 0x00070D08
			public unsafe Vector3 _startPosition_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__startPosition_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__startPosition_5__2)) = value;
				}
			}

			// Token: 0x170045B3 RID: 17843
			// (get) Token: 0x0600D653 RID: 54867 RVA: 0x00344D68 File Offset: 0x00342F68
			// (set) Token: 0x0600D654 RID: 54868 RVA: 0x00072B23 File Offset: 0x00070D23
			public unsafe GameObject _lingling_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__lingling_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__lingling_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045B4 RID: 17844
			// (get) Token: 0x0600D655 RID: 54869 RVA: 0x00344D98 File Offset: 0x00342F98
			// (set) Token: 0x0600D656 RID: 54870 RVA: 0x00072B42 File Offset: 0x00070D42
			public unsafe Il2CppStructArray<Vector2> _allControllers_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__allControllers_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector2>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__allControllers_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045B5 RID: 17845
			// (get) Token: 0x0600D657 RID: 54871 RVA: 0x00344DC8 File Offset: 0x00342FC8
			// (set) Token: 0x0600D658 RID: 54872 RVA: 0x00072B61 File Offset: 0x00070D61
			public unsafe int _cookerCount_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__cookerCount_5__5);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__cookerCount_5__5)) = value;
				}
			}

			// Token: 0x170045B6 RID: 17846
			// (get) Token: 0x0600D659 RID: 54873 RVA: 0x00344DF0 File Offset: 0x00342FF0
			// (set) Token: 0x0600D65A RID: 54874 RVA: 0x00072B7C File Offset: 0x00070D7C
			public unsafe Vector2 _targetsLast_5__6
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__targetsLast_5__6);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__targetsLast_5__6)) = value;
				}
			}

			// Token: 0x170045B7 RID: 17847
			// (get) Token: 0x0600D65B RID: 54875 RVA: 0x00344E18 File Offset: 0x00343018
			// (set) Token: 0x0600D65C RID: 54876 RVA: 0x00072B97 File Offset: 0x00070D97
			public unsafe Animator _animator_5__7
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__animator_5__7);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__animator_5__7), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045B8 RID: 17848
			// (get) Token: 0x0600D65D RID: 54877 RVA: 0x00344E48 File Offset: 0x00343048
			// (set) Token: 0x0600D65E RID: 54878 RVA: 0x00072BB6 File Offset: 0x00070DB6
			public unsafe int _currentCooker_5__8
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__currentCooker_5__8);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__currentCooker_5__8)) = value;
				}
			}

			// Token: 0x170045B9 RID: 17849
			// (get) Token: 0x0600D65F RID: 54879 RVA: 0x00344E70 File Offset: 0x00343070
			// (set) Token: 0x0600D660 RID: 54880 RVA: 0x00072BD1 File Offset: 0x00070DD1
			public unsafe float _currentX_5__9
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__currentX_5__9);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__currentX_5__9)) = value;
				}
			}

			// Token: 0x170045BA RID: 17850
			// (get) Token: 0x0600D661 RID: 54881 RVA: 0x00344E98 File Offset: 0x00343098
			// (set) Token: 0x0600D662 RID: 54882 RVA: 0x00072BEC File Offset: 0x00070DEC
			public unsafe float _currentY_5__10
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__currentY_5__10);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnNegativeBuffExecute_d__36.NativeFieldInfoPtr__currentY_5__10)) = value;
				}
			}

			// Token: 0x0400896D RID: 35181
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400896E RID: 35182
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400896F RID: 35183
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008970 RID: 35184
			private static readonly IntPtr NativeFieldInfoPtr_spellExecutionContext;

			// Token: 0x04008971 RID: 35185
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x04008972 RID: 35186
			private static readonly IntPtr NativeFieldInfoPtr__startPosition_5__2;

			// Token: 0x04008973 RID: 35187
			private static readonly IntPtr NativeFieldInfoPtr__lingling_5__3;

			// Token: 0x04008974 RID: 35188
			private static readonly IntPtr NativeFieldInfoPtr__allControllers_5__4;

			// Token: 0x04008975 RID: 35189
			private static readonly IntPtr NativeFieldInfoPtr__cookerCount_5__5;

			// Token: 0x04008976 RID: 35190
			private static readonly IntPtr NativeFieldInfoPtr__targetsLast_5__6;

			// Token: 0x04008977 RID: 35191
			private static readonly IntPtr NativeFieldInfoPtr__animator_5__7;

			// Token: 0x04008978 RID: 35192
			private static readonly IntPtr NativeFieldInfoPtr__currentCooker_5__8;

			// Token: 0x04008979 RID: 35193
			private static readonly IntPtr NativeFieldInfoPtr__currentX_5__9;

			// Token: 0x0400897A RID: 35194
			private static readonly IntPtr NativeFieldInfoPtr__currentY_5__10;

			// Token: 0x0400897B RID: 35195
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400897C RID: 35196
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400897D RID: 35197
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400897E RID: 35198
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400897F RID: 35199
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008980 RID: 35200
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B59 RID: 2905
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Medicine+<>c__DisplayClass37_0")]
		public sealed class __c__DisplayClass37_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D663 RID: 54883 RVA: 0x00344EC0 File Offset: 0x003430C0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass37_0()
			{
				Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "<>c__DisplayClass37_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr);
				Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr_stew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr, "stew");
				Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr_selected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr, "selected");
				Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr, "<>4__this");
				Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr___9__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr, "<>9__3");
				Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr, 100678976);
				Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr, 100678977);
				Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_SpriteRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr, 100678978);
				Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr, 100678979);
				Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr, 100678980);
			}

			// Token: 0x0600D664 RID: 54884 RVA: 0x00344FA0 File Offset: 0x003431A0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass37_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Medicine.__c__DisplayClass37_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D665 RID: 54885 RVA: 0x00344FDC File Offset: 0x003431DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199500, XrefRangeEnd = 199513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__0(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D666 RID: 54886 RVA: 0x00345020 File Offset: 0x00343220
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199513, XrefRangeEnd = 199588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__3(SpriteRenderer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_SpriteRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D667 RID: 54887 RVA: 0x00345064 File Offset: 0x00343264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199588, XrefRangeEnd = 199589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Vector3 _OnPositiveBuffExecute_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600D668 RID: 54888 RVA: 0x003450A0 File Offset: 0x003432A0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199589, XrefRangeEnd = 199591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnPositiveBuffExecute_b__2(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine.__c__DisplayClass37_0.NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D669 RID: 54889 RVA: 0x00072C07 File Offset: 0x00070E07
			public __c__DisplayClass37_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045BD RID: 17853
			// (get) Token: 0x0600D66A RID: 54890 RVA: 0x003450E0 File Offset: 0x003432E0
			// (set) Token: 0x0600D66B RID: 54891 RVA: 0x00072C10 File Offset: 0x00070E10
			public unsafe GameObject stew
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr_stew);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr_stew), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045BE RID: 17854
			// (get) Token: 0x0600D66C RID: 54892 RVA: 0x00345110 File Offset: 0x00343310
			// (set) Token: 0x0600D66D RID: 54893 RVA: 0x00072C2F File Offset: 0x00070E2F
			public EventManager.SelectedValue selected
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr_selected);
					return new EventManager.SelectedValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr_selected), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EventManager.SelectedValue>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170045BF RID: 17855
			// (get) Token: 0x0600D66E RID: 54894 RVA: 0x00345140 File Offset: 0x00343340
			// (set) Token: 0x0600D66F RID: 54895 RVA: 0x00072C5D File Offset: 0x00070E5D
			public unsafe Spell_Medicine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Medicine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045C0 RID: 17856
			// (get) Token: 0x0600D670 RID: 54896 RVA: 0x00345170 File Offset: 0x00343370
			// (set) Token: 0x0600D671 RID: 54897 RVA: 0x00072C7C File Offset: 0x00070E7C
			public unsafe Action<SpriteRenderer> __9__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr___9__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<SpriteRenderer>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine.__c__DisplayClass37_0.NativeFieldInfoPtr___9__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008981 RID: 35201
			private static readonly IntPtr NativeFieldInfoPtr_stew;

			// Token: 0x04008982 RID: 35202
			private static readonly IntPtr NativeFieldInfoPtr_selected;

			// Token: 0x04008983 RID: 35203
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008984 RID: 35204
			private static readonly IntPtr NativeFieldInfoPtr___9__3;

			// Token: 0x04008985 RID: 35205
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008986 RID: 35206
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__0_Internal_Void_GameObject_0;

			// Token: 0x04008987 RID: 35207
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__3_Internal_Void_SpriteRenderer_0;

			// Token: 0x04008988 RID: 35208
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__1_Internal_Vector3_0;

			// Token: 0x04008989 RID: 35209
			private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__2_Internal_Void_Int32_0;
		}

		// Token: 0x02000B5A RID: 2906
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Medicine+<OnPositiveBuffExecute>d__37")]
		public sealed class _OnPositiveBuffExecute_d__37 : Il2CppSystem.Object
		{
			// Token: 0x0600D672 RID: 54898 RVA: 0x003451A0 File Offset: 0x003433A0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__37()
			{
				Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Medicine>.NativeClassPtr, "<OnPositiveBuffExecute>d__37");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr);
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, "<>1__state");
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, "<>2__current");
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, "<>4__this");
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___8__1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, "<>8__1");
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, 100678981);
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, 100678982);
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, 100678983);
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, 100678984);
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, 100678985);
				Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr, 100678986);
			}

			// Token: 0x0600D673 RID: 54899 RVA: 0x00345294 File Offset: 0x00343494
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__37(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Medicine._OnPositiveBuffExecute_d__37>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D674 RID: 54900 RVA: 0x003452DC File Offset: 0x003434DC
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D675 RID: 54901 RVA: 0x00345310 File Offset: 0x00343510
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199591, XrefRangeEnd = 199614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170045C5 RID: 17861
			// (get) Token: 0x0600D676 RID: 54902 RVA: 0x0034534C File Offset: 0x0034354C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D677 RID: 54903 RVA: 0x0034538C File Offset: 0x0034358C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199614, XrefRangeEnd = 199620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170045C6 RID: 17862
			// (get) Token: 0x0600D678 RID: 54904 RVA: 0x003453C0 File Offset: 0x003435C0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D679 RID: 54905 RVA: 0x00072C9B File Offset: 0x00070E9B
			public _OnPositiveBuffExecute_d__37(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045C1 RID: 17857
			// (get) Token: 0x0600D67A RID: 54906 RVA: 0x00345400 File Offset: 0x00343600
			// (set) Token: 0x0600D67B RID: 54907 RVA: 0x00072CA4 File Offset: 0x00070EA4
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045C2 RID: 17858
			// (get) Token: 0x0600D67C RID: 54908 RVA: 0x00345428 File Offset: 0x00343628
			// (set) Token: 0x0600D67D RID: 54909 RVA: 0x00072CBF File Offset: 0x00070EBF
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045C3 RID: 17859
			// (get) Token: 0x0600D67E RID: 54910 RVA: 0x00345458 File Offset: 0x00343658
			// (set) Token: 0x0600D67F RID: 54911 RVA: 0x00072CDE File Offset: 0x00070EDE
			public unsafe Spell_Medicine __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Medicine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045C4 RID: 17860
			// (get) Token: 0x0600D680 RID: 54912 RVA: 0x00345488 File Offset: 0x00343688
			// (set) Token: 0x0600D681 RID: 54913 RVA: 0x00072CFD File Offset: 0x00070EFD
			public unsafe Spell_Medicine.__c__DisplayClass37_0 __8__1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___8__1);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Medicine.__c__DisplayClass37_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Medicine._OnPositiveBuffExecute_d__37.NativeFieldInfoPtr___8__1), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400898A RID: 35210
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400898B RID: 35211
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400898C RID: 35212
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400898D RID: 35213
			private static readonly IntPtr NativeFieldInfoPtr___8__1;

			// Token: 0x0400898E RID: 35214
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400898F RID: 35215
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008990 RID: 35216
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008991 RID: 35217
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008992 RID: 35218
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008993 RID: 35219
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
