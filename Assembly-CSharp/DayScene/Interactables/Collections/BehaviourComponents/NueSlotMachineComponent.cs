using System;
using DayScene.UI;
using DEYU.UniversalUISystem;
using GameData.Core.Collections;
using GameData.Core.Collections.NightSceneUtility.SkillCollection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000198 RID: 408
	public class NueSlotMachineComponent : EntityBehaviourComponent
	{
		// Token: 0x06002B91 RID: 11153 RVA: 0x0012F3BC File Offset: 0x0012D5BC
		// Note: this type is marked as 'beforefieldinit'.
		static NueSlotMachineComponent()
		{
			Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "NueSlotMachineComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr);
			NueSlotMachineComponent.NativeFieldInfoPtr_offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "offset");
			NueSlotMachineComponent.NativeFieldInfoPtr_priceTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "priceTag");
			NueSlotMachineComponent.NativeFieldInfoPtr_MachineOutline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "MachineOutline");
			NueSlotMachineComponent.NativeFieldInfoPtr_slotMachineSprite2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "slotMachineSprite2");
			NueSlotMachineComponent.NativeFieldInfoPtr_waitSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "waitSeconds");
			NueSlotMachineComponent.NativeFieldInfoPtr_colorUFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "colorUFO");
			NueSlotMachineComponent.NativeFieldInfoPtr_UFO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "UFO");
			NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "BingoEffect");
			NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffectR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "BingoEffectR");
			NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffectG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "BingoEffectG");
			NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffectB = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "BingoEffectB");
			NueSlotMachineComponent.NativeFieldInfoPtr_NotBingoEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "NotBingoEffect");
			NueSlotMachineComponent.NativeFieldInfoPtr_reward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "reward");
			NueSlotMachineComponent.NativeFieldInfoPtr_interactCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "interactCount");
			NueSlotMachineComponent.NativeFieldInfoPtr_costMoneyClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "costMoneyClip");
			NueSlotMachineComponent.NativeFieldInfoPtr_goodRewardClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "goodRewardClip");
			NueSlotMachineComponent.NativeFieldInfoPtr_badRewardClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "badRewardClip");
			NueSlotMachineComponent.NativeFieldInfoPtr_RGBMeatNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "RGBMeatNum");
			NueSlotMachineComponent.NativeFieldInfoPtr_RGBVegNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "RGBVegNum");
			NueSlotMachineComponent.NativeFieldInfoPtr_bevPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "bevPercentage");
			NueSlotMachineComponent.NativeFieldInfoPtr_bevReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "bevReward");
			NueSlotMachineComponent.NativeFieldInfoPtr_bevs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "bevs");
			NueSlotMachineComponent.NativeFieldInfoPtr_cluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "cluster");
			NueSlotMachineComponent.NativeFieldInfoPtr_ingredientPercentage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "ingredientPercentage");
			NueSlotMachineComponent.NativeFieldInfoPtr_ingredientReward = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "ingredientReward");
			NueSlotMachineComponent.NativeFieldInfoPtr_ings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "ings");
			NueSlotMachineComponent.NativeFieldInfoPtr_moduleID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "moduleID");
			NueSlotMachineComponent.NativeFieldInfoPtr_rewardNum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "rewardNum");
			NueSlotMachineComponent.NativeMethodInfoPtr_get_CurrentSlotPrice_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670913);
			NueSlotMachineComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670914);
			NueSlotMachineComponent.NativeMethodInfoPtr_TryButton_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670915);
			NueSlotMachineComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670916);
			NueSlotMachineComponent.NativeMethodInfoPtr_SetSprites_Private_Void_ColorType_ParticleSystem_TrailRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670917);
			NueSlotMachineComponent.NativeMethodInfoPtr_TrySlot_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670918);
			NueSlotMachineComponent.NativeMethodInfoPtr_GiveItem_Private_Void_HashSet_1_ColorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670919);
			NueSlotMachineComponent.NativeMethodInfoPtr_SelectReward_Private_Int32_NueRewardPair_NueUFORewardType_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670920);
			NueSlotMachineComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670921);
			NueSlotMachineComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670922);
			NueSlotMachineComponent.NativeMethodInfoPtr__OnInteract_b__32_0_Private_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, 100670923);
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06002B92 RID: 11154 RVA: 0x0012F6F8 File Offset: 0x0012D8F8
		public unsafe int CurrentSlotPrice
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98157, XrefRangeEnd = 98162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.NativeMethodInfoPtr_get_CurrentSlotPrice_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002B93 RID: 11155 RVA: 0x0012F734 File Offset: 0x0012D934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98162, XrefRangeEnd = 98179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NueSlotMachineComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B94 RID: 11156 RVA: 0x0012F770 File Offset: 0x0012D970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98179, XrefRangeEnd = 98222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TryButton(DaySceneChatSelectionPannel.BaseInteractData baseInteractData, out string title, out bool availability, out Action onInteract)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(baseInteractData);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &availability;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.NativeMethodInfoPtr_TryButton_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			title = IL2CPP.Il2CppStringToManaged(intPtr);
			IntPtr intPtr5 = intPtr2;
			onInteract = ((intPtr5 == 0) ? null : new Action(intPtr5));
		}

		// Token: 0x06002B95 RID: 11157 RVA: 0x0012F800 File Offset: 0x0012DA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98222, XrefRangeEnd = 98233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NueSlotMachineComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x0012F83C File Offset: 0x0012DA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98233, XrefRangeEnd = 98249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSprites(Spell_Nue.ColorType color, ParticleSystem particle, TrailRenderer trailRenderer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trailRenderer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.NativeMethodInfoPtr_SetSprites_Private_Void_ColorType_ParticleSystem_TrailRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B97 RID: 11159 RVA: 0x0012F8A0 File Offset: 0x0012DAA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98249, XrefRangeEnd = 98254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator TrySlot()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.NativeMethodInfoPtr_TrySlot_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06002B98 RID: 11160 RVA: 0x0012F8E0 File Offset: 0x0012DAE0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98298, RefRangeEnd = 98299, XrefRangeStart = 98254, XrefRangeEnd = 98298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GiveItem(HashSet<Spell_Nue.ColorType> colors)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(colors);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.NativeMethodInfoPtr_GiveItem_Private_Void_HashSet_1_ColorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B99 RID: 11161 RVA: 0x0012F924 File Offset: 0x0012DB24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 98484, RefRangeEnd = 98485, XrefRangeStart = 98299, XrefRangeEnd = 98484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int SelectReward(NueRewardPair rewardPair, NueUFORewardType rewardType, bool isOther)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rewardPair;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rewardType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isOther;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.NativeMethodInfoPtr_SelectReward_Private_Int32_NueRewardPair_NueUFORewardType_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002B9A RID: 11162 RVA: 0x0012F98C File Offset: 0x0012DB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98485, XrefRangeEnd = 98507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NueSlotMachineComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B9B RID: 11163 RVA: 0x0012F9C8 File Offset: 0x0012DBC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98507, XrefRangeEnd = 98508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NueSlotMachineComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B9C RID: 11164 RVA: 0x0012FA04 File Offset: 0x0012DC04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98508, XrefRangeEnd = 98509, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _OnInteract_b__32_0(Action x)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.NativeMethodInfoPtr__OnInteract_b__32_0_Private_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B9D RID: 11165 RVA: 0x0001955E File Offset: 0x0001775E
		public NueSlotMachineComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x06002B9E RID: 11166 RVA: 0x0012FA48 File Offset: 0x0012DC48
		// (set) Token: 0x06002B9F RID: 11167 RVA: 0x00019567 File Offset: 0x00017767
		public unsafe Vector3 offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_offset)) = value;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x06002BA0 RID: 11168 RVA: 0x0012FA70 File Offset: 0x0012DC70
		// (set) Token: 0x06002BA1 RID: 11169 RVA: 0x00019582 File Offset: 0x00017782
		public unsafe GameObject priceTag
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_priceTag);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_priceTag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x0012FAA0 File Offset: 0x0012DCA0
		// (set) Token: 0x06002BA3 RID: 11171 RVA: 0x000195A1 File Offset: 0x000177A1
		public unsafe SpriteRenderer MachineOutline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_MachineOutline);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_MachineOutline), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x06002BA4 RID: 11172 RVA: 0x0012FAD0 File Offset: 0x0012DCD0
		// (set) Token: 0x06002BA5 RID: 11173 RVA: 0x000195C0 File Offset: 0x000177C0
		public unsafe Sprite slotMachineSprite2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_slotMachineSprite2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_slotMachineSprite2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x0012FB00 File Offset: 0x0012DD00
		// (set) Token: 0x06002BA7 RID: 11175 RVA: 0x000195DF File Offset: 0x000177DF
		public unsafe float waitSeconds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_waitSeconds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_waitSeconds)) = value;
			}
		}

		// Token: 0x17000EE4 RID: 3812
		// (get) Token: 0x06002BA8 RID: 11176 RVA: 0x0012FB28 File Offset: 0x0012DD28
		// (set) Token: 0x06002BA9 RID: 11177 RVA: 0x000195FA File Offset: 0x000177FA
		public unsafe Il2CppReferenceArray<Spell_Nue.ColorUFO> colorUFO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_colorUFO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Spell_Nue.ColorUFO>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_colorUFO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE5 RID: 3813
		// (get) Token: 0x06002BAA RID: 11178 RVA: 0x0012FB58 File Offset: 0x0012DD58
		// (set) Token: 0x06002BAB RID: 11179 RVA: 0x00019619 File Offset: 0x00017819
		public unsafe GameObject UFO
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_UFO);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_UFO), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE6 RID: 3814
		// (get) Token: 0x06002BAC RID: 11180 RVA: 0x0012FB88 File Offset: 0x0012DD88
		// (set) Token: 0x06002BAD RID: 11181 RVA: 0x00019638 File Offset: 0x00017838
		public unsafe GameObject BingoEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE7 RID: 3815
		// (get) Token: 0x06002BAE RID: 11182 RVA: 0x0012FBB8 File Offset: 0x0012DDB8
		// (set) Token: 0x06002BAF RID: 11183 RVA: 0x00019657 File Offset: 0x00017857
		public unsafe GameObject BingoEffectR
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffectR);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffectR), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE8 RID: 3816
		// (get) Token: 0x06002BB0 RID: 11184 RVA: 0x0012FBE8 File Offset: 0x0012DDE8
		// (set) Token: 0x06002BB1 RID: 11185 RVA: 0x00019676 File Offset: 0x00017876
		public unsafe GameObject BingoEffectG
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffectG);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffectG), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EE9 RID: 3817
		// (get) Token: 0x06002BB2 RID: 11186 RVA: 0x0012FC18 File Offset: 0x0012DE18
		// (set) Token: 0x06002BB3 RID: 11187 RVA: 0x00019695 File Offset: 0x00017895
		public unsafe GameObject BingoEffectB
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffectB);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_BingoEffectB), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEA RID: 3818
		// (get) Token: 0x06002BB4 RID: 11188 RVA: 0x0012FC48 File Offset: 0x0012DE48
		// (set) Token: 0x06002BB5 RID: 11189 RVA: 0x000196B4 File Offset: 0x000178B4
		public unsafe GameObject NotBingoEffect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_NotBingoEffect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_NotBingoEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEB RID: 3819
		// (get) Token: 0x06002BB6 RID: 11190 RVA: 0x0012FC78 File Offset: 0x0012DE78
		// (set) Token: 0x06002BB7 RID: 11191 RVA: 0x000196D3 File Offset: 0x000178D3
		public unsafe Il2CppReferenceArray<NueUFORewardMatch> reward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_reward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<NueUFORewardMatch>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_reward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEC RID: 3820
		// (get) Token: 0x06002BB8 RID: 11192 RVA: 0x0012FCA8 File Offset: 0x0012DEA8
		// (set) Token: 0x06002BB9 RID: 11193 RVA: 0x000196F2 File Offset: 0x000178F2
		public unsafe int interactCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_interactCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_interactCount)) = value;
			}
		}

		// Token: 0x17000EED RID: 3821
		// (get) Token: 0x06002BBA RID: 11194 RVA: 0x0012FCD0 File Offset: 0x0012DED0
		// (set) Token: 0x06002BBB RID: 11195 RVA: 0x0001970D File Offset: 0x0001790D
		public unsafe AudioClip costMoneyClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_costMoneyClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_costMoneyClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEE RID: 3822
		// (get) Token: 0x06002BBC RID: 11196 RVA: 0x0012FD00 File Offset: 0x0012DF00
		// (set) Token: 0x06002BBD RID: 11197 RVA: 0x0001972C File Offset: 0x0001792C
		public unsafe AudioClip goodRewardClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_goodRewardClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_goodRewardClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x06002BBE RID: 11198 RVA: 0x0012FD30 File Offset: 0x0012DF30
		// (set) Token: 0x06002BBF RID: 11199 RVA: 0x0001974B File Offset: 0x0001794B
		public unsafe AudioClip badRewardClip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_badRewardClip);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_badRewardClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x0012FD60 File Offset: 0x0012DF60
		// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x0001976A File Offset: 0x0001796A
		public unsafe int RGBMeatNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_RGBMeatNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_RGBMeatNum)) = value;
			}
		}

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x0012FD88 File Offset: 0x0012DF88
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x00019785 File Offset: 0x00017985
		public unsafe int RGBVegNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_RGBVegNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_RGBVegNum)) = value;
			}
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x06002BC4 RID: 11204 RVA: 0x0012FDB0 File Offset: 0x0012DFB0
		// (set) Token: 0x06002BC5 RID: 11205 RVA: 0x000197A0 File Offset: 0x000179A0
		public unsafe Il2CppStructArray<int> bevPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_bevPercentage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_bevPercentage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x06002BC6 RID: 11206 RVA: 0x0012FDE0 File Offset: 0x0012DFE0
		// (set) Token: 0x06002BC7 RID: 11207 RVA: 0x000197BF File Offset: 0x000179BF
		public unsafe Il2CppStructArray<NueRewardPair> bevReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_bevReward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<NueRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_bevReward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x06002BC8 RID: 11208 RVA: 0x0012FE10 File Offset: 0x0012E010
		// (set) Token: 0x06002BC9 RID: 11209 RVA: 0x000197DE File Offset: 0x000179DE
		public unsafe List<int> bevs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_bevs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_bevs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06002BCA RID: 11210 RVA: 0x0012FE40 File Offset: 0x0012E040
		// (set) Token: 0x06002BCB RID: 11211 RVA: 0x000197FD File Offset: 0x000179FD
		public unsafe UIElementCluster cluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_cluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_cluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06002BCC RID: 11212 RVA: 0x0012FE70 File Offset: 0x0012E070
		// (set) Token: 0x06002BCD RID: 11213 RVA: 0x0001981C File Offset: 0x00017A1C
		public unsafe Il2CppStructArray<int> ingredientPercentage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_ingredientPercentage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_ingredientPercentage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06002BCE RID: 11214 RVA: 0x0012FEA0 File Offset: 0x0012E0A0
		// (set) Token: 0x06002BCF RID: 11215 RVA: 0x0001983B File Offset: 0x00017A3B
		public unsafe Il2CppStructArray<NueRewardPair> ingredientReward
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_ingredientReward);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<NueRewardPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_ingredientReward), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06002BD0 RID: 11216 RVA: 0x0012FED0 File Offset: 0x0012E0D0
		// (set) Token: 0x06002BD1 RID: 11217 RVA: 0x0001985A File Offset: 0x00017A5A
		public unsafe List<int> ings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_ings);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_ings), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06002BD2 RID: 11218 RVA: 0x0012FF00 File Offset: 0x0012E100
		// (set) Token: 0x06002BD3 RID: 11219 RVA: 0x00019879 File Offset: 0x00017A79
		public unsafe string moduleID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_moduleID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_moduleID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x0012FF28 File Offset: 0x0012E128
		// (set) Token: 0x06002BD5 RID: 11221 RVA: 0x00019898 File Offset: 0x00017A98
		public unsafe int rewardNum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_rewardNum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.NativeFieldInfoPtr_rewardNum)) = value;
			}
		}

		// Token: 0x04001CDD RID: 7389
		private static readonly IntPtr NativeFieldInfoPtr_offset;

		// Token: 0x04001CDE RID: 7390
		private static readonly IntPtr NativeFieldInfoPtr_priceTag;

		// Token: 0x04001CDF RID: 7391
		private static readonly IntPtr NativeFieldInfoPtr_MachineOutline;

		// Token: 0x04001CE0 RID: 7392
		private static readonly IntPtr NativeFieldInfoPtr_slotMachineSprite2;

		// Token: 0x04001CE1 RID: 7393
		private static readonly IntPtr NativeFieldInfoPtr_waitSeconds;

		// Token: 0x04001CE2 RID: 7394
		private static readonly IntPtr NativeFieldInfoPtr_colorUFO;

		// Token: 0x04001CE3 RID: 7395
		private static readonly IntPtr NativeFieldInfoPtr_UFO;

		// Token: 0x04001CE4 RID: 7396
		private static readonly IntPtr NativeFieldInfoPtr_BingoEffect;

		// Token: 0x04001CE5 RID: 7397
		private static readonly IntPtr NativeFieldInfoPtr_BingoEffectR;

		// Token: 0x04001CE6 RID: 7398
		private static readonly IntPtr NativeFieldInfoPtr_BingoEffectG;

		// Token: 0x04001CE7 RID: 7399
		private static readonly IntPtr NativeFieldInfoPtr_BingoEffectB;

		// Token: 0x04001CE8 RID: 7400
		private static readonly IntPtr NativeFieldInfoPtr_NotBingoEffect;

		// Token: 0x04001CE9 RID: 7401
		private static readonly IntPtr NativeFieldInfoPtr_reward;

		// Token: 0x04001CEA RID: 7402
		private static readonly IntPtr NativeFieldInfoPtr_interactCount;

		// Token: 0x04001CEB RID: 7403
		private static readonly IntPtr NativeFieldInfoPtr_costMoneyClip;

		// Token: 0x04001CEC RID: 7404
		private static readonly IntPtr NativeFieldInfoPtr_goodRewardClip;

		// Token: 0x04001CED RID: 7405
		private static readonly IntPtr NativeFieldInfoPtr_badRewardClip;

		// Token: 0x04001CEE RID: 7406
		private static readonly IntPtr NativeFieldInfoPtr_RGBMeatNum;

		// Token: 0x04001CEF RID: 7407
		private static readonly IntPtr NativeFieldInfoPtr_RGBVegNum;

		// Token: 0x04001CF0 RID: 7408
		private static readonly IntPtr NativeFieldInfoPtr_bevPercentage;

		// Token: 0x04001CF1 RID: 7409
		private static readonly IntPtr NativeFieldInfoPtr_bevReward;

		// Token: 0x04001CF2 RID: 7410
		private static readonly IntPtr NativeFieldInfoPtr_bevs;

		// Token: 0x04001CF3 RID: 7411
		private static readonly IntPtr NativeFieldInfoPtr_cluster;

		// Token: 0x04001CF4 RID: 7412
		private static readonly IntPtr NativeFieldInfoPtr_ingredientPercentage;

		// Token: 0x04001CF5 RID: 7413
		private static readonly IntPtr NativeFieldInfoPtr_ingredientReward;

		// Token: 0x04001CF6 RID: 7414
		private static readonly IntPtr NativeFieldInfoPtr_ings;

		// Token: 0x04001CF7 RID: 7415
		private static readonly IntPtr NativeFieldInfoPtr_moduleID;

		// Token: 0x04001CF8 RID: 7416
		private static readonly IntPtr NativeFieldInfoPtr_rewardNum;

		// Token: 0x04001CF9 RID: 7417
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentSlotPrice_Private_get_Int32_0;

		// Token: 0x04001CFA RID: 7418
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001CFB RID: 7419
		private static readonly IntPtr NativeMethodInfoPtr_TryButton_Private_Void_BaseInteractData_byref_String_byref_Boolean_byref_Action_0;

		// Token: 0x04001CFC RID: 7420
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001CFD RID: 7421
		private static readonly IntPtr NativeMethodInfoPtr_SetSprites_Private_Void_ColorType_ParticleSystem_TrailRenderer_0;

		// Token: 0x04001CFE RID: 7422
		private static readonly IntPtr NativeMethodInfoPtr_TrySlot_Private_IEnumerator_0;

		// Token: 0x04001CFF RID: 7423
		private static readonly IntPtr NativeMethodInfoPtr_GiveItem_Private_Void_HashSet_1_ColorType_0;

		// Token: 0x04001D00 RID: 7424
		private static readonly IntPtr NativeMethodInfoPtr_SelectReward_Private_Int32_NueRewardPair_NueUFORewardType_Boolean_0;

		// Token: 0x04001D01 RID: 7425
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001D02 RID: 7426
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001D03 RID: 7427
		private static readonly IntPtr NativeMethodInfoPtr__OnInteract_b__32_0_Private_Void_Action_0;

		// Token: 0x020007DF RID: 2015
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NueSlotMachineComponent+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A6E3 RID: 42723 RVA: 0x002B752C File Offset: 0x002B572C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass31_0>.NativeClassPtr);
				NueSlotMachineComponent.__c__DisplayClass31_0.NativeFieldInfoPtr_baseInteractData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass31_0>.NativeClassPtr, "baseInteractData");
				NueSlotMachineComponent.__c__DisplayClass31_0.NativeFieldInfoPtr_hasEnoughMoney = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass31_0>.NativeClassPtr, "hasEnoughMoney");
				NueSlotMachineComponent.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				NueSlotMachineComponent.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass31_0>.NativeClassPtr, 100670924);
				NueSlotMachineComponent.__c__DisplayClass31_0.NativeMethodInfoPtr__TryButton_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass31_0>.NativeClassPtr, 100670925);
			}

			// Token: 0x0600A6E4 RID: 42724 RVA: 0x002B75BC File Offset: 0x002B57BC
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass31_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6E5 RID: 42725 RVA: 0x002B75F8 File Offset: 0x002B57F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98032, XrefRangeEnd = 98038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _TryButton_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass31_0.NativeMethodInfoPtr__TryButton_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6E6 RID: 42726 RVA: 0x0005A38D File Offset: 0x0005858D
			public __c__DisplayClass31_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036E6 RID: 14054
			// (get) Token: 0x0600A6E7 RID: 42727 RVA: 0x002B762C File Offset: 0x002B582C
			// (set) Token: 0x0600A6E8 RID: 42728 RVA: 0x0005A396 File Offset: 0x00058596
			public unsafe DaySceneChatSelectionPannel.BaseInteractData baseInteractData
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass31_0.NativeFieldInfoPtr_baseInteractData);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DaySceneChatSelectionPannel.BaseInteractData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass31_0.NativeFieldInfoPtr_baseInteractData), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036E7 RID: 14055
			// (get) Token: 0x0600A6E9 RID: 42729 RVA: 0x002B765C File Offset: 0x002B585C
			// (set) Token: 0x0600A6EA RID: 42730 RVA: 0x0005A3B5 File Offset: 0x000585B5
			public unsafe bool hasEnoughMoney
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass31_0.NativeFieldInfoPtr_hasEnoughMoney);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass31_0.NativeFieldInfoPtr_hasEnoughMoney)) = value;
				}
			}

			// Token: 0x170036E8 RID: 14056
			// (get) Token: 0x0600A6EB RID: 42731 RVA: 0x002B7684 File Offset: 0x002B5884
			// (set) Token: 0x0600A6EC RID: 42732 RVA: 0x0005A3D0 File Offset: 0x000585D0
			public unsafe NueSlotMachineComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NueSlotMachineComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BCE RID: 27598
			private static readonly IntPtr NativeFieldInfoPtr_baseInteractData;

			// Token: 0x04006BCF RID: 27599
			private static readonly IntPtr NativeFieldInfoPtr_hasEnoughMoney;

			// Token: 0x04006BD0 RID: 27600
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006BD1 RID: 27601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BD2 RID: 27602
			private static readonly IntPtr NativeMethodInfoPtr__TryButton_b__0_Internal_Void_0;
		}

		// Token: 0x020007E0 RID: 2016
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NueSlotMachineComponent+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A6ED RID: 42733 RVA: 0x002B76B4 File Offset: 0x002B58B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass33_0>.NativeClassPtr);
				NueSlotMachineComponent.__c__DisplayClass33_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass33_0>.NativeClassPtr, "color");
				NueSlotMachineComponent.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass33_0>.NativeClassPtr, 100670926);
				NueSlotMachineComponent.__c__DisplayClass33_0.NativeMethodInfoPtr__SetSprites_b__0_Internal_Boolean_ColorUFO_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass33_0>.NativeClassPtr, 100670927);
			}

			// Token: 0x0600A6EE RID: 42734 RVA: 0x002B771C File Offset: 0x002B591C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass33_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6EF RID: 42735 RVA: 0x002B7758 File Offset: 0x002B5958
			[CallerCount(0)]
			public unsafe bool _SetSprites_b__0(Spell_Nue.ColorUFO x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass33_0.NativeMethodInfoPtr__SetSprites_b__0_Internal_Boolean_ColorUFO_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6F0 RID: 42736 RVA: 0x0005A3EF File Offset: 0x000585EF
			public __c__DisplayClass33_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036E9 RID: 14057
			// (get) Token: 0x0600A6F1 RID: 42737 RVA: 0x002B77AC File Offset: 0x002B59AC
			// (set) Token: 0x0600A6F2 RID: 42738 RVA: 0x0005A3F8 File Offset: 0x000585F8
			public unsafe Spell_Nue.ColorType color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass33_0.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass33_0.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x04006BD3 RID: 27603
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x04006BD4 RID: 27604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BD5 RID: 27605
			private static readonly IntPtr NativeMethodInfoPtr__SetSprites_b__0_Internal_Boolean_ColorUFO_0;
		}

		// Token: 0x020007E1 RID: 2017
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NueSlotMachineComponent+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600A6F3 RID: 42739 RVA: 0x002B77D4 File Offset: 0x002B59D4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr);
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__34_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__34_0");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__35_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__35_3");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__35_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__35_4");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_0");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_1");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_2");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_3");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_4");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_6");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_8");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_10");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_11");
				NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, "<>9__36_12");
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670929);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__TrySlot_b__34_0_Internal_Int32_ColorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670930);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__GiveItem_b__35_3_Internal_Single_NueRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670931);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__GiveItem_b__35_4_Internal_Single_NueRewardPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670932);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_0_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670933);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_1_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670934);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_2_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670935);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_3_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670936);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_4_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670937);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_6_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670938);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_8_Internal_Ingredient_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670939);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_10_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670940);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_11_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670941);
				NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_12_Internal_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr, 100670942);
			}

			// Token: 0x0600A6F4 RID: 42740 RVA: 0x002B7A30 File Offset: 0x002B5C30
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NueSlotMachineComponent.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A6F5 RID: 42741 RVA: 0x002B7A6C File Offset: 0x002B5C6C
			[CallerCount(0)]
			public unsafe int _TrySlot_b__34_0(Spell_Nue.ColorType x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__TrySlot_b__34_0_Internal_Int32_ColorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6F6 RID: 42742 RVA: 0x002B7AB8 File Offset: 0x002B5CB8
			[CallerCount(0)]
			public unsafe float _GiveItem_b__35_3(NueRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__GiveItem_b__35_3_Internal_Single_NueRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6F7 RID: 42743 RVA: 0x002B7B04 File Offset: 0x002B5D04
			[CallerCount(0)]
			public unsafe float _GiveItem_b__35_4(NueRewardPair x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__GiveItem_b__35_4_Internal_Single_NueRewardPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6F8 RID: 42744 RVA: 0x002B7B50 File Offset: 0x002B5D50
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__36_0(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_0_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6F9 RID: 42745 RVA: 0x002B7BA0 File Offset: 0x002B5DA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98038, XrefRangeEnd = 98039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__36_1(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_1_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6FA RID: 42746 RVA: 0x002B7BF0 File Offset: 0x002B5DF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98039, XrefRangeEnd = 98041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__36_2(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_2_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6FB RID: 42747 RVA: 0x002B7C40 File Offset: 0x002B5E40
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__36_3(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_3_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A6FC RID: 42748 RVA: 0x002B7C90 File Offset: 0x002B5E90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _SelectReward_b__36_4(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_4_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600A6FD RID: 42749 RVA: 0x002B7CDC File Offset: 0x002B5EDC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _SelectReward_b__36_6(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_6_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600A6FE RID: 42750 RVA: 0x002B7D28 File Offset: 0x002B5F28
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Ingredient _SelectReward_b__36_8(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_8_Internal_Ingredient_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Ingredient>(intPtr3) : null;
			}

			// Token: 0x0600A6FF RID: 42751 RVA: 0x002B7D74 File Offset: 0x002B5F74
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98041, XrefRangeEnd = 98042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__36_10(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_10_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A700 RID: 42752 RVA: 0x002B7DC0 File Offset: 0x002B5FC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__36_11(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_11_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A701 RID: 42753 RVA: 0x002B7E0C File Offset: 0x002B600C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98042, XrefRangeEnd = 98043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _SelectReward_b__36_12(int x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c.NativeMethodInfoPtr__SelectReward_b__36_12_Internal_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A702 RID: 42754 RVA: 0x0005A413 File Offset: 0x00058613
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036EA RID: 14058
			// (get) Token: 0x0600A703 RID: 42755 RVA: 0x002B7E58 File Offset: 0x002B6058
			// (set) Token: 0x0600A704 RID: 42756 RVA: 0x0005A41C File Offset: 0x0005861C
			public unsafe static NueSlotMachineComponent.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NueSlotMachineComponent.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036EB RID: 14059
			// (get) Token: 0x0600A705 RID: 42757 RVA: 0x002B7E80 File Offset: 0x002B6080
			// (set) Token: 0x0600A706 RID: 42758 RVA: 0x0005A42E File Offset: 0x0005862E
			public unsafe static Func<Spell_Nue.ColorType, int> __9__34_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__34_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Spell_Nue.ColorType, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__34_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036EC RID: 14060
			// (get) Token: 0x0600A707 RID: 42759 RVA: 0x002B7EA8 File Offset: 0x002B60A8
			// (set) Token: 0x0600A708 RID: 42760 RVA: 0x0005A440 File Offset: 0x00058640
			public unsafe static Func<NueRewardPair, float> __9__35_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__35_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NueRewardPair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__35_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036ED RID: 14061
			// (get) Token: 0x0600A709 RID: 42761 RVA: 0x002B7ED0 File Offset: 0x002B60D0
			// (set) Token: 0x0600A70A RID: 42762 RVA: 0x0005A452 File Offset: 0x00058652
			public unsafe static Func<NueRewardPair, float> __9__35_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__35_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<NueRewardPair, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__35_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036EE RID: 14062
			// (get) Token: 0x0600A70B RID: 42763 RVA: 0x002B7EF8 File Offset: 0x002B60F8
			// (set) Token: 0x0600A70C RID: 42764 RVA: 0x0005A464 File Offset: 0x00058664
			public unsafe static Func<Ingredient, bool> __9__36_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036EF RID: 14063
			// (get) Token: 0x0600A70D RID: 42765 RVA: 0x002B7F20 File Offset: 0x002B6120
			// (set) Token: 0x0600A70E RID: 42766 RVA: 0x0005A476 File Offset: 0x00058676
			public unsafe static Func<Ingredient, bool> __9__36_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F0 RID: 14064
			// (get) Token: 0x0600A70F RID: 42767 RVA: 0x002B7F48 File Offset: 0x002B6148
			// (set) Token: 0x0600A710 RID: 42768 RVA: 0x0005A488 File Offset: 0x00058688
			public unsafe static Func<Ingredient, bool> __9__36_2
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_2, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_2, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F1 RID: 14065
			// (get) Token: 0x0600A711 RID: 42769 RVA: 0x002B7F70 File Offset: 0x002B6170
			// (set) Token: 0x0600A712 RID: 42770 RVA: 0x0005A49A File Offset: 0x0005869A
			public unsafe static Func<Ingredient, bool> __9__36_3
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_3, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_3, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F2 RID: 14066
			// (get) Token: 0x0600A713 RID: 42771 RVA: 0x002B7F98 File Offset: 0x002B6198
			// (set) Token: 0x0600A714 RID: 42772 RVA: 0x0005A4AC File Offset: 0x000586AC
			public unsafe static Func<int, Ingredient> __9__36_4
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_4, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_4, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F3 RID: 14067
			// (get) Token: 0x0600A715 RID: 42773 RVA: 0x002B7FC0 File Offset: 0x002B61C0
			// (set) Token: 0x0600A716 RID: 42774 RVA: 0x0005A4BE File Offset: 0x000586BE
			public unsafe static Func<int, Ingredient> __9__36_6
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_6, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_6, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F4 RID: 14068
			// (get) Token: 0x0600A717 RID: 42775 RVA: 0x002B7FE8 File Offset: 0x002B61E8
			// (set) Token: 0x0600A718 RID: 42776 RVA: 0x0005A4D0 File Offset: 0x000586D0
			public unsafe static Func<int, Ingredient> __9__36_8
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_8, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, Ingredient>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_8, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F5 RID: 14069
			// (get) Token: 0x0600A719 RID: 42777 RVA: 0x002B8010 File Offset: 0x002B6210
			// (set) Token: 0x0600A71A RID: 42778 RVA: 0x0005A4E2 File Offset: 0x000586E2
			public unsafe static Func<int, bool> __9__36_10
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_10, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_10, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F6 RID: 14070
			// (get) Token: 0x0600A71B RID: 42779 RVA: 0x002B8038 File Offset: 0x002B6238
			// (set) Token: 0x0600A71C RID: 42780 RVA: 0x0005A4F4 File Offset: 0x000586F4
			public unsafe static Func<int, bool> __9__36_11
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_11, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_11, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036F7 RID: 14071
			// (get) Token: 0x0600A71D RID: 42781 RVA: 0x002B8060 File Offset: 0x002B6260
			// (set) Token: 0x0600A71E RID: 42782 RVA: 0x0005A506 File Offset: 0x00058706
			public unsafe static Func<int, bool> __9__36_12
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_12, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(NueSlotMachineComponent.__c.NativeFieldInfoPtr___9__36_12, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BD6 RID: 27606
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04006BD7 RID: 27607
			private static readonly IntPtr NativeFieldInfoPtr___9__34_0;

			// Token: 0x04006BD8 RID: 27608
			private static readonly IntPtr NativeFieldInfoPtr___9__35_3;

			// Token: 0x04006BD9 RID: 27609
			private static readonly IntPtr NativeFieldInfoPtr___9__35_4;

			// Token: 0x04006BDA RID: 27610
			private static readonly IntPtr NativeFieldInfoPtr___9__36_0;

			// Token: 0x04006BDB RID: 27611
			private static readonly IntPtr NativeFieldInfoPtr___9__36_1;

			// Token: 0x04006BDC RID: 27612
			private static readonly IntPtr NativeFieldInfoPtr___9__36_2;

			// Token: 0x04006BDD RID: 27613
			private static readonly IntPtr NativeFieldInfoPtr___9__36_3;

			// Token: 0x04006BDE RID: 27614
			private static readonly IntPtr NativeFieldInfoPtr___9__36_4;

			// Token: 0x04006BDF RID: 27615
			private static readonly IntPtr NativeFieldInfoPtr___9__36_6;

			// Token: 0x04006BE0 RID: 27616
			private static readonly IntPtr NativeFieldInfoPtr___9__36_8;

			// Token: 0x04006BE1 RID: 27617
			private static readonly IntPtr NativeFieldInfoPtr___9__36_10;

			// Token: 0x04006BE2 RID: 27618
			private static readonly IntPtr NativeFieldInfoPtr___9__36_11;

			// Token: 0x04006BE3 RID: 27619
			private static readonly IntPtr NativeFieldInfoPtr___9__36_12;

			// Token: 0x04006BE4 RID: 27620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006BE5 RID: 27621
			private static readonly IntPtr NativeMethodInfoPtr__TrySlot_b__34_0_Internal_Int32_ColorType_0;

			// Token: 0x04006BE6 RID: 27622
			private static readonly IntPtr NativeMethodInfoPtr__GiveItem_b__35_3_Internal_Single_NueRewardPair_0;

			// Token: 0x04006BE7 RID: 27623
			private static readonly IntPtr NativeMethodInfoPtr__GiveItem_b__35_4_Internal_Single_NueRewardPair_0;

			// Token: 0x04006BE8 RID: 27624
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_0_Internal_Boolean_Ingredient_0;

			// Token: 0x04006BE9 RID: 27625
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_1_Internal_Boolean_Ingredient_0;

			// Token: 0x04006BEA RID: 27626
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_2_Internal_Boolean_Ingredient_0;

			// Token: 0x04006BEB RID: 27627
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_3_Internal_Boolean_Ingredient_0;

			// Token: 0x04006BEC RID: 27628
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_4_Internal_Ingredient_Int32_0;

			// Token: 0x04006BED RID: 27629
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_6_Internal_Ingredient_Int32_0;

			// Token: 0x04006BEE RID: 27630
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_8_Internal_Ingredient_Int32_0;

			// Token: 0x04006BEF RID: 27631
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_10_Internal_Boolean_Int32_0;

			// Token: 0x04006BF0 RID: 27632
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_11_Internal_Boolean_Int32_0;

			// Token: 0x04006BF1 RID: 27633
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__36_12_Internal_Boolean_Int32_0;
		}

		// Token: 0x020007E2 RID: 2018
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NueSlotMachineComponent+<TrySlot>d__34")]
		public sealed class _TrySlot_d__34 : Il2CppSystem.Object
		{
			// Token: 0x0600A71F RID: 42783 RVA: 0x002B8088 File Offset: 0x002B6288
			// Note: this type is marked as 'beforefieldinit'.
			static _TrySlot_d__34()
			{
				Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "<TrySlot>d__34");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr);
				NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, "<>1__state");
				NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, "<>2__current");
				NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, "<>4__this");
				NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__canOpen_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, "<canOpen>5__2");
				NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__spriteRenderer_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, "<spriteRenderer>5__3");
				NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__old_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, "<old>5__4");
				NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__colors_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, "<colors>5__5");
				NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, 100670943);
				NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, 100670944);
				NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, 100670945);
				NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, 100670946);
				NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, 100670947);
				NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr, 100670948);
			}

			// Token: 0x0600A720 RID: 42784 RVA: 0x002B81B8 File Offset: 0x002B63B8
			[CallerCount(94)]
			[CachedScanResults(RefRangeStart = 3957, RefRangeEnd = 4051, XrefRangeStart = 3957, XrefRangeEnd = 4051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _TrySlot_d__34(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NueSlotMachineComponent._TrySlot_d__34>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A721 RID: 42785 RVA: 0x002B8200 File Offset: 0x002B6400
			[CallerCount(13496)]
			[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A722 RID: 42786 RVA: 0x002B8234 File Offset: 0x002B6434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98043, XrefRangeEnd = 98100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170036FF RID: 14079
			// (get) Token: 0x0600A723 RID: 42787 RVA: 0x002B8270 File Offset: 0x002B6470
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A724 RID: 42788 RVA: 0x002B82B0 File Offset: 0x002B64B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 98100, XrefRangeEnd = 98106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003700 RID: 14080
			// (get) Token: 0x0600A725 RID: 42789 RVA: 0x002B82E4 File Offset: 0x002B64E4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent._TrySlot_d__34.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600A726 RID: 42790 RVA: 0x0005A518 File Offset: 0x00058718
			public _TrySlot_d__34(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170036F8 RID: 14072
			// (get) Token: 0x0600A727 RID: 42791 RVA: 0x002B8324 File Offset: 0x002B6524
			// (set) Token: 0x0600A728 RID: 42792 RVA: 0x0005A521 File Offset: 0x00058721
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170036F9 RID: 14073
			// (get) Token: 0x0600A729 RID: 42793 RVA: 0x002B834C File Offset: 0x002B654C
			// (set) Token: 0x0600A72A RID: 42794 RVA: 0x0005A53C File Offset: 0x0005873C
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036FA RID: 14074
			// (get) Token: 0x0600A72B RID: 42795 RVA: 0x002B837C File Offset: 0x002B657C
			// (set) Token: 0x0600A72C RID: 42796 RVA: 0x0005A55B File Offset: 0x0005875B
			public unsafe NueSlotMachineComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NueSlotMachineComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036FB RID: 14075
			// (get) Token: 0x0600A72D RID: 42797 RVA: 0x002B83AC File Offset: 0x002B65AC
			// (set) Token: 0x0600A72E RID: 42798 RVA: 0x0005A57A File Offset: 0x0005877A
			public unsafe bool _canOpen_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__canOpen_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__canOpen_5__2)) = value;
				}
			}

			// Token: 0x170036FC RID: 14076
			// (get) Token: 0x0600A72F RID: 42799 RVA: 0x002B83D4 File Offset: 0x002B65D4
			// (set) Token: 0x0600A730 RID: 42800 RVA: 0x0005A595 File Offset: 0x00058795
			public unsafe SpriteRenderer _spriteRenderer_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__spriteRenderer_5__3);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__spriteRenderer_5__3), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036FD RID: 14077
			// (get) Token: 0x0600A731 RID: 42801 RVA: 0x002B8404 File Offset: 0x002B6604
			// (set) Token: 0x0600A732 RID: 42802 RVA: 0x0005A5B4 File Offset: 0x000587B4
			public unsafe Sprite _old_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__old_5__4);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__old_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170036FE RID: 14078
			// (get) Token: 0x0600A733 RID: 42803 RVA: 0x002B8434 File Offset: 0x002B6634
			// (set) Token: 0x0600A734 RID: 42804 RVA: 0x0005A5D3 File Offset: 0x000587D3
			public unsafe HashSet<Spell_Nue.ColorType> _colors_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__colors_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<Spell_Nue.ColorType>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent._TrySlot_d__34.NativeFieldInfoPtr__colors_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BF2 RID: 27634
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04006BF3 RID: 27635
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04006BF4 RID: 27636
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006BF5 RID: 27637
			private static readonly IntPtr NativeFieldInfoPtr__canOpen_5__2;

			// Token: 0x04006BF6 RID: 27638
			private static readonly IntPtr NativeFieldInfoPtr__spriteRenderer_5__3;

			// Token: 0x04006BF7 RID: 27639
			private static readonly IntPtr NativeFieldInfoPtr__old_5__4;

			// Token: 0x04006BF8 RID: 27640
			private static readonly IntPtr NativeFieldInfoPtr__colors_5__5;

			// Token: 0x04006BF9 RID: 27641
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04006BFA RID: 27642
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006BFB RID: 27643
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04006BFC RID: 27644
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04006BFD RID: 27645
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04006BFE RID: 27646
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020007E3 RID: 2019
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NueSlotMachineComponent+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A735 RID: 42805 RVA: 0x002B8464 File Offset: 0x002B6664
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass35_0>.NativeClassPtr);
				NueSlotMachineComponent.__c__DisplayClass35_0.NativeFieldInfoPtr_nueUFONeedType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass35_0>.NativeClassPtr, "nueUFONeedType");
				NueSlotMachineComponent.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				NueSlotMachineComponent.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass35_0>.NativeClassPtr, 100670949);
				NueSlotMachineComponent.__c__DisplayClass35_0.NativeMethodInfoPtr__GiveItem_b__0_Internal_Boolean_NueUFORewardMatch_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass35_0>.NativeClassPtr, 100670950);
				NueSlotMachineComponent.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass35_0>.NativeClassPtr, 100670951);
				NueSlotMachineComponent.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass35_0>.NativeClassPtr, 100670952);
			}

			// Token: 0x0600A736 RID: 42806 RVA: 0x002B8508 File Offset: 0x002B6708
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A737 RID: 42807 RVA: 0x002B8544 File Offset: 0x002B6744
			[CallerCount(0)]
			public unsafe bool _GiveItem_b__0(NueUFORewardMatch x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(x));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass35_0.NativeMethodInfoPtr__GiveItem_b__0_Internal_Boolean_NueUFORewardMatch_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A738 RID: 42808 RVA: 0x002B8598 File Offset: 0x002B6798
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 98130, RefRangeEnd = 98132, XrefRangeStart = 98106, XrefRangeEnd = 98130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A739 RID: 42809 RVA: 0x002B85CC File Offset: 0x002B67CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 98156, RefRangeEnd = 98157, XrefRangeStart = 98132, XrefRangeEnd = 98156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A73A RID: 42810 RVA: 0x0005A5F2 File Offset: 0x000587F2
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003701 RID: 14081
			// (get) Token: 0x0600A73B RID: 42811 RVA: 0x002B8600 File Offset: 0x002B6800
			// (set) Token: 0x0600A73C RID: 42812 RVA: 0x0005A5FB File Offset: 0x000587FB
			public unsafe NueUFONeedType nueUFONeedType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass35_0.NativeFieldInfoPtr_nueUFONeedType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass35_0.NativeFieldInfoPtr_nueUFONeedType)) = value;
				}
			}

			// Token: 0x17003702 RID: 14082
			// (get) Token: 0x0600A73D RID: 42813 RVA: 0x002B8628 File Offset: 0x002B6828
			// (set) Token: 0x0600A73E RID: 42814 RVA: 0x0005A616 File Offset: 0x00058816
			public unsafe NueSlotMachineComponent __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NueSlotMachineComponent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006BFF RID: 27647
			private static readonly IntPtr NativeFieldInfoPtr_nueUFONeedType;

			// Token: 0x04006C00 RID: 27648
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04006C01 RID: 27649
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C02 RID: 27650
			private static readonly IntPtr NativeMethodInfoPtr__GiveItem_b__0_Internal_Boolean_NueUFORewardMatch_0;

			// Token: 0x04006C03 RID: 27651
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x04006C04 RID: 27652
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_1;
		}

		// Token: 0x020007E4 RID: 2020
		[ObfuscatedName("DayScene.Interactables.Collections.BehaviourComponents.NueSlotMachineComponent+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600A73F RID: 42815 RVA: 0x002B8658 File Offset: 0x002B6858
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NueSlotMachineComponent>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass36_0>.NativeClassPtr);
				NueSlotMachineComponent.__c__DisplayClass36_0.NativeFieldInfoPtr_CheckType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass36_0>.NativeClassPtr, "CheckType");
				NueSlotMachineComponent.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass36_0>.NativeClassPtr, 100670953);
				NueSlotMachineComponent.__c__DisplayClass36_0.NativeMethodInfoPtr__SelectReward_b__5_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass36_0>.NativeClassPtr, 100670954);
				NueSlotMachineComponent.__c__DisplayClass36_0.NativeMethodInfoPtr__SelectReward_b__7_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass36_0>.NativeClassPtr, 100670955);
				NueSlotMachineComponent.__c__DisplayClass36_0.NativeMethodInfoPtr__SelectReward_b__9_Internal_Boolean_Ingredient_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass36_0>.NativeClassPtr, 100670956);
			}

			// Token: 0x0600A740 RID: 42816 RVA: 0x002B86E8 File Offset: 0x002B68E8
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NueSlotMachineComponent.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600A741 RID: 42817 RVA: 0x002B8724 File Offset: 0x002B6924
			[CallerCount(0)]
			public unsafe bool _SelectReward_b__5(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass36_0.NativeMethodInfoPtr__SelectReward_b__5_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A742 RID: 42818 RVA: 0x002B8774 File Offset: 0x002B6974
			[CallerCount(0)]
			public unsafe bool _SelectReward_b__7(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass36_0.NativeMethodInfoPtr__SelectReward_b__7_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A743 RID: 42819 RVA: 0x002B87C4 File Offset: 0x002B69C4
			[CallerCount(0)]
			public unsafe bool _SelectReward_b__9(Ingredient x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NueSlotMachineComponent.__c__DisplayClass36_0.NativeMethodInfoPtr__SelectReward_b__9_Internal_Boolean_Ingredient_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600A744 RID: 42820 RVA: 0x0005A635 File Offset: 0x00058835
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003703 RID: 14083
			// (get) Token: 0x0600A745 RID: 42821 RVA: 0x002B8814 File Offset: 0x002B6A14
			// (set) Token: 0x0600A746 RID: 42822 RVA: 0x0005A63E File Offset: 0x0005883E
			public unsafe Func<Ingredient, bool> CheckType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass36_0.NativeFieldInfoPtr_CheckType);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Ingredient, bool>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NueSlotMachineComponent.__c__DisplayClass36_0.NativeFieldInfoPtr_CheckType), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04006C05 RID: 27653
			private static readonly IntPtr NativeFieldInfoPtr_CheckType;

			// Token: 0x04006C06 RID: 27654
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04006C07 RID: 27655
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__5_Internal_Boolean_Ingredient_0;

			// Token: 0x04006C08 RID: 27656
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__7_Internal_Boolean_Ingredient_0;

			// Token: 0x04006C09 RID: 27657
			private static readonly IntPtr NativeMethodInfoPtr__SelectReward_b__9_Internal_Boolean_Ingredient_0;
		}
	}
}
