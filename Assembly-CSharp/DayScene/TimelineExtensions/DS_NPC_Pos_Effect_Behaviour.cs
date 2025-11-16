using System;
using Common.TimelineExtestion;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace DayScene.TimelineExtensions
{
	// Token: 0x02000141 RID: 321
	public class DS_NPC_Pos_Effect_Behaviour : ExtendedPlayableBehaviour
	{
		// Token: 0x0600263F RID: 9791 RVA: 0x0011EB20 File Offset: 0x0011CD20
		// Note: this type is marked as 'beforefieldinit'.
		static DS_NPC_Pos_Effect_Behaviour()
		{
			Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.TimelineExtensions", "DS_NPC_Pos_Effect_Behaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr);
			DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_CharacterLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, "m_CharacterLabel");
			DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_CharacterSetDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, "m_CharacterSetDelay");
			DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectDestroyDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, "m_EffectDestroyDelay");
			DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, "m_EffectLabel");
			DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectPositionOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, "m_EffectPositionOffset");
			DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, "m_EffectPrefab");
			DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectTransitionDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, "m_EffectTransitionDuration");
			DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_ShouldWaitForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, "m_ShouldWaitForFinish");
			DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_Initialize_Public_Void_String_Single_Boolean_String_GameObject_Vector2_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, 100670172);
			DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_TryGetCharacterPosition_Protected_Virtual_New_Boolean_byref_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, 100670173);
			DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, 100670174);
			DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_Execute_Protected_Virtual_New_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, 100670175);
			DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_DestroyEffect_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, 100670176);
			DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, 100670177);
			DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__10_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, 100670178);
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x0011EC7C File Offset: 0x0011CE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90181, XrefRangeEnd = 90184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string characterLabel, float characterSetDelay, bool shouldWaitForFinish, string effectLabel, GameObject effectPrefab, Vector2 effectPositionOffset, float effectDestroyDelay, float effectTransitionDuration = 1f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref characterSetDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldWaitForFinish;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(effectLabel);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(effectPrefab);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref effectPositionOffset;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref effectDestroyDelay;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref effectTransitionDuration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_Initialize_Public_Void_String_Single_Boolean_String_GameObject_Vector2_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x0011ED2C File Offset: 0x0011CF2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90184, XrefRangeEnd = 90185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool TryGetCharacterPosition(out Vector2 position)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &position;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_TryGetCharacterPosition_Protected_Virtual_New_Boolean_byref_Vector2_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x0011ED80 File Offset: 0x0011CF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90185, XrefRangeEnd = 90208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnBehaviourEnter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x0011EDBC File Offset: 0x0011CFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90208, XrefRangeEnd = 90209, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Execute(string characterLabel, bool timeContinue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(characterLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeContinue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_Execute_Protected_Virtual_New_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x0011EE18 File Offset: 0x0011D018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90209, XrefRangeEnd = 90214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DestroyEffect()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr_DestroyEffect_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x0011EE58 File Offset: 0x0011D058
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90156, RefRangeEnd = 90158, XrefRangeStart = 90156, XrefRangeEnd = 90158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DS_NPC_Pos_Effect_Behaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x0011EE94 File Offset: 0x0011D094
		[CallerCount(0)]
		public unsafe void _OnBehaviourEnter_b__10_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour.NativeMethodInfoPtr__OnBehaviourEnter_b__10_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00016920 File Offset: 0x00014B20
		public DS_NPC_Pos_Effect_Behaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002648 RID: 9800 RVA: 0x0011EEC8 File Offset: 0x0011D0C8
		// (set) Token: 0x06002649 RID: 9801 RVA: 0x00016929 File Offset: 0x00014B29
		public unsafe string m_CharacterLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_CharacterLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_CharacterLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x0600264A RID: 9802 RVA: 0x0011EEF0 File Offset: 0x0011D0F0
		// (set) Token: 0x0600264B RID: 9803 RVA: 0x00016948 File Offset: 0x00014B48
		public unsafe float m_CharacterSetDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_CharacterSetDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_CharacterSetDelay)) = value;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x0600264C RID: 9804 RVA: 0x0011EF18 File Offset: 0x0011D118
		// (set) Token: 0x0600264D RID: 9805 RVA: 0x00016963 File Offset: 0x00014B63
		public unsafe float m_EffectDestroyDelay
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectDestroyDelay);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectDestroyDelay)) = value;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x0600264E RID: 9806 RVA: 0x0011EF40 File Offset: 0x0011D140
		// (set) Token: 0x0600264F RID: 9807 RVA: 0x0001697E File Offset: 0x00014B7E
		public unsafe string m_EffectLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002650 RID: 9808 RVA: 0x0011EF68 File Offset: 0x0011D168
		// (set) Token: 0x06002651 RID: 9809 RVA: 0x0001699D File Offset: 0x00014B9D
		public unsafe Vector2 m_EffectPositionOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectPositionOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectPositionOffset)) = value;
			}
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x06002652 RID: 9810 RVA: 0x0011EF90 File Offset: 0x0011D190
		// (set) Token: 0x06002653 RID: 9811 RVA: 0x000169B8 File Offset: 0x00014BB8
		public unsafe GameObject m_EffectPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002654 RID: 9812 RVA: 0x0011EFC0 File Offset: 0x0011D1C0
		// (set) Token: 0x06002655 RID: 9813 RVA: 0x000169D7 File Offset: 0x00014BD7
		public unsafe float m_EffectTransitionDuration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectTransitionDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_EffectTransitionDuration)) = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002656 RID: 9814 RVA: 0x0011EFE8 File Offset: 0x0011D1E8
		// (set) Token: 0x06002657 RID: 9815 RVA: 0x000169F2 File Offset: 0x00014BF2
		public unsafe bool m_ShouldWaitForFinish
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_ShouldWaitForFinish);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour.NativeFieldInfoPtr_m_ShouldWaitForFinish)) = value;
			}
		}

		// Token: 0x04001988 RID: 6536
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterLabel;

		// Token: 0x04001989 RID: 6537
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterSetDelay;

		// Token: 0x0400198A RID: 6538
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectDestroyDelay;

		// Token: 0x0400198B RID: 6539
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectLabel;

		// Token: 0x0400198C RID: 6540
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectPositionOffset;

		// Token: 0x0400198D RID: 6541
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectPrefab;

		// Token: 0x0400198E RID: 6542
		private static readonly IntPtr NativeFieldInfoPtr_m_EffectTransitionDuration;

		// Token: 0x0400198F RID: 6543
		private static readonly IntPtr NativeFieldInfoPtr_m_ShouldWaitForFinish;

		// Token: 0x04001990 RID: 6544
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_Single_Boolean_String_GameObject_Vector2_Single_Single_0;

		// Token: 0x04001991 RID: 6545
		private static readonly IntPtr NativeMethodInfoPtr_TryGetCharacterPosition_Protected_Virtual_New_Boolean_byref_Vector2_0;

		// Token: 0x04001992 RID: 6546
		private static readonly IntPtr NativeMethodInfoPtr_OnBehaviourEnter_Protected_Virtual_Void_0;

		// Token: 0x04001993 RID: 6547
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Protected_Virtual_New_Void_String_Boolean_0;

		// Token: 0x04001994 RID: 6548
		private static readonly IntPtr NativeMethodInfoPtr_DestroyEffect_Private_IEnumerator_0;

		// Token: 0x04001995 RID: 6549
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001996 RID: 6550
		private static readonly IntPtr NativeMethodInfoPtr__OnBehaviourEnter_b__10_0_Private_Void_0;

		// Token: 0x02000781 RID: 1921
		[ObfuscatedName("DayScene.TimelineExtensions.DS_NPC_Pos_Effect_Behaviour+<DestroyEffect>d__12")]
		public sealed class _DestroyEffect_d__12 : Il2CppSystem.Object
		{
			// Token: 0x0600A2C4 RID: 41668 RVA: 0x002ABBFC File Offset: 0x002A9DFC
			// Note: this type is marked as 'beforefieldinit'.
			static _DestroyEffect_d__12()
			{
				Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour>.NativeClassPtr, "<DestroyEffect>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr);
				DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr, "<>1__state");
				DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr, "<>2__current");
				DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr, "<>4__this");
				DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr, 100670179);
				DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr, 100670180);
				DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr, 100670181);
				DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr, 100670182);
				DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr, 100670183);
				DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr, 100670184);
			}

			// Token: 0x0600A2C5 RID: 41669 RVA: 0x002ABCDC File Offset: 0x002A9EDC
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DestroyEffect_d__12(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2C6 RID: 41670 RVA: 0x002ABD24 File Offset: 0x002A9F24
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A2C7 RID: 41671 RVA: 0x002ABD58 File Offset: 0x002A9F58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90169, XrefRangeEnd = 90175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170035BB RID: 13755
			// (get) Token: 0x0600A2C8 RID: 41672 RVA: 0x002ABD94 File Offset: 0x002A9F94
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A2C9 RID: 41673 RVA: 0x002ABDD4 File Offset: 0x002A9FD4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90175, XrefRangeEnd = 90181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170035BC RID: 13756
			// (get) Token: 0x0600A2CA RID: 41674 RVA: 0x002ABE08 File Offset: 0x002AA008
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A2CB RID: 41675 RVA: 0x00057F0E File Offset: 0x0005610E
			public _DestroyEffect_d__12(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170035B8 RID: 13752
			// (get) Token: 0x0600A2CC RID: 41676 RVA: 0x002ABE48 File Offset: 0x002AA048
			// (set) Token: 0x0600A2CD RID: 41677 RVA: 0x00057F17 File Offset: 0x00056117
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170035B9 RID: 13753
			// (get) Token: 0x0600A2CE RID: 41678 RVA: 0x002ABE70 File Offset: 0x002AA070
			// (set) Token: 0x0600A2CF RID: 41679 RVA: 0x00057F32 File Offset: 0x00056132
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170035BA RID: 13754
			// (get) Token: 0x0600A2D0 RID: 41680 RVA: 0x002ABEA0 File Offset: 0x002AA0A0
			// (set) Token: 0x0600A2D1 RID: 41681 RVA: 0x00057F51 File Offset: 0x00056151
			public unsafe DS_NPC_Pos_Effect_Behaviour __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DS_NPC_Pos_Effect_Behaviour>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DS_NPC_Pos_Effect_Behaviour._DestroyEffect_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006965 RID: 26981
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006966 RID: 26982
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006967 RID: 26983
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006968 RID: 26984
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006969 RID: 26985
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400696A RID: 26986
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400696B RID: 26987
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400696C RID: 26988
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400696D RID: 26989
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
