using System;
using Common.CharacterUtility;
using DayScene.Input;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DayScene.Interactables.Collections.BehaviourComponents
{
	// Token: 0x02000176 RID: 374
	public class HakureiFestivalCharacterBehaviourComponent : EntityBehaviourComponent
	{
		// Token: 0x0600290D RID: 10509 RVA: 0x001270BC File Offset: 0x001252BC
		// Note: this type is marked as 'beforefieldinit'.
		static HakureiFestivalCharacterBehaviourComponent()
		{
			Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.BehaviourComponents", "HakureiFestivalCharacterBehaviourComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr);
			HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_DaySceneNPCLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, "m_DaySceneNPCLabel");
			HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_UsePlainSpriteSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, "m_UsePlainSpriteSet");
			HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_CharacterSpriteSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, "m_CharacterSpriteSet");
			HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_FaceDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, "m_FaceDirection");
			HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_DialogPackages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, "m_DialogPackages");
			HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, "m_Collider");
			HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_hasInteracted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, "hasInteracted");
			HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_CharacterControllerUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, "m_CharacterControllerUnit");
			HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, 100670478);
			HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, 100670479);
			HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnPlayerStay_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, 100670480);
			HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnPlayerExit_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, 100670481);
			HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, 100670482);
			HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_GetSpriteCode_Private_ValueTuple_2_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, 100670483);
			HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, 100670484);
			HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr, 100670485);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x0012722C File Offset: 0x0012542C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92886, XrefRangeEnd = 92913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600290F RID: 10511 RVA: 0x00127260 File Offset: 0x00125460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92913, XrefRangeEnd = 92927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002910 RID: 10512 RVA: 0x0012729C File Offset: 0x0012549C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92927, XrefRangeEnd = 92938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayerStay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnPlayerStay_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002911 RID: 10513 RVA: 0x001272D8 File Offset: 0x001254D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92938, XrefRangeEnd = 92941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnPlayerExit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnPlayerExit_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002912 RID: 10514 RVA: 0x00127314 File Offset: 0x00125514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92941, XrefRangeEnd = 92948, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002913 RID: 10515 RVA: 0x00127350 File Offset: 0x00125550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92948, XrefRangeEnd = 92951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTuple<int, int> GetSpriteCode(int orientation, int faceId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref orientation;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref faceId;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_GetSpriteCode_Private_ValueTuple_2_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<int, int>(pointer);
		}

		// Token: 0x06002914 RID: 10516 RVA: 0x001273A4 File Offset: 0x001255A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92951, XrefRangeEnd = 92957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002915 RID: 10517 RVA: 0x001273E0 File Offset: 0x001255E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 19188, RefRangeEnd = 19190, XrefRangeStart = 19188, XrefRangeEnd = 19190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HakureiFestivalCharacterBehaviourComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HakureiFestivalCharacterBehaviourComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HakureiFestivalCharacterBehaviourComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002916 RID: 10518 RVA: 0x0001803F File Offset: 0x0001623F
		public HakureiFestivalCharacterBehaviourComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002917 RID: 10519 RVA: 0x0012741C File Offset: 0x0012561C
		// (set) Token: 0x06002918 RID: 10520 RVA: 0x00018048 File Offset: 0x00016248
		public unsafe string m_DaySceneNPCLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_DaySceneNPCLabel);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_DaySceneNPCLabel), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002919 RID: 10521 RVA: 0x00127444 File Offset: 0x00125644
		// (set) Token: 0x0600291A RID: 10522 RVA: 0x00018067 File Offset: 0x00016267
		public unsafe bool m_UsePlainSpriteSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_UsePlainSpriteSet);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_UsePlainSpriteSet)) = value;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x0600291B RID: 10523 RVA: 0x0012746C File Offset: 0x0012566C
		// (set) Token: 0x0600291C RID: 10524 RVA: 0x00018082 File Offset: 0x00016282
		public unsafe CharacterSpriteSetCompact m_CharacterSpriteSet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_CharacterSpriteSet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_CharacterSpriteSet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x0600291D RID: 10525 RVA: 0x0012749C File Offset: 0x0012569C
		// (set) Token: 0x0600291E RID: 10526 RVA: 0x000180A1 File Offset: 0x000162A1
		public unsafe DayScenePlayerInputGenerator.CharacterRotation m_FaceDirection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_FaceDirection);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_FaceDirection)) = value;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x0600291F RID: 10527 RVA: 0x001274C4 File Offset: 0x001256C4
		// (set) Token: 0x06002920 RID: 10528 RVA: 0x000180BC File Offset: 0x000162BC
		public unsafe Il2CppStringArray m_DialogPackages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_DialogPackages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_DialogPackages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002921 RID: 10529 RVA: 0x001274F4 File Offset: 0x001256F4
		// (set) Token: 0x06002922 RID: 10530 RVA: 0x000180DB File Offset: 0x000162DB
		public unsafe Collider2D m_Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002923 RID: 10531 RVA: 0x00127524 File Offset: 0x00125724
		// (set) Token: 0x06002924 RID: 10532 RVA: 0x000180FA File Offset: 0x000162FA
		public unsafe bool hasInteracted
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_hasInteracted);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_hasInteracted)) = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002925 RID: 10533 RVA: 0x0012754C File Offset: 0x0012574C
		// (set) Token: 0x06002926 RID: 10534 RVA: 0x00018115 File Offset: 0x00016315
		public unsafe CharacterControllerUnit m_CharacterControllerUnit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_CharacterControllerUnit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HakureiFestivalCharacterBehaviourComponent.NativeFieldInfoPtr_m_CharacterControllerUnit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B2B RID: 6955
		private static readonly IntPtr NativeFieldInfoPtr_m_DaySceneNPCLabel;

		// Token: 0x04001B2C RID: 6956
		private static readonly IntPtr NativeFieldInfoPtr_m_UsePlainSpriteSet;

		// Token: 0x04001B2D RID: 6957
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterSpriteSet;

		// Token: 0x04001B2E RID: 6958
		private static readonly IntPtr NativeFieldInfoPtr_m_FaceDirection;

		// Token: 0x04001B2F RID: 6959
		private static readonly IntPtr NativeFieldInfoPtr_m_DialogPackages;

		// Token: 0x04001B30 RID: 6960
		private static readonly IntPtr NativeFieldInfoPtr_m_Collider;

		// Token: 0x04001B31 RID: 6961
		private static readonly IntPtr NativeFieldInfoPtr_hasInteracted;

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeFieldInfoPtr_m_CharacterControllerUnit;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Protected_Virtual_Void_0;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerStay_Public_Virtual_Void_0;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeMethodInfoPtr_OnPlayerExit_Public_Virtual_Void_0;

		// Token: 0x04001B37 RID: 6967
		private static readonly IntPtr NativeMethodInfoPtr_OnInteract_Public_Virtual_Void_0;

		// Token: 0x04001B38 RID: 6968
		private static readonly IntPtr NativeMethodInfoPtr_GetSpriteCode_Private_ValueTuple_2_Int32_Int32_Int32_Int32_0;

		// Token: 0x04001B39 RID: 6969
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001B3A RID: 6970
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
