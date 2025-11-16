using System;
using DEYU.UniversalUISystem;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MusicGame.UI
{
	// Token: 0x0200001E RID: 30
	public class MusicGameMainDancingCharacterElement : MonoBehaviour
	{
		// Token: 0x06000256 RID: 598 RVA: 0x000A68FC File Offset: 0x000A4AFC
		// Note: this type is marked as 'beforefieldinit'.
		static MusicGameMainDancingCharacterElement()
		{
			Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "MusicGame.UI", "MusicGameMainDancingCharacterElement");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr);
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_UIElementCluster = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "m_UIElementCluster");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_HinaAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "m_HinaAnimator");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_BaseAnimator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "m_BaseAnimator");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_guestId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "guestId");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_cachaedMainSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "cachaedMainSprites");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_cachaedEyeSprites = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "cachaedEyeSprites");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "initialized");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_actived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "actived");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_SEKIBANKI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "SEKIBANKI");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_SEKIBANKI_HEAD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "SEKIBANKI_HEAD");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_WAKASAGIHIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "WAKASAGIHIME");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_HINA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "HINA");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_MYSTIA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "MYSTIA");
			MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_AvailableActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "m_AvailableActions");
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_get_UIElementCluster_Public_get_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663638);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_get_BaseAnimator_Public_get_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663639);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_SwapSprite_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663640);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_IsFish_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663641);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_IsHead_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663642);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_IsHina_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663643);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_IsMystia_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663644);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_InitializeForMystia_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663645);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_Initialize_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663646);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_StartFirstJump_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663647);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_StartJump_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663648);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_SetCachedSprites_Private_Void_IEnumerable_1_Sprite_IEnumerable_1_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663649);
			MusicGameMainDancingCharacterElement.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, 100663650);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000257 RID: 599 RVA: 0x000A6B48 File Offset: 0x000A4D48
		public unsafe UIElementCluster UIElementCluster
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 6, RefRangeEnd = 21, XrefRangeStart = 6, XrefRangeEnd = 21, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_get_UIElementCluster_Public_get_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr3) : null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000258 RID: 600 RVA: 0x000A6B88 File Offset: 0x000A4D88
		public unsafe Animator BaseAnimator
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20145, RefRangeEnd = 20148, XrefRangeStart = 20145, XrefRangeEnd = 20145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_get_BaseAnimator_Public_get_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr3) : null;
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000A6BC8 File Offset: 0x000A4DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20148, XrefRangeEnd = 20168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SwapSprite(string args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_SwapSprite_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000A6C0C File Offset: 0x000A4E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20168, XrefRangeEnd = 20171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsFish()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_IsFish_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000A6C48 File Offset: 0x000A4E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20171, XrefRangeEnd = 20174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHead()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_IsHead_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x000A6C84 File Offset: 0x000A4E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20174, XrefRangeEnd = 20177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsHina()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_IsHina_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x000A6CC0 File Offset: 0x000A4EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20177, XrefRangeEnd = 20180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMystia()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_IsMystia_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600025E RID: 606 RVA: 0x000A6CFC File Offset: 0x000A4EFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20183, RefRangeEnd = 20185, XrefRangeStart = 20180, XrefRangeEnd = 20183, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeForMystia()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_InitializeForMystia_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000A6D30 File Offset: 0x000A4F30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 20315, RefRangeEnd = 20318, XrefRangeStart = 20185, XrefRangeEnd = 20315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_Initialize_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000A6D74 File Offset: 0x000A4F74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 20338, RefRangeEnd = 20340, XrefRangeStart = 20318, XrefRangeEnd = 20338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartFirstJump(float currentScoreProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentScoreProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_StartFirstJump_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000A6DB4 File Offset: 0x000A4FB4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 20360, RefRangeEnd = 20364, XrefRangeStart = 20340, XrefRangeEnd = 20360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartJump(float currentScoreProgress)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref currentScoreProgress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_StartJump_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000A6DF4 File Offset: 0x000A4FF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20364, XrefRangeEnd = 20374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCachedSprites(IEnumerable<Sprite> mainSprites, IEnumerable<Sprite> eyeSprites)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(mainSprites);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(eyeSprites);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr_SetCachedSprites_Private_Void_IEnumerable_1_Sprite_IEnumerable_1_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x000A6E48 File Offset: 0x000A5048
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20374, XrefRangeEnd = 20493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MusicGameMainDancingCharacterElement() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0000335B File Offset: 0x0000155B
		public MusicGameMainDancingCharacterElement(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000A6E84 File Offset: 0x000A5084
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00003364 File Offset: 0x00001564
		public unsafe UIElementCluster m_UIElementCluster
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_UIElementCluster);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UIElementCluster>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_UIElementCluster), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000267 RID: 615 RVA: 0x000A6EB4 File Offset: 0x000A50B4
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00003383 File Offset: 0x00001583
		public unsafe Animator m_HinaAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_HinaAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_HinaAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000A6EE4 File Offset: 0x000A50E4
		// (set) Token: 0x0600026A RID: 618 RVA: 0x000033A2 File Offset: 0x000015A2
		public unsafe Animator m_BaseAnimator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_BaseAnimator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_BaseAnimator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000A6F14 File Offset: 0x000A5114
		// (set) Token: 0x0600026C RID: 620 RVA: 0x000033C1 File Offset: 0x000015C1
		public unsafe string guestId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_guestId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_guestId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000A6F3C File Offset: 0x000A513C
		// (set) Token: 0x0600026E RID: 622 RVA: 0x000033E0 File Offset: 0x000015E0
		public unsafe List<Sprite> cachaedMainSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_cachaedMainSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_cachaedMainSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600026F RID: 623 RVA: 0x000A6F6C File Offset: 0x000A516C
		// (set) Token: 0x06000270 RID: 624 RVA: 0x000033FF File Offset: 0x000015FF
		public unsafe List<Sprite> cachaedEyeSprites
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_cachaedEyeSprites);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Sprite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_cachaedEyeSprites), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000271 RID: 625 RVA: 0x000A6F9C File Offset: 0x000A519C
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000341E File Offset: 0x0000161E
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000273 RID: 627 RVA: 0x000A6FC4 File Offset: 0x000A51C4
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00003439 File Offset: 0x00001639
		public unsafe bool actived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_actived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_actived)) = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000275 RID: 629 RVA: 0x000A6FEC File Offset: 0x000A51EC
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00003454 File Offset: 0x00001654
		public unsafe static string SEKIBANKI
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_SEKIBANKI, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_SEKIBANKI, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000A700C File Offset: 0x000A520C
		// (set) Token: 0x06000278 RID: 632 RVA: 0x00003466 File Offset: 0x00001666
		public unsafe static string SEKIBANKI_HEAD
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_SEKIBANKI_HEAD, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_SEKIBANKI_HEAD, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000279 RID: 633 RVA: 0x000A702C File Offset: 0x000A522C
		// (set) Token: 0x0600027A RID: 634 RVA: 0x00003478 File Offset: 0x00001678
		public unsafe static string WAKASAGIHIME
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_WAKASAGIHIME, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_WAKASAGIHIME, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600027B RID: 635 RVA: 0x000A704C File Offset: 0x000A524C
		// (set) Token: 0x0600027C RID: 636 RVA: 0x0000348A File Offset: 0x0000168A
		public unsafe static string HINA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_HINA, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_HINA, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600027D RID: 637 RVA: 0x000A706C File Offset: 0x000A526C
		// (set) Token: 0x0600027E RID: 638 RVA: 0x0000349C File Offset: 0x0000169C
		public unsafe static string MYSTIA
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_MYSTIA, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_MYSTIA, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600027F RID: 639 RVA: 0x000A708C File Offset: 0x000A528C
		// (set) Token: 0x06000280 RID: 640 RVA: 0x000034AE File Offset: 0x000016AE
		public unsafe Il2CppStringArray m_AvailableActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_AvailableActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.NativeFieldInfoPtr_m_AvailableActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000182 RID: 386
		private static readonly IntPtr NativeFieldInfoPtr_m_UIElementCluster;

		// Token: 0x04000183 RID: 387
		private static readonly IntPtr NativeFieldInfoPtr_m_HinaAnimator;

		// Token: 0x04000184 RID: 388
		private static readonly IntPtr NativeFieldInfoPtr_m_BaseAnimator;

		// Token: 0x04000185 RID: 389
		private static readonly IntPtr NativeFieldInfoPtr_guestId;

		// Token: 0x04000186 RID: 390
		private static readonly IntPtr NativeFieldInfoPtr_cachaedMainSprites;

		// Token: 0x04000187 RID: 391
		private static readonly IntPtr NativeFieldInfoPtr_cachaedEyeSprites;

		// Token: 0x04000188 RID: 392
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x04000189 RID: 393
		private static readonly IntPtr NativeFieldInfoPtr_actived;

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_SEKIBANKI;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeFieldInfoPtr_SEKIBANKI_HEAD;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeFieldInfoPtr_WAKASAGIHIME;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeFieldInfoPtr_HINA;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeFieldInfoPtr_MYSTIA;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeFieldInfoPtr_m_AvailableActions;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr_get_UIElementCluster_Public_get_UIElementCluster_0;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeMethodInfoPtr_get_BaseAnimator_Public_get_Animator_0;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeMethodInfoPtr_SwapSprite_Public_Void_String_0;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeMethodInfoPtr_IsFish_Public_Boolean_0;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeMethodInfoPtr_IsHead_Public_Boolean_0;

		// Token: 0x04000195 RID: 405
		private static readonly IntPtr NativeMethodInfoPtr_IsHina_Public_Boolean_0;

		// Token: 0x04000196 RID: 406
		private static readonly IntPtr NativeMethodInfoPtr_IsMystia_Public_Boolean_0;

		// Token: 0x04000197 RID: 407
		private static readonly IntPtr NativeMethodInfoPtr_InitializeForMystia_Public_Void_0;

		// Token: 0x04000198 RID: 408
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_String_0;

		// Token: 0x04000199 RID: 409
		private static readonly IntPtr NativeMethodInfoPtr_StartFirstJump_Public_Void_Single_0;

		// Token: 0x0400019A RID: 410
		private static readonly IntPtr NativeMethodInfoPtr_StartJump_Public_Void_Single_0;

		// Token: 0x0400019B RID: 411
		private static readonly IntPtr NativeMethodInfoPtr_SetCachedSprites_Private_Void_IEnumerable_1_Sprite_IEnumerable_1_Sprite_0;

		// Token: 0x0400019C RID: 412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200048A RID: 1162
		[ObfuscatedName("MusicGame.UI.MusicGameMainDancingCharacterElement+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x06007D61 RID: 32097 RVA: 0x0023D61C File Offset: 0x0023B81C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass12_0>.NativeClassPtr);
				MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass12_0>.NativeClassPtr, "<>4__this");
				MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass12_0>.NativeClassPtr, "index");
				MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeFieldInfoPtr_is3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass12_0>.NativeClassPtr, "is3");
				MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass12_0>.NativeClassPtr, 100663651);
				MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeMethodInfoPtr__SwapSprite_b__0_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass12_0>.NativeClassPtr, 100663652);
				MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeMethodInfoPtr__SwapSprite_b__1_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass12_0>.NativeClassPtr, 100663653);
			}

			// Token: 0x06007D62 RID: 32098 RVA: 0x0023D6C0 File Offset: 0x0023B8C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass12_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D63 RID: 32099 RVA: 0x0023D6FC File Offset: 0x0023B8FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20059, XrefRangeEnd = 20064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SwapSprite_b__0(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeMethodInfoPtr__SwapSprite_b__0_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D64 RID: 32100 RVA: 0x0023D740 File Offset: 0x0023B940
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20064, XrefRangeEnd = 20070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SwapSprite_b__1(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeMethodInfoPtr__SwapSprite_b__1_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D65 RID: 32101 RVA: 0x000438B8 File Offset: 0x00041AB8
			public __c__DisplayClass12_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A6F RID: 10863
			// (get) Token: 0x06007D66 RID: 32102 RVA: 0x0023D784 File Offset: 0x0023B984
			// (set) Token: 0x06007D67 RID: 32103 RVA: 0x000438C1 File Offset: 0x00041AC1
			public unsafe MusicGameMainDancingCharacterElement __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainDancingCharacterElement>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A70 RID: 10864
			// (get) Token: 0x06007D68 RID: 32104 RVA: 0x0023D7B4 File Offset: 0x0023B9B4
			// (set) Token: 0x06007D69 RID: 32105 RVA: 0x000438E0 File Offset: 0x00041AE0
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x17002A71 RID: 10865
			// (get) Token: 0x06007D6A RID: 32106 RVA: 0x0023D7DC File Offset: 0x0023B9DC
			// (set) Token: 0x06007D6B RID: 32107 RVA: 0x000438FB File Offset: 0x00041AFB
			public unsafe bool is3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeFieldInfoPtr_is3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass12_0.NativeFieldInfoPtr_is3)) = value;
				}
			}

			// Token: 0x04005276 RID: 21110
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04005277 RID: 21111
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04005278 RID: 21112
			private static readonly IntPtr NativeFieldInfoPtr_is3;

			// Token: 0x04005279 RID: 21113
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400527A RID: 21114
			private static readonly IntPtr NativeMethodInfoPtr__SwapSprite_b__0_Internal_Void_Image_0;

			// Token: 0x0400527B RID: 21115
			private static readonly IntPtr NativeMethodInfoPtr__SwapSprite_b__1_Internal_Void_Image_0;
		}

		// Token: 0x0200048B RID: 1163
		[ObfuscatedName("MusicGame.UI.MusicGameMainDancingCharacterElement+<>c__DisplayClass24_0")]
		public sealed class __c__DisplayClass24_0 : Il2CppSystem.Object
		{
			// Token: 0x06007D6C RID: 32108 RVA: 0x0023D804 File Offset: 0x0023BA04
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_0()
			{
				Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "<>c__DisplayClass24_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeFieldInfoPtr_characterVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, "characterVisual");
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeFieldInfoPtr___9__17 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, "<>9__17");
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeFieldInfoPtr___9__18 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, "<>9__18");
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, 100663654);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__16_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, 100663655);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__17_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, 100663656);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__18_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, 100663657);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__2_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, 100663658);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__3_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, 100663659);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__4_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, 100663660);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__5_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr, 100663661);
			}

			// Token: 0x06007D6D RID: 32109 RVA: 0x0023D90C File Offset: 0x0023BB0C
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D6E RID: 32110 RVA: 0x0023D948 File Offset: 0x0023BB48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20070, XrefRangeEnd = 20086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__16(UIElementCluster sekibanki)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sekibanki);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__16_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D6F RID: 32111 RVA: 0x0023D98C File Offset: 0x0023BB8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20086, XrefRangeEnd = 20090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__17(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__17_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D70 RID: 32112 RVA: 0x0023D9D0 File Offset: 0x0023BBD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20090, XrefRangeEnd = 20094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__18(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__18_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D71 RID: 32113 RVA: 0x0023DA14 File Offset: 0x0023BC14
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20094, XrefRangeEnd = 20097, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__2(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__2_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D72 RID: 32114 RVA: 0x0023DA58 File Offset: 0x0023BC58
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20097, XrefRangeEnd = 20100, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__3(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__3_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D73 RID: 32115 RVA: 0x0023DA9C File Offset: 0x0023BC9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20100, XrefRangeEnd = 20101, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__4(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__4_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D74 RID: 32116 RVA: 0x0023DAE0 File Offset: 0x0023BCE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20101, XrefRangeEnd = 20102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__5(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeMethodInfoPtr__Initialize_b__5_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D75 RID: 32117 RVA: 0x00043916 File Offset: 0x00041B16
			public __c__DisplayClass24_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A72 RID: 10866
			// (get) Token: 0x06007D76 RID: 32118 RVA: 0x0023DB24 File Offset: 0x0023BD24
			// (set) Token: 0x06007D77 RID: 32119 RVA: 0x0004391F File Offset: 0x00041B1F
			public unsafe CharacterSpriteSetCompact characterVisual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeFieldInfoPtr_characterVisual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeFieldInfoPtr_characterVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A73 RID: 10867
			// (get) Token: 0x06007D78 RID: 32120 RVA: 0x0023DB54 File Offset: 0x0023BD54
			// (set) Token: 0x06007D79 RID: 32121 RVA: 0x0004393E File Offset: 0x00041B3E
			public unsafe Action<Image> __9__17
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeFieldInfoPtr___9__17);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeFieldInfoPtr___9__17), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A74 RID: 10868
			// (get) Token: 0x06007D7A RID: 32122 RVA: 0x0023DB84 File Offset: 0x0023BD84
			// (set) Token: 0x06007D7B RID: 32123 RVA: 0x0004395D File Offset: 0x00041B5D
			public unsafe Action<Image> __9__18
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeFieldInfoPtr___9__18);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_0.NativeFieldInfoPtr___9__18), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400527C RID: 21116
			private static readonly IntPtr NativeFieldInfoPtr_characterVisual;

			// Token: 0x0400527D RID: 21117
			private static readonly IntPtr NativeFieldInfoPtr___9__17;

			// Token: 0x0400527E RID: 21118
			private static readonly IntPtr NativeFieldInfoPtr___9__18;

			// Token: 0x0400527F RID: 21119
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005280 RID: 21120
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__16_Internal_Void_UIElementCluster_0;

			// Token: 0x04005281 RID: 21121
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__17_Internal_Void_Image_0;

			// Token: 0x04005282 RID: 21122
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__18_Internal_Void_Image_0;

			// Token: 0x04005283 RID: 21123
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__2_Internal_Void_Image_0;

			// Token: 0x04005284 RID: 21124
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__3_Internal_Void_Image_0;

			// Token: 0x04005285 RID: 21125
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__4_Internal_Void_Image_0;

			// Token: 0x04005286 RID: 21126
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__5_Internal_Void_Image_0;
		}

		// Token: 0x0200048C RID: 1164
		[ObfuscatedName("MusicGame.UI.MusicGameMainDancingCharacterElement+<>c__DisplayClass24_1")]
		public sealed class __c__DisplayClass24_1 : Il2CppSystem.Object
		{
			// Token: 0x06007D7C RID: 32124 RVA: 0x0023DBB4 File Offset: 0x0023BDB4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_1()
			{
				Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "<>c__DisplayClass24_1");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeFieldInfoPtr_mystiaVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr, "mystiaVisual");
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr, 100663662);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__6_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr, 100663663);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__7_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr, 100663664);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__8_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr, 100663665);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__9_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr, 100663666);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__10_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr, 100663667);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__11_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr, 100663668);
			}

			// Token: 0x06007D7D RID: 32125 RVA: 0x0023DC80 File Offset: 0x0023BE80
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_1() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_1>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D7E RID: 32126 RVA: 0x0023DCBC File Offset: 0x0023BEBC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20102, XrefRangeEnd = 20105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__6(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__6_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D7F RID: 32127 RVA: 0x0023DD00 File Offset: 0x0023BF00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__7(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__7_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D80 RID: 32128 RVA: 0x0023DD44 File Offset: 0x0023BF44
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__8(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__8_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D81 RID: 32129 RVA: 0x0023DD88 File Offset: 0x0023BF88
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20105, XrefRangeEnd = 20108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__9(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__9_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D82 RID: 32130 RVA: 0x0023DDCC File Offset: 0x0023BFCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__10(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__10_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D83 RID: 32131 RVA: 0x0023DE10 File Offset: 0x0023C010
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__11(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeMethodInfoPtr__Initialize_b__11_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D84 RID: 32132 RVA: 0x0004397C File Offset: 0x00041B7C
			public __c__DisplayClass24_1(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A75 RID: 10869
			// (get) Token: 0x06007D85 RID: 32133 RVA: 0x0023DE54 File Offset: 0x0023C054
			// (set) Token: 0x06007D86 RID: 32134 RVA: 0x00043985 File Offset: 0x00041B85
			public unsafe CharacterSpriteSetFull mystiaVisual
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeFieldInfoPtr_mystiaVisual);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetFull>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_1.NativeFieldInfoPtr_mystiaVisual), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005287 RID: 21127
			private static readonly IntPtr NativeFieldInfoPtr_mystiaVisual;

			// Token: 0x04005288 RID: 21128
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005289 RID: 21129
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__6_Internal_Void_Image_0;

			// Token: 0x0400528A RID: 21130
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__7_Internal_Void_Image_0;

			// Token: 0x0400528B RID: 21131
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__8_Internal_Void_Image_0;

			// Token: 0x0400528C RID: 21132
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__9_Internal_Void_Image_0;

			// Token: 0x0400528D RID: 21133
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__10_Internal_Void_Image_0;

			// Token: 0x0400528E RID: 21134
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__11_Internal_Void_Image_0;
		}

		// Token: 0x0200048D RID: 1165
		[ObfuscatedName("MusicGame.UI.MusicGameMainDancingCharacterElement+<>c__DisplayClass24_2")]
		public sealed class __c__DisplayClass24_2 : Il2CppSystem.Object
		{
			// Token: 0x06007D87 RID: 32135 RVA: 0x0023DE84 File Offset: 0x0023C084
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass24_2()
			{
				Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_2>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "<>c__DisplayClass24_2");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_2>.NativeClassPtr);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeFieldInfoPtr_characterVisual2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_2>.NativeClassPtr, "characterVisual2");
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_2>.NativeClassPtr, 100663669);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__Initialize_b__12_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_2>.NativeClassPtr, 100663670);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__Initialize_b__13_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_2>.NativeClassPtr, 100663671);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__Initialize_b__14_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_2>.NativeClassPtr, 100663672);
				MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__Initialize_b__15_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_2>.NativeClassPtr, 100663673);
			}

			// Token: 0x06007D88 RID: 32136 RVA: 0x0023DF28 File Offset: 0x0023C128
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass24_2() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c__DisplayClass24_2>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D89 RID: 32137 RVA: 0x0023DF64 File Offset: 0x0023C164
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__12(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__Initialize_b__12_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D8A RID: 32138 RVA: 0x0023DFA8 File Offset: 0x0023C1A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__13(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__Initialize_b__13_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D8B RID: 32139 RVA: 0x0023DFEC File Offset: 0x0023C1EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__14(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__Initialize_b__14_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D8C RID: 32140 RVA: 0x0023E030 File Offset: 0x0023C230
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__15(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeMethodInfoPtr__Initialize_b__15_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D8D RID: 32141 RVA: 0x000439A4 File Offset: 0x00041BA4
			public __c__DisplayClass24_2(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A76 RID: 10870
			// (get) Token: 0x06007D8E RID: 32142 RVA: 0x0023E074 File Offset: 0x0023C274
			// (set) Token: 0x06007D8F RID: 32143 RVA: 0x000439AD File Offset: 0x00041BAD
			public unsafe CharacterSpriteSetCompact characterVisual2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeFieldInfoPtr_characterVisual2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MusicGameMainDancingCharacterElement.__c__DisplayClass24_2.NativeFieldInfoPtr_characterVisual2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400528F RID: 21135
			private static readonly IntPtr NativeFieldInfoPtr_characterVisual2;

			// Token: 0x04005290 RID: 21136
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04005291 RID: 21137
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__12_Internal_Void_Image_0;

			// Token: 0x04005292 RID: 21138
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__13_Internal_Void_Image_0;

			// Token: 0x04005293 RID: 21139
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__14_Internal_Void_Image_0;

			// Token: 0x04005294 RID: 21140
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__15_Internal_Void_Image_0;
		}

		// Token: 0x0200048E RID: 1166
		[ObfuscatedName("MusicGame.UI.MusicGameMainDancingCharacterElement+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x06007D90 RID: 32144 RVA: 0x0023E0A4 File Offset: 0x0023C2A4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr);
				MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, "<>9");
				MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, "<>9__24_0");
				MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_19 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, "<>9__24_19");
				MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_20 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, "<>9__24_20");
				MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, "<>9__24_1");
				MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__25_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, "<>9__25_0");
				MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, 100663675);
				MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__Initialize_b__24_0_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, 100663676);
				MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__Initialize_b__24_1_Internal_Void_UIElementCluster_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, 100663677);
				MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__Initialize_b__24_19_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, 100663678);
				MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__Initialize_b__24_20_Internal_Void_Image_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, 100663679);
				MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__StartFirstJump_b__25_0_Internal_Void_CanvasGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr, 100663680);
			}

			// Token: 0x06007D91 RID: 32145 RVA: 0x0023E1C0 File Offset: 0x0023C3C0
			[CallerCount(2138)]
			[CachedScanResults(RefRangeStart = 500, RefRangeEnd = 2638, XrefRangeStart = 500, XrefRangeEnd = 2638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicGameMainDancingCharacterElement.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D92 RID: 32146 RVA: 0x0023E1FC File Offset: 0x0023C3FC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20108, XrefRangeEnd = 20110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__24_0(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__Initialize_b__24_0_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D93 RID: 32147 RVA: 0x0023E240 File Offset: 0x0023C440
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20110, XrefRangeEnd = 20141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__24_1(UIElementCluster sekibanki)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sekibanki);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__Initialize_b__24_1_Internal_Void_UIElementCluster_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D94 RID: 32148 RVA: 0x0023E284 File Offset: 0x0023C484
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20141, XrefRangeEnd = 20143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__24_19(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__Initialize_b__24_19_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D95 RID: 32149 RVA: 0x0023E2C8 File Offset: 0x0023C4C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Initialize_b__24_20(Image x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__Initialize_b__24_20_Internal_Void_Image_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D96 RID: 32150 RVA: 0x0023E30C File Offset: 0x0023C50C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 20143, XrefRangeEnd = 20145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _StartFirstJump_b__25_0(CanvasGroup x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MusicGameMainDancingCharacterElement.__c.NativeMethodInfoPtr__StartFirstJump_b__25_0_Internal_Void_CanvasGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06007D97 RID: 32151 RVA: 0x000439CC File Offset: 0x00041BCC
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17002A77 RID: 10871
			// (get) Token: 0x06007D98 RID: 32152 RVA: 0x0023E350 File Offset: 0x0023C550
			// (set) Token: 0x06007D99 RID: 32153 RVA: 0x000439D5 File Offset: 0x00041BD5
			public unsafe static MusicGameMainDancingCharacterElement.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MusicGameMainDancingCharacterElement.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A78 RID: 10872
			// (get) Token: 0x06007D9A RID: 32154 RVA: 0x0023E378 File Offset: 0x0023C578
			// (set) Token: 0x06007D9B RID: 32155 RVA: 0x000439E7 File Offset: 0x00041BE7
			public unsafe static Action<CanvasGroup> __9__24_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A79 RID: 10873
			// (get) Token: 0x06007D9C RID: 32156 RVA: 0x0023E3A0 File Offset: 0x0023C5A0
			// (set) Token: 0x06007D9D RID: 32157 RVA: 0x000439F9 File Offset: 0x00041BF9
			public unsafe static Action<Image> __9__24_19
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_19, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_19, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A7A RID: 10874
			// (get) Token: 0x06007D9E RID: 32158 RVA: 0x0023E3C8 File Offset: 0x0023C5C8
			// (set) Token: 0x06007D9F RID: 32159 RVA: 0x00043A0B File Offset: 0x00041C0B
			public unsafe static Action<Image> __9__24_20
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_20, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Image>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_20, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A7B RID: 10875
			// (get) Token: 0x06007DA0 RID: 32160 RVA: 0x0023E3F0 File Offset: 0x0023C5F0
			// (set) Token: 0x06007DA1 RID: 32161 RVA: 0x00043A1D File Offset: 0x00041C1D
			public unsafe static Action<UIElementCluster> __9__24_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<UIElementCluster>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__24_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17002A7C RID: 10876
			// (get) Token: 0x06007DA2 RID: 32162 RVA: 0x0023E418 File Offset: 0x0023C618
			// (set) Token: 0x06007DA3 RID: 32163 RVA: 0x00043A2F File Offset: 0x00041C2F
			public unsafe static Action<CanvasGroup> __9__25_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__25_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<CanvasGroup>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MusicGameMainDancingCharacterElement.__c.NativeFieldInfoPtr___9__25_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04005295 RID: 21141
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04005296 RID: 21142
			private static readonly IntPtr NativeFieldInfoPtr___9__24_0;

			// Token: 0x04005297 RID: 21143
			private static readonly IntPtr NativeFieldInfoPtr___9__24_19;

			// Token: 0x04005298 RID: 21144
			private static readonly IntPtr NativeFieldInfoPtr___9__24_20;

			// Token: 0x04005299 RID: 21145
			private static readonly IntPtr NativeFieldInfoPtr___9__24_1;

			// Token: 0x0400529A RID: 21146
			private static readonly IntPtr NativeFieldInfoPtr___9__25_0;

			// Token: 0x0400529B RID: 21147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400529C RID: 21148
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_0_Internal_Void_CanvasGroup_0;

			// Token: 0x0400529D RID: 21149
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_1_Internal_Void_UIElementCluster_0;

			// Token: 0x0400529E RID: 21150
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_19_Internal_Void_Image_0;

			// Token: 0x0400529F RID: 21151
			private static readonly IntPtr NativeMethodInfoPtr__Initialize_b__24_20_Internal_Void_Image_0;

			// Token: 0x040052A0 RID: 21152
			private static readonly IntPtr NativeMethodInfoPtr__StartFirstJump_b__25_0_Internal_Void_CanvasGroup_0;
		}
	}
}
