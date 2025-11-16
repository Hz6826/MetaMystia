using System;
using GameData.Core.Collections.CharacterUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Common.CharacterUtility
{
	// Token: 0x02000454 RID: 1108
	public class CharacterControllerInputGeneratorComponent : MonoBehaviour
	{
		// Token: 0x06007A76 RID: 31350 RVA: 0x00234A48 File Offset: 0x00232C48
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterControllerInputGeneratorComponent()
		{
			Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.CharacterUtility", "CharacterControllerInputGeneratorComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr);
			CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr_INPUT_CUTOFF = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, "INPUT_CUTOFF");
			CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr_CHARACTER_CELL_DISTANCE_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, "CHARACTER_CELL_DISTANCE_OFFSET");
			CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr_deltaInputAvailability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, "deltaInputAvailability");
			CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr__Character_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, "<Character>k__BackingField");
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_get_Character_Public_get_CharacterControllerUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687853);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_set_Character_Private_set_Void_CharacterControllerUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687854);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_get_Moving_Protected_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687855);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_set_Moving_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687856);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_set_Sprint_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687857);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_get_CharacterController_Protected_get_CharacterControllerUnit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687858);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687859);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnExternalStop_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687860);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_ExternalStop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687861);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687862);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetFull_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687863);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_ResetCharacter_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687864);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnInitialize_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687865);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_UpdateRotation_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687866);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_UpdateSpeed_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687867);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_UpdateInputDirection_Protected_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687868);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_PreviewTargetPosition_Protected_Vector3_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687869);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnTimelinePositionUpdated_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687870);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnDestroyCalled_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687871);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687872);
			CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr, 100687873);
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x06007A77 RID: 31351 RVA: 0x00234C6C File Offset: 0x00232E6C
		// (set) Token: 0x06007A78 RID: 31352 RVA: 0x00234CAC File Offset: 0x00232EAC
		public unsafe CharacterControllerUnit Character
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_get_Character_Public_get_CharacterControllerUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 49354, RefRangeEnd = 49355, XrefRangeStart = 49354, XrefRangeEnd = 49355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_set_Character_Private_set_Void_CharacterControllerUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002982 RID: 10626
		// (get) Token: 0x06007A79 RID: 31353 RVA: 0x00234CF0 File Offset: 0x00232EF0
		// (set) Token: 0x06007A7A RID: 31354 RVA: 0x00234D2C File Offset: 0x00232F2C
		public unsafe bool Moving
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 294785, RefRangeEnd = 294786, XrefRangeStart = 294785, XrefRangeEnd = 294785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_get_Moving_Protected_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 294788, RefRangeEnd = 294793, XrefRangeStart = 294786, XrefRangeEnd = 294788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_set_Moving_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002983 RID: 10627
		// (set) Token: 0x06007A7B RID: 31355 RVA: 0x00234D6C File Offset: 0x00232F6C
		public unsafe bool Sprint
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 294793, RefRangeEnd = 294796, XrefRangeStart = 294793, XrefRangeEnd = 294793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_set_Sprint_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17002984 RID: 10628
		// (get) Token: 0x06007A7C RID: 31356 RVA: 0x00234DAC File Offset: 0x00232FAC
		public unsafe CharacterControllerUnit CharacterController
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 67576, RefRangeEnd = 67578, XrefRangeStart = 67576, XrefRangeEnd = 67578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_get_CharacterController_Protected_get_CharacterControllerUnit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr3) : null;
			}
		}

		// Token: 0x06007A7D RID: 31357 RVA: 0x00234DEC File Offset: 0x00232FEC
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x00234E20 File Offset: 0x00233020
		[CallerCount(0)]
		public unsafe virtual void OnExternalStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnExternalStop_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x00234E5C File Offset: 0x0023305C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 294798, RefRangeEnd = 294805, XrefRangeStart = 294796, XrefRangeEnd = 294798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExternalStop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_ExternalStop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x00234E90 File Offset: 0x00233090
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 294811, RefRangeEnd = 294816, XrefRangeStart = 294805, XrefRangeEnd = 294811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CharacterSpriteSetCompact visualCompact, float moveSpeedMultiplier, bool shouldTurnOnCollider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visualCompact);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeedMultiplier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTurnOnCollider;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A81 RID: 31361 RVA: 0x00234EF0 File Offset: 0x002330F0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 294811, RefRangeEnd = 294816, XrefRangeStart = 294811, XrefRangeEnd = 294816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(CharacterSpriteSetFull visualFull, float moveSpeedMultiplier, bool shouldTurnOnCollider)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(visualFull);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref moveSpeedMultiplier;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldTurnOnCollider;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetFull_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A82 RID: 31362 RVA: 0x00234F50 File Offset: 0x00233150
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 294820, RefRangeEnd = 294821, XrefRangeStart = 294816, XrefRangeEnd = 294820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetCharacter()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_ResetCharacter_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A83 RID: 31363 RVA: 0x00234F84 File Offset: 0x00233184
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 27675, RefRangeEnd = 27686, XrefRangeStart = 27675, XrefRangeEnd = 27686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnInitialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnInitialize_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A84 RID: 31364 RVA: 0x00234FC0 File Offset: 0x002331C0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 294823, RefRangeEnd = 294829, XrefRangeStart = 294821, XrefRangeEnd = 294823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation(int rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_UpdateRotation_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A85 RID: 31365 RVA: 0x00235000 File Offset: 0x00233200
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 294835, RefRangeEnd = 294839, XrefRangeStart = 294829, XrefRangeEnd = 294835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateSpeed(float extraSpeed)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref extraSpeed;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_UpdateSpeed_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A86 RID: 31366 RVA: 0x00235040 File Offset: 0x00233240
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 294851, RefRangeEnd = 294863, XrefRangeStart = 294839, XrefRangeEnd = 294851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputDirection(Vector2 inputDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_UpdateInputDirection_Protected_Void_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A87 RID: 31367 RVA: 0x00235080 File Offset: 0x00233280
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 294863, XrefRangeEnd = 294864, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 PreviewTargetPosition(Vector2 inputDirection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref inputDirection;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_PreviewTargetPosition_Protected_Vector3_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007A88 RID: 31368 RVA: 0x002350CC File Offset: 0x002332CC
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnTimelinePositionUpdated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnTimelinePositionUpdated_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A89 RID: 31369 RVA: 0x00235108 File Offset: 0x00233308
		[CallerCount(13496)]
		[CachedScanResults(RefRangeStart = 4051, RefRangeEnd = 17547, XrefRangeStart = 4051, XrefRangeEnd = 17547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnDestroyCalled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_OnDestroyCalled_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A8A RID: 31370 RVA: 0x00235144 File Offset: 0x00233344
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 270701, RefRangeEnd = 270703, XrefRangeStart = 270701, XrefRangeEnd = 270703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A8B RID: 31371 RVA: 0x00235180 File Offset: 0x00233380
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterControllerInputGeneratorComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterControllerInputGeneratorComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterControllerInputGeneratorComponent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007A8C RID: 31372 RVA: 0x00042252 File Offset: 0x00040452
		public CharacterControllerInputGeneratorComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x06007A8D RID: 31373 RVA: 0x002351BC File Offset: 0x002333BC
		// (set) Token: 0x06007A8E RID: 31374 RVA: 0x0004225B File Offset: 0x0004045B
		public unsafe static float INPUT_CUTOFF
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr_INPUT_CUTOFF, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr_INPUT_CUTOFF, (void*)(&value));
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x06007A8F RID: 31375 RVA: 0x002351D8 File Offset: 0x002333D8
		// (set) Token: 0x06007A90 RID: 31376 RVA: 0x00042269 File Offset: 0x00040469
		public unsafe static float CHARACTER_CELL_DISTANCE_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr_CHARACTER_CELL_DISTANCE_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr_CHARACTER_CELL_DISTANCE_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x06007A91 RID: 31377 RVA: 0x002351F4 File Offset: 0x002333F4
		// (set) Token: 0x06007A92 RID: 31378 RVA: 0x00042277 File Offset: 0x00040477
		public unsafe bool deltaInputAvailability
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr_deltaInputAvailability);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr_deltaInputAvailability)) = value;
			}
		}

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x06007A93 RID: 31379 RVA: 0x0023521C File Offset: 0x0023341C
		// (set) Token: 0x06007A94 RID: 31380 RVA: 0x00042292 File Offset: 0x00040492
		public unsafe CharacterControllerUnit _Character_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr__Character_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterControllerUnit>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterControllerInputGeneratorComponent.NativeFieldInfoPtr__Character_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400508E RID: 20622
		private static readonly IntPtr NativeFieldInfoPtr_INPUT_CUTOFF;

		// Token: 0x0400508F RID: 20623
		private static readonly IntPtr NativeFieldInfoPtr_CHARACTER_CELL_DISTANCE_OFFSET;

		// Token: 0x04005090 RID: 20624
		private static readonly IntPtr NativeFieldInfoPtr_deltaInputAvailability;

		// Token: 0x04005091 RID: 20625
		private static readonly IntPtr NativeFieldInfoPtr__Character_k__BackingField;

		// Token: 0x04005092 RID: 20626
		private static readonly IntPtr NativeMethodInfoPtr_get_Character_Public_get_CharacterControllerUnit_0;

		// Token: 0x04005093 RID: 20627
		private static readonly IntPtr NativeMethodInfoPtr_set_Character_Private_set_Void_CharacterControllerUnit_0;

		// Token: 0x04005094 RID: 20628
		private static readonly IntPtr NativeMethodInfoPtr_get_Moving_Protected_get_Boolean_0;

		// Token: 0x04005095 RID: 20629
		private static readonly IntPtr NativeMethodInfoPtr_set_Moving_Protected_set_Void_Boolean_0;

		// Token: 0x04005096 RID: 20630
		private static readonly IntPtr NativeMethodInfoPtr_set_Sprint_Protected_set_Void_Boolean_0;

		// Token: 0x04005097 RID: 20631
		private static readonly IntPtr NativeMethodInfoPtr_get_CharacterController_Protected_get_CharacterControllerUnit_0;

		// Token: 0x04005098 RID: 20632
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005099 RID: 20633
		private static readonly IntPtr NativeMethodInfoPtr_OnExternalStop_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400509A RID: 20634
		private static readonly IntPtr NativeMethodInfoPtr_ExternalStop_Public_Void_0;

		// Token: 0x0400509B RID: 20635
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetCompact_Single_Boolean_0;

		// Token: 0x0400509C RID: 20636
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_CharacterSpriteSetFull_Single_Boolean_0;

		// Token: 0x0400509D RID: 20637
		private static readonly IntPtr NativeMethodInfoPtr_ResetCharacter_Public_Void_0;

		// Token: 0x0400509E RID: 20638
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialize_Public_Virtual_New_Void_0;

		// Token: 0x0400509F RID: 20639
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Public_Void_Int32_0;

		// Token: 0x040050A0 RID: 20640
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSpeed_Public_Void_Single_0;

		// Token: 0x040050A1 RID: 20641
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputDirection_Protected_Void_Vector2_0;

		// Token: 0x040050A2 RID: 20642
		private static readonly IntPtr NativeMethodInfoPtr_PreviewTargetPosition_Protected_Vector3_Vector2_0;

		// Token: 0x040050A3 RID: 20643
		private static readonly IntPtr NativeMethodInfoPtr_OnTimelinePositionUpdated_Public_Virtual_New_Void_0;

		// Token: 0x040050A4 RID: 20644
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroyCalled_Protected_Virtual_New_Void_0;

		// Token: 0x040050A5 RID: 20645
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040050A6 RID: 20646
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
