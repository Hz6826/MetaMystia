using System;
using Common.CharacterUtility;
using GameData.Core.Collections.CharacterUtility;
using GameData.RunTime.DaySceneUtility.Collection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace DayScene.Interactables.Collections.ConditionComponents
{
	// Token: 0x02000167 RID: 359
	public class CharacterConditionComponent : EntityConditionComponent
	{
		// Token: 0x0600284F RID: 10319 RVA: 0x001248A0 File Offset: 0x00122AA0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterConditionComponent()
		{
			Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "DayScene.Interactables.Collections.ConditionComponents", "CharacterConditionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr);
			CharacterConditionComponent.NativeFieldInfoPtr_SPRITE_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "SPRITE_OFFSET");
			CharacterConditionComponent.NativeFieldInfoPtr_KYOUKO_STRINGID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "KYOUKO_STRINGID");
			CharacterConditionComponent.NativeFieldInfoPtr_internalIconAvailability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "internalIconAvailability");
			CharacterConditionComponent.NativeFieldInfoPtr_m_AdditiveRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "m_AdditiveRadius");
			CharacterConditionComponent.NativeFieldInfoPtr_m_CircleCollider2D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "m_CircleCollider2D");
			CharacterConditionComponent.NativeFieldInfoPtr_m_Pixel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "m_Pixel");
			CharacterConditionComponent.NativeFieldInfoPtr_tipIconTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "tipIconTransform");
			CharacterConditionComponent.NativeFieldInfoPtr_tipIconRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "tipIconRenderer");
			CharacterConditionComponent.NativeFieldInfoPtr_trackedNPCData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "trackedNPCData");
			CharacterConditionComponent.NativeFieldInfoPtr__Character_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, "<Character>k__BackingField");
			CharacterConditionComponent.NativeMethodInfoPtr_get_Character_Public_get_CharacterControllerUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670376);
			CharacterConditionComponent.NativeMethodInfoPtr_set_Character_Private_set_Void_CharacterControllerUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670377);
			CharacterConditionComponent.NativeMethodInfoPtr_get_CharacterLabel_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670378);
			CharacterConditionComponent.NativeMethodInfoPtr_get_IsOverridePosition_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670379);
			CharacterConditionComponent.NativeMethodInfoPtr_Initialize_Public_Void_TrackedNPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670380);
			CharacterConditionComponent.NativeMethodInfoPtr_SetCircleColliderRadius_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670381);
			CharacterConditionComponent.NativeMethodInfoPtr_UpdatePositionAndRotation_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670382);
			CharacterConditionComponent.NativeMethodInfoPtr_UpdateIcon_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670383);
			CharacterConditionComponent.NativeMethodInfoPtr_PostDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670384);
			CharacterConditionComponent.NativeMethodInfoPtr_AutoInitialize_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670385);
			CharacterConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670386);
			CharacterConditionComponent.NativeMethodInfoPtr_CheckIfShouldShowIconInMap_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670387);
			CharacterConditionComponent.NativeMethodInfoPtr_KyoukoTutorialSet_Private_Boolean_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670388);
			CharacterConditionComponent.NativeMethodInfoPtr_SetSprite_Private_Void_Sprite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670389);
			CharacterConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670390);
			CharacterConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670391);
			CharacterConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr, 100670392);
		}

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x06002850 RID: 10320 RVA: 0x00124AEC File Offset: 0x00122CEC
		// (set) Token: 0x06002851 RID: 10321 RVA: 0x00124B2C File Offset: 0x00122D2C
		public unsafe CharacterControllerUnit Character
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 54389, RefRangeEnd = 54396, XrefRangeStart = 54389, XrefRangeEnd = 54396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_get_Character_Public_get_CharacterControllerUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_set_Character_Private_set_Void_CharacterControllerUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x06002852 RID: 10322 RVA: 0x00124B70 File Offset: 0x00122D70
		public unsafe string CharacterLabel
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_get_CharacterLabel_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x06002853 RID: 10323 RVA: 0x00124BA8 File Offset: 0x00122DA8
		public unsafe bool IsOverridePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_get_IsOverridePosition_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x00124BE4 File Offset: 0x00122DE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92152, RefRangeEnd = 92153, XrefRangeStart = 92087, XrefRangeEnd = 92152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(TrackedNPC characterData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(characterData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_Initialize_Public_Void_TrackedNPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x00124C28 File Offset: 0x00122E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 92155, RefRangeEnd = 92156, XrefRangeStart = 92153, XrefRangeEnd = 92155, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCircleColliderRadius(float newRadius)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref newRadius;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_SetCircleColliderRadius_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x00124C68 File Offset: 0x00122E68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92156, XrefRangeEnd = 92160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePositionAndRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_UpdatePositionAndRotation_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x00124C9C File Offset: 0x00122E9C
		[CallerCount(0)]
		public unsafe void UpdateIcon(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_UpdateIcon_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x00124CDC File Offset: 0x00122EDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92160, XrefRangeEnd = 92172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterConditionComponent.NativeMethodInfoPtr_PostDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00124D18 File Offset: 0x00122F18
		[CallerCount(299)]
		[CachedScanResults(RefRangeStart = 25582, RefRangeEnd = 25881, XrefRangeStart = 25582, XrefRangeEnd = 25881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool AutoInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterConditionComponent.NativeMethodInfoPtr_AutoInitialize_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x00124D60 File Offset: 0x00122F60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92172, XrefRangeEnd = 92225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool OnGetAvailability()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterConditionComponent.NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00124DA8 File Offset: 0x00122FA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 92228, RefRangeEnd = 92233, XrefRangeStart = 92225, XrefRangeEnd = 92228, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckIfShouldShowIconInMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_CheckIfShouldShowIconInMap_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x00124DE4 File Offset: 0x00122FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92233, XrefRangeEnd = 92246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool KyoukoTutorialSet(out bool hasNewTutorial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &hasNewTutorial;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_KyoukoTutorialSet_Private_Boolean_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00124E30 File Offset: 0x00123030
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 92287, RefRangeEnd = 92289, XrefRangeStart = 92246, XrefRangeEnd = 92287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSprite(Sprite sprite)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sprite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr_SetSprite_Private_Void_Sprite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00124E74 File Offset: 0x00123074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92289, XrefRangeEnd = 92295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type GetComponentType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterConditionComponent.NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600285F RID: 10335 RVA: 0x00124EC0 File Offset: 0x001230C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92295, XrefRangeEnd = 92303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterConditionComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x00124EFC File Offset: 0x001230FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 92303, XrefRangeEnd = 92311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterConditionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterConditionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterConditionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002861 RID: 10337 RVA: 0x00017BAE File Offset: 0x00015DAE
		public CharacterConditionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06002862 RID: 10338 RVA: 0x00124F38 File Offset: 0x00123138
		// (set) Token: 0x06002863 RID: 10339 RVA: 0x00017BB7 File Offset: 0x00015DB7
		public unsafe static float SPRITE_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CharacterConditionComponent.NativeFieldInfoPtr_SPRITE_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterConditionComponent.NativeFieldInfoPtr_SPRITE_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06002864 RID: 10340 RVA: 0x00124F54 File Offset: 0x00123154
		// (set) Token: 0x06002865 RID: 10341 RVA: 0x00017BC5 File Offset: 0x00015DC5
		public unsafe static string KYOUKO_STRINGID
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CharacterConditionComponent.NativeFieldInfoPtr_KYOUKO_STRINGID, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterConditionComponent.NativeFieldInfoPtr_KYOUKO_STRINGID, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06002866 RID: 10342 RVA: 0x00124F74 File Offset: 0x00123174
		// (set) Token: 0x06002867 RID: 10343 RVA: 0x00017BD7 File Offset: 0x00015DD7
		public unsafe bool internalIconAvailability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_internalIconAvailability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_internalIconAvailability)) = value;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06002868 RID: 10344 RVA: 0x00124F9C File Offset: 0x0012319C
		// (set) Token: 0x06002869 RID: 10345 RVA: 0x00017BF2 File Offset: 0x00015DF2
		public unsafe float m_AdditiveRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_m_AdditiveRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_m_AdditiveRadius)) = value;
			}
		}

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x0600286A RID: 10346 RVA: 0x00124FC4 File Offset: 0x001231C4
		// (set) Token: 0x0600286B RID: 10347 RVA: 0x00017C0D File Offset: 0x00015E0D
		public unsafe CircleCollider2D m_CircleCollider2D
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_m_CircleCollider2D);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CircleCollider2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_m_CircleCollider2D), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x0600286C RID: 10348 RVA: 0x00124FF4 File Offset: 0x001231F4
		// (set) Token: 0x0600286D RID: 10349 RVA: 0x00017C2C File Offset: 0x00015E2C
		public unsafe CharacterSpriteSetCompact m_Pixel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_m_Pixel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterSpriteSetCompact>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_m_Pixel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x0600286E RID: 10350 RVA: 0x00125024 File Offset: 0x00123224
		// (set) Token: 0x0600286F RID: 10351 RVA: 0x00017C4B File Offset: 0x00015E4B
		public unsafe Transform tipIconTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_tipIconTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_tipIconTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x06002870 RID: 10352 RVA: 0x00125054 File Offset: 0x00123254
		// (set) Token: 0x06002871 RID: 10353 RVA: 0x00017C6A File Offset: 0x00015E6A
		public unsafe SpriteRenderer tipIconRenderer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_tipIconRenderer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpriteRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_tipIconRenderer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x06002872 RID: 10354 RVA: 0x00125084 File Offset: 0x00123284
		// (set) Token: 0x06002873 RID: 10355 RVA: 0x00017C89 File Offset: 0x00015E89
		public unsafe TrackedNPC trackedNPCData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_trackedNPCData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedNPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr_trackedNPCData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x06002874 RID: 10356 RVA: 0x001250B4 File Offset: 0x001232B4
		// (set) Token: 0x06002875 RID: 10357 RVA: 0x00017CA8 File Offset: 0x00015EA8
		public unsafe CharacterControllerUnit _Character_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr__Character_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterConditionComponent.NativeFieldInfoPtr__Character_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001AB0 RID: 6832
		private static readonly IntPtr NativeFieldInfoPtr_SPRITE_OFFSET;

		// Token: 0x04001AB1 RID: 6833
		private static readonly IntPtr NativeFieldInfoPtr_KYOUKO_STRINGID;

		// Token: 0x04001AB2 RID: 6834
		private static readonly IntPtr NativeFieldInfoPtr_internalIconAvailability;

		// Token: 0x04001AB3 RID: 6835
		private static readonly IntPtr NativeFieldInfoPtr_m_AdditiveRadius;

		// Token: 0x04001AB4 RID: 6836
		private static readonly IntPtr NativeFieldInfoPtr_m_CircleCollider2D;

		// Token: 0x04001AB5 RID: 6837
		private static readonly IntPtr NativeFieldInfoPtr_m_Pixel;

		// Token: 0x04001AB6 RID: 6838
		private static readonly IntPtr NativeFieldInfoPtr_tipIconTransform;

		// Token: 0x04001AB7 RID: 6839
		private static readonly IntPtr NativeFieldInfoPtr_tipIconRenderer;

		// Token: 0x04001AB8 RID: 6840
		private static readonly IntPtr NativeFieldInfoPtr_trackedNPCData;

		// Token: 0x04001AB9 RID: 6841
		private static readonly IntPtr NativeFieldInfoPtr__Character_k__BackingField;

		// Token: 0x04001ABA RID: 6842
		private static readonly IntPtr NativeMethodInfoPtr_get_Character_Public_get_CharacterControllerUnit_0;

		// Token: 0x04001ABB RID: 6843
		private static readonly IntPtr NativeMethodInfoPtr_set_Character_Private_set_Void_CharacterControllerUnit_0;

		// Token: 0x04001ABC RID: 6844
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterLabel_Public_get_String_0;

		// Token: 0x04001ABD RID: 6845
		private static readonly IntPtr NativeMethodInfoPtr_get_IsOverridePosition_Public_get_Boolean_0;

		// Token: 0x04001ABE RID: 6846
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_TrackedNPC_0;

		// Token: 0x04001ABF RID: 6847
		private static readonly IntPtr NativeMethodInfoPtr_SetCircleColliderRadius_Public_Void_Single_0;

		// Token: 0x04001AC0 RID: 6848
		private static readonly IntPtr NativeMethodInfoPtr_UpdatePositionAndRotation_Public_Void_0;

		// Token: 0x04001AC1 RID: 6849
		private static readonly IntPtr NativeMethodInfoPtr_UpdateIcon_Private_Void_Boolean_0;

		// Token: 0x04001AC2 RID: 6850
		private static readonly IntPtr NativeMethodInfoPtr_PostDestroy_Protected_Virtual_Void_0;

		// Token: 0x04001AC3 RID: 6851
		private static readonly IntPtr NativeMethodInfoPtr_AutoInitialize_Protected_Virtual_Boolean_0;

		// Token: 0x04001AC4 RID: 6852
		private static readonly IntPtr NativeMethodInfoPtr_OnGetAvailability_Protected_Virtual_Boolean_0;

		// Token: 0x04001AC5 RID: 6853
		private static readonly IntPtr NativeMethodInfoPtr_CheckIfShouldShowIconInMap_Private_Boolean_0;

		// Token: 0x04001AC6 RID: 6854
		private static readonly IntPtr NativeMethodInfoPtr_KyoukoTutorialSet_Private_Boolean_byref_Boolean_0;

		// Token: 0x04001AC7 RID: 6855
		private static readonly IntPtr NativeMethodInfoPtr_SetSprite_Private_Void_Sprite_0;

		// Token: 0x04001AC8 RID: 6856
		private static readonly IntPtr NativeMethodInfoPtr_GetComponentType_Protected_Virtual_Type_0;

		// Token: 0x04001AC9 RID: 6857
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_Void_0;

		// Token: 0x04001ACA RID: 6858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
