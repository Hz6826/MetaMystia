using System;
using Common.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using NightScene.Input;
using UnityEngine;

namespace GameData.Core.Collections.NightSceneUtility.SkillCollection
{
	// Token: 0x02000274 RID: 628
	public class Spell_Murasa : SpellBase
	{
		// Token: 0x06004EC7 RID: 20167 RVA: 0x001ACBA4 File Offset: 0x001AADA4
		// Note: this type is marked as 'beforefieldinit'.
		static Spell_Murasa()
		{
			Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Core.Collections.NightSceneUtility.SkillCollection", "Spell_Murasa");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr);
			Spell_Murasa.NativeFieldInfoPtr_positiveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "positiveDuration");
			Spell_Murasa.NativeFieldInfoPtr_stunDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "stunDuration");
			Spell_Murasa.NativeFieldInfoPtr_reverseDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "reverseDuration");
			Spell_Murasa.NativeFieldInfoPtr_shipAnchorEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "shipAnchorEffect");
			Spell_Murasa.NativeFieldInfoPtr_vertexGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "vertexGameObject");
			Spell_Murasa.NativeFieldInfoPtr_dizzyEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "dizzyEffect");
			Spell_Murasa.NativeFieldInfoPtr_maxSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "maxSpeed");
			Spell_Murasa.NativeFieldInfoPtr_bezierPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "bezierPoint");
			Spell_Murasa.NativeFieldInfoPtr_anchorSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "anchorSFX");
			Spell_Murasa.NativeFieldInfoPtr_vertexSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "vertexSFX");
			Spell_Murasa.NativeFieldInfoPtr_rotateSFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "rotateSFX");
			Spell_Murasa.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, 100679111);
			Spell_Murasa.NativeMethodInfoPtr_GetProgress_Private_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, 100679112);
			Spell_Murasa.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, 100679113);
			Spell_Murasa.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, 100679114);
			Spell_Murasa.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, 100679115);
			Spell_Murasa.NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_0_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, 100679116);
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x001ACD28 File Offset: 0x001AAF28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200511, XrefRangeEnd = 200513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string OnGettingSpellOwnerIdentifier()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Murasa.NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x001ACD6C File Offset: 0x001AAF6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200513, XrefRangeEnd = 200514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetProgress(float progress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref progress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.NativeMethodInfoPtr_GetProgress_Private_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x001ACDB8 File Offset: 0x001AAFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200514, XrefRangeEnd = 200519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnNegativeBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Murasa.NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x001ACE14 File Offset: 0x001AB014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200519, XrefRangeEnd = 200524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator OnPositiveBuffExecute(SpellExecutionContext spellExecutionContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spellExecutionContext);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Spell_Murasa.NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x001ACE70 File Offset: 0x001AB070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200524, XrefRangeEnd = 200525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Spell_Murasa() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x001ACEAC File Offset: 0x001AB0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200525, XrefRangeEnd = 200527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnPositiveBuffExecute_b__14_0(int x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref x;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_0_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x0002953A File Offset: 0x0002773A
		public Spell_Murasa(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001ABA RID: 6842
		// (get) Token: 0x06004ECF RID: 20175 RVA: 0x001ACEEC File Offset: 0x001AB0EC
		// (set) Token: 0x06004ED0 RID: 20176 RVA: 0x00029543 File Offset: 0x00027743
		public unsafe float positiveDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_positiveDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_positiveDuration)) = value;
			}
		}

		// Token: 0x17001ABB RID: 6843
		// (get) Token: 0x06004ED1 RID: 20177 RVA: 0x001ACF14 File Offset: 0x001AB114
		// (set) Token: 0x06004ED2 RID: 20178 RVA: 0x0002955E File Offset: 0x0002775E
		public unsafe float stunDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_stunDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_stunDuration)) = value;
			}
		}

		// Token: 0x17001ABC RID: 6844
		// (get) Token: 0x06004ED3 RID: 20179 RVA: 0x001ACF3C File Offset: 0x001AB13C
		// (set) Token: 0x06004ED4 RID: 20180 RVA: 0x00029579 File Offset: 0x00027779
		public unsafe float reverseDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_reverseDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_reverseDuration)) = value;
			}
		}

		// Token: 0x17001ABD RID: 6845
		// (get) Token: 0x06004ED5 RID: 20181 RVA: 0x001ACF64 File Offset: 0x001AB164
		// (set) Token: 0x06004ED6 RID: 20182 RVA: 0x00029594 File Offset: 0x00027794
		public unsafe GameObject shipAnchorEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_shipAnchorEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_shipAnchorEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ABE RID: 6846
		// (get) Token: 0x06004ED7 RID: 20183 RVA: 0x001ACF94 File Offset: 0x001AB194
		// (set) Token: 0x06004ED8 RID: 20184 RVA: 0x000295B3 File Offset: 0x000277B3
		public unsafe GameObject vertexGameObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_vertexGameObject);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_vertexGameObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001ABF RID: 6847
		// (get) Token: 0x06004ED9 RID: 20185 RVA: 0x001ACFC4 File Offset: 0x001AB1C4
		// (set) Token: 0x06004EDA RID: 20186 RVA: 0x000295D2 File Offset: 0x000277D2
		public unsafe GameObject dizzyEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_dizzyEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_dizzyEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AC0 RID: 6848
		// (get) Token: 0x06004EDB RID: 20187 RVA: 0x001ACFF4 File Offset: 0x001AB1F4
		// (set) Token: 0x06004EDC RID: 20188 RVA: 0x000295F1 File Offset: 0x000277F1
		public unsafe float maxSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_maxSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_maxSpeed)) = value;
			}
		}

		// Token: 0x17001AC1 RID: 6849
		// (get) Token: 0x06004EDD RID: 20189 RVA: 0x001AD01C File Offset: 0x001AB21C
		// (set) Token: 0x06004EDE RID: 20190 RVA: 0x0002960C File Offset: 0x0002780C
		public unsafe Il2CppStructArray<Vector3> bezierPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_bezierPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Vector3>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_bezierPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001AC2 RID: 6850
		// (get) Token: 0x06004EDF RID: 20191 RVA: 0x001AD04C File Offset: 0x001AB24C
		// (set) Token: 0x06004EE0 RID: 20192 RVA: 0x0002962B File Offset: 0x0002782B
		public SpellBase.DelayAudioClip anchorSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_anchorSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_anchorSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001AC3 RID: 6851
		// (get) Token: 0x06004EE1 RID: 20193 RVA: 0x001AD07C File Offset: 0x001AB27C
		// (set) Token: 0x06004EE2 RID: 20194 RVA: 0x00029659 File Offset: 0x00027859
		public SpellBase.DelayAudioClip vertexSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_vertexSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_vertexSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17001AC4 RID: 6852
		// (get) Token: 0x06004EE3 RID: 20195 RVA: 0x001AD0AC File Offset: 0x001AB2AC
		// (set) Token: 0x06004EE4 RID: 20196 RVA: 0x00029687 File Offset: 0x00027887
		public SpellBase.DelayAudioClip rotateSFX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_rotateSFX);
				return new SpellBase.DelayAudioClip(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.NativeFieldInfoPtr_rotateSFX), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SpellBase.DelayAudioClip>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04003592 RID: 13714
		private static readonly IntPtr NativeFieldInfoPtr_positiveDuration;

		// Token: 0x04003593 RID: 13715
		private static readonly IntPtr NativeFieldInfoPtr_stunDuration;

		// Token: 0x04003594 RID: 13716
		private static readonly IntPtr NativeFieldInfoPtr_reverseDuration;

		// Token: 0x04003595 RID: 13717
		private static readonly IntPtr NativeFieldInfoPtr_shipAnchorEffect;

		// Token: 0x04003596 RID: 13718
		private static readonly IntPtr NativeFieldInfoPtr_vertexGameObject;

		// Token: 0x04003597 RID: 13719
		private static readonly IntPtr NativeFieldInfoPtr_dizzyEffect;

		// Token: 0x04003598 RID: 13720
		private static readonly IntPtr NativeFieldInfoPtr_maxSpeed;

		// Token: 0x04003599 RID: 13721
		private static readonly IntPtr NativeFieldInfoPtr_bezierPoint;

		// Token: 0x0400359A RID: 13722
		private static readonly IntPtr NativeFieldInfoPtr_anchorSFX;

		// Token: 0x0400359B RID: 13723
		private static readonly IntPtr NativeFieldInfoPtr_vertexSFX;

		// Token: 0x0400359C RID: 13724
		private static readonly IntPtr NativeFieldInfoPtr_rotateSFX;

		// Token: 0x0400359D RID: 13725
		private static readonly IntPtr NativeMethodInfoPtr_OnGettingSpellOwnerIdentifier_Protected_Virtual_String_0;

		// Token: 0x0400359E RID: 13726
		private static readonly IntPtr NativeMethodInfoPtr_GetProgress_Private_Single_Single_0;

		// Token: 0x0400359F RID: 13727
		private static readonly IntPtr NativeMethodInfoPtr_OnNegativeBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035A0 RID: 13728
		private static readonly IntPtr NativeMethodInfoPtr_OnPositiveBuffExecute_Protected_Virtual_IEnumerator_SpellExecutionContext_0;

		// Token: 0x040035A1 RID: 13729
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040035A2 RID: 13730
		private static readonly IntPtr NativeMethodInfoPtr__OnPositiveBuffExecute_b__14_0_Private_Void_Int32_0;

		// Token: 0x02000B6B RID: 2923
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Murasa+<>c__DisplayClass13_0")]
		public sealed class __c__DisplayClass13_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D761 RID: 55137 RVA: 0x00347F08 File Offset: 0x00346108
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_0()
			{
				Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "<>c__DisplayClass13_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr);
				Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr, "<>4__this");
				Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr, "controller");
				Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr, "coroutine");
				Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr_character = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr, "character");
				Spell_Murasa.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr, 100679117);
				Spell_Murasa.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr, 100679118);
				Spell_Murasa.__c__DisplayClass13_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr, 100679119);
			}

			// Token: 0x0600D762 RID: 55138 RVA: 0x00347FC0 File Offset: 0x003461C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D763 RID: 55139 RVA: 0x00347FFC File Offset: 0x003461FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200380, XrefRangeEnd = 200385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D764 RID: 55140 RVA: 0x0034803C File Offset: 0x0034623C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200385, XrefRangeEnd = 200417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_0.NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D765 RID: 55141 RVA: 0x000733E4 File Offset: 0x000715E4
			public __c__DisplayClass13_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004610 RID: 17936
			// (get) Token: 0x0600D766 RID: 55142 RVA: 0x00348070 File Offset: 0x00346270
			// (set) Token: 0x0600D767 RID: 55143 RVA: 0x000733ED File Offset: 0x000715ED
			public unsafe Spell_Murasa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Murasa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004611 RID: 17937
			// (get) Token: 0x0600D768 RID: 55144 RVA: 0x003480A0 File Offset: 0x003462A0
			// (set) Token: 0x0600D769 RID: 55145 RVA: 0x0007340C File Offset: 0x0007160C
			public unsafe CharacterControllerUnit controller
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr_controller);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004612 RID: 17938
			// (get) Token: 0x0600D76A RID: 55146 RVA: 0x003480D0 File Offset: 0x003462D0
			// (set) Token: 0x0600D76B RID: 55147 RVA: 0x0007342B File Offset: 0x0007162B
			public unsafe Coroutine coroutine
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr_coroutine);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004613 RID: 17939
			// (get) Token: 0x0600D76C RID: 55148 RVA: 0x00348100 File Offset: 0x00346300
			// (set) Token: 0x0600D76D RID: 55149 RVA: 0x0007344A File Offset: 0x0007164A
			public unsafe WorkScenePlayerInputGenerator character
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr_character);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorkScenePlayerInputGenerator>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.NativeFieldInfoPtr_character), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A1C RID: 35356
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A1D RID: 35357
			private static readonly IntPtr NativeFieldInfoPtr_controller;

			// Token: 0x04008A1E RID: 35358
			private static readonly IntPtr NativeFieldInfoPtr_coroutine;

			// Token: 0x04008A1F RID: 35359
			private static readonly IntPtr NativeFieldInfoPtr_character;

			// Token: 0x04008A20 RID: 35360
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A21 RID: 35361
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008A22 RID: 35362
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__2_Internal_Void_0;

			// Token: 0x02001033 RID: 4147
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Murasa+<>c__DisplayClass13_0+<<OnNegativeBuffExecute>g__Round|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011BDC RID: 72668 RVA: 0x004103D4 File Offset: 0x0040E5D4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique()
				{
					Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Round|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr);
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr__rotate_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, "<rotate>5__2");
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr__currentTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, "<currentTime>5__3");
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, 100679120);
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, 100679121);
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, 100679122);
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, 100679123);
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, 100679124);
					Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr, 100679125);
				}

				// Token: 0x06011BDD RID: 72669 RVA: 0x004104DC File Offset: 0x0040E6DC
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BDE RID: 72670 RVA: 0x00410524 File Offset: 0x0040E724
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BDF RID: 72671 RVA: 0x00410558 File Offset: 0x0040E758
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200355, XrefRangeEnd = 200374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C61 RID: 23649
				// (get) Token: 0x06011BE0 RID: 72672 RVA: 0x00410594 File Offset: 0x0040E794
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BE1 RID: 72673 RVA: 0x004105D4 File Offset: 0x0040E7D4
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200374, XrefRangeEnd = 200380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C62 RID: 23650
				// (get) Token: 0x06011BE2 RID: 72674 RVA: 0x00410608 File Offset: 0x0040E808
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BE3 RID: 72675 RVA: 0x0009A345 File Offset: 0x00098545
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C5C RID: 23644
				// (get) Token: 0x06011BE4 RID: 72676 RVA: 0x00410648 File Offset: 0x0040E848
				// (set) Token: 0x06011BE5 RID: 72677 RVA: 0x0009A34E File Offset: 0x0009854E
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C5D RID: 23645
				// (get) Token: 0x06011BE6 RID: 72678 RVA: 0x00410670 File Offset: 0x0040E870
				// (set) Token: 0x06011BE7 RID: 72679 RVA: 0x0009A369 File Offset: 0x00098569
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C5E RID: 23646
				// (get) Token: 0x06011BE8 RID: 72680 RVA: 0x004106A0 File Offset: 0x0040E8A0
				// (set) Token: 0x06011BE9 RID: 72681 RVA: 0x0009A388 File Offset: 0x00098588
				public unsafe Spell_Murasa.__c__DisplayClass13_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Murasa.__c__DisplayClass13_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C5F RID: 23647
				// (get) Token: 0x06011BEA RID: 72682 RVA: 0x004106D0 File Offset: 0x0040E8D0
				// (set) Token: 0x06011BEB RID: 72683 RVA: 0x0009A3A7 File Offset: 0x000985A7
				public unsafe int _rotate_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr__rotate_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr__rotate_5__2)) = value;
					}
				}

				// Token: 0x17005C60 RID: 23648
				// (get) Token: 0x06011BEC RID: 72684 RVA: 0x004106F8 File Offset: 0x0040E8F8
				// (set) Token: 0x06011BED RID: 72685 RVA: 0x0009A3C2 File Offset: 0x000985C2
				public unsafe float _currentTime_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr__currentTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiInObObUnique.NativeFieldInfoPtr__currentTime_5__3)) = value;
					}
				}

				// Token: 0x0400B355 RID: 45909
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B356 RID: 45910
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B357 RID: 45911
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B358 RID: 45912
				private static readonly IntPtr NativeFieldInfoPtr__rotate_5__2;

				// Token: 0x0400B359 RID: 45913
				private static readonly IntPtr NativeFieldInfoPtr__currentTime_5__3;

				// Token: 0x0400B35A RID: 45914
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B35B RID: 45915
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B35C RID: 45916
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B35D RID: 45917
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B35E RID: 45918
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B35F RID: 45919
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B6C RID: 2924
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Murasa+<>c__DisplayClass13_1")]
		public sealed class __c__DisplayClass13_1 : Il2CppSystem.Object
		{
			// Token: 0x0600D76E RID: 55150 RVA: 0x00348130 File Offset: 0x00346330
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass13_1()
			{
				Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "<>c__DisplayClass13_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1>.NativeClassPtr);
				Spell_Murasa.__c__DisplayClass13_1.NativeFieldInfoPtr_dizzy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1>.NativeClassPtr, "dizzy");
				Spell_Murasa.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1>.NativeClassPtr, "CS$<>8__locals1");
				Spell_Murasa.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1>.NativeClassPtr, 100679126);
				Spell_Murasa.__c__DisplayClass13_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1>.NativeClassPtr, 100679127);
				Spell_Murasa.__c__DisplayClass13_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1>.NativeClassPtr, 100679128);
			}

			// Token: 0x0600D76F RID: 55151 RVA: 0x003481C0 File Offset: 0x003463C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass13_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D770 RID: 55152 RVA: 0x003481FC File Offset: 0x003463FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200431, XrefRangeEnd = 200436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_1.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600D771 RID: 55153 RVA: 0x0034823C File Offset: 0x0034643C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200436, XrefRangeEnd = 200442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_1.NativeMethodInfoPtr_Method_Internal_Void_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D772 RID: 55154 RVA: 0x00073469 File Offset: 0x00071669
			public __c__DisplayClass13_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004614 RID: 17940
			// (get) Token: 0x0600D773 RID: 55155 RVA: 0x00348270 File Offset: 0x00346470
			// (set) Token: 0x0600D774 RID: 55156 RVA: 0x00073472 File Offset: 0x00071672
			public unsafe GameObject dizzy
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.NativeFieldInfoPtr_dizzy);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.NativeFieldInfoPtr_dizzy), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004615 RID: 17941
			// (get) Token: 0x0600D775 RID: 55157 RVA: 0x003482A0 File Offset: 0x003464A0
			// (set) Token: 0x0600D776 RID: 55158 RVA: 0x00073491 File Offset: 0x00071691
			public unsafe Spell_Murasa.__c__DisplayClass13_0 field_Public___c__DisplayClass13_0_0
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Murasa.__c__DisplayClass13_0>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A23 RID: 35363
			private static readonly IntPtr NativeFieldInfoPtr_dizzy;

			// Token: 0x04008A24 RID: 35364
			private static readonly IntPtr NativeFieldInfoPtr_field_Public___c__DisplayClass13_0_0;

			// Token: 0x04008A25 RID: 35365
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A26 RID: 35366
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008A27 RID: 35367
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_PDM_0;

			// Token: 0x02001034 RID: 4148
			[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Murasa+<>c__DisplayClass13_1+<<OnNegativeBuffExecute>g__Follow|3>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x06011BEE RID: 72686 RVA: 0x00410720 File Offset: 0x0040E920
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1>.NativeClassPtr, "<<OnNegativeBuffExecute>g__Follow|3>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679129);
					Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679130);
					Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679131);
					Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679132);
					Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679133);
					Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100679134);
				}

				// Token: 0x06011BEF RID: 72687 RVA: 0x00410800 File Offset: 0x0040EA00
				[CallerCount(94)]
				[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BF0 RID: 72688 RVA: 0x00410848 File Offset: 0x0040EA48
				[CallerCount(13496)]
				[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x06011BF1 RID: 72689 RVA: 0x0041087C File Offset: 0x0040EA7C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200417, XrefRangeEnd = 200425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17005C66 RID: 23654
				// (get) Token: 0x06011BF2 RID: 72690 RVA: 0x004108B8 File Offset: 0x0040EAB8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BF3 RID: 72691 RVA: 0x004108F8 File Offset: 0x0040EAF8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200425, XrefRangeEnd = 200431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17005C67 RID: 23655
				// (get) Token: 0x06011BF4 RID: 72692 RVA: 0x0041092C File Offset: 0x0040EB2C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(15)]
					[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x06011BF5 RID: 72693 RVA: 0x0009A3DD File Offset: 0x000985DD
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17005C63 RID: 23651
				// (get) Token: 0x06011BF6 RID: 72694 RVA: 0x0041096C File Offset: 0x0040EB6C
				// (set) Token: 0x06011BF7 RID: 72695 RVA: 0x0009A3E6 File Offset: 0x000985E6
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17005C64 RID: 23652
				// (get) Token: 0x06011BF8 RID: 72696 RVA: 0x00410994 File Offset: 0x0040EB94
				// (set) Token: 0x06011BF9 RID: 72697 RVA: 0x0009A401 File Offset: 0x00098601
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17005C65 RID: 23653
				// (get) Token: 0x06011BFA RID: 72698 RVA: 0x004109C4 File Offset: 0x0040EBC4
				// (set) Token: 0x06011BFB RID: 72699 RVA: 0x0009A420 File Offset: 0x00098620
				public unsafe Spell_Murasa.__c__DisplayClass13_1 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Murasa.__c__DisplayClass13_1>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa.__c__DisplayClass13_1.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400B360 RID: 45920
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x0400B361 RID: 45921
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400B362 RID: 45922
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400B363 RID: 45923
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x0400B364 RID: 45924
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B365 RID: 45925
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400B366 RID: 45926
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400B367 RID: 45927
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400B368 RID: 45928
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000B6D RID: 2925
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Murasa+<>c")]
		[Serializable]
		public new sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D777 RID: 55159 RVA: 0x003482D0 File Offset: 0x003464D0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Spell_Murasa.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Murasa.__c>.NativeClassPtr);
				Spell_Murasa.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c>.NativeClassPtr, "<>9");
				Spell_Murasa.__c.NativeFieldInfoPtr___9__13_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa.__c>.NativeClassPtr, "<>9__13_1");
				Spell_Murasa.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c>.NativeClassPtr, 100679136);
				Spell_Murasa.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__13_1_Internal_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa.__c>.NativeClassPtr, 100679137);
			}

			// Token: 0x0600D778 RID: 55160 RVA: 0x0034834C File Offset: 0x0034654C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Murasa.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D779 RID: 55161 RVA: 0x00348388 File Offset: 0x00346588
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnNegativeBuffExecute_b__13_1(GameObject x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa.__c.NativeMethodInfoPtr__OnNegativeBuffExecute_b__13_1_Internal_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D77A RID: 55162 RVA: 0x000734B0 File Offset: 0x000716B0
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004616 RID: 17942
			// (get) Token: 0x0600D77B RID: 55163 RVA: 0x003483CC File Offset: 0x003465CC
			// (set) Token: 0x0600D77C RID: 55164 RVA: 0x000734B9 File Offset: 0x000716B9
			public unsafe static Spell_Murasa.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Murasa.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Murasa.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Murasa.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004617 RID: 17943
			// (get) Token: 0x0600D77D RID: 55165 RVA: 0x003483F4 File Offset: 0x003465F4
			// (set) Token: 0x0600D77E RID: 55166 RVA: 0x000734CB File Offset: 0x000716CB
			public unsafe static Action<GameObject> __9__13_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Spell_Murasa.__c.NativeFieldInfoPtr___9__13_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GameObject>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Spell_Murasa.__c.NativeFieldInfoPtr___9__13_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A28 RID: 35368
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008A29 RID: 35369
			private static readonly IntPtr NativeFieldInfoPtr___9__13_1;

			// Token: 0x04008A2A RID: 35370
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008A2B RID: 35371
			private static readonly IntPtr NativeMethodInfoPtr__OnNegativeBuffExecute_b__13_1_Internal_Void_GameObject_0;
		}

		// Token: 0x02000B6E RID: 2926
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Murasa+<OnNegativeBuffExecute>d__13")]
		public sealed class _OnNegativeBuffExecute_d__13 : Il2CppSystem.Object
		{
			// Token: 0x0600D77F RID: 55167 RVA: 0x0034841C File Offset: 0x0034661C
			// Note: this type is marked as 'beforefieldinit'.
			static _OnNegativeBuffExecute_d__13()
			{
				Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "<OnNegativeBuffExecute>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr);
				Spell_Murasa._OnNegativeBuffExecute_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr, "<>1__state");
				Spell_Murasa._OnNegativeBuffExecute_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr, "<>2__current");
				Spell_Murasa._OnNegativeBuffExecute_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr, "<>4__this");
				Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr, 100679138);
				Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr, 100679139);
				Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr, 100679140);
				Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr, 100679141);
				Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr, 100679142);
				Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr, 100679143);
			}

			// Token: 0x0600D780 RID: 55168 RVA: 0x003484FC File Offset: 0x003466FC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnNegativeBuffExecute_d__13(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Murasa._OnNegativeBuffExecute_d__13>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D781 RID: 55169 RVA: 0x00348544 File Offset: 0x00346744
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D782 RID: 55170 RVA: 0x00348578 File Offset: 0x00346778
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200442, XrefRangeEnd = 200486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x1700461B RID: 17947
			// (get) Token: 0x0600D783 RID: 55171 RVA: 0x003485B4 File Offset: 0x003467B4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D784 RID: 55172 RVA: 0x003485F4 File Offset: 0x003467F4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200486, XrefRangeEnd = 200492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700461C RID: 17948
			// (get) Token: 0x0600D785 RID: 55173 RVA: 0x00348628 File Offset: 0x00346828
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D786 RID: 55174 RVA: 0x000734DD File Offset: 0x000716DD
			public _OnNegativeBuffExecute_d__13(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004618 RID: 17944
			// (get) Token: 0x0600D787 RID: 55175 RVA: 0x00348668 File Offset: 0x00346868
			// (set) Token: 0x0600D788 RID: 55176 RVA: 0x000734E6 File Offset: 0x000716E6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004619 RID: 17945
			// (get) Token: 0x0600D789 RID: 55177 RVA: 0x00348690 File Offset: 0x00346890
			// (set) Token: 0x0600D78A RID: 55178 RVA: 0x00073501 File Offset: 0x00071701
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700461A RID: 17946
			// (get) Token: 0x0600D78B RID: 55179 RVA: 0x003486C0 File Offset: 0x003468C0
			// (set) Token: 0x0600D78C RID: 55180 RVA: 0x00073520 File Offset: 0x00071720
			public unsafe Spell_Murasa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Murasa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnNegativeBuffExecute_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A2C RID: 35372
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A2D RID: 35373
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A2E RID: 35374
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A2F RID: 35375
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A30 RID: 35376
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A31 RID: 35377
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A32 RID: 35378
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A33 RID: 35379
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A34 RID: 35380
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B6F RID: 2927
		[ObfuscatedName("GameData.Core.Collections.NightSceneUtility.SkillCollection.Spell_Murasa+<OnPositiveBuffExecute>d__14")]
		public sealed class _OnPositiveBuffExecute_d__14 : Il2CppSystem.Object
		{
			// Token: 0x0600D78D RID: 55181 RVA: 0x003486F0 File Offset: 0x003468F0
			// Note: this type is marked as 'beforefieldinit'.
			static _OnPositiveBuffExecute_d__14()
			{
				Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Spell_Murasa>.NativeClassPtr, "<OnPositiveBuffExecute>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr);
				Spell_Murasa._OnPositiveBuffExecute_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr, "<>1__state");
				Spell_Murasa._OnPositiveBuffExecute_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr, "<>2__current");
				Spell_Murasa._OnPositiveBuffExecute_d__14.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr, "<>4__this");
				Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr, 100679144);
				Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr, 100679145);
				Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr, 100679146);
				Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr, 100679147);
				Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr, 100679148);
				Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr, 100679149);
			}

			// Token: 0x0600D78E RID: 55182 RVA: 0x003487D0 File Offset: 0x003469D0
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _OnPositiveBuffExecute_d__14(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Spell_Murasa._OnPositiveBuffExecute_d__14>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D78F RID: 55183 RVA: 0x00348818 File Offset: 0x00346A18
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D790 RID: 55184 RVA: 0x0034884C File Offset: 0x00346A4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200492, XrefRangeEnd = 200505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17004620 RID: 17952
			// (get) Token: 0x0600D791 RID: 55185 RVA: 0x00348888 File Offset: 0x00346A88
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D792 RID: 55186 RVA: 0x003488C8 File Offset: 0x00346AC8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 200505, XrefRangeEnd = 200511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17004621 RID: 17953
			// (get) Token: 0x0600D793 RID: 55187 RVA: 0x003488FC File Offset: 0x00346AFC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D794 RID: 55188 RVA: 0x0007353F File Offset: 0x0007173F
			public _OnPositiveBuffExecute_d__14(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700461D RID: 17949
			// (get) Token: 0x0600D795 RID: 55189 RVA: 0x0034893C File Offset: 0x00346B3C
			// (set) Token: 0x0600D796 RID: 55190 RVA: 0x00073548 File Offset: 0x00071748
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700461E RID: 17950
			// (get) Token: 0x0600D797 RID: 55191 RVA: 0x00348964 File Offset: 0x00346B64
			// (set) Token: 0x0600D798 RID: 55192 RVA: 0x00073563 File Offset: 0x00071763
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700461F RID: 17951
			// (get) Token: 0x0600D799 RID: 55193 RVA: 0x00348994 File Offset: 0x00346B94
			// (set) Token: 0x0600D79A RID: 55194 RVA: 0x00073582 File Offset: 0x00071782
			public unsafe Spell_Murasa __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Spell_Murasa>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Spell_Murasa._OnPositiveBuffExecute_d__14.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008A35 RID: 35381
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008A36 RID: 35382
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008A37 RID: 35383
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008A38 RID: 35384
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008A39 RID: 35385
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A3A RID: 35386
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008A3B RID: 35387
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008A3C RID: 35388
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008A3D RID: 35389
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
